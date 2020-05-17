<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NNPUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NNPUpdate))
        Me.Status = New System.Windows.Forms.Label()
        Me.Ver = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Status
        '
        resources.ApplyResources(Me.Status, "Status")
        Me.Status.Name = "Status"
        Me.Status.UseWaitCursor = True
        '
        'Ver
        '
        resources.ApplyResources(Me.Ver, "Ver")
        Me.Ver.Name = "Ver"
        Me.Ver.Url = New System.Uri("http://nnp.gagamichi.com/VBNet/Version.php", System.UriKind.Absolute)
        '
        'NNPUpdate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox = False
        Me.Controls.Add(Me.Ver)
        Me.Controls.Add(Me.Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NNPUpdate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Ver As System.Windows.Forms.WebBrowser

End Class
