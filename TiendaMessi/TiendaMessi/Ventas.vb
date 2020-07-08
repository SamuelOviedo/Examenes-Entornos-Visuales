Imports System.ComponentModel

Public Class Ventas
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable
    Private Sub dgvRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistros.CellContentClick
        mtbFecha.Text = dgvRegistros.CurrentRow.Cells(0).Value.ToString
        txtPrecio.Text = dgvRegistros.CurrentRow.Cells(3).Value.ToString
        txtCantidad.Text = dgvRegistros.CurrentRow.Cells(4).Value.ToString

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultarVentas()
            If tabla.Rows.Count <> 0 Then
                dgvRegistros.DataSource = tabla
            Else
                dgvRegistros.DataSource = Nothing

            End If
        Catch ex As Exception
            MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Limpiar()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idCliente As String
        idCliente = txtIdCliente.Text

        Try
            If conexion.EliminarVenta(idCliente) Then
                MsgBox("Eliminado correctamente")
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Limpiar()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idCliente As Integer
        idCliente = txtIdCliente.Text

        Try
            tabla = conexion.consultarVentaCompleta(idCliente)
            If tabla.Rows.Count <> 0 Then
                dgvRegistros.DataSource = tabla
            Else
                dgvRegistros.DataSource = Nothing

            End If
        Catch ex As Exception
            MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idVenta, idCliente, idProducto, precio, cantidad As Integer
        Dim fechaVenta As Date


        If txtIdCliente.Text <> "" And txtIdVenta.Text <> "" And txtPrecio.Text <> "" And txtCantidad.Text <> "" And txtIdProducto.Text <> "" And mtbFecha.Text <> "" Then

            idVenta = txtIdVenta.Text
            idCliente = txtIdCliente.Text
            idProducto = txtIdProducto.Text
            precio = txtPrecio.Text
            cantidad = txtCantidad.Text
            fechaVenta = mtbFecha.Text

            Try
                If conexion.AgregarVenta(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) Then
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
        Dim idVenta, idCliente, idProducto, precio, cantidad As Integer
        Dim fechaVenta As Date
        idVenta = txtIdVenta.Text
        idCliente = txtIdCliente.Text
        idProducto = txtIdProducto.Text
        precio = txtPrecio.Text
        cantidad = txtCantidad.Text
        fechaVenta = mtbFecha.Text

        Try
            If conexion.ActualizarVenta(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) Then
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

    Private Sub txtIdVenta_TextChanged(sender As Object, e As EventArgs) Handles txtIdVenta.TextChanged

    End Sub

    Private Sub txtIdVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtIdVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIngreso.SetError(sender, "")
        Else
            Me.ErrorIngreso.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Limpiar()
        txtCantidad.Clear()
        txtIdCliente.Clear()
        txtIdProducto.Clear()
        txtIdVenta.Clear()
        txtPrecio.Clear()
        mtbFecha.Clear()
    End Sub
End Class