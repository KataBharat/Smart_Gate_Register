<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Students
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.txtRN = New System.Windows.Forms.TextBox()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.cmdsearch = New System.Windows.Forms.Button()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Room Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Student Id"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(258, 59)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(199, 30)
        Me.txtid.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(258, 113)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(199, 30)
        Me.txtname.TabIndex = 6
        '
        'txtdept
        '
        Me.txtdept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdept.Location = New System.Drawing.Point(258, 163)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(199, 30)
        Me.txtdept.TabIndex = 7
        '
        'txtyear
        '
        Me.txtyear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(258, 218)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(199, 30)
        Me.txtyear.TabIndex = 8
        '
        'txtRN
        '
        Me.txtRN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRN.Location = New System.Drawing.Point(258, 279)
        Me.txtRN.Name = "txtRN"
        Me.txtRN.Size = New System.Drawing.Size(199, 30)
        Me.txtRN.TabIndex = 9
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(423, 631)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(94, 38)
        Me.cmddelete.TabIndex = 10
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'dgvdata
        '
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Location = New System.Drawing.Point(54, 406)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(876, 199)
        Me.dgvdata.TabIndex = 11
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(423, 347)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(94, 38)
        Me.cmdsearch.TabIndex = 12
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'Delete_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 703)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.txtRN)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtdept)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Delete_Students"
        Me.Text = "Delete_Students"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtRN As System.Windows.Forms.TextBox
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
End Class
