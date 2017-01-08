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
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Txt_Nm2 = New System.Windows.Forms.TextBox()
        Me.Txt_ID2 = New System.Windows.Forms.TextBox()
        Me.Btn_Selesai = New System.Windows.Forms.Button()
        Me.Btn_Cari = New System.Windows.Forms.Button()
        Me.Lbl_Nm2 = New System.Windows.Forms.Label()
        Me.Lbl_NIK2 = New System.Windows.Forms.Label()
        Me.Grp_CariAnggota.SuspendLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grp_CariAnggota
        '
        Me.Grp_CariAnggota.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Grp_CariAnggota.Controls.Add(Me.DG1)
        Me.Grp_CariAnggota.Controls.Add(Me.Txt_Nm2)
        Me.Grp_CariAnggota.Controls.Add(Me.Txt_ID2)
        Me.Grp_CariAnggota.Controls.Add(Me.Btn_Selesai)
        Me.Grp_CariAnggota.Controls.Add(Me.Btn_Cari)
        Me.Grp_CariAnggota.Controls.Add(Me.Lbl_Nm2)
        Me.Grp_CariAnggota.Controls.Add(Me.Lbl_NIK2)
        Me.Grp_CariAnggota.Location = New System.Drawing.Point(15, 15)
        Me.Grp_CariAnggota.Name = "Grp_CariAnggota"
        Me.Grp_CariAnggota.Size = New System.Drawing.Size(363, 324)
        Me.Grp_CariAnggota.TabIndex = 0
        Me.Grp_CariAnggota.TabStop = False
        Me.Grp_CariAnggota.Text = "Mencari Anggota Koperasi"
        '
        'DG1
        '
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(14, 100)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(331, 206)
        Me.DG1.TabIndex = 6
        '
        'Txt_Nm2
        '
        Me.Txt_Nm2.Location = New System.Drawing.Point(158, 45)
        Me.Txt_Nm2.Name = "Txt_Nm2"
        Me.Txt_Nm2.Size = New System.Drawing.Size(188, 20)
        Me.Txt_Nm2.TabIndex = 5
        '
        'Txt_ID2
        '
        Me.Txt_ID2.Location = New System.Drawing.Point(158, 19)
        Me.Txt_ID2.Name = "Txt_ID2"
        Me.Txt_ID2.Size = New System.Drawing.Size(102, 20)
        Me.Txt_ID2.TabIndex = 4
        '
        'Btn_Selesai
        '
        Me.Btn_Selesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Selesai.ForeColor = System.Drawing.Color.White
        Me.Btn_Selesai.Location = New System.Drawing.Point(271, 71)
        Me.Btn_Selesai.Name = "Btn_Selesai"
        Me.Btn_Selesai.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Selesai.TabIndex = 3
        Me.Btn_Selesai.Text = "&Keluar"
        Me.Btn_Selesai.UseVisualStyleBackColor = False
        '
        'Btn_Cari
        '
        Me.Btn_Cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cari.ForeColor = System.Drawing.Color.White
        Me.Btn_Cari.Location = New System.Drawing.Point(158, 71)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cari.TabIndex = 2
        Me.Btn_Cari.Text = "&Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = False
        '
        'Lbl_Nm2
        '
        Me.Lbl_Nm2.AutoSize = True
        Me.Lbl_Nm2.Location = New System.Drawing.Point(73, 48)
        Me.Lbl_Nm2.Name = "Lbl_Nm2"
        Me.Lbl_Nm2.Size = New System.Drawing.Size(77, 13)
        Me.Lbl_Nm2.TabIndex = 1
        Me.Lbl_Nm2.Text = "Nama             :"
        '
        'Lbl_NIK2
        '
        Me.Lbl_NIK2.AutoSize = True
        Me.Lbl_NIK2.Location = New System.Drawing.Point(73, 22)
        Me.Lbl_NIK2.Name = "Lbl_NIK2"
        Me.Lbl_NIK2.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_NIK2.TabIndex = 0
        Me.Lbl_NIK2.Text = "&NIK                :"
        '
        'Cari_Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(456, 356)
        Me.Controls.Add(Me.Grp_CariAnggota)
        Me.Name = "Cari_Anggota"
        Me.Text = " "
        Me.Grp_CariAnggota.ResumeLayout(False)
        Me.Grp_CariAnggota.PerformLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grp_CariAnggota As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_NIK2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Nm2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ID2 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Selesai As System.Windows.Forms.Button
    Friend WithEvents Btn_Cari As System.Windows.Forms.Button
    Friend WithEvents Lbl_Nm2 As System.Windows.Forms.Label
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
End Class
