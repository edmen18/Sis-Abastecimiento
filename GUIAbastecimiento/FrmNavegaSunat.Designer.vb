<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNavegaSunat
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
        Me.browser_sunat = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'browser_sunat
        '
        Me.browser_sunat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser_sunat.Location = New System.Drawing.Point(0, 0)
        Me.browser_sunat.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser_sunat.Name = "browser_sunat"
        Me.browser_sunat.Size = New System.Drawing.Size(716, 407)
        Me.browser_sunat.TabIndex = 0
        '
        'FrmNavegaSunat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 407)
        Me.Controls.Add(Me.browser_sunat)
        Me.Name = "FrmNavegaSunat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Ruc"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browser_sunat As System.Windows.Forms.WebBrowser
End Class
