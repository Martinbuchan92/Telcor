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
        Me.dgvTest = New System.Windows.Forms.DataGridView()
        Me.btnSortName = New System.Windows.Forms.Button()
        Me.btnSortNumber = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTest
        '
        Me.dgvTest.AllowUserToAddRows = False
        Me.dgvTest.AllowUserToDeleteRows = False
        Me.dgvTest.AllowUserToOrderColumns = True
        Me.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTest.Location = New System.Drawing.Point(12, 12)
        Me.dgvTest.Name = "dgvTest"
        Me.dgvTest.ReadOnly = True
        Me.dgvTest.Size = New System.Drawing.Size(458, 288)
        Me.dgvTest.TabIndex = 0
        '
        'btnSortName
        '
        Me.btnSortName.Location = New System.Drawing.Point(12, 327)
        Me.btnSortName.Name = "btnSortName"
        Me.btnSortName.Size = New System.Drawing.Size(75, 23)
        Me.btnSortName.TabIndex = 1
        Me.btnSortName.Text = "Name"
        Me.btnSortName.UseVisualStyleBackColor = True
        '
        'btnSortNumber
        '
        Me.btnSortNumber.Location = New System.Drawing.Point(93, 327)
        Me.btnSortNumber.Name = "btnSortNumber"
        Me.btnSortNumber.Size = New System.Drawing.Size(75, 23)
        Me.btnSortNumber.TabIndex = 2
        Me.btnSortNumber.Text = "Number"
        Me.btnSortNumber.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(395, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sort by:"
        '
        'FormDisplayAndSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSortNumber)
        Me.Controls.Add(Me.btnSortName)
        Me.Controls.Add(Me.dgvTest)
        Me.Name = "FormDisplayAndSort"
        Me.Text = "Display Customers and Sort"
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTest As DataGridView
    Friend WithEvents btnSortName As Button
    Friend WithEvents btnSortNumber As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
End Class
