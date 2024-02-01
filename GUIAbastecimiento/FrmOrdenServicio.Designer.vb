<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrdenServicio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_sunat = New System.Windows.Forms.Button
        Me.btnprov = New System.Windows.Forms.Button
        Me.lbldir = New System.Windows.Forms.Label
        Me.lblrazon = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblcodpersona = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtndoc = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbglosa = New System.Windows.Forms.ComboBox
        Me.cmbdoc = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkImpuesto = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbligv = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblretencion = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblimpuesto = New System.Windows.Forms.Label
        Me.lblsubtotal = New System.Windows.Forms.Label
        Me.LBLorden = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lvwitems = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtservicio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtvalor = New System.Windows.Forms.TextBox
        Me.lblimp = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lbltipo = New System.Windows.Forms.Label
        Me.btnReserva = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtdoc = New System.Windows.Forms.TextBox
        Me.lvwDoc = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtfecha = New System.Windows.Forms.DateTimePicker
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnagregar = New System.Windows.Forms.Button
        Me.lbltotalf = New System.Windows.Forms.Label
        Me.chkvis = New System.Windows.Forms.CheckBox
        Me.txtmontoletras = New System.Windows.Forms.TextBox
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.btn_sunat)
        Me.GroupBox1.Controls.Add(Me.btnprov)
        Me.GroupBox1.Controls.Add(Me.lbldir)
        Me.GroupBox1.Controls.Add(Me.lblrazon)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblcodpersona)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 70)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Personal"
        '
        'btn_sunat
        '
        Me.btn_sunat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sunat.BackColor = System.Drawing.Color.Chocolate
        Me.btn_sunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sunat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sunat.ForeColor = System.Drawing.Color.White
        Me.btn_sunat.Location = New System.Drawing.Point(497, 41)
        Me.btn_sunat.Name = "btn_sunat"
        Me.btn_sunat.Size = New System.Drawing.Size(36, 23)
        Me.btn_sunat.TabIndex = 67
        Me.btn_sunat.Text = "?"
        Me.btn_sunat.UseVisualStyleBackColor = False
        '
        'btnprov
        '
        Me.btnprov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprov.Image = CType(resources.GetObject("btnprov.Image"), System.Drawing.Image)
        Me.btnprov.Location = New System.Drawing.Point(539, 12)
        Me.btnprov.Name = "btnprov"
        Me.btnprov.Size = New System.Drawing.Size(71, 51)
        Me.btnprov.TabIndex = 186
        Me.btnprov.UseVisualStyleBackColor = True
        '
        'lbldir
        '
        Me.lbldir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldir.ForeColor = System.Drawing.Color.Black
        Me.lbldir.Location = New System.Drawing.Point(113, 40)
        Me.lbldir.Name = "lbldir"
        Me.lbldir.Size = New System.Drawing.Size(143, 23)
        Me.lbldir.TabIndex = 2
        Me.lbldir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblrazon
        '
        Me.lblrazon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblrazon.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblrazon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrazon.ForeColor = System.Drawing.Color.Black
        Me.lblrazon.Location = New System.Drawing.Point(113, 12)
        Me.lblrazon.Name = "lblrazon"
        Me.lblrazon.Size = New System.Drawing.Size(420, 23)
        Me.lblrazon.TabIndex = 1
        Me.lblrazon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblruc
        '
        Me.lblruc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblruc.ForeColor = System.Drawing.Color.Black
        Me.lblruc.Location = New System.Drawing.Point(356, 41)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(138, 23)
        Me.lblruc.TabIndex = 3
        Me.lblruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(297, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "R.U.C."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(60, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "D.N.I."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(15, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Nombre/Razón"
        '
        'lblcodpersona
        '
        Me.lblcodpersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodpersona.Location = New System.Drawing.Point(113, 40)
        Me.lblcodpersona.Name = "lblcodpersona"
        Me.lblcodpersona.Size = New System.Drawing.Size(36, 23)
        Me.lblcodpersona.TabIndex = 58
        Me.lblcodpersona.Visible = False
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(791, 47)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales"
        '
        'txtndoc
        '
        Me.txtndoc.Location = New System.Drawing.Point(319, 18)
        Me.txtndoc.MaxLength = 20
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(141, 20)
        Me.txtndoc.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(297, 21)
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
        Me.cmbglosa.Location = New System.Drawing.Point(506, 18)
        Me.cmbglosa.Name = "cmbglosa"
        Me.cmbglosa.Size = New System.Drawing.Size(279, 21)
        Me.cmbglosa.TabIndex = 9
        '
        'cmbdoc
        '
        Me.cmbdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdoc.FormattingEnabled = True
        Me.cmbdoc.Location = New System.Drawing.Point(81, 18)
        Me.cmbdoc.Name = "cmbdoc"
        Me.cmbdoc.Size = New System.Drawing.Size(210, 21)
        Me.cmbdoc.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(466, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Glosa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Documento"
        '
        'chkImpuesto
        '
        Me.chkImpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkImpuesto.AutoSize = True
        Me.chkImpuesto.ForeColor = System.Drawing.Color.White
        Me.chkImpuesto.Location = New System.Drawing.Point(12, 356)
        Me.chkImpuesto.Name = "chkImpuesto"
        Me.chkImpuesto.Size = New System.Drawing.Size(146, 17)
        Me.chkImpuesto.TabIndex = 10
        Me.chkImpuesto.Text = "Exoneración de Impuesto"
        Me.chkImpuesto.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lbligv)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lblretencion)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(10, 379)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 71)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Imposiciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "I.G.V."
        '
        'lbligv
        '
        Me.lbligv.BackColor = System.Drawing.Color.Moccasin
        Me.lbligv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbligv.ForeColor = System.Drawing.Color.Black
        Me.lbligv.Location = New System.Drawing.Point(83, 39)
        Me.lbligv.Name = "lbligv"
        Me.lbligv.Size = New System.Drawing.Size(83, 23)
        Me.lbligv.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(11, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Retenciones"
        '
        'lblretencion
        '
        Me.lblretencion.BackColor = System.Drawing.Color.Moccasin
        Me.lblretencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblretencion.ForeColor = System.Drawing.Color.Black
        Me.lblretencion.Location = New System.Drawing.Point(83, 14)
        Me.lblretencion.Name = "lblretencion"
        Me.lblretencion.Size = New System.Drawing.Size(83, 23)
        Me.lblretencion.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(624, 356)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Sub Total"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.GreenYellow
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(690, 407)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(113, 23)
        Me.lbltotal.TabIndex = 42
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(624, 412)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Total"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(624, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Imposición"
        '
        'lblimpuesto
        '
        Me.lblimpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblimpuesto.BackColor = System.Drawing.Color.Cornsilk
        Me.lblimpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblimpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimpuesto.Location = New System.Drawing.Point(690, 379)
        Me.lblimpuesto.Name = "lblimpuesto"
        Me.lblimpuesto.Size = New System.Drawing.Size(113, 23)
        Me.lblimpuesto.TabIndex = 45
        Me.lblimpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.BackColor = System.Drawing.Color.Cornsilk
        Me.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(690, 351)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(113, 23)
        Me.lblsubtotal.TabIndex = 44
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLorden
        '
        Me.LBLorden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLorden.BackColor = System.Drawing.Color.GreenYellow
        Me.LBLorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLorden.Location = New System.Drawing.Point(647, 54)
        Me.LBLorden.Name = "LBLorden"
        Me.LBLorden.Size = New System.Drawing.Size(130, 23)
        Me.LBLorden.TabIndex = 47
        Me.LBLorden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(664, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 13)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Ultima Orden Registrada"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvwitems
        '
        Me.lvwitems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwitems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwitems.FullRowSelect = True
        Me.lvwitems.GridLines = True
        Me.lvwitems.HideSelection = False
        Me.lvwitems.Location = New System.Drawing.Point(12, 158)
        Me.lvwitems.Name = "lvwitems"
        Me.lvwitems.Size = New System.Drawing.Size(744, 135)
        Me.lvwitems.TabIndex = 49
        Me.lvwitems.UseCompatibleStateImageBehavior = False
        Me.lvwitems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Detalle"
        Me.ColumnHeader1.Width = 633
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Valor"
        Me.ColumnHeader2.Width = 103
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtservicio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 67)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Servicio"
        '
        'txtservicio
        '
        Me.txtservicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtservicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservicio.Location = New System.Drawing.Point(68, 26)
        Me.txtservicio.Multiline = True
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtservicio.Size = New System.Drawing.Size(514, 35)
        Me.txtservicio.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Servicio"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Valor"
        '
        'txtvalor
        '
        Me.txtvalor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.Location = New System.Drawing.Point(618, 41)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 5
        Me.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblimp
        '
        Me.lblimp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblimp.Location = New System.Drawing.Point(111, 383)
        Me.lblimp.Name = "lblimp"
        Me.lblimp.Size = New System.Drawing.Size(35, 23)
        Me.lblimp.TabIndex = 57
        Me.lblimp.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox5.Controls.Add(Me.lbltipo)
        Me.GroupBox5.Controls.Add(Me.btnReserva)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.txtdoc)
        Me.GroupBox5.Controls.Add(Me.lvwDoc)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.dtfecha)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.chkImpuesto)
        Me.GroupBox5.Controls.Add(Me.lblimpuesto)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.LBLorden)
        Me.GroupBox5.Controls.Add(Me.lblsubtotal)
        Me.GroupBox5.Controls.Add(Me.btnEliminar)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.btnagregar)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.lbltotal)
        Me.GroupBox5.Controls.Add(Me.lvwitems)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.lblimp)
        Me.GroupBox5.Location = New System.Drawing.Point(2, -4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(818, 456)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        '
        'lbltipo
        '
        Me.lbltipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(667, 16)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(0, 13)
        Me.lbltipo.TabIndex = 66
        Me.lbltipo.Visible = False
        '
        'btnReserva
        '
        Me.btnReserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReserva.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserva.Image = Global.GUIAbastecimiento.My.Resources.Resources._37
        Me.btnReserva.Location = New System.Drawing.Point(778, 54)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(28, 23)
        Me.btnReserva.TabIndex = 65
        Me.btnReserva.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(320, 360)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Doc. Adj."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.GUIAbastecimiento.My.Resources.Resources._49s
        Me.Button1.Location = New System.Drawing.Point(587, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 27)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdoc
        '
        Me.txtdoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdoc.Location = New System.Drawing.Point(377, 357)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.Size = New System.Drawing.Size(204, 20)
        Me.txtdoc.TabIndex = 11
        '
        'lvwDoc
        '
        Me.lvwDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwDoc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.lvwDoc.FullRowSelect = True
        Me.lvwDoc.GridLines = True
        Me.lvwDoc.HideSelection = False
        Me.lvwDoc.Location = New System.Drawing.Point(320, 380)
        Me.lvwDoc.Name = "lvwDoc"
        Me.lvwDoc.Size = New System.Drawing.Size(291, 66)
        Me.lvwDoc.TabIndex = 61
        Me.lvwDoc.UseCompatibleStateImageBehavior = False
        Me.lvwDoc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Documento"
        Me.ColumnHeader8.Width = 284
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(192, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Fecha Emisión"
        '
        'dtfecha
        '
        Me.dtfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(195, 411)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(119, 20)
        Me.dtfecha.TabIndex = 58
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = Global.GUIAbastecimiento.My.Resources.Resources._50
        Me.btnEliminar.Location = New System.Drawing.Point(761, 194)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 36)
        Me.btnEliminar.TabIndex = 52
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnagregar.Image = Global.GUIAbastecimiento.My.Resources.Resources._49s
        Me.btnagregar.Location = New System.Drawing.Point(761, 158)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(36, 36)
        Me.btnagregar.TabIndex = 6
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'lbltotalf
        '
        Me.lbltotalf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalf.Location = New System.Drawing.Point(6, 455)
        Me.lbltotalf.Name = "lbltotalf"
        Me.lbltotalf.Size = New System.Drawing.Size(66, 23)
        Me.lbltotalf.TabIndex = 60
        Me.lbltotalf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbltotalf.Visible = False
        '
        'chkvis
        '
        Me.chkvis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkvis.AutoSize = True
        Me.chkvis.Checked = True
        Me.chkvis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkvis.ForeColor = System.Drawing.Color.Yellow
        Me.chkvis.Location = New System.Drawing.Point(2, 481)
        Me.chkvis.Name = "chkvis"
        Me.chkvis.Size = New System.Drawing.Size(111, 17)
        Me.chkvis.TabIndex = 61
        Me.chkvis.Text = "Visualizar Reporte"
        Me.chkvis.UseVisualStyleBackColor = True
        '
        'txtmontoletras
        '
        Me.txtmontoletras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmontoletras.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtmontoletras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmontoletras.ForeColor = System.Drawing.Color.White
        Me.txtmontoletras.Location = New System.Drawing.Point(119, 479)
        Me.txtmontoletras.Name = "txtmontoletras"
        Me.txtmontoletras.ReadOnly = True
        Me.txtmontoletras.Size = New System.Drawing.Size(389, 20)
        Me.txtmontoletras.TabIndex = 62
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = Global.GUIAbastecimiento.My.Resources.Resources._17
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(514, 458)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 41)
        Me.btnnuevo.TabIndex = 56
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Image = Global.GUIAbastecimiento.My.Resources.Resources._28
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(668, 458)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 41)
        Me.btncancelar.TabIndex = 55
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._07
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(745, 458)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 41)
        Me.btnsalir.TabIndex = 54
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIAbastecimiento.My.Resources.Resources._15
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(591, 458)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 41)
        Me.btngrabar.TabIndex = 53
        Me.btngrabar.Text = "Guardar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'FrmOrdenServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(827, 502)
        Me.Controls.Add(Me.txtmontoletras)
        Me.Controls.Add(Me.chkvis)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lbltotalf)
        Me.Controls.Add(Me.btngrabar)
        Me.Name = "FrmOrdenServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Servicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnprov As System.Windows.Forms.Button
    Friend WithEvents lbldir As System.Windows.Forms.Label
    Friend WithEvents lblrazon As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtndoc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbglosa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblretencion As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblimpuesto As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents LBLorden As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lvwitems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents lblimp As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbligv As System.Windows.Forms.Label
    Friend WithEvents lblcodpersona As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtservicio As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalf As System.Windows.Forms.Label
    Friend WithEvents chkvis As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtdoc As System.Windows.Forms.TextBox
    Friend WithEvents lvwDoc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtmontoletras As System.Windows.Forms.TextBox
    Friend WithEvents btnReserva As System.Windows.Forms.Button
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents btn_sunat As System.Windows.Forms.Button
End Class
