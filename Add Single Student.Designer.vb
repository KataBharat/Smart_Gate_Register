<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Single_Student
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
        Me.Sid = New System.Windows.Forms.TextBox()
        Me.Sname = New System.Windows.Forms.TextBox()
        Me.Sdept = New System.Windows.Forms.TextBox()
        Me.Syear = New System.Windows.Forms.TextBox()
        Me.SRN = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "StudentId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Room Number"
        '
        'Sid
        '
        Me.Sid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sid.Location = New System.Drawing.Point(300, 116)
        Me.Sid.Name = "Sid"
        Me.Sid.Size = New System.Drawing.Size(158, 30)
        Me.Sid.TabIndex = 5
        '
        'Sname
        '
        Me.Sname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sname.Location = New System.Drawing.Point(300, 183)
        Me.Sname.Name = "Sname"
        Me.Sname.Size = New System.Drawing.Size(158, 30)
        Me.Sname.TabIndex = 6
        '
        'Sdept
        '
        Me.Sdept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sdept.Location = New System.Drawing.Point(300, 247)
        Me.Sdept.Name = "Sdept"
        Me.Sdept.Size = New System.Drawing.Size(158, 30)
        Me.Sdept.TabIndex = 7
        '
        'Syear
        '
        Me.Syear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Syear.Location = New System.Drawing.Point(300, 314)
        Me.Syear.Name = "Syear"
        Me.Syear.Size = New System.Drawing.Size(158, 30)
        Me.Syear.TabIndex = 8
        '
        'SRN
        '
        Me.SRN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRN.Location = New System.Drawing.Point(300, 376)
        Me.SRN.Name = "SRN"
        Me.SRN.Size = New System.Drawing.Size(158, 30)
        Me.SRN.TabIndex = 9
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(486, 463)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(104, 42)
        Me.Save.TabIndex = 10
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'pbPreview
        '
        Me.pbPreview.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbPreview.Location = New System.Drawing.Point(831, 112)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(180, 154)
        Me.pbPreview.TabIndex = 11
        Me.pbPreview.TabStop = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Location = New System.Drawing.Point(862, 306)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(112, 38)
        Me.cmdBrowse.TabIndex = 12
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ofdBrowse
        '
        Me.ofdBrowse.FileName = "*.PNG"
        Me.ofdBrowse.Filter = """ (*.jpg)|*.jpg|All files (*.*)|*.*"""
        Me.ofdBrowse.InitialDirectory = "D:\"
        '
        'txtImagePath
        '
        Me.txtImagePath.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Location = New System.Drawing.Point(756, 376)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Size = New System.Drawing.Size(308, 30)
        Me.txtImagePath.TabIndex = 13
        '
        'Add_Single_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 517)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.pbPreview)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.SRN)
        Me.Controls.Add(Me.Syear)
        Me.Controls.Add(Me.Sdept)
        Me.Controls.Add(Me.Sname)
        Me.Controls.Add(Me.Sid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Single_Student"
        Me.Text = "Add_Single_Student"
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sid As System.Windows.Forms.TextBox
    Friend WithEvents Sname As System.Windows.Forms.TextBox
    Friend WithEvents Sdept As System.Windows.Forms.TextBox
    Friend WithEvents Syear As System.Windows.Forms.TextBox
    Friend WithEvents SRN As System.Windows.Forms.TextBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents pbPreview As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtImagePath As System.Windows.Forms.TextBox
End Class
