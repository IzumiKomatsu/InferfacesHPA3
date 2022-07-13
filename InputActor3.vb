Public Class InputActor3

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        End
    End Sub

    'Botón Guardar
    Private Sub pnlGuardar_Click(sender As Object, e As EventArgs) Handles pnlGuardar.Click
        RegistroExitoso.Show()
    End Sub

    Private Sub lblGuardar_Click(sender As Object, e As EventArgs) Handles lblGuardar.Click
        RegistroExitoso.Show()
    End Sub

    'Botón Atrás
    Private Sub pnlAtras_Click(sender As Object, e As EventArgs) Handles pnlAtras.Click
        Me.Hide()
        InputActor2.Show()
    End Sub

    Private Sub lblAtras_Click(sender As Object, e As EventArgs) Handles lblAtras.Click
        Me.Hide()
        InputActor2.Show()
    End Sub

    Private Sub InputActor3_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        pnlAtras.BackColor = Color.Silver
        pnlGuardar.BackColor = Color.Silver

        pnlAtras.ForeColor = Color.White
        pnlGuardar.ForeColor = Color.White
    End Sub

    Private Sub txtMeses_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeses.KeyPress
        FuncionesComunes.BloquearChar(e)
    End Sub

    Private Sub txtAnios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnios.KeyPress
        FuncionesComunes.BloquearChar(e)
    End Sub
End Class