Imports System.Net.Http
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json.Linq ' JSON parsing için Newtonsoft.Json kullanıyoruz

Public Class AIPrompter
    ' Çıktı boşken gösterilecek mesaj
    Private Const EmptyOutputMessage As String = "Çıktı boş. İnternet bağlantınızı kontrol ettiniz mi?"

    ' HttpClient global tanımlıyoruz
    Private ReadOnly client As New HttpClient()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim texticerik As String = Form1.metinbox.Text()
        Dim cevirilentext As String = ""

        cevirilentext = texticerik & " " & alinanprompt.Text()

        Form1.metinbox.Text() = cevirilentext

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

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Kullanıcıdan alınan mesajı al
        Dim userMessage As String = verilenprompt.Text.Trim()

        ' API'ye istek gönder ve yanıtı al
        Dim responseMessage As String = Await SendMessageToAPI(userMessage)

        ' API yanıtını alinanprompt TextBox'ına yaz
        alinanprompt.Text = responseMessage

        ' Butonları etkinleştir
        Button1.Enabled = True
        Button2.Enabled = True
        alinanprompt.Enabled = True
    End Sub

    Private Async Function SendMessageToAPI(prompt As String) As Task(Of String)
        ' API adresi
        Dim apiUrl As String = String.Format("https://www.msii.xyz/api/cevir?yazi={0}&dil=en", Uri.EscapeDataString(prompt))

        ' API'ye GET isteği gönder
        Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

        ' Yanıt başarılı ise
        If response.IsSuccessStatusCode Then
            ' JSON yanıtını al
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

            ' JSON'dan "ceviri" alanını çıkart
            Return ExtractResponseFromJson(jsonResponse)
        Else
            Return "Hata: API yanıt vermedi. Durum Kodu: " & response.StatusCode.ToString()
        End If
    End Function

    ' JSON yanıtını işleyen fonksiyon
    Private Function ExtractResponseFromJson(json As String) As String
        Try
            Dim jsonObject As JObject = JObject.Parse(json)
            Return jsonObject("ceviri").ToString() ' "ceviri" alanını al
        Catch ex As Exception
            Return "Hata: JSON çözümleme başarısız oldu."
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' alinanprompt içeriğini panoya kopyala
        Dim panola As String = alinanprompt.Text
        Clipboard.SetText(panola)
    End Sub

    Private Sub AIPrompter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDarkMode(Me.Handle, True)
    End Sub
End Class
