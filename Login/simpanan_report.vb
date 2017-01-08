Public Class simpanan_report

    Private Sub simpanan_report_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rpt As New CrystalReport2
        rpt.Refresh()
    End Sub
End Class