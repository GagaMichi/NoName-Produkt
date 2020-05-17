Public Class Knastzeit
    Dim WPasD As Integer
    Dim WP As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(WPa.Text) Then
            If WP69.Checked Then
                WP = 7760
            ElseIf WP61.Checked Then
                WP = 6810
            ElseIf WP35.Checked Then
                WP = 2550
            ElseIf WP15.Checked Then
                WP = 1100
            ElseIf WP10.Checked Then
                WP = 730
            ElseIf WPb.Checked Then
                WP = WPasD
            End If

            Form1.KZ.Text = WP
            On Error Resume Next
            Form1.Status.Text = "Gefangen"
            Form1.Status.BackColor = Color.Red
            Form1.P1.Maximum = Form1.KZ.Text
            CDK.P1.Maximum = Form1.P1.Maximum
            Form1.P1.Value = "0"
            Form1.KMi.Text = Form1.KZ.Text / 60
            Form1.KMi.Text = Now.Minute + Form1.KMi.Text
            Form1.KSt.Text = Now.Hour
            Do
                Form1.KSt.Text = Form1.KSt.Text + 1
                Form1.KMi.Text = Form1.KMi.Text - 60
            Loop While Form1.KMi.Text > 59
            If Form1.KSt.Text > "23" Then
                Form1.KSt.Text = Form1.KSt.Text - 24
            End If
            If Form1.KSt.Text = "1" Or Form1.KSt.Text = "2" Or Form1.KSt.Text = "3" Or Form1.KSt.Text = "4" Or Form1.KSt.Text = "5" Or Form1.KSt.Text = "6" Or Form1.KSt.Text = "7" Or Form1.KSt.Text = "8" Or Form1.KSt.Text = "9" Or Form1.KSt.Text = "0" Then
                Form1.KSt.Text = "0" & Form1.KSt.Text
            End If
            If Form1.KMi.Text = "1" Or Form1.KMi.Text = "2" Or Form1.KMi.Text = "3" Or Form1.KMi.Text = "4" Or Form1.KMi.Text = "5" Or Form1.KMi.Text = "6" Or Form1.KMi.Text = "7" Or Form1.KMi.Text = "8" Or Form1.KMi.Text = "9" Or Form1.KMi.Text = "0" Then
                Form1.KMi.Text = "0" & Form1.KMi.Text
            End If
            If Form1.KMi.Text.Contains(",") Then
                Form1.KMi.Text = Form1.KMi.Text.Split(",")(0)
            End If
            If Form1.KMi.Text.Contains("-") Then
                Form1.KMi.Text = "60" - -Form1.KMi.Text
            End If
            Form1.TB2.Text = "Du bist um ca. " & Form1.KSt.Text & ":" & Form1.KMi.Text & " Uhr wieder frei."
            Form1.TKnast.Start()
            If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                CDK.TCDK.Start()
            End If
            Me.Hide()
        End If
    End Sub

    Private Sub WPa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WPa.ValueChanged
        If IsNumeric(WPa.Text) Then
            If Rechnen.Checked Then
                WPasD = WPa.Text / 6
                WPasD = WPasD * 7.2
                Math.Round(WPasD, 0)
            Else
                WPasD = WPa.Text - -1
            End If
            WPas.Text = "s -> " & WPasD & "s"
        End If
    End Sub

    Private Sub WPb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WPb.CheckedChanged
        If WPb.Checked = True Then
            WPa.Enabled = True
            Rechnen.Enabled = True
        End If
    End Sub

    Private Sub WP10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WP10.CheckedChanged
        If WPb.Checked = False Then
            WPa.Enabled = False
            Rechnen.Enabled = False
        End If
    End Sub

    Private Sub WP15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WP15.CheckedChanged
        If WPb.Checked = False Then
            WPa.Enabled = False
            Rechnen.Enabled = False
        End If
    End Sub

    Private Sub WP35_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WP35.CheckedChanged
        If WPb.Checked = False Then
            WPa.Enabled = False
            Rechnen.Enabled = False
        End If
    End Sub

    Private Sub WP69_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WP69.CheckedChanged
        If WPb.Checked = False Then
            WPa.Enabled = False
            Rechnen.Enabled = False
        End If
    End Sub

    Private Sub WP61_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WP61.CheckedChanged
        If WPb.Checked = False Then
            WPa.Enabled = False
            Rechnen.Enabled = False
        End If
    End Sub

    Private Sub Rechnen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechnen.CheckedChanged
        If IsNumeric(WPa.Text) Then
            If Rechnen.Checked Then
                WPasD = WPa.Text / 6
                WPasD = WPasD * 7.2
                Math.Round(WPasD, 0)
            Else
                WPasD = WPa.Text - -1
            End If
            WPas.Text = "s -> " & WPasD & "s"
        End If
    End Sub
End Class