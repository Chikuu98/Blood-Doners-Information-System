<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.lbladmintopic = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbladmintopic
        '
        Me.lbladmintopic.AutoSize = True
        Me.lbladmintopic.BackColor = System.Drawing.Color.White
        Me.lbladmintopic.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladmintopic.ForeColor = System.Drawing.Color.Red
        Me.lbladmintopic.Location = New System.Drawing.Point(209, 60)
        Me.lbladmintopic.Name = "lbladmintopic"
        Me.lbladmintopic.Size = New System.Drawing.Size(217, 44)
        Me.lbladmintopic.TabIndex = 0
        Me.lbladmintopic.Text = "Admin Area"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.SystemColors.Menu
        Me.lblusername.Location = New System.Drawing.Point(124, 165)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(98, 19)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "User Name"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.SystemColors.Menu
        Me.lblpassword.Location = New System.Drawing.Point(124, 218)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(88, 19)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtUserName.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(347, 161)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(140, 23)
        Me.txtUserName.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPassword.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(347, 214)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(140, 23)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Red
        Me.btnlogin.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnlogin.Location = New System.Drawing.Point(128, 286)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(105, 32)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnClear.Location = New System.Drawing.Point(251, 286)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 32)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnExit.Location = New System.Drawing.Point(383, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 32)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(547, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(636, 379)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lbladmintopic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbladmintopic As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class
