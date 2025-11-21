<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.CustIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairServicesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepairServicesDataSet = New RepairShop_CRUD.RepairServicesDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.CustomersTableAdapter = New RepairShop_CRUD.RepairServicesDataSetTableAdapters.CustomersTableAdapter()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairServicesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairServicesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoGenerateColumns = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn})
        Me.dgvCustomers.DataSource = Me.CustomersBindingSource
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 30)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.Size = New System.Drawing.Size(454, 254)
        Me.dgvCustomers.TabIndex = 0
        '
        'CustIdDataGridViewTextBoxColumn
        '
        Me.CustIdDataGridViewTextBoxColumn.DataPropertyName = "CustId"
        Me.CustIdDataGridViewTextBoxColumn.HeaderText = "CustId"
        Me.CustIdDataGridViewTextBoxColumn.Name = "CustIdDataGridViewTextBoxColumn"
        Me.CustIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.RepairServicesDataSetBindingSource
        '
        'RepairServicesDataSetBindingSource
        '
        Me.RepairServicesDataSetBindingSource.DataSource = Me.RepairServicesDataSet
        Me.RepairServicesDataSetBindingSource.Position = 0
        '
        'RepairServicesDataSet
        '
        Me.RepairServicesDataSet.DataSetName = "RepairServicesDataSet"
        Me.RepairServicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSelectedToolStripMenuItem, Me.DeleteCustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditSelectedToolStripMenuItem
        '
        Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
        Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.EditSelectedToolStripMenuItem.Text = "Edit Selected"
        '
        'DeleteCustomerToolStripMenuItem
        '
        Me.DeleteCustomerToolStripMenuItem.Name = "DeleteCustomerToolStripMenuItem"
        Me.DeleteCustomerToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.DeleteCustomerToolStripMenuItem.Text = "Delete Customer"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 295)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(491, 22)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "StatusStrip1"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 317)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCustomer"
        Me.Text = "Customers"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairServicesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairServicesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStatus As StatusStrip
    Friend WithEvents RepairServicesDataSetBindingSource As BindingSource
    Friend WithEvents RepairServicesDataSet As RepairServicesDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As RepairServicesDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
