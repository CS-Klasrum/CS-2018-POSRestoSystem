Imports MySql.Data.MySqlClient

Public Class frmChangePass

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub



    Private Sub frmChangePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btnsave
        connect.Open()
        query = "Select * from tblusers where Username='" & Username & "'"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        With reader
            While reader.Read
                Username = reader("Username")
            End While
        End With
        reader.Close()
        txtold.Text = ""
        txtnew.Text = ""
        txtconfirm.Text = ""
    End Sub
End Class