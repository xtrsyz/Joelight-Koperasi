<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Lbl_Login = New System.Windows.Forms.Label()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.Lbl_Passd = New System.Windows.Forms.Label()
        Me.Btn_Masuk = New System.Windows.Forms.Button()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Txt_Passd = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Login
        '
        Me.Lbl_Login.AutoSize = True
        Me.Lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Login.Location = New System.Drawing.Point(279, 22)
        Me.Lbl_Login.Name = "Lbl_Login"
        Me.Lbl_Login.Size = New System.Drawing.Size(92, 29)
        Me.Lbl_Login.TabIndex = 0
        Me.Lbl_Login.Text = "LOGIN"
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.Location = New System.Drawing.Point(197, 99)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(77, 16)
        Me.Lbl_User.TabIndex = 1
        Me.Lbl_User.Text = "Nama User"
        '
        'Lbl_Passd
        '
        Me.Lbl_Passd.AutoSize = True
        Me.Lbl_Passd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Passd.Location = New System.Drawing.Point(197, 137)
        Me.Lbl_Passd.Name = "Lbl_Passd"
        Me.Lbl_Passd.Size = New System.Drawing.Size(68, 16)
        Me.Lbl_Passd.TabIndex = 2
        Me.Lbl_Passd.Text = "Password"
        '
        'Btn_Masuk
        '
        Me.Btn_Masuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Masuk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Masuk.Location = New System.Drawing.Point(255, 188)
        Me.Btn_Masuk.Name = "Btn_Masuk"
        Me.Btn_Masuk.Size = New System.Drawing.Size(88, 32)
        Me.Btn_Masuk.TabIndex = 3
        Me.Btn_Masuk.Text = "&Masuk"
        Me.Btn_Masuk.UseVisualStyleBackColor = False
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(293, 99)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(170, 20)
        Me.Txt_User.TabIndex = 4
        '
        'Txt_Passd
        '
        Me.Txt_Passd.Location = New System.Drawing.Point(293, 137)
        Me.Txt_Passd.Name = "Txt_Passd"
        Me.Txt_Passd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Passd.Size = New System.Drawing.Size(171, 20)
        Me.Txt_Passd.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(349, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Batal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 275)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Passd)
        Me.Controls.Add(Me.Txt_User)
        Me.Controls.Add(Me.Btn_Masuk)
        Me.Controls.Add(Me.Lbl_Passd)
        Me.Controls.Add(Me.Lbl_User)
        Me.Controls.Add(Me.Lbl_Login)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Login As System.Windows.Forms.Label
    Friend WithEvents Lbl_User As System.Windows.Forms.Label
    Friend WithEvents Lbl_Passd As System.Windows.Forms.Label
    Friend WithEvents Btn_Masuk As System.Windows.Forms.Button
    Friend WithEvents Txt_User As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Passd As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
