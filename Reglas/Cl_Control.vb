Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_Control
    Dim cFunDb As New cFuncionesDB

    Private nro_os As String
    Private estdo As String

    Private nro_oc As String
    Private estdo_oc As String

    Public Property Estado_OC() As String
        Get
            Return estdo_oc
        End Get
        Set(ByVal value As String)
            estdo_oc = value
        End Set
    End Property
    Public Property Num_oc() As String
        Get
            Return nro_oc
        End Get
        Set(ByVal value As String)
            nro_oc = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return estdo
        End Get
        Set(ByVal value As String)
            estdo = value
        End Set
    End Property
    Public Property Num_os() As String
        Get
            Return nro_os
        End Get
        Set(ByVal value As String)
            nro_os = value
        End Set
    End Property

#Region "Orden Servicio"
    Public Function RegistraOS() As Boolean
        Try
            Dim csql As String = "INSERT INTO T_CONTROL_OS (n_os,estado) VALUES ('" + Num_os.ToString + "','" + Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            Return True
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ActualizaOS(ByVal numero As String) As Boolean
        Try
            Dim csql As String = "UPDATE T_CONTROL_OS set estado ='A' WHERE n_os = '" + numero.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            Return True
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    'Se genera el codigo apartir del numero de orden de la tabla de Control_os
    Function GetUltimaOrden() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,n_os)) AS CCOD FROM T_CONTROL_OS"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function

#End Region


#Region "Orden Compra"
    Public Function RegistraOC() As Boolean
        Try
            Dim csql As String = "INSERT INTO T_CONTROL_OC (n_oc,estado) VALUES ('" + Num_oc.ToString + "','" + Estado_OC.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            Return True
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ActualizaOC(ByVal numoc As String) As Boolean
        Try
            Dim csql As String = "UPDATE T_CONTROL_OC set estado ='A' WHERE n_oc = '" + numoc.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            Return True
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    'Se genera el codigo apartir del numero de orden de la tabla de Control_os
    Function GetUltimaOC() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,n_oc)) AS CCOD FROM T_CONTROL_OC"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
#End Region
   
End Class
