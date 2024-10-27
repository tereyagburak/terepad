Imports System.Runtime.InteropServices
Imports System.Security.Policy

Public Class about
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/tereyagburak/terepad")
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(40, 36, 36)
        EnableDarkMode(Me.Handle, True)
    End Sub


    'Başlık çubuğunu karanlık yapan eleman

    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20
    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    Private Sub EnableDarkMode(hwnd As IntPtr, enable As Boolean)
        Dim useDarkMode As Integer = If(enable, 1, 0)
        DwmSetWindowAttribute(hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, useDarkMode, Marshal.SizeOf(useDarkMode))
    End Sub
    'endBaşlık çubuğunu karanlık yapan eleman
    'EnableDarkMode(Me.Handle, True)
End Class