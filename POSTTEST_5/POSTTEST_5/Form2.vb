Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_mbti")


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Sub TampilData()

        Try
            Dim da As New MySqlDataAdapter("SELECT * FROM guild", conn)
            Dim dt As New DataTable

            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Bersih()

        txtNamaGuild.Clear()
        txtLeader.Clear()
        txtRank.Clear()

        txtNamaGuild.Focus()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Try
            conn.Open()

            Dim sql As String =
            "INSERT INTO guild(nama_guild,leader,rank_guild)
             VALUES(@nama,@leader,@rank)"

            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@nama", txtNamaGuild.Text)
            cmd.Parameters.AddWithValue("@leader", txtLeader.Text)
            cmd.Parameters.AddWithValue("@rank", txtRank.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Guild berhasil ditambahkan")

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
            "UPDATE guild SET
            nama_guild=@nama,
            leader=@leader,
            rank_guild=@rank
            WHERE id_guild=@id"

            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@nama", txtNamaGuild.Text)
            cmd.Parameters.AddWithValue("@leader", txtLeader.Text)
            cmd.Parameters.AddWithValue("@rank", txtRank.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Guild berhasil diupdate")

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
            If MessageBox.Show("Yakin hapus guild?", "Konfirmasi",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then

                conn.Open()

                Dim sql As String =
                "DELETE FROM guild WHERE id_guild=@id"

                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@id",
                DataGridView1.CurrentRow.Cells(0).Value)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Guild berhasil dihapus")

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
            "SELECT * FROM guild WHERE nama_guild LIKE '%" &
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

            txtNamaGuild.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtLeader.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtRank.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        End If

    End Sub

End Class
