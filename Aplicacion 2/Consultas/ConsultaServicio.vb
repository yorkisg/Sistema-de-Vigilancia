
Public Class ConsultaServicio

    Private Sub ConsultaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Llamada al metodo para alternar los colores de las filas
        AlternarFilasGeneral(DataGridView1)
        AlternarFilasGeneral(DataGridView2)
        AlternarFilasGeneral(DataGridView3)

        'Metodos de mejora para los componentes
        EnableDoubleBuffered(DataGridView1)
        EnableDoubleBuffered(DataGridView2)
        EnableDoubleBuffered(DataGridView3)

        BotonConsultar.Enabled = False

    End Sub

    Private Sub ConsultaServicio_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Al cerrar el formulario por el boton "x" se ejecutan los metodos del boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Or DataGridView3.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal del formulario liberando recursos
            Dispose()

        End If

    End Sub

    Private Sub ConsultaServicio_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Evento que permite cerrar el formulario presionando la tecla esc

        If (e.KeyCode = Keys.Escape) Then

            If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Or DataGridView3.RowCount > 0 Then

                Tabla.Clear()
                DataSet.Clear()

                'Cierre formal del formulario liberando recursos
                Dispose()

            Else

                'Cierre formal de la ventana sin liberar recursos
                Close()

            End If

        End If

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

    Private Sub BotonBuscar1_Click(sender As Object, e As EventArgs) Handles BotonBuscar1.Click
        'Llamada al formulario "ListadoServicio"

        ListadoServicio.ShowDialog()

        CargarGridObservacionServicio()
        CargarGridMaterialesServicio()

    End Sub

    Private Sub BotonBuscar2_Click(sender As Object, e As EventArgs) Handles BotonBuscar2.Click
        'Llamada al metodo de carga de datos

        Try

            'La fecha inicial no puede ser mayor que la fecha final
            If DateTimePicker2.Value <= DateTimePicker3.Value Then

                CargarGridListadoServicios()

            Else

                MsgBox("La fecha inicial no puede ser mayor a la fecha final.", MsgBoxStyle.Exclamation, "Error.")

            End If

        Catch ex As Exception


        End Try

    End Sub

    Private Sub BotonExportar_Click(sender As Object, e As EventArgs) Handles BotonExportar.Click
        'Boton Exportar a Excel

        Try

            If DataGridView1.RowCount > 0 And DataGridView2.RowCount > 0 Then

                Dim Mensaje As DialogResult

                Mensaje = MessageBox.Show("Desea expotar el listado?", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'Si la respuesta es "Si"
                If Mensaje = DialogResult.Yes Then


                    If Panel1.SelectedIndex = 0 Then

                        Exportar(DataGridView1)
                        Exportar(DataGridView2)

                    ElseIf Panel1.SelectedIndex = 1 Then

                        Exportar(DataGridView3)

                    ElseIf Panel1.SelectedIndex = 2 Then

                        'Exportar(DataGridView4)

                    End If

                End If

            Else

                MsgBox("No hay datos que exportar.", MsgBoxStyle.Exclamation, "Error.")

            End If

        Catch ex As Exception

            MsgBox("No se logró exportar nada, debe verificar con el administrador del sistema.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        'Boton salir

        If DataGridView1.RowCount > 0 Or DataGridView2.RowCount > 0 Or DataGridView3.RowCount > 0 Then

            Tabla.Clear()
            DataSet.Clear()

            'Cierre formal del formulario liberando recursos
            Dispose()

        Else

            'Cierre formal de la ventana sin liberar recursos
            Close()

        End If

    End Sub

    Private Sub DataGridView3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView3.CellFormatting
        'CellFormatting: Evento del control DataGridview el cual permite cambiar 
        'y dar formato a las celdas, bien sea por color de texto, fondo, etc.

        Try

            Dim TipoEstado As String

            If DataGridView3.Columns(e.ColumnIndex).Name.Equals("ColumnaEstado") Then

                TipoEstado = (DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "POR REALIZAR" Then

                    e.CellStyle.ForeColor = Color.Blue

                End If

                If TipoEstado = "COMPLETADO" Then

                    e.CellStyle.ForeColor = Color.Green

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub


End Class