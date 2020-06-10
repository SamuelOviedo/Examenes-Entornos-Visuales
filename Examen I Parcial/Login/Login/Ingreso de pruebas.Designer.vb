<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_de_pruebas
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.cbbDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMuerto = New System.Windows.Forms.CheckBox()
        Me.chkRecuperado = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbbResultadoPrueba = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbDepart = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNegativos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMuertos = New System.Windows.Forms.TextBox()
        Me.txtRecuperados = New System.Windows.Forms.TextBox()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbHistorial = New System.Windows.Forms.ListBox()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.cbbDepartamento)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información personal"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.Color.BurlyWood
        Me.txtMunicipio.Location = New System.Drawing.Point(55, 318)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(236, 32)
        Me.txtMunicipio.TabIndex = 7
        '
        'cbbDepartamento
        '
        Me.cbbDepartamento.BackColor = System.Drawing.Color.BurlyWood
        Me.cbbDepartamento.FormattingEnabled = True
        Me.cbbDepartamento.Items.AddRange(New Object() {"Atlántida", "Colón", "Comayagua", "Copán", "Cortés", "Choluteca", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cbbDepartamento.Location = New System.Drawing.Point(55, 241)
        Me.cbbDepartamento.Name = "cbbDepartamento"
        Me.cbbDepartamento.Size = New System.Drawing.Size(237, 33)
        Me.cbbDepartamento.TabIndex = 6
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.BurlyWood
        Me.txtEdad.Location = New System.Drawing.Point(55, 163)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(67, 32)
        Me.txtEdad.TabIndex = 5
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.BurlyWood
        Me.txtNombreUsuario.Location = New System.Drawing.Point(55, 87)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(238, 32)
        Me.txtNombreUsuario.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Municipio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Edad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.chkMuerto)
        Me.GroupBox2.Controls.Add(Me.chkRecuperado)
        Me.GroupBox2.Controls.Add(Me.chkActivo)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.cbbResultadoPrueba)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(314, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 392)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'chkMuerto
        '
        Me.chkMuerto.AutoSize = True
        Me.chkMuerto.BackColor = System.Drawing.Color.BurlyWood
        Me.chkMuerto.Location = New System.Drawing.Point(256, 189)
        Me.chkMuerto.Name = "chkMuerto"
        Me.chkMuerto.Size = New System.Drawing.Size(108, 29)
        Me.chkMuerto.TabIndex = 6
        Me.chkMuerto.Text = "Muerto"
        Me.chkMuerto.UseVisualStyleBackColor = False
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.BackColor = System.Drawing.Color.BurlyWood
        Me.chkRecuperado.Location = New System.Drawing.Point(117, 154)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(155, 29)
        Me.chkRecuperado.TabIndex = 5
        Me.chkRecuperado.Text = "Recuperado"
        Me.chkRecuperado.UseVisualStyleBackColor = False
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.BackColor = System.Drawing.Color.BurlyWood
        Me.chkActivo.Location = New System.Drawing.Point(12, 124)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(99, 29)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.BurlyWood
        Me.txtDescripcion.Location = New System.Drawing.Point(35, 258)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(321, 99)
        Me.txtDescripcion.TabIndex = 3
        '
        'cbbResultadoPrueba
        '
        Me.cbbResultadoPrueba.BackColor = System.Drawing.Color.BurlyWood
        Me.cbbResultadoPrueba.FormattingEnabled = True
        Me.cbbResultadoPrueba.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.cbbResultadoPrueba.Location = New System.Drawing.Point(88, 67)
        Me.cbbResultadoPrueba.Name = "cbbResultadoPrueba"
        Me.cbbResultadoPrueba.Size = New System.Drawing.Size(215, 33)
        Me.cbbResultadoPrueba.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Resultado prueba:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(56, 375)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(236, 46)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(511, 604)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(168, 44)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Controls.Add(Me.btnVisualizar)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cbbDepart)
        Me.GroupBox3.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(443, 452)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 146)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione un"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "departamento:"
        '
        'cbbDepart
        '
        Me.cbbDepart.BackColor = System.Drawing.Color.LightCoral
        Me.cbbDepart.FormattingEnabled = True
        Me.cbbDepart.Items.AddRange(New Object() {"Atlántida", "Colón", "Comayagua", "Copán", "Cortés", "Choluteca", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cbbDepart.Location = New System.Drawing.Point(21, 58)
        Me.cbbDepart.Name = "cbbDepart"
        Me.cbbDepart.Size = New System.Drawing.Size(258, 33)
        Me.cbbDepart.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox4.Controls.Add(Me.txtNegativos)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtMuertos)
        Me.GroupBox4.Controls.Add(Me.txtRecuperados)
        Me.GroupBox4.Controls.Add(Me.txtActivos)
        Me.GroupBox4.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 452)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(430, 172)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'txtNegativos
        '
        Me.txtNegativos.BackColor = System.Drawing.Color.Silver
        Me.txtNegativos.Location = New System.Drawing.Point(275, 58)
        Me.txtNegativos.Name = "txtNegativos"
        Me.txtNegativos.Size = New System.Drawing.Size(122, 29)
        Me.txtNegativos.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Negativos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Muertos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 23)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Recuperados:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Activos:"
        '
        'txtMuertos
        '
        Me.txtMuertos.BackColor = System.Drawing.Color.Silver
        Me.txtMuertos.Location = New System.Drawing.Point(264, 123)
        Me.txtMuertos.Name = "txtMuertos"
        Me.txtMuertos.Size = New System.Drawing.Size(122, 29)
        Me.txtMuertos.TabIndex = 3
        '
        'txtRecuperados
        '
        Me.txtRecuperados.BackColor = System.Drawing.Color.Silver
        Me.txtRecuperados.Location = New System.Drawing.Point(79, 123)
        Me.txtRecuperados.Name = "txtRecuperados"
        Me.txtRecuperados.Size = New System.Drawing.Size(122, 29)
        Me.txtRecuperados.TabIndex = 2
        '
        'txtActivos
        '
        Me.txtActivos.BackColor = System.Drawing.Color.Silver
        Me.txtActivos.Location = New System.Drawing.Point(83, 58)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.Size = New System.Drawing.Size(122, 29)
        Me.txtActivos.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox5.Controls.Add(Me.lbHistorial)
        Me.GroupBox5.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(740, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(580, 611)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Historial"
        '
        'lbHistorial
        '
        Me.lbHistorial.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbHistorial.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHistorial.FormattingEnabled = True
        Me.lbHistorial.ItemHeight = 17
        Me.lbHistorial.Location = New System.Drawing.Point(18, 29)
        Me.lbHistorial.Name = "lbHistorial"
        Me.lbHistorial.Size = New System.Drawing.Size(547, 565)
        Me.lbHistorial.TabIndex = 0
        '
        'btnVisualizar
        '
        Me.btnVisualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVisualizar.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.Location = New System.Drawing.Point(63, 97)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(173, 32)
        Me.btnVisualizar.TabIndex = 7
        Me.btnVisualizar.Text = "visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'Ingreso_de_pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1323, 648)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ingreso_de_pruebas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de pruebas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents cbbDepartamento As ComboBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cbbResultadoPrueba As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents chkMuerto As CheckBox
    Friend WithEvents chkRecuperado As CheckBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbbDepart As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNegativos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMuertos As TextBox
    Friend WithEvents txtRecuperados As TextBox
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbHistorial As ListBox
    Friend WithEvents btnVisualizar As Button
End Class
