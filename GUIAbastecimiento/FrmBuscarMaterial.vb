Imports Datos
Imports Reglas
Public Class FrmBuscarMaterial
    Dim FunDb As New cFuncionesDB
    Private Sub FrmBuscarMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub LlenaLstViewConvenios()
        Dim cSql As String = "select * from t_material where descripcon like '%" + Me.txtmaterial.Text + "%'  order by descripcon"
        FunDb.FillDataGridView(cSql, dgvmaterial)
    End Sub
    Sub HeadGrid()
        With dgvmaterial
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 60
            .Columns(1).HeaderText = "Material"
            .Columns(1).Width = 300
        End With
    End Sub

    Private Sub txtmaterial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaterial.KeyPress

        If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmaterial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaterial.TextChanged
        Me.txtmaterial.CharacterCasing = CharacterCasing.Upper
        LlenaLstViewConvenios()
        HeadGrid()
    End Sub

    Sub LLenarComboForma()
        Dim csql As String = "select u.cod_unidad,descripcion from t_unidad u inner join t_material_unidad mu on u.cod_unidad=mu.cod_unidad where item='" + FrmOrdenCompra.lblcodigo.Text + "'"
        FunDb.FillListaOrCombo(csql, FrmOrdenCompra.cmbforma, "descripcion", "cod_unidad")
    End Sub

    Private Sub dgvmaterial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvmaterial.DoubleClick
        If Me.lblflag.Text = "1" Then
            With FrmOrdenCompra
                .lblcodigo.Text = dgvmaterial.Item(0, dgvmaterial.CurrentRow.Index).Value.ToString()
                .lbldescripción.Text = dgvmaterial.Item(1, dgvmaterial.CurrentRow.Index).Value.ToString()
            End With
        End If
        LLenarComboForma()
        Me.Close()
    End Sub
End Class