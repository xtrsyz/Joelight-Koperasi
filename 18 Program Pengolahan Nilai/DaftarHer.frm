VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form DaftarHer 
   Caption         =   "Pendaftaran Ujian Her"
   ClientHeight    =   5655
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   7350
   LinkTopic       =   "Form1"
   ScaleHeight     =   5655
   ScaleWidth      =   7350
   StartUpPosition =   2  'CenterScreen
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "DaftarHer.frx":0000
      Height          =   4095
      Left            =   120
      TabIndex        =   6
      Top             =   960
      Width           =   5175
      _ExtentX        =   9128
      _ExtentY        =   7223
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
         DataField       =   "Nomor"
         Caption         =   "No"
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
         DataField       =   "Kode"
         Caption         =   "Kode"
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
         DataField       =   "Nama"
         Caption         =   "Nama"
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
         DataField       =   "SKS"
         Caption         =   "SKS"
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
            Alignment       =   2
            Locked          =   -1  'True
            ColumnWidth     =   494,929
         EndProperty
         BeginProperty Column01 
            Alignment       =   2
            ColumnWidth     =   750,047
         EndProperty
         BeginProperty Column02 
            Locked          =   -1  'True
            ColumnWidth     =   2849,953
         EndProperty
         BeginProperty Column03 
            Alignment       =   2
            Locked          =   -1  'True
            ColumnWidth     =   494,929
         EndProperty
      EndProperty
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   3720
      Top             =   5160
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
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
   Begin VB.ListBox List1 
      Height          =   4545
      Left            =   5400
      Sorted          =   -1  'True
      TabIndex        =   11
      Top             =   480
      Width           =   1815
   End
   Begin VB.CommandButton CmdTutup 
      Caption         =   "Tutup"
      Height          =   350
      Left            =   2640
      TabIndex        =   9
      Top             =   5160
      Width           =   850
   End
   Begin VB.CommandButton CmdBatal 
      Caption         =   "Batal"
      Height          =   350
      Left            =   1800
      TabIndex        =   8
      Top             =   5160
      Width           =   850
   End
   Begin VB.CommandButton CmdSimpan 
      Caption         =   "Simpan"
      Height          =   350
      Left            =   960
      TabIndex        =   7
      Top             =   5160
      Width           =   850
   End
   Begin VB.TextBox TxtNIM 
      Height          =   350
      Left            =   1080
      TabIndex        =   1
      Top             =   120
      Width           =   1000
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Kode Mata Kuliah"
      Height          =   345
      Left            =   5400
      TabIndex        =   13
      Top             =   120
      Width           =   1785
   End
   Begin VB.Label JmlList 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   5400
      TabIndex        =   12
      Top             =   5160
      Width           =   1815
   End
   Begin VB.Label JmlKode 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   120
      TabIndex        =   10
      Top             =   5160
      Width           =   750
   End
   Begin VB.Label LblJurusan 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2160
      TabIndex        =   5
      Top             =   480
      Width           =   3100
   End
   Begin VB.Label LblKelas 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   1080
      TabIndex        =   4
      Top             =   480
      Width           =   1005
   End
   Begin VB.Label Label3 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Kelas"
      Height          =   345
      Left            =   120
      TabIndex        =   3
      Top             =   480
      Width           =   950
   End
   Begin VB.Label LblNamaMhs 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2160
      TabIndex        =   2
      Top             =   120
      Width           =   3100
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " NIM"
      Height          =   345
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   950
   End
End
Attribute VB_Name = "DaftarHer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'jika anda berminat silakan jadi anggota
'Biaya keanggotaan Rp 100.000

'Transaksi dengan cara transfer ke salah satu rekening di bawah ini :
'No Rek: 066 - 0525 - 947 (BCA an. Uus Rusmawan)
'No Rek: 156 - 000 - 250 - 2146 (Mandiri an. Uus Rusmawan)
'No Rek : 0139 - 0106 - 3038 - 504 (BRI an. Uus Rusmawan)
'setelah itu segera lakukan konfirmasi permbayaran yg sudah disediakn di web www.konsultasivb.com


