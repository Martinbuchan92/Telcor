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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewCustomersCalls))
        Me.CmbSelectOption = New System.Windows.Forms.ComboBox()
        Me.RbName = New System.Windows.Forms.RadioButton()
        Me.RbNumber = New System.Windows.Forms.RadioButton()
        Me.TxtSearchBox = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.RtbResultsBox = New System.Windows.Forms.RichTextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbSelectOption
        '
        Me.CmbSelectOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSelectOption.FormattingEnabled = True
        Me.CmbSelectOption.Items.AddRange(New Object() {"List All", "List All With Call Details", "List All Not Contacted", "List All Contacted", "Search"})
        Me.CmbSelectOption.Location = New System.Drawing.Point(11, 11)
        Me.CmbSelectOption.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbSelectOption.Name = "CmbSelectOption"
        Me.CmbSelectOption.Size = New System.Drawing.Size(168, 21)
        Me.CmbSelectOption.TabIndex = 0
        '
        'RbName
        '
        Me.RbName.AutoSize = True
        Me.RbName.Checked = True
        Me.RbName.Enabled = False
        Me.RbName.Location = New System.Drawing.Point(197, 11)
        Me.RbName.Margin = New System.Windows.Forms.Padding(2)
        Me.RbName.Name = "RbName"
        Me.RbName.Size = New System.Drawing.Size(53, 17)
        Me.RbName.TabIndex = 1
        Me.RbName.TabStop = True
        Me.RbName.Text = "Name"
        Me.RbName.UseVisualStyleBackColor = True
        '
        'RbNumber
        '
        Me.RbNumber.AutoSize = True
        Me.RbNumber.Enabled = False
        Me.RbNumber.Location = New System.Drawing.Point(197, 28)
        Me.RbNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.RbNumber.Name = "RbNumber"
        Me.RbNumber.Size = New System.Drawing.Size(62, 17)
        Me.RbNumber.TabIndex = 2
        Me.RbNumber.Text = "Number"
        Me.RbNumber.UseVisualStyleBackColor = True
        '
        'TxtSearchBox
        '
        Me.TxtSearchBox.Enabled = False
        Me.TxtSearchBox.Location = New System.Drawing.Point(266, 12)
        Me.TxtSearchBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSearchBox.Name = "TxtSearchBox"
        Me.TxtSearchBox.Size = New System.Drawing.Size(110, 20)
        Me.TxtSearchBox.TabIndex = 3
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(362, 275)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 25)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'RtbResultsBox
        '
        Me.RtbResultsBox.Location = New System.Drawing.Point(11, 49)
        Me.RtbResultsBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RtbResultsBox.Name = "RtbResultsBox"
        Me.RtbResultsBox.ReadOnly = True
        Me.RtbResultsBox.Size = New System.Drawing.Size(422, 211)
        Me.RtbResultsBox.TabIndex = 6
        Me.RtbResultsBox.TabStop = False
        Me.RtbResultsBox.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(381, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(56, 20)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'FormViewCustomersCalls
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(444, 311)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.RtbResultsBox)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtSearchBox)
        Me.Controls.Add(Me.RbNumber)
        Me.Controls.Add(Me.RbName)
        Me.Controls.Add(Me.CmbSelectOption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FormViewCustomersCalls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Customer Calls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSelectOption As ComboBox
    Friend WithEvents RbName As RadioButton
    Friend WithEvents RbNumber As RadioButton
    Friend WithEvents TxtSearchBox As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents RtbResultsBox As RichTextBox
    Friend WithEvents BtnSearch As Button
End Class
