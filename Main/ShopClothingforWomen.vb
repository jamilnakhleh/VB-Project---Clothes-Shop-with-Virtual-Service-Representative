Imports System.Speech.Synthesis
Public Class ShopClothingforWomen

    Private Sub ShopClothingforWomen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Welcome " & Form1.TextBox1.Text & " :)"

    End Sub

    Private Sub ShopClothingforWomen_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover

    End Sub
    Dim speaker As New SpeechSynthesizer()
    Private Sub PictureBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label1.Visible = True
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        Label2.Visible = True
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        Label3.Visible = True
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        Label4.Visible = True
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        Label5.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolTip1_Draw(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs)
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
        e.Graphics.DrawRectangle(Pens.LimeGreen, 0, e.Bounds.Height - 4, e.Bounds.Width, e.Bounds.Height - 4)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)
        Dim wid As Integer = e.ToolTipSize.Width + 50
        Dim hgt As Integer = e.ToolTipSize.Height
        If hgt < 50 Then hgt = 50
        e.ToolTipSize = New Size(wid, hgt)
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Dim checking As Integer = 0
    Private Sub SignOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutToolStripMenuItem.Click
        Dim r As DialogResult
        r = MsgBox("Are you sure you want to sign out ? ", MsgBoxStyle.OkCancel)
        If r = DialogResult.OK Then
            Me.Dispose()
            Simloot.Dispose()
            Sarigim.Dispose()
            Shoes.Dispose()
            Accessiores.Dispose()
            Jeans.Dispose()
            Payment.Dispose()
        End If
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ShopClothingforWomen_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Simloot.Dispose()
        Sarigim.Dispose()
        Shoes.Dispose()
        Accessiores.Dispose()
        Jeans.Dispose()
        Payment.Dispose()
    End Sub


    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave

    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.Visible = False
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.Visible = False
    End Sub

    Private Sub Label5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Label5.Visible = False
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Label4.Visible = False
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label2.Visible = False
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label3.Visible = False
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        Label4.Visible = False
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        Label5.Visible = False
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseHover

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Sarigim.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Simloot.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Accessiores.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Jeans.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Shoes.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        speaker.Speak("Choose the Category which you want !")
    End Sub
End Class