Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Timers
Imports System.Web
Imports System.Object
Imports System.MarshalByRefObject
Imports System.ComponentModel.Component
Imports System.Windows.Forms.CommonDialog
Imports System.Windows.Forms.FileDialog
Imports System.Windows.Forms.OpenFileDialog
Imports System.Windows.Forms
Imports System.Xml
Imports ExcelDataReader
Imports System.Data.OleDb
Imports System.String

'Imports ExcelLibrary.CompoundDocumentFormat
'Imports ExcelLibrary.SpreadSheet


'Imports OpenFileDialogue









Public Class SQL
    Private DBCon As New SqlConnection With {.ConnectionString = "Server=BHARAT;Database = SmartGate;Trusted_Connection=True"}
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public DBDS As DataSet


    Public Params As New List(Of SqlParameter)

    Public RecordCount As Integer
    Public Exception As String

    Public Function HasConnection() As Boolean
        Try
            DBCon.Open()
            DBCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return False

    End Function

    Public Sub ExecQuery(Query As String)

        RecordCount = 0
        Exception = ""
        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()

            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            DBDS = New DataSet
            RecordCount = DBDA.Fill(DBDT)
            RecordCount = DBDA.Fill(DBDS)

            DBCon.Close()

        Catch ex As Exception
            ' Exception = "ExecQuery Error " & vbNewLine & ex.Message
            'MsgBox(ex.Message)
            ''' Debug.Print(Err.Erl)
            DBCon.Close()

            ' Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'MessageBox.Show("Line: " & st.GetFrame(0).GetFileLineNumber().ToString, "Error")
            'If DBCon.State = ConnectionState.Open Then
            'DBCon.Close()
            'End If
        End Try
    End Sub

    Public Sub AddParam(Name As String, value As Object)
        Dim NewParam As New SqlParameter(Name, value)
        Params.Add(NewParam)
    End Sub


    'Error Checking
    Public Function HasExeption(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception")
        Return True
    End Function
End Class
