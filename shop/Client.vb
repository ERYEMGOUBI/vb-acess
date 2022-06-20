Imports System.Data.OleDb
Imports System.IO

Public Class Client
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Desktop\shop\loginform.mdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Dim da1 As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter("select * from Client", con)
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
        Dim log = New Login
        log.Show()
        Me.Hide()
    End Sub



    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LoginformDataSet3.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ClientTableAdapter1.Fill(Me.LoginformDataSet3.Client)
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
            Dim cmd As New OleDb.OleDbCommand("Select * from Client", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Nom"), dr.Item("Téléphone"), dr.Item("Adresse"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()








    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub



    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value

    End Sub
    Sub edit()
        Try
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("UPDATE   Client SET `Nom`=@Nom,`Téléphone`=@Téléphone,`Adresse`=@Adresse  Where ID=@ID ", con)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@Nom", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Téléphone", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Adresse", TextBox4.Text)
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
        edit()
    End Sub
    Sub clear()
        TextBox2.Text = "[ AUTO INCREMENT ]"
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        clear()

    End Sub
    Sub save()
        Try


            If TextBox1.Text = "" Then
                MsgBox("Vous devez saisir Nom !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Attention")
                TextBox1.Focus()

            ElseIf TextBox3.Text = "" Then
                MsgBox("Vous devez saisir Téléphone !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "attention")
                TextBox3.Focus()
            ElseIf TextBox4.Text = "" Then
                MsgBox("Vous devez saisir Adresse !", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "attention")
                TextBox4.Focus()
            ElseIf MsgBox("Êtes-vous sûr d'insérer cet enregistrement", vbQuestion + vbYesNo) = vbYes Then

                con.Open()
                Dim cmd As New OleDb.OleDbCommand("Insert into Client (`Nom`,`Téléphone`,`Adresse`) values(@Nom,@Téléphone,@Adresse)", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nom", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Téléphone", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Adresse`", TextBox4.Text)

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
    Sub Delete()
        Try

            If MsgBox("Êtes-vous sûr de supprimer cet enregistrement", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                Dim cmd As New OleDb.OleDbCommand("Delete from Client Where ID=@ID", con)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@ID", TextBox2.Text)
                Poss = cmd.ExecuteNonQuery
                If Poss > 0 Then
                    MsgBox("Enregistrer la suppression réussie !", vbInformation)
                Else
                    MsgBox("Manqué !!", vbCritical)
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
        Delete()
    End Sub
    Sub search()
        Try
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from  Client WHERE `Nom` like '%" & TextBox5.Text & "%' or `Nom` like '%" & TextBox5.Text & "%' ", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Nom"), dr.Item("Téléphone"), dr.Item("Adresse"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub



    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        search()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim pro = New Products
        pro.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim pro = New Products
        pro.Show()
        Me.Hide()
    End Sub


End Class
