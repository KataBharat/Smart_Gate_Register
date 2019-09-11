Public Class Form1
    Private sql As New SQL

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        If sql.HasConnection = True Then
            If IsAututhenticated() = True Then
                'MsgBox("Login successful")

                'code to make text boxes empty
                'TxtUser.Text = String.Empty
                'TxtPass.Text = String.Empty

                Form2.Show()
                Visible = False

            End If

        End If
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Function IsAututhenticated() As Boolean

        If sql.DBDS IsNot Nothing Then
            sql.DBDS.Clear()
        End If
        'If sql.DBDT IsNot Nothing Then
        'sql.DBDT.Clear()
        'End If
        sql.ExecQuery("SELECT Count(Username) As UserCount FROM UserLogin " & _
                     "WHERE Username='" & TxtUser.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS " & _
                      " AND Password='" & TxtPass.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS ")
        'If (sql.DBDT.Rows[0][0].Item("UserCount") = "1") Then
        'If (sql.DBDT.Rows[0][0].ToString() == "1")

        ' Working code for user login
        'If TxtUser.Text = "admin" And TxtPass.Text = "123@" Then 

        If sql.DBDS.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True

        End If

        MsgBox("Invalid user credentials.", MsgBoxStyle.Critical, "LOGIN FAILED")
        TxtUser.Clear()
        TxtPass.Clear()


        Return False



    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()


    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sql.HasConnection = True Then
                If IsAututhenticated() = True Then
                    Form2.Show()
                    Visible = False

                End If

            End If
        End If

    End Sub

    Private Sub TxtUser_TextChanged_1(sender As Object, e As EventArgs) Handles TxtUser.TextChanged, TxtPass.TextChanged
        If Not String.IsNullOrWhiteSpace(TxtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtPass.Text) Then
            CmdLogin.Enabled = True
        End If


    End Sub
End Class

