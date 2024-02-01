<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarConvenio
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
        Me.dgvconvenios = New System.Windows.Forms.DataGridView
        Me.txtconvenio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblflag = New System.Windows.Forms.Label
        CType(Me.dgvconvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvconvenios
        '
        Me.dgvconvenios.AllowUserToAddRows = False
        Me.dgvconvenios.AllowUserToDeleteRows = False
        Me.dgvconvenios.AllowUserToOrderColumns = True
        Me.dgvconvenios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvconvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvconvenios.Location = New System.Drawing.Point(12, 45)
        Me.dgvconvenios.MultiSelect = False
        Me.dgvconvenios.Name = "dgvconvenios"
        Me.dgvconvenios.ReadOnly = True
        Me.dgvconvenios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvconvenios.Size = New System.Drawing.Size(401, 173)
        Me.dgvconvenios.TabIndex = 0
        '
        'txtconvenio
        '
        Me.txtconvenio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtconvenio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconvenio.Location = New System.Drawing.Point(67, 12)
        Me.txtconvenio.Name = "txtconvenio"
        Me.txtconvenio.Size = New System.Drawing.Size(346, 20)
        Me.txtconvenio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Convenio"
        '
        'lblflag
        '
        Me.lblflag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflag.Location = New System.Drawing.Point(64, 193)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(100, 23)
        Me.lblflag.TabIndex = 3
        '
        'FrmBuscarConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(425, 225)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtconvenio)
        Me.Controls.Add(Me.dgvconvenios)
        Me.Controls.Add(Me.lblflag)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarConvenio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Convenio"
        CType(Me.dgvconvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvconvenios As System.Windows.Forms.DataGridView
    Friend WithEvents txtconvenio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblflag As System.Windows.Forms.Label
End Class
