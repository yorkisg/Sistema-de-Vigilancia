
Public Class ListadoDispositivo

    Private Sub ListadoDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Metodos que cargaran al momento de desplegar el formulario.

        'Se llama el metodo para alternar colores entre filas
        AlternarFilasGeneral(DataGridView)

        'Se llama al metodo en el Load del formulario para que el datagridview cargue los datos inmediatamente
        CargarListadoDispositivo()

        'Se llama al metodo para que cargue rapido el datagridview
        EnableDoubleBuffered(DataGridView)

    End Sub

    Private Sub ListadoDispositivo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Cierre del formulario

        If DataGridView.RowCount > 0 Then
            'Si el datagridview contiene datos, obtenemos recursos 
            'liberando los datatable y dataset implementados.

            LimpiarComponentes()
            Tabla.Clear()
            DataSet.Clear()
            Dispose()

        Else

            Dispose()

        End If

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click
        'Boton aceptar

        If DataGridView.RowCount > 0 Then

            If MaestroDispositivo.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                MaestroDispositivo.TextBox1.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox2.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox3.Text = DataGridView.Item("ColumnaUbicacion", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox7.Text = DataGridView.Item("ColumnaDireccion", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox8.Text = DataGridView.Item("ColumnaMarca", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboTipo.Text = DataGridView.Item("ColumnaTipo", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboGrupo.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboEstado.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboSede.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value

                'Se activa el uso del boton modificar del formulario "MaestroVehiculo"
                MaestroDispositivo.BotonModificar.Enabled = True
                'Se desactiva el uso del boton guardar del formulario "MaestroVehiculo"
                MaestroDispositivo.BotonGuardar.Enabled = False

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

        End If

    End Sub

    Private Sub BotonExportar_Click(sender As Object, e As EventArgs) Handles BotonExportar.Click
        'Boton Exportar a Excel

        Try

            If DataGridView.RowCount > 0 Then

                Dim Mensaje As DialogResult

                Mensaje = MessageBox.Show("Desea expotar el listado?", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'Si la respuesta es "Si"
                If Mensaje = DialogResult.Yes Then

                    Exportar(DataGridView)

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

        If DataGridView.RowCount > 0 Then
            'Si el datagridview contiene datos, obtenemos recursos 
            'liberando los datatable y dataset implementados.

            LimpiarComponentes()
            Tabla.Clear()
            DataSet.Clear()
            Dispose()

        Else

            Dispose()

        End If

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged
        'TextBox que permite filtrar de acuerdo a lo establecido en la funcion "Filtrar".

        If Filtrar(TextBox.Text).Rows.Count > 0 Then

            DataGridView.DataSource = Filtrar(TextBox.Text)

        End If

    End Sub

    Function Filtrar(ByVal busqueda As String) As DataTable
        'Funcion que carga los datos de acuerdo a lo ingresado en el TextBox

        Dim cmd As New MySqlCommand("SELECT iddispositivo, nombredispositivo, ubicacion, direccionip, marca, nombretipo, nombregrupo, nombresede, estadodispositivo " _
                                       & " FROM dispositivo, grupo, sede, tipodispositivo " _
                                       & " WHERE dispositivo.grupo = grupo.idgrupo " _
                                       & " AND grupo.sede = sede.idsede " _
                                       & " AND dispositivo.tipodispositivo = tipodispositivo.idtipodispositivo " _
                                       & " AND nombredispositivo Like '%" & busqueda & "%' " _
                                       & " ORDER BY nombredispositivo ", Conexion)

        Dim Tabla As New DataTable
        Dim Adaptador As New MySqlDataAdapter(cmd)

        Adaptador.Fill(Tabla)

        Return Tabla

    End Function

    Private Sub DataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseDoubleClick
        'Al dar dobleclick en cualquier fila
        'se lleva la informacion correspondiente al siguiente formulario

        If DataGridView.RowCount > 0 Then

            If MaestroDispositivo.Visible = True Then
                'si el formulario "MaestroEstado" esta activo, se carga la informacion seleccionada del datagridview.

                MaestroDispositivo.TextBox1.Text = DataGridView.Item("ColumnaID", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox2.Text = DataGridView.Item("ColumnaDescripcion", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox3.Text = DataGridView.Item("ColumnaUbicacion", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox7.Text = DataGridView.Item("ColumnaDireccion", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.TextBox8.Text = DataGridView.Item("ColumnaMarca", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboTipo.Text = DataGridView.Item("ColumnaTipo", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboGrupo.Text = DataGridView.Item("ColumnaGrupo", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboEstado.Text = DataGridView.Item("ColumnaEstado", DataGridView.SelectedRows(0).Index).Value
                MaestroDispositivo.ComboSede.Text = DataGridView.Item("ColumnaSede", DataGridView.SelectedRows(0).Index).Value

                'Se activa el uso del boton modificar del formulario "MaestroVehiculo"
                MaestroDispositivo.BotonModificar.Enabled = True
                'Se desactiva el uso del boton guardar del formulario "MaestroVehiculo"
                MaestroDispositivo.BotonGuardar.Enabled = False

                'Se cierra el formulario ListadoVehiculo
                Tabla.Clear()
                DataSet.Clear()
                Dispose()

            End If

        End If

    End Sub

    Private Sub LimpiarComponentes()
        'Metodo que permite limpiar todos los controles del formulario.

        'Abrimos el ciclo que recorre todas las filas del datagridview
        For i As Integer = 0 To DataGridView.RowCount - 1

            'Eliminamos elemento por elemento
            DataGridView.Rows.Remove(DataGridView.CurrentRow)

        Next

    End Sub

    Private Sub DataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView.CellFormatting
        'CellFormatting: Evento del control DataGridview el cual permite cambiar 
        'y dar formato a las celdas, bien sea por color de texto, fondo, etc.

        Try

            Dim TipoDispositivo As String
            Dim TipoEstado As String

            If DataGridView.Columns(e.ColumnIndex).Name.Equals("ColumnaTipo") Then

                TipoDispositivo = (DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoDispositivo = "DVR - 16 CANALES" Then

                    'e.CellStyle.ForeColor = Color.Blue
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Dvr1

                End If

                If TipoDispositivo = "DVR - 20 CANALES" Then

                    'e.CellStyle.ForeColor = Color.Red
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Dvr2

                End If

                If TipoDispositivo = "CAMARA FRONTAL" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen").Value = CamaraFrontal

                End If

                If TipoDispositivo = "CAMARA 360" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Camara360

                End If

                If TipoDispositivo = "OTRO DISPOSITIVO" Then

                    'e.CellStyle.ForeColor = Color.Orange
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen").Value = Otro

                End If

            End If

            If DataGridView.Columns(e.ColumnIndex).Name.Equals("ColumnaEstado") Then

                TipoEstado = (DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If TipoEstado = "OPERATIVO" Then

                    e.CellStyle.ForeColor = Color.Green
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Operativo

                End If

                If TipoEstado = "PRESENTANDO FALLAS" Then

                    e.CellStyle.ForeColor = Color.Orange
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Fallas

                End If

                If TipoEstado = "DESCONECTADO" Then

                    e.CellStyle.ForeColor = Color.Red
                    DataGridView.Rows(e.RowIndex).Cells("ColumnaImagen2").Value = Desconectada

                End If

            End If

        Catch ex As Exception

            MsgBox("No se pudo completar la operación.", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub


End Class