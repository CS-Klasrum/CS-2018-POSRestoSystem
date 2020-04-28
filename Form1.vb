Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub bntconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntconfirm.Click
        connect.Close()

        Try

            item = ""
            check()
            connect.Open()
            Dim query As String
            query = "select * from tblusers where USERNAME = '" & txtuser.Text & "' and PASSWORD =  '" & txtpass.Text & "'"
            command = New MySqlCommand(query, connect)
            reader = command.ExecuteReader


            del()
            Me.Hide()
            txtpass.Text = ""
            item = ""

            Dim counter As Integer
            While reader.Read
                counter = counter + 1
                role = reader("Role")
            End While
            If counter = 1 Then
                If role = "Admin" Then
                    Admin.Show()
                ElseIf role = "Cashier" Then
                    Cashier.Show()

                End If


            ElseIf counter > 1 Then
                MsgBox("Access Denied. Invalid username and password.")

            Else
                MsgBox("Access Denied. Invalid username and password.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub del()
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub btnend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnend.Click
        Dim msg1 As Integer
        msg1 = MsgBox("Are you sure you want to Exit Appication?", _
           MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbQuestion, "Confirmation")
        If msg1 = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            txtuser.Focus()
        End If
    End Sub

    Public Sub check()

        Dim EncryptionFactor As Integer = 3
        For Each letter As String In txtpass.Text
            item += Chr(Asc(letter) + EncryptionFactor)
        Next

        txtpass.Text = item

        item = ""

    End Sub

    Private Sub lblcreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcreate.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtpass.UseSystemPasswordChar = False
        Else

            txtpass.UseSystemPasswordChar = True

        End If
    End Sub

End Class
