<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarMaterial
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
        Me.txtmaterial = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvmaterial = New System.Windows.Forms.DataGridView
        Me.lblflag = New System.Windows.Forms.Label
        CType(Me.dgvmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmaterial
        '
        Me.txtmaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmaterial.Location = New System.Drawing.Point(116, 22)
        Me.txtmaterial.Name = "txtmaterial"
        Me.txtmaterial.Size = New System.Drawing.Size(600, 20)
        Me.txtmaterial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el producto"
        '
        'dgvmaterial
        '
        Me.dgvmaterial.AllowUserToAddRows = False
        Me.dgvmaterial.AllowUserToDeleteRows = False
        Me.dgvmaterial.AllowUserToOrderColumns = True
        Me.dgvmaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmaterial.Location = New System.Drawing.Point(12, 57)
        Me.dgvmaterial.Name = "dgvmaterial"
        Me.dgvmaterial.ReadOnly = True
        Me.dgvmaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmaterial.Size = New System.Drawing.Size(704, 191)
        Me.dgvmaterial.TabIndex = 2
        '
        'lblflag
        '
        Me.lblflag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflag.Location = New System.Drawing.Point(334, 174)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(100, 23)
        Me.lblflag.TabIndex = 4
        Me.lblflag.Visible = False
        '
        'FrmBuscarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(728, 260)
        Me.Controls.Add(Me.dgvmaterial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmaterial)
        Me.Controls.Add(Me.lblflag)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarMaterial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Articulo"
        CType(Me.dgvmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvmaterial As System.Windows.Forms.DataGridView
    Friend WithEvents lblflag As System.Windows.Forms.Label
End Class
