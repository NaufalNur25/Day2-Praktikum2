Imports System.Data.SQLite

Public Class Nilai
    Public Property Id As Integer
    Public Property MahasiswaId As Integer
    Public Property BanyakPertemuan As Integer
    Public Property Kehadiran As Integer
    Public Property MidTest As Double
    Public Property FinalTest As Double

    Private connectionString As String = "Data Source=D:\Pembelajaran Desktop\day2\Praktikum2\Praktikum2\Database\database.db;Version=3;"

    Public Sub AddNilai(nilai As Nilai)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO nilai (mahasiswa_id, banyak_pertemuan, kehadiran, mid_test, final_test) VALUES (@MahasiswaId, @BanyakPertemuan, @Kehadiran, @MidTest, @FinalTest)"
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@MahasiswaId", nilai.MahasiswaId)
                command.Parameters.AddWithValue("@BanyakPertemuan", nilai.BanyakPertemuan)
                command.Parameters.AddWithValue("@Kehadiran", nilai.Kehadiran)
                command.Parameters.AddWithValue("@MidTest", nilai.MidTest)
                command.Parameters.AddWithValue("@FinalTest", nilai.FinalTest)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetNilais() As List(Of Nilai)
        Dim nilais As New List(Of Nilai)()
        Dim sql As String = "SELECT * FROM nilai"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(sql, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim nilai As New Nilai()
                        nilai.Id = Convert.ToInt32(reader("id"))
                        nilai.MahasiswaId = reader.GetInt32(reader.GetOrdinal("id_mahasiswa"))
                        nilai.BanyakPertemuan = reader.GetInt32(reader.GetOrdinal("banyak_pertemuan"))
                        nilai.Kehadiran = reader.GetInt32(reader.GetOrdinal("kehadiran"))
                        nilai.MidTest = reader.GetDouble(reader.GetOrdinal("mid_test"))
                        nilai.FinalTest = reader.GetDouble(reader.GetOrdinal("final_test"))
                        nilais.Add(nilai)
                    End While
                End Using
            End Using
        End Using
        Return nilais
    End Function

    Public Function GetNilaiByMahasiswaId(id As Integer) As Nilai
        Dim nilai As Nilai = Nothing
        Dim sql As String = "SELECT * FROM nilai WHERE mahasiswa_id = @Id LIMIT 1"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@Id", id)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        nilai = New Nilai() With {
                                .Id = Convert.ToInt32(reader("id")),
                                .BanyakPertemuan = Convert.ToInt16(reader("banyak_pertemuan")),
                                .Kehadiran = Convert.ToInt16(reader("kehadiran")),
                                .MidTest = Convert.ToDouble(reader("mid_test")),
                                .FinalTest = Convert.ToDouble(reader("final_test"))
                              }
                    End If
                End Using
            End Using
        End Using

        Return nilai
    End Function
End Class
