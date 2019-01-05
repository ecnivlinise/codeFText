Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(Form1.SaveFileDialog1.FileName)
    End Sub
End Class