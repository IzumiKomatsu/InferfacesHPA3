Public Class RegistroExitoso
    Private Sub RegistroExitoso_Load(sender As Object, e As EventArgs) Handles Me.Load
        InputActor3.Enabled = False
        InputProductor2.Enabled = False
    End Sub

    Private Sub pnlInicio_Click(sender As Object, e As EventArgs) Handles pnlInicio.Click
        InputActor3.Enabled = True
        InputProductor2.Enabled = True
        Me.Close()
        InputActor3.Close()
        InputProductor2.Close()
        PantallaInicio.Show()
    End Sub

    Private Sub lblInicio_Click(sender As Object, e As EventArgs) Handles lblInicio.Click
        InputActor3.Enabled = True
        InputProductor2.Enabled = True
        Me.Close()
        InputActor3.Close()
        InputProductor2.Close()
        PantallaInicio.Show()
    End Sub
End Class