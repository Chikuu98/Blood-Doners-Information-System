<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PublicDetailShow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donner_detailsDataSet = New RAD_Project.donner_detailsDataSet()
        Me.DetailsTableAdapter = New RAD_Project.donner_detailsDataSetTableAdapters.DetailsTableAdapter()
        Me.TableAdapterManager = New RAD_Project.donner_detailsDataSetTableAdapters.TableAdapterManager()
        Me.DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donner_detailsDataSet1 = New RAD_Project.Donner_detailsDataSet1()
        Me.DetailsTableAdapter1 = New RAD_Project.Donner_detailsDataSet1TableAdapters.DetailsTableAdapter()
        Me.See_DonnersToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BloodTypeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BloodTypeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.See_DonnersToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.searchingtopic = New System.Windows.Forms.Label()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donner_detailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donner_detailsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.See_DonnersToolStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailsBindingSource
        '
        Me.DetailsBindingSource.DataMember = "Details"
        Me.DetailsBindingSource.DataSource = Me.Donner_detailsDataSet
        '
        'Donner_detailsDataSet
        '
        Me.Donner_detailsDataSet.DataSetName = "donner_detailsDataSet"
        Me.Donner_detailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailsTableAdapter
        '
        Me.DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetailsTableAdapter = Me.DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = RAD_Project.donner_detailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetailsDataGridView
        '
        Me.DetailsDataGridView.AutoGenerateColumns = False
        Me.DetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DetailsDataGridView.DataSource = Me.DetailsBindingSource1
        Me.DetailsDataGridView.GridColor = System.Drawing.Color.Maroon
        Me.DetailsDataGridView.Location = New System.Drawing.Point(12, 119)
        Me.DetailsDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailsDataGridView.Name = "DetailsDataGridView"
        Me.DetailsDataGridView.RowHeadersWidth = 51
        Me.DetailsDataGridView.RowTemplate.Height = 24
        Me.DetailsDataGridView.Size = New System.Drawing.Size(864, 434)
        Me.DetailsDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contact_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact_No"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Blood_Group"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Blood_Group"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "How_Many_Times"
        Me.DataGridViewTextBoxColumn6.HeaderText = "How_Many_Times"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DetailsBindingSource1
        '
        Me.DetailsBindingSource1.DataMember = "Details"
        Me.DetailsBindingSource1.DataSource = Me.Donner_detailsDataSet1
        '
        'Donner_detailsDataSet1
        '
        Me.Donner_detailsDataSet1.DataSetName = "Donner_detailsDataSet1"
        Me.Donner_detailsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailsTableAdapter1
        '
        Me.DetailsTableAdapter1.ClearBeforeFill = True
        '
        'See_DonnersToolStrip
        '
        Me.See_DonnersToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.See_DonnersToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.See_DonnersToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.See_DonnersToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BloodTypeToolStripLabel, Me.BloodTypeToolStripTextBox, Me.See_DonnersToolStripButton})
        Me.See_DonnersToolStrip.Location = New System.Drawing.Point(245, 86)
        Me.See_DonnersToolStrip.Name = "See_DonnersToolStrip"
        Me.See_DonnersToolStrip.Size = New System.Drawing.Size(466, 39)
        Me.See_DonnersToolStrip.TabIndex = 7
        Me.See_DonnersToolStrip.Text = "See_DonnersToolStrip"
        '
        'BloodTypeToolStripLabel
        '
        Me.BloodTypeToolStripLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodTypeToolStripLabel.Name = "BloodTypeToolStripLabel"
        Me.BloodTypeToolStripLabel.Size = New System.Drawing.Size(118, 26)
        Me.BloodTypeToolStripLabel.Text = "BloodType:"
        '
        'BloodTypeToolStripTextBox
        '
        Me.BloodTypeToolStripTextBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodTypeToolStripTextBox.Name = "BloodTypeToolStripTextBox"
        Me.BloodTypeToolStripTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BloodTypeToolStripTextBox.Size = New System.Drawing.Size(100, 29)
        Me.BloodTypeToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'See_DonnersToolStripButton
        '
        Me.See_DonnersToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.See_DonnersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.See_DonnersToolStripButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.See_DonnersToolStripButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.See_DonnersToolStripButton.Name = "See_DonnersToolStripButton"
        Me.See_DonnersToolStripButton.Size = New System.Drawing.Size(140, 26)
        Me.See_DonnersToolStripButton.Text = "See_Donners"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 38)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.searchingtopic)
        Me.Panel1.Controls.Add(Me.DetailsDataGridView)
        Me.Panel1.Controls.Add(Me.See_DonnersToolStrip)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 568)
        Me.Panel1.TabIndex = 10
        '
        'searchingtopic
        '
        Me.searchingtopic.AutoSize = True
        Me.searchingtopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchingtopic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.searchingtopic.Location = New System.Drawing.Point(85, 17)
        Me.searchingtopic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchingtopic.Name = "searchingtopic"
        Me.searchingtopic.Size = New System.Drawing.Size(706, 54)
        Me.searchingtopic.TabIndex = 8
        Me.searchingtopic.Text = "Searching for a Blood Donner..!"
        '
        'PublicDetailShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(888, 597)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PublicDetailShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PublicDetailShow"
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donner_detailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donner_detailsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.See_DonnersToolStrip.ResumeLayout(False)
        Me.See_DonnersToolStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Donner_detailsDataSet As donner_detailsDataSet
    Friend WithEvents DetailsBindingSource As BindingSource
    Friend WithEvents DetailsTableAdapter As donner_detailsDataSetTableAdapters.DetailsTableAdapter
    Friend WithEvents TableAdapterManager As donner_detailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Donner_detailsDataSet1 As Donner_detailsDataSet1
    Friend WithEvents DetailsBindingSource1 As BindingSource
    Friend WithEvents DetailsTableAdapter1 As Donner_detailsDataSet1TableAdapters.DetailsTableAdapter
    Friend WithEvents See_DonnersToolStrip As ToolStrip
    Friend WithEvents BloodTypeToolStripLabel As ToolStripLabel
    Friend WithEvents BloodTypeToolStripTextBox As ToolStripTextBox
    Friend WithEvents See_DonnersToolStripButton As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchingtopic As Label
End Class
