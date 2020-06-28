
Public Class SeguimientoServicio

    Dim Contador As Integer = 0

    Private Sub SeguimientoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Inicializamos el timer
        Timer1.Start()
        Timer1.Interval = 1000

        'Carga inicial de las series
        SerieSeguimientoDetalleServicio()

        'Llamada al metodo para alternar los colores de las filas
        AlternarFilasGeneral(DataGridView1)
        AlternarFilasGeneral(DataGridView2)

        'Metodos de mejora para los componentes
        EnableDoubleBuffered(DataGridView1)
        EnableDoubleBuffered(DataGridView2)

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox8.CharacterCasing = CharacterCasing.Upper
        DateTimePicker1.Value = Today

        'validamos uso de los botones
        BotonGuardar.Enabled = False

        BotonAgregar.Enabled = False
        BotonRemover.Enabled = False

    End Sub

    Private Sub SeguimientoServicio_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Al cerrar el formulario por el boton "x" se ejecutan los metodos del boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal del formulario liberando recursos
            Dispose()

        End If

    End Sub

    Private Sub SeguimientoServicio_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Evento que permite cerrar el formulario presionando la tecla esc

        If (e.KeyCode = Keys.Escape) Then

            If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

                Tabla.Clear()
                DataSet.Clear()

                'Cierre formal del formulario liberando recursos
                Dispose()

            Else

                'Cierre formal del formulario liberando recursos
                Dispose()

            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Control Timer: se lleva el tiempo para que la hora y la fecha pueda ser actualizada constantemente

        'Contamos y enviamos el tiempo al label
        Contador = Contador + 1
        Tiempo.Text = Contador

        'Si el tiempo llega a 300 seg (5min) se cierra la aplicacion
        If Contador = 300 Then

            If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

                Tabla.Clear()
                DataSet.Clear()

                'Cierre formal del formulario liberando recursos
                Dispose()

            Else

                'Cierre formal del formulario liberando recursos
                Dispose()

            End If

        End If

    End Sub

    Private Sub ReiniciarTiempo()
        'Se detiene el tiempo, reiniciamos el contador y volvemos a iniciar el conteo del tiempo

        Timer1.Stop()

        Contador = 0

        Timer1.Start()

    End Sub

    Private Sub SeguimientoServicio_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Al mover el mouse sobre el formulario se reinicia el tiempo y evitamos el cierre de la aplicacion

        ReiniciarTiempo()

    End Sub

    Private Sub SeguimientoServicio_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'Al dar click sobre el formulario se reinicia el tiempo y evitamos el cierre de la aplicacion

        ReiniciarTiempo()

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        'Al mover el mouse sobre el panel se reinicia el tiempo y evitamos el cierre de la aplicacion

        ReiniciarTiempo()

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        'Al mover el mouse sobre el panel se reinicia el tiempo y evitamos el cierre de la aplicacion

        ReiniciarTiempo()

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton guardar

        Try

            Dim fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            Dim idmaterial As String
            Dim cantidad As Double

            'Limpiamos la seleccion y la edicion de la celda seleccionada al agregar la cantidad
            DataGridView2.ClearSelection()
            DataGridView2.EndEdit()

            'Iniciamos las validaciones correspondientes
            If ValidarComponentesServicios() = True And ValidarDataGridViewSeguimientoServicio() = True And ValidarDuplicadoSeguimientoServicio() = True Then

                'Se reccorren todos los elementos del grid para guardar fila por fila
                For Each row In DataGridView2.Rows

                    'Se inicializan variables 
                    idmaterial = row.Cells(0).Value
                    cantidad = row.Cells(3).Value

                    Dim db As New MySqlCommand("INSERT INTO detalleservicio (iddetalle, servicio, material, dispositivo, cantidadagregada, fechaservicio, observacion) " _
                    & " VALUES ('" & TextBox5.Text & "', '" & TextBox1.Text & "', '" & idmaterial & "', '" & TextBox7.Text & "', '" & cantidad & "', '" & fecha & "', '" & TextBox8.Text & "')", Conexion)

                    db.ExecuteNonQuery()

                    'Incrementamos el id para el siguiente registro
                    SerieSeguimientoDetalleServicio()

                Next

                'Se limpian todos los componentes del formulario para un nuevo uso.
                LimpiarComponentesServicio()

                MsgBox("Registrado con Exito.", MsgBoxStyle.Information, "Exito.")

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.1", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal de la ventana sin liberar recursos
            Close()

        End If

    End Sub

    Private Sub BotonAgregar_Click(sender As Object, e As EventArgs) Handles BotonAgregar.Click
        'Boton buscar

        'Activamos la seleccion multiple
        ListadoMaterial.DataGridView.MultiSelect = True
        ListadoMaterial.ShowDialog()

    End Sub

    Private Sub BotonRemover_Click(sender As Object, e As EventArgs) Handles BotonRemover.Click
        'boton remover material

        If DataGridView2.RowCount = 0 Then

            BotonRemover.Enabled = False

        ElseIf DataGridView2.RowCount = 1 Then

            DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
            BotonGuardar.Enabled = False
            BotonRemover.Enabled = False

        ElseIf DataGridView2.RowCount > 1 Then

            DataGridView2.Rows.Remove(DataGridView2.CurrentRow)

        End If

    End Sub

    Private Sub BotonBuscar1_Click(sender As Object, e As EventArgs) Handles BotonBuscar1.Click
        'Llamada al formulario "ListadoServicio"

        ListadoServicio.ShowDialog()
        CargarGridSeguimientoServicio()

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
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Dvr1

                End If

                If TipoDispositivo = "DVR - 20 CANALES" Then

                    'e.CellStyle.ForeColor = Color.Red
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Dvr2

                End If

                If TipoDispositivo = "CAMARA FRONTAL" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = CamaraFrontal

                End If

                If TipoDispositivo = "CAMARA 360" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Camara360

                End If

                If TipoDispositivo = "OTRO DISPOSITIVO" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView1.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Otro

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.3", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        'SelectionChanged o CellMouseClick: Propiedad del control DataGridview el cual permite hacer click
        'y seleccionar elementos por filas o columnas.
        'en este caso se selecciona el ID del vehiculo el cual es pasado a un control
        'TextBox pasa su posterior uso.

        Try

            If DataGridView1.RowCount > 0 And DataGridView1.SelectedRows.Count = 1 Then

                'Se limpian todos los componentes del formulario para un nuevo uso.
                LimpiarComponentesServicio()

                'Seleccionamos y pasamos el valor al TextBox.
                'Usado para el detalle de ruta
                TextBox7.Text = DataGridView1.Item("ColumnaID", DataGridView1.SelectedRows(0).Index).Value
                TextBox9.Text = DataGridView1.Item("ColumnaDispositivo", DataGridView1.SelectedRows(0).Index).Value

            End If


        Catch ex As Exception

            MsgBox("No se pudo completar la operación.4", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        'Para contar los caracteres en el textbox

        Label12.Text = Len(TextBox8.Text)

    End Sub


End Class