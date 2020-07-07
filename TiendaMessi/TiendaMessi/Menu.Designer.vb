<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.panelOpciones = New System.Windows.Forms.Panel()
        Me.btnIngresarCliente = New System.Windows.Forms.Button()
        Me.btnCRUD = New System.Windows.Forms.Button()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.panelSuperior.SuspendLayout()
        Me.panelOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panelSuperior.Controls.Add(Me.btnRest)
        Me.panelSuperior.Controls.Add(Me.btnMin)
        Me.panelSuperior.Controls.Add(Me.btnMax)
        Me.panelSuperior.Controls.Add(Me.btnCerrar)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1166, 52)
        Me.panelSuperior.TabIndex = 0
        '
        'panelOpciones
        '
        Me.panelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelOpciones.Controls.Add(Me.btnIngresarCliente)
        Me.panelOpciones.Controls.Add(Me.btnCRUD)
        Me.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelOpciones.Location = New System.Drawing.Point(0, 52)
        Me.panelOpciones.Name = "panelOpciones"
        Me.panelOpciones.Size = New System.Drawing.Size(237, 620)
        Me.panelOpciones.TabIndex = 1
        '
        'btnIngresarCliente
        '
        Me.btnIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarCliente.ForeColor = System.Drawing.Color.White
        Me.btnIngresarCliente.Location = New System.Drawing.Point(2, 131)
        Me.btnIngresarCliente.Name = "btnIngresarCliente"
        Me.btnIngresarCliente.Size = New System.Drawing.Size(235, 52)
        Me.btnIngresarCliente.TabIndex = 1
        Me.btnIngresarCliente.Text = "Ingresar Cliente"
        Me.btnIngresarCliente.UseVisualStyleBackColor = True
        '
        'btnCRUD
        '
        Me.btnCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCRUD.ForeColor = System.Drawing.Color.White
        Me.btnCRUD.Location = New System.Drawing.Point(2, 62)
        Me.btnCRUD.Name = "btnCRUD"
        Me.btnCRUD.Size = New System.Drawing.Size(235, 52)
        Me.btnCRUD.TabIndex = 0
        Me.btnCRUD.Text = "CRUD"
        Me.btnCRUD.UseVisualStyleBackColor = True
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.Silver
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(237, 52)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(929, 620)
        Me.panelContenido.TabIndex = 2
        '
        'btnRest
        '
        Me.btnRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRest.BackgroundImage = CType(resources.GetObject("btnRest.BackgroundImage"), System.Drawing.Image)
        Me.btnRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRest.FlatAppearance.BorderSize = 0
        Me.btnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRest.Location = New System.Drawing.Point(1067, 6)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(40, 40)
        Me.btnRest.TabIndex = 5
        Me.btnRest.UseVisualStyleBackColor = True
        Me.btnRest.Visible = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(1021, 6)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(40, 40)
        Me.btnMin.TabIndex = 4
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1113, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackgroundImage = CType(resources.GetObject("btnMax.BackgroundImage"), System.Drawing.Image)
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(1067, 6)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(40, 40)
        Me.btnMax.TabIndex = 2
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 672)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelOpciones)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.panelSuperior.ResumeLayout(False)
        Me.panelOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSuperior As Panel
    Friend WithEvents panelOpciones As Panel
    Friend WithEvents btnIngresarCliente As Button
    Friend WithEvents btnCRUD As Button
    Friend WithEvents panelContenido As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnRest As Button
End Class
