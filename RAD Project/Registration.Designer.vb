<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.lblreg = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblBloodGroup = New System.Windows.Forms.Label()
        Me.lblHowManyTimes = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtHowManyTimes = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ComboBloodG = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblreg
        '
        Me.lblreg.AutoSize = True
        Me.lblreg.BackColor = System.Drawing.Color.Gold
        Me.lblreg.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreg.ForeColor = System.Drawing.Color.Red
        Me.lblreg.Location = New System.Drawing.Point(164, 20)
        Me.lblreg.Name = "lblreg"
        Me.lblreg.Size = New System.Drawing.Size(280, 44)
        Me.lblreg.TabIndex = 0
        Me.lblreg.Text = "REGISTRATION"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFirstName.Location = New System.Drawing.Point(123, 110)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 15)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLastName.Location = New System.Drawing.Point(123, 148)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(78, 15)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAge.Location = New System.Drawing.Point(123, 190)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 15)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContact.Location = New System.Drawing.Point(123, 229)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(114, 15)
        Me.lblContact.TabIndex = 4
        Me.lblContact.Text = "Contact Number"
        '
        'lblBloodGroup
        '
        Me.lblBloodGroup.AutoSize = True
        Me.lblBloodGroup.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloodGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBloodGroup.Location = New System.Drawing.Point(123, 266)
        Me.lblBloodGroup.Name = "lblBloodGroup"
        Me.lblBloodGroup.Size = New System.Drawing.Size(88, 15)
        Me.lblBloodGroup.TabIndex = 5
        Me.lblBloodGroup.Text = "Blood Group"
        '
        'lblHowManyTimes
        '
        Me.lblHowManyTimes.AutoSize = True
        Me.lblHowManyTimes.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowManyTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHowManyTimes.Location = New System.Drawing.Point(123, 307)
        Me.lblHowManyTimes.Name = "lblHowManyTimes"
        Me.lblHowManyTimes.Size = New System.Drawing.Size(120, 15)
        Me.lblHowManyTimes.TabIndex = 6
        Me.lblHowManyTimes.Text = "How Many Times"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(303, 105)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(164, 21)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(303, 143)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(164, 21)
        Me.txtLastName.TabIndex = 8
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(303, 185)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(164, 21)
        Me.txtAge.TabIndex = 9
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(303, 224)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(164, 21)
        Me.txtContact.TabIndex = 10
        '
        'txtHowManyTimes
        '
        Me.txtHowManyTimes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHowManyTimes.Location = New System.Drawing.Point(303, 302)
        Me.txtHowManyTimes.Name = "txtHowManyTimes"
        Me.txtHowManyTimes.Size = New System.Drawing.Size(164, 21)
        Me.txtHowManyTimes.TabIndex = 12
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Red
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubmit.Location = New System.Drawing.Point(248, 353)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 27)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Yellow
        Me.btnBack.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkRed
        Me.btnBack.Location = New System.Drawing.Point(502, 367)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(79, 27)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ComboBloodG
        '
        Me.ComboBloodG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBloodG.FormattingEnabled = True
        Me.ComboBloodG.Items.AddRange(New Object() {"A", "B", "O", "AB", "A+", "B+", "O+", "A-", "B-", "O-"})
        Me.ComboBloodG.Location = New System.Drawing.Point(303, 260)
        Me.ComboBloodG.Name = "ComboBloodG"
        Me.ComboBloodG.Size = New System.Drawing.Size(164, 21)
        Me.ComboBloodG.TabIndex = 15
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(380, 353)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 27)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(603, 406)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.ComboBloodG)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtHowManyTimes)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblHowManyTimes)
        Me.Controls.Add(Me.lblBloodGroup)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblreg As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblBloodGroup As Label
    Friend WithEvents lblHowManyTimes As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtHowManyTimes As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents ComboBloodG As ComboBox
    Friend WithEvents btnClear As Button
End Class
