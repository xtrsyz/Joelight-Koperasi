VERSION 5.00
Object = "{00025600-0000-0000-C000-000000000046}#5.2#0"; "Crystl32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form MENU 
   Caption         =   "MENU UTAMA PORGRAM SPP"
   ClientHeight    =   3090
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   Picture         =   "MENU.frx":0000
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin Crystal.CrystalReport CR 
      Left            =   1560
      Top             =   1200
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   348160
      PrintFileLinesPerPage=   60
   End
   Begin ComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   2715
      Width           =   4680
      _ExtentX        =   8255
      _ExtentY        =   661
      SimpleText      =   ""
      _Version        =   327682
      BeginProperty Panels {0713E89E-850A-101B-AFC0-4210102A8DA7} 
         NumPanels       =   2
         BeginProperty Panel1 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Object.Visible         =   0   'False
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel2 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            TextSave        =   ""
            Object.Tag             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Menu MNFILE 
      Caption         =   "FILE"
      Begin VB.Menu MNMAHASISWA 
         Caption         =   "MAHASISWA"
      End
      Begin VB.Menu MNCETAKKARTU 
         Caption         =   "CETAK KARTU SPP"
      End
   End
   Begin VB.Menu MNTRANSAKSI 
      Caption         =   "TRANSAKSI"
      Begin VB.Menu MNBAYARSPP 
         Caption         =   "BAYAR SPP"
      End
      Begin VB.Menu MNTUNGGAKAN 
         Caption         =   "CARI DATA TUNGGAKAN"
      End
      Begin VB.Menu MNBYRTUNGGAKAN 
         Caption         =   "BAYAR TUNGGAKAN"
      End
   End
   Begin VB.Menu MNLAPORAN 
      Caption         =   "LAPORAN"
      Begin VB.Menu MNLAPNIMKELAS 
         Caption         =   "LAPORAN SPP PER NIM DAN PER KELAS"
      End
      Begin VB.Menu MNLAPTANGGAL 
         Caption         =   "LAPORAN SPP HARIAN, MINGGUAN, BULANAN"
      End
      Begin VB.Menu MNLAPTUNGGAKAN 
         Caption         =   "LAPORAN TUNGGAKAN SPP"
      End
   End
   Begin VB.Menu MNKELUAR 
      Caption         =   "KELUAR"
   End
End
Attribute VB_Name = "MENU"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyPress(Keyascii As Integer)
If Keyascii = 27 Then
    Pesan = MsgBox("Yakin akan ditutup...?", vbYesNo)
    If Pesan = vbYes Then End
End If
If Keyascii = 13 Then
    TUNGGAKAN.Show
End If

End Sub

Private Sub MNBAYARSPP_Click()
SPP.Show vbModal
End Sub

Private Sub MNBYRTUNGGAKAN_Click()
BYR_TUNGGAKAN.Show vbModal
End Sub

Private Sub MNCETAKKARTU_Click()
    CR.ReportFileName = App.Path & "\KARTU SPP.rpt"
    CR.WindowState = crptMaximized
    CR.RetrieveDataFiles
    CR.Action = 1
End Sub

Private Sub MNKELUAR_Click()
End
End Sub

Private Sub MNLAPNIMKELAS_Click()
LAPORAN.Show vbModal
End Sub


Private Sub MNLAPTANGGAL_Click()
LAPTANGGAL.Show vbModal
End Sub

Private Sub MNLAPTUNGGAKAN_Click()
LAP_TUNGGAKAN.Show vbModal
End Sub

Private Sub MNMAHASISWA_Click()
MAHASISWA.Show vbModal
End Sub

Private Sub MNSPP1_Click()
SPP1.Show vbModal
End Sub

Private Sub MNTUNGGAKAN_Click()
TUNGGAKAN.Show vbModal
End Sub

Private Sub MNUJISQL_Click()
UjiSQL.Show vbModal
End Sub
