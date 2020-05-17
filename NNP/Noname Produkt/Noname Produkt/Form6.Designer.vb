<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAQ
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
        Me.components = New System.ComponentModel.Container()
        Me.FAQBox = New System.Windows.Forms.ListView()
        Me.Frage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Antwort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Größe = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'FAQBox
        '
        Me.FAQBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Frage, Me.Antwort})
        Me.FAQBox.Location = New System.Drawing.Point(12, 12)
        Me.FAQBox.Name = "FAQBox"
        Me.FAQBox.Size = New System.Drawing.Size(849, 158)
        Me.FAQBox.TabIndex = 0
        Me.FAQBox.UseCompatibleStateImageBehavior = False
        Me.FAQBox.View = System.Windows.Forms.View.Details
        '
        'Frage
        '
        Me.Frage.Text = "Frage"
        Me.Frage.Width = 282
        '
        'Antwort
        '
        Me.Antwort.Text = "Antwort"
        Me.Antwort.Width = 1175
        '
        'Größe
        '
        Me.Größe.Interval = 500
        '
        'FAQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 182)
        Me.Controls.Add(Me.FAQBox)
        Me.MinimumSize = New System.Drawing.Size(889, 220)
        Me.Name = "FAQ"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAQ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FAQBox As System.Windows.Forms.ListView
    Friend WithEvents Frage As System.Windows.Forms.ColumnHeader
    Friend WithEvents Antwort As System.Windows.Forms.ColumnHeader
    Friend WithEvents Größe As System.Windows.Forms.Timer
End Class
