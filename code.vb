Imports MySql.Data.MySqlClient

Module code
    Public connect As MySqlConnection
    Public command As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter

    Public role As String
    Public item As String
    Public query As String
    Public Username As String
    Public Password As String
    Public myDate As DateTime = DateString
    Public Status As String
    Public ImageIsNull As String
    Public autoEmployeeID As String
    Public autoAccountID As String
    Public autoInvoiceNo As String
    Public EID As String
    Public AID As String
    Public DateFull As String
    Public VoidRemovable As String
    Public MyPosition As String
    Public YearandMonth_No As String
    Public Day_No As String
    Public myInvoiceNo As String
    Public myTableNo As String
    Public myTotalBill As String
    Public Description As String
    Public Price As String
    Public myCategory As String
    Public TB As String
    Public CommaGrandTotal As String
    Public NoCommaGrandTotal As String
    Public Subtotal As String
    Public TotalBill As String
    Public myID As String
    Public myQty As String
    Public newQty As String
    Public NewSubtotal As String
    Public NewTotalBill As String
    Public mySubTotal As String
    Public myPrice As String
    Public NewandOldSubtotal As String
    Public CustomerChange As String
    Public TenderInvoiceNo As String
    Public Counter As String = "01"

    Sub Connection()
        connect = New MySqlConnection
        connect.ConnectionString = "server=localhost;userid=root;database=finals"

        Try
            connect.Open()
            Form1.lblcon.Text = "Online"

        Catch ex As Exception
            Form1.lblcon.Text = "Offline"

        End Try
    End Sub

    Function maxInvoiceNo() As String

        connect.Open()
        query = "Select ifnull(max(InvoiceNo)+1,1) as mINo from myInvoiceNo"
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader
        With reader
            If .HasRows = True Then
                While .Read
                    autoInvoiceNo = CInt(.Item("mINo").ToString)
                End While
            End If
        End With
        connect.Close()
        Return autoInvoiceNo
    End Function

End Module
