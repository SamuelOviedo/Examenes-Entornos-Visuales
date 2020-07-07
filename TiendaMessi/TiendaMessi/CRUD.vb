Public Class CRUD
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable
    Private Sub dgvRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistros.CellContentClick

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
            MsgBox("SeArruinó")
        End Try
    End Sub
End Class