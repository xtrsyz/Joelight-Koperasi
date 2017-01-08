Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader


Public Class Simpanan
    Dim tx As String
    Dim table As DataTable
    Dim adapter As MySqlDataAdapter
    Dim reader As MySqlDataReader '
    Dim comm As MySqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksimysql()
        'conn.Open() 
        'tx = "select * from anggota where `NIK` = '" & NIKUSER & "'"
        tx = "select * from anggota where `NIK` = '" & Txt_ID.Text & "'"

        Dim table = New DataTable
        Dim adapter = New MySqlDataAdapter(tx, conn)

        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim row1 As DataRow = table.Rows(0)
            Dim tmpcredit As Integer
            tmpcredit = row1("Kredit")
            tmpcredit = tmpcredit - Jumlah.Text
            If tmpcredit >= 0 Then
                tx = "INSERT INTO `simpanan` (`NIK`, `Transaksi`, `Jenis`, `Nilai`, `Total`) VALUES ('" & Txt_ID.Text & "', 'D" & TimeOfDay.TimeOfDay.TotalSeconds & "', 'Debit', '" & Jumlah.Text & "', '" & tmpcredit & "');"

                'ins.CommandText = (tx)
                Dim ins As New MySqlCommand(tx, conn)
                On Error GoTo savegagal
                ins.ExecuteNonQuery()

                tx = "UPDATE `anggota` SET `Kredit` = '" & tmpcredit & "' WHERE `NIK` = '" & Txt_ID.Text & "';"

                ins.CommandText = (tx)

                On Error GoTo savegagal
                ins.ExecuteNonQuery()

                'MsgBox("sukses")
                Button2.PerformClick()
                GoTo savesukses
                'ins.ExecuteReader(tx)
            End If


        End If




savegagal:
        MsgBox("Kredit Tidak Cukup")
savesukses:
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        koneksimysql()
        'conn.Open() 
        'tx = "select * from anggota where `NIK` = '" & NIKUSER & "'"
        tx = "select * from anggota where `NIK` = '" & Txt_ID.Text & "'"

        Dim table = New DataTable
        Dim adapter = New MySqlDataAdapter(tx, conn)

        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim row1 As DataRow = table.Rows(0)
            Dim tmpcredit As Integer
            tmpcredit = row1("Kredit")
            tmpcredit = tmpcredit + Jumlah.Text

            tx = "INSERT INTO `simpanan` (`NIK`, `Transaksi`, `Jenis`, `Nilai`, `Total`) VALUES ('" & Txt_ID.Text & "', 'K" & TimeOfDay.TimeOfDay.TotalSeconds & "', 'Kredit', '" & Jumlah.Text & "', '" & tmpcredit & "');"

            'ins.CommandText = (tx)
            Dim ins As New MySqlCommand(tx, conn)
            On Error GoTo savegagal
            ins.ExecuteNonQuery()

            tx = "UPDATE `anggota` SET `Kredit` = '" & tmpcredit & "' WHERE `NIK` = '" & Txt_ID.Text & "';"

            ins.CommandText = (tx)

            On Error GoTo savegagal
            ins.ExecuteNonQuery()

            ' MsgBox("sukses")
            Button2.PerformClick()
            GoTo savesukses
            'ins.ExecuteReader(tx)

        End If




savegagal:
        MsgBox("Simpan Galat")
savesukses:
        conn.Close()
    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksimysql()
        tx = "Select * FROM `simpanan` WHERE `NIK`= '" & Txt_ID.Text & "'" & _
            "ORDER BY `Tanggal` DESC LIMIT 0 , 30"


        table = New DataTable
        adapter = New MySqlDataAdapter(tx, conn)


        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim row1 As DataRow = table.Rows(0)
            DG1.DataSource = table
        End If
        conn.Close()
        koneksimysql()
        tx = "Select * FROM `anggota` WHERE `NIK`= '" & Txt_ID.Text & "'"
        Dim table2 = New DataTable
        Dim adapter2 = New MySqlDataAdapter(tx, conn)

        adapter2.Fill(table2)
        Dim row2 As DataRow = table2.Rows(0)
        'Dim comm As New MySqlCommand(tx, conn)
        'comm.ExecuteNonQuery()
        'comm.CommandText = (tx)
        'reader = comm.ExecuteReader
        'reader.Read()
        Txt_nama.Text = row2("Nama")
        Txt_Dept.Text = row2("Departemen")
        conn.Close()

    End Sub

    Private Sub pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If loginadmin = False Then
            Button1.Visible = False
            'Button2.Visible = False
            Button3.Visible = False
            Jumlah.Visible = False
            Txt_ID.Text = NIKUSER
            Txt_ID.ReadOnly = True
        Else
            Button1.Visible = True
            Jumlah.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Txt_ID.ReadOnly = False
        End If
    End Sub

    Private Sub Txt_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_ID.TextChanged

    End Sub

    Private Sub Txt_Dept_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Dept.TextChanged

    End Sub

    Private Function row(ByVal p1 As String) As String
        Throw New NotImplementedException
    End Function

    Private Function BY() As Object
        Throw New NotImplementedException
    End Function

    Private Sub ORDER(ByVal p1 As Object, Optional ByVal p2 As Object = Nothing, Optional ByVal p3 As Integer = Nothing)
        Throw New NotImplementedException
    End Sub

    Private Sub Txt_nama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_nama.TextChanged

    End Sub

    Private Sub Jumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jumlah.TextChanged

    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class