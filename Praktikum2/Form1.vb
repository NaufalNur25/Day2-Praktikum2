Public Class FrmDashbord
    Private Sub DaftarkanSiswa(sender As Object, e As EventArgs) Handles DaftarkanToolStripMenuItem.Click
        Dim form2 As New FrmInputMahasiswa(Nothing)
        form2.ShowDialog()
    End Sub

    Private Sub InputNilai(sender As Object, e As EventArgs) Handles InputNilaiToolStripMenuItem.Click
        Dim form3 As New FrmInputNilai
        form3.ShowDialog()
    End Sub

    Private Sub EditMahasiswa(sender As Object, e As MouseEventArgs) Handles BtEdit.MouseClick
        Dim mahasiswa As Mahasiswa = PersonalData(GetMahasiswaId())

        If mahasiswa IsNot Nothing Then
            Dim newForm As New FrmInputMahasiswa(mahasiswa)

            newForm.ShowDialog()
        Else
            MessageBox.Show("Data mahasiswa tidak tersedia.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteMahasiswa(sender As Object, e As MouseEventArgs) Handles BtDelete.MouseClick
        Try
            Dim confirmation As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then
                Dim Id As Integer = GetMahasiswaId()

                Dim mahasiswa As New Mahasiswa() With {.Id = Id}
                mahasiswa.DeleteMahasiswa(Id)

                ClearDashboard()
                MessageBox.Show("Berhasil Menghapus Data Siswa", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub InputChecked(sender As Object, e As EventArgs) Handles CbSearch.TextChanged
        Dim allInputsValid As Boolean = Not String.IsNullOrWhiteSpace(CbSearch.Text)

        ' Button Delete 
        With BtDelete
            .Enabled = allInputsValid
            .BackColor = If(allInputsValid, Color.Coral, Color.LightGray)
        End With

        ' Button Edit
        With BtEdit
            .Enabled = allInputsValid
            .BackColor = If(allInputsValid, Color.DeepSkyBlue, Color.LightGray)
        End With
    End Sub

    Private Function ListOfMahasiswa() As List(Of Mahasiswa)
        Dim mahasiswa As Mahasiswa = New Mahasiswa
        Dim mahasiswas As List(Of Mahasiswa) = mahasiswa.GetMahasiswas()

        Return mahasiswas
    End Function

    Private Function GenerateNilaiKehadiran(pertemuan As Double, kehadiran As Double)
        Dim hasil As Double = (kehadiran / pertemuan) * 100

        Return hasil
    End Function

    Private Function GenerateNilaiAkhir(nilaiKehadiran As Double, nilaiMidTest As Double, nilaiFinalTest As Double)
        Dim hasil As Double = (nilaiKehadiran + nilaiMidTest + nilaiFinalTest) / 3

        Return hasil
    End Function

    Private Function implementNilaiAkhir()
        Dim nilai As Nilai = NilaiSiswa(GetMahasiswaId())
        Dim nilaiKehadiran As Double = GenerateNilaiKehadiran(Double.Parse(nilai.BanyakPertemuan), Double.Parse(nilai.Kehadiran))
        Dim jumlahNilaiAkhir As Integer = GenerateNilaiAkhir(nilaiKehadiran, Double.Parse(nilai.MidTest), Double.Parse(nilai.FinalTest))

        Return jumlahNilaiAkhir
    End Function

    Private Function PersonalData(id As Integer) As Mahasiswa
        Dim mahasiswa As Mahasiswa = New Mahasiswa()
        Return mahasiswa.GetMahasiswaById(id)
    End Function

    Private Function NilaiSiswa(mahasiswaId As Integer) As Nilai
        Dim nilai As Nilai = New Nilai()
        Return nilai.GetNilaiByMahasiswaId(mahasiswaId)
    End Function

    Private Sub Search(sender As Object, e As EventArgs) Handles CbSearch.TextChanged
        Dim mahasiswa As Mahasiswa = PersonalData(GetMahasiswaId())
        Dim nilai As Nilai = NilaiSiswa(GetMahasiswaId())

        If mahasiswa IsNot Nothing Then
            TxtNamaLengkap.Text = "  " & mahasiswa.Fullname
            TxtNpm.Text = "  " & mahasiswa.Npm
            TxtJenisKelamin.Text = "  " & mahasiswa.JenisKelamin
        End If

        If nilai IsNot Nothing Then
            TxtNilaiTatapMuka.Text = "  " & Integer.Parse(nilai.Kehadiran) & $" dari {nilai.BanyakPertemuan} Pertemuan"
            TxtNilaiMidTest.Text = "  " & Integer.Parse(nilai.MidTest)
            TxtNilaiFinalTest.Text = "  " & Integer.Parse(nilai.FinalTest)
            TxtNilaiAkhir.Text = "  " & Integer.Parse(implementNilaiAkhir())
        Else
            TxtNilaiTatapMuka.Text = "  Siswa Belum Memiliki Nilai"
            TxtNilaiMidTest.Text = "  Siswa Belum Memiliki Nilai"
            TxtNilaiFinalTest.Text = "  Siswa Belum Memiliki Nilai"
            TxtNilaiAkhir.Text = ""
        End If

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


    Private Function GetMahasiswaId() As String
        Dim selectedId As Integer = -1
        If CbSearch.SelectedItem IsNot Nothing Then
            Dim selectedItem As ComboBoxItem = DirectCast(CbSearch.SelectedItem, ComboBoxItem)
            selectedId = selectedItem.Id
        End If

        Return selectedId
    End Function

    Private Sub ClearDashboard()
        TxtNamaLengkap.Text = ""
        TxtNpm.Text = ""
        TxtJenisKelamin.Text = ""
        TxtNilaiTatapMuka.Text = "  Siswa Belum Memiliki Nilai"
        TxtNilaiMidTest.Text = "  Siswa Belum Memiliki Nilai"
        TxtNilaiFinalTest.Text = "  Siswa Belum Memiliki Nilai"
        TxtNilaiAkhir.Text = "-"
        CbSearch.SelectedIndex = -1
    End Sub
End Class
