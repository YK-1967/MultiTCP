Public Class FrmMDI
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientToolStripMenuItem.Click
        Dim FrmClient As New FrmClient
        FrmClient.MdiParent = Me
        FrmClient.Show()
    End Sub

    Private Sub ServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerToolStripMenuItem.Click
        Dim frmListen As New FrmListen
        frmListen.MdiParent = Me
        frmListen.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons)
    End Sub
End Class
