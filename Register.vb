Imports MySql.Data.MySqlClient

Public Class Register

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Sub check1()

        Dim EncryptionFactor As Integer = 3
        For Each letter As String In txtpass.Text
            item += Chr(Asc(letter) + EncryptionFactor)
        Next

        txtpass.Text = item

        item = ""

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        connect.Close()

        Try
            item = ""
            check1()
            connect.Open()
            command = New MySqlCommand("insert into tblusers(UserID, Fullname, Username, Password, Role)values('" & txtuserid.Text & "','" & txtfullname.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & txtrole.Text & "')", connect)
            command.ExecuteNonQuery()
            MsgBox("Record has been successfully saved!", vbInformation)

            connect.Close()
            delete()
            txtpass.Text = ""
            item = ""

            Me.Dispose()
            Form1.Show()

        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Sub delete()
        txtfullname.Clear()
        txtuser.Clear()
        txtpass.Clear()
        txtrole.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtpass.UseSystemPasswordChar = False
        Else

            txtpass.UseSystemPasswordChar = True

        End If
    End Sub

End Class