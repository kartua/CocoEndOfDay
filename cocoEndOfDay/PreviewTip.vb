﻿Public Class PreviewTip
    'Reference this form to Main
    Inherits System.Windows.Forms.Form
    Public myCaller As Main

    Private Sub linkHide_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHide.LinkClicked
        Me.Hide()
    End Sub

    Private Sub linkPrint_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkPrint.LinkClicked
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(20, 20, 50, 50)
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.Print()

    End Sub
    '''''''''''''''''''''''''


End Class