
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

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) 
        Dim objetoConf As New ConfigurarXML
        If objetoConf.ActualizarSBDPXML() = True Then

        End If
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numeroCompilacion As Integer
        Dim objetoLectorXML As New ManejoXML
        numeroCompilacion = Convert.ToInt32(objetoLectorXML.ObtenerValorXML("Compilaciones", "SBDP.xml"))
        If numeroCompilacion >= 480 Or numeroCompilacion = 0 Then
            MessageBox.Show("Error en el modulo .NET 4.5")
            End
        End If
    End Sub
End Class