Public Class Login
    Dim sqlManager As SQLManager = New SQLManager
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim macht As Integer
        macht = sqlManager.CheckValidLogin(UsernameTextBox.Text, PasswordTextBox.Text)
        If (macht > 0) Then
            UserData.User = UsernameTextBox.Text
            UserData.Authority = macht

            MsgBox("Connected")
            Me.Hide()
            MenuForm.Show()
        Else
            MsgBox("Gebruikersnaam of wachtwoord niet gevonden, probeer opnieuw")
        End If
    End Sub
End Class