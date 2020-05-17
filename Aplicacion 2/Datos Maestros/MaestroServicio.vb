
Public Class MaestroServicio

    Private Sub MaestroServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se habilita la serie correlativa para el siguiente ID.
        Serie()

        'Se inhabilita el boton modificar.
        BotonModificar.Enabled = False

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox2.CharacterCasing = CharacterCasing.Upper

        CargarComboSede()
        'CargarComboGrupo()

    End Sub

    Private Sub MaestroServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        LimpiarComponentes()
        Dispose()

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton registrar

        Dim fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        'Se valida que no haya algun campo vacio
        If ValidarComponentes() = True Then

            Dim db As New MySqlCommand("INSERT INTO servicio (idservicio, nombreservicio, fechainicio, grupo, estadoservicio) " _
            & " VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & fecha & "', '" & TextBox4.Text & "', '" & ComboEstado.Text & "')", Conexion)

            db.ExecuteNonQuery()
            MsgBox("Registrado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentes()
            'Se habilita el metodo para incrementar el siguiente ID.
            Serie()

        End If

    End Sub

    Private Sub BotonModificar_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        'Boton modificar

        Dim fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        'Se valida que no haya algun campo vacio
        If ValidarComponentes() = True Then

            Dim db As New MySqlCommand("UPDATE servicio SET nombreservicio = '" & TextBox2.Text & "', fechainicio = '" & fecha & "', grupo = '" & TextBox4.Text & "', estadoservicio = '" & ComboEstado.Text & "' WHERE idservicio = '" & TextBox1.Text & "' ", Conexion)
            db.ExecuteNonQuery()
            MsgBox("Modificado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se desactiva el uso del boton modificar.
            BotonModificar.Enabled = False
            'Se activa el uso del boton guardar.
            BotonGuardar.Enabled = True
            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentes()
            'Se habilita el metodo para incrementar el siguiente ID.
            Serie()

        End If

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        LimpiarComponentes()
        Dispose()

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        'Boton buscar

        ListadoServicio.ShowDialog()

    End Sub

    Private Sub LimpiarComponentes()
        'Metodo que permite limpiar todos los controles del formulario.

        'TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub CargarComboSede()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM sede ORDER BY nombresede ASC", Conexion)
        Adaptador.Fill(Tabla)

        ComboSede.DataSource = Tabla
        ComboSede.DisplayMember = "nombresede"
        ComboSede.ValueMember = "idsede"

    End Sub

    Private Sub CargarComboGrupo()
        'Metodo que permite cargar el Combobox desde la BD.

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter

        Adaptador = New MySqlDataAdapter("SELECT * FROM grupo, sede " _
                               & " WHERE grupo.sede = sede.idsede " _
                               & " And nombresede = '" & TextBox3.Text & "' ORDER BY nombregrupo ASC", Conexion)

        Adaptador.Fill(Tabla)

        ComboGrupo.DataSource = Tabla
        ComboGrupo.DisplayMember = "nombregrupo"
        ComboGrupo.ValueMember = "idgrupo"

    End Sub

    Private Sub ComboSede_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSede.SelectedIndexChanged
        'Evento que permite cargar el metodo de acuerdo al valor selecionado

        TextBox3.Text = ComboSede.Text
        CargarComboGrupo()

    End Sub

    Private Sub ComboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGrupo.SelectedIndexChanged
        'Este metodo permite obtener el ID de cada item seleccionado. 

        Dim Adaptador As New MySqlDataAdapter
        Dim Tabla As New DataTable

        Adaptador = New MySqlDataAdapter("SELECT idgrupo FROM grupo WHERE nombregrupo = '" & ComboGrupo.Text & "' ", Conexion)
        Adaptador.Fill(Tabla)

        For Each row As DataRow In Tabla.Rows
            TextBox4.Text = row("idgrupo").ToString
        Next

    End Sub

    Private Sub Serie()
        'Metodo que permite generar una serie correlativa de numeros enteros. 
        'Usado para generar automaticamente el ID.

        'Se obtiene el ultimo ID del chofer.
        Dim Command As New MySqlCommand("SELECT MAX(idservicio) FROM servicio", Conexion)
        Dim numero As Integer

        'El ID obtenido de la BD se incrementa.
        numero = Command.ExecuteScalar
        numero = numero + 1

        'Se da formato al ID obtenido de la BD.
        TextBox1.Text = Format(numero, "000000000")

    End Sub

    Function ValidarComponentes() As Boolean

        Dim Validar As Boolean = True

        'Limpia todos los mensajes de error mostrados en la interfaz de usuario
        ErrorProvider1.Clear()

        'Valida que el textbox no este nulo o vacio
        If String.IsNullOrEmpty(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(TextBox3.Text) Then
            ErrorProvider1.SetError(TextBox3, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(ComboSede.Text) Then
            ErrorProvider1.SetError(ComboSede, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(ComboGrupo.Text) Then
            ErrorProvider1.SetError(ComboGrupo, "No puede dejar campos en blanco.")
            Validar = False
        End If

        If String.IsNullOrEmpty(ComboEstado.Text) Then
            ErrorProvider1.SetError(ComboEstado, "No puede dejar campos en blanco.")
            Validar = False
        End If

        Return Validar

    End Function


End Class