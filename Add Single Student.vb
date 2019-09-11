Imports System.IO

Public Class Add_Single_Student
    Private sql As New SQL


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        sql.AddParam("@1", Sid.Text)
        sql.AddParam("@2", Sname.Text)
        sql.AddParam("@3", Sdept.Text)
        sql.AddParam("@4", Syear.Text)
        sql.AddParam("@5", SRN.Text)

        'sql.ExecQuery("Select * from Student_Details where StudentId = '" & Sid.Text & "' ")
        sql.ExecQuery("Select * from Student_Details where StudentId = @1 ")
        If sql.RecordCount > 0 Then
            MsgBox("StudentId already registered. Please enter new StudentId")
            Sid.Clear()
            Exit Sub

        End If

        sql.AddParam("@1", Sid.Text)
        sql.AddParam("@2", Sname.Text)
        sql.AddParam("@3", Sdept.Text)
        sql.AddParam("@4", Syear.Text)
        sql.AddParam("@5", SRN.Text)
        sql.ExecQuery("Insert into Student_Details(STUDENTId,Name,Department,Year,RoomNumber) values(@1,@2,@3,@4,@5);")
        'If sql.HasExeption(True) Then Exit Sub
        uploadimage(txtImagePath.Text)


        MsgBox("Added successfully")



    End Sub

    

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        ofdBrowse.Filter = "All Files|*.*|Image Files|*.jpg;*.gif;*.png;*.bmp"
        ofdBrowse.ShowDialog()
    End Sub

    Private Sub ofdBrowse_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdBrowse.FileOk
        Try
            ' MsgBox("2")
            pbPreview.Image = Image.FromFile(ofdBrowse.FileName)
            txtImagePath.Text = ofdBrowse.FileName

        Catch ex As Exception

        End Try


    End Sub
    Private Sub uploadimage(path As String)
        'MsgBox("1")
        If String.IsNullOrEmpty(path) Then Exit Sub
        Dim img As Image = Image.FromFile(path)
        Dim ms As New MemoryStream
        img.Save(ms, img.RawFormat)
        Dim buffer As Byte() = ms.GetBuffer()

        sql.AddParam("@id", Sid.Text)
        sql.AddParam("@image", buffer)
        sql.ExecQuery("Insert into Student_Images(StudentId,Images) values(@id,@image)")
        'MsgBox("2")
        If sql.HasExeption(True) Then Exit Sub





    End Sub


    Private Sub pbPreview_Click(sender As Object, e As EventArgs) Handles pbPreview.Click

    End Sub
End Class