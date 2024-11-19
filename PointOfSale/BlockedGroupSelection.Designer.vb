<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockedGroupSelection
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlockedGroupSelection))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CustomGroupBox2 = New PointOfSale.CustomGroupBox
        Me.dgvGrps = New System.Windows.Forms.DataGridView
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.panelheader = New System.Windows.Forms.Panel
        Me.exitBtn = New System.Windows.Forms.Button
        Me.POSTitleLbl = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        CType(Me.dgvGrps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 13)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Click on a group then press OK to select a group to block"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Group Selection"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CustomGroupBox2)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.panelheader)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 408)
        Me.Panel1.TabIndex = 349
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.DimGray
        Me.CustomGroupBox2.Controls.Add(Me.dgvGrps)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(7, 88)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(361, 311)
        Me.CustomGroupBox2.TabIndex = 352
        Me.CustomGroupBox2.TabStop = False
        '
        'dgvGrps
        '
        Me.dgvGrps.AllowUserToAddRows = False
        Me.dgvGrps.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvGrps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGrps.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrps.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrps.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrps.EnableHeadersVisualStyles = False
        Me.dgvGrps.GridColor = System.Drawing.Color.White
        Me.dgvGrps.Location = New System.Drawing.Point(1, 1)
        Me.dgvGrps.Name = "dgvGrps"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrps.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrps.RowHeadersVisible = False
        Me.dgvGrps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrps.Size = New System.Drawing.Size(359, 309)
        Me.dgvGrps.TabIndex = 335
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
        Me.btn_close.Location = New System.Drawing.Point(385, 122)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(91, 28)
        Me.btn_close.TabIndex = 351
        Me.btn_close.Text = "Close"
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
        Me.btn_ok.Location = New System.Drawing.Point(385, 88)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(91, 28)
        Me.btn_ok.TabIndex = 350
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.White
        Me.panelheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelheader.Controls.Add(Me.exitBtn)
        Me.panelheader.Controls.Add(Me.POSTitleLbl)
        Me.panelheader.Controls.Add(Me.PictureBox1)
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(491, 25)
        Me.panelheader.TabIndex = 349
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
        Me.exitBtn.Location = New System.Drawing.Point(458, 1)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(26, 22)
        Me.exitBtn.TabIndex = 294
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'POSTitleLbl
        '
        Me.POSTitleLbl.AutoSize = True
        Me.POSTitleLbl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSTitleLbl.ForeColor = System.Drawing.Color.Black
        Me.POSTitleLbl.Location = New System.Drawing.Point(40, 5)
        Me.POSTitleLbl.Name = "POSTitleLbl"
        Me.POSTitleLbl.Size = New System.Drawing.Size(117, 15)
        Me.POSTitleLbl.TabIndex = 296
        Me.POSTitleLbl.Text = "Add Group To Block"
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
        'BlockedGroupSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(495, 412)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BlockedGroupSelection"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Selection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CustomGroupBox2.ResumeLayout(False)
        CType(Me.dgvGrps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelheader.ResumeLayout(False)
        Me.panelheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelheader As System.Windows.Forms.Panel
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents POSTitleLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents CustomGroupBox2 As PointOfSale.CustomGroupBox
    Friend WithEvents dgvGrps As System.Windows.Forms.DataGridView
End Class
