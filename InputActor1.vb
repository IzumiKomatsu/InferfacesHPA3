Public Class InputActor1

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        End
    End Sub

    'Botón Siguiente
    Private Sub pnlSiguiente_Click(sender As Object, e As EventArgs) Handles pnlSiguiente.Click
        Me.Hide()
        InputActor2.Show()
    End Sub

    Private Sub lblSiguiente_Click(sender As Object, e As EventArgs) Handles lblSiguiente.Click
        Me.Hide()
        InputActor2.Show()
    End Sub

    'Botón Atrás
    Private Sub pnlAtras_Click(sender As Object, e As EventArgs) Handles pnlAtras.Click
        Me.Close()
        TipoRegistro.Show()
    End Sub

    Private Sub lblAtras_Click(sender As Object, e As EventArgs) Handles lblAtras.Click
        Me.Close()
        TipoRegistro.Show()
    End Sub
End Class