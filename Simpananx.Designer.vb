<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Lbl_No = New System.Windows.Forms.Label()
        Me.Lbl_TglTrans = New System.Windows.Forms.Label()
        Me.Txt_No = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Dprt3 = New System.Windows.Forms.TextBox()
        Me.Txt_Almt3 = New System.Windows.Forms.TextBox()
        Me.Txt_Nm4 = New System.Windows.Forms.TextBox()
        Me.Txt_ID4 = New System.Windows.Forms.TextBox()
        Me.Lbl_Dprt3 = New System.Windows.Forms.Label()
        Me.Lbl_Almt3 = New System.Windows.Forms.Label()
        Me.Lbl_Nm4 = New System.Windows.Forms.Label()
        Me.Lbl_ID4 = New System.Windows.Forms.Label()
        Me.Dtp_Trans = New System.Windows.Forms.DateTimePicker()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Txt_Kredit = New System.Windows.Forms.TextBox()
        Me.Txt_Gaji3 = New System.Windows.Forms.TextBox()
        Me.Lbl_Jmlh = New System.Windows.Forms.Label()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Lbl_Kredit = New System.Windows.Forms.Label()
        Me.Lbl_Gaji3 = New System.Windows.Forms.Label()
        Me.Btn_Tmbh2 = New System.Windows.Forms.Button()
        Me.Btn_Simp2 = New System.Windows.Forms.Button()
        Me.Btn_Edit2 = New System.Windows.Forms.Button()
        Me.Btn_Hapus3 = New System.Windows.Forms.Button()
        Me.Btn_Tutup2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(101, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi Uang Simpanan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Anggota Koperasi"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(835, 582)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 750
        Me.LineShape1.Y1 = 108
        Me.LineShape1.Y2 = 108
        '
        'Lbl_No
        '
        Me.Lbl_No.AutoSize = True
        Me.Lbl_No.Location = New System.Drawing.Point(2, 41)
        Me.Lbl_No.Name = "Lbl_No"
        Me.Lbl_No.Size = New System.Drawing.Size(115, 13)
        Me.Lbl_No.TabIndex = 2
        Me.Lbl_No.Text = "&No.Transaksi              :"
        '
        'Lbl_TglTrans
        '
        Me.Lbl_TglTrans.AutoSize = True
        Me.Lbl_TglTrans.Location = New System.Drawing.Point(289, 35)
        Me.Lbl_TglTrans.Name = "Lbl_TglTrans"
        Me.Lbl_TglTrans.Size = New System.Drawing.Size(116, 13)
        Me.Lbl_TglTrans.TabIndex = 3
        Me.Lbl_TglTrans.Text = "Tanggal Transaksi      :"
        '
        'Txt_No
        '
        Me.Txt_No.Location = New System.Drawing.Point(123, 38)
        Me.Txt_No.Name = "Txt_No"
        Me.Txt_No.Size = New System.Drawing.Size(86, 20)
        Me.Txt_No.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Txt_Saldo)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Lbl_Jmlh)
        Me.GroupBox1.Controls.Add(Me.Txt_Dprt3)
        Me.GroupBox1.Controls.Add(Me.Txt_Almt3)
        Me.GroupBox1.Controls.Add(Me.Txt_Kredit)
        Me.GroupBox1.Controls.Add(Me.Lbl_Saldo)
        Me.GroupBox1.Controls.Add(Me.Txt_Nm4)
        Me.GroupBox1.Controls.Add(Me.Lbl_Kredit)
        Me.GroupBox1.Controls.Add(Me.Txt_Gaji3)
        Me.GroupBox1.Controls.Add(Me.Txt_ID4)
        Me.GroupBox1.Controls.Add(Me.Lbl_Dprt3)
        Me.GroupBox1.Controls.Add(Me.Lbl_Almt3)
        Me.GroupBox1.Controls.Add(Me.Lbl_Nm4)
        Me.GroupBox1.Controls.Add(Me.Lbl_Gaji3)
        Me.GroupBox1.Controls.Add(Me.Lbl_ID4)
        Me.GroupBox1.Controls.Add(Me.Dtp_Trans)
        Me.GroupBox1.Controls.Add(Me.Txt_No)
        Me.GroupBox1.Controls.Add(Me.Lbl_TglTrans)
        Me.GroupBox1.Controls.Add(Me.Lbl_No)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 194)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "- Data Anggota -"
        '
        'Txt_Dprt3
        '
        Me.Txt_Dprt3.Location = New System.Drawing.Point(97, 157)
        Me.Txt_Dprt3.Name = "Txt_Dprt3"
        Me.Txt_Dprt3.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Dprt3.TabIndex = 7
        '
        'Txt_Almt3
        '
        Me.Txt_Almt3.Location = New System.Drawing.Point(97, 129)
        Me.Txt_Almt3.Name = "Txt_Almt3"
        Me.Txt_Almt3.Size = New System.Drawing.Size(317, 20)
        Me.Txt_Almt3.TabIndex = 6
        '
        'Txt_Nm4
        '
        Me.Txt_Nm4.Location = New System.Drawing.Point(97, 102)
        Me.Txt_Nm4.Name = "Txt_Nm4"
        Me.Txt_Nm4.Size = New System.Drawing.Size(192, 20)
        Me.Txt_Nm4.TabIndex = 5
        '
        'Txt_ID4
        '
        Me.Txt_ID4.Location = New System.Drawing.Point(97, 74)
        Me.Txt_ID4.Name = "Txt_ID4"
        Me.Txt_ID4.Size = New System.Drawing.Size(93, 20)
        Me.Txt_ID4.TabIndex = 4
        '
        'Lbl_Dprt3
        '
        Me.Lbl_Dprt3.AutoSize = True
        Me.Lbl_Dprt3.Location = New System.Drawing.Point(0, 160)
        Me.Lbl_Dprt3.Name = "Lbl_Dprt3"
        Me.Lbl_Dprt3.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_Dprt3.TabIndex = 3
        Me.Lbl_Dprt3.Text = "Departemen    :"
        '
        'Lbl_Almt3
        '
        Me.Lbl_Almt3.AutoSize = True
        Me.Lbl_Almt3.Location = New System.Drawing.Point(1, 132)
        Me.Lbl_Almt3.Name = "Lbl_Almt3"
        Me.Lbl_Almt3.Size = New System.Drawing.Size(81, 13)
        Me.Lbl_Almt3.TabIndex = 2
        Me.Lbl_Almt3.Text = "Alamat             :"
        '
        'Lbl_Nm4
        '
        Me.Lbl_Nm4.AutoSize = True
        Me.Lbl_Nm4.Location = New System.Drawing.Point(0, 105)
        Me.Lbl_Nm4.Name = "Lbl_Nm4"
        Me.Lbl_Nm4.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_Nm4.TabIndex = 1
        Me.Lbl_Nm4.Text = "Nama              :"
        '
        'Lbl_ID4
        '
        Me.Lbl_ID4.AutoSize = True
        Me.Lbl_ID4.Location = New System.Drawing.Point(0, 77)
        Me.Lbl_ID4.Name = "Lbl_ID4"
        Me.Lbl_ID4.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_ID4.TabIndex = 0
        Me.Lbl_ID4.Text = "&ID Anggota      :"
        '
        'Dtp_Trans
        '
        Me.Dtp_Trans.Location = New System.Drawing.Point(411, 29)
        Me.Dtp_Trans.Name = "Dtp_Trans"
        Me.Dtp_Trans.Size = New System.Drawing.Size(132, 20)
        Me.Dtp_Trans.TabIndex = 9
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(519, 128)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(154, 20)
        Me.TextBox10.TabIndex = 7
        '
        'Txt_Saldo
        '
        Me.Txt_Saldo.Location = New System.Drawing.Point(519, 157)
        Me.Txt_Saldo.Name = "Txt_Saldo"
        Me.Txt_Saldo.Size = New System.Drawing.Size(154, 20)
        Me.Txt_Saldo.TabIndex = 6
        '
        'Txt_Kredit
        '
        Me.Txt_Kredit.Location = New System.Drawing.Point(519, 102)
        Me.Txt_Kredit.Name = "Txt_Kredit"
        Me.Txt_Kredit.Size = New System.Drawing.Size(154, 20)
        Me.Txt_Kredit.TabIndex = 5
        '
        'Txt_Gaji3
        '
        Me.Txt_Gaji3.Location = New System.Drawing.Point(519, 77)
        Me.Txt_Gaji3.Name = "Txt_Gaji3"
        Me.Txt_Gaji3.Size = New System.Drawing.Size(154, 20)
        Me.Txt_Gaji3.TabIndex = 4
        '
        'Lbl_Jmlh
        '
        Me.Lbl_Jmlh.AutoSize = True
        Me.Lbl_Jmlh.Location = New System.Drawing.Point(443, 160)
        Me.Lbl_Jmlh.Name = "Lbl_Jmlh"
        Me.Lbl_Jmlh.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Jmlh.TabIndex = 3
        Me.Lbl_Jmlh.Text = "Jumlah    :"
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(443, 132)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Saldo.TabIndex = 2
        Me.Lbl_Saldo.Text = "Saldo      :"
        '
        'Lbl_Kredit
        '
        Me.Lbl_Kredit.AutoSize = True
        Me.Lbl_Kredit.Location = New System.Drawing.Point(443, 105)
        Me.Lbl_Kredit.Name = "Lbl_Kredit"
        Me.Lbl_Kredit.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Kredit.TabIndex = 1
        Me.Lbl_Kredit.Text = "Kredit      :"
        '
        'Lbl_Gaji3
        '
        Me.Lbl_Gaji3.AutoSize = True
        Me.Lbl_Gaji3.Location = New System.Drawing.Point(443, 80)
        Me.Lbl_Gaji3.Name = "Lbl_Gaji3"
        Me.Lbl_Gaji3.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Gaji3.TabIndex = 0
        Me.Lbl_Gaji3.Text = "Gaji         :"
        '
        'Btn_Tmbh2
        '
        Me.Btn_Tmbh2.Location = New System.Drawing.Point(107, 336)
        Me.Btn_Tmbh2.Name = "Btn_Tmbh2"
        Me.Btn_Tmbh2.Size = New System.Drawing.Size(62, 26)
        Me.Btn_Tmbh2.TabIndex = 11
        Me.Btn_Tmbh2.Text = "&Tambah "
        Me.Btn_Tmbh2.UseVisualStyleBackColor = True
        '
        'Btn_Simp2
        '
        Me.Btn_Simp2.Location = New System.Drawing.Point(23, 336)
        Me.Btn_Simp2.Name = "Btn_Simp2"
        Me.Btn_Simp2.Size = New System.Drawing.Size(62, 26)
        Me.Btn_Simp2.TabIndex = 12
        Me.Btn_Simp2.Text = "&Simpan"
        Me.Btn_Simp2.UseVisualStyleBackColor = True
        '
        'Btn_Edit2
        '
        Me.Btn_Edit2.Location = New System.Drawing.Point(197, 336)
        Me.Btn_Edit2.Name = "Btn_Edit2"
        Me.Btn_Edit2.Size = New System.Drawing.Size(62, 26)
        Me.Btn_Edit2.TabIndex = 14
        Me.Btn_Edit2.Text = "&Edit"
        Me.Btn_Edit2.UseVisualStyleBackColor = True
        '
        'Btn_Hapus3
        '
        Me.Btn_Hapus3.Location = New System.Drawing.Point(295, 337)
        Me.Btn_Hapus3.Name = "Btn_Hapus3"
        Me.Btn_Hapus3.Size = New System.Drawing.Size(62, 25)
        Me.Btn_Hapus3.TabIndex = 15
        Me.Btn_Hapus3.Text = "&Hapus"
        Me.Btn_Hapus3.UseVisualStyleBackColor = True
        '
        'Btn_Tutup2
        '
        Me.Btn_Tutup2.Location = New System.Drawing.Point(484, 337)
        Me.Btn_Tutup2.Name = "Btn_Tutup2"
        Me.Btn_Tutup2.Size = New System.Drawing.Size(62, 25)
        Me.Btn_Tutup2.TabIndex = 16
        Me.Btn_Tutup2.Text = "&Tutup"
        Me.Btn_Tutup2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 26)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(718, 175)
        Me.ShapeContainer2.TabIndex = 10
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 427
        Me.LineShape2.X2 = 426
        Me.LineShape2.Y1 = 65
        Me.LineShape2.Y2 = 178
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 378)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(728, 201)
        Me.DataGridView1.TabIndex = 19
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(835, 582)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Hapus3)
        Me.Controls.Add(Me.Btn_Tmbh2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Edit2)
        Me.Controls.Add(Me.Btn_Tutup2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Simp2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Lbl_No As System.Windows.Forms.Label
    Friend WithEvents Lbl_TglTrans As System.Windows.Forms.Label
    Friend WithEvents Txt_No As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Dprt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Almt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nm4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ID4 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Dprt3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Almt3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nm4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ID4 As System.Windows.Forms.Label
    Friend WithEvents Dtp_Trans As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Saldo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Kredit As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Gaji3 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Jmlh As System.Windows.Forms.Label
    Friend WithEvents Lbl_Saldo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Kredit As System.Windows.Forms.Label
    Friend WithEvents Lbl_Gaji3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Tmbh2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Simp2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Edit2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Hapus3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Tutup2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
