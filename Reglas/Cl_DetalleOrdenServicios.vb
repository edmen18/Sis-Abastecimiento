Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DetalleOrdenServicios
    Dim cFunDb As New cFuncionesDB
    Private _numero As String
    Private _descripcion As String
    Private _valor As Double
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Function AltaDetalle() As Boolean
        Try
            Dim csql As String = "insert into dbo.T_DETALLE_ORDEN_SERVICIO (NUMERO,DESCRIPCION,VALOR)values ('" + Numero.ToString + "','" + Descripcion.ToString + "','" + Valor.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Detalle Orden" + ex.ToString, "Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
