Imports Datos
Imports Reglas
Public Class FrmBuscarUnidad
    Dim FunDb As New cFuncionesDB
    Private Sub FrmBuscarUnidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub LlenaLstViewunidadunid()
        Dim cSql As String = "select * from t_unidad where descripcion like '%" + Me.txtunidad.Text + "%'  order by descripcion"
        FunDb.FillDataGridView(cSql, dgvUnidad)
    End Sub
    Sub LlenaLstViewunidadabrev()
        Dim cSql As String = "select * from t_unidad where abrev like '%" + Me.txtunidad.Text + "%' order by descripcion "
        FunDb.FillDataGridView(cSql, dgvUnidad)
    End Sub
    Sub HeadGrid()
        With dgvUnidad
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 60
            .Columns(1).HeaderText = "Unidad"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Abrev."
            .Columns(2).Width = 150
        End With
    End Sub

    Private Sub txtunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtunidad.KeyPress

        If Me.rbdescripcion.Checked = True Then
            LlenaLstViewunidadunid()
            HeadGrid()
        ElseIf Me.rbabreviatura.Checked = True Then
            LlenaLstViewunidadunid()
            HeadGrid()
        End If
    End Sub

    Private Sub dgvUnidad_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUnidad.DoubleClick
        If Me.lblflag.Text = 1 Then
            With FrmRegistrarUnidades
                .lblcodunidad.Text = dgvUnidad.Item(0, dgvUnidad.CurrentRow.Index).Value.ToString()
                .lblunidad.Text = dgvUnidad.Item(1, dgvUnidad.CurrentRow.Index).Value.ToString()
                .lblabrev.Text = dgvUnidad.Item(2, dgvUnidad.CurrentRow.Index).Value.ToString()
            End With
        End If
        Me.Close()
    End Sub

  
End Class