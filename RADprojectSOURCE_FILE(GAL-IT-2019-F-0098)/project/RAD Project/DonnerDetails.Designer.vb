<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonnerDetails
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
        Me.components = New System.ComponentModel.Container()
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Contact_NoLabel As System.Windows.Forms.Label
        Dim Blood_GroupLabel As System.Windows.Forms.Label
        Dim How_Many_TimesLabel As System.Windows.Forms.Label
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donner_detailsDataSet = New RAD_Project.donner_detailsDataSet()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NoTextBox = New System.Windows.Forms.TextBox()
        Me.How_Many_TimesTextBox = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsTableAdapter = New RAD_Project.donner_detailsDataSetTableAdapters.DetailsTableAdapter()
        Me.TableAdapterManager = New RAD_Project.donner_detailsDataSetTableAdapters.TableAdapterManager()
        Me.Blood_GroupTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Contact_NoLabel = New System.Windows.Forms.Label()
        Blood_GroupLabel = New System.Windows.Forms.Label()
        How_Many_TimesLabel = New System.Windows.Forms.Label()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donner_detailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        First_NameLabel.Location = New System.Drawing.Point(12, 425)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(117, 24)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Last_NameLabel.Location = New System.Drawing.Point(12, 470)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(114, 24)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AgeLabel.Location = New System.Drawing.Point(340, 427)
        AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(58, 25)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        '
        'Contact_NoLabel
        '
        Contact_NoLabel.AutoSize = True
        Contact_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Contact_NoLabel.Location = New System.Drawing.Point(11, 513)
        Contact_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Contact_NoLabel.Name = "Contact_NoLabel"
        Contact_NoLabel.Size = New System.Drawing.Size(127, 25)
        Contact_NoLabel.TabIndex = 9
        Contact_NoLabel.Text = "Contact No:"
        '
        'Blood_GroupLabel
        '
        Blood_GroupLabel.AutoSize = True
        Blood_GroupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Blood_GroupLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Blood_GroupLabel.Location = New System.Drawing.Point(341, 470)
        Blood_GroupLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Blood_GroupLabel.Name = "Blood_GroupLabel"
        Blood_GroupLabel.Size = New System.Drawing.Size(134, 24)
        Blood_GroupLabel.TabIndex = 11
        Blood_GroupLabel.Text = "Blood Group:"
        '
        'How_Many_TimesLabel
        '
        How_Many_TimesLabel.AutoSize = True
        How_Many_TimesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        How_Many_TimesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        How_Many_TimesLabel.Location = New System.Drawing.Point(340, 517)
        How_Many_TimesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        How_Many_TimesLabel.Name = "How_Many_TimesLabel"
        How_Many_TimesLabel.Size = New System.Drawing.Size(185, 25)
        How_Many_TimesLabel.TabIndex = 13
        How_Many_TimesLabel.Text = "How Many Times:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(159, 426)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(155, 29)
        Me.First_NameTextBox.TabIndex = 4
        Me.First_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(159, 470)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(155, 29)
        Me.Last_NameTextBox.TabIndex = 6
        Me.Last_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(495, 425)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(132, 29)
        Me.AgeTextBox.TabIndex = 8
        Me.AgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Contact_NoTextBox
        '
        Me.Contact_NoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Contact_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Contact_No", True))
        Me.Contact_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_NoTextBox.Location = New System.Drawing.Point(159, 512)
        Me.Contact_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Contact_NoTextBox.Name = "Contact_NoTextBox"
        Me.Contact_NoTextBox.Size = New System.Drawing.Size(155, 29)
        Me.Contact_NoTextBox.TabIndex = 10
        Me.Contact_NoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'How_Many_TimesTextBox
        '
        Me.How_Many_TimesTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.How_Many_TimesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "How_Many_Times", True))
        Me.How_Many_TimesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.How_Many_TimesTextBox.Location = New System.Drawing.Point(545, 513)
        Me.How_Many_TimesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.How_Many_TimesTextBox.Name = "How_Many_TimesTextBox"
        Me.How_Many_TimesTextBox.Size = New System.Drawing.Size(81, 29)
        Me.How_Many_TimesTextBox.TabIndex = 14
        Me.How_Many_TimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Lime
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.DarkRed
        Me.btnInsert.Location = New System.Drawing.Point(704, 425)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(169, 36)
        Me.btnInsert.TabIndex = 15
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Cyan
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkRed
        Me.btnUpdate.Location = New System.Drawing.Point(703, 468)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(169, 36)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(703, 511)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(169, 36)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DetailsDataGridView
        '
        Me.DetailsDataGridView.AutoGenerateColumns = False
        Me.DetailsDataGridView.BackgroundColor = System.Drawing.Color.LightCoral
        Me.DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DetailsDataGridView.DataSource = Me.DetailsBindingSource
        Me.DetailsDataGridView.GridColor = System.Drawing.Color.Red
        Me.DetailsDataGridView.Location = New System.Drawing.Point(16, 30)
        Me.DetailsDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DetailsDataGridView.Name = "DetailsDataGridView"
        Me.DetailsDataGridView.RowHeadersWidth = 51
        Me.DetailsDataGridView.Size = New System.Drawing.Size(857, 383)
        Me.DetailsDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Contact_No"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contact_No"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Blood_Group"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Blood_Group"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "How_Many_Times"
        Me.DataGridViewTextBoxColumn7.HeaderText = "How_Many_Times"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
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
        'Blood_GroupTextBox
        '
        Me.Blood_GroupTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Blood_GroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Blood_Group", True))
        Me.Blood_GroupTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blood_GroupTextBox.Location = New System.Drawing.Point(495, 470)
        Me.Blood_GroupTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Blood_GroupTextBox.Name = "Blood_GroupTextBox"
        Me.Blood_GroupTextBox.Size = New System.Drawing.Size(132, 29)
        Me.Blood_GroupTextBox.TabIndex = 18
        Me.Blood_GroupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.InformationsToolStripMenuItem, Me.BackToLoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(888, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'InformationsToolStripMenuItem
        '
        Me.InformationsToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformationsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.InformationsToolStripMenuItem.Name = "InformationsToolStripMenuItem"
        Me.InformationsToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.InformationsToolStripMenuItem.Text = "About"
        '
        'BackToLoginToolStripMenuItem
        '
        Me.BackToLoginToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToLoginToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.BackToLoginToolStripMenuItem.Name = "BackToLoginToolStripMenuItem"
        Me.BackToLoginToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.BackToLoginToolStripMenuItem.Text = "Back to Login"
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
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.DetailsDataGridView)
        Me.Panel1.Controls.Add(Me.Blood_GroupTextBox)
        Me.Panel1.Controls.Add(Me.First_NameTextBox)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(First_NameLabel)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Last_NameTextBox)
        Me.Panel1.Controls.Add(Me.btnInsert)
        Me.Panel1.Controls.Add(Last_NameLabel)
        Me.Panel1.Controls.Add(How_Many_TimesLabel)
        Me.Panel1.Controls.Add(Me.AgeTextBox)
        Me.Panel1.Controls.Add(Me.How_Many_TimesTextBox)
        Me.Panel1.Controls.Add(AgeLabel)
        Me.Panel1.Controls.Add(Blood_GroupLabel)
        Me.Panel1.Controls.Add(Me.Contact_NoTextBox)
        Me.Panel1.Controls.Add(Contact_NoLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 564)
        Me.Panel1.TabIndex = 21
        '
        'DonnerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(888, 597)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DonnerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DonnerDetails"
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donner_detailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Contact_NoTextBox As TextBox
    Friend WithEvents How_Many_TimesTextBox As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Blood_GroupTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
