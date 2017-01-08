VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form MAHASISWA 
   Caption         =   "DATA MAHASISWA"
   ClientHeight    =   4590
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5910
   LinkTopic       =   "Form1"
   ScaleHeight     =   4590
   ScaleWidth      =   5910
   StartUpPosition =   2  'CenterScreen
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   3960
      Top             =   1320
      Visible         =   0   'False
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "MAHASISWA.frx":0000
      Height          =   1995
      Left            =   120
      TabIndex        =   19
      Top             =   1920
      Width           =   5655
      _ExtentX        =   9975
      _ExtentY        =   3519
      _Version        =   393216
      AllowUpdate     =   0   'False
      HeadLines       =   2
      RowHeight       =   15
      FormatLocked    =   -1  'True
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ColumnCount     =   4
      BeginProperty Column00 
         DataField       =   "NIM"
         Caption         =   "NIM"
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1057
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   "NAMA"
         Caption         =   "NAMA"
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1057
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column02 
         DataField       =   "KELAS"
         Caption         =   "KELAS"
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1057
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column03 
         DataField       =   "JURUSAN"
         Caption         =   "JURUSAN"
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1057
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
            ColumnWidth     =   1005.165
         EndProperty
         BeginProperty Column01 
            ColumnWidth     =   1995.024
         EndProperty
         BeginProperty Column02 
            ColumnWidth     =   1005.165
         EndProperty
         BeginProperty Column03 
            ColumnWidth     =   1005.165
         EndProperty
      EndProperty
   End
   Begin VB.TextBox TNIM 
      Height          =   350
      Left            =   1200
      TabIndex        =   5
      Top             =   480
      Width           =   1250
   End
   Begin VB.TextBox TNama 
      Height          =   350
      Left            =   1200
      TabIndex        =   6
      Top             =   840
      Width           =   4500
   End
   Begin VB.ComboBox CBJurusan 
      Height          =   315
      Left            =   1200
      TabIndex        =   4
      Top             =   120
      Width           =   1250
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Input"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   1320
      Width           =   1000
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Edit"
      Height          =   375
      Left            =   1080
      TabIndex        =   1
      Top             =   1320
      Width           =   1000
   End
   Begin VB.CommandButton Command3 
      Caption         =   "&Hapus"
      Height          =   375
      Left            =   2040
      TabIndex        =   2
      Top             =   1320
      Width           =   1000
   End
   Begin VB.CommandButton Command4 
      Caption         =   "&Tutup"
      Height          =   375
      Left            =   3000
      TabIndex        =   3
      Top             =   1320
      Width           =   1000
   End
   Begin VB.Label Label5 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Jumlah Data"
      Height          =   345
      Left            =   1320
      TabIndex        =   20
      Top             =   4080
      Width           =   1245
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Jurusan"
      Height          =   345
      Left            =   120
      TabIndex        =   18
      Top             =   120
      Width           =   1005
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " NIM"
      Height          =   345
      Left            =   120
      TabIndex        =   17
      Top             =   480
      Width           =   1005
   End
   Begin VB.Label Label3 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Nama"
      Height          =   345
      Left            =   120
      TabIndex        =   16
      Top             =   840
      Width           =   1005
   End
   Begin VB.Label Label4 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Kelas"
      Height          =   345
      Left            =   2640
      TabIndex        =   15
      Top             =   480
      Width           =   1005
   End
   Begin VB.Label Label12 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "MI"
      Height          =   345
      Left            =   2640
      TabIndex        =   14
      Top             =   4080
      Width           =   495
   End
   Begin VB.Label Label13 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "KA"
      Height          =   345
      Left            =   3600
      TabIndex        =   13
      Top             =   4080
      Width           =   495
   End
   Begin VB.Label Label14 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "TK"
      Height          =   345
      Left            =   4680
      TabIndex        =   12
      Top             =   4080
      Width           =   495
   End
   Begin VB.Label LBKelas 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   3720
      TabIndex        =   11
      Top             =   480
      Width           =   1965
   End
   Begin VB.Label LBMI 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   3120
      TabIndex        =   10
      Top             =   4080
      Width           =   495
   End
   Begin VB.Label LBKA 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   4080
      TabIndex        =   9
      Top             =   4080
      Width           =   495
   End
   Begin VB.Label LBJurusan 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2640
      TabIndex        =   8
      Top             =   120
      Width           =   3045
   End
   Begin VB.Label LBTK 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   5160
      TabIndex        =   7
      Top             =   4080
      Width           =   495
   End
