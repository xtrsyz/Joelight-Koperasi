VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form Pendaftaran 
   ClientHeight    =   6075
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8355
   LinkTopic       =   "Form1"
   ScaleHeight     =   6075
   ScaleWidth      =   8355
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CmdPasienBaru 
      Caption         =   "Pasien Baru"
      Height          =   375
      Left            =   4200
      TabIndex        =   28
      Top             =   3480
      Width           =   3855
   End
   Begin VB.ListBox List1 
      Height          =   1035
      Left            =   120
      TabIndex        =   5
      Top             =   2280
      Width           =   3855
   End
   Begin VB.CommandButton CmdInput 
      Caption         =   "&Input"
      Height          =   400
      Left            =   120
      TabIndex        =   0
      Top             =   3480
      Width           =   1000
   End
   Begin VB.CommandButton CmdSimpan 
      Caption         =   "&Simpan"
      Height          =   400
      Left            =   1080
      TabIndex        =   1
      Top             =   3480
      Width           =   1000
   End
   Begin VB.CommandButton CmdBatal 
      Caption         =   "&Batal"
      Height          =   400
      Left            =   2040
      TabIndex        =   2
      Top             =   3480
      Width           =   1000
   End
   Begin VB.CommandButton CmdTutup 
      Caption         =   "&Tutup"
      Height          =   400
      Left            =   3000
      TabIndex        =   3
      Top             =   3480
      Width           =   1000
   End
   Begin VB.ComboBox Combo2 
      Height          =   315
      Left            =   6120
      TabIndex        =   6
      Top             =   600
      Width           =   2000
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   2040
      TabIndex        =   4
      Top             =   1440
      Width           =   2000
   End
   Begin VB.TextBox Telepon 
      Height          =   350
      Left            =   6120
      TabIndex        =   11
      Top             =   2400
      Width           =   2000
   End
   Begin VB.TextBox Umur 
      Height          =   350
      Left            =   6120
      TabIndex        =   10
      Top             =   2040
      Width           =   2000
   End
   Begin VB.TextBox Gender 
      Height          =   350
      Left            =   6120
      TabIndex        =   9
      Top             =   1680
      Width           =   2000
   End
   Begin VB.TextBox Alamat 
      Height          =   350
      Left            =   6120
      TabIndex        =   8
      Top             =   1320
      Width           =   2000
   End
   Begin VB.TextBox Nama 
      Height          =   350
      Left            =   6120
      TabIndex        =   7
      Top             =   960
      Width           =   2000
   End
   Begin MSDataGridLib.DataGrid DG 
      Height          =   1845
      Left            =   120
      TabIndex        =   27
      Top             =   4080
      Width           =   8055
      _ExtentX        =   14208
      _ExtentY        =   3254
      _Version        =   393216
      AllowUpdate     =   0   'False
      HeadLines       =   2
      RowHeight       =   15
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
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin MSAdodcLib.Adodc ADO 
      Height          =   330
      Left            =   120
      Top             =   6240
      Visible         =   0   'False
      Width           =   3120
      _ExtentX        =   5503
      _ExtentY        =   582
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
   Begin VB.Label Label12 
      Alignment       =   2  'Center
      BackColor       =   &H008080FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Data Pendaftaran"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   0
      TabIndex        =   29
      Top             =   0
      Width           =   8415
   End
   Begin VB.Label Biaya 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   6120
      TabIndex        =   26
      Top             =   2880
      Width           =   1995
   End
   Begin VB.Label NomorAntri 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2040
      TabIndex        =   25
      Top             =   1800
      Width           =   1995
   End
   Begin VB.Label TanggalDft 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2040
      TabIndex        =   24
      Top             =   960
      Width           =   1995
   End
   Begin VB.Label NomorDft 
      BorderStyle     =   1  'Fixed Single
      Height          =   345
      Left            =   2040
      TabIndex        =   23
      Top             =   600
      Width           =   1995
   End
   Begin VB.Label Label11 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Biaya"
      Height          =   345
      Left            =   4200
      TabIndex        =   22
      Top             =   2880
      Width           =   1755
   End
   Begin VB.Label Label10 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Kode Poli"
      Height          =   345
      Left            =   120
      TabIndex        =   21
      Top             =   1440
      Width           =   1755
   End
   Begin VB.Label Label9 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Telepon"
      Height          =   345
      Left            =   4200
      TabIndex        =   20
      Top             =   2400
      Width           =   1755
   End
   Begin VB.Label Label8 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Umur"
      Height          =   345
      Left            =   4200
      TabIndex        =   19
      Top             =   2040
      Width           =   1755
   End
   Begin VB.Label Label7 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Gender"
      Height          =   345
      Left            =   4200
      TabIndex        =   18
      Top             =   1680
      Width           =   1755
   End
   Begin VB.Label Label6 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Alamat"
      Height          =   345
      Left            =   4200
      TabIndex        =   17
      Top             =   1320
      Width           =   1755
   End
   Begin VB.Label Label5 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Nama Pasien"
      Height          =   345
      Left            =   4200
      TabIndex        =   16
      Top             =   960
      Width           =   1755
   End
   Begin VB.Label Label4 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Kode Pasien"
      Height          =   345
      Left            =   4200
      TabIndex        =   15
      Top             =   600
      Width           =   1755
   End
   Begin VB.Label Label3 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Nomor Antrian"
      Height          =   345
      Left            =   120
      TabIndex        =   14
      Top             =   1800
      Width           =   1755
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Tanggal"
      Height          =   345
      Left            =   120
      TabIndex        =   13
      Top             =   960
      Width           =   1755
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Nomor Pendaftaran"
      Height          =   345
      Left            =   120
      TabIndex        =   12
      Top             =   600
      Width           =   1755
   End
End
Attribute VB_Name = "Pendaftaran"
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
'setelah itu segera lakukan konfirmasi permbayaran yg sudah disediakn di web


