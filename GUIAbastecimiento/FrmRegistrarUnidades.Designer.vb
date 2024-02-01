<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarUnidades))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblmaterial = New System.Windows.Forms.Label
        Me.lblcodmaterial = New System.Windows.Forms.Label
        Me.lvwunidades = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblabrev = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblunidad = New System.Windows.Forms.Label
        Me.lblcodunidad = New System.Windows.Forms.Label
        Me.btnagregar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblmaterial)
        Me.GroupBox2.Controls.Add(Me.lblcodmaterial)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 65)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Material"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Item"
        '
        'lblmaterial
        '
        Me.lblmaterial.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblmaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaterial.Location = New System.Drawing.Point(107, 33)
        Me.lblmaterial.Name = "lblmaterial"
        Me.lblmaterial.Size = New System.Drawing.Size(387, 23)
        Me.lblmaterial.TabIndex = 5
        Me.lblmaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodmaterial
        '
        Me.lblcodmaterial.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblcodmaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodmaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodmaterial.Location = New System.Drawing.Point(6, 33)
        Me.lblcodmaterial.Name = "lblcodmaterial"
        Me.lblcodmaterial.Size = New System.Drawing.Size(95, 23)
        Me.lblcodmaterial.TabIndex = 4
        Me.lblcodmaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvwunidades
        '
        Me.lvwunidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwunidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwunidades.FullRowSelect = True
        Me.lvwunidades.GridLines = True
        Me.lvwunidades.HideSelection = False
        Me.lvwunidades.Location = New System.Drawing.Point(14, 154)
        Me.lvwunidades.Name = "lvwunidades"
        Me.lvwunidades.Size = New System.Drawing.Size(465, 137)
        Me.lvwunidades.TabIndex = 13
        Me.lvwunidades.UseCompatibleStateImageBehavior = False
        Me.lvwunidades.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 118
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Unidad"
        Me.ColumnHeader2.Width = 229
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Abreviatura"
        Me.ColumnHeader3.Width = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblabrev)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblunidad)
        Me.GroupBox1.Controls.Add(Me.lblcodunidad)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 65)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Unidad"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(455, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(391, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Abrev."
        '
        'lblabrev
        '
        Me.lblabrev.BackColor = System.Drawing.Color.OldLace
        Me.lblabrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblabrev.Location = New System.Drawing.Point(386, 33)
        Me.lblabrev.Name = "lblabrev"
        Me.lblabrev.Size = New System.Drawing.Size(64, 23)
        Me.lblabrev.TabIndex = 8
        Me.lblabrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Unidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código"
        '
        'lblunidad
        '
        Me.lblunidad.BackColor = System.Drawing.Color.OldLace
        Me.lblunidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblunidad.Location = New System.Drawing.Point(104, 33)
        Me.lblunidad.Name = "lblunidad"
        Me.lblunidad.Size = New System.Drawing.Size(279, 23)
        Me.lblunidad.TabIndex = 5
        Me.lblunidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodunidad
        '
        Me.lblcodunidad.BackColor = System.Drawing.Color.OldLace
        Me.lblcodunidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodunidad.Location = New System.Drawing.Point(6, 33)
        Me.lblcodunidad.Name = "lblcodunidad"
        Me.lblcodunidad.Size = New System.Drawing.Size(95, 23)
        Me.lblcodunidad.TabIndex = 4
        Me.lblcodunidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnagregar
        '
        Me.btnagregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnagregar.Image = Global.GUIAbastecimiento.My.Resources.Resources._49s
        Me.btnagregar.Location = New System.Drawing.Point(485, 154)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(33, 37)
        Me.btnagregar.TabIndex = 11
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Image = Global.GUIAbastecimiento.My.Resources.Resources._28
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(368, 297)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 41)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._07
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(443, 297)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 41)
        Me.btnsalir.TabIndex = 17
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIAbastecimiento.My.Resources.Resources._15
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(292, 297)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 41)
        Me.btngrabar.TabIndex = 16
        Me.btngrabar.Text = "Guardar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneliminar.Image = Global.GUIAbastecimiento.My.Resources.Resources._50
        Me.btneliminar.Location = New System.Drawing.Point(485, 190)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(33, 37)
        Me.btneliminar.TabIndex = 19
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'FrmRegistrarUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(534, 340)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvwunidades)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistrarUnidades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Unidades"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblmaterial As System.Windows.Forms.Label
    Friend WithEvents lblcodmaterial As System.Windows.Forms.Label
    Friend WithEvents lvwunidades As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblunidad As System.Windows.Forms.Label
    Friend WithEvents lblcodunidad As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblabrev As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
End Class
