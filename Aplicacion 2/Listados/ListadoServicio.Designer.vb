﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoServicio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Contador = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BotonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboEstado = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.Contador})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 567)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip2.TabIndex = 77
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
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaID, Me.ColumnaDescripcion, Me.ColumnaSede, Me.ColumnaGrupo, Me.ColumnaResponsable, Me.ColumnaTipo, Me.ColumnaFecha, Me.ColumnaEstado})
        Me.DataGridView.GridColor = System.Drawing.SystemColors.Menu
        Me.DataGridView.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidth = 45
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(960, 536)
        Me.DataGridView.TabIndex = 76
        '
        'ColumnaID
        '
        Me.ColumnaID.DataPropertyName = "idservicio"
        Me.ColumnaID.HeaderText = "ID SERVICIO"
        Me.ColumnaID.Name = "ColumnaID"
        Me.ColumnaID.ReadOnly = True
        Me.ColumnaID.Visible = False
        Me.ColumnaID.Width = 150
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaDescripcion.DataPropertyName = "nombreservicio"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaDescripcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnaDescripcion.HeaderText = "DESCRIPCIÓN"
        Me.ColumnaDescripcion.MinimumWidth = 240
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        Me.ColumnaDescripcion.Width = 240
        '
        'ColumnaSede
        '
        Me.ColumnaSede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaSede.DataPropertyName = "nombresede"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaSede.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnaSede.HeaderText = "SEDE"
        Me.ColumnaSede.Name = "ColumnaSede"
        Me.ColumnaSede.ReadOnly = True
        '
        'ColumnaGrupo
        '
        Me.ColumnaGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaGrupo.DataPropertyName = "nombregrupo"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaGrupo.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnaGrupo.HeaderText = "GRUPO"
        Me.ColumnaGrupo.Name = "ColumnaGrupo"
        Me.ColumnaGrupo.ReadOnly = True
        '
        'ColumnaResponsable
        '
        Me.ColumnaResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaResponsable.DataPropertyName = "responsable"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaResponsable.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColumnaResponsable.HeaderText = "RESPONSABLE"
        Me.ColumnaResponsable.Name = "ColumnaResponsable"
        Me.ColumnaResponsable.ReadOnly = True
        '
        'ColumnaTipo
        '
        Me.ColumnaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaTipo.DataPropertyName = "tiposervicio"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaTipo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColumnaTipo.HeaderText = "TIPO"
        Me.ColumnaTipo.Name = "ColumnaTipo"
        Me.ColumnaTipo.ReadOnly = True
        '
        'ColumnaFecha
        '
        Me.ColumnaFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaFecha.DataPropertyName = "fechainicio"
        Me.ColumnaFecha.HeaderText = "FECHA DE INICIO"
        Me.ColumnaFecha.MinimumWidth = 100
        Me.ColumnaFecha.Name = "ColumnaFecha"
        Me.ColumnaFecha.ReadOnly = True
        '
        'ColumnaEstado
        '
        Me.ColumnaEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaEstado.DataPropertyName = "estadoservicio"
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEstado.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColumnaEstado.HeaderText = "ESTADO"
        Me.ColumnaEstado.MinimumWidth = 100
        Me.ColumnaEstado.Name = "ColumnaEstado"
        Me.ColumnaEstado.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonGuardar, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ComboEstado, Me.ToolStripSeparator5, Me.BotonExportar, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.TextBox, Me.ToolStripSeparator1, Me.BotonSalir, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 75
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BotonGuardar
        '
        Me.BotonGuardar.Image = CType(resources.GetObject("BotonGuardar.Image"), System.Drawing.Image)
        Me.BotonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonGuardar.Name = "BotonGuardar"
        Me.BotonGuardar.Size = New System.Drawing.Size(68, 22)
        Me.BotonGuardar.Text = "Aceptar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel3.Text = "Estado:"
        '
        'ComboEstado
        '
        Me.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ComboEstado.Items.AddRange(New Object() {"POR REALIZAR", "COMPLETADO"})
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(180, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BotonExportar
        '
        Me.BotonExportar.Image = CType(resources.GetObject("BotonExportar.Image"), System.Drawing.Image)
        Me.BotonExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonExportar.Name = "BotonExportar"
        Me.BotonExportar.Size = New System.Drawing.Size(108, 22)
        Me.BotonExportar.Text = "Exportar a Excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel1.Text = "Buscar:"
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(180, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(424, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 78
        Me.TextBox1.Visible = False
        '
        'ListadoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 592)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ListadoServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Servicios"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Contador As ToolStripLabel
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BotonGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BotonExportar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TextBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BotonSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ComboEstado As ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ColumnaEstado As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaResponsable As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaSede As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaID As DataGridViewTextBoxColumn
End Class
