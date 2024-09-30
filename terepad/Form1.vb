Imports System.IO
Imports System.Security.Cryptography

Public Class Form1
    Dim selectedFilePath As String
    Private Sub IhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dosyasekme.Click

    End Sub

    Private Sub kaydetDosya_Click(sender As Object, e As EventArgs) Handles kaydetDosya.Click
        If otokayit = False Then


            Dim saveFileDialog1 As New SaveFileDialog()

            ' Filtreyi ayarla (Sadece .txt dosyalarını kaydetmek için)
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*"
            saveFileDialog1.Title = "Metni Kaydet"

            ' Kullanıcı 'Kaydet' butonuna tıklarsa
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Dosya yolunu al
                Dim filePath As String = saveFileDialog1.FileName

                ' Dosyaya metni yaz
                Using writer As New StreamWriter(filePath)
                    writer.Write(metinbox.Text)
                End Using

                Dim fileName As String = Path.GetFileName(filePath)

                ' Kaydedildiği mesajını göster
                Me.Text = $"terepad ({fileName})"
                durumL.Text = "Kaydedildi."
            End If
        End If

        If otokayit = True Then
            MessageBox.Show("Otokayıt açıkken bunu yapamazsınız.", "terepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        metinbox.AutoSize = True
    End Sub

    Private Sub YeniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniToolStripMenuItem.Click
        If otokayit = False Then
            metinbox.Clear()
            Me.Text = "terepad - Yeni Yazı Dosyası"
            durumL.Text = "Yeni dosya"
        End If

        If otokayit = True Then
            MessageBox.Show("Otokayıt açıkken bunu yapamazsınız.", "terepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub acDosya_Click(sender As Object, e As EventArgs)
        If otokayit = False Then
            ' OpenFileDialog nesnesini oluştur
            ' OpenFileDialog oluştur
            Dim ofd As New OpenFileDialog()

            ' .txt dosyalarını filtrele
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            ofd.Title = "Bir .txt dosyası seçin"

            ' OpenFileDialog'u göster ve dosya seçimi yapıldıysa devam et
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Dosya yolunu bir değişkene ata
                Dim filePath As String = ofd.FileName

                ' Dosya içeriğini bir değişkene ata
                metinbox.Text = File.ReadAllText(filePath)
                Dim fileName As String = Path.GetFileName(filePath)
                Me.Text = $"terepad: ({fileName})"
                durumL.Text = "Dosya açıldı."
            End If
        End If

        If otokayit = True Then
            MessageBox.Show("Otokayıt açıkken bunu yapamazsınız.", "terepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub YazıTipiVeBoyotunuDeğiştirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazıTipiVeBoyotunuDeğiştirToolStripMenuItem.Click
        ' FontDialog oluştur
        Dim fontDialog As New FontDialog()

        ' FontDialog'u göster ve kullanıcı bir font seçtiyse devam et
        If fontDialog.ShowDialog() = DialogResult.OK Then
            ' TextBox'un fontunu değiştir
            metinbox.Font = fontDialog.Font
            durumL.Text = "Font değiştirildi."
        End If
    End Sub

    Private Sub AIPrompteriAçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AIPrompteriAçToolStripMenuItem.Click
        AIPrompter.Show()
    End Sub

    Private Sub TümünüPanoyaKopyalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TümünüPanoyaKopyalaToolStripMenuItem.Click
        Dim metinkomple As String = metinbox.Text()
        Clipboard.SetText(metinkomple)
        durumL.Text = "Bütün metin panoya kopyalandı."
    End Sub

    Private Sub KaydetToolStripMenuItem_Click(sender As Object, e As EventArgs)
        kaydetcik()
    End Sub

    Private Sub TerepadBetaV03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerepadBetaV03ToolStripMenuItem.Click

    End Sub

    Private Sub KaydetmeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Text = "Kapatılıyor!"
        alreadyPrompted = True
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "terepad - Beta"

        ' Komut satırı argümanlarını al
        Dim args() As String = Environment.GetCommandLineArgs()

        ' Eğer bir dosya argümanı varsa, bu dosyayı aç
        If args.Length > 1 Then
            Dim filePath As String = args(1)

            ' Dosya mevcut mu kontrol et
            If File.Exists(filePath) Then
                Dim fileContent As String = File.ReadAllText(filePath)
                metinbox.Text = fileContent
                Dim fileName As String = Path.GetFileName(filePath)
                Me.Text = $"terepad: ({fileName})"

            End If
        End If
    End Sub

    Private Sub TarihVeSaatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarihVeSaatiToolStripMenuItem.Click
        Dim cevirilentext As String = ""

        cevirilentext = Me.metinbox.Text & " " & DateTime.Now()

        Me.metinbox.Text() = cevirilentext

        metinbox.SelectionStart = metinbox.Text.Length
        metinbox.ScrollToCaret()

    End Sub

    Private Sub kaydetcik()
        If otokayit = False Then
            Dim saveFileDialog1 As New SaveFileDialog()

            ' Filtreyi ayarla (Sadece .txt dosyalarını kaydetmek için)
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*"
            saveFileDialog1.Title = "Metni Kaydet"

            ' Kullanıcı 'Kaydet' butonuna tıklarsa
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Dosya yolunu al
                Dim filePath As String = saveFileDialog1.FileName

                ' Dosyaya metni yaz
                Using writer As New StreamWriter(filePath)
                    writer.Write(metinbox.Text)
                End Using

                Dim fileName As String = Path.GetFileName(filePath)

                ' Kaydedildiği mesajını göster
                durumL.Text = "Kaydedildi!"
            End If
        End If

        If otokayit = True Then
            MessageBox.Show("Otokayıt açıkken bunu yapamazsınız.", "terepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private alreadyPrompted As Boolean = False ' Durum değişkeni

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Eğer kullanıcı daha önce bir uyarı göstermişsek çıkış yapmasına izin verelim
        If alreadyPrompted Then
            Return ' Hiçbir şey yapma, doğrudan çık
        End If

        ' Formun kapanmasını engelle
        e.Cancel = True

        ' Kullanıcıdan onay iste
        Dim result As DialogResult
        Label1.Visible = False
        durumL.Text = "terepad kapatılmak üzere. Dosyayı kaydetmediyseniz değişiklikler kaybolacak."
        result = MessageBox.Show("Çıkmak istediğinizden emin misiniz? Kaydedilmemiş veriler kaybolacak!", "terepad - Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question)




        ' Kullanıcının hangi butona tıkladığını kontrol edelim
        Select Case result
            Case DialogResult.Yes
                alreadyPrompted = True ' Uyarıyı gösterdiğimizi belirt
                Me.Text = "Kapatılıyor!"
                durumL.Text = "terepad kapatıldı."
                Me.Close() ' Formu kapat


            Case DialogResult.No
                ' Hiçbir şey yapma, form kapanmayı iptal eder (e.Cancel = True)
                Label1.Visible = True
                durumL.Text = "Kapatma işlemi iptal edildi!"

        End Select
    End Sub

    Private Sub metinbox_TextChanged(sender As Object, e As EventArgs) Handles metinbox.TextChanged
        karakterbelirt()

        If metinbox.TextLength() > 32000 Then
            durumL.Text = "Metindeki karakterler 32000 değerinden büyük. terepad yavaşlayabilir."
        End If

        If durumL.Text = "Metindeki karakterler 32000 değerinden büyük. terepad yavaşlayabilir." Then
            If metinbox.TextLength() < 32000 Then
                durumL.Text = "Destan mı yazmıştınız?"
            End If
        End If


        If otokayit = True Then
            Using writer As New StreamWriter(filePath)
                writer.Write(metinbox.Text)
            End Using

        End If
    End Sub

    Private Sub TerepadHakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerepadHakkındaToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem.Click
        calcu.Show()
        calcu.Text = "Şu anda hesap makinesi yapmaya üşendiğimden boş bir forma bakıyorsun."
    End Sub


    Dim filePath As String = ""
    Dim otokayit As Boolean = False
    Dim fileName As String = ""

    Private Sub AçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçToolStripMenuItem.Click
        ' OpenFileDialog nesnesini oluştur
        ' OpenFileDialog oluştur
        Dim ofd As New OpenFileDialog()

        ' .txt dosyalarını filtrele
        ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        ofd.Title = "Otokayıt yapılacak dosyayı seçin."

        ' OpenFileDialog'u göster ve dosya seçimi yapıldıysa devam et
        If ofd.ShowDialog() = DialogResult.OK Then
            ' Dosya yolunu bir değişkene ata
            filePath = ofd.FileName
            otokayit = True
            ' Dosya içeriğini bir değişkene ata
            metinbox.Text = File.ReadAllText(filePath)
            Dim fileName As String = Path.GetFileName(filePath)
            Me.Text = $"terepad: ({fileName})"
            durumL.Text = "Otokayıt açık."
            AçToolStripMenuItem.Enabled = False
            KapatToolStripMenuItem.Enabled = True

        End If
    End Sub

    Private Sub karakterbelirt()
        Dim harfSayisi As Integer

        ' TextBox1 içindeki harflerin sayısını değişkene atayın
        harfSayisi = metinbox.Text.Length
        Label1.Text = $"Bu dosyada {harfSayisi} karakter."
    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        otokayit = False
        AçToolStripMenuItem.Enabled = True
        KapatToolStripMenuItem.Enabled = False
        Me.Text = $"terepad"
        durumL.Text = "Otokayıt kapalı."
    End Sub

    Private Sub ConsolasYazıTipineGeçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolasYazıTipineGeçToolStripMenuItem.Click
        ' varsayılan font
        metinbox.Font = New Font("Consolas", 12, FontStyle.Regular)
        durumL.Text = "Consolas 12pt fontuna geçildi."
    End Sub

    Private Sub durumL_Click(sender As Object, e As EventArgs) Handles durumL.Click
        durumL.Text = "Yardıma mı ihtiyacın var?"
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        alreadyPrompted = True
        Application.Exit()
    End Sub

    Private Sub AçToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AçToolStripMenuItem1.Click
        If otokayit = False Then
            ' OpenFileDialog nesnesini oluştur
            ' OpenFileDialog oluştur
            Dim ofd As New OpenFileDialog()

            ' .txt dosyalarını filtrele
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            ofd.Title = "Bir .txt dosyası seçin"

            ' OpenFileDialog'u göster ve dosya seçimi yapıldıysa devam et
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Dosya yolunu bir değişkene ata
                Dim filePath As String = ofd.FileName

                ' Dosya içeriğini bir değişkene ata
                metinbox.Text = File.ReadAllText(filePath)
                Dim fileName As String = Path.GetFileName(filePath)
                Me.Text = $"terepad: ({fileName})"
                durumL.Text = "Dosya açıldı."
            End If
        End If

        If otokayit = True Then
            MessageBox.Show("Otokayıt açıkken bunu yapamazsınız.", "terepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class