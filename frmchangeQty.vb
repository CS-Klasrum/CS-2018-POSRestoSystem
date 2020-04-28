Imports MySql.Data.MySqlClient

Public Class frmchangeQty

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub

    Private Sub frmchangeQty_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtchange.Focus()
    End Sub

    Private Sub frmchangeQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btnsubmit
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        NewTotalBill = Val(myPrice) * Val(txtchange.Text)
        NewandOldSubtotal = Val(NewSubtotal) - Val(mySubTotal)
        NewTotalBill = Val(NewandOldSubtotal) + Val(NewandOldSubtotal)
        connect.Open()
        command = connect.CreateCommand
        command = New MySqlCommand("Update history_sale set Qty='" & txtchange.Text & "' Subtotal='" & NewSubtotal & "' where ID='" & myID & "'", connect)
        reader.Close()
        command = New MySqlCommand("Update tbltable set TotalBill='" & NewTotalBill & "' where TableNo='" & Cashier.lvtable.Text & "'", connect)
        reader.Close()
        Call Cashier.ShowDiningCart()
        Call Cashier.ShowTables()
        Call Cashier.GrandTotal()
        Call Cashier.ColoredTotalBill()
        For Each item As ListViewItem In Cashier.lvdiningcart.Items
            If (item.Text = Description) Then
                item.BackColor = Color.DodgerBlue
            End If
        Next
        Close()
        connect.Close()
    End Sub

    Private Sub txtchange_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchange.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 27, 48 To 57
                e.Handled = True
            Case Else
                MsgBox("Please Enter Numbers Only", MsgBoxStyle.Critical, "Enter Occur")
                e.Handled = True
                txtchange.Focus()
        End Select
    End Sub

End Class