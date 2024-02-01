Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmRepOC
    Dim FunDb As New cFuncionesDB
    Dim cos As New Cl_OrdenConpra
    Dim imp As New C_imprime
    Private Sub btnverreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverreporte.Click
        If Me.rbtodas.Checked = True Then
            Dim cr As New Cr_OCtodas
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbpe.Checked = True Then
            Dim cr As New Cr_OrdenesProveedor
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbdoc.Checked = True Then
            Dim cr As New Cr_OrdenesDoc
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbpy.Checked = True Then
            Dim cr As New Cr_OrdenesProyecto
            imp.reporte(cos.REPORTEtodas(), cr)
        ElseIf Me.rbfecha.Checked = True Then
            Dim cr As New CrOrdenesFecha
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

    Private Sub FrmRepOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gbfech.Visible = False
    End Sub
End Class