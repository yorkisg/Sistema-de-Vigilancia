﻿

Public Class SeguimientoDispositivo

    Dim Fila As Integer
    Dim Columna As Integer

    Private Sub SeguimientoDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarTimer()

        'Carga del arbol de opciones
        CargarArbolSeguimiento()

        'Validamos que el primer item seleccionado en el arbol sea el primero
        Arbol.SelectedNode = Arbol.Nodes(0).Nodes(0) 'SELECCIONAMOS EL PRIMER HIJO
        'Arbol.SelectedNode = Arbol.Nodes(0) 'SELECCIONAMOS EL PRIMER PADRE

        'Llamada al metodo para alternar los colores de las filas
        AlternarFilasGeneral(DataGridView1)
        AlternarFilasGeneral(DataGridView2)
        AlternarFilasGeneral(DataGridView3)
        'Metodos de mejora para los componentes

        EnableDoubleBuffered(Arbol)
        EnableDoubleBuffered(DataGridView1)
        EnableDoubleBuffered(DataGridView2)
        EnableDoubleBuffered(DataGridView3)

        'Inicializacion de la serie
        SerieSeguimientoIncidencia()
        SerieSeguimientohistorial()

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox5.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub SeguimientoDispositivo_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Al cerrar el formulario por el boton "x" se ejecutan los metodos del boton salir

        If DataGridView1.RowCount > 0 Then

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
        LimpiarComponentes()

        'Enviamos el nombre de la flota al textbox mediante la propiedad node.text
        TextBox1.Text = e.Node.Text

        'Al conocer la sede enviada al textbox, se ejecuta el metodo
        CargarGridSeguimiento()


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

            'Luego de seleccionar el valor en el DataGridView1 llamamos al metodo 
            'CargarHistorialSeguimiento para cargar lo correspondiente.

            CargarHistorialSeguimiento()
            CargarHistorialEstatus()

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

            If DataGridView1.Columns(e.ColumnIndex).Name.Equals("ColumnaEstado") Then

                TipoEstado = (DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "OPERATIVA" Then

                    e.CellStyle.ForeColor = Color.Green
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Operativo

                End If

                If TipoEstado = "PRESENTANDO FALLAS" Then

                    e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Fallas

                End If

                If TipoEstado = "DESCONECTADA" Then

                    e.CellStyle.ForeColor = Color.Red
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Desconectada

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

                If TipoEstado = "OPERATIVA" Then

                    e.CellStyle.ForeColor = Color.Green
                    DataGridView3.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Operativo

                End If

                If TipoEstado = "PRESENTANDO FALLAS" Then

                    e.CellStyle.ForeColor = Color.Orange
                    DataGridView3.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Fallas

                End If

                If TipoEstado = "DESCONECTADA" Then

                    e.CellStyle.ForeColor = Color.Red
                    DataGridView3.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Desconectada

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.2", MsgBoxStyle.Exclamation, "Error.")

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

            Dim db As New MySqlCommand("UPDATE dispositivo SET descripcion = '" & TextBox8.Text & "', " _
                             & " ubicacion = '" & TextBox9.Text & "', tipo = '" & ComboTipo.Text & "', " _
                             & " grupo = '" & TextBox13.Text & "', estado = '" & ComboEstado.Text & "' " _
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
            'DataGridView1.CurrentCell = DataGridView1(Columna, Fila)

            MsgBox("Modificado con Exito.", MsgBoxStyle.Information, "Exito.")

        End If

    End Sub

    Private Sub BotonSalir2_Click(sender As Object, e As EventArgs) Handles BotonSalir2.Click
        'Boton salir

        If DataGridView1.RowCount > 0 Then

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

    Private Sub ComboEstado_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboEstado.DrawItem

        If (e.Index <> -1) Then

            e.Graphics.DrawImage(ImageList2.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

            e.Graphics.DrawString(ComboEstado.Items(e.Index).ToString(), e.Font, Brushes.Black, e.Bounds.Left + ImageList2.Images(e.Index).Width, e.Bounds.Top)

        End If

    End Sub


End Class