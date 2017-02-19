<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScoreForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HighScoreForm))
        Me.lstboxHighScores = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstboxHighScores
        '
        Me.lstboxHighScores.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxHighScores.FormattingEnabled = True
        Me.lstboxHighScores.ItemHeight = 16
        Me.lstboxHighScores.Location = New System.Drawing.Point(12, 12)
        Me.lstboxHighScores.Name = "lstboxHighScores"
        Me.lstboxHighScores.Size = New System.Drawing.Size(317, 180)
        Me.lstboxHighScores.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(107, 198)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(124, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset high score"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'HighScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 234)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lstboxHighScores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HighScoreForm"
        Me.Text = "High Score"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstboxHighScores As System.Windows.Forms.ListBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
