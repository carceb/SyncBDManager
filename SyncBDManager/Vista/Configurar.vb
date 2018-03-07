Imports System
Imports System.Xml
Public Class Configurar
    Private Sub Configurar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbdConfiguraciones.SelectedIndex = 0
        LeerXML()
    End Sub
    Private Sub ConfigurarXML()
        Dim objetoConfigurarXML As New ConfigurarXML
        If objetoConfigurarXML.ActualizarConfiguraciones(Me) Then
            MessageBox.Show("Configuración actualizada.", "Correcto")
        End If
    End Sub
    Private Sub LeerXML()
        Dim objetoManejoXML As New ManejoXML
        Dim filtroDiaActual As String

        If objetoManejoXML.ObtenerValorXML("FiltraSiempreDiaActual", "Configuracion.xml") <> "Error" Then
            filtroDiaActual = objetoManejoXML.ObtenerValorXML("FiltraSiempreDiaActual", "Configuracion.xml")
            If filtroDiaActual = "Si" Then
                mtgHoy.Checked = True
            Else
                mtgHoy.Checked = False
            End If

            If mtgHoy.Checked = True Then
                mcboDias.Text = "0"
            Else
                mcboDias.Text = objetoManejoXML.ObtenerValorXML("CantidadDiasRestaDiaActual", "Configuracion.xml")
            End If

            mtxtAccess.Text = objetoManejoXML.ObtenerValorXML("RutaBDAccess2003", "Configuracion.xml")
            mtxtMySQL.Text = objetoManejoXML.ObtenerValorXML("CadenaConexionMySQL", "Configuracion.xml")
            mcboTiempoSincronizacion.Text = objetoManejoXML.ObtenerValorXML("TiempoEjecucionServicioSincronizacion", "Configuracion.xml")

            'Se comentó debido a que los archivos logs se borran en tiempo real
            'borrarLogs = objetoManejoXML.ObtenerValorXML("BorrarLogs")
            'If borrarLogs = "Si" Then
            '    mtgBorrarLogs.Checked = True
            'Else
            '    mtgBorrarLogs.Checked = False
            'End If
        End If
    End Sub
    Private Function ErrorAlActualizar() As Boolean
        Dim resultado As Boolean
        If mtxtAccess.Text = "" Then
            resultado = True
            MessageBox.Show("Debe colocar la ruta de acceso a la base de datos de Access 2003")
        End If
        If mtxtMySQL.Text = "" Then
            resultado = True
            MessageBox.Show("Debe colocar la cadena de conexión de MySQL")
        End If
        If mcboTiempoSincronizacion.Text = "" Then
            resultado = True
            MessageBox.Show("Debe indicar el tiempo del servicio de sincronización")
        End If

        ErrorAlActualizar = resultado
    End Function
    Private Sub mlnkFiltros_Click(sender As Object, e As EventArgs) Handles mlnkFiltros.Click
        mtbdConfiguraciones.SelectedIndex = 0
    End Sub

    Private Sub mlnkUbicaciones_Click(sender As Object, e As EventArgs) Handles mlnkUbicaciones.Click
        mtbdConfiguraciones.SelectedIndex = 1
    End Sub

    Private Sub mlnkSincronizador_Click(sender As Object, e As EventArgs) Handles mlnkSincronizador.Click
        mtbdConfiguraciones.SelectedIndex = 2
    End Sub

    Private Sub mbtnAplicar_Click(sender As Object, e As EventArgs) Handles mbtnAplicar.Click
        Dim result As Integer
        If Not ErrorAlActualizar() Then
            If mtgBorrarLogs.Checked = True Then
                Try
                    result = MessageBox.Show("¿Desea eliminar los archivos log del sincronizador?, esta acción no podrá deshacerse", "Atención", MessageBoxButtons.YesNo)
                    If result = 6 Then
                        BorrarLogs()
                    Else
                        MessageBox.Show("No se eliminaron los archivos log", "Cancelado")
                    End If
                Catch ex As Exception

                End Try
            End If
            ConfigurarXML()
        End If
    End Sub

    Private Sub mtgHoy_CheckedChanged(sender As Object, e As EventArgs) Handles mtgHoy.CheckedChanged
        If Me.mtgHoy.Checked = False Then
            mcboDias.Enabled = True
        Else
            mcboDias.Enabled = False
        End If
    End Sub
    Private Sub BorrarLogs()
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ServicioSincronizacion.txt")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Logs\Inventory.txt")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Logs\InventoryPricing.txt")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Logs\InventoryItemsXRef.txt")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Logs\Orders.txt")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Logs\OrdersDetail.txt")
    End Sub
End Class