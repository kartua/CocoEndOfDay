Public Class Main

    '''''''''''' Subforms '''''''''''''''
    Dim formExp As New FormExp
    Dim formHp As New FormHp
    Dim formWaitress As New FormWaitress
    Dim formPreview As New PreviewTip
    Dim formPassword As New Password

    ''''''''''''''''''''''''''''''''''''
    '''
    Public tipPullOut As Decimal = 0D   'Use in formWaitress
    Dim expenses As Decimal = 0D

    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Calculate()
    End Sub

    Private Sub btMoreExpenses_Click(sender As Object, e As EventArgs) Handles btDetailExpenses.Click
        'If the form is not visble then
        If Not formExp.Visible Then
            formExp.myCaller = Me
            formExp.Show(Me)
            formExp.TopMost = True
        Else
            If Not formExp.TopMost Then

                formExp.TopMost() = True
            Else
                formExp.Hide()

            End If

        End If

    End Sub

    Private Sub btDetailHp_Click(sender As Object, e As EventArgs) Handles btDetailHp.Click
        If Not formPassword.Visible And Not formHp.Visible Then
            formPassword.myCaller = Me
            formPassword.Show(Me)
            formPassword.TopMost = True
        ElseIf formHp.Visible Then
            If formHp.TopMost Then
                formHp.Hide()
            Else
                formHp.TopMost = True
            End If

        ElseIf formPassword.Visible Then
            If formPassword.TopMost Then
                formPassword.Hide()
            Else
                formPassword.TopMost = True

            End If
            formPassword.TopMost = True

        End If


    End Sub

    Private Sub btDetailWaitress_Click(sender As Object, e As EventArgs) Handles btDetailWaitress.Click
        'If the form is not visble then
        If Not formWaitress.Visible Then
            formWaitress.myCaller = Me
            formWaitress.Show(Me)
            formWaitress.TopMost = True
        Else
            If Not formWaitress.TopMost Then

                formWaitress.TopMost() = True
            Else
                formWaitress.Hide()

            End If

        End If

    End Sub



    Private Sub btPreviewAdd_Click(sender As Object, e As EventArgs) Handles btPreviewAdd.Click
        'If the form is not visble then
        Dim outputStr As String = ""
        If txtLunchTip.Text.Trim.Length > 0 Then
            outputStr += "Lunch $" + txtLunchTip.Text + vbNewLine +
                "---------------------" + vbNewLine

        End If
        outputStr += lbladd.Text + vbNewLine + vbNewLine
        formPreview.lblPreview.Text = outputStr
        If Not formPreview.Visible Then
            formPreview.myCaller = Me
            formPreview.Show(Me)
            formPreview.TopMost = True
        Else
            formPreview.TopMost() = True
        End If
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click

        Me.Close()

    End Sub

    Public Sub showHpForm()
        If formHp.Visible = False Then
            formHp.myCaller = Me
            formHp.Show(Me)
            formHp.TopMost = True
        End If

    End Sub

    Private Sub Calculate()
        Dim carry As Decimal = 0D
        Dim cash As Decimal = 0D
        Dim void As Decimal = 0D
        Dim creditTip As Decimal = 0D
        Dim cashTipCharged As Decimal = 0D
        Dim hp As Decimal = 0D
        Dim expenses As Decimal = 0D
        Dim subTotal As Decimal = 0D
        Dim addTc As Decimal = 0D
        Dim add As Decimal = 0D
        Dim totalShift As Decimal = 0D
        Try
            If txtCarry.Text.Trim.Length > 0 Then
                carry = CDec(txtCarry.Text)
            End If
            If txtCash.Text.Trim.Length > 0 Then
                cash = CDec(txtCash.Text)
            End If
            If txtVoid.Text.Trim.Length > 0 Then
                void = CDec(txtVoid.Text)
            End If
            If txtCreditTip.Text.Trim.Length > 0 Then
                creditTip = CDec(txtCreditTip.Text)
            End If
            If txtCashTipCharged.Text.Trim.Length > 0 Then
                cashTipCharged = CDec(txtCashTipCharged.Text)
            End If
            If txtHP.Text.Trim.Length > 0 Then
                hp = CDec(txtHP.Text)
            End If
            If txtExpenses.Text.Trim.Length > 0 Then
                expenses = CDec(txtExpenses.Text)
            End If
            If txtAddTc.Text.Trim.Length > 0 Then
                addTc = CDec(txtAddTc.Text)
            End If

            ' Add back Credit Tip
            '''''''''''''''''''''''''''''''''''''''
            add = creditTip - tipPullOut
            ''''''''''''''''''''''''''''''''''''''
            subTotal = cash + void - creditTip - cashTipCharged - hp - expenses
            totalShift = subTotal + addTc + add

            lblSubTotal.Text = subTotal.ToString
            lblTotalShift.Text = totalShift.ToString
            lblTotalDay.Text = CStr(carry + totalShift)


        Catch ex As System.InvalidCastException
            MessageBox.Show("Please Enter Numbers Only", "Invalid Entry")
        End Try

    End Sub
End Class
