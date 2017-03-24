Public Class Payment

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ErrorProvider1.SetError(TextBox1, "Insert a number then Press Enter")
        GroupBox1.Text = "Invoice :"
    End Sub
    Dim k As Integer
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label2.Visible = True
        Label6.Visible = True
        Label3.Visible = True
        Label5.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label4.Visible = False
        TextBox1.Visible = False
        Label2.Text = "Total Cost : " & RG
        Label6.Text = "Cash : " & RG
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim u As Integer
        If (e.KeyCode = Keys.Enter) Then
            u = TextBox1.Text
            If (u <= 0) Then
                MsgBox("Insert a good number!!")
                TextBox1.ResetText()
            Else
                Label8.Text = "Every Payment is : " & RG / u
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As DialogResult
        r = MsgBox("Do you want to save your Invoice ?", MsgBoxStyle.OkCancel)
        If (r = DialogResult.OK) Then
            SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
            SaveFileDialog1.Title = "Save a File"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim w As New IO.StreamWriter(SaveFileDialog1.FileName)
                Dim i As Integer
                w.WriteLine("Welcome To JOF- Shop Clothing for Women")
                w.WriteLine("Invoice Number :" & CInt(Math.Ceiling(Rnd() * 1500)) + 1)
                w.WriteLine(DateTime.Now.ToString())
                For i = 0 To ListBox1.Items.Count - 1
                    w.WriteLine(ListBox1.Items(i).ToString)
                Next
                w.WriteLine("")
                w.WriteLine("For Any Help - Call : 054-3414438")
                w.WriteLine("Thank You :)")
                w.Close()
                MsgBox("Your invoice has been saved")
                Me.Dispose()
                ShopClothingforWomen.Dispose()
                Sarigim.Dispose()
                Simloot.Dispose()
                Shoes.Dispose()
                Accessiores.Dispose()
                Jeans.Dispose()
            Else
                Me.Dispose()
                ShopClothingforWomen.Dispose()
                Sarigim.Dispose()
                Simloot.Dispose()
                Shoes.Dispose()
                Accessiores.Dispose()
                Jeans.Dispose()
            End If
        Else
            Me.Dispose()
            ShopClothingforWomen.Dispose()
            Sarigim.Dispose()
            Simloot.Dispose()
            Shoes.Dispose()
            Accessiores.Dispose()
            Jeans.Dispose()
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label5.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label4.Visible = True
        TextBox1.Visible = True
        Label2.Visible = False
        Label6.Visible = False
        Label3.Visible = False
        Label5.Text = "Total Cost : " & RG
    End Sub

    Public RG As Integer = (Sarigim.sum + Simloot.sum + Shoes.sum + Jeans.sum + Accessiores.sum)

End Class