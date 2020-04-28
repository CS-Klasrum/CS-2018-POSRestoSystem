Imports MySql.Data.MySqlClient

Public Class ManageCategory
    Dim _Id, _cat As String

    Private Sub ManageCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Public Sub LoadRecord()
        connect.Close()
        connect.Open()
        DataGridView1.Rows.Clear()
        Dim i As Integer = 0

        command = connect.CreateCommand
        command = New MySqlCommand("select * from tblcategory", connect)
        reader = command.ExecuteReader
        While reader.Read
            i += 1
            DataGridView1.Rows.Add(i, reader.Item("catID").ToString, reader.Item("Category").ToString, "Edit", "Delete")
        End While
        reader.Close()
        connect.Close()
        lblcount.Text = "(" & DataGridView1.RowCount & ")"
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        With frmCategory
            .btnsave.Enabled = True
            .btnupdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Edit" Then
            With frmCategory
                .txtcategory.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .lblcat.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .btnsave.Enabled = False
                .btnupdate.Enabled = True
                .ShowDialog()
            End With
        ElseIf colName = "Delete" Then
            If MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                command = New MySqlCommand("delete from tblcategory where catID like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                command.ExecuteNonQuery()
                connect.Close()
                MsgBox("Category has been successfully deleted.", vbInformation)
                LoadRecord()
            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _Id = DataGridView1.Item(0, i).Value
        _cat = DataGridView1.Item(2, i).Value
    End Sub

   
End Class