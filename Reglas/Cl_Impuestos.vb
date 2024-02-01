Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Impuestos
    Private _codimpuesto As Integer
    Private _porcentaje As Double
    Private _annio As String
    Private _descripcion As String
    Dim cFunDb As New cFuncionesDB
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Annio() As String
        Get
            Return _annio
        End Get
        Set(ByVal value As String)
            _annio = value
        End Set
    End Property

    Public Property Porcentaje() As Double
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Double)
            _porcentaje = value
        End Set
    End Property

    Public Property CodiMPUESTO() As Integer
        Get
            Return _codimpuesto
        End Get
        Set(ByVal value As Integer)
            _codimpuesto = value
        End Set
    End Property

    Public Function AltaImpuesto() As Boolean
        Try
            Dim csql As String = "insert into dbo.T_IMPUESTO (COD_IMPUESTO,PORCENTAJE,ANNIO,DESCRIPCION) values ('" + CStr(CodiMPUESTO.ToString) + "','" + CStr(Porcentaje.ToString) + "','" + CStr(Now.Year) + "','" + Descripcion.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Impuesto para el presente año", "Insercion de Impuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Impuesto" + ex.ToString, "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateImpuesto() As Boolean
        Try
            Dim csql As String = "update t_impuesto set Descripcion ='" + Descripcion.ToString + "',porcentaje='" + CStr(Porcentaje.ToString) + "' where cod_impuesto='" + CStr(CodiMPUESTO.ToString) + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar este Impuesto ", "Actualización de impuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Impuesto" + ex.ToString, "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodIMPUESTO() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,Cod_impuesto))+1 AS CCOD FROM T_impuesto"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
