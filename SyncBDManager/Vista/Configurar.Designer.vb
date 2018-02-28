<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configurar
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mpMenu = New MetroFramework.Controls.MetroPanel()
        Me.mtbdConfiguraciones = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtgHoy = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mcboDias = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.mtxtMySQL = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtxtAccess = New MetroFramework.Controls.MetroTextBox()
        Me.mtbConfiguracion = New MetroFramework.Controls.MetroTabPage()
        Me.mtgBorrarLogs = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.mcboTiempoSincronizacion = New MetroFramework.Controls.MetroComboBox()
        Me.mbtnAplicar = New MetroFramework.Controls.MetroButton()
        Me.mlnkSincronizador = New MetroFramework.Controls.MetroLink()
        Me.mlnkUbicaciones = New MetroFramework.Controls.MetroLink()
        Me.mlnkFiltros = New MetroFramework.Controls.MetroLink()
        Me.mpMenu.SuspendLayout()
        Me.mtbdConfiguraciones.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.mtbConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'mpMenu
        '
        Me.mpMenu.AutoScroll = True
        Me.mpMenu.Controls.Add(Me.mlnkSincronizador)
        Me.mpMenu.Controls.Add(Me.mlnkUbicaciones)
        Me.mpMenu.Controls.Add(Me.mlnkFiltros)
        Me.mpMenu.HorizontalScrollbar = True
        Me.mpMenu.HorizontalScrollbarBarColor = True
        Me.mpMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.mpMenu.HorizontalScrollbarSize = 10
        Me.mpMenu.Location = New System.Drawing.Point(23, 64)
        Me.mpMenu.Name = "mpMenu"
        Me.mpMenu.Size = New System.Drawing.Size(270, 218)
        Me.mpMenu.TabIndex = 4
        Me.mpMenu.VerticalScrollbar = True
        Me.mpMenu.VerticalScrollbarBarColor = True
        Me.mpMenu.VerticalScrollbarHighlightOnWheel = False
        Me.mpMenu.VerticalScrollbarSize = 10
        '
        'mtbdConfiguraciones
        '
        Me.mtbdConfiguraciones.Controls.Add(Me.MetroTabPage1)
        Me.mtbdConfiguraciones.Controls.Add(Me.MetroTabPage2)
        Me.mtbdConfiguraciones.Controls.Add(Me.mtbConfiguracion)
        Me.mtbdConfiguraciones.Location = New System.Drawing.Point(311, 24)
        Me.mtbdConfiguraciones.Name = "mtbdConfiguraciones"
        Me.mtbdConfiguraciones.SelectedIndex = 0
        Me.mtbdConfiguraciones.Size = New System.Drawing.Size(407, 265)
        Me.mtbdConfiguraciones.TabIndex = 15
        Me.mtbdConfiguraciones.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.mtgHoy)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.mcboDias)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(399, 223)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 7)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(250, 25)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Filtros y criterios de búsqueda"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 50)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(205, 19)
        Me.MetroLabel1.TabIndex = 10
        Me.MetroLabel1.Text = "Filtrar búsqueda siempre por hoy"
        '
        'mtgHoy
        '
        Me.mtgHoy.AutoSize = True
        Me.mtgHoy.Checked = True
        Me.mtgHoy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mtgHoy.Location = New System.Drawing.Point(13, 81)
        Me.mtgHoy.Name = "mtgHoy"
        Me.mtgHoy.Size = New System.Drawing.Size(80, 17)
        Me.mtgHoy.TabIndex = 9
        Me.mtgHoy.Text = "On"
        Me.mtgHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtgHoy.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 127)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(137, 19)
        Me.MetroLabel2.TabIndex = 8
        Me.MetroLabel2.Text = "Al día de hoy restarle:"
        '
        'mcboDias
        '
        Me.mcboDias.FormattingEnabled = True
        Me.mcboDias.ItemHeight = 23
        Me.mcboDias.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.mcboDias.Location = New System.Drawing.Point(13, 149)
        Me.mcboDias.Name = "mcboDias"
        Me.mcboDias.Size = New System.Drawing.Size(186, 29)
        Me.mcboDias.TabIndex = 7
        Me.mcboDias.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.mtxtMySQL)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.Controls.Add(Me.mtxtAccess)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(399, 223)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 119)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(197, 19)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Parametros de conexión MySQL"
        '
        'mtxtMySQL
        '
        '
        '
        '
        Me.mtxtMySQL.CustomButton.Image = Nothing
        Me.mtxtMySQL.CustomButton.Location = New System.Drawing.Point(333, 2)
        Me.mtxtMySQL.CustomButton.Name = ""
        Me.mtxtMySQL.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.mtxtMySQL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxtMySQL.CustomButton.TabIndex = 1
        Me.mtxtMySQL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxtMySQL.CustomButton.UseSelectable = True
        Me.mtxtMySQL.CustomButton.Visible = False
        Me.mtxtMySQL.Lines = New String(-1) {}
        Me.mtxtMySQL.Location = New System.Drawing.Point(16, 141)
        Me.mtxtMySQL.MaxLength = 32767
        Me.mtxtMySQL.Name = "mtxtMySQL"
        Me.mtxtMySQL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtMySQL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxtMySQL.SelectedText = ""
        Me.mtxtMySQL.SelectionLength = 0
        Me.mtxtMySQL.SelectionStart = 0
        Me.mtxtMySQL.ShortcutsEnabled = True
        Me.mtxtMySQL.Size = New System.Drawing.Size(365, 34)
        Me.mtxtMySQL.TabIndex = 13
        Me.mtxtMySQL.UseSelectable = True
        Me.mtxtMySQL.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxtMySQL.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 4)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(208, 25)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Conexión acceso a datos"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 47)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(284, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Parametros de conexión OLDB BD Access 2003"
        '
        'mtxtAccess
        '
        '
        '
        '
        Me.mtxtAccess.CustomButton.Image = Nothing
        Me.mtxtAccess.CustomButton.Location = New System.Drawing.Point(333, 2)
        Me.mtxtAccess.CustomButton.Name = ""
        Me.mtxtAccess.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.mtxtAccess.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxtAccess.CustomButton.TabIndex = 1
        Me.mtxtAccess.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxtAccess.CustomButton.UseSelectable = True
        Me.mtxtAccess.CustomButton.Visible = False
        Me.mtxtAccess.Lines = New String(-1) {}
        Me.mtxtAccess.Location = New System.Drawing.Point(16, 69)
        Me.mtxtAccess.MaxLength = 32767
        Me.mtxtAccess.Name = "mtxtAccess"
        Me.mtxtAccess.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtAccess.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxtAccess.SelectedText = ""
        Me.mtxtAccess.SelectionLength = 0
        Me.mtxtAccess.SelectionStart = 0
        Me.mtxtAccess.ShortcutsEnabled = True
        Me.mtxtAccess.Size = New System.Drawing.Size(365, 34)
        Me.mtxtAccess.TabIndex = 10
        Me.mtxtAccess.UseSelectable = True
        Me.mtxtAccess.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxtAccess.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtbConfiguracion
        '
        Me.mtbConfiguracion.Controls.Add(Me.mtgBorrarLogs)
        Me.mtbConfiguracion.Controls.Add(Me.MetroLabel9)
        Me.mtbConfiguracion.Controls.Add(Me.MetroLabel8)
        Me.mtbConfiguracion.Controls.Add(Me.MetroLabel7)
        Me.mtbConfiguracion.Controls.Add(Me.mcboTiempoSincronizacion)
        Me.mtbConfiguracion.HorizontalScrollbarBarColor = True
        Me.mtbConfiguracion.HorizontalScrollbarHighlightOnWheel = False
        Me.mtbConfiguracion.HorizontalScrollbarSize = 10
        Me.mtbConfiguracion.Location = New System.Drawing.Point(4, 38)
        Me.mtbConfiguracion.Name = "mtbConfiguracion"
        Me.mtbConfiguracion.Size = New System.Drawing.Size(399, 223)
        Me.mtbConfiguracion.TabIndex = 2
        Me.mtbConfiguracion.VerticalScrollbarBarColor = True
        Me.mtbConfiguracion.VerticalScrollbarHighlightOnWheel = False
        Me.mtbConfiguracion.VerticalScrollbarSize = 10
        '
        'mtgBorrarLogs
        '
        Me.mtgBorrarLogs.AutoSize = True
        Me.mtgBorrarLogs.Location = New System.Drawing.Point(17, 167)
        Me.mtgBorrarLogs.Name = "mtgBorrarLogs"
        Me.mtgBorrarLogs.Size = New System.Drawing.Size(80, 17)
        Me.mtgBorrarLogs.TabIndex = 32
        Me.mtgBorrarLogs.Text = "Off"
        Me.mtgBorrarLogs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtgBorrarLogs.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(17, 133)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(218, 19)
        Me.MetroLabel9.TabIndex = 31
        Me.MetroLabel9.Text = "Borrar los archivos log cada 30 días"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(17, 55)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(256, 19)
        Me.MetroLabel8.TabIndex = 29
        Me.MetroLabel8.Text = "Ejecutar el servicio de sincronización cada:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(120, 25)
        Me.MetroLabel7.TabIndex = 28
        Me.MetroLabel7.Text = "Sincronizador"
        '
        'mcboTiempoSincronizacion
        '
        Me.mcboTiempoSincronizacion.DisplayMember = "1"
        Me.mcboTiempoSincronizacion.FormattingEnabled = True
        Me.mcboTiempoSincronizacion.ItemHeight = 23
        Me.mcboTiempoSincronizacion.Items.AddRange(New Object() {"30 Segundos", "40 Segundos", "50 Segundos", "1 Minuto", "10 Minutos", "20 Minutos", "30 Minutos"})
        Me.mcboTiempoSincronizacion.Location = New System.Drawing.Point(17, 86)
        Me.mcboTiempoSincronizacion.Name = "mcboTiempoSincronizacion"
        Me.mcboTiempoSincronizacion.Size = New System.Drawing.Size(252, 29)
        Me.mcboTiempoSincronizacion.TabIndex = 27
        Me.mcboTiempoSincronizacion.UseSelectable = True
        '
        'mbtnAplicar
        '
        Me.mbtnAplicar.Location = New System.Drawing.Point(580, 305)
        Me.mbtnAplicar.Name = "mbtnAplicar"
        Me.mbtnAplicar.Size = New System.Drawing.Size(103, 18)
        Me.mbtnAplicar.TabIndex = 16
        Me.mbtnAplicar.Text = "Aplicar cambios"
        Me.mbtnAplicar.UseSelectable = True
        '
        'mlnkSincronizador
        '
        Me.mlnkSincronizador.Image = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mlnkSincronizador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkSincronizador.ImageSize = 22
        Me.mlnkSincronizador.Location = New System.Drawing.Point(20, 132)
        Me.mlnkSincronizador.Name = "mlnkSincronizador"
        Me.mlnkSincronizador.Size = New System.Drawing.Size(138, 27)
        Me.mlnkSincronizador.TabIndex = 5
        Me.mlnkSincronizador.Text = "Sincronizador"
        Me.mlnkSincronizador.UseSelectable = True
        '
        'mlnkUbicaciones
        '
        Me.mlnkUbicaciones.Image = Global.SyncBDManager.My.Resources.Resources.Ubicaciones
        Me.mlnkUbicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkUbicaciones.ImageSize = 22
        Me.mlnkUbicaciones.Location = New System.Drawing.Point(20, 84)
        Me.mlnkUbicaciones.Name = "mlnkUbicaciones"
        Me.mlnkUbicaciones.Size = New System.Drawing.Size(201, 27)
        Me.mlnkUbicaciones.TabIndex = 4
        Me.mlnkUbicaciones.Text = "Conexión acceso a datos"
        Me.mlnkUbicaciones.UseSelectable = True
        '
        'mlnkFiltros
        '
        Me.mlnkFiltros.Image = Global.SyncBDManager.My.Resources.Resources.fechaHora
        Me.mlnkFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mlnkFiltros.ImageSize = 22
        Me.mlnkFiltros.Location = New System.Drawing.Point(20, 40)
        Me.mlnkFiltros.Name = "mlnkFiltros"
        Me.mlnkFiltros.Size = New System.Drawing.Size(231, 27)
        Me.mlnkFiltros.TabIndex = 3
        Me.mlnkFiltros.Text = "Filtros y criterios de búsqueda"
        Me.mlnkFiltros.UseSelectable = True
        '
        'Configurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImagePadding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BackMaxSize = 40
        Me.ClientSize = New System.Drawing.Size(724, 435)
        Me.Controls.Add(Me.mbtnAplicar)
        Me.Controls.Add(Me.mtbdConfiguraciones)
        Me.Controls.Add(Me.mpMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Configurar"
        Me.Resizable = False
        Me.Text = "Configuración"
        Me.mpMenu.ResumeLayout(False)
        Me.mtbdConfiguraciones.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.mtbConfiguracion.ResumeLayout(False)
        Me.mtbConfiguracion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mpMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlnkSincronizador As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkUbicaciones As MetroFramework.Controls.MetroLink
    Friend WithEvents mlnkFiltros As MetroFramework.Controls.MetroLink
    Friend WithEvents mtbdConfiguraciones As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtgHoy As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcboDias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxtMySQL As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxtAccess As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtbConfiguracion As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcboTiempoSincronizacion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mbtnAplicar As MetroFramework.Controls.MetroButton
    Friend WithEvents mtgBorrarLogs As MetroFramework.Controls.MetroToggle
End Class
