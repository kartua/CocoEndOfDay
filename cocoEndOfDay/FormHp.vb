Public Class FormHp
    'Reference this form to Main
    Inherits System.Windows.Forms.Form
    Public myCaller As Main
    '''''''''''''''''''''''''
    Const SMITH As Decimal = 13D
    Const JOSELIN As Decimal = 8.5D
    Const FAI As Decimal = 9D
    Const NOON As Decimal = 9D
    Const ROSITA As Decimal = 11D

    Private Sub btHide_Click(sender As Object, e As EventArgs) Handles btHide.Click
        Hide()
    End Sub

    Private Sub chkJoselin_CheckedChanged(sender As Object, e As EventArgs) Handles chkJoselin.CheckedChanged

        If chkJoselin.Checked = True Then
            txtJoselin.Enabled = True
        Else
            txtJoselin.Clear()
            txtJoselin.Enabled = False
            lblJoselin.Text = String.Empty
            Me.Calculate()
        End If

    End Sub

    Private Sub chkSmith_CheckedChanged(sender As Object, e As EventArgs) Handles chkSmith.CheckedChanged
        If chkSmith.Checked = True Then
            txtSmith.Enabled = True
        Else
            txtSmith.Clear()
            txtSmith.Enabled = False
            lblSmith.Text = String.Empty
            Me.Calculate()
        End If
    End Sub

    Private Sub chkNoon_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoon.CheckedChanged

        If chkNoon.Checked = True Then
            txtNoon.Enabled = True
        Else
            txtNoon.Clear()
            txtNoon.Enabled = False
            lblNoon.Text = String.Empty
            Me.Calculate()
        End If

    End Sub

    Private Sub chkFai_CheckedChanged(sender As Object, e As EventArgs) Handles chkFai.CheckedChanged

        If chkFai.Checked = True Then
            txtFai.Enabled = True
        Else
            txtFai.Clear()
            txtFai.Enabled = False
            lblFai.Text = String.Empty
            Me.Calculate()
        End If

    End Sub

    Private Sub chkRosita_CheckedChanged(sender As Object, e As EventArgs) Handles chkRosita.CheckedChanged

        If chkRosita.Checked = True Then
            txtRosita.Enabled = True
        Else
            txtRosita.Clear()
            txtRosita.Enabled = False
            lblRosita.Text = String.Empty
            Me.Calculate()
        End If

    End Sub

    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Me.Calculate()
    End Sub

    Private Sub Calculate()
        Dim smithHp As Decimal = 0D
        Dim joselinHp As Decimal = 0D
        Dim noonHp As Decimal = 0D
        Dim faiHp As Decimal = 0D
        Dim rositaHp As Decimal = 0D
        Dim other1 As Decimal = 0D
        Dim other2 As Decimal = 0D
        Dim total As Decimal = 0D
        Try
            ' Check if the text box is not empty
            If txtJoselin.Text.Trim.Length > 0 Then
                joselinHp = CDec(txtJoselin.Text) * JOSELIN
                lblJoselin.Text = joselinHp.ToString("C")
            End If

            ' Check if the text box is not empty
            If txtSmith.Text.Trim.Length > 0 Then
                smithHp = CDec(txtSmith.Text) * SMITH
                lblSmith.Text = smithHp.ToString("C")
            End If

            ' Check if the text box is not empty
            If txtNoon.Text.Trim.Length > 0 Then
                noonHp = CDec(txtNoon.Text) * NOON
                lblNoon.Text = noonHp.ToString("C")
            End If

            ' Check if the text box is not empty
            If txtFai.Text.Trim.Length > 0 Then
                faiHp = CDec(txtFai.Text) * FAI
                lblFai.Text = faiHp.ToString("C")
            End If

            ' Check if the text box is not empty
            If txtRosita.Text.Trim.Length > 0 Then
                rositaHp = CDec(txtRosita.Text) * ROSITA
                lblRosita.Text = rositaHp.ToString("C")
            End If

            ' Check if the text box is not empty
            If txtOther1.Text.Trim.Length > 0 Then
                other1 = CDec(txtOther1.Text)
            End If

            ' Check if the text box is not empty
            If txtOther2.Text.Trim.Length > 0 Then
                other2 = CDec(txtOther2.Text)
            End If

            total = smithHp + joselinHp + noonHp + faiHp + rositaHp + other1 + other2
            lblTotal.Text = total.ToString("C")

            myCaller.txtHP.Text = lblTotal.Text
        Catch ex As Exception
            MessageBox.Show("Please Enter Numbers Only", "Invalid Input")
        End Try

    End Sub
End Class