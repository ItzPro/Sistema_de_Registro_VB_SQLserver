'----------------------------------------------------------------------------------------------------------------
'Import de conexion
'----------------------------------------------------------------------------------------------------------------
Imports System.Data.SqlClient
'----------------------------------------------------------------------------------------------------------------
'----------------------------------------------------------------------------------------------------------------
Public Class Empleado
    '----------------------------------------------------------------------------------------------------------------
    'Funcionalidades extras
    '----------------------------------------------------------------------------------------------------------------
    'Limpiar textboxs
    Private Sub Limpiar()
        txtNombreEmpleado.Clear()
        txtIDUbucacion.Clear()
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    'Botones de Agregar y Cerrar

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        PanelAgregar.Visible = True
        Limpiar()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        txtNombreEmpleado.Focus()
    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
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

        If txtNombreEmpleado.Text <> "" And txtIDUbucacion.Text <> "" Then
            Try

                Abrir_Conexion()
                Consulta = New SqlCommand("SP_AGREGAR_EMPLEADO", conexionsql)
                Consulta.CommandType = 4

                Consulta.Parameters.AddWithValue("@Nombre", txtNombreEmpleado.Text.ToString)
                Consulta.Parameters.AddWithValue("@TIENDA", Convert.ToInt32(txtIDUbucacion.Text))


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
            da = New SqlDataAdapter("SELECT * FROM V_MOSTRAR_EMPLEADO", conexionsql)

            'Forma para traer la data desde un procedimiento'
            'da = New SqlDataAdapter("SP_Mostrar_Tienda", conexionsql)
            da.Fill(dt)
            DataGridEmpleado.DataSource = dt
            Cerrar_Conexion()

            'Cambiar ancho del datagrid'
            DataGridEmpleado.Columns(0).Width = 70
            DataGridEmpleado.Columns(1).Width = 20
            DataGridEmpleado.Columns(2).Width = 200
            DataGridEmpleado.Columns(3).Width = 200
            DataGridEmpleado.Columns(4).Width = 200

            'Apariencia de los encabezados del datagrid'
            DataGridEmpleado.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Arial", 10, FontStyle.Regular Or FontStyle.Bold)
            DataGridEmpleado.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try

    End Sub



    'CARGAR EL FORM'

    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mostrar()
    End Sub

    'BUSCAR EN TIEMPO REAL'

    Private Sub BuscarDG()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try

            Abrir_Conexion()
            'Forma para traer la data desde una vista'
            da = New SqlDataAdapter("SP_BUSCAR_EMPLEADO", conexionsql)
            da.SelectCommand.CommandType = 4

            da.SelectCommand.Parameters.AddWithValue("@Buscar", txtBuscar.Text)

            da.Fill(dt)
            DataGridEmpleado.DataSource = dt
            Cerrar_Conexion()

            'Cambiar ancho del datagrid'
            DataGridEmpleado.Columns(0).Width = 70
            DataGridEmpleado.Columns(1).Width = 20
            DataGridEmpleado.Columns(2).Width = 200
            DataGridEmpleado.Columns(3).Width = 200
            DataGridEmpleado.Columns(4).Width = 200

            'Apariencia de los encabezados del datagrid'
            DataGridEmpleado.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Arial", 10, FontStyle.Regular Or FontStyle.Bold)
            DataGridEmpleado.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try



    End Sub



    'EVENTO AL ESCRIBIR EN EL BUSCADOR'

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDG()
    End Sub



    'MODIFICAR'
    '1. Hacer que el panel de agregar se abra con todos los datos reemplazados
    Private Sub DataGridEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DataGridEmpleado.DoubleClick
        PanelAgregar.Visible = True
        btnAgregar.Enabled = False
        btnModificar.Enabled = True

        Try
            Dim ID As String

            TextID.Text = DataGridEmpleado.SelectedCells.Item(1).Value
            txtNombreEmpleado.Text = DataGridEmpleado.SelectedCells.Item(2).Value
            txtIDUbucacion.Text = DataGridEmpleado.SelectedCells.Item(3).Value



        Catch ex As Exception

        End Try

    End Sub



    '2. Guardar modificacion

    Private Sub btnModificar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnModificar.MouseClick

        Dim Consulta As New SqlCommand

        If txtNombreEmpleado.Text <> "" And txtIDUbucacion.Text <> "" Then
            Try

                Abrir_Conexion()
                Consulta = New SqlCommand("SP_MODIFICAR_EMPLEADO", conexionsql)
                Consulta.CommandType = 4

                Consulta.Parameters.AddWithValue("@EMPLEADOID", TextID.Text.ToString)
                Consulta.Parameters.AddWithValue("@NOMBRE", txtNombreEmpleado.Text.ToString)
                Consulta.Parameters.AddWithValue("@TIENDAID", txtIDUbucacion.Text.ToString)

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

    Private Sub DataGridEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridEmpleado.CellContentClick

        'Verificar si se ha dado click sobre la columna eliminar'
        If e.ColumnIndex = DataGridEmpleado.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MsgBox("El registro sera eliminado", vbQuestion + vbOKCancel, "Empleados")

            If result = DialogResult.OK Then
                Dim Consulta As SqlCommand

                Try
                    Abrir_Conexion()
                    Consulta = New SqlCommand("SP_ELIMINAR_EMPLEADO", conexionsql)
                    Consulta.CommandType = 4
                    Consulta.Parameters.AddWithValue("@EMPLEADOID", DataGridEmpleado.SelectedCells.Item(1).Value)
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
    '----------------------------------------------------------------------------------------------------------------

End Class