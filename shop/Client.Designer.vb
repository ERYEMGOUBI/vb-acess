<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet2 = New shop.loginformDataSet2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ClientTableAdapter = New shop.loginformDataSet2TableAdapters.ClientTableAdapter()
        Me.LoginformDataSet3 = New shop.loginformDataSet3()
        Me.ClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter1 = New shop.loginformDataSet3TableAdapters.ClientTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Controls.Add(Me.BunifuThinButton23)
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(138, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 806)
        Me.Panel1.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Nom", True))
        Me.TextBox5.Location = New System.Drawing.Point(549, 414)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(578, 32)
        Me.TextBox5.TabIndex = 39
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.LoginformDataSet2
        '
        'LoginformDataSet2
        '
        Me.LoginformDataSet2.DataSetName = "loginformDataSet2"
        Me.LoginformDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(361, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 23)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Rechercher"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Nom", True))
        Me.TextBox2.Location = New System.Drawing.Point(167, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 32)
        Me.TextBox2.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(163, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 23)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(461, 547)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(538, 207)
        Me.DataGridView1.TabIndex = 35
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Nom"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 86
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Téléphone"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 142
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Adressse"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 124
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1217, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(618, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Client liste"
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Supprimer"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton24.Location = New System.Drawing.Point(993, 325)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(134, 42)
        Me.BunifuThinButton24.TabIndex = 32
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Efacer"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(764, 325)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(134, 42)
        Me.BunifuThinButton23.TabIndex = 31
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Modifier"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(539, 325)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(142, 42)
        Me.BunifuThinButton22.TabIndex = 30
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Enregistrer"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(305, 325)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(164, 41)
        Me.BunifuThinButton21.TabIndex = 29
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(53, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 24
        Me.PictureBox6.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Adresse", True))
        Me.TextBox4.Location = New System.Drawing.Point(807, 224)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(351, 32)
        Me.TextBox4.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(875, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Adresse"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Téléphone", True))
        Me.TextBox3.Location = New System.Drawing.Point(555, 224)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(210, 32)
        Me.TextBox3.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(551, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Téléphone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(529, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Produits"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(764, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(62, 7)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(56, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(62, 7)
        Me.Panel3.TabIndex = 16
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-56, -33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 72)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(52, -7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 23)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Client"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(642, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(102, 72)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(548, 79)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(116, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Nom", True))
        Me.TextBox1.Location = New System.Drawing.Point(258, 224)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 32)
        Me.TextBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(254, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(760, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Client"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(412, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'LoginformDataSet3
        '
        Me.LoginformDataSet3.DataSetName = "loginformDataSet3"
        Me.LoginformDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientBindingSource1
        '
        Me.ClientBindingSource1.DataMember = "Client"
        Me.ClientBindingSource1.DataSource = Me.LoginformDataSet3
        '
        'ClientTableAdapter1
        '
        Me.ClientTableAdapter1.ClearBeforeFill = True
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1553, 929)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Client"
        Me.Text = "Client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginformDataSet2 As loginformDataSet2
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As loginformDataSet2TableAdapters.ClientTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LoginformDataSet3 As loginformDataSet3
    Friend WithEvents ClientBindingSource1 As BindingSource
    Friend WithEvents ClientTableAdapter1 As loginformDataSet3TableAdapters.ClientTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
End Class
