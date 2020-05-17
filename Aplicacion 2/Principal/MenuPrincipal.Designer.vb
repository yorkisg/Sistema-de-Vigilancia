<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.usuariorol = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuDatosMaestros = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSede = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGrupo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDispositivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMaterial = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSeguimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSeguimientoIncidencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuServicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSeguimientoServicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalir2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.usuariorol, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripLabel2, Me.ToolStripSeparator5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 537)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "Usuario:"
        '
        'usuariorol
        '
        Me.usuariorol.Name = "usuariorol"
        Me.usuariorol.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton1.Text = "10.05.2020"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel2.Text = "Versión:"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuDatosMaestros, Me.ToolStripSeparator12, Me.MenuSeguimiento, Me.ToolStripSeparator10, Me.ConsultasToolStripMenuItem, Me.ToolStripSeparator2, Me.MenuSalir, Me.ToolStripSeparator11})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuDatosMaestros
        '
        Me.MenuDatosMaestros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSede, Me.MenuGrupo, Me.MenuDispositivo, Me.MenuMaterial, Me.ToolStripSeparator8})
        Me.MenuDatosMaestros.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDatosMaestros.Image = CType(resources.GetObject("MenuDatosMaestros.Image"), System.Drawing.Image)
        Me.MenuDatosMaestros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuDatosMaestros.Name = "MenuDatosMaestros"
        Me.MenuDatosMaestros.Size = New System.Drawing.Size(129, 23)
        Me.MenuDatosMaestros.Text = "Datos Maestros"
        '
        'MenuSede
        '
        Me.MenuSede.Image = CType(resources.GetObject("MenuSede.Image"), System.Drawing.Image)
        Me.MenuSede.Name = "MenuSede"
        Me.MenuSede.Size = New System.Drawing.Size(146, 22)
        Me.MenuSede.Text = "Sedes"
        '
        'MenuGrupo
        '
        Me.MenuGrupo.Image = CType(resources.GetObject("MenuGrupo.Image"), System.Drawing.Image)
        Me.MenuGrupo.Name = "MenuGrupo"
        Me.MenuGrupo.Size = New System.Drawing.Size(146, 22)
        Me.MenuGrupo.Text = "Grupos"
        '
        'MenuDispositivo
        '
        Me.MenuDispositivo.Image = CType(resources.GetObject("MenuDispositivo.Image"), System.Drawing.Image)
        Me.MenuDispositivo.Name = "MenuDispositivo"
        Me.MenuDispositivo.Size = New System.Drawing.Size(146, 22)
        Me.MenuDispositivo.Text = "Dispositivos"
        '
        'MenuMaterial
        '
        Me.MenuMaterial.Image = CType(resources.GetObject("MenuMaterial.Image"), System.Drawing.Image)
        Me.MenuMaterial.Name = "MenuMaterial"
        Me.MenuMaterial.Size = New System.Drawing.Size(146, 22)
        Me.MenuMaterial.Text = "Materiales"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(143, 6)
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 23)
        '
        'MenuSeguimiento
        '
        Me.MenuSeguimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSeguimientoIncidencia, Me.ToolStripSeparator9, Me.MenuServicio, Me.MenuSeguimientoServicio, Me.ToolStripSeparator1})
        Me.MenuSeguimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuSeguimiento.Image = CType(resources.GetObject("MenuSeguimiento.Image"), System.Drawing.Image)
        Me.MenuSeguimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuSeguimiento.Name = "MenuSeguimiento"
        Me.MenuSeguimiento.Size = New System.Drawing.Size(108, 23)
        Me.MenuSeguimiento.Text = "Seguimiento"
        '
        'MenuSeguimientoIncidencia
        '
        Me.MenuSeguimientoIncidencia.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuSeguimientoIncidencia.Image = CType(resources.GetObject("MenuSeguimientoIncidencia.Image"), System.Drawing.Image)
        Me.MenuSeguimientoIncidencia.Name = "MenuSeguimientoIncidencia"
        Me.MenuSeguimientoIncidencia.Size = New System.Drawing.Size(184, 22)
        Me.MenuSeguimientoIncidencia.Text = "Incidencias"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(181, 6)
        '
        'MenuServicio
        '
        Me.MenuServicio.Image = CType(resources.GetObject("MenuServicio.Image"), System.Drawing.Image)
        Me.MenuServicio.Name = "MenuServicio"
        Me.MenuServicio.Size = New System.Drawing.Size(184, 22)
        Me.MenuServicio.Text = "Registrar Servicios"
        '
        'MenuSeguimientoServicio
        '
        Me.MenuSeguimientoServicio.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuSeguimientoServicio.Image = CType(resources.GetObject("MenuSeguimientoServicio.Image"), System.Drawing.Image)
        Me.MenuSeguimientoServicio.Name = "MenuSeguimientoServicio"
        Me.MenuSeguimientoServicio.Size = New System.Drawing.Size(184, 22)
        Me.MenuSeguimientoServicio.Text = "Seguimiento"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 23)
        '
        'MenuSalir
        '
        Me.MenuSalir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSalir2})
        Me.MenuSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuSalir.Image = CType(resources.GetObject("MenuSalir.Image"), System.Drawing.Image)
        Me.MenuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(61, 23)
        Me.MenuSalir.Text = "Salir"
        '
        'MenuSalir2
        '
        Me.MenuSalir2.Image = CType(resources.GetObject("MenuSalir2.Image"), System.Drawing.Image)
        Me.MenuSalir2.Name = "MenuSalir2"
        Me.MenuSalir2.Size = New System.Drawing.Size(101, 22)
        Me.MenuSalir2.Text = "Salir"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 23)
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 23)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Vigilancia"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents usuariorol As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuDatosMaestros As ToolStripMenuItem
    Friend WithEvents MenuSede As ToolStripMenuItem
    Friend WithEvents MenuGrupo As ToolStripMenuItem
    Friend WithEvents MenuDispositivo As ToolStripMenuItem
    Friend WithEvents MenuMaterial As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents MenuSeguimiento As ToolStripMenuItem
    Friend WithEvents MenuSeguimientoIncidencia As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents MenuSeguimientoServicio As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents MenuSalir As ToolStripMenuItem
    Friend WithEvents MenuSalir2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents MenuServicio As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
