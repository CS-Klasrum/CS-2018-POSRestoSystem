Imports MySql.Data.MySqlClient

Public Class frmTable
  
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Sub Clear()
        txttable.Clear()
        btnsave.Enabled = True
        btnupdate.Enabled = False
        txttable.Focus()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try
            If MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim found As Boolean = False
                connect.Open()
                command = New MySqlCommand("select * from tbltable where tableID like '" & txttable.Text & "'", connect)
                reader = command.ExecuteReader
                reader.Read()
                If reader.HasRows Then found = True
                reader.Close()
                connect.Close()

                If found = False Then
                    connect.Open()
                    command = Nothing
                    command = New MySqlCommand("insert into tbltable (tableNo) values(@cant)", connect)
                    command.Parameters.AddWithValue("@cant", txttable.Text)
                    command.ExecuteNonQuery()
                    connect.Close()
                Else
                    MsgBox("Errors: Duplicate entry.", vbCritical)
                End If
                MsgBox("Table has been successfully saved,", vbInformation)

                ManageTable.LoadRecord()
                Clear()

            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                command = Nothing
                command = New MySqlCommand("Update tbltable set tableNo = @cant where tableID like @ID", connect)
                command.Parameters.AddWithValue("@cant", txttable.Text)
                command.Parameters.AddWithValue("@ID", lbltable.Text)
                command.ExecuteNonQuery()
                connect.Close()
                MsgBox("Table has been successfully updated!", vbInformation)

                With ManageTable
                    .LoadRecord()
                End With
                Me.Dispose()
            End If

        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class