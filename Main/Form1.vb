Imports System.Speech.Synthesis
Public Class Form1
    Dim speaker As New SpeechSynthesizer
    Dim y1 As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.BalloonTipTitle = "Welcome to JOF"
        NotifyIcon1.BalloonTipText = "This is my visual basic project,enjoy :)"
        NotifyIcon1.ShowBalloonTip(2000)
        speaker.Speak("Hello and Welcome to JOF - A Shop Clothing for Women!")
    End Sub
    Dim username, password As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Location = New Point(Label1.Location.X + 10, Label1.Location.Y)
        If Label1.Location.X > Me.Width Then
            Label1.Location = New Point(0 - Label1.Width, Label1.Location.Y)
        End If
    End Sub

    Private Sub TextBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox4.Text = ""


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox2.Text = ""

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub
    Dim count As Integer = 0

    Dim k As Integer = 0
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim arr1(100) As String
    Dim arr2(100) As String
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Dim onoff As Integer = 0
    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (onoff = 0) Then
            TextBox3.Visible = True
            TextBox4.Visible = True
            Button2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            onoff = 1
        ElseIf (onoff = 1) Then
            TextBox3.Visible = False
            TextBox4.Visible = False
            Button2.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            onoff = 0
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim str1() As String
    Dim str2() As String
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("UserName/Password is not correct!", MsgBoxStyle.Information)

        ElseIf TextBox1.Text = "Jamil" And TextBox2.Text = "Nakhleh" Then
            ShopClothingforWomen.ShowDialog()
            y = y + 1
            TextBox1.ResetText()
            TextBox2.ResetText()
        Else
            For i = 0 To arr1.Length - 1
                If TextBox1.Text = arr1(i) Then
                    x = 1
                End If
            Next
            For i = 0 To arr2.Length - 1
                If TextBox2.Text = arr2(i) Then
                    y = 1
                End If
            Next
            If (x = 1 And y = 1) Then
                x = 0
                y = 0
                ShopClothingforWomen.ShowDialog()
                y = y + 1
                TextBox1.ResetText()
                TextBox2.ResetText()
            ElseIf x <> 1 Or y <> 1 Then
                MsgBox("UserName/Password is not correct!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover

    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
    End Sub

    Private Sub AboutToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim i As Integer
        For i = 0 To arr1.Length - 1
            If TextBox3.Text = arr1(i) Or TextBox3.Text = "Jamil" Then
                k = 1
            End If
        Next
        If (k = 1) Then
            k = 0
            MsgBox("ERROR!" & Environment.NewLine & "We have the same username!,Choose another UserName", MsgBoxStyle.Information)
            count = count - 1
        ElseIf (k = 0) Then
            arr1(count) = TextBox3.Text
            arr2(count) = TextBox4.Text
            count = count + 1
            MsgBox("User Created!" & Environment.NewLine & "Thank you for signing up With JOF")
        End If
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox3.Visible = False
        TextBox4.Visible = False
        Button2.Visible = False
        Label4.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub TextBox1_TextAlignChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextAlignChanged
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Label6.Visible = True
        If (TextBox3.Text = "Jamil" Or arr1.Contains(TextBox3.Text)) Then
            Label6.Text = TextBox3.Text & " is already a JOF account."
            Label6.ForeColor = Color.Red
        ElseIf TextBox3.Text = "" Then
            Label6.Text = ""
        Else
            Label6.Text = TextBox3.Text & " is available."
            Label6.ForeColor = Color.Green
        End If
    End Sub
End Class
