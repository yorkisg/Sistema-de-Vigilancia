
Public Class SeguimientoDispositivo

    Dim Fila As Integer
    Dim Columna As Integer

    Private Sub SeguimientoDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inicializamos el timer
        InicializarTimer()

        'Carga del arbol de opciones
        CargarArbolSeguimiento()

        'Validamos que el primer item seleccionado en el arbol sea el primero
        'Arbol.SelectedNode = Arbol.Nodes(0).Nodes(0) 'SELECCIONAMOS EL PRIMER HIJO
        Arbol.SelectedNode = Arbol.Nodes(0) 'SELECCIONAMOS EL PRIMER PADRE

        'Llamada al metodo para alternar los colores de las filas
        AlternarFilasGeneral(DataGridView1)
        AlternarFilasGeneral(DataGridView2)
        AlternarFilasGeneral(DataGridView3)
        AlternarFilasGeneral(DataGridView4)

        'Metodos de mejora para los componentes
        EnableDoubleBuffered(Arbol)
        EnableDoubleBuffered(DataGridView1)
        EnableDoubleBuffered(DataGridView2)
        EnableDoubleBuffered(DataGridView3)
        EnableDoubleBuffered(DataGridView4)

        'Inicializacion de la serie
        SerieSeguimientoIncidencia()
        SerieSeguimientohistorial()

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox5.CharacterCasing = CharacterCasing.Upper

        'Carga del combo
        CargarComboTipoDispositivoSeguimiento()
        CargarComboPrioridad()
        CargarComboEstado()

    End Sub

    Private Sub SeguimientoDispositivo_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Al cerrar el formulario por el boton "x" se ejecutan los metodos del boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

            LimpiarDataGridView()

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal del formulario liberando recursos
            Dispose()

        End If

    End Sub

    Private Sub InicializarTimer()
        'Metodo que inicializa el timer

        Timer1.Start()
        Timer1.Interval = 1000

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Control Timer: se lleva el tiempo para que la hora y la fecha pueda ser actualizada constantemente

        'Serie
        SerieSeguimientoIncidencia()

        TextBox6.Text = DateTime.Now.ToShortTimeString()
        DateTimePicker1.Value = Today

    End Sub

    Private Sub Arbol_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Arbol.AfterSelect
        'AfterSelect: propiedad del control TreeView (Arbol) que permite seleccionar opciones del arbol
        'MENU DE OPCIONES DINAMICO. SE PUEDEN AGREGAR NUEVAS OPCIONES.

        'Si se selecciona una opcion sin elementos, se limpian todos los componentes
        'LimpiarComponentes()

        'Enviamos el nombre de la flota al textbox mediante la propiedad node.text
        TextBox1.Text = e.Node.Text

        'Al conocer la sede enviada al textbox, se ejecuta el metodo
        CargarGridSeguimiento()

        'Si el nodo seleccionado es padre se inhabilita el panel2 y el panel3
        If e.Node.Parent Is Nothing And e.Node.Nodes.Count > 0 Then

            Panel2.Enabled = False
            Panel3.Enabled = False

            LimpiarDataGridView()

            'Si el nodo seleccionado es hijo se habilita el panel2 y el panel3
        Else

            Panel2.Enabled = True
            Panel3.Enabled = True

        End If

    End Sub

    Private Sub Arbol_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs) Handles Arbol.BeforeCollapse
        'Evento que permite que el arbol no se contraiga

        e.Cancel = True

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        'SelectionChanged o CellMouseClick: Propiedad del control DataGridview el cual permite hacer click
        'y seleccionar elementos por filas o columnas.
        'en este caso se seleccionan las columnas y los datos son pasados a un
        'TextBox pasa su posterior uso.

        Try

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentes()

            If DataGridView1.RowCount > 0 And DataGridView1.SelectedRows.Count = 1 Then

                'Seleccionamos y pasamos el valor al TextBox.
                'Usado para el registro de incidencia
                TextBox2.Text = DataGridView1.Item("ColumnaID", DataGridView1.SelectedRows(0).Index).Value
                TextBox4.Text = DataGridView1.Item("ColumnaDispositivo", DataGridView1.SelectedRows(0).Index).Value

                'Usado para el cambio de estatus
                TextBox7.Text = DataGridView1.Item("ColumnaID", DataGridView1.SelectedRows(0).Index).Value
                TextBox8.Text = DataGridView1.Item("ColumnaDispositivo", DataGridView1.SelectedRows(0).Index).Value
                TextBox9.Text = DataGridView1.Item("ColumnaUbicacion", DataGridView1.SelectedRows(0).Index).Value
                ComboTipo.Text = DataGridView1.Item("ColumnaTipo", DataGridView1.SelectedRows(0).Index).Value
                ComboSede.Text = DataGridView1.Item("ColumnaSede", DataGridView1.SelectedRows(0).Index).Value
                ComboGrupo.Text = DataGridView1.Item("ColumnaGrupo", DataGridView1.SelectedRows(0).Index).Value
                ComboEstado.Text = DataGridView1.Item("ColumnaEstado", DataGridView1.SelectedRows(0).Index).Value

                SerieSeguimientoIncidencia()

                TextBox12.Text = DataGridView1.Item("ColumnaGrupo", DataGridView1.SelectedRows(0).Index).Value

            End If

            'Luego de seleccionar el valor en el DataGridView1 llamamos a los metodos para cargar lo correspondiente.

            CargarHistorialSeguimiento()
            CargarHistorialEstatus()
            CargarHistorialServicios()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.4", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        'Se usa el evento CellMouseClick para obtener el index de la fila seleccionada
        'y luego pasarlo al textbox para que pueda ser posicionado luego de guardar 

        Try

            If DataGridView1.RowCount > 0 And DataGridView1.SelectedRows.Count = 1 Then

                If e.Button = MouseButtons.Left Then

                    Fila = DataGridView1.CurrentRow.Index
                    Columna = 5

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.3", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        'CellFormatting: Evento del control DataGridview el cual permite cambiar 
        'y dar formato a las celdas, bien sea por color de texto, fondo, etc.

        Try

            Dim TipoEstado As String
            Dim TipoDispositivo As String

            If DataGridView1.Columns(e.ColumnIndex).Name.Equals("ColumnaEstado") Then

                TipoEstado = (DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "OPERATIVO" Then

                    e.CellStyle.ForeColor = Color.Green
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Operativo

                End If

                If TipoEstado = "PRESENTANDO FALLAS" Then

                    e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Fallas

                End If

                If TipoEstado = "DESCONECTADO" Then

                    e.CellStyle.ForeColor = Color.Red
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Desconectada

                End If

            End If

            If DataGridView1.Columns(e.ColumnIndex).Name.Equals("ColumnaTipo") Then

                TipoDispositivo = (DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoDispositivo = "DVR - 16 CANALES" Then

                    'e.CellStyle.ForeColor = Color.Blue
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen3").Value = Dvr1

                End If

                If TipoDispositivo = "DVR - 20 CANALES" Then

                    'e.CellStyle.ForeColor = Color.Red
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen3").Value = Dvr2

                End If

                If TipoDispositivo = "CAMARA FRONTAL" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen3").Value = CamaraFrontal

                End If

                If TipoDispositivo = "CAMARA 360" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen3").Value = Camara360

                End If

                If TipoDispositivo = "OTRO DISPOSITIVO" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen3").Value = Otro

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.2", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        'CellFormatting: Evento del control DataGridview el cual permite cambiar 
        'y dar formato a las celdas, bien sea por color de texto, fondo, etc.

        Try

            Dim TipoEstado As String

            If DataGridView2.Columns(e.ColumnIndex).Name.Equals("ColumnaPrioridad") Then

                TipoEstado = (DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "ALTA" Then

                    e.CellStyle.ForeColor = Color.Red

                End If

                If TipoEstado = "MEDIA" Then

                    e.CellStyle.ForeColor = Color.Orange

                End If

                If TipoEstado = "BAJA" Then

                    e.CellStyle.ForeColor = Color.Green

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.2", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView3.CellFormatting
        'CellFormatting: Evento del control DataGridview el cual permite cambiar 
        'y dar formato a las celdas, bien sea por color de texto, fondo, etc.

        Try

            Dim TipoEstado As String

            If DataGridView3.Columns(e.ColumnIndex).Name.Equals("ColumnaDescripcion2") Then

                TipoEstado = (DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "OPERATIVO" Then

                    e.CellStyle.ForeColor = Color.Green
                    DataGridView3.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Operativo

                End If

                If TipoEstado = "PRESENTANDO FALLAS" Then

                    e.CellStyle.ForeColor = Color.Orange
                    DataGridView3.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Fallas

                End If

                If TipoEstado = "DESCONECTADO" Then

                    e.CellStyle.ForeColor = Color.Red
                    DataGridView3.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Desconectada

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.2", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView4_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView4.MouseClick
        'Metodo o evento que permite generar menu contextual con click derecho

        Try

            If DataGridView4.RowCount > 0 Or DataGridView4.SelectedRows.Count = 1 Then

                DataGridView4.ContextMenuStrip = MenuServicios

            Else

                DataGridView4.ContextMenuStrip = Nothing

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.7", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView4_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView4.MouseDown
        'Metodo o evento que permite seleccionar filas con el click derecho

        Dim Indice As Integer
        Dim Dato As DataGridView.HitTestInfo = DataGridView4.HitTest(e.X, e.Y)

        Try

            If e.Button = MouseButtons.Right Then

                If Dato.Type = DataGridViewHitTestType.Cell Then

                    If Dato.RowIndex >= 0 Then

                        Indice = Dato.RowIndex
                        DataGridView4.CurrentCell = DataGridView4.Rows(Dato.RowIndex).Cells(Dato.ColumnIndex)
                        DataGridView4.Rows(Dato.RowIndex).Selected = True
                        DataGridView4.ContextMenuStrip = MenuServicios

                    End If

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.8", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton guardar

        Try

            Dim fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")

            If ValidarComponentes() = True Then

                'Registro formal de la ruta con todos sus atributos
                Dim db As New MySqlCommand("INSERT INTO incidencia (idincidencia, dispositivo, prioridad, clasificacion, descripcion, fecha, hora) " _
                                    & " VALUES ('" & TextBox3.Text & "', '" & TextBox2.Text & "', '" & ComboPrioridad.Text & "', " _
                                    & " '" & ComboClasificacion.Text & "', '" & TextBox5.Text & "', '" & fecha & "', '" & TextBox6.Text & "')", Conexion)

                db.ExecuteNonQuery()

                'Se limpian todos los componentes del formulario para un nuevo uso.
                LimpiarComponentes()

                'Se habilita el metodo para incrementar el siguiente ID.
                SerieSeguimientoIncidencia()

                'Actualizamos la lista
                CargarGridSeguimiento()

                'Luego de seleccionar el valor en el DataGridView1 llamamos al metodo 
                'CargarHistorialSeguimiento para cargar lo correspondiente.
                CargarHistorialSeguimiento()

                'Luego de guardar nos posicionamos en la fila ya seleccionada anteriormente
                'para verificar la inclusion de la ruta en el datagridview2.
                DataGridView1.CurrentCell = DataGridView1(Columna, Fila)

                MsgBox("Registrado con Exito.", MsgBoxStyle.Information, "Exito.")

            End If

        Catch ex As Exception

            MsgBox("Debe verificar los datos.11", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub BotonGuardar2_Click(sender As Object, e As EventArgs) Handles BotonGuardar2.Click
        'Boton modificar

        Dim fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        'Se valida que no haya algun campo vacio
        If ValidarComponentes() = True Then

            Dim db As New MySqlCommand("UPDATE dispositivo SET nombredispositivo = '" & TextBox8.Text & "', " _
                             & " ubicacion = '" & TextBox9.Text & "', tipodispositivo = '" & TextBox11.Text & "', " _
                             & " grupo = '" & TextBox13.Text & "', estadodispositivo = '" & ComboEstado.Text & "' " _
                             & " WHERE iddispositivo = '" & TextBox7.Text & "' ", Conexion)

            db.ExecuteNonQuery()

            'Registro formal de la ruta con todos sus atributos
            Dim db2 As New MySqlCommand("INSERT INTO historial (idhistorial, dispositivo, descripcionhistorial, fecha, hora) " _
            & " VALUES ('" & TextBox10.Text & "', '" & TextBox7.Text & "', '" & ComboEstado.Text & "', '" & fecha & "', '" & TextBox6.Text & "')", Conexion)

            db2.ExecuteNonQuery()

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentes()

            'Se habilita el metodo para incrementar el siguiente ID.
            SerieSeguimientoIncidencia()
            SerieSeguimientohistorial()

            'Actualizamos la lista
            CargarGridSeguimiento()

            'Luego de seleccionar el valor en el DataGridView1 llamamos al metodo 
            'CargarHistorialEstatus para cargar lo correspondiente.
            CargarHistorialEstatus()

            'Luego de guardar nos posicionamos en la fila ya seleccionada anteriormente
            'para verificar la inclusion de la ruta en el datagridview2.
            DataGridView1.CurrentCell = DataGridView1(Columna, Fila)

            MsgBox("Modificado con Exito.", MsgBoxStyle.Information, "Exito.")

        End If

    End Sub

    Private Sub BotonSalir2_Click(sender As Object, e As EventArgs) Handles BotonSalir2.Click
        'Boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

            LimpiarDataGridView()

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal de la ventana sin liberar recursos
            Close()

        End If

    End Sub

    Private Sub ComboSede_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSede.SelectedIndexChanged
        'Evento que permite cargar el metodo de acuerdo al valor selecionado

        TextBox12.Text = ComboSede.Text
        CargarComboGrupo()

    End Sub

    Private Sub ComboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGrupo.SelectedIndexChanged
        'Obtenemos el id del grupo seleccionado

        ObtenerGrupo()

    End Sub

    Private Sub Panel2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Panel2.SelectedIndexChanged

        If Panel2.SelectedIndex = 0 Then

            Panel3.SelectedIndex = 0

        End If

        If Panel2.SelectedIndex = 1 Then

            Panel3.SelectedIndex = 1

            'Cargamos el combo con las sedes
            CargarComboSede()

        End If

    End Sub

    Private Sub Panel3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Panel3.SelectedIndexChanged
        'Evento donde se seleccionan los tabs del tabcontrol (paginas) y luego se cargan metodos dependiendo del index del tab

        If Panel3.SelectedIndex = 0 Then

            Panel2.SelectedIndex = 0

        End If

        If Panel3.SelectedIndex = 1 Then

            Panel2.SelectedIndex = 1

        End If

    End Sub

    Private Sub ComboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipo.SelectedIndexChanged
        'Este metodo permite obtener el ID de cada item seleccionado. 

        Try

            Dim Adaptador As New MySqlDataAdapter
            Dim Tabla As New DataTable

            Adaptador = New MySqlDataAdapter("SELECT idtipodispositivo FROM tipodispositivo WHERE nombretipo = '" & ComboTipo.Text & "' ", Conexion)
            Adaptador.Fill(Tabla)

            For Each row As DataRow In Tabla.Rows
                TextBox11.Text = row("idtipodispositivo").ToString
            Next

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.13", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboTipo_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ComboTipo.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList3.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList3.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList3.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList3.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboTipo_MeasureItem(sender As Object, e As System.Windows.Forms.MeasureItemEventArgs) Handles ComboTipo.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList3.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboPrioridad_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ComboPrioridad.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo2(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList4.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList4.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList4.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo2(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList4.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.667", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboPrioridad_MeasureItem(sender As Object, e As System.Windows.Forms.MeasureItemEventArgs) Handles ComboPrioridad.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList4.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.668", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboEstado_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ComboEstado.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo4(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList2.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList2.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList2.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo4(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList2.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboEstado_MeasureItem(sender As Object, e As System.Windows.Forms.MeasureItemEventArgs) Handles ComboEstado.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList2.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboSede_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ComboSede.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo5(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList5.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList5.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList5.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo5(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList5.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboSede_MeasureItem(sender As Object, e As System.Windows.Forms.MeasureItemEventArgs) Handles ComboSede.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList5.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub


End Class