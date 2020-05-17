<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDK
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
        Me.TCDK = New System.Windows.Forms.Timer(Me.components)
        Me.STCDK = New System.Windows.Forms.Timer(Me.components)
        Me.CDKC = New System.Windows.Forms.TextBox()
        Me.P1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'TCDK
        '
        Me.TCDK.Interval = 10
        '
        'STCDK
        '
        Me.STCDK.Interval = 10
        '
        'CDKC
        '
        Me.CDKC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CDKC.Enabled = False
        Me.CDKC.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDKC.Location = New System.Drawing.Point(12, 12)
        Me.CDKC.Multiline = True
        Me.CDKC.Name = "CDKC"
        Me.CDKC.ReadOnly = True
        Me.CDKC.Size = New System.Drawing.Size(106, 42)
        Me.CDKC.TabIndex = 0
        Me.CDKC.Text = "9999"
        Me.CDKC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P1
        '
        Me.P1.Location = New System.Drawing.Point(1, 57)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(129, 10)
        Me.P1.TabIndex = 1
        '
        'CDK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(130, 66)
        Me.ControlBox = False
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.CDKC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CDK"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCDK As System.Windows.Forms.Timer
    Friend WithEvents STCDK As System.Windows.Forms.Timer
    Friend WithEvents CDKC As System.Windows.Forms.TextBox
    Friend WithEvents P1 As System.Windows.Forms.ProgressBar
End Class
