<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leerling_Toevoegen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TelefoonLabel As System.Windows.Forms.Label
        Dim Straat___NummerLabel1 As System.Windows.Forms.Label
        Dim VoornaamLabel As System.Windows.Forms.Label
        Dim NaamLabel As System.Windows.Forms.Label
        Dim KlasLabel As System.Windows.Forms.Label
        Dim NummerLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim BedrijfLabel As System.Windows.Forms.Label
        Dim Contact_PersoonLabel As System.Windows.Forms.Label
        Dim MentorLabel As System.Windows.Forms.Label
        Dim OpmerkingenLabel As System.Windows.Forms.Label
        Me.TelefoonTextBox = New System.Windows.Forms.TextBox()
        Me.adresTextBox = New System.Windows.Forms.TextBox()
        Me.VoornaamTextBox = New System.Windows.Forms.TextBox()
        Me.NaamTextBox = New System.Windows.Forms.TextBox()
        Me.NummerTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_PersoonTextBox = New System.Windows.Forms.TextBox()
        Me.OpmerkingenTextBox = New System.Windows.Forms.TextBox()
        Me.Bedrijf = New System.Windows.Forms.ComboBox()
        Me.Mentor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Klas = New System.Windows.Forms.ComboBox()
        TelefoonLabel = New System.Windows.Forms.Label()
        Straat___NummerLabel1 = New System.Windows.Forms.Label()
        VoornaamLabel = New System.Windows.Forms.Label()
        NaamLabel = New System.Windows.Forms.Label()
        KlasLabel = New System.Windows.Forms.Label()
        NummerLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        BedrijfLabel = New System.Windows.Forms.Label()
        Contact_PersoonLabel = New System.Windows.Forms.Label()
        MentorLabel = New System.Windows.Forms.Label()
        OpmerkingenLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TelefoonLabel
        '
        TelefoonLabel.AutoSize = True
        TelefoonLabel.BackColor = System.Drawing.Color.Transparent
        TelefoonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        TelefoonLabel.Location = New System.Drawing.Point(405, 9)
        TelefoonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefoonLabel.Name = "TelefoonLabel"
        TelefoonLabel.Size = New System.Drawing.Size(52, 13)
        TelefoonLabel.TabIndex = 55
        TelefoonLabel.Text = "Telefoon:"
        '
        'Straat___NummerLabel1
        '
        Straat___NummerLabel1.AutoSize = True
        Straat___NummerLabel1.BackColor = System.Drawing.Color.Transparent
        Straat___NummerLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Straat___NummerLabel1.Location = New System.Drawing.Point(284, 52)
        Straat___NummerLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Straat___NummerLabel1.Name = "Straat___NummerLabel1"
        Straat___NummerLabel1.Size = New System.Drawing.Size(34, 13)
        Straat___NummerLabel1.TabIndex = 53
        Straat___NummerLabel1.Text = "Adres"
        '
        'VoornaamLabel
        '
        VoornaamLabel.AutoSize = True
        VoornaamLabel.BackColor = System.Drawing.Color.Transparent
        VoornaamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        VoornaamLabel.Location = New System.Drawing.Point(61, 9)
        VoornaamLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VoornaamLabel.Name = "VoornaamLabel"
        VoornaamLabel.Size = New System.Drawing.Size(55, 13)
        VoornaamLabel.TabIndex = 34
        VoornaamLabel.Text = "Voornaam"
        '
        'NaamLabel
        '
        NaamLabel.AutoSize = True
        NaamLabel.BackColor = System.Drawing.Color.Transparent
        NaamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        NaamLabel.Location = New System.Drawing.Point(177, 9)
        NaamLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NaamLabel.Name = "NaamLabel"
        NaamLabel.Size = New System.Drawing.Size(38, 13)
        NaamLabel.TabIndex = 36
        NaamLabel.Text = "Naam:"
        '
        'KlasLabel
        '
        KlasLabel.AutoSize = True
        KlasLabel.BackColor = System.Drawing.Color.Transparent
        KlasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        KlasLabel.Location = New System.Drawing.Point(306, 9)
        KlasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KlasLabel.Name = "KlasLabel"
        KlasLabel.Size = New System.Drawing.Size(30, 13)
        KlasLabel.TabIndex = 38
        KlasLabel.Text = "Klas:"
        '
        'NummerLabel
        '
        NummerLabel.AutoSize = True
        NummerLabel.BackColor = System.Drawing.Color.Transparent
        NummerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        NummerLabel.Location = New System.Drawing.Point(4, 9)
        NummerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NummerLabel.Name = "NummerLabel"
        NummerLabel.Size = New System.Drawing.Size(49, 13)
        NummerLabel.TabIndex = 40
        NummerLabel.Text = "Nummer:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.BackColor = System.Drawing.Color.Transparent
        E_mailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        E_mailLabel.Location = New System.Drawing.Point(5, 52)
        E_mailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(38, 13)
        E_mailLabel.TabIndex = 44
        E_mailLabel.Text = "E-mail:"
        '
        'BedrijfLabel
        '
        BedrijfLabel.AutoSize = True
        BedrijfLabel.BackColor = System.Drawing.Color.Transparent
        BedrijfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        BedrijfLabel.Location = New System.Drawing.Point(4, 95)
        BedrijfLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BedrijfLabel.Name = "BedrijfLabel"
        BedrijfLabel.Size = New System.Drawing.Size(39, 13)
        BedrijfLabel.TabIndex = 46
        BedrijfLabel.Text = "Bedrijf:"
        '
        'Contact_PersoonLabel
        '
        Contact_PersoonLabel.AutoSize = True
        Contact_PersoonLabel.BackColor = System.Drawing.Color.Transparent
        Contact_PersoonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Contact_PersoonLabel.Location = New System.Drawing.Point(164, 95)
        Contact_PersoonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Contact_PersoonLabel.Name = "Contact_PersoonLabel"
        Contact_PersoonLabel.Size = New System.Drawing.Size(89, 13)
        Contact_PersoonLabel.TabIndex = 48
        Contact_PersoonLabel.Text = "Contact Persoon:"
        '
        'MentorLabel
        '
        MentorLabel.AutoSize = True
        MentorLabel.BackColor = System.Drawing.Color.Transparent
        MentorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        MentorLabel.Location = New System.Drawing.Point(353, 95)
        MentorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MentorLabel.Name = "MentorLabel"
        MentorLabel.Size = New System.Drawing.Size(43, 13)
        MentorLabel.TabIndex = 50
        MentorLabel.Text = "Mentor:"
        '
        'OpmerkingenLabel
        '
        OpmerkingenLabel.AutoSize = True
        OpmerkingenLabel.BackColor = System.Drawing.Color.Transparent
        OpmerkingenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        OpmerkingenLabel.Location = New System.Drawing.Point(4, 149)
        OpmerkingenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OpmerkingenLabel.Name = "OpmerkingenLabel"
        OpmerkingenLabel.Size = New System.Drawing.Size(73, 13)
        OpmerkingenLabel.TabIndex = 52
        OpmerkingenLabel.Text = "Opmerkingen:"
        '
        'TelefoonTextBox
        '
        Me.TelefoonTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TelefoonTextBox.Location = New System.Drawing.Point(437, 27)
        Me.TelefoonTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TelefoonTextBox.Name = "TelefoonTextBox"
        Me.TelefoonTextBox.Size = New System.Drawing.Size(99, 20)
        Me.TelefoonTextBox.TabIndex = 57
        '
        'adresTextBox
        '
        Me.adresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.adresTextBox.Location = New System.Drawing.Point(309, 70)
        Me.adresTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.adresTextBox.Name = "adresTextBox"
        Me.adresTextBox.Size = New System.Drawing.Size(254, 20)
        Me.adresTextBox.TabIndex = 56
        '
        'VoornaamTextBox
        '
        Me.VoornaamTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.VoornaamTextBox.Location = New System.Drawing.Point(81, 27)
        Me.VoornaamTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VoornaamTextBox.Name = "VoornaamTextBox"
        Me.VoornaamTextBox.Size = New System.Drawing.Size(99, 20)
        Me.VoornaamTextBox.TabIndex = 35
        '
        'NaamTextBox
        '
        Me.NaamTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NaamTextBox.Location = New System.Drawing.Point(208, 27)
        Me.NaamTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NaamTextBox.Name = "NaamTextBox"
        Me.NaamTextBox.Size = New System.Drawing.Size(99, 20)
        Me.NaamTextBox.TabIndex = 37
        '
        'NummerTextBox
        '
        Me.NummerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NummerTextBox.Location = New System.Drawing.Point(26, 27)
        Me.NummerTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NummerTextBox.Name = "NummerTextBox"
        Me.NummerTextBox.Size = New System.Drawing.Size(27, 20)
        Me.NummerTextBox.TabIndex = 41
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.E_mailTextBox.Location = New System.Drawing.Point(26, 70)
        Me.E_mailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(250, 20)
        Me.E_mailTextBox.TabIndex = 45
        '
        'Contact_PersoonTextBox
        '
        Me.Contact_PersoonTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Contact_PersoonTextBox.Location = New System.Drawing.Point(180, 113)
        Me.Contact_PersoonTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Contact_PersoonTextBox.Name = "Contact_PersoonTextBox"
        Me.Contact_PersoonTextBox.Size = New System.Drawing.Size(176, 20)
        Me.Contact_PersoonTextBox.TabIndex = 49
        '
        'OpmerkingenTextBox
        '
        Me.OpmerkingenTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OpmerkingenTextBox.Location = New System.Drawing.Point(7, 167)
        Me.OpmerkingenTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpmerkingenTextBox.Multiline = True
        Me.OpmerkingenTextBox.Name = "OpmerkingenTextBox"
        Me.OpmerkingenTextBox.Size = New System.Drawing.Size(556, 45)
        Me.OpmerkingenTextBox.TabIndex = 54
        '
        'Bedrijf
        '
        Me.Bedrijf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Bedrijf.FormattingEnabled = True
        Me.Bedrijf.Location = New System.Drawing.Point(36, 111)
        Me.Bedrijf.Name = "Bedrijf"
        Me.Bedrijf.Size = New System.Drawing.Size(121, 21)
        Me.Bedrijf.TabIndex = 58
        '
        'Mentor
        '
        Me.Mentor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Mentor.FormattingEnabled = True
        Me.Mentor.Location = New System.Drawing.Point(379, 113)
        Me.Mentor.Name = "Mentor"
        Me.Mentor.Size = New System.Drawing.Size(121, 21)
        Me.Mentor.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(396, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Toevoegen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button2.Location = New System.Drawing.Point(488, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Anuleren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Klas
        '
        Me.Klas.FormattingEnabled = True
        Me.Klas.Location = New System.Drawing.Point(314, 28)
        Me.Klas.Name = "Klas"
        Me.Klas.Size = New System.Drawing.Size(94, 21)
        Me.Klas.TabIndex = 61
        '
        'Leerling_Toevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(577, 268)
        Me.Controls.Add(Me.Klas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Mentor)
        Me.Controls.Add(Me.Bedrijf)
        Me.Controls.Add(TelefoonLabel)
        Me.Controls.Add(Me.TelefoonTextBox)
        Me.Controls.Add(Straat___NummerLabel1)
        Me.Controls.Add(Me.adresTextBox)
        Me.Controls.Add(VoornaamLabel)
        Me.Controls.Add(Me.VoornaamTextBox)
        Me.Controls.Add(NaamLabel)
        Me.Controls.Add(Me.NaamTextBox)
        Me.Controls.Add(KlasLabel)
        Me.Controls.Add(NummerLabel)
        Me.Controls.Add(Me.NummerTextBox)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(BedrijfLabel)
        Me.Controls.Add(Contact_PersoonLabel)
        Me.Controls.Add(Me.Contact_PersoonTextBox)
        Me.Controls.Add(MentorLabel)
        Me.Controls.Add(OpmerkingenLabel)
        Me.Controls.Add(Me.OpmerkingenTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Leerling_Toevoegen"
        Me.Text = "Leerling Toevoegen"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TelefoonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents adresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VoornaamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NaamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NummerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contact_PersoonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpmerkingenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bedrijf As System.Windows.Forms.ComboBox
    Friend WithEvents Mentor As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Klas As System.Windows.Forms.ComboBox
End Class
