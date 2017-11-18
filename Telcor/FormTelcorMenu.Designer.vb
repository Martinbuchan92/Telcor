<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTelcorMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadFileDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCustomersAndSortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersCallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterCallsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateCallCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.CallsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFileDataToolStripMenuItem, Me.SaveFileDataToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadFileDataToolStripMenuItem
        '
        Me.LoadFileDataToolStripMenuItem.Name = "LoadFileDataToolStripMenuItem"
        Me.LoadFileDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadFileDataToolStripMenuItem.Text = "Load File Data"
        '
        'SaveFileDataToolStripMenuItem
        '
        Me.SaveFileDataToolStripMenuItem.Name = "SaveFileDataToolStripMenuItem"
        Me.SaveFileDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveFileDataToolStripMenuItem.Text = "Save File Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomersToolStripMenuItem, Me.DisplayCustomersAndSortToolStripMenuItem, Me.ViewCustomersCallsToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'AddCustomersToolStripMenuItem
        '
        Me.AddCustomersToolStripMenuItem.Name = "AddCustomersToolStripMenuItem"
        Me.AddCustomersToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AddCustomersToolStripMenuItem.Text = "Add Customers"
        '
        'DisplayCustomersAndSortToolStripMenuItem
        '
        Me.DisplayCustomersAndSortToolStripMenuItem.Name = "DisplayCustomersAndSortToolStripMenuItem"
        Me.DisplayCustomersAndSortToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.DisplayCustomersAndSortToolStripMenuItem.Text = "Display Customers and Sort"
        '
        'ViewCustomersCallsToolStripMenuItem
        '
        Me.ViewCustomersCallsToolStripMenuItem.Name = "ViewCustomersCallsToolStripMenuItem"
        Me.ViewCustomersCallsToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ViewCustomersCallsToolStripMenuItem.Text = "View Customers' Calls"
        '
        'CallsToolStripMenuItem
        '
        Me.CallsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterCallsToolStripMenuItem, Me.CalculateCallCostToolStripMenuItem})
        Me.CallsToolStripMenuItem.Name = "CallsToolStripMenuItem"
        Me.CallsToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.CallsToolStripMenuItem.Text = "Calls"
        '
        'EnterCallsToolStripMenuItem
        '
        Me.EnterCallsToolStripMenuItem.Name = "EnterCallsToolStripMenuItem"
        Me.EnterCallsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EnterCallsToolStripMenuItem.Text = "Enter Calls"
        '
        'CalculateCallCostToolStripMenuItem
        '
        Me.CalculateCallCostToolStripMenuItem.Name = "CalculateCallCostToolStripMenuItem"
        Me.CalculateCallCostToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CalculateCallCostToolStripMenuItem.Text = "Calculate Call Cost"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'FormTelcorMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormTelcorMenu"
        Me.Text = "Telcor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadFileDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CallsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayCustomersAndSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomersCallsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterCallsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateCallCostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
