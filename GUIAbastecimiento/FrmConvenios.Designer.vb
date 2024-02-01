<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConvenios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConvenios))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.txtconvenio = New System.Windows.Forms.TextBox
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.dgvConvenios = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tsbtnnuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbtngrabar = New System.Windows.Forms.ToolStripButton
        Me.tsbtncancelar = New System.Windows.Forms.ToolStripButton
        Me.tsbtnsalir = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txttexto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.dgvConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.Location = New System.Drawing.Point(110, 22)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(100, 23)
        Me.lblcodigo.TabIndex = 2
        '
        'txtconvenio
        '
        Me.txtconvenio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtconvenio.Location = New System.Drawing.Point(110, 48)
        Me.txtconvenio.Name = "txtconvenio"
        Me.txtconvenio.Size = New System.Drawing.Size(320, 20)
        Me.txtconvenio.TabIndex = 3
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIAbastecimiento.My.Resources.Resources._15
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(201, 12)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 41)
        Me.btngrabar.TabIndex = 4
        Me.btngrabar.Text = "Guardar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._07
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(355, 12)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 41)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Image = Global.GUIAbastecimiento.My.Resources.Resources._28
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(278, 12)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 41)
        Me.btncancelar.TabIndex = 6
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = Global.GUIAbastecimiento.My.Resources.Resources._17
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(124, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 41)
        Me.btnnuevo.TabIndex = 7
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'dgvConvenios
        '
        Me.dgvConvenios.AllowUserToAddRows = False
        Me.dgvConvenios.AllowUserToDeleteRows = False
        Me.dgvConvenios.AllowUserToOrderColumns = True
        Me.dgvConvenios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConvenios.Location = New System.Drawing.Point(12, 220)
        Me.dgvConvenios.MultiSelect = False
        Me.dgvConvenios.Name = "dgvConvenios"
        Me.dgvConvenios.ReadOnly = True
        Me.dgvConvenios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConvenios.Size = New System.Drawing.Size(449, 179)
        Me.dgvConvenios.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.txtconvenio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 82)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'tsbtnnuevo
        '
        Me.tsbtnnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnnuevo.Image = CType(resources.GetObject("tsbtnnuevo.Image"), System.Drawing.Image)
        Me.tsbtnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnnuevo.Name = "tsbtnnuevo"
        Me.tsbtnnuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnnuevo.Text = "ToolStripButton1"
        '
        'tsbtngrabar
        '
        Me.tsbtngrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtngrabar.Image = CType(resources.GetObject("tsbtngrabar.Image"), System.Drawing.Image)
        Me.tsbtngrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtngrabar.Name = "tsbtngrabar"
        Me.tsbtngrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbtngrabar.Text = "ToolStripButton2"
        '
        'tsbtncancelar
        '
        Me.tsbtncancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtncancelar.Image = CType(resources.GetObject("tsbtncancelar.Image"), System.Drawing.Image)
        Me.tsbtncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtncancelar.Name = "tsbtncancelar"
        Me.tsbtncancelar.Size = New System.Drawing.Size(23, 22)
        Me.tsbtncancelar.Text = "ToolStripButton3"
        '
        'tsbtnsalir
        '
        Me.tsbtnsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnsalir.Image = CType(resources.GetObject("tsbtnsalir.Image"), System.Drawing.Image)
        Me.tsbtnsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnsalir.Name = "tsbtnsalir"
        Me.tsbtnsalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnsalir.Text = "ToolStripButton4"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Controls.Add(Me.btngrabar)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btncancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 58)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txttexto
        '
        Me.txttexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttexto.Location = New System.Drawing.Point(111, 20)
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(313, 20)
        Me.txttexto.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ingrese el texto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txttexto)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 51)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar por Descripción"
        '
        'FrmConvenios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(483, 412)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvConvenios)
        Me.Name = "FrmConvenios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios"
        CType(Me.dgvConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents txtconvenio As System.Windows.Forms.TextBox
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents dgvConvenios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tsbtnnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtngrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtncancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnsalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txttexto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
