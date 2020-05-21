<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaServicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaServicio))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BotonConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.TabControl()
        Me.Pagina1 = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Contador = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnaMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BotonBuscar1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pagina2 = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Pagina3 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Pagina1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonConsultar, Me.ToolStripSeparator3, Me.BotonSalir, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1057, 25)
        Me.ToolStrip1.TabIndex = 48
        '
        'BotonConsultar
        '
        Me.BotonConsultar.Image = CType(resources.GetObject("BotonConsultar.Image"), System.Drawing.Image)
        Me.BotonConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonConsultar.Name = "BotonConsultar"
        Me.BotonConsultar.Size = New System.Drawing.Size(78, 22)
        Me.BotonConsultar.Text = "Consultar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BotonSalir
        '
        Me.BotonSalir.Image = CType(resources.GetObject("BotonSalir.Image"), System.Drawing.Image)
        Me.BotonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(49, 22)
        Me.BotonSalir.Text = "Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Pagina1)
        Me.Panel1.Controls.Add(Me.Pagina2)
        Me.Panel1.Controls.Add(Me.Pagina3)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Panel1.ImageList = Me.ImageList1
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.SelectedIndex = 0
        Me.Panel1.Size = New System.Drawing.Size(1033, 601)
        Me.Panel1.TabIndex = 49
        '
        'Pagina1
        '
        Me.Pagina1.Controls.Add(Me.DateTimePicker1)
        Me.Pagina1.Controls.Add(Me.Label6)
        Me.Pagina1.Controls.Add(Me.TextBox3)
        Me.Pagina1.Controls.Add(Me.Label5)
        Me.Pagina1.Controls.Add(Me.Label4)
        Me.Pagina1.Controls.Add(Me.TextBox2)
        Me.Pagina1.Controls.Add(Me.TextBox5)
        Me.Pagina1.Controls.Add(Me.Label2)
        Me.Pagina1.Controls.Add(Me.GroupBox1)
        Me.Pagina1.Controls.Add(Me.Label1)
        Me.Pagina1.Controls.Add(Me.TextBox4)
        Me.Pagina1.Controls.Add(Me.GroupBox2)
        Me.Pagina1.Controls.Add(Me.BotonBuscar1)
        Me.Pagina1.Controls.Add(Me.TextBox1)
        Me.Pagina1.Controls.Add(Me.Label3)
        Me.Pagina1.Controls.Add(Me.TextBox6)
        Me.Pagina1.ImageIndex = 0
        Me.Pagina1.Location = New System.Drawing.Point(4, 24)
        Me.Pagina1.Name = "Pagina1"
        Me.Pagina1.Padding = New System.Windows.Forms.Padding(3)
        Me.Pagina1.Size = New System.Drawing.Size(1025, 573)
        Me.Pagina1.TabIndex = 0
        Me.Pagina1.Text = "LISTADO DE SERVICIOS"
        Me.Pagina1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox6.Location = New System.Drawing.Point(625, 39)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(116, 23)
        Me.TextBox6.TabIndex = 138
        Me.TextBox6.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(220, 23)
        Me.DateTimePicker1.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "FECHA DE INICIO"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox3.Location = New System.Drawing.Point(232, 65)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 23)
        Me.TextBox3.TabIndex = 135
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(229, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "GRUPO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "SEDE"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(6, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 23)
        Me.TextBox2.TabIndex = 132
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox5.Location = New System.Drawing.Point(232, 109)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(220, 23)
        Me.TextBox5.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(229, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "TÉCNICO A CARGO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 429)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MATERIALES INCLUIDOS"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.Contador})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 401)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(440, 25)
        Me.ToolStrip2.TabIndex = 130
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripLabel2.Text = "REGISTROS ENCONTRADOS:"
        '
        'Contador
        '
        Me.Contador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Contador.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contador.Image = CType(resources.GetObject("Contador.Image"), System.Drawing.Image)
        Me.Contador.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Contador.Name = "Contador"
        Me.Contador.Size = New System.Drawing.Size(0, 22)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaMaterial, Me.ColumnaCantidad})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 45
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(440, 376)
        Me.DataGridView1.TabIndex = 129
        '
        'ColumnaMaterial
        '
        Me.ColumnaMaterial.DataPropertyName = "nombredispositivo"
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaMaterial.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColumnaMaterial.HeaderText = "MATERIAL"
        Me.ColumnaMaterial.Name = "ColumnaMaterial"
        Me.ColumnaMaterial.ReadOnly = True
        '
        'ColumnaCantidad
        '
        Me.ColumnaCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaCantidad.DataPropertyName = "suma"
        Me.ColumnaCantidad.HeaderText = "CANTIDAD"
        Me.ColumnaCantidad.MinimumWidth = 120
        Me.ColumnaCantidad.Name = "ColumnaCantidad"
        Me.ColumnaCantidad.ReadOnly = True
        Me.ColumnaCantidad.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(263, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "ESTADO DEL SERVICIO"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox4.Location = New System.Drawing.Point(266, 21)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 23)
        Me.TextBox4.TabIndex = 127
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(458, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 561)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OBSERVACIONES DEL SERVICIO"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaDescripcion, Me.ColumnaObservacion})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Menu
        Me.DataGridView2.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 45
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(555, 539)
        Me.DataGridView2.TabIndex = 51
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaDescripcion.DataPropertyName = "nombredispositivo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaDescripcion.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColumnaDescripcion.HeaderText = "DISPOSITIVO"
        Me.ColumnaDescripcion.MinimumWidth = 120
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        Me.ColumnaDescripcion.Width = 120
        '
        'ColumnaObservacion
        '
        Me.ColumnaObservacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaObservacion.DataPropertyName = "observacion"
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaObservacion.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColumnaObservacion.HeaderText = "OBSERVACIONES"
        Me.ColumnaObservacion.MinimumWidth = 130
        Me.ColumnaObservacion.Name = "ColumnaObservacion"
        Me.ColumnaObservacion.ReadOnly = True
        '
        'BotonBuscar1
        '
        Me.BotonBuscar1.Image = CType(resources.GetObject("BotonBuscar1.Image"), System.Drawing.Image)
        Me.BotonBuscar1.Location = New System.Drawing.Point(233, 17)
        Me.BotonBuscar1.Name = "BotonBuscar1"
        Me.BotonBuscar1.Size = New System.Drawing.Size(28, 28)
        Me.BotonBuscar1.TabIndex = 125
        Me.BotonBuscar1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(6, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 23)
        Me.TextBox1.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "DESCRIPCIÓN"
        '
        'Pagina2
        '
        Me.Pagina2.ImageIndex = 4
        Me.Pagina2.Location = New System.Drawing.Point(4, 24)
        Me.Pagina2.Name = "Pagina2"
        Me.Pagina2.Padding = New System.Windows.Forms.Padding(3)
        Me.Pagina2.Size = New System.Drawing.Size(1025, 573)
        Me.Pagina2.TabIndex = 1
        Me.Pagina2.Text = "MATERIALES"
        Me.Pagina2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Historial.png")
        Me.ImageList1.Images.SetKeyName(1, "ModificarReporte.png")
        Me.ImageList1.Images.SetKeyName(2, "CambiarEstado.png")
        Me.ImageList1.Images.SetKeyName(3, "EditarRuta.png")
        Me.ImageList1.Images.SetKeyName(4, "RegistrarrNovedad.png")
        Me.ImageList1.Images.SetKeyName(5, "Camara.png")
        Me.ImageList1.Images.SetKeyName(6, "ControlDeRutas4.png")
        Me.ImageList1.Images.SetKeyName(7, "Icono6.ico")
        Me.ImageList1.Images.SetKeyName(8, "Camara2.png")
        Me.ImageList1.Images.SetKeyName(9, "Camara4.png")
        '
        'Pagina3
        '
        Me.Pagina3.ImageIndex = 5
        Me.Pagina3.Location = New System.Drawing.Point(4, 24)
        Me.Pagina3.Name = "Pagina3"
        Me.Pagina3.Size = New System.Drawing.Size(1025, 573)
        Me.Pagina3.TabIndex = 2
        Me.Pagina3.Text = "DISPOSITIVOS"
        Me.Pagina3.UseVisualStyleBackColor = True
        '
        'ConsultaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1057, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ConsultaServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Servicios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Pagina1.ResumeLayout(False)
        Me.Pagina1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BotonConsultar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BotonSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Panel1 As TabControl
    Friend WithEvents Pagina1 As TabPage
    Friend WithEvents Pagina2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BotonBuscar1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ColumnaObservacion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Contador As ToolStripLabel
    Friend WithEvents ColumnaCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Pagina3 As TabPage
End Class
