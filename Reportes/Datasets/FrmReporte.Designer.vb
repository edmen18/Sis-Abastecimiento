﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporte
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
        Me.CrvwReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvwReporte
        '
        Me.CrvwReporte.ActiveViewIndex = -1
        Me.CrvwReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvwReporte.DisplayGroupTree = False
        Me.CrvwReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvwReporte.Location = New System.Drawing.Point(0, 0)
        Me.CrvwReporte.Name = "CrvwReporte"
        Me.CrvwReporte.SelectionFormula = ""
        Me.CrvwReporte.Size = New System.Drawing.Size(520, 370)
        Me.CrvwReporte.TabIndex = 0
        Me.CrvwReporte.ViewTimeSelectionFormula = ""
        '
        'FrmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 370)
        Me.Controls.Add(Me.CrvwReporte)
        Me.Name = "FrmReporte"
        Me.Text = "Informes SAB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvwReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
