Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_OrdenServicio
    Dim cFunDb As New cFuncionesDB
    Private _numero As String
    Private _fecha As String
    Private _codtipodoc As Integer
    Private _codproyecto As String
    Private _subtotal As Double
    Private _total As Double
    Private _RETENCIONES As Double
    Private _igv As Double
    Private _documento As String
    Private _codimpuesto As Integer
    Private _ruc As String
    Private _totall As String
    Private _adjunto As String
    Private _dni As String
    Private _hora As String
    Public Property Hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property

    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property
    Public Property Adjunto() As String
        Get
            Return _adjunto
        End Get
        Set(ByVal value As String)
            _adjunto = value
        End Set
    End Property
    Public Property Totall() As String
        Get
            Return _totall
        End Get
        Set(ByVal value As String)
            _totall = value
        End Set
    End Property

    Public Property Ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property

    Public Property CodImpuesto() As Integer
        Get
            Return _codimpuesto
        End Get
        Set(ByVal value As Integer)
            _codimpuesto = value
        End Set
    End Property

    Public Property Documento() As String
        Get
            Return _documento
        End Get
        Set(ByVal value As String)
            _documento = value
        End Set
    End Property

    Public Property Igv() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
        End Set
    End Property

    Public Property Retenciones() As Double
        Get
            Return _RETENCIONES
        End Get
        Set(ByVal value As Double)
            _RETENCIONES = value
        End Set
    End Property


    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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

    Public Property CodProyecto() As String
        Get
            Return _codproyecto
        End Get
        Set(ByVal value As String)
            _codproyecto = value
        End Set
    End Property

    Public Property CodTipoDoc() As Integer
        Get
            Return _codtipodoc
        End Get
        Set(ByVal value As Integer)
            _codtipodoc = value
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


    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Function AltaOrdenServicio() As Boolean
        Try
            Dim csql As String = "insert into dbo.T_ORDEN_SERVICIO (NUMERO,ruc,FECHA,CODTIPODOC,CODPROYECTO,SUBTOTAL,TOTAL,RETENCIONES,IGV,DOCUMENTO,COD_IMPUESTO,totall,adjunto,DNI,hora,ESTADO) values ('" + Numero.ToString + "','" + Ruc.ToString + "','" + Fecha.ToString + "','" + CodTipoDoc.ToString + "','" + CodProyecto.ToString + "','" + Subtotal.ToString + "','" + Total.ToString + "','" + Retenciones.ToString + "','" + Igv.ToString + "','" + Documento.ToString + "','" + CodImpuesto.ToString + "','" + Totall.ToString + "','" + Me.Adjunto.ToString + "','" + Dni.ToString + "','" + Hora.ToString + "','A')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Orden", "Insercion de Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarOrdenServicio(ByRef NUM As String) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Try
            Dim csql As String = "UPDATE T_ORDEN_SERVICIO SET ESTADO ='E' WHERE NUMERO='" + NUM.ToString + "'"
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            Return True
        Catch ex As Exception
            db.CancelarTransaccion()
            Return False
            db.Desconectar()
            MessageBox.Show("Error Eliminación Orden" + ex.ToString, "Orden Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    'Se genera el codigo apartir del numero de orden de la tabla de Control_os
    Function GeneraCodOrden() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,n_os)) AS CCOD FROM T_CONTROL_OS"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    'imprime orden
    Public Function ImprimeOrden(ByRef codorden As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,per.descripcion AS razonsocial,per.direccion,ttd.descripcion as documento,documento as numerodoc,py.descripcion as glosa,os.subtotal as subtotalos,os.total as totalos,igv,retenciones,im.descripcion as impuesto ,dos.descripcion as servicio, valor,totall,adjunto from dbo.T_DETALLE_ORDEN_SERVICIO dos inner join dbo.T_ORDEN_SERVICIO os on os.numero=dos.numero inner join dbo.T_Proveedores per on per.ruc=os.ruc inner join dbo.T_TIPODOC ttd on ttd.codtipodoc=os.codtipodoc inner join dbo.T_PROYECTO py on py.codproyecto=os.codproyecto inner join dbo.T_IMPUESTO im on im.COD_IMPUESTO=os.COD_IMPUESTO where os.numero='" + codorden + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenservicio")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'imprime Detalles de orden
    Public Function ImprimeDOrden(ByRef FECHADEL As Date, ByRef FECHAAL As Date, ByRef ind As Integer) As DataSet
        Dim dset As New DataSet
        Dim csql As String
        Try
            If ind = 1 Then
                csql = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,per.descripcion AS razonsocial,per.direccion,ttd.descripcion as documento,documento as numerodoc,py.descripcion as glosa,os.subtotal as subtotalos,os.total as totalos,igv,retenciones,im.descripcion as impuesto ,dos.descripcion as servicio, valor,totall,adjunto from dbo.T_DETALLE_ORDEN_SERVICIO dos inner join dbo.T_ORDEN_SERVICIO os on os.numero=dos.numero inner join dbo.T_Proveedores per on per.ruc=os.ruc inner join dbo.T_TIPODOC ttd on ttd.codtipodoc=os.codtipodoc inner join dbo.T_PROYECTO py on py.codproyecto=os.codproyecto inner join dbo.T_IMPUESTO im on im.COD_IMPUESTO=os.COD_IMPUESTO where  fecha >= '" + FECHADEL.Date + "' and fecha<='" + FECHAAL.Date + "' and os.estado='A' order by fecha"
            ElseIf ind = 2 Then
                csql = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,per.descripcion AS razonsocial,per.direccion,ttd.descripcion as documento,documento as numerodoc,py.descripcion as glosa,os.subtotal as subtotalos,os.total as totalos,igv,retenciones,im.descripcion as impuesto ,dos.descripcion as servicio, valor,totall,adjunto from dbo.T_DETALLE_ORDEN_SERVICIO dos inner join dbo.T_ORDEN_SERVICIO os on os.numero=dos.numero inner join dbo.T_Proveedores per on per.ruc=os.ruc inner join dbo.T_TIPODOC ttd on ttd.codtipodoc=os.codtipodoc inner join dbo.T_PROYECTO py on py.codproyecto=os.codproyecto inner join dbo.T_IMPUESTO im on im.COD_IMPUESTO=os.COD_IMPUESTO where  fecha >= '" + FECHADEL.Date + "' and fecha<='" + FECHAAL.Date + "' and os.estado='E' order by fecha"
            End If
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenservicio")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function REPORTEFECHAS(ByRef FECHADEL As Date, ByRef FECHAAL As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc,py.DESCRIPCION as proyecto,per.descripcion as Persona,os.subtotal ,igv,retenciones,os.total from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores per on per.ruc=os.ruc where  fecha >= '" + FECHADEL.Date + "' and fecha<='" + FECHAAL.Date + "' order by fecha"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenesServicios")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function REPORTEPROVEEDOR(ByRef PROV As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = " select os.NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc,py.DESCRIPCION as proyecto,per.descripcion as Persona,os.subtotal ,igv,retenciones,os.total from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores per on per.ruc=os.ruc  WHERE OS.ruc='" + PROV.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenesServicios")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function REPORTEPROYECTO(ByRef PROYECTO As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc,py.DESCRIPCION as proyecto,per.descripcion as Persona,os.subtotal ,igv,retenciones,os.total from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores per on per.ruc=os.ruc WHERE PY.CODPROYECTO='" + PROYECTO.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenesServicios")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function REPORTEDOC(ByRef doc As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc,py.DESCRIPCION as proyecto,per.descripcion as Persona,os.subtotal ,igv,retenciones,os.total from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores per on per.ruc=os.ruc WHERE ttd.codtipodoc='" + doc.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenesServicios")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function REPORTEtodas() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select os.NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc,py.DESCRIPCION as proyecto,ps.descripcion as Persona,os.subtotal ,igv,retenciones,os.total from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenesServicios")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
