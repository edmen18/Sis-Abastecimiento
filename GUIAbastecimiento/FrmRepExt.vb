Imports Reglas
Imports Reportes
Public Class FrmRepExt
    Dim cimp As New C_imprime
    Dim cext As New Cl_Extorno
    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        If Me.rbtodos.Checked = True Then
            Dim cr As New Cr_Extorno
            cimp.reporte(cext.ImprimeTodos(), cr)
        ElseIf Me.rbtransaccion.Checked = True Then
            Dim cr As New Cr_ExtTransaccion
            cimp.reporte(cext.ImprimeTodos(), cr)
        ElseIf Me.rbusuario.Checked = True Then
            Dim cr As New Cr_ExtTransac
            cimp.reporte(cext.ImprimeTodos(), cr)
        End If
    End Sub
End Class