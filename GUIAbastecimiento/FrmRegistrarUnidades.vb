Imports Datos
Imports Reglas
Public Class FrmRegistrarUnidades
    Dim fundb As New cFuncionesDB
    Dim c As Integer = 0
    Dim contador As Integer = 0
    Dim cmu As New Cl_unidad_material
    Private Sub FrmRegistrarUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewCategoria()
    End Sub
    Sub LlenaLstViewCategoria()
        Me.lvwunidades.Items.Clear()
        Dim cSql As String = "select u.cod_unidad,descripcion,abrev from t_unidad u inner join t_material_unidad mu on u.cod_unidad=mu.cod_unidad where item='" + Me.lblcodmaterial.Text + "'"
        fundb.FillListview(cSql, lvwunidades)
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmBuscarUnidad.lblflag.Text = "1"
        FrmBuscarUnidad.ShowDialog()
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        agregaItem()
        Me.lblcodunidad.ResetText()
        Me.lblunidad.ResetText()
        Me.lblabrev.ResetText()
    End Sub
    Sub agregaItem()
        If Me.lblcodunidad.Text = "" Then
            MessageBox.Show("Operación no válida, debe buscar una unidad", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For i = 0 To Me.lvwunidades.Items.Count - 1
                If Me.lvwunidades.Items(i).SubItems(0).Text = Me.lblcodunidad.Text Then
                    contador = contador + 1
                End If
            Next
            If contador > 0 Then
                MessageBox.Show("Operación no válida, la unidad ya se encuentra registrada", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                c = Me.lvwunidades.Items.Count
                Me.lvwunidades.Items.Add(Me.lblcodunidad.Text)
                Me.lvwunidades.Items(c).SubItems.Add(Me.lblunidad.Text)
                Me.lvwunidades.Items(c).SubItems.Add(Me.lblabrev.Text)
            End If
        End If
        c = 0
        contador = 0
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        delOne()
    End Sub
    Sub delOne()
        If Me.lvwunidades.SelectedItems.Count > 0 Then
            Me.lvwunidades.Items.RemoveAt(Me.lvwunidades.SelectedItems(0).Index)
        Else
            MessageBox.Show("No ha seleccionado el elemento a quitar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If MessageBox.Show("Seguro que desea continuar", "SAB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cmu.deleteUnidad(Me.lblcodmaterial.Text)
            For i = 0 To Me.lvwunidades.Items.Count - 1
                cmu.Item = Me.lblcodmaterial.Text
                cmu.CodUnidad = Me.lvwunidades.Items(i).SubItems(0).Text
                cmu.AltaUnidad()
            Next
            MessageBox.Show("Los datos se registraron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
       
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lblcodunidad.ResetText()
        Me.lblunidad.ResetText()
        Me.lblabrev.ResetText()
        Me.lvwunidades.Items.Clear()
    End Sub
End Class