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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTelcorMenu))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.CallsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1568, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFileDataToolStripMenuItem, Me.SaveFileDataToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadFileDataToolStripMenuItem
        '
        Me.LoadFileDataToolStripMenuItem.Name = "LoadFileDataToolStripMenuItem"
        Me.LoadFileDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadFileDataToolStripMenuItem.Size = New System.Drawing.Size(345, 38)
        Me.LoadFileDataToolStripMenuItem.Text = "&Load File Data"
        '
        'SaveFileDataToolStripMenuItem
        '
        Me.SaveFileDataToolStripMenuItem.Name = "SaveFileDataToolStripMenuItem"
        Me.SaveFileDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveFileDataToolStripMenuItem.Size = New System.Drawing.Size(345, 38)
        Me.SaveFileDataToolStripMenuItem.Text = "&Save File Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(345, 38)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomersToolStripMenuItem, Me.DisplayCustomersAndSortToolStripMenuItem, Me.ViewCustomersCallsToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(140, 36)
        Me.CustomersToolStripMenuItem.Text = "&Customers"
        '
        'AddCustomersToolStripMenuItem
        '
        Me.AddCustomersToolStripMenuItem.Name = "AddCustomersToolStripMenuItem"
        Me.AddCustomersToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddCustomersToolStripMenuItem.Size = New System.Drawing.Size(493, 38)
        Me.AddCustomersToolStripMenuItem.Text = "&Add Customers"
        '
        'DisplayCustomersAndSortToolStripMenuItem
        '
        Me.DisplayCustomersAndSortToolStripMenuItem.Name = "DisplayCustomersAndSortToolStripMenuItem"
        Me.DisplayCustomersAndSortToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DisplayCustomersAndSortToolStripMenuItem.Size = New System.Drawing.Size(493, 38)
        Me.DisplayCustomersAndSortToolStripMenuItem.Text = "&Display Customers and Sort"
        '
        'ViewCustomersCallsToolStripMenuItem
        '
        Me.ViewCustomersCallsToolStripMenuItem.Name = "ViewCustomersCallsToolStripMenuItem"
        Me.ViewCustomersCallsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewCustomersCallsToolStripMenuItem.Size = New System.Drawing.Size(493, 38)
        Me.ViewCustomersCallsToolStripMenuItem.Text = "&View Customers' Calls"
        '
        'CallsToolStripMenuItem
        '
        Me.CallsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterCallsToolStripMenuItem, Me.CalculateCallCostToolStripMenuItem})
        Me.CallsToolStripMenuItem.Name = "CallsToolStripMenuItem"
        Me.CallsToolStripMenuItem.Size = New System.Drawing.Size(76, 36)
        Me.CallsToolStripMenuItem.Text = "C&alls"
        '
        'EnterCallsToolStripMenuItem
        '
        Me.EnterCallsToolStripMenuItem.Name = "EnterCallsToolStripMenuItem"
        Me.EnterCallsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.EnterCallsToolStripMenuItem.Size = New System.Drawing.Size(395, 38)
        Me.EnterCallsToolStripMenuItem.Text = "E&nter Calls"
        '
        'CalculateCallCostToolStripMenuItem
        '
        Me.CalculateCallCostToolStripMenuItem.Name = "CalculateCallCostToolStripMenuItem"
        Me.CalculateCallCostToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CalculateCallCostToolStripMenuItem.Size = New System.Drawing.Size(395, 38)
        Me.CalculateCallCostToolStripMenuItem.Text = "Calc&ulate Call Cost"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(264, 38)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1057)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1568, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Telcor.My.Resources.Resources.phone_call
        Me.PictureBox1.InitialImage = Global.Telcor.My.Resources.Resources.phone_call
        Me.PictureBox1.Location = New System.Drawing.Point(1244, 52)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 288)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormTelcorMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1568, 1079)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormTelcorMenu"
        Me.Text = "Telcor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
