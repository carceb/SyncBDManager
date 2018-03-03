
Imports System.ServiceProcess
Public Class InformacionServicio
    Private Sub InformacionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLog()
        EstadoServicio()
    End Sub
    Private Sub CargarLog()
        Dim objetoLogLector As New LogLector
        objetoLogLector.CargarArchivoLog(Application.StartupPath & "\ServicioSincronizacion.txt", lvLog)
    End Sub
    Private Sub EstadoServicio()
        Dim sc As New ServiceController("SyncBD")
        If sc.Status.Equals(ServiceControllerStatus.Stopped) Or sc.Status.Equals(ServiceControllerStatus.StopPending) Then
            mlblEstatus.Text = "El servicio de sincronización esta actualmente detenido"
            mlblEstatus.ForeColor = Color.Red
        Else
            mlblEstatus.Text = "El servicio de sincronización esta actualmente en funcionamiento"
            mlblEstatus.ForeColor = Color.Green
        End If
        sc.Refresh()
    End Sub
End Class