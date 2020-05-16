
Module ModuloListado

    Public Sub CargarListadoSede()
        'Metodo para cargar el datagridview.

        'Conexion a la BD.
        Dim sql As String = "SELECT idsede, nombresede FROM sede ORDER BY nombresede ASC"
        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "sedes")
        Tabla = DataSet.Tables("sedes")
        ListadoSede.DataGridView.DataSource = Tabla

        With ListadoSede.DataGridView
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ListadoSede.Contador.Text = ListadoSede.DataGridView.RowCount

    End Sub

    Public Sub CargarListadoDispositivo()
        'Metodo para cargar el datagridview.

        'Conexion a la BD.
        Dim sql As String = "SELECT iddispositivo, descripcion, ubicacion, tipo, nombregrupo, estado, nombresede " _
                            & " FROM dispositivo, grupo, sede " _
                            & " WHERE dispositivo.grupo = grupo.idgrupo " _
                            & " AND grupo.sede = sede.idsede " _
                            & " ORDER BY descripcion ASC"

        Dim connection As New MySqlConnection(ConnectionString)


        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "dispositivos")
        Tabla = DataSet.Tables("dispositivos")
        ListadoDispositivo.DataGridView.DataSource = Tabla

        With ListadoDispositivo.DataGridView
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ListadoDispositivo.Contador.Text = ListadoDispositivo.DataGridView.RowCount

    End Sub

    Public Sub CargarListadoGrupo()
        'Metodo para cargar el datagridview.

        'Conexion a la BD.
        Dim sql As String = "SELECT idgrupo, nombregrupo, nombresede " _
                            & " FROM grupo, sede " _
                            & " WHERE grupo.sede = sede.idsede" _
                            & " ORDER BY nombregrupo ASC"

        Dim connection As New MySqlConnection(ConnectionString)


        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "grupos")
        Tabla = DataSet.Tables("grupos")
        ListadoGrupo.DataGridView.DataSource = Tabla

        With ListadoGrupo.DataGridView
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ListadoGrupo.Contador.Text = ListadoGrupo.DataGridView.RowCount

    End Sub

    Public Sub CargarListadoMaterial()
        'Metodo para cargar el datagridview.

        'Conexion a la BD.
        Dim sql As String = "SELECT idmaterial, nombrematerial, unidad, cantidad " _
                            & " FROM material " _
                            & " ORDER BY nombrematerial ASC"

        Dim connection As New MySqlConnection(ConnectionString)


        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "materiales")
        Tabla = DataSet.Tables("materiales")
        ListadoMaterial.DataGridView.DataSource = Tabla

        With ListadoMaterial.DataGridView
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ListadoMaterial.Contador.Text = ListadoMaterial.DataGridView.RowCount

    End Sub

    Public Sub CargarListadoServicio()
        'Metodo para cargar el datagridview.

        'Conexion a la BD.
        Dim sql As String = "SELECT idservicio, descripcion, fechainicio, nombresede, nombregrupo, estado" _
                            & " FROM servicio, grupo, sede" _
                            & " WHERE servicio.grupo = grupo.idgrupo " _
                            & " AND grupo.sede = sede.idsede " _
                            & " AND estado = '" & ListadoServicio.TextBox1.Text & "' " _
                            & " ORDER BY descripcion ASC"

        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "servicios")
        Tabla = DataSet.Tables("servicios")
        ListadoServicio.DataGridView.DataSource = Tabla

        With ListadoServicio.DataGridView
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 9) 'Fuente para Headers
        End With

        'Mostramos la cantidad de registros encontrados
        ListadoServicio.Contador.Text = ListadoServicio.DataGridView.RowCount

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''METODOS DE APOYO''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



End Module