End
Attribute VB_Name = "MAHASISWA"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Form_Activate()
Call BukaDB
Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\DBSPP.mdb"
Adodc1.RecordSource = "MAHASISWA"
Adodc1.Refresh
Set DataGrid1.DataSource = Adodc1
DataGrid1.Refresh
'panggil prosedur untuk mengetahui jumlah siswa
Call JumlahMI
Call JumlahKA
Call JumlahTK
End Sub

Private Sub Form_Load()
Call BukaDB
Call KONDISIAWAL
TNIM.MaxLength = 7
Call ListJurusan
End Sub


Private Sub CBJurusan_KeyPress(Keyascii As Integer)
Keyascii = Asc(UCase(Chr(Keyascii)))
If Keyascii = 27 Then Unload Me
If Keyascii = 13 Then
    If CBJurusan = "MI" Then
        LBJurusan = "MANAJEMEN INFORMATIKA"
        Call Nim_OTO_MI
        Call KelasMI
    ElseIf CBJurusan = "KA" Then
        LBJurusan = "KOMPUTER AKUNTANSI"
        Call Nim_OTO_KA
        Call KelasKA
    ElseIf CBJurusan = "TK" Then
        LBJurusan = "TEKNIK KOMPUTER"
        Call Nim_OTO_TK
        Call KelasTK
    End If
    
    'jika jurusan bukan MI, KA atau TK, tampilkan pesan
    TNIM.Enabled = False
    If CBJurusan <> "MI" And CBJurusan <> "KA" And CBJurusan <> "TK" Then
        MsgBox ("Jurusan tidak terdaftar, harusnya MI, KA atau TK")
        CBJurusan.SetFocus
        Exit Sub
    Else
        TNama.SetFocus
    End If
End If
End Sub

Private Sub CBJurusan_Click()
If CBJurusan = "MI" Then
    LBJurusan = "MANAJEMEN INFORMATIKA"
    Call Nim_OTO_MI
    Call KelasMI
ElseIf CBJurusan = "KA" Then
    LBJurusan = "KOMPUTER AKUNTANSI"
    Call Nim_OTO_KA
    Call KelasKA
ElseIf CBJurusan = "TK" Then
    LBJurusan = "TEKNIK KOMPUTER"
    Call Nim_OTO_TK
    Call KelasTK
End If
TNIM.Enabled = False
End Sub

Private Sub Command1_Click()
If Command1.Caption = "&Input" Then
    Command1.Caption = "Simpan"
    Command2.Enabled = False
    Command3.Enabled = False
    Command4.Caption = "&Batal"
    Call Terang
    CBJurusan.SetFocus
    Exit Sub
Else
    If CBJurusan = "" Or TNIM = "" Or TNama = "" Or LBKelas = "" Then
        MsgBox "Data belum lengkap"
        Exit Sub
    Else
        Dim aa As String
        aa = "insert into MAHASISWA(NIM,NAMA,KELAS,JURUSAN) values ('" & TNIM & "','" & TNama & "','" & LBKelas & "','" & LBJurusan & "')"
        Conn.Execute aa
        Adodc1.Refresh
        DataGrid1.Refresh
        Call KONDISIAWAL
    End If
End If
End Sub

Private Sub Command2_Click()
If Command2.Caption = "&Edit" Then
    Command2.Caption = "Simpan"
    Command1.Enabled = False
    Command3.Enabled = False
    Command4.Caption = "&Batal"
    Call Terang
    CBJurusan.Enabled = False
    TNIM.SetFocus
    Exit Sub
Else
    If TNIM = "" Or TNama = "" Then
        MsgBox "Data belum lengkap"
        Exit Sub
    Else
        Dim cc As String
        cc = "Update MAHASISWA set NAMA='" & TNama & "' where nim='" & TNIM & "'"
        Conn.Execute cc
        Call KONDISIAWAL
        Adodc1.Refresh
        DataGrid1.Refresh
        Command2.SetFocus
        Call KONDISIAWAL
    End If
End If
End Sub

Private Sub Command3_Click()
If Command3.Caption = "&Hapus" Then
    Command1.Enabled = False
    Command2.Enabled = False
    Command3.Caption = "&Hapus"
    Command4.Caption = "&Batal"
    TNIM.Enabled = True
    TNIM.SetFocus
End If
End Sub

Private Sub Command4_Click()
Select Case Command4.Caption
    Case "&Tutup"
        Unload Me
    Case "&Batal"
        Call KONDISIAWAL
End Select
End Sub

