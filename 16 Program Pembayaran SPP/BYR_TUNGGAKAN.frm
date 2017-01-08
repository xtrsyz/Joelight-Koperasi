VERSION 5.00
Object = "{00025600-0000-0000-C000-000000000046}#5.2#0"; "Crystl32.OCX"
Begin VB.Form BYR_TUNGGAKAN 
   Caption         =   "PEMBAYARAN TUNGGAKAN"
   ClientHeight    =   4950
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4500
   LinkTopic       =   "Form1"
   ScaleHeight     =   4950
   ScaleWidth      =   4500
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox CBONIM 
      Height          =   315
      Left            =   1320
      TabIndex        =   3
      Top             =   480
      Width           =   3000
   End
   Begin VB.CommandButton CmdInput 
      Caption         =   "&Input"
      Height          =   400
      Left            =   120
      TabIndex        =   0
      Top             =   4440
      Width           =   1250
   End
   Begin VB.CommandButton CmdEdit 
      Caption         =   "&Edit"
      Height          =   400
      Left            =   1560
      TabIndex        =   1
      Top             =   4440
      Width           =   1250
   End
   Begin VB.CommandButton CmdTutup 
      Caption         =   "&Tutup"
      Height          =   400
      Left            =   3120
      TabIndex        =   2
      Top             =   4440
      Width           =   1250
   End
   Begin VB.TextBox DIBAYAR 
      Appearance      =   0  'Flat
      Height          =   300
      Left            =   1320
      TabIndex        =   4
      Top             =   2280
      Width           =   1500
   End
   Begin VB.TextBox CARINOMOR 
      Appearance      =   0  'Flat
      Height          =   300
      Left            =   1320
      TabIndex        =   5
      Top             =   120
      Width           =   3000
   End
   Begin Crystal.CrystalReport CR 
      Left            =   3360
      Top             =   2280
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   348160
      PrintFileLinesPerPage=   60
   End
   Begin VB.ListBox List1 
      Height          =   1230
      Left            =   120
      TabIndex        =   6
      Top             =   3000
      Width           =   4215
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   " NIM"
      Height          =   300
      Left            =   120
      TabIndex        =   20
      Top             =   480
      Width           =   345
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   " Nama Siswa"
      Height          =   300
      Left            =   120
      TabIndex        =   19
      Top             =   840
      Width           =   930
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   " Kelas"
      Height          =   300
      Left            =   120
      TabIndex        =   18
      Top             =   1200
      Width           =   435
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   " Jurusan"
      Height          =   300
      Left            =   120
      TabIndex        =   17
      Top             =   1560
      Width           =   600
   End
   Begin VB.Label NAMA 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1320
      TabIndex        =   16
      Top             =   840
      Width           =   3000
   End
   Begin VB.Label KELAS 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1320
      TabIndex        =   15
      Top             =   1200
      Width           =   3000
   End
   Begin VB.Label JURUSAN 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1320
      TabIndex        =   14
      Top             =   1560
      Width           =   3000
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   " Jumlah"
      Height          =   300
      Left            =   120
      TabIndex        =   13
      Top             =   1920
      Width           =   540
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      Caption         =   " Nomor Bayar"
      Height          =   300
      Left            =   120
      TabIndex        =   12
      Top             =   120
      Width           =   960
   End
   Begin VB.Label NOMOR 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1320
      TabIndex        =   11
      Top             =   120
      Width           =   3000
   End
   Begin VB.Label JUMLAH 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1320
      TabIndex        =   10
      Top             =   1920
      Width           =   1500
   End
   Begin VB.Label Label7 
      AutoSize        =   -1  'True
      Caption         =   " Dibayar"
      Height          =   300
      Left            =   120
      TabIndex        =   9
      Top             =   2280
      Width           =   585
   End
   Begin VB.Label Label8 
      AutoSize        =   -1  'True
      Caption         =   " Kembali"
      Height          =   300
      Left            =   120
      TabIndex        =   8
      Top             =   2640
      Width           =   600
   End
   Begin VB.Label KEMBALI 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   1320
      TabIndex        =   7
      Top             =   2640
      Width           =   1500
   End
End
Attribute VB_Name = "BYR_TUNGGAKAN"
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



