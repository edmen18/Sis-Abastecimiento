<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepExt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepExt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbusuario = New System.Windows.Forms.RadioButton
        Me.rbtransaccion = New System.Windows.Forms.RadioButton
        Me.rbtodos = New System.Windows.Forms.RadioButton
        Me.btnreporte = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbusuario)
        Me.GroupBox1.Controls.Add(Me.rbtransaccion)
        Me.GroupBox1.Controls.Add(Me.rbtodos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'rbusuario
        '
        Me.rbusuario.AutoSize = True
        Me.rbusuario.Location = New System.Drawing.Point(30, 73)
        Me.rbusuario.Name = "rbusuario"
        Me.rbusuario.Size = New System.Drawing.Size(61, 17)
        Me.rbusuario.TabIndex = 3
        Me.rbusuario.TabStop = True
        Me.rbusuario.Text = "Usuario"
        Me.rbusuario.UseVisualStyleBackColor = True
        '
        'rbtransaccion
        '
        Me.rbtransaccion.AutoSize = True
        Me.rbtransaccion.Location = New System.Drawing.Point(30, 46)
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
        Me.btnreporte.Image = CType(resources.GetObject("btnreporte.Image"), System.Drawing.Image)
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnreporte.Location = New System.Drawing.Point(169, 35)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(69, 69)
        Me.btnreporte.TabIndex = 17
        Me.btnreporte.Text = "Ver Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'FrmRepExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(250, 129)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepExt"
        Me.Text = "Reportes de Extornos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbusuario As System.Windows.Forms.RadioButton
    Friend WithEvents rbtransaccion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnreporte As System.Windows.Forms.Button
End Class
