Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1

    Const ITEM_ID_LENGTH As Integer = 4
    Const ATTRIB_FILE_NAME As String = ".\attributes.csv"
    Const SAVED_ITEMID_FILE_NAME As String = ".\SavedItems.csv"
    Dim btnAttrib(7) As Button
    Dim btnDefaultBgColor As Color
    Dim attribImported As Boolean = False
    Dim allowDefaultAttrib As Boolean = False

    Private Sub btnImportAttrib_Click(sender As Object, e As EventArgs) Handles btnImportAttrib.Click
        Dim attribReader As StreamReader
        Dim strRead As String
        Dim idxAttrib As Integer

        'Check the file exists
        If Not File.Exists(ATTRIB_FILE_NAME) Then
            MsgBox("The file for attributes does not exist." & vbCrLf & "But you can use the default attributes.")
            Exit Sub
        End If

        If attribImported Then
            Dim result As MsgBoxResult = MsgBox("Attributes were imported already." & vbCrLf & "Import again?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        attribReader = New StreamReader(ATTRIB_FILE_NAME)
        idxAttrib = 0
        Dim pattern As Regex = New Regex("[^a-zA-Z0-9]")
        Do While Not attribReader.EndOfStream
            strRead = attribReader.ReadLine()

            Dim attribArray() As String = strRead.Split(Chr(Asc(",")))
            For Each attrib As String In attribArray
                'Check attribute is alphanumeric and the length is between 1 to 12
                If Not pattern.IsMatch(attrib.Trim()) And attrib.Trim().Length > 0 And attrib.Trim().Length < 13 Then
                    btnAttrib(idxAttrib).Text = attrib.Trim()
                    idxAttrib = idxAttrib + 1
                    If idxAttrib > 7 Then
                        Exit Do
                    End If
                Else
                    MsgBox("Found a mismatching attribute." & vbCrLf & "Going to skip this attribute (" & attrib.Trim() & ")")
                End If
            Next
        Loop
        attribReader.Close()

        attribImported = True

        If idxAttrib < 8 Then
            MsgBox("The count of attributes in the file is only " & idxAttrib & "." & vbCrLf & "The rest of attributes use the default values")
        End If
    End Sub

    Private Sub btnAttrib1_Click(sender As Object, e As EventArgs) Handles btnAttrib1.Click, btnAttrib2.Click, btnAttrib3.Click, btnAttrib4.Click, btnAttrib5.Click, btnAttrib6.Click, btnAttrib7.Click, btnAttrib8.Click
        CType(sender, Button).BackColor = IIf(CType(sender, Button).BackColor = btnDefaultBgColor, Color.Orange, btnDefaultBgColor)
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click

        'Check Item ID length
        If txtItemID.Text.Trim().Length < ITEM_ID_LENGTH Then
            MsgBox("Item ID should be 4 digits.")
            txtItemID.Focus()
            Exit Sub
        End If

        'Check Item ID is all numeric
        If Not IsNumeric(txtItemID.Text.Trim()) Then
            MsgBox("Item ID should be all numeric digits.")
            txtItemID.Focus()
            Exit Sub
        End If

        'check any attributes selected
        'Dim attribSelected As Boolean = False
        'For i As Integer = 0 To 7
        '    If btnAttrib(i).BackColor <> btnDefaultBgColor Then
        '        attribSelected = True
        '        Exit For
        '    End If
        'Next
        'If Not attribSelected Then
        '    MsgBox("No attributes are selected.")
        '    Exit Sub
        'End If

        'Check attributes are imported
        If Not attribImported And Not allowDefaultAttrib Then
            Dim result As MsgBoxResult = MsgBox("Attributes are not imported yet." & vbCrLf & "Would you save this Item ID with the default attributes?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.No Then
                Exit Sub
            Else
                allowDefaultAttrib = True
            End If
        End If

        'save item id & attributes to the list box
        Dim strItem = txtItemID.Text.Trim()
        For idx As Integer = 0 To 7
            If btnAttrib(idx).BackColor <> btnDefaultBgColor Then 'selected
                strItem = strItem + ", " + btnAttrib(idx).Text
            End If
        Next

        ListBox1.Items.Add(strItem)

        'reset
        txtItemID.Text = ""
        For idx As Integer = 0 To 7
            btnAttrib(idx).BackColor = btnDefaultBgColor
        Next
    End Sub

    Private Sub btnViewSavedItems_Click(sender As Object, e As EventArgs) Handles btnViewSavedItems.Click

        ListBox1.Visible = IIf(ListBox1.Visible, False, True)
        Label5.Visible = IIf(Label5.Visible, False, True)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim itemWriter As StreamWriter

        'Save the Item IDs with attributes
        itemWriter = New StreamWriter(SAVED_ITEMID_FILE_NAME, False)
        For Each item In ListBox1.Items
            itemWriter.WriteLine(item.ToString)
        Next
        itemWriter.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read saved item file if exists
        If File.Exists(SAVED_ITEMID_FILE_NAME) Then
            Dim itemReader As StreamReader
            itemReader = New StreamReader(SAVED_ITEMID_FILE_NAME)
            Do While Not itemReader.EndOfStream
                Dim item As String
                item = itemReader.ReadLine()
                ListBox1.Items.Add(item)
            Loop
            itemReader.Close()
        End If
    End Sub
End Class
