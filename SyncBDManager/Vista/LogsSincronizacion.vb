Public Class LogsSincronizacion

    Private Sub LogsSincronizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListViewLog(0)
        mtbdProcesosSinc.SelectedIndex = 0
    End Sub
    Private Sub mlnkInventory_Click(sender As Object, e As EventArgs) Handles mlnkInventory.Click
        mtbdProcesosSinc.SelectedIndex = 0
        CargarListViewLog(0)
    End Sub
    Private Sub mlnkInventoryPricing_Click(sender As Object, e As EventArgs) Handles mlnkInventoryPricing.Click
        mtbdProcesosSinc.SelectedIndex = 1
        CargarListViewLog(1)
    End Sub
    Private Sub mlnkInventoryItemXRef_Click(sender As Object, e As EventArgs) Handles mlnkInventoryItemXRef.Click
        mtbdProcesosSinc.SelectedIndex = 2
        CargarListViewLog(2)
    End Sub
    Private Sub mlnkOrders_Click(sender As Object, e As EventArgs) Handles mlnkOrders.Click
        mtbdProcesosSinc.SelectedIndex = 3
        CargarListViewLog(3)
    End Sub

    Private Sub mlnkOrdersDetail_Click(sender As Object, e As EventArgs) Handles mlnkOrdersDetail.Click
        mtbdProcesosSinc.SelectedIndex = 4
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        mtbdProcesosSinc.SelectedIndex = 5
    End Sub

    Private Sub mlnkCustormersBill_Click(sender As Object, e As EventArgs) Handles mlnkCustormersBill.Click
        mtbdProcesosSinc.SelectedIndex = 6
    End Sub

    Private Sub mlnkCustormersPrsn_Click(sender As Object, e As EventArgs) Handles mlnkCustormersPrsn.Click
        mtbdProcesosSinc.SelectedIndex = 7
    End Sub

    Private Sub mlnkCustormersBillPrcol_Click(sender As Object, e As EventArgs) Handles mlnkCustormersBillPrcol.Click
        mtbdProcesosSinc.SelectedIndex = 8
    End Sub

    Private Sub mlnkCodesCat_Click(sender As Object, e As EventArgs) Handles mlnkCodesCat.Click
        mtbdProcesosSinc.SelectedIndex = 9
    End Sub

    Private Sub mlnkCodesCatSub_Click(sender As Object, e As EventArgs) Handles mlnkCodesCatSub.Click
        mtbdProcesosSinc.SelectedIndex = 10
    End Sub
    Private Sub CargarListViewLog(listViewACargar As Integer)
        Dim objetoLogLector As New LogLector
        Select Case listViewACargar
            Case 0
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\Inventory.txt", lvInventory)
            Case 1
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\InventoryPricing.txt", lvInventoryPricing)
            Case 2
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\InventoryItemsXRef.txt", mlvInventoryItemXRef)
            Case 3
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\Orders.txt", mlvOrders)
            Case 4
            Case 5
            Case 6
            Case 7
            Case 8
            Case 9
            Case 10
        End Select
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        CargarListViewLog(0)
        CargarListViewLog(1)
        CargarListViewLog(2)
        CargarListViewLog(3)
    End Sub
End Class