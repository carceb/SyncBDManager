Imports System.Xml
Public Class ManejoXML
    Public Sub New()
    End Sub
    Public Function ObtenerValorXML(nombreNodo As String) As String
        Dim resultadoValorNodo As String = ""
        Dim confFilePath As String
        Try
            confFilePath = My.Application.Info.DirectoryPath & "\Configuracion.xml"
            If (IO.File.Exists(confFilePath)) Then
                Dim document As XmlReader = New XmlTextReader(confFilePath)
                While (document.Read())
                    Dim type = document.NodeType
                    If (type = XmlNodeType.Element) Then
                        If (document.Name = nombreNodo) Then
                            resultadoValorNodo = document.ReadInnerXml.ToString()
                        End If
                    End If
                End While
                document.Close()
                ObtenerValorXML = resultadoValorNodo
            Else
                ObtenerValorXML = "Error"
                MessageBox.Show("Aún no ha realizado la configuracion del servicio de sincronización.")
            End If
        Catch ex As Exception
            ObtenerValorXML = "Error"
        End Try
    End Function
End Class
