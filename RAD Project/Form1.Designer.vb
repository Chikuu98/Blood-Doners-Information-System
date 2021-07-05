<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Roboto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(162, 30)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(410, 58)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "BLOOD DONNERS"
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.Maroon
        Me.btnregister.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnregister.Location = New System.Drawing.Point(59, 269)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(135, 42)
        Me.btnregister.TabIndex = 2
        Me.btnregister.Text = "REGISTER"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Maroon
        Me.btnAdmin.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdmin.Location = New System.Drawing.Point(283, 269)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(145, 42)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnDetails
        '
        Me.btnDetails.BackColor = System.Drawing.Color.Maroon
        Me.btnDetails.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDetails.Location = New System.Drawing.Point(511, 269)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(144, 42)
        Me.btnDetails.TabIndex = 4
        Me.btnDetails.Text = "DETAILS"
        Me.btnDetails.UseVisualStyleBackColor = False
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.BackColor = System.Drawing.Color.Transparent
        Me.lbldesc.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldesc.Location = New System.Drawing.Point(9, 9)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(584, 25)
        Me.lbldesc.TabIndex = 5
        Me.lbldesc.Text = "The blood you donate gives someone another chance at life..!"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbldesc)
        Me.Panel1.Location = New System.Drawing.Point(59, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 44)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(86, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 58)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "INFORMATION SYSTEM"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(717, 357)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.lbltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents lbldesc As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
