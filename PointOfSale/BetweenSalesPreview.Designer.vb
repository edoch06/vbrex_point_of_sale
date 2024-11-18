<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BetweenSalesPreview
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
        Me.rprtviewer_sales = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.panelheader = New System.Windows.Forms.Panel
        Me.exitBtn = New System.Windows.Forms.Button
        Me.POSTitleLbl = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.rect_maximise = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Panel1.SuspendLayout()
        Me.panelheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.rprtviewer_sales)
        Me.Panel1.Controls.Add(Me.panelheader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 465)
        Me.Panel1.TabIndex = 4
        '
        'rprtviewer_sales
        '
        Me.rprtviewer_sales.ActiveViewIndex = -1
        Me.rprtviewer_sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rprtviewer_sales.DisplayBackgroundEdge = False
        Me.rprtviewer_sales.DisplayGroupTree = False
        Me.rprtviewer_sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rprtviewer_sales.Location = New System.Drawing.Point(0, 25)
        Me.rprtviewer_sales.Name = "rprtviewer_sales"
        Me.rprtviewer_sales.SelectionFormula = ""
        Me.rprtviewer_sales.ShowCloseButton = False
        Me.rprtviewer_sales.ShowGroupTreeButton = False
        Me.rprtviewer_sales.Size = New System.Drawing.Size(783, 440)
        Me.rprtviewer_sales.TabIndex = 296
        Me.rprtviewer_sales.ViewTimeSelectionFormula = ""
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.White
        Me.panelheader.Controls.Add(Me.exitBtn)
        Me.panelheader.Controls.Add(Me.POSTitleLbl)
        Me.panelheader.Controls.Add(Me.PictureBox1)
        Me.panelheader.Controls.Add(Me.ShapeContainer1)
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(783, 25)
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
        Me.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.Black
        Me.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.exitBtn.Location = New System.Drawing.Point(752, 1)
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
        Me.POSTitleLbl.Location = New System.Drawing.Point(47, 5)
        Me.POSTitleLbl.Name = "POSTitleLbl"
        Me.POSTitleLbl.Size = New System.Drawing.Size(83, 15)
        Me.POSTitleLbl.TabIndex = 296
        Me.POSTitleLbl.Text = "Print Preview"
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rect_maximise})
        Me.ShapeContainer1.Size = New System.Drawing.Size(783, 25)
        Me.ShapeContainer1.TabIndex = 298
        Me.ShapeContainer1.TabStop = False
        '
        'rect_maximise
        '
        Me.rect_maximise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rect_maximise.BorderWidth = 2
        Me.rect_maximise.Location = New System.Drawing.Point(736, 8)
        Me.rect_maximise.Name = "rect_maximise"
        Me.rect_maximise.Size = New System.Drawing.Size(12, 10)
        '
        'BetweenSalesPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(787, 469)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BetweenSalesPreview"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "BetweenSalesPreview"
        Me.Panel1.ResumeLayout(False)
        Me.panelheader.ResumeLayout(False)
        Me.panelheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rprtviewer_sales As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents panelheader As System.Windows.Forms.Panel
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents POSTitleLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rect_maximise As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
