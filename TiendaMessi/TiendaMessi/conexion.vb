Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-O55QRS2\MSSQLSERVERSAM;Initial Catalog=TiendaMessi;Integrated Security=True")
    Public Sub abrirConexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("No se pudo Conectar: " + ex.ToString)
            End
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consultarClientes()

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function

    Public Function consultarVentas()

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarVentas", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function
End Class
