<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeguimientoDispositivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeguimientoDispositivo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.TabControl()
        Me.Pagina1 = New System.Windows.Forms.TabPage()
        Me.Arbol = New System.Windows.Forms.TreeView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BotonRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSalir2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonConsulta1 = New System.Windows.Forms.ToolStripButton()
        Me.BotonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnaID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaTipoVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEstadoVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4.SuspendLayout()
        Me.Pagina1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Pagina1)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Panel4.Location = New System.Drawing.Point(12, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.SelectedIndex = 0
        Me.Panel4.Size = New System.Drawing.Size(213, 538)
        Me.Panel4.TabIndex = 45
        '
        'Pagina1
        '
        Me.Pagina1.BackColor = System.Drawing.Color.White
        Me.Pagina1.Controls.Add(Me.Arbol)
        Me.Pagina1.ImageIndex = 0
        Me.Pagina1.Location = New System.Drawing.Point(4, 24)
        Me.Pagina1.Name = "Pagina1"
        Me.Pagina1.Padding = New System.Windows.Forms.Padding(3)
        Me.Pagina1.Size = New System.Drawing.Size(205, 510)
        Me.Pagina1.TabIndex = 0
        Me.Pagina1.Text = "SEDES DE VIGILANCIA"
        '
        'Arbol
        '
        Me.Arbol.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Arbol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Arbol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Arbol.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Arbol.FullRowSelect = True
        Me.Arbol.ItemHeight = 18
        Me.Arbol.LineColor = System.Drawing.Color.DarkGray
        Me.Arbol.Location = New System.Drawing.Point(3, 3)
        Me.Arbol.Name = "Arbol"
        Me.Arbol.ShowNodeToolTips = True
        Me.Arbol.Size = New System.Drawing.Size(199, 504)
        Me.Arbol.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonRegistrar, Me.ToolStripSeparator2, Me.BotonSalir2, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip1.TabIndex = 46
        '
        'BotonRegistrar
        '
        Me.BotonRegistrar.Image = CType(resources.GetObject("BotonRegistrar.Image"), System.Drawing.Image)
        Me.BotonRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonRegistrar.Name = "BotonRegistrar"
        Me.BotonRegistrar.Size = New System.Drawing.Size(73, 22)
        Me.BotonRegistrar.Text = "Registrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BotonSalir2
        '
        Me.BotonSalir2.Image = CType(resources.GetObject("BotonSalir2.Image"), System.Drawing.Image)
        Me.BotonSalir2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonSalir2.Name = "BotonSalir2"
        Me.BotonSalir2.Size = New System.Drawing.Size(49, 22)
        Me.BotonSalir2.Text = "Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BotonConsulta1
        '
        Me.BotonConsulta1.Image = CType(resources.GetObject("BotonConsulta1.Image"), System.Drawing.Image)
        Me.BotonConsulta1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonConsulta1.Name = "BotonConsulta1"
        Me.BotonConsulta1.Size = New System.Drawing.Size(73, 22)
        Me.BotonConsulta1.Text = "Registrar"
        '
        'BotonSalir
        '
        Me.BotonSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BotonSalir.Image = CType(resources.GetObject("BotonSalir.Image"), System.Drawing.Image)
        Me.BotonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(49, 22)
        Me.BotonSalir.Text = "Salir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Registrar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaID2, Me.ColumnaID, Me.ColumnaTipoVehiculo, Me.ColumnaUbicacion, Me.ColumnaEstadoVehiculo})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.Location = New System.Drawing.Point(540, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 45
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(464, 538)
        Me.DataGridView1.TabIndex = 47
        '
        'ColumnaID2
        '
        Me.ColumnaID2.DataPropertyName = "iddispositivo"
        Me.ColumnaID2.HeaderText = "ID DISPOSITIVO"
        Me.ColumnaID2.Name = "ColumnaID2"
        Me.ColumnaID2.ReadOnly = True
        Me.ColumnaID2.Visible = False
        '
        'ColumnaID
        '
        Me.ColumnaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaID.DataPropertyName = "descripcion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColumnaID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnaID.FillWeight = 19.49362!
        Me.ColumnaID.HeaderText = "DISPOSITIVO"
        Me.ColumnaID.MinimumWidth = 100
        Me.ColumnaID.Name = "ColumnaID"
        Me.ColumnaID.ReadOnly = True
        Me.ColumnaID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnaTipoVehiculo
        '
        Me.ColumnaTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaTipoVehiculo.DataPropertyName = "tipo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaTipoVehiculo.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnaTipoVehiculo.FillWeight = 26.29328!
        Me.ColumnaTipoVehiculo.HeaderText = "TIPO"
        Me.ColumnaTipoVehiculo.MinimumWidth = 110
        Me.ColumnaTipoVehiculo.Name = "ColumnaTipoVehiculo"
        Me.ColumnaTipoVehiculo.ReadOnly = True
        Me.ColumnaTipoVehiculo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnaTipoVehiculo.Width = 110
        '
        'ColumnaUbicacion
        '
        Me.ColumnaUbicacion.DataPropertyName = "ubicacion"
        Me.ColumnaUbicacion.HeaderText = "UBICACIÓN"
        Me.ColumnaUbicacion.Name = "ColumnaUbicacion"
        Me.ColumnaUbicacion.ReadOnly = True
        '
        'ColumnaEstadoVehiculo
        '
        Me.ColumnaEstadoVehiculo.DataPropertyName = "estado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEstadoVehiculo.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnaEstadoVehiculo.FillWeight = 380.7106!
        Me.ColumnaEstadoVehiculo.HeaderText = "ESTADO"
        Me.ColumnaEstadoVehiculo.MinimumWidth = 150
        Me.ColumnaEstadoVehiculo.Name = "ColumnaEstadoVehiculo"
        Me.ColumnaEstadoVehiculo.ReadOnly = True
        Me.ColumnaEstadoVehiculo.Width = 150
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(336, 417)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 48
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(231, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(303, 538)
        Me.TabControl1.TabIndex = 49
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(295, 512)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(281, 512)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SeguimientoDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 578)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SeguimientoDispositivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento de Camaras de Vigilancia"
        Me.Panel4.ResumeLayout(False)
        Me.Pagina1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As TabControl
    Friend WithEvents Pagina1 As TabPage
    Friend WithEvents Arbol As TreeView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BotonConsulta1 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BotonSalir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BotonRegistrar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BotonSalir2 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ColumnaEstadoVehiculo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaTipoVehiculo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaID2 As DataGridViewTextBoxColumn
End Class
