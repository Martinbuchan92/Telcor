<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddCustomer
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
        Dim btnClose As System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        btnClose.Location = New System.Drawing.Point(207, 234)
        btnClose.Name = "btnClose"
        btnClose.Size = New System.Drawing.Size(75, 25)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        AddHandler btnClose.Click, AddressOf Me.btnClose_Click
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 20)
        Me.txtName.TabIndex = 0
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(15, 87)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(186, 20)
        Me.txtPhoneNumber.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(12, 71)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(45, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(126, 234)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'FormAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 271)
        Me.Controls.Add(btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtName)
        Me.Name = "FormAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
