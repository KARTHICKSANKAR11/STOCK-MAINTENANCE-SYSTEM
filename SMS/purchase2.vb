Imports System.Data.OleDb
Public Class purchase2
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\project\SMS.mdb;Persist Security Info=True")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub purchase2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        Dim j As String
        j = "select Productid from pdeptregister"
        cmd = New OleDbCommand(j, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox3.Items.Add(dr("Productid").ToString())
        End While

        Dim str As String
        str = "select Productid,ProductName from pdeptregister"
        adp = New OleDbDataAdapter(str, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        Dim s As String
        s = "select staffid from staff"
        cmd = New OleDbCommand(s, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox2.Items.Add(dr("staffid").ToString())
        End While

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        menu2.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        Dim str As String
        str = "select staffid,staffname,phonenumber from staff where staffid='" & ComboBox2.SelectedItem & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox1.Text = dr("staffname").ToString
            TextBox2.Text = dr("phonenumber").ToString
        End While
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.LostFocus
        Dim str As String
        str = "select Productid,ProductName from deptregister where Productid='" & ComboBox3.SelectedItem & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox5.Text = dr("ProductName").ToString
        End While
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class