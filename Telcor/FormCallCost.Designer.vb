<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCallCost
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
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCallType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RtbResponse = New System.Windows.Forms.RichTextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtDuration
        '
        Me.TxtDuration.Location = New System.Drawing.Point(150, 25)
        Me.TxtDuration.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(133, 20)
        Me.TxtDuration.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Duration (seconds)"
        '
        'CmbCallType
        '
        Me.CmbCallType.FormattingEnabled = True
        Me.CmbCallType.Location = New System.Drawing.Point(11, 24)
        Me.CmbCallType.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCallType.Name = "CmbCallType"
        Me.CmbCallType.Size = New System.Drawing.Size(114, 21)
        Me.CmbCallType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Call Type"
        '
        'RtbResponse
        '
        Me.RtbResponse.Location = New System.Drawing.Point(11, 49)
        Me.RtbResponse.Margin = New System.Windows.Forms.Padding(2)
        Me.RtbResponse.Name = "RtbResponse"
        Me.RtbResponse.Size = New System.Drawing.Size(272, 171)
        Me.RtbResponse.TabIndex = 4
        Me.RtbResponse.Text = ""
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(208, 235)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 25)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(47, 235)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 25)
        Me.BtnCalculate.TabIndex = 6
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(128, 235)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 25)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FormCallCost
        '
        Me.AcceptButton = Me.BtnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(294, 271)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.RtbResponse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCallType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDuration)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCallCost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Call Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDuration As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbCallType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RtbResponse As RichTextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnClear As Button
End Class
