Public Class FormWaitress
    'Reference this form to Main
    Inherits System.Windows.Forms.Form
    Public myCaller As Main

    'variable to count number of waitress
    Private totalWaits As Integer = 0I
    Private totalTogo As Integer = 0I
    Private tipAmount As Decimal = 0D
    Private countWaitLate As Integer = 0I
    Private countTogoLate As Integer = 0I
    Private tipFromMain As Decimal = 0D
    Private totalTip As Decimal = 0D
    Private shiftHour As Decimal

    Private lateStr As String = ""
    Private togoStr As String = ""






    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Try
            Me.Calculate()
        Catch ex As Exception
            MessageBox.Show("Please make sure that you input all valid number")
        End Try

    End Sub


    '''''''''''''''''''''''' Check Action for waits''''''''''''''''''
    Private Sub chkAlex_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlex.CheckedChanged

        If chkAlex.Checked = True Then
            chkLateAlex.Enabled = True
            totalWaits += 1
        Else
            chkLateAlex.Enabled = False
            chkLateAlex.Checked = False
            txtAlex.Text = String.Empty
            txtAlex.Enabled = False
            totalWaits -= 1
        End If

    End Sub

    Private Sub chkYari_CheckedChanged(sender As Object, e As EventArgs) Handles chkYari.CheckedChanged
        If chkYari.Checked = True Then
            chkLateYari.Enabled = True
            totalWaits += 1
        Else
            chkLateYari.Enabled = False
            chkLateYari.Checked = False
            txtYari.Text = String.Empty
            txtYari.Enabled = False
            totalWaits -= 1
        End If



    End Sub

    Private Sub chkNana_CheckedChanged(sender As Object, e As EventArgs) Handles chkNana.CheckedChanged
        If chkNana.Checked = True Then
            chkLateNana.Enabled = True
            totalWaits += 1
        Else
            chkLateNana.Enabled = False
            chkLateNana.Checked = False
            txtNana.Text = String.Empty
            txtNana.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkRon_CheckedChanged(sender As Object, e As EventArgs) Handles chkRon.CheckedChanged
        If chkRon.Checked = True Then
            chkLateRon.Enabled = True
            totalWaits += 1
        Else
            chkLateRon.Enabled = False
            chkLateRon.Checked = False
            txtRon.Text = String.Empty
            txtRon.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkLinda_CheckedChanged(sender As Object, e As EventArgs) Handles chkLinda.CheckedChanged
        If chkLinda.Checked = True Then
            chkLateLinda.Enabled = True
            totalWaits += 1
        Else
            chkLateLinda.Enabled = False
            chkLateLinda.Checked = False
            txtLinda.Text = String.Empty
            txtLinda.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkJasmine_CheckedChanged(sender As Object, e As EventArgs) Handles chkJasmine.CheckedChanged
        If chkJasmine.Checked = True Then
            chkLateJasmine.Enabled = True
            totalWaits += 1
        Else
            chkLateJasmine.Enabled = False
            chkLateJasmine.Checked = False
            txtJasmine.Text = String.Empty
            txtJasmine.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkDude1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDude1.CheckedChanged
        If chkDude1.Checked = True Then
            chkLateDude1.Enabled = True
            totalWaits += 1
        Else
            chkLateDude1.Enabled = False
            chkLateDude1.Checked = False
            txtDude1.Text = String.Empty
            txtDude1.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkDude2_CheckedChanged(sender As Object, e As EventArgs) Handles chkDude2.CheckedChanged
        If chkDude2.Checked = True Then
            chkLateDude2.Enabled = True
            totalWaits += 1
        Else
            chkLateDude2.Enabled = False
            chkLateDude2.Checked = False
            txtDude2.Text = String.Empty
            txtDude2.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkDude3_CheckedChanged(sender As Object, e As EventArgs) Handles chkDude3.CheckedChanged
        If chkDude3.Checked = True Then
            chkLateDude3.Enabled = True
            totalWaits += 1
        Else
            chkLateDude3.Enabled = False
            chkLateDude3.Checked = False
            txtDude3.Text = String.Empty
            txtDude3.Enabled = False
            totalWaits -= 1
        End If
    End Sub

    Private Sub chkDude4_CheckedChanged(sender As Object, e As EventArgs) Handles chkDude4.CheckedChanged
        If chkDude4.Checked = True Then
            chkLateDude4.Enabled = True
            totalWaits += 1
        Else
            chkLateDude4.Enabled = False
            chkLateDude4.Checked = False
            txtDude4.Text = String.Empty
            txtDude4.Enabled = False
            totalWaits -= 1
        End If
    End Sub



    '''''''''''''''''''''''' Check Action for Togo''''''''''''''''''
    Private Sub chkTik_CheckedChanged(sender As Object, e As EventArgs) Handles chkTik.CheckedChanged
        If chkTik.Checked = True Then
            chkLateTik.Enabled = True
            totalTogo += 1
        Else
            chkLateTik.Enabled = False
            chkLateTik.Checked = False
            totalTogo -= 1
        End If
    End Sub

    Private Sub chkEve_CheckedChanged(sender As Object, e As EventArgs) Handles chkEve.CheckedChanged
        If chkEve.Checked = True Then
            chkLateEve.Enabled = True
            totalTogo += 1
        Else
            chkLateEve.Enabled = False
            chkLateEve.Checked = False
            totalTogo -= 1
        End If
    End Sub

    Private Sub chkTogo1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTogo1.CheckedChanged
        If chkTogo1.Checked = True Then
            chkLateTogo1.Enabled = True
            totalTogo += 1
        Else
            chkLateTogo1.Enabled = False
            chkLateTogo1.Checked = False
            totalTogo -= 1
        End If
    End Sub



    '''''''''''''''''''''''''''''''''Hide Button''''''''''''''''''''''''''''''
    Private Sub btHide_Click(sender As Object, e As EventArgs) Handles btHide.Click
        Me.Hide()
    End Sub

    '''''''''''''''''''''''''''''''''''''Waitress Late Button Check''''''''''''''''''''''''''''''''''''
    Private Sub chkLateAlex_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateAlex.CheckedChanged
        If chkLateAlex.Checked = True Then
            txtAlex.Enabled = True
            countWaitLate += 1
        Else
            txtAlex.Text = String.Empty
            txtAlex.Enabled = False
            lblAlex.Text = String.Empty
            countWaitLate -= 1

        End If
    End Sub

    Private Sub chkLateYari_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateYari.CheckedChanged
        If chkLateYari.Checked = True Then
            txtYari.Enabled = True
            countWaitLate += 1
        Else
            txtYari.Text = String.Empty
            txtYari.Enabled = False
            lblYari.Text = String.Empty
            countWaitLate -= 1
        End If

    End Sub

    Private Sub chkLateNana_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateNana.CheckedChanged
        If chkLateNana.Checked = True Then
            txtNana.Enabled = True
            countWaitLate += 1
        Else
            txtNana.Text = String.Empty
            txtNana.Enabled = False
            lblNana.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateRon_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateRon.CheckedChanged
        If chkLateRon.Checked = True Then
            txtRon.Enabled = True
            countWaitLate += 1
        Else
            txtRon.Text = String.Empty
            txtRon.Enabled = False
            lblRon.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateLinda_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateLinda.CheckedChanged
        If chkLateLinda.Checked = True Then
            txtLinda.Enabled = True
            countWaitLate += 1
        Else
            txtLinda.Text = String.Empty
            txtLinda.Enabled = False
            lblLinda.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateJasmine_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateJasmine.CheckedChanged
        If chkLateJasmine.Checked = True Then
            txtJasmine.Enabled = True
            countWaitLate += 1
        Else
            txtJasmine.Text = String.Empty
            txtJasmine.Enabled = False
            lblJasmine.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateDude1_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateDude1.CheckedChanged
        If chkLateDude1.Checked = True Then
            txtDude1.Enabled = True
            countWaitLate += 1
        Else
            txtDude1.Text = String.Empty
            txtDude1.Enabled = False
            lblDude1.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateDude2_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateDude2.CheckedChanged
        If chkLateDude2.Checked = True Then
            txtDude2.Enabled = True
            countWaitLate += 1
        Else
            txtDude2.Text = String.Empty
            txtDude2.Enabled = False
            lblDude2.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateDude3_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateDude3.CheckedChanged
        If chkLateDude3.Checked = True Then
            txtDude3.Enabled = True
            countWaitLate += 1
        Else
            txtDude3.Text = String.Empty
            txtDude3.Enabled = False
            lblDude3.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub

    Private Sub chkLateDude4_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateDude4.CheckedChanged
        If chkLateDude4.Checked = True Then
            txtDude4.Enabled = True
            countWaitLate += 1
        Else
            txtDude4.Text = String.Empty
            txtDude4.Enabled = False
            lblDude4.Text = String.Empty
            countWaitLate -= 1
        End If
    End Sub


    ''''''''''''''''''''''''''''''''''' Togo Late Button Check '''''''''''''''''''''''''''''''''''''''''''''
    Private Sub chkLateTik_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateTik.CheckedChanged
        If chkLateTik.Checked = True Then
            txtTik.Enabled = True
            countTogoLate += 1
        Else
            txtTik.Text = String.Empty
            txtTik.Enabled = False
            lblTik.Text = String.Empty
            countTogoLate -= 1

        End If
    End Sub

    Private Sub chkLateEve_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateEve.CheckedChanged
        If chkLateEve.Checked = True Then
            txtEve.Enabled = True
            countTogoLate += 1
        Else
            txtEve.Text = String.Empty
            txtEve.Enabled = False
            lblEve.Text = String.Empty
            countTogoLate -= 1
        End If
    End Sub

    Private Sub chkLateTogo1_CheckedChanged(sender As Object, e As EventArgs) Handles chkLateTogo1.CheckedChanged
        If chkLateTogo1.Checked = True Then
            txtTogo1.Enabled = True
            countTogoLate += 1
        Else
            txtTogo1.Text = String.Empty
            txtTogo1.Enabled = False
            lblTogo1.Text = String.Empty
            countTogoLate -= 1
        End If
    End Sub


    ''' ''''''''''''''''''''''''''Mehtods''''''''''''''''''''''''''''

    Private Sub Calculate()
        ''' reset global lateStr '''
        lateStr = String.Empty
        myCaller.tipPullOut = 0D
        '''''get tip amount from main Form'''''
        If Not getTipFromMain() Then
            Exit Sub
        End If
        totalTip = tipFromMain

        If txtTipPullOut.Text.Trim.Length > 0 Then
            Dim thisTipPullOut = CDec(txtTipPullOut.Text)
            totalTip -= thisTipPullOut
            myCaller.tipPullOut = thisTipPullOut
            myCaller.txtAddTc.Text = Str(thisTipPullOut * 0.1)
        Else
            myCaller.tipPullOut = 0
            myCaller.txtAddTc.Text = String.Empty
        End If
        Dim outputStr As String = ""
        Dim tipPerWait As Decimal
        Dim tipPerTogo As Decimal
        Dim thisTotalTogo As Integer
        Dim thisTotalTip As Decimal
        Dim thisTotalWait As Integer

        thisTotalTogo = totalTogo
        thisTotalTip = totalTip
        thisTotalWait = totalWaits

        If Not validWaitressNumber() Then
            Exit Sub
        End If


        '''''''''''Check if there is any Late'''''''''''''''''
        If countTogoLate > 0 Or countWaitLate > 0 Then

            If Not setShiftHour() Then
                Exit Sub
            End If

            If shiftHour = 0 Then
                MessageBox.Show("Shift Hour must greater than 0")
                Exit Sub
            End If
        End If




        If countTogoLate > 0 Then
            If setShiftHour() Then
                CalculateTogoLate()
            Else
                Exit Sub
            End If
        End If

        '''' Total Number of togo after subtract with late''''''''''''''''''''''
        thisTotalTogo -= countTogoLate
        If thisTotalTogo <> 0 Then
            tipPerTogo = tipFromMain * 0.1
            totalTip -= tipPerTogo * thisTotalTogo
            outputStr += "Togo Tip" & vbNewLine &
                    tipPerTogo.ToString("C") & " × " & thisTotalTogo.ToString() & vbNewLine
        End If


        CalculateWaitLate()



        '''''''''''''Total number of Waitress after subtract with Late People'''''''''''
        thisTotalWait -= countWaitLate




        tipPerWait = totalTip / thisTotalWait


        outputStr += "Server Tip" & vbNewLine &
                tipPerWait.ToString("C") & " × " & thisTotalWait.ToString & vbNewLine +
                "---------------------" + vbNewLine


        outputStr += lateStr


        myCaller.lbladd.Text = outputStr



    End Sub

    Private Sub CalculateWaitLate()

        Dim tipPerWait As Decimal = totalTip / totalWaits

        If chkLateAlex.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtAlex.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblAlex.Text = deduct.ToString("C")
            lateStr += "Alex " + tip.ToString("C") + vbNewLine
        End If


        If chkLateYari.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtYari.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblYari.Text = deduct.ToString("C")
            lateStr += "Yari " + tip.ToString("C") + vbNewLine
        End If

        If chkLateNana.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtNana.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblNana.Text = deduct.ToString("C")
            lateStr += "Nana " + tip.ToString("C") + vbNewLine
        End If

        If chkLateRon.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtRon.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblRon.Text = deduct.ToString("C")
            lateStr += "Ron " + tip.ToString("C") + vbNewLine
        End If

        If chkLateLinda.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtLinda.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblLinda.Text = deduct.ToString("C")
            lateStr += "Linda " + tip.ToString("C") + vbNewLine
        End If

        If chkLateJasmine.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtJasmine.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblJasmine.Text = deduct.ToString("C")
            lateStr += "Jasmine " + tip.ToString("C") + vbNewLine
        End If

        If chkLateDude1.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtDude1.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblDude1.Text = deduct.ToString("C")
            lateStr += "Dude1 " + tip.ToString("C") + vbNewLine
        End If
        If chkLateDude2.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtDude2.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblDude2.Text = deduct.ToString("C")
            lateStr += "Dude2 " + tip.ToString("C") + vbNewLine
        End If
        If chkLateDude3.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtDude3.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblDude3.Text = deduct.ToString("C")
            lateStr += "Dude3 " + tip.ToString("C") + vbNewLine
        End If

        If chkLateDude4.Checked Then
            Dim tip As Decimal
            Dim deduct As Decimal
            deduct = tipPerWait / (shiftHour * 60) * CDec(txtDude4.Text)
            tip = tipPerWait - deduct
            totalTip -= tip
            lblDude4.Text = deduct.ToString("C")
            lateStr += "Dude4 " + tip.ToString("C") + vbNewLine
        End If


    End Sub


    Private Sub CalculateTogoLate()

        lateStr = String.Empty

        Dim togoLateStr As String = ""
        Dim togoTip As Decimal


        togoTip = totalTip * 0.1

        If chkLateTik.Checked Then

            Dim tikDeduct As Decimal
            Dim tikTip As Decimal
            tikDeduct = (togoTip / (shiftHour * 60)) * CDec(txtTik.Text)
            tikTip = togoTip - tikDeduct
            totalTip -= tikTip

            lblTik.Text = tikDeduct.ToString("C")
            lateStr += "Tik " + tikTip.ToString("C") + vbNewLine

        End If

        If chkLateEve.Checked Then

            Dim eveDeduct As Decimal
            Dim eveTip As Decimal
            eveDeduct = (togoTip / (shiftHour * 60)) * CDec(txtEve.Text)
            eveTip = togoTip - eveDeduct
            totalTip -= eveTip

            lblEve.Text = eveDeduct.ToString("C")
            lateStr += "Eve " + eveTip.ToString("C") + vbNewLine

        End If

        If chkLateTogo1.Checked Then

            Dim togo1Deduct As Decimal
            Dim togo1Tip As Decimal
            togo1Deduct = (togoTip / (shiftHour * 60)) * CDec(txtTogo1.Text)
            togo1Tip = togoTip - togo1Deduct
            totalTip -= togo1Tip

            lblTogo1.Text = togo1Deduct.ToString("C")
            lateStr += "Togo1 " + togo1Tip.ToString("C") + vbNewLine

        End If

    End Sub

    Private Function getTipFromMain()
        Try
            tipFromMain = CDec(myCaller.txtCreditTip.Text)
            Return True
        Catch ex As InvalidCastException
            myCaller.lbladd.Text = String.Empty
            MessageBox.Show("Please input a number in Credit Tip")
            Return False

        End Try


    End Function


    Private Function validWaitressNumber()
        Try
            Dim i As Decimal = 0

            i = i / totalWaits
            Return True
        Catch ex As DivideByZeroException
            myCaller.lbladd.Text = String.Empty
            MessageBox.Show("Please Check Who Works Today")
            Return False

        End Try
    End Function

    Private Function setShiftHour()
        Try
            shiftHour = CDec(txtShiftHour.Text)
            Return True
        Catch ex As InvalidCastException
            MessageBox.Show("Please Input Valid Shift Hours")
            Return False
        End Try


    End Function


End Class