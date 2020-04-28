Imports MySql.Data.MySqlClient

Public Class frmVoid

    Function admin() As Boolean

        item = ""
        check()
        connect.Open()
        command = connect.CreateCommand
        command = New MySqlCommand("Select * from tblusers where Username='" & txtuser.Text & "' and Password='" & txtpass.Text & "' and Role='Admin'", connect)
        reader = command.ExecuteReader
        With reader
            If .HasRows = True Then
                While .Read
                    If txtuser.Text = CStr(.Item("Username").ToString) And txtpass.Text = CStr(.Item("Password").ToString) Then
                        del()
                        txtpass.Text = ""
                        item = ""
                        connect.Close()
                        Return True
                    End If

                End While
            End If

        End With
        connect.Close()
        Return False
    End Function

    Sub del()
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Public Sub check()

        Dim EncryptionFactor As Integer = 3
        For Each letter As String In txtpass.Text
            item += Chr(Asc(letter) + EncryptionFactor)
        Next

        txtpass.Text = item

        item = ""

    End Sub

    Private Sub txtuser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.GotFocus
        txtuser.BackColor = Color.LightBlue
    End Sub

    Private Sub txtuser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        txtuser.ForeColor = Color.White
    End Sub

    Private Sub txtpass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpass.GotFocus
        txtpass.BackColor = Color.LightBlue
    End Sub

    Private Sub txtpass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpass.Leave
        txtpass.ForeColor = Color.White
    End Sub

    Private Sub frmVoid_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtuser.Focus()
    End Sub

    Private Sub frmVoid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call btnexit_Click(sender, e)
        End If
    End Sub

    Private Sub frmVoid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btnsubmit
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        NewTotalBill = Val(NoCommaGrandTotal) - Val(mySubTotal)
        If txtuser.Text <> "" Then
            If txtpass.Text <> "" Then
                If admin() = True Then
                    connect.Open()
                    command = New MySqlCommand("Delete from history_sale where ID='" & myID & "'", connect)
                    reader.Close()
                    command = New MySqlCommand("Update tbltable set TotalBill='" & NewTotalBill & "' where TableNo='" & Cashier.lbltable.Text & "'", connect)
                    reader.Close()
                    MsgBox("This item has been Removed", MsgBoxStyle.Information, "Void Item")
                    Call Cashier.ShowDiningCart()
                    Call Cashier.ShowTables()
                    Call Cashier.GrandTotal()
                    Call Cashier.ColoredTotalBill()
                    Close()
                    myID = Nothing
                    connect.Close()

                Else
                    MsgBox("Incorrect Username and Password", MsgBoxStyle.Critical, "Error Occur")
                    txtpass.Text = ""
                    txtpass.Focus()
                End If
            Else
                MsgBox("Please input Password", MsgBoxStyle.Exclamation, "Password Entry")
                txtpass.Focus()
            End If

        Else
            MsgBox("Please input Username", MsgBoxStyle.Exclamation, "Username Entry")
            txtuser.Focus()
        End If
    End Sub
End Class