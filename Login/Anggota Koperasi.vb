Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader
Public Class Entry_Anggota

    
    Dim tx As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If loginadmin = False Then
        Txt_ID.ReadOnly = True
        Txt_Almt.ReadOnly = True
        Txt_Dprt.ReadOnly = True
        txt_gaji.ReadOnly = True
        Txt_Nm.ReadOnly = True
        Txt_Notlp.ReadOnly = True
        Txt_Ttl.ReadOnly = True
        Dtp_Tgl.Enabled = False
        'End If

        Txt_ID.Text = NIKUSER
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
        End If

        conn.Close()

    End Sub




    Private Sub Btn_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Batal.Click
        Me.Dispose()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Login.Txt_Passd.Text = TextBox1.Text Then
            If TextBox2.Text <> "" And TextBox2.Text = TextBox3.Text Then
                koneksimysql()
                tx = "UPDATE `anggota` SET `password`='" & TextBox3.Text & "' WHERE `NIK`=  '" & NIKUSER & "'"
                Dim ins As New MySqlCommand(tx, conn)
                On Error GoTo savegagal
                ins.ExecuteNonQuery()

                MsgBox("sukses")
                Login.Txt_Passd.Text = TextBox3.Text
                GoTo savesukses
savegagal:
                MsgBox("Update Galat")
savesukses:
                conn.Close()
            Else
                MsgBox("password baru tidak sama")
            End If
        Else
            MsgBox("password salah")
        End If
    End Sub

End Class