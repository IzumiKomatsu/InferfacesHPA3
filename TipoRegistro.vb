Class TipoRegistro
    'Botón Siguiente
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs)
        Me.Close()
        InputActor1.Show()
    End Sub

    Private Sub lblSiguiente_Click(sender As Object, e As EventArgs) Handles lblSiguiente.Click
        If rboActor.Checked = True Then
            Me.Close()
            InputActor1.Show()
        ElseIf rboDirector.Checked = True Then
            Me.Close()
            InputProductor1.Show()
        End If
    End Sub

    Private Sub pnlSiguiente_Click(sender As Object, e As EventArgs) Handles pnlSiguiente.Click
        If rboActor.Checked = True Then
            Me.Close()
            InputActor1.Show()
        ElseIf rboDirector.Checked = True Then
            Me.Close()
            InputProductor1.Show()
        End If
    End Sub

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        End
    End Sub

    Private Sub pnlAtras_Click(sender As Object, e As EventArgs) Handles pnlAtras.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub lblAtras_Click(sender As Object, e As EventArgs) Handles lblAtras.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class