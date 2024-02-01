Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_adjuntos
    Private _numero As String
    Private _descripcion As String

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
    Public Function AltaAdjunto(ByVal ind As Integer) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Try
            Dim csql As String
            If ind = 1 Then
                csql = "Insert into T_dordenc(numero,descripcion) values ('" + Me.Numero + "','" + Me.Descripcion + "')"
            ElseIf ind = 2 Then
                csql = "Insert into T_dordens(numero,descripcion) values ('" + Me.Numero + "','" + Me.Descripcion + "')"
            End If
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Adjuntos" + ex.ToString, "Adjuntos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            db.CancelarTransaccion()
            Return False
        End Try
    End Function
End Class
