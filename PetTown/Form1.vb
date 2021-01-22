Imports System.IO
Imports System.Text
Imports System.Net


Public Class Form1

    Dim username = "testuser"
    Dim requesturl = "https://pettown-server.ckaecore.repl.co/"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim address As String = requesturl + "getXPos?username=" + username
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(address)

        Dim address2 As String = requesturl + "getYPos?username=" + username
        Dim client2 As WebClient = New WebClient()
        Dim reply2 As String = client2.DownloadString(address2)


        PictureBox1.Location = New Point(reply, reply2)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim address As String = requesturl + "setPos?username=" + username + "&x=" + PictureBox1.Location.X.ToString() + "&y=" + PictureBox1.Location.Y.ToString()
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(address)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Left Then

            PictureBox1.Location = New Point(PictureBox1.Location.X - 5, PictureBox1.Location.Y)

        End If

        If e.KeyCode = Keys.Right Then

            PictureBox1.Location = New Point(PictureBox1.Location.X + 5, PictureBox1.Location.Y)

        End If


        If e.KeyCode = Keys.Up Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - 5)

        End If
        If e.KeyCode = Keys.Down Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 5)

        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim address As String = requesturl + "getMoney?username=" + username
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(address)
        Label1.Text = "Money: $" + reply
    End Sub


    Private Sub Timer4_tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim address As String = requesturl + "getRank?username=" + username
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(address)
        Label2.Text = "Rank:" + reply
    End Sub


    Private Sub Timer5_tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim address As String = requesturl + "getAcc?username=" + username
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(address)
        Label3.Text = "" + reply
    End Sub
End Class

