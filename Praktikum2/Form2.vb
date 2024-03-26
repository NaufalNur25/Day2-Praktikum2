Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmInputMahasiswa
    Private Mahasiswa As New Mahasiswa()
    Public Property PersonalData As Mahasiswa

    Public Sub New(ByVal PersonalData As Mahasiswa)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' InputChecked
        AddHandler TxtNamaLengkap.TextChanged, AddressOf InputChecked
        AddHandler TxtNpm.TextChanged, AddressOf InputChecked
        AddHandler TxtKelas.TextChanged, AddressOf InputChecked
        AddHandler CbJenisKelamin.TextChanged, AddressOf InputChecked
        AddHandler CbProgramStudi.TextChanged, AddressOf InputChecked
        AddHandler DateTimeTanggalLahir.TextChanged, AddressOf InputChecked

        ' KeyboardValidation
        AddHandler TxtNpm.KeyPress, AddressOf KeyboardValidation

        ' ProsesEdit
        If PersonalData IsNot Nothing Then
            Me.PersonalData = PersonalData

            ' EditableContent
            TxtNamaLengkap.Text = PersonalData.Fullname
            TxtNpm.Text = PersonalData.Npm
            TxtKelas.Text = PersonalData.Kelas
            CbJenisKelamin.SelectedItem = PersonalData.JenisKelamin
            CbProgramStudi.SelectedItem = PersonalData.ProgramStudi
            DateTimeTanggalLahir.Value = DateTime.Parse(PersonalData.TanggalLahir)
            TxtEmail.Text = PersonalData.Email
            CheckBoxIsActive.Checked = PersonalData.IsActive

            ' MscAttribute
            Me.Text = PersonalData.Fullname
            BtDaftarkan.Text = "Ubah Data Mahasiswa"
        End If

    End Sub

    Private Sub KeyboardValidation(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChecked(sender As Object, e As EventArgs)
        Dim allInputsValid As Boolean = True

        ' Check if all required inputs are filled
        If String.IsNullOrWhiteSpace(TxtNamaLengkap.Text) Then
            allInputsValid = False
        End If

        If String.IsNullOrWhiteSpace(TxtNpm.Text) Then
            allInputsValid = False
        End If

        If String.IsNullOrWhiteSpace(TxtKelas.Text) Then
            allInputsValid = False
        End If

        If CbJenisKelamin.SelectedIndex = -1 Then
            allInputsValid = False
        End If

        If CbProgramStudi.SelectedIndex = -1 Then
            allInputsValid = False
        End If

        BtDaftarkan.Enabled = allInputsValid
    End Sub

    Private Sub Daftarkan(sender As Object, e As MouseEventArgs) Handles BtDaftarkan.MouseClick
        Try
            Dim FullName As String = TxtNamaLengkap.Text
            Dim Npm As String = TxtNpm.Text
            Dim JenisKelamin As String = CbJenisKelamin.Text
            Dim ProgramStudi As String = CbProgramStudi.Text
            Dim Kelas As String = TxtKelas.Text
            Dim TanggalLahir As String = DateTimeTanggalLahir.Text
            Dim Email As String = TxtEmail.Text
            Dim IsActive As Boolean = CheckBoxIsActive.Checked

            If PersonalData IsNot Nothing Then
                Dim Id As Integer = PersonalData.Id
                Dim Mahasiswa As New Mahasiswa() With {.Id = Id, .Fullname = FullName, .Npm = Npm, .JenisKelamin = JenisKelamin, .ProgramStudi = ProgramStudi, .Kelas = Kelas, .TanggalLahir = TanggalLahir, .Email = Email, .IsActive = IsActive}
                Mahasiswa.UpdateMahasiswa(Mahasiswa)
                MessageBox.Show("Berhasil Mengubah Data Siswa", "Berhasil", MessageBoxButtons.OK)
            Else
                Dim Mahasiswa As New Mahasiswa() With {.Fullname = FullName, .Npm = Npm, .JenisKelamin = JenisKelamin, .ProgramStudi = ProgramStudi, .Kelas = Kelas, .TanggalLahir = TanggalLahir, .Email = Email, .IsActive = IsActive}
                Mahasiswa.AddMahasiswa(Mahasiswa)
                MessageBox.Show("Berhasil Mendaftarkan Siswa", "Berhasil", MessageBoxButtons.OK)
            End If

            CloseDialog()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CloseDialog()
        Me.Close()
    End Sub
End Class