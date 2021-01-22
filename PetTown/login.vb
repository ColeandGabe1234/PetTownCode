Imports System.Net
Public Class login

    Dim requesturl = "https://pettown-server.ckaecore.repl.co/"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = TextBox1.Text
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim address2 As String = requesturl + "createUser?username=" + TextBox1.Text
        Dim client2 As WebClient = New WebClient()
        Dim reply2 As String = client2.DownloadString(address2)

        TextBox3.Text = TextBox1.Text
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class