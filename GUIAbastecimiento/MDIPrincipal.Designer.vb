<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.smnuUsuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenesDeServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExtornosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ExtornosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnudatossiaf = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuacercade = New System.Windows.Forms.ToolStripMenuItem
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.tsbusuar = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsbdni = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsbnada = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsbhora = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsb_proveedor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsb_ordser = New System.Windows.Forms.ToolStripButton
        Me.tsb_ordcom = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsb_consultas = New System.Windows.Forms.ToolStripSplitButton
        Me.tsb_mnuordcom = New System.Windows.Forms.ToolStripMenuItem
        Me.tsb_mnuordser = New System.Windows.Forms.ToolStripMenuItem
        Me.tsb_imprimir = New System.Windows.Forms.ToolStripSplitButton
        Me.ImprimirOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImpOrdenDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ToolsMenu, Me.WindowsMenu, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 36)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator4, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripSeparator5, Me.smnuUsuarios, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.FileMenu.ForeColor = System.Drawing.Color.White
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(59, 32)
        Me.FileMenu.Text = "&Registro"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._04
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.NewToolStripMenuItem.Text = "&Convenios"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._18
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OpenToolStripMenuItem.Text = "&Materiales"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._46
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveToolStripMenuItem.Text = "&Unidades"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._30
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveAsToolStripMenuItem.Text = "&Proveedores"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(171, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._10
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PrintToolStripMenuItem.Text = "&Impuestos"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._16
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "&Proyectos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(171, 6)
        '
        'smnuUsuarios
        '
        Me.smnuUsuarios.Image = Global.GUIAbastecimiento.My.Resources.Resources._38
        Me.smnuUsuarios.Name = "smnuUsuarios"
        Me.smnuUsuarios.Size = New System.Drawing.Size(174, 22)
        Me.smnuUsuarios.Text = "Usuarios"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(171, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._34
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripMenuItem1, Me.RedoToolStripMenuItem})
        Me.EditMenu.ForeColor = System.Drawing.Color.White
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(79, 32)
        Me.EditMenu.Text = "&Operaciones"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._11
        Me.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.UndoToolStripMenuItem.Text = "&Ordenes de Compra"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(216, 6)
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._12
        Me.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.RedoToolStripMenuItem.Text = "&Ordenes de Servicio"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.OrdenesDeServicioToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExtornosToolStripMenuItem})
        Me.ToolsMenu.ForeColor = System.Drawing.Color.White
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(66, 32)
        Me.ToolsMenu.Text = "&Consultas"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._11
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OptionsToolStripMenuItem.Text = "&Ordenes de Compra"
        '
        'OrdenesDeServicioToolStripMenuItem
        '
        Me.OrdenesDeServicioToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._12
        Me.OrdenesDeServicioToolStripMenuItem.Name = "OrdenesDeServicioToolStripMenuItem"
        Me.OrdenesDeServicioToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OrdenesDeServicioToolStripMenuItem.Text = "&Ordenes de Servicio"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'ExtornosToolStripMenuItem
        '
        Me.ExtornosToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._28
        Me.ExtornosToolStripMenuItem.Name = "ExtornosToolStripMenuItem"
        Me.ExtornosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExtornosToolStripMenuItem.Text = "Extornos"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdCompraToolStripMenuItem, Me.OrdServicioToolStripMenuItem, Me.ToolStripMenuItem4, Me.ExtornosToolStripMenuItem1, Me.ToolStripMenuItem5, Me.mnudatossiaf})
        Me.WindowsMenu.ForeColor = System.Drawing.Color.White
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(63, 32)
        Me.WindowsMenu.Text = "&Reportes"
        '
        'OrdCompraToolStripMenuItem
        '
        Me.OrdCompraToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._18
        Me.OrdCompraToolStripMenuItem.Name = "OrdCompraToolStripMenuItem"
        Me.OrdCompraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrdCompraToolStripMenuItem.Text = "Ord. Compra"
        '
        'OrdServicioToolStripMenuItem
        '
        Me.OrdServicioToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._16
        Me.OrdServicioToolStripMenuItem.Name = "OrdServicioToolStripMenuItem"
        Me.OrdServicioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrdServicioToolStripMenuItem.Text = "Ord. Servicio"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 6)
        '
        'ExtornosToolStripMenuItem1
        '
        Me.ExtornosToolStripMenuItem1.Image = Global.GUIAbastecimiento.My.Resources.Resources._28
        Me.ExtornosToolStripMenuItem1.Name = "ExtornosToolStripMenuItem1"
        Me.ExtornosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExtornosToolStripMenuItem1.Text = "Extornos"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(149, 6)
        '
        'mnudatossiaf
        '
        Me.mnudatossiaf.Image = Global.GUIAbastecimiento.My.Resources.Resources._51
        Me.mnudatossiaf.Name = "mnudatossiaf"
        Me.mnudatossiaf.Size = New System.Drawing.Size(152, 22)
        Me.mnudatossiaf.Text = "Datos Siaf"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuacercade})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 32)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'mnuacercade
        '
        Me.mnuacercade.Image = Global.GUIAbastecimiento.My.Resources.Resources._31
        Me.mnuacercade.Name = "mnuacercade"
        Me.mnuacercade.Size = New System.Drawing.Size(155, 22)
        Me.mnuacercade.Text = "Acerca de SAB"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbusuar, Me.tsbdni, Me.tsbnada, Me.ToolStripStatusLabel1, Me.tsbhora})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tsbusuar
        '
        Me.tsbusuar.Name = "tsbusuar"
        Me.tsbusuar.Size = New System.Drawing.Size(50, 17)
        Me.tsbusuar.Text = "Usuario :"
        '
        'tsbdni
        '
        Me.tsbdni.Name = "tsbdni"
        Me.tsbdni.Size = New System.Drawing.Size(111, 17)
        Me.tsbdni.Text = "ToolStripStatusLabel1"
        '
        'tsbnada
        '
        Me.tsbnada.AutoSize = False
        Me.tsbnada.Name = "tsbnada"
        Me.tsbnada.Size = New System.Drawing.Size(0, 17)
        Me.tsbnada.Text = "toll"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel1.Text = "Hora del Sistema"
        '
        'tsbhora
        '
        Me.tsbhora.Name = "tsbhora"
        Me.tsbhora.Size = New System.Drawing.Size(97, 17)
        Me.tsbhora.Text = "                              "
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._29
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewWindowToolStripMenuItem.Text = "&Ordenes de Compra"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._48
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CascadeToolStripMenuItem.Text = "&Ordenes de Servicio"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.GUIAbastecimiento.My.Resources.Resources._29
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(96, 33)
        Me.NewToolStripButton.Text = "Ord. Compra"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = Global.GUIAbastecimiento.My.Resources.Resources._11
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(91, 33)
        Me.OpenToolStripButton.Text = "Ord.Servicio"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = Global.GUIAbastecimiento.My.Resources.Resources._30
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(81, 33)
        Me.SaveToolStripButton.Text = "Proveedor"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.GUIAbastecimiento.My.Resources.Resources._04
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(78, 33)
        Me.PrintToolStripButton.Text = "Convenio"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.Image = Global.GUIAbastecimiento.My.Resources.Resources._16
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(74, 33)
        Me.PrintPreviewToolStripButton.Text = "Proyecto"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.GUIAbastecimiento.My.Resources.Resources._34
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 33)
        Me.ToolStripButton1.Text = "Salir"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_proveedor, Me.ToolStripSeparator6, Me.tsb_ordser, Me.tsb_ordcom, Me.ToolStripSeparator7, Me.tsb_consultas, Me.tsb_imprimir, Me.ToolStripSeparator8, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 36)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 39)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsb_proveedor
        '
        Me.tsb_proveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_proveedor.Image = Global.GUIAbastecimiento.My.Resources.Resources.b_045
        Me.tsb_proveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_proveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_proveedor.Name = "tsb_proveedor"
        Me.tsb_proveedor.Size = New System.Drawing.Size(36, 36)
        Me.tsb_proveedor.Text = "Registrar Proveedor"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'tsb_ordser
        '
        Me.tsb_ordser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_ordser.Image = Global.GUIAbastecimiento.My.Resources.Resources._2b_5
        Me.tsb_ordser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_ordser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_ordser.Name = "tsb_ordser"
        Me.tsb_ordser.Size = New System.Drawing.Size(36, 36)
        Me.tsb_ordser.Text = "Ingresar Orden de Servicio"
        '
        'tsb_ordcom
        '
        Me.tsb_ordcom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_ordcom.Image = Global.GUIAbastecimiento.My.Resources.Resources.b_58
        Me.tsb_ordcom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_ordcom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_ordcom.Name = "tsb_ordcom"
        Me.tsb_ordcom.Size = New System.Drawing.Size(36, 36)
        Me.tsb_ordcom.Text = "Ingresar Orden de Compra"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'tsb_consultas
        '
        Me.tsb_consultas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_consultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_mnuordcom, Me.tsb_mnuordser})
        Me.tsb_consultas.Image = Global.GUIAbastecimiento.My.Resources.Resources.b_30
        Me.tsb_consultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_consultas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_consultas.Name = "tsb_consultas"
        Me.tsb_consultas.Size = New System.Drawing.Size(48, 36)
        Me.tsb_consultas.Text = "Consultar Ordenes"
        '
        'tsb_mnuordcom
        '
        Me.tsb_mnuordcom.Image = Global.GUIAbastecimiento.My.Resources.Resources._11
        Me.tsb_mnuordcom.Name = "tsb_mnuordcom"
        Me.tsb_mnuordcom.Size = New System.Drawing.Size(170, 22)
        Me.tsb_mnuordcom.Text = "Orden de Compra"
        '
        'tsb_mnuordser
        '
        Me.tsb_mnuordser.Image = Global.GUIAbastecimiento.My.Resources.Resources._12
        Me.tsb_mnuordser.Name = "tsb_mnuordser"
        Me.tsb_mnuordser.Size = New System.Drawing.Size(170, 22)
        Me.tsb_mnuordser.Text = "Orden de Servicio"
        '
        'tsb_imprimir
        '
        Me.tsb_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_imprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirOrdenToolStripMenuItem, Me.ImpOrdenDeCompraToolStripMenuItem})
        Me.tsb_imprimir.Image = Global.GUIAbastecimiento.My.Resources.Resources.b_20
        Me.tsb_imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_imprimir.Name = "tsb_imprimir"
        Me.tsb_imprimir.Size = New System.Drawing.Size(48, 36)
        Me.tsb_imprimir.Text = "Imprimir Ordenes"
        '
        'ImprimirOrdenToolStripMenuItem
        '
        Me.ImprimirOrdenToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._14
        Me.ImprimirOrdenToolStripMenuItem.Name = "ImprimirOrdenToolStripMenuItem"
        Me.ImprimirOrdenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImprimirOrdenToolStripMenuItem.Text = "Imp. Orden de Servicio"
        '
        'ImpOrdenDeCompraToolStripMenuItem
        '
        Me.ImpOrdenDeCompraToolStripMenuItem.Image = Global.GUIAbastecimiento.My.Resources.Resources._25
        Me.ImpOrdenDeCompraToolStripMenuItem.Name = "ImpOrdenDeCompraToolStripMenuItem"
        Me.ImpOrdenDeCompraToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImpOrdenDeCompraToolStripMenuItem.Text = "Imp. Orden de Compra"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = Global.GUIAbastecimiento.My.Resources.Resources.b_03
        Me.cmdSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.Text = "Salir del Sistema"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 356)
        Me.Panel1.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIPrincipal"
        Me.Text = "SISTEMA DE ABASTECIMIENTO (SAB 1.0) -- Municipalidad Distrital de Colán"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OrdCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsb_ordser As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_ordcom As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_proveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_consultas As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsb_mnuordcom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsb_mnuordser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsb_imprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ImprimirOrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpOrdenDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuacercade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbusuar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsbdni As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents smnuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsbnada As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsbhora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExtornosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtornosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnudatossiaf As System.Windows.Forms.ToolStripMenuItem

End Class
