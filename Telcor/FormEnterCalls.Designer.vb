﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnterCalls
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
        Me.CmbCustomer = New System.Windows.Forms.ComboBox()
        Me.CmbCallType = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NupDuration = New System.Windows.Forms.NumericUpDown()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.LblCallType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNumberCalled = New System.Windows.Forms.Label()
        CType(Me.NupDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbCustomer
        '
        Me.CmbCustomer.FormattingEnabled = True
        Me.CmbCustomer.Location = New System.Drawing.Point(11, 24)
        Me.CmbCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCustomer.Name = "CmbCustomer"
        Me.CmbCustomer.Size = New System.Drawing.Size(168, 21)
        Me.CmbCustomer.TabIndex = 0
        '
        'CmbCallType
        '
        Me.CmbCallType.FormattingEnabled = True
        Me.CmbCallType.Location = New System.Drawing.Point(11, 62)
        Me.CmbCallType.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCallType.Name = "CmbCallType"
        Me.CmbCallType.Size = New System.Drawing.Size(168, 21)
        Me.CmbCallType.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 137)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 20)
        Me.TextBox2.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(12, 172)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(47, 21)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(72, 171)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(74, 22)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(161, 172)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(64, 21)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'NupDuration
        '
        Me.NupDuration.Location = New System.Drawing.Point(11, 100)
        Me.NupDuration.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDuration.Name = "NupDuration"
        Me.NupDuration.Size = New System.Drawing.Size(90, 20)
        Me.NupDuration.TabIndex = 7
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(11, 9)
        Me.lblCustomer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 8
        Me.lblCustomer.Text = "Customer"
        '
        'LblCallType
        '
        Me.LblCallType.AutoSize = True
        Me.LblCallType.Location = New System.Drawing.Point(11, 47)
        Me.LblCallType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCallType.Name = "LblCallType"
        Me.LblCallType.Size = New System.Drawing.Size(51, 13)
        Me.LblCallType.TabIndex = 9
        Me.LblCallType.Text = "Call Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Duration (Seconds)"
        '
        'LblNumberCalled
        '
        Me.LblNumberCalled.AutoSize = True
        Me.LblNumberCalled.Location = New System.Drawing.Point(11, 122)
        Me.LblNumberCalled.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNumberCalled.Name = "LblNumberCalled"
        Me.LblNumberCalled.Size = New System.Drawing.Size(76, 13)
        Me.LblNumberCalled.TabIndex = 11
        Me.LblNumberCalled.Text = "Number Called"
        '
        'FormEnterCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 207)
        Me.Controls.Add(Me.LblNumberCalled)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblCallType)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.NupDuration)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CmbCallType)
        Me.Controls.Add(Me.CmbCustomer)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormEnterCalls"
        Me.Text = "Enter Calls"
        CType(Me.NupDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbCustomer As ComboBox
    Friend WithEvents CmbCallType As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents NupDuration As NumericUpDown
    Friend WithEvents lblCustomer As Label
    Friend WithEvents LblCallType As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNumberCalled As Label
End Class
