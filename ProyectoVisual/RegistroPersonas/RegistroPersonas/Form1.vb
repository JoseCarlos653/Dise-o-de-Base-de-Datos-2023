Public Class Form1
    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        'FrmCiudad.Show()
        Dim frm As New FrmCiudad
        frm.MdiParent = Me
        frm.Show()


    End Sub


End Class
