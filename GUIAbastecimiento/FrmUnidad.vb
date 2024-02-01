Imports Datos
Imports Reglas
Public Class FrmUnidad
    Dim FunDb As New cFuncionesDB
    Dim FLG As Integer = 0
    Dim cunidad As New Cl_Unidad
    Private Sub FrmUnidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewConvenios()
        HeadGrid()
    End Sub
    Sub LlenaLstViewConvenios()
        Dim cSql As String = "select cod_unidad,descripcion,abrev from t_unidad"
        FunDb.FillDataGridView(cSql, dgvUnidad)
    End Sub
    Sub HeadGrid()
        With dgvUnidad
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Unidad"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Abreviatura"
            .Columns(2).Width = 150
        End With
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.lblcodigo.Text = Format(CInt(cunidad.GeneraCodUnidad()) + 1, "0000000000")
        FLG = 0
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.FLG = 0 Then
            If Me.lblcodigo.Text <> "" Or Me.txtunidad.Text <> "" Or Me.txtabreviatura.Text <> "" Then
                cunidad.CodUnidad = Me.lblcodigo.Text
                cunidad.Descripcion = Me.txtunidad.Text
                cunidad.Abreviatura = Me.txtabreviatura.Text
                cunidad.Altaunidad()
            Else
                MessageBox.Show("Complete los datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf FLG = 1 Then
            cunidad.UpdateUnidad(Me.lblcodigo.Text, Me.txtunidad.Text, Me.txtabreviatura.Text)
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewConvenios()
        HeadGrid()
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lblcodigo.ResetText()
        Me.txtunidad.ResetText()
        Me.txtabreviatura.ResetText()
        Me.btnnuevo.Enabled = True
        FLG = 0
    End Sub
    Private Sub dgvUnidad_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUnidad.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.dgvUnidad.CurrentRow.Cells(0).Value)
        Me.txtunidad.Text = Convert.ToString(Me.dgvUnidad.CurrentRow.Cells(1).Value)
        Me.txtabreviatura.Text = Convert.ToString(Me.dgvUnidad.CurrentRow.Cells(2).Value)
        FLG = 1
        Me.btnnuevo.Enabled = False
    End Sub

    Private Sub txtunidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunidad.TextChanged
        txtunidad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtabreviatura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtabreviatura.TextChanged
        Me.txtabreviatura.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class