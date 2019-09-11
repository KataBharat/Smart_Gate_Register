<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Multiple_Students
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBdept = New System.Windows.Forms.TextBox()
        Me.CmdSearch = New System.Windows.Forms.Button()
        Me.DGVdata = New System.Windows.Forms.DataGridView()
        Me.CmdUpdate = New System.Windows.Forms.Button()
        Me.TBYear = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year"
        '
        'TBdept
        '
        Me.TBdept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBdept.Location = New System.Drawing.Point(267, 82)
        Me.TBdept.Name = "TBdept"
        Me.TBdept.Size = New System.Drawing.Size(149, 30)
        Me.TBdept.TabIndex = 4
        '
        'CmdSearch
        '
        Me.CmdSearch.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Location = New System.Drawing.Point(552, 214)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(101, 36)
        Me.CmdSearch.TabIndex = 5
        Me.CmdSearch.Text = "Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'DGVdata
        '
        Me.DGVdata.AllowUserToAddRows = False
        Me.DGVdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdata.Location = New System.Drawing.Point(31, 293)
        Me.DGVdata.Name = "DGVdata"
        Me.DGVdata.RowTemplate.Height = 24
        Me.DGVdata.Size = New System.Drawing.Size(1196, 309)
        Me.DGVdata.TabIndex = 6
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdUpdate.Location = New System.Drawing.Point(413, 630)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(106, 35)
        Me.CmdUpdate.TabIndex = 7
        Me.CmdUpdate.Text = "Update"
        Me.CmdUpdate.UseVisualStyleBackColor = True
        '
        'TBYear
        '
        Me.TBYear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBYear.Location = New System.Drawing.Point(267, 145)
        Me.TBYear.Name = "TBYear"
        Me.TBYear.Size = New System.Drawing.Size(149, 30)
        Me.TBYear.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(727, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Edit_Multiple_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 699)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBYear)
        Me.Controls.Add(Me.CmdUpdate)
        Me.Controls.Add(Me.DGVdata)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.TBdept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Multiple_Students"
        Me.Text = "Edit_Multiple_Students"
        CType(Me.DGVdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBdept As System.Windows.Forms.TextBox
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents DGVdata As System.Windows.Forms.DataGridView
    Friend WithEvents CmdUpdate As System.Windows.Forms.Button
    Friend WithEvents TBYear As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
