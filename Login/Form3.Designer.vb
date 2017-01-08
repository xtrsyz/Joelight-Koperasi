<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cari_Anggota
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
        Me.Grp_CariAnggota = New System.Windows.Forms.GroupBox()
        Me.Lbl_IDAnggota = New System.Windows.Forms.Label()
        Me.Lbl_NmAnggota = New System.Windows.Forms.Label()
        Me.Btn_Cari = New System.Windows.Forms.Button()
        Me.Btn_Selesai = New System.Windows.Forms.Button()
        Me.Txt_IDAnggota = New System.Windows.Forms.TextBox()
        Me.Txt_NmAnggota = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grp_CariAnggota.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grp_CariAnggota
        '
        Me.Grp_CariAnggota.Controls.Add(Me.DataGridView1)
        Me.Grp_CariAnggota.Controls.Add(Me.Txt_NmAnggota)
        Me.Grp_CariAnggota.Controls.Add(Me.Txt_IDAnggota)
        Me.Grp_CariAnggota.Controls.Add(Me.Btn_Selesai)
        Me.Grp_CariAnggota.Controls.Add(Me.Btn_Cari)
        Me.Grp_CariAnggota.Controls.Add(Me.Lbl_NmAnggota)
        Me.Grp_CariAnggota.Controls.Add(Me.Lbl_IDAnggota)
        Me.Grp_CariAnggota.Location = New System.Drawing.Point(15, 15)
        Me.Grp_CariAnggota.Name = "Grp_CariAnggota"
        Me.Grp_CariAnggota.Size = New System.Drawing.Size(590, 324)
        Me.Grp_CariAnggota.TabIndex = 0
        Me.Grp_CariAnggota.TabStop = False
        Me.Grp_CariAnggota.Text = "Mencari Anggota Koperasi"
        '
        'Lbl_IDAnggota
        '
        Me.Lbl_IDAnggota.AutoSize = True
        Me.Lbl_IDAnggota.Location = New System.Drawing.Point(72, 57)
        Me.Lbl_IDAnggota.Name = "Lbl_IDAnggota"
        Me.Lbl_IDAnggota.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_IDAnggota.TabIndex = 0
        Me.Lbl_IDAnggota.Text = "&ID Anggota"
        '
        'Lbl_NmAnggota
        '
        Me.Lbl_NmAnggota.AutoSize = True
        Me.Lbl_NmAnggota.Location = New System.Drawing.Point(72, 81)
        Me.Lbl_NmAnggota.Name = "Lbl_NmAnggota"
        Me.Lbl_NmAnggota.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_NmAnggota.TabIndex = 1
        Me.Lbl_NmAnggota.Text = "Nama"
        '
        'Btn_Cari
        '
        Me.Btn_Cari.Location = New System.Drawing.Point(91, 120)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cari.TabIndex = 2
        Me.Btn_Cari.Text = "&Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = True
        '
        'Btn_Selesai
        '
        Me.Btn_Selesai.Location = New System.Drawing.Point(184, 120)
        Me.Btn_Selesai.Name = "Btn_Selesai"
        Me.Btn_Selesai.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Selesai.TabIndex = 3
        Me.Btn_Selesai.Text = "&Selesai"
        Me.Btn_Selesai.UseVisualStyleBackColor = True
        '
        'Txt_IDAnggota
        '
        Me.Txt_IDAnggota.Location = New System.Drawing.Point(157, 50)
        Me.Txt_IDAnggota.Name = "Txt_IDAnggota"
        Me.Txt_IDAnggota.Size = New System.Drawing.Size(102, 20)
        Me.Txt_IDAnggota.TabIndex = 4
        '
        'Txt_NmAnggota
        '
        Me.Txt_NmAnggota.Location = New System.Drawing.Point(157, 76)
        Me.Txt_NmAnggota.Name = "Txt_NmAnggota"
        Me.Txt_NmAnggota.Size = New System.Drawing.Size(188, 20)
        Me.Txt_NmAnggota.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(549, 131)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Cari_Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 356)
        Me.Controls.Add(Me.Grp_CariAnggota)
        Me.Name = "Cari_Anggota"
        Me.Text = "Form3"
        Me.Grp_CariAnggota.ResumeLayout(False)
        Me.Grp_CariAnggota.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grp_CariAnggota As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_IDAnggota As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_NmAnggota As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IDAnggota As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Selesai As System.Windows.Forms.Button
    Friend WithEvents Btn_Cari As System.Windows.Forms.Button
    Friend WithEvents Lbl_NmAnggota As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
