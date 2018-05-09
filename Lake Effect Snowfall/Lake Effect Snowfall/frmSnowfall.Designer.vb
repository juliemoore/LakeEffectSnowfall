<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSnowfall
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
        Me.mnuSnowfall = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalSnowfall = New System.Windows.Forms.Label()
        Me.btnSnowfall = New System.Windows.Forms.Button()
        Me.lstSnowfall = New System.Windows.Forms.ListBox()
        Me.mnuSnowfall.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuSnowfall
        '
        Me.mnuSnowfall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuSnowfall.Location = New System.Drawing.Point(0, 0)
        Me.mnuSnowfall.Name = "mnuSnowfall"
        Me.mnuSnowfall.Size = New System.Drawing.Size(659, 24)
        Me.mnuSnowfall.TabIndex = 0
        Me.mnuSnowfall.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblTitle.Location = New System.Drawing.Point(136, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(386, 75)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Lake Effect Snowfall October through April"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSnowfall
        '
        Me.lblTotalSnowfall.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSnowfall.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSnowfall.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTotalSnowfall.Location = New System.Drawing.Point(71, 369)
        Me.lblTotalSnowfall.Name = "lblTotalSnowfall"
        Me.lblTotalSnowfall.Size = New System.Drawing.Size(517, 48)
        Me.lblTotalSnowfall.TabIndex = 2
        Me.lblTotalSnowfall.Text = "Total Snowfall is 888.8 inches"
        Me.lblTotalSnowfall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotalSnowfall.Visible = False
        '
        'btnSnowfall
        '
        Me.btnSnowfall.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSnowfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnowfall.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSnowfall.Location = New System.Drawing.Point(203, 125)
        Me.btnSnowfall.Name = "btnSnowfall"
        Me.btnSnowfall.Size = New System.Drawing.Size(252, 41)
        Me.btnSnowfall.TabIndex = 3
        Me.btnSnowfall.Text = "Enter Snowfall Amount"
        Me.btnSnowfall.UseVisualStyleBackColor = False
        '
        'lstSnowfall
        '
        Me.lstSnowfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSnowfall.FormattingEnabled = True
        Me.lstSnowfall.ItemHeight = 23
        Me.lstSnowfall.Location = New System.Drawing.Point(222, 191)
        Me.lstSnowfall.Name = "lstSnowfall"
        Me.lstSnowfall.Size = New System.Drawing.Size(215, 165)
        Me.lstSnowfall.TabIndex = 4
        '
        'frmSnowfall
        '
        Me.AcceptButton = Me.btnSnowfall
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lake_Effect_Snowfall.My.Resources.Resources.lake_effect_snowfall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 436)
        Me.Controls.Add(Me.lstSnowfall)
        Me.Controls.Add(Me.btnSnowfall)
        Me.Controls.Add(Me.lblTotalSnowfall)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuSnowfall)
        Me.MainMenuStrip = Me.mnuSnowfall
        Me.Name = "frmSnowfall"
        Me.Text = "Lake Effect Snowfall"
        Me.mnuSnowfall.ResumeLayout(False)
        Me.mnuSnowfall.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuSnowfall As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalSnowfall As Label
    Friend WithEvents btnSnowfall As Button
    Friend WithEvents lstSnowfall As ListBox
End Class
