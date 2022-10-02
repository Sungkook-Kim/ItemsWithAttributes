<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSaveMsg = New System.Windows.Forms.Label()
        Me.lblItemMsg = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAttrib8 = New System.Windows.Forms.Button()
        Me.btnAttrib7 = New System.Windows.Forms.Button()
        Me.btnAttrib6 = New System.Windows.Forms.Button()
        Me.btnAttrib5 = New System.Windows.Forms.Button()
        Me.btnAttrib4 = New System.Windows.Forms.Button()
        Me.btnAttrib3 = New System.Windows.Forms.Button()
        Me.btnAttrib2 = New System.Windows.Forms.Button()
        Me.btnAttrib1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblImportMsg = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSaveMsg)
        Me.Panel1.Controls.Add(Me.lblItemMsg)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtItemID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 137)
        Me.Panel1.TabIndex = 0
        '
        'lblSaveMsg
        '
        Me.lblSaveMsg.AutoSize = True
        Me.lblSaveMsg.ForeColor = System.Drawing.Color.Red
        Me.lblSaveMsg.Location = New System.Drawing.Point(655, 113)
        Me.lblSaveMsg.Name = "lblSaveMsg"
        Me.lblSaveMsg.Size = New System.Drawing.Size(10, 15)
        Me.lblSaveMsg.TabIndex = 9
        Me.lblSaveMsg.Text = " "
        '
        'lblItemMsg
        '
        Me.lblItemMsg.AutoSize = True
        Me.lblItemMsg.ForeColor = System.Drawing.Color.Red
        Me.lblItemMsg.Location = New System.Drawing.Point(470, 88)
        Me.lblItemMsg.Name = "lblItemMsg"
        Me.lblItemMsg.Size = New System.Drawing.Size(10, 15)
        Me.lblItemMsg.TabIndex = 8
        Me.lblItemMsg.Text = " "
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(651, 83)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(122, 25)
        Me.Button11.TabIndex = 7
        Me.Button11.Text = "Save"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(374, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ITEM ID"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(374, 85)
        Me.txtItemID.MaxLength = 4
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(52, 23)
        Me.txtItemID.TabIndex = 1
        Me.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter Item ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(numerical 4 digits)"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnAttrib8)
        Me.Panel2.Controls.Add(Me.btnAttrib7)
        Me.Panel2.Controls.Add(Me.btnAttrib6)
        Me.Panel2.Controls.Add(Me.btnAttrib5)
        Me.Panel2.Controls.Add(Me.btnAttrib4)
        Me.Panel2.Controls.Add(Me.btnAttrib3)
        Me.Panel2.Controls.Add(Me.btnAttrib2)
        Me.Panel2.Controls.Add(Me.btnAttrib1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(15, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(830, 183)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Please select attributes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the Item ID above"
        '
        'btnAttrib8
        '
        Me.btnAttrib8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib8.Location = New System.Drawing.Point(499, 102)
        Me.btnAttrib8.Name = "btnAttrib8"
        Me.btnAttrib8.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib8.TabIndex = 11
        Me.btnAttrib8.Text = "Attrib8"
        Me.btnAttrib8.UseVisualStyleBackColor = False
        '
        'btnAttrib7
        '
        Me.btnAttrib7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib7.Location = New System.Drawing.Point(404, 102)
        Me.btnAttrib7.Name = "btnAttrib7"
        Me.btnAttrib7.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib7.TabIndex = 10
        Me.btnAttrib7.Text = "Attrib7"
        Me.btnAttrib7.UseVisualStyleBackColor = False
        '
        'btnAttrib6
        '
        Me.btnAttrib6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib6.Location = New System.Drawing.Point(310, 102)
        Me.btnAttrib6.Name = "btnAttrib6"
        Me.btnAttrib6.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib6.TabIndex = 9
        Me.btnAttrib6.Text = "Attrib6"
        Me.btnAttrib6.UseVisualStyleBackColor = False
        '
        'btnAttrib5
        '
        Me.btnAttrib5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib5.Location = New System.Drawing.Point(214, 102)
        Me.btnAttrib5.Name = "btnAttrib5"
        Me.btnAttrib5.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib5.TabIndex = 8
        Me.btnAttrib5.Text = "Attrib5"
        Me.btnAttrib5.UseVisualStyleBackColor = False
        '
        'btnAttrib4
        '
        Me.btnAttrib4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib4.Location = New System.Drawing.Point(499, 69)
        Me.btnAttrib4.Name = "btnAttrib4"
        Me.btnAttrib4.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib4.TabIndex = 7
        Me.btnAttrib4.Text = "Attrib4"
        Me.btnAttrib4.UseVisualStyleBackColor = False
        '
        'btnAttrib3
        '
        Me.btnAttrib3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib3.Location = New System.Drawing.Point(404, 69)
        Me.btnAttrib3.Name = "btnAttrib3"
        Me.btnAttrib3.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib3.TabIndex = 6
        Me.btnAttrib3.Text = "Attrib3"
        Me.btnAttrib3.UseVisualStyleBackColor = False
        '
        'btnAttrib2
        '
        Me.btnAttrib2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib2.Location = New System.Drawing.Point(310, 69)
        Me.btnAttrib2.Name = "btnAttrib2"
        Me.btnAttrib2.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib2.TabIndex = 5
        Me.btnAttrib2.Text = "Attrib2"
        Me.btnAttrib2.UseVisualStyleBackColor = False
        '
        'btnAttrib1
        '
        Me.btnAttrib1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAttrib1.Location = New System.Drawing.Point(214, 69)
        Me.btnAttrib1.Name = "btnAttrib1"
        Me.btnAttrib1.Size = New System.Drawing.Size(98, 35)
        Me.btnAttrib1.TabIndex = 4
        Me.btnAttrib1.Text = "Attrib1"
        Me.btnAttrib1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(364, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ATTRIBUTES"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(420, 464)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(122, 29)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Import Attributes"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(555, 464)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(157, 29)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "View/Hide Saved Item IDs"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(724, 464)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(122, 29)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Exit"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(159, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Saved Items"
        Me.Label5.Visible = False
        '
        'lblImportMsg
        '
        Me.lblImportMsg.AutoSize = True
        Me.lblImportMsg.ForeColor = System.Drawing.Color.Red
        Me.lblImportMsg.Location = New System.Drawing.Point(431, 437)
        Me.lblImportMsg.Name = "lblImportMsg"
        Me.lblImportMsg.Size = New System.Drawing.Size(10, 15)
        Me.lblImportMsg.TabIndex = 10
        Me.lblImportMsg.Text = " "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(19, 367)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(390, 199)
        Me.ListBox1.TabIndex = 11
        Me.ListBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 583)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblImportMsg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        btnAttrib(0) = btnAttrib1
        btnAttrib(1) = btnAttrib2
        btnAttrib(2) = btnAttrib3
        btnAttrib(3) = btnAttrib4
        btnAttrib(4) = btnAttrib5
        btnAttrib(5) = btnAttrib6
        btnAttrib(6) = btnAttrib7
        btnAttrib(7) = btnAttrib8
        btnDefaultBgColor = btnAttrib1.BackColor

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAttrib8 As Button
    Friend WithEvents btnAttrib7 As Button
    Friend WithEvents btnAttrib6 As Button
    Friend WithEvents btnAttrib5 As Button
    Friend WithEvents btnAttrib4 As Button
    Friend WithEvents btnAttrib3 As Button
    Friend WithEvents btnAttrib2 As Button
    Friend WithEvents btnAttrib1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSaveMsg As Label
    Friend WithEvents lblItemMsg As Label
    Friend WithEvents lblImportMsg As Label
    Friend WithEvents ListBox1 As ListBox
End Class
