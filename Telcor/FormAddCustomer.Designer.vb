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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        BtnClose.Location = New System.Drawing.Point(207, 234)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(75, 25)
        BtnClose.TabIndex = 4
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = True
        AddHandler BtnClose.Click, AddressOf Me.BtnClose_Click
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(12, 71)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(45, 234)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 25)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(126, 234)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 25)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(15, 89)
        Me.txtPhoneNumber.Mask = "9999 000 000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPhoneNumber.Size = New System.Drawing.Size(186, 20)
        Me.txtPhoneNumber.TabIndex = 1
        '
        'FormAddCustomer
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = BtnClose
        Me.ClientSize = New System.Drawing.Size(294, 271)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(BtnClose)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents txtPhoneNumber As MaskedTextBox
End Class
