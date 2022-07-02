Imports System.Data.OleDb
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class FACTURATION
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
        Dim log = New Utilisateure
        log.Show()
        Me.Hide()
    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Dim dr As OleDbDataReader
    Dim Poss As Integer
    Private Sub ProduitDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProduitDGV.CellContentClick
        TextBox1.Text = ProduitDGV.CurrentRow.Cells(1).Value
        TextBox4.Text = ProduitDGV.CurrentRow.Cells(4).Value

    End Sub


    Dim N1, N2, somme As Double

    Sub save()
        Try
            N1 = Val(TextBox2.Text)
            N2 = Val(TextBox4.Text)
            somme = N1 * N2
            TextBox5.Text = somme



            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Insert into Facturation (`Produit`,`Prix`,`Quantité`,`Total`) values(@Produit,@Prix,@Quantité,@Total)", con)
            cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Produit", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Prix", TextBox4.Text)
            cmd.Parameters.AddWithValue("@Quantité`", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Total`", TextBox5.Text)

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

        clear()
        updat()
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        save
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""

        TextBox4.Text = ""
        TextBox5.Text = "000.00"
    End Sub
    Sub loadReport()

        Try
            con.Open()
            Dim ds As New DataSet
            Dim da As New OleDb.OleDbDataAdapter

            da.SelectCommand = New OleDbCommand("select * from Facturation", con)
            da.SelectCommand.Parameters.Clear()
            da.Fill(ds, "DataTable")

            Dim rpt As New CrystalReport3
            rpt.Load(Application.StartupPath & "C:\Users\hp\Desktop\shop\shop\CrystalReport3.rpt")
            rpt.SetDataSource(ds.Tables("DataTable"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        loadReport()
    End Sub


    Dim cltkey = 0
    Private Sub updat()
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