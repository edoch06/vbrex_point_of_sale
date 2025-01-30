<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashPickUp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel49 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lbl_companyname = New System.Windows.Forms.Label
        Me.exitBtn = New System.Windows.Forms.Button
        Me.closeBtn = New System.Windows.Forms.Button
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.amntTenTxt = New System.Windows.Forms.TextBox
        Me.amnttenLbl = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.paymntDueTxt = New System.Windows.Forms.TextBox
        Me.paymentDueLbl = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt_balance = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblcreatedby = New System.Windows.Forms.Label
        Me.paymntVLbl = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.amntpaidLbl = New System.Windows.Forms.Label
        Me.amntpaidTxt = New System.Windows.Forms.TextBox
        Me.processPayBtn = New System.Windows.Forms.Button
        Me.CustomGroupBox2 = New PointOfSale.CustomGroupBox
        Me.dgvSettlements = New System.Windows.Forms.DataGridView
        Me.Panel49.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        CType(Me.dgvSettlements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel49
        '
        Me.Panel49.BackColor = System.Drawing.Color.White
        Me.Panel49.Controls.Add(Me.Panel7)
        Me.Panel49.Controls.Add(Me.CustomGroupBox2)
        Me.Panel49.Controls.Add(Me.closeBtn)
        Me.Panel49.Controls.Add(Me.Panel11)
        Me.Panel49.Controls.Add(Me.Panel3)
        Me.Panel49.Controls.Add(Me.Panel1)
        Me.Panel49.Controls.Add(Me.Panel4)
        Me.Panel49.Controls.Add(Me.Panel6)
        Me.Panel49.Controls.Add(Me.processPayBtn)
        Me.Panel49.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel49.Location = New System.Drawing.Point(2, 2)
        Me.Panel49.Name = "Panel49"
        Me.Panel49.Size = New System.Drawing.Size(652, 308)
        Me.Panel49.TabIndex = 18
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lbl_companyname)
        Me.Panel7.Controls.Add(Me.exitBtn)
        Me.Panel7.Location = New System.Drawing.Point(6, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(639, 23)
        Me.Panel7.TabIndex = 337
        '
        'lbl_companyname
        '
        Me.lbl_companyname.AutoSize = True
        Me.lbl_companyname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_companyname.ForeColor = System.Drawing.Color.Black
        Me.lbl_companyname.Location = New System.Drawing.Point(6, 3)
        Me.lbl_companyname.Name = "lbl_companyname"
        Me.lbl_companyname.Size = New System.Drawing.Size(82, 15)
        Me.lbl_companyname.TabIndex = 5
        Me.lbl_companyname.Text = "Cash Pick Up"
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.BackColor = System.Drawing.Color.White
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.Black
        Me.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.exitBtn.Location = New System.Drawing.Point(608, 0)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(26, 22)
        Me.exitBtn.TabIndex = 296
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Black
        Me.closeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.closeBtn.Location = New System.Drawing.Point(381, 266)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(262, 34)
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.Text = "Close (F4)"
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.amntTenTxt)
        Me.Panel11.Controls.Add(Me.amnttenLbl)
        Me.Panel11.Location = New System.Drawing.Point(381, 63)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(264, 51)
        Me.Panel11.TabIndex = 333
        '
        'amntTenTxt
        '
        Me.amntTenTxt.BackColor = System.Drawing.Color.White
        Me.amntTenTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.amntTenTxt.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amntTenTxt.ForeColor = System.Drawing.Color.Black
        Me.amntTenTxt.Location = New System.Drawing.Point(33, 17)
        Me.amntTenTxt.Name = "amntTenTxt"
        Me.amntTenTxt.Size = New System.Drawing.Size(198, 30)
        Me.amntTenTxt.TabIndex = 25
        Me.amntTenTxt.Text = "0.00"
        Me.amntTenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'amnttenLbl
        '
        Me.amnttenLbl.AutoSize = True
        Me.amnttenLbl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amnttenLbl.ForeColor = System.Drawing.Color.Black
        Me.amnttenLbl.Location = New System.Drawing.Point(5, 3)
        Me.amnttenLbl.Name = "amnttenLbl"
        Me.amnttenLbl.Size = New System.Drawing.Size(107, 14)
        Me.amnttenLbl.TabIndex = 0
        Me.amnttenLbl.Text = "Amount Tendered"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.paymntDueTxt)
        Me.Panel3.Controls.Add(Me.paymentDueLbl)
        Me.Panel3.Location = New System.Drawing.Point(381, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 51)
        Me.Panel3.TabIndex = 333
        '
        'paymntDueTxt
        '
        Me.paymntDueTxt.BackColor = System.Drawing.Color.White
        Me.paymntDueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.paymntDueTxt.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymntDueTxt.ForeColor = System.Drawing.Color.Black
        Me.paymntDueTxt.Location = New System.Drawing.Point(35, 16)
        Me.paymntDueTxt.Name = "paymntDueTxt"
        Me.paymntDueTxt.Size = New System.Drawing.Size(195, 30)
        Me.paymntDueTxt.TabIndex = 25
        Me.paymntDueTxt.Text = "0.00"
        Me.paymntDueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'paymentDueLbl
        '
        Me.paymentDueLbl.AutoSize = True
        Me.paymentDueLbl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDueLbl.ForeColor = System.Drawing.Color.Black
        Me.paymentDueLbl.Location = New System.Drawing.Point(3, 3)
        Me.paymentDueLbl.Name = "paymentDueLbl"
        Me.paymentDueLbl.Size = New System.Drawing.Size(47, 14)
        Me.paymentDueLbl.TabIndex = 0
        Me.paymentDueLbl.Text = "Pick Up"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_balance)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(381, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 51)
        Me.Panel1.TabIndex = 331
        '
        'txt_balance
        '
        Me.txt_balance.BackColor = System.Drawing.Color.White
        Me.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_balance.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_balance.ForeColor = System.Drawing.Color.Black
        Me.txt_balance.Location = New System.Drawing.Point(33, 14)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(198, 30)
        Me.txt_balance.TabIndex = 27
        Me.txt_balance.Text = "0.00"
        Me.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Balance"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblcreatedby)
        Me.Panel4.Controls.Add(Me.paymntVLbl)
        Me.Panel4.Location = New System.Drawing.Point(381, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(264, 24)
        Me.Panel4.TabIndex = 31
        '
        'lblcreatedby
        '
        Me.lblcreatedby.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcreatedby.AutoSize = True
        Me.lblcreatedby.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreatedby.ForeColor = System.Drawing.Color.Black
        Me.lblcreatedby.Location = New System.Drawing.Point(5, 5)
        Me.lblcreatedby.Name = "lblcreatedby"
        Me.lblcreatedby.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcreatedby.Size = New System.Drawing.Size(36, 15)
        Me.lblcreatedby.TabIndex = 32
        Me.lblcreatedby.Text = "Type:"
        Me.lblcreatedby.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'paymntVLbl
        '
        Me.paymntVLbl.BackColor = System.Drawing.Color.White
        Me.paymntVLbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.paymntVLbl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymntVLbl.ForeColor = System.Drawing.Color.Black
        Me.paymntVLbl.Location = New System.Drawing.Point(109, 5)
        Me.paymntVLbl.Name = "paymntVLbl"
        Me.paymntVLbl.Size = New System.Drawing.Size(46, 14)
        Me.paymntVLbl.TabIndex = 0
        Me.paymntVLbl.Text = "Cash"
        Me.paymntVLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.amntpaidLbl)
        Me.Panel6.Controls.Add(Me.amntpaidTxt)
        Me.Panel6.Location = New System.Drawing.Point(106, 234)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(269, 48)
        Me.Panel6.TabIndex = 7
        '
        'amntpaidLbl
        '
        Me.amntpaidLbl.AutoSize = True
        Me.amntpaidLbl.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amntpaidLbl.ForeColor = System.Drawing.Color.Black
        Me.amntpaidLbl.Location = New System.Drawing.Point(9, 8)
        Me.amntpaidLbl.Name = "amntpaidLbl"
        Me.amntpaidLbl.Size = New System.Drawing.Size(45, 16)
        Me.amntpaidLbl.TabIndex = 14
        Me.amntpaidLbl.Text = "Amount"
        '
        'amntpaidTxt
        '
        Me.amntpaidTxt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.amntpaidTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amntpaidTxt.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amntpaidTxt.ForeColor = System.Drawing.Color.Black
        Me.amntpaidTxt.Location = New System.Drawing.Point(84, 8)
        Me.amntpaidTxt.Name = "amntpaidTxt"
        Me.amntpaidTxt.Size = New System.Drawing.Size(161, 31)
        Me.amntpaidTxt.TabIndex = 1
        '
        'processPayBtn
        '
        Me.processPayBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.processPayBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.processPayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.processPayBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processPayBtn.ForeColor = System.Drawing.Color.Black
        Me.processPayBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.processPayBtn.Location = New System.Drawing.Point(381, 234)
        Me.processPayBtn.Name = "processPayBtn"
        Me.processPayBtn.Size = New System.Drawing.Size(262, 28)
        Me.processPayBtn.TabIndex = 0
        Me.processPayBtn.Text = "Enter PickUp (Enter)"
        Me.processPayBtn.UseVisualStyleBackColor = False
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.DimGray
        Me.CustomGroupBox2.Controls.Add(Me.dgvSettlements)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(6, 33)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(369, 196)
        Me.CustomGroupBox2.TabIndex = 336
        Me.CustomGroupBox2.TabStop = False
        '
        'dgvSettlements
        '
        Me.dgvSettlements.AllowUserToAddRows = False
        Me.dgvSettlements.AllowUserToDeleteRows = False
        Me.dgvSettlements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSettlements.BackgroundColor = System.Drawing.Color.White
        Me.dgvSettlements.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSettlements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSettlements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSettlements.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSettlements.EnableHeadersVisualStyles = False
        Me.dgvSettlements.GridColor = System.Drawing.Color.White
        Me.dgvSettlements.Location = New System.Drawing.Point(1, 1)
        Me.dgvSettlements.Name = "dgvSettlements"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSettlements.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSettlements.RowHeadersVisible = False
        Me.dgvSettlements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSettlements.Size = New System.Drawing.Size(367, 194)
        Me.dgvSettlements.TabIndex = 335
        '
        'CashPickUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(656, 312)
        Me.Controls.Add(Me.Panel49)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "CashPickUp"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashPickUp"
        Me.Panel49.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.CustomGroupBox2.ResumeLayout(False)
        CType(Me.dgvSettlements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel49 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl_companyname As System.Windows.Forms.Label
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents CustomGroupBox2 As PointOfSale.CustomGroupBox
    Friend WithEvents dgvSettlements As System.Windows.Forms.DataGridView
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents processPayBtn As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents amntTenTxt As System.Windows.Forms.TextBox
    Friend WithEvents amnttenLbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents paymntDueTxt As System.Windows.Forms.TextBox
    Friend WithEvents paymentDueLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblcreatedby As System.Windows.Forms.Label
    Friend WithEvents paymntVLbl As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents amntpaidLbl As System.Windows.Forms.Label
    Friend WithEvents amntpaidTxt As System.Windows.Forms.TextBox
End Class
