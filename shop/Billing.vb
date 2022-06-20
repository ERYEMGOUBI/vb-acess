Imports System.Data.OleDb
Imports System.IO
Public Class Billing
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Desktop\shop\loginform.mdb")
    Private Sub displayProducts()
        con.Open()
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
        ds = New DataSet

        con.Close()
    End Sub
    Private Sub displayClient()
        con.Open()
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

        con.Close()

    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim log = New Login
        log.Show()
        Me.Hide()
    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LoginformDataSet12.Facturation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.FacturationTableAdapter1.Fill(Me.LoginformDataSet12.Facturation)
        displayClient()
        displayProducts()
    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Me.ProduitTableAdapter.Fill(Me.LoginformDataSet6.Produit)
        Me.ClientTableAdapter.Fill(Me.LoginformDataSet7.Client)
    End Sub
    Private Sub CltDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CltDGV.CellContentClick

        TextBox3.Text = CltDGV.CurrentRow.Cells(1).Value
    End Sub
    Dim key = 0, stock = 0
    Private Sub ProduitDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProduitDGV.CellContentClick
        TextBox1.Text = ProduitDGV.CurrentRow.Cells(1).Value
        TextBox4.Text = ProduitDGV.CurrentRow.Cells(4).Value

    End Sub
    Dim dr As OleDbDataReader
    Sub loadingDatagridView()
        Try
            BillDGV.Rows.Clear()
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from Facturation", con)
            dr = cmd.ExecuteReader
            While dr.Read
                BillDGV.Rows.Add(dr.Item("ID"), dr.Item("Produit"), dr.Item("Prix"), dr.Item("quantité"), dr.Item("Total"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()


    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If TextBox2.Text = "" Then
            MsgBox("Vous devez entrer la quantité!!! ")
        ElseIf TextBox4.Text = " " Then
            MsgBox("Vous devez entrer le prix !!!")

        Else


            Dim runm As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(TextBox2.Text) * Convert.ToInt32(TextBox4.Text)
            BillDGV.Rows.Item(runm).Cells("coulmn1").Value = i
            BillDGV.Rows.Item(runm).Cells("coulmn2").Value = TextBox1.Text
            BillDGV.Rows.Item(runm).Cells("coulmn3").Value = TextBox4.Text
            BillDGV.Rows.Item(runm).Cells("coulmn4").Value = TextBox2.Text
            BillDGV.Rows.Item(runm).Cells("coulmn5").Value = total
            Grdtot = Grdtot + total
            Dim tot As String
            tot = "sold " + Convert.ToString(Grdtot)
            Label8.Text = tot


            reset()
        update()


        End If

    End Sub
    Sub reset()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        key = 0
        cltkey = 0

    End Sub
    Dim i = 0, Grdtot = 0

    Dim cltkey = 0
    Private Sub update()
        Try
            Dim newqty = stock - Convert.ToInt32(TextBox2.Text)
            con.Open()
            Dim query = "UPDATE  Facturation SET Quantité" & newqty & " where ID" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            'msgbox("l'article modifer ")
            con.Close()
            displayProducts()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class