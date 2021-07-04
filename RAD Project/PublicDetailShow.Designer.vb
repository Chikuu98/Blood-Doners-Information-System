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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donner_detailsDataSet = New RAD_Project.donner_detailsDataSet()
        Me.DetailsTableAdapter = New RAD_Project.donner_detailsDataSetTableAdapters.DetailsTableAdapter()
        Me.TableAdapterManager = New RAD_Project.donner_detailsDataSetTableAdapters.TableAdapterManager()
        Me.SeeResultToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BloodTypeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BloodTypeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SeeResultToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donner_detailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeeResultToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Donner Details Table"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(585, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 31)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'DetailsDataGridView
        '
        Me.DetailsDataGridView.AutoGenerateColumns = False
        Me.DetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DetailsDataGridView.DataSource = Me.DetailsBindingSource
        Me.DetailsDataGridView.GridColor = System.Drawing.Color.Red
        Me.DetailsDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.DetailsDataGridView.Name = "DetailsDataGridView"
        Me.DetailsDataGridView.ReadOnly = True
        Me.DetailsDataGridView.Size = New System.Drawing.Size(642, 375)
        Me.DetailsDataGridView.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(512, 451)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(67, 31)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contact_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact_No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Blood_Group"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Blood_Group"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "How_Many_Times"
        Me.DataGridViewTextBoxColumn6.HeaderText = "How_Many_Times"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'SeeResultToolStrip
        '
        Me.SeeResultToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SeeResultToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BloodTypeToolStripLabel, Me.BloodTypeToolStripTextBox, Me.SeeResultToolStripButton})
        Me.SeeResultToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SeeResultToolStrip.Name = "SeeResultToolStrip"
        Me.SeeResultToolStrip.Size = New System.Drawing.Size(674, 25)
        Me.SeeResultToolStrip.TabIndex = 5
        Me.SeeResultToolStrip.Text = "SeeResultToolStrip"
        '
        'BloodTypeToolStripLabel
        '
        Me.BloodTypeToolStripLabel.Name = "BloodTypeToolStripLabel"
        Me.BloodTypeToolStripLabel.Size = New System.Drawing.Size(65, 22)
        Me.BloodTypeToolStripLabel.Text = "BloodType:"
        '
        'BloodTypeToolStripTextBox
        '
        Me.BloodTypeToolStripTextBox.Name = "BloodTypeToolStripTextBox"
        Me.BloodTypeToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'SeeResultToolStripButton
        '
        Me.SeeResultToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SeeResultToolStripButton.Name = "SeeResultToolStripButton"
        Me.SeeResultToolStripButton.Size = New System.Drawing.Size(61, 19)
        Me.SeeResultToolStripButton.Text = "SeeResult"
        '
        'PublicDetailShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 494)
        Me.Controls.Add(Me.SeeResultToolStrip)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DetailsDataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PublicDetailShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PublicDetailShow"
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donner_detailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeeResultToolStrip.ResumeLayout(False)
        Me.SeeResultToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Donner_detailsDataSet As donner_detailsDataSet
    Friend WithEvents DetailsBindingSource As BindingSource
    Friend WithEvents DetailsTableAdapter As donner_detailsDataSetTableAdapters.DetailsTableAdapter
    Friend WithEvents TableAdapterManager As donner_detailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents SeeResultToolStrip As ToolStrip
    Friend WithEvents BloodTypeToolStripLabel As ToolStripLabel
    Friend WithEvents BloodTypeToolStripTextBox As ToolStripTextBox
    Friend WithEvents SeeResultToolStripButton As ToolStripButton
End Class
