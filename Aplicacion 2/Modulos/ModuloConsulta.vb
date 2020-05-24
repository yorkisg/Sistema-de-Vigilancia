
Module ModuloConsulta

    Public Sub CargarGridObservacionServicio()
        'Metodo para cargar el datagridview.

        'Conexion a la BD.
        Dim sql As String = "SELECT nombredispositivo, observacion " _
                            & " FROM dispositivo, detalleservicio " _
                            & " WHERE detalleservicio.dispositivo = dispositivo.iddispositivo " _
                            & " AND servicio = '" & ConsultaServicio.TextBox6.Text & "' " _
                            & " ORDER BY fechaservicio DESC "

        Dim connection As New MySqlConnection(ConnectionString)


        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "observaciones")
        Tabla = DataSet.Tables("observaciones")
        ConsultaServicio.DataGridView2.DataSource = Tabla

        With ConsultaServicio.DataGridView2
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        ConsultaServicio.DataGridView2.ClearSelection()

    End Sub

    Public Sub CargarGridMaterialesServicio()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT nombredispositivo, SUM(cantidadagregada) AS 'suma' " _
                        & " FROM dispositivo, detalleservicio " _
                        & " WHERE detalleservicio.dispositivo = dispositivo.iddispositivo " _
                        & " And servicio = '" & ConsultaServicio.TextBox6.Text & "' " _
                        & " GROUP BY nombredispositivo " _
                        & " ORDER BY SUM(cantidadagregada) DESC "

        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "historial")
        Tabla = DataSet.Tables("historial")
        ConsultaServicio.DataGridView1.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With ConsultaServicio.DataGridView1
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ConsultaServicio.Contador.Text = ConsultaServicio.DataGridView1.RowCount

        ConsultaServicio.DataGridView1.ClearSelection()

    End Sub

    Public Sub CargarGridListadoServicios()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT nombresede, nombregrupo, nombreservicio, responsable, fechainicio, estadoservicio " _
                           & " FROM sede, grupo, servicio " _
                           & " WHERE servicio.grupo = grupo.idgrupo " _
                           & " AND grupo.sede = sede.idsede "

        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "historial")
        Tabla = DataSet.Tables("historial")
        ConsultaServicio.DataGridView3.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With ConsultaServicio.DataGridView3
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ConsultaServicio.Contador.Text = ConsultaServicio.DataGridView3.RowCount

        ConsultaServicio.DataGridView3.ClearSelection()

    End Sub

    Public Sub ObtenerServicio()
        'Este metodo permite obtener el ID del chofer y sus datos

        Dim Adaptador As New MySqlDataAdapter
        Dim Tabla As New DataTable

        Adaptador = New MySqlDataAdapter("SELECT idservicio, nombreservicio, responsable, tiposervicio, fechainicio, nombresede, nombregrupo, idgrupo, estadoservicio " _
                                        & " FROM sede, grupo, servicio " _
                                        & " WHERE servicio.grupo = grupo.idgrupo " _
                                        & " AND grupo.sede = sede.idsede " _
                                        & " AND idservicio = '" & MaestroServicio.TextBox1.Text & "' ", Conexion)

        Adaptador.Fill(Tabla)

        For Each row As DataRow In Tabla.Rows

            MaestroServicio.TextBox1.Text = row("idservicio").ToString
            MaestroServicio.TextBox2.Text = row("nombreservicio").ToString
            MaestroServicio.TextBox5.Text = row("responsable").ToString
            MaestroServicio.ComboTipo.Text = row("tiposervicio").ToString
            MaestroServicio.DateTimePicker1.Text = row("fechainicio").ToString

            MaestroServicio.ComboSede.Text = row("nombresede").ToString '''''''''''''''''''''''''''''''''''
            MaestroServicio.ComboGrupo.Text = row("nombregrupo").ToString '''''''''''''''''''''''''''''''''''

            MaestroServicio.TextBox4.Text = row("idgrupo").ToString
            MaestroServicio.ComboEstado.Text = row("estadoservicio").ToString

        Next

    End Sub


End Module
