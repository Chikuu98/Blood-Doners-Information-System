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
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.White
        Me.lbltitle.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Maroon
        Me.lbltitle.Location = New System.Drawing.Point(106, 42)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(586, 44)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Blood Donars Information System"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.Maroon
        Me.lblwelcome.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblwelcome.Location = New System.Drawing.Point(348, 156)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(105, 23)
        Me.lblwelcome.TabIndex = 1
        Me.lblwelcome.Text = "Welcome..!"
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.Red
        Me.btnregister.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnregister.Location = New System.Drawing.Point(114, 291)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(135, 42)
        Me.btnregister.TabIndex = 2
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdmin.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdmin.Location = New System.Drawing.Point(325, 291)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(145, 42)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "Admin Area"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnDetails
        '
        Me.btnDetails.BackColor = System.Drawing.Color.Red
        Me.btnDetails.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDetails.Location = New System.Drawing.Point(548, 291)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(144, 42)
        Me.btnDetails.TabIndex = 4
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = False
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldesc.Location = New System.Drawing.Point(108, 193)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(584, 25)
        Me.lbldesc.TabIndex = 5
        Me.lbldesc.Text = "The blood you donate gives someone another chance at life..!"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.lbltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents lblwelcome As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents lbldesc As Label
End Class
