<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelLayby
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CustomGroupBox2 = New PointOfSale.CustomGroupBox
        Me.lbl_balance = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_deposit = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.lbl_amount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.panelheader = New System.Windows.Forms.Panel
        Me.exitBtn = New System.Windows.Forms.Button
        Me.POSTitleLbl = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        Me.panelheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.CustomGroupBox2)
        Me.Panel1.Controls.Add(Me.panelheader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 320)
        Me.Panel1.TabIndex = 6
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BackColor = System.Drawing.Color.White
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.DimGray
        Me.CustomGroupBox2.Controls.Add(Me.lbl_balance)
        Me.CustomGroupBox2.Controls.Add(Me.Label7)
        Me.CustomGroupBox2.Controls.Add(Me.lbl_deposit)
        Me.CustomGroupBox2.Controls.Add(Me.Label5)
        Me.CustomGroupBox2.Controls.Add(Me.btn_close)
        Me.CustomGroupBox2.Controls.Add(Me.btn_ok)
        Me.CustomGroupBox2.Controls.Add(Me.lbl_amount)
        Me.CustomGroupBox2.Controls.Add(Me.Label2)
        Me.CustomGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomGroupBox2.Location = New System.Drawing.Point(0, 77)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(408, 243)
        Me.CustomGroupBox2.TabIndex = 296
        Me.CustomGroupBox2.TabStop = False
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.ForeColor = System.Drawing.Color.Black
        Me.lbl_balance.Location = New System.Drawing.Point(231, 94)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(59, 29)
        Me.lbl_balance.TabIndex = 329
        Me.lbl_balance.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(116, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 29)
        Me.Label7.TabIndex = 328
        Me.Label7.Text = "Balance"
        '
        'lbl_deposit
        '
        Me.lbl_deposit.AutoSize = True
        Me.lbl_deposit.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deposit.ForeColor = System.Drawing.Color.Black
        Me.lbl_deposit.Location = New System.Drawing.Point(231, 54)
        Me.lbl_deposit.Name = "lbl_deposit"
        Me.lbl_deposit.Size = New System.Drawing.Size(59, 29)
        Me.lbl_deposit.TabIndex = 327
        Me.lbl_deposit.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(116, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 29)
        Me.Label5.TabIndex = 326
        Me.Label5.Text = "Deposit"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(206, 180)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 28)
        Me.btn_close.TabIndex = 325
        Me.btn_close.Text = "Close F4"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(96, 180)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(104, 28)
        Me.btn_ok.TabIndex = 324
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.ForeColor = System.Drawing.Color.Black
        Me.lbl_amount.Location = New System.Drawing.Point(231, 16)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(59, 29)
        Me.lbl_amount.TabIndex = 298
        Me.lbl_amount.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(116, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 29)
        Me.Label2.TabIndex = 297
        Me.Label2.Text = "Amount"
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.White
        Me.panelheader.Controls.Add(Me.exitBtn)
        Me.panelheader.Controls.Add(Me.POSTitleLbl)
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(408, 77)
        Me.panelheader.TabIndex = 295
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.BackColor = System.Drawing.Color.White
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.Black
        Me.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.exitBtn.Location = New System.Drawing.Point(377, 1)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(26, 22)
        Me.exitBtn.TabIndex = 294
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'POSTitleLbl
        '
        Me.POSTitleLbl.AutoSize = True
        Me.POSTitleLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSTitleLbl.ForeColor = System.Drawing.Color.Black
        Me.POSTitleLbl.Location = New System.Drawing.Point(132, 31)
        Me.POSTitleLbl.Name = "POSTitleLbl"
        Me.POSTitleLbl.Size = New System.Drawing.Size(145, 24)
        Me.POSTitleLbl.TabIndex = 296
        Me.POSTitleLbl.Text = "Cancel Layby"
        '
        'CancelLayby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(412, 324)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "CancelLayby"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CancelLayby"
        Me.Panel1.ResumeLayout(False)
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.CustomGroupBox2.PerformLayout()
        Me.panelheader.ResumeLayout(False)
        Me.panelheader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CustomGroupBox2 As PointOfSale.CustomGroupBox
    Friend WithEvents lbl_balance As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_deposit As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelheader As System.Windows.Forms.Panel
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents POSTitleLbl As System.Windows.Forms.Label
End Class
