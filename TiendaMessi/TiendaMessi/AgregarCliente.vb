Imports System.ComponentModel

Public Class AgregarCliente
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultarClientes()
            If tabla.Rows.Count <> 0 Then
                dgvClientes.DataSource = tabla

            Else
                dgvClientes.DataSource = Nothing

            End If
            Limpiar()

        Catch ex As Exception
            MsgBox("Algo salió mal", "Error", MessageBoxIcon.Warning)
            Limpiar()
        End Try
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        txtIdCliente.Text = dgvClientes.CurrentRow.Cells(0).Value.ToString
        txtNombre.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
        txtApellido.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString
        txtDireccion.Text = dgvClientes.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idCliente As Integer
        Dim nombre, apellido, direccion As String
        idCliente = txtIdCliente.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        direccion = txtDireccion.Text
        If txtNombre.Text <> "" Or txtIdCliente.Text <> "" Or txtApellido.Text <> "" Or txtDireccion.Text <> "" Then

            Try
                If conexion.AgregarClientes(idCliente, nombre, apellido, direccion) Then
                    MsgBox("Ingresado correctamente")
                Else
                    MsgBox("Algo salió mal", "Error", MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MsgBox("Algo salió mal", "Error", MessageBoxIcon.Warning)
            End Try
            Limpiar()

        Else
            MessageBox.Show("Ingrese todos los datos, por favor", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Limpiar()

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim idCliente As Integer
        Dim nombre, apellido, direccion As String
        idCliente = txtIdCliente.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        direccion = txtDireccion.Text
        If txtNombre.Text <> "" Or txtIdCliente.Text <> "" Or txtApellido.Text <> "" Or txtDireccion.Text <> "" Then

            Try
                If conexion.ActualizarCliente(idCliente, nombre, apellido, direccion) Then
                    MessageBox.Show("Actualizado correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                Else
                    MsgBox("Algo salió mal", "Error", MessageBoxIcon.Warning)
                    Limpiar()
                End If
            Catch ex As Exception
                MsgBox("Algo salió mal", "Error", MessageBoxIcon.Warning)
                Limpiar()
            End Try
        Else
            MessageBox.Show("Ingrese todos los datos, por favor", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Limpiar()

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idCliente As String
        idCliente = txtIdCliente.Text

        Try
            If conexion.EliminarCliente(idCliente) Then
                MsgBox("Eliminado correctamente")
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox("Algo salió mal", "Error", MessageBoxIcon.Warning)
            Limpiar()
        End Try
    End Sub

    Private Sub Limpiar()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtIdCliente.Clear()
        txtNombre.Clear()


    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub txtIdCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIdCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class