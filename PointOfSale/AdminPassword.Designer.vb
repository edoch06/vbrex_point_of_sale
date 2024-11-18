<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPassword
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_close = New System.Windows.Forms.Button
        Me.panelheader = New System.Windows.Forms.Panel
        Me.exitBtn = New System.Windows.Forms.Button
        Me.strenghtLbl = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_ok = New System.Windows.Forms.Button
        Me.validInfoLbl = New System.Windows.Forms.Label
        Me.pswdChkbox = New System.Windows.Forms.CheckBox
        Me.confirmpswdLbl = New System.Windows.Forms.Label
        Me.pswdTxt = New System.Windows.Forms.TextBox
        Me.Panel3.SuspendLayout()
        Me.panelheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.panelheader)
        Me.Panel3.Controls.Add(Me.btn_ok)
        Me.Panel3.Controls.Add(Me.validInfoLbl)
        Me.Panel3.Controls.Add(Me.pswdChkbox)
        Me.Panel3.Controls.Add(Me.confirmpswdLbl)
        Me.Panel3.Controls.Add(Me.pswdTxt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 155)
        Me.Panel3.TabIndex = 296
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
        Me.btn_close.Location = New System.Drawing.Point(148, 93)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(89, 25)
        Me.btn_close.TabIndex = 329
        Me.btn_close.Text = "Cancel (F4)"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.White
        Me.panelheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelheader.Controls.Add(Me.exitBtn)
        Me.panelheader.Controls.Add(Me.strenghtLbl)
        Me.panelheader.Controls.Add(Me.PictureBox1)
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(311, 25)
        Me.panelheader.TabIndex = 293
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
        Me.exitBtn.Location = New System.Drawing.Point(278, 1)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(26, 22)
        Me.exitBtn.TabIndex = 294
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'strenghtLbl
        '
        Me.strenghtLbl.AutoSize = True
        Me.strenghtLbl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strenghtLbl.ForeColor = System.Drawing.Color.Black
        Me.strenghtLbl.Location = New System.Drawing.Point(47, 5)
        Me.strenghtLbl.Name = "strenghtLbl"
        Me.strenghtLbl.Size = New System.Drawing.Size(65, 15)
        Me.strenghtLbl.TabIndex = 296
        Me.strenghtLbl.Text = "Password"
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
        Me.btn_ok.Location = New System.Drawing.Point(51, 93)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(89, 25)
        Me.btn_ok.TabIndex = 328
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'validInfoLbl
        '
        Me.validInfoLbl.AutoSize = True
        Me.validInfoLbl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validInfoLbl.ForeColor = System.Drawing.Color.Black
        Me.validInfoLbl.Location = New System.Drawing.Point(76, 124)
        Me.validInfoLbl.Name = "validInfoLbl"
        Me.validInfoLbl.Size = New System.Drawing.Size(146, 14)
        Me.validInfoLbl.TabIndex = 15
        Me.validInfoLbl.Text = "Your Login Details are Invalid"
        '
        'pswdChkbox
        '
        Me.pswdChkbox.AutoSize = True
        Me.pswdChkbox.ForeColor = System.Drawing.Color.Black
        Me.pswdChkbox.Location = New System.Drawing.Point(51, 70)
        Me.pswdChkbox.Name = "pswdChkbox"
        Me.pswdChkbox.Size = New System.Drawing.Size(135, 17)
        Me.pswdChkbox.TabIndex = 291
        Me.pswdChkbox.Text = "Make Password Visible"
        Me.pswdChkbox.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pswdChkbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.pswdChkbox.UseVisualStyleBackColor = True
        '
        'confirmpswdLbl
        '
        Me.confirmpswdLbl.AutoSize = True
        Me.confirmpswdLbl.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpswdLbl.ForeColor = System.Drawing.Color.DimGray
        Me.confirmpswdLbl.Location = New System.Drawing.Point(48, 28)
        Me.confirmpswdLbl.Name = "confirmpswdLbl"
        Me.confirmpswdLbl.Size = New System.Drawing.Size(53, 15)
        Me.confirmpswdLbl.TabIndex = 290
        Me.confirmpswdLbl.Text = "Password"
        '
        'pswdTxt
        '
        Me.pswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pswdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pswdTxt.Location = New System.Drawing.Point(51, 44)
        Me.pswdTxt.Name = "pswdTxt"
        Me.pswdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.pswdTxt.Size = New System.Drawing.Size(200, 20)
        Me.pswdTxt.TabIndex = 286
        '
        'AdminPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(315, 159)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "AdminPassword"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPassword"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelheader.ResumeLayout(False)
        Me.panelheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents panelheader As System.Windows.Forms.Panel
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents strenghtLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents validInfoLbl As System.Windows.Forms.Label
    Friend WithEvents pswdChkbox As System.Windows.Forms.CheckBox
    Friend WithEvents confirmpswdLbl As System.Windows.Forms.Label
    Friend WithEvents pswdTxt As System.Windows.Forms.TextBox
End Class
