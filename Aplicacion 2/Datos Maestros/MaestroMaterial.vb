
Public Class MaestroMaterial

    Private Sub MaestroMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se habilita la serie correlativa para el siguiente ID.
        SerieMaterial()

        'Se inhabilita el boton modificar.
        BotonModificar.Enabled = False

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox2.CharacterCasing = CharacterCasing.Upper
        TextBox3.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub MaestroDispositivo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        LimpiarComponentesMaterial()
        Dispose()

    End Sub

    Private Sub MaestroMaterial_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Evento que permite cerrar el formulario presionando la tecla esc

        If (e.KeyCode = Keys.Escape) Then

            ComboUnidad.Dispose()

            LimpiarComponentesMaterial()
            Dispose()

        End If

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton registrar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesMaterial() = True Then

            Dim db As New MySqlCommand("INSERT INTO material (idmaterial, nombrematerial, unidad, cantidad) " _
            & " VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboUnidad.Text & "', '" & TextBox3.Text & "')", Conexion)

            db.ExecuteNonQuery()
            MsgBox("Registrado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesMaterial()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieMaterial()

        End If

    End Sub

    Private Sub BotonModificar_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        'Boton modificar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesMaterial() = True Then

            Dim db As New MySqlCommand("UPDATE material SET nombrematerial = '" & TextBox2.Text & "', unidad = '" & ComboUnidad.Text & "', cantidad = '" & TextBox3.Text & "' WHERE idmaterial = '" & TextBox1.Text & "' ", Conexion)
            db.ExecuteNonQuery()
            MsgBox("Modificado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se desactiva el uso del boton modificar.
            BotonModificar.Enabled = False
            'Se activa el uso del boton guardar.
            BotonGuardar.Enabled = True
            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesSeguimientoDispositivo()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieMaterial()

        End If

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        LimpiarComponentesMaterial()
        Dispose()

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        'Boton buscar

        ListadoMaterial.ShowDialog()

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        'Evento KeyPress: permite agregar solo numeros en el textbox.

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


End Class