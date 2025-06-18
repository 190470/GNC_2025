Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Acconage
    'Private Conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Glo App Ser\Desktop\GNC_2025_version_VS2019\GNC_DB2025.accdb")
    'Private ConnDBTRANSIT2025 As New OleDbConnection()
    'ReadOnly ConnectionGNC_DBTRANSIT2025String As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Glo App Ser\Desktop\GNC_2025_version_VS2019\GNC_DBTRANSIT2025.accdb"
    ' Utilisation des connexions globales
    Private Conn As OleDbConnection = ModuleGlobal.Conn
    Private Conn_transit As OleDbConnection = ModuleGlobal.Conn_transit
    Private connectionString As String = ModuleGlobal.connectionString
    Private connectionTransitString As String = ModuleGlobal.connectionTransitString

    Private AcconageMontantParTc40 As Double
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numeroOT.SelectedIndexChanged

        NumeroOT_Change()

    End Sub
    Private Sub NumeroOT_Change()
        Try
            Dim ot As String

            Dim sql_nbreTcs As String
            Dim nombreTcs As Integer

            If Not String.IsNullOrEmpty(Me.numeroOT.Text) Then
                ot = Me.numeroOT.Text
                ModuleTransit.RechercheOT(ot)
                Me.numeroBooking.Text = ModuleDBManip.Recherche("booking", "t_empotage", "ot", ot)

                ' Ci-dessous la requête pour obtenir le nombre de Tcs empoté.
                sql_nbreTcs = "SELECT count(tcs_numero) From (select DISTINCTROW( Tcs_numero ) from t_empotage where ot='" & Me.numeroOT.Text & "' GROUP BY Tcs_numero)"
                nombreTcs = ModuleDBManip.Cumul_Parametre(sql_nbreTcs)
                Me.NbreTcs.Text = nombreTcs.ToString()
                Me.Acconage_Client.Text = ModuleDBManip.Recherche("ot_client", "OT", "Ot_Numero", ot)
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Acconage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MiseEnformeDatagridview()

        AffichageDataGridview1()

        AlimenterComboboxPrestataire()

        AlimenterComboboxOT()

        AlimenterNumeroBooking()

        InitialiserListeCompagnieMaritime()

    End Sub
    Sub AlimenterNumeroBooking()
        Dim reqListeBooking = "Select Ot_Booking From OT"
        Dim numeroBooking As Object = Me.numeroBooking
        Call Alimenter_combo.listderoulante(reqListeBooking, numeroBooking, 0)
    End Sub
    Sub AlimenterComboboxOT()
        Dim req_Liste_ot = "Select * From OT"
        Dim numeroOT As Object = Me.numeroOT
        Call Alimenter_combo.listderoulante(req_Liste_ot, numeroOT, 0)
    End Sub
    Sub MiseEnformeDatagridview()

        Try
            Dim Sql_recapitulatif_facturation As String = "Select ShippingCompany, Sum([MontantFacture]) as [Cumul débit],Sum([MontantReglement]) as [Cumul crédit] ,Sum([SoldeFacture]) as [Solde]" _
                                   & " From t_Facture" _
                                   & " Where" _
                                   & " Prestation='Acconage'" _
                                   & " GROUP BY ShippingCompany"
            dataGrid3(Sql_recapitulatif_facturation)
            DataGridView3.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataGridView3.Columns(1).DefaultCellStyle.Format = "N2"
            DataGridView3.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataGridView3.Columns(2).DefaultCellStyle.Format = "N2"
            DataGridView3.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataGridView3.Columns(3).DefaultCellStyle.Format = "N2"
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Sub AlimenterComboboxPrestataire()
        Try
            Dim prestaires As String() = {"Abidjan terminal(ATL)", "Côte d'ivoire terminal(CIT)"}
            AcconagePrestataire.Items.AddRange(prestaires)
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub ShippingCo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShippingCo.SelectedIndexChanged

         Affichage_data_acconage()
    End Sub
    Public Sub Affichage_data_acconage()
        Try
            Dim nomCompagnieMaritime As String

            If String.IsNullOrEmpty(Me.ShippingCo.Text) Then
                nomCompagnieMaritime = "MAERSK"
            Else
                nomCompagnieMaritime = Me.ShippingCo.Text
            End If



            ' Liste contenant les différentes requêtes SQL
            Dim requetes As New List(Of String) From {
            "SELECT SUM([MontantFacture]) FROM t_Facture WHERE Prestation='Acconage' AND ShippingCompany='" & nomCompagnieMaritime & "'",
            "SELECT SUM([MontantReglement]) FROM t_Facture WHERE Prestation='Acconage' AND ShippingCompany='" & nomCompagnieMaritime & "'",
            "SELECT SUM([SoldeFacture]) FROM t_Facture WHERE Prestation='Acconage' AND ShippingCompany='" & nomCompagnieMaritime & "'"
        }

            ' Exécuter les requêtes et récupérer les résultats
            Dim valeurs As New List(Of Double) From {
            ModuleTransit.Cumul_debit(requetes(0)),
            ModuleTransit.Cumul_credit(requetes(1)),
            ModuleTransit.Cumul_Somme(requetes(2))
        }

            ' Affichage des résultats dans les labels
            Me.acconage_Debit_lbl.Text = Format(valeurs(0), "##,##0")
            Me.acconage_Credit.Text = Format(valeurs(1), "##,##0")
            Me.acconage_Solde.Text = Format(valeurs(2), "##,##0")

            ' Requête pour récupérer les données et alimenter le DataGridView


            Dim Sql_acconage As String = "SELECT numeroBooking, Acconage_Date, Acconage_numeroFacture, acconage_Montant, numeroOT, Client " &
                                     "FROM t_transit WHERE ShippingCompagny='" & nomCompagnieMaritime & "' AND acconage_Montant>0 ORDER BY Acconage_numeroFacture, Acconage_Date"


            dataGrid(Sql_acconage)

            ' Personnalisation du DataGridView
            Dim columns As String() = {"Booking", "Date", "Facture", "Montant", "OT", "Client"}
            For i As Integer = 0 To columns.Length - 1
                DataGridView2.Columns(i).HeaderText = columns(i)
                DataGridView2.Columns(i).HeaderCell.Style.Font = New Font(Me.DataGridView2.Font, FontStyle.Bold)
            Next

            DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataGridView2.Columns(3).DefaultCellStyle.Format = "N2"
            DataGridView2.Columns(5).Width = 300

            ' Alimenter la liste déroulante des OT
            Dim req_Liste_Ot As String = "SELECT * FROM OT WHERE Ot_ShippingCo='" & nomCompagnieMaritime & "'"
            Call Alimenter_combo.listderoulante(req_Liste_Ot, Me.numeroOT, 0)

            ' Affichage du nombre d'enregistrements
            Me.nbreDeFacture.Text = "Nombre d'enregistrements: " & (Me.DataGridView2.Rows.Count - 1).ToString()

        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Public Sub dataGrid(sql)
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Glo App Ser\Desktop\GNC_2025_version_VS2019\GNC_DBTRANSIT2025.accdb")

            Dim cmd_OT As New OleDbCommand(sql, conn)
            Dim da As New OleDbDataAdapter
            Dim oT As New DataTable()
            If conn.State = ConnectionState.Closed Then conn.Open()

            da.SelectCommand = cmd_OT
            oT.Clear()
            da.Fill(oT)
            DataGridView2.DataSource = oT
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub dataGrid3(sql)
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Glo App Ser\Desktop\GNC_2025_version_VS2019\GNC_DBTRANSIT2025.accdb")

            Dim cmd_t_facture As New OleDbCommand(sql, conn)
            Dim da As New OleDbDataAdapter
            Dim t_Facture As New DataTable()
            If conn.State = ConnectionState.Closed Then conn.Open()

            da.SelectCommand = cmd_t_facture
            t_Facture.Clear()
            da.Fill(t_Facture)
            DataGridView3.DataSource = t_Facture
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Quitter_btn_Click(sender As Object, e As EventArgs) Handles Quitter_btn.Click

        Me.Hide()
        Using Menu As New Menu
            Menu.Opacity = 1
            Menu.ShowDialog()
        End Using

    End Sub
    Private Sub RechercherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechercherToolStripMenuItem.Click
        Dim Prestataire As String = Me.AcconagePrestataire.Text
        Rechercher(DataGridView2)
    End Sub
    Sub Rechercher(Dgv As DataGridView)
        Try
            ' Appel de la méthode pour rechercher et afficher les données
            ModuleDBManip.RechercherEtAfficher(Dgv)
        Catch ex As Exception
            ' Gestion des erreurs avec un message clair
            MessageBox.Show($"Une erreur est survenue lors de la recherche : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AconnageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AconnageToolStripMenuItem.Click
        Using aconnage As New Acconage
            aconnage.ShowDialog()
        End Using
    End Sub

    Private Sub BmcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BmcToolStripMenuItem.Click
        Using bmc As New Bmc
            bmc.ShowDialog()
        End Using
    End Sub

    Private Sub TirageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TirageToolStripMenuItem.Click
        Using tirageDeclaration As New TirageDeclaration
            tirageDeclaration.ShowDialog()
        End Using
    End Sub

    Private Sub AffectionCréditArmateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffectionCréditArmateurToolStripMenuItem.Click
        Using affectionCreditArmateur As New AffectionCreditArmateur
            affectionCreditArmateur.ShowDialog()
        End Using
    End Sub

    Private Sub LettrageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LettrageToolStripMenuItem.Click
        Using lettrage As New Lettrage
            lettrage.ShowDialog()
        End Using
    End Sub
    Private Sub FretToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FretToolStripMenuItem.Click
        Using fret As New Fret
            fret.ShowDialog()
        End Using
    End Sub
    Public Sub AcconageValider()
        Try
            Dim date_acconage As Date
            Dim montant_acconage As Double
            Dim numeroFacture_Acconage As String
            Dim ot As String
            Dim sql As String
            Dim Prestation As String = "Acconage"
            Dim Prestataire As String = Me.AcconagePrestataire.Text
            Dim navire As String = ""
            Dim Client As String = Me.Acconage_Client.Text
            Dim Sql_acconage_datagridview_affichage As String

            ' Vérifier si les champs requis sont remplis
            If String.IsNullOrWhiteSpace(Me.numeroOT.Text) OrElse
               String.IsNullOrWhiteSpace(Me.Acconage_Date.Text) OrElse
               String.IsNullOrWhiteSpace(Me.Acconage_numeroFacture.Text) OrElse
               String.IsNullOrWhiteSpace(Me.acconage_Montant.Text) Then

                MessageBox.Show("Veuillez renseigner tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Récupération des valeurs
            date_acconage = Date.Parse(Me.Acconage_Date.Text)
            montant_acconage = Convert.ToDouble(Me.acconage_Montant.Text.Replace(Chr(160), ""))
            numeroFacture_Acconage = Me.Acconage_numeroFacture.Text
            ot = Me.numeroOT.Text

            ' Mise à jour de la base de données avec requête paramétrée
            sql = "UPDATE t_TRANSIT SET Acconage_Date=@date, Acconage_Montant=@montant, Acconage_NumeroFacture=@facture WHERE numeroOT=@ot"

            Try
                Using cnx As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Glo App Ser\Desktop\GNC_2025_version_VS2019\GNC_DBTRANSIT2025.accdb"),
          cmd As New OleDbCommand(sql, cnx)

                    cmd.Parameters.AddWithValue("@date", date_acconage)
                    cmd.Parameters.AddWithValue("@montant", montant_acconage)
                    cmd.Parameters.AddWithValue("@facture", numeroFacture_Acconage)
                    cmd.Parameters.AddWithValue("@ot", ot)

                    cnx.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("L'opération a réussi avec " & rowsAffected & " enregistrements affectés.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Aucun enregistrement n'a été affecté.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

            Catch ex As OleDbException
                MessageBox.Show("Une erreur de base de données s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub ' Quitter la procédure en cas d'erreur
            Catch ex As Exception
                MessageBox.Show("Une erreur inattendue s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub ' Quitter la procédure en cas d'erreur
            End Try

            ' Construction du libellé
            Dim Libelle As String = $"Facture acconage, Ot numéro {ot}, {Me.NbreTcs.Text}Tcs, Booking: {Me.numeroBooking.Text}."

            Dim compagnieMaritime As String = ModuleTransit.Recherche(ot, "ShippingCompagny")
            Dim cumul_Tcs_lourds_BL As Integer = 0
            Dim Devise As String = "FCFA"

            ' Enregistrement de la facture
            If Not Enregistrement_facture_MiseAJour_tTransit(Client, date_acconage, numeroFacture_Acconage, Libelle, Me.numeroBooking.Text, "",
                                                      ot, Me.NbreTcs.Text, montant_acconage, 0, montant_acconage, "",
                                                      compagnieMaritime, navire, Prestataire, Prestation, sql, cumul_Tcs_lourds_BL, Devise) Then
                Exit Sub
            End If


            ' Réinitialiser le formulaire
            Remise_A_Zero_Formulaire()

        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub Acconage_valider_Click(sender As Object, e As EventArgs) Handles acconage_valider.Click

        AcconageValider()

        Affichage_data_acconage()

        AffichageDataGridview1()

    End Sub
    Sub AffichageDataGridview1()
        Try
            ' Mise à jour du DataGridView1
            Dim Sql_acconage_datagridview_affichage As String = "SELECT Acconage_Date, Acconage_numeroFacture, numeroOT, acconage_Montant FROM t_transit Where acconage_numeroFacture<>''"
            Dim dt As New DataTable()

            Using cnx As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Glo App Ser\Desktop\GNC_2025_version_VS2019\GNC_DBTRANSIT2025.accdb"),
                  da As New OleDbDataAdapter(Sql_acconage_datagridview_affichage, cnx)

                da.Fill(dt)
            End Using

            Me.DataGridView1.DataSource = dt  ' Liaison des données au DataGridView
            Me.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells) ' Ajustement des colonnes
            Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(3).DefaultCellStyle.Format = ("N0")

            Me.DataGridView1.Columns(0).HeaderText = "Date enregistrement"
            Me.DataGridView1.Columns(1).HeaderText = "N°facture"
            Me.DataGridView1.Columns(2).HeaderText = "OT"
            Me.DataGridView1.Columns(3).HeaderText = "Montant"

        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Public Sub Remise_A_Zero_Formulaire()
        Try
            For Each ctrl As Control In Me.Controls
                ' Vérification du type du contrôle
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Text = String.Empty
                ElseIf TypeOf ctrl Is ComboBox Then
                    CType(ctrl, ComboBox).SelectedIndex = -1 ' Réinitialisation du ComboBox
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub Acconage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous  vraiment  quitter ?", "Fermer", MessageBoxButtons.YesNo)
            If confirmation = DialogResult.No Then
                e.Cancel = True
            Else
                Me.Hide()
                Using Menu As New Menu
                    Menu.Opacity = 1
                    Menu.ShowDialog()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub AcconagePrestataire_SelectedValueChanged(sender As Object, e As EventArgs) Handles AcconagePrestataire.SelectedValueChanged
        Dim AcconagePrestataire As String = Me.AcconagePrestataire.Text
        If AcconagePrestataire = "Côte d'ivoire terminal(CIT)" Then
            AcconageMontantParTc40 = 285000
        ElseIf AcconagePrestataire = "Abidjan terminal(ATL)" Then
            AcconageMontantParTc40 = 296600
        Else
            Exit Sub
            MsgBox("Vauillez saisir un  prestataire  valide")
        End If
        CalculMontantAcconage()
    End Sub

    Private Sub numeroBooking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numeroBooking.SelectedIndexChanged
        Dim NumeroBooking As String = Me.numeroBooking.Text
        Dim NbreTc As Integer
        If NumeroBooking = "" Then MsgBox("Veuillez renseigner le  numero  de booking") : Exit Sub
        Me.numeroOT.Text = DatabaseHelper.GetStringValue($"Select [Ot_Numero] from OT Where OT_Booking='{NumeroBooking}'", 1)
        NbreTc = DatabaseHelper.GetIntegerValue($"Select [Ot_TonnageThéorique]/25 from OT Where OT_Booking='{NumeroBooking}'", 1)
        Me.LabelNbTcs.Text = NbreTc
        CalculMontantAcconage
    End Sub
    Sub CalculMontantAcconage()
        If Me.NbreTcs.Text = "" Then Me.NbreTcs.Text = 0
        Dim NbreTc As Integer = CInt(Me.NbreTcs.Text)
        Dim Montantacconage As Double = NbreTc * AcconageMontantParTc40
        Me.acconage_Montant.Text = Montantacconage.ToString("N0")
    End Sub

    Private Sub InitialiserListeCompagnieMaritime()
        Dim gestionCompagnies As New CompagniesMaritimes()
        Me.ShippingCo.Items.Clear() ' Nettoyer le ComboBox
        Me.ShippingCo.Items.AddRange(gestionCompagnies.ObtenirListeCompagnies().ToArray())
    End Sub
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        If Me.ShippingCo.Text = "" Then MsgBox("Veuillez  renseigner  le  nom  de  la compagnie maritime!") : Exit Sub
        Dim gestionCompagnies As New CompagniesMaritimes()
        Dim nouvelleCompagnie As String = ShippingCo.Text.Trim()

        gestionCompagnies.AjouterCompagnie(nouvelleCompagnie)
        Me.ShippingCo.Items.Clear()
        Me.ShippingCo.Items.AddRange(gestionCompagnies.ObtenirListeCompagnies().ToArray())

    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
