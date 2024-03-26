Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmInputNilai
    Private Nilai As New Nilai()
    Public Property NilaiProperty As Nilai
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' InputChecked
        AddHandler TxtKehadiran.TextChanged, AddressOf InputChecked
        AddHandler TxtPertemuan.TextChanged, AddressOf InputChecked
        AddHandler TxtNilaiMidTest.TextChanged, AddressOf InputChecked
        AddHandler TxtNilaiFinalTest.TextChanged, AddressOf InputChecked
        ' Search
        AddHandler CbSearch.TextChanged, AddressOf EnableTextIfSearch

        ' KeyboardValidation
        AddHandler TxtKehadiran.KeyPress, AddressOf KeyboardValidation
        AddHandler TxtPertemuan.KeyPress, AddressOf KeyboardValidation
        AddHandler TxtNilaiMidTest.KeyPress, AddressOf KeyboardValidation
        AddHandler TxtNilaiFinalTest.KeyPress, AddressOf KeyboardValidation

    End Sub

    Private Sub KeyboardValidation(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EnableTextIfSearch(sender As Object, e As EventArgs)
        Dim allInputsValid As Boolean = Not String.IsNullOrWhiteSpace(CbSearch.Text)

        ' Enable/disable TextBox based on search input validity
        TxtNilaiFinalTest.Enabled = allInputsValid
        TxtNilaiMidTest.Enabled = allInputsValid
        TxtPertemuan.Enabled = allInputsValid

        ' If any input is invalid, reset input
        If Not allInputsValid Then
            ResetInput()
        End If
    End Sub

    Private Sub TxtPertemuan_Leave(sender As Object, e As EventArgs) Handles TxtPertemuan.TextChanged
        Dim allInputsValid As Boolean = Not String.IsNullOrWhiteSpace(TxtPertemuan.Text)

        ' Enable/disable TextBox based on search input validity
        TxtKehadiran.Enabled = allInputsValid
    End Sub

    Private Sub TxtKehadiranLeave(sender As Object, e As EventArgs) Handles TxtKehadiran.Leave
        ValidateKehadiran()
    End Sub

    Private Sub ValidateKehadiran()
        If Not String.IsNullOrWhiteSpace(TxtPertemuan.Text) Then
            Dim kehadiran As Integer
            Dim pertemuan As Integer

            If Integer.TryParse(TxtKehadiran.Text, kehadiran) AndAlso Integer.TryParse(TxtPertemuan.Text, pertemuan) Then
                If kehadiran > pertemuan Then
                    MessageBox.Show("Jumlah kehadiran tidak boleh lebih besar dari jumlah pertemuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ' Mengembalikan fokus ke TxtKehadiran agar pengguna dapat memperbaiki masukan
                    TxtKehadiran.Focus()
                End If
            Else
                MessageBox.Show("Masukkan angka yang valid untuk kehadiran dan pertemuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Mengembalikan fokus ke TxtKehadiran agar pengguna dapat memperbaiki masukan
                TxtKehadiran.Focus()
            End If
        End If
    End Sub



    Private Sub InputChecked(sender As Object, e As EventArgs)
        Dim allInputsValid As Boolean = True

        If String.IsNullOrWhiteSpace(TxtKehadiran.Text) OrElse
           String.IsNullOrWhiteSpace(TxtPertemuan.Text) OrElse
           String.IsNullOrWhiteSpace(TxtNilaiFinalTest.Text) OrElse
           String.IsNullOrWhiteSpace(TxtNilaiMidTest.Text) Then
            allInputsValid = False
        End If

        ' Enable/disable button based on validation status
        BtNilai.Enabled = allInputsValid

        ' If all inputs are valid, generate the description
        If allInputsValid Then
            generateKeterangan()
            implementNilaiAkhir()
        End If
    End Sub


    Private Function GenerateNilaiKehadiran(pertemuan As Double, kehadiran As Double)
        Dim hasil As Double = (kehadiran / pertemuan) * 100

        Return hasil
    End Function

    Private Function GenerateNilaiAkhir(nilaiKehadiran As Double, nilaiMidTest As Double, nilaiFinalTest As Double)
        Dim hasil As Double = (nilaiKehadiran + nilaiMidTest + nilaiFinalTest) / 3

        Return hasil
    End Function

    Private Function ListOfMahasiswa() As List(Of Mahasiswa)
        Dim mahasiswa As Mahasiswa = New Mahasiswa
        Dim mahasiswas As List(Of Mahasiswa) = mahasiswa.GetMahasiswasWithNoNilai()

        Return mahasiswas
    End Function

    Private Sub implementNilaiAkhir()
        Dim nilaiKehadiran As Double = GenerateNilaiKehadiran(Double.Parse(TxtPertemuan.Text), Double.Parse(TxtKehadiran.Text))
        Dim nilai As Double = GenerateNilaiAkhir(nilaiKehadiran, Double.Parse(TxtNilaiMidTest.Text), Double.Parse(TxtNilaiFinalTest.Text))

        Dim formattedNilai As String = nilai.ToString("0.0")
        TxtNilaiAkhir.Text = formattedNilai
    End Sub

    Private Sub generateKeterangan()
        Dim keterangan As String = ""
        Dim nilaiKehadiran As Double = GenerateNilaiKehadiran(Double.Parse(TxtPertemuan.Text), Double.Parse(TxtKehadiran.Text))
        Dim nilai As Integer = GenerateNilaiAkhir(nilaiKehadiran, Double.Parse(TxtNilaiMidTest.Text), Double.Parse(TxtNilaiFinalTest.Text))

        If nilai >= 90 Then
            keterangan = "Lulus dengan nilai sangat tinggi."
        ElseIf nilai >= 70 Then
            keterangan = "Lulus dengan nilai cukup tinggi."
        Else
            keterangan = "Tidak lulus."
        End If

        LabelKeterangan.Text = "*" & keterangan
    End Sub

    Private Sub LoadSearch(sender As Object, e As EventArgs) Handles CbSearch.MouseClick
        Dim items As List(Of Mahasiswa) = ListOfMahasiswa()

        If CbSearch.Items.Count > 0 Then
            CbSearch.Items.Clear()
            CbSearch.ResetText()
        End If

        Dim comboItems As New List(Of ComboBoxItem)()

        For Each item In items
            Dim displayText As String = $"{item.Npm} - {item.Fullname}"
            Dim comboItem As New ComboBoxItem(displayText, item.Id)
            comboItems.Add(comboItem)
        Next

        CbSearch.Items.AddRange(comboItems.ToArray())
    End Sub

    Public Sub ResetInput()
        TxtKehadiran.Text = String.Empty
        TxtPertemuan.Text = String.Empty
        TxtNilaiFinalTest.Text = String.Empty
        TxtNilaiMidTest.Text = String.Empty
        TxtNilaiAkhir.Text = String.Empty
        LabelKeterangan.Text = "*Keterangan"
    End Sub

    Private Sub BerikanNilai(sender As Object, e As MouseEventArgs) Handles BtNilai.MouseClick
        Try
            Dim kehadiran As String = TxtKehadiran.Text
            Dim pertemuan As String = TxtPertemuan.Text
            Dim midTest As String = TxtNilaiMidTest.Text
            Dim finalTest As String = TxtNilaiFinalTest.Text
            Dim mahasiswaId As Integer = GetMahasiswaId()
            Dim confirmation As DialogResult = MessageBox.Show("Perhatian: Nilai yang dimasukkan adalah nilai akhir siswa dan hanya diperbolehkan memberikan nilai sekali kepada setiap siswa." & vbCrLf & $"Apakah nilai yang Anda berikan kepada siswa {CbSearch.Text} sudah sesuai?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then
                Dim Nilai As New Nilai() With {.MahasiswaId = mahasiswaId, .BanyakPertemuan = pertemuan, .Kehadiran = kehadiran, .MidTest = midTest, .FinalTest = finalTest}
                Nilai.AddNilai(Nilai)
                MessageBox.Show("Berhasil Memberikan Siswa Nilai", "Berhasil", MessageBoxButtons.OK)
            End If

            CloseDialog()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CloseDialog()
        Me.Close()
    End Sub

    Private Function GetMahasiswaId() As String
        Dim selectedId As Integer = -1
        If CbSearch.SelectedItem IsNot Nothing Then
            Dim selectedItem As ComboBoxItem = DirectCast(CbSearch.SelectedItem, ComboBoxItem)
            selectedId = selectedItem.Id
        End If

        Return selectedId
    End Function
End Class