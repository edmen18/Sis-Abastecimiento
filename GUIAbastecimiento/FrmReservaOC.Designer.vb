<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReservaOC
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnReserva = New System.Windows.Forms.ToolStripButton
        Me.btngetReserva = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.nroreserva = New System.Windows.Forms.NumericUpDown
        Me.lblOrden = New System.Windows.Forms.Label
        Me.dgvReserva = New System.Windows.Forms.DataGridView
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        CType(Me.nroreserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReserva, Me.btngetReserva, Me.ToolStripSeparator1, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(292, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnReserva
        '
        Me.btnReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReserva.Image = Global.GUIAbastecimiento.My.Resources.Resources._17
        Me.btnReserva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(23, 22)
        Me.btnReserva.Text = "Reservar Orden"
        '
        'btngetReserva
        '
        Me.btngetReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btngetReserva.Image = Global.GUIAbastecimiento.My.Resources.Resources._06
        Me.btngetReserva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btngetReserva.Name = "btngetReserva"
        Me.btngetReserva.Size = New System.Drawing.Size(23, 22)
        Me.btngetReserva.Text = "Recuperar Reservas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._30
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(23, 22)
        Me.btnSalir.Text = "Salir"
        '
        'nroreserva
        '
        Me.nroreserva.Location = New System.Drawing.Point(230, 36)
        Me.nroreserva.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nroreserva.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroreserva.Name = "nroreserva"
        Me.nroreserva.Size = New System.Drawing.Size(45, 20)
        Me.nroreserva.TabIndex = 8
        Me.nroreserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nroreserva.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblOrden
        '
        Me.lblOrden.BackColor = System.Drawing.Color.YellowGreen
        Me.lblOrden.Location = New System.Drawing.Point(124, 36)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(100, 20)
        Me.lblOrden.TabIndex = 7
        Me.lblOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvReserva
        '
        Me.dgvReserva.AllowUserToAddRows = False
        Me.dgvReserva.AllowUserToDeleteRows = False
        Me.dgvReserva.AllowUserToOrderColumns = True
        Me.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserva.Location = New System.Drawing.Point(12, 62)
        Me.dgvReserva.Name = "dgvReserva"
        Me.dgvReserva.ReadOnly = True
        Me.dgvReserva.Size = New System.Drawing.Size(263, 184)
        Me.dgvReserva.TabIndex = 6
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.GUIAbastecimiento.My.Resources.Resources._15
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(178, 252)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FrmReservaOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(292, 278)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.nroreserva)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.dgvReserva)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmReservaOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva OC"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.nroreserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnReserva As System.Windows.Forms.ToolStripButton
    Friend WithEvents btngetReserva As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents nroreserva As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOrden As System.Windows.Forms.Label
    Friend WithEvents dgvReserva As System.Windows.Forms.DataGridView
End Class
