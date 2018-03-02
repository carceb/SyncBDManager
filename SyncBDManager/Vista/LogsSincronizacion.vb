Public Class LogsSincronizacion
    Private lvwColumnSorter As ListViewColumnSorter
    Private Sub LogsSincronizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbdProcesosSinc.SelectedIndex = 0

        lvwColumnSorter = New ListViewColumnSorter()
        lvwColumnSorter = New ListViewColumnSorter()
        lvInventory.ListViewItemSorter = lvwColumnSorter
        CargarListViewLog(0)
        CargarListViewLog(1)
    End Sub
    Private Sub mlnkInventory_Click(sender As Object, e As EventArgs) Handles mlnkInventory.Click
        mtbdProcesosSinc.SelectedIndex = 0
        CargarListViewLog(1)
    End Sub
    Private Sub mlnkInventoryPricing_Click(sender As Object, e As EventArgs) Handles mlnkInventoryPricing.Click
        mtbdProcesosSinc.SelectedIndex = 1
        CargarListViewLog(1)
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
    Private Sub CargarListViewLog(listViewACargar As Integer)
        Dim objetoLogLector As New LogLector
        Select Case listViewACargar
            Case 0
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\Inventory.txt", lvInventory)
            Case 1
                objetoLogLector.CargarArchivoLog(Application.StartupPath & "\Logs\InventoryPricing.txt", lvInventoryPricing)
            Case 2
            Case 3
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
    End Sub

    Private Sub lvInventory_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvInventory.ColumnClick
        If (e.Column = lvwColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                lvwColumnSorter.Order = SortOrder.Descending
            Else
                lvwColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        Me.lvInventory.Sort()
    End Sub

    Private Sub lvInventoryPricing_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvInventoryPricing.ColumnClick
        If (e.Column = lvwColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                lvwColumnSorter.Order = SortOrder.Descending
            Else
                lvwColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        Me.lvInventoryPricing.Sort()
    End Sub
End Class