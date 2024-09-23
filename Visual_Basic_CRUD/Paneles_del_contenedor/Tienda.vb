'----------------------------------------------------------------------------------------------------------------
'Import de conexion
'----------------------------------------------------------------------------------------------------------------
Imports System.Data.SqlClient
'----------------------------------------------------------------------------------------------------------------
'----------------------------------------------------------------------------------------------------------------
Public Class Tienda

    '----------------------------------------------------------------------------------------------------------------
    'Funcionalidades extras
    '----------------------------------------------------------------------------------------------------------------
    'Limpiar textboxs
    Private Sub Limpiar()
        TextNombreTienda.Clear()
        TextUbicacion.Clear()
    End Sub
    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------

    '----------------------------------------------------------------------------------------------------------------
    'BOTONES
    '----------------------------------------------------------------------------------------------------------------
    'AGREGAR'
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        DatosTienda.Visible = True
        Limpiar()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        TextNombreTienda.Focus()
    End Sub
    '----------------------------------------------------------------------------------------------------------------
    'Cerrar "Dentro del panel de agregar"

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        Limpiar()
        DatosTienda.Visible = False
        btnAgregar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------


    '----------------------------------------------------------------------------------------------------------------
    'CRUD
    '----------------------------------------------------------------------------------------------------------------
    'GUARDAR'
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim Consulta As New SqlCommand

        If TextNombreTienda.Text <> "" And TextUbicacion.Text <> "" Then
            Try

                Abrir_Conexion()
                Consulta = New SqlCommand("SP_Agregar_Tienda", conexionsql)
                Consulta.CommandType = 4

                Consulta.Parameters.AddWithValue("@Nombre", TextNombreTienda.Text.ToString)
                Consulta.Parameters.AddWithValue("@Ubicacion", TextUbicacion.Text.ToString)

                Consulta.ExecuteNonQuery()

                Cerrar_Conexion()



                DatosTienda.Visible = False
                Limpiar()

                Mostrar()

            Catch ex As Exception

            End Try

        Else
            MsgBox("Los capos son obligatorios")

        End If

    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'MOSTRAR DATA EN EL DATAGRID

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            'Forma para traer la data desde una vista'
            da = New SqlDataAdapter("SELECT * FROM V_Mostrar_Tienda", conexionsql)

            'Forma para traer la data desde un procedimiento'
            'da = New SqlDataAdapter("SP_Mostrar_Tienda", conexionsql)
            da.Fill(dt)
            DataTienda.DataSource = dt
            Cerrar_Conexion()

            'Cambiar ancho del datagrid'
            DataTienda.Columns(0).Width = 70
            DataTienda.Columns(1).Width = 20
            DataTienda.Columns(2).Width = 200
            DataTienda.Columns(3).Width = 200

            'Apariencia de los encabezados del datagrid'
            DataTienda.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Arial", 10, FontStyle.Regular Or FontStyle.Bold)
            DataTienda.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Al cargar la pestaña se carga el datagrid "EVENTO"
    Private Sub Tienda_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mostrar()
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Buscar en tiempo real

    Private Sub BuscarDG()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try

            Abrir_Conexion()
            'Forma para traer la data desde una vista'
            da = New SqlDataAdapter("SP_Buscar_Tienda", conexionsql)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@Buscar", txtBuscar.Text)

            da.Fill(dt)
            DataTienda.DataSource = dt
            Cerrar_Conexion()

            'Cambiar ancho'
            DataTienda.Columns(0).Width = 70
            DataTienda.Columns(1).Width = 20
            DataTienda.Columns(2).Width = 200
            DataTienda.Columns(3).Width = 200

            'Apariencia de los encabezados'
            DataTienda.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Arial", 10, FontStyle.Regular Or FontStyle.Bold)
            DataTienda.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try



    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Para mandar a llamar en tiempo real el buscador

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDG()
        DatosTienda.Visible = False
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Funcionalidad para traer la data del datagrid a los textbox de agregar "Recordatorio necesitas un lugar para colocar el ID asi que crea un txt.visible = false"'


    Private Sub DataTienda_DoubleClick(sender As Object, e As EventArgs) Handles DataTienda.DoubleClick

        DatosTienda.Visible = True
        btnAgregar.Enabled = False
        btnModificar.Enabled = True

        Try
            Dim ID As String

            TextID.Text = DataTienda.SelectedCells.Item(1).Value
            TextNombreTienda.Text = DataTienda.SelectedCells.Item(2).Value
            TextUbicacion.Text = DataTienda.SelectedCells.Item(3).Value



        Catch ex As Exception

        End Try




    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Modificar

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Consulta As New SqlCommand

        If TextNombreTienda.Text <> "" And TextUbicacion.Text <> "" Then
            Try

                Abrir_Conexion()
                Consulta = New SqlCommand("SP_Modificar_Tienda", conexionsql)
                Consulta.CommandType = 4

                Consulta.Parameters.AddWithValue("@TiendaID", TextID.Text.ToString)
                Consulta.Parameters.AddWithValue("@Nombre", TextNombreTienda.Text.ToString)
                Consulta.Parameters.AddWithValue("@Ubicacion", TextUbicacion.Text.ToString)

                Consulta.ExecuteNonQuery()

                Cerrar_Conexion()



                DatosTienda.Visible = False
                Limpiar()

                Mostrar()

            Catch ex As Exception

            End Try

        Else
            MsgBox("Los capos son obligatorios")

        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'ELIMINAR

    Private Sub DataTienda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataTienda.CellContentClick
        'Verificar si se ha dado click sobre la columna eliminar'
        If e.ColumnIndex = DataTienda.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MsgBox("El registro sera eliminado", vbQuestion + vbOKCancel, "Tiendas")

            If result = DialogResult.OK Then
                Dim Consulta As SqlCommand

                Try
                    Abrir_Conexion()
                    Consulta = New SqlCommand("SP_Eliminar_Tienda", conexionsql)
                    Consulta.CommandType = 4
                    Consulta.Parameters.AddWithValue("@TiendaID", DataTienda.SelectedCells.Item(1).Value)
                    Consulta.ExecuteNonQuery()
                    Cerrar_Conexion()

                    Mostrar()

                Catch ex As Exception

                End Try
            Else
                MsgBox("Eliminacion Cancelada")
            End If
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Esto solo es para comprobar si funciona la conexion

    'Comprobacion de conexion
    'Private Sub Tienda_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Abrir_Conexion()
    '    MsgBox("Conexion Creada")
    'End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
End Class