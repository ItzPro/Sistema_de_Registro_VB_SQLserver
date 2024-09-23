'----------------------------------------------------------------------------------------------------------------
'Import de conexion
'----------------------------------------------------------------------------------------------------------------
Imports System.Data.SqlClient
'----------------------------------------------------------------------------------------------------------------
'----------------------------------------------------------------------------------------------------------------
Public Class Producto

    '----------------------------------------------------------------------------------------------------------------
    'Funcionalidades extras
    '----------------------------------------------------------------------------------------------------------------
    'Limpiar textboxs
    Private Sub Limpiar()
        txtnombreproducto.Clear()
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Botones de Agregar y Cerrar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelAgregar.Visible = True
        Limpiar()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        txtnombreproducto.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar()
        PanelAgregar.Visible = False
        btnAgregar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'CRUD

    'AGREGAR'


    Private Sub btnAgregar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseClick

        Dim Consulta As New SqlCommand

        If txtnombreproducto.Text <> "" Then
            Try

                Abrir_Conexion()
                Consulta = New SqlCommand("SP_AGREGAR_PRODUCTOS", conexionsql)
                Consulta.CommandType = 4

                Consulta.Parameters.AddWithValue("@Nombre", txtnombreproducto.Text.ToString)


                Consulta.ExecuteNonQuery()

                Cerrar_Conexion()



                PanelAgregar.Visible = False
                Limpiar()

                Mostrar()

            Catch ex As Exception

            End Try

        Else
            MsgBox("Los capos son obligatorios")

        End If

    End Sub

    'MOSTRAR'

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            'Forma para traer la data desde una vista'
            da = New SqlDataAdapter("SELECT * FROM V_Mostrar_PRODUCTOS", conexionsql)

            'Forma para traer la data desde un procedimiento'
            'da = New SqlDataAdapter("SP_Mostrar_Tienda", conexionsql)
            da.Fill(dt)
            DataGridProducto.DataSource = dt
            Cerrar_Conexion()

            'Cambiar ancho del datagrid'
            DataGridProducto.Columns(0).Width = 70
            DataGridProducto.Columns(1).Width = 20
            DataGridProducto.Columns(2).Width = 200


            'Apariencia de los encabezados del datagrid'
            DataGridProducto.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Arial", 10, FontStyle.Regular Or FontStyle.Bold)
            DataGridProducto.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mostrar()
    End Sub

    'BUSCAR EN TIEMPO REAL'

    Private Sub BuscarDG()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try

            Abrir_Conexion()
            'Forma para traer la data desde una vista'
            da = New SqlDataAdapter("SP_BUSCAR_PRODUCTOS", conexionsql)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@Buscar", txtBuscar.Text)

            da.Fill(dt)
            DataGridProducto.DataSource = dt
            Cerrar_Conexion()

            'Cambiar ancho del datagrid'
            DataGridProducto.Columns(0).Width = 70
            DataGridProducto.Columns(1).Width = 20
            DataGridProducto.Columns(2).Width = 200

            'Apariencia de los encabezados del datagrid'
            DataGridProducto.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Arial", 10, FontStyle.Regular Or FontStyle.Bold)
            DataGridProducto.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try


    End Sub


    'EVENTO AL ESCRIBIR EN EL BUSCADOR'
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDG()
    End Sub

    'MODIFICAR'
    '1. Hacer que el panel de agregar se abra con todos los datos reemplazados
    Private Sub DataGridProducto_DoubleClick(sender As Object, e As EventArgs) Handles DataGridProducto.DoubleClick
        PanelAgregar.Visible = True
        btnAgregar.Enabled = False
        btnModificar.Enabled = True

        Try
            Dim ID As String

            TextID.Text = DataGridProducto.SelectedCells.Item(1).Value
            txtnombreproducto.Text = DataGridProducto.SelectedCells.Item(2).Value



        Catch ex As Exception

        End Try

    End Sub


    '2. Guardar modificacion
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Consulta As New SqlCommand

        If txtnombreproducto.Text <> "" Then
            Try

                Abrir_Conexion()
                Consulta = New SqlCommand("SP_MODIFICAR_PRODUCTOS", conexionsql)
                Consulta.CommandType = 4

                Consulta.Parameters.AddWithValue("@PRODUCTOID", TextID.Text.ToString)
                Consulta.Parameters.AddWithValue("@NOMBRE", txtnombreproducto.Text.ToString)

                Consulta.ExecuteNonQuery()

                Cerrar_Conexion()



                PanelAgregar.Visible = False
                Limpiar()

                Mostrar()

            Catch ex As Exception

            End Try

        Else
            MsgBox("Los capos son obligatorios")

        End If
    End Sub

    'Eliominar'
    Private Sub DataGridProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProducto.CellContentClick

        'Verificar si se ha dado click sobre la columna eliminar'
        If e.ColumnIndex = DataGridProducto.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MsgBox("El registro sera eliminado", vbQuestion + vbOKCancel, "Productos")

            If result = DialogResult.OK Then
                Dim Consulta As SqlCommand

                Try
                    Abrir_Conexion()
                    Consulta = New SqlCommand("SP_ELIMINAR_PRODUCTOS", conexionsql)
                    Consulta.CommandType = 4
                    Consulta.Parameters.AddWithValue("@PRODUCTOID", DataGridProducto.SelectedCells.Item(1).Value)
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



    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Esto solo es para comprobar si funciona la conexion

    'Private Sub Tienda_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Abrir_Conexion()
    '    MsgBox("Conexion Creada")
    'End Sub

    '----------------------------------------------------------------------------------------------------------------


End Class