Imports System.Runtime.InteropServices
Imports System.Security.Policy

Public Class about
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/tereyagburak/terepad")
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(40, 36, 36)
        Try
            EnableDarkMode(Me.Handle, True)
        Catch ex As Exception
            Label5.Visible = True
            Return
            'ARAP AHMET AMK SESE BAK https://cdn.discordapp.com/attachments/1276782442510024714/1300722404817113108/tursu.mp3?ex=6721dfa3&is=67208e23&hm=d5e791bff1a4ef04239ca357ade04fc8eae4f9863d8ec3c1492866ccd9a9208e&
        End Try
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

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/drwellss")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://github.com/StereoLuigi99/")
    End Sub
End Class