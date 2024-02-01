<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbrazon = New System.Windows.Forms.RadioButton
        Me.rbruc = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtprov = New System.Windows.Forms.TextBox
        Me.dgvproveedores = New System.Windows.Forms.DataGridView
        Me.lblflag = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbrazon)
        Me.GroupBox1.Controls.Add(Me.rbruc)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'rbrazon
        '
        Me.rbrazon.AutoSize = True
        Me.rbrazon.Location = New System.Drawing.Point(118, 23)
        Me.rbrazon.Name = "rbrazon"
        Me.rbrazon.Size = New System.Drawing.Size(88, 17)
        Me.rbrazon.TabIndex = 1
        Me.rbrazon.TabStop = True
        Me.rbrazon.Text = "Razón Social"
        Me.rbrazon.UseVisualStyleBackColor = True
        '
        'rbruc
        '
        Me.rbruc.AutoSize = True
        Me.rbruc.Location = New System.Drawing.Point(321, 22)
        Me.rbruc.Name = "rbruc"
        Me.rbruc.Size = New System.Drawing.Size(57, 17)
        Me.rbruc.TabIndex = 0
        Me.rbruc.TabStop = True
        Me.rbruc.Text = "R.U.C."
        Me.rbruc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el Dato"
        '
        'txtprov
        '
        Me.txtprov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtprov.Location = New System.Drawing.Point(120, 70)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(419, 20)
        Me.txtprov.TabIndex = 2
        '
        'dgvproveedores
        '
        Me.dgvproveedores.AllowUserToAddRows = False
        Me.dgvproveedores.AllowUserToDeleteRows = False
        Me.dgvproveedores.AllowUserToOrderColumns = True
        Me.dgvproveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproveedores.Location = New System.Drawing.Point(15, 100)
        Me.dgvproveedores.Name = "dgvproveedores"
        Me.dgvproveedores.ReadOnly = True
        Me.dgvproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproveedores.Size = New System.Drawing.Size(524, 204)
        Me.dgvproveedores.TabIndex = 3
        '
        'lblflag
        '
        Me.lblflag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflag.Location = New System.Drawing.Point(399, 213)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(38, 10)
        Me.lblflag.TabIndex = 5
        Me.lblflag.Visible = False
        '
        'FrmBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(551, 316)
        Me.Controls.Add(Me.dgvproveedores)
        Me.Controls.Add(Me.txtprov)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblflag)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarProveedor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbrazon As System.Windows.Forms.RadioButton
    Friend WithEvents rbruc As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprov As System.Windows.Forms.TextBox
    Friend WithEvents dgvproveedores As System.Windows.Forms.DataGridView
    Friend WithEvents lblflag As System.Windows.Forms.Label
End Class
