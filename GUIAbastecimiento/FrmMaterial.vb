Imports Datos
Imports Reglas
Public Class FrmMaterial
    Dim FunDb As New cFuncionesDB
    Dim FLG As Integer = 0
    Dim cmaterial As New Cl_Material
    Dim EstiloGrid As New Cl_EstiloGrid
    Private Sub FrmMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewMaterial()
        EstiloGrid.AplicaStiloBlue(DgvMaterial)
        HeadGrid()
        Me.BtnUnidad.Enabled = False
    End Sub
    Sub LlenaLstViewMaterial()
        Dim cSql As String = "select item,m.descripcon,c.descripcion from t_material m inner join t_convenios c on c.codconvenio=m.codconvenio order by m.descripcon"
        FunDb.FillDataGridView(cSql, DgvMaterial)
    End Sub
    Sub LlenaLstViewMaterialT()
        Dim cSql As String = "select item,m.descripcon,c.descripcion from t_material m inner join t_convenios c on c.codconvenio=m.codconvenio where m.descripcon like '%" + Me.txttexto.Text + "%' order by m.descripcon"
        FunDb.FillDataGridView(cSql, DgvMaterial)
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.lblcodigo.Text = Format(CInt(cmaterial.GeneraCodMaterial()) + 1, "0000000000")
        FLG = 0
        Me.BtnUnidad.Enabled = False
        Me.btngrabar.Enabled = True
    End Sub

    Private Sub btnbuscarconv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarconv.Click
        FrmBuscarConvenio.lblflag.Text = 1
        FrmBuscarConvenio.ShowDialog()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lblcodigo.ResetText()
        Me.txtmaterial.ResetText()
        Me.btnnuevo.Enabled = True
        Me.btngrabar.Enabled = False
        Me.BtnUnidad.Enabled = False
        Me.lblcodconv.ResetText()
        Me.lblconvenio.ResetText()
        FLG = 0
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.FLG = 0 Then
            If Me.lblcodigo.Text <> "" And Me.txtmaterial.Text <> "" And Me.lblcodconv.Text <> "" Then
                cmaterial.Item = Me.lblcodigo.Text
                cmaterial.Descripcon = Me.txtmaterial.Text
                cmaterial.CodConvenio = Me.lblcodconv.Text
                If cmaterial.AltaMaterial() = True Then
                    If MessageBox.Show("Desea registrar las unidades ahora?", "SAB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        FrmRegistrarUnidades.lblcodmaterial.Text = lblcodigo.Text
                        FrmRegistrarUnidades.lblmaterial.Text = txtmaterial.Text
                        FrmRegistrarUnidades.ShowDialog()
                    End If
                End If
                Me.btngrabar.Enabled = False
            Else
                MessageBox.Show("Debe completar los datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf FLG = 1 Then
            cmaterial.UpdateMaterial(Me.lblcodigo.Text, Me.txtmaterial.Text, Me.lblcodconv.Text)
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewMaterial()
        HeadGrid()
        Me.btncancelar.PerformClick()

    End Sub
    Sub HeadGrid()
        With DgvMaterial
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 120
            .Columns(1).HeaderText = "Material"
            .Columns(1).Width = 400
            .Columns(2).HeaderText = "Convenio"
            .Columns(2).Width = 400
        End With
    End Sub


    Private Sub DgvMaterial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvMaterial.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.DgvMaterial.CurrentRow.Cells(0).Value)
        Me.txtmaterial.Text = Convert.ToString(Me.DgvMaterial.CurrentRow.Cells(1).Value)
        FLG = 1
        Me.btnnuevo.Enabled = False
        Me.BtnUnidad.Enabled = True
        GetDatosconvenio()
        LlenaLstViewMaterial()
        Me.txttexto.ResetText()
    End Sub
    Sub GetDatosconvenio()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select c.codconvenio,c.descripcion from t_convenios c inner join t_material m on c.codconvenio=m.codconvenio where item='" + Me.lblcodigo.Text + "'"
            dt = cFun.ConsultaX(csql)
            Me.lblcodconv.Text = CStr(dt.Rows(0).Item(0))
            Me.lblconvenio.Text = CStr(dt.Rows(0).Item(1))
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnidad.Click
        FrmRegistrarUnidades.lblcodmaterial.Text = lblcodigo.Text
        FrmRegistrarUnidades.lblmaterial.Text = txtmaterial.Text
        FrmRegistrarUnidades.ShowDialog()
        
    End Sub

    Private Sub txtmaterial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaterial.TextChanged
        Me.txtmaterial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txttexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttexto.TextChanged
        LlenaLstViewMaterialT()
    End Sub

    Private Sub DgvMaterial_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvMaterial.CellContentClick

    End Sub
End Class