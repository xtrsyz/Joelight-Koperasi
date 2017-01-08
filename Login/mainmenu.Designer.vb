<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterAnggotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSimpanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterPinjamanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulasiKreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanSimpananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPinjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.SuzukiLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(538, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterAnggotaToolStripMenuItem1, Me.MasterSimpanaToolStripMenuItem, Me.MasterPinjamanToolStripMenuItem1, Me.SimulasiKreditToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MasterAnggotaToolStripMenuItem1
        '
        Me.MasterAnggotaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputAnggotaToolStripMenuItem, Me.CariAnggotaToolStripMenuItem, Me.ShowProfileToolStripMenuItem})
        Me.MasterAnggotaToolStripMenuItem1.Name = "MasterAnggotaToolStripMenuItem1"
        Me.MasterAnggotaToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.MasterAnggotaToolStripMenuItem1.Text = "Master Anggota"
        '
        'InputAnggotaToolStripMenuItem
        '
        Me.InputAnggotaToolStripMenuItem.Name = "InputAnggotaToolStripMenuItem"
        Me.InputAnggotaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.InputAnggotaToolStripMenuItem.Text = "Input Anggota"
        '
        'CariAnggotaToolStripMenuItem
        '
        Me.CariAnggotaToolStripMenuItem.Name = "CariAnggotaToolStripMenuItem"
        Me.CariAnggotaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CariAnggotaToolStripMenuItem.Text = "Cari Anggota"
        '
        'ShowProfileToolStripMenuItem
        '
        Me.ShowProfileToolStripMenuItem.Name = "ShowProfileToolStripMenuItem"
        Me.ShowProfileToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ShowProfileToolStripMenuItem.Text = "Lihat Profile"
        '
        'MasterSimpanaToolStripMenuItem
        '
        Me.MasterSimpanaToolStripMenuItem.Name = "MasterSimpanaToolStripMenuItem"
        Me.MasterSimpanaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MasterSimpanaToolStripMenuItem.Text = "Master Simpanan"
        '
        'MasterPinjamanToolStripMenuItem1
        '
        Me.MasterPinjamanToolStripMenuItem1.Name = "MasterPinjamanToolStripMenuItem1"
        Me.MasterPinjamanToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.MasterPinjamanToolStripMenuItem1.Text = "Master Pinjaman"
        '
        'SimulasiKreditToolStripMenuItem
        '
        Me.SimulasiKreditToolStripMenuItem.Name = "SimulasiKreditToolStripMenuItem"
        Me.SimulasiKreditToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SimulasiKreditToolStripMenuItem.Text = "Simulasi Kredit"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanSimpananToolStripMenuItem, Me.LaporanPinjamanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan "
        '
        'LaporanSimpananToolStripMenuItem
        '
        Me.LaporanSimpananToolStripMenuItem.Name = "LaporanSimpananToolStripMenuItem"
        Me.LaporanSimpananToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LaporanSimpananToolStripMenuItem.Text = "Laporan Simpanan"
        '
        'LaporanPinjamanToolStripMenuItem
        '
        Me.LaporanPinjamanToolStripMenuItem.Name = "LaporanPinjamanToolStripMenuItem"
        Me.LaporanPinjamanToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LaporanPinjamanToolStripMenuItem.Text = "Laporan Pinjaman"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExitToolStripMenuItem.Text = "Keluar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(538, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.HelpToolStripMenuItem.Text = "Bantuan"
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(538, 350)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainmenu"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterAnggotaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CariAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterSimpanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterPinjamanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimulasiKreditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanSimpananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPinjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
