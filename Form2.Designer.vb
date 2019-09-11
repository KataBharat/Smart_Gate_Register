<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ESD = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASS = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMS = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(249, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESD, Me.LogFileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(675, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ESD
        '
        Me.ESD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDIT, Me.EMS, Me.ASS, Me.AMS, Me.DeleteStudentsToolStripMenuItem})
        Me.ESD.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESD.Name = "ESD"
        Me.ESD.Size = New System.Drawing.Size(132, 24)
        Me.ESD.Text = "Edit Student details"
        '
        'EDIT
        '
        Me.EDIT.Name = "EDIT"
        Me.EDIT.Size = New System.Drawing.Size(212, 26)
        Me.EDIT.Text = "Edit Single Student"
        '
        'EMS
        '
        Me.EMS.Name = "EMS"
        Me.EMS.Size = New System.Drawing.Size(212, 26)
        Me.EMS.Text = "Edit Multiple Students"
        '
        'ASS
        '
        Me.ASS.Name = "ASS"
        Me.ASS.Size = New System.Drawing.Size(212, 26)
        Me.ASS.Text = "Add Single Student"
        '
        'AMS
        '
        Me.AMS.Name = "AMS"
        Me.AMS.Size = New System.Drawing.Size(212, 26)
        Me.AMS.Text = "Add Multiple Students"
        '
        'DeleteStudentsToolStripMenuItem
        '
        Me.DeleteStudentsToolStripMenuItem.Name = "DeleteStudentsToolStripMenuItem"
        Me.DeleteStudentsToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.DeleteStudentsToolStripMenuItem.Text = "Delete Students"
        '
        'LogFileToolStripMenuItem
        '
        Me.LogFileToolStripMenuItem.Name = "LogFileToolStripMenuItem"
        Me.LogFileToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.LogFileToolStripMenuItem.Text = "LogFile"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(249, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(675, 418)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ESD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDIT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AMS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
