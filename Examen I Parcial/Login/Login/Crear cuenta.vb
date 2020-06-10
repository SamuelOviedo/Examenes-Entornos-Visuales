Public Class Crear_cuenta
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnCrearNueva.Click

        Dim nuevoUsuario, nuevaContra As String

        nuevoUsuario = txtUsuario.Text
        nuevaContra = txtContrasenia.Text

        ModuloVariables.usuarioEstable = nuevoUsuario
        ModuloVariables.contraEstable = nuevaContra

        MsgBox("Cuenta creada exitosamente", vbInformation, "Información")

        System.Threading.Thread.Sleep(2000)

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Crear_cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrasenia.Clear()
        txtUsuario.Clear()


    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged

    End Sub

    Private Sub txtContrasenia_MouseEnter(sender As Object, e As EventArgs) Handles txtContrasenia.MouseEnter

    End Sub
End Class