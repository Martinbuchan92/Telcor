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
        Me.btnSortName = New System.Windows.Forms.Button()
        Me.btnSortNumber = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSortName
        '
        Me.btnSortName.Location = New System.Drawing.Point(24, 629)
        Me.btnSortName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSortName.Name = "btnSortName"
        Me.btnSortName.Size = New System.Drawing.Size(150, 44)
        Me.btnSortName.TabIndex = 1
        Me.btnSortName.Text = "Name"
        Me.btnSortName.UseVisualStyleBackColor = True
        '
        'btnSortNumber
        '
        Me.btnSortNumber.Location = New System.Drawing.Point(186, 629)
        Me.btnSortNumber.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSortNumber.Name = "btnSortNumber"
        Me.btnSortNumber.Size = New System.Drawing.Size(150, 44)
        Me.btnSortNumber.TabIndex = 2
        Me.btnSortNumber.Text = "Number"
        Me.btnSortNumber.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(790, 629)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 598)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sort by:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(54, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(826, 429)
        Me.ListBox1.TabIndex = 5
        '
        'FormDisplayAndSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 696)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSortNumber)
        Me.Controls.Add(Me.btnSortName)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FormDisplayAndSort"
        Me.Text = "Display Customers and Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSortName As Button
    Friend WithEvents btnSortNumber As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
