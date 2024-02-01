Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmRepOS
    Dim FunDb As New cFuncionesDB
    Dim cos As New Cl_OrdenServicio
    Dim imp As New C_imprime
    Private Sub FrmRepOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gbfech.Visible = False
    End Sub

    Private Sub btnverreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverreporte.Click
        If Me.rbtodas.Checked = True Then
            Dim cr As New Cr_OSTodas
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbpe.Checked = True Then
            Dim cr As New Cr_OrdSerProveedor
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbdoc.Checked = True Then
            Dim cr As New Cr_OSDoc
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbpy.Checked = True Then
            Dim cr As New Cr_OSProyecto
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbfecha.Checked = True Then
            Dim cr As New Cr_OrdenFecha
            cr.DataDefinition.FormulaFields.Item("fechadel").Text = "'" + Me.dtdel.Text + "'"
            cr.DataDefinition.FormulaFields.Item("fechaal").Text = "'" + Me.dtal.Text + "'"
            imp.reporte(cos.REPORTEFECHAS(Me.dtdel.Value.Date, dtal.Value.Date), cr)
        End If
    End Sub
    Private Sub rbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfecha.CheckedChanged
        If Me.rbfecha.Checked = True Then
            Me.gbfech.Visible = True
        Else
            Me.gbfech.Visible = False
        End If
    End Sub
End Class