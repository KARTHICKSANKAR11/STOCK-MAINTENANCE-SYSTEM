Imports System.Data.OleDb
Public Class staff
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\project\SMS.mdb;Persist Security Info=True")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        ComboBox1.Items.Add("B.Sc Agriculture")
        ComboBox1.Items.Add("B.Sc Physics")
        ComboBox1.Items.Add("B.Sc Chemistry")
        ComboBox1.Items.Add("B.Sc Maths")
        ComboBox1.Items.Add("B.Sc Zoology")
        ComboBox1.Items.Add("B.Sc Statistics")
        ComboBox1.Items.Add("B.Sc Botany")
        ComboBox1.Items.Add("B.Sc Computer Sciencs")
        ComboBox1.Items.Add("B.Sc Fahion technology")
        ComboBox1.Items.Add("B.Com Cosmputer Science")
        ComboBox1.Items.Add("B.Sc Computer Application")
        ComboBox1.Items.Add("B.Com Computer Science")
        ComboBox1.Items.Add("B.Com Computer Application")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        menu1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = " "
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "insert into staff values('" & ComboBox1.SelectedItem & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        MsgBox("Added new ID")
        ComboBox1.Text = " "
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        'Dim str As String
        'Dim user As Boolean = False
        'str = "select staffid from staff where staffid='" & TextBox2.Text & "'"
        'cmd = New OleDbCommand(str, con)
        'dr = cmd.ExecuteReader()
        'While dr.Read
        '    user = True
        'End While
        'If user = True Then
        '    MsgBox("User is Already Used")
        '    TextBox2.Clear()
        '    TextBox3.Clear()
        '    TextBox4.Clear()
        '    TextBox2.Focus()
        'Else

        'End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class