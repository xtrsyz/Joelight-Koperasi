VERSION 5.00
Object = "{00025600-0000-0000-C000-000000000046}#5.2#0"; "Crystl32.OCX"
Begin VB.Form LAPORAN 
   Caption         =   "LAPORAN PEMBAYARAN SPP"
   ClientHeight    =   2670
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4005
   LinkTopic       =   "Form1"
   ScaleHeight     =   2670
   ScaleWidth      =   4005
   StartUpPosition =   2  'CenterScreen
   Begin Crystal.CrystalReport CR 
      Left            =   1200
      Top             =   1200
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   348160
      PrintFileLinesPerPage=   60
   End
   Begin VB.Frame Frame2 
      Height          =   1215
      Left            =   120
      TabIndex        =   5
      Top             =   1320
      Width           =   3735
      Begin VB.CommandButton Command2 
         Caption         =   "Cetak Per Kelas"
         Height          =   735
         Left            =   2280
         TabIndex        =   11
         Top             =   360
         Width           =   1250
      End
      Begin VB.ComboBox Combo4 
         Height          =   315
         Left            =   720
         TabIndex        =   9
         Top             =   720
         Width           =   1500
      End
      Begin VB.ComboBox Combo3 
         Height          =   315
         Left            =   720
         TabIndex        =   8
         Top             =   360
         Width           =   1500
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   " Tahun"
         Height          =   195
         Left            =   120
         TabIndex        =   7
         Top             =   720
         Width           =   510
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   " Kelas"
         Height          =   195
         Left            =   120
         TabIndex        =   6
         Top             =   360
         Width           =   435
      End
   End
   Begin VB.Frame Frame1 
      Height          =   1215
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3735
      Begin VB.CommandButton Command1 
         Caption         =   "Cetak Per Nim"
         Height          =   735
         Left            =   2280
         TabIndex        =   10
         Top             =   360
         Width           =   1250
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   720
         TabIndex        =   4
         Top             =   720
         Width           =   1500
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   720
         TabIndex        =   2
         Top             =   360
         Width           =   1500
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   " Tahun"
         Height          =   195
         Left            =   120
         TabIndex        =   3
         Top             =   720
         Width           =   510
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   " NIM"
         Height          =   195
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   345
      End
   End
End
Attribute VB_Name = "LAPORAN"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub Form_Load()
Call BukaDB
RSSPP.Open "Select Distinct NIM From SPP order By 1", Conn
RSSPP.Requery
Do Until RSSPP.EOF
    Combo1.AddItem RSSPP!NIM
    RSSPP.MoveNext
Loop

Dim RSTHN As New ADODB.Recordset
RSTHN.Open "select distinct year(TANGGAL)  as Tahun from SPP", Conn
Do While Not RSTHN.EOF
    Combo2.AddItem RSTHN!Tahun
    Combo4.AddItem RSTHN!Tahun
    RSTHN.MoveNext
Loop

RSMAHASISWA.Open "Select Distinct KELAS FROM MAHASISWA order By 1", Conn
RSMAHASISWA.Requery
Do Until RSMAHASISWA.EOF
    Combo3.AddItem RSMAHASISWA!KELAS
    RSMAHASISWA.MoveNext
Loop
Conn.Close
End Sub


Private Sub Command1_Click()
Call BukaDB
RSSPP.Open "SELECT * FROM SPP WHERE NIM='" & Combo1 & "' AND YEAR(TANGGAL)='" & Combo2 & "'", Conn
If RSSPP.EOF Then
    MsgBox "DATA TIDAK DITEMUKAN"
    Exit Sub
Else
    CR.SelectionFormula = "{SPP.NIM}='" & Combo1 & "' and Year({SPP.TANGGAL})=" & Val(Combo2.Text)
    CR.ReportFileName = App.Path & "\Lap spp per nim.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub

Private Sub Command2_Click()
Call BukaDB
RSSPP.Open "SELECT KELAS,TANGGAL FROM MAHASISWA,SPP WHERE MAHASISWA.NIM=SPP.NIM AND KELAS='" & Combo3 & "' AND YEAR(TANGGAL)='" & Combo4 & "'", Conn
If RSSPP.EOF Then
    MsgBox "DATA TIDAK DITEMUKAN"
    Exit Sub
Else
    CR.SelectionFormula = "{MAHASISWA.KELAS}='" & Combo3 & "' and Year({SPP.TANGGAL})=" & Val(Combo4.Text)
    CR.ReportFileName = App.Path & "\Lap spp per KELAS.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub


