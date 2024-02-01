<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepOS
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
        Me.rbpe = New System.Windows.Forms.RadioButton
        Me.rbfecha = New System.Windows.Forms.RadioButton
        Me.rbpy = New System.Windows.Forms.RadioButton
        Me.rbdoc = New System.Windows.Forms.RadioButton
        Me.rbtodas = New System.Windows.Forms.RadioButton
        Me.btnverreporte = New System.Windows.Forms.Button
        Me.gbfech = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtal = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtdel = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.gbfech.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbpe)
        Me.GroupBox1.Controls.Add(Me.rbfecha)
        Me.GroupBox1.Controls.Add(Me.rbpy)
        Me.GroupBox1.Controls.Add(Me.rbdoc)
        Me.GroupBox1.Controls.Add(Me.rbtodas)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 195)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Todas las Ordenes de Servicios por:"
        '
        'rbpe
        '
        Me.rbpe.AutoSize = True
        Me.rbpe.Location = New System.Drawing.Point(15, 55)
        Me.rbpe.Name = "rbpe"
        Me.rbpe.Size = New System.Drawing.Size(122, 17)
        Me.rbpe.TabIndex = 4
        Me.rbpe.TabStop = True
        Me.rbpe.Text = "Por Persona-Entidad"
        Me.rbpe.UseVisualStyleBackColor = True
        '
        'rbfecha
        '
        Me.rbfecha.AutoSize = True
        Me.rbfecha.Location = New System.Drawing.Point(15, 138)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(74, 17)
        Me.rbfecha.TabIndex = 3
        Me.rbfecha.TabStop = True
        Me.rbfecha.Text = "Por Fecha"
        Me.rbfecha.UseVisualStyleBackColor = True
        '
        'rbpy
        '
        Me.rbpy.AutoSize = True
        Me.rbpy.Location = New System.Drawing.Point(15, 109)
        Me.rbpy.Name = "rbpy"
        Me.rbpy.Size = New System.Drawing.Size(86, 17)
        Me.rbpy.TabIndex = 2
        Me.rbpy.TabStop = True
        Me.rbpy.Text = "Por Proyecto"
        Me.rbpy.UseVisualStyleBackColor = True
        '
        'rbdoc
        '
        Me.rbdoc.AutoSize = True
        Me.rbdoc.Location = New System.Drawing.Point(17, 82)
        Me.rbdoc.Name = "rbdoc"
        Me.rbdoc.Size = New System.Drawing.Size(97, 17)
        Me.rbdoc.TabIndex = 1
        Me.rbdoc.TabStop = True
        Me.rbdoc.Text = "Por documento"
        Me.rbdoc.UseVisualStyleBackColor = True
        '
        'rbtodas
        '
        Me.rbtodas.AutoSize = True
        Me.rbtodas.Location = New System.Drawing.Point(15, 30)
        Me.rbtodas.Name = "rbtodas"
        Me.rbtodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtodas.TabIndex = 0
        Me.rbtodas.TabStop = True
        Me.rbtodas.Text = "Todas"
        Me.rbtodas.UseVisualStyleBackColor = True
        '
        'btnverreporte
        '
        Me.btnverreporte.Image = Global.GUIAbastecimiento.My.Resources.Resources._33
        Me.btnverreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnverreporte.Location = New System.Drawing.Point(267, 42)
        Me.btnverreporte.Name = "btnverreporte"
        Me.btnverreporte.Size = New System.Drawing.Size(75, 56)
        Me.btnverreporte.TabIndex = 2
        Me.btnverreporte.Text = "Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Reporte"
        Me.btnverreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnverreporte.UseVisualStyleBackColor = True
        '
        'gbfech
        '
        Me.gbfech.Controls.Add(Me.Label2)
        Me.gbfech.Controls.Add(Me.dtal)
        Me.gbfech.Controls.Add(Me.Label1)
        Me.gbfech.Controls.Add(Me.dtdel)
        Me.gbfech.Location = New System.Drawing.Point(223, 114)
        Me.gbfech.Name = "gbfech"
        Me.gbfech.Size = New System.Drawing.Size(119, 93)
        Me.gbfech.TabIndex = 3
        Me.gbfech.TabStop = False
        Me.gbfech.Text = "Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Al"
        '
        'dtal
        '
        Me.dtal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtal.Location = New System.Drawing.Point(6, 64)
        Me.dtal.Name = "dtal"
        Me.dtal.Size = New System.Drawing.Size(101, 20)
        Me.dtal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Del"
        '
        'dtdel
        '
        Me.dtdel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdel.Location = New System.Drawing.Point(8, 27)
        Me.dtdel.Name = "dtdel"
        Me.dtdel.Size = New System.Drawing.Size(100, 20)
        Me.dtdel.TabIndex = 0
        '
        'FrmRepOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(356, 219)
        Me.Controls.Add(Me.gbfech)
        Me.Controls.Add(Me.btnverreporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRepOS"
        Me.Text = "Reportes Órdenes de Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbfech.ResumeLayout(False)
        Me.gbfech.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbpy As System.Windows.Forms.RadioButton
    Friend WithEvents rbdoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtodas As System.Windows.Forms.RadioButton
    Friend WithEvents rbpe As System.Windows.Forms.RadioButton
    Friend WithEvents btnverreporte As System.Windows.Forms.Button
    Friend WithEvents gbfech As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtdel As System.Windows.Forms.DateTimePicker
End Class
