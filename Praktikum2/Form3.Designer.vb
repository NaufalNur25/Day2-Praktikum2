<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInputNilai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        TxtKehadiran = New TextBox()
        TxtPertemuan = New TextBox()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        LabelKeterangan = New Label()
        Label5 = New Label()
        TxtNilaiAkhir = New TextBox()
        TxtNilaiFinalTest = New TextBox()
        TxtNilaiMidTest = New TextBox()
        CbSearch = New ComboBox()
        BtNilai = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Siswa:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 1
        Label2.Text = "Banyak Pertemuan:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mid Test:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(280, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 3
        Label4.Text = "Final Test:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtKehadiran)
        GroupBox1.Controls.Add(TxtPertemuan)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(38, 68)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(546, 93)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Kehadiran"
        ' 
        ' TxtKehadiran
        ' 
        TxtKehadiran.Enabled = False
        TxtKehadiran.Location = New Point(393, 32)
        TxtKehadiran.MaxLength = 2
        TxtKehadiran.Name = "TxtKehadiran"
        TxtKehadiran.Size = New Size(140, 27)
        TxtKehadiran.TabIndex = 5
        TxtKehadiran.TabStop = False
        ' 
        ' TxtPertemuan
        ' 
        TxtPertemuan.Enabled = False
        TxtPertemuan.Location = New Point(155, 32)
        TxtPertemuan.MaxLength = 2
        TxtPertemuan.Name = "TxtPertemuan"
        TxtPertemuan.PlaceholderText = "Persemester"
        TxtPertemuan.Size = New Size(147, 27)
        TxtPertemuan.TabIndex = 4
        TxtPertemuan.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(308, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 20)
        Label6.TabIndex = 2
        Label6.Text = "Kehadiran:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(LabelKeterangan)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TxtNilaiAkhir)
        GroupBox2.Controls.Add(TxtNilaiFinalTest)
        GroupBox2.Controls.Add(TxtNilaiMidTest)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(38, 167)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(546, 152)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Nilai"
        ' 
        ' LabelKeterangan
        ' 
        LabelKeterangan.AutoSize = True
        LabelKeterangan.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LabelKeterangan.ForeColor = Color.DarkGray
        LabelKeterangan.Location = New Point(280, 98)
        LabelKeterangan.Name = "LabelKeterangan"
        LabelKeterangan.Size = New Size(99, 20)
        LabelKeterangan.TabIndex = 10
        LabelKeterangan.Text = "*Keterangan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 9
        Label5.Text = "Nilai Akhir:"
        ' 
        ' TxtNilaiAkhir
        ' 
        TxtNilaiAkhir.Enabled = False
        TxtNilaiAkhir.Location = New Point(112, 95)
        TxtNilaiAkhir.MaxLength = 3
        TxtNilaiAkhir.Name = "TxtNilaiAkhir"
        TxtNilaiAkhir.Size = New Size(155, 27)
        TxtNilaiAkhir.TabIndex = 8
        TxtNilaiAkhir.TabStop = False
        ' 
        ' TxtNilaiFinalTest
        ' 
        TxtNilaiFinalTest.Enabled = False
        TxtNilaiFinalTest.Location = New Point(377, 42)
        TxtNilaiFinalTest.MaxLength = 3
        TxtNilaiFinalTest.Name = "TxtNilaiFinalTest"
        TxtNilaiFinalTest.Size = New Size(155, 27)
        TxtNilaiFinalTest.TabIndex = 7
        TxtNilaiFinalTest.TabStop = False
        ' 
        ' TxtNilaiMidTest
        ' 
        TxtNilaiMidTest.Enabled = False
        TxtNilaiMidTest.Location = New Point(112, 42)
        TxtNilaiMidTest.MaxLength = 3
        TxtNilaiMidTest.Name = "TxtNilaiMidTest"
        TxtNilaiMidTest.Size = New Size(155, 27)
        TxtNilaiMidTest.TabIndex = 6
        TxtNilaiMidTest.TabStop = False
        ' 
        ' CbSearch
        ' 
        CbSearch.FormattingEnabled = True
        CbSearch.Location = New Point(195, 25)
        CbSearch.Name = "CbSearch"
        CbSearch.Size = New Size(375, 28)
        CbSearch.TabIndex = 6
        ' 
        ' BtNilai
        ' 
        BtNilai.Location = New Point(38, 340)
        BtNilai.Name = "BtNilai"
        BtNilai.Size = New Size(546, 51)
        BtNilai.TabIndex = 7
        BtNilai.Text = "Berikan Siswa Nilai"
        BtNilai.UseVisualStyleBackColor = True
        ' 
        ' FrmInputNilai
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 406)
        Controls.Add(BtNilai)
        Controls.Add(CbSearch)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmInputNilai"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "Nilai"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtKehadiran As TextBox
    Friend WithEvents TxtPertemuan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNilaiFinalTest As TextBox
    Friend WithEvents TxtNilaiMidTest As TextBox
    Friend WithEvents CbSearch As ComboBox
    Friend WithEvents BtNilai As Button
    Friend WithEvents LabelKeterangan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNilaiAkhir As TextBox
End Class