'mengatur kelas sebanyak 5 orang untuk jurusan MI
'1-5 kelas MI-A, 6-10 kelas MI-B dan seterusnya

Sub KelasMI()
If Val(LBMI) < 5 And CBJurusan = "MI" Then
    LBKelas = "MI1A"
ElseIf Val(LBMI) = 5 And CBJurusan = "MI" Then
    LBKelas = "MI1B"
ElseIf Val(LBMI) >= 6 And Val(LBMI) < 10 And CBJurusan = "MI" Then
    LBKelas = "MI1B"
ElseIf Val(LBMI) = 10 And CBJurusan = "MI" Then
    LBKelas = "MI1C"
ElseIf Val(LBMI) > 10 And CBJurusan = "MI" Then
    LBKelas = "MI1C"
End If
End Sub

Sub KelasKA()
If LBKA < 5 And CBJurusan = "KA" Then
    LBKelas = "KA1A"
ElseIf LBKA = 5 And CBJurusan = "KA" Then
    LBKelas = "KA1B"
ElseIf LBKA >= 6 And LBKA < 10 And CBJurusan = "KA" Then
    LBKelas = "KA1B"
ElseIf LBKA = 10 And CBJurusan = "KA" Then
    LBKelas = "KA1C"
ElseIf LBKA > 10 And CBJurusan = "KA" Then
    LBKelas = "KA1C"
End If
End Sub

Sub KelasTK()
If LBTK < 5 And CBJurusan = "TK" Then
    LBKelas = "TK1A"
ElseIf LBTK = 5 And CBJurusan = "TK" Then
    LBKelas = "TK1B"
ElseIf LBTK >= 6 And LBTK < 10 And CBJurusan = "TK" Then
    LBKelas = "TK1B"
ElseIf LBTK = 10 And CBJurusan = "TK" Then
    LBKelas = "TK1C"
ElseIf LBTK > 10 And CBJurusan = "TK" Then
    LBKelas = "TK1C"
End If
End Sub

'pengaturan pola NIM adalah YY01001
'nim akan bertambah otomatis pada tiga digit terakhirnya
'01 = MI (manajemen informatika)
'02 = KA (komputer akuntansi)
'03 = TK (teknik komputer)

Private Sub Nim_OTO_MI()
Call BukaDB
Dim RS As New ADODB.Recordset
RS.Open "select NIM from MAHASISWA where Jurusan='MANAJEMEN INFORMATIKA' order by nim desc", Conn
RS.Requery
If RS.EOF Then
    Urutan = Format(Date, "YY") + "01" + "001"
    TNIM = Urutan
    Exit Sub
Else
    Hitung = Right(RS!NIM, 3) + 1
    Urutan = Format(Date, "YY") + "01" + Right("000" & Hitung, 3)
End If
TNIM = Urutan
End Sub

Sub Nim_OTO_KA()
Call BukaDB
Dim RS As New ADODB.Recordset
RS.Open "select NIM from MAHASISWA where Jurusan='KOMPUTER AKUNTANSI' order by nim desc", Conn
RS.Requery
If RS.EOF Then
    Urutan = Format(Date, "YY") + "02" + "001"
    TNIM = Urutan
Else
    Hitung = Right(RS!NIM, 3) + 1
    Urutan = Format(Date, "YY") + "02" + Right("000" & Hitung, 3)
End If
TNIM = Urutan
End Sub

Sub Nim_OTO_TK()
Call BukaDB
Dim RS As New ADODB.Recordset
RS.Open "select NIM from MAHASISWA where Jurusan='TEKNIK KOMPUTER' order by nim desc", Conn
RS.Requery
If RS.EOF Then
    Urutan = Format(Date, "YY") + "03" + "001"
    TNIM = Urutan
Else
    Hitung = Right(RS!NIM, 3) + 1
    Urutan = Format(Date, "YY") + "03" + Right("000" & Hitung, 3)
End If
TNIM = Urutan
End Sub

'prosedur untuk mencari jumlah total siswa di kelas MI
Function JumlahMI()
Dim RS As New ADODB.Recordset
RS.Open "select count(NIM) as JMLMI from MAHASISWA where jurusan='MANAJEMEN INFORMATIKA'", Conn
LBMI = RS!JMLMI
End Function

'prosedur untuk mencari jumlah total siswa di kelas MI
Function JumlahKA()
Dim RS As New ADODB.Recordset
 RS.Open "select count(NIM) as JMLKA from MAHASISWA where jurusan='KOMPUTER AKUNTANSI'", Conn
LBKA = RS!JMLKA
End Function

