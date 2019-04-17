Public Class FormExp
    'Reference this form to Main
    Inherits System.Windows.Forms.Form
    Public myCaller As Main


    'Dim exp1 As Decimal = 0D
    'Dim exp2 As Decimal = 0D
    'Dim exp3 As Decimal = 0D
    'Dim exp4 As Decimal = 0D
    'Dim exp5 As Decimal = 0D
    'Dim exp6 As Decimal = 0D
    'Dim exp7 As Decimal = 0D
    'Dim exp8 As Decimal = 0D
    'Dim exp9 As Decimal = 0D
    'Dim exp10 As Decimal = 0D




    Private Sub btHide_Click(sender As Object, e As EventArgs) Handles btHide.Click
        Me.Hide()
    End Sub

    Private Sub btCalculateExpenses_Click(sender As Object, e As EventArgs) Handles btCalculateExpenses.Click
        Dim exp() As Decimal = New Decimal(9) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim totalExp As Decimal = 0D

        Try
            If txtExp1.Text.Trim.Length > 0 Then
                exp(0) = CDec(txtExp1.Text)
            End If
            If txtExp2.Text.Trim.Length > 0 Then
                exp(1) = CDec(txtExp2.Text)
            End If
            If txtExp3.Text.Trim.Length > 0 Then
                exp(2) = CDec(txtExp3.Text)
            End If
            If txtExp4.Text.Trim.Length > 0 Then
                exp(3) = CDec(txtExp4.Text)
            End If
            If txtExp5.Text.Trim.Length > 0 Then
                exp(4) = CDec(txtExp5.Text)
            End If
            If txtExp6.Text.Trim.Length > 0 Then
                exp(5) = CDec(txtExp6.Text)
            End If
            If txtExp7.Text.Trim.Length > 0 Then
                exp(6) = CDec(txtExp7.Text)
            End If
            If txtExp8.Text.Trim.Length > 0 Then
                exp(7) = CDec(txtExp8.Text)
            End If
            If txtExp9.Text.Trim.Length > 0 Then
                exp(8) = CDec(txtExp9.Text)
            End If
            If txtExp10.Text.Trim.Length > 0 Then
                exp(9) = CDec(txtExp10.Text)
            End If

            For index As Integer = 0 To 9
                totalExp += exp(index)
            Next
            lblTotalExpenses.Text = totalExp.ToString
            Main.txtExpenses.Text = totalExp.ToString

        Catch ex As InvalidCastException
            MessageBox.Show("Please Enter Numbers Only", "Invalid Input")
        End Try




    End Sub


End Class