Imports System.Data.OleDb
Public Class Login
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\project\SMS.mdb;Persist Security Info=True")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim userfound As Boolean = False
        Dim str As String
        str = "select StaffID,Password,Usertype from LOGIN where StaffID='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        While dr.Read()
            userfound = True
            TextBox3.Text = dr("Usertype").ToString()
        End While
        If userfound = True Then
            If TextBox3.Text <> "Admin" Then
                MsgBox("User request is accepted")
                menu2.Show()
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
            Else
                MsgBox("Admin request is accepted")
                menu1.Show()
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
            End If
        Else
            MsgBox("Userid or Password Incorrectly")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("THANK YOU")
        End
    End Sub
End Class
