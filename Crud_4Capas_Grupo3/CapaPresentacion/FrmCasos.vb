Public Class FrmCasos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FrmCliente.Show()
        Timer1.Enabled = False
        Me.Hide()
    End Sub
End Class