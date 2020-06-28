
Public Class MaestroGrupo

    Private Sub MaestroGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se habilita la serie correlativa para el siguiente ID.
        SerieGrupo()

        'Se inhabilita el boton modificar.
        BotonModificar.Enabled = False

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox2.CharacterCasing = CharacterCasing.Upper

        CargarComboSedeGrupo()

    End Sub

    Private Sub MaestroGrupo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        LimpiarComponentesGrupo()
        Dispose()

    End Sub

    Private Sub MaestroGrupo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Evento que permite cerrar el formulario presionando la tecla esc

        If (e.KeyCode = Keys.Escape) Then

            ComboSede.Dispose()

            LimpiarComponentesGrupo()
            Dispose()

        End If

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton registrar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesGrupo() = True Then

            Dim db As New MySqlCommand("INSERT INTO grupo (idgrupo, nombregrupo, sede) " _
                    & " VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')", Conexion)

            db.ExecuteNonQuery()
            MsgBox("Registrado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesGrupo()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieGrupo()

        End If

    End Sub

    Private Sub BotonModificar_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        'Boton modificar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesGrupo() = True Then

            Dim db As New MySqlCommand("UPDATE grupo SET nombregrupo = '" & TextBox2.Text & "', sede = '" & TextBox3.Text & "' WHERE idgrupo = '" & TextBox1.Text & "' ", Conexion)
            db.ExecuteNonQuery()
            MsgBox("Modificado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se desactiva el uso del boton modificar.
            BotonModificar.Enabled = False
            'Se activa el uso del boton guardar.
            BotonGuardar.Enabled = True
            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesGrupo()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieGrupo()

        End If

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        LimpiarComponentesGrupo()
        Dispose()

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        'Boton buscar

        ListadoGrupo.ShowDialog()

    End Sub

    Private Sub ComboSedeSelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSede.SelectedIndexChanged
        'Este metodo permite obtener el ID de cada item seleccionado. 

        Dim Adaptador As New MySqlDataAdapter
        Dim Tabla As New DataTable

        Adaptador = New MySqlDataAdapter("SELECT idsede FROM sede WHERE nombresede = '" & ComboSede.Text & "' ", Conexion)
        Adaptador.Fill(Tabla)

        For Each row As DataRow In Tabla.Rows
            TextBox3.Text = row("idsede").ToString
        Next

    End Sub

    Private Sub ComboSede_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ComboSede.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo2(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList1.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList1.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList1.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo2(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList1.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboSede_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles ComboSede.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList1.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub


End Class