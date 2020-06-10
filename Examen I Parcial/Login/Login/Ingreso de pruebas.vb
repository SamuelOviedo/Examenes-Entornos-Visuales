Imports System.ComponentModel

Public Class Ingreso_de_pruebas

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim nombre, municipio, resultado, estado, departamento As String
        Dim edad, totalAct, totalRec, totalMuert, totalNega As Integer

        nombre = txtNombreUsuario.Text
        edad = txtEdad.Text
        municipio = txtMunicipio.Text

        resultado = cbbResultadoPrueba.SelectedItem

        If cbbResultadoPrueba.SelectedItem = "Positivo" And chkActivo.Checked = True Then
            estado = "Activo"
            totalAct += 1

        ElseIf cbbResultadoPrueba.SelectedItem = "Positivo" And chkMuerto.Checked = True Then
            estado = "Muerto"
            totalMuert += 1

        End If

        If cbbResultadoPrueba.SelectedItem = "Negativo" And chkRecuperado.Checked = True Then
            estado = "Recuperado"
            totalMuert += 1

        ElseIf cbbResultadoPrueba.SelectedItem = "Negativo" Then
            estado = "Ninguno"
            totalNega += 1

        End If

        departamento = cbbDepartamento.SelectedItem

        lbHistorial.Items.Add(resultado & "-" & estado & ", " & nombre & ", " & edad & ", " & municipio & ", " & departamento)


        txtActivos.Text = totalAct
        txtMuertos.Text = totalMuert
        txtNegativos.Text = totalNega
        txtRecuperados.Text = totalRec

        txtDescripcion.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtNombreUsuario.Clear()
        cbbResultadoPrueba.SelectedItem = -1
        cbbDepartamento.SelectedItem = -1

        chkActivo.Enabled = True
        chkMuerto.Enabled = True
        chkRecuperado.Enabled = True

        chkActivo.Checked = False
        chkMuerto.Checked = False
        chkRecuperado.Checked = False

    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged

    End Sub

    Private Sub txtNombreUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtNombreUsuario.MouseHover
        ToolTip.SetToolTip(txtNombreUsuario, "Ingrese el nombre del paciente")
        ToolTip.ToolTipTitle = "Información"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Esta seguro de salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End

        End If

    End Sub

    Private Sub txtNombreUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")

        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")

        End If

    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")

        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")

        End If

    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")

        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtNombreUsuario, "Ingrese la edad del paciente")
        ToolTip.ToolTipTitle = "Información"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtNombreUsuario, "Ingrese el municipio del paciente")
        ToolTip.ToolTipTitle = "Información"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub cbbResultadoPrueba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbResultadoPrueba.SelectedIndexChanged

        If cbbResultadoPrueba.SelectedItem = "Positivo" Then
            chkActivo.Enabled = True
            chkMuerto.Enabled = True
            chkRecuperado.Enabled = False

        ElseIf cbbResultadoPrueba.SelectedItem = "Negativo" Then
            chkRecuperado.Enabled = True
            chkActivo.Enabled = False
            chkMuerto.Enabled = False

        End If

    End Sub

    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        If chkActivo.Checked = True Then
            chkMuerto.Enabled = False

        End If

        If chkActivo.Checked = False Then
            chkMuerto.Enabled = True

        End If
    End Sub

    Private Sub chkMuerto_CheckedChanged(sender As Object, e As EventArgs) Handles chkMuerto.CheckedChanged
        If chkMuerto.Checked = True Then
            chkActivo.Enabled = False

        End If

        If chkMuerto.Checked = False Then
            chkMuerto.Enabled = True

        End If

    End Sub

    Private Sub cbbDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbDepart.SelectedIndexChanged

    End Sub

    Private Structure Datos
        Public resultado, estado, nombre, municipio, departamento As String
        Public edad As Integer

    End Structure

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click

    End Sub
End Class