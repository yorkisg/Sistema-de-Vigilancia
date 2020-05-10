
Module ModuloSeguimientoServicio


    Public Sub CargarComboSedeServicio()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("Select idsede, nombresede FROM sede ORDER BY nombresede ASC", Conexion)
        Adaptador.Fill(Tabla)

        SeguimientoServicio.ComboSede.DataSource = Tabla
        SeguimientoServicio.ComboSede.DisplayMember = "nombresede"
        SeguimientoServicio.ComboSede.ValueMember = "idsede"

    End Sub

    Public Sub CargarComboGrupoServicio()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("Select idgrupo, nombregrupo FROM grupo, sede " _
                         & " WHERE grupo.sede = sede.idsede " _
                         & " AND nombresede LIKE '" & SeguimientoServicio.TextBox3.Text & "' " _
                         & " ORDER BY nombregrupo ASC", Conexion)

        Adaptador.Fill(Tabla)

        SeguimientoServicio.ComboGrupo.DataSource = Tabla
        SeguimientoServicio.ComboGrupo.DisplayMember = "nombregrupo"
        SeguimientoServicio.ComboGrupo.ValueMember = "idgrupo"

    End Sub

    Public Sub CargarGridSeguimientoServicio()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT iddispositivo, idgrupo, nombregrupo, nombresede, descripcion, tipo, ubicacion, estado FROM dispositivo, grupo, sede " _
                       & " WHERE dispositivo.grupo = grupo.idgrupo " _
                       & " AND grupo.sede = sede.idsede " _
                       & " AND nombregrupo = '" & SeguimientoServicio.TextBox4.Text & "' " _
                       & " ORDER BY iddispositivo ASC "


        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "servicios")
        Tabla = DataSet.Tables("servicios")
        SeguimientoServicio.DataGridView1.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With SeguimientoServicio.DataGridView1
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 8) 'Fuente para Headers
        End With

        'Llamada al metodo para cargar imagenes
        CargarImagenesSeguimiento()

        SeguimientoServicio.DataGridView1.ClearSelection()

    End Sub


End Module
