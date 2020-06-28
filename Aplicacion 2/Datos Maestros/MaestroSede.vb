
Public Class MaestroSede

    Private Sub MaestroSede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se habilita la serie correlativa para el siguiente ID.
        SerieSede()

        'Se inhabilita el boton modificar.
        BotonModificar.Enabled = False

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox1.CharacterCasing = CharacterCasing.Upper
        TextBox2.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub MaestroSede_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        LimpiarComponentesSede()
        Dispose()

    End Sub

    Private Sub MaestroSede_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Evento que permite cerrar el formulario presionando la tecla esc

        If (e.KeyCode = Keys.Escape) Then

            LimpiarComponentesSede()
            Dispose()

        End If

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton registrar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesSede() = True Then

            Dim db As New MySqlCommand("INSERT INTO sede (idsede, nombresede) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "')", Conexion)
            db.ExecuteNonQuery()
            MsgBox("Sede registrada con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesSede()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieSede()

        End If

    End Sub

    Private Sub BotonModificar_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        'Boton modificar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesSede() = True Then

            Dim db As New MySqlCommand("UPDATE sede SET nombresede = '" & TextBox2.Text & "' WHERE idsede = '" & TextBox1.Text & "' ", Conexion)
            db.ExecuteNonQuery()
            MsgBox("Sede modificada con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se desactiva el uso del boton modificar.
            BotonModificar.Enabled = False
            'Se activa el uso del boton guardar.
            BotonGuardar.Enabled = True
            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesSede()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieSede()

        End If

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        'Boton buscar

        ListadoSede.ShowDialog()

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        LimpiarComponentesSede()
        Dispose()

    End Sub


End Class