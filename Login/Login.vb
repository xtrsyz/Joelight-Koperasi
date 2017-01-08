Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader

Public Class Login
    ' Dim ins As New MySql.Data.MySqlClient.MySqlCommand
    'Dim ins As New myscommand

    Dim tx As String
    Private _mySqlCommand As String

    Private Property txbRootPass As Object

    Private Property tx_User As Object

    Private Property MySqlCommand(ByVal tx As String, ByVal conn As MySqlConnection) As String
        Get
            Return _mySqlCommand
        End Get
        Set(ByVal value As String)
            _mySqlCommand = value
        End Set
    End Property



    Private Sub Btn_Masuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Masuk.Click
        koneksimysql()
        tx = "select * from anggota where `NIK` = '" & Txt_User.Text & "' AND `password` = '" & Txt_Passd.Text & "'"
        Dim table = New DataTable
        Dim adapter = New MySqlDataAdapter(tx, conn)

        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim row1 As DataRow = table.Rows(0)

            Dim jmlrow As Integer = table.Rows.Count

            If jmlrow = "0" Then

                MessageBox.Show("Invalid Login.", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tx_User.Focus()

            Else
                NIKUSER = row1("NIK")
                Dim admin As String = row1("admin")

                MessageBox.Show("Login success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If admin = True Then
                    'MsgBox("login sebgai admin")
                    loginadmin = True
                    mainmenu.Show()
                    Me.Hide()
                Else
                    ' MsgBox("login user biasa")
                    loginadmin = False
                    mainmenu.Show()
                    Me.Hide()
                End If
            End If
            conn.Close()
        Else
            MsgBox("Password Anda Salah")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Update_Data.Show()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
