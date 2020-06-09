Imports System.ComponentModel

Public Class Login
    Dim usuario, contrasenia As String

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        txtUsuario.Clear()
        txtContrasenia.Clear()
        Crear_cuenta.Show()
        Me.Hide()

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim nombre, contra As String

        txtUsuario.Text = usuario
        txtContrasenia.Text = contrasenia

        nombre = "Administrador"
        contra = "SinHacer2020"

        If usuario = nombre And contrasenia = contra Then
            Ingreso_de_pruebas.Show()
            Me.Hide()

        Else

            MsgBox("Este usuario no existe, por favor cree una cuenta", vbExclamation, "Advertencia")
        End If

    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContrasenia_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasenia.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class
