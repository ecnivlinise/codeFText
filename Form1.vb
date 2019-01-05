Public Class Form1

    Private Sub SauvegarderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SauvegarderToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = 1 Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
        Me.Text = (SaveFileDialog1.FileName + " - CodeF Text 2018.1")
        FlatStatusBar1.Text = ("Fichier enregistré à " + Now().ToString("HH:mm"))
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = 1 Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
        Me.Text = (OpenFileDialog1.FileName + " - CodeF Text 2018.1")
    End Sub

    Private Sub PoliceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PoliceToolStripMenuItem.Click
        If FontDialog1.ShowDialog = 1 Then
            RichTextBox1.Font = (FontDialog1.Font)
        End If
    End Sub

    Private Sub CouleurDePoliceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CouleurDePoliceToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = 1 Then
            RichTextBox1.ForeColor = (ColorDialog1.Color)
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Form2.Close()
    End Sub

    Private Sub TestWebToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestWebToolStripMenuItem.Click

    End Sub
End Class
