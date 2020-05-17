<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NB
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Das Noname Produkt (nachfolgend: NNP oder NNPs) ist ein ", "kostenloses Programm zur Erleichterung des Spielens auf ", "Grand Theft Auto (nachfolgend: GTA) San Andreas ", "Multiplayer (nachfolgend: SA:MP) Servern. Das NNP wurde ", "für die SA:MP Server Nova e-Sports Reallife ", "(http://www.nes-reallife.de)(nachfolgend: RL) und ", "Nova e-Sports Newlife (https://www.nes-newlife.de)", "(nachfolgend: NL) entwickelt und an diese angepasst.", "Mit dem ausführen und nutzen des NNPs erklärt sich der ", "Nutzer mit den Nutzungsbedingungen einverstanden.", "", "", "", "1. Haftung", "Es wird vom Entwickler des NNPs weder für jegliche ", "Ingame-Aktionen noch für Schäden an Hardware und/oder", "Software des Computers in irgendeiner Art Haftung ", "übernommen. Sollten solche Schäden auftreten muss ", "schnellstmöglich der Entwickler des NNPs kontaktiert ", "werden (bug@gagamichi.com) und das Problem so ", "detailliert wie möglich geschildert werden um weitere ", "Schäden verhindern zu können.", "", "1.1 Sicherung von Dateien", "Das NNP wird beim ersten Start sowie in dem weiteren ", "Verlauf der Nutzung dessen Dateien erstellen, löschen, ", "überschreiben und verschieben.", "Folgende Dateien sind davon Betrofen:", "•C:\Program Files (x86)\NNP\API.dll", "•C:\Program Files (x86)\NNP\Log.Gaga", "•C:\Program Files (x86)\NNP\NNP.Gaga", "•C:\Program Files (x86)\NNP\R1.exe", "sowie das eigentliche Programm (Noname Produkt.exe) ", "und eventuell nachfolgende Dateien. Werden dadurch ", "wichtige Dateien gelöscht oder gehen anders verloren", "übernimmt der Entwickler des NNPs keinerlei Verantwortung.", "", "", "2. Berechtigung", "Das NNP funktioniert nur dann korrekt wenn dieses als ", "Administrator ausgeführt wird. Diese Berechtigungen werden ", "lediglich dafür verwendet um das NNP mit dem SA:MP Server ", "zu kompatibilisieren und alles was in irgendeiner Art damit zu ", "tun hat. Das beinhaltet die Webseiten und Foren der SA:MP ", "Servern RL und NL sowie der NNP Webseite ", "(http://www.nnp.gagamichi.com und", " http://www.nnpv1.gagamichi.com).", "", "2.1 Verbreitung", "Der Nutzer ist nur dazu berechtigt das NNP über die offizielle ", "Webseite (http://www.nnp.gagamichi.com oder", " http://www.nnpv1.gagamichi.com) zu verbreiten. Ist das NNP ", "über andere Webseiten gedownloadet worden sein sollte ", "dieses sofort entfernt werden (siehe: 3.2).", "", "2.2 Veränderung des Codes", "Es ist nicht gestattet den Code des NNPs zu verändern und ", "dieses veränderte Programm zu verbreiten. Sollte dies der Fall ", "gewesen sein ist das veränderte Programm sofort zu ", "entfernen (siehe: 3.2). Sollten Änderungswünsche am NNP ", "vorliegen können diese auf der NNP Webseite eingereicht ", "werden: http://www.nnp.gagamichi.com/Vorschlaege.php.", "", "", "3. Sicherheit", "Es befinden sich keine Viren oder andere Schadsoftware ", "(-teile) im Code des NNPs (zu beachten: 3.1). Sollte das NNP ", "dennoch von Antivieren Programmen blockiert werden liegt ", "das  vermutlich an den Erweiterungen (3.1). Wer sich ", "dennoch nicht Sicher ist ob er dem NNP vertrauen kann, ", "kann gerne einen Administrator (oder höherer Rang) des ", "SA:MP Servers NL darum bitten den Code des NNPs zu ", "überprüfen.", "", "3.1 Erweiterungen", "Das NNP enthält Erweiterungen zur besseren Kompatibilität ", "zu GTA San Andreas (Multiplayer). Diese sind (bis vor kurzem) ", "die overlay.dll (http://www.overlay-api.net) und (aktuell) die ", "API.dll (http://www.samp-api.de). Für diese Erweiterungen ", "wird keine Verantwortung und keine Garantie für die ", "Schadensfreiheit und die Sicherheit übernommen. Der Code ", "dieser Open Source Dateien lässt sich doch von jedem den ", "das interessiert oder auch nicht interessiert unter den ", "Verlinkungen zu GitHub auf den Webseiten überprüfen.", "", "3.2 Download/Update", "Um zu verhindern dass das NNP bearbeitet oder mit ", "Schadsoftware infiziert wurde sollte es nur von den offiziellen ", "Webseiten des NNPs (http://www.nnp.gagamichi.com und", "http://www.nnpv1.gagamichi.com) gedownloadet werden ", "sowie nur von den dort gedownloadeten Versionen die ", "Update-Funktion genutzt werden. Sollte eine NNP Version ", "nicht von diesen Webseiten gedownloadet sein sollte diese ", "Version gelöscht werden, ein Virensacn durchgeführt und ", "die Version auf den oben genannten Webseiten ", "gedownloadet werden.", "", "3.3 Datenschutz", "Es werden keine Persönlichen Daten des Nutzers ", "hochgeladen oder veröffentlicht (abgesehen von dem ", "eingetragenen Nutzernamen, bestimmte Nachrichten und ", "teilweise die Position welche für beispielsweise den Chat", "oder das Schwarzmarkt System benötigt werden).", "Das NNP besitzt weder eine Funktion zum auslesen des ", "Passworts noch zum infiltrieren der Daten auf den ", "Computer (abgesehen der NNP Dateien, siehe: 1.1) oder ", "für das aufzeichnen der Tastaturanschläge, Mikrofon-, ", "Webcam-, Soundausgabeaktivitäten oder anderer ", "Verläufe/Aktivitäten.", "", "", "", "", "", "Sollten diese Bedingungen nicht Akzeptiert werden ist das ", "NNP nicht mehr zu verwenden und dieses und alle ", "dazugehörigen Dateien (C:\Program Files (x86)\NNP\*) ", "vom Computer zu entfernen. entfernen."})
        Me.ListBox1.Location = New System.Drawing.Point(12, 10)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(317, 160)
        Me.ListBox1.TabIndex = 0
        '
        'NB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(340, 182)
        Me.Controls.Add(Me.ListBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(356, 220)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(356, 220)
        Me.Name = "NB"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nutzungsbedingungen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
