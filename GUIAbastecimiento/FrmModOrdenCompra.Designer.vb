<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModOrdenCompra))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblorden = New System.Windows.Forms.TextBox
        Me.lbltipo = New System.Windows.Forms.Label
        Me.lblver = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtdoc = New System.Windows.Forms.TextBox
        Me.lvwDoc = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.dtfecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_sunat = New System.Windows.Forms.Button
        Me.btnprov = New System.Windows.Forms.Button
        Me.lbldir = New System.Windows.Forms.Label
        Me.lblprov = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtndoc = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbglosa = New System.Windows.Forms.ComboBox
        Me.cmbdoc = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.chkImpuesto = New System.Windows.Forms.CheckBox
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtpu = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbforma = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnmaterial = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.lbldescripción = New System.Windows.Forms.Label
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.btnagregar = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.lvwitem = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lblimpuesto = New System.Windows.Forms.Label
        Me.lblsubtotal = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblretencion = New System.Windows.Forms.Label
        Me.lbligv = New System.Windows.Forms.Label
        Me.txtmontoletras = New System.Windows.Forms.TextBox
        Me.chkvis = New System.Windows.Forms.CheckBox
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.lblimp = New System.Windows.Forms.Label
        Me.chkretencion = New System.Windows.Forms.CheckBox
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.lblorden)
        Me.GroupBox5.Controls.Add(Me.lbltipo)
        Me.GroupBox5.Controls.Add(Me.lblver)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtdoc)
        Me.GroupBox5.Controls.Add(Me.lvwDoc)
        Me.GroupBox5.Controls.Add(Me.dtfecha)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.chkImpuesto)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.btnEliminar)
        Me.GroupBox5.Controls.Add(Me.lbltotal)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.btnagregar)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.lvwitem)
        Me.GroupBox5.Controls.Add(Me.lblimpuesto)
        Me.GroupBox5.Controls.Add(Me.lblsubtotal)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(854, 440)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        '
        'lblorden
        '
        Me.lblorden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblorden.Location = New System.Drawing.Point(709, 63)
        Me.lblorden.Name = "lblorden"
        Me.lblorden.Size = New System.Drawing.Size(100, 20)
        Me.lblorden.TabIndex = 71
        '
        'lbltipo
        '
        Me.lbltipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(701, 16)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(0, 13)
        Me.lbltipo.TabIndex = 67
        Me.lbltipo.Visible = False
        '
        'lblver
        '
        Me.lblver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblver.BackColor = System.Drawing.Color.DarkSalmon
        Me.lblver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblver.Image = Global.GUIAbastecimiento.My.Resources.Resources._37
        Me.lblver.Location = New System.Drawing.Point(815, 58)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(28, 23)
        Me.lblver.TabIndex = 66
        Me.lblver.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.GUIAbastecimiento.My.Resources.Resources._49s
        Me.Button1.Location = New System.Drawing.Point(635, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 27)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(368, 348)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Doc. Adj."
        '
        'txtdoc
        '
        Me.txtdoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdoc.Location = New System.Drawing.Point(425, 345)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.Size = New System.Drawing.Size(204, 20)
        Me.txtdoc.TabIndex = 18
        '
        'lvwDoc
        '
        Me.lvwDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwDoc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.lvwDoc.FullRowSelect = True
        Me.lvwDoc.GridLines = True
        Me.lvwDoc.HideSelection = False
        Me.lvwDoc.Location = New System.Drawing.Point(368, 368)
        Me.lvwDoc.Name = "lvwDoc"
        Me.lvwDoc.Size = New System.Drawing.Size(291, 66)
        Me.lvwDoc.TabIndex = 42
        Me.lvwDoc.UseCompatibleStateImageBehavior = False
        Me.lvwDoc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Documento"
        Me.ColumnHeader8.Width = 284
        '
        'dtfecha
        '
        Me.dtfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(216, 403)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(131, 20)
        Me.dtfecha.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSalmon
        Me.GroupBox1.Controls.Add(Me.btn_sunat)
        Me.GroupBox1.Controls.Add(Me.btnprov)
        Me.GroupBox1.Controls.Add(Me.lbldir)
        Me.GroupBox1.Controls.Add(Me.lblprov)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 73)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Proveedor"
        '
        'btn_sunat
        '
        Me.btn_sunat.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_sunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sunat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sunat.ForeColor = System.Drawing.Color.Black
        Me.btn_sunat.Location = New System.Drawing.Point(222, 17)
        Me.btn_sunat.Name = "btn_sunat"
        Me.btn_sunat.Size = New System.Drawing.Size(36, 23)
        Me.btn_sunat.TabIndex = 68
        Me.btn_sunat.Text = "?"
        Me.btn_sunat.UseVisualStyleBackColor = False
        '
        'btnprov
        '
        Me.btnprov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprov.Image = CType(resources.GetObject("btnprov.Image"), System.Drawing.Image)
        Me.btnprov.Location = New System.Drawing.Point(619, 24)
        Me.btnprov.Name = "btnprov"
        Me.btnprov.Size = New System.Drawing.Size(43, 38)
        Me.btnprov.TabIndex = 4
        Me.btnprov.UseVisualStyleBackColor = True
        '
        'lbldir
        '
        Me.lbldir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldir.ForeColor = System.Drawing.Color.Black
        Me.lbldir.Location = New System.Drawing.Point(79, 44)
        Me.lbldir.Name = "lbldir"
        Me.lbldir.Size = New System.Drawing.Size(534, 23)
        Me.lbldir.TabIndex = 4
        Me.lbldir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprov
        '
        Me.lblprov.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblprov.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprov.ForeColor = System.Drawing.Color.Black
        Me.lblprov.Location = New System.Drawing.Point(337, 17)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(276, 23)
        Me.lblprov.TabIndex = 5
        Me.lblprov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblruc
        '
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.ForeColor = System.Drawing.Color.Black
        Me.lblruc.Location = New System.Drawing.Point(79, 17)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(142, 23)
        Me.lblruc.TabIndex = 6
        Me.lblruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R.U.C."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(15, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(269, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proveedor"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(216, 388)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Fecha Emisión"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtndoc)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.cmbglosa)
        Me.GroupBox3.Controls.Add(Me.cmbdoc)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(15, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(822, 40)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del documento"
        '
        'txtndoc
        '
        Me.txtndoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtndoc.Location = New System.Drawing.Point(306, 15)
        Me.txtndoc.MaxLength = 20
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(141, 20)
        Me.txtndoc.TabIndex = 16
        Me.txtndoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(284, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "N°"
        '
        'cmbglosa
        '
        Me.cmbglosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbglosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbglosa.FormattingEnabled = True
        Me.cmbglosa.Location = New System.Drawing.Point(490, 13)
        Me.cmbglosa.Name = "cmbglosa"
        Me.cmbglosa.Size = New System.Drawing.Size(326, 21)
        Me.cmbglosa.TabIndex = 17
        '
        'cmbdoc
        '
        Me.cmbdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdoc.FormattingEnabled = True
        Me.cmbdoc.Location = New System.Drawing.Point(81, 15)
        Me.cmbdoc.Name = "cmbdoc"
        Me.cmbdoc.Size = New System.Drawing.Size(196, 21)
        Me.cmbdoc.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(453, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Glosa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Documento"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(704, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 26)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Ultima Orden Registrada"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(676, 360)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Sub Total"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkImpuesto
        '
        Me.chkImpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkImpuesto.AutoSize = True
        Me.chkImpuesto.BackColor = System.Drawing.Color.SteelBlue
        Me.chkImpuesto.ForeColor = System.Drawing.Color.Yellow
        Me.chkImpuesto.Location = New System.Drawing.Point(216, 368)
        Me.chkImpuesto.Name = "chkImpuesto"
        Me.chkImpuesto.Size = New System.Drawing.Size(146, 17)
        Me.chkImpuesto.TabIndex = 38
        Me.chkImpuesto.Text = "Exoneración de Impuesto"
        Me.chkImpuesto.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = Global.GUIAbastecimiento.My.Resources.Resources._50
        Me.btnEliminar.Location = New System.Drawing.Point(799, 219)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 36)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.GreenYellow
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(735, 404)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(101, 23)
        Me.lbltotal.TabIndex = 24
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(676, 409)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Total"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtpu)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbforma)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnmaterial)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.lbldescripción)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(15, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 65)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Código"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(112, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripcion"
        '
        'txtpu
        '
        Me.txtpu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpu.Location = New System.Drawing.Point(568, 35)
        Me.txtpu.Name = "txtpu"
        Me.txtpu.Size = New System.Drawing.Size(100, 20)
        Me.txtpu.TabIndex = 12
        Me.txtpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(493, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cantidad"
        '
        'cmbforma
        '
        Me.cmbforma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbforma.FormattingEnabled = True
        Me.cmbforma.Location = New System.Drawing.Point(674, 35)
        Me.cmbforma.Name = "cmbforma"
        Me.cmbforma.Size = New System.Drawing.Size(142, 21)
        Me.cmbforma.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(674, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Forma"
        '
        'btnmaterial
        '
        Me.btnmaterial.Image = Global.GUIAbastecimiento.My.Resources.Resources.b_09
        Me.btnmaterial.Location = New System.Drawing.Point(440, 19)
        Me.btnmaterial.Name = "btnmaterial"
        Me.btnmaterial.Size = New System.Drawing.Size(43, 40)
        Me.btnmaterial.TabIndex = 12
        Me.btnmaterial.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(600, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "P.U."
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(490, 35)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(73, 20)
        Me.txtcantidad.TabIndex = 11
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldescripción
        '
        Me.lbldescripción.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbldescripción.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripción.ForeColor = System.Drawing.Color.Black
        Me.lbldescripción.Location = New System.Drawing.Point(115, 34)
        Me.lbldescripción.Name = "lbldescripción"
        Me.lbldescripción.Size = New System.Drawing.Size(321, 23)
        Me.lbldescripción.TabIndex = 10
        Me.lbldescripción.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.ForeColor = System.Drawing.Color.White
        Me.lblcodigo.Location = New System.Drawing.Point(16, 34)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(93, 23)
        Me.lblcodigo.TabIndex = 7
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnagregar
        '
        Me.btnagregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnagregar.Image = Global.GUIAbastecimiento.My.Resources.Resources._49s
        Me.btnagregar.Location = New System.Drawing.Point(799, 173)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(36, 40)
        Me.btnagregar.TabIndex = 14
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(676, 385)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Imposición"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvwitem
        '
        Me.lvwitem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwitem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwitem.FullRowSelect = True
        Me.lvwitem.GridLines = True
        Me.lvwitem.HideSelection = False
        Me.lvwitem.Location = New System.Drawing.Point(15, 164)
        Me.lvwitem.Name = "lvwitem"
        Me.lvwitem.Size = New System.Drawing.Size(780, 136)
        Me.lvwitem.TabIndex = 28
        Me.lvwitem.UseCompatibleStateImageBehavior = False
        Me.lvwitem.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Material"
        Me.ColumnHeader2.Width = 283
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cod.Unidad"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unidad"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cantidad"
        Me.ColumnHeader5.Width = 99
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "P.U."
        Me.ColumnHeader6.Width = 83
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Subtotal"
        Me.ColumnHeader7.Width = 99
        '
        'lblimpuesto
        '
        Me.lblimpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblimpuesto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblimpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblimpuesto.Location = New System.Drawing.Point(735, 380)
        Me.lblimpuesto.Name = "lblimpuesto"
        Me.lblimpuesto.Size = New System.Drawing.Size(101, 23)
        Me.lblimpuesto.TabIndex = 35
        Me.lblimpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsubtotal.Location = New System.Drawing.Point(735, 356)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(101, 23)
        Me.lblsubtotal.TabIndex = 33
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lblretencion)
        Me.GroupBox4.Controls.Add(Me.lbligv)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(15, 356)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(195, 68)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Imposiciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "I.G.V."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(11, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Retenciones"
        '
        'lblretencion
        '
        Me.lblretencion.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblretencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblretencion.ForeColor = System.Drawing.Color.Black
        Me.lblretencion.Location = New System.Drawing.Point(84, 40)
        Me.lblretencion.Name = "lblretencion"
        Me.lblretencion.Size = New System.Drawing.Size(99, 23)
        Me.lblretencion.TabIndex = 21
        Me.lblretencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbligv
        '
        Me.lbligv.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbligv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbligv.ForeColor = System.Drawing.Color.Black
        Me.lbligv.Location = New System.Drawing.Point(84, 12)
        Me.lbligv.Name = "lbligv"
        Me.lbligv.Size = New System.Drawing.Size(99, 23)
        Me.lbligv.TabIndex = 22
        Me.lbligv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmontoletras
        '
        Me.txtmontoletras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmontoletras.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtmontoletras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmontoletras.ForeColor = System.Drawing.Color.White
        Me.txtmontoletras.Location = New System.Drawing.Point(151, 491)
        Me.txtmontoletras.Name = "txtmontoletras"
        Me.txtmontoletras.ReadOnly = True
        Me.txtmontoletras.Size = New System.Drawing.Size(408, 20)
        Me.txtmontoletras.TabIndex = 70
        '
        'chkvis
        '
        Me.chkvis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkvis.AutoSize = True
        Me.chkvis.Checked = True
        Me.chkvis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkvis.ForeColor = System.Drawing.Color.Yellow
        Me.chkvis.Location = New System.Drawing.Point(12, 493)
        Me.chkvis.Name = "chkvis"
        Me.chkvis.Size = New System.Drawing.Size(111, 17)
        Me.chkvis.TabIndex = 69
        Me.chkvis.Text = "Visualizar Reporte"
        Me.chkvis.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = Global.GUIAbastecimiento.My.Resources.Resources._17
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(565, 470)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 41)
        Me.btnnuevo.TabIndex = 68
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Image = Global.GUIAbastecimiento.My.Resources.Resources._28
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(716, 470)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 41)
        Me.btncancelar.TabIndex = 67
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._07
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(791, 470)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 41)
        Me.btnsalir.TabIndex = 66
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIAbastecimiento.My.Resources.Resources._15
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(640, 470)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 41)
        Me.btngrabar.TabIndex = 65
        Me.btngrabar.Text = "Guardar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'lblimp
        '
        Me.lblimp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblimp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblimp.Location = New System.Drawing.Point(27, 464)
        Me.lblimp.Name = "lblimp"
        Me.lblimp.Size = New System.Drawing.Size(88, 23)
        Me.lblimp.TabIndex = 64
        Me.lblimp.Visible = False
        '
        'chkretencion
        '
        Me.chkretencion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkretencion.AutoSize = True
        Me.chkretencion.BackColor = System.Drawing.Color.SteelBlue
        Me.chkretencion.ForeColor = System.Drawing.Color.Yellow
        Me.chkretencion.Location = New System.Drawing.Point(342, 470)
        Me.chkretencion.Name = "chkretencion"
        Me.chkretencion.Size = New System.Drawing.Size(110, 17)
        Me.chkretencion.TabIndex = 71
        Me.chkretencion.Text = "Aplicar Retencion"
        Me.chkretencion.UseVisualStyleBackColor = False
        '
        'FrmModOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(958, 526)
        Me.Controls.Add(Me.chkretencion)
        Me.Controls.Add(Me.txtmontoletras)
        Me.Controls.Add(Me.chkvis)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.lblimp)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "FrmModOrdenCompra"
        Me.Text = "FrmModOrdenCompra"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblver As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtdoc As System.Windows.Forms.TextBox
    Friend WithEvents lvwDoc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_sunat As System.Windows.Forms.Button
    Friend WithEvents btnprov As System.Windows.Forms.Button
    Friend WithEvents lbldir As System.Windows.Forms.Label
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtndoc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbglosa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbforma As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnmaterial As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbldescripción As System.Windows.Forms.Label
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lvwitem As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblimpuesto As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblretencion As System.Windows.Forms.Label
    Friend WithEvents lbligv As System.Windows.Forms.Label
    Friend WithEvents txtmontoletras As System.Windows.Forms.TextBox
    Friend WithEvents chkvis As System.Windows.Forms.CheckBox
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents lblimp As System.Windows.Forms.Label
    Friend WithEvents lblorden As System.Windows.Forms.TextBox
    Friend WithEvents chkretencion As System.Windows.Forms.CheckBox
End Class
