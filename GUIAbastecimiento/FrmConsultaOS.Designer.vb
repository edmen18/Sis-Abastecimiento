<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaOS))
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.gbdoc = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtpreferencia = New System.Windows.Forms.TextBox
        Me.cmbdoc = New System.Windows.Forms.ComboBox
        Me.chkpreferencia = New System.Windows.Forms.CheckBox
        Me.gbproyecto = New System.Windows.Forms.GroupBox
        Me.cmbglosa = New System.Windows.Forms.ComboBox
        Me.gbfecha = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtal = New System.Windows.Forms.DateTimePicker
        Me.dtdel = New System.Windows.Forms.DateTimePicker
        Me.gbproveedor = New System.Windows.Forms.GroupBox
        Me.btnbuscarprov = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblprov = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.gbnumero = New System.Windows.Forms.GroupBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbextorno = New System.Windows.Forms.RadioButton
        Me.rbdocumento = New System.Windows.Forms.RadioButton
        Me.rbproyecto = New System.Windows.Forms.RadioButton
        Me.rbfecha = New System.Windows.Forms.RadioButton
        Me.rbproveedor = New System.Windows.Forms.RadioButton
        Me.rbnumero = New System.Windows.Forms.RadioButton
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnODetalle = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.bnreporte = New System.Windows.Forms.Button
        Me.btnverdetalle = New System.Windows.Forms.Button
        Me.btnver = New System.Windows.Forms.Button
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdoc.SuspendLayout()
        Me.gbproyecto.SuspendLayout()
        Me.gbfecha.SuspendLayout()
        Me.gbproveedor.SuspendLayout()
        Me.gbnumero.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(7, 133)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(690, 231)
        Me.dgvDatos.TabIndex = 20
        '
        'gbdoc
        '
        Me.gbdoc.Controls.Add(Me.Label10)
        Me.gbdoc.Controls.Add(Me.txtpreferencia)
        Me.gbdoc.Controls.Add(Me.cmbdoc)
        Me.gbdoc.Controls.Add(Me.chkpreferencia)
        Me.gbdoc.Location = New System.Drawing.Point(7, 58)
        Me.gbdoc.Name = "gbdoc"
        Me.gbdoc.Size = New System.Drawing.Size(530, 68)
        Me.gbdoc.TabIndex = 19
        Me.gbdoc.TabStop = False
        Me.gbdoc.Text = "Documento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Doc."
        '
        'txtpreferencia
        '
        Me.txtpreferencia.Location = New System.Drawing.Point(360, 30)
        Me.txtpreferencia.Name = "txtpreferencia"
        Me.txtpreferencia.Size = New System.Drawing.Size(122, 20)
        Me.txtpreferencia.TabIndex = 8
        '
        'cmbdoc
        '
        Me.cmbdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdoc.FormattingEnabled = True
        Me.cmbdoc.Location = New System.Drawing.Point(66, 29)
        Me.cmbdoc.Name = "cmbdoc"
        Me.cmbdoc.Size = New System.Drawing.Size(202, 21)
        Me.cmbdoc.TabIndex = 6
        '
        'chkpreferencia
        '
        Me.chkpreferencia.AutoSize = True
        Me.chkpreferencia.Location = New System.Drawing.Point(274, 29)
        Me.chkpreferencia.Name = "chkpreferencia"
        Me.chkpreferencia.Size = New System.Drawing.Size(80, 17)
        Me.chkpreferencia.TabIndex = 7
        Me.chkpreferencia.Text = "Preferencia"
        Me.chkpreferencia.UseVisualStyleBackColor = True
        '
        'gbproyecto
        '
        Me.gbproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbproyecto.Controls.Add(Me.cmbglosa)
        Me.gbproyecto.Location = New System.Drawing.Point(7, 75)
        Me.gbproyecto.Name = "gbproyecto"
        Me.gbproyecto.Size = New System.Drawing.Size(530, 46)
        Me.gbproyecto.TabIndex = 18
        Me.gbproyecto.TabStop = False
        Me.gbproyecto.Text = "Proyecto"
        '
        'cmbglosa
        '
        Me.cmbglosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbglosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbglosa.FormattingEnabled = True
        Me.cmbglosa.Location = New System.Drawing.Point(7, 19)
        Me.cmbglosa.Name = "cmbglosa"
        Me.cmbglosa.Size = New System.Drawing.Size(503, 21)
        Me.cmbglosa.TabIndex = 9
        '
        'gbfecha
        '
        Me.gbfecha.Controls.Add(Me.Label5)
        Me.gbfecha.Controls.Add(Me.Label4)
        Me.gbfecha.Controls.Add(Me.dtal)
        Me.gbfecha.Controls.Add(Me.dtdel)
        Me.gbfecha.Location = New System.Drawing.Point(7, 64)
        Me.gbfecha.Name = "gbfecha"
        Me.gbfecha.Size = New System.Drawing.Size(530, 57)
        Me.gbfecha.TabIndex = 17
        Me.gbfecha.TabStop = False
        Me.gbfecha.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "&Al"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Del"
        '
        'dtal
        '
        Me.dtal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtal.Location = New System.Drawing.Point(315, 19)
        Me.dtal.Name = "dtal"
        Me.dtal.Size = New System.Drawing.Size(127, 20)
        Me.dtal.TabIndex = 1
        '
        'dtdel
        '
        Me.dtdel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdel.Location = New System.Drawing.Point(94, 19)
        Me.dtdel.Name = "dtdel"
        Me.dtdel.Size = New System.Drawing.Size(127, 20)
        Me.dtdel.TabIndex = 0
        '
        'gbproveedor
        '
        Me.gbproveedor.Controls.Add(Me.btnbuscarprov)
        Me.gbproveedor.Controls.Add(Me.Label3)
        Me.gbproveedor.Controls.Add(Me.Label2)
        Me.gbproveedor.Controls.Add(Me.lblprov)
        Me.gbproveedor.Controls.Add(Me.lblruc)
        Me.gbproveedor.Location = New System.Drawing.Point(7, 62)
        Me.gbproveedor.Name = "gbproveedor"
        Me.gbproveedor.Size = New System.Drawing.Size(530, 65)
        Me.gbproveedor.TabIndex = 16
        Me.gbproveedor.TabStop = False
        Me.gbproveedor.Text = "Proveedor"
        '
        'btnbuscarprov
        '
        Me.btnbuscarprov.Location = New System.Drawing.Point(482, 34)
        Me.btnbuscarprov.Name = "btnbuscarprov"
        Me.btnbuscarprov.Size = New System.Drawing.Size(28, 23)
        Me.btnbuscarprov.TabIndex = 9
        Me.btnbuscarprov.Text = "..."
        Me.btnbuscarprov.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre/Razon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código"
        '
        'lblprov
        '
        Me.lblprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprov.Location = New System.Drawing.Point(116, 34)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(360, 23)
        Me.lblprov.TabIndex = 7
        '
        'lblruc
        '
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(6, 34)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(93, 23)
        Me.lblruc.TabIndex = 8
        '
        'gbnumero
        '
        Me.gbnumero.Controls.Add(Me.txtnumero)
        Me.gbnumero.Controls.Add(Me.Label1)
        Me.gbnumero.Location = New System.Drawing.Point(7, 55)
        Me.gbnumero.Name = "gbnumero"
        Me.gbnumero.Size = New System.Drawing.Size(530, 44)
        Me.gbnumero.TabIndex = 15
        Me.gbnumero.TabStop = False
        Me.gbnumero.Text = "Número"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(135, 14)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(203, 20)
        Me.txtnumero.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el Número"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbextorno)
        Me.GroupBox1.Controls.Add(Me.rbdocumento)
        Me.GroupBox1.Controls.Add(Me.rbproyecto)
        Me.GroupBox1.Controls.Add(Me.rbfecha)
        Me.GroupBox1.Controls.Add(Me.rbproveedor)
        Me.GroupBox1.Controls.Add(Me.rbnumero)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 49)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'rbextorno
        '
        Me.rbextorno.AutoSize = True
        Me.rbextorno.Location = New System.Drawing.Point(599, 23)
        Me.rbextorno.Name = "rbextorno"
        Me.rbextorno.Size = New System.Drawing.Size(121, 17)
        Me.rbextorno.TabIndex = 5
        Me.rbextorno.TabStop = True
        Me.rbextorno.Text = "Ordenes Extornadas"
        Me.rbextorno.UseVisualStyleBackColor = True
        '
        'rbdocumento
        '
        Me.rbdocumento.AutoSize = True
        Me.rbdocumento.Location = New System.Drawing.Point(474, 23)
        Me.rbdocumento.Name = "rbdocumento"
        Me.rbdocumento.Size = New System.Drawing.Size(80, 17)
        Me.rbdocumento.TabIndex = 4
        Me.rbdocumento.TabStop = True
        Me.rbdocumento.Text = "Documento"
        Me.rbdocumento.UseVisualStyleBackColor = True
        '
        'rbproyecto
        '
        Me.rbproyecto.AutoSize = True
        Me.rbproyecto.Location = New System.Drawing.Point(362, 23)
        Me.rbproyecto.Name = "rbproyecto"
        Me.rbproyecto.Size = New System.Drawing.Size(67, 17)
        Me.rbproyecto.TabIndex = 3
        Me.rbproyecto.TabStop = True
        Me.rbproyecto.Text = "Proyecto"
        Me.rbproyecto.UseVisualStyleBackColor = True
        '
        'rbfecha
        '
        Me.rbfecha.AutoSize = True
        Me.rbfecha.Location = New System.Drawing.Point(256, 23)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(55, 17)
        Me.rbfecha.TabIndex = 2
        Me.rbfecha.TabStop = True
        Me.rbfecha.Text = "Fecha"
        Me.rbfecha.UseVisualStyleBackColor = True
        '
        'rbproveedor
        '
        Me.rbproveedor.AutoSize = True
        Me.rbproveedor.Location = New System.Drawing.Point(135, 23)
        Me.rbproveedor.Name = "rbproveedor"
        Me.rbproveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbproveedor.TabIndex = 1
        Me.rbproveedor.TabStop = True
        Me.rbproveedor.Text = "Proveedor"
        Me.rbproveedor.UseVisualStyleBackColor = True
        '
        'rbnumero
        '
        Me.rbnumero.AutoSize = True
        Me.rbnumero.Location = New System.Drawing.Point(30, 23)
        Me.rbnumero.Name = "rbnumero"
        Me.rbnumero.Size = New System.Drawing.Size(62, 17)
        Me.rbnumero.TabIndex = 0
        Me.rbnumero.TabStop = True
        Me.rbnumero.Text = "Número"
        Me.rbnumero.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._75
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(707, 310)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(69, 54)
        Me.btnsalir.TabIndex = 26
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnODetalle
        '
        Me.btnODetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnODetalle.Image = CType(resources.GetObject("btnODetalle.Image"), System.Drawing.Image)
        Me.btnODetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnODetalle.Location = New System.Drawing.Point(707, 193)
        Me.btnODetalle.Name = "btnODetalle"
        Me.btnODetalle.Size = New System.Drawing.Size(69, 69)
        Me.btnODetalle.TabIndex = 25
        Me.btnODetalle.Text = "Ordenes y Detalles"
        Me.btnODetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnODetalle.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneliminar.Location = New System.Drawing.Point(707, 133)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(69, 54)
        Me.btneliminar.TabIndex = 24
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'bnreporte
        '
        Me.bnreporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnreporte.Image = CType(resources.GetObject("bnreporte.Image"), System.Drawing.Image)
        Me.bnreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bnreporte.Location = New System.Drawing.Point(707, 64)
        Me.bnreporte.Name = "bnreporte"
        Me.bnreporte.Size = New System.Drawing.Size(69, 54)
        Me.bnreporte.TabIndex = 23
        Me.bnreporte.Text = "Reporte"
        Me.bnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bnreporte.UseVisualStyleBackColor = True
        '
        'btnverdetalle
        '
        Me.btnverdetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnverdetalle.Image = CType(resources.GetObject("btnverdetalle.Image"), System.Drawing.Image)
        Me.btnverdetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnverdetalle.Location = New System.Drawing.Point(632, 64)
        Me.btnverdetalle.Name = "btnverdetalle"
        Me.btnverdetalle.Size = New System.Drawing.Size(69, 54)
        Me.btnverdetalle.TabIndex = 22
        Me.btnverdetalle.Text = "Ver Detalle"
        Me.btnverdetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnverdetalle.UseVisualStyleBackColor = True
        '
        'btnver
        '
        Me.btnver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnver.Image = CType(resources.GetObject("btnver.Image"), System.Drawing.Image)
        Me.btnver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnver.Location = New System.Drawing.Point(557, 65)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(69, 54)
        Me.btnver.TabIndex = 21
        Me.btnver.Text = "Ver"
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnver.UseVisualStyleBackColor = True
        '
        'FrmConsultaOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(824, 376)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnODetalle)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.bnreporte)
        Me.Controls.Add(Me.btnverdetalle)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.gbdoc)
        Me.Controls.Add(Me.gbproyecto)
        Me.Controls.Add(Me.gbfecha)
        Me.Controls.Add(Me.gbproveedor)
        Me.Controls.Add(Me.gbnumero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConsultaOS"
        Me.ShowIcon = False
        Me.Text = "Consulta Ordenes de Servicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdoc.ResumeLayout(False)
        Me.gbdoc.PerformLayout()
        Me.gbproyecto.ResumeLayout(False)
        Me.gbfecha.ResumeLayout(False)
        Me.gbfecha.PerformLayout()
        Me.gbproveedor.ResumeLayout(False)
        Me.gbproveedor.PerformLayout()
        Me.gbnumero.ResumeLayout(False)
        Me.gbnumero.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bnreporte As System.Windows.Forms.Button
    Friend WithEvents btnverdetalle As System.Windows.Forms.Button
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents gbdoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtpreferencia As System.Windows.Forms.TextBox
    Friend WithEvents cmbdoc As System.Windows.Forms.ComboBox
    Friend WithEvents chkpreferencia As System.Windows.Forms.CheckBox
    Friend WithEvents gbproyecto As System.Windows.Forms.GroupBox
    Friend WithEvents cmbglosa As System.Windows.Forms.ComboBox
    Friend WithEvents gbfecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdel As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbproveedor As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscarprov As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents gbnumero As System.Windows.Forms.GroupBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdocumento As System.Windows.Forms.RadioButton
    Friend WithEvents rbproyecto As System.Windows.Forms.RadioButton
    Friend WithEvents rbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbproveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbnumero As System.Windows.Forms.RadioButton
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnODetalle As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents rbextorno As System.Windows.Forms.RadioButton
End Class
