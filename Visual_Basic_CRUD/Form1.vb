Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    '----------------------------------------------------------------------------------------------------------------
    'CODIGO PARA MOSTRAR OTROS FORMS'
    '----------------------------------------------------------------------------------------------------------------
    Public Sub CargarFormularioEnPanel(formulario As Form)
        ' Limpia el panel antes de agregar un nuevo formulario
        Contenedor.Controls.Clear()

        ' Establece el tamaño del formulario para que se ajuste al panel
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill

        ' Agrega el formulario al panel
        Contenedor.Controls.Add(formulario)
        formulario.Show()
    End Sub
    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------

    '----------------------------------------------------------------------------------------------------------------
    'Evento al hacer click sobre el boton cargue el formulario'
    '----------------------------------------------------------------------------------------------------------------

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Dim frmMenu As New Menu()
        ' Llamar a la función para cargar el formulario en el panel
        CargarFormularioEnPanel(frmMenu)

    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        Dim frmTienda As New Tienda()
        ' Llamar a la función para cargar el formulario en el panel
        CargarFormularioEnPanel(frmTienda)
    End Sub

    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        Dim frmEmpleado As New Empleado()
        ' Llamar a la función para cargar el formulario en el panel
        CargarFormularioEnPanel(frmEmpleado)
    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        Dim frmProducto As New Producto()
        ' Llamar a la función para cargar el formulario en el panel
        CargarFormularioEnPanel(frmProducto)
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------

End Class
