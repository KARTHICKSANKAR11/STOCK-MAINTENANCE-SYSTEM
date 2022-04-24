Imports System.Data.OleDb
Public Class purchase1
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\project\SMS.mdb;Persist Security Info=True")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        menu1.Show()
        Me.Hide()
    End Sub

    Private Sub purchase1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim p As String
        p = "select Productid from pofficeregister"
        cmd = New OleDbCommand(p, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox3.Items.Add(dr("Productid").ToString())
        End While

        

        Dim str As String
        str = "select Productid,ProductName from pofficeregister"
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

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim str As String
        str = "select staffid,staffname,phonenumber from staff where staffid='" & ComboBox2.SelectedItem & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox1.Text = dr("staffname").ToString
            TextBox2.Text = dr("phonenumber").ToString
        End While
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim str As String
        str = "select Productid,ProductName from pofficeregister where Productid='" & ComboBox3.SelectedItem & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox5.Text = dr("ProductName").ToString
        End While
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        menu1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        Dim userfound As Boolean = False
        str = "select ProductID,Quantity from pofficeregister where ProductID='" & ComboBox3.Text & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader()
        Dim i As Integer
        While dr.Read
            i = dr(1)
            userfound = True
        End While
        If userfound = True Then
            Dim k As String
            k = "update pofficeregister set Quantity ='" & i - Val(TextBox6.Text) & "' where ProductID='" & ComboBox3.Text & "' "
            cmd = New OleDbCommand(k, con)
            cmd.ExecuteNonQuery()
            MsgBox("updated")
            'Else
            '    Dim j As String
            '    j = "insert into opurchase values('" & DateTimePicker1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            '    cmd = New OleDbCommand(str, con)
            '    cmd.ExecuteNonQuery()
            '    MsgBox("process")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton3.Text)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton4.Text)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton3.Text)
        End If
    End Sub

    Private Sub ComboBox2_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox3_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.LostFocus

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class