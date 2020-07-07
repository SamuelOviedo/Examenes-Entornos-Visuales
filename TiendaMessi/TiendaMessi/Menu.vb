Public Class Menu
    Private Sub abrirFormulario(ByVal formHijo As Object)

        If panelContenido.Controls.Count > 0 Then

            Me.panelContenido.Controls.RemoveAt(0)
        End If

        Dim frm As Form = TryCast(formHijo, Form)

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        Me.panelContenido.Controls.Add(frm)
        Me.panelContenido.Tag = frm

        frm.Show()
    End Sub

    Private Sub btnCRUD_Click(sender As Object, e As EventArgs) Handles btnCRUD.Click
        abrirFormulario(CRUD)


    End Sub

    Private Sub btnIngresarCliente_Click(sender As Object, e As EventArgs) Handles btnIngresarCliente.Click
        abrirFormulario(AgregarCliente)

    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        btnRest.Visible = False
        btnMax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnRest.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            End

        Else

        End If
    End Sub
End Class
