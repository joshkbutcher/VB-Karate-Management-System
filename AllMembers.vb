Public Class frmAllMembers
    Private Sub frmAllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub tsmClose_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        Me.Close()
    End Sub
End Class