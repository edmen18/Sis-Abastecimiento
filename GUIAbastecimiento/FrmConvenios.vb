Imports Datos
Imports Reglas
Public Class FrmConvenios
    Dim FunDb As New cFuncionesDB
    Dim clconvenio As New Cl_Convenio
    Dim FLG As Integer = 0

    Private Sub FrmConvenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewConvenios()
        HeadGrid()
    End Sub
    Sub LlenaLstViewConvenios()
        Dim cSql As String = "select * from t_convenios order by DESCRIPCION"
        FunDb.FillDataGridView(cSql, dgvConvenios)
    End Sub
    Sub LlenaLstViewConveniosO()
        Dim cSql As String = "select * from t_convenios where DESCRIPCION like '%" + Me.txttexto.Text + "%' order by DESCRIPCION"
        FunDb.FillDataGridView(cSql, dgvConvenios)
    End Sub
    Sub HeadGrid()
        With dgvConvenios
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 200
            .Columns(1).HeaderText = "Convenio"
            .Columns(1).Width = 800
        End With
    End Sub
    Private Sub dgvConvenios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvConvenios.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.dgvConvenios.CurrentRow.Cells(0).Value)
        Me.txtconvenio.Text = Convert.ToString(Me.dgvConvenios.CurrentRow.Cells(1).Value)
        FLG = 1
        Me.btnnuevo.Enabled = False
        LlenaLstViewConvenios()
        Me.txttexto.ResetText()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.lblcodigo.Text = Format(CInt(clconvenio.GeneraCodConvenio()) + 1, "0000000000")
        FLG = 0
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.FLG = 0 Then
            If Me.lblcodigo.Text <> "" And Me.txtconvenio.Text <> "" Then
                clconvenio.Codigo = Me.lblcodigo.Text
                clconvenio.Descripcion = Me.txtconvenio.Text
                clconvenio.AltaConvenio()
            Else
                MessageBox.Show("Los datos no se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf FLG = 1 Then
            clconvenio.UpdateConvenio(Me.lblcodigo.Text, Me.txtconvenio.Text)
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewConvenios()
        Me.btncancelar.PerformClick()
    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lblcodigo.ResetText()
        Me.txtconvenio.ResetText()
        Me.tsbtnnuevo.Enabled = True
        FLG = 0
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtconvenio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconvenio.KeyPress
        If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtconvenio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconvenio.TextChanged
        Me.txtconvenio.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txttexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttexto.TextChanged
        LlenaLstViewConveniosO()
    End Sub
End Class
