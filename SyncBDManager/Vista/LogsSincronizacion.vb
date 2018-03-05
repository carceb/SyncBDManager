Public Class LogsSincronizacion
    Private Sub LogsSincronizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListViewLog(0)
        mtbdProcesosSinc.SelectedIndex = 0
    End Sub
    Private Sub mlnkInventory_Click(sender As Object, e As EventArgs) Handles mlnkInventory.Click
        CargarListViewLog(0)
        mtbdProcesosSinc.SelectedIndex = 0
    End Sub
    Private Sub mlnkInventoryPricing_Click(sender As Object, e As EventArgs) Handles mlnkInventoryPricing.Click
        CargarListViewLog(1)
        mtbdProcesosSinc.SelectedIndex = 1
    End Sub
    Private Sub mlnkInventoryItemXRef_Click(sender As Object, e As EventArgs) Handles mlnkInventoryItemXRef.Click
        CargarListViewLog(2)
        mtbdProcesosSinc.SelectedIndex = 2
    End Sub
    Private Sub mlnkOrders_Click(sender As Object, e As EventArgs) Handles mlnkOrders.Click
        CargarListViewLog(3)
        mtbdProcesosSinc.SelectedIndex = 3
    End Sub

    Private Sub mlnkOrdersDetail_Click(sender As Object, e As EventArgs) Handles mlnkOrdersDetail.Click
        CargarListViewLog(4)
        mtbdProcesosSinc.SelectedIndex = 4
    End Sub
    Private Sub mlnkCustormersBill_Click(sender As Object, e As EventArgs) Handles mlnkCustormersBill.Click
        CargarListViewLog(5)
        mtbdProcesosSinc.SelectedIndex = 5
    End Sub

    Private Sub mlnkCustormersPrsn_Click(sender As Object, e As EventArgs) Handles mlnkCustormersPrsn.Click
        CargarListViewLog(6)
        mtbdProcesosSinc.SelectedIndex = 6
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
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\OrdersDetail.txt", lvOrdersDetail)
            Case 5
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\CustomersBill.txt", lvCustomersBill)
            Case 6
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\CustomersBillPrsn.txt", lvCustomersBillPrsn)
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
        CargarListViewLog(4)
        CargarListViewLog(5)
        CargarListViewLog(6)
    End Sub
End Class