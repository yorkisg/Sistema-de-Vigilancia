

Imports System.Reflection

Module ModuloGeneral

    'Variables globales de conexion de datos.
    Public Command As MySqlCommand
    Public Adaptador As MySqlDataAdapter
    Public DataSet As DataSet
    Public Tabla As DataTable
    'Public Builder As MySqlCommandBuilder
    Public ConnectionString As String = "server=172.16.8.88;user=cecon01;password=1234;database=bdvigilancia;port=3306"
    Public Conexion As New MySqlConnection
    Public Reader As MySqlDataReader

    'Usado para cargar las imagenes en un arreglo y desplegarlas en el combobox mediante los eventos drawitem y measureitem
    Public Arreglo As New ArrayList
    Public Arreglo2 As New ArrayList

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''CONEXION A LA BD''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub ConectarBaseDeDatos()
        'Metodo que permite conectar la BD.

        Try

            If Conexion.State = ConnectionState.Closed Then

                Conexion.ConnectionString = " server=172.16.8.88; " _
                                     & " user=cecon01; " _
                                     & " password=1234; " _
                                     & " database=bdvigilancia; " _
                                     & " port=3306"
                Conexion.Open()

                'Comprobamos si existen actualizaciones disponibles e iniciamos la aplicacion
                'ComprobarActualizacion()

                MsgBox("Conexión Exitosa.", MsgBoxStyle.Information, "Exito.")

            End If

        Catch myerror As Exception

            MsgBox("Error en Conexión", MsgBoxStyle.Exclamation, "Error.")

        End Try

    End Sub

    Public Sub DesconectarBaseDeDatos()
        'Metodo que permite desconectar la BD.

        Try

            Conexion.Close()

        Catch myerror As System.Data.SqlClient.SqlException

            MsgBox("Base de Datos Cerrada.")

        End Try

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''METODOS DE APOYO'''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub AlternarFilasGeneral(ByVal DataGridView As DataGridView)
        'En este metodo especificamos cuales son los colores de las filas y los alternamos
        'con el color blanco y el color de seleccion de filas

        DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        DataGridView.RowsDefaultCellStyle.BackColor = Color.White

    End Sub

    Public Sub EnableDoubleBuffered(ByVal control As Control)
        'Metodo que permite la rapida ejecucion del listview al cargar los datos

        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})

    End Sub


End Module
