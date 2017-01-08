VERSION 5.00
Object = "{00025600-0000-0000-C000-000000000046}#5.2#0"; "Crystl32.OCX"
Begin VB.Form LAP_TUNGGAKAN 
   Caption         =   "LAPORAN TUNGGAKAN"
   ClientHeight    =   2685
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4035
   LinkTopic       =   "Form1"
   ScaleHeight     =   2685
   ScaleWidth      =   4035
   StartUpPosition =   2  'CenterScreen
   Begin Crystal.CrystalReport CR 
      Left            =   1440
      Top             =   1320
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   348160
      PrintFileLinesPerPage=   60
   End
   Begin VB.Frame Frame1 
      Height          =   1095
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   3735
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   720
         TabIndex        =   0
         Top             =   240
         Width           =   1500
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   720
         TabIndex        =   1
         Top             =   600
         Width           =   1500
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Cetak Per Bulan"
         Height          =   615
         Left            =   2280
         TabIndex        =   7
         Top             =   240
         Width           =   1250
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   " Bulan"
         Height          =   195
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   450
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   " Tahun"
         Height          =   195
         Left            =   120
         TabIndex        =   8
         Top             =   600
         Width           =   510
      End
   End
   Begin VB.Frame Frame2 
      Height          =   1215
      Left            =   120
      TabIndex        =   3
      Top             =   1320
      Width           =   3735
      Begin VB.ComboBox Combo4 
         Height          =   315
         Left            =   720
         TabIndex        =   10
         Top             =   720
         Width           =   1500
      End
      Begin VB.ComboBox Combo3 
         Height          =   315
         Left            =   720
         TabIndex        =   2
         Top             =   360
         Width           =   1500
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Cetak"
         Height          =   615
         Left            =   2280
         TabIndex        =   4
         Top             =   360
         Width           =   1250
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   " Tahun"
         Height          =   195
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   510
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   " Kelas"
         Height          =   195
         Left            =   120
         TabIndex        =   5
         Top             =   360
         Width           =   435
      End
   End
End
Attribute VB_Name = "LAP_TUNGGAKAN"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Call BukaDB
Dim RSBLN As New ADODB.Recordset
RSBLN.Open "select distinct MONTH(BULAN)  as BLN from TUNGGAKAN", Conn
Do While Not RSBLN.EOF
    Combo1.AddItem RSBLN!BLN
    RSBLN.MoveNext
Loop

Dim RSTHN As New ADODB.Recordset
RSTHN.Open "select distinct year(BULAN)  as Tahun from TUNGGAKAN", Conn
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
RSTUNGGAKAN.Open "select * from tunggakan where month(bulan)='" & Combo1 & "' and year (bulan)='" & Combo2 & "'", Conn
If RSTUNGGAKAN.EOF Then
    MsgBox "DATA TIDAK DITEMUKAN"
    Exit Sub
ElseIf Combo1 = "" Or Combo2 = "" Then
    MsgBox "BULAN DAN TAHUN HARUS DIISI"
    If Combo1 = "" Then
        Combo1.SetFocus
    ElseIf Combo2 = "" Then
        Combo2.SetFocus
    End If
Else
    CR.SelectionFormula = "Month({TUNGGAKAN.BULAN})=" & Combo1 & " and Year({TUNGGAKAN.BULAN})=" & Combo2
    CR.ReportFileName = App.Path & "\Lap TUNGGAKAN BLN.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub

Private Sub Command2_Click()
Call BukaDB
RSTUNGGAKAN.Open "SELECT KELAS,BULAN FROM MAHASISWA,TUNGGAKAN WHERE MAHASISWA.NIM=TUNGGAKAN.NIM AND KELAS='" & Combo3 & "' AND YEAR(BULAN)='" & Combo4 & "'", Conn
If RSTUNGGAKAN.EOF Then
    MsgBox "DATA TIDAK DITEMUKAN"
    Exit Sub
Else
    CR.SelectionFormula = "YEAR({TUNGGAKAN.BULAN})=" & Val(Combo4) & " AND {MAHASISWA.KELAS}='" & Combo3 & "'"
    CR.ReportFileName = App.Path & "\Lap TUNGGAKAN PER KELAS.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End If
End Sub



