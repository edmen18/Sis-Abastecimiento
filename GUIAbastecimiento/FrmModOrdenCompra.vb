Imports Datos
Imports Reglas
Imports Reportes
Imports System.Math
Public Class FrmModOrdenCompra
    Dim FunDB As New cFuncionesDB
    Dim imp As New C_imprime
    Dim coc As New Cl_OrdenConpra
    Dim doc As New Cl_DetalleCompra
    Dim reserva As New Cl_Control
    Dim c As Integer = 0
    Dim contador As Integer = 0
    Dim cadj As New Cl_adjuntos
    Dim adjunto As String = ""

    Private Sub FrmModOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarComboglosa()
        LLenarCombodocumentos()
        Me.GroupBox5.Enabled = False
        Me.lbltotal.Text = "0.00"
        Me.lblsubtotal.Text = "0.00"
    End Sub
    Sub LLenarCombodocumentos()
        Dim csql As String = "select codtipodoc,descripcion from t_tipodoc ORDER BY descripcion  "
        FunDB.FillListaOrCombo(csql, cmbdoc, "descripcion", "codtipodoc")
    End Sub
    Sub LLenarComboglosa()
        Dim csql As String = "select codproyecto,descripcion from t_proyecto  where estado='1'  order by descripcion"
        FunDB.FillListaOrCombo(csql, cmbglosa, "descripcion", "codproyecto")
    End Sub

    Private Sub lblver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblver.Click
        FrmConsultaOC.ind = 1
        FrmConsultaOC.Show()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.GroupBox5.Enabled = True
        'Me.lblorden.Text = Format(CInt(coc.GeneraCodOrden()), "0000000000")
        Me.lbltotal.Text = "0.00"
        Me.lbltipo.Text = "N"
    End Sub
    Sub PROVEEDOR()
        Dim CSQL As String = "select p.ruc, descripcion,direccion from t_proveedores p inner join t_orden_compra c on p.ruc=c.ruc where c.numero='" + Me.lblorden.Text + "'"
        Me.lblruc.Text = FunDB.ConsultaUnDato(CSQL, 0)
        Me.lblprov.Text = FunDB.ConsultaUnDato(CSQL, 1)
        Me.lbldir.Text = FunDB.ConsultaUnDato(CSQL, 2)
    End Sub
    Sub GLOSAYCOMPROBANTE()
        Dim CSQL As String = "SELECT TD.CODTIPODOC,TD.DESCRIPCION,DOCUMENTO,PY.CODPROYECTO,PY.DESCRIPCION,igv,retenciones,total,subtotal FROM dbo.T_ORDEN_COMPRA OC INNER JOIN dbo.T_TIPODOC TD ON OC.CODTIPODOC=TD.CODTIPODOC INNER JOIN dbo.T_PROYECTO PY ON PY.CODPROYECTO=OC.CODPROYECTO WHERE OC.NUMERO='" + Me.lblorden.Text + "'"
        Me.cmbdoc.SelectedValue = FunDB.ConsultaUnDato(CSQL, 0)
        Me.cmbdoc.Text = FunDB.ConsultaUnDato(CSQL, 1)
        Me.txtndoc.Text = FunDB.ConsultaUnDato(CSQL, 2)
        Me.cmbglosa.SelectedValue = FunDB.ConsultaUnDato(CSQL, 3)
        Me.cmbglosa.Text = FunDB.ConsultaUnDato(CSQL, 4)
        Me.lbligv.Text = FunDB.ConsultaUnDato(CSQL, 5)
        Me.lblretencion.Text = FunDB.ConsultaUnDato(CSQL, 6)
        Me.lbltotal.Text = FunDB.ConsultaUnDato(CSQL, 7)
        Me.lblsubtotal.Text = FunDB.ConsultaUnDato(CSQL, 8)
    End Sub
    Sub llamadas()
        PROVEEDOR()
        GLOSAYCOMPROBANTE()
        impuestos()
        detalle()
        docadjunto()
    End Sub
    Sub docadjunto()
        Dim csql As String = "select ADJUNTO from dbo.T_ORDEN_COMPRA where NUMERO='" + Me.lblorden.Text + "'"
        FunDB.FillListview(csql, Me.lvwDoc)
    End Sub
    Sub impuestos()
        If cmbdoc.SelectedValue = "1" Or cmbdoc.SelectedValue = "2" Or cmbdoc.SelectedValue = "3" Or cmbdoc.SelectedValue = "4" Or cmbdoc.SelectedValue = "5" Or cmbdoc.SelectedValue = "6" Or cmbdoc.SelectedValue = "7" Then
            If CDbl(Me.lblsubtotal.Text) = CDbl(lbltotal.Text) Then
                Me.chkImpuesto.Checked = True
                Me.chkretencion.Checked = False
            End If
        End If
        If CDbl(Me.lblsubtotal.Text) <> CDbl(lbltotal.Text) Then
            If cmbdoc.SelectedValue = "3" Then
                Me.chkImpuesto.Checked = False
                Me.lblimpuesto.Text = CDbl(lbltotal.Text) - CDbl(Me.lblsubtotal.Text)
            End If
            If Me.cmbdoc.SelectedValue = "1" Or Me.cmbdoc.SelectedValue = "7" Then
                Me.chkretencion.Checked = True
                Me.chkImpuesto.Checked = False
                Me.lblimpuesto.Text = CDbl(lbltotal.Text) - CDbl(Me.lblsubtotal.Text)
            End If
        End If
    End Sub
    Sub detalle()
        Dim csql As String = "select m.ITEM,m.DESCRIPCON,u.COD_UNIDAD,u.DESCRIPCION,CANTIDAD,PRECIO_U,SUBTOTAL from dbo.T_DETALLE_ORDEN_COMPRA do inner join dbo.T_MATERIAL m on m.ITEM=do.ITEM inner join dbo.T_UNIDAD u on u.COD_UNIDAD=do.COD_UNIDAD where numero='" + Me.lblorden.Text + "'"
        FunDB.FillListview(csql, Me.lvwitem)
    End Sub
    Sub agregaItem()
        If Me.lblcodigo.Text = "" Then
            MessageBox.Show("Operación no válida, debe buscar un material", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For i = 0 To Me.lvwitem.Items.Count - 1
                If Me.lvwitem.Items(i).SubItems(0).Text = Me.lblcodigo.Text Then
                    contador = contador + 1
                End If
            Next
            If contador > 0 Then
                MessageBox.Show("Operación no válida, el material ya se encuentra registrado", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Me.lblcodigo.Text = "" Or Me.txtcantidad.Text = "" Or Me.txtpu.Text = "" Then
                    MessageBox.Show("Complete los datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Try
                        c = Me.lvwitem.Items.Count
                        Me.lvwitem.Items.Add(Me.lblcodigo.Text)
                        Me.lvwitem.Items(c).SubItems.Add(Me.lbldescripción.Text)
                        Me.lvwitem.Items(c).SubItems.Add(Me.cmbforma.SelectedValue)
                        Me.lvwitem.Items(c).SubItems.Add(Me.cmbforma.Text)
                        Me.lvwitem.Items(c).SubItems.Add(CStr(Format(CDbl(Me.txtcantidad.Text), "#,##0.00")))
                        Me.lvwitem.Items(c).SubItems.Add(CStr(Format(CDbl(Me.txtpu.Text), "#,##0.00")))
                        Me.lvwitem.Items(c).SubItems.Add(CStr(Format(CDbl(Me.txtcantidad.Text) * CDbl(Me.txtpu.Text), "#,##0.00")))
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
        c = 0
        contador = 0
        sumar()
    End Sub
    Sub sumar()
        Try
            Me.lbltotal.Text = "0.00"
            For i = 0 To Me.lvwitem.Items.Count - 1
                Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        total()
    End Sub
    Sub total()
        If Me.lbltotal.Text <> "" Then
            If Me.cmbdoc.Text = "RECIBO POR HONORARIOS" Then
                If Me.cmbdoc.Text = "RECIBO POR HONORARIOS" And CDbl(Me.lbltotal.Text) >= 1500 And chkImpuesto.Checked = False Then
                    Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lbltotal.Text) * CDbl(Me.lblretencion.Text)), "#,##0.00")
                    Me.lblimpuesto.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lblsubtotal.Text)), "#,##0.00")
                    Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text), "#,##0.00")
                    Me.lbltotal.Text = Format(CDbl(Me.lblsubtotal.Text) - CDbl(Me.lblimpuesto.Text), "#,##0.00")
                    'Me.lbltotalf.Text = CDbl(Me.lblsubtotal.Text) - CDbl(Me.lblimpuesto.Text)

                ElseIf (CDbl(Me.lbltotal.Text) >= 1500 Or CDbl(Me.lblsubtotal.Text) <= 1500) And chkImpuesto.Checked = True Then
                    Me.lblimpuesto.Text = "0.00"
                    Me.lbltotal.Text = "0.00"
                    'Me.lbltotalf.Text = "0.00"
                    For i = 0 To Me.lvwitem.Items.Count - 1
                        Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
                        '   Me.lbltotalf.Text = CDbl(Me.lbltotalf.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text)
                    Next
                    Me.lblsubtotal.Text = Me.lbltotal.Text
                ElseIf Me.cmbdoc.Text = "RECIBO POR HONORARIOS" And CDbl(Me.lbltotal.Text) < 1500 Then
                    Me.lblimpuesto.Text = "0.00"
                    Me.lblsubtotal.Text = Me.lbltotal.Text
                End If
            End If
            If Me.cmbdoc.Text = "FACTURA" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                'Me.lbltotalf.Text = "0.00"
                For i = 0 To Me.lvwitem.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
                    '   Me.lbltotalf.Text = CDbl(Me.lbltotalf.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text)
                Next
                Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text) / CDbl(Me.lbligv.Text), "#,##0.00")
                Me.lblimpuesto.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lblsubtotal.Text)), "#,##0.00")
            End If
            If Me.cmbdoc.Text = "RECIBOS" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                ' Me.lbltotalf.Text = "0.00"
                For i = 0 To Me.lvwitem.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
                    '    Me.lbltotalf.Text = Format(CDbl(Me.lbltotalf.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
                Next
                Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text) / CDbl(Me.lbligv.Text), "#,##0.00")
                Me.lblimpuesto.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lblsubtotal.Text)), "#,##0.00")
            End If
            If Me.cmbdoc.Text = "BOLETA" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                'Me.lbltotalf.Text = "0.00"
                For i = 0 To Me.lvwitem.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
                    '   Me.lbltotalf.Text = CDbl(Me.lbltotalf.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text)
                Next
                Me.lblsubtotal.Text = Me.lbltotal.Text
            End If
            If Me.cmbdoc.Text = "RECIBOS TELEFONICA" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                'Me.lbltotalf.Text = "0.00"
                For i = 0 To Me.lvwitem.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text), "#,##0.00")
                    '   Me.lbltotalf.Text = CDbl(Me.lbltotalf.Text) + CDbl(Me.lvwitem.Items(i).SubItems(6).Text)
                Next
                Me.lblsubtotal.Text = Me.lbltotal.Text
            End If

        End If
        lbltotal.Text = CStr(Round(CDbl(lbltotal.Text), 2, MidpointRounding.ToEven))
        'Me.lbltotalf.Text = CDbl(Me.lbltotal.Text)
        'Me.txtmontoletras.Text = Letras(Me.lbltotalf.Text)
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        agregaItem()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        delOne()
        sumar()
        total()
    End Sub
    Sub delOne()
        If Me.lvwitem.SelectedItems.Count > 0 Then
            Me.lvwitem.Items.RemoveAt(Me.lvwitem.SelectedItems(0).Index)
        Else
            MessageBox.Show("No ha seleccionado el elemento a quitar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class