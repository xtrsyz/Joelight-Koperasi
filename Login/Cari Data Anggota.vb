Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader

Public Class Cari_Anggota
    ' Dim ins As New MySql.Data.MySqlClient.MySqlCommand
    'Dim ins As New myscommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim tx As String

    Private Sub Grp_CariAnggota_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_CariAnggota.Enter

    End Sub

    
    Private Sub Btn_Cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cari.Click

        koneksimysql()

        table = New DataTable

        If Txt_ID2.Text <> "" Then adapter = New MySqlDataAdapter("Select `NIK`,`Nama`,`Departemen` FROM `anggota` WHERE `NIK` LIKE  '%" & Txt_ID2.Text & "%'", conn)
        If Txt_Nm2.Text <> "" Then adapter = New MySqlDataAdapter("Select `NIK`,`Nama`,`Departemen` FROM `anggota` WHERE `Nama` LIKE '%" & Txt_Nm2.Text & "%'", conn)

        adapter.Fill(table)


        DG1.DataSource = table
        If DG1.Rows.Count = 1 Then MsgBox("data tidak ditemukan")

        conn.Close()
    End Sub

    Private Sub Txt_Nm2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Nm2.TextChanged

    End Sub

    Private Sub Btn_Selesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Selesai.Click
        Me.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub

    Private Sub Cari_Anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class