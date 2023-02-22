Public Class Form1
    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        DataGridView1.Rows.Add(txttittle.Text, txtnotes.Text)
        txttittle.Text = ""
        txtnotes.Text = ""
    End Sub

    Private Sub btnread_Click(sender As Object, e As EventArgs) Handles btnread.Click
        Dim n = DataGridView1.CurrentCell.RowIndex
        txttittle.Text = DataGridView1.Rows(n).Cells(0).Value.ToString()
        txtnotes.Text = DataGridView1.Rows(n).Cells(1).Value.ToString()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim n = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.Remove(DataGridView1.Rows(n))
        txttittle.Text = ""
        txtnotes.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        DataGridView1.Rows.Add(txttittle.Text, txtnotes.Text)
        txttittle.Text = ""
        txtnotes.Text = ""
    End Sub
End Class
