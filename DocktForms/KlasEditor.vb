Public Class KlasEditor
    Dim sqlManager As SQLManager = New SQLManager
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Klassen.Button1.Visible = True
        Me.Close()
    End Sub

    Private Sub KlasEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Klassen.refreshKlasEditorTekst()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        sqlManager.NieuweKlas(TextBox1.Text)
        Klassen.leerlingToevoegenRefreshCombo()
        Klassen.refreshKlas()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (MsgBox("bent u zeker dat u de " & Klassen.ComboKlas.Text & " wilt verwijderen?", MsgBoxStyle.YesNo, "Delete Object")) Then
            sqlManager.DeleteKlas(Klassen.ComboKlas.Text)
            Klassen.refreshKlas()
            Klassen.leerlingToevoegenRefreshCombo()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlManager.UpdateKlas(Klassen.ComboKlas.Text, TextBox1.Text)
        Klassen.refreshKlas()
        Klassen.leerlingToevoegenRefreshCombo()
    End Sub
End Class