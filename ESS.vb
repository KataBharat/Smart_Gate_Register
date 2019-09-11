Imports System.IO

Public Class ESS
    Private sql As New SQL



    Private Sub TbId_KeyDown(sender As Object, e As KeyEventArgs) Handles TbId.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If TxtId.Text.Length.ToString < 7 Then
            'MsgBox("Enter valid Student Id")

            'End If
            ShowDetails()
            drawimage(PictureBox1)
        End If
    End Sub

    Private Sub TbId_TextChanged(sender As Object, e As EventArgs) Handles TbId.TextChanged
        If TbId.Text.Length.ToString = 7 Then
            ShowDetails()
            'MsgBox("hello")
            drawimage(PictureBox1)
            'MsgBox("hello 1")






            If sql.HasExeption = True Then
                MsgBox("Exception")
            End If
            'TbId.Clear()


        End If
    End Sub

    Private Sub ShowDetails()

        sql.AddParam("@id", TbId.Text)
        sql.ExecQuery("Select * from Student_Details where StudentId = @id")
        'TxtName.Text = sql.DBDT.Rows[0][0].ToString()
        If sql.RecordCount < 1 Then
            MsgBox("Please enter valid StudentId")
            TbId.Clear()
            Exit Sub


        End If

        For Each r As DataRow In sql.DBDT.Rows
            TbName.Text = r("Name")
            TbDept.Text = r("Department")
            TbYear.Text = r("Year")
            TbRn.Text = r("RoomNumber")
        Next





        TbId.ReadOnly = True

    End Sub


    Private Sub Update_Student_Details()
        sql.AddParam("@id", TbId.Text)
        sql.AddParam("@name", TbName.Text)
        sql.AddParam("@dept", TbDept.Text)
        sql.AddParam("@year", TbYear.Text)
        sql.AddParam("@RN", TbRn.Text)

        sql.ExecQuery("UPDATE Student_Details SET Name=@name, Department=@dept, Year=@year, RoomNumber=@RN WHERE StudentId=@id;")
        uploadimage(TextBox1.Text)


    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        Update_Student_Details()
        MsgBox("Updated Successfully")
        TbId.Clear()
        TbId.ReadOnly = False
        TbName.Clear()
        TbDept.Clear()
        TbYear.Clear()
        TbRn.Clear()







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Function Fetchimage(id As String) As Byte()
        'MsgBox("fecthinmae")

        sql.ExecQuery("Select * from Student_Images where StudentId = '" & TbId.Text & "' ")
        ' If Not String.IsNullOrEmpty(sql.HasExeption) OrElse sql.RecordCount < 1 Then MsgBox("exception")

        ' Dim Buffer As Byte() = sql.DBDS.Tables(0).Rows(0)("Images")
        Dim buffer As Byte()
        'MsgBox("hi 1")
        For Each r As DataRow In sql.DBDT.Rows
            buffer = r("Images")
        Next
        Return buffer



    End Function

    Private Sub drawimage(PB As PictureBox)
        'MsgBox("new 2")
        Dim buffer As Byte() = Fetchimage(TbId.Text)
        If buffer IsNot Nothing Then
            '   MsgBox("hi")
            Using ms As New MemoryStream(buffer, 0, buffer.Length)
                ms.Write(buffer, 0, buffer.Length)
                PB.Image = Image.FromStream(ms, True)
                ' MsgBox(" new 1")
            End Using
        End If


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ofdBrowse.ShowDialog()

    End Sub

    Private Sub ofdBrowse_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdBrowse.FileOk
        Try
            PictureBox1.Image = Image.FromFile(ofdBrowse.FileName)
            TextBox1.Text = ofdBrowse.FileName

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uploadimage(path As String)
        If String.IsNullOrEmpty(path) Then Exit Sub
        Dim img As Image = Image.FromFile(path)
        Dim ms As New MemoryStream
        img.Save(ms, img.RawFormat)
        Dim buffer As Byte() = ms.GetBuffer()

        sql.AddParam("@id", TbId.Text)
        sql.AddParam("@image", buffer)
        'sql.ExecQuery("Insert into Student_Images(StudentId,Images) values(@id,@image)")
        sql.ExecQuery("Update Student_Images set Images =@image where StudentId=@id")
        If sql.HasExeption(True) Then Exit Sub





    End Sub
End Class