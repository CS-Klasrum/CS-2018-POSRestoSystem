Imports MySql.Data.MySqlClient

Public Class frmCategory

    Sub Clear()
        txtcategory.Clear()
        btnsave.Enabled = True
        btnupdate.Enabled = False
        txtcategory.Focus()
    End Sub

    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim found As Boolean = False
                connect.Open()
                command = New MySqlCommand("select * from tblcategory where catID like '" & txtcategory.Text & "'", connect)
                reader = command.ExecuteReader
                reader.Read()
                If reader.HasRows Then found = True
                reader.Close()
                connect.Close()

                If found = False Then
                    connect.Open()
                    command = Nothing
                    command = New MySqlCommand("insert into tblcategory (Category) values(@cat)", connect)
                    command.Parameters.AddWithValue("@cat", txtcategory.Text)
                    command.ExecuteNonQuery()
                    connect.Close()
                Else
                    MsgBox("Errors: Duplicate entry.", vbCritical)
                End If
                MsgBox("Category has been successfully saved,", vbInformation)

                ManageCategory.LoadRecord()
                Clear()

            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                command = Nothing
                command = New MySqlCommand("Update tblcategory set Category = @cat where catID like @ID", connect)
                command.Parameters.AddWithValue("@cat", txtcategory.Text)
                command.Parameters.AddWithValue("@ID", lblcat.Text)
                command.ExecuteNonQuery()
                connect.Close()
                MsgBox("Category has been successfully updated!", vbInformation)

                With ManageCategory
                    .LoadRecord()
                End With
                Me.Dispose()
            End If

        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub
End Class