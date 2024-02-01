Imports Datos
Imports Reglas
Public Class FrmBuscarProveedor
    Dim FunDb As New cFuncionesDB
    Sub LlenaLstViewProvprov()
        Dim cSql As String = "select * from t_proveedores where descripcion like '%" + Me.txtprov.Text + "%'  order by descripcion"
        FunDb.FillDataGridView(cSql, dgvproveedores)
    End Sub
    Sub LlenaLstViewprovruc()
        Dim cSql As String = "select * from t_proveedores where ruc like '%" + Me.txtprov.Text + "%' "
        FunDb.FillDataGridView(cSql, dgvproveedores)
    End Sub
    Sub HeadGrid()
        Try
            With dgvproveedores
                .Columns(0).HeaderText = "R.U.C."
                .Columns(0).Width = 60
                .Columns(1).HeaderText = "Proveedor"
                .Columns(1).Width = 150
                .Columns(2).HeaderText = "Dirección Fiscal"
                .Columns(2).Width = 150
                .Columns(3).HeaderText = "Rubro"
                .Columns(3).Width = 150
                .Columns(4).HeaderText = "Teléfonos"
                .Columns(4).Width = 150
            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub dgvproveedores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvproveedores.DoubleClick
        If Me.lblflag.Text = 1 Then
            With FrmOrdenCompra
                .lblruc.Text = dgvproveedores.Item(0, dgvproveedores.CurrentRow.Index).Value.ToString()
                .lblprov.Text = dgvproveedores.Item(1, dgvproveedores.CurrentRow.Index).Value.ToString()
                .lbldir.Text = dgvproveedores.Item(2, dgvproveedores.CurrentRow.Index).Value.ToString()
            End With
        End If
        If Me.lblflag.Text = 2 Then
            With FrmConsultaOC
                .lblruc.Text = dgvproveedores.Item(0, dgvproveedores.CurrentRow.Index).Value.ToString()
                .lblprov.Text = dgvproveedores.Item(1, dgvproveedores.CurrentRow.Index).Value.ToString()
            End With
        End If
        If Me.lblflag.Text = 3 Then
            With FrmConsultaOS
                .lblruc.Text = dgvproveedores.Item(0, dgvproveedores.CurrentRow.Index).Value.ToString()
                .lblprov.Text = dgvproveedores.Item(1, dgvproveedores.CurrentRow.Index).Value.ToString()
            End With
        End If
        If Me.lblflag.Text = 4 Then
            With FrmOrdenServicio
                .lblruc.Text = dgvproveedores.Item(0, dgvproveedores.CurrentRow.Index).Value.ToString()
                .lblrazon.Text = dgvproveedores.Item(1, dgvproveedores.CurrentRow.Index).Value.ToString()
            End With
        End If
        Me.Close()
    End Sub

    Private Sub txtprov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprov.KeyPress

        If rbrazon.Checked = True Then

            If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
        ElseIf Me.rbruc.Checked = True Then
            If SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
        End If
       
    End Sub


    Private Sub txtprov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprov.TextChanged

        txtprov.CharacterCasing = CharacterCasing.Upper
        If Me.rbrazon.Checked = True Then
            LlenaLstViewProvprov()
        ElseIf Me.rbruc.Checked = True Then
            LlenaLstViewprovruc()
        End If
        HeadGrid()
    End Sub

    Private Sub FrmBuscarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class