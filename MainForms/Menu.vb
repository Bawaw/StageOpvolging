Public Class MenuForm

    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UserData.Authority < 2 Then
            AccountsToolStripMenuItem.Visible = False
        End If
        XxpoesxxToolStripMenuItem.Text = UserData.User
    End Sub

    Private Sub AfmeldenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfmeldenToolStripMenuItem.Click
        UserData.ClearMemory()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub AfsluitenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfsluitenToolStripMenuItem.Click
        UserData.ClearMemory()
        Me.Close()
        Login.Close()
    End Sub

    
    Private Sub KlassenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KlassenToolStripMenuItem.Click
        Klassen.Show()
    End Sub

    Private Sub BedrijfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BedrijfToolStripMenuItem.Click
        Bedrijf.Show()
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click
        Accounts.Show()
    End Sub
End Class