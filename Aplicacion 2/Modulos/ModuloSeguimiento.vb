
Module ModuloSeguimiento
    Public Property Seguimientodispostivo As Object

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''CARGA DEL ARBOL''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub CargarArbolSeguimiento()
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

    Public Sub CargarGridSeguimiento()
        'Metodo que genera la carga de datos en el DataGridview1 

        Dim sql As String = "SELECT iddispositivo, descripcion, tipo, ubicacion, estado FROM dispositivo, grupo " _
                       & " WHERE dispositivo.grupo = grupo.idgrupo " _
                       & " AND nombregrupo = '" & SeguimientoDispositivo.TextBox1.Text & "' " _
                       & " ORDER BY iddispositivo ASC "


        Dim connection As New MySqlConnection(ConnectionString)

        'Instancia y uso de variables.
        Command = New MySqlCommand(sql, connection)
        Adaptador = New MySqlDataAdapter(Command)
        DataSet = New DataSet()

        'Llenado del datagridview.
        Adaptador.Fill(DataSet, "flota")
        Tabla = DataSet.Tables("flota")
        SeguimientoDispositivo.DataGridView1.DataSource = Tabla

        'Parametros para editar apariencia del datagridview.
        With SeguimientoDispositivo.DataGridView1
            .DefaultCellStyle.Font = New Font("Segoe UI", 8) 'Fuente para celdas
            .Font = New Font("Segoe UI", 8) 'Fuente para Headers
        End With

        'Llamada al metodo para cargar imagenes
        'CargarImagenesEstadoVehiculoCarga()

        SeguimientoDispositivo.DataGridView1.ClearSelection()

    End Sub



End Module
