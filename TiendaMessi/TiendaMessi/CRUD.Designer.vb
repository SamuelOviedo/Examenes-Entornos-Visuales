<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvRegistros = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.mtbCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.mtbPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.mtbPrecio)
        Me.GroupBox1.Controls.Add(Me.mtbCantidad)
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Location = New System.Drawing.Point(686, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 389)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvRegistros)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 268)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'dgvRegistros
        '
        Me.dgvRegistros.AllowUserToAddRows = False
        Me.dgvRegistros.AllowUserToDeleteRows = False
        Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistros.Location = New System.Drawing.Point(3, 18)
        Me.dgvRegistros.Name = "dgvRegistros"
        Me.dgvRegistros.ReadOnly = True
        Me.dgvRegistros.RowHeadersWidth = 51
        Me.dgvRegistros.RowTemplate.Height = 24
        Me.dgvRegistros.Size = New System.Drawing.Size(634, 247)
        Me.dgvRegistros.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(138, 125)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(64, 17)
        Me.Cantidad.TabIndex = 5
        Me.Cantidad.Text = "Cantidad"
        '
        'mtbCantidad
        '
        Me.mtbCantidad.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCantidad.Location = New System.Drawing.Point(196, 145)
        Me.mtbCantidad.Mask = "999"
        Me.mtbCantidad.Name = "mtbCantidad"
        Me.mtbCantidad.Size = New System.Drawing.Size(85, 31)
        Me.mtbCantidad.TabIndex = 6
        '
        'mtbPrecio
        '
        Me.mtbPrecio.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbPrecio.Location = New System.Drawing.Point(368, 61)
        Me.mtbPrecio.Mask = "9999.99"
        Me.mtbPrecio.Name = "mtbPrecio"
        Me.mtbPrecio.Size = New System.Drawing.Size(138, 31)
        Me.mtbPrecio.TabIndex = 7
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(81, 61)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(179, 22)
        Me.dtpFecha.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "L."
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(17, 38)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(192, 42)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(17, 114)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(192, 42)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(17, 186)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(192, 42)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(17, 252)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(192, 42)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(934, 553)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CRUD"
        Me.Text = "CRUD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvRegistros As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents mtbPrecio As MaskedTextBox
    Friend WithEvents mtbCantidad As MaskedTextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConsultar As Button
End Class
