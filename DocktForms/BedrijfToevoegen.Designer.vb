<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BedrijfToevoegen
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Straat = New System.Windows.Forms.TextBox()
        Me.HuisNummer = New System.Windows.Forms.TextBox()
        Me.Postcode = New System.Windows.Forms.TextBox()
        Me.Plaats = New System.Windows.Forms.TextBox()
        Me.BedrijfNaam = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContactPersoon = New System.Windows.Forms.TextBox()
        Me.Opmerkingen = New System.Windows.Forms.RichTextBox()
        Me.eMail = New System.Windows.Forms.TextBox()
        Me.Telefoon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(598, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 26)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Anuleren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(598, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 26)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Toevoegen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Straat
        '
        Me.Straat.Location = New System.Drawing.Point(150, 94)
        Me.Straat.Name = "Straat"
        Me.Straat.Size = New System.Drawing.Size(203, 20)
        Me.Straat.TabIndex = 14
        '
        'HuisNummer
        '
        Me.HuisNummer.Location = New System.Drawing.Point(379, 94)
        Me.HuisNummer.Name = "HuisNummer"
        Me.HuisNummer.Size = New System.Drawing.Size(32, 20)
        Me.HuisNummer.TabIndex = 15
        '
        'Postcode
        '
        Me.Postcode.Location = New System.Drawing.Point(468, 94)
        Me.Postcode.Name = "Postcode"
        Me.Postcode.Size = New System.Drawing.Size(100, 20)
        Me.Postcode.TabIndex = 16
        '
        'Plaats
        '
        Me.Plaats.Location = New System.Drawing.Point(21, 94)
        Me.Plaats.Name = "Plaats"
        Me.Plaats.Size = New System.Drawing.Size(100, 20)
        Me.Plaats.TabIndex = 13
        '
        'BedrijfNaam
        '
        Me.BedrijfNaam.Location = New System.Drawing.Point(21, 33)
        Me.BedrijfNaam.Name = "BedrijfNaam"
        Me.BedrijfNaam.Size = New System.Drawing.Size(100, 20)
        Me.BedrijfNaam.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "eMail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Huisnummer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Straat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Postcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Plaats"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bedrijf Naam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ContactPersoon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Opmerkingen"
        '
        'ContactPersoon
        '
        Me.ContactPersoon.Location = New System.Drawing.Point(150, 33)
        Me.ContactPersoon.Name = "ContactPersoon"
        Me.ContactPersoon.Size = New System.Drawing.Size(100, 20)
        Me.ContactPersoon.TabIndex = 15
        '
        'Opmerkingen
        '
        Me.Opmerkingen.Location = New System.Drawing.Point(21, 143)
        Me.Opmerkingen.Name = "Opmerkingen"
        Me.Opmerkingen.Size = New System.Drawing.Size(547, 44)
        Me.Opmerkingen.TabIndex = 22
        Me.Opmerkingen.Text = ""
        '
        'eMail
        '
        Me.eMail.Location = New System.Drawing.Point(293, 33)
        Me.eMail.Name = "eMail"
        Me.eMail.Size = New System.Drawing.Size(118, 20)
        Me.eMail.TabIndex = 14
        '
        'Telefoon
        '
        Me.Telefoon.Location = New System.Drawing.Point(438, 33)
        Me.Telefoon.Name = "Telefoon"
        Me.Telefoon.Size = New System.Drawing.Size(130, 20)
        Me.Telefoon.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Telefoon"
        '
        'BedrijfToevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1030, 204)
        Me.Controls.Add(Me.Opmerkingen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ContactPersoon)
        Me.Controls.Add(Me.eMail)
        Me.Controls.Add(Me.Telefoon)
        Me.Controls.Add(Me.Straat)
        Me.Controls.Add(Me.HuisNummer)
        Me.Controls.Add(Me.Postcode)
        Me.Controls.Add(Me.Plaats)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BedrijfNaam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BedrijfToevoegen"
        Me.Text = "NieuwBedrijf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Straat As System.Windows.Forms.TextBox
    Friend WithEvents HuisNummer As System.Windows.Forms.TextBox
    Friend WithEvents Postcode As System.Windows.Forms.TextBox
    Friend WithEvents Plaats As System.Windows.Forms.TextBox
    Friend WithEvents BedrijfNaam As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ContactPersoon As System.Windows.Forms.TextBox
    Friend WithEvents Opmerkingen As System.Windows.Forms.RichTextBox
    Friend WithEvents eMail As System.Windows.Forms.TextBox
    Friend WithEvents Telefoon As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
