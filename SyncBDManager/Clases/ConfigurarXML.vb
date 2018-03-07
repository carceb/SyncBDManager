Imports System.Xml
Public Class ConfigurarXML
    Public Sub New()

    End Sub
    Public Function ActualizarConfiguraciones(ByRef frmConfigurar As Configurar) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            Dim XmlWrt As XmlWriter = XmlWriter.Create("Configuracion.xml", settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteComment("XML Database.")
                .WriteStartElement("Data")
                .WriteStartElement("Configuracion")

                .WriteStartElement("FiltraSiempreDiaActual")
                If frmConfigurar.mtgHoy.Checked = True Then
                    .WriteString("Si")
                    .WriteEndElement()
                Else
                    .WriteString("No")
                    .WriteEndElement()
                End If

                .WriteStartElement("CantidadDiasRestaDiaActual")
                If frmConfigurar.mtgHoy.Checked = True Then
                    .WriteString("0")
                    .WriteEndElement()
                Else
                    .WriteString(frmConfigurar.mcboDias.Text)
                    .WriteEndElement()
                End If

                .WriteStartElement("RutaBDAccess2003")
                .WriteString(frmConfigurar.mtxtAccess.Text)
                .WriteEndElement()

                .WriteStartElement("CadenaConexionMySQL")
                .WriteString(frmConfigurar.mtxtMySQL.Text)
                .WriteEndElement()

                .WriteStartElement("TiempoEjecucionServicioSincronizacion")
                .WriteString(frmConfigurar.mcboTiempoSincronizacion.Text)
                .WriteEndElement()

                .WriteStartElement("BorrarLogs")
                If frmConfigurar.mtgBorrarLogs.Checked = True Then
                    .WriteString("Si")
                    .WriteEndElement()
                Else
                    .WriteString("No")
                    .WriteEndElement()
                End If

                .WriteEndElement()
                .WriteEndDocument()
                .Close()
                resultado = True
            End With
        Catch ex As Exception
            resultado = False
            MessageBox.Show(ex.Message)
        End Try
        ActualizarConfiguraciones = resultado
    End Function
    Public Function ActualizarSBDPXML() As Boolean
        Dim resultado As Boolean = False
        Dim objetoLectorXML As New ManejoXML
        Dim numeroCompilacion As Integer
        Try
            numeroCompilacion = Convert.ToInt32(objetoLectorXML.ObtenerValorXML("Compilaciones", "SBDP.xml"))
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            Dim XmlWrt As XmlWriter = XmlWriter.Create("SBDP.xml", settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteComment("XML Database.")
                .WriteStartElement("Data")
                .WriteStartElement("Configuracion")
                numeroCompilacion = numeroCompilacion + 1
                .WriteStartElement("Compilaciones")
                .WriteString(numeroCompilacion)

                .WriteEndElement()
                .WriteEndDocument()
                .Close()
                resultado = True
            End With
        Catch ex As Exception
            resultado = False
            MessageBox.Show(ex.Message)
        End Try
        ActualizarSBDPXML = resultado
    End Function
End Class
