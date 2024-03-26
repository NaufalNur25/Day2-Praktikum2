<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInputMahasiswa
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TxtNamaLengkap = New TextBox()
        TxtNpm = New TextBox()
        CbJenisKelamin = New ComboBox()
        CbProgramStudi = New ComboBox()
        TxtKelas = New TextBox()
        TxtEmail = New TextBox()
        DateTimeTanggalLahir = New DateTimePicker()
        BtDaftarkan = New Button()
        CheckBoxIsActive = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 0
        Label1.Text = "*Nama Lengkap:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 20)
        Label2.TabIndex = 1
        Label2.Text = "*Jenis Kelamin:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 2
        Label3.Text = "*Program Studi:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 3
        Label4.Text = "*Kelas:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 4
        Label5.Text = "*Tanggal Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(58, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 5
        Label6.Text = "Email:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(533, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 20)
        Label7.TabIndex = 13
        Label7.Text = "*NPM:"
        ' 
        ' TxtNamaLengkap
        ' 
        TxtNamaLengkap.CharacterCasing = CharacterCasing.Upper
        TxtNamaLengkap.Location = New Point(174, 27)
        TxtNamaLengkap.Name = "TxtNamaLengkap"
        TxtNamaLengkap.Size = New Size(353, 27)
        TxtNamaLengkap.TabIndex = 6
        ' 
        ' TxtNpm
        ' 
        TxtNpm.Location = New Point(589, 27)
        TxtNpm.MaxLength = 9
        TxtNpm.Name = "TxtNpm"
        TxtNpm.Size = New Size(161, 27)
        TxtNpm.TabIndex = 7
        ' 
        ' CbJenisKelamin
        ' 
        CbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList
        CbJenisKelamin.FormattingEnabled = True
        CbJenisKelamin.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        CbJenisKelamin.Location = New Point(174, 81)
        CbJenisKelamin.Name = "CbJenisKelamin"
        CbJenisKelamin.Size = New Size(576, 28)
        CbJenisKelamin.TabIndex = 8
        ' 
        ' CbProgramStudi
        ' 
        CbProgramStudi.DropDownStyle = ComboBoxStyle.DropDownList
        CbProgramStudi.FormattingEnabled = True
        CbProgramStudi.Items.AddRange(New Object() {"S1 - TEKNIK INFORMATIKA", "S1 - SISTEM INFORMASI", "D4 - KOMPUTERISASI AKUNTANSI", "D3 - KOMPUTERISASI AKUNTANSI", "D4 - MANAJEMEN INFORMATIKA", "D4 - SISTEM KOMPUTER"})
        CbProgramStudi.Location = New Point(174, 147)
        CbProgramStudi.Name = "CbProgramStudi"
        CbProgramStudi.Size = New Size(576, 28)
        CbProgramStudi.TabIndex = 9
        ' 
        ' TxtKelas
        ' 
        TxtKelas.CharacterCasing = CharacterCasing.Upper
        TxtKelas.Location = New Point(174, 204)
        TxtKelas.Name = "TxtKelas"
        TxtKelas.Size = New Size(576, 27)
        TxtKelas.TabIndex = 10
        ' 
        ' TxtEmail
        ' 
        TxtEmail.CharacterCasing = CharacterCasing.Upper
        TxtEmail.Location = New Point(174, 319)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(576, 27)
        TxtEmail.TabIndex = 12
        ' 
        ' DateTimeTanggalLahir
        ' 
        DateTimeTanggalLahir.Location = New Point(174, 257)
        DateTimeTanggalLahir.Name = "DateTimeTanggalLahir"
        DateTimeTanggalLahir.Size = New Size(576, 27)
        DateTimeTanggalLahir.TabIndex = 11
        ' 
        ' BtDaftarkan
        ' 
        BtDaftarkan.Enabled = False
        BtDaftarkan.Location = New Point(50, 404)
        BtDaftarkan.Name = "BtDaftarkan"
        BtDaftarkan.Size = New Size(700, 52)
        BtDaftarkan.TabIndex = 14
        BtDaftarkan.Text = "Daftarkan"
        BtDaftarkan.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxIsActive
        ' 
        CheckBoxIsActive.AutoSize = True
        CheckBoxIsActive.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBoxIsActive.ForeColor = SystemColors.ButtonShadow
        CheckBoxIsActive.Location = New Point(55, 374)
        CheckBoxIsActive.Name = "CheckBoxIsActive"
        CheckBoxIsActive.Size = New Size(164, 24)
        CheckBoxIsActive.TabIndex = 15
        CheckBoxIsActive.Text = "*adalah siswa aktif?"
        CheckBoxIsActive.UseVisualStyleBackColor = True
        ' 
        ' FrmInputMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(796, 477)
        Controls.Add(CheckBoxIsActive)
        Controls.Add(BtDaftarkan)
        Controls.Add(Label7)
        Controls.Add(TxtEmail)
        Controls.Add(DateTimeTanggalLahir)
        Controls.Add(TxtKelas)
        Controls.Add(CbProgramStudi)
        Controls.Add(CbJenisKelamin)
        Controls.Add(TxtNpm)
        Controls.Add(TxtNamaLengkap)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmInputMahasiswa"
        RightToLeft = RightToLeft.No
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNamaLengkap As TextBox
    Friend WithEvents TxtNpm As TextBox
    Friend WithEvents CbJenisKelamin As ComboBox
    Friend WithEvents CbProgramStudi As ComboBox
    Friend WithEvents TxtKelas As TextBox
    Friend WithEvents DateTimeTanggalLahir As DateTimePicker
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtDaftarkan As Button
    Friend WithEvents CheckBoxIsActive As CheckBox

End Class
