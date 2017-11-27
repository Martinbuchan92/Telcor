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
        Dim BtnClose As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddCustomer))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        BtnClose.Location = New System.Drawing.Point(414, 450)
        BtnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(150, 48)
        BtnClose.TabIndex = 4
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = True
        AddHandler BtnClose.Click, AddressOf Me.btnClose_Click
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(30, 52)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(368, 31)
        Me.txtName.TabIndex = 0
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(30, 171)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(368, 31)
        Me.txtPhoneNumber.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(24, 17)
        Me.lblName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(24, 137)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(6, 0, 6, 4)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(155, 25)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(90, 450)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(150, 48)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(252, 450)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(150, 48)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FormAddCustomer
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = BtnClose
        Me.ClientSize = New System.Drawing.Size(588, 521)
        Me.Controls.Add(BtnClose)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
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
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
End Class
