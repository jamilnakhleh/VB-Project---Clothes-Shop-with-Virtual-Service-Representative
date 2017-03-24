Imports System.Drawing.Drawing2D
Public Class RoundButton

    Inherits Button


    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)


        Dim grPath As GraphicsPath = New GraphicsPath()


        grPath.AddEllipse(0, 0, ClientSize.Width - 4, ClientSize.Height)


        Me.Region = New Region(grPath)


        MyBase.OnPaint(e)
        Me.Region = New Region(grPath)

    End Sub

End Class
