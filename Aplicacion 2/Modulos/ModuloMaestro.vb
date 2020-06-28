
Module ModuloMaestro

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''MAESTRO DISPOSITIVO'''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub CargarComboSedeDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM sede ORDER BY nombresede ASC", Conexion)
        Adaptador.Fill(Tabla)

        MaestroDispositivo.ComboSede.DataSource = Tabla
        MaestroDispositivo.ComboSede.DisplayMember = "nombresede"
        MaestroDispositivo.ComboSede.ValueMember = "idsede"

        MaestroDispositivo.ComboSede.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        MaestroDispositivo.ComboSede.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        'Generamos un ciclo para obtener cada nombre de la consulta guardada en el Tabla
        'cada valor obtenido es agregado al ArrayList declarado al inicio de la clase
        For Each dr As DataRow In Tabla.Rows

            'guardamos cada registro en el Arreglo2
            Arreglo2.Add(dr("nombresede"))

        Next

    End Sub

    Public Sub CargarComboGrupoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM grupo, sede " _
                               & " WHERE grupo.sede = sede.idsede " _
                               & " And nombresede = '" & MaestroDispositivo.TextBox5.Text & "' ORDER BY nombregrupo ASC", Conexion)

        Adaptador.Fill(Tabla)

        MaestroDispositivo.ComboGrupo.DataSource = Tabla
        MaestroDispositivo.ComboGrupo.DisplayMember = "nombregrupo"
        MaestroDispositivo.ComboGrupo.ValueMember = "idgrupo"

    End Sub

    Public Sub CargarComboTipoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM tipodispositivo ORDER BY idtipodispositivo ASC", Conexion)
        Adaptador.Fill(Tabla)

        MaestroDispositivo.ComboTipo.DataSource = Tabla
        MaestroDispositivo.ComboTipo.DisplayMember = "nombretipo"
        MaestroDispositivo.ComboTipo.ValueMember = "idtipodispositivo"

        MaestroDispositivo.ComboTipo.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        MaestroDispositivo.ComboTipo.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        'Generamos un ciclo para obtener cada nombre de la consulta guardada en el Tabla
        'cada valor obtenido es agregado al ArrayList declarado al inicio de la clase
        For Each dr As DataRow In Tabla.Rows

            'guardamos cada registro en el Arreglo2
            Arreglo3.Add(dr("nombretipo"))

        Next

    End Sub

    Public Sub CargarComboEstadoDispositivo()
        'Metodo que permite cargar el Combobox desde la BD.

        Arreglo5.Add("OPERATIVO")
        Arreglo5.Add("PRESENTANDO FALLAS")
        Arreglo5.Add("DESCONECTADO")

        MaestroDispositivo.ComboEstado.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        MaestroDispositivo.ComboEstado.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        MaestroDispositivo.ComboEstado.DataSource = Arreglo5

    End Sub

    Public Sub SerieDispositivo()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(iddispositivo) FROM dispositivo", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        MaestroDispositivo.TextBox1.Text = Format(numero, "000000000")

    End Sub

    Public Sub LimpiarComponentesDispositivo()
        'Metodo que permite limpiar todos los controles del formulario.

        'TextBox1.Text = ""
        MaestroDispositivo.TextBox2.Text = ""
        MaestroDispositivo.TextBox3.Text = ""
        MaestroDispositivo.TextBox7.Text = ""
        MaestroDispositivo.TextBox8.Text = ""

    End Sub

    Public Function ValidarComponentesDispositivo() As Boolean

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        MaestroDispositivo.ErrorProvider1.Clear()

        'Valida que el textbox no este nulo o vacio
        If String.IsNullOrEmpty(MaestroDispositivo.TextBox2.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.TextBox3.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.TextBox3, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.TextBox7.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.TextBox7, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.TextBox8.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.TextBox8, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.ComboTipo.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.ComboTipo, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.ComboSede.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.ComboSede, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.ComboGrupo.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.ComboGrupo, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroDispositivo.ComboEstado.Text) Then
            MaestroDispositivo.ErrorProvider1.SetError(MaestroDispositivo.ComboEstado, "No puede dejar campos en blanco.")
            Validar = False
        End If

        Return Validar

    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''MAESTRO GRUPO'''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub CargarComboSedeGrupo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM sede ORDER BY nombresede ASC", Conexion)
        Adaptador.Fill(Tabla)

        MaestroGrupo.ComboSede.DataSource = Tabla
        MaestroGrupo.ComboSede.DisplayMember = "nombresede"
        MaestroGrupo.ComboSede.ValueMember = "idsede"

        MaestroGrupo.ComboSede.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        MaestroGrupo.ComboSede.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        'Generamos un ciclo para obtener cada nombre de la consulta guardada en el Tabla
        'cada valor obtenido es agregado al ArrayList declarado al inicio de la clase
        For Each dr As DataRow In Tabla.Rows

            'guardamos cada registro en el Arreglo2
            Arreglo2.Add(dr("nombresede"))

        Next

    End Sub

    Public Sub SerieGrupo()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(idgrupo) FROM grupo", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        MaestroGrupo.TextBox1.Text = Format(numero, "000000000")

    End Sub

    Public Sub LimpiarComponentesGrupo()
        'Metodo que permite limpiar todos los controles del formulario.

        'MaestroGrupo.TextBox1.Text = ""
        MaestroGrupo.TextBox2.Text = ""

    End Sub

    Public Function ValidarComponentesGrupo() As Boolean

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        MaestroGrupo.ErrorProvider1.Clear()

        'Valida que el textbox no este nulo o vacio
        If String.IsNullOrEmpty(MaestroGrupo.TextBox2.Text) Then
            MaestroGrupo.ErrorProvider1.SetError(MaestroGrupo.TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroGrupo.ComboSede.Text) Then
            MaestroGrupo.ErrorProvider1.SetError(MaestroGrupo.ComboSede, "No puede dejar campos en blanco.")
            Validar = False
        End If

        Return Validar

    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''MAESTRO MATERIAL''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub SerieMaterial()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(idmaterial) FROM material", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        MaestroMaterial.TextBox1.Text = Format(numero, "000000000")

    End Sub

    Public Sub LimpiarComponentesMaterial()
        'Metodo que permite limpiar todos los controles del formulario.

        'TextBox1.Text = ""
        MaestroMaterial.TextBox2.Text = ""
        MaestroMaterial.TextBox3.Text = ""

    End Sub

    Public Function ValidarComponentesMaterial() As Boolean

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        MaestroMaterial.ErrorProvider1.Clear()

        'Valida que el textbox no este nulo o vacio
        If String.IsNullOrEmpty(MaestroMaterial.TextBox2.Text) Then
            MaestroMaterial.ErrorProvider1.SetError(MaestroMaterial.TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroMaterial.TextBox3.Text) Then
            MaestroMaterial.ErrorProvider1.SetError(MaestroMaterial.TextBox3, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroMaterial.ComboUnidad.Text) Then
            MaestroMaterial.ErrorProvider1.SetError(MaestroMaterial.ComboUnidad, "No puede dejar campos en blanco.")
            Validar = False
        End If

        Return Validar

    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''MAESTRO SEDE''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub SerieSede()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(idsede) FROM sede", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        MaestroSede.TextBox1.Text = Format(numero, "000000000")

    End Sub

    Public Sub LimpiarComponentesSede()
        'Metodo que permite limpiar todos los controles del formulario.

        'TextBox1.Text = ""
        MaestroSede.TextBox2.Text = ""

    End Sub

    Public Function ValidarComponentesSede() As Boolean

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        MaestroSede.ErrorProvider1.Clear()

        'Valida que el textbox no este nulo o vacio
        If String.IsNullOrEmpty(MaestroSede.TextBox2.Text) Then
            MaestroSede.ErrorProvider1.SetError(MaestroSede.TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        End If

        Return Validar

    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''MAESTRO SERVICIO''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub CargarComboSedeServicio()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM sede ORDER BY nombresede ASC", Conexion)
        Adaptador.Fill(Tabla)

        MaestroServicio.ComboSede.DataSource = Tabla
        MaestroServicio.ComboSede.DisplayMember = "nombresede"
        MaestroServicio.ComboSede.ValueMember = "idsede"

        MaestroServicio.ComboSede.DrawMode = DrawMode.OwnerDrawVariable 'PARA PODER PONER NUESTRAS IMAGENES
        MaestroServicio.ComboSede.DropDownHeight = 480 'PARA QUE MUESTRE TODOS LOS ELEMENTOS. DEPENDE DEL NUMERO DE ELEMENTOS Y SU ALTURA

        'Generamos un ciclo para obtener cada nombre de la consulta guardada en el Tabla
        'cada valor obtenido es agregado al ArrayList declarado al inicio de la clase
        For Each dr As DataRow In Tabla.Rows

            'guardamos cada registro en el Arreglo2
            Arreglo2.Add(dr("nombresede"))

        Next

    End Sub

    Public Sub CargarComboGrupoServicio()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM grupo, sede " _
                               & " WHERE grupo.sede = sede.idsede " _
                               & " AND nombresede = '" & MaestroServicio.ComboSede.Text & "' ", Conexion)

        Adaptador.Fill(Tabla)

        MaestroServicio.ComboGrupo.DataSource = Tabla
        MaestroServicio.ComboGrupo.DisplayMember = "nombregrupo"
        MaestroServicio.ComboGrupo.ValueMember = "idgrupo"

    End Sub

    Public Sub SerieServicio()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(idservicio) FROM servicio", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        MaestroServicio.TextBox1.Text = Format(numero, "000000000")

    End Sub

    Public Sub LimpiarComponentesServicio()
        'Metodo que permite limpiar todos los controles del formulario.

        ' maestroservicio.TextBox1.Text = ""
        MaestroServicio.TextBox2.Text = ""
        MaestroServicio.TextBox5.Text = ""

    End Sub

    Public Function ValidarComponentesServicio() As Boolean

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        MaestroServicio.ErrorProvider1.Clear()

        'Valida que el textbox no este nulo o vacio
        If String.IsNullOrEmpty(MaestroServicio.TextBox2.Text) Then
            MaestroServicio.ErrorProvider1.SetError(MaestroServicio.TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroServicio.TextBox5.Text) Then
            MaestroServicio.ErrorProvider1.SetError(MaestroServicio.TextBox5, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroServicio.ComboSede.Text) Then
            MaestroServicio.ErrorProvider1.SetError(MaestroServicio.ComboSede, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroServicio.ComboGrupo.Text) Then
            MaestroServicio.ErrorProvider1.SetError(MaestroServicio.ComboGrupo, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroServicio.ComboEstado.Text) Then
            MaestroServicio.ErrorProvider1.SetError(MaestroServicio.ComboEstado, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(MaestroServicio.ComboTipo.Text) Then
            MaestroServicio.ErrorProvider1.SetError(MaestroServicio.ComboTipo, "No puede dejar campos en blanco.")
            Validar = False
        End If

        Return Validar

    End Function


End Module
