Imports System.Data.OleDb
Public Class officeRegister
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\project\SMS.mdb;Persist Security Info=True;")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        menu1.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

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
        TextBox10.Clear()

        Dim s As String
        s = "select Productid,ProductName from pofficeregister "
        adp = New OleDbDataAdapter(s, con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)


        Dim str As String
        str = "select staffid from staff"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr("staffid").ToString())
        End While

        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
        TextBox10.Clear()
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String
        Dim userfound As Boolean = False
        str = "select ProductID,Quantity from pofficeregister where ProductID='" & TextBox4.Text & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader()
        Dim i As Integer
        While dr.Read
            i = dr(1)
            userfound = True
        End While
        If userfound = True Then
            Dim k As String
            k = "update pofficeregister set Quantity ='" & i + Val(TextBox7.Text) & "' where ProductID='" & TextBox4.Text & "' "
            cmd = New OleDbCommand(k, con)
            cmd.ExecuteNonQuery()
            MsgBox("updated")
        Else
            Dim g As String
            g = "insert into pofficeregister values('" & DateTimePicker1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "');"
            cmd = New OleDbCommand(g, con)
            cmd.ExecuteNonQuery()
            MsgBox("New Data Added")
        End If
        sample()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        Dim str As String
        str = "select staffid,staffname from staff where staffid='" & ComboBox1.SelectedItem & "'"
        cmd = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox3.Text = dr("staffname").ToString
        End While
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        TextBox9.Text = Val(TextBox6.Text) * Val(TextBox8.Text)
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub
    Public Function sample()
        Dim str As String
        str = "insert into officeregister values('" & DateTimePicker1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.SelectedItem & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton3.Text)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton4.Text)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox6.Text = (TextBox6.Text + RadioButton5.Text)
        End If
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub
End Class