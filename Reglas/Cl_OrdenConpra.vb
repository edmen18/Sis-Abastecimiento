Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_OrdenConpra
    Dim cFunDb As New cFuncionesDB
    Private _numero As String
    Private _fecha As String
    Private _codtipodoc As String
    Private _codProyecto As String
    Private _subtotal As Double
    Private _total As Double
    Private _ruc As String
    Private _retenciones As Double
    Private _igv As Double
    Private _documento As String
    Private _codimpuesto As Integer
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
            Return _retenciones
        End Get
        Set(ByVal value As Double)
            _retenciones = value
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
            Return _codProyecto
        End Get
        Set(ByVal value As String)
            _codProyecto = value
        End Set
    End Property

    Public Property CodTipoDoc() As String
        Get
            Return _codtipodoc
        End Get
        Set(ByVal value As String)
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
    'guardar orden de compra
    Public Function AltaOrdenCompra() As Boolean
        Try
            Dim csql As String = "insert into dbo.T_ORDEN_COMPRA (NUMERO,FECHA,CODTIPODOC,CODPROYECTO,SUBTOTAL,TOTAL,RUC,RETENCIONES,IGV,DOCUMENTO,COD_IMPUESTO,totall,adjunto,dni,hora,ESTADO)values ('" + Numero.ToString + "','" + Fecha.ToString + "','" + CodTipoDoc.ToString + "','" + CodProyecto.ToString + "','" + Subtotal.ToString + "','" + Total.ToString + "','" + Ruc.ToString + "','" + Retenciones.ToString + "','" + Igv.ToString + "','" + Documento.ToString + "','" + CodImpuesto.ToString + "','" + Totall.ToString + "','" + Adjunto.ToString + "','" + Dni.ToString + "','" + Hora.ToString + "','A')"
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
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '*********+++ ELIMINAR ORDEN
    Public Function EliminarOrdenCompra(ByRef numer As String) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Try
            Dim csql As String = "update t_orden_compra set estado='E' where numero='" + numer + "'"
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
            MessageBox.Show("Error Eliminación Orden" + ex.ToString, "Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Function GeneraCodOrden() As String
        Dim strsql As String
        strsql = "SELECT  MAX(CONVERT(INT,n_oc)) AS CCOD FROM T_CONTROL_OC"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    'imprime orden
    Public Overloads Function ImprimeOrden(ByRef codorden As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select oc.numero as numero,convert(char(10),fecha,103)as fecha,pv.ruc,pv.descripcion as proveedor,pv.direccion,ttd.DESCRIPCION as documento,documento as numerodoc,py.descripcion as glosa,oc.subtotal as subtotaloc,retenciones,igv,oc.total as totaloc,doc.item,cantidad,u.descripcion as unidad,m.descripcon as material,PRECIO_U,doc.SUBTOTAL as subtotaldoc,totall,adjunto from dbo.T_DETALLE_ORDEN_COMPRA doc inner join dbo.T_MATERIAL m on m.item=doc.item inner join dbo.T_UNIDAD u on u.cod_unidad=doc.COD_UNIDAD inner join dbo.T_ORDEN_COMPRA oc on oc.numero=doc.numero inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC=oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.ruc inner join dbo.T_IMPUESTO im on im.COD_IMPUESTO=oc.COD_IMPUESTO where oc.numero='" + codorden.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'imprime Detalles de orden
    Public Overloads Function ImprimeDOrden(ByRef FECHADEL As Date, ByRef FECHAAL As Date, ByRef ind As Integer) As DataSet
        Dim dset As New DataSet
        Dim csql As String
        Try
            If ind = 1 Then
                csql = "select oc.numero as numero,convert(char(10),fecha,103)as fecha,pv.ruc,pv.descripcion as proveedor,pv.direccion,ttd.DESCRIPCION as documento,documento as numerodoc,py.descripcion as glosa,oc.subtotal as subtotaloc,retenciones,igv,oc.total as totaloc,doc.item,cantidad,u.descripcion as unidad,m.descripcon as material,PRECIO_U,doc.SUBTOTAL as subtotaldoc,totall from dbo.T_DETALLE_ORDEN_COMPRA doc inner join dbo.T_MATERIAL m on m.item=doc.item inner join dbo.T_UNIDAD u on u.cod_unidad=doc.COD_UNIDAD inner join dbo.T_ORDEN_COMPRA oc on oc.numero=doc.numero inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC=oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.ruc inner join dbo.T_IMPUESTO im on im.COD_IMPUESTO=oc.COD_IMPUESTO where  fecha >= '" + FECHADEL.Date + "' and fecha<='" + FECHAAL.Date + "' and oc.estado='E'order by fecha"
            ElseIf ind = 2 Then
                csql = "select oc.numero as numero,convert(char(10),fecha,103)as fecha,pv.ruc,pv.descripcion as proveedor,pv.direccion,ttd.DESCRIPCION as documento,documento as numerodoc,py.descripcion as glosa,oc.subtotal as subtotaloc,retenciones,igv,oc.total as totaloc,doc.item,cantidad,u.descripcion as unidad,m.descripcon as material,PRECIO_U,doc.SUBTOTAL as subtotaldoc,totall from dbo.T_DETALLE_ORDEN_COMPRA doc inner join dbo.T_MATERIAL m on m.item=doc.item inner join dbo.T_UNIDAD u on u.cod_unidad=doc.COD_UNIDAD inner join dbo.T_ORDEN_COMPRA oc on oc.numero=doc.numero inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC=oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.ruc inner join dbo.T_IMPUESTO im on im.COD_IMPUESTO=oc.COD_IMPUESTO where  fecha >= '" + FECHADEL.Date + "' and fecha<='" + FECHAAL.Date + "' and oc.estado='E' order by fecha"
            End If
                       Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function REPORTEFECHAS(ByRef FECHADEL As Date, ByRef FECHAAL As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc, py.DESCRIPCION as proyecto,pv.descripcion as proveedor,subtotal,igv,retenciones,total from dbo.T_ORDEN_COMPRA oc inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.RUC  where  fecha >= '" + FECHADEL.Date + "' and fecha<='" + FECHAAL.Date + "' order by fecha"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOdenesCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function REPORTEPROVEEDOR(ByRef PROV As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc, py.DESCRIPCION as proyecto,pv.descripcion as proveedor,subtotal,igv,retenciones,total from dbo.T_ORDEN_COMPRA oc inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.RUC  WHERE OC.RUC='" + PROV.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOdenesCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function REPORTEPROYECTO(ByRef PROYECTO As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc, py.DESCRIPCION as proyecto,pv.descripcion as proveedor,subtotal,igv,retenciones,total from dbo.T_ORDEN_COMPRA oc inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.RUC  WHERE PY.CODPROYECTO='" + PROYECTO.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOdenesCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function REPORTEDOC(ByRef doc As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc, py.DESCRIPCION as proyecto,pv.descripcion as proveedor,subtotal,igv,retenciones,total from dbo.T_ORDEN_COMPRA oc inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.RUC  WHERE ttd.codtipodoc='" + doc.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOdenesCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function REPORTEtodas() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento as ndoc, py.DESCRIPCION as proyecto,pv.descripcion as proveedor,subtotal,igv,retenciones,total from dbo.T_ORDEN_COMPRA oc inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= oc.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=oc.CODPROYECTO inner join dbo.T_PROVEEDORES pv on pv.RUC=oc.RUC"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOdenesCompra")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
