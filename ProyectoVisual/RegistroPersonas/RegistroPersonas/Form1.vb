Public Class Form1
    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        'FrmCiudad.Show()
        Dim frm As New FrmCiudad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem1.Click
        Dim frm As New FrmPersonas
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
