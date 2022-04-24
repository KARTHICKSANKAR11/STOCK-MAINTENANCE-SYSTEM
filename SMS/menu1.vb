Public Class menu1

    Private Sub CreateUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateUSERToolStripMenuItem.Click
        createuser.Show()
        Me.Hide()
    End Sub

    Private Sub StaffIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffIDToolStripMenuItem.Click
        staff.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        report.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        officeRegister.Show()
        Me.Hide()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        purchase1.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub menu1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ViewStockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockDetailsToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class