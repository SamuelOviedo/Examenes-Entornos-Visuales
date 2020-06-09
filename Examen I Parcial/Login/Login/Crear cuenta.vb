Public Class Crear_cuenta
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnCrearNueva.Click
        txtContrasenia.Text = contrasenia
        txtUsuario.Text = usuario
        MsgBox("Cuenta creada exitosamente", vbInformation, "Información")
        Login.Show()
        Me.Hide()

    End Sub
End Class