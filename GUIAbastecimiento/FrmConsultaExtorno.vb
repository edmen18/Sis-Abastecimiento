Imports Reglas
Imports Reportes
Imports Datos
Public Class FrmConsultaExtorno
    Dim cext As New Cl_Extorno
    Dim cimp As New C_imprime
    Dim FunDB As New cFuncionesDB
    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        If Me.rbtodos.Checked = True Then
            Dim cr As New Cr_Extorno
            cimp.reporte(cext.ImprimeTodos(), cr)
        ElseIf Me.rbusuario.Checked = True Then
            Dim cru As New Cr_ExtTransac
            cimp.reporte(cext.ImprimeUsuarios(Me.cmbusuario.Text), cru)
        ElseIf Me.rbfecha.Checked = True Then
            Dim crf As New Cr_ExtFecha
            crf.DataDefinition.FormulaFields.Item("fechadel").Text = "'" + Me.dtdel.Text + "'"
            crf.DataDefinition.FormulaFields.Item("fechaal").Text = "'" + Me.dtal.Text + "'"
            cimp.reporte(cext.Imprimefechas(Me.dtdel.Value.Date, dtal.Value.Date), crf)
        ElseIf Me.rbtransaccion.Checked = True Then
            Dim crt As New Cr_ExtTransaccion
            cimp.reporte(cext.ImprimeTrans(cmbtrans.Text), crt)
        End If
    End Sub

    Private Sub FrmConsultaExtorno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbusuario.Visible = False
        gbfecha.Visible = False
        gbtransaccion.Visible = False
        LLenarComboUsuario()
    End Sub
    Sub LLenarComboUsuario()
        Dim csql As String = "select dni+' '+nombres+' '+apellidos as usuario from t_usuarios "
        FunDB.FillListaOrCombo(csql, cmbusuario, "usuario", "usuario")
    End Sub

    Private Sub rbtodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtodos.CheckedChanged
        If rbtodos.Checked = True Then
            gbusuario.Visible = False
            Me.gbfecha.Visible = False
            gbtransaccion.Visible = False
        End If
    End Sub

    Private Sub rbusuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbusuario.CheckedChanged
        If rbusuario.Checked = True Then
            gbusuario.Visible = True
            gbfecha.Visible = False
            gbtransaccion.Visible = False
        End If
    End Sub

    Private Sub rbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfecha.CheckedChanged
        If Me.rbfecha.Checked = True Then
            Me.gbfecha.Visible = True
            Me.gbusuario.Visible = False
            gbtransaccion.Visible = False
        End If
    End Sub

    Private Sub rbtransaccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtransaccion.CheckedChanged
        If Me.rbtransaccion.Checked = True Then
            Me.gbfecha.Visible = False
            Me.gbusuario.Visible = False
            gbtransaccion.Visible = True
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class