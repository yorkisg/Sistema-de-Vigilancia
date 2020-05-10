
Public Class SeguimientoServicio

    Private Sub SeguimientoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'InicializarTimer()

        'Carga del arbol de opciones
        CargarArbolSeguimiento()

        'Llamada al metodo para alternar los colores de las filas
        AlternarFilasGeneral(DataGridView1)
        AlternarFilasGeneral(DataGridView2)

        'Metodos de mejora para los componentes
        EnableDoubleBuffered(DataGridView1)
        EnableDoubleBuffered(DataGridView2)

        'Validamos que en cada Textbox del formulario solo se agregue texto en mayusculas.
        TextBox2.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click


    End Sub

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click


    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        'Boton buscar

        'ListadoServicio.ShowDialog()

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        If DataGridView1.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal de la ventana sin liberar recursos
            Close()

        End If

    End Sub

    Private Sub BotonAgregar_Click(sender As Object, e As EventArgs) Handles BotonAgregar.Click
        'Boton buscar

        ListadoMaterial.ShowDialog()


    End Sub

    Private Sub BotonRemover_Click(sender As Object, e As EventArgs) Handles BotonRemover.Click


    End Sub

End Class