VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form SPP1 
   Caption         =   "PEMBAYARAN SPP"
   ClientHeight    =   7035
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4965
   LinkTopic       =   "Form1"
   ScaleHeight     =   7035
   ScaleWidth      =   4965
   StartUpPosition =   2  'CenterScreen
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   1200
      Top             =   4080
      Visible         =   0   'False
      Width           =   2055
      _ExtentX        =   3625
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Data Buku VB ke 5\7 Program Pembayaran SPP\DBSPP.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Data Buku VB ke 5\7 Program Pembayaran SPP\DBSPP.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "TRSPP"
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
   Begin VB.TextBox NIM 
      Height          =   350
      Left            =   1680
      TabIndex        =   5
      Top             =   120
      Width           =   1500
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "SPP1.frx":0000
      Height          =   4815
      Left            =   120
      TabIndex        =   10
      Top             =   2040
      Width           =   4695
      _ExtentX        =   8281
      _ExtentY        =   8493
      _Version        =   393216
      AllowUpdate     =   -1  'True
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
         DataField       =   "NO"
         Caption         =   "NO"
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
         DataField       =   "BULAN"
         Caption         =   "BULAN"
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
         DataField       =   "TANGGAL"
         Caption         =   "TANGGAL"
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
         DataField       =   "JUMLAH"
         Caption         =   "JUMLAH"
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
            ColumnWidth     =   494,929
         EndProperty
         BeginProperty Column01 
            ColumnWidth     =   1739,906
         EndProperty
         BeginProperty Column02 
            ColumnWidth     =   1005,165
         EndProperty
         BeginProperty Column03 
            ColumnWidth     =   1005,165
         EndProperty
      EndProperty
   End
   Begin VB.Label TAHUN 
      BorderStyle     =   1  'Fixed Single
      Height          =   350
      Left            =   1680
      TabIndex        =   9
      Top             =   1560
      Width           =   1500
   End
   Begin VB.Label JURUSAN 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   1680
      TabIndex        =   8
      Top             =   1200
      Width           =   3000
   End
   Begin VB.Label KELAS 
      BorderStyle     =   1  'Fixed Single
      Height          =   350
      Left            =   1680
      TabIndex        =   7
      Top             =   840
      Width           =   3000
   End
   Begin VB.Label NAMA 
      BorderStyle     =   1  'Fixed Single
      Height          =   350
      Left            =   1680
      TabIndex        =   6
      Top             =   480
      Width           =   3000
   End
   Begin VB.Label Label5 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " TAHUN"
      Height          =   350
      Left            =   120
      TabIndex        =   4
      Top             =   1560
      Width           =   1500
   End
   Begin VB.Label Label4 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " JURUSAN"
      Height          =   350
      Left            =   120
      TabIndex        =   3
      Top             =   1200
      Width           =   1500
   End
   Begin VB.Label Label3 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " KELAS"
      Height          =   350
      Left            =   120
      TabIndex        =   2
      Top             =   840
      Width           =   1500
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " NAMA"
      Height          =   350
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   1500
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " NIM"
      Height          =   350
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1500
   End
End
Attribute VB_Name = "SPP1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Call BukaDB

End Sub

Private Sub Text1_Change()

End Sub

Private Sub NIM_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then
    If NIM = "" Then
        MsgBox "NIM WAJIB DIISI"
        NIM.SetFocus
        Exit Sub
    Else
        Call BukaDB
        RSMAHASISWA.Open "SELECT * FROM MAHASISWA WHERE NIM='" & NIM & "'", Conn
        If RSMAHASISWA.EOF Then
            MsgBox "NIM TIDAK TERDAFTAR"
            NIM.SetFocus
            Exit Sub
        Else
            NAMA = RSMAHASISWA!NAMA
            KELAS = RSMAHASISWA!KELAS
            JURUSAN = RSMAHASISWA!JURUSAN
            TAHUN = Year(Date)
        End If
        
        RSTRSPP.Open "SELECT * FROM SPP WHERE YEAR(TANGGAL)='" & TAHUN & "' AND NIM='" & NIM & "'", Conn
        If RSTRSPP.EOF Then
            MsgBox "DATA SPP TIDAK DITEMUKAN"
            NIM.SetFocus
            Exit Sub
        Else
            Call Tabel_Kosong
            RSTRSPP.MoveFirst
            NOMOR = 0
            Do While Not RSTRSPP.EOF
                NOMOR = NOMOR + 1
                Adodc1.Recordset.AddNew
                Adodc1.Recordset!NO = NOMOR
                'Adodc1.Recordset!NIM = RSTRSPP!NIM
                'Adodc1.Recordset!NAMA = RSTRSPP!NAMA
                Adodc1.Recordset!BULAN = TGLAKHIR
                Adodc1.Recordset!TANGGAL = TGLAKHIR
                Adodc1.Recordset!JUMLAH = 100000
                Adodc1.Recordset.Update
                RSTRSPP.MoveNext
            Loop
            Adodc1.Recordset.MoveFirst
        End If
    End If
End If
End Sub


Function Tabel_Kosong()
If Adodc1.Recordset.RecordCount > 0 Then
    Adodc1.Recordset.MoveFirst
    Do While Not Adodc1.Recordset.EOF
        Adodc1.Recordset.Delete
        Adodc1.Recordset.MoveNext
    Loop
End If
End Function

