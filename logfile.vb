
Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class logfile
    Private sql As New SQL

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub logfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details")
        DataGridView1.DataSource = sql.DBDT

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.FileName = "PDF (*.pdf)|*.pdf"

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then

            TextBox2.Text = SaveFileDialog1.FileName

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim paragraph As New Paragraph
        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20)
        pdffile.AddTitle(TextBox1.Text)
        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(TextBox2.Text, FileMode.Create))
        pdffile.Open()


        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)


        paragraph = New Paragraph(New Chunk(TextBox1.Text, pTitle))
        paragraph.Alignment = Element.ALIGN_CENTER
        paragraph.SpacingAfter = 5.0F

        pdffile.Add(paragraph)

        Dim pdftable As New PdfPTable(DataGridView1.Columns.Count)

        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True

        Dim widths(0 To DataGridView1.Columns.Count - 1) As Single
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            widths(i) = 1.0F
        Next

        pdftable.SetWidths(widths)
        pdftable.HorizontalAlignment = 0
        pdftable.SpacingBefore = 5.0F

        Dim pdfcell As PdfPCell = New PdfPCell

        For i As Integer = 0 To DataGridView1.Columns.Count - 1

            pdfcell = New PdfPCell(New Phrase(New Chunk(DataGridView1.Columns(i).HeaderText, pTable)))
            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            pdftable.AddCell(pdfcell)

        Next

        For i As Integer = 0 To DataGridView1.Columns.Count - 2
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(DataGridView1(j, i).Value.ToString(), pTable))
                pdftable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                pdftable.AddCell(pdfcell)
            Next
        Next

        pdffile.Add(pdftable)
        pdffile.Close()

        MsgBox("PDF generated")






    End Sub

    
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        sql.AddParam("@new1", "%" & TextBox3.Text & "%")
        If (TextBox3.Text.Length.ToString > 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox7.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            'sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where StudentId = '" & TextBox3.Text & "' ")
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where StudentId like @new1 ")

            DataGridView1.DataSource = sql.DBDT
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
        End If


        If (TextBox3.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
        End If
        'End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        sql.AddParam("@new10", "%" & TextBox4.Text & "%")

        If (TextBox3.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString > 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox7.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then

            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Name = like @new10 ")
            DataGridView1.DataSource = sql.DBDT
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False

        End If


        If (TextBox4.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
        End If

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If (TextBox3.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString > 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox7.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Department = '" & TextBox5.Text & "' ")
            DataGridView1.DataSource = sql.DBDT
           


        End If

        If (TextBox3.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString > 0) And (TextBox6.Text.Length.ToString > 0) And (TextBox7.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Department = '" & TextBox5.Text & "' and Year = '" & TextBox6.Text & "' ")
            DataGridView1.DataSource = sql.DBDT
            


        End If

    End Sub


    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If (TextBox3.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString > 0) And (TextBox7.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Year = '" & TextBox6.Text & "' ")
            DataGridView1.DataSource = sql.DBDT
            

            
            End If


        If (TextBox3.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString > 0) And (TextBox6.Text.Length.ToString > 0) And (TextBox7.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Department = '" & TextBox5.Text & "' and Year = '" & TextBox6.Text & "' ")
            DataGridView1.DataSource = sql.DBDT
           

            
            
        End If
    End Sub

   




    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If (TextBox7.Text.Length.ToString > 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox3.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where RoomNumber = '" & TextBox7.Text & "' ")
            DataGridView1.DataSource = sql.DBDT
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox4.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False

        End If

        If (TextBox7.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox3.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
        End If

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If (TextBox7.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox3.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString > 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.AddParam("@new2", "%" & TextBox8.Text & "%")
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Outdate like @new2 ")
            DataGridView1.DataSource = sql.DBDT
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox4.Enabled = False
            TextBox7.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
        End If

        If (TextBox8.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox3.Enabled = True
            TextBox7.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
        End If




    End Sub


    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If (TextBox7.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox3.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString > 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.AddParam("@new4", "%" & TextBox9.Text & "%")
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Outtime like @new4 ")
            DataGridView1.DataSource = sql.DBDT
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox4.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
        End If

        If (TextBox9.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox3.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If (TextBox7.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox3.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString > 0) And (TextBox11.Text.Length.ToString = 0) Then
            sql.AddParam("@new3", "%" & TextBox10.Text & "%")
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Indate like @new3 ")
            DataGridView1.DataSource = sql.DBDT
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox4.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox11.Enabled = False
        End If

        If (TextBox10.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox3.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox11.Enabled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        If (TextBox7.Text.Length.ToString = 0) And (TextBox4.Text.Length.ToString = 0) And (TextBox5.Text.Length.ToString = 0) And (TextBox6.Text.Length.ToString = 0) And (TextBox3.Text.Length.ToString = 0) And (TextBox8.Text.Length.ToString = 0) And (TextBox9.Text.Length.ToString = 0) And (TextBox10.Text.Length.ToString = 0) And (TextBox11.Text.Length.ToString > 0) Then
            sql.AddParam("@new5", "%" & TextBox11.Text & "%")
            sql.ExecQuery("Select ROW_NUMBER() OVER(ORDER BY Year) as Sno,StudentId,Name,Department,Year,RoomNumber,Outdate,Outtime,Indate,Intime from Logfile_Details where Intime like @new5 ")
            DataGridView1.DataSource = sql.DBDT
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox4.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
        End If

        If (TextBox11.Text.Length.ToString = 0) Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox3.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class