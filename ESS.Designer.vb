<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESS
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.TbDept = New System.Windows.Forms.TextBox()
        Me.TbYear = New System.Windows.Forms.TextBox()
        Me.TbRn = New System.Windows.Forms.TextBox()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Room Number"
        '
        'TbId
        '
        Me.TbId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbId.Location = New System.Drawing.Point(227, 68)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(200, 30)
        Me.TbId.TabIndex = 5
        '
        'TbName
        '
        Me.TbName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbName.Location = New System.Drawing.Point(227, 135)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(200, 30)
        Me.TbName.TabIndex = 6
        '
        'TbDept
        '
        Me.TbDept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDept.Location = New System.Drawing.Point(227, 190)
        Me.TbDept.Name = "TbDept"
        Me.TbDept.Size = New System.Drawing.Size(200, 30)
        Me.TbDept.TabIndex = 7
        '
        'TbYear
        '
        Me.TbYear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbYear.Location = New System.Drawing.Point(227, 257)
        Me.TbYear.Name = "TbYear"
        Me.TbYear.Size = New System.Drawing.Size(200, 30)
        Me.TbYear.TabIndex = 8
        '
        'TbRn
        '
        Me.TbRn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbRn.Location = New System.Drawing.Point(227, 318)
        Me.TbRn.Name = "TbRn"
        Me.TbRn.Size = New System.Drawing.Size(200, 30)
        Me.TbRn.TabIndex = 9
        '
        'CmdSave
        '
        Me.CmdSave.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.Location = New System.Drawing.Point(401, 410)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(116, 37)
        Me.CmdSave.TabIndex = 10
        Me.CmdSave.Text = "Update"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(609, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Location = New System.Drawing.Point(802, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 177)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(875, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ofdBrowse
        '
        Me.ofdBrowse.FileName = "*.PNG"
        Me.ofdBrowse.Filter = """ (*.jpg)|*.jpg|All files (*.*)|*.*"""
        Me.ofdBrowse.InitialDirectory = "D:\"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(792, 281)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 22)
        Me.TextBox1.TabIndex = 14
        '
        'ESS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 480)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.TbRn)
        Me.Controls.Add(Me.TbYear)
        Me.Controls.Add(Me.TbDept)
        Me.Controls.Add(Me.TbName)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ESS"
        Me.Text = "ESS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbId As System.Windows.Forms.TextBox
    Friend WithEvents TbName As System.Windows.Forms.TextBox
    Friend WithEvents TbDept As System.Windows.Forms.TextBox
    Friend WithEvents TbYear As System.Windows.Forms.TextBox
    Friend WithEvents TbRn As System.Windows.Forms.TextBox
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
