<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashbord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashbord))
        MenuStrip1 = New MenuStrip()
        TestToolStripMenuItem = New ToolStripMenuItem()
        MahasiswaToolStripMenuItem = New ToolStripMenuItem()
        InputNilaiToolStripMenuItem = New ToolStripMenuItem()
        DataMahasiswaToolStripMenuItem = New ToolStripMenuItem()
        DaftarkanToolStripMenuItem = New ToolStripMenuItem()
        CbSearch = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtNamaLengkap = New TextBox()
        TxtNpm = New TextBox()
        TxtJenisKelamin = New TextBox()
        GroupBox1 = New GroupBox()
        TxtNilaiFinalTest = New TextBox()
        TxtNilaiMidTest = New TextBox()
        TxtNilaiTatapMuka = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        BtEdit = New Button()
        BtDelete = New Button()
        Label8 = New Label()
        TxtNilaiAkhir = New TextBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TestToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(574, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TestToolStripMenuItem
        ' 
        TestToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MahasiswaToolStripMenuItem})
        TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        TestToolStripMenuItem.Size = New Size(46, 24)
        TestToolStripMenuItem.Text = "File"
        ' 
        ' MahasiswaToolStripMenuItem
        ' 
        MahasiswaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InputNilaiToolStripMenuItem, DataMahasiswaToolStripMenuItem})
        MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        MahasiswaToolStripMenuItem.Size = New Size(164, 26)
        MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        ' 
        ' InputNilaiToolStripMenuItem
        ' 
        InputNilaiToolStripMenuItem.Name = "InputNilaiToolStripMenuItem"
        InputNilaiToolStripMenuItem.Size = New Size(200, 26)
        InputNilaiToolStripMenuItem.Text = "Input Nilai"
        ' 
        ' DataMahasiswaToolStripMenuItem
        ' 
        DataMahasiswaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DaftarkanToolStripMenuItem})
        DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        DataMahasiswaToolStripMenuItem.Size = New Size(200, 26)
        DataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        ' 
        ' DaftarkanToolStripMenuItem
        ' 
        DaftarkanToolStripMenuItem.Name = "DaftarkanToolStripMenuItem"
        DaftarkanToolStripMenuItem.Size = New Size(157, 26)
        DaftarkanToolStripMenuItem.Text = "Daftarkan"
        ' 
        ' CbSearch
        ' 
        CbSearch.DropDownStyle = ComboBoxStyle.DropDownList
        CbSearch.ForeColor = Color.Black
        CbSearch.FormattingEnabled = True
        CbSearch.Location = New Point(84, 46)
        CbSearch.Name = "CbSearch"
        CbSearch.Size = New Size(278, 28)
        CbSearch.TabIndex = 3
        CbSearch.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 4
        Label1.Text = "Search"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 6
        Label2.Text = "Nama Lengkap:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 7
        Label3.Text = "NPM:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 20)
        Label4.TabIndex = 8
        Label4.Text = "Jenis Kelamin:"
        ' 
        ' TxtNamaLengkap
        ' 
        TxtNamaLengkap.BorderStyle = BorderStyle.FixedSingle
        TxtNamaLengkap.Enabled = False
        TxtNamaLengkap.ImeMode = ImeMode.NoControl
        TxtNamaLengkap.Location = New Point(143, 110)
        TxtNamaLengkap.Name = "TxtNamaLengkap"
        TxtNamaLengkap.Size = New Size(396, 27)
        TxtNamaLengkap.TabIndex = 9
        ' 
        ' TxtNpm
        ' 
        TxtNpm.BorderStyle = BorderStyle.FixedSingle
        TxtNpm.Enabled = False
        TxtNpm.Location = New Point(143, 153)
        TxtNpm.Name = "TxtNpm"
        TxtNpm.Size = New Size(396, 27)
        TxtNpm.TabIndex = 10
        ' 
        ' TxtJenisKelamin
        ' 
        TxtJenisKelamin.BorderStyle = BorderStyle.FixedSingle
        TxtJenisKelamin.Enabled = False
        TxtJenisKelamin.Location = New Point(143, 198)
        TxtJenisKelamin.Name = "TxtJenisKelamin"
        TxtJenisKelamin.Size = New Size(396, 27)
        TxtJenisKelamin.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtNilaiAkhir)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TxtNilaiFinalTest)
        GroupBox1.Controls.Add(TxtNilaiMidTest)
        GroupBox1.Controls.Add(TxtNilaiTatapMuka)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Font = New Font("Segoe UI", 9F)
        GroupBox1.ForeColor = SystemColors.ControlDarkDark
        GroupBox1.Location = New Point(11, 253)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(552, 164)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rincian Nilai"
        ' 
        ' TxtNilaiFinalTest
        ' 
        TxtNilaiFinalTest.BorderStyle = BorderStyle.FixedSingle
        TxtNilaiFinalTest.Enabled = False
        TxtNilaiFinalTest.Location = New Point(132, 119)
        TxtNilaiFinalTest.Name = "TxtNilaiFinalTest"
        TxtNilaiFinalTest.PlaceholderText = "  Siswa Belum Memiliki Nilai"
        TxtNilaiFinalTest.Size = New Size(219, 27)
        TxtNilaiFinalTest.TabIndex = 18
        ' 
        ' TxtNilaiMidTest
        ' 
        TxtNilaiMidTest.BorderStyle = BorderStyle.FixedSingle
        TxtNilaiMidTest.Enabled = False
        TxtNilaiMidTest.Location = New Point(132, 76)
        TxtNilaiMidTest.Name = "TxtNilaiMidTest"
        TxtNilaiMidTest.PlaceholderText = "  Siswa Belum Memiliki Nilai"
        TxtNilaiMidTest.Size = New Size(396, 27)
        TxtNilaiMidTest.TabIndex = 17
        ' 
        ' TxtNilaiTatapMuka
        ' 
        TxtNilaiTatapMuka.BorderStyle = BorderStyle.FixedSingle
        TxtNilaiTatapMuka.Enabled = False
        TxtNilaiTatapMuka.Location = New Point(132, 35)
        TxtNilaiTatapMuka.Name = "TxtNilaiTatapMuka"
        TxtNilaiTatapMuka.PlaceholderText = "  Siswa Belum Memiliki Nilai"
        TxtNilaiTatapMuka.Size = New Size(396, 27)
        TxtNilaiTatapMuka.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(14, 122)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 20)
        Label7.TabIndex = 15
        Label7.Text = "Final Test:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(14, 79)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 20)
        Label6.TabIndex = 14
        Label6.Text = "Mid Test:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(14, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 14
        Label5.Text = "Tatap Muka:"
        ' 
        ' BtEdit
        ' 
        BtEdit.BackColor = Color.LightGray
        BtEdit.Cursor = Cursors.Hand
        BtEdit.Enabled = False
        BtEdit.FlatAppearance.BorderColor = Color.Silver
        BtEdit.FlatStyle = FlatStyle.Flat
        BtEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtEdit.ForeColor = SystemColors.ControlText
        BtEdit.Image = CType(resources.GetObject("BtEdit.Image"), Image)
        BtEdit.ImageAlign = ContentAlignment.MiddleLeft
        BtEdit.Location = New Point(368, 46)
        BtEdit.Name = "BtEdit"
        BtEdit.Size = New Size(75, 28)
        BtEdit.TabIndex = 14
        BtEdit.Text = "Edit"
        BtEdit.UseVisualStyleBackColor = False
        ' 
        ' BtDelete
        ' 
        BtDelete.BackColor = Color.LightGray
        BtDelete.Cursor = Cursors.Hand
        BtDelete.Enabled = False
        BtDelete.FlatAppearance.BorderColor = Color.Silver
        BtDelete.FlatStyle = FlatStyle.Flat
        BtDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtDelete.ForeColor = SystemColors.ControlText
        BtDelete.Image = CType(resources.GetObject("BtDelete.Image"), Image)
        BtDelete.ImageAlign = ContentAlignment.MiddleLeft
        BtDelete.Location = New Point(449, 46)
        BtDelete.Name = "BtDelete"
        BtDelete.Size = New Size(90, 28)
        BtDelete.TabIndex = 15
        BtDelete.Text = "Delete"
        BtDelete.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(357, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 20)
        Label8.TabIndex = 19
        Label8.Text = "Nilai Akhir:"
        ' 
        ' TxtNilaiAkhir
        ' 
        TxtNilaiAkhir.Enabled = False
        TxtNilaiAkhir.Location = New Point(438, 119)
        TxtNilaiAkhir.MaxLength = 3
        TxtNilaiAkhir.Name = "TxtNilaiAkhir"
        TxtNilaiAkhir.Size = New Size(90, 27)
        TxtNilaiAkhir.TabIndex = 20
        ' 
        ' FrmDashbord
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(574, 427)
        Controls.Add(BtDelete)
        Controls.Add(BtEdit)
        Controls.Add(GroupBox1)
        Controls.Add(TxtJenisKelamin)
        Controls.Add(TxtNpm)
        Controls.Add(TxtNamaLengkap)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CbSearch)
        Controls.Add(MenuStrip1)
        MaximizeBox = False
        Name = "FrmDashbord"
        Text = "Dashbord"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputNilaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbSearch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNamaLengkap As TextBox
    Friend WithEvents TxtNpm As TextBox
    Friend WithEvents TxtJenisKelamin As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNilaiFinalTest As TextBox
    Friend WithEvents TxtNilaiMidTest As TextBox
    Friend WithEvents TxtNilaiTatapMuka As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtEdit As Button
    Friend WithEvents BtDelete As Button
    Friend WithEvents TxtNilaiAkhir As TextBox
    Friend WithEvents Label8 As Label

End Class
