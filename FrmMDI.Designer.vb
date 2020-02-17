<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(391, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem, Me.ClientToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.ToolStripMenuItem1.Text = "TCP"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile Vertical"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "Arrange Icons"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 247)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As ToolStripMenuItem
End Class
