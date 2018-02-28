Public Class LogsSincronizacion
    Private Sub LogsSincronizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbdProcesosSinc.SelectedIndex = 0
    End Sub
    Private Sub mlnkInventory_Click(sender As Object, e As EventArgs) Handles mlnkInventory.Click
        mtbdProcesosSinc.SelectedIndex = 0
    End Sub
    Private Sub mlnkInventoryPricing_Click(sender As Object, e As EventArgs) Handles mlnkInventoryPricing.Click
        mtbdProcesosSinc.SelectedIndex = 1
    End Sub

    Private Sub mlnkInventoryDTS_Click(sender As Object, e As EventArgs) Handles mlnkInventoryDTS.Click
        mtbdProcesosSinc.SelectedIndex = 2
    End Sub

    Private Sub mlnkOrders_Click(sender As Object, e As EventArgs) Handles mlnkOrders.Click
        mtbdProcesosSinc.SelectedIndex = 3
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


End Class