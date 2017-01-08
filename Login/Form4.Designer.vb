<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Lbl_Pinjaman = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Pinjaman
        '
        Me.Lbl_Pinjaman.AutoSize = True
        Me.Lbl_Pinjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pinjaman.Location = New System.Drawing.Point(188, 9)
        Me.Lbl_Pinjaman.Name = "Lbl_Pinjaman"
        Me.Lbl_Pinjaman.Size = New System.Drawing.Size(318, 25)
        Me.Lbl_Pinjaman.TabIndex = 0
        Me.Lbl_Pinjaman.Text = "PINJAMAN UANG KOPERASI"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 346)
        Me.Controls.Add(Me.Lbl_Pinjaman)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Pinjaman As System.Windows.Forms.Label
End Class
