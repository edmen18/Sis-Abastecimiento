<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarUnidad
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
        Me.rbabreviatura = New System.Windows.Forms.RadioButton
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtunidad = New System.Windows.Forms.TextBox
        Me.dgvUnidad = New System.Windows.Forms.DataGridView
        Me.lblflag = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbabreviatura)
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'rbabreviatura
        '
        Me.rbabreviatura.AutoSize = True
        Me.rbabreviatura.Location = New System.Drawing.Point(238, 26)
        Me.rbabreviatura.Name = "rbabreviatura"
        Me.rbabreviatura.Size = New System.Drawing.Size(79, 17)
        Me.rbabreviatura.TabIndex = 1
        Me.rbabreviatura.TabStop = True
        Me.rbabreviatura.Text = "Abreviatura"
        Me.rbabreviatura.UseVisualStyleBackColor = True
        '
        'rbdescripcion
        '
        Me.rbdescripcion.AutoSize = True
        Me.rbdescripcion.Location = New System.Drawing.Point(75, 25)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(81, 17)
        Me.rbdescripcion.TabIndex = 0
        Me.rbdescripcion.TabStop = True
        Me.rbdescripcion.Text = "Descripción"
        Me.rbdescripcion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el Dato"
        '
        'txtunidad
        '
        Me.txtunidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtunidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtunidad.Location = New System.Drawing.Point(100, 70)
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.Size = New System.Drawing.Size(341, 20)
        Me.txtunidad.TabIndex = 2
        '
        'dgvUnidad
        '
        Me.dgvUnidad.AllowUserToAddRows = False
        Me.dgvUnidad.AllowUserToDeleteRows = False
        Me.dgvUnidad.AllowUserToOrderColumns = True
        Me.dgvUnidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidad.Location = New System.Drawing.Point(12, 96)
        Me.dgvUnidad.Name = "dgvUnidad"
        Me.dgvUnidad.ReadOnly = True
        Me.dgvUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnidad.Size = New System.Drawing.Size(429, 190)
        Me.dgvUnidad.TabIndex = 3
        '
        'lblflag
        '
        Me.lblflag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflag.Location = New System.Drawing.Point(336, 172)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(38, 10)
        Me.lblflag.TabIndex = 4
        Me.lblflag.Visible = False
        '
        'FrmBuscarUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(453, 298)
        Me.Controls.Add(Me.dgvUnidad)
        Me.Controls.Add(Me.txtunidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblflag)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarUnidad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Unidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbabreviatura As System.Windows.Forms.RadioButton
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtunidad As System.Windows.Forms.TextBox
    Friend WithEvents dgvUnidad As System.Windows.Forms.DataGridView
    Friend WithEvents lblflag As System.Windows.Forms.Label
End Class
