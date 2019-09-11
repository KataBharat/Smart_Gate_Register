Public Class Delete_Students
    Private sql As New SQL


    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Deletegrid()
        'MsgBox("Delete successfully")


    End Sub

    Private Sub cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        If (txtid.Text.Length > 0) Then 'And (txtdept.Text.Length = 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length = 0) Then
            txtdept.Enabled = False
            txtyear.Enabled = False
            txtRN.Enabled = False
            txtname.Enabled = False
            sql.AddParam("@id", txtid.Text)
            sql.ExecQuery("select * from Student_details where StudentId=@id ")
            If sql.HasExeption(True) Then Exit Sub
            dgvdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
                txtdept.Enabled = True
                txtyear.Enabled = True
                txtRN.Enabled = True
                txtname.Enabled = True
                txtid.Clear()

            End If
        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length > 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length = 0) Then
            sql.AddParam("@dept", txtdept.Text)
            sql.ExecQuery("select * from Student_details where Department=@dept ")
            If sql.HasExeption(True) Then Exit Sub
            dgvdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
                txtdept.Clear()

            End If
        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length > 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length = 0) Then
            txtdept.Enabled = False
            txtyear.Enabled = False
            txtid.Enabled = False
            txtname.Enabled = False
            sql.AddParam("@RN", txtRN.Text)
            sql.ExecQuery("select * from Student_details where RoomNumber=@RN ")
            If sql.HasExeption(True) Then Exit Sub
            dgvdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
                txtdept.Enabled = True
                txtyear.Enabled = True
                txtid.Enabled = True
                txtname.Enabled = True
                txtRN.Clear()

            End If
        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length > 0) And (txtname.Text.Length = 0) Then
            sql.AddParam("@year", txtyear.Text)
            sql.ExecQuery("select * from Student_details where Year=@year ")
            If sql.HasExeption(True) Then Exit Sub
            dgvdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
                txtyear.Clear()

            End If
        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length > 0) Then
            txtdept.Enabled = False
            txtyear.Enabled = False
            txtRN.Enabled = False
            txtid.Enabled = False
            sql.AddParam("@name", txtname.Text)
            sql.ExecQuery("select * from Student_details where Name=@name ")
            If sql.HasExeption(True) Then Exit Sub
            dgvdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
                txtdept.Enabled = True
                txtyear.Enabled = True
                txtRN.Enabled = True
                txtid.Enabled = True
                txtname.Clear()

            End If
        End If

        If (txtdept.Text.Length > 0) And (txtyear.Text.Length) Then
            txtname.Enabled = False
            txtid.Enabled = False
            txtRN.Enabled = False
            sql.AddParam("@dept", txtdept.Text)
            sql.AddParam("@year", txtyear.Text)
            sql.ExecQuery("Select * from Student_Details where Department=@dept and Year=@year;")
            If sql.HasExeption(True) Then Exit Sub
            dgvdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
                txtname.Enabled = True
                txtid.Enabled = True
                txtRN.Enabled = True
                txtdept.Clear()
                txtyear.Clear()

            End If

        End If


    End Sub

    Private Sub Deletegrid()
        
        If (txtid.Text.Length > 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length = 0) Then

            sql.AddParam("@id", txtid.Text)
            sql.ExecQuery("Delete from Student_details where StudentId=@id ")
            If sql.HasExeption(True) Then Exit Sub
            MsgBox("Deleted successfully")

        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length > 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length = 0) Then
            sql.AddParam("@dept", txtdept.Text)
            sql.ExecQuery("delete from Student_details where Department=@dept ")
            'If sql.HasExeption(True) Then Exit Sub
            If sql.HasExeption(True) Then Exit Sub
            MsgBox("Deleted successfully")
            
        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length > 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length = 0) Then
            
            sql.AddParam("@RN", txtRN.Text)
            sql.ExecQuery("delete from Student_details where RoomNumber=@RN ")
            'If sql.HasExeption(True) Then Exit Sub
            If sql.HasExeption(True) Then Exit Sub
            MsgBox("Deleted successfully")

        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length > 0) And (txtname.Text.Length = 0) Then
            sql.AddParam("@year", txtyear.Text)
            sql.ExecQuery("delete from Student_details where Year=@year ")
            If sql.HasExeption(True) Then Exit Sub
            MsgBox("Deleted successfully")
        End If

        If (txtid.Text.Length = 0) And (txtdept.Text.Length = 0) And (txtRN.Text.Length = 0) And (txtyear.Text.Length = 0) And (txtname.Text.Length > 0) Then
            
            sql.AddParam("@name", txtname.Text)
            sql.ExecQuery("delete from Student_details where Name=@name ")
            If sql.HasExeption(True) Then Exit Sub
            'If sql.HasExeption(True) Then Exit Sub
            MsgBox("Deleted successfully")
        End If

        If (txtdept.Text.Length > 0) And (txtyear.Text.Length) Then
            
            sql.AddParam("@dept", txtdept.Text)
            sql.AddParam("@year", txtyear.Text)
            sql.ExecQuery("delete from Student_Details where Department=@dept and Year=@year ")
            If sql.HasExeption(True) Then Exit Sub
            'If sql.HasExeption(True) Then Exit Sub
            MsgBox("Deleted successfully")
        End If


    End Sub
End Class