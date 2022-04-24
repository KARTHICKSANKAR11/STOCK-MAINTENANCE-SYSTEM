Public Class menu2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        createuser.Show()
        Me.Hide()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        staff.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem1.Click
        deptRegister.Show()
        Me.Hide()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        purchase2.Show()
        Me.Hide()
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        report.Show()
        Me.Hide()
    End Sub

    Private Sub ViewStockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockDetailsToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        OpenFileDialog1.OpenFile()
    End Sub
End Class