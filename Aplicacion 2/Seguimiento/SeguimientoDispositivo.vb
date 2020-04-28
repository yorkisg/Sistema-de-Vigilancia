
Public Class SeguimientoDispositivo

    Private Sub SeguimientoDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarBaseDeDatos()

        CargarArbolSeguimiento()

        AlternarFilasGeneral(DataGridView1)
        EnableDoubleBuffered(DataGridView1)

    End Sub

    Private Sub Arbol_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Arbol.AfterSelect

        'Enviamos el nombre de la flota al textbox mediante la propiedad node.text
        TextBox1.Text = e.Node.Text

        CargarGridSeguimiento()


    End Sub

    Private Sub BotonRegistrar_Click(sender As Object, e As EventArgs) Handles BotonRegistrar.Click



    End Sub

    Private Sub BotonSalir2_Click(sender As Object, e As EventArgs) Handles BotonSalir2.Click

        Dispose()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class
