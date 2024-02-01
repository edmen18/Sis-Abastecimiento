Imports Datos
Imports Reglas
Public Class FrmImpuestos
    Dim FunDb As New cFuncionesDB
    Dim cimp As New Cl_impuestos
    Dim FLG As Integer = 0
    Dim contador As Integer = 0

    Private Sub FrmImpuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewConvenios()
        HeadGrid()
        Me.GroupBox1.Enabled = False
    End Sub
    Sub LlenaLstViewConvenios()
        Dim cSql As String = "select cod_impuesto,descripcion,porcentaje,annio from t_IMPUESTO WHERE ANNIO=YEAR(GETDATE()) "
        FunDb.FillDataGridView(cSql, DGVimpuestos)
    End Sub
    Sub HeadGrid()
        With DGVimpuestos
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "Descripción"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Porcentaje"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "Año"
            .Columns(3).Width = 100
        End With
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.lblcodigo.Text = cimp.GeneraCodIMPUESTO()
        FLG = 0
        Me.GroupBox1.Enabled = True

    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        cimp.CodiMPUESTO = Me.lblcodigo.Text
        cimp.Descripcion = Me.cmbdesc.Text
        cimp.Porcentaje = Me.txtporc.Text
        If Me.FLG = 0 Then
            If Me.lblcodigo.Text <> "" And Me.txtporc.Text <> "" Then
                evaluar()
                If contador = 0 Then
                    cimp.AltaImpuesto()
                Else
                    MessageBox.Show("Este Impuesto ya esta dado de alta para el presente año ..... si desea modificarlo seleccionelo de la lista", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Los datos no se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf FLG = 1 Then
            cimp.UpdateImpuesto()
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewConvenios()
        Me.btncancelar.PerformClick()
    End Sub
    Sub evaluar()
        For i = 0 To Me.DGVimpuestos.Rows.Count - 1
            If Me.cmbdesc.Text = Convert.ToString(Me.DGVimpuestos.Item(1, i).Value) And CStr(Now.Year) = Convert.ToString(Me.DGVimpuestos.Item(3, i).Value) Then
                contador = contador + 1
            End If
        Next
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lblcodigo.ResetText()
        Me.txtporc.ResetText()
        Me.cmbdesc.Text = ""
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub DGVimpuestos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVimpuestos.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.DGVimpuestos.CurrentRow.Cells(0).Value)
        Me.cmbdesc.Text = Convert.ToString(Me.DGVimpuestos.CurrentRow.Cells(1).Value)
        Me.txtporc.Text = Convert.ToString(Me.DGVimpuestos.CurrentRow.Cells(2).Value)
        FLG = 1
        Me.btnnuevo.Enabled = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtporc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtporc.KeyPress
        If SoloNumerosD(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
End Class