Imports System.Security.Policy

Public Class about
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/tereyagburak/terepad")
    End Sub
End Class