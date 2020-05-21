
Public Class ConsultaServicio

    Private Sub ConsultaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Llamada al metodo para alternar los colores de las filas
        AlternarFilasGeneral(DataGridView1)
        AlternarFilasGeneral(DataGridView2)

        'Metodos de mejora para los componentes
        EnableDoubleBuffered(DataGridView1)
        EnableDoubleBuffered(DataGridView2)

        BotonConsultar.Enabled = False

    End Sub

    Private Sub ConsultaServicio_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Al cerrar el formulario por el boton "x" se ejecutan los metodos del boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal del formulario liberando recursos
            Dispose()

        End If

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal de la ventana sin liberar recursos
            Close()

        End If

    End Sub

    Private Sub BotonBuscar1_Click(sender As Object, e As EventArgs) Handles BotonBuscar1.Click
        'Llamada al formulario "ListadoServicio"

        ListadoServicio.ShowDialog()

        CargarGridObservacionServicio()
        CargarGridMaterialesServicio()

    End Sub

    Private Sub BotonConsultar_Click(sender As Object, e As EventArgs) Handles BotonConsultar.Click
        'Boton Filtrar

        Try

            If TextBox6.Text <> "" Then

                'CargarGridObservacionServicio()
                'CargarGridMaterialesServicio()

            ElseIf TextBox6.Text = "" Then

                'MsgBox("Debe seleccionar un servicio a consultar.", MsgBoxStyle.Exclamation, "Error.")

            End If

        Catch ex As Exception

        End Try

    End Sub


End Class