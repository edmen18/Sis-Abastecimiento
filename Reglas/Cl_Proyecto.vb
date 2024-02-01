Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_Proyecto
    Dim cFunDb As New cFuncionesDB
    Private _codproyecto As String
    Private _proyecto As String
    Public Property Proyecto() As String
        Get
            Return _proyecto
        End Get
        Set(ByVal value As String)
            _proyecto = value
        End Set
    End Property

    Public Property CodProyecto() As String
        Get
            Return _codproyecto
        End Get
        Set(ByVal value As String)
            _codproyecto = value
        End Set
    End Property
    Public Function AltaProyecto() As Boolean
        Try
            Dim csql As String = "Insert into T_proyecto(codproyecto,descripcion,estado) values ('" + Me.CodProyecto + "','" + Me.Proyecto + "','1')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Proyecto", "Insercion de Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Proyecto" + ex.ToString, "Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateProyecto(ByVal codg As String, ByVal descrip As String) As Boolean
        Try
            Dim csql As String = "update t_proyecto set Descripcion ='" + descrip + "' where codproyecto='" + codg + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar esta Proyecto ", "Actualización de Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Proyecto" + ex.ToString, "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarProyecto(ByVal codg As String, ByVal descrip As String) As Boolean
        Try
            Dim csql As String = "update t_proyecto set estado ='0' where codproyecto='" + codg + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar este Proyecto ", "Eliminación de Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminación de Proyecto" + ex.ToString, "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodproyecto() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,codproyecto)) AS CCOD FROM T_proyecto"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function

End Class
