Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.BackColor = ColorDialog1.Color 'Arkaplan Rengini ColorDialog1 Atıyoruz.
        RichTextBox1.ForeColor = ColorDialog2.Color 'Yazı Rengini ColorDialog2 Atıyoruz.
        RichTextBox1.Font = FontDialog1.Font 'Font Stilini FontDialog1 Atıyoruz.
    End Sub

    Private Sub ArkaplanRengiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArkaplanRengiToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub YazıRengiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YazıRengiToolStripMenuItem.Click
        If ColorDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog2.Color
        End If
    End Sub

    Private Sub YazıStiliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YazıStiliToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub YeniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniToolStripMenuItem.Click
        If RichTextBox1.Text = "" Then
            RichTextBox1.Enabled = True
        Else
            If MsgBox("Yeni bir sayfa eski yazınızı silecektir devam etmek istiyor musunuz?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                RichTextBox1.Clear()
                RichTextBox1.Enabled = True
                ColorDialog1.Color = Color.White
                ColorDialog2.Color = Color.Black
                FontDialog1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End If
        End If
    End Sub

    Private Sub AçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AçToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        open.Title = "Not Defteri Dosya Aç"
        open.Filter = "Notepad Dosyası (*.ntp)|*.ntp"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub KaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaydetToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        save.Title = "Not Defteri Dosya Kaydet"
        save.Filter = "Notepad Dosyası (*.ntp)|*.ntp"

        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        End
    End Sub

    Private Sub SaatEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaatEkleToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Sub

    Private Sub TarihEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarihEkleToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & " " & Now.Day & "." & Now.Month & "." & Now.Year
    End Sub

    Private Sub TemizleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemizleToolStripMenuItem.Click
        If MsgBox("Tüm belge silinecek emin misiniz?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RichTextBox1.Clear()
        End If
    End Sub
End Class
