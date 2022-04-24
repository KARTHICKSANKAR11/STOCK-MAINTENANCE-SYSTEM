Imports System.Data.OleDb
Public Class deptRegister
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\project\SMS.mdb")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub deptpurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub deptpurchase_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = " "
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()

        Dim s As String
        s = "select Productid,ProductName from pdeptregister "
        adp = New OleDbDataAdapter(s, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        Dim str As String
        str = "select staffid from staff"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox2.Items.Add(dr("staffid").ToString())
        End While

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim userfound As Boolean = False
        Dim str As String
        str = "select ProductID,Quantity from pdeptregister where ProductID='" & TextBox4.Text & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        Dim i As Integer
        While dr.Read
            i = dr(1)
            userfound = True
        End While
        If userfound = True Then
            Dim j As String
            j = "update pdeptregister set Quantity='" & i + Val(TextBox7.Text) & "' where ProductID='" & TextBox4.Text & "'"
            cmd = New OleDbCommand(j, con)
            cmd.ExecuteNonQuery()
            MsgBox("updated")
        Else
            Dim s As String
            s = "insert into pdeptregister values('" & DateTimePicker1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox11.Text & "')"
            cmd = New OleDbCommand(s, con)
            cmd.ExecuteNonQuery()
            MsgBox("New Date Added")
        End If
        dept()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
    End Sub
    Public Function dept()
        Dim str As String
        str = "insert into deptregister values('" & DateTimePicker1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox11.Text & "')"
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
    End Function
    Private Sub TextBox3_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus

    End Sub

    Private Sub TextBox3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        TextBox9.Text = Val(TextBox6.Text) * Val(TextBox8.Text)
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        menu2.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        Dim str As String
        str = "select staffid,staffname from staff where staffid='" & ComboBox2.SelectedItem & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox3.Text = dr("staffname").ToString
        End While
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

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
        If RadioButton5.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton5.Text)
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
End Class