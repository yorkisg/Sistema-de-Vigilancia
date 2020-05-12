
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

    Public Sub SerieSeguimientoServicio()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(idservicio) FROM servicio", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        SeguimientoServicio.TextBox1.Text = Format(numero, "000000000")

    End Sub

    Public Sub SerieSeguimientoDetalle()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(iddetalle) FROM detalleservicio", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        SeguimientoServicio.TextBox5.Text = Format(numero, "000000000")

    End Sub

    Public Sub LimpiarComponentesServicio()
        'Metodo que permite limpiar todos los controles del formulario.

        'Abrimos el ciclo que recorre todas las filas del datagridview
        For i As Integer = 0 To SeguimientoServicio.DataGridView2.RowCount - 1

            'Eliminamos elemento por elemento
            SeguimientoServicio.DataGridView2.Rows.Remove(SeguimientoServicio.DataGridView2.CurrentRow)

        Next

        SeguimientoServicio.TextBox2.Text = ""

    End Sub

    Public Function ValidarComponentesServicio() As Boolean
        'Funcion booleana que permite validar si algun campo quedo vacio.

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        SeguimientoServicio.ErrorProvider1.Clear()

        If String.IsNullOrEmpty(SeguimientoServicio.TextBox1.Text) Then
            SeguimientoServicio.ErrorProvider1.SetError(SeguimientoServicio.TextBox1, "No puede dejar campos en blanco.")
            Validar = False
        Else
            'Si el error ha sido superado, se debe borrar
            SeguimientoServicio.ErrorProvider1.SetError(SeguimientoServicio.TextBox1, "")

        End If

        If String.IsNullOrEmpty(SeguimientoServicio.TextBox2.Text) Then
            SeguimientoServicio.ErrorProvider1.SetError(SeguimientoServicio.TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        Else
            'Si el error ha sido superado, se debe borrar
            SeguimientoServicio.ErrorProvider1.SetError(SeguimientoServicio.TextBox2, "")

        End If

        Return Validar

    End Function


End Module
