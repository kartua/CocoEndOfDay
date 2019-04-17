<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewTip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewTip))
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.linkPrint = New System.Windows.Forms.LinkLabel()
        Me.linkHide = New System.Windows.Forms.LinkLabel()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.Location = New System.Drawing.Point(13, 66)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(71, 25)
        Me.lblPreview.TabIndex = 0
        Me.lblPreview.Text = "Label1"
        '
        'linkPrint
        '
        Me.linkPrint.AutoSize = True
        Me.linkPrint.Location = New System.Drawing.Point(15, 13)
        Me.linkPrint.Name = "linkPrint"
        Me.linkPrint.Size = New System.Drawing.Size(37, 17)
        Me.linkPrint.TabIndex = 1
        Me.linkPrint.TabStop = True
        Me.linkPrint.Text = "Print"
        '
        'linkHide
        '
        Me.linkHide.AutoSize = True
        Me.linkHide.Location = New System.Drawing.Point(73, 13)
        Me.linkHide.Name = "linkHide"
        Me.linkHide.Size = New System.Drawing.Size(37, 17)
        Me.linkHide.TabIndex = 2
        Me.linkHide.TabStop = True
        Me.linkHide.Text = "Hide"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PreviewTip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(264, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.linkHide)
        Me.Controls.Add(Me.linkPrint)
        Me.Controls.Add(Me.lblPreview)
        Me.Name = "PreviewTip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PreviewTip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPreview As Label
    Friend WithEvents linkPrint As LinkLabel
    Friend WithEvents linkHide As LinkLabel
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
