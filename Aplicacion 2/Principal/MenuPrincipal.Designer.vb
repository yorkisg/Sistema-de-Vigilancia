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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.MenuArchivo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuSedes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDispositivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGrupos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSalir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuSalir2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.usuariorol = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuArchivo, Me.ToolStripSeparator1, Me.MenuSalir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'MenuArchivo
        '
        Me.MenuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSedes, Me.MenuDispositivos, Me.MenuMateriales, Me.MenuGrupos, Me.ToolStripSeparator3})
        Me.MenuArchivo.Image = CType(resources.GetObject("MenuArchivo.Image"), System.Drawing.Image)
        Me.MenuArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuArchivo.Name = "MenuArchivo"
        Me.MenuArchivo.Size = New System.Drawing.Size(130, 22)
        Me.MenuArchivo.Text = "Datos Maestros"
        '
        'MenuSedes
        '
        Me.MenuSedes.Image = CType(resources.GetObject("MenuSedes.Image"), System.Drawing.Image)
        Me.MenuSedes.Name = "MenuSedes"
        Me.MenuSedes.Size = New System.Drawing.Size(146, 22)
        Me.MenuSedes.Text = "Sedes"
        '
        'MenuDispositivos
        '
        Me.MenuDispositivos.Image = CType(resources.GetObject("MenuDispositivos.Image"), System.Drawing.Image)
        Me.MenuDispositivos.Name = "MenuDispositivos"
        Me.MenuDispositivos.Size = New System.Drawing.Size(146, 22)
        Me.MenuDispositivos.Text = "Dispositivos"
        '
        'MenuMateriales
        '
        Me.MenuMateriales.Image = CType(resources.GetObject("MenuMateriales.Image"), System.Drawing.Image)
        Me.MenuMateriales.Name = "MenuMateriales"
        Me.MenuMateriales.Size = New System.Drawing.Size(146, 22)
        Me.MenuMateriales.Text = "Materiales"
        '
        'MenuGrupos
        '
        Me.MenuGrupos.Image = CType(resources.GetObject("MenuGrupos.Image"), System.Drawing.Image)
        Me.MenuGrupos.Name = "MenuGrupos"
        Me.MenuGrupos.Size = New System.Drawing.Size(146, 22)
        Me.MenuGrupos.Text = "Grupos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'MenuSalir
        '
        Me.MenuSalir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSalir2})
        Me.MenuSalir.Image = CType(resources.GetObject("MenuSalir.Image"), System.Drawing.Image)
        Me.MenuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(62, 22)
        Me.MenuSalir.Text = "Salir"
        '
        'MenuSalir2
        '
        Me.MenuSalir2.Image = CType(resources.GetObject("MenuSalir2.Image"), System.Drawing.Image)
        Me.MenuSalir2.Name = "MenuSalir2"
        Me.MenuSalir2.Size = New System.Drawing.Size(101, 22)
        Me.MenuSalir2.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.ToolStripButton1.Text = "28.04.2020"
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
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Vigilancia"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents MenuArchivo As ToolStripDropDownButton
    Friend WithEvents MenuSedes As ToolStripMenuItem
    Friend WithEvents MenuSalir As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MenuDispositivos As ToolStripMenuItem
    Friend WithEvents MenuMateriales As ToolStripMenuItem
    Friend WithEvents MenuGrupos As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuSalir2 As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents usuariorol As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
