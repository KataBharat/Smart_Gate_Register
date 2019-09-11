Imports System.Data.SqlClient

Public Class Edit_Multiple_Students

    Private sql As New SQL

    Private Sub LoadDGV()


        If (TBdept.Text.Length = 0) And (TBYear.Text.Length > 0) Then
            sql.AddParam("@year", TBYear.Text)

            sql.ExecQuery("Select * from Student_Details where Year=@year;")
            If sql.HasExeption(True) Then Exit Sub
            DGVdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
            End If
        End If




        If (TBYear.Text.Length = 0) And (TBdept.Text.Length > 0) Then
            sql.AddParam("@dept", TBdept.Text)
            sql.ExecQuery("Select * from Student_Details where Department=@dept;")
            If sql.HasExeption(True) Then Exit Sub
            DGVdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
            End If
        End If

        If (TBYear.Text.Length > 0) And (TBdept.Text.Length > 0) Then
            sql.AddParam("@dept", TBdept.Text)
            sql.AddParam("@year", TBYear.Text)
            sql.ExecQuery("Select * from Student_Details where Department=@dept and Year=@year;")
            If sql.HasExeption(True) Then Exit Sub
            DGVdata.DataSource = sql.DBDT
            If sql.RecordCount < 1 Then
                MsgBox("Please enter valid search options")
            End If
        End If







    End Sub

    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles CmdSearch.Click
        LoadDGV()
        'LoadGrid()
    End Sub



    Private Sub LoadGrid()

        ' sql.DBDA.UpdateCommand = New System.Data.SqlClient.SqlCommandBuilder(sql.DBDA).GetUpdateCommand
        For i As Integer = 0 To DGVdata.Rows.Count - 1 Step +1
            ' If (DGVdata.Rows(i).Cells(0).Value.Length = 0) Then Exit Sub

            sql.AddParam("@id2", DGVdata.Rows(i).Cells(0).Value.ToString())
            sql.AddParam("@name2", DGVdata.Rows(i).Cells(1).Value.ToString())
            sql.AddParam("@dept2", DGVdata.Rows(i).Cells(2).Value.ToString())
            sql.AddParam("@year2", DGVdata.Rows(i).Cells(3).Value.ToString())
            sql.AddParam("@rn2", DGVdata.Rows(i).Cells(4).Value.ToString())

            sql.ExecQuery("UPDATE Student_Details SET Name=@name2, Department=@dept2, Year=@year2, RoomNumber=@rn2 WHERE StudentId=@id2;")
            If sql.HasExeption(True) Then Exit Sub



        Next



    End Sub


    Private Sub Edit_Multiple_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdUpdate.Enabled = False


    End Sub





    Private Sub DGVdata_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdata.CellValueChanged
        CmdUpdate.Enabled = True
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles CmdUpdate.Click
        LoadGrid()

        sql.DBDA.Update(sql.DBDT)
        MsgBox("Updated Successfully")
        CmdUpdate.Enabled = False
        TBdept.Clear()
        TBYear.Clear()









    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class