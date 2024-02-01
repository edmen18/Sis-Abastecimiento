Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Proveedor
    Dim cFunDb As New cFuncionesDB
    Private _ruc As String
    Private _descripcion As String
    Private _direccion As String
    Private _rubro As String
    Private _telefonos As String
    Private _rep As String
    Public Property Rep() As String
        Get
            Return _rep
        End Get
        Set(ByVal value As String)
            _rep = value
        End Set
    End Property

    Public Property Telefonos() As String
        Get
            Return _telefonos
        End Get
        Set(ByVal value As String)
            _telefonos = value
        End Set
    End Property

    Public Property Rubro() As String
        Get
            Return _rubro
        End Get
        Set(ByVal value As String)
            _rubro = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
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

    Public Property RUC() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property
    Public Function AltaProveedor() As Boolean
        Try
            Dim csql As String = "Insert into T_proveedores(ruc,descripcion,direccion,rubro,telefonos,rep_LEGAL) values ('" + Me.RUC + "','" + Me.Descripcion + "','" + Me.Direccion + "','" + Me.Rubro + "','" + Me.Telefonos + "','" + Me.Rep + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Proveedor", "Insercion de Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Proveedor" + ex.ToString, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'eliminar proveedor
    Public Function EliminarProveedor(ByVal RucProv As String) As Boolean
        Try
            Dim csql As String = "delete T_proveedores where ruc='" + RucProv + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar este Proveedor", "Eliminacion de Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("El proveedor ha sido eliminado satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Eliminación Proveedor" + "Es probable que estos datos hayan sido utilizados en otras operaciones", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateProveedor(ByVal ruc As String, ByVal direcc As String, ByVal telef As String, ByVal descrip As String, ByVal rubro As String, ByVal rep As String) As Boolean
        Try
            Dim csql As String = "update t_Proveedores set Descripcion ='" + descrip + "',direccion='" + direcc + "',telefonos='" + telef + "',rubro='" + rubro + "',rep_legal='" + Me.Rep + "' where ruc='" + ruc + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar este Proveedor ", "Actualización de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Proveedor" + ex.ToString, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
