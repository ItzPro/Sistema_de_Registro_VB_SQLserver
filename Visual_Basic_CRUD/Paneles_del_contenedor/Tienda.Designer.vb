﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tienda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTienda = New System.Windows.Forms.Panel()
        Me.DatosTienda = New System.Windows.Forms.Panel()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TextUbicacion = New System.Windows.Forms.TextBox()
        Me.TextNombreTienda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataTienda = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.panelBusqueda.SuspendLayout()
        Me.PanelTienda.SuspendLayout()
        Me.DatosTienda.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.panelBusqueda.Controls.Add(Me.Button1)
        Me.panelBusqueda.Controls.Add(Me.txtBuscar)
        Me.panelBusqueda.Controls.Add(Me.Buscar)
        Me.panelBusqueda.Controls.Add(Me.Label1)
        Me.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(805, 44)
        Me.panelBusqueda.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(127, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(579, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(214, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'Buscar
        '
        Me.Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buscar.AutoSize = True
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Buscar.Location = New System.Drawing.Point(510, 12)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(65, 20)
        Me.Buscar.TabIndex = 1
        Me.Buscar.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tienda"
        '
        'PanelTienda
        '
        Me.PanelTienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTienda.Controls.Add(Me.DatosTienda)
        Me.PanelTienda.Controls.Add(Me.DataTienda)
        Me.PanelTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTienda.Location = New System.Drawing.Point(0, 44)
        Me.PanelTienda.Name = "PanelTienda"
        Me.PanelTienda.Size = New System.Drawing.Size(805, 495)
        Me.PanelTienda.TabIndex = 1
        '
        'DatosTienda
        '
        Me.DatosTienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.DatosTienda.Controls.Add(Me.TextID)
        Me.DatosTienda.Controls.Add(Me.Button4)
        Me.DatosTienda.Controls.Add(Me.Panel2)
        Me.DatosTienda.Controls.Add(Me.btnModificar)
        Me.DatosTienda.Controls.Add(Me.btnAgregar)
        Me.DatosTienda.Controls.Add(Me.TextUbicacion)
        Me.DatosTienda.Controls.Add(Me.TextNombreTienda)
        Me.DatosTienda.Controls.Add(Me.Label3)
        Me.DatosTienda.Controls.Add(Me.Label4)
        Me.DatosTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatosTienda.Location = New System.Drawing.Point(0, 0)
        Me.DatosTienda.Name = "DatosTienda"
        Me.DatosTienda.Size = New System.Drawing.Size(805, 495)
        Me.DatosTienda.TabIndex = 1
        Me.DatosTienda.Visible = False
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(766, 55)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(27, 20)
        Me.TextID.TabIndex = 18
        Me.TextID.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(614, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 44)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Cerrar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 49)
        Me.Panel2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(18, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Agregar Tienda"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Maroon
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Transparent
        Me.btnModificar.Location = New System.Drawing.Point(201, 425)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(159, 44)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregar.Location = New System.Drawing.Point(16, 425)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(159, 44)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'TextUbicacion
        '
        Me.TextUbicacion.Location = New System.Drawing.Point(333, 207)
        Me.TextUbicacion.Name = "TextUbicacion"
        Me.TextUbicacion.Size = New System.Drawing.Size(321, 20)
        Me.TextUbicacion.TabIndex = 13
        '
        'TextNombreTienda
        '
        Me.TextNombreTienda.Location = New System.Drawing.Point(333, 154)
        Me.TextNombreTienda.Name = "TextNombreTienda"
        Me.TextNombreTienda.Size = New System.Drawing.Size(321, 20)
        Me.TextNombreTienda.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(121, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ubicacion de la tienda: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(121, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre de la tienda: "
        '
        'DataTienda
        '
        Me.DataTienda.AllowUserToAddRows = False
        Me.DataTienda.AllowUserToDeleteRows = False
        Me.DataTienda.AllowUserToResizeColumns = False
        Me.DataTienda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataTienda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTienda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataTienda.EnableHeadersVisualStyles = False
        Me.DataTienda.Location = New System.Drawing.Point(16, 19)
        Me.DataTienda.Name = "DataTienda"
        Me.DataTienda.ReadOnly = True
        Me.DataTienda.RowHeadersVisible = False
        Me.DataTienda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataTienda.Size = New System.Drawing.Size(777, 464)
        Me.DataTienda.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar"
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(805, 539)
        Me.Controls.Add(Me.PanelTienda)
        Me.Controls.Add(Me.panelBusqueda)
        Me.Name = "Tienda"
        Me.Text = "Tienda"
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        Me.PanelTienda.ResumeLayout(False)
        Me.DatosTienda.ResumeLayout(False)
        Me.DatosTienda.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataTienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Buscar As Label
    Friend WithEvents PanelTienda As Panel
    Friend WithEvents DataTienda As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DatosTienda As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents TextUbicacion As TextBox
    Friend WithEvents TextNombreTienda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents TextID As TextBox
    Friend WithEvents Eliminar As DataGridViewButtonColumn
End Class
