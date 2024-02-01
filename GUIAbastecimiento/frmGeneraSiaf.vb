Imports Datos

Public Class frmGeneraSiaf
    Dim Fundb As New cFuncionesDB
    Private Sub frmGeneraSiaf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LLenaGridSiaf()
    End Sub

    Sub LLenaGridSiaf()
        Try
            Dim sql As String = "SELECT do.Numero, do.Descripcion, convert(char(10),o.FECHA,103) as Fecha,do.Valor FROM T_ORDEN_SERVICIO o INNER JOIN T_DETALLE_ORDEN_SERVICIO do ON o.numero = do.numero where  fecha >= '" + Me.dtpFecIni.Value.Date + "' and fecha<='" + Me.dtpFecFin.Value.Date + "' AND o.ESTADO='A' order by fecha"
            Fundb.FillDataGridView(sql, dgvDatosSiaf)
        Catch ex As Exception
            MessageBox.Show("No hay resultados para esta consulta", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        LLenaGridSiaf()
        HeadGrid()
    End Sub

    Sub HeadGrid()
        With dgvDatosSiaf
            .Columns(0).HeaderText = "Numero"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Concepto"
            .Columns(1).Width = (dgvDatosSiaf.Width) - (.Columns(0).Width + .Columns(2).Width + .Columns(3).Width)
            .Columns(2).HeaderText = "Fecha"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "Valor"
            .Columns(3).Width = 120
        End With
    End Sub

End Class