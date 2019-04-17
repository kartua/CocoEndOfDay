<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblLunck = New System.Windows.Forms.Label()
        Me.txtCarry = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCreditTip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVoid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddTc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExpenses = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCashTipCharged = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotalShift = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btCalculate = New System.Windows.Forms.Button()
        Me.lblTotalDay = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btDetailExpenses = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btDetailHp = New System.Windows.Forms.Button()
        Me.btDetailWaitress = New System.Windows.Forms.Button()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btPreviewAdd = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLunchTip = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLunck
        '
        Me.lblLunck.AutoSize = True
        Me.lblLunck.Location = New System.Drawing.Point(31, 192)
        Me.lblLunck.Name = "lblLunck"
        Me.lblLunck.Size = New System.Drawing.Size(119, 17)
        Me.lblLunck.TabIndex = 0
        Me.lblLunck.Text = "Cash From Lunch"
        '
        'txtCarry
        '
        Me.txtCarry.Location = New System.Drawing.Point(40, 214)
        Me.txtCarry.Name = "txtCarry"
        Me.txtCarry.Size = New System.Drawing.Size(100, 22)
        Me.txtCarry.TabIndex = 7
        Me.txtCarry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(312, 189)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 22)
        Me.txtCash.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cash"
        '
        'txtCreditTip
        '
        Me.txtCreditTip.Location = New System.Drawing.Point(312, 256)
        Me.txtCreditTip.Name = "txtCreditTip"
        Me.txtCreditTip.Size = New System.Drawing.Size(100, 22)
        Me.txtCreditTip.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Credit Tip"
        '
        'txtVoid
        '
        Me.txtVoid.Location = New System.Drawing.Point(312, 223)
        Me.txtVoid.Name = "txtVoid"
        Me.txtVoid.Size = New System.Drawing.Size(100, 22)
        Me.txtVoid.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Void"
        '
        'txtAddTc
        '
        Me.txtAddTc.Location = New System.Drawing.Point(312, 423)
        Me.txtAddTc.Name = "txtAddTc"
        Me.txtAddTc.Size = New System.Drawing.Size(100, 22)
        Me.txtAddTc.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Add TC%"
        '
        'txtExpenses
        '
        Me.txtExpenses.Location = New System.Drawing.Point(312, 354)
        Me.txtExpenses.Name = "txtExpenses"
        Me.txtExpenses.Size = New System.Drawing.Size(100, 22)
        Me.txtExpenses.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(237, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Expenses"
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(312, 321)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(100, 22)
        Me.txtHP.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "HP"
        '
        'txtCashTipCharged
        '
        Me.txtCashTipCharged.Location = New System.Drawing.Point(312, 288)
        Me.txtCashTipCharged.Name = "txtCashTipCharged"
        Me.txtCashTipCharged.Size = New System.Drawing.Size(100, 22)
        Me.txtCashTipCharged.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(184, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cash Tip Charged"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sub Total"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(312, 385)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 28)
        Me.lblSubTotal.TabIndex = 23
        '
        'lblTotalShift
        '
        Me.lblTotalShift.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalShift.Location = New System.Drawing.Point(312, 570)
        Me.lblTotalShift.Name = "lblTotalShift"
        Me.lblTotalShift.Size = New System.Drawing.Size(100, 28)
        Me.lblTotalShift.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(237, 576)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total Shift"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(174, 476)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Add"
        '
        'btCalculate
        '
        Me.btCalculate.Location = New System.Drawing.Point(139, 658)
        Me.btCalculate.Name = "btCalculate"
        Me.btCalculate.Size = New System.Drawing.Size(124, 43)
        Me.btCalculate.TabIndex = 28
        Me.btCalculate.Text = "&Calculate"
        Me.btCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalDay
        '
        Me.lblTotalDay.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDay.Location = New System.Drawing.Point(206, 616)
        Me.lblTotalDay.Name = "lblTotalDay"
        Me.lblTotalDay.Size = New System.Drawing.Size(100, 28)
        Me.lblTotalDay.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(131, 617)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Total Day"
        '
        'btDetailExpenses
        '
        Me.btDetailExpenses.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btDetailExpenses.Location = New System.Drawing.Point(419, 354)
        Me.btDetailExpenses.Name = "btDetailExpenses"
        Me.btDetailExpenses.Size = New System.Drawing.Size(21, 22)
        Me.btDetailExpenses.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btDetailExpenses, "Click Here to Declare Expense")
        Me.btDetailExpenses.UseVisualStyleBackColor = False
        '
        'btDetailHp
        '
        Me.btDetailHp.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btDetailHp.Location = New System.Drawing.Point(419, 321)
        Me.btDetailHp.Name = "btDetailHp"
        Me.btDetailHp.Size = New System.Drawing.Size(21, 22)
        Me.btDetailHp.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.btDetailHp, "Click Here To Declare House Pay")
        Me.btDetailHp.UseVisualStyleBackColor = False
        '
        'btDetailWaitress
        '
        Me.btDetailWaitress.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btDetailWaitress.Location = New System.Drawing.Point(419, 463)
        Me.btDetailWaitress.Name = "btDetailWaitress"
        Me.btDetailWaitress.Size = New System.Drawing.Size(21, 22)
        Me.btDetailWaitress.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btDetailWaitress, "Click Here To Declare Waitress Tip Shared")
        Me.btDetailWaitress.UseVisualStyleBackColor = False
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.BackColor = System.Drawing.SystemColors.Control
        Me.lbladd.Location = New System.Drawing.Point(3, 5)
        Me.lbladd.MaximumSize = New System.Drawing.Size(170, 0)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(0, 17)
        Me.lbladd.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbladd)
        Me.Panel1.Location = New System.Drawing.Point(213, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 34
        '
        'btPreviewAdd
        '
        Me.btPreviewAdd.Location = New System.Drawing.Point(419, 507)
        Me.btPreviewAdd.Name = "btPreviewAdd"
        Me.btPreviewAdd.Size = New System.Drawing.Size(75, 35)
        Me.btPreviewAdd.TabIndex = 36
        Me.btPreviewAdd.Text = "Preview"
        Me.btPreviewAdd.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(316, 658)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(124, 43)
        Me.btExit.TabIndex = 37
        Me.btExit.Text = "&Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 25)
        Me.StatusStrip1.TabIndex = 38
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(90, 20)
        Me.ToolStripStatusLabel1.Text = "version 1.0.3"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Image = Global.cocoEndOfDay.My.Resources.Resources.logo
        Me.Label9.Location = New System.Drawing.Point(176, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 161)
        Me.Label9.TabIndex = 35
        '
        'txtLunchTip
        '
        Me.txtLunchTip.Location = New System.Drawing.Point(40, 278)
        Me.txtLunchTip.Name = "txtLunchTip"
        Me.txtLunchTip.Size = New System.Drawing.Size(100, 22)
        Me.txtLunchTip.TabIndex = 40
        Me.txtLunchTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Luch Tip Each"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 748)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLunchTip)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btPreviewAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btDetailWaitress)
        Me.Controls.Add(Me.btDetailHp)
        Me.Controls.Add(Me.btDetailExpenses)
        Me.Controls.Add(Me.lblTotalDay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btCalculate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTotalShift)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAddTc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtExpenses)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCashTipCharged)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCreditTip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVoid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCarry)
        Me.Controls.Add(Me.lblLunck)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Coco Thai Bistro END of DAY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLunck As Label
    Friend WithEvents txtCarry As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCreditTip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVoid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddTc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExpenses As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCashTipCharged As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotalShift As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btCalculate As Button
    Friend WithEvents lblTotalDay As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btDetailExpenses As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btDetailHp As Button
    Friend WithEvents btDetailWaitress As Button
    Friend WithEvents lbladd As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btPreviewAdd As Button
    Friend WithEvents btExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLunchTip As TextBox
    Friend WithEvents Label12 As Label
End Class
