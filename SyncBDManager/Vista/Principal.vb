Public Class Principal
    Private Sub mtConfiguracion_Click(sender As Object, e As EventArgs) Handles mtConfiguracion.Click
        Dim frmConfigurar As New Configurar
        frmConfigurar.Show()
    End Sub

    Private Sub mtLogs_Click(sender As Object, e As EventArgs) Handles mtLogs.Click
        Dim frmLogs As New LogsSincronizacion
        frmLogs.Show()
    End Sub

    Private Sub mtLogServicio_Click(sender As Object, e As EventArgs) Handles mtLogServicio.Click
        Dim frmInfServicio As New InformacionServicio
        frmInfServicio.Show()
    End Sub
End Class