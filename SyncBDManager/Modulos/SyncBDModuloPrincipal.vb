Module SyncBDModuloPrincipal
    Public Function TiempoEjecucionSincronizador(valorConfiguracionXML As String) As Double
        Dim resultado As Double = 0
        Try
            Select Case valorConfiguracionXML
                Case "30 Segundos"
                    resultado = 30000
                Case "40 Segundos"
                    resultado = 40000
                Case "50 Segundos"
                    resultado = 50000
                Case "1 Minuto"
                    resultado = 60000
                Case "20 Minutos"
                    resultado = 1200000
                Case "30 Minutos"
                    resultado = 1800000
            End Select
        Catch ex As Exception

        End Try
        TiempoEjecucionSincronizador = resultado
    End Function
End Module
