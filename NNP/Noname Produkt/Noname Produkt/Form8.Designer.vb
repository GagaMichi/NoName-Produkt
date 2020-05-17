<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Knastzeit
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
        Me.WP69 = New System.Windows.Forms.RadioButton()
        Me.WP61 = New System.Windows.Forms.RadioButton()
        Me.WP35 = New System.Windows.Forms.RadioButton()
        Me.WP15 = New System.Windows.Forms.RadioButton()
        Me.WP10 = New System.Windows.Forms.RadioButton()
        Me.WPb = New System.Windows.Forms.RadioButton()
        Me.WPas = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WPa = New System.Windows.Forms.NumericUpDown()
        Me.Rechnen = New System.Windows.Forms.CheckBox()
        CType(Me.WPa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WP69
        '
        Me.WP69.AutoSize = True
        Me.WP69.Location = New System.Drawing.Point(12, 12)
        Me.WP69.Name = "WP69"
        Me.WP69.Size = New System.Drawing.Size(163, 17)
        Me.WP69.TabIndex = 0
        Me.WP69.TabStop = True
        Me.WP69.Text = "69 WPs (6300s -> ca. 7760s)"
        Me.WP69.UseVisualStyleBackColor = True
        '
        'WP61
        '
        Me.WP61.AutoSize = True
        Me.WP61.Location = New System.Drawing.Point(12, 35)
        Me.WP61.Name = "WP61"
        Me.WP61.Size = New System.Drawing.Size(163, 17)
        Me.WP61.TabIndex = 1
        Me.WP61.TabStop = True
        Me.WP61.Text = "61 WPs (5600s -> ca. 6810s)"
        Me.WP61.UseVisualStyleBackColor = True
        '
        'WP35
        '
        Me.WP35.AutoSize = True
        Me.WP35.Location = New System.Drawing.Point(12, 58)
        Me.WP35.Name = "WP35"
        Me.WP35.Size = New System.Drawing.Size(163, 17)
        Me.WP35.TabIndex = 2
        Me.WP35.TabStop = True
        Me.WP35.Text = "35 WPs (2100s -> ca. 2550s)"
        Me.WP35.UseVisualStyleBackColor = True
        '
        'WP15
        '
        Me.WP15.AutoSize = True
        Me.WP15.Location = New System.Drawing.Point(12, 81)
        Me.WP15.Name = "WP15"
        Me.WP15.Size = New System.Drawing.Size(157, 17)
        Me.WP15.TabIndex = 3
        Me.WP15.TabStop = True
        Me.WP15.Text = "15 WPs (900s -> ca. 1100s)"
        Me.WP15.UseVisualStyleBackColor = True
        '
        'WP10
        '
        Me.WP10.AutoSize = True
        Me.WP10.Location = New System.Drawing.Point(12, 104)
        Me.WP10.Name = "WP10"
        Me.WP10.Size = New System.Drawing.Size(151, 17)
        Me.WP10.TabIndex = 4
        Me.WP10.Text = "10 WPs (600s -> ca. 730s)"
        Me.WP10.UseVisualStyleBackColor = True
        '
        'WPb
        '
        Me.WPb.AutoSize = True
        Me.WPb.Location = New System.Drawing.Point(12, 127)
        Me.WPb.Name = "WPb"
        Me.WPb.Size = New System.Drawing.Size(14, 13)
        Me.WPb.TabIndex = 5
        Me.WPb.UseVisualStyleBackColor = True
        '
        'WPas
        '
        Me.WPas.AutoSize = True
        Me.WPas.Location = New System.Drawing.Point(89, 127)
        Me.WPas.Name = "WPas"
        Me.WPas.Size = New System.Drawing.Size(70, 13)
        Me.WPas.TabIndex = 7
        Me.WPas.Text = "in Sekunden!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 21)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Countdown starten"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WPa
        '
        Me.WPa.Enabled = False
        Me.WPa.Location = New System.Drawing.Point(32, 125)
        Me.WPa.Maximum = New Decimal(New Integer() {7000, 0, 0, 0})
        Me.WPa.Name = "WPa"
        Me.WPa.Size = New System.Drawing.Size(55, 20)
        Me.WPa.TabIndex = 9
        '
        'Rechnen
        '
        Me.Rechnen.AutoSize = True
        Me.Rechnen.Checked = True
        Me.Rechnen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Rechnen.Location = New System.Drawing.Point(165, 126)
        Me.Rechnen.Name = "Rechnen"
        Me.Rechnen.Size = New System.Drawing.Size(15, 14)
        Me.Rechnen.TabIndex = 10
        Me.Rechnen.UseVisualStyleBackColor = True
        '
        'Knastzeit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(182, 179)
        Me.Controls.Add(Me.Rechnen)
        Me.Controls.Add(Me.WPa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WPas)
        Me.Controls.Add(Me.WPb)
        Me.Controls.Add(Me.WP10)
        Me.Controls.Add(Me.WP15)
        Me.Controls.Add(Me.WP35)
        Me.Controls.Add(Me.WP61)
        Me.Controls.Add(Me.WP69)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(198, 217)
        Me.MinimumSize = New System.Drawing.Size(198, 217)
        Me.Name = "Knastzeit"
        Me.ShowIcon = False
        Me.Text = "Knastzeit"
        CType(Me.WPa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WP69 As System.Windows.Forms.RadioButton
    Friend WithEvents WP61 As System.Windows.Forms.RadioButton
    Friend WithEvents WP35 As System.Windows.Forms.RadioButton
    Friend WithEvents WP15 As System.Windows.Forms.RadioButton
    Friend WithEvents WP10 As System.Windows.Forms.RadioButton
    Friend WithEvents WPb As System.Windows.Forms.RadioButton
    Friend WithEvents WPas As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WPa As System.Windows.Forms.NumericUpDown
    Friend WithEvents Rechnen As System.Windows.Forms.CheckBox
End Class
