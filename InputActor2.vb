Public Class InputActor2
    Private Sub InputActor2_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub txtAltura_TextChanged(sender As Object, e As EventArgs) Handles txtAltura.TextChanged
        txtAltura.ForeColor = Color.Black
        txtAltura.Font = New Font("Segoe UI Semilight", 12)
    End Sub

    Private Sub txtAltura_Click(sender As Object, e As EventArgs) Handles txtAltura.Click
        If txtAltura.Text = "Ej. 1.70" Then
            txtAltura.Clear()
        End If
    End Sub

    Private Sub txtPeso_TextChanged(sender As Object, e As EventArgs) Handles txtPeso.TextChanged
        txtPeso.ForeColor = Color.Black
        txtPeso.Font = New Font("Segoe UI Semilight", 12)
    End Sub

    Private Sub txtPeso_Click(sender As Object, e As EventArgs) Handles txtPeso.Click
        If txtPeso.Text = "Ej. 20.55" Then
            txtPeso.Clear()
        End If
    End Sub

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        End
    End Sub

    'Botón Atrás
    Private Sub pnlAtras_Click(sender As Object, e As EventArgs) Handles pnlAtras.Click
        Me.Close()
        InputActor1.Show()
    End Sub

    Private Sub lblAtras_Click(sender As Object, e As EventArgs) Handles lblAtras.Click
        Me.Close()
        InputActor1.Show()
    End Sub

    'Botón Siguiente
    Private Sub pnlSiguiente_Click(sender As Object, e As EventArgs) Handles pnlSiguiente.Click
        Me.Close()
        InputActor3.Show()
    End Sub

    Private Sub lblSiguiente_Click(sender As Object, e As EventArgs) Handles lblSiguiente.Click
        Me.Close()
        InputActor3.Show()
    End Sub
End Class