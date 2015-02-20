<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KlassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BedrijfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XxpoesxxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KlassenToolStripMenuItem, Me.BedrijfToolStripMenuItem, Me.XxpoesxxToolStripMenuItem, Me.AccountsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1090, 39)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KlassenToolStripMenuItem
        '
        Me.KlassenToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.KlassenToolStripMenuItem.Name = "KlassenToolStripMenuItem"
        Me.KlassenToolStripMenuItem.Size = New System.Drawing.Size(97, 35)
        Me.KlassenToolStripMenuItem.Text = "&Klassen"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(116, 35)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        '
        'BedrijfToolStripMenuItem
        '
        Me.BedrijfToolStripMenuItem.Name = "BedrijfToolStripMenuItem"
        Me.BedrijfToolStripMenuItem.Size = New System.Drawing.Size(97, 35)
        Me.BedrijfToolStripMenuItem.Text = "&Bedrijf"
        '
        'XxpoesxxToolStripMenuItem
        '
        Me.XxpoesxxToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.XxpoesxxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfmeldenToolStripMenuItem, Me.AfsluitenToolStripMenuItem})
        Me.XxpoesxxToolStripMenuItem.Name = "XxpoesxxToolStripMenuItem"
        Me.XxpoesxxToolStripMenuItem.Size = New System.Drawing.Size(181, 35)
        Me.XxpoesxxToolStripMenuItem.Text = "Gebruikersnaam"
        '
        'AfmeldenToolStripMenuItem
        '
        Me.AfmeldenToolStripMenuItem.Name = "AfmeldenToolStripMenuItem"
        Me.AfmeldenToolStripMenuItem.Size = New System.Drawing.Size(181, 34)
        Me.AfmeldenToolStripMenuItem.Text = "&Afmelden"
        '
        'AfsluitenToolStripMenuItem
        '
        Me.AfsluitenToolStripMenuItem.Name = "AfsluitenToolStripMenuItem"
        Me.AfsluitenToolStripMenuItem.Size = New System.Drawing.Size(181, 34)
        Me.AfsluitenToolStripMenuItem.Text = "&Afsluiten"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 551)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuForm"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KlassenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BedrijfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XxpoesxxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfsluitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
