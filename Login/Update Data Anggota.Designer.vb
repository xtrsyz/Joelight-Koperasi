<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Data
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
        Me.Grp_Update = New System.Windows.Forms.GroupBox()
        Me.Txt_Dprt = New System.Windows.Forms.ComboBox()
        Me.txt_Passd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_gaji = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Tgl = New System.Windows.Forms.Label()
        Me.Dtp_Tgl = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Nm = New System.Windows.Forms.TextBox()
        Me.Txt_Ttl = New System.Windows.Forms.TextBox()
        Me.Lbl_Ttl = New System.Windows.Forms.Label()
        Me.Lbl_Dprt = New System.Windows.Forms.Label()
        Me.Txt_Notlp = New System.Windows.Forms.TextBox()
        Me.Txt_Almt = New System.Windows.Forms.TextBox()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Notlp = New System.Windows.Forms.Label()
        Me.Lbl_Almt = New System.Windows.Forms.Label()
        Me.Lbl_Nm = New System.Windows.Forms.Label()
        Me.Lbl_NIK = New System.Windows.Forms.Label()
        Me.Btn_Simpan = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Grp_Update.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_Update
        '
        Me.Grp_Update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Grp_Update.Controls.Add(Me.Txt_Dprt)
        Me.Grp_Update.Controls.Add(Me.txt_Passd)
        Me.Grp_Update.Controls.Add(Me.Label6)
        Me.Grp_Update.Controls.Add(Me.CheckBox1)
        Me.Grp_Update.Controls.Add(Me.Button1)
        Me.Grp_Update.Controls.Add(Me.txt_gaji)
        Me.Grp_Update.Controls.Add(Me.Label1)
        Me.Grp_Update.Controls.Add(Me.Lbl_Tgl)
        Me.Grp_Update.Controls.Add(Me.Dtp_Tgl)
        Me.Grp_Update.Controls.Add(Me.Txt_Nm)
        Me.Grp_Update.Controls.Add(Me.Txt_Ttl)
        Me.Grp_Update.Controls.Add(Me.Lbl_Ttl)
        Me.Grp_Update.Controls.Add(Me.Lbl_Dprt)
        Me.Grp_Update.Controls.Add(Me.Txt_Notlp)
        Me.Grp_Update.Controls.Add(Me.Txt_Almt)
        Me.Grp_Update.Controls.Add(Me.Txt_ID)
        Me.Grp_Update.Controls.Add(Me.Lbl_Notlp)
        Me.Grp_Update.Controls.Add(Me.Lbl_Almt)
        Me.Grp_Update.Controls.Add(Me.Lbl_Nm)
        Me.Grp_Update.Controls.Add(Me.Lbl_NIK)
        Me.Grp_Update.Location = New System.Drawing.Point(12, 12)
        Me.Grp_Update.Name = "Grp_Update"
        Me.Grp_Update.Size = New System.Drawing.Size(385, 315)
        Me.Grp_Update.TabIndex = 2
        Me.Grp_Update.TabStop = False
        Me.Grp_Update.Text = "Input Data Anggota Koperasi"
        '
        'Txt_Dprt
        '
        Me.Txt_Dprt.FormattingEnabled = True
        Me.Txt_Dprt.Items.AddRange(New Object() {"Departemen1", "Departemen2", "Departemen3", "Departemen4"})
        Me.Txt_Dprt.Location = New System.Drawing.Point(138, 191)
        Me.Txt_Dprt.Name = "Txt_Dprt"
        Me.Txt_Dprt.Size = New System.Drawing.Size(153, 21)
        Me.Txt_Dprt.TabIndex = 36
        '
        'txt_Passd
        '
        Me.txt_Passd.Location = New System.Drawing.Point(138, 269)
        Me.txt_Passd.Name = "txt_Passd"
        Me.txt_Passd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Passd.Size = New System.Drawing.Size(153, 20)
        Me.txt_Passd.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Password                    :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(309, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Admin?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(239, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Lihat"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_gaji
        '
        Me.txt_gaji.Location = New System.Drawing.Point(138, 217)
        Me.txt_gaji.Name = "txt_gaji"
        Me.txt_gaji.Size = New System.Drawing.Size(153, 20)
        Me.txt_gaji.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Gaji                              :"
        '
        'Lbl_Tgl
        '
        Me.Lbl_Tgl.AutoSize = True
        Me.Lbl_Tgl.Location = New System.Drawing.Point(12, 246)
        Me.Lbl_Tgl.Name = "Lbl_Tgl"
        Me.Lbl_Tgl.Size = New System.Drawing.Size(118, 13)
        Me.Lbl_Tgl.TabIndex = 22
        Me.Lbl_Tgl.Text = "Tanggal                       :"
        '
        'Dtp_Tgl
        '
        Me.Dtp_Tgl.Location = New System.Drawing.Point(138, 243)
        Me.Dtp_Tgl.Name = "Dtp_Tgl"
        Me.Dtp_Tgl.Size = New System.Drawing.Size(153, 20)
        Me.Dtp_Tgl.TabIndex = 21
        '
        'Txt_Nm
        '
        Me.Txt_Nm.Location = New System.Drawing.Point(138, 44)
        Me.Txt_Nm.Name = "Txt_Nm"
        Me.Txt_Nm.Size = New System.Drawing.Size(153, 20)
        Me.Txt_Nm.TabIndex = 13
        '
        'Txt_Ttl
        '
        Me.Txt_Ttl.Location = New System.Drawing.Point(138, 70)
        Me.Txt_Ttl.Name = "Txt_Ttl"
        Me.Txt_Ttl.Size = New System.Drawing.Size(232, 20)
        Me.Txt_Ttl.TabIndex = 12
        '
        'Lbl_Ttl
        '
        Me.Lbl_Ttl.AutoSize = True
        Me.Lbl_Ttl.Location = New System.Drawing.Point(11, 73)
        Me.Lbl_Ttl.Name = "Lbl_Ttl"
        Me.Lbl_Ttl.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_Ttl.TabIndex = 11
        Me.Lbl_Ttl.Text = "Tempat/Tanggal Lahir :"
        '
        'Lbl_Dprt
        '
        Me.Lbl_Dprt.AutoSize = True
        Me.Lbl_Dprt.Location = New System.Drawing.Point(11, 194)
        Me.Lbl_Dprt.Name = "Lbl_Dprt"
        Me.Lbl_Dprt.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_Dprt.TabIndex = 8
        Me.Lbl_Dprt.Text = "Departemen                 :"
        '
        'Txt_Notlp
        '
        Me.Txt_Notlp.Location = New System.Drawing.Point(138, 165)
        Me.Txt_Notlp.Name = "Txt_Notlp"
        Me.Txt_Notlp.Size = New System.Drawing.Size(153, 20)
        Me.Txt_Notlp.TabIndex = 6
        '
        'Txt_Almt
        '
        Me.Txt_Almt.Location = New System.Drawing.Point(138, 96)
        Me.Txt_Almt.Multiline = True
        Me.Txt_Almt.Name = "Txt_Almt"
        Me.Txt_Almt.Size = New System.Drawing.Size(232, 63)
        Me.Txt_Almt.TabIndex = 5
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(138, 19)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(95, 20)
        Me.Txt_ID.TabIndex = 4
        '
        'Lbl_Notlp
        '
        Me.Lbl_Notlp.AutoSize = True
        Me.Lbl_Notlp.Location = New System.Drawing.Point(12, 168)
        Me.Lbl_Notlp.Name = "Lbl_Notlp"
        Me.Lbl_Notlp.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_Notlp.TabIndex = 3
        Me.Lbl_Notlp.Text = "No Telepon/HP           :"
        '
        'Lbl_Almt
        '
        Me.Lbl_Almt.AutoSize = True
        Me.Lbl_Almt.Location = New System.Drawing.Point(11, 99)
        Me.Lbl_Almt.Name = "Lbl_Almt"
        Me.Lbl_Almt.Size = New System.Drawing.Size(120, 13)
        Me.Lbl_Almt.TabIndex = 2
        Me.Lbl_Almt.Text = "Alamat             .            :"
        '
        'Lbl_Nm
        '
        Me.Lbl_Nm.AutoSize = True
        Me.Lbl_Nm.Location = New System.Drawing.Point(11, 47)
        Me.Lbl_Nm.Name = "Lbl_Nm"
        Me.Lbl_Nm.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_Nm.TabIndex = 1
        Me.Lbl_Nm.Text = "Nama                           :"
        '
        'Lbl_NIK
        '
        Me.Lbl_NIK.AutoSize = True
        Me.Lbl_NIK.Location = New System.Drawing.Point(10, 22)
        Me.Lbl_NIK.Name = "Lbl_NIK"
        Me.Lbl_NIK.Size = New System.Drawing.Size(148, 13)
        Me.Lbl_NIK.TabIndex = 0
        Me.Lbl_NIK.Text = "&NIK                               :         "
        '
        'Btn_Simpan
        '
        Me.Btn_Simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Simpan.ForeColor = System.Drawing.Color.White
        Me.Btn_Simpan.Location = New System.Drawing.Point(403, 34)
        Me.Btn_Simpan.Name = "Btn_Simpan"
        Me.Btn_Simpan.Size = New System.Drawing.Size(75, 29)
        Me.Btn_Simpan.TabIndex = 15
        Me.Btn_Simpan.Text = "&Simpan"
        Me.Btn_Simpan.UseVisualStyleBackColor = False
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Update.ForeColor = System.Drawing.Color.White
        Me.Btn_Update.Location = New System.Drawing.Point(403, 69)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(75, 29)
        Me.Btn_Update.TabIndex = 17
        Me.Btn_Update.Text = "&Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(403, 104)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 28)
        Me.BtnHapus.TabIndex = 19
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(403, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 33)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "&Keluar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Update_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 339)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Simpan)
        Me.Controls.Add(Me.Grp_Update)
        Me.Name = "Update_Data"
        Me.Text = "Input Data Anggota"
        Me.Grp_Update.ResumeLayout(False)
        Me.Grp_Update.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grp_Update As System.Windows.Forms.GroupBox
    Friend WithEvents txt_gaji As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tgl As System.Windows.Forms.Label
    Friend WithEvents Dtp_Tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_Nm As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Ttl As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ttl As System.Windows.Forms.Label
    Friend WithEvents Lbl_Dprt As System.Windows.Forms.Label
    Friend WithEvents Txt_Notlp As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Almt As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Notlp As System.Windows.Forms.Label
    Friend WithEvents Lbl_Almt As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nm As System.Windows.Forms.Label
    Friend WithEvents Lbl_NIK As System.Windows.Forms.Label
    Friend WithEvents Btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Passd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_Dprt As System.Windows.Forms.ComboBox
End Class
