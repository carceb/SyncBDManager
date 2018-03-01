Imports System.IO
Imports MetroFramework.Controls

Public Class LogLector
    Public Sub New()
    End Sub
    Public Sub CargarArchivoLog(archivoLog As String, ByRef lvLog As ListView)
        lvLog.Clear()
        lvLog.View = View.Details
        lvLog.Columns.Add("Fecha", 140)
        lvLog.Columns.Add("Proceso", 400)
        Try
            Dim MyStream As New StreamReader(archivoLog)
            Dim strTemp() As String
            Do While MyStream.Peek <> -1
                Dim LVItem As New ListViewItem
                strTemp = MyStream.ReadLine.Split("|"c)
                LVItem.Text = strTemp(0).ToString
                lvLog.Items.Add(LVItem)
                LVItem.SubItems.Add(strTemp(1).ToString)
                If strTemp.Length > 2 Then LVItem.SubItems.Add(strTemp(2).ToString)
            Loop
            MyStream.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
