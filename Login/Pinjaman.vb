Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader
Public Class Form4
    Dim tx As String
    Dim bayar As Boolean
    Dim totalangsuran As Integer
    Dim table As DataTable
    Dim adapter As MySqlDataAdapter
 

    Private Sub Btn_Simp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        koneksimysql()
        'conn.Open()
        tx = "INSERT INTO `koperasi`.`pinjaman` (`No_Pinajaman` ,`Tgl_Pinjaman` ,`NIK` ,`Departemen` ,`Pinjaman_Pokok` ,`Lama_Angsuran`)VALUES ( '" & Txt_NoPinj.Text & "' , '" & Dtp_TglPinj.Text & "', '" & Txt_ID3.Text & "', '" & Txt_Nm3.Text & "', '" & Txt_Dprt2.Text & "','" & Txt_Gaji2.Text & "','" & Txt_Pinj.Text & "','" & ComboBox1.Text & "' )"
        'ins.CommandText = (tx)
        Dim ins As New MySql.Data.MySqlClient.MySqlCommand(tx, conn)
        ins.ExecuteNonQuery()
        'ins.ExecuteReader(tx)
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        If loginadmin = True Then
            Button3.Visible = True
            Btn_Hapus2.Visible = True
            Btn_Tmbh.Visible = True
            Button2.Visible = True
            Txt_ID3.ReadOnly = False
        Else
            Txt_NoPinj.Items.Clear()
            Button3.Visible = False
            Btn_Hapus2.Visible = False
            Btn_Tmbh.Visible = False
            Button2.Visible = False
            Txt_ID3.Text = NIKUSER
            Txt_ID3.ReadOnly = True
            listpinjaman()
            cariDataAnggota()
        End If
    End Sub
    Private Sub listpinjaman()
        Txt_NoPinj.Items.Clear()
        koneksimysql()
        'query mencari data pinjaman
        tx = "select * from `pinjaman` where `NIK` = '" & Txt_ID3.Text & "'"

        Dim table1 = New DataTable
        Dim adapter1 = New MySqlDataAdapter(tx, conn)

        'isi hasil database ke table1
        adapter1.Fill(table1)
        conn.Close()
        Dim row1 As DataRow
        For iii = 0 To table1.Rows.Count - 1
            row1 = table1.Rows(iii)
            Txt_NoPinj.Items.Add(row1("pinj_id"))
        Next
    End Sub

    Private Sub Txt_Pinj_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Pinj.LostFocus
        If Txt_Pinj.Text = "" Then Txt_Pinj.Text = 0
    End Sub


    Private Sub Txt_Pinj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Pinj.TextChanged
        On Error Resume Next
        If Txt_Pinj.Text <= 10000000 Then
            Txt_Bunga2.Text = "1"
        Else
            Txt_Bunga2.Text = "2"
        End If
        If Txt_Pinj.Text <> "" Then cekangsuran()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksimysql()
        'query mencari data pinjaman
        tx = "select * from `pinjaman` where `pinj_id` = '" & Txt_NoPinj.Text & "'"

        Dim table = New DataTable
        Dim adapter = New MySqlDataAdapter(tx, conn)

        'isi hasil database ke table1
        adapter.Fill(table)

        'memeriksa apakah table1 isi?
        If table.Rows.Count > 0 Then
            'mengambil baris pertama dari table1 disimpan ke row1
            Dim row1 As DataRow = table.Rows(0)
            Txt_ID3.Text = row1("NIK")


            Button2.PerformClick()


            'memasukan data dari row1 ke form
            Dtp_TglPinj.Text = row1("pinj_tanggal")
            Txt_Pinj.Text = row1("pinj_pokok")
            ComboBox1.Text = row1("pinj_bulan")
            Dtp_TglPinj.Text = row1("pinj_tanggal")
            DateTimePicker1.Text = row1("pinj_mulai")
            DateTimePicker2.Text = row1("pinj_selesai")

            lihatangsuran()

        Else
            MsgBox("Data tidak ditemukan")
        End If
        bayar = False
        conn.Close()
    End Sub
    Private Sub lihatangsuran()
        Dim table = New DataTable

        Dim adapter = New MySqlDataAdapter("Select `angs_id` as 'Kode Trx', `angs_bayar` as 'Pembayaran', `Tanggal` FROM `Angsuran` WHERE `pinj_id` = '" & Txt_NoPinj.Text & "' ORDER BY `Tanggal` DESC", conn)
        adapter.Fill(table)
        'sgBox(table.Rows(1).Item(1))
        TextBox1.Text = 0
        For iii = 0 To table.Rows.Count - 1
            TextBox1.Text = TextBox1.Text + Int(table.Rows(iii).Item(1))
        Next
        'TextBox1.Text = table.Rows.Count * txt_angsuran.Text
        TextBox2.Text = ComboBox1.Text * txt_angsuran.Text - TextBox1.Text

        'If table.Rows.Count = ComboBox1.Text Then
        If TextBox2.Text = 0 Then
            Button3.Enabled = False
            Button3.Text = "Lunas"
            Button4.Visible = False
            If bayar = True Then pinjamanlunas()
        Else
            Button3.Enabled = True
            Button3.Text = "Bayar"
            Button4.Visible = True
        End If
        
        DataGridView1.DataSource = table
    End Sub
    Private Sub pinjamanlunas()
        koneksimysql()
        tx = "UPDATE `anggota` SET `Angsuran`=  `Angsuran` - " & txt_angsuran.Text & " WHERE `NIK` =  '" & Txt_ID3.Text & "'"
        Dim ins As New MySqlCommand(tx, conn)
        ins.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub pinjamanbaru()
        koneksimysql()
        tx = "UPDATE `anggota` SET `Angsuran` =  `Angsuran` + " & txt_angsuran.Text & " WHERE `NIK`=  '" & Txt_ID3.Text & "'"
        Dim ins As New MySqlCommand(tx, conn)
        ins.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub cariDataAnggota()
        koneksimysql()
        'conn.Open() 
        'tx = "select * from anggota where `NIK` = '" & NIKUSER & "'"
        tx = "select * from `anggota` where `NIK` = '" & Txt_ID3.Text & "'"

        Dim table = New DataTable
        Dim adapter = New MySqlDataAdapter(tx, conn)

        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim row1 As DataRow = table.Rows(0)
            Txt_ID3.Text = row1("NIK")
            Txt_Nm3.Text = row1("Nama")
            Txt_Dprt2.Text = row1("Departemen")
            Txt_Gaji2.Text = row1("Gaji")
            totalangsuran = row1("Angsuran")
            listpinjaman()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        caridataanggota()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cekangsuran()
        hitungtanggal()
    End Sub
    Private Sub cekangsuran()
        On Error Resume Next
        If Txt_Pinj.Text = "" Then Txt_Pinj.Text = 0
        If ComboBox1.Text = "" Then ComboBox1.Text = 12
        txt_angsuran.Text = Math.Ceiling((Txt_Pinj.Text + (Txt_Pinj.Text * Txt_Bunga2.Text / 100 * ComboBox1.Text)) / ComboBox1.Text)
        If txt_angsuran.Text + totalangsuran > (30 / 100 * Txt_Gaji2.Text) Then
            Btn_Tmbh.Enabled = False
            Label4.Visible = True
        Else
            Btn_Tmbh.Enabled = True
            Label4.Visible = False
        End If
    End Sub
    Private Sub Btn_Tmbh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Tmbh.Click
        koneksimysql()
        Dim kodepinj As String = "P" & TimeOfDay.TimeOfDay.TotalSeconds
        tx = "INSERT INTO `pinjaman` (`pinj_id`, `pinj_pokok`, `pinj_bulan`, `NIK`, `pinj_tanggal`, `pinj_mulai`, `pinj_selesai`) VALUES ('" & kodepinj & "', '" & Txt_Pinj.Text & "', '" & ComboBox1.Text & "', '" & Txt_ID3.Text & "', '" & Dtp_TglPinj.Text & "', '" & DateTimePicker1.Text & "', '" & DateTimePicker2.Text & "');"

        Dim ins As New MySqlCommand(tx, conn)
        On Error GoTo savegagal
        ins.ExecuteNonQuery()
        Txt_NoPinj.Text = kodepinj
        MsgBox("Pinjaman Sukses! Nomor pinjaman " & kodepinj)
        pinjamanbaru()
        Button1.PerformClick()
        GoTo savesukses
