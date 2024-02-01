Imports Datos
Imports Reglas
Public Class FrmProveedores
    Dim FunDb As New cFuncionesDB
    Dim cprov As New Cl_Proveedor
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim FLG As Integer = 0
    Dim contador As Integer = 0
    Private Sub FrmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewProveedores()
        EstiloGrid.AplicaStiloBlue(dgvProveedores)
        HeadGrid()
        btneliminar.Enabled = False
        Me.GroupBox1.Enabled = False
    End Sub
    Sub LlenaLstViewProveedores()
        Dim cSql As String = "select * from t_proveedores order by descripcion"
        FunDb.FillDataGridView(cSql, dgvProveedores)
    End Sub
    Sub LlenaLstViewProveedoresD()
        Dim cSql As String = "select * from t_proveedores where Descripcion like '%" + Me.txttexto.Text + "%'order by descripcion"
        FunDb.FillDataGridView(cSql, dgvProveedores)
    End Sub
    Sub LlenaLstViewProveedoresR()
        Dim cSql As String = "select * from t_proveedores where ruc LIKE '%" + Me.txttexto.Text + "%' order by descripcion"
        FunDb.FillDataGridView(cSql, dgvProveedores)
    End Sub
    Sub HeadGrid()
        With dgvProveedores
            .Columns(0).HeaderText = "R.U.C."
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Razon Social"
            .Columns(1).Width = 300
            .Columns(2).HeaderText = "Dirección Fiscal"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "Rubro"
            .Columns(3).Width = 200
            .Columns(4).HeaderText = "Teléfonos"
            .Columns(4).Width = 200
            .Columns(5).HeaderText = "Representante Legal"
            .Columns(5).Width = 200
        End With
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        FLG = 0
        Me.GroupBox1.Enabled = True
    End Sub
    Sub validar()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select ruc from t_proveedores where ruc='" + Me.txtruc.Text + "'"
            dt = cFun.ConsultaX(csql)
            If dt.Rows.Count > 0 Then
                contador = contador + 1
            End If
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado" + ex.Message, " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.FLG = 0 Then
            If Me.txtruc.Text <> "" And Me.txtdirfis.Text <> "" And Me.txtrs.Text <> "" And Me.txttelefonos.Text <> "" Then
                validar()
                If contador = 0 Then
                    cprov.RUC = Me.txtruc.Text
                    cprov.Descripcion = Me.txtrs.Text
                    cprov.Direccion = Me.txtdirfis.Text
                    cprov.Telefonos = Me.txttelefonos.Text
                    cprov.Rubro = Me.txtrubro.Text
                    cprov.Rep = Me.txtrep.Text
                    cprov.AltaProveedor()
                Else
                    MessageBox.Show("El Proveedor ya se encuentra registrado", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Los datos no se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf FLG = 1 Then
            cprov.UpdateProveedor(Me.txtruc.Text, Me.txtdirfis.Text, Me.txttelefonos.Text, Me.txtrs.Text, Me.txtrubro.Text, Me.txtrep.Text)
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewProveedores()
        EstiloGrid.AplicaStiloBlue(dgvProveedores)
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.txtruc.ResetText()
        Me.txtdirfis.ResetText()
        Me.txtrs.ResetText()
        Me.txttelefonos.ResetText()
        Me.txtrubro.ResetText()
        Me.GroupBox1.Enabled = False
        Me.btnnuevo.Enabled = True
        btneliminar.Enabled = False
        FLG = 0
        contador = 0
    End Sub
    Private Sub dgvProveedores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProveedores.DoubleClick
        Me.txtruc.Text = Convert.ToString(Me.dgvProveedores.CurrentRow.Cells(0).Value)
        Me.txtrs.Text = Convert.ToString(Me.dgvProveedores.CurrentRow.Cells(1).Value)
        Me.txtdirfis.Text = Convert.ToString(Me.dgvProveedores.CurrentRow.Cells(2).Value)
        Me.txtrubro.Text = Convert.ToString(Me.dgvProveedores.CurrentRow.Cells(3).Value)
        Me.txttelefonos.Text = Convert.ToString(Me.dgvProveedores.CurrentRow.Cells(4).Value)
        FLG = 1
        Me.btnnuevo.Enabled = False
        Me.GroupBox1.Enabled = True
        LlenaLstViewProveedores()
        EstiloGrid.AplicaStiloBlue(dgvProveedores)
        Me.txttexto.ResetText()
        btneliminar.Enabled = True
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtruc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        If SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtrs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrs.KeyPress
        'If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtrubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrubro.KeyPress

        If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtrubro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrubro.TextChanged
        Me.txtrubro.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtrep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrep.KeyPress
        If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtrep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrep.TextChanged
        Me.txtrep.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txttelefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefonos.KeyPress
        If SoloNumerosf(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdirfis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdirfis.TextChanged
        txtdirfis.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txttexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttexto.TextChanged
        If rbruc.Checked = True Then
            LlenaLstViewProveedoresR()
            EstiloGrid.AplicaStiloBlue(dgvProveedores)
        ElseIf rbdescripcion.Checked = True Then
            LlenaLstViewProveedoresD()
            EstiloGrid.AplicaStiloBlue(dgvProveedores)
        End If
    End Sub

    Private Sub txtruc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtruc.LostFocus
        If Len(Me.txtruc.Text) <> 11 Then
            MessageBox.Show("Ruc invalido, porfavor verifique", "SAB 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtruc.Focus()
        End If
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If FLG = 1 Then
            cprov.EliminarProveedor(Me.txtruc.Text)
            btncancelar.PerformClick()
            LlenaLstViewProveedores()
        End If
    End Sub


    Private Sub btn_sunat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sunat.Click
        FrmNavegaSunat.Show()
        FrmNavegaSunat.browser_sunat.Navigate("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")
    End Sub
End Class