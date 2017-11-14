Public Class frmPaymentsOneMember
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        Dim id As Short = Convert.ToInt16(lstMembers.SelectedValue)
        Me.PaymentsTableAdapter.Fill(Me.MemberPaymentDataSet.Payments, id)
    End Sub

    Private Sub frmPaymentsOneMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MemberPaymentDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MemberPaymentDataSet.Members)

    End Sub
End Class