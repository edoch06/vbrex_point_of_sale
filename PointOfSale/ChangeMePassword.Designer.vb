<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeMePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeMePassword))
        Me.currPswdTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.strenghtLbl = New System.Windows.Forms.Label
        Me.pswdTxt = New System.Windows.Forms.TextBox
        Me.passwdLbl = New System.Windows.Forms.Label
        Me.pswdConfirmationTxt = New System.Windows.Forms.TextBox
        Me.confirmpswdLbl = New System.Windows.Forms.Label
        Me.pswdChkbox = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.panelheader = New System.Windows.Forms.Panel
        Me.exitBtn = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.panelheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currPswdTxt
        '
        Me.currPswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currPswdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currPswdTxt.Location = New System.Drawing.Point(143, 37)
        Me.currPswdTxt.Name = "currPswdTxt"
        Me.currPswdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.currPswdTxt.Size = New System.Drawing.Size(200, 20)
        Me.currPswdTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Current Password"
        '
        'strenghtLbl
        '
        Me.strenghtLbl.AutoSize = True
        Me.strenghtLbl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strenghtLbl.Location = New System.Drawing.Point(150, 163)
        Me.strenghtLbl.Name = "strenghtLbl"
        Me.strenghtLbl.Size = New System.Drawing.Size(113, 14)
        Me.strenghtLbl.TabIndex = 296
        Me.strenghtLbl.Text = "Password Information"
        '
        'pswdTxt
        '
        Me.pswdTxt.BackColor = System.Drawing.Color.White
        Me.pswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pswdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pswdTxt.Location = New System.Drawing.Point(143, 60)
        Me.pswdTxt.Name = "pswdTxt"
        Me.pswdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.pswdTxt.Size = New System.Drawing.Size(200, 20)
        Me.pswdTxt.TabIndex = 1
        '
        'passwdLbl
        '
        Me.passwdLbl.AutoSize = True
        Me.passwdLbl.Location = New System.Drawing.Point(23, 62)
        Me.passwdLbl.Name = "passwdLbl"
        Me.passwdLbl.Size = New System.Drawing.Size(78, 13)
        Me.passwdLbl.TabIndex = 289
        Me.passwdLbl.Text = "New Password"
        '
        'pswdConfirmationTxt
        '
        Me.pswdConfirmationTxt.BackColor = System.Drawing.Color.White
        Me.pswdConfirmationTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pswdConfirmationTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pswdConfirmationTxt.Location = New System.Drawing.Point(143, 83)
        Me.pswdConfirmationTxt.Name = "pswdConfirmationTxt"
        Me.pswdConfirmationTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.pswdConfirmationTxt.Size = New System.Drawing.Size(200, 20)
        Me.pswdConfirmationTxt.TabIndex = 2
        '
        'confirmpswdLbl
        '
        Me.confirmpswdLbl.AutoSize = True
        Me.confirmpswdLbl.Location = New System.Drawing.Point(23, 85)
        Me.confirmpswdLbl.Name = "confirmpswdLbl"
        Me.confirmpswdLbl.Size = New System.Drawing.Size(91, 13)
        Me.confirmpswdLbl.TabIndex = 290
        Me.confirmpswdLbl.Text = "Confirm Password"
        '
        'pswdChkbox
        '
        Me.pswdChkbox.AutoSize = True
        Me.pswdChkbox.Location = New System.Drawing.Point(143, 109)
        Me.pswdChkbox.Name = "pswdChkbox"
        Me.pswdChkbox.Size = New System.Drawing.Size(135, 17)
        Me.pswdChkbox.TabIndex = 291
        Me.pswdChkbox.Text = "Make Password Visible"
        Me.pswdChkbox.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pswdChkbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.pswdChkbox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.panelheader)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.pswdTxt)
        Me.Panel1.Controls.Add(Me.currPswdTxt)
        Me.Panel1.Controls.Add(Me.passwdLbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pswdChkbox)
        Me.Panel1.Controls.Add(Me.pswdConfirmationTxt)
        Me.Panel1.Controls.Add(Me.strenghtLbl)
        Me.Panel1.Controls.Add(Me.confirmpswdLbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 190)
        Me.Panel1.TabIndex = 301
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.White
        Me.panelheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelheader.Controls.Add(Me.exitBtn)
        Me.panelheader.Controls.Add(Me.Label2)
        Me.panelheader.Controls.Add(Me.PictureBox1)
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(413, 25)
        Me.panelheader.TabIndex = 396
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.BackColor = System.Drawing.Color.White
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.Black
        Me.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.exitBtn.Location = New System.Drawing.Point(380, 1)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(26, 22)
        Me.exitBtn.TabIndex = 294
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 296
        Me.Label2.Text = "Change Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PointOfSale.My.Resources.Resources.keys
        Me.PictureBox1.Location = New System.Drawing.Point(8, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 295
        Me.PictureBox1.TabStop = False
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
        Me.btn_close.Location = New System.Drawing.Point(232, 132)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(89, 25)
        Me.btn_close.TabIndex = 395
        Me.btn_close.Text = "Cancel"
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
        Me.btn_ok.Location = New System.Drawing.Point(141, 132)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(89, 25)
        Me.btn_ok.TabIndex = 394
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'ChangeMePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(417, 194)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeMePassword"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelheader.ResumeLayout(False)
        Me.panelheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents strenghtLbl As System.Windows.Forms.Label
    Friend WithEvents pswdTxt As System.Windows.Forms.TextBox
    Friend WithEvents passwdLbl As System.Windows.Forms.Label
    Friend WithEvents pswdConfirmationTxt As System.Windows.Forms.TextBox
    Friend WithEvents confirmpswdLbl As System.Windows.Forms.Label
    Friend WithEvents pswdChkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents currPswdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents panelheader As System.Windows.Forms.Panel
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
