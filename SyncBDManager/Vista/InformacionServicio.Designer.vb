<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionServicio
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
        Me.mlblEstatus = New MetroFramework.Controls.MetroLabel()
        Me.mlvLog = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lvLog = New System.Windows.Forms.ListView()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mlblEstatus
        '
        Me.mlblEstatus.AutoSize = True
        Me.mlblEstatus.BackColor = System.Drawing.Color.White
        Me.mlblEstatus.ForeColor = System.Drawing.Color.Red
        Me.mlblEstatus.Location = New System.Drawing.Point(46, 60)
        Me.mlblEstatus.Name = "mlblEstatus"
        Me.mlblEstatus.Size = New System.Drawing.Size(329, 19)
        Me.mlblEstatus.TabIndex = 1
        Me.mlblEstatus.Text = "El servicio de sincronización esta actualmente detenido"
        Me.mlblEstatus.UseCustomForeColor = True
        '
        'mlvLog
        '
        Me.mlvLog.AutoSize = True
        Me.mlvLog.Location = New System.Drawing.Point(46, 86)
        Me.mlvLog.Name = "mlvLog"
        Me.mlvLog.Size = New System.Drawing.Size(101, 19)
        Me.mlvLog.TabIndex = 3
        Me.mlvLog.Text = "Log del servicio"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.lvLog)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(46, 108)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(670, 304)
        Me.MetroPanel1.TabIndex = 4
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'lvLog
        '
        Me.lvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLog.Location = New System.Drawing.Point(0, 0)
        Me.lvLog.Name = "lvLog"
        Me.lvLog.Size = New System.Drawing.Size(670, 304)
        Me.lvLog.TabIndex = 3
        Me.lvLog.UseCompatibleStateImageBehavior = False
        '
        'InformacionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 435)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.mlvLog)
        Me.Controls.Add(Me.mlblEstatus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InformacionServicio"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Informacion del Servicio de Sincronización"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mlblEstatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlvLog As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lvLog As ListView
End Class
