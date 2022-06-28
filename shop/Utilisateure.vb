Imports System.Data.SqlClient
Imports System.Configuration
Public Class Utilisateure
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Veuillez entrer le champ obligatoire", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Desktop\shop\loginform.mdb"

            Try
                Dim sql As String = "SELECT * FROM Utilisateur WHERE USERNAME ='" & TextBox1.Text & "' AND PASSWORD ='" & TextBox2.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
                If sqlRead.Read() Then
                    Products.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Le nom d'utilisateur et le mot de passe ne correspondent pas!!", "Échec de l'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Text = ""
                    TextBox2.Text = ""

                    TextBox1.Focus()

                End If
            Catch ex As Exception
                MessageBox.Show("Échec de la connexion à la base de données..", "Erreur de connexion à la base de données ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim bill = New FACTURATION
        bill.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class