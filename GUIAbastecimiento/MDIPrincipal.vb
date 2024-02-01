Imports System.Windows.Forms

Public Class MDIPrincipal

    Sub MostrarForm(ByRef Formx As Form)
        Formx.TopLevel = False
        Formx.Parent = Panel1
        Formx.Show()
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        MostrarForm(FrmConvenios)
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        MostrarForm(FrmMaterial)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        MostrarForm(FrmProveedores)
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        MostrarForm(FrmRepOS)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        MostrarForm(FrmUnidad)
    End Sub

    

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        MostrarForm(FrmProyectos)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        MostrarForm(FrmOrdenCompra)
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        MostrarForm(FrmOrdenServicio)
    End Sub

    Private Sub OrdenesDeServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesDeServicioToolStripMenuItem.Click
        MostrarForm(FrmConsultaOS)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        MostrarForm(FrmConsultaOC)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        MostrarForm(FrmConvenios)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarForm(FrmMaterial)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarForm(FrmConvenios)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarForm(FrmOrdenCompra)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarForm(FrmOrdenServicio)
    End Sub

    Private Sub OrdCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdCompraToolStripMenuItem.Click
        MostrarForm(FrmRepOC)
    End Sub

    Private Sub OrdServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdServicioToolStripMenuItem.Click
        MostrarForm(FrmRepOS)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        MostrarForm(FrmImpuestos)
    End Sub


    Private Sub tsb_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_proveedor.Click
        MostrarForm(FrmProveedores)
    End Sub

    Private Sub tsb_ordser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ordser.Click
        MostrarForm(FrmOrdenServicio)
    End Sub

    Private Sub tsb_ordcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ordcom.Click
        MostrarForm(FrmOrdenCompra)
    End Sub

    Private Sub tsb_mnuordcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_mnuordcom.Click
        MostrarForm(FrmConsultaOC)
    End Sub

    Private Sub tsb_mnuordser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_mnuordser.Click
        MostrarForm(FrmConsultaOS)
    End Sub

    Private Sub ImprimirOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirOrdenToolStripMenuItem.Click
        MostrarForm(FrmRepOS)
    End Sub

    Private Sub ImpOrdenDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpOrdenDeCompraToolStripMenuItem.Click
        MostrarForm(FrmRepOC)
    End Sub

    Private Sub mnuacercade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuacercade.Click
        MostrarForm(AboutBox1)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuUsuarios.Click
        MostrarForm(FrmUsuarios)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tsbhora.Text = Format(Now(), "hh:mm:ss") + " " + Format(Now(), "tt")
    End Sub

    Private Sub ExtornosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtornosToolStripMenuItem.Click
        MostrarForm(FrmConsultaExtorno)
    End Sub

    Private Sub ExtornosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtornosToolStripMenuItem1.Click
        MostrarForm(FrmRepExt)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If MessageBox.Show("Desea abandonar el Sistema", "SAB 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

   
    Private Sub MDIPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Desea abandonar el Sistema", "SAB 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mnudatossiaf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudatossiaf.Click
        MostrarForm(frmGeneraSiaf)
    End Sub
End Class
