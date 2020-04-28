Imports MySql.Data.MySqlClient

Public Class ManageProducts
    Dim dbDataSet As New DataSet

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub ManageProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProductRecords()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        With frmProducts
            .txtdesc.Text = ""
            .txtcategory.Text = ""
            .txtprice.Text = ""
            .CheckBox1.CheckState = CheckState.Checked
            '.picImage = My.Resources.NoImagePOS
            .ShowDialog()
        End With
    End Sub

    Sub ProductRecords()

        connect.Close()
        Try
            DataGridView1.Rows.Clear()
            Dim x As Integer = 0
            connect.Open()
            command = connect.CreateCommand
            command = New MySqlCommand("Select * from tblproducts order by Description", connect)
            reader = command.ExecuteReader
            While reader.Read
                x += 1
                DataGridView1.Rows.Add(x, reader.Item("Description").ToString, reader.Item("Category").ToString, reader.Item("Price").ToString, reader.Item("Status").ToString, "Delete")
            End While
            reader.Close()
            connect.Close()
            lblcount.Text = "(" & DataGridView1.RowCount & ")"

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Delete" Then
            If MsgBox("Delete this record!", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                command = New MySqlCommand("Delete from tblproducts where Description like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                command.ExecuteNonQuery()
                connect.Close()
                MsgBox("Record has been successfully deleted", vbInformation)
                ProductRecords()
            End If

        End If
    End Sub

    Public Sub FilterData()

        If txtsearch.Text.Equals(String.Empty) Then
            ProductRecords()

        Else

            DataGridView1.Rows.Clear()
            Dim x As Integer = 0
            connect.Open()
            command = connect.CreateCommand
            command = New MySqlCommand("select * from tblproducts where Description like '" & txtsearch.Text & "%' order by Description", connect)
            reader = command.ExecuteReader
            While reader.Read
                x += 1
                DataGridView1.Rows.Add(x, reader.Item("Description").ToString, reader.Item("Category").ToString, reader.Item("Price").ToString, reader.Item("Status").ToString, "Delete")
            End While
            reader.Close()
            connect.Close()
        End If

    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        ProductRecords()
        txtsearch.Text = ""
    End Sub

    Private Sub txtsearch_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            FilterData()
        End If
    End Sub
End Class