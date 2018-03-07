Imports System.Xml
Public Class ManejoXML
    Public Sub New()
    End Sub
    Public Function ObtenerValorXML(nombreNodo As String, nombreArchivoXML As String) As String
        Dim resultadoValorNodo As String = ""
        Dim confFilePath As String
        Try
            confFilePath = My.Application.Info.DirectoryPath & "\" & nombreArchivoXML
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
                ObtenerValorXML = "0"
            End If
        Catch ex As Exception
            ObtenerValorXML = "0"
        End Try
    End Function
End Class
