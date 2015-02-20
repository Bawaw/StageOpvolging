Public Class Leerling_Toevoegen
    Dim sqlManager As New SQLManager

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Klassen.Size = New Size(Klassen.Width, Klassen.Height - 200)
        Klassen.Button4.Visible = True

        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SeptemberDate As Date

        SeptemberDate = Date.Today

        If (SeptemberDate.Month < 9) Then
            SeptemberDate = New Date(Date.Today.Year - 1, Date.Today.Month, Date.Today.Month)
        End If
        Try
            sqlManager.NieuweLeerling(NummerTextBox.Text, VoornaamTextBox.Text, NaamTextBox.Text, Klas.Text, E_mailTextBox.Text, TelefoonTextBox.Text, adresTextBox.Text, Bedrijf.Text, Mentor.Text, OpmerkingenTextBox.Text, SeptemberDate.Year.ToString)
        Catch ex As Exception
            MsgBox("Een veld werd niet correct ingevuld")
        End Try
           Klassen.refreshLeerlingen()
    End Sub

    Private Sub Leerling_Toevoegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Klassen.leerlingToevoegenRefreshCombo()
    End Sub
End Class