Public Class Password
    'Reference this form to Main
    Inherits System.Windows.Forms.Form
    Public myCaller As Main

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtPassword.Text = "8888" Then
                myCaller.showHpForm()

                Hide()
            Else
                txtPassword.Text = String.Empty
                MessageBox.Show("Click Close to close")

            End If
        Else
            txtPassword.PasswordChar = "๘"
        End If

    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Hide()

    End Sub

    Private Sub txtPassword_Clice(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.PasswordChar = "๘"
        txtPassword.Text = String.Empty
    End Sub

End Class