Imports Reglas
Imports Datos
Public Class FrmExtorno
    Public flg As Integer = 0
    Dim cext As New Cl_Extorno
    Dim cos As New Cl_OrdenServicio
    Dim cod As New Cl_OrdenConpra
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub FrmExtorno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If flg = 1 Then
            Me.lbltransac.Text = "ORDEN DE SERVICIO"
            Me.lbloperacion.Text = Convert.ToString(FrmConsultaOS.dgvDatos.CurrentRow.Cells(0).Value)
            Me.lblmonto.Text = Convert.ToString(FrmConsultaOS.dgvDatos.CurrentRow.Cells(9).Value)
        ElseIf flg = 2 Then
            Me.lbltransac.Text = "ORDEN DE COMPRA"
            Me.lbloperacion.Text = Convert.ToString(FrmConsultaOC.dgvDatos.CurrentRow.Cells(0).Value)
            Me.lblmonto.Text = Convert.ToString(FrmConsultaOC.dgvDatos.CurrentRow.Cells(9).Value)
        End If
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.TextBox1.Text = "" Then
            MessageBox.Show("Debe ingresar un motivo válido para la eliminación", "Extorno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cext.Numero = Me.lbloperacion.Text
            cext.Tipo_transac = Me.lbltransac.Text
            cext.Fecha = CStr(Now.Date)
            cext.Hora = MDIPrincipal.tsbhora.Text
            cext.Motivo = Me.TextBox1.Text
            cext.Usuario = Me.lblusuario.Text
            cext.Admin = Me.lbladmin.Text
            cext.Monto = CDbl(Me.lblmonto.Text)
            If cext.AltaExtorno = True Then
                If flg = 1 Then
                    cos.EliminarOrdenServicio(Me.lbloperacion.Text)
                    FrmConsultaOS.btnver.PerformClick()
                ElseIf flg = 2 Then
                    cod.EliminarOrdenCompra(Me.lbloperacion.Text)
                    FrmConsultaOC.btnver.PerformClick()
                End If
            End If
        End If
        limpiar()
    End Sub
    Sub limpiar()
        Me.lbloperacion.ResetText()
        Me.lbltransac.ResetText()
        Me.lblmonto.ResetText()
        Me.lblusuario.ResetText()
        Me.lbladmin.ResetText()
        Me.TextBox1.ResetText()
    End Sub
End Class