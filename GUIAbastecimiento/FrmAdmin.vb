Imports Datos
Imports Reglas
Public Class FrmAdmin
    Dim Sesion As New Cl_Sesion
    Public flg As Integer = 0
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT dni,usuario,clave,CodNivel from t_usuarios where usuario='" + Me.txtusuario.Text + "'and clave='" + Me.txtcontraseña.Text + "'"
            dt = cFun.ConsultaX(csql)
            If Me.txtusuario.Text = CStr(dt.Rows(0).Item(1)) And Me.txtcontraseña.Text = CStr(dt.Rows(0).Item(2)) Then
                If CStr(dt.Rows(0).Item(3)) = "00001" Then
                    FrmExtorno.lbladmin.Text = CStr(dt.Rows(0).Item(0))
                    If flg = 1 Then
                        FrmConsultaOS.dtos()
                    ElseIf flg = 2 Then
                        FrmConsultaOC.dtos()
                    End If
                    FrmExtorno.ShowDialog()
                Else
                    MessageBox.Show("Error debe Ingresar un Usuario que tenga nivel de Administrador", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Me.Hide()
                MDIPrincipal.Show()
            Else
                MessageBox.Show("Error de Inicio de Sesion el usuario y/o contraseña son incorrectos", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtcontraseña.ResetText()
                Me.txtusuario.ResetText()
            End If

        Catch ex As Exception
            MessageBox.Show("Error de Inicio de Sesion el usuario y/o contraseña son incorrectos", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.txtcontraseña.ResetText()
        Me.txtusuario.ResetText()
        Me.Close()
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged
        Me.txtusuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtcontraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.TextChanged
        Me.txtcontraseña.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class