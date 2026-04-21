Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_mbti")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub


    Sub TampilData()
        Try
            Dim da As New MySqlDataAdapter("SELECT * FROM karakter", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub Bersih()
        txtNama.Clear()
        txtUmur.Clear()
        txtGender.Clear()
        txtMBTI.Clear()
        txtKepribadian.Clear()
        txtSkill.Clear()
        txtDeskripsi.Clear()
        txtSearch.Clear()
        txtNama.Focus()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            conn.Open()

            Dim sql As String =
            "INSERT INTO karakter(nama,umur,gender,mbti,kepribadian,skill,deskripsi)
             VALUES(@nama,@umur,@gender,@mbti,@kp,@skill,@desk)"

            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@umur", txtUmur.Text)
            cmd.Parameters.AddWithValue("@gender", txtGender.Text)
            cmd.Parameters.AddWithValue("@mbti", txtMBTI.Text)
            cmd.Parameters.AddWithValue("@kp", txtKepribadian.Text)
            cmd.Parameters.AddWithValue("@skill", txtSkill.Text)
            cmd.Parameters.AddWithValue("@desk", txtDeskripsi.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil ditambahkan")

            conn.Close()

            TampilData()
            Bersih()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            conn.Open()

            Dim sql As String =
            "UPDATE karakter SET
            nama=@nama,
            umur=@umur,
            gender=@gender,
            mbti=@mbti,
            kepribadian=@kp,
            skill=@skill,
            deskripsi=@desk
            WHERE id=@id"

            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@umur", txtUmur.Text)
            cmd.Parameters.AddWithValue("@gender", txtGender.Text)
            cmd.Parameters.AddWithValue("@mbti", txtMBTI.Text)
            cmd.Parameters.AddWithValue("@kp", txtKepribadian.Text)
            cmd.Parameters.AddWithValue("@skill", txtSkill.Text)
            cmd.Parameters.AddWithValue("@desk", txtDeskripsi.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diubah")

            conn.Close()

            TampilData()
            Bersih()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If MessageBox.Show("Yakin hapus data?", "Konfirmasi",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then

                conn.Open()

                Dim sql As String = "DELETE FROM karakter WHERE id=@id"

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Data berhasil dihapus")

                conn.Close()

                TampilData()
                Bersih()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim da As New MySqlDataAdapter(
            "SELECT * FROM karakter WHERE nama LIKE '%" &
            txtSearch.Text &
            "%' OR mbti LIKE '%" &
            txtSearch.Text & "%'", conn)

            Dim dt As New DataTable
            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TampilData()
        Bersih()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object,
    e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then

            txtNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtUmur.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtGender.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            txtMBTI.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            txtKepribadian.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            txtSkill.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            txtDeskripsi.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value

        End If

    End Sub

End Class
