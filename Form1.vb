Class Form1
    'Private Sub btnEntrar_MouseHover(sender As Object, e As EventArgs) Handles btnEntrar.MouseHover
    '    btnEntrar.BackColor = Color.Silver
    'End Sub

    'Private Sub btnEntrar_MouseLeave(sender As Object, e As EventArgs) Handles btnEntrar.MouseLeave
    '    btnEntrar.BackColor = Color.Black
    'End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        TipoRegistro.Show()
    End Sub

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub pnlEntrar_Click(sender As Object, e As EventArgs) Handles pnlEntrar.Click
        Me.Hide()
        PantallaInicio.Show()
    End Sub

    Private Sub lblEntrar_Click(sender As Object, e As EventArgs) Handles lblEntrar.Click
        Me.Hide()
        PantallaInicio.Show()
    End Sub

    Private Sub linklblCreaCuenta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblCreaCuenta.LinkClicked
        Me.Hide()
        TipoRegistro.Show()
    End Sub
End Class
