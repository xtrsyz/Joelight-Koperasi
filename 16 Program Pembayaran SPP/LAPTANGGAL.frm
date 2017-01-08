VERSION 5.00
Object = "{00025600-0000-0000-C000-000000000046}#5.2#0"; "Crystl32.OCX"
Begin VB.Form LAPTANGGAL 
   Caption         =   "LAPORAN PEMBAYARAN SPP"
   ClientHeight    =   3750
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4710
   LinkTopic       =   "Form1"
   ScaleHeight     =   3750
   ScaleWidth      =   4710
   StartUpPosition =   2  'CenterScreen
   Begin Crystal.CrystalReport CR 
      Left            =   1920
      Top             =   2160
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   348160
      PrintFileLinesPerPage=   60
   End
   Begin VB.Frame Frame3 
      Caption         =   "Bulanan"
      Height          =   1215
      Left            =   120
      TabIndex        =   10
      Top             =   2400
      Width           =   4455
      Begin VB.CommandButton Command3 
         Caption         =   "Cetak Per Bulan"
         Height          =   735
         Left            =   2880
         TabIndex        =   15
         Top             =   360
         Width           =   1455
      End
      Begin VB.ComboBox Combo4 
         Height          =   315
         Left            =   1320
         TabIndex        =   3
         Top             =   360
         Width           =   1500
      End
      Begin VB.ComboBox Combo5 
         Height          =   315
         Left            =   1320
         TabIndex        =   4
         Top             =   720
         Width           =   1500
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   " Tahun"
         Height          =   195
         Left            =   120
         TabIndex        =   12
         Top             =   720
         Width           =   510
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         Caption         =   " Bulan"
         Height          =   195
         Left            =   120
         TabIndex        =   11
         Top             =   360
         Width           =   450
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Harian"
      Height          =   855
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   4455
      Begin VB.CommandButton Command1 
         Caption         =   "Cetak Per Harian"
         Height          =   495
         Left            =   2880
         TabIndex        =   13
         Top             =   240
         Width           =   1455
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   1320
         TabIndex        =   0
         Top             =   360
         Width           =   1500
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Tanggal"
         Height          =   195
         Left            =   120
         TabIndex        =   9
         Top             =   360
         Width           =   585
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Mingguan"
      Height          =   1215
      Left            =   120
      TabIndex        =   5
      Top             =   1080
      Width           =   4455
      Begin VB.CommandButton Command2 
         Caption         =   "Cetak Per MInggu"
         Height          =   735
         Left            =   2880
         TabIndex        =   14
         Top             =   360
         Width           =   1455
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   1320
         TabIndex        =   1
         Top             =   360
         Width           =   1500
      End
      Begin VB.ComboBox Combo3 
         Height          =   315
         Left            =   1320
         TabIndex        =   2
         Top             =   720
         Width           =   1500
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "Tanggal Awal"
         Height          =   195
         Left            =   120
         TabIndex        =   7
         Top             =   360
         Width           =   975
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   "Tanggal Akhir"
         Height          =   195
         Left            =   120
         TabIndex        =   6
         Top             =   720
         Width           =   990
      End
   End
End
Attribute VB_Name = "LAPTANGGAL"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Call BukaDB
RSSPP.Open "Select Distinct TANGGAL From SPP order By 1", Conn
RSSPP.Requery
Do Until RSSPP.EOF
    Combo1.AddItem Format(RSSPP!TANGGAL, "DD-MMM-YYYY")
    Combo2.AddItem Format(RSSPP!TANGGAL, "YYYY ,MM, DD")
    Combo3.AddItem Format(RSSPP!TANGGAL, "YYYY ,MM, DD")
    RSSPP.MoveNext
Loop
Conn.Close

Call BukaDB
Dim RSTGL As New ADODB.Recordset
RSTGL.Open "select distinct month(TANGGAL) as Bulan from SPP", Conn
Do While Not RSTGL.EOF
    Combo4.AddItem RSTGL!BULAN & Space(5) & MonthName(RSTGL!BULAN)
    RSTGL.MoveNext
Loop
Conn.Close

Call BukaDB
Dim RSTHN As New ADODB.Recordset
RSTHN.Open "select distinct year(TANGGAL)  as Tahun from SPP", Conn
Do While Not RSTHN.EOF
    Combo5.AddItem RSTHN!Tahun
    RSTHN.MoveNext
Loop
Conn.Close
End Sub

Private Sub Command1_Click()
If Combo1 = "" Then
    MsgBox "PILIH TANGGALNYA DULU..."
    Exit Sub
Else
    CR.SelectionFormula = "Totext({SPP.TANGGAL})='" & CDate(Combo1) & "'"
    CR.ReportFileName = App.Path & "\Lap SPP Harian.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub

Private Sub Command2_Click()
If Combo2 = "" Or Combo3 = "" Then
    MsgBox "PILIH TANGGAL AWAL DAN TANGGAL AKHIRNYA..."
    Exit Sub
Else
    CR.SelectionFormula = "{SPP.TANGGAL} in date (" & Combo2.Text & ") to date (" & Combo3.Text & ")"
    CR.ReportFileName = App.Path & "\Lap SPP Mingguan.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub

Private Sub Command3_Click()
If Combo4 = "" Or Combo5 = "" Then
    MsgBox "PILIH BULAN DAN TAHUNYA DULU..."
    Exit Sub
Else
    Call BukaDB
    RSSPP.Open "select * from SPP where month(TANGGAL)='" & Val(Combo4) & "' and year(TANGGAL)='" & (Combo5) & "'", Conn
    If RSSPP.EOF Then
        MsgBox "Data tidak ditemukan"
        Exit Sub
        Combo4.SetFocus
    End If

    CR.SelectionFormula = "Month({SPP.TANGGAL})=" & Val(Combo4.Text) & " and Year({SPP.TANGGAL})=" & Val(Combo5.Text)
    CR.ReportFileName = App.Path & "\Lap SPP Bulanan.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub


