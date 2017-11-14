Public Class frmMemDates

    Private Sub dtpMembers_ValueChanged(sender As Object, e As EventArgs) Handles dtpMembers.ValueChanged, rbtBefore.CheckedChanged, rbtOnAfter.CheckedChanged
        Dim selectedDate As String = dtpMembers.Value.Date.ToString()
        Dim dbDate As DateTime = Convert.ToDateTime(selectedDate)

        If rbtBefore.Checked Then
            Me.MembersTableAdapter.Before(Me.FindMemberByDateDataSet.Members, dbDate)
        ElseIf rbtOnAfter.Checked Then
            Me.MembersTableAdapter.After(Me.FindMemberByDateDataSet.Members, dbDate)
        Else
            Me.MembersTableAdapter.Fill(Me.FindMemberByDateDataSet.Members)
        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class