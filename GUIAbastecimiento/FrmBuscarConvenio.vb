Imports Datos
Imports Reglas
Public Class FrmBuscarConvenio
    Dim FunDb As New cFuncionesDB

    Private Sub FrmBuscarConvenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
   
    Sub LlenaLstViewConvenios()
        Dim cSql As String = "select * from t_convenios where descripcion like '%" + Me.txtconvenio.Text + "%' order by descripcion "
        FunDb.FillDataGridView(cSql, dgvconvenios)
    End Sub
    Sub HeadGrid()
        With dgvConvenios
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 60
            .Columns(1).HeaderText = "Convenio"
            .Columns(1).Width = 300
        End With
    End Sub


    Private Sub txtconvenio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtconvenio.DoubleClick
        LlenaLstViewConvenios()
        HeadGrid()
    End Sub

    Private Sub dgvconvenios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvconvenios.DoubleClick
        If Me.lblflag.Text = "1" Then
            With FrmMaterial
                .lblcodconv.Text = dgvconvenios.Item(0, dgvconvenios.CurrentRow.Index).Value.ToString()
                .lblconvenio.Text = dgvconvenios.Item(1, dgvconvenios.CurrentRow.Index).Value.ToString()
            End With
        End If
        Me.Close()
    End Sub

    Private Sub txtconvenio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconvenio.KeyPress

        If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtconvenio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconvenio.TextChanged
        LlenaLstViewConvenios()
    End Sub
End Class