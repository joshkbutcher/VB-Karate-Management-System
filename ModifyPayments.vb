Public Class frmModifyPayments
    Private Sub ModifyPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ModifyPaymentDataSource1.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.ModifyPaymentDataSource1.Payments)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModPay.CellClick
        Dim i As Integer
        i = dgvModPay.CurrentRow.Index
        Dim id As Integer = Convert.ToInt32(dgvModPay.Item(0, i).Value)
        Console.WriteLine("2nd: " + dgvModPay.Item(3, i).Value.ToString() + " / 3rd: " + id.ToString())
        txtID.Text = dgvModPay.Item(0, i).Value.ToString()
        txtMemId.Text = dgvModPay.Item(3, i).Value.ToString()
        dtpPayDate.Text = Convert.ToDateTime(dgvModPay.Item(4, i).Value).ToShortDateString()
        txtAmount.Text = dgvModPay.Item(5, i).Value.ToString()

    End Sub

End Class