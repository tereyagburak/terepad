<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dosyasekme = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.kaydetDosya = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtokayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuNedirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AIPrompteriAçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TümünüPanoyaKopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarihVeSaatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörünümToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YazıTipiVeBoyotunuDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolasYazıTipineGeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltBarıGizleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerepadBetaV03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerepadHakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.metinbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.durumL = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.YapışkanNotlarModuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dosyasekme, Me.DüzenleToolStripMenuItem, Me.GörünümToolStripMenuItem, Me.TerepadBetaV03ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 437)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'dosyasekme
        '
        Me.dosyasekme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem1, Me.kaydetDosya, Me.YeniToolStripMenuItem, Me.OtokayıtToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.dosyasekme.Name = "dosyasekme"
        Me.dosyasekme.Size = New System.Drawing.Size(51, 20)
        Me.dosyasekme.Text = "Dosya"
        '
        'AçToolStripMenuItem1
        '
        Me.AçToolStripMenuItem1.Name = "AçToolStripMenuItem1"
        Me.AçToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AçToolStripMenuItem1.Text = "Aç"
        '
        'kaydetDosya
        '
        Me.kaydetDosya.Name = "kaydetDosya"
        Me.kaydetDosya.Size = New System.Drawing.Size(180, 22)
        Me.kaydetDosya.Text = "Kaydet"
        '
        'YeniToolStripMenuItem
        '
        Me.YeniToolStripMenuItem.Name = "YeniToolStripMenuItem"
        Me.YeniToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YeniToolStripMenuItem.Text = "Yeni"
        '
        'OtokayıtToolStripMenuItem
        '
        Me.OtokayıtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem, Me.KapatToolStripMenuItem, Me.BuNedirToolStripMenuItem})
        Me.OtokayıtToolStripMenuItem.Name = "OtokayıtToolStripMenuItem"
        Me.OtokayıtToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OtokayıtToolStripMenuItem.Text = "Otokayıt"
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AçToolStripMenuItem.Text = "Aç"
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Enabled = False
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.KapatToolStripMenuItem.Text = "Kapat"
        '
        'BuNedirToolStripMenuItem
        '
        Me.BuNedirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.BuNedirToolStripMenuItem.Name = "BuNedirToolStripMenuItem"
        Me.BuNedirToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.BuNedirToolStripMenuItem.Text = "Bu nedir?"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(720, 22)
        Me.ToolStripMenuItem1.Text = "Yaptığınız bütün değişiklikleri otomatik olarak kayıt eden bir özellik. Yapılan d" &
    "eğişiklikler harfi harfine dosyaya kaydedilecek."
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'DüzenleToolStripMenuItem
        '
        Me.DüzenleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AIPrompteriAçToolStripMenuItem, Me.TümünüPanoyaKopyalaToolStripMenuItem, Me.TarihVeSaatiToolStripMenuItem, Me.AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem})
        Me.DüzenleToolStripMenuItem.Name = "DüzenleToolStripMenuItem"
        Me.DüzenleToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DüzenleToolStripMenuItem.Text = "Düzenle"
        '
        'AIPrompteriAçToolStripMenuItem
        '
        Me.AIPrompteriAçToolStripMenuItem.Name = "AIPrompteriAçToolStripMenuItem"
        Me.AIPrompteriAçToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AIPrompteriAçToolStripMenuItem.Text = "Çeviriciyi aç"
        '
        'TümünüPanoyaKopyalaToolStripMenuItem
        '
        Me.TümünüPanoyaKopyalaToolStripMenuItem.Name = "TümünüPanoyaKopyalaToolStripMenuItem"
        Me.TümünüPanoyaKopyalaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TümünüPanoyaKopyalaToolStripMenuItem.Text = "Tümünü panoya kopyala"
        '
        'TarihVeSaatiToolStripMenuItem
        '
        Me.TarihVeSaatiToolStripMenuItem.Name = "TarihVeSaatiToolStripMenuItem"
        Me.TarihVeSaatiToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TarihVeSaatiToolStripMenuItem.Text = "Tarih ve saati işle"
        '
        'AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem
        '
        Me.AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem.Name = "AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem"
        Me.AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem.Text = "Hesap Makinesi"
        '
        'GörünümToolStripMenuItem
        '
        Me.GörünümToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YazıTipiVeBoyotunuDeğiştirToolStripMenuItem, Me.ConsolasYazıTipineGeçToolStripMenuItem, Me.AltBarıGizleToolStripMenuItem, Me.YapışkanNotlarModuToolStripMenuItem})
        Me.GörünümToolStripMenuItem.Name = "GörünümToolStripMenuItem"
        Me.GörünümToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GörünümToolStripMenuItem.Text = "Görünüm"
        '
        'YazıTipiVeBoyotunuDeğiştirToolStripMenuItem
        '
        Me.YazıTipiVeBoyotunuDeğiştirToolStripMenuItem.Name = "YazıTipiVeBoyotunuDeğiştirToolStripMenuItem"
        Me.YazıTipiVeBoyotunuDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.YazıTipiVeBoyotunuDeğiştirToolStripMenuItem.Text = "Yazı tipi ve boyutunu değiştir"
        '
        'ConsolasYazıTipineGeçToolStripMenuItem
        '
        Me.ConsolasYazıTipineGeçToolStripMenuItem.Name = "ConsolasYazıTipineGeçToolStripMenuItem"
        Me.ConsolasYazıTipineGeçToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.ConsolasYazıTipineGeçToolStripMenuItem.Text = "Varsayılan Consolas yazı tipine geç"
        '
        'AltBarıGizleToolStripMenuItem
        '
        Me.AltBarıGizleToolStripMenuItem.Name = "AltBarıGizleToolStripMenuItem"
        Me.AltBarıGizleToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.AltBarıGizleToolStripMenuItem.Text = "AltBar'ı gizle"
        '
        'TerepadBetaV03ToolStripMenuItem
        '
        Me.TerepadBetaV03ToolStripMenuItem.AutoToolTip = True
        Me.TerepadBetaV03ToolStripMenuItem.Checked = True
        Me.TerepadBetaV03ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TerepadBetaV03ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerepadHakkındaToolStripMenuItem})
        Me.TerepadBetaV03ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TerepadBetaV03ToolStripMenuItem.Name = "TerepadBetaV03ToolStripMenuItem"
        Me.TerepadBetaV03ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.TerepadBetaV03ToolStripMenuItem.Text = "Yardım"
        '
        'TerepadHakkındaToolStripMenuItem
        '
        Me.TerepadHakkındaToolStripMenuItem.Name = "TerepadHakkındaToolStripMenuItem"
        Me.TerepadHakkındaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TerepadHakkındaToolStripMenuItem.Text = "terepad Hakkında"
        '
        'metinbox
        '
        Me.metinbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metinbox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.metinbox.ForeColor = System.Drawing.Color.White
        Me.metinbox.Location = New System.Drawing.Point(-5, -2)
        Me.metinbox.MaxLength = 9999999
        Me.metinbox.Multiline = True
        Me.metinbox.Name = "metinbox"
        Me.metinbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.metinbox.Size = New System.Drawing.Size(909, 439)
        Me.metinbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(747, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bu dosyada 0 karakter."
        '
        'durumL
        '
        Me.durumL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.durumL.AutoSize = True
        Me.durumL.BackColor = System.Drawing.Color.Transparent
        Me.durumL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.durumL.Location = New System.Drawing.Point(290, 440)
        Me.durumL.Name = "durumL"
        Me.durumL.Size = New System.Drawing.Size(71, 15)
        Me.durumL.TabIndex = 3
        Me.durumL.Text = "Hey! Naber?"
        '
        'YapışkanNotlarModuToolStripMenuItem
        '
        Me.YapışkanNotlarModuToolStripMenuItem.Name = "YapışkanNotlarModuToolStripMenuItem"
        Me.YapışkanNotlarModuToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.YapışkanNotlarModuToolStripMenuItem.Text = "Yapışkan Notlar Modu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.durumL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.metinbox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Form1"
        Me.Text = "terepad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents dosyasekme As ToolStripMenuItem
    Friend WithEvents kaydetDosya As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DüzenleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AIPrompteriAçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TümünüPanoyaKopyalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GörünümToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YazıTipiVeBoyotunuDeğiştirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents metinbox As TextBox
    Friend WithEvents TerepadBetaV03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarihVeSaatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TerepadHakkındaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnlıkDolarTLHesaplamasınıMetneGeçirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtokayıtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuNedirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsolasYazıTipineGeçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents durumL As Label
    Friend WithEvents AçToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AltBarıGizleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YapışkanNotlarModuToolStripMenuItem As ToolStripMenuItem
End Class
