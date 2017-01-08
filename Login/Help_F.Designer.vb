<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_F
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Main Menu")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Login")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Main Menu")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lihat Profil")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mencari Angggota")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Input Anggota")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pinjaman")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Simulasi Kredit")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Simpanan")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sistem", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help_F))
        Me.treeHelp = New System.Windows.Forms.TreeView()
        Me.wbView = New System.Windows.Forms.WebBrowser()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.PbGp = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbGp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeHelp
        '
        Me.treeHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.treeHelp.Location = New System.Drawing.Point(12, 130)
        Me.treeHelp.Name = "treeHelp"
        TreeNode1.Name = "nMainMenu"
        TreeNode1.Text = "Main Menu"
        TreeNode2.Name = "nLogin"
        TreeNode2.Text = "Login"
        TreeNode3.Name = "nMenuUtama"
        TreeNode3.Text = "Main Menu"
        TreeNode4.Name = "nProfil"
        TreeNode4.Text = "Lihat Profil"
        TreeNode5.Name = "nCari_Anggota"
        TreeNode5.Text = "Mencari Angggota"
        TreeNode6.Name = "NInput_Anggota"
        TreeNode6.Text = "Input Anggota"
        TreeNode7.Name = "NPinjaman"
        TreeNode7.Text = "Pinjaman"
        TreeNode8.Name = "nSimulasi"
        TreeNode8.Text = "Simulasi Kredit"
        TreeNode9.Name = "nSimpanan"
        TreeNode9.Text = "Simpanan"
        TreeNode10.Name = "nSistem"
        TreeNode10.Text = "Sistem"
        Me.treeHelp.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode10})
        Me.treeHelp.Size = New System.Drawing.Size(196, 274)
        Me.treeHelp.TabIndex = 3
        '
        'wbView
        '
        Me.wbView.Location = New System.Drawing.Point(214, 130)
        Me.wbView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbView.Name = "wbView"
        Me.wbView.Size = New System.Drawing.Size(948, 464)
        Me.wbView.TabIndex = 4
        '
        'pbLogo
        '
        Me.pbLogo.Location = New System.Drawing.Point(12, 5)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(1158, 119)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 5
        Me.pbLogo.TabStop = False
        '
        'PbGp
        '
        Me.PbGp.Location = New System.Drawing.Point(12, 387)
        Me.PbGp.Name = "PbGp"
        Me.PbGp.Size = New System.Drawing.Size(196, 207)
        Me.PbGp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbGp.TabIndex = 6
        Me.PbGp.TabStop = False
        '
        'Help_F
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1028, 582)
        Me.Controls.Add(Me.PbGp)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.wbView)
        Me.Controls.Add(Me.treeHelp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Help_F"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manual"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbGp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treeHelp As System.Windows.Forms.TreeView
    Friend WithEvents wbView As System.Windows.Forms.WebBrowser
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PbGp As System.Windows.Forms.PictureBox
End Class
