Imports System.Data.SQLite

Public Class Mahasiswa
    Public Property Id As Integer
    Public Property Fullname As String
    Public Property Npm As String
    Public Property JenisKelamin As String
    Public Property ProgramStudi As String
    Public Property Kelas As String
    Public Property TanggalLahir As String
    Public Property Email As String
    Public Property IsActive As Boolean

    Private connectionString As String = "Data Source=D:\Pembelajaran Desktop\day2\Praktikum2\Praktikum2\Database\database.db;Version=3;"

    Public Sub AddMahasiswa(mahasiswa As Mahasiswa)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO mahasiswa (fullname, npm, jenis_kelamin, program_studi, kelas, tanggal_lahir, email, is_active) VALUES (@Fullname, @Npm, @JenisKelamin, @ProgramStudi, @Kelas, @TanggalLahir, @Email, @IsActive)"
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@Fullname", mahasiswa.Fullname)
                command.Parameters.AddWithValue("@Npm", mahasiswa.Npm)
                command.Parameters.AddWithValue("@JenisKelamin", mahasiswa.JenisKelamin)
                command.Parameters.AddWithValue("@ProgramStudi", mahasiswa.ProgramStudi)
                command.Parameters.AddWithValue("@Kelas", mahasiswa.Kelas)
                command.Parameters.AddWithValue("@TanggalLahir", mahasiswa.TanggalLahir)
                command.Parameters.AddWithValue("@Email", mahasiswa.Email)
                command.Parameters.AddWithValue("@IsActive", mahasiswa.IsActive)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateMahasiswa(mahasiswa As Mahasiswa)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim sql As String = "UPDATE mahasiswa SET fullname = @Fullname, npm = @Npm, jenis_kelamin = @JenisKelamin, program_studi = @ProgramStudi, kelas = @Kelas, tanggal_lahir = @TanggalLahir, email = @Email, is_active = @IsActive WHERE id = @Id"
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@Fullname", mahasiswa.Fullname)
                command.Parameters.AddWithValue("@Npm", mahasiswa.Npm)
                command.Parameters.AddWithValue("@JenisKelamin", mahasiswa.JenisKelamin)
                command.Parameters.AddWithValue("@ProgramStudi", mahasiswa.ProgramStudi)
                command.Parameters.AddWithValue("@Kelas", mahasiswa.Kelas)
                command.Parameters.AddWithValue("@TanggalLahir", mahasiswa.TanggalLahir)
                command.Parameters.AddWithValue("@Email", mahasiswa.Email)
                command.Parameters.AddWithValue("@IsActive", mahasiswa.IsActive)
                command.Parameters.AddWithValue("@Id", mahasiswa.Id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteMahasiswa(mahasiswaId As Integer)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM mahasiswa WHERE id = @Id"
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@Id", mahasiswaId)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetMahasiswas() As List(Of Mahasiswa)
        Dim mahasiswas As New List(Of Mahasiswa)()
        Dim sql As String = "SELECT * FROM mahasiswa"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(sql, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim mahasiswa As New Mahasiswa()
                        mahasiswa.Id = Convert.ToInt32(reader("id"))
                        mahasiswa.Fullname = reader("fullname").ToString()
                        mahasiswa.Npm = reader("npm").ToString()
                        mahasiswa.JenisKelamin = reader("jenis_kelamin").ToString()
                        mahasiswa.ProgramStudi = reader("program_studi").ToString()
                        mahasiswa.Kelas = reader("kelas").ToString()
                        mahasiswa.TanggalLahir = reader("tanggal_lahir").ToString()
                        mahasiswa.Email = reader("email").ToString()
                        mahasiswa.IsActive = Convert.ToBoolean(reader("is_active"))
                        mahasiswas.Add(mahasiswa)
                    End While
                End Using
            End Using
        End Using
        Return mahasiswas
    End Function

    Public Function GetMahasiswaWithNpm(npm As String) As List(Of Mahasiswa)
        Dim mahasiswas As New List(Of Mahasiswa)()
        Dim sql As String = "SELECT * FROM mahasiswa WHERE npm = @Npm"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@Npm", npm)

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim mahasiswa As New Mahasiswa()
                        mahasiswa.Id = Convert.ToInt32(reader("id"))
                        mahasiswa.Fullname = reader("fullname").ToString()
                        mahasiswa.Npm = reader("npm").ToString()
                        mahasiswa.JenisKelamin = reader("jenis_kelamin").ToString()
                        mahasiswa.ProgramStudi = reader("program_studi").ToString()
                        mahasiswa.Kelas = reader("kelas").ToString()
                        mahasiswa.TanggalLahir = reader("tanggal_lahir").ToString()
                        mahasiswa.Email = reader("email").ToString()
                        mahasiswa.IsActive = Convert.ToBoolean(reader("is_active"))
                        mahasiswas.Add(mahasiswa)
                    End While
                End Using
            End Using
        End Using

        Return mahasiswas
    End Function

    Public Function GetMahasiswaById(id As Integer) As Mahasiswa
        Dim mahasiswa As Mahasiswa = Nothing
        Dim sql As String = "SELECT * FROM mahasiswa WHERE id = @Id"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@Id", id)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        mahasiswa = New Mahasiswa() With {
                            .Id = Convert.ToInt32(reader("id")),
                            .Fullname = Convert.ToString(reader("fullname")),
                            .Npm = Convert.ToString(reader("npm")),
                            .JenisKelamin = Convert.ToString(reader("jenis_kelamin")),
                            .ProgramStudi = Convert.ToString(reader("program_studi")),
                            .Kelas = Convert.ToString(reader("kelas")),
                            .TanggalLahir = Convert.ToString(reader("tanggal_lahir")),
                            .Email = Convert.ToString(reader("email")),
                            .IsActive = Convert.ToBoolean(reader("is_active"))
                        }
                    End If
                End Using
            End Using
        End Using

        Return mahasiswa
    End Function

    Public Function GetMahasiswasWithNoNilai() As List(Of Mahasiswa)
        Dim mahasiswas As New List(Of Mahasiswa)()

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim sql As String = "SELECT mahasiswa.* FROM mahasiswa LEFT JOIN nilai ON mahasiswa.id = nilai.mahasiswa_id WHERE nilai.mahasiswa_id IS NULL"
            Using command As New SQLiteCommand(sql, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim mahasiswa As New Mahasiswa()
                        mahasiswa.Id = Convert.ToInt32(reader("id"))
                        mahasiswa.Fullname = reader("fullname").ToString()
                        mahasiswa.Npm = reader("npm").ToString()
                        mahasiswa.JenisKelamin = reader("jenis_kelamin").ToString()
                        mahasiswa.ProgramStudi = reader("program_studi").ToString()
                        mahasiswa.Kelas = reader("kelas").ToString()
                        mahasiswa.TanggalLahir = reader("tanggal_lahir").ToString()
                        mahasiswa.Email = reader("email").ToString()
                        mahasiswa.IsActive = Convert.ToBoolean(reader("is_active"))

                        mahasiswas.Add(mahasiswa)
                    End While
                End Using
            End Using
        End Using

        Return mahasiswas
    End Function
End Class
