VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomct2.ocx"
Begin VB.Form TUNGGAKAN 
   Caption         =   "CARI DAN PROSES DATA TUNGGAKAN"
   ClientHeight    =   5010
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5970
   LinkTopic       =   "Form1"
   ScaleHeight     =   5010
   ScaleWidth      =   5970
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      Caption         =   " Simpan Data Tunggakan"
      Height          =   450
      Left            =   2880
      TabIndex        =   2
      Top             =   4440
      Width           =   2895
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "TUNGGAKAN.frx":0000
      Height          =   3015
      Left            =   120
      TabIndex        =   5
      Top             =   1320
      Width           =   5655
      _ExtentX        =   9975
      _ExtentY        =   5318
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
      ColumnCount     =   5
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
      BeginProperty Column02 
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
      BeginProperty Column03 
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
      BeginProperty Column04 
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
            Alignment       =   2
            ColumnWidth     =   750,047
         EndProperty
         BeginProperty Column01 
            Alignment       =   2
            ColumnWidth     =   1005,165
         EndProperty
         BeginProperty Column02 
            ColumnWidth     =   1500,095
         EndProperty
         BeginProperty Column03 
            Alignment       =   2
            ColumnWidth     =   1005,165
         EndProperty
         BeginProperty Column04 
            Alignment       =   1
            ColumnWidth     =   1005,165
         EndProperty
      EndProperty
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   345
      Left            =   3720
      Top             =   120
      Visible         =   0   'False
      Width           =   1935
      _ExtentX        =   3413
      _ExtentY        =   609
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
   Begin VB.CommandButton Command1 
      Caption         =   " Tampilkan Data Tunggakan"
      Height          =   450
      Left            =   120
      TabIndex        =   1
      Top             =   4440
      Width           =   2655
   End
   Begin MSComCtl2.DTPicker BLNTUNGGAKAN 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "d/MM/yyyy"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   3
      EndProperty
      Height          =   345
      Left            =   2040
      TabIndex        =   0
      Top             =   480
      Width           =   1500
      _ExtentX        =   2646
      _ExtentY        =   609
      _Version        =   393216
      Format          =   20643841
      CurrentDate     =   39891
   End
   Begin VB.Label TGLSEKARANG 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2040
      TabIndex        =   8
      Top             =   120
      Width           =   1500
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      Caption         =   " Tgl Sekarang"
      Height          =   195
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   1005
   End
   Begin VB.Label TGLAKHIR 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2040
      TabIndex        =   6
      Top             =   840
      Width           =   1500
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   " Tgl Akhir Pembayaran"
      Height          =   195
      Left            =   120
      TabIndex        =   4
      Top             =   840
      Width           =   1605
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   " Bln/Thn Tunggakan"
      Height          =   195
      Left            =   120
      TabIndex        =   3
      Top             =   480
      Width           =   1500
   End
End
Attribute VB_Name = "TUNGGAKAN"
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



