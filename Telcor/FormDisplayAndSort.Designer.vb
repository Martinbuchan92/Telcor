﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnSortName = New System.Windows.Forms.Button()
        Me.BtnSortNumber = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbxResultSet = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnSortName
        '
        Me.BtnSortName.Location = New System.Drawing.Point(18, 541)
        Me.BtnSortName.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnSortName.Name = "BtnSortName"
        Me.BtnSortName.Size = New System.Drawing.Size(150, 44)
        Me.BtnSortName.TabIndex = 1
        Me.BtnSortName.Text = "Name"
        Me.BtnSortName.UseVisualStyleBackColor = True
        '
        'BtnSortNumber
        '
        Me.BtnSortNumber.Location = New System.Drawing.Point(180, 541)
        Me.BtnSortNumber.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnSortNumber.Name = "BtnSortNumber"
        Me.BtnSortNumber.Size = New System.Drawing.Size(150, 44)
        Me.BtnSortNumber.TabIndex = 2
        Me.BtnSortNumber.Text = "Number"
        Me.BtnSortNumber.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(784, 541)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(150, 44)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 510)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sort by:"
        '
        'LbxResultSet
        '
        Me.LbxResultSet.FormattingEnabled = True
        Me.LbxResultSet.ItemHeight = 25
        Me.LbxResultSet.Location = New System.Drawing.Point(54, 56)
        Me.LbxResultSet.Name = "LbxResultSet"
        Me.LbxResultSet.Size = New System.Drawing.Size(826, 429)
        Me.LbxResultSet.TabIndex = 5
        '
        'FormDisplayAndSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 612)
        Me.Controls.Add(Me.LbxResultSet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSortNumber)
        Me.Controls.Add(Me.BtnSortName)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormDisplayAndSort"
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
