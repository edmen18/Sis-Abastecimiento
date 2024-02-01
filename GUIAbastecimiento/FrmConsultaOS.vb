Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmConsultaOS
    Dim FunDb As New cFuncionesDB
    Dim cos As New Cl_OrdenServicio
    Dim imp As New C_imprime
    Dim EstiloGrid As New Cl_EstiloGrid
    Private Sub FrmConsultaOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gbnumero.Visible = False
        Me.gbfecha.Visible = False
        Me.gbproyecto.Visible = False
        Me.gbproveedor.Visible = False
        Me.gbdoc.Visible = False
        Try
            EstiloGrid.AplicaStiloBlue(dgvDatos)
        Catch ex As Exception
        End Try
    End Sub
    Sub LLenarComboglosa()
        Dim csql As String = "select codproyecto,descripcion from t_proyecto  where estado='1'"
        FunDb.FillListaOrCombo(csql, cmbglosa, "descripcion", "codproyecto")
    End Sub

    Private Sub rbproveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbproveedor.CheckedChanged
        Me.gbnumero.Visible = False
        Me.gbfecha.Visible = False
        Me.gbproyecto.Visible = False
        Me.gbproveedor.Visible = True
        Me.gbdoc.Visible = False
        LlenaLstViewtodas()
    End Sub

    Private Sub rbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfecha.CheckedChanged
        Me.gbnumero.Visible = False
        Me.gbfecha.Visible = True
        Me.gbproyecto.Visible = False
        Me.gbproveedor.Visible = False
        Me.gbdoc.Visible = False
        LlenaLstViewtodas()
    End Sub

    Private Sub rbproyecto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbproyecto.CheckedChanged
        Me.gbnumero.Visible = False
        Me.gbfecha.Visible = False
        Me.gbproyecto.Visible = True
        Me.gbproveedor.Visible = False
        Me.gbdoc.Visible = False
        LLenarComboglosa()
        LlenaLstViewtodas()
    End Sub

    Private Sub rbdocumento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdocumento.CheckedChanged
        LLenarCombodocumentos()
        Me.gbnumero.Visible = False
        Me.gbfecha.Visible = False
        Me.gbproyecto.Visible = False
        Me.gbproveedor.Visible = False
        Me.gbdoc.Visible = True
        LlenaLstViewtodas()
    End Sub
    Sub LlenaLstViewnumero()
        Dim cSql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc where  numero like '%" + Me.txtnumero.Text + "%' AND os.ESTADO='A' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LlenaLstViewproyecto()
        Dim cSql As String = " select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc  where  os.codproyecto = '" + Me.cmbglosa.SelectedValue + "' AND os.ESTADO='A' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LlenaLstViewfecha()
        Dim cSql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc where  fecha >= '" + Me.dtdel.Value.Date + "' and fecha<='" + Me.dtal.Value.Date + "' AND os.ESTADO='A' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LlenaLstViewProveedor()
        Dim cSql As String = " select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc where  os.ruc='" + Me.lblruc.Text + "' AND os.ESTADO='A' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LLenarCombodocumentos()
        Dim csql As String = "select codtipodoc,descripcion from t_tipodoc ORDER BY descripcion  "
        FunDb.FillListaOrCombo(csql, cmbdoc, "descripcion", "codtipodoc")
    End Sub
    Sub LlenaLstViewdoc()
        Dim cSql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc where  os.codtipodoc='" + CStr(Me.cmbdoc.SelectedValue) + "'AND os.ESTADO='A' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LlenaLstViewExt()
        Dim cSql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc where os.ESTADO='E' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LlenaLstViewtodas()
        Dim cSql As String = "select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc where os.estado='0' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub LlenaLstViewdocpref()
        Dim cSql As String = " select NUMERO,convert(char(10),FECHA,103) as fecha,ttd.DESCRIPCION as documento,documento,py.DESCRIPCION as proyecto,ps.descripcion as Proveedor,subtotal,igv,retenciones,total,dni from dbo.T_ORDEN_Servicio os inner join dbo.T_TIPODOC ttd on ttd.CODTIPODOC= os.CODTIPODOC inner join dbo.T_PROYECTO py on py.CODPROYECTO=os.CODPROYECTO inner join dbo.T_Proveedores ps on ps.ruc=os.ruc  where  os.codtipodoc='" + CStr(Me.cmbdoc.SelectedValue) + "' and documento='" + Me.txtpreferencia.Text + "' AND os.ESTADO='A' order by fecha"
        FunDb.FillDataGridView(cSql, dgvDatos)
    End Sub
    Sub HeadGrid()
        With dgvDatos
            .Columns(0).HeaderText = "Número"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Fecha"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Documento"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Número"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Proyecto"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "Proveedor"
            .Columns(5).Width = 150
            .Columns(6).HeaderText = "Subtotal"
            .Columns(6).Width = 150
            .Columns(7).HeaderText = "Igv"
            .Columns(7).Width = 150
            .Columns(8).HeaderText = "Retenciones"
            .Columns(8).Width = 150
            .Columns(9).HeaderText = "Total"
            .Columns(9).Width = 150
            .Columns(10).HeaderText = "Usuario"
            .Columns(10).Width = 150
        End With
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        If Me.rbnumero.Checked = True Then
            LlenaLstViewnumero()
        ElseIf Me.rbextorno.Checked = True Then
            LlenaLstViewExt()
        ElseIf Me.rbfecha.Checked = True Then
            LlenaLstViewfecha()
        ElseIf Me.rbproveedor.Checked = True Then
            LlenaLstViewProveedor()
        ElseIf Me.rbdocumento.Checked = True Then
            If Me.chkpreferencia.Checked = False Then
                LlenaLstViewdoc()
            Else
                If Me.txtpreferencia.Text = "" Then
                    MessageBox.Show("Debe Ingresar un número válido de documento", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    LlenaLstViewdocpref()
                End If
            End If
        ElseIf Me.rbproyecto.Checked = True Then
            LlenaLstViewproyecto()
        End If
        HeadGrid()
    End Sub

    Private Sub btnbuscarprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarprov.Click
        FrmBuscarProveedor.lblflag.Text = 3
        FrmBuscarProveedor.ShowDialog()
    End Sub

    Private Sub rbnumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnumero.CheckedChanged
        Me.gbnumero.Visible = True
        Me.gbfecha.Visible = False
        Me.gbproyecto.Visible = False
        Me.gbproveedor.Visible = False
        Me.gbdoc.Visible = False
        LlenaLstViewtodas()
    End Sub

    Private Sub btnverdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverdetalle.Click
        If Me.rbextorno.Checked = True Then
            Dim cr As New Cr_ordenSEXT
            imp.reporte(cos.ImprimeOrden(Convert.ToString(Me.dgvDatos.CurrentRow.Cells(0).Value)), cr)
        Else
            Dim cr As New Cr_OrdenServicios
            imp.reporte(cos.ImprimeOrden(Convert.ToString(Me.dgvDatos.CurrentRow.Cells(0).Value)), cr)
        End If
    End Sub

    Private Sub bnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnreporte.Click
        If Me.rbfecha.Checked = True Then
            Dim cr As New Cr_OrdenFecha
            cr.DataDefinition.FormulaFields.Item("fechadel").Text = "'" + Me.dtdel.Text + "'"
            cr.DataDefinition.FormulaFields.Item("fechaal").Text = "'" + Me.dtal.Text + "'"
            imp.reporte(cos.REPORTEFECHAS(Me.dtdel.Value.Date, Me.dtal.Value.Date), cr)
        ElseIf Me.rbproveedor.Checked = True Then
            Dim cr As New Cr_OrdSerProveedor
            imp.reporte(cos.REPORTEPROVEEDOR(Me.lblruc.Text), cr)
        ElseIf Me.rbproyecto.Checked = True Then
            Dim cr As New Cr_OSProyecto
            imp.reporte(cos.REPORTEPROYECTO(Me.cmbglosa.SelectedValue), cr)
        ElseIf Me.rbdocumento.Checked = True And Me.chkpreferencia.Checked = False Then
            Dim cr As New Cr_OSDoc
            imp.reporte(cos.REPORTEDOC(Me.cmbdoc.SelectedValue), cr)
        End If

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select codnivel from t_usuarioS where dni='" + MDIPrincipal.tsbdni.Text + "' "
            dt = cFun.ConsultaX(csql)
            If CStr(dt.Rows(0).Item(0)) = "00002" Then
                FrmExtorno.flg = 1
                FrmExtorno.lblusuario.Text = Convert.ToString(Me.dgvDatos.CurrentRow.Cells(10).Value)
                FrmExtorno.lbladmin.Text = MDIPrincipal.tsbdni.Text
                FrmExtorno.ShowDialog()
            Else
                FrmAdmin.flg = 1
                FrmAdmin.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado" + ex.Message, " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Sub dtos()
        FrmExtorno.flg = 1
        FrmExtorno.lblusuario.Text = Convert.ToString(Me.dgvDatos.CurrentRow.Cells(10).Value)
    End Sub
    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        If SoloNumerosf(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvDatos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDatos.DoubleClick
        If Me.rbextorno.Checked = True Then
            Dim cr As New Cr_ordenSEXT
            imp.reporte(cos.ImprimeOrden(Convert.ToString(Me.dgvDatos.CurrentRow.Cells(0).Value)), cr)
        Else
            Dim cr As New Cr_OrdenServicios
            imp.reporte(cos.ImprimeOrden(Convert.ToString(Me.dgvDatos.CurrentRow.Cells(0).Value)), cr)
        End If
    End Sub

    Private Sub btnODetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnODetalle.Click
        Dim cr As New Cr_OrdenServicios
        If rbextorno.Checked = True Then
            imp.reporte(cos.ImprimeDOrden(Me.dtdel.Value.Date, Me.dtal.Value.Date, 2), cr)
        Else
            imp.reporte(cos.ImprimeDOrden(Me.dtdel.Value.Date, Me.dtal.Value.Date, 1), cr)
        End If
            End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub rbextorno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbextorno.CheckedChanged
        If Me.rbextorno.Checked = True Then
            Me.gbnumero.Visible = False
            Me.gbfecha.Visible = False
            Me.gbproyecto.Visible = False
            Me.gbproveedor.Visible = False
            Me.gbdoc.Visible = False
            Me.btneliminar.Enabled = False
            Me.bnreporte.Enabled = False
            btnODetalle.Enabled = False
        Else
            Me.btneliminar.Enabled = True
            Me.bnreporte.Enabled = True
            btnODetalle.Enabled = True
        End If
    End Sub
End Class