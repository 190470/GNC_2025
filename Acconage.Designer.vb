<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acconage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acconage))
        Me.ShippingCo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.acconage_Solde = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.acconage_Debit_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.acconage_Credit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numeroOT = New System.Windows.Forms.ComboBox()
        Me.NbreTcs = New System.Windows.Forms.Label()
        Me.Acconage_Client = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Acconage_Date = New System.Windows.Forms.TextBox()
        Me.Acconage_numeroFacture = New System.Windows.Forms.TextBox()
        Me.acconage_Montant = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.acconage_valider = New System.Windows.Forms.Button()
        Me.Export_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Quitter_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numeroBL = New System.Windows.Forms.ComboBox()
        Me.nbreDeFacture = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.M1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AconnageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BmcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemandeAffectionCreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TirageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LettrageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutresFraisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffectionCréditArmateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FretToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcconagePrestataire = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelNbTcs = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numeroBooking = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShippingCo
        '
        Me.ShippingCo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ShippingCo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingCo.ForeColor = System.Drawing.Color.Red
        Me.ShippingCo.FormattingEnabled = True
        Me.ShippingCo.Location = New System.Drawing.Point(174, 24)
        Me.ShippingCo.Margin = New System.Windows.Forms.Padding(4)
        Me.ShippingCo.Name = "ShippingCo"
        Me.ShippingCo.Size = New System.Drawing.Size(265, 26)
        Me.ShippingCo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Shipping company"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Controls.Add(Me.acconage_Solde)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.acconage_Debit_lbl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.acconage_Credit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ShippingCo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 162)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(481, 196)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(448, 27)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(27, 23)
        Me.BtnAjouter.TabIndex = 8
        Me.BtnAjouter.Text = "..."
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'acconage_Solde
        '
        Me.acconage_Solde.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.acconage_Solde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.acconage_Solde.Enabled = False
        Me.acconage_Solde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acconage_Solde.ForeColor = System.Drawing.Color.Red
        Me.acconage_Solde.Location = New System.Drawing.Point(174, 157)
        Me.acconage_Solde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.acconage_Solde.Name = "acconage_Solde"
        Me.acconage_Solde.Size = New System.Drawing.Size(265, 32)
        Me.acconage_Solde.TabIndex = 7
        Me.acconage_Solde.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Solde:"
        '
        'acconage_Debit_lbl
        '
        Me.acconage_Debit_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.acconage_Debit_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.acconage_Debit_lbl.Enabled = False
        Me.acconage_Debit_lbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acconage_Debit_lbl.ForeColor = System.Drawing.Color.Red
        Me.acconage_Debit_lbl.Location = New System.Drawing.Point(174, 58)
        Me.acconage_Debit_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.acconage_Debit_lbl.Name = "acconage_Debit_lbl"
        Me.acconage_Debit_lbl.Size = New System.Drawing.Size(265, 32)
        Me.acconage_Debit_lbl.TabIndex = 5
        Me.acconage_Debit_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Debit:"
        '
        'acconage_Credit
        '
        Me.acconage_Credit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.acconage_Credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.acconage_Credit.Enabled = False
        Me.acconage_Credit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acconage_Credit.ForeColor = System.Drawing.Color.Red
        Me.acconage_Credit.Location = New System.Drawing.Point(174, 107)
        Me.acconage_Credit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.acconage_Credit.Name = "acconage_Credit"
        Me.acconage_Credit.Size = New System.Drawing.Size(265, 33)
        Me.acconage_Credit.TabIndex = 0
        Me.acconage_Credit.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Credit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(527, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cumul montant  facture par  Shipping company"
        '
        'numeroOT
        '
        Me.numeroOT.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.numeroOT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeroOT.ForeColor = System.Drawing.Color.Red
        Me.numeroOT.FormattingEnabled = True
        Me.numeroOT.Location = New System.Drawing.Point(284, 48)
        Me.numeroOT.Margin = New System.Windows.Forms.Padding(4)
        Me.numeroOT.Name = "numeroOT"
        Me.numeroOT.Size = New System.Drawing.Size(75, 26)
        Me.numeroOT.TabIndex = 7
        '
        'NbreTcs
        '
        Me.NbreTcs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.NbreTcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NbreTcs.ForeColor = System.Drawing.Color.Red
        Me.NbreTcs.Location = New System.Drawing.Point(379, 48)
        Me.NbreTcs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NbreTcs.Name = "NbreTcs"
        Me.NbreTcs.Size = New System.Drawing.Size(56, 26)
        Me.NbreTcs.TabIndex = 9
        Me.NbreTcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Acconage_Client
        '
        Me.Acconage_Client.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Acconage_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Acconage_Client.ForeColor = System.Drawing.Color.Red
        Me.Acconage_Client.Location = New System.Drawing.Point(91, 99)
        Me.Acconage_Client.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Acconage_Client.Name = "Acconage_Client"
        Me.Acconage_Client.Size = New System.Drawing.Size(348, 38)
        Me.Acconage_Client.TabIndex = 10
        Me.Acconage_Client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Client"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(288, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "OT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(88, 31)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Booking"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(378, 24)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Nbre Tcs"
        '
        'Acconage_Date
        '
        Me.Acconage_Date.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Acconage_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Acconage_Date.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acconage_Date.ForeColor = System.Drawing.Color.Red
        Me.Acconage_Date.Location = New System.Drawing.Point(144, 67)
        Me.Acconage_Date.Margin = New System.Windows.Forms.Padding(4)
        Me.Acconage_Date.Name = "Acconage_Date"
        Me.Acconage_Date.Size = New System.Drawing.Size(291, 26)
        Me.Acconage_Date.TabIndex = 15
        '
        'Acconage_numeroFacture
        '
        Me.Acconage_numeroFacture.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Acconage_numeroFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Acconage_numeroFacture.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acconage_numeroFacture.ForeColor = System.Drawing.Color.Red
        Me.Acconage_numeroFacture.Location = New System.Drawing.Point(144, 112)
        Me.Acconage_numeroFacture.Margin = New System.Windows.Forms.Padding(4)
        Me.Acconage_numeroFacture.Name = "Acconage_numeroFacture"
        Me.Acconage_numeroFacture.Size = New System.Drawing.Size(291, 26)
        Me.Acconage_numeroFacture.TabIndex = 17
        '
        'acconage_Montant
        '
        Me.acconage_Montant.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.acconage_Montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.acconage_Montant.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acconage_Montant.ForeColor = System.Drawing.Color.Red
        Me.acconage_Montant.Location = New System.Drawing.Point(144, 157)
        Me.acconage_Montant.Margin = New System.Windows.Forms.Padding(4)
        Me.acconage_Montant.Name = "acconage_Montant"
        Me.acconage_Montant.Size = New System.Drawing.Size(291, 26)
        Me.acconage_Montant.TabIndex = 18
        Me.acconage_Montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 73)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Date facture"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 123)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Prestataire acconage"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 118)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "N°Facture"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 163)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Montant facture"
        '
        'acconage_valider
        '
        Me.acconage_valider.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.acconage_valider.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.acconage_valider.FlatAppearance.BorderSize = 2
        Me.acconage_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.acconage_valider.Location = New System.Drawing.Point(154, 779)
        Me.acconage_valider.Margin = New System.Windows.Forms.Padding(4)
        Me.acconage_valider.Name = "acconage_valider"
        Me.acconage_valider.Size = New System.Drawing.Size(161, 38)
        Me.acconage_valider.TabIndex = 23
        Me.acconage_valider.Text = "Enregistrer"
        Me.acconage_valider.UseVisualStyleBackColor = False
        '
        'Export_btn
        '
        Me.Export_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Export_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Export_btn.FlatAppearance.BorderSize = 2
        Me.Export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Export_btn.Location = New System.Drawing.Point(735, 779)
        Me.Export_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Export_btn.Name = "Export_btn"
        Me.Export_btn.Size = New System.Drawing.Size(161, 38)
        Me.Export_btn.TabIndex = 25
        Me.Export_btn.Text = "Exporter vers excel"
        Me.Export_btn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(524, 374)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(597, 155)
        Me.DataGridView1.TabIndex = 26
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(524, 549)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(871, 192)
        Me.DataGridView2.TabIndex = 27
        '
        'DataGridView3
        '
        Me.DataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(524, 172)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(495, 184)
        Me.DataGridView3.TabIndex = 28
        '
        'Quitter_btn
        '
        Me.Quitter_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Quitter_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Quitter_btn.FlatAppearance.BorderSize = 2
        Me.Quitter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Quitter_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitter_btn.Location = New System.Drawing.Point(1316, 779)
        Me.Quitter_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Quitter_btn.Name = "Quitter_btn"
        Me.Quitter_btn.Size = New System.Drawing.Size(161, 38)
        Me.Quitter_btn.TabIndex = 73
        Me.Quitter_btn.Text = "Quitter"
        Me.Quitter_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "N°BL"
        '
        'numeroBL
        '
        Me.numeroBL.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.numeroBL.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeroBL.ForeColor = System.Drawing.Color.Red
        Me.numeroBL.FormattingEnabled = True
        Me.numeroBL.Location = New System.Drawing.Point(144, 21)
        Me.numeroBL.Margin = New System.Windows.Forms.Padding(4)
        Me.numeroBL.Name = "numeroBL"
        Me.numeroBL.Size = New System.Drawing.Size(166, 24)
        Me.numeroBL.TabIndex = 75
        '
        'nbreDeFacture
        '
        Me.nbreDeFacture.AutoSize = True
        Me.nbreDeFacture.Location = New System.Drawing.Point(527, 743)
        Me.nbreDeFacture.Name = "nbreDeFacture"
        Me.nbreDeFacture.Size = New System.Drawing.Size(16, 17)
        Me.nbreDeFacture.TabIndex = 77
        Me.nbreDeFacture.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Teal
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox6.Location = New System.Drawing.Point(0, 0)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(1592, 49)
        Me.TextBox6.TabIndex = 78
        Me.TextBox6.Text = "GESTION FRET ET CHARGES LOCALES-ACONNAGE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MenuStrip1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 65)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1ToolStripMenuItem, Me.RechercherToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'M1ToolStripMenuItem
        '
        Me.M1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AconnageToolStripMenuItem, Me.BmcToolStripMenuItem, Me.DemandeAffectionCreditToolStripMenuItem, Me.TirageToolStripMenuItem, Me.LettrageToolStripMenuItem, Me.PaiementClientToolStripMenuItem, Me.AutresFraisToolStripMenuItem, Me.AffectionCréditArmateurToolStripMenuItem, Me.FretToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.M1ToolStripMenuItem.Name = "M1ToolStripMenuItem"
        Me.M1ToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.M1ToolStripMenuItem.Text = "Menu"
        '
        'AconnageToolStripMenuItem
        '
        Me.AconnageToolStripMenuItem.Name = "AconnageToolStripMenuItem"
        Me.AconnageToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.AconnageToolStripMenuItem.Text = "Aconnage"
        '
        'BmcToolStripMenuItem
        '
        Me.BmcToolStripMenuItem.Name = "BmcToolStripMenuItem"
        Me.BmcToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.BmcToolStripMenuItem.Text = "Bmc"
        '
        'DemandeAffectionCreditToolStripMenuItem
        '
        Me.DemandeAffectionCreditToolStripMenuItem.Name = "DemandeAffectionCreditToolStripMenuItem"
        Me.DemandeAffectionCreditToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.DemandeAffectionCreditToolStripMenuItem.Text = "Demande affection credit"
        '
        'TirageToolStripMenuItem
        '
        Me.TirageToolStripMenuItem.Name = "TirageToolStripMenuItem"
        Me.TirageToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.TirageToolStripMenuItem.Text = "Tirage"
        '
        'LettrageToolStripMenuItem
        '
        Me.LettrageToolStripMenuItem.Name = "LettrageToolStripMenuItem"
        Me.LettrageToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.LettrageToolStripMenuItem.Text = "Lettrage"
        '
        'PaiementClientToolStripMenuItem
        '
        Me.PaiementClientToolStripMenuItem.Name = "PaiementClientToolStripMenuItem"
        Me.PaiementClientToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.PaiementClientToolStripMenuItem.Text = "Paiement client"
        '
        'AutresFraisToolStripMenuItem
        '
        Me.AutresFraisToolStripMenuItem.Name = "AutresFraisToolStripMenuItem"
        Me.AutresFraisToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.AutresFraisToolStripMenuItem.Text = "Autres  frais"
        '
        'AffectionCréditArmateurToolStripMenuItem
        '
        Me.AffectionCréditArmateurToolStripMenuItem.Name = "AffectionCréditArmateurToolStripMenuItem"
        Me.AffectionCréditArmateurToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.AffectionCréditArmateurToolStripMenuItem.Text = "Affection Crédit  Armateur(autorisation lettrage)"
        '
        'FretToolStripMenuItem
        '
        Me.FretToolStripMenuItem.Name = "FretToolStripMenuItem"
        Me.FretToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.FretToolStripMenuItem.Text = "Fret"
        '
        'RechercherToolStripMenuItem
        '
        Me.RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        Me.RechercherToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.RechercherToolStripMenuItem.Text = "Rechercher"
        '
        'AcconagePrestataire
        '
        Me.AcconagePrestataire.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcconagePrestataire.ForeColor = System.Drawing.Color.Red
        Me.AcconagePrestataire.FormattingEnabled = True
        Me.AcconagePrestataire.Location = New System.Drawing.Point(189, 120)
        Me.AcconagePrestataire.Name = "AcconagePrestataire"
        Me.AcconagePrestataire.Size = New System.Drawing.Size(267, 26)
        Me.AcconagePrestataire.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Nbre Tcs"
        '
        'LabelNbTcs
        '
        Me.LabelNbTcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelNbTcs.ForeColor = System.Drawing.Color.Red
        Me.LabelNbTcs.Location = New System.Drawing.Point(388, 21)
        Me.LabelNbTcs.Name = "LabelNbTcs"
        Me.LabelNbTcs.Size = New System.Drawing.Size(47, 21)
        Me.LabelNbTcs.TabIndex = 113
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numeroBooking)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Acconage_Client)
        Me.GroupBox2.Controls.Add(Me.NbreTcs)
        Me.GroupBox2.Controls.Add(Me.numeroOT)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 365)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 165)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        '
        'numeroBooking
        '
        Me.numeroBooking.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeroBooking.ForeColor = System.Drawing.Color.Red
        Me.numeroBooking.FormattingEnabled = True
        Me.numeroBooking.Location = New System.Drawing.Point(91, 48)
        Me.numeroBooking.Name = "numeroBooking"
        Me.numeroBooking.Size = New System.Drawing.Size(166, 26)
        Me.numeroBooking.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelNbTcs)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.numeroBL)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.acconage_Montant)
        Me.GroupBox4.Controls.Add(Me.Acconage_numeroFacture)
        Me.GroupBox4.Controls.Add(Me.Acconage_Date)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 545)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(480, 196)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(412, 26)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'Acconage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1592, 824)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.nbreDeFacture)
        Me.Controls.Add(Me.AcconagePrestataire)
        Me.Controls.Add(Me.Quitter_btn)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Export_btn)
        Me.Controls.Add(Me.acconage_valider)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Acconage"
        Me.Text = "Acconage-Enregistrement factures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShippingCo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents acconage_Solde As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents acconage_Debit_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents acconage_Credit As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numeroOT As ComboBox
    Friend WithEvents NbreTcs As Label
    Friend WithEvents Acconage_Client As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Acconage_Date As TextBox
    Friend WithEvents Acconage_numeroFacture As TextBox
    Friend WithEvents acconage_Montant As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents acconage_valider As Button
    Friend WithEvents Export_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Quitter_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents numeroBL As ComboBox
    Friend WithEvents nbreDeFacture As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents M1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AconnageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BmcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemandeAffectionCreditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TirageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LettrageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaiementClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutresFraisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AffectionCréditArmateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FretToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcconagePrestataire As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelNbTcs As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents numeroBooking As ComboBox
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
End Class
