<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewCustomersCalls
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
        Me.CmbSelectOption = New System.Windows.Forms.ComboBox()
        Me.RbName = New System.Windows.Forms.RadioButton()
        Me.RbNumber = New System.Windows.Forms.RadioButton()
        Me.TxtSearchBox = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'CmbSelectOption
        '
        Me.CmbSelectOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSelectOption.FormattingEnabled = True
        Me.CmbSelectOption.Items.AddRange(New Object() {"List All", "List All with Calls", "List All with Call details", "List All without Calls", "Search"})
        Me.CmbSelectOption.Location = New System.Drawing.Point(12, 35)
        Me.CmbSelectOption.Name = "CmbSelectOption"
        Me.CmbSelectOption.Size = New System.Drawing.Size(333, 33)
        Me.CmbSelectOption.TabIndex = 0
        '
        'RbName
        '
        Me.RbName.AutoSize = True
        Me.RbName.Enabled = False
        Me.RbName.Location = New System.Drawing.Point(377, 18)
        Me.RbName.Name = "RbName"
        Me.RbName.Size = New System.Drawing.Size(99, 29)
        Me.RbName.TabIndex = 1
        Me.RbName.TabStop = True
        Me.RbName.Text = "Name"
        Me.RbName.UseVisualStyleBackColor = True
        '
        'RbNumber
        '
        Me.RbNumber.AutoSize = True
        Me.RbNumber.Enabled = False
        Me.RbNumber.Location = New System.Drawing.Point(377, 53)
        Me.RbNumber.Name = "RbNumber"
        Me.RbNumber.Size = New System.Drawing.Size(118, 29)
        Me.RbNumber.TabIndex = 2
        Me.RbNumber.TabStop = True
        Me.RbNumber.Text = "Number"
        Me.RbNumber.UseVisualStyleBackColor = True
        '
        'TxtSearchBox
        '
        Me.TxtSearchBox.Enabled = False
        Me.TxtSearchBox.Location = New System.Drawing.Point(529, 35)
        Me.TxtSearchBox.Name = "TxtSearchBox"
        Me.TxtSearchBox.Size = New System.Drawing.Size(318, 31)
        Me.TxtSearchBox.TabIndex = 3
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(699, 542)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(147, 43)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(28, 114)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(817, 402)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'FormViewCustomersCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 597)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtSearchBox)
        Me.Controls.Add(Me.RbNumber)
        Me.Controls.Add(Me.RbName)
        Me.Controls.Add(Me.CmbSelectOption)
        Me.Name = "FormViewCustomersCalls"
        Me.Text = "View Customer Calls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSelectOption As ComboBox
    Friend WithEvents RbName As RadioButton
    Friend WithEvents RbNumber As RadioButton
    Friend WithEvents TxtSearchBox As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
