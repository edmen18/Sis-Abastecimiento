Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Extorno
    Private _numero As String
    Private _motivo As String
    Private _fecha As String
    Private _usuario As String
    Private _tipo_transac As String
    Private _hora As String
    Private _admin As String
    Private _monto As Double
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    Public Property Admin() As String
        Get
            Return _admin
        End Get
        Set(ByVal value As String)
            _admin = value
        End Set
    End Property

    Public Property Hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property

    Public Property Tipo_transac() As String
        Get
            Return _tipo_transac
        End Get
        Set(ByVal value As String)
            _tipo_transac = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property


    Public Property Motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
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
    Public Function AltaExtorno() As Boolean
        Try
            Dim csql As String = "Insert into T_extorno(numero,fecha_elim,motivo,usuario,tipo_transac,monto,hora,admin) values ('" + Me.Numero.ToString + "','" + Me.Fecha.ToString + "','" + Me.Motivo.ToString + "','" + Usuario.ToString + "','" + Me.Tipo_transac.ToString + "','" + Monto.ToString + "','" + Me.Hora.ToString + "','" + Admin.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Extorno", "Insercion de Extorno", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Extorno" + ex.ToString, "Extorno", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'reporte de todos los extornos
    Public Overloads Function ImprimeTodos() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select numero,convert(char(10),fecha_elim,103)as fecha_elim,motivo,usuario,tipo_transac,monto,hora,admin from t_extorno"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtExtorno")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'reporte de extornos por usuario
    Public Overloads Function ImprimeUsuarios(ByVal usuarios As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select numero,convert(char(10),fecha_elim,103)as fecha_elim,motivo,e.usuario+' '+nombres+' '+apellidos as usuario,tipo_transac,monto,hora,admin from t_extorno e inner join t_usuarios u on u.dni=e.usuario where e.usuario+' '+nombres+' '+apellidos='" + usuarios + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtExtorno")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'reporte de extornos por fecha
    Public Overloads Function Imprimefechas(ByVal fechadel As Date, ByVal fechaal As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select numero,convert(char(10),fecha_elim,103)as fecha_elim,motivo,usuario as usuario,tipo_transac,monto,hora,admin from t_extorno  where fecha_elim>='" + fechadel.Date + "' and fecha_elim<='" + fechaal.Date + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtExtorno")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'reporte de extornos por transaccion
    Public Overloads Function ImprimeTrans(ByVal Transaccion As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select numero,convert(char(10),fecha_elim,103)as fecha_elim,motivo,usuario as usuario,tipo_transac,monto,hora,admin from t_extorno  where tipo_transac='" + Transaccion.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtExtorno")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
