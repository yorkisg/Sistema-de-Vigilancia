﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoDispositivo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoDispositivo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BotonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaImagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColumnaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaImagen2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColumnaEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaIDGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaIDSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Contador = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonGuardar, Me.ToolStripSeparator2, Me.BotonExportar, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.TextBox, Me.ToolStripSeparator1, Me.BotonSalir, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1134, 25)
        Me.ToolStrip1.TabIndex = 25
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
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaID, Me.ColumnaDescripcion, Me.ColumnaUbicacion, Me.ColumnaDireccion, Me.ColumnaMarca, Me.ColumnaImagen, Me.ColumnaTipo, Me.ColumnaImagen2, Me.ColumnaEstado, Me.ColumnaSede, Me.ColumnaGrupo, Me.ColumnaIDGrupo, Me.ColumnaIDSede})
        Me.DataGridView.GridColor = System.Drawing.SystemColors.Menu
        Me.DataGridView.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidth = 45
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1110, 536)
        Me.DataGridView.TabIndex = 26
        '
        'ColumnaID
        '
        Me.ColumnaID.DataPropertyName = "iddispositivo"
        Me.ColumnaID.HeaderText = "ID DISPOSITIVO"
        Me.ColumnaID.Name = "ColumnaID"
        Me.ColumnaID.ReadOnly = True
        Me.ColumnaID.Visible = False
        Me.ColumnaID.Width = 150
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaDescripcion.DataPropertyName = "nombredispositivo"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaDescripcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnaDescripcion.HeaderText = "DESCRIPCIÓN"
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        '
        'ColumnaUbicacion
        '
        Me.ColumnaUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaUbicacion.DataPropertyName = "ubicacion"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaUbicacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnaUbicacion.HeaderText = "UBICACIÓN"
        Me.ColumnaUbicacion.Name = "ColumnaUbicacion"
        Me.ColumnaUbicacion.ReadOnly = True
        '
        'ColumnaDireccion
        '
        Me.ColumnaDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaDireccion.DataPropertyName = "direccionip"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaDireccion.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnaDireccion.HeaderText = "DIRECCIÓN IP"
        Me.ColumnaDireccion.Name = "ColumnaDireccion"
        Me.ColumnaDireccion.ReadOnly = True
        '
        'ColumnaMarca
        '
        Me.ColumnaMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaMarca.DataPropertyName = "marca"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaMarca.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColumnaMarca.HeaderText = "MARCA"
        Me.ColumnaMarca.Name = "ColumnaMarca"
        Me.ColumnaMarca.ReadOnly = True
        '
        'ColumnaImagen
        '
        Me.ColumnaImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaImagen.HeaderText = ""
        Me.ColumnaImagen.MinimumWidth = 25
        Me.ColumnaImagen.Name = "ColumnaImagen"
        Me.ColumnaImagen.ReadOnly = True
        Me.ColumnaImagen.Width = 25
        '
        'ColumnaTipo
        '
        Me.ColumnaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaTipo.DataPropertyName = "nombretipo"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaTipo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColumnaTipo.HeaderText = "TIPO"
        Me.ColumnaTipo.Name = "ColumnaTipo"
        Me.ColumnaTipo.ReadOnly = True
        '
        'ColumnaImagen2
        '
        Me.ColumnaImagen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnaImagen2.HeaderText = ""
        Me.ColumnaImagen2.MinimumWidth = 25
        Me.ColumnaImagen2.Name = "ColumnaImagen2"
        Me.ColumnaImagen2.ReadOnly = True
        Me.ColumnaImagen2.Width = 25
        '
        'ColumnaEstado
        '
        Me.ColumnaEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaEstado.DataPropertyName = "estadodispositivo"
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEstado.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColumnaEstado.HeaderText = "ESTADO"
        Me.ColumnaEstado.Name = "ColumnaEstado"
        Me.ColumnaEstado.ReadOnly = True
        '
        'ColumnaSede
        '
        Me.ColumnaSede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaSede.DataPropertyName = "nombresede"
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaSede.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColumnaSede.HeaderText = "SEDE"
        Me.ColumnaSede.Name = "ColumnaSede"
        Me.ColumnaSede.ReadOnly = True
        '
        'ColumnaGrupo
        '
        Me.ColumnaGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaGrupo.DataPropertyName = "nombregrupo"
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaGrupo.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColumnaGrupo.HeaderText = "GRUPO"
        Me.ColumnaGrupo.Name = "ColumnaGrupo"
        Me.ColumnaGrupo.ReadOnly = True
        '
        'ColumnaIDGrupo
        '
        Me.ColumnaIDGrupo.DataPropertyName = "idgrupo"
        Me.ColumnaIDGrupo.HeaderText = "ID GRUPO"
        Me.ColumnaIDGrupo.Name = "ColumnaIDGrupo"
        Me.ColumnaIDGrupo.ReadOnly = True
        Me.ColumnaIDGrupo.Visible = False
        '
        'ColumnaIDSede
        '
        Me.ColumnaIDSede.DataPropertyName = "idsede"
        Me.ColumnaIDSede.HeaderText = "ID SEDE"
        Me.ColumnaIDSede.Name = "ColumnaIDSede"
        Me.ColumnaIDSede.ReadOnly = True
        Me.ColumnaIDSede.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.Contador})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 567)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1134, 25)
        Me.ToolStrip2.TabIndex = 74
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
        'ListadoDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1134, 592)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ListadoDispositivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Dispositivos de Vigilancia"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Contador As ToolStripLabel
    Friend WithEvents ColumnaIDGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaIDSede As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaSede As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaEstado As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaImagen2 As DataGridViewImageColumn
    Friend WithEvents ColumnaTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaImagen As DataGridViewImageColumn
    Friend WithEvents ColumnaMarca As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDireccion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaID As DataGridViewTextBoxColumn
End Class
