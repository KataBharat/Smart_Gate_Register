Imports System.Data.OleDb
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient


Public Class Add_Multiple_Students
    Private sql As New SQL









    Private Sub CmdFile_Click(sender As Object, e As EventArgs) Handles CmdFile.Click
        'Dim ofd As New OpenFileDialog()

        'ofd.InitialDirectory = "D:"
        'ofd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        'If (ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
        'Txtfile.Text = ofd.FileName
        'Dim constr As String
        'constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Txtfile.Text + ";Extended Properties =\"Excel 12.0;HDR=YES;\";";
        Dim conn As OleDbConnection
        Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

            Dim fi As New FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Sheet1$]")
            DGV1data.DataSource = dts
            DGV1data.DataMember = "[Sheet1$]"

            conn.Close()











        End If




    End Sub

    Private Sub insertdb()

        'DGV1data.Rows.GetLastRow.Clear()
        For i As Integer = 0 To DGV1data.Rows.Count - 1 Step 1


            'sql.AddParam("@id2", DbType.Int64).addwithvalueValue(DGV1data.Rows(i).Cells(0).Value.ToString())
            ' If (DGV1data.Rows(i).Cells(0).Value. = DBNull.Value) Then Exit Sub

            sql.AddParam("@id2", DGV1data.Rows(i).Cells(0).Value.ToString())
            sql.AddParam("@name2", DGV1data.Rows(i).Cells(1).Value.ToString())
            sql.AddParam("@dept2", DGV1data.Rows(i).Cells(2).Value.ToString())
            sql.AddParam("@year2", DGV1data.Rows(i).Cells(3).Value.ToString())
            sql.AddParam("@rn2", DGV1data.Rows(i).Cells(4).Value.ToString())

            'sql.ExecQuery("Insert into Student_Details('StudentId', 'Name', 'Department', 'Year', 'RoomNumber') values(@id2,@name2,@dept2,@year2,@rn2)")

            sql.ExecQuery("Insert into Student_Details(StudentId, Name, Department, Year, RoomNumber) values(@id2,@name2,@dept2,@year2,@rn2)")

            If sql.HasExeption(True) Then Exit Sub

            MsgBox("Inserted successfully")
        Next

    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        'insertdb()
        insertdb1()


    End Sub

    Private Sub insertdb1()
        For i As Integer = 0 To DGV1data.Rows.Count - 1 Step +1
            'Dim r As DataRow

            'For each r As in dts.row

            'sql.AddParam("@id2", DbType.Int64).addwithvalueValue(DGV1data.Rows(i).Cells(0).Value.ToString())
            ' If (DGV1data.Rows(i).Cells(0).Value. = DBNull.Value) Then Exit Sub
            ' Try
            'On Error Resume Next
            ' On Error Goto end sub 


            sql.AddParam("@id2", DGV1data.Rows(i).Cells(0).Value.ToString())
            'On Error GoTo 138

            sql.AddParam("@name2", DGV1data.Rows(i).Cells(1).Value.ToString())
            sql.AddParam("@dept2", DGV1data.Rows(i).Cells(2).Value.ToString())
            sql.AddParam("@year2", DGV1data.Rows(i).Cells(3).Value.ToString())
            sql.AddParam("@rn2", DGV1data.Rows(i).Cells(4).Value.ToString())
            'Catch ex As Exception
            'Catch

            'Finally
            'MsgBox("Successfull")





            'End Try


            'sql.ExecQuery("Insert into Student_Details('StudentId', 'Name', 'Department', 'Year', 'RoomNumber') values(@id2,@name2,@dept2,@year2,@rn2)")
            sql.ExecQuery("select * from Student_Details where StudentId = @id2")
            If (sql.RecordCount > 0) Then
                MsgBox("StudentId already registered. Please enter a new StudentId")
                Exit Sub
            End If

            sql.AddParam("@id3", DGV1data.Rows(i).Cells(0).Value.ToString())
            sql.ExecQuery("Insert into Student_Details(StudentId, Name, Department, Year, RoomNumber) values(@id3,@name2,@dept2,@year2,@rn2)")

            ' If sql.HasExeption(True) Then Exit Sub

            'MsgBox("Inserted successfully")
        Next

        MsgBox("Inserted successfully")


    End Sub

    Private Sub Add_Multiple_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class