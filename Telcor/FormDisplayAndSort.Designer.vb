<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDisplayAndSort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDisplayAndSort))
        Me.BtnSortName = New System.Windows.Forms.Button()
        Me.BtnSortNumber = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbxResultSet = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnSortName
        '
        Me.BtnSortName.Location = New System.Drawing.Point(12, 274)
        Me.BtnSortName.Name = "BtnSortName"
        Me.BtnSortName.Size = New System.Drawing.Size(75, 25)
        Me.BtnSortName.TabIndex = 1
        Me.BtnSortName.Text = "Name"
        Me.BtnSortName.UseVisualStyleBackColor = True
        '
        'BtnSortNumber
        '
        Me.BtnSortNumber.Location = New System.Drawing.Point(93, 274)
        Me.BtnSortNumber.Name = "BtnSortNumber"
        Me.BtnSortNumber.Size = New System.Drawing.Size(75, 25)
        Me.BtnSortNumber.TabIndex = 2
        Me.BtnSortNumber.Text = "Number"
        Me.BtnSortNumber.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(357, 274)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 25)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 256)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sort by:"
        '
        'LbxResultSet
        '
        Me.LbxResultSet.FormattingEnabled = True
        Me.LbxResultSet.Location = New System.Drawing.Point(11, 11)
        Me.LbxResultSet.Margin = New System.Windows.Forms.Padding(2)
        Me.LbxResultSet.Name = "LbxResultSet"
        Me.LbxResultSet.Size = New System.Drawing.Size(421, 238)
        Me.LbxResultSet.TabIndex = 5
        '
        'FormDisplayAndSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(444, 311)
        Me.Controls.Add(Me.LbxResultSet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSortNumber)
        Me.Controls.Add(Me.BtnSortName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormDisplayAndSort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display Customers and Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSortName As Button
    Friend WithEvents BtnSortNumber As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbxResultSet As ListBox
End Class
