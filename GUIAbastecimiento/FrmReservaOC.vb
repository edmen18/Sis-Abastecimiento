Imports Datos
Imports Reglas
Public Class FrmReservaOC
    Dim Fundb As New cFuncionesDB
    Dim ReservaOC As New Cl_Control
    Dim flg As Byte

    Sub LLenaGrid()
        Dim sql As String = "SELECT n_oc, estado FROM T_CONTROL_OC  where ESTADO='R' ORDER BY n_oc"
        Me.dgvReserva.Columns.Clear()
        Fundb.FillDataGridView(sql, dgvReserva)
    End Sub

    Private Sub FrmReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaOrden()
    End Sub

    Sub ActualizaOrden()
        Me.lblOrden.Text = Format(CInt(ReservaOC.GetUltimaOC()), "0000000000")
        Me.nroreserva.Minimum = CInt(lblOrden.Text) + 1
        Me.nroreserva.Value = CInt(lblOrden.Text) + 1
        Me.nroreserva.Maximum = CInt(lblOrden.Text) + 10
    End Sub


    Private Sub btnReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReserva.Click
        flg = 0
        Dim inicio As Integer
        inicio = CInt(lblOrden.Text) + 1

        Me.dgvReserva.DataSource = Nothing
        Me.dgvReserva.Rows.Clear()
        Me.dgvReserva.Columns.Clear()
        Me.dgvReserva.Columns.Add("num", "Numero")

        For i = inicio To nroreserva.Value
            Me.dgvReserva.Rows.Add(Format(i, "0000000000"))
        Next
        btnAceptar.Enabled = True
    End Sub

    Private Sub btngetReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetReserva.Click
        flg = 1
        LLenaGrid()
        btnAceptar.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        FrmOrdenCompra.btnnuevo.PerformClick()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If MessageBox.Show("Seguro que desea reservar las Ordenes de la Lista", "SAB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For i = 0 To dgvReserva.Rows.Count - 1
                ReservaOC.Num_oc = dgvReserva.Rows(i).Cells(0).Value
                ReservaOC.Estado_OC = "R"
                ReservaOC.RegistraOC()
            Next
            MessageBox.Show("Reserva satisfactoria", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LLenaGrid()
            ActualizaOrden()
        End If
    End Sub

    Private Sub dgvReserva_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvReserva.DoubleClick
        If flg = 1 Then
            FrmOrdenCompra.lbltipo.Text = "R"
            FrmOrdenCompra.LBLorden.Text = Convert.ToString(Me.dgvReserva.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub
End Class