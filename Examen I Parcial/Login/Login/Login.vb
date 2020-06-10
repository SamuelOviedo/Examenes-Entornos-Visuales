Imports System.ComponentModel

Public Class Login

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        txtUsuario.Clear()
        txtContrasenia.Clear()

        Crear_cuenta.Show()
        Me.Hide()

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario, contra, name, password As String

        usuario = txtUsuario.Text
        contra = txtContrasenia.Text

        usuario = usuario.ToLower

        name = ModuloVariables.usuarioEstable

        If name = "" Then
            name = " "
        Else
            name = name.ToLower
        End If

        password = ModuloVariables.contraEstable

        If usuario = name And contra = password Then

        ElseIf usuario = "administrador" And contra = "SinHacer2020" Then
            Ingreso_de_pruebas.Show()
            Me.Hide()

        ElseIf usuario = "" Or contra = "" Then
            MsgBox("Por favor ingrese todos los datos solicitados", vbExclamation, "Advertencia")
            txtUsuario.Clear()
            txtContrasenia.Clear()

        Else
            MsgBox("El usuario ingresado no existe, por favor cree uno", vbExclamation, "Advertencia")

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
