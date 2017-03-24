Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Speech.AudioFormat
Imports System.Speech.Recognition
Public Class Accessiores
    Public sum As Double = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
    Public c0 As Integer = 15
    Public c1 As Integer = 15
    Public c2 As Integer = 15
    Public c3 As Integer = 15
    Public c4 As Integer = 15
    Public c5 As Integer = 15
    Public c6 As Integer = 15
    Public c7 As Integer = 15
    Public p0 As Integer = 50
    Public p1 As Integer = 60
    Public p2 As Integer = 99
    Public p3 As Integer = 100
    Public p4 As Integer = 150
    Public p5 As Integer = 120
    Public p6 As Integer = 140
    Public p7 As Integer = 230

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Payment.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                PictureBox1.Image = ImageList1.Images.Item(0)
                Label1.Text = "Price : " & p0
                Label2.Text = "Count for shop this product : " & c0
            Case 1
                PictureBox1.Image = ImageList1.Images.Item(1)
                Label1.Text = "Price : " & p1
                Label2.Text = "Count for shop this product : " & c1
            Case 2
                PictureBox1.Image = ImageList1.Images.Item(2)
                Label1.Text = "Price : " & p2
                Label2.Text = "Count for shop this product : " & c2
            Case 3
                PictureBox1.Image = ImageList1.Images.Item(3)
                Label1.Text = "Price : " & p3
                Label2.Text = "Count for shop this product : " & c3
            Case 4
                PictureBox1.Image = ImageList1.Images.Item(4)
                Label1.Text = "Price : " & p4
                Label2.Text = "Count for shop this product : " & c4
            Case 5
                PictureBox1.Image = ImageList1.Images.Item(5)
                Label1.Text = "Price : " & p5
                Label2.Text = "Count for shop this product : " & c5
            Case 6
                PictureBox1.Image = ImageList1.Images.Item(6)
                Label1.Text = "Price : " & p6
                Label2.Text = "Count for shop this product : " & c6
            Case 7
                PictureBox1.Image = ImageList1.Images.Item(7)
                Label1.Text = "Price : " & p7
                Label2.Text = "Count for shop this product : " & c7
        End Select

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                If c0 > 0 Then
                    c0 = c0 - 1
                    Label2.Text = "Count for shop this product : " & c0
                    sum = sum + p0
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p0)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 1
                If c1 > 0 Then
                    c1 = c1 - 1
                    Label2.Text = "Count for shop this product : " & c1
                    sum = sum + p1
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p1)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 2
                If c2 > 0 Then
                    c2 = c2 - 1
                    Label2.Text = "Count for shop this product : " & c2
                    sum = sum + p2
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p2)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 3
                If c3 > 0 Then
                    c3 = c3 - 1
                    Label2.Text = "Count for shop this product : " & c3
                    sum = sum + p3
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p3)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 4
                If c4 > 0 Then
                    c4 = c4 - 1
                    Label2.Text = "Count for shop this product : " & c4
                    sum = sum + p4
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p4)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 5
                If c5 > 0 Then
                    c5 = c5 - 1
                    Label2.Text = "Count for shop this product : " & c5
                    sum = sum + p5
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p5)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 6
                If c6 > 0 Then
                    c6 = c6 - 1
                    Label2.Text = "Count for shop this product : " & c6
                    sum = sum + p6
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p6)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 7
                If c7 > 0 Then
                    c7 = c7 - 1
                    Label2.Text = "Count for shop this product : " & c7
                    sum = sum + p7
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & Payment.RG
                    Payment.ListBox1.Items.Add("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p7)
                Else
                    Label2.Text = "Sorry!Count for shop this product is Finished!"
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
        End Select
    End Sub
    Dim speaker As New SpeechSynthesizer
    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Private Sub Accessiores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Total Cost :" & Payment.RG
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim orders As New Recognition.SrgsGrammar.SrgsRule("orders")
        Dim grammars As New Recognition.SrgsGrammar.SrgsOneOf("List", "Like", "remove", "checkout", "next", "back", "Home", "close")
        speaker.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult)
        reco.SetInputToDefaultAudioDevice()
        orders.Add(grammars)
        gram.Rules.Add(orders)
        gram.Root = orders
        reco.LoadGrammar(New Recognition.Grammar(gram))
        ServiceRepresentativeToolStripMenuItem_Click(sender, e)
    End Sub
    Dim i As Integer = 0
    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Select Case e.Result.Text
            Case "List"
                ComboBox1.DroppedDown = True

            Case "Like"
                Button2_Click(sender, e)

            Case "remove"
                Button4_Click(sender, e)

            Case "checkout"
                Payment.ShowDialog()

            Case "next"
                If (ComboBox1.DroppedDown = True) Then
                    ComboBox1.SelectedIndex = i
                    i = i + 1
                End If

            Case "back"
                If (ComboBox1.DroppedDown = True) Then
                    ComboBox1.SelectedIndex = i
                    i = i - 1
                End If

            Case "close"
                Me.Hide()

        End Select

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                If c0 < 15 Then
                    c0 = c0 + 1
                    Label2.Text = "Count for shop this product : " & c0
                    sum = sum - p0
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p0)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 1
                If c1 < 15 Then
                    c1 = c1 + 1
                    Label2.Text = "Count for shop this product : " & c1
                    sum = sum - p1
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p1)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 2
                If c2 < 15 Then
                    c2 = c2 + 1
                    Label2.Text = "Count for shop this product : " & c2
                    sum = sum - p2
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p2)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 3
                If c3 < 15 Then
                    c3 = c3 + 1
                    Label2.Text = "Count for shop this product : " & c3
                    sum = sum - p3
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p3)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 4
                If c4 < 15 Then
                    c4 = c4 + 1
                    Label2.Text = "Count for shop this product : " & c4
                    sum = sum - p4
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p4)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 5
                If c5 < 15 Then
                    c5 = c5 + 1
                    Label2.Text = "Count for shop this product : " & c5
                    sum = sum - p5
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p5)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 6
                If c6 < 15 Then
                    c6 = c6 + 1
                    Label2.Text = "Count for shop this product : " & c6
                    sum = sum - p6
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p6)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
            Case 7
                If c7 < 15 Then
                    c7 = c7 + 1
                    Label2.Text = "Count for shop this product : " & c7
                    sum = sum - p7
                    Payment.RG = sum + Simloot.sum + Shoes.sum + Jeans.sum + Sarigim.sum
                    Label3.Text = "Total Cost :" & (Payment.RG)
                    Payment.ListBox1.Items.Remove("מוצר : " & ComboBox1.Items.Item(ComboBox1.SelectedIndex) & " - " & " מחיר :" & p7)
                Else
                    Label3.Text = "Total Cost :" & Payment.RG
                End If
        End Select
    End Sub

    Private Sub ServiceRepresentativeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceRepresentativeToolStripMenuItem.Click
        reco.RecognizeAsync(5)
    End Sub

    Private Sub OFFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFToolStripMenuItem.Click
        reco.RecognizeAsyncStop()
    End Sub

    Private Sub Accessiores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        OFFToolStripMenuItem_Click(sender, e)
    End Sub
End Class