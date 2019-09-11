Imports System.Object
Imports System.Data.InternalDataCollectionBase
Imports System.Data.DataRowCollection
Imports System.DateTime
Imports System.IO


Public Class Form3
    Private sql As New SQL
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowDetails()

        sql.AddParam("@id", TxtId.Text)
        sql.ExecQuery("Select * from Student_Details where StudentId = @id")
        'TxtName.Text = sql.DBDT.Rows[0][0].ToString()
        If sql.RecordCount < 1 Then
            MsgBox("Please enter valid StudentId")
            TxtId.Clear()

        End If

        For Each r As DataRow In sql.DBDT.Rows
            TxtName.Text = r("Name")
            TxtDept.Text = r("Department")
            TxtYear.Text = r("Year")
            TxtRN.Text = r("RoomNumber")
        Next

    End Sub

    ' Private Sub TxtId_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtId.KeyDown



    'If e.KeyCode = Keys.Enter Then

    'sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' ")

    'insert3()
    'TxtId.Clear()
    'drawimage(PictureBox1)



    'End If

    'End Sub


    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged


        If TxtId.Text.Length.ToString = 7 Then
            ShowDetails()
            insert3()
            drawimage(PictureBox1)
            If sql.HasExeption = True Then
                MsgBox("Exception")

            End If
            TxtId.Clear()
        End If









    End Sub

    Private Sub showninsert()

        sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' ")
        If sql.RecordCount > 1 Then
            sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' and max(Sno)")
        End If



        If sql.RecordCount = 1 Then
            MsgBox("dummy 1")

            For Each r As DataRow In sql.DBDT.Rows
                TxtName.Text = r("Name")
                TxtDept.Text = r("Department")
                TxtYear.Text = r("Year")
                TxtRN.Text = r("RoomNumber")
                outdate.Text = r("Outdate")
                outtime.Text = r("Outtime")
                indate.Text = r("Indate")
                intime.Text = r("Intime")
            Next

            If (intime.Text = "NA") And (indate.Text = "NA") Then
                MsgBox("newww")

                indate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
                MsgBox("hello")
                intime.Text = DateTime.Now.ToString("hh:mm:ss tt")
                MsgBox("Hello 1")

                sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' ")
                MsgBox("hello 2")
                If sql.RecordCount > 1 Then
                    MsgBox("Hello 4")
                    sql.ExecQuery("Update Logfile_Details set Indate='" & indate.Text & "'  and Intime = '" & intime.Text & "' " & _
                              "where StudentId = '" & TxtId.Text & "' and max(Sno) ")
                    MsgBox("Hello 5")
                    TxtId.Clear()
                    Exit Sub



                Else
                    'sql.ExecQuery("Update Logfile_Details set Indate='" & indate.Text & "'  and Intime = '" & intime.Text & "' " & _
                    '             "where StudentId = '" & TxtId.Text & "' ")
                    sql.ExecQuery("Update Logfile_Details set Indate='" & indate.Text & "' ")
                    sql.ExecQuery("Update Logfile_Details set Intime='" & intime.Text & "' ")

                    MsgBox("newwwwwwwwwww 1")
                    TxtId.Clear()
                    Exit Sub
                End If


            End If
            outdate.Clear()
            outtime.Clear()
            indate.Clear()
            intime.Clear()

            outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
            outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
            indate.Text = "NA"
            intime.Text = "NA"
            MsgBox("hello 10")

            'sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Intdate,Intime) values('" & TxtId.Text & "' " & _
            '                    " '" & TxtName.Text & "','" & TxtDept.Text & "','" & TxtYear.Text & "','" & TxtRN.Text & "', '" & outdate.Text & "','" & outtime.Text & "' " & _
            '                  " '" & indate.Text & "','" & intime.Text & "' ")

            sql.AddParam("@id", TxtId.Text)
            sql.AddParam("@name", TxtName.Text)
            sql.AddParam("@dept", TxtDept.Text)
            sql.AddParam("@year", TxtYear.Text)
            sql.AddParam("@rn", TxtRN.Text)
            sql.AddParam("@od", outdate.Text)
            sql.AddParam("@ot", outtime.Text)
            sql.AddParam("@it", intime.Text)
            sql.AddParam("@id1", indate.Text)

            sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it)")

            MsgBox("hello 20")

            Exit Sub


        End If

        If sql.RecordCount = 0 Then
            MsgBox("Dummy 3")

            sql.ExecQuery("Select * from Student_Details where StudentId = '" & TxtId.Text & "'")
            MsgBox("dummy 4")
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid StudentId")
                TxtId.Clear()

            End If

            For Each r As DataRow In sql.DBDT.Rows
                TxtName.Text = r("Name")
                TxtDept.Text = r("Department")
                TxtYear.Text = r("Year")
                TxtRN.Text = r("RoomNumber")
            Next

            outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
            outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
            indate.Text = "NA"
            intime.Text = "NA"


            ' sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Intdate,Intime) values('" & TxtId.Text & "' " & _
            '              " '" & TxtName.Text & "','" & TxtDept.Text & "','" & TxtYear.Text & "','" & TxtRN.Text & "' " & _
            '             " '" & outdate.Text & "','" & outtime.Text & "','" & indate.Text & "','" & intime.Text & "' ")


            sql.AddParam("@id", TxtId.Text)
            sql.AddParam("@name", TxtName.Text)
            sql.AddParam("@dept", TxtDept.Text)
            sql.AddParam("@year", TxtYear.Text)
            sql.AddParam("@rn", TxtRN.Text)
            sql.AddParam("@od", outdate.Text)
            sql.AddParam("@ot", outtime.Text)
            sql.AddParam("@it", intime.Text)
            sql.AddParam("@id1", indate.Text)

            sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it)")



            If sql.HasExeption(True) Then Exit Sub
            TxtId.Clear()




        End If


    End Sub

    'sql.AddParam("@id", TxtId.Text)
    'sql.AddParam("@name", TxtName.Text)
    'sql.AddParam("@dept", TxtDept.Text)
    'sql.AddParam("@year", TxtYear.Text)
    'sql.AddParam("@rn", TxtRN.Text)
    'sql.AddParam("@od", outdate.Text)
    'sql.AddParam("@ot", outtime.Text)
    'sql.AddParam("@it", intime.Text)
    ' sql.AddParam("@id1", indate.Text)


    'TxtName.Text = sql.DBDT.Rows[0][0].ToString()
    'If sql.RecordCount < 1 Then
    'MsgBox("Please enter valid StudentId")
    'TxtId.Clear()

    'End If

    'For Each r As DataRow In sql.DBDT.Rows
    'TxtName.Text = r("Name")
    'TxtDept.Text = r("Department")
    'TxtYear.Text = r("Year")
    'TxtRN.Text = r("RoomNumber")
    'Next

    Private Sub insert1()

        If sql.RecordCount > 1 Then
            sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' and max(Sno) ")
        End If

        For Each r As DataRow In sql.DBDT.Rows
            TxtName.Text = r("Name")
            TxtDept.Text = r("Department")
            TxtYear.Text = r("Year")
            TxtRN.Text = r("RoomNumber")
            outdate.Text = r("Outdate")
            outtime.Text = r("Outtime")
            indate.Text = r("Indate")
            intime.Text = r("Intime")
        Next

        If (intime.Text = "NA") And (indate.Text = "NA") Then
            MsgBox("newww")

            indate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
            MsgBox("hello")
            intime.Text = DateTime.Now.ToString("hh:mm:ss tt")
            MsgBox("Hello 1")

            sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' ")
            MsgBox("hello 2")
            If sql.RecordCount > 1 Then
                MsgBox("Hello 4")
                sql.ExecQuery("Update Logfile_Details set Indate='" & indate.Text & "'  and Intime = '" & intime.Text & "' " & _
                          "where StudentId = '" & TxtId.Text & "' and max(Sno) ")
                MsgBox("Hello 5")
                TxtId.Clear()
                Exit Sub


            Else
                'sql.ExecQuery("Update Logfile_Details set Indate='" & indate.Text & "'  and Intime = '" & intime.Text & "' " & _
                '             "where StudentId = '" & TxtId.Text & "' ")
                sql.ExecQuery("Update Logfile_Details set Indate='" & indate.Text & "' where StudentId = '" & TxtId.Text & "' ")
                sql.ExecQuery("Update Logfile_Details set Intime='" & intime.Text & "' where StudentId = '" & TxtId.Text & "' ")

                MsgBox("newwwwwwwwwww 1")
                TxtId.Clear()
                Exit Sub
            End If


        End If
        outdate.Clear()
        outtime.Clear()
        indate.Clear()
        intime.Clear()

        outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
        indate.Text = "NA"
        intime.Text = "NA"
        MsgBox("hello 10")

        'sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Intdate,Intime) values('" & TxtId.Text & "' " & _
        '                    " '" & TxtName.Text & "','" & TxtDept.Text & "','" & TxtYear.Text & "','" & TxtRN.Text & "', '" & outdate.Text & "','" & outtime.Text & "' " & _
        '                  " '" & indate.Text & "','" & intime.Text & "' ")

        sql.AddParam("@id", TxtId.Text)
        sql.AddParam("@name", TxtName.Text)
        sql.AddParam("@dept", TxtDept.Text)
        sql.AddParam("@year", TxtYear.Text)
        sql.AddParam("@rn", TxtRN.Text)
        sql.AddParam("@od", outdate.Text)
        sql.AddParam("@ot", outtime.Text)
        sql.AddParam("@it", intime.Text)
        sql.AddParam("@id1", indate.Text)

        sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it)")
        Exit Sub
        MsgBox("hello 20")


    End Sub

    Private Sub insert2()


        MsgBox("Dummy 3")

        sql.ExecQuery("Select * from Student_Details where StudentId = '" & TxtId.Text & "'")
        MsgBox("dummy 4")
        If sql.RecordCount < 1 Then
            MsgBox("Please enter valid StudentId")
            TxtId.Clear()

        End If

        For Each r As DataRow In sql.DBDT.Rows
            TxtName.Text = r("Name")
            TxtDept.Text = r("Department")
            TxtYear.Text = r("Year")
            TxtRN.Text = r("RoomNumber")
        Next

        outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
        outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        indate.Text = "NA"
        intime.Text = "NA"


        ' sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Intdate,Intime) values('" & TxtId.Text & "' " & _
        '              " '" & TxtName.Text & "','" & TxtDept.Text & "','" & TxtYear.Text & "','" & TxtRN.Text & "' " & _
        '             " '" & outdate.Text & "','" & outtime.Text & "','" & indate.Text & "','" & intime.Text & "' ")


        sql.AddParam("@id", TxtId.Text)
        sql.AddParam("@name", TxtName.Text)
        sql.AddParam("@dept", TxtDept.Text)
        sql.AddParam("@year", TxtYear.Text)
        sql.AddParam("@rn", TxtRN.Text)
        sql.AddParam("@od", outdate.Text)
        sql.AddParam("@ot", outtime.Text)
        sql.AddParam("@it", intime.Text)
        sql.AddParam("@id1", indate.Text)

        sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it)")
        Exit Sub


        If sql.HasExeption(True) Then Exit Sub
        TxtId.Clear()







    End Sub



    Private Sub insert3()

        sql.ExecQuery("Select * from Student_Details Where StudentId= '" & TxtId.Text & "' ")
        If sql.RecordCount < 1 Then
            MsgBox("Enter valid StudnetId")
            Exit Sub
        End If

        For Each r As DataRow In sql.DBDT.Rows
            TxtName.Text = r("Name")
            TxtDept.Text = r("Department")
            TxtYear.Text = r("Year")
            TxtRN.Text = r("RoomNumber")
        Next

        sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' ")
        If sql.RecordCount > 1 Then
            'MsgBox("1")
            ' sql.ExecQuery("Select * from Logfile_Details where StudentId = '" & TxtId.Text & "' and max(Sno) as Sno ")
            sql.ExecQuery("Select Outdate,Outtime,Indate,Intime,LastModified,max(Sno) as value from Logfile_Details where StudentId = '" & TxtId.Text & "' group by StudentId,Outdate,Outtime,Indate,Intime,LastModified ")
            'sql.ExecQuery("Select max(Sno) from Logfile_Details where StudentId = '" & TxtId.Text & "' ")
            'For Each r As DataRow In sql.DBDT.Rows
            '   TextBox1.Text = r("Sno")
            'Next
            'sql.ExecQuery("select * from Logfile_Details where StudentId = '" & TxtId.Text & "' and Sno = '" & TextBox1.Text & "' ")
            'MsgBox("2")
            For Each r As DataRow In sql.DBDT.Rows
                outdate.Text = r("Outdate")
                outtime.Text = r("Outtime")
                indate.Text = r("Indate")
                intime.Text = r("Intime")
                TextBox1.Text = r("LastModified")

            Next
            If (indate.Text = "NA") And (intime.Text = "NA") Then
                indate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
                intime.Text = DateTime.Now.ToString("hh:mm:ss tt")
                sql.ExecQuery("update Logfile_Details set Indate = '" & indate.Text & "' where StudentId = '" & TxtId.Text & "' and LastModified = '" & TextBox1.Text & "' ")
                'MsgBox("3")
                sql.ExecQuery("update Logfile_Details set Intime = '" & intime.Text & "' where StudentId = '" & TxtId.Text & "' and LastModified = '" & TextBox1.Text & "' ")
                Exit Sub

            End If
            outdate.Clear()
            outtime.Clear()
            indate.Clear()
            intime.Clear()

            outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
            outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
            indate.Text = "NA"
            intime.Text = "NA"


            sql.AddParam("@id", TxtId.Text)
            sql.AddParam("@name", TxtName.Text)
            sql.AddParam("@dept", TxtDept.Text)
            sql.AddParam("@year", TxtYear.Text)
            sql.AddParam("@rn", TxtRN.Text)
            sql.AddParam("@od", outdate.Text)
            sql.AddParam("@ot", outtime.Text)
            sql.AddParam("@it", intime.Text)
            sql.AddParam("@id1", indate.Text)
            Try
                sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime,LastModified) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it,CURRENT_TIMESTAMP )")
            Catch ex As Exception
            End Try

            'MsgBox("1")
            Exit Sub

        End If


        If sql.RecordCount = 0 Then
            outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
            outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
            indate.Text = "NA"
            intime.Text = "NA"


            sql.AddParam("@id", TxtId.Text)
            sql.AddParam("@name", TxtName.Text)
            sql.AddParam("@dept", TxtDept.Text)
            sql.AddParam("@year", TxtYear.Text)
            sql.AddParam("@rn", TxtRN.Text)
            sql.AddParam("@od", outdate.Text)
            sql.AddParam("@ot", outtime.Text)
            sql.AddParam("@it", intime.Text)
            sql.AddParam("@id1", indate.Text)
            Try
                sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime,LastModified) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it,CURRENT_TIMESTAMP)")
            Catch ex As Exception
            End Try
            'MsgBox("2")
            Exit Sub
        End If

        If sql.RecordCount = 1 Then
            For Each r As DataRow In sql.DBDT.Rows
                outdate.Text = r("Outdate")
                outtime.Text = r("Outtime")
                indate.Text = r("Indate")
                intime.Text = r("Intime")
                TextBox1.Text = r("LastModified")
            Next

            If (indate.Text = "NA") And (intime.Text = "NA") Then
                indate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
                intime.Text = DateTime.Now.ToString("hh:mm:ss tt")
                sql.ExecQuery("update Logfile_Details set Indate = '" & indate.Text & "' where StudentId = '" & TxtId.Text & "' and LastModified = '" & TextBox1.Text & "' ")
                sql.ExecQuery("update Logfile_Details set Intime = '" & intime.Text & "' where StudentId = '" & TxtId.Text & "'and LastModified = '" & TextBox1.Text & "' ")
                sql.ExecQuery("Update LogFile_Details set LastModified = CURRENT_TIMESTAMP where StudentId = '" & TxtId.Text & "'and LastModified = '" & TextBox1.Text & "' ")
                Exit Sub

            End If

            outdate.Clear()
            outtime.Clear()
            indate.Clear()
            intime.Clear()

            outtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
            outdate.Text = DateTime.Now.ToString("dd MMMM,yyyy")
            indate.Text = "NA"
            intime.Text = "NA"


            sql.AddParam("@id", TxtId.Text)
            sql.AddParam("@name", TxtName.Text)
            sql.AddParam("@dept", TxtDept.Text)
            sql.AddParam("@year", TxtYear.Text)
            sql.AddParam("@rn", TxtRN.Text)
            sql.AddParam("@od", outdate.Text)
            sql.AddParam("@ot", outtime.Text)
            sql.AddParam("@it", intime.Text)
            sql.AddParam("@id1", indate.Text)
            Try
                sql.ExecQuery("Insert into Logfile_Details(StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime,LastModified) values(@id,@name,@dept,@year,@rn,@od,@ot,@id1,@it,CURRENT_TIMESTAMP)")
            Catch ex As Exception
            End Try

            'MsgBox("3")
            Exit Sub
        End If

    End Sub


    Private Function Fetchimage(id As String) As Byte()
        'MsgBox("fecthinmae")

        sql.ExecQuery("Select * from Student_Images where StudentId = '" & TxtId.Text & "' ")
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
        Dim buffer As Byte() = Fetchimage(TxtId.Text)
        If buffer IsNot Nothing Then
            '   MsgBox("hi")
            Using ms As New MemoryStream(buffer, 0, buffer.Length)
                ms.Write(buffer, 0, buffer.Length)
                PB.Image = Image.FromStream(ms, True)
                ' MsgBox(" new 1")
            End Using
        End If

    End Sub

End Class
