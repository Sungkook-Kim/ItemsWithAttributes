Imports System.IO
Public Class Form1
    Dim btnAttrib(7) As Button
    Dim btnDefaultBgColor As Color
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim attribReader As StreamReader
        Dim strRead As String
        Dim idxAttrib As Integer

        attribReader = New StreamReader(".\attributes.csv")
        idxAttrib = 0
        Do While Not attribReader.EndOfStream
            strRead = attribReader.ReadLine()

            Dim attribArray() As String = strRead.Split(Chr(Asc(",")))
            For Each attrib As String In attribArray
                btnAttrib(idxAttrib).Text = attrib
                idxAttrib = idxAttrib + 1
                If idxAttrib > 7 Then
                    Exit Do
                End If
            Next
        Loop

        attribReader.Close()
    End Sub

    Private Sub btnAttrib1_Click(sender As Object, e As EventArgs) Handles btnAttrib1.Click, btnAttrib2.Click, btnAttrib3.Click, btnAttrib4.Click, btnAttrib5.Click, btnAttrib6.Click, btnAttrib7.Click, btnAttrib8.Click
        CType(sender, Button).BackColor = IIf(CType(sender, Button).BackColor = btnDefaultBgColor, Color.Orange, btnDefaultBgColor)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'text box check, numeric And length
        ' code
        'check attributes selected
        ' code
        '
        'save item id & attributes to the list box
        Dim strItem = txtItemID.Text.Trim()
        For idx As Integer = 0 To 7
            If btnAttrib(idx).BackColor <> btnDefaultBgColor Then 'selected
                strItem = strItem + "," + btnAttrib(idx).Text
            End If
        Next

        ListBox1.Items.Add(strItem)

        'reset
        txtItemID.Text = ""
        For idx As Integer = 0 To 7
            btnAttrib(idx).BackColor = btnDefaultBgColor
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ListBox1.Visible = IIf(ListBox1.Visible, False, True)
        Label5.Visible = IIf(Label5.Visible, False, True)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Me.Close()

    End Sub
End Class
