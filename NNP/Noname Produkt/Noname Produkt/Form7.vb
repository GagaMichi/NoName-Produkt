Public Class CDK
    Public Loc As Integer = -70
    Public Pos As Integer = 0
    Public SPC As Integer = 0
    Private Sub TCDK_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCDK.Tick
        If Pos = 0 Then
            Loc = Loc - -1
            If Loc = 0 Then
                TCDK.Stop()
                Pos = 1
                Form1.CBA.Text = "CountdownBox ausblenden"
            End If
        ElseIf Pos = 1 Then
            Loc = Loc - 1
            If Loc = -70 Then
                TCDK.Stop()
                Pos = 0
                SPC = 0
                Form1.CBA.Text = "CountdownBox anzeigen"
            End If
        End If
        Me.Location = New Point(0, Loc)
    End Sub


    Private Sub CDK_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        STCDK.Start()
    End Sub

    Private Sub CDK_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        TCDK.Start()
    End Sub

    Private Sub STCDK_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STCDK.Tick
        If SPC = 0 Then
            Loc = Loc - 1
            If Loc = -60 Then
                STCDK.Stop()
                SPC = 1
            End If
        ElseIf SPC = 1 Then
            Loc = Loc - -1
            If Loc = 0 Then
                STCDK.Stop()
                SPC = 0
            End If
        End If
        Me.Location = New Point(0, Loc)
    End Sub

    Private Sub CDKC_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CDKC.MouseClick
        STCDK.Start()
    End Sub

    Private Sub CDKC_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CDKC.MouseDoubleClick
        TCDK.Start()
    End Sub

    Private Sub P1_MouseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P1.MouseClick
        STCDK.Start()
    End Sub
End Class