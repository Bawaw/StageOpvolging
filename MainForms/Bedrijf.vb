Public Class Bedrijf
    Dim SqlManager As New SQLManager

    Private Sub Bedrijf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bindingSource1 As New BindingSource()

        Dim Table As New DataTable

        Table = SqlManager.LoadGrid("bedrijven")

        DataGridView1.DataSource = bindingSource1
        bindingSource1.DataSource = Table
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim field As String, Value As String, ID As Integer

        ID = DataGridView1.CurrentRow.Cells(0).Value.ToString
        field = DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name
        Value = DataGridView1.CurrentCell.Value.ToString

        SqlManager.UpdateData("bedrijven", ID, field, Value)
        RefreshBedrijfData()
    End Sub

    Public Sub RefreshBedrijfData()
        Dim bindingSource1 As New BindingSource()
        Dim Table As New DataTable
        Table = SqlManager.LoadGrid("bedrijven")
        DataGridView1.DataSource = bindingSource1
        bindingSource1.DataSource = Table
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Size = New Size(Me.Size.Width, Me.Size.Height + 180)
        BedrijfToevoegen.TopLevel = False
        BedrijfToevoegen.Dock = DockStyle.Fill
        Panel1.Controls.Add(BedrijfToevoegen)
        BedrijfToevoegen.Show()
        Button2.Visible = False
    End Sub

    Private Sub Toevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toevoegen.Click
        SqlManager.DeleteRow("bedrijven", DataGridView1.CurrentRow.Cells(0).Value.ToString)
        RefreshBedrijfData()
    End Sub
End Class