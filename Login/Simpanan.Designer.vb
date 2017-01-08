<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simpanan
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
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_NIK2 = New System.Windows.Forms.Label()
        Me.Jumlah = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Dept = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG1
        '
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(12, 90)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(837, 248)
        Me.DG1.TabIndex = 7
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(137, 12)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(177, 20)
        Me.Txt_ID.TabIndex = 8
        '
        'Lbl_NIK2
        '
        Me.Lbl_NIK2.AutoSize = True
        Me.Lbl_NIK2.Location = New System.Drawing.Point(12, 15)
        Me.Lbl_NIK2.Name = "Lbl_NIK2"
        Me.Lbl_NIK2.Size = New System.Drawing.Size(106, 13)
        Me.Lbl_NIK2.TabIndex = 9
        Me.Lbl_NIK2.Text = "&NIK                          :"
        '
        'Jumlah
        '
        Me.Jumlah.Location = New System.Drawing.Point(457, 38)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(102, 20)
        Me.Jumlah.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(591, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 25)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Kredit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(591, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 25)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Debit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(332, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 25)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nama                       :"
        '
        'Txt_nama
        '
        Me.Txt_nama.Location = New System.Drawing.Point(137, 38)
        Me.Txt_nama.Name = "Txt_nama"
        Me.Txt_nama.Size = New System.Drawing.Size(177, 20)
        Me.Txt_nama.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Departemen             :"
        '
        'Txt_Dept
        '
        Me.Txt_Dept.Location = New System.Drawing.Point(137, 64)
        Me.Txt_Dept.Name = "Txt_Dept"
        Me.Txt_Dept.Size = New System.Drawing.Size(177, 20)
        Me.Txt_Dept.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(741, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "&Keluar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Jumlah"
        '
        'Simpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 350)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Dept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_nama)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Jumlah)
        Me.Controls.Add(Me.Lbl_NIK2)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.DG1)
        Me.Name = "Simpanan"
        Me.Text = "Simpanan"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_NIK2 As System.Windows.Forms.Label
    Friend WithEvents Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Dept As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
