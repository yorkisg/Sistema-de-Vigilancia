
Public Class MaestroDispositivo

    Private Sub MaestroDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se habilita la serie correlativa para el siguiente ID.
        SerieDispositivo()

        'Se inhabilita el boton modificar.
        BotonModificar.Enabled = False

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox2.CharacterCasing = CharacterCasing.Upper
        TextBox3.CharacterCasing = CharacterCasing.Upper
        TextBox8.CharacterCasing = CharacterCasing.Upper

        'Carga inicial de combos
        CargarComboSedeDispositivo()
        CargarComboTipoDispositivo()
        CargarComboEstadoDispositivo()

    End Sub

    Private Sub MaestroDispositivo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        LimpiarComponentesDispositivo()
        Dispose()

    End Sub

    Private Sub MaestroDispositivo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Evento que permite cerrar el formulario presionando la tecla esc

        If (e.KeyCode = Keys.Escape) Then

            ComboSede.Dispose()
            ComboGrupo.Dispose()
            ComboEstado.Dispose()
            ComboTipo.Dispose()

            LimpiarComponentesDispositivo()
            Dispose()

        End If

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton registrar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesDispositivo() = True Then

            Dim db As New MySqlCommand("INSERT INTO dispositivo (iddispositivo, nombredispositivo, ubicacion, direccionip, marca, tipodispositivo, grupo, estadodispositivo) " _
            & " VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox6.Text & "', '" & TextBox4.Text & "', '" & ComboEstado.Text & "')", Conexion)

            db.ExecuteNonQuery()
            MsgBox("Registrado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesDispositivo()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieDispositivo()

        End If

    End Sub

    Private Sub BotonModificar_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        'Boton modificar

        'Se valida que no haya algun campo vacio
        If ValidarComponentesDispositivo() = True Then

            Dim db As New MySqlCommand("UPDATE dispositivo SET nombredispositivo = '" & TextBox2.Text & "', ubicacion = '" & TextBox3.Text & "', direccionip = '" & TextBox7.Text & "', marca = '" & TextBox8.Text & "', tipodispositivo = '" & TextBox6.Text & "', grupo = '" & TextBox4.Text & "', estadodispositivo = '" & ComboEstado.Text & "' WHERE iddispositivo = '" & TextBox1.Text & "' ", Conexion)
            db.ExecuteNonQuery()
            MsgBox("Modificado con Exito.", MsgBoxStyle.Information, "Exito.")

            'Se desactiva el uso del boton modificar.
            BotonModificar.Enabled = False
            'Se activa el uso del boton guardar.
            BotonGuardar.Enabled = True
            'Se limpian todos los componentes del formulario para un nuevo uso.
            LimpiarComponentesDispositivo()
            'Se habilita el metodo para incrementar el siguiente ID.
            SerieDispositivo()

        End If

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        LimpiarComponentesDispositivo()
        Dispose()

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        'Boton buscar

        ListadoDispositivo.ShowDialog()

    End Sub

    Private Sub ComboSede_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSede.SelectedIndexChanged
        'Evento que permite cargar el metodo de acuerdo al valor selecionado

        TextBox5.Text = ComboSede.Text
        CargarComboGrupoDispositivo()

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

    Private Sub ComboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipo.SelectedIndexChanged
        'Este metodo permite obtener el ID de cada item seleccionado. 

        Dim Adaptador As New MySqlDataAdapter
        Dim Tabla As New DataTable

        Adaptador = New MySqlDataAdapter("SELECT idtipodispositivo FROM tipodispositivo WHERE nombretipo = '" & ComboTipo.Text & "' ", Conexion)
        Adaptador.Fill(Tabla)

        For Each row As DataRow In Tabla.Rows
            TextBox6.Text = row("idtipodispositivo").ToString
        Next

    End Sub

    Private Sub ComboTipo_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ComboTipo.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo3(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList3.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList3.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList3.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo3(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList3.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboTipo_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles ComboTipo.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList3.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

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

    Private Sub ComboEstado_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ComboEstado.DrawItem
        'Evento que dibuja el texto y las imagenes cargadas en el combobox

        Try

            e.DrawBackground()

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'Si hay un elemento seleccionado se dibuja la seleccion, el texto y la imagen

                'Dibuja la seleccion
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds)

                'Dibuja el texto
                e.Graphics.DrawString(Arreglo5(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList2.ImageSize.Width + 16, e.Bounds.Top)

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList2.Images(e.Index), e.Bounds.Left, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            Else
                'Si no se selecciona nada, se dibuja el texto y la imagen

                'Dibuja la imagen
                e.Graphics.DrawImage(ImageList2.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
                'Dibuja el texto
                e.Graphics.DrawString(Arreglo5(e.Index), e.Font, Brushes.Black, e.Bounds.Left + ImageList2.ImageSize.Width + 16, e.Bounds.Top)

                'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic

            End If

            e.DrawFocusRectangle()

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub ComboEstado_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles ComboEstado.MeasureItem
        'Esto es para darle espacio a los elementos mostrados en el ComboBox

        Try

            e.ItemHeight = ImageList2.ImageSize.Height + 3

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub


End Class