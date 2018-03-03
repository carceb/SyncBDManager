<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsSincronizacion
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mpMenu = New MetroFramework.Controls.MetroPanel()
        Me.mlnkCodesCatSub = New MetroFramework.Controls.MetroLink()
        Me.mlnkCodesCat = New MetroFramework.Controls.MetroLink()
        Me.mlnkCustormersBillPrcol = New MetroFramework.Controls.MetroLink()
        Me.mlnkCustormersPrsn = New MetroFramework.Controls.MetroLink()
        Me.mlnkCustormersBill = New MetroFramework.Controls.MetroLink()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.mlnkOrdersDetail = New MetroFramework.Controls.MetroLink()
        Me.mlnkOrders = New MetroFramework.Controls.MetroLink()
        Me.mlnkInventoryItemXRef = New MetroFramework.Controls.MetroLink()
        Me.mlnkInventoryPricing = New MetroFramework.Controls.MetroLink()
        Me.mlnkInventory = New MetroFramework.Controls.MetroLink()
        Me.mtbdProcesosSinc = New MetroFramework.Controls.MetroTabControl()
        Me.mtbConfiguracion = New MetroFramework.Controls.MetroTabPage()
        Me.mlvOrders = New System.Windows.Forms.ListView()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage10 = New MetroFramework.Controls.MetroTabPage()
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.lvInventoryPricing = New System.Windows.Forms.ListView()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.mlvInventoryItemXRef = New System.Windows.Forms.ListView()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage7 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage8 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage9 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.mpMenu.SuspendLayout()
        Me.mtbdProcesosSinc.SuspendLayout()
        Me.mtbConfiguracion.SuspendLayout()
        Me.MetroTabPage10.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        Me.MetroTabPage5.SuspendLayout()
        Me.MetroTabPage6.SuspendLayout()
        Me.MetroTabPage7.SuspendLayout()
        Me.MetroTabPage8.SuspendLayout()
        Me.MetroTabPage9.SuspendLayout()
        Me.SuspendLayout()
        '
        'mpMenu
        '
        Me.mpMenu.AutoScroll = True
        Me.mpMenu.Controls.Add(Me.mlnkCodesCatSub)
        Me.mpMenu.Controls.Add(Me.mlnkCodesCat)
        Me.mpMenu.Controls.Add(Me.mlnkCustormersBillPrcol)
        Me.mpMenu.Controls.Add(Me.mlnkCustormersPrsn)
        Me.mpMenu.Controls.Add(Me.mlnkCustormersBill)
        Me.mpMenu.Controls.Add(Me.MetroLink1)
        Me.mpMenu.Controls.Add(Me.mlnkOrdersDetail)
        Me.mpMenu.Controls.Add(Me.mlnkOrders)
        Me.mpMenu.Controls.Add(Me.mlnkInventoryItemXRef)
        Me.mpMenu.Controls.Add(Me.mlnkInventoryPricing)
        Me.mpMenu.Controls.Add(Me.mlnkInventory)
        Me.mpMenu.HorizontalScrollbar = True
        Me.mpMenu.HorizontalScrollbarBarColor = True
        Me.mpMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.mpMenu.HorizontalScrollbarSize = 10
        Me.mpMenu.Location = New System.Drawing.Point(33, 76)
        Me.mpMenu.Name = "mpMenu"
        Me.mpMenu.Size = New System.Drawing.Size(270, 336)
        Me.mpMenu.TabIndex = 5
        Me.mpMenu.VerticalScrollbar = True
        Me.mpMenu.VerticalScrollbarBarColor = True
        Me.mpMenu.VerticalScrollbarHighlightOnWheel = False
        Me.mpMenu.VerticalScrollbarSize = 10
        '
        'mlnkCodesCatSub
        '
        Me.mlnkCodesCatSub.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkCodesCatSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkCodesCatSub.ImageSize = 22
        Me.mlnkCodesCatSub.Location = New System.Drawing.Point(20, 343)
        Me.mlnkCodesCatSub.Name = "mlnkCodesCatSub"
        Me.mlnkCodesCatSub.Size = New System.Drawing.Size(146, 27)
        Me.mlnkCodesCatSub.TabIndex = 14
        Me.mlnkCodesCatSub.Text = "Codes Cat Sub"
        Me.mlnkCodesCatSub.UseSelectable = True
        '
        'mlnkCodesCat
        '
        Me.mlnkCodesCat.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkCodesCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkCodesCat.ImageSize = 22
        Me.mlnkCodesCat.Location = New System.Drawing.Point(20, 310)
        Me.mlnkCodesCat.Name = "mlnkCodesCat"
        Me.mlnkCodesCat.Size = New System.Drawing.Size(124, 27)
        Me.mlnkCodesCat.TabIndex = 12
        Me.mlnkCodesCat.Text = "Codes Cat"
        Me.mlnkCodesCat.UseSelectable = True
        '
        'mlnkCustormersBillPrcol
        '
        Me.mlnkCustormersBillPrcol.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkCustormersBillPrcol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkCustormersBillPrcol.ImageSize = 22
        Me.mlnkCustormersBillPrcol.Location = New System.Drawing.Point(20, 277)
        Me.mlnkCustormersBillPrcol.Name = "mlnkCustormersBillPrcol"
        Me.mlnkCustormersBillPrcol.Size = New System.Drawing.Size(180, 27)
        Me.mlnkCustormersBillPrcol.TabIndex = 11
        Me.mlnkCustormersBillPrcol.Text = "Custormers Bill Prcol"
        Me.mlnkCustormersBillPrcol.UseSelectable = True
        '
        'mlnkCustormersPrsn
        '
        Me.mlnkCustormersPrsn.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkCustormersPrsn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkCustormersPrsn.ImageSize = 22
        Me.mlnkCustormersPrsn.Location = New System.Drawing.Point(20, 244)
        Me.mlnkCustormersPrsn.Name = "mlnkCustormersPrsn"
        Me.mlnkCustormersPrsn.Size = New System.Drawing.Size(158, 27)
        Me.mlnkCustormersPrsn.TabIndex = 10
        Me.mlnkCustormersPrsn.Text = "Custormers Prsn"
        Me.mlnkCustormersPrsn.UseSelectable = True
        '
        'mlnkCustormersBill
        '
        Me.mlnkCustormersBill.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkCustormersBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkCustormersBill.ImageSize = 22
        Me.mlnkCustormersBill.Location = New System.Drawing.Point(20, 211)
        Me.mlnkCustormersBill.Name = "mlnkCustormersBill"
        Me.mlnkCustormersBill.Size = New System.Drawing.Size(158, 27)
        Me.mlnkCustormersBill.TabIndex = 9
        Me.mlnkCustormersBill.Text = "Custormers Bill"
        Me.mlnkCustormersBill.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.MetroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.ImageSize = 22
        Me.MetroLink1.Location = New System.Drawing.Point(20, 178)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(146, 27)
        Me.MetroLink1.TabIndex = 8
        Me.MetroLink1.Text = "Orders Detail"
        Me.MetroLink1.UseSelectable = True
        '
        'mlnkOrdersDetail
        '
        Me.mlnkOrdersDetail.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkOrdersDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkOrdersDetail.ImageSize = 22
        Me.mlnkOrdersDetail.Location = New System.Drawing.Point(20, 145)
        Me.mlnkOrdersDetail.Name = "mlnkOrdersDetail"
        Me.mlnkOrdersDetail.Size = New System.Drawing.Size(146, 27)
        Me.mlnkOrdersDetail.TabIndex = 7
        Me.mlnkOrdersDetail.Text = "Orders Detail"
        Me.mlnkOrdersDetail.UseSelectable = True
        '
        'mlnkOrders
        '
        Me.mlnkOrders.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkOrders.ImageSize = 22
        Me.mlnkOrders.Location = New System.Drawing.Point(20, 112)
        Me.mlnkOrders.Name = "mlnkOrders"
        Me.mlnkOrders.Size = New System.Drawing.Size(111, 27)
        Me.mlnkOrders.TabIndex = 6
        Me.mlnkOrders.Text = "Orders"
        Me.mlnkOrders.UseSelectable = True
        '
        'mlnkInventoryItemXRef
        '
        Me.mlnkInventoryItemXRef.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkInventoryItemXRef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkInventoryItemXRef.ImageSize = 22
        Me.mlnkInventoryItemXRef.Location = New System.Drawing.Point(20, 79)
        Me.mlnkInventoryItemXRef.Name = "mlnkInventoryItemXRef"
        Me.mlnkInventoryItemXRef.Size = New System.Drawing.Size(180, 27)
        Me.mlnkInventoryItemXRef.TabIndex = 5
        Me.mlnkInventoryItemXRef.Text = "Inventory Item X Ref"
        Me.mlnkInventoryItemXRef.UseSelectable = True
        '
        'mlnkInventoryPricing
        '
        Me.mlnkInventoryPricing.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkInventoryPricing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkInventoryPricing.ImageSize = 22
        Me.mlnkInventoryPricing.Location = New System.Drawing.Point(20, 46)
        Me.mlnkInventoryPricing.Name = "mlnkInventoryPricing"
        Me.mlnkInventoryPricing.Size = New System.Drawing.Size(158, 27)
        Me.mlnkInventoryPricing.TabIndex = 4
        Me.mlnkInventoryPricing.Text = "Inventory Pricing"
        Me.mlnkInventoryPricing.UseSelectable = True
        '
        'mlnkInventory
        '
        Me.mlnkInventory.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkInventory.ImageSize = 22
        Me.mlnkInventory.Location = New System.Drawing.Point(20, 13)
        Me.mlnkInventory.Name = "mlnkInventory"
        Me.mlnkInventory.Size = New System.Drawing.Size(124, 27)
        Me.mlnkInventory.TabIndex = 3
        Me.mlnkInventory.Text = "Inventory"
        Me.mlnkInventory.UseSelectable = True
        '
        'mtbdProcesosSinc
        '
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage10)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage1)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage2)
        Me.mtbdProcesosSinc.Controls.Add(Me.mtbConfiguracion)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage3)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage4)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage5)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage6)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage7)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage8)
        Me.mtbdProcesosSinc.Controls.Add(Me.MetroTabPage9)
        Me.mtbdProcesosSinc.Location = New System.Drawing.Point(309, 29)
        Me.mtbdProcesosSinc.Name = "mtbdProcesosSinc"
        Me.mtbdProcesosSinc.SelectedIndex = 3
        Me.mtbdProcesosSinc.Size = New System.Drawing.Size(407, 366)
        Me.mtbdProcesosSinc.TabIndex = 16
        Me.mtbdProcesosSinc.UseSelectable = True
        '
        'mtbConfiguracion
        '
        Me.mtbConfiguracion.Controls.Add(Me.mlvOrders)
        Me.mtbConfiguracion.Controls.Add(Me.MetroLabel7)
        Me.mtbConfiguracion.HorizontalScrollbarBarColor = True
        Me.mtbConfiguracion.HorizontalScrollbarHighlightOnWheel = False
        Me.mtbConfiguracion.HorizontalScrollbarSize = 10
        Me.mtbConfiguracion.Location = New System.Drawing.Point(4, 38)
        Me.mtbConfiguracion.Name = "mtbConfiguracion"
        Me.mtbConfiguracion.Size = New System.Drawing.Size(399, 324)
        Me.mtbConfiguracion.TabIndex = 2
        Me.mtbConfiguracion.VerticalScrollbarBarColor = True
        Me.mtbConfiguracion.VerticalScrollbarHighlightOnWheel = False
        Me.mtbConfiguracion.VerticalScrollbarSize = 10
        '
        'mlvOrders
        '
        Me.mlvOrders.AllowColumnReorder = True
        Me.mlvOrders.Location = New System.Drawing.Point(13, 34)
        Me.mlvOrders.Name = "mlvOrders"
        Me.mlvOrders.Size = New System.Drawing.Size(382, 294)
        Me.mlvOrders.TabIndex = 29
        Me.mlvOrders.UseCompatibleStateImageBehavior = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(66, 25)
        Me.MetroLabel7.TabIndex = 28
        Me.MetroLabel7.Text = "Orders"
        '
        'MetroTabPage10
        '
        Me.MetroTabPage10.Controls.Add(Me.lvInventory)
        Me.MetroTabPage10.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage10.HorizontalScrollbarBarColor = True
        Me.MetroTabPage10.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage10.HorizontalScrollbarSize = 10
        Me.MetroTabPage10.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage10.Name = "MetroTabPage10"
        Me.MetroTabPage10.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage10.TabIndex = 10
        Me.MetroTabPage10.VerticalScrollbarBarColor = True
        Me.MetroTabPage10.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage10.VerticalScrollbarSize = 10
        '
        'lvInventory
        '
        Me.lvInventory.AllowColumnReorder = True
        Me.lvInventory.Location = New System.Drawing.Point(17, 34)
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(382, 294)
        Me.lvInventory.TabIndex = 13
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(87, 25)
        Me.MetroLabel11.TabIndex = 12
        Me.MetroLabel11.Text = "Inventory"
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.lvInventoryPricing)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'lvInventoryPricing
        '
        Me.lvInventoryPricing.AllowColumnReorder = True
        Me.lvInventoryPricing.Location = New System.Drawing.Point(13, 34)
        Me.lvInventoryPricing.Name = "lvInventoryPricing"
        Me.lvInventoryPricing.Size = New System.Drawing.Size(382, 294)
        Me.lvInventoryPricing.TabIndex = 14
        Me.lvInventoryPricing.UseCompatibleStateImageBehavior = False
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 7)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(145, 25)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Inventory Pricing"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.mlvInventoryItemXRef)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'mlvInventoryItemXRef
        '
        Me.mlvInventoryItemXRef.AllowColumnReorder = True
        Me.mlvInventoryItemXRef.Location = New System.Drawing.Point(13, 34)
        Me.mlvInventoryItemXRef.Name = "mlvInventoryItemXRef"
        Me.mlvInventoryItemXRef.Size = New System.Drawing.Size(382, 294)
        Me.mlvInventoryItemXRef.TabIndex = 15
        Me.mlvInventoryItemXRef.UseCompatibleStateImageBehavior = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 4)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(174, 25)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Inventory Item X Ref"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage3.TabIndex = 3
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(116, 25)
        Me.MetroLabel1.TabIndex = 29
        Me.MetroLabel1.Text = "Orders Detail"
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage4.TabIndex = 4
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(124, 25)
        Me.MetroLabel2.TabIndex = 30
        Me.MetroLabel2.Text = "Customers Bill"
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.HorizontalScrollbarSize = 10
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage5.TabIndex = 5
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        Me.MetroTabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel4.TabIndex = 31
        Me.MetroLabel4.Text = "Customers Prsn"
        '
        'MetroTabPage6
        '
        Me.MetroTabPage6.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage6.HorizontalScrollbarBarColor = True
        Me.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.HorizontalScrollbarSize = 10
        Me.MetroTabPage6.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage6.Name = "MetroTabPage6"
        Me.MetroTabPage6.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage6.TabIndex = 6
        Me.MetroTabPage6.VerticalScrollbarBarColor = True
        Me.MetroTabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.VerticalScrollbarSize = 10
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(168, 25)
        Me.MetroLabel6.TabIndex = 32
        Me.MetroLabel6.Text = "Customers Bill Prcol"
        '
        'MetroTabPage7
        '
        Me.MetroTabPage7.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage7.HorizontalScrollbarBarColor = True
        Me.MetroTabPage7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.HorizontalScrollbarSize = 10
        Me.MetroTabPage7.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage7.Name = "MetroTabPage7"
        Me.MetroTabPage7.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage7.TabIndex = 7
        Me.MetroTabPage7.VerticalScrollbarBarColor = True
        Me.MetroTabPage7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.VerticalScrollbarSize = 10
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(168, 25)
        Me.MetroLabel8.TabIndex = 33
        Me.MetroLabel8.Text = "Customers Bill Prcol"
        '
        'MetroTabPage8
        '
        Me.MetroTabPage8.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage8.HorizontalScrollbarBarColor = True
        Me.MetroTabPage8.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage8.HorizontalScrollbarSize = 10
        Me.MetroTabPage8.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage8.Name = "MetroTabPage8"
        Me.MetroTabPage8.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage8.TabIndex = 8
        Me.MetroTabPage8.VerticalScrollbarBarColor = True
        Me.MetroTabPage8.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage8.VerticalScrollbarSize = 10
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 25)
        Me.MetroLabel9.TabIndex = 34
        Me.MetroLabel9.Text = "Codes Cat"
        '
        'MetroTabPage9
        '
        Me.MetroTabPage9.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage9.HorizontalScrollbarBarColor = True
        Me.MetroTabPage9.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage9.HorizontalScrollbarSize = 10
        Me.MetroTabPage9.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage9.Name = "MetroTabPage9"
        Me.MetroTabPage9.Size = New System.Drawing.Size(399, 324)
        Me.MetroTabPage9.TabIndex = 9
        Me.MetroTabPage9.VerticalScrollbarBarColor = True
        Me.MetroTabPage9.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage9.VerticalScrollbarSize = 10
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(129, 25)
        Me.MetroLabel10.TabIndex = 35
        Me.MetroLabel10.Text = "Codes Cat Sub"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(637, 401)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 17
        Me.MetroButton1.Text = "Refrescar"
        Me.MetroButton1.UseSelectable = True
        '
        'LogsSincronizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 435)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.mtbdProcesosSinc)
        Me.Controls.Add(Me.mpMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogsSincronizacion"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Procesos de sincronización"
        Me.mpMenu.ResumeLayout(False)
        Me.mtbdProcesosSinc.ResumeLayout(False)
        Me.mtbConfiguracion.ResumeLayout(False)
        Me.mtbConfiguracion.PerformLayout()
        Me.MetroTabPage10.ResumeLayout(False)
        Me.MetroTabPage10.PerformLayout()
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.MetroTabPage4.ResumeLayout(False)
        Me.MetroTabPage4.PerformLayout()
        Me.MetroTabPage5.ResumeLayout(False)
        Me.MetroTabPage5.PerformLayout()
        Me.MetroTabPage6.ResumeLayout(False)
        Me.MetroTabPage6.PerformLayout()
        Me.MetroTabPage7.ResumeLayout(False)
        Me.MetroTabPage7.PerformLayout()
        Me.MetroTabPage8.ResumeLayout(False)
        Me.MetroTabPage8.PerformLayout()
        Me.MetroTabPage9.ResumeLayout(False)
        Me.MetroTabPage9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlnkInventoryItemXRef As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkInventoryPricing As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkInventory As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkOrders As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkOrdersDetail As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkCustormersBill As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkCustormersPrsn As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkCustormersBillPrcol As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkCodesCat As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkCodesCatSub As MetroFramework.Controls.MetroLink
    Friend WithEvents mtbdProcesosSinc As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mtbConfiguracion As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage6 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage7 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage8 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage9 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage10 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents lvInventory As ListView
    Friend WithEvents lvInventoryPricing As ListView
    Friend WithEvents mlvInventoryItemXRef As ListView
    Friend WithEvents mlvOrders As ListView
End Class
