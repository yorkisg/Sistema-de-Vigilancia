
Module ModuloSeguimientoServicio


    Public Sub CargarGridSeguimientoServicio()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT iddispositivo, idgrupo, nombregrupo, nombresede, nombredispositivo, nombretipo, ubicacion, estadodispositivo " _
                       & " FROM dispositivo, grupo, sede, tipodispositivo " _
                       & " WHERE dispositivo.grupo = grupo.idgrupo " _
                       & " AND grupo.sede = sede.idsede " _
                       & " AND dispositivo.tipodispositivo = tipodispositivo.idtipodispositivo " _
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

        CargarImagenesDispositivo()

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

        SeguimientoServicio.BotonRemover.Enabled = False
        SeguimientoServicio.BotonGuardar.Enabled = False
        'SeguimientoServicio.TextBox2.Text = ""

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

        If String.IsNullOrEmpty(SeguimientoServicio.TextBox8.Text) Then
            SeguimientoServicio.ErrorProvider1.SetError(SeguimientoServicio.Label10, "No puede dejar campos en blanco.")
            Validar = False
        Else
            'Si el error ha sido superado, se debe borrar
            SeguimientoServicio.ErrorProvider1.SetError(SeguimientoServicio.Label10, "")

        End If

        Return Validar

    End Function

    Public Function ValidarDataGridView() As Boolean
        'metodo para validar q no se cargue dos veces un elemento en el datagridview

        Dim Existe As Boolean = True

        If SeguimientoServicio.DataGridView2.RowCount > 0 Then

            'Validamos el ingreso de las cantidades en el datagridview2
            'Se reccorren todos los elementos del grid para guardar fila por fila
            For Each row In SeguimientoServicio.DataGridView2.Rows

                'Por ejemplo si deseas de nota
                If row.Cells("ColumnaCantidad").Value.ToString = "0" Or row.Cells("ColumnaCantidad").Value.ToString = "" Then

                    Existe = False

                End If

            Next

        End If

        If Existe = False Then

            MsgBox("Debe agregar una cantidad al material.", MsgBoxStyle.Exclamation, "Error.")

        End If

        Return Existe

    End Function

    Public Function ValidarDuplicado() As Boolean
        'metodo para validar q no se cargue dos veces un elemento en el datagridview

        Dim Existe As Boolean = True

        For Fila1 As Integer = 0 To SeguimientoServicio.DataGridView2.Rows.Count - 1

            For Fila2 As Integer = 0 To SeguimientoServicio.DataGridView2.Rows.Count - 1

                If Fila2 <> Fila1 AndAlso SeguimientoServicio.DataGridView2.Rows(Fila1).Cells(0).Value.ToString = SeguimientoServicio.DataGridView2.Rows(Fila2).Cells(0).Value.ToString Then

                    Existe = False

                End If

            Next

        Next

        If Existe = False Then

            MsgBox("Elementos repetidos, por favor verifique la información.", MsgBoxStyle.Exclamation, "Error.")

        End If

        Return Existe

    End Function


End Module
