Imports System.Data.OleDb
Public Class report
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\project\SMS.mdb;Persist Security Info=True;")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        menu1.Show()
        Me.Hide()
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        Dim j As String
        j = "select Productid from pofficeregister"
        cmd = New OleDbCommand(j, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox3.Items.Add(dr("Productid").ToString())
        End While
        Dim a As String
        a = "select Productid from pdeptregister"
        cmd = New OleDbCommand(a, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox3.Items.Add(dr("Productid").ToString())
        End While


        Dim k As String
        k = "select staffid from staff"
        cmd = New OleDbCommand(k, con)
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

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "select * from pofficeregister where staffid='" & ComboBox2.Text & "'"
        adp = New OleDbDataAdapter(str, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Dim s As String
        s = "select * from pdeptregister where staffid='" & ComboBox2.Text & "'"
        adp = New OleDbDataAdapter(s, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String
        str = "select * from pofficeregister where ProductID='" & ComboBox3.Text & "'"
        adp = New OleDbDataAdapter(str, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Dim k As String
        k = "select * from pdeptregister where ProductID='" & ComboBox3.Text & "'"
        adp = New OleDbDataAdapter(k, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim str As String
        str = "select * from pdeptregister where department='" & ComboBox1.Text & "'"
        adp = New OleDbDataAdapter(str, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim k As String
        k = "select * from officeregister "
        adp = New OleDbDataAdapter(k, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim k As String
        k = "select * from deptregister "
        adp = New OleDbDataAdapter(k, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton4.Checked = True Then
            Dim str As String
            str = "select * from officeregister where DateTime='" & DateTimePicker1.Text & "'"
            adp = New OleDbDataAdapter(str, con)
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Else
            Dim str As String
            str = "select * from deptregister where DateTime='" & DateTimePicker1.Text & "'"
            adp = New OleDbDataAdapter(str, con)
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End If
    End Sub
End Class