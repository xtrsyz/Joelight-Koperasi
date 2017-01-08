VERSION 5.00
Begin VB.Form SalinFile 
   ClientHeight    =   3765
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6015
   LinkTopic       =   "Form2"
   ScaleHeight     =   3765
   ScaleWidth      =   6015
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command1 
      Caption         =   "Copy File"
      Height          =   750
      Left            =   4800
      TabIndex        =   9
      Top             =   2880
      Width           =   1000
   End
   Begin VB.TextBox Text2 
      Height          =   350
      Left            =   1440
      TabIndex        =   8
      Top             =   3240
      Width           =   3350
   End
   Begin VB.TextBox Text1 
      Height          =   350
      Left            =   1440
      TabIndex        =   7
      Top             =   2880
      Width           =   3350
   End
   Begin VB.Frame Frame2 
      Caption         =   "Direktori Tujuan"
      Height          =   2175
      Left            =   3840
      TabIndex        =   4
      Top             =   600
      Width           =   2055
      Begin VB.DirListBox Dir2 
         Height          =   1215
         Left            =   120
         TabIndex        =   6
         Top             =   720
         Width           =   1750
      End
      Begin VB.DriveListBox Drive2 
         Height          =   315
         Left            =   120
         TabIndex        =   5
         Top             =   360
         Width           =   1750
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "File Sumber"
      Height          =   2175
      Left            =   120
      TabIndex        =   0
      Top             =   600
      Width           =   3615
      Begin VB.FileListBox File1 
         Height          =   1650
         Left            =   2160
         Pattern         =   "*.mdb"
         TabIndex        =   3
         Top             =   360
         Width           =   1300
      End
      Begin VB.DirListBox Dir1 
         Height          =   1215
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   2000
      End
      Begin VB.DriveListBox Drive1 
         Height          =   315
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   2000
      End
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      BackColor       =   &H008080FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Backup Database"
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
      TabIndex        =   12
      Top             =   0
      Width           =   6255
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Direktori Tujuan"
      Height          =   345
      Left            =   120
      TabIndex        =   11
      Top             =   3240
      Width           =   1305
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   " Direktori Asal"
      Height          =   345
      Left            =   120
      TabIndex        =   10
      Top             =   2880
      Width           =   1305
   End
End
Attribute VB_Name = "SalinFile"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Declare Function SHFileOperation Lib "Shell32.dll" Alias "SHFileOperationA" (lpFileOP As shfileopstruct) As Long
Private Const FO_copy = &H2
Private Const fof_allowundo = &H40

Private Type shfileopstruct
    hwnd As Long
    wfunc As Long
    pfrom As String
    pto As String
    Fflags As Integer
    Faborted As Boolean
    hnamemaps As Long
    sprogress As String
End Type

Public Sub copy(ByVal asal As String, ByVal tujuan As String)
Dim x As shfileopstruct
    With x
        .hwnd = 0
        .wfunc = FO_copy
        .pfrom = asal & vbNullChar & vbNullChar
        .pto = tujuan & vbNullChar & vbNullChar
        .Fflags = fof_allowundo
    End With
    SHFileOperation x
End Sub

Private Sub Command1_Click()
On Error Resume Next
If Text1 = "" Then
    MsgBox "Anda belum memilih file yang akan dicopy"
    Exit Sub
ElseIf Text2 = "" Then
    MsgBox "Anda tidak memilih direktori tujuan peng-Copy-an"
    Exit Sub
End If
copy Text1.Text, Text2.Text
MsgBox "File sudah di copy"
End Sub

Private Sub Command1_KeyPress(Keyascii As Integer)
If Keyascii = 27 Then Unload Me
End Sub

Private Sub Drive1_Change()
Dir1.Path = Drive1.Drive
End Sub

Private Sub Drive2_Change()
Dir2.Path = Drive2.Drive
End Sub

Private Sub Dir1_Change()
File1.Path = Dir1.Path
End Sub

Private Sub Dir2_Change()
Text2.Text = Dir2.Path
End Sub

Private Sub File1_Click()
Text1.Text = File1.Path & "\" & File1.FileName
End Sub


