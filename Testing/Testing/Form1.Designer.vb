<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CmdStart = New System.Windows.Forms.Button()
        Me.CmdEnd = New System.Windows.Forms.Button()
        Me.LSTDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CmdStart
        '
        Me.CmdStart.Location = New System.Drawing.Point(73, 102)
        Me.CmdStart.Name = "CmdStart"
        Me.CmdStart.Size = New System.Drawing.Size(329, 104)
        Me.CmdStart.TabIndex = 0
        Me.CmdStart.Text = "Start"
        Me.CmdStart.UseVisualStyleBackColor = True
        '
        'CmdEnd
        '
        Me.CmdEnd.Location = New System.Drawing.Point(73, 309)
        Me.CmdEnd.Name = "CmdEnd"
        Me.CmdEnd.Size = New System.Drawing.Size(329, 102)
        Me.CmdEnd.TabIndex = 1
        Me.CmdEnd.Text = "Stop"
        Me.CmdEnd.UseVisualStyleBackColor = True
        '
        'LSTDisplay
        '
        Me.LSTDisplay.FormattingEnabled = True
        Me.LSTDisplay.ItemHeight = 15
        Me.LSTDisplay.Location = New System.Drawing.Point(455, 107)
        Me.LSTDisplay.Name = "LSTDisplay"
        Me.LSTDisplay.Size = New System.Drawing.Size(872, 499)
        Me.LSTDisplay.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1849, 1200)
        Me.Controls.Add(Me.LSTDisplay)
        Me.Controls.Add(Me.CmdEnd)
        Me.Controls.Add(Me.CmdStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdStart As Button
    Friend WithEvents CmdEnd As Button
    Friend WithEvents LSTDisplay As ListBox
End Class
