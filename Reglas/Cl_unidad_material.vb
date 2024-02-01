Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_unidad_material
    Dim cFunDb As New cFuncionesDB
    Private _item As String
    Private _codunidad As String
    Public Property CodUnidad() As String
        Get
            Return _codunidad
        End Get
        Set(ByVal value As String)
            _codunidad = value
        End Set
    End Property

    Public Property Item() As String
        Get
            Return _item
        End Get
        Set(ByVal value As String)
            _item = value
        End Set
    End Property
    Public Function AltaUnidad() As Boolean
        Try
            Dim csql As String = "Insert into T_material_unidad (item,cod_unidad) values ('" + Me.Item + "','" + Me.CodUnidad + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Unidad" + ex.ToString, "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function deleteUnidad(ByRef codg As String) As Boolean
        Try
            Dim csql As String = "delete t_material_unidad where item='" + codg + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            Return True
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Unidad" + ex.ToString, "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
