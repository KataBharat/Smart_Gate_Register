Public Class Form2
    Private sql As New SQL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub AddMultipleStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMS.Click
        Add_Multiple_Students.Show()

    End Sub

   
    Private Sub Ess_Click(sender As Object, e As EventArgs) Handles EDIT.Click
        ESS.Show()
    End Sub

    Private Sub EMS_Click(sender As Object, e As EventArgs) Handles EMS.Click
        Edit_Multiple_Students.Show()

    End Sub

    Private Sub ASS_Click(sender As Object, e As EventArgs) Handles ASS.Click
        Add_Single_Student.Show()
    End Sub

    Private Sub DeleteStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentsToolStripMenuItem.Click
        Delete_Students.Show()
    End Sub

    Private Sub LogFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogFileToolStripMenuItem.Click
        logfile.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class