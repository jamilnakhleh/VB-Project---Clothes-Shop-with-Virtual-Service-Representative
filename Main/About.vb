Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel3.Text = "ORT" & Environment.NewLine & "BRAUDE"
        WebBrowser1.MaximumSize = Me.MaximumSize

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("https://www.facebook.com/showntwk")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("https://www.facebook.com/fares7110")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("http://www.braude.ac.il/")
    End Sub
End Class