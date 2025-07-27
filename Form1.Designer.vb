<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Envoyeur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Receveur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.srs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taille = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Données = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Console = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrersousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuavantimpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RétablirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SélectionnertoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonnaliserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SommaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÀproposdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Uncryptz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 24)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1431, 536)
        Me.MainPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1429, 390)
        Me.Panel2.TabIndex = 1
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Envoyeur, Me.Receveur, Me.srs, Me.dest, Me.Column1, Me.Column2, Me.type, Me.taille, Me.Données, Me.Uncryptz})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidth = 62
        Me.DGV.ShowCellErrors = False
        Me.DGV.ShowEditingIcon = False
        Me.DGV.ShowRowErrors = False
        Me.DGV.Size = New System.Drawing.Size(1429, 390)
        Me.DGV.TabIndex = 1
        '
        'Envoyeur
        '
        Me.Envoyeur.HeaderText = "Envoyeur"
        Me.Envoyeur.MinimumWidth = 8
        Me.Envoyeur.Name = "Envoyeur"
        Me.Envoyeur.Width = 150
        '
        'Receveur
        '
        Me.Receveur.HeaderText = "Receveur"
        Me.Receveur.MinimumWidth = 8
        Me.Receveur.Name = "Receveur"
        Me.Receveur.Width = 150
        '
        'srs
        '
        Me.srs.HeaderText = "Port source"
        Me.srs.MinimumWidth = 8
        Me.srs.Name = "srs"
        Me.srs.Width = 150
        '
        'dest
        '
        Me.dest.HeaderText = "Port destinataire"
        Me.dest.MinimumWidth = 8
        Me.dest.Name = "dest"
        Me.dest.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "Protocole source"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Protocole distant"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'type
        '
        Me.type.HeaderText = "Type (TCP/UDP)"
        Me.type.MinimumWidth = 8
        Me.type.Name = "type"
        Me.type.Width = 150
        '
        'taille
        '
        Me.taille.HeaderText = "Taille"
        Me.taille.MinimumWidth = 8
        Me.taille.Name = "taille"
        Me.taille.Width = 60
        '
        'Données
        '
        Me.Données.HeaderText = "Données"
        Me.Données.MinimumWidth = 8
        Me.Données.Name = "Données"
        Me.Données.Width = 500
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Console)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1429, 144)
        Me.Panel1.TabIndex = 0
        '
        'Console
        '
        Me.Console.Location = New System.Drawing.Point(707, 4)
        Me.Console.Name = "Console"
        Me.Console.Size = New System.Drawing.Size(630, 133)
        Me.Console.TabIndex = 3
        Me.Console.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(435, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(10, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(371, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(371, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1431, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.toolStripSeparator, Me.EnregistrerToolStripMenuItem, Me.EnregistrersousToolStripMenuItem, Me.toolStripSeparator1, Me.ImprimerToolStripMenuItem, Me.AperçuavantimpressionToolStripMenuItem, Me.toolStripSeparator2, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Image = CType(resources.GetObject("NouveauToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Image = CType(resources.GetObject("OuvrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OuvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(202, 6)
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Image = CType(resources.GetObject("EnregistrerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'EnregistrersousToolStripMenuItem
        '
        Me.EnregistrersousToolStripMenuItem.Name = "EnregistrersousToolStripMenuItem"
        Me.EnregistrersousToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EnregistrersousToolStripMenuItem.Text = "Enregistrer &sous"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Image = CType(resources.GetObject("ImprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ImprimerToolStripMenuItem.Text = "&Imprimer"
        '
        'AperçuavantimpressionToolStripMenuItem
        '
        Me.AperçuavantimpressionToolStripMenuItem.Image = CType(resources.GetObject("AperçuavantimpressionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AperçuavantimpressionToolStripMenuItem.Name = "AperçuavantimpressionToolStripMenuItem"
        Me.AperçuavantimpressionToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(202, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnulerToolStripMenuItem, Me.RétablirToolStripMenuItem, Me.toolStripSeparator3, Me.CouperToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CollerToolStripMenuItem, Me.toolStripSeparator4, Me.SélectionnertoutToolStripMenuItem})
        Me.EditionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "&Edition"
        '
        'AnnulerToolStripMenuItem
        '
        Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        Me.AnnulerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AnnulerToolStripMenuItem.Text = "&Annuler"
        '
        'RétablirToolStripMenuItem
        '
        Me.RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem"
        Me.RétablirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RétablirToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RétablirToolStripMenuItem.Text = "&Rétablir"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Image = CType(resources.GetObject("CouperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CouperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CouperToolStripMenuItem.Text = "&Couper"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Image = CType(resources.GetObject("CopierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopierToolStripMenuItem.Text = "Co&pier"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Image = CType(resources.GetObject("CollerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CollerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CollerToolStripMenuItem.Text = "Co&ller"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(161, 6)
        '
        'SélectionnertoutToolStripMenuItem
        '
        Me.SélectionnertoutToolStripMenuItem.Name = "SélectionnertoutToolStripMenuItem"
        Me.SélectionnertoutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonnaliserToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.OutilsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "&Outils"
        '
        'PersonnaliserToolStripMenuItem
        '
        Me.PersonnaliserToolStripMenuItem.Name = "PersonnaliserToolStripMenuItem"
        Me.PersonnaliserToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PersonnaliserToolStripMenuItem.Text = "&Personnaliser"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SommaireToolStripMenuItem, Me.IndexToolStripMenuItem, Me.RechercherToolStripMenuItem, Me.toolStripSeparator5, Me.ÀproposdeToolStripMenuItem})
        Me.AideToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "&Aide"
        '
        'SommaireToolStripMenuItem
        '
        Me.SommaireToolStripMenuItem.Name = "SommaireToolStripMenuItem"
        Me.SommaireToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SommaireToolStripMenuItem.Text = "&Sommaire"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'RechercherToolStripMenuItem
        '
        Me.RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        Me.RechercherToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RechercherToolStripMenuItem.Text = "&Rechercher"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(144, 6)
        '
        'ÀproposdeToolStripMenuItem
        '
        Me.ÀproposdeToolStripMenuItem.Name = "ÀproposdeToolStripMenuItem"
        Me.ÀproposdeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ÀproposdeToolStripMenuItem.Text = "À &propos de..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 560)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1431, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Uncryptz
        '
        Me.Uncryptz.HeaderText = "Column3"
        Me.Uncryptz.Name = "Uncryptz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(573, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1431, 582)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MainPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrersousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ImprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperçuavantimpressionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnulerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RétablirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CouperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SélectionnertoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonnaliserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SommaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ÀproposdeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Envoyeur As DataGridViewTextBoxColumn
    Friend WithEvents Receveur As DataGridViewTextBoxColumn
    Friend WithEvents srs As DataGridViewTextBoxColumn
    Friend WithEvents dest As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents taille As DataGridViewTextBoxColumn
    Friend WithEvents Données As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Console As RichTextBox
    Friend WithEvents Uncryptz As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
