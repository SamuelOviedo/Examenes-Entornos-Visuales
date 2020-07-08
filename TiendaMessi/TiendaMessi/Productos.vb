Imports System.ComponentModel

Public Class Productos
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultarProductos()
            If tabla.Rows.Count <> 0 Then
                dgvProductos.DataSource = tabla
                Limpiar()
            Else
                dgvProductos.DataSource = Nothing
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Limpiar()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idProducto As Integer
        Dim nombreProducto, descripcion As String
        idProducto = txtIdProducto.Text
        nombreProducto = txtNombreProducto.Text
        descripcion = txtDescripcion.Text

        If txtNombreProducto.Text <> "" Or txtDescripcion.Text <> "" Or txtIdProducto.Text <> "" Then

            Try
                If conexion.AgregarProducto(idProducto, nombreProducto, descripcion) Then
                    MsgBox("Ingresado correctamente")
                    Limpiar()
                Else
                    MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Limpiar()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Limpiar()
            End Try

        Else
            MessageBox.Show("Ingrese todos los datos, por favor", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Limpiar()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim idProducto As Integer
        Dim nombreProducto, descripcion As String
        idProducto = txtIdProducto.Text
        nombreProducto = txtNombreProducto.Text
        descripcion = txtDescripcion.Text

        If txtNombreProducto.Text <> "" Or txtDescripcion.Text <> "" Or txtIdProducto.Text <> "" Then

            Try
                If conexion.ActualizarProducto(idProducto, nombreProducto, descripcion) Then
                    MessageBox.Show("Actualizado correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                Else
                    MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Limpiar()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Limpiar()
            End Try
        Else
            MessageBox.Show("Ingrese todos los datos, por favor", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idProducto As String
        idProducto = txtIdProducto.Text

        Try
            If conexion.EliminarProducto(idProducto) Then
                MsgBox("Eliminado correctamente")
                Limpiar()

            End If
        Catch ex As Exception
            MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Limpiar()
        End Try
    End Sub

    Private Sub Limpiar()
        txtDescripcion.Clear()
        txtIdProducto.Clear()
        txtNombreProducto.Clear()
    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged

    End Sub

    Private Sub txtIdProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtIdProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProducto.TextChanged

    End Sub

    Private Sub txtNombreProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class