Public Class Help_F

    Private Sub Help_F_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Help_F_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbLogo.Image = WindowsApplication1.My.Resources.images
        PbGp.Image = WindowsApplication1.My.Resources.logomotorSuzuki
        treeHelp.Nodes.Item("nSistem").Expand()
        'treeHelp.Nodes.Item("nMetode").Expand()
        wbView.Navigate(CurDir() + "\bantuan.html")
    End Sub

    Private Sub treeHelp_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeHelp.AfterSelect
        If treeHelp.Nodes.Item("nSistem").IsSelected Then
            wbView.Navigate(CurDir() + "\bantuan.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nLogin").IsSelected Then
            wbView.Navigate(CurDir() + "\html\login.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nMenuUtama").IsSelected Then
            wbView.Navigate(CurDir() + "\html\menu_utama.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nProfil").IsSelected Then
            wbView.Navigate(CurDir() + "\html\melihat_profil.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nInput_Anggota").IsSelected Then
            wbView.Navigate(CurDir() + "\html\input_anggota.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nCari_Anggota").IsSelected Then
            wbView.Navigate(CurDir() + "\html\Mencari Anggota.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nSimpanan").IsSelected Then
            wbView.Navigate(CurDir() + "\html\Simpanan.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nPinjaman").IsSelected Then
            wbView.Navigate(CurDir() + "\html\Pinjaman.html")
        ElseIf treeHelp.Nodes.Item("nSistem").Nodes.Item("nSimulasi").IsSelected Then
            wbView.Navigate(CurDir() + "\html\Simulasi Kredit.html")
        End If
    End Sub
End Class