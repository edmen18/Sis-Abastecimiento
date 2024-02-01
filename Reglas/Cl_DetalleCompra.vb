Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DetalleCompra
    Dim cFunDb As New cFuncionesDB
    Private _item As String
    Private _codunidad As String
    Private _cantidad As Double
    Private _preciou As Double
    Private _subtotal As Double
    Private _numero As String
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property Subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property

    Public Property Precio_u() As Double
        Get
            Return _preciou
        End Get
        Set(ByVal value As Double)
            _preciou = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

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
    Public Function AltaDetalle() As Boolean
        Try
            Dim csql As String = "insert into dbo.T_DETALLE_ORDEN_COMPRA (ITEM,COD_UNIDAD,CANTIDAD,PRECIO_U,SUBTOTAL,NUMERO)values ('" + Item.ToString + "','" + CodUnidad.ToString + "','" + Cantidad.ToString + "','" + Precio_u.ToString + "','" + Subtotal.ToString + "','" + Numero.ToString + "')"
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
