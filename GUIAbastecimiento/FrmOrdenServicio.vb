Imports Datos
Imports Reglas
Imports Reportes
Imports System.Math
Public Class FrmOrdenServicio
    Dim FunDB As New cFuncionesDB
    Dim cos As New Cl_OrdenServicio
    Dim dos As New Cl_DetalleOrdenServicios
    Dim reserva As New Cl_Control
    Dim imp As New C_imprime
    Dim c As Integer = 0
    Dim contador As Integer = 0
    Dim adjunto As String = ""
    Dim cadj As New Cl_adjuntos

    Private Sub FrmOrdenServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.FromArgb(146, 172, 201)
        LLenarCombodocumentos()
        LLenarComboglosa()
        Me.GroupBox5.Enabled = False
    End Sub
    Sub LLenarCombodocumentos()
        Dim csql As String = "select codtipodoc,descripcion from t_tipodoc ORDER BY descripcion  "
        FunDB.FillListaOrCombo(csql, cmbdoc, "descripcion", "codtipodoc")
    End Sub
    Sub LLenarComboglosa()
        Dim csql As String = "select codproyecto,descripcion from t_proyecto  where estado='1'  order by descripcion"
        FunDB.FillListaOrCombo(csql, cmbglosa, "descripcion", "codproyecto")
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        agregaItem()
    End Sub
    Sub agregaItem()
        If Me.txtservicio.Text = "" Or Me.txtvalor.Text = "" Then
            MessageBox.Show("Operación no válida, debe ingrear un servicio y/o su valor", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For i = 0 To Me.lvwitems.Items.Count - 1
                If Me.lvwitems.Items(i).SubItems(0).Text = Me.txtservicio.Text Then
                    contador = contador + 1
                End If
            Next
            If contador > 0 Then
                MessageBox.Show("Operación no válida, la unidad ya se encuentra registrada", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Me.txtservicio.Text = "" Or Me.txtvalor.Text = "" Then
                    MessageBox.Show("Complete los datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    c = Me.lvwitems.Items.Count
                    Me.lvwitems.Items.Add(Me.txtservicio.Text)
                    Me.lvwitems.Items(c).SubItems.Add(Format(CDbl(Me.txtvalor.Text), "#,##0.00"))
                End If
            End If
        End If
        c = 0
        contador = 0
        sumar()
    End Sub
    Sub sumar()
        Me.lbltotal.Text = "0.00"
        For i = 0 To Me.lvwitems.Items.Count - 1
            Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitems.Items(i).SubItems(1).Text), "#,##0.00")
        Next
        total()
    End Sub

    Private Sub cmbdoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdoc.SelectedIndexChanged
        If Me.cmbdoc.Text = "FACTURA" Then
            GetDatosIGV()
        ElseIf Me.cmbdoc.Text = "RECIBO POR HONORARIOS" Then
            GetDatosRETENCIONES()
        ElseIf Me.cmbdoc.Text = "BOLETA" Then
            GetDatosBoleta()
        ElseIf Me.cmbdoc.Text = "RECIBOS" Then
            GetDatosIGV()
        ElseIf Me.cmbdoc.Text = "RECIBOS TELEFONICA" Then
            Me.lbligv.Text = "0.00"
            GetDatosBoleta()
            Me.lblretencion.Text = "0.00"
        End If
        sumar()
    End Sub
    Sub GetDatosIGV()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select porcentaje,cod_impuesto from t_IMPUESTO WHERE DESCRIPCION='IGV'AND ANNIO=YEAR(GETDATE())"
            dt = cFun.ConsultaX(csql)
            Me.lbligv.Text = CDbl(dt.Rows(0).Item(0)) + 1
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
    Sub GetDatosBoleta()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select porcentaje,cod_impuesto from t_IMPUESTO  WHERE DESCRIPCION='NINGUNO' "
            dt = cFun.ConsultaX(csql)
            Me.lblretencion.Text = CStr(dt.Rows(0).Item(0))
            Me.lblimp.Text = CStr(dt.Rows(0).Item(1))
            Me.lbligv.Text = "0.00"
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado" + ex.Message, " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub total()
        If Me.lbltotal.Text <> "" Then
            Me.lblsubtotal.Text = "0.00"
            If Me.cmbdoc.Text = "RECIBO POR HONORARIOS" Then
                If Me.cmbdoc.Text = "RECIBO POR HONORARIOS" And CDbl(Me.lbltotal.Text) >= 1500 And chkImpuesto.Checked = False Then
                    Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lbltotal.Text) * CDbl(Me.lblretencion.Text)), "#,##0.00")
                    Me.lblimpuesto.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lblsubtotal.Text)), "#,##0.00")
                    Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text), "#,##0.00")
                    Me.lbltotal.Text = Format(CDbl(Me.lblsubtotal.Text) - CDbl(Me.lblimpuesto.Text), "#,##0.00")

                ElseIf (CDbl(Me.lbltotal.Text) > 1500 Or CDbl(Me.lblsubtotal.Text) < 1500) And chkImpuesto.Checked = True Then
                    Me.lblimpuesto.Text = "0.00"
                    Me.lbltotal.Text = "0.00"
                    Me.lbltotalf.Text = "0.00"
                    For i = 0 To Me.lvwitems.Items.Count - 1
                        Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitems.Items(i).SubItems(1).Text), "#,##0.00")
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
                For i = 0 To Me.lvwitems.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitems.Items(i).SubItems(1).Text), "#,##0.00")
                Next
                Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text) / CDbl(Me.lbligv.Text), "#,##0.00")
                Me.lblimpuesto.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lblsubtotal.Text)), "#,##0.00")
            End If
            If Me.cmbdoc.Text = "RECIBOS" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                For i = 0 To Me.lvwitems.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitems.Items(i).SubItems(1).Text), "#,##0.00")
                Next
                Me.lblsubtotal.Text = Format(CDbl(Me.lbltotal.Text) / CDbl(Me.lbligv.Text), "#,##0.00")
                Me.lblimpuesto.Text = Format(CDbl(Me.lbltotal.Text) - (CDbl(Me.lblsubtotal.Text)), "#,##0.00")
            End If
            If Me.cmbdoc.Text = "BOLETA" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                For i = 0 To Me.lvwitems.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitems.Items(i).SubItems(1).Text), "#,##0.00")
                Next
                Me.lblsubtotal.Text = Me.lbltotal.Text
            End If
            If Me.cmbdoc.Text = "RECIBOS TELEFONICA" Then
                Me.lblimpuesto.Text = "0.00"
                Me.lblsubtotal.Text = "0.00"
                Me.lbltotal.Text = "0.00"
                For i = 0 To Me.lvwitems.Items.Count - 1
                    Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwitems.Items(i).SubItems(1).Text), "#,##0.00")
                Next
                Me.lblsubtotal.Text = Me.lbltotal.Text
            End If
        End If
        Me.lbltotalf.Text = CDbl(Me.lbltotal.Text)
        Me.txtmontoletras.Text = Letras(Me.lbltotalf.Text)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        delOne()
        sumar()
        total()
    End Sub
    Sub delOne()
        If Me.lvwitems.SelectedItems.Count > 0 Then
            Me.lvwitems.Items.RemoveAt(Me.lvwitems.SelectedItems(0).Index)
        Else
            MessageBox.Show("No ha seleccionado el elemento a quitar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub chkImpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImpuesto.CheckedChanged
        total()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        adjunto = ""
        Me.lbltotal.Text = "0.00"
        Me.lbltotalf.Text = "0.00"
        Me.lblsubtotal.ResetText()
        Me.lblimpuesto.ResetText()
        Me.lblruc.ResetText()
        Me.lblrazon.ResetText()
        Me.lbldir.ResetText()
        Me.txtvalor.ResetText()
        Me.txtservicio.ResetText()
        Me.lvwitems.Items.Clear()
        Me.txtndoc.ResetText()
        Me.LBLorden.ResetText()
        Me.GroupBox5.Enabled = False
        Me.lvwDoc.Items.Clear()
        Me.txtmontoletras.ResetText()
        Me.lbltipo.ResetText()
    End Sub

    Private Sub btnprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprov.Click
        FrmBuscarProveedor.lblflag.Text = "4"
        FrmBuscarProveedor.ShowDialog()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.GroupBox5.Enabled = True
        Me.LBLorden.Text = Format(CInt(cos.GeneraCodOrden()), "0000000000")
        Me.lbltipo.Text = "N"
    End Sub
    Sub reporte()
        Dim cr As New Cr_OrdenServicios
        'cr.DataDefinition.FormulaFields.Item("numeroletras").Text = "'" + Letras(Me.lbltotalf.Text) + "'"
        imp.reporte(cos.ImprimeOrden(Me.LBLorden.Text), cr)
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
        If Me.txtndoc.Text = "" Or Me.lblruc.Text = "" Or Me.lvwitems.Items.Count = 0 Then
            MessageBox.Show("Complete los Datos antes de continuar", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Evaluar si es Reserva o Registro Normal
            If lbltipo.Text = "N" Then
                Me.LBLorden.Text = Format(CInt(cos.GeneraCodOrden()) + 1, "0000000000")
            Else
                Me.LBLorden.Text = Me.LBLorden.Text
            End If

            '************************************************************************
            ''Me.lbltotalf.Text = Me.lbltotal.Text
            cos.Hora = MDIPrincipal.tsbhora.Text
            cos.Dni = MDIPrincipal.tsbdni.Text
            cos.Totall = Me.txtmontoletras.Text
            cos.Numero = CStr(Me.LBLorden.Text)
            cos.Fecha = Me.dtfecha.Text
            cos.CodTipoDoc = Me.cmbdoc.SelectedValue
            cos.Documento = Me.txtndoc.Text
            cos.CodProyecto = Me.cmbglosa.SelectedValue
            cos.Subtotal = Me.lblsubtotal.Text
            cos.Total = Me.lbltotal.Text
            cos.Ruc = Me.lblruc.Text
            If Me.cmbdoc.Text = "FACTURA" Or Me.cmbdoc.Text = "RECIBOS" Then
                cos.Igv = Me.lblimpuesto.Text
                cos.Retenciones = "0.00"
            ElseIf Me.cmbdoc.Text = "RECIBO POR HONORARIOS" Then
                cos.Igv = "0.00"
                cos.Retenciones = Me.lblimpuesto.Text
            ElseIf Me.cmbdoc.Text = "BOLETA" Or Me.cmbdoc.Text = "RECIBOS TELEFONICA" Then
                cos.Igv = "0.00"
                cos.Retenciones = Me.lblimpuesto.Text
            End If
            cos.CodImpuesto = CInt(Me.lblimp.Text)
            adjuntos()
            cos.Adjunto = adjunto
            If cos.AltaOrdenServicio() = True Then
                For i = 0 To Me.lvwitems.Items.Count - 1
                    dos.Numero = Me.LBLorden.Text
                    dos.Descripcion = Me.lvwitems.Items(i).SubItems(0).Text
                    dos.Valor = Me.lvwitems.Items(i).SubItems(1).Text
                    dos.AltaDetalle()
                Next
                For j = 0 To Me.lvwDoc.Items.Count - 1
                    cadj.Numero = Me.LBLorden.Text
                    cadj.Descripcion = Me.lvwDoc.Items(j).SubItems(0).Text
                    cadj.AltaAdjunto(2)
                Next
                'Se registra la orden en la tabla de Control
                reserva.Num_os = Me.LBLorden.Text
                reserva.Estado = "A"

                If lbltipo.Text = "N" Then
                    reserva.RegistraOS()
                Else
                    reserva.ActualizaOS(Me.LBLorden.Text)
                End If

                If Me.chkvis.Checked = True Then
                    reporte()
                End If
            End If
            btncancelar.PerformClick()
        End If

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtvalor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalor.GotFocus
        Me.txtvalor.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtvalor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalor.KeyPress
        If SoloNumerosD(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
        If CShort(Asc(e.KeyChar)) = 13 Then
            Me.btnagregar.Focus()
        End If
    End Sub

    Private Sub txtservicio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtservicio.GotFocus
        Me.txtservicio.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtservicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtservicio.LostFocus
        Me.txtservicio.BackColor = Color.White
    End Sub

   
    Private Sub txtvalor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalor.LostFocus
        Me.txtvalor.BackColor = Color.White
    End Sub

    Private Sub txtservicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservicio.TextChanged
        txtservicio.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtndoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtndoc.GotFocus
        Me.txtndoc.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtndoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtndoc.LostFocus
        Me.txtndoc.BackColor = Color.White
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        agregadoc()
    End Sub

    Sub agregadoc()
        Me.lvwDoc.Items.Add(Me.txtdoc.Text)
        Me.txtdoc.ResetText()
    End Sub

    Private Sub txtdoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdoc.GotFocus
        Me.txtdoc.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtdoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdoc.KeyPress
        If CShort(Asc(e.KeyChar)) = 13 Then
            agregadoc()
        End If
    End Sub

    Private Sub txtdoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdoc.LostFocus
        Me.txtdoc.BackColor = Color.White
    End Sub

    Private Sub txtdoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdoc.TextChanged
        Me.txtdoc.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub lvwDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwDoc.DoubleClick
        Me.txtdoc.Text = Me.lvwDoc.SelectedItems(0).SubItems(0).Text
        Me.lvwDoc.Items.RemoveAt(Me.lvwDoc.SelectedItems(0).Index)
    End Sub

    Private Sub btnagregar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnagregar.KeyPress
        If CShort(Asc(e.KeyChar)) = 13 Then
            agregaItem()
            cmbdoc.Focus()
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
        FrmReserva.Show()
    End Sub

   
    Private Sub btn_sunat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sunat.Click
        FrmNavegaSunat.Show()
        FrmNavegaSunat.browser_sunat.Navigate("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")
    End Sub
End Class