Imports System
Imports System.IO
Imports System.Text

Public Class Einstellungen
    Public ChatEnde As Integer
    Dim K As Integer = 800
    Dim KP As Integer = 0
    Dim I As Integer = 800
    Dim IP As Integer = 0
    Dim D As Integer = 800
    Dim DP As Integer = 0
    Dim S As Integer = 800
    Dim SP As Integer = 0
    Dim P As Integer = 800
    Dim PP As Integer = 0
    Dim SZ As Integer = 10
    Dim openFileDialog1 As New OpenFileDialog()
    Dim OpenFolder As New FolderBrowserDialog
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If IngameName.Text = "" Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
            MsgBox("Du musst deinen Ingamename eingeben!")
        Else
            If IsNumeric(Kills.Text) Then
                If Form1.Tode.Text > "0" Then
                    Form1.KD.Text = Form1.Kills.Text / Form1.Tode.Text
                End If
                If Math.Round(5 * (Form1.Level ^ 2 / 3), 0) < Form1.Kills.Text Then
                    Do While Math.Round(5 * (Form1.Level ^ 2 / 3), 0) < Form1.Kills.Text
                        Form1.Level = Form1.Level + 1
                        NNPLevel.Text = Form1.Level
                    Loop
                ElseIf Math.Round(5 * (Form1.Level ^ 2 / 3), 0) > Form1.Kills.Text Then
                    Do While Math.Round(5 * (Form1.Level ^ 2 / 3), 0) > Form1.Kills.Text
                        Form1.Level = Form1.Level - 1
                        NNPLevel.Text = Form1.Level
                    Loop
                End If
                If AusleseReagier.Text = "" Then
                    AusleseReagier.Text = " "
                End If
                If AusleseSende.Text = "" Then
                    AusleseSende.Text = " "
                End If
                If LoginMsc.Text = "" Then
                    LoginMsc.Text = "false"
                End If
                Dim path As String = "C:\Program Files (x86)\NNP\NNP.Gaga"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(Kills.Text & vbCrLf & Form1.Killsh.Text & vbCrLf & Form1.Tode.Text & vbCrLf & Form1.Todeh.Text & vbCrLf & Form1.Datum.Text & vbCrLf & IngameName.Text & vbCrLf & KNB1.Text & vbCrLf & KNS1.Checked & vbCrLf & KNB2.Text & vbCrLf & KNS2.Checked & vbCrLf & KNB3.Text & vbCrLf & KNS3.Checked & vbCrLf & CLPf.Text & vbCrLf & KSp.Text & vbCrLf & KSs.Checked & vbCrLf & Green.Text & vbCrLf & GreenBÄ.Checked & vbCrLf & Gold.Text & vbCrLf & GoldBÄ.Checked & vbCrLf & "Platzhalter" & vbCrLf & "Platzhalter" & vbCrLf & Eisen.Text & vbCrLf & EisenBÄ.Checked & vbCrLf & DrogenE.Checked & vbCrLf & DrogenAA.Checked & vbCrLf & LSD.Text & vbCrLf & LSDBÄ.Checked & vbCrLf & CDKA.Checked & vbCrLf & CDKT.Text & vbCrLf & GTAPfad.Text & vbCrLf & LVL.Checked & vbCrLf & GWKN.Text & vbCrLf & GWKNS.Checked & vbCrLf & VST.Text & vbCrLf & VSS.Text & vbCrLf & KNSGW1.Checked & vbCrLf & KNSGW2.Checked & vbCrLf & KNSGW3.Checked & vbCrLf & HH.Checked & vbCrLf & Form1.Level & vbCrLf & CH.Checked & vbCrLf & HPW.Checked & vbCrLf & OL.Text & vbCrLf & ChatAktiv.Checked & vbCrLf & AusleseReagier.Text & vbCrLf & AusleseSende.Text & vbCrLf & OLPX.Text & vbCrLf & OLPY.Text & vbCrLf & LoginMsc.Text & vbCrLf & Übersicht.Checked & vbCrLf & Noticon.Checked)
                fs.Write(info, 0, info.Length)
                fs.Close()
                Form1.Kills.Text = Kills.Text
                CDK.Opacity = CDKT.Text / 100
                If KSs.Checked = True And KSp.Text = "" Then
                    My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
                    If PP = 1 Then
                    Else
                        TKN.BorderStyle = BorderStyle.None
                        TPF.BorderStyle = BorderStyle.Fixed3D
                        TID.BorderStyle = BorderStyle.None
                        TDE.BorderStyle = BorderStyle.None
                        TSo.BorderStyle = BorderStyle.None
                        If PP = 0 Then
                            TP.Start()
                        End If
                    End If
                    KSs.BackColor = Color.Red
                    KSp.BackColor = Color.Red
                    If (MsgBox("Wenn du keinen KillsoundPfad angegeben hast aber bei Senden den Haken gesetzt hast, kann das zu Komplikationen führen." & vbCrLf & "Möchtest du den Haken jetzt entfernen?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                        KSs.Checked = False
                        KSs.BackColor = Color.Transparent
                        KSp.BackColor = Color.White
                        Button9.PerformClick()
                    End If

                Else
                    Ende.Start()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openFileDialog1.InitialDirectory = CLPf.Text.Split("chatlog.txt")(0)
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            CLPf.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            KSp.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Process.Start(KSp.Text)
        Catch
            MsgBox("Es ist ein Fehler aufgetreten!" & vbCrLf & "Damit das funktioniert solltest du was ändern!", MsgBoxStyle.Critical, "Fehler!")
        End Try
    End Sub

    Private Sub KSs_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KSs.Click
        If KSs.Checked = True Then
            MsgBox("!!Achtung!!" & vbCrLf & "Diese funktion wird dich eventuell bei jedem Kill auf den Desktop werfen!" & vbCrLf & "Wenn du das Programm - welches sich zum abspielen der Datei öffnet - offen lässt," & vbCrLf & "solltest du bei einem Kill im Spiel bleiben.")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Kills.Text = Form1.Kills.Text
        IngameName.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(5)
        KNB1.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(6)
        KNS1.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(7)
        KNB2.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(8)
        KNS2.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(9)
        KNB3.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(10)
        KNS3.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(11)
        CLPf.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(12)
        KSp.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(13)
        KSs.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(14)
        Green.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(15)
        GreenBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(16)
        Gold.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(17)
        GoldBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(18)
        VST2.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(19)
        VSS2.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(20)
        Eisen.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(21)
        EisenBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(22)
        DrogenE.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(23)
        DrogenAA.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(24)
        LSD.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(25)
        LSDBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(26)
        CDKA.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(27)
        CDKT.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(28)
        GTAPfad.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(29)
        LVL.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(30)
        GWKN.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(31)
        GWKNS.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(32)
        VST.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(33)
        VSS.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(34)
        KNSGW1.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(35)
        KNSGW2.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(36)
        KNSGW3.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(37)
        HH.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(38)
        Form1.Level = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(39)
        CH.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(40)
        HPW.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(41)
        OL.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(42)
        ChatAktiv.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(43)
        AusleseReagier.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(44)
        AusleseSende.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(45)
        OLPX.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(46)
        OLPY.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(47)
        LoginMsc.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(48)
        Übersicht.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(49)
        Noticon.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(50)
        Ende.Start()
    End Sub

    Private Sub IngameName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngameName.TextChanged
        IngameName.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WMW.Text = "Erklärung" Then
            MsgBox("Für ein Beispiel musst du eine Bezeichnung auswählen!")
        ElseIf WMW.Text = "[Kills]" Then
            MsgBox("/f Ich habe [Kills] Kills gemacht!" & vbCrLf & vbCrLf & "Chatmeldung:" & vbCrLf & "Ich habe " & Form1.Kills.Text & " Kills gemacht!", 0, "Beispiel - [Kills]")
        ElseIf WMW.Text = "[HKills]" Then
            MsgBox("/f Ich habe heute [HKills] Kills gemacht!" & vbCrLf & vbCrLf & "Chatmeldung:" & vbCrLf & "Ich habe heute " & Form1.Killsh.Text & " Kills gemacht!", 0, "Beispiel - [HKills]")
        ElseIf WMW.Text = "[Ort]" Then
            MsgBox("/f Ich habe [Ort] einen Kill gemacht!" & vbCrLf & vbCrLf & "Chatmeldung:" & vbCrLf & "Ich habe am BSN einen Kill gemacht!", 0, "Beispiel - [Ort]")
        ElseIf WMW.Text = "[HP]" Then
            MsgBox("/f Ich habe mit [HP] hp einen Kill gemacht!" & vbCrLf & vbCrLf & "Chatmeldung:" & vbCrLf & "Ich habe mit 50 hp einen Kill gemacht", 0, "Beispiel - [HP]")
        ElseIf WMW.Text = "[Armour]" Then
            MsgBox("/f Ich habe mit [Armour] Armour einen Kill gemacht!" & vbCrLf & vbCrLf & "Chatmeldung:" & vbCrLf & "Ich habe mit 50 Armour einen Kill gemacht", 0, "Beispiel - [Armour]")
        ElseIf WMW.Text = "[Waffe]" Then
            MsgBox("/f Ich habe jemanden mit [Waffe] getötet!" & vbCrLf & vbCrLf & "Chatmeldung:" & vbCrLf & "Ich habe jemanden mit der Deagle getötet!", 0, "Beispiel - [Waffe]")
        End If
    End Sub
    Private Sub TKN_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKN.Click
        TKN.BorderStyle = BorderStyle.Fixed3D
        TPF.BorderStyle = BorderStyle.None
        TID.BorderStyle = BorderStyle.None
        TDE.BorderStyle = BorderStyle.None
        TSo.BorderStyle = BorderStyle.None
        If KP = 0 Then
            TK.Start()
        End If
    End Sub

    Private Sub TID_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TID.Click
        TKN.BorderStyle = BorderStyle.None
        TPF.BorderStyle = BorderStyle.None
        TID.BorderStyle = BorderStyle.Fixed3D
        TDE.BorderStyle = BorderStyle.None
        TSo.BorderStyle = BorderStyle.None
        If IP = 0 Then
            TI.Start()
        End If
    End Sub

    Private Sub TDE_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDE.Click
        TKN.BorderStyle = BorderStyle.None
        TPF.BorderStyle = BorderStyle.None
        TID.BorderStyle = BorderStyle.None
        TDE.BorderStyle = BorderStyle.Fixed3D
        TSo.BorderStyle = BorderStyle.None
        If DP = 0 Then
            TD.Start()
        End If
    End Sub

    Public Sub Tpf_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPF.Click
        TKN.BorderStyle = BorderStyle.None
        TPF.BorderStyle = BorderStyle.Fixed3D
        TID.BorderStyle = BorderStyle.None
        TDE.BorderStyle = BorderStyle.None
        TSo.BorderStyle = BorderStyle.None
        If PP = 0 Then
            TP.Start()
        End If
    End Sub

    Private Sub Tcb_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSo.Click
        TKN.BorderStyle = BorderStyle.None
        TPF.BorderStyle = BorderStyle.None
        TID.BorderStyle = BorderStyle.None
        TDE.BorderStyle = BorderStyle.None
        TSo.BorderStyle = BorderStyle.Fixed3D
        If SP = 0 Then
            TS.Start()
        End If
    End Sub

    Private Sub TK_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TK.Tick
        If IP = 1 Then
            I = I + 25
            ID.Location = New Point(I, 12)
            If I > 800 Then
                IP = 0
            End If
        ElseIf DP = 1 Then
            D = D + 25
            DE.Location = New Point(D, 12)
            If D > 800 Then
                DP = 0
            End If
        ElseIf SP = 1 Then
            S = S + 25
            So.Location = New Point(S, 12)
            If S > 800 Then
                SP = 0
            End If
        ElseIf PP = 1 Then
            P = P + 25
            PF.Location = New Point(P, 12)
            If P > 800 Then
                PP = 0
            End If
        Else
            K = K - 25
            If K < 130 Then
                TK.Stop()
                KP = 1
            End If
            KN.Location = New Point(K, 12)
        End If
    End Sub

    Private Sub TI_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TI.Tick
        If KP = 1 Then
            K = K + 25
            If K > 800 Then
                KP = 0
            End If
            KN.Location = New Point(K, 12)
        ElseIf DP = 1 Then
            D = D + 25
            DE.Location = New Point(D, 12)
            If D > 800 Then
                DP = 0
            End If
        ElseIf SP = 1 Then
            S = S + 25
            So.Location = New Point(S, 12)
            If S > 800 Then
                SP = 0
            End If
        ElseIf PP = 1 Then
            P = P + 25
            PF.Location = New Point(P, 12)
            If P > 800 Then
                PP = 0
            End If
        Else
            I = I - 25
            ID.Location = New Point(I, 12)
            If I < 130 Then
                TI.Stop()
                IP = 1
            End If
        End If
    End Sub

    Private Sub TP_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TP.Tick
        If KP = 1 Then
            K = K + 25
            If K > 800 Then
                KP = 0
            End If
            KN.Location = New Point(K, 12)
        ElseIf DP = 1 Then
            D = D + 25
            DE.Location = New Point(D, 12)
            If D > 800 Then
                DP = 0
            End If
        ElseIf SP = 1 Then
            S = S + 25
            So.Location = New Point(S, 12)
            If S > 800 Then
                SP = 0
            End If
        ElseIf IP = 1 Then
            I = I + 25
            ID.Location = New Point(I, 12)
            If I > 800 Then
                IP = 0
            End If
        Else
            P = P - 25
            PF.Location = New Point(P, 12)
            If P < 130 Then
                TP.Stop()
                PP = 1
            End If
        End If
    End Sub

    Private Sub TD_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TD.Tick
        If KP = 1 Then
            K = K + 25
            If K > 800 Then
                KP = 0
            End If
            KN.Location = New Point(K, 12)
        ElseIf IP = 1 Then
            I = I + 25
            ID.Location = New Point(I, 12)
            If I > 800 Then
                IP = 0
            End If
        ElseIf SP = 1 Then
            S = S + 25
            So.Location = New Point(S, 12)
            If S > 800 Then
                SP = 0
            End If
        ElseIf PP = 1 Then
            P = P + 25
            PF.Location = New Point(P, 12)
            If P > 800 Then
                PP = 0
            End If
        Else
            D = D - 25
            DE.Location = New Point(D, 12)
            If D < 130 Then
                TD.Stop()
                DP = 1
            End If
        End If
    End Sub

    Private Sub TS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS.Tick
        If KP = 1 Then
            K = K + 25
            If K > 800 Then
                KP = 0
            End If
            KN.Location = New Point(K, 12)
        ElseIf IP = 1 Then
            I = I + 25
            ID.Location = New Point(I, 12)
            If I > 800 Then
                IP = 0
            End If
        ElseIf DP = 1 Then
            D = D + 25
            DE.Location = New Point(D, 12)
            If D > 800 Then
                DP = 0
            End If
        ElseIf PP = 1 Then
            P = P + 25
            PF.Location = New Point(P, 12)
            If P > 800 Then
                PP = 0
            End If
        Else
            S = S - 25
            So.Location = New Point(S, 12)
            If S < 130 Then
                TS.Stop()
                SP = 1
            End If
        End If
    End Sub

    Private Sub Start_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Tick
        SZ = SZ + 10
        Me.Size = New Size(808, SZ)
        If SZ > 233 Then
            Start.Stop()
            TK.Start()
        End If
    End Sub

    Private Sub Ende_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ende.Tick
        If KP = 1 Then
            K = K + 25
            If K > 800 Then
                KP = 0
            End If
            KN.Location = New Point(K, 12)
        ElseIf IP = 1 Then
            I = I + 25
            ID.Location = New Point(I, 12)
            If I > 800 Then
                IP = 0
            End If
        ElseIf DP = 1 Then
            D = D + 25
            DE.Location = New Point(D, 12)
            If D > 800 Then
                DP = 0
            End If
        ElseIf PP = 1 Then
            P = P + 25
            PF.Location = New Point(P, 12)
            If P > 800 Then
                PP = 0
            End If
        ElseIf SP = 1 Then
            S = S + 25
            So.Location = New Point(S, 12)
            If S > 800 Then
                SP = 0
            End If
        Else
            SZ = SZ - 10
            Me.Size = New Size(808, SZ)
            If SZ < 11 Then
                Ende.Stop()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(808, 233)
    End Sub

    Private Sub KNS1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KNS1.CheckedChanged
        If KNS1.Checked = True Then
            KNSGW1.Enabled = True
        Else
            KNSGW1.Enabled = False
            If KNSGW1.Checked = True Then
                KNSGW1.Checked = False
            End If
        End If
    End Sub

    Private Sub KNS2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KNS2.CheckedChanged
        If KNS2.Checked = True Then
            KNSGW2.Enabled = True
        Else
            KNSGW2.Enabled = False
            If KNSGW2.Checked = True Then
                KNSGW2.Checked = False
            End If
        End If
    End Sub

    Private Sub KNS3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KNS3.CheckedChanged
        If KNS3.Checked = True Then
            KNSGW3.Enabled = True
        Else
            KNSGW3.Enabled = False
            If KNSGW3.Checked = True Then
                KNSGW3.Checked = False
            End If
        End If
    End Sub

    Private Sub TabControl3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl3.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Sobald das was in der ersten Textbox steht im Chat steht wird der Inhalt der letzten Textbox gesendet." & vbCrLf & vbCrLf & "Kopiere den Text am besten aus der Chatlog.txt." & vbCrLf & "Beachte, das der Teil '[00:00:00] ' nicht mit eingefügt werden darf!", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub ChatAktiv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChatAktiv.MouseClick
        If ChatAktiv.Checked = True Then
            MsgBox("Achtung! Das diese einstellung übernommen wird, musst du das NNP neustarten!", MsgBoxStyle.Critical, "Starte das NNP neu!")
            ChatEnde = 0
        ElseIf ChatAktiv.Checked = False Then
            ChatEnde = 1
        End If
    End Sub


    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Der Chat und alle andere Funktionen welche Zugriff auf die Webseite benötigt haben sind mit der deaktivierung der Webseite nicht mehr Verfügbar!", MsgBoxStyle.Critical, "Nicht Verfügbar!")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If OpenFolder.ShowDialog() = DialogResult.OK Then
            GTAPfad.Text = OpenFolder.SelectedPath
        End If
    End Sub

End Class