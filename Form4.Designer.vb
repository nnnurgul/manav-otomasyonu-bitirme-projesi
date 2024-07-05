<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class anaform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(anaform))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ÜRÜNEKLEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GüncelleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜRÜNGÜNCELLEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatışİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KASİYEREKLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniPersonelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HESAPDEFTERİToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇIKIŞToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜRÜNEKLEToolStripMenuItem1, Me.ÜRÜNGÜNCELLEToolStripMenuItem1, Me.KASİYEREKLEToolStripMenuItem, Me.HESAPDEFTERİToolStripMenuItem, Me.ÇIKIŞToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 31)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ÜRÜNEKLEToolStripMenuItem1
        '
        Me.ÜRÜNEKLEToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GüncelleToolStripMenuItem1})
        Me.ÜRÜNEKLEToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ÜRÜNEKLEToolStripMenuItem1.Name = "ÜRÜNEKLEToolStripMenuItem1"
        Me.ÜRÜNEKLEToolStripMenuItem1.Size = New System.Drawing.Size(130, 27)
        Me.ÜRÜNEKLEToolStripMenuItem1.Text = "ÜRÜN TANIM"
        '
        'GüncelleToolStripMenuItem1
        '
        Me.GüncelleToolStripMenuItem1.Name = "GüncelleToolStripMenuItem1"
        Me.GüncelleToolStripMenuItem1.Size = New System.Drawing.Size(240, 28)
        Me.GüncelleToolStripMenuItem1.Text = "Ekle,Güncelle ve Sil"
        '
        'ÜRÜNGÜNCELLEToolStripMenuItem1
        '
        Me.ÜRÜNGÜNCELLEToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SatışİşlemleriToolStripMenuItem})
        Me.ÜRÜNGÜNCELLEToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ÜRÜNGÜNCELLEToolStripMenuItem1.Name = "ÜRÜNGÜNCELLEToolStripMenuItem1"
        Me.ÜRÜNGÜNCELLEToolStripMenuItem1.Size = New System.Drawing.Size(119, 27)
        Me.ÜRÜNGÜNCELLEToolStripMenuItem1.Text = "ÜRÜN SATIŞ"
        '
        'SatışİşlemleriToolStripMenuItem
        '
        Me.SatışİşlemleriToolStripMenuItem.Name = "SatışİşlemleriToolStripMenuItem"
        Me.SatışİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.SatışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri"
        '
        'KASİYEREKLEToolStripMenuItem
        '
        Me.KASİYEREKLEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniPersonelToolStripMenuItem})
        Me.KASİYEREKLEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KASİYEREKLEToolStripMenuItem.Name = "KASİYEREKLEToolStripMenuItem"
        Me.KASİYEREKLEToolStripMenuItem.Size = New System.Drawing.Size(130, 27)
        Me.KASİYEREKLEToolStripMenuItem.Text = "KASİYER EKLE"
        '
        'YeniPersonelToolStripMenuItem
        '
        Me.YeniPersonelToolStripMenuItem.Name = "YeniPersonelToolStripMenuItem"
        Me.YeniPersonelToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.YeniPersonelToolStripMenuItem.Text = "Yeni Kasiyer"
        '
        'HESAPDEFTERİToolStripMenuItem
        '
        Me.HESAPDEFTERİToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HESAPDEFTERİToolStripMenuItem.Name = "HESAPDEFTERİToolStripMenuItem"
        Me.HESAPDEFTERİToolStripMenuItem.Size = New System.Drawing.Size(86, 27)
        Me.HESAPDEFTERİToolStripMenuItem.Text = "GEÇMİŞ"
        '
        'ÇIKIŞToolStripMenuItem
        '
        Me.ÇIKIŞToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ÇIKIŞToolStripMenuItem.Name = "ÇIKIŞToolStripMenuItem"
        Me.ÇIKIŞToolStripMenuItem.Size = New System.Drawing.Size(64, 27)
        Me.ÇIKIŞToolStripMenuItem.Text = "ÇIKIŞ"
        '
        'anaform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 525)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "anaform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HESAPDEFTERİToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KASİYEREKLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇIKIŞToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜRÜNEKLEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents YeniPersonelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GüncelleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ÜRÜNGÜNCELLEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SatışİşlemleriToolStripMenuItem As ToolStripMenuItem
End Class
