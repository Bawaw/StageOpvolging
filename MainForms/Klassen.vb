Public Class Klassen
    Dim sqlManager As SQLManager = New SQLManager
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KlasEditor.Show()

        KlasEditor.TopLevel = False
        KlasEditor.Dock = DockStyle.Fill
        Panel1.Controls.Add(KlasEditor)
        Button1.Visible = False
    End Sub

    Private Sub Klassen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SeptemberDate As Date

        SeptemberDate = Date.Today

        If (SeptemberDate.Month < 9) Then
            SeptemberDate = New Date(Date.Today.Year - 1, Date.Today.Month, Date.Today.Month)
        End If

        Dim test As Integer = SeptemberDate.Year
        test = SeptemberDate.Year - 3

        For i As Integer = SeptemberDate.Year - 3 To SeptemberDate.Year
            ComboJaar.Items.Add(i.ToString & " - " & i.ToString + 1)
        Next
        ComboJaar.Items.Add("alles")
        ComboJaar.SelectedItem = "alles"

        refreshLeerlingen()
        refreshKlas()
    End Sub

    Public Sub refreshKlas()
        Dim datatable As New DataTable
        Dim bindingsource As New BindingSource

        datatable = sqlManager.LoadGrid("klassen")
        datatable.Rows.Add("0", "alles")

        ComboKlas.DataSource = datatable
        ComboKlas.DisplayMember = "klas"
        ComboKlas.SelectedIndex = ComboKlas.Items.Count - 1

    End Sub

    Public Sub refreshLeerlingen()
        Dim datatable As New DataTable
        Dim bindingsource As New BindingSource

        If (ComboKlas.Text = "alles" And ComboJaar.Text = "alles") Then
            datatable = sqlManager.LoadGrid("leerlingen")
        ElseIf (ComboKlas.Text <> "alles" And ComboJaar.Text = "alles") Then
            datatable = sqlManager.LoadFilteredData("leerlingen", "Klas", ComboKlas.Text)
        ElseIf (ComboJaar.Text <> "alles" And ComboKlas.Text = "alles") Then
            datatable = sqlManager.LoadFilteredData("leerlingen", "ToegevoegdJaar", ComboJaar.Text.Substring(0, 4))
        Else
            datatable = sqlManager.LoadDoubleFilteredData("leerlingen", "ToegevoegdJaar", "Klas", ComboJaar.Text.Substring(0, 4), ComboKlas.Text)
        End If

        DataGridView1.DataSource = bindingsource
        bindingsource.DataSource = datatable
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(11).Visible = False
    End Sub

    Private Sub ComboKlas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboKlas.SelectedIndexChanged
        refreshLeerlingen()
        refreshKlasEditorTekst()
    End Sub

    Public Sub refreshKlasEditorTekst()
        If (KlasEditor.Visible) Then
            If (ComboKlas.Text = "alles") Then
                ComboKlas.SelectedIndex = ComboKlas.Items.Count - 2
            End If
            KlasEditor.TextBox1.Text = ComboKlas.Text
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim field As String, Value As String, ID As Integer

        ID = DataGridView1.CurrentRow.Cells(0).Value.ToString
        field = DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name
        Value = DataGridView1.CurrentCell.Value.ToString

        sqlManager.UpdateData("leerlingen", ID, field, Value)
        refreshLeerlingen()
    End Sub


    Private Sub ComboJaar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboJaar.SelectedIndexChanged
        refreshLeerlingen()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        sqlManager.DeleteRow("leerlingen", DataGridView1.CurrentRow.Cells(0).Value.ToString)
        refreshLeerlingen()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Size = New Size(Me.Width, Me.Height + 300)

        Leerling_Toevoegen.TopLevel = False
        Leerling_Toevoegen.Dock = DockStyle.Fill
        Panel2.Controls.Add(Leerling_Toevoegen)
        Leerling_Toevoegen.Show()
        Button4.Visible = False
    End Sub

    Public Sub leerlingToevoegenRefreshCombo()
        If (Leerling_Toevoegen.Visible) Then
            Dim datatable As New DataTable
            Dim bindingsource As New BindingSource

            'klassen
            datatable = sqlManager.LoadGrid("klassen")

            Leerling_Toevoegen.Klas.DataSource = datatable
            Leerling_Toevoegen.Klas.DisplayMember = "klas"

            'Bedrijf
            datatable = sqlManager.LoadGrid("bedrijven")

            Leerling_Toevoegen.Bedrijf.DataSource = datatable
            Leerling_Toevoegen.Bedrijf.DisplayMember = "BedrijfNaam"

            'Mentor
            datatable = sqlManager.LoadGrid("accounts")

            Leerling_Toevoegen.Mentor.DataSource = datatable
            Leerling_Toevoegen.Mentor.DisplayMember = "Voornaam"
        End If
    End Sub
End Class