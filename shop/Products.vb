Imports System.Data.OleDb
Imports System.IO

Public Class Products
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Desktop\shop\loginform.mdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da1 As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter("select * from produit", con)
    Dim Cl As DataTable
    Dim CL1 As New DataTable
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim TR As Boolean
    Dim CB As OleDbCommandBuilder
    Dim cmd1 As OleDbCommand
    Dim dr1 As DataRow
    Dim Poss As Integer
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim log = New Utilisateure
        log.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub



    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LoginformDataSet5.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ProduitTableAdapter3.Fill(Me.LoginformDataSet5.Produit)
        'TODO: cette ligne de code charge les données dans la table 'LoginformDataSet4.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.


        TextBox1.Focus()
        CB = New OleDbCommandBuilder

        TextBox2.Text = "[ AUTO INCRÉMENT ]"
        TextBox2.Enabled = False
        loadingDatagridView()


    End Sub
    Sub loadingDatagridView()
        Try
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from Produit", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Article"), dr.Item("Catégories"), dr.Item("Types"), dr.Item("Prix"), dr.Item("Quantité"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
        ComboBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub
    Sub save()
        Try


            If TextBox1.Text = "" Then
                MsgBox("Vous devez saisir Article !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Attention")
                TextBox1.Focus()
            ElseIf ComboBox1.Text = "" Then
                MsgBox("Vous devez saisir Catégories  !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "attention")
                ComboBox1.Focus()
            ElseIf ComboBox2.Text = "" Then
                MsgBox("Vous devez saisir Types  !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "attention")
                ComboBox2.Focus()

            ElseIf TextBox3.Text = "" Then
                MsgBox("Vous devez saisir Prix !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "attention")
                TextBox3.Focus()
            ElseIf TextBox4.Text = "" Then
                MsgBox("Vous devez saisir Quantité !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "attention")
                TextBox4.Focus()
            ElseIf MsgBox("Êtes-vous sûr d'insérer cet enregistrement", vbQuestion + vbYesNo) = vbYes Then


                con.Open()
                Dim cmd As New OleDb.OleDbCommand("Insert into produit (`Article`,`Catégories`,`Types`,`Prix`,`Quantité`) values(@Nom,@Catégories,@Types,@Prix,@Quantité)", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Article", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Catégories", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Types", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@Prix", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Quantité", TextBox4.Text)

                Poss = cmd.ExecuteNonQuery
                If Poss > 0 Then
                    MsgBox("Enregistrer la sauvegarde réussie !", vbInformation)
                Else
                    MsgBox("Manqué!!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
        loadingDatagridView()
        clear()
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        save()
    End Sub
    Sub clear()
        TextBox2.Text = "[ AUTO INCREMENT ]"
        TextBox1.Clear()
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        clear()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim clt = New Client
        clt.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim clt = New Client
        clt.Show()
        Me.Hide()
    End Sub
    Sub edite()
        Try
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("UPDATE Produit SET `Article`=@Article,`Catégories`=@Catégories,`Types`=@Types,`Prix`=@Prix,`Quantité`=@Quantité Where ID=@ID ", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Article", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Catégories", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@Types", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@Prix", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Quantité", TextBox4.Text)
            cmd.Parameters.AddWithValue("@ID", TextBox2.Text)
            Poss = cmd.ExecuteNonQuery
            If Poss > 0 Then
                MsgBox("Enregistrer la sauvegarde réussie !", vbInformation)
            Else
                MsgBox("Manqué!!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        loadingDatagridView()
        clear()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        edite()
    End Sub
    Sub delete()
        Try

            If MsgBox("Êtes-vous sûr de supprimer cet enregistrement!!?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                Dim cmd As New OleDb.OleDbCommand("Delete from Produit Where ID=@ID", con)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@ID", TextBox2.Text)
                Poss = cmd.ExecuteNonQuery
                If Poss > 0 Then
                    MsgBox("Record Delete Success !", vbInformation)
                Else
                    MsgBox("Manqué!!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        loadingDatagridView()
        clear()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        delete()
    End Sub
    Sub search()
        Try
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from  Produit WHERE `Catégories` like '%" & ComboBox4.Text & "%' or `Types` like '%" & ComboBox4.Text & "%' ", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Article"), dr.Item("Catégories"), dr.Item("Types"), dr.Item("Prix"), dr.Item("Quantité"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        search()
    End Sub
    Sub searchee()
        Try
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from  Produit WHERE `Types` like '%" & ComboBox3.Text & "%' or `Types` like '%" & ComboBox3.Text & "%' ", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Article"), dr.Item("Catégories"), dr.Item("Types"), dr.Item("Prix"), dr.Item("Quantité"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        searchee
    End Sub
End Class

