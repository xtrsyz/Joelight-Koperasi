Public Class mainmenu

    Private Sub mainmenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Login.Show()
        Simpanan.Close()
        Entry_Anggota.Close()
    End Sub

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If loginadmin = True Then
            
        Else
            LaporanToolStripMenuItem.Visible = False

            'MasterAnggotaToolStripMenuItem1.Visible = False
            'ShowProfileToolStripMenuItem.Visible = True
            CariAnggotaToolStripMenuItem.Visible = False
            InputAnggotaToolStripMenuItem.Visible = False
            SimulasiKreditToolStripMenuItem.Visible = True
            'Button5.Visible = False
            'Button6.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Entry_Anggota.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cari_Anggota.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Update_Data.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Simpanan.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub

    Private Sub SimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub MasterAnggotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterAnggotaToolStripMenuItem1.Click

    End Sub

    Private Sub CariAnggotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cari_Anggota.Show()
    End Sub

    Private Sub InputAnggotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Update_Data.Show()
    End Sub

    Private Sub MasterSimpanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterSimpanaToolStripMenuItem.Click
        Simpanan.Show()
    End Sub

    Private Sub MasterPinjamanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterPinjamanToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ShowProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Entry_Anggota.Show()

    End Sub

    Private Sub InputAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputAnggotaToolStripMenuItem.Click
        Update_Data.Show()
    End Sub

    Private Sub CariAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariAnggotaToolStripMenuItem.Click
        Cari_Anggota.Show()
    End Sub

    Private Sub ShowProfileToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowProfileToolStripMenuItem.Click
        Entry_Anggota.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SimulasiKreditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimulasiKreditToolStripMenuItem.Click
        Simulasi_Kredit.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub LaporanSimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanSimpananToolStripMenuItem.Click
        Dim simpanan_rep As New simpanan_report
        simpanan_rep.ShowDialog()
        simpanan_rep.Dispose()

    End Sub

    Private Sub LaporanPinjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPinjamanToolStripMenuItem.Click
        Dim pinjaman_rep As New pinjaman_rport
        pinjaman_rep.ShowDialog() '
        pinjaman_rep.Dispose()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help_F.Show()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MelihatProfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MemasukkanAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenambahSimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenambahPinjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenambahBayaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class