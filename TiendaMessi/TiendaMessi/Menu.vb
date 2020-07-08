Imports System.Runtime.InteropServices
Public Class Menu

#Region "Move form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMs As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub panelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles panelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub panelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles panelSuperior.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region
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

    Private Sub btnCRUD_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        abrirFormulario(Ventas)

    End Sub

    Private Sub btnIngresarCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
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

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        abrirFormulario(Productos)
    End Sub
End Class
