Attribute VB_Name = "Module1"

Public Conn As New ADODB.Connection
Public RSSPP As ADODB.Recordset
Public RSTUNGGAKAN As ADODB.Recordset
Public RSMAHASISWA As ADODB.Recordset
Public RSKASIR As ADODB.Recordset
Public RSTRSPP As ADODB.Recordset


Public Sub BukaDB()
Set Conn = New ADODB.Connection
Set RSSPP = New ADODB.Recordset
Set RSTUNGGAKAN = New ADODB.Recordset
Set RSMAHASISWA = New ADODB.Recordset
Set RSKASIR = New ADODB.Recordset
Set RSTRSPP = New ADODB.Recordset
Conn.Open "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\DBSPP.mdb"
End Sub



