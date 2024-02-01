<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaExtorno
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
        Me.rbusuario = New System.Windows.Forms.RadioButton
        Me.rbfecha = New System.Windows.Forms.RadioButton
        Me.rbtransaccion = New System.Windows.Forms.RadioButton
        Me.rbtodos = New System.Windows.Forms.RadioButton
        Me.btnreporte = New System.Windows.Forms.Button
        Me.cmbusuario = New System.Windows.Forms.ComboBox
        Me.gbusuario = New System.Windows.Forms.GroupBox
        Me.gbfecha = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtal = New System.Windows.Forms.DateTimePicker
        Me.dtdel = New System.Windows.Forms.DateTimePicker
        Me.gbtransaccion = New System.Windows.Forms.GroupBox
        Me.cmbtrans = New System.Windows.Forms.ComboBox
        Me.btnsalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.gbusuario.SuspendLayout()
        Me.gbfecha.SuspendLayout()
        Me.gbtransaccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbusuario)
        Me.GroupBox1.Controls.Add(Me.rbfecha)
        Me.GroupBox1.Controls.Add(Me.rbtransaccion)
        Me.GroupBox1.Controls.Add(Me.rbtodos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 49)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'rbusuario
        '
        Me.rbusuario.AutoSize = True
        Me.rbusuario.Location = New System.Drawing.Point(362, 23)
        Me.rbusuario.Name = "rbusuario"
        Me.rbusuario.Size = New System.Drawing.Size(61, 17)
        Me.rbusuario.TabIndex = 3
        Me.rbusuario.TabStop = True
        Me.rbusuario.Text = "Usuario"
        Me.rbusuario.UseVisualStyleBackColor = True
        '
        'rbfecha
        '
        Me.rbfecha.AutoSize = True
        Me.rbfecha.Location = New System.Drawing.Point(256, 23)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(80, 17)
        Me.rbfecha.TabIndex = 2
        Me.rbfecha.TabStop = True
        Me.rbfecha.Text = "Fecha Elim."
        Me.rbfecha.UseVisualStyleBackColor = True
        '
        'rbtransaccion
        '
        Me.rbtransaccion.AutoSize = True
        Me.rbtransaccion.Location = New System.Drawing.Point(135, 23)
        Me.rbtransaccion.Name = "rbtransaccion"
        Me.rbtransaccion.Size = New System.Drawing.Size(84, 17)
        Me.rbtransaccion.TabIndex = 1
        Me.rbtransaccion.TabStop = True
        Me.rbtransaccion.Text = "Transacción"
        Me.rbtransaccion.UseVisualStyleBackColor = True
        '
        'rbtodos
        '
        Me.rbtodos.AutoSize = True
        Me.rbtodos.Location = New System.Drawing.Point(30, 23)
        Me.rbtodos.Name = "rbtodos"
        Me.rbtodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtodos.TabIndex = 0
        Me.rbtodos.TabStop = True
        Me.rbtodos.Text = "Todos"
        Me.rbtodos.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnreporte.Image = Global.GUIAbastecimiento.My.Resources.Resources._33
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnreporte.Location = New System.Drawing.Point(296, 130)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(85, 42)
        Me.btnreporte.TabIndex = 16
        Me.btnreporte.Text = "Ver Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbusuario
        '
        Me.cmbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Location = New System.Drawing.Point(26, 19)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(414, 21)
        Me.cmbusuario.TabIndex = 17
        '
        'gbusuario
        '
        Me.gbusuario.Controls.Add(Me.cmbusuario)
        Me.gbusuario.Location = New System.Drawing.Point(16, 67)
        Me.gbusuario.Name = "gbusuario"
        Me.gbusuario.Size = New System.Drawing.Size(446, 60)
        Me.gbusuario.TabIndex = 18
        Me.gbusuario.TabStop = False
        Me.gbusuario.Text = "Usuario"
        '
        'gbfecha
        '
        Me.gbfecha.Controls.Add(Me.Label2)
        Me.gbfecha.Controls.Add(Me.Label1)
        Me.gbfecha.Controls.Add(Me.dtal)
        Me.gbfecha.Controls.Add(Me.dtdel)
        Me.gbfecha.Location = New System.Drawing.Point(17, 73)
        Me.gbfecha.Name = "gbfecha"
        Me.gbfecha.Size = New System.Drawing.Size(444, 52)
        Me.gbfecha.TabIndex = 19
        Me.gbfecha.TabStop = False
        Me.gbfecha.Text = "Fecha de Eliminación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Del"
        '
        'dtal
        '
        Me.dtal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtal.Location = New System.Drawing.Point(290, 26)
        Me.dtal.Name = "dtal"
        Me.dtal.Size = New System.Drawing.Size(128, 20)
        Me.dtal.TabIndex = 1
        '
        'dtdel
        '
        Me.dtdel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdel.Location = New System.Drawing.Point(70, 24)
        Me.dtdel.Name = "dtdel"
        Me.dtdel.Size = New System.Drawing.Size(110, 20)
        Me.dtdel.TabIndex = 0
        '
        'gbtransaccion
        '
        Me.gbtransaccion.Controls.Add(Me.cmbtrans)
        Me.gbtransaccion.Location = New System.Drawing.Point(19, 69)
        Me.gbtransaccion.Name = "gbtransaccion"
        Me.gbtransaccion.Size = New System.Drawing.Size(441, 55)
        Me.gbtransaccion.TabIndex = 20
        Me.gbtransaccion.TabStop = False
        Me.gbtransaccion.Text = "Transacción"
        '
        'cmbtrans
        '
        Me.cmbtrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtrans.FormattingEnabled = True
        Me.cmbtrans.Items.AddRange(New Object() {"ORDEN DE COMPRA", "ORDEN DE SERVICIO"})
        Me.cmbtrans.Location = New System.Drawing.Point(21, 19)
        Me.cmbtrans.Name = "cmbtrans"
        Me.cmbtrans.Size = New System.Drawing.Size(414, 21)
        Me.cmbtrans.TabIndex = 18
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIAbastecimiento.My.Resources.Resources._07
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(387, 130)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 41)
        Me.btnsalir.TabIndex = 55
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'FrmConsultaExtorno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(494, 178)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.gbtransaccion)
        Me.Controls.Add(Me.gbfecha)
        Me.Controls.Add(Me.gbusuario)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaExtorno"
        Me.Text = "FrmConsultaExtorno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbusuario.ResumeLayout(False)
        Me.gbfecha.ResumeLayout(False)
        Me.gbfecha.PerformLayout()
        Me.gbtransaccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbusuario As System.Windows.Forms.RadioButton
    Friend WithEvents rbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbtransaccion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents gbusuario As System.Windows.Forms.GroupBox
    Friend WithEvents gbfecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdel As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbtransaccion As System.Windows.Forms.GroupBox
    Friend WithEvents cmbtrans As System.Windows.Forms.ComboBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