savegagal:
        MsgBox("Simpan Galat")
savesukses:
        conn.Close()
    End Sub

    Private Sub Btn_Hapus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Hapus2.Click
        koneksimysql()
        tx = "DELETE FROM `pinjaman` WHERE `pinj_id` = '" & Txt_NoPinj.Text & "'"

        Dim ins As New MySqlCommand(tx, conn)
        On Error GoTo savegagal
        ins.ExecuteNonQuery()

        MsgBox("Pinjaman nomor " & Txt_NoPinj.Text & " berhasil dihapus!")
        GoTo savesukses
savegagal:
        MsgBox("Hapus Galat")
savesukses:
        conn.Close()
    End Sub

    Private Sub Btn_Tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Tutup.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        koneksimysql()
        Dim kodebayar As String = "B" & TimeOfDay.TimeOfDay.TotalSeconds
        tx = "INSERT INTO `Angsuran` (`pinj_id`, `angs_id`, `angs_bayar`) VALUES ('" & Txt_NoPinj.Text & "', '" & kodebayar & "', '" & txt_angsuran.Text & "');"

        Dim ins As New MySqlCommand(tx, conn)
        On Error GoTo savegagal
        ins.ExecuteNonQuery()
        bayar = True
        Button1.PerformClick()
        GoTo savesukses
savegagal:
        MsgBox("Simpan Galat")
savesukses:
        conn.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        hitungtanggal()
    End Sub
    Private Sub hitungtanggal()
        If ComboBox1.Text = "" Then ComboBox1.Text = 12
        Dim addd As String
        addd = DateTimePicker1.Value.Date.ToFileTimeUtc
        Dim adds As String
        adds = addd + (ComboBox1.Text / 12 * 365.25 * 864000000000)
        DateTimePicker2.Value = Date.FromFileTimeUtc(adds)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        koneksimysql()
        Dim kodebayar As String = "B" & TimeOfDay.TimeOfDay.TotalSeconds
        tx = "INSERT INTO `Angsuran` (`pinj_id`, `angs_id`, `angs_bayar`) VALUES ('" & Txt_NoPinj.Text & "', '" & kodebayar & "', '" & TextBox2.Text & "');"

        Dim ins As New MySqlCommand(tx, conn)
        On Error GoTo savegagal
        ins.ExecuteNonQuery()
        bayar = True
        Button1.PerformClick()
        GoTo savesukses
savegagal:
        MsgBox("Simpan Galat")
savesukses:
        conn.Close()
    End Sub


End Class