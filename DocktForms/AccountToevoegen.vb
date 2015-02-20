Public Class AccountToevoegen
    Dim sqlManager As SQLManager = New SQLManager

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlManager.NieuwAcount(VoorNaam.Text, Naam.Text, Klas.Text, Telefoon.Text, eMail.Text, Ta.CheckState, Admin.CheckState)
        Accounts.RefreshAcountsData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Accounts.Button2.Location = New Point(Accounts.Button2.Location.X, Accounts.Button2.Location.Y - 100)
        Accounts.Size = New Size(Accounts.Width, Accounts.Height - 100)
        Accounts.Button2.Visible = True

        Me.Close()
    End Sub


End Class