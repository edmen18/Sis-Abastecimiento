Imports Datos
Imports Reglas
Public Class FrmProyectos
    Dim FunDb As New cFuncionesDB
    Dim FLG As Integer = 0
    Dim cpy As New Cl_Proyecto

    Private Sub FrmProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewProyectos()
        HeadGrid()
    End Sub
    Sub LlenaLstViewProyectos()
        Dim cSql As String = "select codproyecto,descripcion from t_proyecto where estado='1'"
        FunDb.FillDataGridView(cSql, dgvProyecto)
    End Sub
    Sub HeadGrid()
        With dgvProyecto
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 200
            .Columns(1).HeaderText = "Proyecto"
            .Columns(1).Width = 700
        End With
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.lblcodigo.Text = Format(CInt(cpy.GeneraCodproyecto()) + 1, "0000000000")
        FLG = 0
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.FLG = 0 Then
            If Me.lblcodigo.Text <> "" Or Me.txtproyecto.Text <> "" Then
                cpy.CodProyecto = Me.lblcodigo.Text
                cpy.Proyecto = Me.txtproyecto.Text
                cpy.AltaProyecto()
            Else
                MessageBox.Show("Complete los datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf FLG = 1 Then
            cpy.UpdateProyecto(Me.lblcodigo.Text, Me.txtproyecto.Text)
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewProyectos()
        HeadGrid()
        Me.btncancelar.PerformClick()
    End Sub
    Private Sub dgvProyecto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProyecto.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.dgvProyecto.CurrentRow.Cells(0).Value)
        Me.txtproyecto.Text = Convert.ToString(Me.dgvProyecto.CurrentRow.Cells(1).Value)
        FLG = 1
        'MsgBox(FLG)
        Me.btnnuevo.Enabled = False
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lblcodigo.ResetText()
        Me.txtproyecto.ResetText()
        Me.btnnuevo.Enabled = True
        FLG = 0
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If FLG = 1 Then
            cpy.EliminarProyecto(Me.lblcodigo.Text, Me.txtproyecto.Text)
        End If
        Me.btnnuevo.Enabled = True
        LlenaLstViewProyectos()
        HeadGrid()
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub txtproyecto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtproyecto.KeyPress
        'If SoloLetras(CShort(Asc(e.KeyChar))) = 0 Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtproyecto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproyecto.TextChanged

    End Sub
End Class