Imports MySql.Data.MySqlClient

Public Class ManageUsers
    Dim dbDataSet As New DataSet

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        With frmUserDetails
            .btnsave.Enabled = False
            .btnupdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub ManageUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsersRecords()
    End Sub

    Sub UsersRecords()
        connect.Close()

        Try

            DataGridView1.Rows.Clear()
            Dim i As Integer = 0
            connect.Open()
            command = connect.CreateCommand
            command = New MySqlCommand("select * from tblusers order by Fullname", connect)
            reader = command.ExecuteReader
            While reader.Read
                i += 1
                ' i = 1 += every read the value of i increment by 1
                DataGridView1.Rows.Add(i, reader("ID").ToString, reader("userID").ToString, reader("Fullname").ToString, reader("Username").ToString, reader("Password").ToString, reader("Role").ToString, "Edit", "Delete")
            End While
            reader.Close()
            connect.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Edit" Then
            With frmUserDetails
                .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtId.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .txtfullname.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .txtuser.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .txtpass.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .txtrole.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString

                .btnsave.Enabled = False
                .btnupdate.Enabled = True

                .txtId.Enabled = False
                .txtpass.Enabled = False
                .txtrole.Enabled = False

                .ShowDialog()

            End With

        ElseIf colName = "Delete" Then
            If MsgBox("Do you really want to Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                command = New MySqlCommand("delete from tblusers where ID like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                command.ExecuteNonQuery()
                connect.Close()
                MsgBox("Successfully deleted", vbInformation)
                UsersRecords()
            End If

        End If
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            FilterData()
        End If

    End Sub

    Public Sub FilterData()

        If txtsearch.Text.Equals(String.Empty) Then
            UsersRecords()

        Else

            DataGridView1.Rows.Clear()
            Dim i As Integer = 0
            connect.Open()
            command = New MySqlCommand("select * from tblusers where ID like '" & txtsearch.Text & "%' or Fullname like '" & txtsearch.Text & "%' order by Fullname", connect)
            reader = command.ExecuteReader
            While reader.Read
                i += 1
                DataGridView1.Rows.Add(i, reader.Item("ID").ToString, reader.Item("userID").ToString, reader.Item("Fullname").ToString, reader.Item("Username").ToString, reader.Item("Password").ToString, reader.Item("Role").ToString, "Edit", "Delete")
            End While
            reader.Close()
            connect.Close()
        End If

    End Sub

    Private Sub btnrefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        UsersRecords()
        txtsearch.Text = ""
    End Sub
End Class