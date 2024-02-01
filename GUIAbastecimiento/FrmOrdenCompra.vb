Imports Datos
Imports Reglas
Imports Reportes
Imports System.Math

Public Class FrmOrdenCompra
    Dim FunDB As New cFuncionesDB
    Dim imp As New C_imprime
    Dim coc As New Cl_OrdenConpra
    Dim doc As New Cl_DetalleCompra
    Dim reserva As New Cl_Control
    Dim c As Integer = 0
    Dim contador As Integer = 0
    Dim cadj As New Cl_adjuntos
    Dim adjunto As String = ""

    Private Sub btnprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprov.Click
        FrmBuscarProveedor.lblflag.Text = "1"
        FrmBuscarProveedor.ShowDialog()
    End Sub

    Private Sub btnmaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaterial.Click
        FrmBuscarMaterial.lblflag.Text = "1"
        FrmBuscarMaterial.ShowDialog()
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        agregaItem()
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
                    Me.lbltotalf.Text = "0.00"
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
        Me.lbltotalf.Text = CDbl(Me.lbltotal.Text)
        Me.txtmontoletras.Text = Letras(Me.lbltotalf.Text)
    End Sub
    Sub LLenarCombodocumentos()
        Dim csql As String = "select codtipodoc,descripcion from t_tipodoc ORDER BY descripcion  "
        FunDB.FillListaOrCombo(csql, cmbdoc, "descripcion", "codtipodoc")
    End Sub
    Sub LLenarComboglosa()
        Dim csql As String = "select codproyecto,descripcion from t_proyecto  where estado='1'  order by descripcion"
        FunDB.FillListaOrCombo(csql, cmbglosa, "descripcion", "codproyecto")
    End Sub

    Private Sub FrmOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarComboglosa()
        LLenarCombodocumentos()
        Me.GroupBox5.Enabled = False
        Me.lbltotal.Text = "0.00"
        Me.lblsubtotal.Text = "0.00"
    End Sub

    Private Sub cmbdoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdoc.SelectedIndexChanged
        If Me.cmbdoc.Text = "FACTURA" Then
            GetDatosIGV()
        ElseIf Me.cmbdoc.Text = "RECIBO POR HONORARIOS" Then
            GetDatosRETENCIONES()
        ElseIf Me.cmbdoc.Text = "BOLETA" Then
            Me.lbligv.Text = "0.00"
            GetDatosNINGUNO()
            Me.lblretencion.Text = "0.00"
        ElseIf Me.cmbdoc.Text = "RECIBOS" Then
            GetDatosIGV()
        ElseIf Me.cmbdoc.Text = "RECIBOS TELEFONICA" Then
            Me.lbligv.Text = "0.00"
            GetDatosNINGUNO()
            Me.lblretencion.Text = "0.00"
        End If
        Me.lbltotal.Text = "0.00"
        sumar()
    End Sub
    Sub GetDatosIGV()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select porcentaje,cod_impuesto from t_IMPUESTO WHERE DESCRIPCION='IGV' AND ANNIO=YEAR(GETDATE())"
            dt = cFun.ConsultaX(csql)
            Me.lbligv.Text = CStr(CDbl(dt.Rows(0).Item(0)) + 1)
            Me.lblimp.Text = CStr(dt.Rows(0).Item(1))
            Me.lblretencion.Text = "0.00"
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado" + ex.Message, " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub GetDatosRETENCIONES()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select porcentaje,cod_impuesto from t_IMPUESTO  WHERE DESCRIPCION='RETENCION' and annio=year(getdate())"
            dt = cFun.ConsultaX(csql)
            Me.lblretencion.Text = CStr(dt.Rows(0).Item(0))
            Me.lblimp.Text = CStr(dt.Rows(0).Item(1))
            Me.lbligv.Text = "0.00"
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado" + ex.Message, " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub GetDatosNINGUNO()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select porcentaje,cod_impuesto from t_IMPUESTO  WHERE DESCRIPCION='NINGUNO'"
            dt = cFun.ConsultaX(csql)
            Me.lblretencion.Text = CStr(dt.Rows(0).Item(0))
            Me.lblimp.Text = CStr(dt.Rows(0).Item(1))
            Me.lbligv.Text = "0.00"
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado" + ex.Message, " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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

    Private Sub chkImpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImpuesto.CheckedChanged
        total()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.GroupBox5.Enabled = False
        Me.adjunto = ""
        Me.lvwDoc.Items.Clear()
        Me.lbltotal.Text = "0.00"
        Me.lbltotalf.Text = "0.00"
        Me.lblsubtotal.Text = "0.00"
        Me.lblimpuesto.ResetText()
        Me.lblruc.ResetText()
        Me.lblprov.ResetText()
        Me.lbldir.ResetText()
        Me.lblcodigo.ResetText()
        Me.lbldescripción.ResetText()
        Me.txtcantidad.ResetText()
        Me.txtpu.ResetText()
        Me.lvwitem.Items.Clear()
        Me.txtndoc.ResetText()
        Me.LBLorden.ResetText()
        Me.txtmontoletras.ResetText()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.GroupBox5.Enabled = True
        Me.LBLorden.Text = Format(CInt(coc.GeneraCodOrden()), "0000000000")
        Me.lbltotal.Text = "0.00"
        Me.lbltipo.Text = "N"
    End Sub
    Sub adjuntos()
        For i = 0 To Me.lvwDoc.Items.Count - 1
            If adjunto = "" Then
                adjunto = Me.lvwDoc.Items(i).SubItems(0).Text
            Else
                adjunto = adjunto & "," & Me.lvwDoc.Items(i).SubItems(0).Text
            End If

        Next
    End Sub
    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim j As Integer = 0
        If Me.txtndoc.Text = "" Or Me.lblruc.Text = "" Or Me.lvwitem.Items.Count = 0 Then
            MessageBox.Show("Complete los Datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Evaluar si es Reserva o Registro Normal
            If lbltipo.Text = "N" Then
                Me.LBLorden.Text = Format(CInt(coc.GeneraCodOrden()) + 1, "0000000000")
            Else
                Me.LBLorden.Text = Me.LBLorden.Text
            End If

            Me.lbltotalf.Text = Me.lbltotal.Text
            coc.Hora = MDIPrincipal.tsbhora.Text
            coc.Dni = MDIPrincipal.tsbdni.Text
            coc.Totall = Me.txtmontoletras.Text
            coc.Numero = CStr(Me.LBLorden.Text)
            coc.Fecha = Me.dtfecha.Text
            coc.CodTipoDoc = Me.cmbdoc.SelectedValue
            coc.Documento = Me.txtndoc.Text
            coc.CodProyecto = Me.cmbglosa.SelectedValue
            coc.Subtotal = Me.lblsubtotal.Text
            coc.Total = Me.lbltotal.Text
            coc.Ruc = Me.lblruc.Text
            If Me.cmbdoc.Text = "FACTURA" Then
                coc.Igv = Me.lblimpuesto.Text
                coc.Retenciones = "0.00"
            ElseIf Me.cmbdoc.Text = "BOLETA" Then
                coc.Igv = "0.00"
                coc.Retenciones = "0.00"
            ElseIf Me.cmbdoc.Text = "RECIBO POR HONORARIOS" Then
                coc.Igv = "0.00"
                coc.Retenciones = Me.lblimpuesto.Text
            ElseIf Me.cmbdoc.Text = "RECIBOS" Then
                coc.Igv = Me.lblimpuesto.Text
                coc.Retenciones = "0.00"
            ElseIf Me.cmbdoc.Text = "RECIBOS TELEFONICA" Then
                coc.Igv = "0.00"
                coc.Retenciones = "0.00"
            End If
            coc.CodImpuesto = CInt(Me.lblimp.Text)
            adjuntos()
            coc.Adjunto = adjunto
            If coc.AltaOrdenCompra() = True Then
                For i = 0 To Me.lvwitem.Items.Count - 1
                    doc.Numero = Me.LBLorden.Text
                    doc.Item = Me.lvwitem.Items(i).SubItems(0).Text
                    doc.CodUnidad = Me.lvwitem.Items(i).SubItems(2).Text
                    doc.Cantidad = Me.lvwitem.Items(i).SubItems(4).Text
                    doc.Precio_u = Me.lvwitem.Items(i).SubItems(5).Text
                    doc.Subtotal = Me.lvwitem.Items(i).SubItems(6).Text
                    doc.AltaDetalle()
                Next
                For j = 0 To Me.lvwDoc.Items.Count - 1
                    cadj.Numero = Me.LBLorden.Text
                    cadj.Descripcion = Me.lvwDoc.Items(j).SubItems(0).Text
                    cadj.AltaAdjunto(1)
                Next

                'Se registra la orden en la tabla de Control
                reserva.Num_oc = Me.LBLorden.Text
                reserva.Estado_OC = "A"

                If lbltipo.Text = "N" Then
                    reserva.RegistraOC()
                Else
                    reserva.ActualizaOC(Me.LBLorden.Text)
                End If


                If Me.chkvis.Checked = True Then
                    reporte()
                End If
            End If
            Me.btncancelar.PerformClick()
        End If
    End Sub
    Sub reporte()
        Dim cr As New CrOrdenCompra
        'cr.DataDefinition.FormulaFields.Item("numeroletra").Text = "'" + Letras(Me.lbltotalf.Text) + "'"
        imp.reporte(coc.ImprimeOrden(Me.LBLorden.Text), cr)
    End Sub

    Private Sub txtcantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.GotFocus
        Me.txtcantidad.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If SoloNumerosD(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
        If CShort(Asc(e.KeyChar)) = 13 Then
            txtpu.Focus()
        End If

    End Sub

    Private Sub txtpu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpu.GotFocus
        Me.txtpu.BackColor = Color.GreenYellow
    End Sub


    Private Sub txtpu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpu.KeyPress
        If SoloNumerosD(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
        If CShort(Asc(e.KeyChar)) = 13 Then
            cmbforma.Focus()
        End If

    End Sub

    Private Sub txtcantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.LostFocus
        Me.txtcantidad.BackColor = Color.White
    End Sub

    Private Sub txtpu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpu.LostFocus
        Me.txtpu.BackColor = Color.White
    End Sub

    Private Sub txtndoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtndoc.GotFocus
        Me.txtndoc.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtndoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtndoc.LostFocus
        Me.txtndoc.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        agregaadjunto()
    End Sub

    Private Sub lvwDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwDoc.DoubleClick
        Me.txtdoc.Text = Me.lvwDoc.SelectedItems(0).SubItems(0).Text
        Me.lvwDoc.Items.RemoveAt(Me.lvwDoc.SelectedItems(0).Index)
    End Sub

    Sub agregaadjunto()
        Me.lvwDoc.Items.Add(Me.txtdoc.Text)
        Me.txtdoc.ResetText()
    End Sub

    Private Sub txtdoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdoc.GotFocus
        Me.txtdoc.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtdoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdoc.KeyPress
        If CShort(Asc(e.KeyChar)) = 13 Then
            agregaadjunto()
        End If
    End Sub

    Private Sub txtdoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdoc.LostFocus
        Me.txtdoc.BackColor = Color.White
    End Sub

    Private Sub txtdoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdoc.TextChanged
        Me.txtdoc.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub cmbforma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbforma.KeyPress
        If CShort(Asc(e.KeyChar)) = 13 Then
            btnagregar.Focus()
        End If
    End Sub

    Private Sub txtmontoletras_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmontoletras.DoubleClick
        Me.txtmontoletras.ReadOnly = False
        Me.txtmontoletras.BackColor = Color.White
        Me.txtmontoletras.ForeColor = Color.Black
    End Sub


    Private Sub txtmontoletras_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmontoletras.LostFocus
        Me.txtmontoletras.ReadOnly = True
        Me.txtmontoletras.BackColor = Color.LightSlateGray
        Me.txtmontoletras.ForeColor = Color.White
    End Sub

    Private Sub btnReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReserva.Click
        FrmReservaOC.Show()
    End Sub

    Private Sub btn_sunat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sunat.Click
        FrmNavegaSunat.Show()
        FrmNavegaSunat.browser_sunat.Navigate("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")

    End Sub
End Class