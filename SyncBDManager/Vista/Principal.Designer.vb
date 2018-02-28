<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.mtServicio = New MetroFramework.Controls.MetroTile()
        Me.mtLogs = New MetroFramework.Controls.MetroTile()
        Me.mtConfiguracion = New MetroFramework.Controls.MetroTile()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.AutoSize = True
        Me.MetroPanel1.Controls.Add(Me.mtServicio)
        Me.MetroPanel1.Controls.Add(Me.mtLogs)
        Me.MetroPanel1.Controls.Add(Me.mtConfiguracion)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(684, 355)
        Me.MetroPanel1.TabIndex = 5
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'mtServicio
        '
        Me.mtServicio.ActiveControl = Nothing
        Me.mtServicio.Location = New System.Drawing.Point(232, 229)
        Me.mtServicio.Name = "mtServicio"
        Me.mtServicio.Size = New System.Drawing.Size(430, 105)
        Me.mtServicio.Style = MetroFramework.MetroColorStyle.Lime
        Me.mtServicio.TabIndex = 7
        Me.mtServicio.Text = "Iniciar/Detener servicio de sincronización"
        Me.mtServicio.UseSelectable = True
        '
        'mtLogs
        '
        Me.mtLogs.ActiveControl = Nothing
        Me.mtLogs.Location = New System.Drawing.Point(232, 22)
        Me.mtLogs.Name = "mtLogs"
        Me.mtLogs.Size = New System.Drawing.Size(430, 201)
        Me.mtLogs.Style = MetroFramework.MetroColorStyle.Orange
        Me.mtLogs.TabIndex = 6
        Me.mtLogs.Text = "Procesos de sincronización"
        Me.mtLogs.TileImage = Global.SyncBDManager.My.Resources.Resources.sync
        Me.mtLogs.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.mtLogs.UseSelectable = True
        Me.mtLogs.UseTileImage = True
        '
        'mtConfiguracion
        '
        Me.mtConfiguracion.ActiveControl = Nothing
        Me.mtConfiguracion.Location = New System.Drawing.Point(21, 22)
        Me.mtConfiguracion.Name = "mtConfiguracion"
        Me.mtConfiguracion.Size = New System.Drawing.Size(205, 312)
        Me.mtConfiguracion.TabIndex = 5
        Me.mtConfiguracion.Text = "Configurar sincronizador"
        Me.mtConfiguracion.TileImage = Global.SyncBDManager.My.Resources.Resources.Sincro
        Me.mtConfiguracion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtConfiguracion.UseSelectable = True
        Me.mtConfiguracion.UseTileImage = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 435)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.Resizable = False
        Me.Text = "Bienvenido al Administrador de SyncBD"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mtServicio As MetroFramework.Controls.MetroTile
    Friend WithEvents mtLogs As MetroFramework.Controls.MetroTile
    Friend WithEvents mtConfiguracion As MetroFramework.Controls.MetroTile
End Class
