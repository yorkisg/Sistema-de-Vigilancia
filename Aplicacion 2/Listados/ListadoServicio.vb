
Public Class ListadoServicio

    Private Sub ListadoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se llama el metodo para alternar colores entre filas
        AlternarFilasGeneral(DataGridView)

        'Se llama al metodo en el Load del formulario para que el datagridview cargue los datos inmediatamente
        CargarListadoServicio()

        'Se llama al metodo para que cargue rapido el datagridview
        EnableDoubleBuffered(DataGridView)

        'Decimos que el primer elemento activo del combo es "POR REALIZAR"
        ComboEstado.SelectedItem = "POR REALIZAR"

        'si la llamada proviene del seguimiento liviano entonces cargamos los choferes livianos
        If SeguimientoServicio.Visible = True Then

            ComboEstado.SelectedItem = "POR REALIZAR"
            ComboEstado.Enabled = False

        End If

    End Sub

    Private Sub ListadoServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        If DataGridView.RowCount > 0 Then
            'Si el datagridview contiene datos, obtenemos recursos 
            'liberando los datatable y dataset implementados.

            LimpiarComponentes()
            Tabla.Clear()
            DataSet.Clear()
            Dispose()

        Else

            Dispose()

        End If

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton aceptar

        If DataGridView.RowCount > 0 Then

            If MaestroServicio.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                MaestroServicio.TextBox1.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.TextBox2.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.TextBox5.Text = DataGridView.Item("ColumnaResponsable", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.DateTimePicker1.Text = DataGridView.Item("ColumnaFecha", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.ComboGrupo.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.ComboEstado.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.ComboSede.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value

                'Se activa el uso del boton modificar del formulario "MaestroVehiculo"
                MaestroServicio.BotonModificar.Enabled = True
                'Se desactiva el uso del boton guardar del formulario "MaestroVehiculo"
                MaestroServicio.BotonGuardar.Enabled = False

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

            If SeguimientoServicio.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                SeguimientoServicio.TextBox1.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.DateTimePicker1.Text = DataGridView.Item("ColumnaFecha", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox2.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox10.Text = DataGridView.Item("ColumnaResponsable", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox4.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox3.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox6.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value

                'validamos uso de los botones
                'SeguimientoServicio.BotonGuardar.Enabled = True
                SeguimientoServicio.BotonAgregar.Enabled = True

                ComboEstado.Enabled = True

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

            If ConsultaServicio.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                ConsultaServicio.TextBox6.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox1.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox5.Text = DataGridView.Item("ColumnaResponsable", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.DateTimePicker1.Text = DataGridView.Item("ColumnaFecha", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox3.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox4.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox2.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value

                'ConsultaServicio.BotonConsultar.Enabled = True

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

        End If

    End Sub

    Private Sub BotonExportar_Click(sender As Object, e As EventArgs) Handles BotonExportar.Click
        'Boton Exportar a Excel

        Try

            If DataGridView.RowCount > 0 Then

                Dim Mensaje As DialogResult

                Mensaje = MessageBox.Show("Desea expotar el listado?", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'Si la respuesta es "Si"
                If Mensaje = DialogResult.Yes Then

                    Exportar(DataGridView)

                End If

            Else

                MsgBox("No hay datos que exportar.", MsgBoxStyle.Exclamation, "Error.")

            End If

        Catch ex As Exception

            MsgBox("No se logró exportar nada, debe verificar con el administrador del sistema.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        If DataGridView.RowCount > 0 Then
            'Si el datagridview contiene datos, obtenemos recursos 
            'liberando los datatable y dataset implementados.

            LimpiarComponentes()
            Tabla.Clear()
            DataSet.Clear()
            Dispose()

        Else

            Dispose()

        End If

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged
        'TextBox que permite filtrar de acuerdo a lo establecido en la funcion "Filtrar".

        If Filtrar(TextBox.Text).Rows.Count > 0 Then

            DataGridView.DataSource = Filtrar(TextBox.Text)

        End If

    End Sub

    Function Filtrar(ByVal busqueda As String) As DataTable
        'Funcion que carga los datos de acuerdo a lo ingresado en el TextBox

        Dim cmd As New MySqlCommand("SELECT idservicio, descripcion, fechainicio, nombresede, nombregrupo, estado" _
                                       & " FROM servicio, grupo, sede" _
                                       & " WHERE servicio.grupo = grupo.idgrupo " _
                                       & " AND grupo.sede = sede.idsede " _
                                       & " AND descripcion Like '%" & busqueda & "%' ", Conexion)

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter(cmd)

        Adaptador.Fill(Tabla)

        Return Tabla

    End Function

    Private Sub DataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseDoubleClick
        'Al dar dobleclick en cualquier fila
        'se lleva la informacion correspondiente al siguiente formulario

        If DataGridView.RowCount > 0 Then

            If MaestroServicio.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                MaestroServicio.TextBox1.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.TextBox2.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.TextBox5.Text = DataGridView.Item("ColumnaResponsable", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.DateTimePicker1.Text = DataGridView.Item("ColumnaFecha", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.ComboGrupo.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.ComboEstado.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value
                MaestroServicio.ComboSede.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value

                'Se activa el uso del boton modificar del formulario "MaestroVehiculo"
                MaestroServicio.BotonModificar.Enabled = True
                'Se desactiva el uso del boton guardar del formulario "MaestroVehiculo"
                MaestroServicio.BotonGuardar.Enabled = False

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

            If SeguimientoServicio.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                SeguimientoServicio.TextBox1.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.DateTimePicker1.Text = DataGridView.Item("ColumnaFecha", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox2.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox10.Text = DataGridView.Item("ColumnaResponsable", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox4.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox3.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value
                SeguimientoServicio.TextBox6.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value

                'validamos uso de los botones
                'SeguimientoServicio.BotonGuardar.Enabled = True
                SeguimientoServicio.BotonAgregar.Enabled = True

                ComboEstado.Enabled = True

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

            If ConsultaServicio.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                ConsultaServicio.TextBox6.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox1.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox5.Text = DataGridView.Item("ColumnaResponsable", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.DateTimePicker1.Text = DataGridView.Item("ColumnaFecha", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox3.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox4.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value
                ConsultaServicio.TextBox2.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value

                'ConsultaServicio.BotonConsultar.Enabled = True

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

        End If

    End Sub

    Private Sub LimpiarComponentes()
        'Metodo que permite limpiar todos los controles del formulario.

        'Abrimos el ciclo que recorre todas las filas del datagridview
        For i As Integer = 0 To DataGridView.RowCount - 1

            'Eliminamos elemento por elemento
            DataGridView.Rows.Remove(DataGridView.CurrentRow)

        Next

    End Sub

    Private Sub DataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView.CellFormatting
        'CellFormatting: Evento del control DataGridview el cual permite cambiar 
        'y dar formato a las celdas, bien sea por color de texto, fondo, etc.

        Try

            Dim TipoEstado As String

            If DataGridView.Columns(e.ColumnIndex).Name.Equals("ColumnaEstado") Then

                TipoEstado = (DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "POR REALIZAR" Then

                    e.CellStyle.ForeColor = Color.Blue

                End If

                If TipoEstado = "COMPLETADO" Then

                    e.CellStyle.ForeColor = Color.Green

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstado.SelectedIndexChanged
        'Evento donde seleccionamos el combobox y el elemento se va directamente al textbox
        'inmediatamente cargamos el datagridview para refrescar.

        TextBox1.Text = ComboEstado.Text
        CargarListadoServicio()

    End Sub


End Class