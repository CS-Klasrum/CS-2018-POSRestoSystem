Imports MySql.Data.MySqlClient

Public Class frmUserDetails
   
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If txtId.Text.Equals("") Or txtfullname.Text.Equals("") Or txtuser.Text.Equals("") Or txtrole.Text.Equals("") Then
                MsgBox("Can't proceed, Please input blank textfields.", vbCritical)

            Else
                connect.Open()
                command = Nothing
                command = New MySqlCommand("Insert into tblusers (Fullname, Username, Password, Role, userID)values('" & txtfullname.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & txtrole.Text & "','" & txtId.Text & "')", connect)
                command.ExecuteNonQuery()
                connect.Close()
                MsgBox("Successfully saved!", vbInformation)
            End If

            connect.Close()
            Clear()
            Me.Dispose()
            ManageUsers.UsersRecords()

        Catch ex As Exception
            'connect.Close()
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub

    Sub Clear()

        txtId.Clear()
        txtfullname.Clear()
        txtuser.Clear()
        txtrole.Clear()
        txtId.Enabled = True
        btnsave.Enabled = True
        btnupdate.Enabled = False

        txtId.Focus()

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        connect.Open()
        command = New MySqlCommand("update tblusers set Fullname='" & txtfullname.Text & "', Username = '" & txtuser.Text & "', Password = '" & txtpass.Text & "', Role = '" & txtrole.Text & "' where userID like '" & txtId.Text & "'", connect)
        command.ExecuteNonQuery()

        connect.Close()
        MsgBox("Successfully updated!", vbInformation)
        Clear()
        Me.Dispose()
        ManageUsers.UsersRecords()
    End Sub

    Private Sub frmUserDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class