'prosedur untuk mencari jumlah total siswa di kelas MI
Function JumlahTK()
Dim RS As New ADODB.Recordset
RS.Open "select count(NIM) as JMLTK from MAHASISWA where jurusan='TEKNIK KOMPUTER'", Conn
LBTK = RS!JMLTK
End Function

Sub ListJurusan()
CBJurusan.AddItem ("MI")
CBJurusan.AddItem ("KA")
CBJurusan.AddItem ("TK")
End Sub

Sub KONDISIAWAL()
Form_Activate
Call Gelap
Call KOSONGKAN
Call JumlahMI
Call JumlahKA
Call JumlahTK
Command1.Caption = "&Input"
Command2.Caption = "&Edit"
Command3.Caption = "&Hapus"
Command4.Caption = "&Tutup"
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = True
Command4.Enabled = True
End Sub

Sub Tampilkan()
With RSMAHASISWA
    CBJurusan = Left(!KELAS, 2)
    TNama = !NAMA
    LBKelas = !KELAS
    LBJurusan = !JURUSAN
End With
End Sub

Private Sub TNama_KeyPress(Keyascii As Integer)
Keyascii = Asc(UCase(Chr(Keyascii)))
If Keyascii = 13 Then
    If Command1.Enabled = True Then
        Command1.SetFocus
    Else
        Command2.SetFocus
    End If
End If
End Sub

Private Sub TNIM_KeyPress(Keyascii As Integer)
If Keyascii = 13 Then
    If Len(TNIM) < 7 Then
        MsgBox "NIM harus 7 digit"
        TNIM.SetFocus
        Exit Sub
    End If
    
    'untuk &Input
    If Command1.Caption = "Simpan" Then
        Call CariNIM
            If Not RSMAHASISWA.EOF Then
                Gelap
                Tampilkan
                MsgBox "Nomor MAHASISWA Sudah Ada"
                KOSONGKAN
                Terang
                TNIM.SetFocus
            Else
                Terang
                Gelap
                TNama.SetFocus
            End If
    
    'untuk &Edit
    ElseIf Command2.Caption = "Simpan" Then
            Call CariNIM
            If Not RSMAHASISWA.EOF Then
                Tampilkan
                Terang
                CBJurusan.Enabled = False
                TNIM.Enabled = False
                TNama.SetFocus
            Else
                MsgBox "Nomor MAHASISWA Tidak Ditemukan"
                KOSONGKAN
                Terang
                TNIM.SetFocus
            End If
        
    'untuk hapus
    ElseIf Command3.Caption = "&Hapus" Then
        With RSMAHASISWA
            Call CariNIM
            If Not RSMAHASISWA.EOF Then
                Tampilkan
                Gelap
                Pesan = MsgBox("Yakin Data Ini Akan Dihapus...?", vbYesNo)
                If Pesan = vbYes Then
                    Dim HapusMhs As String
                    HapusMhs = "delete * from mahasiswa where nim='" & TNIM & "'"
                    Conn.Execute (HapusMhs)
                    Adodc1.Refresh
                    DataGrid1.Refresh
                    KONDISIAWAL
                    Command3.SetFocus
                Else
                    KONDISIAWAL
                    Command3.SetFocus
                End If
            Else
                MsgBox "Nomor Formulir Tidak Ditemukan"
                KOSONGKAN
                Terang
                TNIM.SetFocus
            End If
        End With
   End If
End If
If Not (Keyascii >= Asc("0") And Keyascii <= Asc("9") Or Keyascii = vbKeyBack) Then Keyascii = 0
End Sub

Private Sub KOSONGKAN()
Dim Ctl As Control
For Each Ctl In Me
    If TypeName(Ctl) = "TextBox" Or TypeName(Ctl) = "ComboBox" Then
        Ctl.Text = ""
    End If
Next
LBJurusan = ""
LBKelas = ""
End Sub

Private Sub Terang()
Dim Ctl As Control
For Each Ctl In Me
    If TypeName(Ctl) = "TextBox" Or TypeName(Ctl) = "ComboBox" Then
        Ctl.Enabled = True
    End If
Next
End Sub

Private Sub Gelap()
Dim Ctl As Control
For Each Ctl In Me
    If TypeName(Ctl) = "TextBox" Or TypeName(Ctl) = "ComboBox" Then
        Ctl.Enabled = False
    End If
Next
End Sub

Sub CariNIM()
Call BukaDB
RSMAHASISWA.Open "Select * From MAHASISWA where NIM='" & TNIM & "'", Conn
End Sub


