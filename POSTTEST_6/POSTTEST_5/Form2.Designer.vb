<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents txtNamaGuild As TextBox
    Friend WithEvents txtLeader As TextBox
    Friend WithEvents txtRank As TextBox
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button

    Friend WithEvents DataGridView1 As DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNamaGuild = New TextBox()
        txtLeader = New TextBox()
        txtRank = New TextBox()
        txtSearch = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        btnRefresh = New Button()
        btnSearch = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "Nama Guild"
        ' 
        ' Label2
        ' 
        Label2.ForeColor = Color.White
        Label2.Location = New Point(30, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 1
        Label2.Text = "Leader"
        ' 
        ' Label3
        ' 
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 2
        Label3.Text = "Rank Guild"
        ' 
        ' Label4
        ' 
        Label4.ForeColor = Color.White
        Label4.Location = New Point(384, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 3
        Label4.Text = "Search"
        ' 
        ' txtNamaGuild
        ' 
        txtNamaGuild.Location = New Point(140, 30)
        txtNamaGuild.Name = "txtNamaGuild"
        txtNamaGuild.Size = New Size(220, 31)
        txtNamaGuild.TabIndex = 4
        ' 
        ' txtLeader
        ' 
        txtLeader.Location = New Point(140, 80)
        txtLeader.Name = "txtLeader"
        txtLeader.Size = New Size(220, 31)
        txtLeader.TabIndex = 5
        ' 
        ' txtRank
        ' 
        txtRank.Location = New Point(140, 130)
        txtRank.Name = "txtRank"
        txtRank.Size = New Size(220, 31)
        txtRank.TabIndex = 6
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(490, 20)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(220, 31)
        txtSearch.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnTambah.Location = New Point(30, 220)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(90, 35)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnEdit.Location = New Point(130, 220)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(90, 35)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnHapus.Location = New Point(230, 220)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(90, 35)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnRefresh.Location = New Point(330, 220)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 35)
        btnRefresh.TabIndex = 11
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnSearch.Location = New Point(730, 18)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(80, 28)
        btnSearch.TabIndex = 12
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeight = 34
        DataGridView1.Location = New Point(420, 60)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(540, 500)
        DataGridView1.TabIndex = 13
        ' 
        ' Form2
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(166), CByte(79), CByte(81))
        ClientSize = New Size(1000, 600)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtNamaGuild)
        Controls.Add(txtLeader)
        Controls.Add(txtRank)
        Controls.Add(txtSearch)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(DataGridView1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DATA GUILD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

End Class
