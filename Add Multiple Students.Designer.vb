<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Multiple_Students
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
        Me.CmdFile = New System.Windows.Forms.Button()
        Me.DGV1data = New System.Windows.Forms.DataGridView()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV1data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdFile
        '
        Me.CmdFile.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFile.Location = New System.Drawing.Point(435, 74)
        Me.CmdFile.Name = "CmdFile"
        Me.CmdFile.Size = New System.Drawing.Size(188, 46)
        Me.CmdFile.TabIndex = 0
        Me.CmdFile.Text = "Load Excel File "
        Me.CmdFile.UseVisualStyleBackColor = True
        '
        'DGV1data
        '
        Me.DGV1data.AllowUserToAddRows = False
        Me.DGV1data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1data.Location = New System.Drawing.Point(84, 150)
        Me.DGV1data.Name = "DGV1data"
        Me.DGV1data.RowTemplate.Height = 24
        Me.DGV1data.Size = New System.Drawing.Size(971, 240)
        Me.DGV1data.TabIndex = 4
        '
        'CmdAdd
        '
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.Location = New System.Drawing.Point(421, 416)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(92, 32)
        Me.CmdAdd.TabIndex = 5
        Me.CmdAdd.Text = "Save"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(590, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add_Multiple_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.DGV1data)
        Me.Controls.Add(Me.CmdFile)
        Me.Name = "Add_Multiple_Students"
        Me.Text = "Add_Multiple_Students"
        CType(Me.DGV1data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdFile As System.Windows.Forms.Button
    Friend WithEvents DGV1data As System.Windows.Forms.DataGridView
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
