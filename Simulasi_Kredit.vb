Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports MySql.Data.MySqlClient.MySqlDataReader
Public Class Simulasi_Kredit
    Dim tx As String
    Dim bayar As Boolean
    Dim totalangsuran As Integer
    Dim table As DataTable
    Dim adapter As MySqlDataAdapter



    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then TextBox1.Text = 0
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then cekangsuran()
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cekangsuran()
        hitungtanggal()
    End Sub
    Private Sub hitungtanggal()
        If ComboBox1.Text = "" Then ComboBox1.Text = 12
        Dim addd As String
        addd = DateTimePicker2.Value.Date.ToFileTimeUtc
        Dim adds As String
        adds = addd + (ComboBox1.Text / 12 * 365.25 * 864000000000)
        DateTimePicker1.Value = Date.FromFileTimeUtc(adds)
    End Sub
    Private Sub cekangsuran()
        On Error Resume Next
        If TextBox1.Text = "" Then TextBox1.Text = 0
        If TextBox2.Text = "" Then TextBox2.Text = 0
        If ComboBox1.Text = "" Then ComboBox1.Text = 12
        TextBox3.Text = Math.Ceiling((TextBox2.Text + (TextBox2.Text * TextBox4.Text / 100 * ComboBox1.Text)) / ComboBox1.Text)
        If TextBox3.Text + totalangsuran > (30 / 100 * TextBox1.Text) Then

            Label12.Visible = True
        Else

            Label12.Visible = False
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        hitungtanggal()
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then TextBox2.Text = 0
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        On Error Resume Next
        If TextBox2.Text <= 10000000 Then
            TextBox4.Text = "1"
        Else
            TextBox4.Text = "2"
        End If
        If TextBox2.Text <> "" Then cekangsuran()
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

End Class