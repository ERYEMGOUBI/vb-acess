<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitéDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet12 = New shop.loginformDataSet12()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CltDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TéléphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet7 = New shop.loginformDataSet7()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProduitDGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatégoriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitéDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet6 = New shop.loginformDataSet6()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FacturationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet9 = New shop.loginformDataSet9()
        Me.ProduitTableAdapter = New shop.loginformDataSet6TableAdapters.ProduitTableAdapter()
        Me.ClientTableAdapter = New shop.loginformDataSet7TableAdapters.ClientTableAdapter()
        Me.LoginformDataSet8 = New shop.loginformDataSet8()
        Me.FacturationTableAdapter = New shop.loginformDataSet9TableAdapters.FacturationTableAdapter()
        Me.FacturationTableAdapter1 = New shop.loginformDataSet12TableAdapters.FacturationTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.CltDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduitDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BillDGV)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Controls.Add(Me.BunifuThinButton23)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(22, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 622)
        Me.Panel1.TabIndex = 3
        '
        'BillDGV
        '
        Me.BillDGV.AutoGenerateColumns = False
        Me.BillDGV.BackgroundColor = System.Drawing.Color.White
        Me.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.ProduitDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn1, Me.QuantitéDataGridViewTextBoxColumn1, Me.TotalDataGridViewTextBoxColumn})
        Me.BillDGV.DataSource = Me.FacturationBindingSource1
        Me.BillDGV.Location = New System.Drawing.Point(511, 106)
        Me.BillDGV.Name = "BillDGV"
        Me.BillDGV.RowHeadersVisible = False
        Me.BillDGV.RowHeadersWidth = 51
        Me.BillDGV.RowTemplate.Height = 24
        Me.BillDGV.Size = New System.Drawing.Size(630, 224)
        Me.BillDGV.TabIndex = 40
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        Me.IDDataGridViewTextBoxColumn2.Width = 125
        '
        'ProduitDataGridViewTextBoxColumn
        '
        Me.ProduitDataGridViewTextBoxColumn.DataPropertyName = "Produit"
        Me.ProduitDataGridViewTextBoxColumn.HeaderText = "Produit"
        Me.ProduitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProduitDataGridViewTextBoxColumn.Name = "ProduitDataGridViewTextBoxColumn"
        Me.ProduitDataGridViewTextBoxColumn.Width = 125
        '
        'PrixDataGridViewTextBoxColumn1
        '
        Me.PrixDataGridViewTextBoxColumn1.DataPropertyName = "Prix"
        Me.PrixDataGridViewTextBoxColumn1.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.PrixDataGridViewTextBoxColumn1.Name = "PrixDataGridViewTextBoxColumn1"
        Me.PrixDataGridViewTextBoxColumn1.Width = 125
        '
        'QuantitéDataGridViewTextBoxColumn1
        '
        Me.QuantitéDataGridViewTextBoxColumn1.DataPropertyName = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn1.HeaderText = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.QuantitéDataGridViewTextBoxColumn1.Name = "QuantitéDataGridViewTextBoxColumn1"
        Me.QuantitéDataGridViewTextBoxColumn1.Width = 125
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 125
        '
        'FacturationBindingSource1
        '
        Me.FacturationBindingSource1.DataMember = "Facturation"
        Me.FacturationBindingSource1.DataSource = Me.LoginformDataSet12
        '
        'LoginformDataSet12
        '
        Me.LoginformDataSet12.DataSetName = "loginformDataSet12"
        Me.LoginformDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(770, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Facture"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1018, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 23)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Total"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CltDGV)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ProduitDGV)
        Me.Panel4.Location = New System.Drawing.Point(20, 397)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1121, 211)
        Me.Panel4.TabIndex = 36
        '
        'CltDGV
        '
        Me.CltDGV.AutoGenerateColumns = False
        Me.CltDGV.BackgroundColor = System.Drawing.Color.White
        Me.CltDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CltDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CltDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.NomDataGridViewTextBoxColumn, Me.TéléphoneDataGridViewTextBoxColumn, Me.AdresseDataGridViewTextBoxColumn})
        Me.CltDGV.DataSource = Me.ClientBindingSource
        Me.CltDGV.Location = New System.Drawing.Point(27, 42)
        Me.CltDGV.Name = "CltDGV"
        Me.CltDGV.RowHeadersVisible = False
        Me.CltDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.CltDGV.RowTemplate.Height = 24
        Me.CltDGV.Size = New System.Drawing.Size(433, 154)
        Me.CltDGV.TabIndex = 37
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.Width = 59
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.Width = 86
        '
        'TéléphoneDataGridViewTextBoxColumn
        '
        Me.TéléphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TéléphoneDataGridViewTextBoxColumn.DataPropertyName = "Téléphone"
        Me.TéléphoneDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.TéléphoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TéléphoneDataGridViewTextBoxColumn.Name = "TéléphoneDataGridViewTextBoxColumn"
        Me.TéléphoneDataGridViewTextBoxColumn.Width = 142
        '
        'AdresseDataGridViewTextBoxColumn
        '
        Me.AdresseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AdresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse"
        Me.AdresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.AdresseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AdresseDataGridViewTextBoxColumn.Name = "AdresseDataGridViewTextBoxColumn"
        Me.AdresseDataGridViewTextBoxColumn.Width = 116
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.LoginformDataSet7
        '
        'LoginformDataSet7
        '
        Me.LoginformDataSet7.DataSetName = "loginformDataSet7"
        Me.LoginformDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(152, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 23)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nom des clients"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(713, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nom des produits"
        '
        'ProduitDGV
        '
        Me.ProduitDGV.AutoGenerateColumns = False
        Me.ProduitDGV.BackgroundColor = System.Drawing.Color.White
        Me.ProduitDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProduitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProduitDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ArticleDataGridViewTextBoxColumn, Me.CatégoriesDataGridViewTextBoxColumn, Me.TypesDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn, Me.QuantitéDataGridViewTextBoxColumn})
        Me.ProduitDGV.DataSource = Me.ProduitBindingSource
        Me.ProduitDGV.Location = New System.Drawing.Point(491, 42)
        Me.ProduitDGV.Name = "ProduitDGV"
        Me.ProduitDGV.RowHeadersVisible = False
        Me.ProduitDGV.RowHeadersWidth = 51
        Me.ProduitDGV.RowTemplate.Height = 24
        Me.ProduitDGV.Size = New System.Drawing.Size(618, 154)
        Me.ProduitDGV.TabIndex = 23
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 59
        '
        'ArticleDataGridViewTextBoxColumn
        '
        Me.ArticleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ArticleDataGridViewTextBoxColumn.DataPropertyName = "Article"
        Me.ArticleDataGridViewTextBoxColumn.HeaderText = "Article"
        Me.ArticleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ArticleDataGridViewTextBoxColumn.Name = "ArticleDataGridViewTextBoxColumn"
        Me.ArticleDataGridViewTextBoxColumn.Width = 101
        '
        'CatégoriesDataGridViewTextBoxColumn
        '
        Me.CatégoriesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CatégoriesDataGridViewTextBoxColumn.DataPropertyName = "Catégories"
        Me.CatégoriesDataGridViewTextBoxColumn.HeaderText = "Catégories"
        Me.CatégoriesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CatégoriesDataGridViewTextBoxColumn.Name = "CatégoriesDataGridViewTextBoxColumn"
        Me.CatégoriesDataGridViewTextBoxColumn.Width = 145
        '
        'TypesDataGridViewTextBoxColumn
        '
        Me.TypesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TypesDataGridViewTextBoxColumn.DataPropertyName = "Types"
        Me.TypesDataGridViewTextBoxColumn.HeaderText = "Types"
        Me.TypesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypesDataGridViewTextBoxColumn.Name = "TypesDataGridViewTextBoxColumn"
        Me.TypesDataGridViewTextBoxColumn.Width = 93
        '
        'PrixDataGridViewTextBoxColumn
        '
        Me.PrixDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrixDataGridViewTextBoxColumn.DataPropertyName = "Prix"
        Me.PrixDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrixDataGridViewTextBoxColumn.Name = "PrixDataGridViewTextBoxColumn"
        Me.PrixDataGridViewTextBoxColumn.Width = 70
        '
        'QuantitéDataGridViewTextBoxColumn
        '
        Me.QuantitéDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QuantitéDataGridViewTextBoxColumn.DataPropertyName = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantitéDataGridViewTextBoxColumn.Name = "QuantitéDataGridViewTextBoxColumn"
        Me.QuantitéDataGridViewTextBoxColumn.Width = 124
        '
        'ProduitBindingSource
        '
        Me.ProduitBindingSource.DataMember = "Produit"
        Me.ProduitBindingSource.DataSource = Me.LoginformDataSet6
        '
        'LoginformDataSet6
        '
        Me.LoginformDataSet6.DataSetName = "loginformDataSet6"
        Me.LoginformDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.BunifuThinButton21)
        Me.Panel3.Location = New System.Drawing.Point(34, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(425, 231)
        Me.Panel3.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(243, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(167, 32)
        Me.TextBox2.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nom des produits"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(10, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 32)
        Me.TextBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(239, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Quantité"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nom des clients"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(10, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 32)
        Me.TextBox3.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(239, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Prix"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(243, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(155, 32)
        Me.TextBox4.TabIndex = 18
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
        Me.BunifuThinButton21.ButtonText = "Ajouter à la facture"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(77, 183)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(241, 41)
        Me.BunifuThinButton21.TabIndex = 29
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1118, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
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
        Me.BunifuThinButton24.ButtonText = "Imprimer"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton24.Location = New System.Drawing.Point(712, 339)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(173, 42)
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
        Me.BunifuThinButton23.ButtonText = "Voir les ventes"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(111, 346)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(241, 42)
        Me.BunifuThinButton23.TabIndex = 31
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(544, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Facturation"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(548, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(117, 7)
        Me.Panel2.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(427, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'FacturationBindingSource
        '
        Me.FacturationBindingSource.DataMember = "Facturation"
        Me.FacturationBindingSource.DataSource = Me.LoginformDataSet9
        '
        'LoginformDataSet9
        '
        Me.LoginformDataSet9.DataSetName = "loginformDataSet9"
        Me.LoginformDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProduitTableAdapter
        '
        Me.ProduitTableAdapter.ClearBeforeFill = True
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'LoginformDataSet8
        '
        Me.LoginformDataSet8.DataSetName = "loginformDataSet8"
        Me.LoginformDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturationTableAdapter
        '
        Me.FacturationTableAdapter.ClearBeforeFill = True
        '
        'FacturationTableAdapter1
        '
        Me.FacturationTableAdapter1.ClearBeforeFill = True
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 647)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Billing"
        Me.Text = "Billing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.CltDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduitDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ProduitDGV As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CltDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LoginformDataSet6 As loginformDataSet6
    Friend WithEvents ProduitBindingSource As BindingSource
    Friend WithEvents ProduitTableAdapter As loginformDataSet6TableAdapters.ProduitTableAdapter
    Friend WithEvents LoginformDataSet7 As loginformDataSet7
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As loginformDataSet7TableAdapters.ClientTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TéléphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArticleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatégoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantitéDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginformDataSet8 As loginformDataSet8
    Friend WithEvents LoginformDataSet9 As loginformDataSet9
    Friend WithEvents FacturationBindingSource As BindingSource
    Friend WithEvents FacturationTableAdapter As loginformDataSet9TableAdapters.FacturationTableAdapter
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents LoginformDataSet12 As loginformDataSet12
    Friend WithEvents FacturationBindingSource1 As BindingSource
    Friend WithEvents FacturationTableAdapter1 As loginformDataSet12TableAdapters.FacturationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProduitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantitéDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
