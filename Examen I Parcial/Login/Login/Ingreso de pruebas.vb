Public Class Ingreso_de_pruebas
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim totalAct, totalRec, totalMuer, totalActCom, totalRecCom, totalMuerCom As Integer

        If cbbDepartamento.SelectedItem = "Comayagua" And cbbResultadoPrueba.SelectedItem = "Positivo" And chkActivo.Checked = True Then
            estado = "Comayagua activo"
            totalActCom += 1
            totalAct += 1

        ElseIf cbbDepartamento.SelectedItem = "Comayagua" And cbbResultadoPrueba.SelectedItem = "Positivo" And chkMuerto.Checked = True Then
            estado = "Comayagua muerto"
            totalMuerCom += 1
            totalMuer += 1

        ElseIf cbbDepartamento.SelectedItem = "Comayagua" And cbbResultadoPrueba.SelectedItem = "Positivo" And chkRecuperado.Checked = True Then
            estado = "Comayagua recuperado"
            totalRecCom += 1
            totalRec += 1

        End If

        If cbbDepartamento.SelectedItem = "Francisco Morazan" And cbbResultadoPrueba.SelectedItem = "Positivo" And chkActivo.Checked = True Then
            estado = "Comayagua activo"
            totalActCom += 1
            totalAct += 1

        ElseIf cbbDepartamento.SelectedItem = "Francisco Morazan" And cbbResultadoPrueba.SelectedItem = "Positivo" And chkMuerto.Checked = True Then
            estado = "Comayagua muerto"
            totalMuerCom += 1
            totalMuer += 1

        ElseIf cbbDepartamento.SelectedItem = "Francisco Morazan" And cbbResultadoPrueba.SelectedItem = "Positivo" And chkRecuperado.Checked = True Then
            estado = "Comayagua recuperado"
            totalRecCom += 1
            totalRec += 1

        End If

        ModuleUsuario.estado = estado
        ModuleUsuario.cantidadAct = cantidadAct

        txtDescripcion.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtNombreUsuario.Clear()

    End Sub

    Private Sub ReportePDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePDepartamentoToolStripMenuItem.Click
        Resultados_por_departamento.Show()
        Me.Show()

    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged

    End Sub

    Private Sub txtNombreUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtNombreUsuario.MouseHover

    End Sub
End Class