Imports Datos
Imports System.Data
Imports System.Windows.Forms

Public Class Cl_Material
    Dim cFunDb As New cFuncionesDB
    Private _item As String
    Private _descripcon As String
    Private _codconvenio As String

    Public Property CodConvenio() As String
        Get
            Return _codconvenio
        End Get
        Set(ByVal value As String)
            _codconvenio = value
        End Set
    End Property

    Public Property Descripcon() As String
        Get
            Return _descripcon
        End Get
        Set(ByVal value As String)
            _descripcon = value
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

    Public Function AltaMaterial() As Boolean
        Try
            Dim csql As String = "Insert into T_material(item,descripcon,codconvenio) values ('" + Me.Item + "','" + Me.Descripcon + "','" + Me.CodConvenio + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este material", "Insercion de Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SIAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Material" + ex.ToString, "Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateMaterial(ByRef codg As String, ByRef descrip As String, ByRef convenio As String) As Boolean
        Try
            Dim csql As String = "update t_material set Descripcon ='" + descrip + "',codconvenio='" + convenio + "' where item='" + codg + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar este Material ", "Actualización de Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Material" + ex.ToString, "Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodMaterial() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,item)) AS CCOD FROM T_material"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
