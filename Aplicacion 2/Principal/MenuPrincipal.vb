
Public Class MenuPrincipal

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Instancia principal de la conexion de la BD.
        ConectarBaseDeDatos()

        'Instancia del metodo que evita que el ejecutable se abra 2 veces
        Instancia()

    End Sub

    Private Sub MenuSalir2_Click(sender As Object, e As EventArgs) Handles MenuSalir2.Click

        'Desconexion de la BD y cierre de la aplicacion.
        DesconectarBaseDeDatos()

        'Dispose o Close, cualquiera de los dos sirve
        Close()

        'Application.Exit()

    End Sub

    Private Sub MenuSedes_Click(sender As Object, e As EventArgs) Handles MenuSedes.Click
        'Formulario MaestroSede

        MaestroSede.ShowDialog()

    End Sub

    Private Sub MenuDispositivos_Click(sender As Object, e As EventArgs) Handles MenuDispositivos.Click
        'Formulario MaestroDispositivo

        MaestroDispositivo.ShowDialog()

    End Sub

    Private Sub MenuGrupos_Click(sender As Object, e As EventArgs) Handles MenuGrupos.Click
        'Formulario MaestroGrupo

        MaestroGrupo.ShowDialog()

    End Sub

    Private Sub MenuSeguimientoIncidencia_Click(sender As Object, e As EventArgs) Handles MenuSeguimientoIncidencia.Click
        'Formulario SeguimientoDispositivo

        SeguimientoDispositivo.ShowDialog()

    End Sub


End Class