
Module ModuloSeguimientoDispositivo

    Public Operativo As Image
    Public Desconectada As Image
    Public Fallas As Image


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''CARGA DEL ARBOL''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub CargarArbolSeguimientoDispositivo()
        'Metodo donde generamos el arbol de opciones de acuerdo a las flotas, subflotas y grupos registrados en BD

        'Adaptadores
        Dim Padres As New MySqlDataAdapter("SELECT idsede, nombresede " _
                                        & " FROM sede " _
                                        & " ORDER BY nombresede ASC", Conexion)

        Dim Hijos As New MySqlDataAdapter(" SELECT idgrupo, nombregrupo, sede " _
                                        & " FROM grupo " _
                                        & " ORDER BY idgrupo ASC", Conexion)
        Dim Dataset As New DataSet

        'Llenar el DataSet
        Padres.Fill(Dataset, "Padres")
        Hijos.Fill(Dataset, "Hijos")

        'Creamos una relación a través del campo idflota (flota) común en ambos objetos DataTable.
        Dim ColumnaPadre As DataColumn = Dataset.Tables("Padres").Columns("idsede")

        Dim ColumnaHijo As DataColumn = Dataset.Tables("Hijos").Columns("sede") 'clave foranea en tabla hijos (subflota)

        'se cambio a false por un error con los constrain
        Dim Relacion As New DataRelation("Padres_Hijos", ColumnaPadre, ColumnaHijo, False) '*********

        'Añadimos la relación al objeto DataSet.
        Dataset.Relations.Add(Relacion)

        With SeguimientoDispositivo.Arbol

            'Para que no se repinte el control TreeView hasta que se hayan creado los nodos.
            .BeginUpdate()

            'Limpiamos el control TreeView.
            .Nodes.Clear()

            'Añadimos un objeto TreeNode ra¡z para cada objeto Padre existente en el objeto DataTable llamado Padres.
            For Each padre As DataRow In Dataset.Tables("Padres").Rows

                'Creamos el nodo padre.
                Dim NodoPadre As New TreeNode(padre.Item("nombresede").ToString)

                'Lo añadimos a la colección Nodes del control TreeView.
                SeguimientoDispositivo.Arbol.Nodes.Add(NodoPadre)

                'Añadimos un objeto TreeNode hijo por cada objeto Hijo existente en el objeto Padre actual.
                For Each hijo In padre.GetChildRows("Padres_Hijos")

                    'Creamos el nodo hijo
                    Dim NodoHijo As New TreeNode(hijo.Item("nombregrupo").ToString)

                    'Lo añadimos al nodo padre
                    NodoPadre.Nodes.Add(NodoHijo)

                Next

            Next

            'Editamos la apariencia del arbol
            .Font = New Font("Calibri", 9)
            .ExpandAll()
            .EndUpdate()

        End With

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''CARGA DE DATOS''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub CargarGridSeguimientoDispositivo()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT iddispositivo, idgrupo, nombregrupo, nombresede, nombredispositivo, nombretipo, ubicacion, estadodispositivo " _
                       & " FROM dispositivo, grupo, sede, tipodispositivo " _
                       & " WHERE dispositivo.grupo = grupo.idgrupo " _
                       & " AND grupo.sede = sede.idsede " _
                       & " AND dispositivo.tipodispositivo = tipodispositivo.idtipodispositivo " _
                       & " AND nombregrupo = '" & SeguimientoDispositivo.TextBox1.Text & "' " _
                       & " ORDER BY iddispositivo ASC "


        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "seguimientos")
        Tabla = DataSet.Tables("seguimientos")
        SeguimientoDispositivo.DataGridView1.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With SeguimientoDispositivo.DataGridView1
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 8) 'Fuente para Headers
        End With

        'Llamada al metodo para cargar imagenes
        CargarImagenesSeguimientoDispositivo()

        CargarImagenesDispositivo()
        'SeguimientoDispositivo.DataGridView1.ClearSelection()

    End Sub

    Public Sub CargarHistorialSeguimientoDispositivo()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT idincidencia, descripcion, prioridad, clasificacion, fecha, hora " _
                            & " FROM incidencia " _
                            & " WHERE dispositivo = '" & SeguimientoDispositivo.TextBox2.Text & "' " _
                            & " ORDER BY idincidencia DESC, fecha DESC, hora DESC " _
                            & " LIMIT 10 "


        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "historial")
        Tabla = DataSet.Tables("historial")
        SeguimientoDispositivo.DataGridView2.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With SeguimientoDispositivo.DataGridView2
            .DefaultCellStyle.Font = New Font("Segoe UI", 7) 'Fuente para celdas
            .Font = New Font("Segoe UI", 8) 'Fuente para Headers
        End With

        'Llamada al metodo para cargar imagenes
        'CargarImagenesHistorial()

        SeguimientoDispositivo.DataGridView2.ClearSelection()

    End Sub

    Public Sub CargarHistorialEstatusDispositivo()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT idhistorial, nombredispositivo, descripcionhistorial, fecha, hora " _
                            & " FROM historial, dispositivo " _
                            & " WHERE historial.dispositivo = dispositivo.iddispositivo " _
                            & " AND dispositivo = '" & SeguimientoDispositivo.TextBox2.Text & "' " _
                            & " ORDER BY idhistorial DESC, fecha DESC, hora DESC "

        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "historial")
        Tabla = DataSet.Tables("historial")
        SeguimientoDispositivo.DataGridView3.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With SeguimientoDispositivo.DataGridView3
            .DefaultCellStyle.Font = New Font("Segoe UI", 7) 'Fuente para celdas
            .Font = New Font("Segoe UI", 8) 'Fuente para Headers
        End With

        'Llamada al metodo para cargar imagenes
        'CargarImagenesHistorial()

        SeguimientoDispositivo.DataGridView3.ClearSelection()

    End Sub

    Public Sub CargarHistorialServiciosDispositivo()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT servicio, nombredispositivo, nombreservicio, observacion, fechainicio " _
                    & " FROM dispositivo, detalleservicio, servicio " _
                    & " WHERE detalleservicio.dispositivo = dispositivo.iddispositivo " _
                    & " AND detalleservicio.servicio = servicio.idservicio " _
                    & " AND dispositivo = '" & SeguimientoDispositivo.TextBox2.Text & "' " _
                    & " ORDER BY fechainicio DESC "

        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "historialservicios")
        Tabla = DataSet.Tables("historialservicios")
        SeguimientoDispositivo.DataGridView4.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With SeguimientoDispositivo.DataGridView4
            .DefaultCellStyle.Font = New Font("Segoe UI", 7) 'Fuente para celdas
            .Font = New Font("Segoe UI", 8) 'Fuente para Headers
        End With

        SeguimientoDispositivo.DataGridView4.ClearSelection()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''METODOS DE APOYO''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub SerieIncidenciaSeguimientoDispositivo()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID

        'Se obtiene el ultimo ID
        Dim Command As New MySqlCommand("Select MAX(idincidencia) FROM incidencia", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        SeguimientoDispositivo.TextBox3.Text = Format(numero, "000000000")

    End Sub

    Public Sub SerieHistorialSeguimientoDispositivo()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID

        'Se obtiene el ultimo ID
        Dim Command As New MySqlCommand("Select MAX(idhistorial) FROM historial", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        SeguimientoDispositivo.TextBox10.Text = Format(numero, "000000000")

    End Sub

    Public Sub CargarImagenesSeguimientoDispositivo()
        'En este metodo especificamos cuales son las imagenes que se cargaran en el 
        'CellFormatting del DataGridView1

        Operativo = My.Resources.Operativo
        Desconectada = My.Resources.Desconectada
        Fallas = My.Resources.SinReporte

    End Sub

    Public Sub CargarComboSedeSeguimientoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("Select idsede, nombresede FROM sede ORDER BY nombresede ASC", Conexion)
        Adaptador.Fill(Tabla)

        SeguimientoDispositivo.ComboSede.DataSource = Tabla
        SeguimientoDispositivo.ComboSede.DisplayMember = "nombresede"
        SeguimientoDispositivo.ComboSede.ValueMember = "idsede"

        SeguimientoDispositivo.ComboSede.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        SeguimientoDispositivo.ComboSede.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        'Generamos un ciclo para obtener cada nombre de la consulta guardada en el Tabla
        'cada valor obtenido es agregado al ArrayList declarado al inicio de la clase
        For Each dr As DataRow In Tabla.Rows

            'guardamos cada registro en el arreglo
            Arreglo5.Add(dr("nombresede"))

        Next

    End Sub

    Public Sub CargarComboGrupoSeguimientoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("Select idgrupo, nombregrupo FROM grupo, sede " _
                         & " WHERE grupo.sede = sede.idsede " _
                         & " And nombresede LIKE '" & SeguimientoDispositivo.TextBox12.Text & "' " _
                         & " ORDER BY nombregrupo ASC", Conexion)

        Adaptador.Fill(Tabla)

        SeguimientoDispositivo.ComboGrupo.DataSource = Tabla
        SeguimientoDispositivo.ComboGrupo.DisplayMember = "nombregrupo"
        SeguimientoDispositivo.ComboGrupo.ValueMember = "idgrupo"

    End Sub

    Public Sub CargarComboPrioridadSeguimientoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Arreglo3.Add("ALTA")
        Arreglo3.Add("MEDIA")
        Arreglo3.Add("BAJA")

        SeguimientoDispositivo.ComboPrioridad.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        SeguimientoDispositivo.ComboPrioridad.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        SeguimientoDispositivo.ComboPrioridad.DataSource = Arreglo3

    End Sub

    Public Sub CargarComboEstadoSeguimientoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Arreglo4.Add("OPERATIVO")
        Arreglo4.Add("PRESENTANDO FALLAS")
        Arreglo4.Add("DESCONECTADO")

        SeguimientoDispositivo.ComboEstado.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        SeguimientoDispositivo.ComboEstado.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        SeguimientoDispositivo.ComboEstado.DataSource = Arreglo4

    End Sub

    Public Sub ObtenerGrupoSeguimientoDispositivo()
        'Este metodo permite obtener el ID del chofer y sus datos

        Dim Adaptador As New MySqlDataAdapter
        Dim Tabla As New DataTable

        Adaptador = New MySqlDataAdapter("SELECT idgrupo FROM grupo WHERE nombregrupo = '" & SeguimientoDispositivo.ComboGrupo.Text & "' ", Conexion)
        Adaptador.Fill(Tabla)

        For Each row As DataRow In Tabla.Rows

            SeguimientoDispositivo.TextBox13.Text = row("idgrupo").ToString

        Next

    End Sub

    Public Sub CargarComboTipoDispositivoSeguimiento()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM tipodispositivo", Conexion)
        Adaptador.Fill(Tabla)

        SeguimientoDispositivo.ComboTipo.DataSource = Tabla
        SeguimientoDispositivo.ComboTipo.DisplayMember = "nombretipo"
        SeguimientoDispositivo.ComboTipo.ValueMember = "idtipodispositivo"

        SeguimientoDispositivo.ComboTipo.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        SeguimientoDispositivo.ComboTipo.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        'Generamos un ciclo para obtener cada nombre de la consulta guardada en el Tabla
        'cada valor obtenido es agregado al ArrayList declarado al inicio de la clase
        For Each dr As DataRow In Tabla.Rows

            'guardamos cada registro en el arreglo
            Arreglo.Add(dr("nombretipo"))

        Next

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''METODOS DE LIMPIEZA'''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Function ValidarComponentesSeguimientoDispositivo() As Boolean
        'Funcion booleana que permite validar si algun campo quedo vacio.

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        SeguimientoDispositivo.ErrorProvider1.Clear()

        If SeguimientoDispositivo.Panel2.SelectedIndex = 0 Then

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox3.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox3, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox3, "")

            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox4.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox4, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox4, "")

            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox5.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox5, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox5, "")

            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox6.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox6, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox6, "")

            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.ComboClasificacion.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboClasificacion, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboClasificacion, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.ComboPrioridad.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboPrioridad, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboPrioridad, "")
            End If

        ElseIf SeguimientoDispositivo.Panel2.SelectedIndex = 1 Then

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox7.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox7, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox7, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox8.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox8, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox8, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.TextBox9.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox9, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.TextBox9, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.ComboTipo.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboTipo, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboTipo, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.ComboSede.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboSede, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboSede, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.ComboGrupo.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboGrupo, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboGrupo, "")
            End If

            If String.IsNullOrEmpty(SeguimientoDispositivo.ComboEstado.Text) Then
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboEstado, "No puede dejar campos en blanco.")
                Validar = False
            Else
                'Si el error ha sido superado, se debe borrar
                SeguimientoDispositivo.ErrorProvider1.SetError(SeguimientoDispositivo.ComboEstado, "")

            End If

        End If

        Return Validar

    End Function

    Public Sub LimpiarComponentesSeguimientoDispositivo()
        'Metodo que permite limpiar todos los controles del formulario.

        If SeguimientoDispositivo.Panel2.SelectedIndex = 0 Then

            SeguimientoDispositivo.TextBox2.Text = ""
            SeguimientoDispositivo.TextBox4.Text = ""
            SeguimientoDispositivo.TextBox5.Text = ""
            'SeguimientoDispositivo.ComboPrioridad.SelectedIndex = -1
            SeguimientoDispositivo.ComboClasificacion.SelectedIndex = -1

        ElseIf SeguimientoDispositivo.Panel2.SelectedIndex = 1 Then

            SeguimientoDispositivo.TextBox7.Text = ""
            SeguimientoDispositivo.TextBox8.Text = ""
            SeguimientoDispositivo.TextBox9.Text = ""
            'SeguimientoDispositivo.ComboTipo.SelectedIndex = -1
            'SeguimientoDispositivo.ComboSede.SelectedIndex = -1
            SeguimientoDispositivo.ComboGrupo.SelectedIndex = -1
            ' SeguimientoDispositivo.ComboEstado.SelectedIndex = -1

        End If

    End Sub

    Public Sub LimpiarDataGridViewSeguimientoDispositivo()
        'Metodo que permite limpiar todos los controles del formulario.

        If SeguimientoDispositivo.DataGridView1.RowCount > 0 Then

            'Abrimos el ciclo que recorre todas las filas del datagridview
            For i As Integer = 0 To SeguimientoDispositivo.DataGridView1.RowCount - 1

                SeguimientoDispositivo.DataGridView1.Rows.Remove(SeguimientoDispositivo.DataGridView1.CurrentRow)

            Next

        End If

        If SeguimientoDispositivo.DataGridView2.RowCount > 0 Then


            For i As Integer = 0 To SeguimientoDispositivo.DataGridView2.RowCount - 1

                SeguimientoDispositivo.DataGridView2.Rows.Remove(SeguimientoDispositivo.DataGridView2.CurrentRow)

            Next

        End If

        If SeguimientoDispositivo.DataGridView3.RowCount > 0 Then

            For i As Integer = 0 To SeguimientoDispositivo.DataGridView3.RowCount - 1

                SeguimientoDispositivo.DataGridView3.Rows.Remove(SeguimientoDispositivo.DataGridView3.CurrentRow)

            Next

        End If

        If SeguimientoDispositivo.DataGridView4.RowCount > 0 Then

            For i As Integer = 0 To SeguimientoDispositivo.DataGridView4.RowCount - 1

                SeguimientoDispositivo.DataGridView4.Rows.Remove(SeguimientoDispositivo.DataGridView4.CurrentRow)

            Next

        End If

    End Sub


End Module
