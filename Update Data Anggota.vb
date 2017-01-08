Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader
Public Class Update_Data
    ' Dim ins As New MySql.Data.MySqlClient.MySqlCommand
    'Dim ins As New myscommand
    Dim adapter As MySqlDataAdapter

    Dim tx As String


    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        koneksimysql()
        'conn.Open()
        tx = "UPDATE `anggota` SET `NIK`='" & Txt_ID.Text & "',`Nama`='" & Txt_Nm.Text & "',`TTL`='" & Txt_Ttl.Text & "',`Alamat`= '" & Txt_Almt.Text & "',`No Telp`='" & Txt_Notlp.Text & "',`Departemen`='" & Txt_Dprt.Text & "',`Gaji`='" & txt_gaji.Text & "',`Tanggal`='" & Dtp_Tgl.Text & "',`admin` =  " & CheckBox1.Checked & ", `password` = '" & txt_Passd.Text & "' WHERE `NIK`=  '" & Txt_ID.Text & "'"
        'ins.CommandText = (tx)
        Dim ins As New MySqlCommand(tx, conn)
        On Error GoTo savegagal
        ins.ExecuteNonQuery()

        MsgBox("sukses")
        GoTo savesukses
savegagal:
        MsgBox("Update Galat")
savesukses:
        conn.Close()
    End Sub


    Private Sub Btn_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Simpan.Click
        koneksimysql()
        tx = "INSERT INTO `anggota` (`NIK`, `Nama`, `TTL`, `Alamat`, `No Telp`, `Departemen`, `Gaji`, `Tanggal`, `admin` ,`password`) VALUES ('" & Txt_ID.Text & "', '" & Txt_Nm.Text & "', '" & Txt_Ttl.Text & "', '" & Txt_Almt.Text & "', '" & Txt_Notlp.Text & "', '" & Txt_Dprt.Text & "', '" & txt_gaji.Text & "', '" & Dtp_Tgl.Text & "', " & CheckBox1.Checked & ", '" & txt_Passd.Text & "');"

        Dim ins As New MySqlCommand(tx, conn)
        On Error GoTo savegagal
        ins.ExecuteNonQuery()

        MsgBox("Data telah berhasil disimpan")
        GoTo savesukses
savegagal:
        MsgBox("Simpan Galat")
savesukses:
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        koneksimysql()
        tx = "select * from anggota where `NIK` = '" & Txt_ID.Text & "'"

        Dim table = New DataTable
        Dim adapter = New MySqlDataAdapter(tx, conn)

        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim row1 As DataRow = table.Rows(0)
            Txt_Nm.Text = row1("Nama")
            Txt_Notlp.Text = row1("No Telp")
            Txt_Ttl.Text = row1("TTL")
            Txt_Almt.Text = row1("Alamat")
            Txt_Dprt.Text = row1("Departemen")
            Dtp_Tgl.Text = row1("Tanggal")
            txt_gaji.Text = row1("Gaji")
            txt_Passd.Text = row1("Password")
            CheckBox1.Checked = row1("admin")
        Else
            MsgBox("Data tidak ditemukan")
        End If

        conn.Close()
    End Sub
    Private Sub kosongkan()
        Txt_ID.Text = ""
        Txt_Nm.Text = ""
        Txt_Notlp.Text = ""
        Txt_Ttl.Text = ""
        txt_Passd.Text = ""
        Txt_Almt.Text = ""
        txt_gaji.Text = ""
        Txt_Dprt.Text = ""
        Dtp_Tgl.Text = ""

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click

        If MsgBox("Apakah Anda yakin untuk menghapusnya?", MsgBoxStyle.OkCancel, "Hapus Anggota") = MsgBoxResult.Ok Then
            koneksimysql()
            tx = "DELETE FROM `anggota` WHERE `NIK` = '" & Txt_ID.Text & "'"
            Dim ins As New MySqlCommand(tx, conn)
            On Error GoTo savegagal
            ins.ExecuteNonQuery()

            MsgBox("Data telah berhasil dihapus")
            kosongkan()

            GoTo savesukses
savegagal:
            MsgBox("Simpan Galat")
savesukses:
            conn.Close()
        End If
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Grp_Update_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_Update.Enter

    End Sub

    Private Sub Update_Data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_Passd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Passd.TextChanged

    End Sub

End Class