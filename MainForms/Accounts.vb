Public Class Accounts
    Dim sqlManager As SQLManager = New SQLManager
    Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bindingSource1 As New BindingSource()

        Dim Table As New DataTable

        Select Case UserData.Authority
            Case 2
                Table = sqlManager.LoadDoubleFilteredData("accounts", "TA", "0", "Administrator", "0")
            Case 3
                Table = sqlManager.LoadGrid("accounts")
            Case Else
        End Select

        DataGridView1.DataSource = bindingSource1
        bindingSource1.DataSource = Table
        DataGridView1.Columns(0).Visible = False
        'DataGridView1.Item(1, 1) = New DataGridViewComboBoxCell

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim field As String, Value As String, ID As Integer

        ID = DataGridView1.CurrentRow.Cells(0).Value.ToString
        field = DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name
        Value = DataGridView1.CurrentCell.Value.ToString

        sqlManager.UpdateData("accounts", ID, field, Value)
        RefreshAcountsData()
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlManager.DeleteRow("accounts", DataGridView1.CurrentRow.Cells(0).Value.ToString)
        RefreshAcountsData()
    End Sub

    Public Sub RefreshAcountsData()
        Dim bindingSource1 As New BindingSource()
        Dim Table As New DataTable
        Table = sqlManager.LoadGrid("accounts")
        DataGridView1.DataSource = bindingSource1
        bindingSource1.DataSource = Table
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Size = New Size(Me.Width, Me.Height + 100)
        Me.Button2.Location = New Point(Me.Button2.Location.X, Me.Button2.Location.Y + 100)

        AccountToevoegen.TopLevel = False
        AccountToevoegen.Dock = DockStyle.Fill
        Panel1.Controls.Add(AccountToevoegen)
        AccountToevoegen.Show()
        Button2.Visible = False
    End Sub

End Class
