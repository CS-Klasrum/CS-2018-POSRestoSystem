Imports MySql.Data.MySqlClient

Public Class frmCashTender
    Dim valueA, valueB As Decimal
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub

    Private Sub frmCashTender_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtcash.Focus()
    End Sub

    Private Sub txtcash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 27, 48 To 57
                e.Handled = True
            Case Else
                MsgBox("Please Enter Numbers Only", MsgBoxStyle.Critical, "Enter Occur")
                e.Handled = True
                txtcash.Focus()
        End Select
    End Sub

    Private Sub txtcash_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.Leave
        On Error Resume Next
        txtcash.Text = Decimal.Parse(txtcash.Text, 2).ToString("f2")
    End Sub

    Private Sub txtcash_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.TextChanged
        If txtcash.Text = "0" Then
            MsgBox("Please Use Zero (0) as your Cash Payment", MsgBoxStyle.Critical, "Strictly Prohibited")
            txtcash.Text = ""
            txtcash.Focus()
        End If
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Call txtcash_Leave(sender, e)
        Decimal.TryParse(txtcash.Text, valueA)
        Decimal.TryParse(NoCommaGrandTotal, valueB)
        If txtcash.Text = "" Then
            MsgBox("Please Enter Amount", MsgBoxStyle.Exclamation, "Amount Entry")
            txtcash.Text = ""
            txtcash.Focus()
        ElseIf valueA >= valueB Then
            CustomerChange = Decimal.Parse(txtcash.Text) - Decimal.Parse(NoCommaGrandTotal)
            maxInvoiceNo()
            connect.Open()
            command = connect.CreateCommand
            command = New MySqlCommand("Update myinvoiceno set InvoiceNo ='" & maxInvoiceNo() & "' where ID=1")
            reader.Close()
            maxInvoiceNo.ToString.PadLeft(4, "0")
            'TenderInvoiceNo =


        End If

    End Sub
End Class