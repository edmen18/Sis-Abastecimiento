Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_Unidad
    Dim cFunDb As New cFuncionesDB
    Private _codunidad As String
    Private _descripcion As String
    Private _abreviatura As String

    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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

    Public Property CodUnidad() As String
        Get
            Return _codunidad
        End Get
        Set(ByVal value As String)
            _codunidad = value
        End Set
    End Property
    Public Function Altaunidad() As Boolean
        Try
            Dim csql As String = "Insert into T_unidad(cod_unidad,descripcion,abrev) values ('" + Me.CodUnidad + "','" + Me.Descripcion + "','" + Me.Abreviatura + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Unidad", "Insercion de Unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Unidad" + ex.ToString, "Unidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateUnidad(ByRef codg As String, ByRef descrip As String, ByRef abrev As String) As Boolean
        Try
            Dim csql As String = "update t_unidad set Descripcion ='" + descrip + "',abrev='" + abrev + "' where cod_unidad='" + codg + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar esta Unidad ", "Actualización de Unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Unidad" + ex.ToString, "Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodUnidad() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,cod_unidad)) AS CCOD FROM T_unidad"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
