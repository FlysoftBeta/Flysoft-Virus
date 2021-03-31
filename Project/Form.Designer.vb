<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.NetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MsgBoxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DialogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShutdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'NetTimer
        '
        Me.NetTimer.Interval = 5000
        '
        'MsgBoxTimer
        '
        Me.MsgBoxTimer.Enabled = True
        Me.MsgBoxTimer.Interval = 2000
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "需要执行操作。"
        Me.NotifyIcon.Visible = True
        '
        'DialogTimer
        '
        Me.DialogTimer.Enabled = True
        Me.DialogTimer.Interval = 10000
        '
        'ShutdownTimer
        '
        Me.ShutdownTimer.Enabled = True
        Me.ShutdownTimer.Interval = 180000
        '
        'Form
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Private components As System.ComponentModel.IContainer
    Friend WithEvents NetTimer As System.Windows.Forms.Timer
    Friend WithEvents MsgBoxTimer As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents DialogTimer As System.Windows.Forms.Timer
    Friend WithEvents ShutdownTimer As System.Windows.Forms.Timer

End Class
