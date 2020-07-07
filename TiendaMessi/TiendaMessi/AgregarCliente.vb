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
        Catch ex As Exception
            MsgBox("SeArrruinó")
        End Try
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        txtNombre.Text = dgvClientes.CurrentRow.Cells(0).Value.ToString
        txtApellido.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
        txtDireccion.Text = dgvClientes.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub
End Class