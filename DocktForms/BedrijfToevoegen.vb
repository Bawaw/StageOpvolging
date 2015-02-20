Public Class BedrijfToevoegen
    Dim sqlManager As SQLManager = New SQLManager
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlManager.NieuwBedrijf(BedrijfNaam.Text, Plaats.Text, Straat.Text, Telefoon.Text, eMail.Text, ContactPersoon.Text, Opmerkingen.Text, Postcode.Text, HuisNummer.Text)
        Bedrijf.RefreshBedrijfData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Bedrijf.Size = New Size(Bedrijf.Size.Width, Bedrijf.Size.Height - 180)
        Bedrijf.Button2.Visible = True
        Me.Close()
    End Sub
End Class