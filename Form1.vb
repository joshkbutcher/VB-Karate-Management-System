Public Class frmMain
    Private Sub tsmMemDate_Click(sender As Object, e As EventArgs) Handles tsmMemDate.Click
        Dim frmMemDates = New frmMemDates
        frmMemDates.ShowDialog()
    End Sub

    Private Sub tsmPayMembers_Click(sender As Object, e As EventArgs) Handles tsmPayMembers.Click
        Dim frmPaymentsAll As New AllPaymentsForm
        frmPaymentsAll.ShowDialog()
    End Sub

    Private Sub tsmListAll_Click(sender As Object, e As EventArgs) Handles tsmListAll.Click
        Dim frmAllMem = New frmAllMembers
        frmAllMem.ShowDialog()
    End Sub

    Private Sub ModifyPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyPaymentsToolStripMenuItem.Click
        Dim frmModPay = New frmModifyPayments
        frmModPay.ShowDialog()
    End Sub

    Private Sub PaymentsByOneMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsByOneMemberToolStripMenuItem.Click
        Dim frmMemberPay = New frmPaymentsOneMember
        frmMemberPay.ShowDialog()
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub
End Class
