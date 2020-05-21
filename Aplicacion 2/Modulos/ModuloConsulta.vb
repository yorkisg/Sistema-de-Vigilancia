
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


End Module
