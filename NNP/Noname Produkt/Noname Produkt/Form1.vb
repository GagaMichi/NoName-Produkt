'INFO FÜR DIE, DIE SICH DEN CODE ANSCHAUEN
'2014 habe ich - erstmal für mich - angefangen das NNP zu entwickeln, da ich eine Info wollte, wann ich auf Nova wieder lebe.
'Im Laufe der Zeit kamen immer mehr Funktionen dazu - es wurde ein Killzähler-Multitool daraus.
'Mit der Entwicklung des NNPs habe ich die Programmierung in Visual Basic "gelernt", daher ist der Code nicht schön, sehr umständlich und nicht Performance optimiert.
'Wer sich dennoch den Scheiß geben möchte, kann sich gerne umschauen.
'Falls jemand eine Funktion übernehmen möchte, kann er das gerne ohne Rückfragen oder ähnlichem tun, sollte jedoch beachten, dass ich keinerlei Verantwortung übernehme, sollte irgendetwas passieren.







'{FF0000} = Rot
'{00E533} = Grün
'{FFFFFF} = Weiß
'www.html-php-mysql.de/generatoren/colors.php

'Imports Orte
Imports System
Imports System.IO
Imports System.Text
Imports System.IntPtr


    Public Class Form1
        Dim SAMPVersion As New System.IO.FileInfo("C:\Program Files (x86)\Rockstar Games\GTA San Andreas\samp.dll")
        'Ort
        Dim Ort As String = "Fehler"
        Dim SpielerX As Integer
        Dim SpielerY As Integer
        Dim SpielerZ As Integer

        'Overlay
        Dim GPI As Integer = 0
        Dim GPA As Integer = 0
        Dim OverlayStatus As Integer = 0
        Dim Zeile0 As String
        Dim Zeile1 As String
        Dim Zeile2 As String
        Dim Zeile3 As String
        Dim Zeile4 As String
        Dim Zeile5 As String
        Dim Zeile6 As String
        Dim Zeile7 As String

        'Zeile0
        Dim WP0 As String
        Dim WP1 As String
        Dim WP2 As String
        Dim WP3 As String

        'Zeile1
        Dim WP4 As String
        Dim WP5 As String
        Dim WP6 As String
        Dim WP7 As String

        'Zeile2
        Dim WP8 As String
        Dim WP9 As String
        Dim WP10 As String
        Dim WP11 As String

        'Zeile3
        Dim WP12 As String
        Dim WP13 As String
        Dim WP14 As String
        Dim WP15 As String

        'Zeile4
        Dim WP16 As String
        Dim WP17 As String
        Dim WP18 As String
        Dim WP19 As String

        'Zeile5
        Dim WP20 As String
        Dim WP21 As String
        Dim WP22 As String
        Dim WP23 As String

        'Zeile6
        Dim WP24 As String
        Dim WP25 As String
        Dim WP26 As String
        Dim WP27 As String

    'Sonstiges
    Dim sOrt As String
    Dim SchCount As Integer
    Dim Schritt As Integer
    Dim azXorte()
    Dim azYorte()
    Dim azNorte()
    Dim azGorte As Integer
    Dim aXa, aYa, aX, aY, aXz, aYz, aT, aD, aDa, aGa, aGa2, aGa3, aGa4, aGd, aG As Integer
    Dim ÜbOl As Integer
        Dim Abspielen As Boolean = False
        'Dim Swapgun, Swapgunalt As Integer
        Dim KleeblattZeit(3) As Integer
        Dim OverlayGröße As Integer
        Dim MaskenZeit As Integer
        Dim MaskenH, MaskenM, MaskenS As Integer
        Dim LKPX, LKPY As Integer
        Dim LTPX, LTPY As Integer
        Dim DistZiel As String
        Dim DifX As Integer
        Dim DifY As Integer
        Dim Distanz As Integer
        Dim Ordner As New FolderBrowserDialog
        Dim GaganChat As String
        Dim GD As Integer = 0
        Dim HFWP As Integer = -1
        Dim HFID As Integer = -1
        Dim KWWPs As Integer = 0
        Public CSC As String
        Public CSender As String
        Public CText As String
        Public ChatN As String
        Dim NewWPs As Integer
        Dim NewWPler As String
        Dim Bombenzahlen As String
        Dim LEintrag As Integer = 0
        Dim LEintragMax As Integer = 0
        Dim BombenZeit As Integer = 0
        Dim BombenZeitMin As Integer = 0
        Dim KilledWPLer As String
        Dim Streifenpartner As String
        Dim KTZ As Integer
        Dim KG As String
        Dim KGP As Integer
        Dim KFP As Integer
        Dim LottoCP As String
        Dim VLottoCP As String
        Dim UPdateNI As String
        Dim DEStatus As String
        Dim Defizeit As Integer
        Dim Wst As Integer
        Dim Wmi As Integer
        Dim WZeit As Integer
        Dim WaffenID As Integer
        Dim Waffe As String
        Public Level As Integer = 1
        Dim LevelPunkte As Integer = 0
        Dim Carheal As Integer = 0
        Dim CarhealAlt As Integer = 0
        Dim MeText As String
        Dim CLalt As String
        Dim GRF As Integer
        Dim GRFM As Integer
        Dim GRFS As Integer
        Dim NS As String
        Dim NSX As Integer
        Dim NSY As Integer
        Dim SC As Integer = 3
        Dim STo As Integer = 0
        Dim SCD As Integer
        Dim Smarkt As String
        Dim SMF As String
        Dim SMS As String
    Dim LSDZ As Integer = 110
        Dim AEName As String
        Dim AELevel As String
        Dim AEMorde As Integer
        Dim AEG As Integer = 0
        Dim X As Single
        Dim Y As Single
        Dim Z As Single
        Dim Armour As Integer = 1
        Dim ArmourAlt As Integer = 1
        Dim Heal As Integer = 1
        Dim HealAlt As Integer = 1
        Dim VSText As String
        Dim VSLoop As Integer
        Dim Chat As String
        Dim KZI2 As Integer
        Dim ITA As Integer = 0
        Dim NewsZ As Integer = 0
        Dim Rnd As New System.Random()
        Dim Lotto As Integer
        Dim VIPLotto As Integer
        Dim TruckingTimerSek As Integer
        Dim WPOverlaySortierSchritt As Integer

        'Overlay C:\Program Files (x86)\NNP\overlay.dll
        Public Declare Sub SetParam Lib "C:\Program Files (x86)\NNP\API.dll" Alias "SetParam" (ByVal _szParamName As String, ByVal _szParamValue As String)
        Public Declare Function TextCreate Lib "C:\Program Files (x86)\NNP\API.dll" Alias "TextCreate" (ByVal font As String, ByVal fontsize As Integer, ByVal bbold As Boolean, ByVal bitalic As Boolean, ByVal x As Integer, ByVal y As Integer, ByVal color As Integer, ByVal text As String, ByVal shadow As Boolean, ByVal zeichnen As Boolean) As Integer
    Public Declare Function DestroyAllVisual Lib "C:\Program Files (x86)\NNP\API.dll" Alias "DestroyAllVisual" () As Integer
    Public Declare Function TextDestroy Lib "C:\Program Files (x86)\NNP\API.dll" Alias "TextDestroy" (ByVal ID As Integer) As Integer

        'API

    Public Declare Sub SendChat Lib "C:\Program Files (x86)\NNP\API.dll" Alias "SendChat" (ByVal Text As String)
    
    Public Declare Function GetPlayerHealth Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerHealth" () As Integer
    Public Declare Function GetPlayerArmour Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerArmor" () As Integer
    Public Declare Function GetVehicleHealth Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetVehicleHealth" () As String
    Public Declare Function PosX Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerX" (ByRef X As Single) As Integer
    Public Declare Function PosY Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerY" (ByRef Y As Single) As Integer
    Public Declare Function PosZ Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerZ" (ByRef Z As Single) As Integer
    Public Declare Function GetPlayerPos Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerPosition" (ByRef X As Single, ByRef Y As Single, ByRef Z As Single) As Integer
    Public Declare Sub AddChatMessage Lib "C:\Program Files (x86)\NNP\API.dll" Alias "AddChatMessage" (ByVal Text As String)
    
    Public Declare Function Interior Lib "C:\Program Files (x86)\NNP\API.dll" Alias "IsPlayerInAnyInterior" () As Integer
    Public Declare Function InteriorID Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerInteriorID" () As Integer
    Public Declare Sub ShowGameText Lib "C:\Program Files (x86)\NNP\API.dll" Alias "ShowGameText" (ByVal Text As String, ByVal Zeit As Integer, ByVal Style As Integer)
    Public Declare Function GetZoneName Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetZoneName" (ByRef ZoneName As String) As Integer
    Public Declare Function GetCityName Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetCityName" (ByRef CityName As String) As Integer
    Public Declare Function IsPlayerInAnyVehicle Lib "C:\Program Files (x86)\NNP\API.dll" Alias "IsPlayerInAnyVehicle" () As Integer
    Public Declare Function GetPlayerWeaponID Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerWeaponID" () As Integer
    Public Declare Function GPPing Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerPing" () As Integer
    Public Declare Function APIShowDialog Lib "C:\Program Files (x86)\NNP\API.dll" Alias "ShowDialog" (ByVal Style As Integer, ByVal Title As String, ByVal Text As String, ByVal Knopf As String) As Integer
    Public Declare Sub GetPlayerName Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerName" (ByRef Name As String)
    'Public Declare Function IsPlayerInRangeOfPoint Lib "C:\Program Files (x86)\NNP\API.dll" Alias "IsPlayerInRangeOfPoint" (ByVal radius As Single, ByVal x As Single, ByVal y As Single, ByVal z As Single) As Integer
    'Public Declare Function IsPlayerPassenger Lib "C:\Program Files (x86)\NNP\API.dll" Alias "IsPlayerPassenger" () As Integer

    'Public Declare Function GetVehicleModelID Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetVehicleModelID" () As Integer
    'Public Declare Sub GetPlayerMoney Lib "C:\Program Files (x86)\NNP\API.dll" Alias "GetPlayerMoney" (ByRef Geld As String)




    Private Sub TCL_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCL.Tick

        Try
            If IO.File.Exists(Einstellungen.CLPf.Text) Then

                If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length < 50 And Abspielen = False And Not Einstellungen.LoginMsc.Text = "false" Then
                    Abspieler.Url = New Uri(Einstellungen.LoginMsc.Text)
                    Abspielen = True
                    Status.Text = "Login"
                    Status.BackColor = Color.Aqua
                End If

                If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length > 75 Then

                    If Einstellungen.HH.Checked = True Then
                        ArmourAlt = Armour

                        HealAlt = Heal

                        Armour = GetPlayerArmour

                        Heal = GetPlayerHealth
                    End If
                    If Einstellungen.CH.Checked = True Then
                        CarhealAlt = Carheal

                        Carheal = GetVehicleHealth

                    End If

                    'Swapgun
                    'ABREAGE OBS AKTIVIERT IST
                    'Swapgunalt = Swapgun
                    'Swapgun = IsPlayerInAnyVehicle
                    'If Not Swapgun = Swapgunalt Then
                    'If IsPlayerPassenger Then
                    'SendChat("/Swapgun")
                    'System.Threading.Thread.Sleep("500")
                    'My.Computer.Keyboard.SendKeys("{down}{down}{enter}")
                    'End If
                    'End If

                    'Sekunden und so

                    If Now.Hour = 21 And Now.Minute = 0 And Now.Second = 0 Then
                        AddChatMessage("Es ist jetzt {00E533}21 Uhr{FFFFFF}. Bitte denke an die Lichtpflicht! (/cveh Licht)")
                        System.Threading.Thread.Sleep("1000")
                    End If
                    If Now.Minute = 0 And Now.Second = 2 Then
                        If Not Einstellungen.IngameName.Text = SpielerName.Text And Not SpielerName.Text = "Fehler!" Then
                            AddChatMessage("{FF3333}NNP Info: {FFFFFF} Bitte stelle deinen Ingamename korrekt ein!")
                            System.Threading.Thread.Sleep("1000")
                        End If
                    End If
                    If Now.Minute = 10 Then
                        If Now.Second = 30 And SCDT.Enabled Then
                            SCD = 0
                            SCDT.Stop()
                        End If
                    End If
                    If Now.Minute = 0 And Now.Second = 4 And Einstellungen.IngameName.Text = "" Then
                        AddChatMessage("{FF0000}Achtung! {FFFFFF}Du hast keinen Ingamename angegen. Gib jetzt {00E533}/echo AE{FFFFFF} ein.")
                        System.Threading.Thread.Sleep("1000")
                    End If




CLWirderholen:
                    'Try
                    CLalt = CL.Text
                    CL.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text, System.Text.Encoding.Default)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2)
                    'Catch ex As Exception
                    'MsgBox(ex)
                    'GoTo CLWirderholen
                    'End Try

                    'Try


                    'EInloggmusik Stop
                    If Abspielen = True Then
                        If System.IO.File.ReadAllText(Einstellungen.CLPf.Text).ToLower.Contains("willkommen") Then
                            Abspielen = False
                            Abspieler.Url = New Uri("")
                            Status.Text = "Frei/lebend"
                            Status.BackColor = Color.Green
                        End If
                    End If




                    If Not CLalt = CL.Text Or Not Heal = HealAlt Or Not Armour = ArmourAlt Or Not Carheal = CarhealAlt Then
                        LCÄ.Text = CL.Text.Split(" ")(0).Split("[")(1).Split("]")(0)
                        'Ab hier 'Code
                        '##########__############__##########____##########
                        '##########__############__###########___##########
                        '####________####____####__####____####__####______
                        '####________####____####__####____####__##########
                        '####________####____####__####____####__##########
                        '####________####____####__####____####__####______
                        '##########__############__###########___##########
                        '##########__############__##########____##########


                        'Ankunfttimer
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}AT" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}Schreibe '{00E533}/echo AT [S/[NUMMER]]{FFFFFF}'.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}AT ") Then

                            If IsNumeric(CL.Text.Split(" ")(3)) Then
                                CheckATz(CL.Text.Split(" ")(3) - 1)
                            Else
                                AddChatMessage("Bitte gib den Anfangsbuchstaben des gesuchten Ortes ein (* für alle " & azGorte & " Orte):")
                                My.Computer.Keyboard.SendKeys("t/echo ATS ")
                            End If

                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}ATS ") Then
                            sOrt = CL.Text.ToUpper.Split(" ")(3)
                            If sOrt.Length = 1 Then
                                Schritt = 0
                                SchCount = 0
                                Do Until Schritt + 1 = azGorte
                                    If Not sOrt = "*" Then
                                        If azNorte(Schritt).ToString.Substring(0, 1) = sOrt Then
                                            AddChatMessage("{00e533}" & Schritt + 1 & "{FFFFFF} - {FF0000}" & azNorte(Schritt))
                                            SchCount += 1
                                        End If
                                    Else
                                        SchCount += 1
                                        AddChatMessage("{00e533}" & Schritt + 1 & "{FFFFFF} - {FF0000}" & azNorte(Schritt))
                                    End If
                                    Schritt += 1
                                Loop
                                AddChatMessage("Deine Suche nach Orten mit dem Buchstaben {FF0000}" & sOrt & "{FFFFFF} ergab {00e533}" & SchCount & "{FFFFFF} ergebnisse.")
                            Else
                                AddChatMessage("{FF3333}Fehler! {FFFFFF}Gib nur {00E533}1{FFFFFF} Buchstaben an!")
                            End If

                        End If
                        'Kleeblatt
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] INFO:{FFFFFF} Deine Friedhofszeit wird nun für 5 Stunden um 2 Minuten gesenkt." Then
                            KleeblattZeit(1) = Now.Hour
                            KleeblattZeit(2) = Now.Minute
                            KleeblattZeit(3) = Now.Second
                            AddChatMessage("{00E533}NNP Kleeblatt Info: {FFFFFF}Du bist bis " & (Now.Hour + 5) & " 2 Minuten weniger auf dem Friedhof.")
                            AddChatMessage("Debugging: " & ((KleeblattZeit(1) * 3600) + (KleeblattZeit(2) * 60) + KleeblattZeit(3) + 18000) >= ((Now.Hour * 3600) + (Now.Minute * 60) + Now.Second))
                        End If

                        'Flucht
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}FLUCHT" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}Schreibe '{00E533}/echo Flucht [ID]{FFFFFF}'.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}FLUCHT ") Then
                            HFID = CL.Text.Split(" ")(3)
                            SendChat("/checkwanted " & HFID)
                            System.Threading.Thread.Sleep("150")
                            HFWP = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Split(" ")(4)
                            If IsNumeric(HFWP) Then
                                If HFWP - -5 > 35 Then
                                    AddChatMessage("Diese Person hat bereits {FF0000}" & HFWP & " WPs{FFFFFF} und kann deshalb nicht mehr erhalten.")
                                Else
                                    SendChat("/su " & HFID & " " & HFWP - -5 & " Flucht (" & HFWP & " WPs -> " & HFWP - -5 & " WPs)")
                                End If
                            Else
                                AddChatMessage("{FF3333}Fehler! {FFFFFF}Es ist ein Fehler aufgetreten! Versuchs nochmal!")
                            End If
                        End If
                        'Truck Timer
                        If CL.Text.Contains("[" & TimeOfDay & "] Du kannst erst in ") And CL.Text.Contains(" Sekunden) eine neue Mission beginnen!") Then
                            TruckingTimerSek = CL.Text.Split("(")(1).Split(" ")(0)
                            TruckingTimerSek = Math.Round(TruckingTimerSek * 1.02, 0)
                            TruckingTimer.Start()
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Diese Zeit hängt von deinem Truckerlevel ab. Umso höher das Level, desto weniger musst du warten." Then
                            'If CL.Text.Contains("[" & TimeOfDay & "] Du kannst erst in ") And CL.Text.Contains(" Sekunden) eine neue Mission beginnen!") Then
                            TruckingTimerSek = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text, System.Text.Encoding.Default)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split("(")(1).Split(" ")(0)
                            TruckingTimerSek = Math.Round(TruckingTimerSek * 1.02, 0)
                            TruckingTimer.Start()
                        End If
                        'Oamt
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}OAMT" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}Schreibe '{00E533}/echo OAMT [Fraktion] [Fahrzeug]{FFFFFF}'.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}OAMT ") Then
                            Orte()
                            SendChat("/d " & CL.Text.Split(" ")(3) & ", wird das Fahrzeug " & CL.Text.Split(" ")(4) & " " & Ort & " noch gebraucht?")
                        End If
                        'Maske
                        If CL.Text = "[" & TimeOfDay & "] * " & Einstellungen.IngameName.Text & " zieht seine Sturmhaube ab." Then
                            MaskenTimer.Stop()
                            TB1.Text = ""
                            TB2.Text = ""
                        End If
                        If CL.Text = "[" & TimeOfDay & "] * " & Einstellungen.IngameName.Text & " zieht sich eine Sturmhaube auf." Then
                            MaskenZeit = 1224
                            MaskenTimer.Start()

                            MaskenH = Now.Hour
                            MaskenM = Now.Minute
                            MaskenS = Now.Second + MaskenZeit
                            Do While MaskenS > 60
                                MaskenS -= 60
                                MaskenM += 1
                            Loop
                            Do While MaskenM > 60
                                MaskenM -= 60
                                MaskenH += 1
                            Loop
                            TB1.Text = "Maskiert bis " & MaskenH & ":" & MaskenM & ":" & MaskenS & " Uhr."
                            AddChatMessage("{FF0000}Achtung! {FFFFFF} Deine Maske läuft um {FF0000}" & MaskenH & ":" & MaskenM & ":" & MaskenS & " Uhr{FFFFFF} ({00E533}" & MaskenZeit & " sekunden{FFFFFF}) ab!")
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] * Deine Sturmhaube hält noch ") Then
                            MaskenZeit = CL.Text.Split(" ")(6)
                            MaskenZeit = MaskenZeit + Math.Round(MaskenZeit * 0.02, 0)
                            MaskenTimer.Start()

                            MaskenH = Now.Hour
                            MaskenM = Now.Minute
                            MaskenS = Now.Second + MaskenZeit
                            Do While MaskenS > 59
                                MaskenS -= 60
                                MaskenM += 1
                            Loop
                            Do While MaskenM > 59
                                MaskenM -= 60
                                MaskenH += 1
                            Loop
                            TB1.Text = "Maskiert bis " & MaskenH & ":" & MaskenM & ":" & MaskenS & " Uhr."
                            AddChatMessage("{FF0000}Achtung! {FFFFFF} Deine Maske läuft um {FF0000}" & MaskenH & ":" & MaskenM & ":" & MaskenS & " Uhr{FFFFFF} ({00E533}" & MaskenZeit & " sekunden{FFFFFF}) ab!")
                        End If

                        'Sex
                        If CL.Text.Contains("[" & TimeOfDay & "] * Die Hure ") And CL.Text.Contains(" hat dir Sex für $1 angeboten.(/accept sex)") Then
                            If GetPlayerHealth < 100 Then
                                SendChat("/accept sex")
                                System.Threading.Thread.Sleep("1000")
                            Else
                                SendChat("/cc Ich habe genug leben und brauche kein Sex!")
                                System.Threading.Thread.Sleep("1000")
                            End If
                        End If
                        'Todes und Kill Posi
                        If Einstellungen.HH.Checked = True Then
                            If Heal <= 0 Then
                                GetPlayerPos(LTPX, LTPY, Z)
                                System.Threading.Thread.Sleep("1000")
                            End If
                            If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}LTP" Then
                                If Not LTPX = 0 And Not LTPY = 0 Then
                                    GetPlayerPos(X, Y, Z)
                                    DifX = X - LTPX
                                    DifY = Y - LTPY
                                    Distanz = Math.Sqrt(DifX ^ 2 - -DifY ^ 2)
                                    AddChatMessage("Distanz bis zum letzten Todespunkt: {00E533}" & Distanz & "{FFFFFF} Meter.")
                                Else
                                    AddChatMessage("{FF3333}Fehler! {FFFFFF}Seit dem Start des NNPs bist du noch kein mal gestorben!")
                                End If
                                System.Threading.Thread.Sleep("1000")
                            End If
                            If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}LKP" Then
                                If Not LKPX = 0 And Not LKPY = 0 Then
                                    GetPlayerPos(X, Y, Z)
                                    DifX = X - LKPX
                                    DifY = Y - LKPY
                                    Distanz = Math.Sqrt(DifX ^ 2 - -DifY ^ 2)
                                    AddChatMessage("Distanz bis zum letzten Killpunkt: {00E533}" & Distanz & "{FFFFFF} Meter.")
                                Else
                                    AddChatMessage("{FF3333}Fehler! {FFFFFF}Seit dem Start des NNPs hast du noch neimanden getötet!")
                                End If
                                System.Threading.Thread.Sleep("1000")
                            End If
                        End If

                        'GagaBefehl
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}GAGA" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}Schreibe '{00E533}/echo GAGA [Chat]{FFFFFF}'.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}GAGA ") Then
                            GaganChat = CL.Text.Split(" ")(3)
                            SendChat("/" & GaganChat & " ############__############__############__############")
                            System.Threading.Thread.Sleep("200")
                            SendChat("/" & GaganChat & " ############__############__############__############")
                            System.Threading.Thread.Sleep("200")
                            SendChat("/" & GaganChat & " ####__________####____####__####__________####____####")
                            System.Threading.Thread.Sleep("200")
                            SendChat("/" & GaganChat & " ####__######__####____####__####__######__####____####")
                            System.Threading.Thread.Sleep("200")
                            SendChat("/" & GaganChat & " ####_____###__############__####_____###__############")
                            System.Threading.Thread.Sleep("200")
                            SendChat("/" & GaganChat & " ############__####____####__############__####____####")
                            System.Threading.Thread.Sleep("200")
                            SendChat("/" & GaganChat & " ############__####____####__############__####____####")
                        End If

                        'Gagan
                        'If CL.Text.Contains("[" & TimeOfDay & "] GagaMichi sagt: " & CSC.ToLower & ", bitte gagan! (") Then
                        'If Not System.IO.File.ReadAllLines(Einstellungen.CLPf.Text, System.Text.Encoding.Default)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains(" flüstert dir:") And CL.Text.Split(":").Count = 4 Then
                        'GaganChat = CL.Text.Split("(")(1).Split(")")(0)
                        'SendChat("/" & GaganChat & " ############__############__############__############")
                        'System.Threading.Thread.Sleep("200")
                        'SendChat("/" & GaganChat & " ############__############__############__############")
                        'System.Threading.Thread.Sleep("200")
                        'SendChat("/" & GaganChat & " ####__________####____####__####__________####____####")
                        'System.Threading.Thread.Sleep("200")
                        'SendChat("/" & GaganChat & " ####__######__####____####__####__######__####____####")
                        'System.Threading.Thread.Sleep("200")
                        'SendChat("/" & GaganChat & " ####_____###__############__####_____###__############")
                        'System.Threading.Thread.Sleep("200")
                        'SendChat("/" & GaganChat & " ############__####____####__############__####____####")
                        'System.Threading.Thread.Sleep("200")
                        'SendChat("/" & GaganChat & " ############__####____####__############__####____####")
                        'End If
                        'End If
                        'BombeFail
                        If CL.Text = "[" & TimeOfDay & "] Die Bombe konnte nicht entschärft werden. Lauf um dein Leben!!!" Then
                            SendChat("/d Durch meinen Skill konnte ich die Bombe erfolgreich zur")
                            SendChat("/d kontrollierten Detonation bringen!")
                            SendChat("/d Ich empfehle das Gebiet schnellst möglich zu verlassen!")
                        End If
                        'UCler
                        If CL.Text = "[" & TimeOfDay & "] HQ: Die Person ist ein Undercover Agent des FBI." Then
                            ShowGameText("~n~~n~~n~~r~Stop! ~w~Das ist einen ~b~FBI Agent~w~!~n~~n~~n~", 2500, 3)
                            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
                        End If
                        'Auslese
                        If Not Einstellungen.AusleseReagier.Text = "" And Not Einstellungen.AusleseSende.Text = "" Then
                            If CL.Text = "[" & TimeOfDay & "] " & Einstellungen.AusleseReagier.Text Then
                                SendChat(Einstellungen.AusleseSende.Text)
                            End If
                        End If
                        'Get Donut
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}GD" Then
                            GD = 0
                            Do Until System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] Soviel kannst du nicht tragen (Inventar voll)." Or System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER: Du besitzt nicht genug Geld!" Or System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "]  Du bist nicht am Donutladen in LS oder SF."
                                SendChat("/get donut 20")
                                System.Threading.Thread.Sleep("300")
                            Loop
                        End If
                        'Hausflucht
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}HF" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}Schreibe '{00E533}/echo HF [ID]{FFFFFF}'.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}HF ") Then
                            HFID = CL.Text.Split(" ")(3)
                            SendChat("/checkwanted " & HFID)
                            System.Threading.Thread.Sleep("150")
                            HFWP = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Split(" ")(4)
                            If IsNumeric(HFWP) Then
                                If HFWP - -20 > 61 Then
                                    SendChat("/su " & HFID & " 61 Hausflucht (" & HFWP & " WPs -> 61 WPs)")
                                Else
                                    SendChat("/su " & HFID & " " & HFWP - -20 & " Innenraumflucht (" & HFWP & " WPs -> " & HFWP - -20 & " WPs)")
                                End If
                            Else
                                AddChatMessage("{FF3333}Fehler! {FFFFFF}Es ist ein Fehler aufgetreten! Versuchs nochmal!")
                            End If
                        End If
                        'Verweigerung
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}VW" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}Schreibe '{00E533}/echo VW [ID]{FFFFFF}'.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}VW ") Then
                            HFID = CL.Text.Split(" ")(3)
                            SendChat("/checkwanted " & HFID)
                            System.Threading.Thread.Sleep("150")
                            HFWP = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Split(" ")(4)
                            If IsNumeric(HFWP) Then
                                If HFWP - -5 > 61 Then
                                    SendChat("/su " & HFID & " 61 Verweigerung (" & HFWP & " WPs -> 61 WPs)")
                                Else
                                    SendChat("/su " & HFID & " " & HFWP - -5 & " Verweigerung (" & HFWP & " WPs -> " & HFWP - -5 & " WPs)")
                                End If
                            Else
                                AddChatMessage("{FF3333}Fehler! {FFFFFF}Es ist ein Fehler aufgetreten! Versuchs nochmal!")
                            End If
                        End If
                        'Chat
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NC" Then
                            AddChatMessage("{FF3333}Achtung: {FFFFFF}der Chat ist nicht mehr Verfügbar!")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}NC ") Then
                            AddChatMessage("{FF3333}Achtung: {FFFFFF}der Chat ist nicht mehr Verfügbar!")
                        End If
                        'Chat Online spieler
                        'If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NO" Then
                        'ChatVNO:
                        'If ChatB.ReadyState = WebBrowserReadyState.Complete Then
                        'AddChatMessage("{00E533}NNP Chat {FFFFFF}Spieler werden Ermittelt.")
                        ' ChatOnline.Refresh()
                        'System.Threading.Thread.Sleep("1000")
                        'NNPChat.Timeout = 0
                        'NNPChat.OP.Start()
                        'Else
                        'GoTo ChatVNO
                        'End If
                        'End If
                        'Bombe
                        If CL.Text = "[" & TimeOfDay & "] BOMBENALARM: Es wurde eine Bombe gelegt!" Then
                            TTod.Stop()
                            Defi.Stop()
                            WaffenTimer.Stop()
                            TKnast.Stop()
                            TEinbruch.Stop()
                            BombenTimer.Stop()
                            Ende.Stop()
                            Start.Stop()
                            BombenZeit = 300
                            BombenTimer.Start()
                            AddChatMessage("{0033FF}NNP Info - {FFFFFF} schreibe '{00E533}/echo B 5{FFFFFF}/{00E533}10{FFFFFF}/{00E533}15{FFFFFF}' um den Timer dementsprechend zu verlängern.")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}B" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}/echo B {00E533}5{FFFFFF}/{00E533}10{FFFFFF}/{00E533}15{FFFFFF}.")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] {CC210A}SERVER:{FFFFFF} Du hast gerade einen Mord begangen. Achtung!" Then
                            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] <<Beamter " & Einstellungen.IngameName.Text & " hat die gesuchte Person ") Then
                                If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Contains("[" & TimeOfDay & "] Folgende Ziffern wurden fallen gelassen: ") Then
                                    Bombenzahlen = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split(" ")(6) & " " & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split(" ")(8) & " " & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split(" ")(10)
                                    SendChat("/d Der Code zum entschärfen der Bombe lautet: " & Bombenzahlen)
                                    SendChat("/d Der Code zum entschärfen der Bombe lautet: " & Bombenzahlen)
                                End If
                            Else
                                If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] Folgende Ziffern wurden fallen gelassen: ") Then
                                    Bombenzahlen = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(6) & " " & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(8) & " " & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(10)
                                    SendChat("/d Der Code zum entschärfen der Bombe lautet: " & Bombenzahlen)
                                    SendChat("/d Der Code zum entschärfen der Bombe lautet: " & Bombenzahlen)
                                End If
                            End If
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}B ") Then
                            BombenZeitMin = CL.Text.Split(" ")(3)
                            If BombenZeitMin = 5 Or BombenZeitMin = 10 Or BombenZeitMin = 15 Then
                                If Not BombenZeit > 600 Then
                                    BombenZeit = BombenZeit - -Math.Round(BombenZeitMin * 60, 0)
                                    BombenTimer.Start()
                                    AddChatMessage("{00R533}Erfolgreich!{FFFFFF} Der Bombentimer wurde um {00E533}" & BombenZeitMin & "{FFFFFF} Minuten verlängert.")
                                Else
                                    AddChatMessage("{FF3333}Fehler!{FFFFFF} Der Bombentimer kann nicht weiter erhöht werden!")
                                End If
                            Else
                                AddChatMessage("{FF3333}Fehler! {FFFFFF}/echo B {00E533}5{FFFFFF}/{00E533}10{FFFFFF}/{00E533}15{FFFFFF}.")
                            End If
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}BOMBE" Then
                            AddChatMessage("{FF3333}Fehler! {FFFFFF}/echo Bombe {00E533}5{FFFFFF}/{00E533}10{FFFFFF}/{00E533}15{FFFFFF}/{00E533}20{FFFFFF}.")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}BOMBE ") Then
                            BombenZeitMin = CL.Text.Split(" ")(3)
                            If BombenZeitMin = 5 Or BombenZeitMin = 10 Or BombenZeitMin = 15 Or BombenZeitMin = 20 Then
                                BombenZeit = BombenZeitMin * 60
                                BombenTimer.Start()
                                AddChatMessage("{0033FF}NNP Info - {FFFFFF} schreibe '{00E533}/echo B 5{FFFFFF}/{00E533}10{FFFFFF}/{00E533}15{FFFFFF}' um den Timer dementsprechend zu verlängern.")
                            Else
                                AddChatMessage("{FF3333}Fehler! {FFFFFF}/echo Bombe {00E533}5{FFFFFF}/{00E533}10{FFFFFF}/{00E533}15{FFFFFF}/{00E533}20{FFFFFF}.")
                            End If
                        End If
                        'Kriegsinfo
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}KI" Then
                            SendChat("/warinfo")
                            System.Threading.Thread.Sleep("200")
                            CL.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2)
                            If CL.Text.Contains("Deine Fraktion hat Krieg mit") Then
                                KG = CL.Text.Split(" ")(6)
                                If KG = "Ballas" Then
                                    KG = "Ballas Family"
                                ElseIf KG = "Los" Then
                                    KG = "Los Vagos"
                                End If
                                KGP = CL.Text.Split(" ")(14)
                                KFP = CL.Text.Split(" ")(12).Split(",")(0)
                                SendChat("/f Kriegsinfo (Krieg gegen die " & KG & "):")
                                KTZ = KGP - KFP
                                KTZ = KTZ.ToString.Replace("-", "")
                                SendChat("/f Es müssen noch " & KGP & " Gegner und " & KFP & " Member sterben! Differenz: " & KTZ & " Kills")
                                If KGP > KFP Then
                                    SendChat("/f Wir sind am verlieren")
                                ElseIf KGP < KFP Then
                                    SendChat("/f Wir sind am gewinnen")
                                End If
                            Else
                                AddChatMessage(CL.Text)
                            End If
                        End If

                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}PD" Then
                            AddChatMessage("{FF3333}Fehler!{FFFFFF} Schreibe '{00E533}/echo PD [Partner1],[Partner2],...{FFFFFF}'")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}PD ") Then
                            Orte()
                            Streifenpartner = CL.Text.Split(" ")(3)
                            Streifenpartner = Streifenpartner.ToString.Replace(",", ", ")
                            SendChat("/r " & Einstellungen.IngameName.Text & ", " & Streifenpartner & ".")
                            SendChat("/r Unterwegs " & Ort & " | Onduty")


                        End If

                        If Not Einstellungen.OL.Text = "Aus" Then
                            'Overlay
                            'Zeilen
                            Zeile7 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 16)
                            Zeile6 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 14)
                            Zeile5 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 12)
                            Zeile4 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 10)
                            Zeile3 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 8)
                            Zeile2 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6)
                            Zeile1 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4)
                            Zeile0 = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2)

                            'WPOverlay


                            WPOverlayZeugs()

                        End If
                        'Overlay WPler hinziufügen
                        If Not Einstellungen.OL.Text = "Aus" Then
                            If OverlayStatus = 1 Then
                                If CL.Text = "[" & TimeOfDay & "] Du hast dem Spieler Wantedpunkte gegeben!" Then
                                    CL.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4)
                                End If
                                If CL.Text.Contains("[" & TimeOfDay & "] HQ: Verbrechen: ") And CL.Text.Contains(", Gesuchter: ") Then
                                    '[15:53:52] HQ: Verbrechen: MORD, Gesuchter: JetTee
                                    NewWPler = CL.Text.Split(" ")(CL.Text.Split(" ").Count - 1)
                                    '[16:17:55] HQ: {FFFFFF}Nefret hat 0 Wantedpunkte und somit Wantedlevel: 0, over.
                                    If Not TTod.Enabled Then
                                        SendChat("/checkwanted " & NewWPler)
                                        System.Threading.Thread.Sleep("150")
                                        NewWPs = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Split(" ")(4)
                                    Else
                                        NewWPs = "??"
                                    End If
                                    If NewWPs > 14 Then


                                        If Not WP0.Split(" ")(0) = NewWPler And Not WP1.Split(" ")(0) = NewWPler And Not WP2.Split(" ")(0) = NewWPler And Not WP3.Split(" ")(0) = NewWPler And Not WP4.Split(" ")(0) = NewWPler And Not WP5.Split(" ")(0) = NewWPler And Not WP6.Split(" ")(0) = NewWPler And Not WP7.Split(" ")(0) = NewWPler And Not WP8.Split(" ")(0) = NewWPler And Not WP9.Split(" ")(0) = NewWPler And Not WP10.Split(" ")(0) = NewWPler And Not WP11.Split(" ")(0) = NewWPler And Not WP12.Split(" ")(0) = NewWPler And Not WP13.Split(" ")(0) = NewWPler And Not WP14.Split(" ")(0) = NewWPler And Not WP15.Split(" ")(0) = NewWPler And Not WP16.Split(" ")(0) = NewWPler And Not WP17.Split(" ")(0) = NewWPler And Not WP18.Split(" ")(0) = NewWPler And Not WP19.Split(" ")(0) = NewWPler And Not WP20.Split(" ")(0) = NewWPler And Not WP21.Split(" ")(0) = NewWPler And Not WP22.Split(" ")(0) = NewWPler And Not WP23.Split(" ")(0) = NewWPler And Not WP24.Split(" ")(0) = NewWPler And Not WP25.Split(" ")(0) = NewWPler And Not WP26.Split(" ")(0) = NewWPler And Not WP27.Split(" ")(0) = NewWPler Then
                                            If WP0 = "" Then
                                                WP0 = NewWPler & " - " & NewWPs
                                            ElseIf WP1 = "" Then
                                                WP1 = NewWPler & " - " & NewWPs
                                            ElseIf WP2 = "" Then
                                                WP2 = NewWPler & " - " & NewWPs
                                            ElseIf WP3 = "" Then
                                                WP3 = NewWPler & " - " & NewWPs
                                            ElseIf WP4 = "" Then
                                                WP4 = NewWPler & " - " & NewWPs
                                            ElseIf WP5 = "" Then
                                                WP5 = NewWPler & " - " & NewWPs
                                            ElseIf WP6 = "" Then
                                                WP6 = NewWPler & " - " & NewWPs
                                            ElseIf WP7 = "" Then
                                                WP7 = NewWPler & " - " & NewWPs
                                            ElseIf WP8 = "" Then
                                                WP8 = NewWPler & " - " & NewWPs
                                            ElseIf WP9 = "" Then
                                                WP9 = NewWPler & " - " & NewWPs
                                            ElseIf WP10 = "" Then
                                                WP1 = NewWPler & " - " & NewWPs
                                            ElseIf WP11 = "" Then
                                                WP11 = NewWPler & " - " & NewWPs
                                            ElseIf WP12 = "" Then
                                                WP12 = NewWPler & " - " & NewWPs
                                            ElseIf WP13 = "" Then
                                                WP13 = NewWPler & " - " & NewWPs
                                            ElseIf WP14 = "" Then
                                                WP14 = NewWPler & " - " & NewWPs
                                            ElseIf WP15 = "" Then
                                                WP15 = NewWPler & " - " & NewWPs
                                            ElseIf WP16 = "" Then
                                                WP16 = NewWPler & " - " & NewWPs
                                            ElseIf WP17 = "" Then
                                                WP17 = NewWPler & " - " & NewWPs
                                            ElseIf WP18 = "" Then
                                                WP18 = NewWPler & " - " & NewWPs
                                            ElseIf WP19 = "" Then
                                                WP19 = NewWPler & " - " & NewWPs
                                            ElseIf WP20 = "" Then
                                                WP20 = NewWPler & " - " & NewWPs
                                            ElseIf WP21 = "" Then
                                                WP21 = NewWPler & " - " & NewWPs
                                            ElseIf WP22 = "" Then
                                                WP22 = NewWPler & " - " & NewWPs
                                            ElseIf WP23 = "" Then
                                                WP23 = NewWPler & " - " & NewWPs
                                            ElseIf WP24 = "" Then
                                                WP24 = NewWPler & " - " & NewWPs
                                            ElseIf WP25 = "" Then
                                                WP25 = NewWPler & " - " & NewWPs
                                            ElseIf WP26 = "" Then
                                                WP26 = NewWPler & " - " & NewWPs
                                            ElseIf WP27 = "" Then
                                                WP27 = NewWPler & " - " & NewWPs
                                            End If
                                            AddChatMessage("Gesuchte Person {00E533}" & NewWPler & " {FFFFFF} wurde mit {00E533}" & NewWPs & " WPs {FFFFFF}hinzugefügt!")
                                        Else
                                            If WP0.Split(" ")(0) = NewWPler Then
                                                WP0 = NewWPler & " - " & NewWPs
                                            ElseIf WP1.Split(" ")(0) = NewWPler Then
                                                WP1 = NewWPler & " - " & NewWPs
                                            ElseIf WP2.Split(" ")(0) = NewWPler Then
                                                WP2 = NewWPler & " - " & NewWPs
                                            ElseIf WP3.Split(" ")(0) = NewWPler Then
                                                WP3 = NewWPler & " - " & NewWPs
                                            ElseIf WP4.Split(" ")(0) = NewWPler Then
                                                WP4 = NewWPler & " - " & NewWPs
                                            ElseIf WP5.Split(" ")(0) = NewWPler Then
                                                WP5 = NewWPler & " - " & NewWPs
                                            ElseIf WP6.Split(" ")(0) = NewWPler Then
                                                WP6 = NewWPler & " - " & NewWPs
                                            ElseIf WP7.Split(" ")(0) = NewWPler Then
                                                WP7 = NewWPler & " - " & NewWPs
                                            ElseIf WP8.Split(" ")(0) = NewWPler Then
                                                WP8 = NewWPler & " - " & NewWPs
                                            ElseIf WP9.Split(" ")(0) = NewWPler Then
                                                WP9 = NewWPler & " - " & NewWPs
                                            ElseIf WP10.Split(" ")(0) = NewWPler Then
                                                WP10 = NewWPler & " - " & NewWPs
                                            ElseIf WP11.Split(" ")(0) = NewWPler Then
                                                WP11 = NewWPler & " - " & NewWPs
                                            ElseIf WP12.Split(" ")(0) = NewWPler Then
                                                WP12 = NewWPler & " - " & NewWPs
                                            ElseIf WP13.Split(" ")(0) = NewWPler Then
                                                WP13 = NewWPler & " - " & NewWPs
                                            ElseIf WP14.Split(" ")(0) = NewWPler Then
                                                WP14 = NewWPler & " - " & NewWPs
                                            ElseIf WP15.Split(" ")(0) = NewWPler Then
                                                WP15 = NewWPler & " - " & NewWPs
                                            ElseIf WP16.Split(" ")(0) = NewWPler Then
                                                WP16 = NewWPler & " - " & NewWPs
                                            ElseIf WP17.Split(" ")(0) = NewWPler Then
                                                WP17 = NewWPler & " - " & NewWPs
                                            ElseIf WP18.Split(" ")(0) = NewWPler Then
                                                WP18 = NewWPler & " - " & NewWPs
                                            ElseIf WP19.Split(" ")(0) = NewWPler Then
                                                WP19 = NewWPler & " - " & NewWPs
                                            ElseIf WP20.Split(" ")(0) = NewWPler Then
                                                WP20 = NewWPler & " - " & NewWPs
                                            ElseIf WP21.Split(" ")(0) = NewWPler Then
                                                WP21 = NewWPler & " - " & NewWPs
                                            ElseIf WP22.Split(" ")(0) = NewWPler Then
                                                WP22 = NewWPler & " - " & NewWPs
                                            ElseIf WP23.Split(" ")(0) = NewWPler Then
                                                WP23 = NewWPler & " - " & NewWPs
                                            ElseIf WP24.Split(" ")(0) = NewWPler Then
                                                WP24 = NewWPler & " - " & NewWPs
                                            ElseIf WP25.Split(" ")(0) = NewWPler Then
                                                WP25 = NewWPler & " - " & NewWPs
                                            ElseIf WP26.Split(" ")(0) = NewWPler Then
                                                WP26 = NewWPler & " - " & NewWPs
                                            ElseIf WP27.Split(" ")(0) = NewWPler Then
                                                WP27 = NewWPler & " - " & NewWPs
                                            End If
                                            AddChatMessage("Gesuchte Person {00E533}" & NewWPler & " {FFFFFF} wurde aktualisiert! (Auf {00E533}" & NewWPs & " WPs{FFFFFF}!)")
                                        End If
                                    End If


                                    DestroyAllVisual()

                                    OverlayErstellen()


                                End If
                            End If
                        End If
                        'Overlay WPler löschen
                        If Not Einstellungen.OL.Text = "Aus" Then
                            If OverlayStatus = 1 Then
                                If CL.Text = "[" & TimeOfDay & "] {CC210A}SERVER:{FFFFFF} Du hast gerade einen Mord begangen. Achtung!" Then
                                    If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] <<Beamter ") And System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("hat die gesuchte Person ") And System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains(" getötet>>") Then
                                        KilledWPLer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(7)
                                        KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                        WPLöschen()
                                    End If
                                    If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] << Polizist ") And System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains(" eingesperrt >>") Then
                                        KilledWPLer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(5)
                                        KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                        WPLöschen()
                                    End If
                                    If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] << FBI Agent ") And System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains(" eingesperrt >>") Then
                                        KilledWPLer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(6)
                                        KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                        WPLöschen()
                                    End If
                                    If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] << Soldat ") And System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains(" eingesperrt >>") Then
                                        KilledWPLer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(5)
                                        KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                        WPLöschen()
                                    End If
                                End If

                                If CL.Text.Contains("[" & TimeOfDay & "] <<Beamter ") And CL.Text.Contains("hat die gesuchte Person ") And CL.Text.Contains(" getötet>>") Then
                                    KilledWPLer = CL.Text.Split(" ")(7)
                                    KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                    WPLöschen()
                                End If
                                If CL.Text.Contains("[" & TimeOfDay & "] << Polizist ") And CL.Text.Contains(" eingesperrt >>") Then
                                    KilledWPLer = CL.Text.Split(" ")(5)
                                    KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                    WPLöschen()
                                End If
                                If CL.Text.Contains("[" & TimeOfDay & "] << FBI Agent ") And CL.Text.Contains(" eingesperrt >>") Then
                                    KilledWPLer = CL.Text.Split(" ")(6)
                                    KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                    WPLöschen()
                                End If
                                If CL.Text.Contains("[" & TimeOfDay & "] << Soldat ") And CL.Text.Contains(" eingesperrt >>") Then
                                    KilledWPLer = CL.Text.Split(" ")(5)
                                    KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                    WPLöschen()
                                End If
                                If CL.Text.Contains("[" & TimeOfDay & "] <<Beamter ") And CL.Text.Contains(" hat ") And CL.Text.Contains(" die Akten gelöscht Grund: ") Then
                                    KilledWPLer = CL.Text.Split(" ")(4)
                                    KilledWPLer = KilledWPLer.ToString.Replace(".", " ")
                                    WPLöschen()
                                End If


                            End If
                        End If
                        'Overlay ausblenden
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}OA" Then
                            AddChatMessage("Das Overlay wurde {FF3333}ausgeblendet.")
                            OverlayStatus = 0
                            DestroyAllVisual()
                        End If
                        'OverlayAFK
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}GPSTATUS" Then
                            If Not Einstellungen.OL.Text = "Aus" Then
                                If OverlayStatus = 1 Then


                                    WP0 = WP0.ToString.Replace(" (AFK)", "")
                                    WP1 = WP1.ToString.Replace(" (AFK)", "")
                                    WP2 = WP2.ToString.Replace(" (AFK)", "")
                                    WP3 = WP3.ToString.Replace(" (AFK)", "")
                                    WP4 = WP4.ToString.Replace(" (AFK)", "")
                                    WP5 = WP5.ToString.Replace(" (AFK)", "")
                                    WP6 = WP6.ToString.Replace(" (AFK)", "")
                                    WP7 = WP7.ToString.Replace(" (AFK)", "")
                                    WP8 = WP8.ToString.Replace(" (AFK)", "")
                                    WP9 = WP9.ToString.Replace(" (AFK)", "")
                                    WP10 = WP10.ToString.Replace(" (AFK)", "")
                                    WP11 = WP11.ToString.Replace(" (AFK)", "")
                                    WP12 = WP12.ToString.Replace(" (AFK)", "")
                                    WP13 = WP13.ToString.Replace(" (AFK)", "")
                                    WP14 = WP14.ToString.Replace(" (AFK)", "")
                                    WP15 = WP15.ToString.Replace(" (AFK)", "")
                                    WP16 = WP16.ToString.Replace(" (AFK)", "")
                                    WP17 = WP17.ToString.Replace(" (AFK)", "")
                                    WP18 = WP18.ToString.Replace(" (AFK)", "")
                                    WP19 = WP19.ToString.Replace(" (AFK)", "")
                                    WP20 = WP20.ToString.Replace(" (AFK)", "")
                                    WP21 = WP21.ToString.Replace(" (AFK)", "")
                                    WP22 = WP22.ToString.Replace(" (AFK)", "")
                                    WP23 = WP23.ToString.Replace(" (AFK)", "")
                                    WP24 = WP24.ToString.Replace(" (AFK)", "")
                                    WP25 = WP25.ToString.Replace(" (AFK)", "")
                                    WP26 = WP26.ToString.Replace(" (AFK)", "")
                                    WP27 = WP27.ToString.Replace(" (AFK)", "")

                                    WP0 = WP0.ToString.Replace(" (TOT)", "")
                                    WP1 = WP1.ToString.Replace(" (TOT)", "")
                                    WP2 = WP2.ToString.Replace(" (TOT)", "")
                                    WP3 = WP3.ToString.Replace(" (TOT)", "")
                                    WP4 = WP4.ToString.Replace(" (TOT)", "")
                                    WP5 = WP5.ToString.Replace(" (TOT)", "")
                                    WP6 = WP6.ToString.Replace(" (TOT)", "")
                                    WP7 = WP7.ToString.Replace(" (TOT)", "")
                                    WP8 = WP8.ToString.Replace(" (TOT)", "")
                                    WP9 = WP9.ToString.Replace(" (TOT)", "")
                                    WP10 = WP10.ToString.Replace(" (TOT)", "")
                                    WP11 = WP11.ToString.Replace(" (TOT)", "")
                                    WP12 = WP12.ToString.Replace(" (TOT)", "")
                                    WP13 = WP13.ToString.Replace(" (TOT)", "")
                                    WP14 = WP14.ToString.Replace(" (TOT)", "")
                                    WP15 = WP15.ToString.Replace(" (TOT)", "")
                                    WP16 = WP16.ToString.Replace(" (TOT)", "")
                                    WP17 = WP17.ToString.Replace(" (TOT)", "")
                                    WP18 = WP18.ToString.Replace(" (TOT)", "")
                                    WP19 = WP19.ToString.Replace(" (TOT)", "")
                                    WP20 = WP20.ToString.Replace(" (TOT)", "")
                                    WP21 = WP21.ToString.Replace(" (TOT)", "")
                                    WP22 = WP22.ToString.Replace(" (TOT)", "")
                                    WP23 = WP23.ToString.Replace(" (TOT)", "")
                                    WP24 = WP24.ToString.Replace(" (TOT)", "")
                                    WP25 = WP25.ToString.Replace(" (TOT)", "")
                                    WP26 = WP26.ToString.Replace(" (TOT)", "")
                                    WP27 = WP27.ToString.Replace(" (TOT)", "")

                                    WP0 = WP0.ToString.Replace(" (Knast)", "")
                                    WP1 = WP1.ToString.Replace(" (Knast)", "")
                                    WP2 = WP2.ToString.Replace(" (Knast)", "")
                                    WP3 = WP3.ToString.Replace(" (Knast)", "")
                                    WP4 = WP4.ToString.Replace(" (Knast)", "")
                                    WP5 = WP5.ToString.Replace(" (Knast)", "")
                                    WP6 = WP6.ToString.Replace(" (Knast)", "")
                                    WP7 = WP7.ToString.Replace(" (Knast)", "")
                                    WP8 = WP8.ToString.Replace(" (Knast)", "")
                                    WP9 = WP9.ToString.Replace(" (Knast)", "")
                                    WP10 = WP10.ToString.Replace(" (Knast)", "")
                                    WP11 = WP11.ToString.Replace(" (Knast)", "")
                                    WP12 = WP12.ToString.Replace(" (Knast)", "")
                                    WP13 = WP13.ToString.Replace(" (Knast)", "")
                                    WP14 = WP14.ToString.Replace(" (Knast)", "")
                                    WP15 = WP15.ToString.Replace(" (Knast)", "")
                                    WP16 = WP16.ToString.Replace(" (Knast)", "")
                                    WP17 = WP17.ToString.Replace(" (Knast)", "")
                                    WP18 = WP18.ToString.Replace(" (Knast)", "")
                                    WP19 = WP19.ToString.Replace(" (Knast)", "")
                                    WP20 = WP20.ToString.Replace(" (Knast)", "")
                                    WP21 = WP21.ToString.Replace(" (Knast)", "")
                                    WP22 = WP22.ToString.Replace(" (Knast)", "")
                                    WP23 = WP23.ToString.Replace(" (Knast)", "")
                                    WP24 = WP24.ToString.Replace(" (Knast)", "")
                                    WP25 = WP25.ToString.Replace(" (Knast)", "")
                                    WP26 = WP26.ToString.Replace(" (Knast)", "")
                                    WP27 = WP27.ToString.Replace(" (Knast)", "")

                                    WPStatus()

                                    WPOverlaySortieren()


                                    OverlayStatus = 1
                                    DestroyAllVisual()
                                    'SetParam("use_window", "1")
                                    'SetParam("window", "GTA:SA:MP")
                                    'SetParam("window", "gta_sa")
                                    OverlayErstellen()
                                    System.Threading.Thread.Sleep("1000")

                                Else
                                    AddChatMessage("{FF3333}FEHLER!{FFFFFF} Du musst zuerst das Overlay aktivieren (/wanted oder /bl)")
                                End If
                            Else
                                AddChatMessage("{FF3333}FEHLER!{FFFFFF} Du musst das Overlay erlauben (Datei->Einstellungen->Sonstiges->Overlay)")
                            End If
                        End If

                        'Tests
                        If CL.Text = "[" & TimeOfDay & "] #: {FFFFFF}test2" Then
                            PosX(X)
                            PosY(Y)
                            PosZ(Z)
                            AddChatMessage("X: " & X)
                            AddChatMessage("Y: " & Y)
                            AddChatMessage("Z: " & Z)
                        End If
                        'TB1.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4)
                        'TB2.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2)
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}DROGEN" Then
                            SendChat("/oldstats")
                            System.Threading.Thread.Sleep("150")
                            Dim Green As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(2).Split("]")(0)
                            Dim Gold As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(3).Split("]")(0)
                            Dim LSD As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(4).Split("]")(0)
                            Dim Eisen As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(5).Split("]")(0)
                            Dim Donuts As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 8).Split("[")(7).Split("]")(0)
                            AddChatMessage("Eisen: {00E533}" & Eisen & "{FFFFFF}, Green: {00E533}" & Green & "{FFFFFF}, Gold: {00E533}" & Gold & "{FFFFFF}, LSD: {00E533}" & LSD & "{FFFFFF}, Donuts: {00E533}" & Donuts & "{FFFFFF}.")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] (GagaMichi fügt hinzu: NNPVersion)" And Not Einstellungen.IngameName.Text = "GagaMichi" Then
                            SendChat("/oos Version: " & Version.Text)
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If Einstellungen.CH.Checked Then
                            If Not Carheal = CarhealAlt And Not Carheal > CarhealAlt And Not Carheal = 0 Then
                                If IsPlayerInAnyVehicle Then
                                    If Carheal < 300 Then
                                        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~r~-" & CarhealAlt - Carheal & " Carheal~n~~y~(Carheal: ~r~" & GetVehicleHealth & "~y~)", 1000, 3)
                                    ElseIf Carheal < 600 Then
                                        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~y~-" & CarhealAlt - Carheal & " Carheal~n~(Carheal: " & GetVehicleHealth & ")", 1000, 3)
                                    Else
                                        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~g~-" & CarhealAlt - Carheal & " Carheal~n~~y~(Carheal: ~g~" & GetVehicleHealth & "~y~)", 1000, 3)
                                    End If
                                End If
                            End If
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] FEHLER: {FFFFFF}Dieses Graffiti kann erst in") And CL.Text.Contains("Sekunden übersprüht werden.") Then
                            GRF = CL.Text.Split(" ")(7) / 60
                            GRF = Math.Round(GRF, 0)
                            GRFM = Now.Minute + GRF
                            GRFS = Now.Hour
                            If GRFM > 59 Then
                                GRFM = GRFM - 60
                                GRFS = GRFS + 1
                                If GRFS > 23 Then
                                    GRFS = GRFS - 24
                                End If
                            End If

                            AddChatMessage("Das Graffiti kann in ca. {00E533}" & GRF & "{FFFFFF} Minuten ( um {00E533}" & GRFS & ":" & GRFM & " uhr{FFFFFF}) übersprüht werden")
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] FEHLER: {FFFFFF}Dieses Geschäft kann erst in ") And CL.Text.Contains(" Sekunden befreit werden.") Then
                            GRF = CL.Text.Split(" ")(7) / 60
                            GRF = Math.Round(GRF, 0)
                            GRFM = Now.Minute + GRF
                            GRFS = Now.Hour
                            If GRFM > 59 Then
                                GRFM = GRFM - 60
                                GRFS = GRFS + 1
                                If GRFS > 23 Then
                                    GRFS = GRFS - 24
                                End If
                            End If

                            AddChatMessage("Das Geschäft kann in ca. {00E533}" & GRF & "{FFFFFF} Minuten ( um {00E533}" & GRFS & ":" & GRFM & " uhr{FFFFFF}) befreit werden")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPLEVEL" Then
                            Einstellungen.NNPLevel.Text = Level
                            ShowGameText("~b~Noname Produkt Level! ~n~~y~ Level ~r~" & Level & "~y~. ~n~~r~" & Kills.Text & "/" & Math.Round(5 * (Level ^ 2 / 3), 0) & "~y~ bis Level ~r~" & Level + 1 & "~y~.", 0, 1)
                        End If
                        If CL.Text = "[" & TimeOfDay & "] FEHLER:{FFFFFF}Die Person ist durch die Blacklist gestorben und kann nicht reanimiert werden." Then
                            SendChat("/ame Diese Person kann nicht reanimiert werden!")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] * " & Einstellungen.IngameName.Text & " verwendet einen Defibrillator zur Reanimation." Then
                            Defizeit = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(9) - -3
                            SendChat("/ame " & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(6) & " wird nun reanimiert.")
                            SendChat("/me beginnt " & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(6) & " zu reanimieren und benötigt " & Defizeit & " sekunden.")
                            TTod.Stop()
                            TEinbruch.Stop()
                            TKnast.Stop()
                            TTod.Stop()
                            WaffenTimer.Stop()
                            System.Threading.Thread.Sleep("1000")
                            LMi.Text = Now.Minute + Math.Round(Defizeit / 60, 0)
                            P1.Maximum = Defizeit + 5
                            CDK.P1.Maximum = Defizeit + 5
                            News.Visible = False
                            P1.Visible = True
                            P1.Value = "0"
                            LSt.Text = Now.Hour
                            If LMi.Text = "60" Or LMi.Text = "61" Or LMi.Text = "62" Or LMi.Text = "63" Or LMi.Text = "64" Or LMi.Text = "65" Or LMi.Text = "66" Or LMi.Text = "67" Or LMi.Text = "68" Or LMi.Text = "69" Or LMi.Text = "70" Then
                                LSt.Text = LSt.Text + 1
                                LMi.Text = LMi.Text - 60
                            End If
                            If LSt.Text = "24" Then
                                LSt.Text = "00"
                            End If
                            If LSt.Text = "1" Or LSt.Text = "2" Or LSt.Text = "3" Or LSt.Text = "4" Or LSt.Text = "5" Or LSt.Text = "6" Or LSt.Text = "7" Or LSt.Text = "8" Or LSt.Text = "9" Or LSt.Text = "0" Then
                                LSt.Text = "0" & LSt.Text
                            End If
                            If LMi.Text = "1" Or LMi.Text = "2" Or LMi.Text = "3" Or LMi.Text = "4" Or LMi.Text = "5" Or LMi.Text = "6" Or LMi.Text = "7" Or LMi.Text = "8" Or LMi.Text = "9" Or LMi.Text = "0" Then
                                LMi.Text = "0" & LMi.Text
                            End If
                            TB2.Text = "Du bist um ca. " & LSt.Text & ":" & LMi.Text & " Uhr fertig."
                            Status.Text = "im Revive (Defibrilator)"
                            Status.BackColor = Color.CadetBlue
                            If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                CDK.TCDK.Start()
                            End If
                            Defi.Start()
                        End If

                        If CL.Text = "[" & TimeOfDay & "] * Während du wartest, kannst du nebenbei noch Munition für deine Waffen produzieren..." Then

                            TKnast.Stop()
                            TTod.Stop()
                            TEinbruch.Stop()

                            WZeit = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split(" ")(6) / 60

                            Wst = Now.Hour
                            Wmi = Math.Round(WZeit / 60)
                            Wmi = Now.Minute + Wmi
                            If Wmi > 59 Then
                                Wmi = Wmi - 60
                                Wst = Wst - -1
                            End If
                            If Wst > 23 Then
                                Wst = Wst - 24
                            End If

                            TB1.Text = "Du bastelst jetzt eine Waffe."
                            TB2.Text = "Du bist fertig um ca. " & Wst & ":" & Wmi & " Uhr."
                            P1.Visible = True
                            P1.Value = "0"
                            P1.Maximum = WZeit

                            If Einstellungen.CDKA.Checked And CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If

                            WaffenTimer.Start()
                        End If

                        If CL.Text.Contains("[" & TimeOfDay & "] " & Einstellungen.IngameName.Text & " sagt:") And TTod.Enabled Then
                            TZ.Text = 0
                            TB1.Text = ""
                            TB2.Text = ""
                            P1.Value = 0
                            TTod.Stop()
                            If GW.Text = 1 Then
                                Status.Text = "Gangwar"
                                Status.BackColor = Color.YellowGreen
                            Else
                                Status.Text = "Frei/lebend"
                                Status.BackColor = Color.Green
                            End If
                            If CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If
                            MaximumSize = New Size(240, 215)
                            Size = New Size(240, 215)
                            SD.Visible = False
                            AddChatMessage("Der Friedhoftimer wurde abgebrochen!")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] **Für ca. 2 Stunden im Gefängnis**" Then
                            SendChat("/jailtime")
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] " & Einstellungen.IngameName.Text & " schreit:") And TTod.Enabled Then
                            TZ.Text = 0
                            TB1.Text = ""
                            TB2.Text = ""
                            P1.Value = 0
                            TTod.Stop()
                            If GW.Text = 1 Then
                                Status.Text = "Gangwar"
                                Status.BackColor = Color.YellowGreen
                            Else
                                Status.Text = "Frei/lebend"
                                Status.BackColor = Color.Green
                            End If
                            If CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If
                            MaximumSize = New Size(240, 215)
                            Size = New Size(240, 215)
                            SD.Visible = False
                            AddChatMessage("Der Friedhoftimer wurde abgebrochen!")
                        End If

                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}SMARKT" Then
                            AddChatMessage("{00B200}Die SMarkt Funktion ist nicht mehr Verfügbar!")
                        End If

                        If CDK.Loc > -10 And Not IsNumeric(CDK.CDKC.Text) Then

                            System.Threading.Thread.Sleep("1000")
                            'AddChatMessage("Fehler bei der erkennung. {FF0000}" & CDK.CDKC.Text & "{FFFFFF} ist keine Zahl!")
                            Endet.Text = "0"
                            Status.Text = "Frei/lebend"
                            Status.BackColor = Color.Green
                            P1.Value = "0"
                            TTod.Stop()
                            TKnast.Stop()
                            KZ.Text = "1"
                            TZ.Text = "1"
                            TB1.Text = ""
                            TB2.Text = ""
                            MaximumSize = New Size(240, 215)
                            Size = New Size(240, 215)
                            SD.Visible = False
                            If CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If
                            If CDK.TCDK.Enabled Then
                                CDK.Pos = 1
                            End If
                            Ende.Stop()
                        ElseIf CDK.CDKC.Text < 0 Then
                            System.Threading.Thread.Sleep("1000")
                            'AddChatMessage("Fehler bei der erkennung. {FF0000}" & CDK.CDKC.Text & "{FFFFFF} ist eine zu kleine Zahl!")
                            Endet.Text = "0"
                            Status.Text = "Frei/lebend"
                            Status.BackColor = Color.Green
                            P1.Value = "0"
                            TTod.Stop()
                            TKnast.Stop()
                            TB1.Text = ""
                            TB2.Text = ""
                            KZ.Text = "1"
                            TZ.Text = "1"
                            CDK.CDKC.Text = "1"
                            MaximumSize = New Size(240, 215)
                            Size = New Size(240, 215)
                            SD.Visible = False
                            Ende.Stop()
                            If CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If
                            If CDK.TCDK.Enabled Then
                                CDK.Pos = 1
                            End If
                        End If

                        'Hitlog
                        If Einstellungen.HH.Checked = True Then
                            If Not CL.Text = "[" & TimeOfDay & "]  Der LSD Rausch ist nun vorbei und die Nebenwirkung tritt ein (15HP)!" Then
                                If Not Heal = HealAlt And Not HealAlt - Heal < 6 And Not HealAlt - Heal > 200 Then
                                    If Armour < 6 Then

                                        If Heal < 1 And Heal > 10 Then
                                            AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wurdest getötet!. ({00E533}-" & HealAlt - Heal + ArmourAlt - Armour & " Heal{FFFFFF})")
                                        Else
                                            If HealAlt - Heal = 46 Or HealAlt - Heal = 47 Or HealAlt - Heal = 48 Or HealAlt - Heal + ArmourAlt - Armour = 46 Or HealAlt - Heal + ArmourAlt - Armour = 47 Or HealAlt - Heal + ArmourAlt - Armour = 48 Then
                                                AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}Deagle {FFFFFF}gehittet. ({00E533}-" & HealAlt - Heal + ArmourAlt - Armour & " Heal{FFFFFF})")

                                            ElseIf HealAlt - Heal = 7 Or HealAlt - Heal = 8 Or HealAlt - Heal = 9 Or HealAlt - Heal + ArmourAlt - Armour = 7 Or HealAlt - Heal + ArmourAlt - Armour = 8 Or HealAlt - Heal + ArmourAlt - Armour = 9 Then
                                                AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}MP5 {FFFFFF}gehittet. ({00E533}-" & HealAlt - Heal + ArmourAlt - Armour & " Heal{FFFFFF})")

                                            ElseIf HealAlt - Heal = 9 Or HealAlt - Heal = 10 Or HealAlt - Heal = 11 Or HealAlt - Heal + ArmourAlt - Armour = 9 Or HealAlt - Heal + ArmourAlt - Armour = 10 Or HealAlt - Heal + ArmourAlt - Armour = 11 Then
                                                AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}AK47/M4 {FFFFFF}gehittet. ({00E533}-" & HealAlt - Heal + ArmourAlt - Armour & " Heal{FFFFFF})")

                                            ElseIf HealAlt - Heal = 40 Or HealAlt - Heal = 41 Or HealAlt - Heal = 42 Or HealAlt - Heal + ArmourAlt - Armour = 40 Or HealAlt - Heal + ArmourAlt - Armour = 41 Or HealAlt - Heal + ArmourAlt - Armour = 42 Then
                                                AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}Sniper {FFFFFF}gehittet. ({00E533}-" & HealAlt - Heal + ArmourAlt - Armour & " Heal{FFFFFF})")

                                            ElseIf HealAlt - Heal = 48 Or HealAlt - Heal = 49 Or HealAlt - Heal = 50 Or HealAlt - Heal + ArmourAlt - Armour = 48 Or HealAlt - Heal + ArmourAlt - Armour = 49 Or HealAlt - Heal + ArmourAlt - Armour = 50 Then
                                                AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst direkt mit einer {FF0000}Shotgun {FFFFFF}gehittet. ({00E533}-" & HealAlt - Heal + ArmourAlt - Armour & " Heal{FFFFFF})")

                                            Else
                                                AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du verlierst {FF0000}" & HealAlt - Heal + ArmourAlt - Armour & "{FFFFFF} Heal.")

                                            End If
                                        End If
                                    Else
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du verlierst {FF0000}" & HealAlt - Heal & "{FFFFFF} Heal.")
                                    End If
                                ElseIf Not Armour = ArmourAlt And Not ArmourAlt - Armour < 10 Then

                                    If ArmourAlt - Armour = 46 Or ArmourAlt - Armour = 47 Or ArmourAlt - Armour = 48 Then
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}Deagle {FFFFFF}gehittet. ({00E533}-" & ArmourAlt - Armour & " Armour{FFFFFF})")

                                    ElseIf ArmourAlt - Armour = 7 Or ArmourAlt - Armour = 8 Or ArmourAlt - Armour = 9 Then
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}MP5 {FFFFFF}gehittet. ({00E533}-" & ArmourAlt - Armour & " Armour{FFFFFF})")

                                    ElseIf ArmourAlt - Armour = 9 Or ArmourAlt - Armour = 10 Or ArmourAlt - Armour = 11 Then
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}AK47/M4 {FFFFFF}gehittet. ({00E533}-" & ArmourAlt - Armour & " Armour{FFFFFF})")

                                    ElseIf ArmourAlt - Armour = 40 Or ArmourAlt - Armour = 41 Or ArmourAlt - Armour = 41 Then
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst mit einer {FF0000}Sniper {FFFFFF}gehittet. ({00E533}-" & ArmourAlt - Armour & " Armour{FFFFFF})")

                                    ElseIf ArmourAlt - Armour = 48 Or ArmourAlt - Armour = 49 Or ArmourAlt - Armour = 50 Then
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du wirst direkt mit einer {FF0000}Shotgun {FFFFFF}gehittet. ({00E533}-" & ArmourAlt - Armour & " Armour{FFFFFF})")

                                    Else
                                        AddChatMessage("{FF0000}ACHTUNG!! {FFFFFF}Du verlierst {FF0000}" & ArmourAlt - Armour & "{FFFFFF} Armour")

                                    End If
                                End If
                            End If
                        End If


                        If CL.Text = "[" & TimeOfDay & "] * " & Einstellungen.IngameName.Text & " hat LSD genommen." Then
                            LSDTimer.Start()
                            AddChatMessage("Du hast LSD genommen. Die nachwirkung wird in ca. {00E533}" & LSDZ & " sekunden{FFFFFF} eintreten!")
                        End If
                        '########################################################################################
                        If CL.Text = "[" & TimeOfDay & "] #: {FFFFFF}test" Then
                            Orte()
                            Waffenabgleich()
                            GetPlayerPos(X, Y, Z)

                            'Ausgabe
                            System.Threading.Thread.Sleep("100")
                            AddChatMessage("Ich bin {00E533}" & Ort)
                            AddChatMessage("Heal: {00E533}" & GetPlayerHealth & "{FFFFFF}, Armour: {00E533}" & GetPlayerArmour)
                            AddChatMessage("Carheal: {00E533}" & GetVehicleHealth)
                            AddChatMessage("Waffe: {00E533}" & Waffe)
                            AddChatMessage("Position: {00E533}X: " & X & "{FFFFFF}, {00E533}Y: " & Y & "{FFFFFF}, {00E533}Z: " & Z)
                            System.Threading.Thread.Sleep("800")
                        End If
                        '########################################################################################
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}AE" Then
                            SendChat("/oldstats")
                            System.Threading.Thread.Sleep("150")
                            AEName = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 16).Split(" ")(2)
                            AELevel = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 14).Split("[")(2).Split("]")(0)
                            AEMorde = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 8).Split("[")(2).Split("]")(0)
                            AddChatMessage("Dein Name: {00E533}" & AEName & "{FFFFFF}, Dein Level: {00E533}" & AELevel & "{FFFFFF}, Deine Morde: {00E533}" & AEMorde)
                            AddChatMessage("Ist das richtig, dann schreibe jetzt {FF0000}/echo Ja{FFFFFF}. Wenn nicht, schreibe erneut {FF0000}/echo AE{FFFFFF}.")
                            AEG = 1
                        End If

                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}JA" Then
                            If AEG = 1 Then
                                If AELevel > 3 Then
                                    AELevel = "True"
                                Else
                                    AELevel = "False"
                                End If
                                SpeichernAE()
                                Einstellungen.LVL.Checked = AELevel
                                Einstellungen.IngameName.Text = AEName
                                Einstellungen.Kills.Text = AEMorde
                                If AELevel = "True" Then
                                    AddChatMessage("{00E533}Erfolgreich!{FFFFFF} Du hast deinen Namen auf {00E533}" & Einstellungen.IngameName.Text & "{FFFFFF}, dein level auf {00E533}über 3")
                                    AddChatMessage("{FFFFFF} und deine Morde auf {00E533}" & Einstellungen.Kills.Text & "{FFFFFF} gesetzt.")
                                ElseIf AELevel = "False" Then
                                    AddChatMessage("{00E533}Erfolgreich!{FFFFFF} Du hast deinen Namen auf {00E533}" & Einstellungen.IngameName.Text & "{FFFFFF},")
                                    AddChatMessage("dein level auf {00E533}unter 3{FFFFFF} und deine Morde auf {00E533}" & Einstellungen.Kills.Text & "{FFFFFF} gesetzt.")
                                    Einstellungen.Button9.PerformClick()
                                End If
                                AEG = 0
                            Else
                                AddChatMessage("{FF0000}Fehler!{FFFFFF} Es ist ein Fehler aufgetreten. Gib zuerst {00E533}/echo AE{FFFFFF} ein.")
                            End If
                        End If

                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}VS" Then
                            PosX(X)
                            PosY(Y)
                            PosZ(Z)
                            X = X + 5000
                            Y = Y + 5000
                            'Koordinaten
                            SpielerX = X
                            SpielerY = Y
                            SpielerZ = Z

                            'Abgleichen
                            Orte()
                            VSText = Einstellungen.VST.Text


                            VSText = VSText.Replace("[Ort]", Ort)
                            VSText = VSText.Replace("[HP]", GetPlayerHealth)
                            VSText = VSText.Replace("[Armour]", GetPlayerArmour)
                            VSLoop = Einstellungen.VSS.Text
                            Do
                                SendChat(VSText)
                                VSLoop = VSLoop - 1
                            Loop Until VSLoop = 0
                            System.Threading.Thread.Sleep("1000")
                        End If

                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}VS2" Then
                            PosX(X)
                            PosY(Y)
                            PosZ(Z)
                            X = X + 5000
                            Y = Y + 5000
                            'Koordinaten
                            SpielerX = X
                            SpielerY = Y
                            SpielerZ = Z

                            'Abgleichen
                            Orte()
                            VSText = Einstellungen.VST2.Text


                            VSText = VSText.Replace("[Ort]", Ort)
                            VSText = VSText.Replace("[HP]", GetPlayerHealth)
                            VSText = VSText.Replace("[Armour]", GetPlayerArmour)
                            VSLoop = Einstellungen.VSS2.Text
                            Do
                                SendChat(VSText)
                                VSLoop = VSLoop - 1
                            Loop Until VSLoop = 0
                            System.Threading.Thread.Sleep("1000")
                        End If



                        If CDK.Location.Y > 1 Then
                            CDK.Location = New Point(0, -70)
                        End If
                        ' And Not News.Document.GetElementById("News").InnerHtml = "" 


                        If P1.Value = "0" And ITA = 0 Then
                            P1.Visible = False
                        Else
                            P1.Visible = True
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] VIP Lotto:") Then
                            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] Lotto: Heute hat noch keine Ziehung stattgefunden (Jackpot: ") Then
                                LottoCP = "{FFFFFF}Normaler Jackpot: {00E533}" & System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(9).Split(")")(0) & "{FFFFFF}, "
                            Else
                                LottoCP = "{FF3333}Es hat bereits eine normale Ziehung stattgefunden{FFFFFF}, "
                            End If
                            If CL.Text.Contains("[" & TimeOfDay & "] VIP Lotto: Heute hat noch keine Ziehung stattgefunden (VIP Jackpot: ") Then
                                VLottoCP = "{FFFFFF}VIP Jackpot: {00E533}" & CL.Text.Split(" ")(11).Split(")")(0) & "{FFFFFF}."
                            Else
                                VLottoCP = "{FF3333}Es hat bereits eine VIP Ziehung stattgefunden{FFFFFF}, "
                            End If
                            System.Threading.Thread.Sleep("200")
                            SendChat("/oldstats")
                            System.Threading.Thread.Sleep("150")
                            Lotto = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 12).Split("[")(4).Split("]")(0)
                            VIPLotto = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 12).Split("[")(5).Split("]")(0)
                            AddChatMessage(" ")
                            AddChatMessage("{FFFFFF}Deine Lottozahl: {00E533}" & Lotto & "{FFFFFF}, deine BigLottozahl: {00E533}" & VIPLotto & "{FFFFFF}.")
                            AddChatMessage(LottoCP & VLottoCP)
                            System.Threading.Thread.Sleep("1500")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPINFO" Then
                            AddChatMessage("{FF3333}FEHLER! {FFFFFF}Schreibe '/echo NNPInfo{00E533}1/2/3{FFFFFF}' um zur Übersicht zu kommen.")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPINFO1" Then
                            APIShowDialog(0, "NNP Info - Killnachricht", "{00E533}" & Einstellungen.KNB1.Text & "{FFFFFF}, wird gesendet:{00E533} " & Einstellungen.KNS1.Checked & vbCrLf & "{00E533}" & Einstellungen.KNB2.Text & "{FFFFFF}, wird gesendet:{00E533} " & Einstellungen.KNS2.Checked & vbCrLf & "{00E533}" & Einstellungen.KNB3.Text & "{FFFFFF}, wird gesendet:{00E533} " & Einstellungen.KNS3.Checked, "Schließen")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPINFO2" Then
                            If Einstellungen.DrogenE.Checked = True Then
                                DEStatus = "Drogen werden {00E533}Herausgenommen."
                            ElseIf Einstellungen.DrogenAA.Checked = True Then
                                DEStatus = "Drogen werden {00E533}auf den Betrag gesetzt."
                            End If
                            APIShowDialog(0, "NNP Info - Drogenentnahme", "{FFFFFF}Green: {00E533}" & Einstellungen.Green.Text & "{FFFFFF}, wird entnommen: {00E533}" & Einstellungen.GreenBÄ.Checked & vbCrLf & "{FFFFFF}Gold: {00E533}" & Einstellungen.Gold.Text & "{FFFFFF}, wird entnommen: {00E533}" & Einstellungen.GoldBÄ.Checked & vbCrLf & "{FFFFFF}LSD: {00E533}" & Einstellungen.LSD.Text & "{FFFFFF}, wird entnommen: {00E533}" & Einstellungen.LSDBÄ.Checked & vbCrLf & "{FFFFFF}Eisen: {00E533}" & Einstellungen.Eisen.Text & "{FFFFFF}, wird entnommen: {00E533}" & Einstellungen.EisenBÄ.Checked & vbCrLf & DEStatus, "Schließen")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPINFO3" Then
                            If Updatek.Checked = True Then
                                UPdateNI = "{FFFFFF}NNPVersion: {FF0000}" & Version.Text & "{FFFFFF}, diese Version ist {FF0000}veraltet{FFFFFF}!"
                            Else
                                UPdateNI = "{FFFFFF}NNPVersion: {00E533}" & Version.Text & "{FFFFFF}, diese Version ist {00E533}aktuell{FFFFFF}!"
                            End If
                            APIShowDialog(0, "NNP Info - Allgemein", "{FFFFFF}Name: {00E533}" & Einstellungen.IngameName.Text & vbCrLf & "{FFFFFF}Heal: {00E533}" & GetPlayerHealth & vbCrLf & "{FFFFFF}Armour: {00E533}" & GetPlayerArmour & vbCrLf & vbCrLf & "{FFFFFF}Kills: {00E533}" & Kills.Text & "{FFFFFF}, Tode: {00E533}" & Tode.Text & "{FFFFFF}, KD: {00E533}" & KD.Text & vbCrLf & "{FFFFFF}Kills heute: {00E533}" & Killsh.Text & "{FFFFFF}, Tode heute: {00E533}" & Todeh.Text & "{FFFFFF}, KD heute: {00E533}" & KDh.Text & "{FFFFFF}." & vbCrLf & vbCrLf & "{FFFFFF}Chatlogpfad: {00E533}" & Einstellungen.CLPf.Text & vbCrLf & vbCrLf & "{FFFFFF}Killsoundpfad: {00E533}" & Einstellungen.KSp.Text & "{FFFFFF}, wird gesendet: {00E533}" & Einstellungen.KSs.Checked & vbCrLf & vbCrLf & UPdateNI, "Schließen")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}GET DROGEN" Then
                            SendChat("/oldstats")
                            System.Threading.Thread.Sleep("150")
                            Dim Green As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(2).Split("]")(0)
                            Dim Gold As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(3).Split("]")(0)
                            Dim LSD As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(4).Split("]")(0)
                            Dim Eisen As Integer = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 6).Split("[")(5).Split("]")(0)
                            If Einstellungen.DrogenAA.Checked = True Then
                                If Einstellungen.GreenBÄ.Checked = True Then
                                    If Green > Einstellungen.Green.Text Then
                                        SendChat("/housedrop green " & Green - Einstellungen.Green.Text)
                                    End If
                                    If Green < Einstellungen.Green.Text Then
                                        SendChat("/houseget green " & Einstellungen.Green.Text - Green)
                                    End If
                                End If

                                If Einstellungen.GoldBÄ.Checked = True Then
                                    If Gold > Einstellungen.Gold.Text Then
                                        SendChat("/housedrop Gold " & Gold - Einstellungen.Gold.Text)
                                    End If
                                    If Gold < Einstellungen.Gold.Text Then
                                        SendChat("/houseget Gold " & Einstellungen.Gold.Text - Gold)
                                    End If
                                End If


                                If Einstellungen.LSDBÄ.Checked = True Then
                                    If LSD > Einstellungen.LSD.Text Then
                                        SendChat("/housedrop lsd " & LSD - Einstellungen.LSD.Text)
                                    End If
                                    If LSD < Einstellungen.LSD.Text Then
                                        SendChat("/houseget lsd " & Einstellungen.LSD.Text - LSD)
                                    End If
                                End If

                                If Einstellungen.EisenBÄ.Checked = True Then
                                    If Eisen > Einstellungen.Eisen.Text Then
                                        SendChat("/housedrop Eisen " & Eisen - Einstellungen.Eisen.Text)
                                    End If
                                    If Green < Einstellungen.Green.Text Then
                                        SendChat("/houseget Eisen " & Einstellungen.Eisen.Text - Eisen)
                                    End If
                                End If
                            End If

                            If Einstellungen.DrogenE.Checked = True Then
                                If Einstellungen.GreenBÄ.Checked = True Then
                                    SendChat("/houseget green " & Einstellungen.Green.Text)
                                End If

                                If Einstellungen.GoldBÄ.Checked = True Then
                                    SendChat("/houseget gold " & Einstellungen.Gold.Text)
                                End If
                                If Einstellungen.LSDBÄ.Checked = True Then
                                    SendChat("/houseget lsd " & Einstellungen.LSD.Text)
                                End If
                                If Einstellungen.EisenBÄ.Checked = True Then
                                    SendChat("/houseget eisen " & Einstellungen.Eisen.Text)
                                End If
                            End If
                        End If
                        '############################

                        '######################################
                        If CL.Text = "[" & TimeOfDay & "] Gib /afk ein um den AFK-Modus zu verlassen." Then
                            SendChat("/afk")
                        End If
                        If GW.Text = GWD.Text Then
                        Else
                            GWD.Text = GW.Text
                            If GW.Text = "0" Then
                                Status.Text = "Frei/lebend"
                                Status.BackColor = Color.Green
                            End If
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPHELP" Then
                            AddChatMessage("{00E533}/echo AE{FFFFFF} - Gleicht die Ingame Daten mit den NNP Daten ab.")
                            AddChatMessage("{00E533}/echo NS{FFFFFF} - Startet das NNP Neu. (wirft dich evt. auf den Desktop).")
                            AddChatMessage("{00E533}/echo TS{FFFFFF} - Stoppt alle Timer.")
                            AddChatMessage("{00E533}/echo VG{FFFFFF} - Setzt das NNP in den Vordergrund (lohnt sich nur mit 2 Bildschirmen).")
                            AddChatMessage("{00E533}/echo DR{FFFFFF} - Ist ein Drogenrechner (Bezieht ab 5kg Drogen den Mengenrabatt von 25% mit ein).")
                            AddChatMessage("{00E533}/echo get Drogen {FFFFFF}- Nimmt Drogen aus dem Hauslager (Menge einstellbar: Datei->Einstellungen).")
                            AddChatMessage("{00E533}/echo GW{FFFFFF} - Startet den Gangwar-Modus.")
                            AddChatMessage("{00E533}/echo GWEnde{FFFFFF} - Stoppt den Gangwar-Modus.")
                            AddChatMessage("{00E533}/echo STVO{FFFFFF} - Damit schreist du leute an die dich gerammt haben. (nur im Fahrzeug).")
                            AddChatMessage("{00E533}/echo NNPTest{FFFFFF} - Damit testest du die Killnachrichten + Killsound.")
                            AddChatMessage("{00E533}/echo SMarkt{FFFFFF} - Zeigt die zuletzt eingetragene SMarkt Position an.")
                            AddChatMessage("{00E533}/echo Drogen{FFFFFF} - Zeigt dir deine Drogen auf der Hand an.")
                            AddChatMessage("{00E533}/echo NNPLevel{FFFFFF} - Zeigt dir dein aktuelles NNPLevel an.")
                            AddChatMessage("{00E533}/echo OA{FFFFFF} - Blendet das Overlay aus.")
                            AddChatMessage("{00E533}/echo KI{FFFFFF} - Gibt die Kriegsinformationen im Fchat aus.")
                            AddChatMessage("{00E533}/echo Bombe{FFFFFF} - Startet den Bombentimer.")
                            AddChatMessage("{00E533}/echo NC{FFFFFF} - Schreibt in den NNP Chat.")
                            AddChatMessage("{00E533}/echo NO{FFFFFF} - Ermittelt die Spieler welche im NNPChat online sind.")
                            AddChatMessage("{00E533}/echo HF{FFFFFF} - Gibt +20 WPs (Hausflucht).")
                            AddChatMessage("{00E533}/echo VW{FFFFFF} - Gibt +5 WPs (Verweigerung).")
                            AddChatMessage("{00E533}/echo GD{FFFFFF} - Kauft so viele Donuts wie möglich (20er schritte).")
                            AddChatMessage("{00E533}/echo LKP{FFFFFF} - Zeigt die Distanz zur letzte Killposition an.")
                            AddChatMessage("{00E533}/echo LTP{FFFFFF} - Zeigt die Distanz zur letzte Todesposition an.")
                            AddChatMessage("{00E533}/echo VS & /echo VS2{FFFFFF} - Damit rufst du im eingestellten Chat Verstärkung.")
                            AddChatMessage("{FF0000}Information{FFFFFF} Gehe auf die NNPSeite (nnp.gagamichi.com) und klicke auf Funktionen.")
                            AddChatMessage("Dort findest du unter 'Befehle' {00E533}alle{FFFFFF} Befehle. {FFFF00}Das hier sind nicht alle Befehle!")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}DR" Then
                            AddChatMessage("Drogenrechner: /echo DR [Menge in Gramm] [Preis pro Gramm]")
                        End If
                        If CL.Text.ToUpper.Contains("[" & TimeOfDay & "] #: {FFFFFF}DR ") Then
                            If IsNumeric(CL.Text.Split(" ")(3)) And IsNumeric(CL.Text.Split(" ")(4)) Then
                                Dim Menge As Integer = CL.Text.Split(" ")(3)
                                Dim Preis As Integer = CL.Text.Split(" ")(4)
                                If Menge > 5000 Then
                                    Menge = Menge - 5000
                                    Dim PreisG As Integer
                                    PreisG = Preis * Menge
                                    PreisG = PreisG / 100
                                    PreisG = PreisG * 75
                                    PreisG = PreisG + (5000 * Preis)
                                    Menge = Menge + 5000
                                    AddChatMessage("Der Preis der {00E533}" & Menge & "g {FFFFFF}Drogen ({00E533}" & Preis & "${FFFFFF}/gramm) abzüglich des Mengenrabatts beträgt: {FF0000}" & PreisG & "$")
                                Else
                                    Dim PreisG As Integer
                                    PreisG = Preis * Menge
                                    AddChatMessage("Der Preis der {00E533}" & Menge & "g {FFFFFF}Drogen ({00E533}" & Preis & "${FFFFFF}/gramm) beträgt: {FF0000}" & PreisG & "$")
                                End If
                                System.Threading.Thread.Sleep("1000")
                            Else
                                AddChatMessage("Die Menge und der Preis müssen aus {00E533}Zahlen{FFFFFF} bestehen ({FF0000}keine Buchstaben/Sonderzeichen!{FFFFFF})")
                            End If
                        End If
                        If Datum.Text = Now.Date Then

                        Else

                            Datum.Text = Now.Date

                            SpeichernDatum()

                            Killsh.Text = "0"
                            Todeh.Text = "0"
                            KDh.Text = "0"
                        End If
                        If CL.Text = "[" & TimeOfDay & "] {FF0000}SERVER:{FFFF00} C-Bug ist verboten und wird bestraft!" Then
                            SendChat("/me rutscht auf einer Bananenschale aus.")
                            System.Threading.Thread.Sleep("2500")
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] [" & Einstellungen.IngameName.Text & " hat ") And CL.Text.Contains(" getötet | Grund: Blacklisted]") Or CL.Text.Contains("[" & TimeOfDay & "] [" & Einstellungen.IngameName.Text & " hat ") And CL.Text.Contains(" getötet | Grund: Sinlist]") Then
                            GW.Text = "0"
                            System.Threading.Thread.Sleep("100")
                            Kills.Text = Kills.Text + 1
                            LogEintrag("Kill")
                            LevelPunkte = Math.Round(5 * (Level ^ 2 / 3), 0)
                            If Kills.Text > LevelPunkte Then
                                Level = Level + 1
                                Einstellungen.NNPLevel.Text = Level
                                ShowGameText("~b~Noname Produkt Level! ~n~~y~ Level ~r~" & Level & "~y~ erreicht. ~n~~r~" & Kills.Text & "/" & Math.Round(5 * (Level ^ 2 / 3), 0) & "~y~ bis Level ~r~" & Level + 1 & "~y~.", 0, 1)
                            End If
                            Killsh.Text = Killsh.Text + 1
                            If Tode.Text > "0" Then
                                KD.Text = Kills.Text / Tode.Text
                            Else
                                KD.Text = Kills.Text
                            End If
                            If Todeh.Text > "0" Then
                                KDh.Text = Killsh.Text / Todeh.Text
                            Else
                                KDh.Text = Killsh.Text
                            End If
                            Speichern()
                            '##############################################################################################

                            If Einstellungen.KNB1.Text.Contains("[Ort]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Ort]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Ort]") And Einstellungen.KNS3.Checked = True Then
                                Orte()
                            End If

                            If Einstellungen.KNB1.Text.Contains("[Waffe]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Waffe]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Waffe]") And Einstellungen.KNS3.Checked = True Then
                                If IsPlayerInAnyVehicle Then
                                    Waffe = "einem Fahrzeug"
                                Else
                                    WaffenID = GetPlayerWeaponID
                                    If WaffenID = 0 Then
                                        Waffe = "der Faust"
                                    ElseIf WaffenID = 5 Then
                                        Waffe = "dem Baseballschläger"
                                    ElseIf WaffenID = 24 Then
                                        Waffe = "der Deagle"
                                    ElseIf WaffenID = 29 Then
                                        Waffe = "der MP5"
                                    ElseIf WaffenID = 30 Then
                                        Waffe = "der AK47"
                                    ElseIf WaffenID = 41 Then
                                        Waffe = "dem Spray"
                                    ElseIf WaffenID = 4 Then
                                        Waffe = "dem Messer"
                                    ElseIf WaffenID = 8 Then
                                        Waffe = "dem Katana"
                                    ElseIf WaffenID = 22 Then
                                        Waffe = "der 9mm"
                                    ElseIf WaffenID = 23 Then
                                        Waffe = "der 9mm (Schallgedämpft)"
                                    ElseIf WaffenID = 9 Then
                                        Waffe = "der Kettensäge"
                                    ElseIf WaffenID = 3 Then
                                        Waffe = "dem Schlagstock"
                                    ElseIf WaffenID = 26 Then
                                        Waffe = "der Shotgun"
                                    ElseIf WaffenID = 31 Then
                                        Waffe = "der M4"
                                    ElseIf WaffenID = 33 Then
                                        Waffe = "der Coun Rfile"
                                    ElseIf WaffenID = 34 Then
                                        Waffe = "der Sniper"
                                    ElseIf WaffenID = 35 Then
                                        Waffe = "dem Raketenwerfer"
                                    ElseIf WaffenID = 42 Then
                                        Waffe = "dem Feuerlöscher"
                                    Else
                                        Waffe = "einer unbekannten Waffe"
                                    End If
                                End If
                            End If

                            '##############################################################################################################
                            If Einstellungen.KNS1.Checked = True Then
                                KNS1.Text = Einstellungen.KNB1.Text
                                KNS1.Text = KNS1.Text.Replace("[Kills]", Kills.Text)
                                KNS1.Text = KNS1.Text.Replace("[HKills]", Killsh.Text)
                                KNS1.Text = KNS1.Text.Replace("[Ort]", Ort)
                                KNS1.Text = KNS1.Text.Replace("[HP]", GetPlayerHealth)
                                KNS1.Text = KNS1.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS1.Text = KNS1.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS1.Text & "(Blacklist)")
                            End If
                            If Einstellungen.KNS2.Checked = True Then
                                KNS2.Text = Einstellungen.KNB2.Text
                                KNS2.Text = KNS2.Text.Replace("[Kills]", Kills.Text)
                                KNS2.Text = KNS2.Text.Replace("[HKills]", Killsh.Text)
                                KNS2.Text = KNS2.Text.Replace("[Ort]", Ort)
                                KNS2.Text = KNS2.Text.Replace("[HP]", GetPlayerHealth)
                                KNS2.Text = KNS2.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS2.Text = KNS2.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS2.Text & "(Blacklist)")
                            End If
                            If Einstellungen.KNS3.Checked = True Then
                                KNS3.Text = Einstellungen.KNB3.Text
                                KNS3.Text = KNS3.Text.Replace("[Kills]", Kills.Text)
                                KNS3.Text = KNS3.Text.Replace("[HKills]", Killsh.Text)
                                KNS3.Text = KNS3.Text.Replace("[Ort]", Ort)
                                KNS3.Text = KNS3.Text.Replace("[HP]", GetPlayerHealth)
                                KNS3.Text = KNS3.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS3.Text = KNS3.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS3.Text & "(Blacklist)")
                            End If
                            If Einstellungen.KSs.Checked = True Then
                                Process.Start(Einstellungen.KSp.Text)
                            End If
                            If Einstellungen.HH.Checked = True Then
                                GetPlayerPos(LKPX, LKPY, Z)
                            End If
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NNPTEST" Then
                            If Einstellungen.KNB1.Text.Contains("[Ort]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Ort]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Ort]") And Einstellungen.KNS3.Checked = True Then
                                Orte()
                            End If
                            If Einstellungen.KNB1.Text.Contains("[Waffe]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Waffe]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Waffe]") And Einstellungen.KNS3.Checked = True Then
                                If IsPlayerInAnyVehicle Then
                                    Waffe = "einem Fahrzeug"
                                Else
                                    WaffenID = GetPlayerWeaponID
                                    If WaffenID = 0 Then
                                        Waffe = "der Faust"
                                    ElseIf WaffenID = 5 Then
                                        Waffe = "dem Baseballschläger"
                                    ElseIf WaffenID = 24 Then
                                        Waffe = "der Deagle"
                                    ElseIf WaffenID = 29 Then
                                        Waffe = "der MP5"
                                    ElseIf WaffenID = 30 Then
                                        Waffe = "der AK47"
                                    ElseIf WaffenID = 41 Then
                                        Waffe = "dem Spray"
                                    ElseIf WaffenID = 4 Then
                                        Waffe = "dem Messer"
                                    ElseIf WaffenID = 8 Then
                                        Waffe = "dem Katana"
                                    ElseIf WaffenID = 22 Then
                                        Waffe = "der 9mm"
                                    ElseIf WaffenID = 23 Then
                                        Waffe = "der 9mm (Schallgedämpft)"
                                    ElseIf WaffenID = 9 Then
                                        Waffe = "der Kettensäge"
                                    ElseIf WaffenID = 3 Then
                                        Waffe = "dem Schlagstock"
                                    ElseIf WaffenID = 26 Then
                                        Waffe = "der Shotgun"
                                    ElseIf WaffenID = 31 Then
                                        Waffe = "der M4"
                                    ElseIf WaffenID = 33 Then
                                        Waffe = "der Coun Rfile"
                                    ElseIf WaffenID = 34 Then
                                        Waffe = "der Sniper"
                                    ElseIf WaffenID = 35 Then
                                        Waffe = "dem Raketenwerfer"
                                    ElseIf WaffenID = 42 Then
                                        Waffe = "dem Feuerlöscher"
                                    Else
                                        Waffe = "einer unbekannten Waffe"
                                    End If
                                End If
                            End If

                            '##############################################################################################################
                            If Einstellungen.KNS1.Checked = True Then
                                KNS1.Text = Einstellungen.KNB1.Text
                                KNS1.Text = KNS1.Text.Replace("[Kills]", Kills.Text)
                                KNS1.Text = KNS1.Text.Replace("[HKills]", Killsh.Text)
                                KNS1.Text = KNS1.Text.Replace("[Ort]", Ort)
                                KNS1.Text = KNS1.Text.Replace("[HP]", GetPlayerHealth)
                                KNS1.Text = KNS1.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS1.Text = KNS1.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS1.Text & "(Test)")
                            End If
                            If Einstellungen.KNS2.Checked = True Then
                                KNS2.Text = Einstellungen.KNB2.Text
                                KNS2.Text = KNS2.Text.Replace("[Kills]", Kills.Text)
                                KNS2.Text = KNS2.Text.Replace("[HKills]", Killsh.Text)
                                KNS2.Text = KNS2.Text.Replace("[Ort]", Ort)
                                KNS2.Text = KNS2.Text.Replace("[HP]", GetPlayerHealth)
                                KNS2.Text = KNS2.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS2.Text = KNS2.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS2.Text & "(Test)")
                            End If
                            If Einstellungen.KNS3.Checked = True Then
                                KNS3.Text = Einstellungen.KNB3.Text
                                KNS3.Text = KNS3.Text.Replace("[Kills]", Kills.Text)
                                KNS3.Text = KNS3.Text.Replace("[HKills]", Killsh.Text)
                                KNS3.Text = KNS3.Text.Replace("[Ort]", Ort)
                                KNS3.Text = KNS3.Text.Replace("[HP]", GetPlayerHealth)
                                KNS3.Text = KNS3.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS3.Text = KNS3.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS3.Text & "(Test)")
                            End If
                            If Einstellungen.KSs.Checked = True Then
                                Process.Start(Einstellungen.KSp.Text)
                            End If
                            If Einstellungen.HH.Checked = True Then
                                GetPlayerPos(LKPX, LKPY, Z)
                            End If
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Du hast einen Feind ausgeschaltet." Then

                            System.Threading.Thread.Sleep("100")
                            Kills.Text = Kills.Text + 1
                            LogEintrag("Kill")
                            LevelPunkte = Math.Round(5 * (Level ^ 2 / 3), 0)
                            If Kills.Text > LevelPunkte Then
                                Level = Level + 1
                                Einstellungen.NNPLevel.Text = Level
                                ShowGameText("~b~Noname Produkt Level! ~n~~y~ Level ~r~" & Level & "~y~ erreicht. ~n~~r~" & Kills.Text & "/" & Math.Round(5 * (Level ^ 2 / 3), 0) & "~y~ bis Level ~r~" & Level + 1 & "~y~.", 0, 1)
                            End If
                            Killsh.Text = Killsh.Text + 1
                            If Tode.Text > "0" Then
                                KD.Text = Kills.Text / Tode.Text
                            Else
                                KD.Text = Kills.Text
                            End If
                            If Todeh.Text > "0" Then
                                KDh.Text = Killsh.Text / Todeh.Text
                            Else
                                KDh.Text = Killsh.Text
                            End If
                            Speichern()
                            '##############################################################################################
                            If Einstellungen.KNB1.Text.Contains("[Ort]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Ort]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Ort]") And Einstellungen.KNS3.Checked = True Then
                                Orte()
                            End If

                            If Einstellungen.KNB1.Text.Contains("[Waffe]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Waffe]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Waffe]") And Einstellungen.KNS3.Checked = True Then
                                If IsPlayerInAnyVehicle Then
                                    Waffe = "einem Fahrzeug"
                                Else
                                    WaffenID = GetPlayerWeaponID
                                    If WaffenID = 0 Then
                                        Waffe = "der Faust"
                                    ElseIf WaffenID = 5 Then
                                        Waffe = "dem Baseballschläger"
                                    ElseIf WaffenID = 24 Then
                                        Waffe = "der Deagle"
                                    ElseIf WaffenID = 29 Then
                                        Waffe = "der MP5"
                                    ElseIf WaffenID = 30 Then
                                        Waffe = "der AK47"
                                    ElseIf WaffenID = 41 Then
                                        Waffe = "dem Spray"
                                    ElseIf WaffenID = 4 Then
                                        Waffe = "dem Messer"
                                    ElseIf WaffenID = 8 Then
                                        Waffe = "dem Katana"
                                    ElseIf WaffenID = 22 Then
                                        Waffe = "der 9mm"
                                    ElseIf WaffenID = 23 Then
                                        Waffe = "der 9mm (Schallgedämpft)"
                                    ElseIf WaffenID = 9 Then
                                        Waffe = "der Kettensäge"
                                    ElseIf WaffenID = 3 Then
                                        Waffe = "dem Schlagstock"
                                    ElseIf WaffenID = 26 Then
                                        Waffe = "der Shotgun"
                                    ElseIf WaffenID = 31 Then
                                        Waffe = "der M4"
                                    ElseIf WaffenID = 33 Then
                                        Waffe = "der Coun Rfile"
                                    ElseIf WaffenID = 34 Then
                                        Waffe = "der Sniper"
                                    ElseIf WaffenID = 35 Then
                                        Waffe = "dem Raketenwerfer"
                                    ElseIf WaffenID = 42 Then
                                        Waffe = "dem Feuerlöscher"
                                    Else
                                        Waffe = "einer unbekannten Waffe"
                                    End If
                                End If
                            End If

                            '##############################################################################################################
                            If Einstellungen.KNS1.Checked = True And Einstellungen.KNSGW1.Checked = True Then
                                KNS1.Text = Einstellungen.KNB1.Text
                                KNS1.Text = KNS1.Text.Replace("[Kills]", Kills.Text)
                                KNS1.Text = KNS1.Text.Replace("[HKills]", Killsh.Text)
                                KNS1.Text = KNS1.Text.Replace("[Ort]", Ort)
                                KNS1.Text = KNS1.Text.Replace("[HP]", GetPlayerHealth)
                                KNS1.Text = KNS1.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS1.Text = KNS1.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS1.Text & "(Gangwar)")
                            End If
                            If Einstellungen.KNS2.Checked = True And Einstellungen.KNSGW2.Checked = True Then
                                KNS2.Text = Einstellungen.KNB2.Text
                                KNS2.Text = KNS2.Text.Replace("[Kills]", Kills.Text)
                                KNS2.Text = KNS2.Text.Replace("[HKills]", Killsh.Text)
                                KNS2.Text = KNS2.Text.Replace("[Ort]", Ort)
                                KNS2.Text = KNS2.Text.Replace("[HP]", GetPlayerHealth)
                                KNS2.Text = KNS2.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS2.Text = KNS2.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS2.Text & "(Gangwar)")
                            End If
                            If Einstellungen.KNS3.Checked = True And Einstellungen.KNSGW3.Checked = True Then
                                KNS3.Text = Einstellungen.KNB3.Text
                                KNS3.Text = KNS3.Text.Replace("[Kills]", Kills.Text)
                                KNS3.Text = KNS3.Text.Replace("[HKills]", Killsh.Text)
                                KNS3.Text = KNS3.Text.Replace("[Ort]", Ort)
                                KNS3.Text = KNS3.Text.Replace("[HP]", GetPlayerHealth)
                                KNS3.Text = KNS3.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS3.Text = KNS3.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS3.Text & "(Gangwar)")
                            End If
                            If Einstellungen.GWKNS.Checked = True Then
                                Dim GWKNN As String = Einstellungen.GWKN.Text
                                GWKNN = GWKNN.Replace("[Kills]", Kills.Text)
                                GWKNN = GWKNN.Replace("[HKills]", Killsh.Text)
                                GWKNN = GWKNN.Replace("[Ort]", Ort)
                                GWKNN = GWKNN.Replace("[HP]", GetPlayerHealth)
                                GWKNN = GWKNN.Replace("[Armour]", GetPlayerArmour)
                                GWKNN = GWKNN.Replace("[Waffe]", Waffe)
                                SendChat(GWKNN)
                            End If
                            GW.Text = "1"
                            Status.Text = "Gangwar"
                            Status.BackColor = Color.GreenYellow
                            TGW.Start()
                            If Einstellungen.KSs.Checked = True Then
                                Process.Start(Einstellungen.KSp.Text)
                            End If
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] INFO: {FFFFFF}Du bist wieder frei! Bitte benimm dich in Zukunft." Then
                            Ende.Start()
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "]") And CL.Text.Contains(" hat deine Reanimation abgebrochen.") Then
                            GW.Text = "0"
                            System.Threading.Thread.Sleep("1000")
                            SendChat("/friedhof")
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] INFO: {FFFFFF}Du wirst nun mit einem Defibrillator reanimiert (Dauer: ") Then
                            GW.Text = "0"
                            If IsNumeric(CL.Text.Split(" ")(10)) Then
                                TZ.Text = CL.Text.Split(" ")(10)
                            Else
                                SendChat("/friedhof")
                            End If

                        End If
                        If KZ.Text < "1" Then
                            Me.Size = New Size(240, 215)
                            SD.Visible = False
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Es wurde ein Report an die Admins gesendet!" Then

                            GW.Text = "0"
                            System.Threading.Thread.Sleep("100")
                            Kills.Text = Kills.Text + 1
                            LogEintrag("Kill")
                            LevelPunkte = Math.Round(5 * (Level ^ 2 / 3), 0)
                            If Kills.Text > LevelPunkte Then
                                Level = Level + 1
                                Einstellungen.NNPLevel.Text = Level
                                ShowGameText("~b~Noname Produkt Level! ~n~~y~ Level ~r~" & Level & "~y~ erreicht. ~n~~r~" & Kills.Text & "/" & Math.Round(5 * (Level ^ 2 / 3), 0) & "~y~ bis Level ~r~" & Level + 1 & "~y~.", 0, 1)
                            End If
                            Killsh.Text = Killsh.Text + 1
                            If Tode.Text > "0" Then
                                KD.Text = Kills.Text / Tode.Text
                            Else
                                KD.Text = Kills.Text
                            End If
                            If Todeh.Text > "0" Then
                                KDh.Text = Killsh.Text / Todeh.Text
                            Else
                                KDh.Text = Killsh.Text
                            End If
                            Speichern()
                            '##############################################################################################
                            If Einstellungen.KNB1.Text.Contains("[Ort]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Ort]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Ort]") And Einstellungen.KNS3.Checked = True Then
                                Orte()
                            End If


                            '##############################################################################################################
                            If Einstellungen.KNS1.Checked = True Then
                                KNS1.Text = Einstellungen.KNB1.Text
                                KNS1.Text = KNS1.Text.Replace("[Kills]", Kills.Text)
                                KNS1.Text = KNS1.Text.Replace("[HKills]", Killsh.Text)
                                KNS1.Text = KNS1.Text.Replace("[Ort]", Ort)
                                KNS1.Text = KNS1.Text.Replace("[HP]", GetPlayerHealth)
                                KNS1.Text = KNS1.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS1.Text = KNS1.Text.Replace("[Waffe]", "dem Rotor")
                                SendChat(KNS1.Text & " (Rotorkill)")
                            End If
                            If Einstellungen.KNS2.Checked = True Then
                                KNS2.Text = Einstellungen.KNB2.Text
                                KNS2.Text = KNS2.Text.Replace("[Kills]", Kills.Text)
                                KNS2.Text = KNS2.Text.Replace("[HKills]", Killsh.Text)
                                KNS2.Text = KNS2.Text.Replace("[Ort]", Ort)
                                KNS2.Text = KNS2.Text.Replace("[HP]", GetPlayerHealth)
                                KNS2.Text = KNS2.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS2.Text = KNS2.Text.Replace("[Waffe]", "dem Rotor")
                                SendChat(KNS2.Text & " (Rotorkill)")
                            End If
                            If Einstellungen.KNS3.Checked = True Then
                                KNS3.Text = Einstellungen.KNB3.Text
                                KNS3.Text = KNS3.Text.Replace("[Kills]", Kills.Text)
                                KNS3.Text = KNS3.Text.Replace("[HKills]", Killsh.Text)
                                KNS3.Text = KNS3.Text.Replace("[Ort]", Ort)
                                KNS3.Text = KNS3.Text.Replace("[HP]", GetPlayerHealth)
                                KNS3.Text = KNS3.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS3.Text = KNS3.Text.Replace("[Waffe]", "dem Rotor")
                                SendChat(KNS3.Text & " (Rotorkill)")
                            End If
                            If Einstellungen.KSs.Checked = True Then
                                Process.Start(Einstellungen.KSp.Text)
                            End If
                            If Einstellungen.HH.Checked = True Then
                                GetPlayerPos(LKPX, LKPY, Z)
                            End If
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Du hast ein Verbrechen begangen ( Vorsätzlicher Mord ). Reporter: Anonym." Or CL.Text = "[" & TimeOfDay & "] {CC210A}SERVER:{FFFFFF} Du hast gerade einen Mord begangen. Achtung!" Or CL.Text = "[" & TimeOfDay & "] Du hast ein Verbrechen begangen ( Fahrerflucht ). Reporter: Anonym." Then

                            GW.Text = "0"
                            System.Threading.Thread.Sleep("100")
                            Kills.Text = Kills.Text + 1
                            LogEintrag("Kill")
                            LevelPunkte = Math.Round(5 * (Level ^ 2 / 3), 0)
                            If Kills.Text > LevelPunkte Then
                                Level = Level + 1
                                Einstellungen.NNPLevel.Text = Level
                                ShowGameText("~b~Noname Produkt Level! ~n~~y~ Level ~r~" & Level & "~y~ erreicht. ~n~~r~" & Kills.Text & "/" & Math.Round(5 * (Level ^ 2 / 3), 0) & "~y~ bis Level ~r~" & Level + 1 & "~y~.", 0, 1)
                            End If
                            Killsh.Text = Killsh.Text + 1
                            If Tode.Text > "0" Then
                                KD.Text = Kills.Text / Tode.Text
                            Else
                                KD.Text = Kills.Text
                            End If
                            If Todeh.Text > "0" Then
                                KDh.Text = Killsh.Text / Todeh.Text
                            Else
                                KDh.Text = Killsh.Text
                            End If
                            Speichern()
                            '##############################################################################################
                            If Einstellungen.KNB1.Text.Contains("[Ort]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Ort]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Ort]") And Einstellungen.KNS3.Checked = True Then
                                Orte()
                            End If

                            If Einstellungen.KNB1.Text.Contains("[Waffe]") And Einstellungen.KNS1.Checked = True Or Einstellungen.KNB2.Text.Contains("[Waffe]") And Einstellungen.KNS2.Checked = True Or Einstellungen.KNB3.Text.Contains("[Waffe]") And Einstellungen.KNS3.Checked = True Then
                                If IsPlayerInAnyVehicle Then
                                    Waffe = "einem Fahrzeug"
                                Else
                                    WaffenID = GetPlayerWeaponID
                                    If WaffenID = 0 Then
                                        Waffe = "der Faust"
                                    ElseIf WaffenID = 5 Then
                                        Waffe = "dem Baseballschläger"
                                    ElseIf WaffenID = 24 Then
                                        Waffe = "der Deagle"
                                    ElseIf WaffenID = 29 Then
                                        Waffe = "der MP5"
                                    ElseIf WaffenID = 30 Then
                                        Waffe = "der AK47"
                                    ElseIf WaffenID = 41 Then
                                        Waffe = "dem Spray"
                                    ElseIf WaffenID = 4 Then
                                        Waffe = "dem Messer"
                                    ElseIf WaffenID = 8 Then
                                        Waffe = "dem Katana"
                                    ElseIf WaffenID = 22 Then
                                        Waffe = "der 9mm"
                                    ElseIf WaffenID = 23 Then
                                        Waffe = "der 9mm (Schallgedämpft)"
                                    ElseIf WaffenID = 9 Then
                                        Waffe = "der Kettensäge"
                                    ElseIf WaffenID = 3 Then
                                        Waffe = "dem Schlagstock"
                                    ElseIf WaffenID = 26 Then
                                        Waffe = "der Shotgun"
                                    ElseIf WaffenID = 31 Then
                                        Waffe = "der M4"
                                    ElseIf WaffenID = 33 Then
                                        Waffe = "der Coun Rfile"
                                    ElseIf WaffenID = 34 Then
                                        Waffe = "der Sniper"
                                    ElseIf WaffenID = 35 Then
                                        Waffe = "dem Raketenwerfer"
                                    ElseIf WaffenID = 42 Then
                                        Waffe = "dem Feuerlöscher"
                                    Else
                                        Waffe = "einer unbekannten Waffe"
                                    End If
                                End If
                            End If

                            '##############################################################################################################
                            If Einstellungen.KNS1.Checked = True Then
                                KNS1.Text = Einstellungen.KNB1.Text
                                KNS1.Text = KNS1.Text.Replace("[Kills]", Kills.Text)
                                KNS1.Text = KNS1.Text.Replace("[HKills]", Killsh.Text)
                                KNS1.Text = KNS1.Text.Replace("[Ort]", Ort)
                                KNS1.Text = KNS1.Text.Replace("[HP]", GetPlayerHealth)
                                KNS1.Text = KNS1.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS1.Text = KNS1.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS1.Text)
                            End If
                            If Einstellungen.KNS2.Checked = True Then
                                KNS2.Text = Einstellungen.KNB2.Text
                                KNS2.Text = KNS2.Text.Replace("[Kills]", Kills.Text)
                                KNS2.Text = KNS2.Text.Replace("[HKills]", Killsh.Text)
                                KNS2.Text = KNS2.Text.Replace("[Ort]", Ort)
                                KNS2.Text = KNS2.Text.Replace("[HP]", GetPlayerHealth)
                                KNS2.Text = KNS2.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS2.Text = KNS2.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS2.Text)
                            End If
                            If Einstellungen.KNS3.Checked = True Then
                                KNS3.Text = Einstellungen.KNB3.Text
                                KNS3.Text = KNS3.Text.Replace("[Kills]", Kills.Text)
                                KNS3.Text = KNS3.Text.Replace("[HKills]", Killsh.Text)
                                KNS3.Text = KNS3.Text.Replace("[Ort]", Ort)
                                KNS3.Text = KNS3.Text.Replace("[HP]", GetPlayerHealth)
                                KNS3.Text = KNS3.Text.Replace("[Armour]", GetPlayerArmour)
                                KNS3.Text = KNS3.Text.Replace("[Waffe]", Waffe)
                                SendChat(KNS3.Text)
                            End If
                            If Einstellungen.KSs.Checked = True Then
                                Process.Start(Einstellungen.KSp.Text)
                            End If
                            If Einstellungen.HH.Checked = True Then
                                GetPlayerPos(LKPX, LKPY, Z)
                            End If
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Als Gefangener kannst du den fchat nicht nutzen." Then
                            GW.Text = "0"
                            System.Threading.Thread.Sleep("1000")
                            SendChat("/Jailtime")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}VG" Then

                            If Me.TopMost = True Then
                                Me.TopMost = False
                                VordergrundToolStripMenuItem.Checked = False
                                AddChatMessage("Das NNP wird jetzt {FF0000}nichtmehr im Vordergrund {FFFFFF}angezeigt!")
                            ElseIf Me.TopMost = False Then
                                Me.TopMost = True
                                VordergrundToolStripMenuItem.Checked = True
                                AddChatMessage("Das NNP wird jetzt {00E533}im Vordergrund {FFFFFF}angezeigt!")
                            End If
                            System.Threading.Thread.Sleep("1000")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}TS" Then

                            AddChatMessage("Du hast {FF0000}alle Timer gestoppt{FFFFFF}!")
                            Atimer.Stop()
                            MaskenTimer.Stop()
                            TTod.Stop()
                            WaffenTimer.Stop()
                            TKnast.Stop()
                            Defi.Stop()
                            TEinbruch.Stop()
                            BombenTimer.Stop()
                            TruckingTimer.Stop()
                            KZ.Text = ""
                            KS.Text = "0"
                            KS2.Text = "0"
                            Einbruch.Text = ""
                            TB1.Text = ""
                            TB2.Text = ""
                            P1.Value = "0"
                            TZ.Text = "0"
                            Status.Text = "Frei/lebend"
                            Status.BackColor = Color.Green
                            If CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}NS" Then
                            TCL.Stop()
                            BGTimer.Stop()

                            NS = Me.Location.X & "," & Me.Location.Y
                            Dim path As String = ".\NNPPos.Gaga"
                            Dim fs As FileStream = File.Create(path)
                            Dim info As Byte() = New UTF8Encoding(True).GetBytes(NS & vbCrLf & Me.TopMost)
                            fs.Write(info, 0, info.Length)
                            fs.Close()
                            Me.TopMost = False
                            If Me.TopMost = True Then
                                AddChatMessage("Das Noname Produkt wird jetzt neugestartet! (Position: {00E533}P(" & NS & "){FFFFFF}, Vordergrund: {00E533}Ja{FFFFFF})")
                                Me.TopMost = False
                            Else
                                AddChatMessage("Das Noname Produkt wird jetzt neugestartet! (Position: {00E533}P(" & NS & "){FFFFFF}, Vordergrund: {ff0000}Nein{FFFFFF})")
                                Me.TopMost = False
                            End If
                            System.Threading.Thread.Sleep("500")
                            Process.Start(".\Noname Produkt.exe")
                            End
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}STVO" Then
                            'If Not GetVehicleHealth = "0" Then
                            SendChat("/s Hey du Verkehrsrowdy! Wegen dir habe ich nurnoch " & GetVehicleHealth & " Carheal!")
                            System.Threading.Thread.Sleep("1000")
                            'End If
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] Du bist noch ca. ") And CL.Text.Contains(" Sekunden auf dem Friedhof!") Then
                            MaskenTimer.Stop()
                            GW.Text = "0"
                            If IsNumeric(CL.Text.Split(" ")(5)) Then
                                'MSGBOX(CL.Text & vbCrLf & vbCrLf & CL.Text.Split(" ")(4))
                                TZ.Text = CL.Text.Split(" ")(5)
                                P1.Maximum = CL.Text.Split(" ")(5)
                                CDK.P1.Maximum = P1.Maximum
                                TKnast.Stop()
                                TTod.Start()
                                WaffenTimer.Stop()
                                P1.Value = "0"
                                Status.Text = "tot"
                                LogEintrag("Tot")
                                Status.BackColor = Color.Yellow
                                LMi.Text = Math.Round((TZ.Text / 60), 0)
                                LMi.Text = Now.Minute + LMi.Text
                                LSt.Text = Now.Hour
                                If LMi.Text = "60" Or LMi.Text = "61" Or LMi.Text = "62" Or LMi.Text = "63" Or LMi.Text = "64" Or LMi.Text = "65" Or LMi.Text = "66" Or LMi.Text = "67" Or LMi.Text = "68" Or LMi.Text = "69" Or LMi.Text = "70" Then
                                    LSt.Text = LSt.Text + 1
                                    LMi.Text = LMi.Text - 60
                                End If
                                If LSt.Text = "24" Then
                                    LSt.Text = "00"
                                End If
                                If LSt.Text = "1" Or LSt.Text = "2" Or LSt.Text = "3" Or LSt.Text = "4" Or LSt.Text = "5" Or LSt.Text = "6" Or LSt.Text = "7" Or LSt.Text = "8" Or LSt.Text = "9" Or LSt.Text = "0" Then
                                    LSt.Text = "0" & LSt.Text
                                End If
                                If LMi.Text = "1" Or LMi.Text = "2" Or LMi.Text = "3" Or LMi.Text = "4" Or LMi.Text = "5" Or LMi.Text = "6" Or LMi.Text = "7" Or LMi.Text = "8" Or LMi.Text = "9" Or LMi.Text = "0" Then
                                    LMi.Text = "0" & LMi.Text
                                End If
                                TB2.Text = "Du lebst wieder um ca. " & LSt.Text & ":" & LMi.Text & " Uhr."
                                'AddChatMessage("Du lebst wieder um ca. {00E533}" & LSt.Text & ":" & LMi.Text & "{FFFFFF} Uhr.")
                                LSDTimer.Stop()
                                LSDZ = 110
                            End If
                            If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                CDK.TCDK.Start()
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Deine Strafe ist noch nicht vorbei, zurück in den Knast." Then
                            GW.Text = "0"
                            System.Threading.Thread.Sleep("1000")
                            If KZ.Text < "5" Then
                                SendChat("/jailtime")
                            End If
                            If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                CDK.TCDK.Start()
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Tipp /jailtime um deine abgesessene Zeit zu sehen." Then
                            MaskenTimer.Stop()

                            GW.Text = "0"
                            TEinbruch.Stop()
                            TTod.Stop()
                            If IsNumeric(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(6)) And KZ.Text < 4 Then
                                KZ.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(6)

                                Dim KZI2 As Integer
                                If Einstellungen.LVL.Checked = True Then
                                    KZ.Text = KZ.Text - -415
                                    TZ.Text = "415"
                                Else
                                    KZ.Text = KZ.Text - -180
                                    TZ.Text = "180"
                                End If
                                KZI2 = KZ.Text / 60
                                System.Threading.Thread.Sleep("120")
                                KZI2 = Math.Round((KZI2 * 73), 0)
                                Status.Text = "Tot + gefangen"
                                LogEintrag("Tot")
                                Status.BackColor = Color.Red
                                KZ.Text = KZI2
                                P1.Maximum = KZ.Text
                                CDK.P1.Maximum = P1.Maximum
                                P1.Value = "0"
                                KMi.Text = KZ.Text / 60
                                KMi.Text = Now.Minute + KMi.Text
                                KSt.Text = Now.Hour
                                If KMi.Text > "59" Then
KnastW:
                                    KSt.Text = KSt.Text + 1
                                    KMi.Text = KMi.Text - 60
                                End If
                                If KMi.Text > "59" Then
                                    GoTo KnastW
                                End If
                                If KSt.Text = "24" Then
                                    KSt.Text = "00"
                                End If
                                If KSt.Text = "25" Then
                                    KSt.Text = "01"
                                End If
                                If KSt.Text = "1" Or KSt.Text = "2" Or KSt.Text = "3" Or KSt.Text = "4" Or KSt.Text = "5" Or KSt.Text = "6" Or KSt.Text = "7" Or KSt.Text = "8" Or KSt.Text = "9" Or KSt.Text = "0" Then
                                    KSt.Text = "0" & KSt.Text
                                End If
                                If KMi.Text = "1" Or KMi.Text = "2" Or KMi.Text = "3" Or KMi.Text = "4" Or KMi.Text = "5" Or KMi.Text = "6" Or KMi.Text = "7" Or KMi.Text = "8" Or KMi.Text = "9" Or KMi.Text = "0" Then
                                    KMi.Text = "0" & KMi.Text
                                End If
                                If KMi.Text.Contains(",") Then
                                    KMi.Text = KMi.Text.Split(",")(0)
                                End If
                                If KMi.Text.Contains("-") Then
                                    KMi.Text = "60" - -KMi.Text
                                End If
                                TB2.Text = "Du bist um ca. " & KSt.Text & ":" & KMi.Text & " Uhr wieder frei."
                                'AddChatMessage("Du bist um ca. {00E533}" & KSt.Text & ":" & KMi.Text & "{FFFFFF} Uhr wieder frei ({FF0000}" & KZ.Text & "{FFFFFF} sekunden).")
                                TKnast.Start()
                                WaffenTimer.Stop()
                                If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                    CDK.TCDK.Start()
                                End If
                                MaximumSize = New Size(240, 230)
                                Size = New Size(240, 230)
                                SD.Visible = True
                            End If
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] Du hast dich erfolgreich ") And CL.Text.Contains(" freigekauft.") Then
                            SendChat("/jailtime")
                            System.Threading.Thread.Sleep("1000")
                            If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                CDK.TCDK.Start()
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] " & Einstellungen.IngameName.Text & ", du bist nicht länger gesucht Grund: Eingesperrt" Then
                            System.Threading.Thread.Sleep("1000")
                            GW.Text = "0"
                            SendChat("/Jailtime")
                        End If

                        If Not IsNumeric(KZ.Text) And Not IsNumeric(TZ.Text) Then
                            Status.Text = "Frei/lebend"
                            Status.BackColor = Color.Green
                            P1.Value = "0"
                            TTod.Stop()
                            TKnast.Stop()
                            TZ.Text = 0
                            KZ.Text = 0
                            TB1.Text = ""
                            TB2.Text = ""
                            MaximumSize = New Size(240, 216)
                            Size = New Size(240, 216)
                            SD.Visible = False
                            If CDK.Pos = 1 Then
                                CDK.TCDK.Start()
                            End If
                        End If
                        If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("[" & TimeOfDay & "] Du bist für ") And System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Contains("Sekunden im Knast. Kaution:") Then

                            If IsNumeric(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(4)) And KZ.Text < 4 Then
                                KZ.Text = System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 4).Split(" ")(4)
                                GW.Text = "0"
                                TKnast.Start()
                                WaffenTimer.Stop()
                                Status.Text = "Gefangen"
                                Status.BackColor = Color.Red
                                P1.Maximum = KZ.Text
                                CDK.P1.Maximum = P1.Maximum
                                P1.Value = "0"
                                KMi.Text = KZ.Text / 59
                                KMi.Text = Now.Minute + KMi.Text
                                KSt.Text = Now.Hour
                                If KMi.Text > 59 Then
EKLoop:
                                    KSt.Text = KSt.Text + 1
                                    KMi.Text = KMi.Text - 60
                                End If
                                If KMi.Text > 59 Then
                                    GoTo EKLoop
                                End If

                                If KSt.Text = "24" Then
                                    KSt.Text = "00"
                                End If
                                If KSt.Text = "25" Then
                                    KSt.Text = "01"
                                End If
                                If KSt.Text = "1" Or KSt.Text = "2" Or KSt.Text = "3" Or KSt.Text = "4" Or KSt.Text = "5" Or KSt.Text = "6" Or KSt.Text = "7" Or KSt.Text = "8" Or KSt.Text = "9" Or KSt.Text = "0" Then
                                    KSt.Text = "0" & KSt.Text
                                End If
                                If KMi.Text = "1" Or KMi.Text = "2" Or KMi.Text = "3" Or KMi.Text = "4" Or KMi.Text = "5" Or KMi.Text = "6" Or KMi.Text = "7" Or KMi.Text = "8" Or KMi.Text = "9" Or KMi.Text = "0" Then
                                    KMi.Text = "0" & KMi.Text
                                End If


                                TB2.Text = "Du bist um ca. " & KSt.Text & ":" & KMi.Text & " Uhr wieder frei."
                                'AddChatMessage("Du bist um ca. {00E533}" & KSt.Text & ":" & KMi.Text & "{FFFFFF} Uhr wieder frei.")
                                LSDTimer.Stop()
                                LSDZ = 110
                                KS.Text = "0"
                                If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                    CDK.TCDK.Start()
                                End If
                                MaximumSize = New Size(240, 230)
                                Size = New Size(240, 230)
                                SD.Visible = True
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Tote können keine Befehle benutzen!" And TZ.Text < "1" Then
                            System.Threading.Thread.Sleep("1000")
                            SendChat("/friedhof")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Tote können nicht sprechen." And TZ.Text < "1" Then
                            System.Threading.Thread.Sleep("1000")
                            SendChat("/friedhof")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] INFO: {FFFFFF}Mit /quiz kannst du ein Quizduell starten oder mit /newquiz neue Fragen erstellen." Then
                            MaskenTimer.Stop()

                            If Status.BackColor = Color.Green Or Status.BackColor = Color.GreenYellow Then
                                If TZ.Text < 4 Then
                                    Defi.Stop()
                                    TEinbruch.Stop()
                                    TKnast.Stop()
                                    TTod.Start()
                                    WaffenTimer.Stop()
                                    Tode.Text = Tode.Text + 1
                                    Todeh.Text = Todeh.Text + 1
                                    KD.Text = Kills.Text / Tode.Text
                                    KDh.Text = Killsh.Text / Todeh.Text
                                    System.Threading.Thread.Sleep("1000")
                                    Speichern()
                                    If GW.Text = "1" Then
                                        TZ.Text = "60"
                                        LMi.Text = Now.Minute + 1
                                        P1.Maximum = "60"
                                        CDK.P1.Maximum = P1.Maximum
                                        GW.Text = "0"
                                    Else
                                        If Einstellungen.LVL.Checked = True Then
                                            LMi.Text = Now.Minute + 7
                                            If ((KleeblattZeit(1) * 3600) + (KleeblattZeit(2) * 60) + KleeblattZeit(3) + 18000) >= ((Now.Hour * 3600) + (Now.Minute * 60) + Now.Second) Then
                                                AddChatMessage("Debugging: " & ((KleeblattZeit(1) * 3600) + (KleeblattZeit(2) * 60) + KleeblattZeit(3) + 18000) >= ((Now.Hour * 3600) + (Now.Minute * 60) + Now.Second))
                                                P1.Maximum = "300"
                                                TZ.Text = "300"
                                            Else
                                                P1.Maximum = "415"
                                                TZ.Text = "415"
                                            End If
                                        Else
                                            TZ.Text = "180"
                                            LMi.Text = Now.Minute + 3
                                            P1.Maximum = "180"
                                        End If
                                        CDK.P1.Maximum = P1.Maximum
                                    End If
                                    P1.Value = "0"
                                    LSt.Text = Now.Hour
                                    If LMi.Text = "60" Or LMi.Text = "61" Or LMi.Text = "62" Or LMi.Text = "63" Or LMi.Text = "64" Or LMi.Text = "65" Or LMi.Text = "66" Or LMi.Text = "67" Or LMi.Text = "68" Or LMi.Text = "69" Or LMi.Text = "70" Then
                                        LSt.Text = LSt.Text + 1
                                        LMi.Text = LMi.Text - 60
                                    End If
                                    If LSt.Text = "24" Then
                                        LSt.Text = "00"
                                    End If
                                    If LSt.Text = "1" Or LSt.Text = "2" Or LSt.Text = "3" Or LSt.Text = "4" Or LSt.Text = "5" Or LSt.Text = "6" Or LSt.Text = "7" Or LSt.Text = "8" Or LSt.Text = "9" Or LSt.Text = "0" Then
                                        LSt.Text = "0" & LSt.Text
                                    End If
                                    If LMi.Text = "1" Or LMi.Text = "2" Or LMi.Text = "3" Or LMi.Text = "4" Or LMi.Text = "5" Or LMi.Text = "6" Or LMi.Text = "7" Or LMi.Text = "8" Or LMi.Text = "9" Or LMi.Text = "0" Then
                                        LMi.Text = "0" & LMi.Text
                                    End If
                                    TB2.Text = "Du lebst wieder um ca. " & LSt.Text & ":" & LMi.Text & " Uhr."
                                    'AddChatMessage("Du lebst wieder um ca. {00E533}" & LSt.Text & ":" & LMi.Text & "{FFFFFF} Uhr (in {FF0000}" & TZ.Text & "{FFFFFF} sekunden).")
                                    LSDTimer.Stop()
                                    LSDZ = 110
                                    Status.Text = "Tot"
                                    LogEintrag("Tot")
                                    Status.BackColor = Color.Yellow
                                    If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                        CDK.TCDK.Start()
                                    End If
                                End If
                            End If
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] Werbung: ") Then
                            ADZeit.Text = "62"
                            ADTimer.Start()
                        End If
                        If CL.Text = "[" & TimeOfDay & "]   Man kann nur alle 60 Sekunden eine AD/Werbung machen!" Or CL.Text = "[" & TimeOfDay & "] Du bist nicht an einem AD Punkt (LS BSN/SF Bahnhof)." Then
                            If ADZeit.Text > "0" Then
                                AddChatMessage("Du kannst in {00E533}" & ADZeit.Text & " {FFFFFF}sekunden wieder eine Werbung machen!")
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] * Du bist nun 10min auf dem Friedhof, da ein Kopfgeld auf dich ausgesetzt war!" Or CL.Text = "[" & TimeOfDay & "] << Du wurdest gerade von einem Hitman getötet. Grund: Gruppenauftrag gegen deine Fraktion (/fcontract). >>" Then

                            MaskenTimer.Stop()
                            GW.Text = "0"
                            TEinbruch.Stop()
                            TKnast.Stop()
                            Tode.Text = Tode.Text + 1
                            Todeh.Text = Todeh.Text + 1
                            KD.Text = Kills.Text / Tode.Text
                            KDh.Text = Killsh.Text / Todeh.Text
                            Speichern()
                            Status.Text = "Tot (Hitman)"
                            LogEintrag("Tot")
                            Status.BackColor = Color.Yellow
                            TZ.Text = "600"
                            P1.Maximum = "600"
                            CDK.P1.Maximum = P1.Maximum
                            P1.Value = "0"
                            LMi.Text = Now.Minute + 10
                            LSt.Text = Now.Hour
                            If LMi.Text = "60" Or LMi.Text = "61" Or LMi.Text = "62" Or LMi.Text = "63" Or LMi.Text = "64" Or LMi.Text = "65" Or LMi.Text = "66" Or LMi.Text = "67" Or LMi.Text = "68" Or LMi.Text = "69" Or LMi.Text = "70" Then
                                LSt.Text = LSt.Text + 1
                                LMi.Text = LMi.Text - 60
                            End If
                            If LSt.Text = "24" Then
                                LSt.Text = "00"
                            End If
                            If LSt.Text = "1" Or LSt.Text = "2" Or LSt.Text = "3" Or LSt.Text = "4" Or LSt.Text = "5" Or LSt.Text = "6" Or LSt.Text = "7" Or LSt.Text = "8" Or LSt.Text = "9" Or LSt.Text = "0" Then
                                LSt.Text = "0" & LSt.Text
                            End If
                            If LSt.Text = "1" Or LSt.Text = "2" Or LSt.Text = "3" Or LSt.Text = "4" Or LSt.Text = "5" Or LSt.Text = "6" Or LSt.Text = "7" Or LSt.Text = "8" Or LSt.Text = "9" Or LSt.Text = "0" Then
                                LSt.Text = "0" & LSt.Text
                            End If
                            TB2.Text = "Du lebst wieder um ca. " & LSt.Text & ":" & LMi.Text & " Uhr."
                            'AddChatMessage("Du lebst wieder um ca. {00E533}" & LSt.Text & ":" & LMi.Text & "{FFFFFF} Uhr (in {FF0000}" & TZ.Text & "{FFFFFF} sekunden) ({00E533}Hitmankill{FFFFFF}).")
                            LSDTimer.Stop()
                            LSDZ = 110
                            System.Threading.Thread.Sleep("1000")
                            TTod.Start()
                            WaffenTimer.Stop()
                            If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                CDK.TCDK.Start()
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Du wirst nun von einem Arzt reanimiert." Then

                            GW.Text = "0"
                            TZ.Text = "13"
                            TB2.Text = "Du wirst von einem Arzt reanimiert."
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Du wirst nun von einem Arzt direkt reanimiert." Then

                            GW.Text = "0"
                            TZ.Text = "2"
                            TB2.Text = ""
                        End If
                        If CL.Text = "[" & TimeOfDay & "] INFO: {FFFFFF}Das Brecheisen ist nun verbraucht. Für den nächsten Einbruch wist du ein neues benötigen." Then
                            Einbruch.Text = "25"
                            GW.Text = "0"
                            P1.Value = "0"
                            P1.Maximum = "25"
                            CDK.P1.Maximum = P1.Maximum
                            TB1.Text = "Du brichst gerade in ein Haus ein!"
                            TEinbruch.Start()
                        End If
                        If CL.Text = "[" & TimeOfDay & "]  Du benötigst nun 20 Sekunden, um die Hauskasse zu leeren." Then
                            Einbruch.Text = "20"
                            GW.Text = "0"
                            P1.Value = "0"
                            P1.Maximum = "20"
                            CDK.P1.Maximum = P1.Maximum
                            TB1.Text = "Du raubst gerade ein Haus aus!"
                            TEinbruch.Start()
                        End If
                        If CL.Text = "[" & TimeOfDay & "]  Du bist nun 40 Sekunden außer Gefecht gesetzt. Danach solltest du schnell abhauen." Then
                            Einbruch.Text = "40"
                            P1.Value = "0"
                            GW.Text = "0"
                            P1.Maximum = "40"
                            CDK.P1.Maximum = P1.Maximum
                            TB1.Text = "Du raubst gerade ein Haus aus!"
                            TEinbruch.Start()
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Wenn dich der Bewohner oder Wachschutz in der Zwischenzeit tötet, bekommst du kein Geld!" Then
                            Einbruch.Text = "600"
                            P1.Value = "0"
                            GW.Text = "0"
                            P1.Maximum = "600"
                            CDK.P1.Maximum = P1.Maximum
                            TB1.Text = "Du musst noch 10 Minuten überleben!"
                            TEinbruch.Start()
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Achtung: Gangwar Ausrüstung hinzugefügt!" Then
                            GW.Text = "1"
                            Status.Text = "Gangwar"
                            Status.BackColor = Color.GreenYellow
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}GW" Then
                            GW.Text = "1"
                            Status.Text = "Gangwar"
                            Status.BackColor = Color.GreenYellow
                            AddChatMessage("Gangwarmodus {00E533}gestartet{FFFFFF}.")
                        End If
                        If CL.Text.ToUpper = "[" & TimeOfDay & "] #: {FFFFFF}GWENDE" Then
                            GW.Text = "0"
                            Status.Text = "Frei/lebend"
                            Status.BackColor = Color.Green
                            AddChatMessage("Gangwarmodus {FF0000}gestoppt{FFFFFF}.")
                        End If
                        If CL.Text.Contains("[" & TimeOfDay & "] Du bist noch") And CL.Text.Contains(" Sekunden im Gefängnis.") Then

                            GW.Text = "0"
                            If IsNumeric(CL.Text.Split(" ")(4)) Then
                                'MSGBOX(CL.Text & vbCrLf & vbCrLf & CL.Text.Split(" ")(4))
                                KS.Text = CL.Text.Split(" ")(4)
                                KS.Text = KS.Text * 4200
                                KS2.Text = CL.Text.Split(" ")(6)
                                KS2.Text = Math.Round((KS2.Text * 73), 0)
                                KZ.Text = KS2.Text - -KS.Text
                                KS.Text = CL.Text.Split(" ")(9)
                                KZ.Text = KZ.Text - -KS.Text
                                P1.Maximum = KZ.Text
                                CDK.P1.Maximum = P1.Maximum
                                P1.Value = "0"
                                KS2.Text = KZ.Text / 60
                                KZI2 = KZ.Text / 60
                                KS2.Text = Math.Round(KZI2, 2)
                                KMi.Text = Minute(Now) - -KS2.Text
                                KSt.Text = Hour(Now)
                                Do
                                    KSt.Text = KSt.Text + 1
                                    KMi.Text = KMi.Text - 60
                                Loop While KMi.Text > 59
                                If KSt.Text > "23" Then
                                    KSt.Text = KS.Text - 24
                                End If
                                If KSt.Text = "1" Or KSt.Text = "2" Or KSt.Text = "3" Or KSt.Text = "4" Or KSt.Text = "5" Or KSt.Text = "6" Or KSt.Text = "7" Or KSt.Text = "8" Or KSt.Text = "9" Or KSt.Text = "0" Then
                                    KSt.Text = "0" & KSt.Text
                                End If
                                If KMi.Text.Contains("-") Then
                                    KMi.Text = "60" - -KMi.Text
                                End If
                                If KMi.Text = "1" Or KMi.Text = "2" Or KMi.Text = "3" Or KMi.Text = "4" Or KMi.Text = "5" Or KMi.Text = "6" Or KMi.Text = "7" Or KMi.Text = "8" Or KMi.Text = "9" Or KMi.Text = "0" Then
                                    KMi.Text = "0" & KMi.Text
                                End If
                                TB2.Text = "Du bist um ca. " & KSt.Text & ":" & KMi.Text & " Uhr wieder frei."
                                'AddChatMessage("Du bist um ca. {00E533}" & KSt.Text & ":" & KMi.Text & "{FFFFFF} Uhr wieder frei. (in {FF0000}" & KZ.Text & "{FFFFFF} sekunden).")
                                LSDTimer.Stop()
                                LSDZ = 110
                                Status.Text = "Gefangen"
                                Status.BackColor = Color.Red
                                System.Threading.Thread.Sleep("1000")
                                TKnast.Start()
                                WaffenTimer.Stop()
                                If CDK.Pos = 0 And Einstellungen.CDKA.Checked = True Then
                                    CDK.TCDK.Start()
                                End If
                            End If
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Schalte zuerst dein Mobiltelefon mit /togphone ein." Then
                            SendChat("/togphone")
                            System.Threading.Thread.Sleep("100")
                            SendChat("/service")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] Du kannst keinen Anruf tätigen, da ein Telefon nicht eingeschaltet ist." Then
                            SendChat("/togphone")
                            System.Threading.Thread.Sleep("100")
                        End If
                        If CL.Text = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Dein Handy ist aus. (Einschalten mit /togphone)" Then
                            SendChat("/togphone")
                            System.Threading.Thread.Sleep("100")
                        End If
                    End If

                    'Catch
                    'GoTo CLWirderholen
                    'End Try
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub TTod_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTod.Tick

        If Not IsNumeric(KZ.Text) And Not IsNumeric(TZ.Text) Then
            Status.Text = "Frei/lebend"
            Status.BackColor = Color.Green
            P1.Value = "0"
            TTod.Stop()
            TKnast.Stop()
            TZ.Text = 0
            KZ.Text = 0
            TB1.Text = ""
            TB2.Text = ""
            MaximumSize = New Size(240, 215)
            Size = New Size(240, 215)
            SD.Visible = False
            If CDK.Pos = 1 Then
                CDK.TCDK.Start()
            End If
        End If
        TZ.Text = TZ.Text - 1
        CDK.CDKC.Text = TZ.Text
        CDK.P1.Value = P1.Value
        P1.Value = P1.Value + 1
        If TZ.Text = "1" Then
            TB1.Text = "Du lebst wieder in " & TZ.Text & " sekunde."
        Else
            TB1.Text = "Du lebst wieder in " & TZ.Text & " sekunden."
        End If
        If TZ.Text = "20" Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If TZ.Text < "1" Then
            TTod.Stop()
            TB1.Text = ""
            TB2.Text = ""
            P1.Value = "0"
            If KZ.Text > "5" And IsNumeric(KZ.Text) Then
                Status.Text = "Gefangen"
                Status.BackColor = Color.Red
                P1.Maximum = KZ.Text
                CDK.P1.Maximum = P1.Maximum
                P1.Value = "0"
                KMi.Text = KZ.Text / 60
                KMi.Text = Now.Minute + KMi.Text
                KSt.Text = Now.Hour
                Do
                    KSt.Text = KSt.Text + 1
                    KMi.Text = KMi.Text - 60
                Loop While KMi.Text > 59
                If KSt.Text = "24" Then
                    KSt.Text = "00"
                End If
                If KSt.Text = "25" Then
                    KSt.Text = "01"
                End If
                If KSt.Text = "1" Or KSt.Text = "2" Or KSt.Text = "3" Or KSt.Text = "4" Or KSt.Text = "5" Or KSt.Text = "6" Or KSt.Text = "7" Or KSt.Text = "8" Or KSt.Text = "9" Or KSt.Text = "0" Then
                    KSt.Text = "0" & KSt.Text
                End If
                If KMi.Text = "1" Or KMi.Text = "2" Or KMi.Text = "3" Or KMi.Text = "4" Or KMi.Text = "5" Or KMi.Text = "6" Or KMi.Text = "7" Or KMi.Text = "8" Or KMi.Text = "9" Or KMi.Text = "0" Then
                    KMi.Text = "0" & KMi.Text
                End If
                TB2.Text = "Du bist um ca. " & KSt.Text & ":" & KMi.Text & " Uhr wieder frei."
                'AddChatMessage("Du bist um ca. {00E533}" & KSt.Text & ":" & KMi.Text & "{FFFFFF} Uhr wieder frei. (in {FF0000}" & KZ.Text & "{FFFFFF} sekunden).")
                TKnast.Start()
                WaffenTimer.Stop()
                LSDTimer.Stop()
                LSDZ = 110
            Else
                If Not BombenTimer.Enabled Then
                    Ende.Start()
                Else
                    TTod.Stop()
                End If
            End If
        End If


    End Sub

    Private Sub Ende_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ende.Tick

        Endet.Text = Endet.Text + 1
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        If Endet.Text = "5" Then
            If Not ITA = 1 Then
                News.Visible = True
            End If
            Ende.Stop()
            Endet.Text = "0"
            Status.Text = "Frei/lebend"
            Status.BackColor = Color.Green
            P1.Value = "0"
            TTod.Stop()
            TKnast.Stop()
            Defi.Stop()
            BombenTimer.Stop()
            TB1.Text = ""
            TB2.Text = ""
            If SD.Checked = True Then
                System.Diagnostics.Process.Start("shutdown", "-s -t 120")
                End
            Else
                MaximumSize = New Size(240, 215)
                Size = New Size(240, 215)
                SD.Visible = False
            End If
            If CDK.Pos = 1 Then
                CDK.TCDK.Start()
            End If
        End If

    End Sub

    Private Sub TKnast_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKnast.Tick

        If Not IsNumeric(KZ.Text) And Not IsNumeric(TZ.Text) Then
            Status.Text = "Frei/lebend"
            Status.BackColor = Color.Green
            P1.Value = "0"
            TTod.Stop()
            TKnast.Stop()
            TZ.Text = 0
            KZ.Text = 0
            TB1.Text = ""
            TB2.Text = ""
            MaximumSize = New Size(240, 215)
            Size = New Size(240, 215)
            SD.Visible = False
            If CDK.Pos = 1 Then
                CDK.TCDK.Start()
            End If
        End If
        KZ.Text = KZ.Text - 1
        CDK.CDKC.Text = KZ.Text
        CDK.P1.Value = P1.Value
        P1.Value = P1.Value + 1
        If TZ.Text > "0" Then
            TZ.Text = TZ.Text - 1
            If TZ.Text = "1" Then
                Status.Text = "Gefangen"
                Status.BackColor = Color.Red
            End If
        End If
        MaximumSize = New Size(240, 230)
        SD.Visible = True
        Size = New Size(240, 230)
        If KZ.Text = "1" Then
            TB1.Text = "Deine Knastzeit endet in " & KZ.Text & " sekunde."
        Else
            TB1.Text = "Deine Knastzeit endet in " & KZ.Text & " sekunden."
        End If
        If KZ.Text = "20" Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If KZ.Text < "1" Then
            TKnast.Stop()
            Ende.Start()
        End If


    End Sub

    Private Sub Start_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Tick
NeuStarten:
        Try
            S.Text = S.Text + 1


            If S.Text = "-5" Then
                Me.Opacity = 0.05
                If Not System.IO.Directory.Exists("C:\Program Files (x86)\NNP") Then
                    My.Computer.FileSystem.CreateDirectory("C:\Program Files (x86)\NNP")
                End If
            End If
            If S.Text = "-4" Then
                Me.Opacity = 0.1
                If System.IO.File.Exists(".\NNPPos.Gaga") Then
                    Me.Location = New Point(System.IO.File.ReadAllLines(".\NNPPos.Gaga")(0).Split(",")(0), System.IO.File.ReadAllLines(".\NNPPos.Gaga")(0).Split(",")(1))
                    Me.TopMost = System.IO.File.ReadAllLines(".\NNPPos.Gaga")(1)
                    System.IO.File.Delete(".\NNPPos.Gaga")
                End If
            End If
            If S.Text = "-3" Then
                Me.Opacity = 0.15
            End If
            If S.Text = "-2" Then
                Me.Opacity = 0.2
                If System.IO.File.Exists(".\NNP Update.exe") Then
                    My.Computer.FileSystem.DeleteFile(".\NNP Update.exe")

                    MsgBox("Beachte: der Chat und alle andere Funktionen welche Zugriff auf die Webseite benötigt haben sind mit der deaktivierung der Webseite nicht mehr Verfügbar!", MsgBoxStyle.Information, "Onlinefunktionen nicht Verfügbar!")
                End If
                If System.IO.File.Exists(".\NNP Setup.exe") Then
                    My.Computer.FileSystem.DeleteFile(".\NNP Setup.exe")
                    UDL.Text = "1"
                End If
                Status.Text = "Lösche API"
                Status.BackColor = Color.Yellow
                System.IO.File.Delete("C:\Program Files (x86)\NNP\API.dll")


            End If
            If S.Text = "-1" Then
                Me.Opacity = 0.25
                Status.BackColor = Color.Yellow
                Status.Text = "Extrahiere APIs"
                System.IO.File.WriteAllBytes("C:\Program Files (x86)\NNP\API.dll", My.Resources.API)
                If System.IO.File.Exists("C:\Program Files (x86)\NNP\overlay.dll") Then
                    System.IO.File.Delete("C:\Program Files (x86)\NNP\overlay.dll")
                End If
            End If
            If S.Text = "0" Then
                Me.Opacity = 0.3
                If System.IO.File.Exists("C:\Users\" & Environment.UserName & "\Documents\My Games\NNP\NNP.Gaga") And Not System.IO.File.Exists("C:\Program Files (x86)\NNP\NNP.Gaga") Then
                    My.Computer.FileSystem.CopyFile("C:\Users\" & Environment.UserName & "\Documents\My Games\NNP\NNP.Gaga", "C:\Program Files (x86)\NNP\NNP.Gaga")
                    If Not System.IO.File.Exists("C:\Users\" & Environment.UserName & "\Documents\My Games\NNP\AlteNNP.Gaga") Then
                        My.Computer.FileSystem.RenameFile("C:\Users\" & Environment.UserName & "\Documents\My Games\NNP\NNP.Gaga", "AlteNNP.Gaga")

                    End If

                ElseIf System.IO.File.Exists("C:\Users\" & Environment.UserName & "\Documents\GTA San Andreas sUser Files\SAMP\NNP.Gaga") And Not System.IO.File.Exists("C:\Program Files (x86)\NNP\NNP.Gaga") Then
                    My.Computer.FileSystem.CopyFile("C:\Users\" & Environment.UserName & "\Documents\GTA San Andreas User Files\SAMP\NNP.Gaga", "C:\Program Files (x86)\NNP\NNP.Gaga")
                    If Not System.IO.File.Exists("C:\Users\" & Environment.UserName & "\Documents\GTA San Andreas User Files\SAMP\AlteNNP.Gaga") Then
                        My.Computer.FileSystem.RenameFile("C:\Users\" & Environment.UserName & "\Documents\GTA San Andreas User Files\SAMP\NNP.Gaga", "AlteNNP.Gaga")

                    End If
                End If
            End If
            If S.Text = "1" Then
                Status.Text = "Finale Version!"
                Status.BackColor = Color.Yellow
                Me.Opacity = 0.35
                P1.Style = ProgressBarStyle.Marquee
                Me.Text = "By GagaMichi"
                If System.IO.File.Exists("C:\Program Files (x86)\NNP\NNP.Gaga") Then
                    If Not System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga").Length >= "47" Then
                        My.Computer.FileSystem.WriteAllText("C:\Program Files (x86)\NNP\NNP.Gaga", vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf, True)
                        UDL.Text = "1"
                        Start.Stop()
                        If (MsgBox("Aufgrund des Updates wurden zur NNP.Gaga Datei ein paar Zeilen hinzugefügt." & vbCrLf & "Dies kann zu Fehlermeldungen beim Start führen." & vbCrLf & "Klicke bei allen Fehlermeldungen auf 'Weiter'!" & vbCrLf & vbCrLf & "Du solltest die Einstellungen öffnen und einmal auf 'Übernehmen' klicken." & vbCrLf & "Möchtest du das jetzt tun?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then

                            Einstellungen.Show()
                            Einstellungen.Size = New Size(808, 5)
                            If Einstellungen.VST.Text = "" Then
                                Einstellungen.VST.Text = " Ich brauche [Ort] Verstärkung!"
                            End If
                            Einstellungen.Start.Start()
                        End If
                        Start.Start()
                    End If
                End If
            End If
            If S.Text = "2" Then
                Me.Opacity = 0.4

                Me.Text = "By GagaMich-"

            End If
            If S.Text = "3" Then
                Me.Opacity = 0.45
                Me.Text = "By GagaMic-"
                If System.IO.File.Exists("C:\Program Files (x86)\NNP\NNP.Gaga") Then
                    Einstellungen.CLPf.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(12)
                Else
                    Einstellungen.CLPf.Text = "C:\Users\" & Environment.UserName & "\Documents\GTA San Andreas User Files\SAMP\chatlog.txt"
                End If

            End If
            If S.Text = "4" Then
                Me.Opacity = 0.5
                If Not System.IO.File.Exists("C:\Program Files (x86)\NNP\Log.Gaga") Then
                    Dim path As String = "C:\Program Files (x86)\NNP\Log.Gaga"
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes("Erstellt am " & Now.Date & " um " & TimeOfDay & " Uhr.")
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                End If
                Me.Text = "By GagaMi-"
            End If
            If S.Text = "5" Then
                Me.Opacity = 0.55
                Me.Text = "By GagaM-"
                Status.Text = "Keine Updates"
                Status.BackColor = Color.Yellow
            End If
            If S.Text = "6" Then
                Me.Opacity = 0.6
                Me.Text = "By Gaga-"
            End If
            If S.Text = "7" Then
                Me.Opacity = 0.65
                Me.Text = "By Gag-"
                'NeuLaden:
                'Try
                If System.IO.File.Exists("C:\Program Files (x86)\NNP\NNP.Gaga") Then
                    Kills.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(0)
                    Killsh.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(1)
                    Tode.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(2)
                    Todeh.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(3)
                    Datum.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(4)
                    Einstellungen.IngameName.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(5)
                    Einstellungen.KNB1.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(6)
                    Einstellungen.KNS1.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(7)
                    Einstellungen.KNB2.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(8)
                    Einstellungen.KNS2.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(9)
                    Einstellungen.KNB3.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(10)
                    Einstellungen.KNS3.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(11)
                    Einstellungen.CLPf.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(12)
                    Einstellungen.KSp.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(13)
                    Einstellungen.KSs.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(14)
                    Einstellungen.Green.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(15)
                    Einstellungen.GreenBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(16)
                    Einstellungen.Gold.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(17)
                    Einstellungen.GoldBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(18)
                    Einstellungen.VST2.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(19)
                    Einstellungen.VSS2.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(20)
                    Einstellungen.Eisen.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(21)
                    Einstellungen.EisenBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(22)
                    Einstellungen.DrogenE.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(23)
                    Einstellungen.DrogenAA.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(24)
                    Einstellungen.LSD.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(25)
                    Einstellungen.LSDBÄ.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(26)
                    Einstellungen.CDKA.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(27)
                    Einstellungen.CDKT.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(28)
                    Einstellungen.GTAPfad.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(29)
                    Einstellungen.LVL.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(30)
                    Einstellungen.GWKN.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(31)
                    Einstellungen.GWKNS.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(32)
                    Einstellungen.VST.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(33)
                    Einstellungen.VSS.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(34)
                    Einstellungen.KNSGW1.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(35)
                    Einstellungen.KNSGW2.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(36)
                    Einstellungen.KNSGW3.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(37)
                    Einstellungen.HH.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(38)
                    Level = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(39)
                    Einstellungen.CH.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(40)
                    Einstellungen.HPW.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(41)
                    Einstellungen.OL.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(42)
                    Einstellungen.ChatAktiv.Checked = False
                    Einstellungen.AusleseReagier.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(44)
                    Einstellungen.AusleseSende.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(45)
                    Einstellungen.OLPX.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(46)
                    Einstellungen.OLPY.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(47)
                    Einstellungen.LoginMsc.Text = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(48)
                    Einstellungen.Übersicht.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(49)
                    Einstellungen.Noticon.Checked = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\NNP.Gaga")(50)

                    If Datum.Text = Now.Date Then

                    Else

                        Datum.Text = Now.Date

                        SpeichernDatum()

                        Killsh.Text = "0"
                        Todeh.Text = "0"
                    End If
                Else
                    Datum.Text = Now.Date
                    Dim path As String = "C:\Program Files (x86)\NNP\NNP.Gaga"
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes("0" & vbCrLf & "0" & vbCrLf & "0" & vbCrLf & "0" & vbCrLf & Datum.Text & vbCrLf & "" & vbCrLf & "/echo Ich habe meinen Killzähler noch nicht eingerichtet!" & vbCrLf & "true" & vbCrLf & "/echo Ich habe meinen Killzähler noch nicht eingerichtet!" & vbCrLf & "false" & vbCrLf & "/echo Ich habe meinen Killzähler noch nicht eingerichtet!" & vbCrLf & "false" & vbCrLf & "C:\Users\" & Environment.UserName & "\Documents\GTA San Andreas User Files\SAMP\chatlog.txt" & vbCrLf & "" & vbCrLf & "False" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "false" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "true" & vbCrLf & "50" & vbCrLf & "true" & vbCrLf & "/echo Gangwar Killnachricht" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "false" & vbCrLf & "true" & vbCrLf & "0" & vbCrLf & "false" & vbCrLf & "Ich brauche [Ort] verstärkung!" & vbCrLf & "2" & vbCrLf & "false" & vbCrLf & "false" & vbCrLf & "false" & vbCrLf & "true" & vbCrLf & "true" & vbCrLf & "1" & vbCrLf & "true" & vbCrLf & "true" & vbCrLf & "true" & vbCrLf & "true" & vbCrLf & "False" & vbCrLf & "false" & vbCrLf & "true" & vbCrLf & "GagaMichi sagt: hi" & vbCrLf & "Hi, Gaga!" & vbCrLf & "675" & vbCrLf & "175" & vbCrLf & "")
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                    If UDL.Text = "1" Then
                    Else
                        Start.Stop()
                        If (MsgBox("Mir scheint als würdest du das Noname Produkt zum ersten mal starten." & vbCrLf & "Möchtest du eine Funktionserklärung bekommen?", MsgBoxStyle.YesNo, "Willkommen beim Noname Produkt!")) = MsgBoxResult.Yes Then
                            HauptGuideToolStripMenuItem.PerformClick()
                        End If
                        Start.Start()
                    End If
                End If
                'Catch
                'GoTo Neuladen
                ' End Try
            End If
            If S.Text = "8" Then
                Me.Opacity = 0.7
                Me.Text = "By Ga-"
                If Einstellungen.VSS.Text = "" Then
                    Einstellungen.VSS.Text = "2"
                End If
                If Einstellungen.VST.Text = "" Then
                    Einstellungen.VST.Text = "Ich brauche [Ort] Verstärkung!"
                End If
                If Einstellungen.OL.Text = "false" Then
                    Einstellungen.OL.Text = "Aus"
                End If
                If Einstellungen.OL.Text = "true" Then
                    Einstellungen.OL.Text = "Normal"
                End If
                Progspeichern()
            End If
            If S.Text = "9" Then
                Me.Opacity = 0.75
                Me.Text = "By G-"
                CDK.Opacity = Einstellungen.CDKT.Text / 100
                If System.IO.File.Exists("C:\Program Files (x86)\NNP\SAMP.exe") Then
                    System.IO.File.Delete("C:\Program Files (x86)\NNP\SAMP.exe")
                End If
            End If
            If S.Text = "10" Then
                Me.Opacity = 0.8
                Me.Text = "By -"
                Einstellungen.NNPLevel.Text = Level
            End If
            If S.Text = "11" Then
                Me.Opacity = 0.85
                Me.Text = "By-"
                If System.IO.File.Exists(Einstellungen.GTAPfad.Text & "\samp.dll") Then
                    If Not SAMPVersion.Length = "2199552" Then
                        Start.Stop()
                        If (MsgBox("Du hast nicht die korrekte SAMP Version." & vbCrLf & "Das Noname Produkt funktioniert so nicht!" & vbCrLf & "Möchtest du die passende SAMP Version Downloaden", MsgBoxStyle.YesNo, "SAMP Version Fehler!") = MsgBoxResult.Yes) Then
                            TB1.Text = "Das NNP Hängt beim Download!"
                            TB2.Text = "NICHT SCHLIEßEN!"
                            MsgBox("Der Download der SAMP Version 0.3.7 wird gestartet." & vbCrLf & "Das NNP wird aussehen als würde es sich aufhängen." & vbCrLf & "Schließe es nicht um Fehler zu vermeiden!" & vbCrLf & "Nach dem Download geht es weiter! Dieser könnte ein paar Sekunden dauern!", MsgBoxStyle.Information, "Download startet")
                            My.Computer.Network.DownloadFile("http://files.sa-mp.com/sa-mp-0.3.7-install.exe", "C:\Program Files (x86)\NNP\SAMP.exe")
                            MsgBox("Der Download wurde abgeschlossen!" & vbCrLf & "Sollte bei der Installation eine Fehlermeldung auftreten, mache bitte folgendes:" & vbCrLf & "•Melde dich von deinem Computer ab oder starte ihn neu." & vbCrLf & "•Nach dem erneuten Anmelden starte NICHT GTA!!!" & vbCrLf & "•Starte das NNP erneut und führe die SAMP Installation aus.", MsgBoxStyle.Information, "Hinweiß")
                            Process.Start("C:\Program Files (x86)\NNP\SAMP.exe")
                            TB1.Text = ""
                            TB2.Text = ""
                            System.Threading.Thread.Sleep("500")
                            My.Computer.Keyboard.SendKeys("%A")
                        Else
                            MsgBox("Ohne die SAMP Version 0.3z R1 kann die API.dll nicht auf GTA zugreifen!" & vbCrLf & "Es können z.b. Textausgaben (wie die Killnachricht) nicht ausgegeben werden!" & vbCrLf & "Tja. Dein Pech!", MsgBoxStyle.Critical, "Fehler!")
                        End If
                        Start.Start()
                    End If
                End If
            End If
            If S.Text = "12" Then
                Me.Opacity = 0.9
                Me.Text = "B-"
                DestroyAllVisual()
            End If
            If S.Text = "13" Then
                Me.Opacity = 0.95
                Me.Text = "-"
            End If
            If S.Text = "14" Then
                Me.Opacity = 1
                Me.Text = " "
            End If
            If S.Text = "24" Then
                GetPlayerName(SpielerName.Text)
            End If
            If S.Text = "25" Then
                Me.Text = "-"
                If SpielerName.Text = "Fehler!" Then
                    CSC = Einstellungen.IngameName.Text
                Else
                    CSC = SpielerName.Text
                End If
            End If
            If S.Text = "26" Then
                Me.Text = "B-"
                Einstellungen.Kills.Text = Kills.Text
            End If
            If S.Text = "27" Then
                Me.Text = "Be-"
            End If
            If S.Text = "28" Then
                Me.Text = "Ber-"
                If Einstellungen.KNS1.Checked = True Then
                    Einstellungen.KNSGW1.Enabled = True
                Else
                    Einstellungen.KNSGW1.Enabled = False
                    If Einstellungen.KNSGW1.Checked = True Then
                        Einstellungen.KNSGW1.Checked = False
                    End If
                End If
                If Einstellungen.KNS2.Checked = True Then
                    Einstellungen.KNSGW2.Enabled = True
                Else
                    Einstellungen.KNSGW2.Enabled = False
                    If Einstellungen.KNSGW2.Checked = True Then
                        Einstellungen.KNSGW2.Checked = False
                    End If
                End If
                If Einstellungen.KNS3.Checked = True Then
                    Einstellungen.KNSGW3.Enabled = True
                Else
                    Einstellungen.KNSGW3.Enabled = False
                    If Einstellungen.KNSGW3.Checked = True Then
                        Einstellungen.KNSGW3.Checked = False
                    End If
                End If
            End If
            If S.Text = "29" Then
                Me.Text = "Bere-"
                TB1.Text = ""
                TB2.Text = ""
                If Einstellungen.Noticon.Checked = True Then
                    Me.ShowInTaskbar = False
                    Notify.Visible = True
                    Notify.BalloonTipTitle = "Hallo, " & Einstellungen.IngameName.Text
                    Notify.ShowBalloonTip(3)
                End If
            End If
            If S.Text = "30" Then
                Me.Text = "Berei-"
                If Not Einstellungen.OL.Text = "Aus" Then
                    SetParam("process", "gta_sa.exe")
                End If
            End If
            If S.Text = "31" Then
                Me.Enabled = True
                Me.Text = "Bereit"
                TCL.Start()
                If Einstellungen.HPW.Checked = True Or Einstellungen.Übersicht.Checked Then
                    BGTimer.Start()
                End If
                Cursor = Cursors.Default
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                P1.Style = ProgressBarStyle.Blocks
                P1.Value = 100
                'Bereit()
            End If
            If S.Text = "36" Then
                Me.Text = "Berei-"
            End If
            If S.Text = "37" Then
                Me.Text = "Ber-"
                MenuStrip1.Enabled = True
            End If
            If S.Text = "38" Then
                Me.Text = "Ber-"
            End If
            If S.Text = "39" Then
                Me.Text = "Be-"
                P1.Value = 0
            End If
            If S.Text = "40" Then
                Me.Text = "B-"
            End If
            If S.Text = "41" Then
                Me.Text = "-"
                If Tode.Text > "0" Then
                    KD.Text = Kills.Text / Tode.Text
                Else
                    KD.Text = Kills.Text
                End If
            End If
            If S.Text = "42" Then
                Me.Text = " "
                'System.Diagnostics.Process.Start("attrib", "-r .\API.dll")
            End If

            If S.Text = "50" Then
                Me.Text = "-"
                CDK.Show()
                CDK.Pos = 0
                CDK.Loc = -70
                CDK.Location = New Point(0, CDK.Loc)
            End If
            If S.Text = "51" Then
                Me.Text = "v-"
                If Todeh.Text > "0" Then
                    KDh.Text = Killsh.Text / Todeh.Text
                Else
                    KDh.Text = Killsh.Text
                End If
            End If
            If S.Text = "52" Then
                Me.Text = "v2-"
                TB1.BackColor = Color.White
                TB2.BackColor = Color.White
            End If
            If S.Text = "53" Then
                Me.Text = "v2.-"
                '#########################################################################################################################
                '#########################################################################################################################
                '#########################################################################################################################
                Einstellungen.CH.Checked = False
                Einstellungen.HPW.Checked = False
                '#########################################################################################################################
                '#########################################################################################################################
                '#########################################################################################################################
            End If
            If S.Text = "54" Then
                Me.Text = "v2.3"
            End If
            If S.Text = "57" Then
                TB1.BorderStyle = BorderStyle.Fixed3D
                TB2.BorderStyle = BorderStyle.Fixed3D
            End If
            'If S.Text = "58" Then
            'Me.Text = "v1.10.10"
            'End If
            If S.Text = "75" Then
                Status.Text = "Frei/lebend"
                Status.BackColor = Color.Green
                Start.Stop()
            End If
        Catch
            GoTo NeuStarten
        End Try

    End Sub

    Private Sub VordergrundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VordergrundToolStripMenuItem.Click
        If Me.TopMost = True Then
            Me.TopMost = False
        ElseIf Me.TopMost = False Then
            Me.TopMost = True
        End If
    End Sub

    Private Sub AlleTimerStoppenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlleTimerStoppenToolStripMenuItem.Click
        Atimer.Stop()
        MaskenTimer.Stop()
        TTod.Stop()
        Defi.Stop()
        WaffenTimer.Stop()
        TKnast.Stop()
        TEinbruch.Stop()
        BombenTimer.Stop()
        TruckingTimer.Stop()
        Ende.Stop()
        Start.Stop()
        KZ.Text = "0"
        TZ.Text = "0"
        P1.Value = "0"
        TB1.Text = ""
        TB2.Text = ""
        Status.Text = "Frei/lebend"
        Status.BackColor = Color.Green
        If CDK.Pos = 1 Then
            CDK.TCDK.Start()
        End If
        SD.Checked = False
        Me.MaximumSize = New Point(240, 215)
        SD.Visible = False


    End Sub

    Private Sub TEinbruch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEinbruch.Tick

        Einbruch.Text = Einbruch.Text - 1
        TB2.Text = "Du bist fertig in " & Einbruch.Text & " sekunden."
        If Einbruch.Text = "540" Then
            TB1.Text = "Du musst noch 9 Minuten überleben!"
        End If
        If Einbruch.Text = "480" Then
            TB1.Text = "Du musst noch 8 Minuten überleben!"
        End If
        If Einbruch.Text = "420" Then
            TB1.Text = "Du musst noch 7 Minuten überleben!"
        End If
        If Einbruch.Text = "360" Then
            TB1.Text = "Du musst noch 6 Minuten überleben!"
        End If
        If Einbruch.Text = "300" Then
            TB1.Text = "Du musst noch 5 Minuten überleben!"
        End If
        If Einbruch.Text = "240" Then
            TB1.Text = "Du musst noch 4 Minuten überleben!"
        End If
        If Einbruch.Text = "180" Then
            TB1.Text = "Du musst noch 3 Minuten überleben!"
        End If
        If Einbruch.Text = "120" Then
            TB1.Text = "Du musst noch 2 Minuten überleben!"
        End If
        If Einbruch.Text = "60" Then
            TB1.Text = "Du musst noch 1 Minute überleben!"
        End If
        P1.Value = P1.Value + 1
        If Einbruch.Text = "5" Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If Einbruch.Text < "1" Then
            TEinbruch.Stop()
            P1.Value = "0"
            TB1.Text = ""
            TB2.Text = ""
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            System.Threading.Thread.Sleep("250")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            System.Threading.Thread.Sleep("250")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If


    End Sub

    Private Sub NeustartenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeustartenToolStripMenuItem.Click
        TCL.Stop()
        BGTimer.Stop()

        NS = Me.Location.X & "," & Me.Location.Y
        Dim path As String = ".\NNPPos.Gaga"
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(NS & vbCrLf & Me.TopMost)
        fs.Write(info, 0, info.Length)
        fs.Close()
        Me.TopMost = False
        System.Threading.Thread.Sleep("500")
        Process.Start(".\Noname Produkt.exe")
        End
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click

        If Me.TopMost = True Then
            Einstellungen.TopMost = True
        End If
        Einstellungen.Show()
        Einstellungen.Size = New Size(808, 5)
        Einstellungen.Start.Start()
        Einstellungen.TKN.BorderStyle = BorderStyle.Fixed3D
        Einstellungen.TPF.BorderStyle = BorderStyle.None
        Einstellungen.TID.BorderStyle = BorderStyle.None
        Einstellungen.TDE.BorderStyle = BorderStyle.None
        Einstellungen.TSo.BorderStyle = BorderStyle.None


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximumSize = New Size(240, 216)
        azXorte = {1884, 1379, 1927, 2223, 2497, 1644, 939, 1203, 808, 734, 688, 2593, 750, 2120, 1970, 2489, 2044, 352, 2221, 1128, 1504, 399, 1914, 1546, 2239, -102, 56, 2236, 1192}
        azYorte = {-1680, -1286, -2402, -2259, -2003, -1064, -1977, -914, -1611, -862, -587, -2422, -1348, -1102, -1193, -1675, -1402, -1525, -1160, -1496, -1719, -2039, -1404, -1352, -2273, -587, -1525, -1029, -2036}
        azNorte = {"Allhabmra", "Ammunation (LS)", "Airport (LS)", "Bahnhof (LS)", "Ballas Base", "Bankparkplatz", "Bootsverleih", "BSN", "BSS", "DD Auffahrt", "Dillimore", "Docks (LS)", "Fahrschule", "Friedhof", "Glenpark", "Grove Street", "Krankenhaus (LS-Ost)", "LCN Hotel", "Noobmotel", "Noobspawn", "PD/Stadthalle (LS)", "Pier (LS)", "Skaterpark", "Startower", "Trainstation (LS)", "Truckstop", "Truckstop Brücke", "Varrios Los Aztecas", "Weißes Haus"}
        azGorte = 29
    End Sub

    Private Sub TGW_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TGW.Tick
        GW.Text = "0"
        Status.Text = "Frei/lebend"
        Status.BackColor = Color.Green
        TGW.Stop()
    End Sub

    Private Sub HilfeM_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        Cursor = Cursors.Help
    End Sub

    Private Sub HilfeM_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Cursor = Cursors.Default
    End Sub

    Private Sub ADTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADTimer.Tick
        ADZeit.Text = ADZeit.Text - 1
        If ADZeit.Text < "0" Then
            ADTimer.Stop()
        End If
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Hilfe1.Show()
        'If Me.TopMost = True Then
        'Hilfe1.TopMost = True
        'End If
        'Hilfe1.Status.Text = "Frei/lebend"
        'Hilfe1.Status.BackColor = Color.Green
    End Sub


    Private Sub NutzungsbedingungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NutzungsbedingungToolStripMenuItem.Click
        NB.Show()
        If Me.TopMost = True Then
            NB.TopMost = True
        End If
    End Sub

    Private Sub FAQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FAQToolStripMenuItem.Click
        FAQ.Show()
        If Me.TopMost = True Then
            FAQ.TopMost = True
        End If
        FAQ.FAQBox.Items.Add("Wie funktioniert das NNP?")
        FAQ.FAQBox.Items(0).SubItems.Add("Das NNP liest den Chatlog aus und reagiert entsprechend auf die einträge.")
        FAQ.FAQBox.Items.Add("Was kann das NNP?")
        FAQ.FAQBox.Items(1).SubItems.Add("Eine Liste der Funktionen steht auf: http://www.nnp.gagamichi.com/Funktionen.php")
        FAQ.FAQBox.Items.Add("Wieso werden Kills gezählt aber die Killnachricht nicht gesendet?")
        FAQ.FAQBox.Items(2).SubItems.Add("Das kann daran liegen das du eine falsche GTA SAMP Version nutzt. Das NNP sollte dich eigentlich darauf hinweisen. Wenn nicht, klicke auf Extras -> SAMP Version Prüfen.")
        FAQ.FAQBox.Items.Add("Kann ich die Countdownbox ausblenden?")
        FAQ.FAQBox.Items(3).SubItems.Add("Ja. Durch einen Doppelklick auf diese. Durch einen einfachen Klick wird diese Minimiert sodass nurnoch der Fortschrittsbalken angezeigt wird.")
        FAQ.FAQBox.Items.Add("Wo stelle ich die Killnachticht ein?")
        FAQ.FAQBox.Items(4).SubItems.Add("Die Killnachricht kannst du unter 'Datei->Einstellungen' bei Killnachricht in die Textboxen schreiben und bei 'Killnachricht senden' einen Haken reinmachen.")
        FAQ.FAQBox.Items.Add("Wo stehen die Kills in der Nachricht?")
        FAQ.FAQBox.Items(5).SubItems.Add("Die Kills kannst du (wie alles andere auch) frei in der Nachricht plazieren. Unter 'Killnachticht senden' kannst du bei 'Erklärung' auf den Pfeil drücken und auf den Knopf 'Beispiel' klicken um zu sehen wie das gemacht wird.")
        FAQ.FAQBox.Items.Add("Wieso funktioniert das Overlay nicht?")
        FAQ.FAQBox.Items(6).SubItems.Add("Das kann entweder daran liegen das du es nicht aktiviert hast, du ein ENB hast oder das Overlay sich nicht mit deinem Aufnahmeprogramm verträgt.")
        FAQ.FAQBox.Items.Add("Wieso ziegt das NNP soviel CPU leistung?")
        FAQ.FAQBox.Items(7).SubItems.Add("Das ligt am aufrufen der Funktionen der API.dll. Stelle den Hithinweiß aus und es zieht weniger Leistung. Für die geringste CPU auslastung des NNPs kannst du alle API Funktionen (Carheal hinweiß, Hit hinweiß und Highping warner) ausstellen")
        FAQ.FAQBox.Items.Add("Wieso wird manchmal keine Killnachricht gesendet?")
        FAQ.FAQBox.Items(8).SubItems.Add("Manchmal kommt es vor das entweder das NNP die Zeile aus der Chatlog datei nicht liest oder manche Zeilen nicht in die Chatlog datei geschrieben wird. Ein Lösungsansatz ist es das NNP nicht so viel CPU Leistung ziehen zu lassen.")
        FAQ.FAQBox.Items.Add("Wieso bekomme ich ne exe wenn das NNP etwas sendet?")
        FAQ.FAQBox.Items(9).SubItems.Add("Das liegt an deiner SAMP Version. Das NNP funktioniert nur mit der SAMP Version 0.3z !R1!. Downloaden kannstdu diese Version auf der NNP Seite. (Der obere Lauftext)")
        FAQ.FAQBox.Items.Add("")
        FAQ.FAQBox.Items(10).SubItems.Add("")
        FAQ.Größe.Start()
    End Sub

    Private Sub GWModusStoppenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GWModusStoppenToolStripMenuItem.Click
        GW.Text = "0"
        Status.Text = "Frei/lebend"
        Status.BackColor = Color.Green
        TGW.Stop()
    End Sub

    Private Sub InfotextAusblendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfotextAusblendenToolStripMenuItem.Click
        P1.Visible = True
        ITA = 1
    End Sub

    Private Sub TB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB1.Click
        MsgBox("Du kannst hier nichts reinschreiben!")
    End Sub

    Private Sub CBA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBA.Click
        CDK.TCDK.Start()
    End Sub

    Private Sub PositionResetenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionResetenToolStripMenuItem.Click
        CDK.TCDK.Stop()
        CDK.STCDK.Stop()
        CDK.Location = New Point(0, -70)
        CDK.Pos = 0
        CDK.SPC = 0
        CDK.Loc = -70
        If CBA.Text = "CountdownBox ausblenden" Then
            CBA.Text = "CountdownBox anzeigen"
        End If
    End Sub

    Private Sub GuideS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuideS.Click
        HauptGuideToolStripMenuItem.PerformClick()
    End Sub

    Private Sub HauptGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HauptGuideToolStripMenuItem.Click
        Me.Location = New Point(0, 0)
        MsgBox("Willkommen beim Noname Produkt!" & vbCrLf & vbCrLf & "Es folgt eine beschreibung der Funktionen und eine erklärung des Programms.")
        TB1.BackColor = Color.Red
        TB2.BackColor = Color.Red
        MsgBox("In diesen Textboxen wird sofern du tot oder im Knast bist angezeigt," & vbCrLf & "wann du wieder lebst oder frei bist." & vbCrLf & "In der oberen Textbox wird ein Countdown ablaufen." & vbCrLf & "In der unteren steht die Uhrzeit.")
        TB1.BackColor = Color.White
        TB2.BackColor = Color.White
        P1.Maximum = 100
        P1.Value = 75
        MsgBox("Dazwischen ist eine ProgressBar." & vbCrLf & "Diese zeigt den Frotschritt bis zur Freilassung oder bis du wieder lebst an.")
        P1.Value = 0
        Label1.BackColor = Color.Red
        MsgBox("Diese Statusanzeige zeigt dir an ob du gerade Tot, gefangen, lebend oder im Gangwar bist.")
        Label1.BackColor = Color.Transparent
        Kills.BackColor = Color.Red
        MsgBox("Die Hauptaufgabe des Killbinders ist es die Kills zu zählen." & vbCrLf & "Hier siehst du, wieviele Kills du insgesammt hast." & vbCrLf & "Diese kills kannst du ingame mit '/echo AE' oder unter Datei->Einstellungen->Ingame Daten bei 'Kills' einstellen.")
        Kills.BackColor = Color.Transparent
        Tode.BackColor = Color.Red
        MsgBox("Zu der Funktion kills zu zählen, zählt das NNP auch die Tode." & vbCrLf & "Hier kannst du sehen wie oft du gestorben bist, wärend das NNP lief.")
        Tode.BackColor = Color.Transparent
        KD.BackColor = Color.Red
        MsgBox("Aus den Kills und den Toden wird die K/D berechnet." & vbCrLf & "Diese kannst du hier sehen.")
        KD.BackColor = Color.Transparent
        Killsh.BackColor = Color.Red
        Todeh.BackColor = Color.Red
        KDh.BackColor = Color.Red
        MsgBox("Hier ist das gleiche wie auf der anderen Seite." & vbCrLf & "Jedoch ist das die Statistik für den aktuellen Tag.")
        Killsh.BackColor = Color.Transparent
        Todeh.BackColor = Color.Transparent
        KDh.BackColor = Color.Transparent
        Label4.BackColor = Color.Red
        MsgBox("Dieser Teil ist hauptsächlich zur überprüfung gedacht ob:" & vbCrLf & "•in die Chatlog.txt Datei geschrieben wird" & vbCrLf & "•der richtige Pfad angegeben wurde" & vbCrLf & vbCrLf & "Sollte dort nicht die aktuelle zeit stehen, mache einen Relog." & vbCrLf & "Sollte das Problem immernoch nicht behoben sein gehe auf Datei->Einstellungen->Pfade und suche den Chatlog.txt Pfad raus. (Vergiss nicht auf 'Übernehmen' zu drücken.)")
        Label4.BackColor = Color.Transparent
        If (MsgBox("Der Haupt-Guide ist jetzt beednet." & vbCrLf & vbCrLf & "Möchtest du den Einstellungen-Guide ausführen?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            EinstellungenGuideToolStripMenuItem.PerformClick()
        Else
            MsgBox("Der Guide wurde beendet." & vbCrLf & vbCrLf & " Solltest du noch Fragen haben, gehe auf Extras->Guide und wähle den Passenden Guide aus.")
        End If
    End Sub

    Private Sub EinstellungenGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenGuideToolStripMenuItem.Click
        Me.Location = New Point(0, 0)
        MsgBox("Willkommen beim Einstellungen-Guide!")
        VG.BackColor = Color.Red
        VG.ShowDropDown()
        EinstellungenToolStripMenuItem.BackColor = Color.Red
        MsgBox("Auf die Einstellungen kommst du über Datei->Einstellungen.")
        VG.BackColor = Color.Transparent
        VG.HideDropDown()
        EinstellungenToolStripMenuItem.BackColor = Color.Transparent
        EinstellungenToolStripMenuItem.PerformClick()
        Einstellungen.Location = New Point(250, 0)
        MsgBox("Es öffnet sich das Einstellungen-Fesnter." & vbCrLf & "Es wird immer zuerst die Killnachricht angezeigt.")
        Einstellungen.TID.BackColor = Color.Red
        Einstellungen.TPF.BackColor = Color.Red
        Einstellungen.TKN.BackColor = Color.Red
        Einstellungen.TSo.BackColor = Color.Red
        Einstellungen.TDE.BackColor = Color.Red
        MsgBox("Hier kannst du durch die Einstellungen Navigieren." & vbCrLf & "Klicke dazu auf einen der Texte.")
        Einstellungen.TID.BackColor = Color.WhiteSmoke
        Einstellungen.TPF.BackColor = Color.WhiteSmoke
        Einstellungen.TKN.BackColor = Color.WhiteSmoke
        Einstellungen.TSo.BackColor = Color.WhiteSmoke
        Einstellungen.TDE.BackColor = Color.WhiteSmoke
        Einstellungen.KNB1.BackColor = Color.Red
        Einstellungen.KNB2.BackColor = Color.Red
        Einstellungen.KNB3.BackColor = Color.Red
        Einstellungen.GWKN.BackColor = Color.Red
        MsgBox("Du hast hier bei der Killnachricht 4 Textboxen." & vbCrLf & "3 normale Killnachrichten und 1 nur für den Gangwar." & vbCrLf & "In diese kannst du deine beliebige Killnachricht schreiben." & vbCrLf & "Vor jede Killnachricht solltest du den Chat (z.b. /f) setzen." & vbCrLf & "Achte darauf das die Killnachrichten nicht zu lang sind!")
        Einstellungen.KNB1.BackColor = Color.White
        Einstellungen.KNB2.BackColor = Color.White
        Einstellungen.KNB3.BackColor = Color.White
        Einstellungen.GWKN.BackColor = Color.White
        Einstellungen.KNS1.BackColor = Color.Red
        Einstellungen.KNS2.BackColor = Color.Red
        Einstellungen.KNS3.BackColor = Color.Red
        Einstellungen.GWKNS.BackColor = Color.Red
        MsgBox("Hier kannst du auswählen ob die Killnachricht gesendet werden soll oder nicht." & vbCrLf & "Natürlich gilt: " & vbCrLf & "Haken = wird gesendet" & vbCrLf & "kien Haken = wird NICHT gesendet")
        Einstellungen.KNS1.BackColor = Color.Transparent
        Einstellungen.KNS2.BackColor = Color.Transparent
        Einstellungen.KNS3.BackColor = Color.Transparent
        Einstellungen.GWKNS.BackColor = Color.Transparent
        Einstellungen.GWKN.BackColor = Color.Red
        MsgBox("Die Gangwarnachricht wird NUR im Gangwar gesendet." & vbCrLf & "Wenn du einen normalen Kill machst, wird diese Nachricht also nicht mitgesendet.")
        Einstellungen.GWKN.BackColor = Color.White
        Einstellungen.KNSGW1.BackColor = Color.Red
        Einstellungen.KNSGW2.BackColor = Color.Red
        Einstellungen.KNSGW3.BackColor = Color.Red
        MsgBox("Wenn du deine normalen Killnachrichten nicht im Gangwar senden möchtest, kannst du dies hier ausstellen.")
        Einstellungen.KNSGW1.BackColor = Color.Transparent
        Einstellungen.KNSGW2.BackColor = Color.Transparent
        Einstellungen.KNSGW3.BackColor = Color.Transparent
        Einstellungen.WMW.BackColor = Color.Red
        MsgBox("In den Killnachrichten kannst du beliebig die folgenten 'Befehle' unterbringen." & vbCrLf & "[Kills], [HKills], [HP], [Ort]." & vbCrLf & "Was welcher Befehl bedeutet kannst du hier nachschauen." & vbCrLf & "Wähle dazu einen Befehl aus.")
        Einstellungen.WMW.BackColor = Color.White
        Einstellungen.Button2.BackColor = Color.Red
        MsgBox("Dann klickst du hier auf 'Beispiel' und dir wird eine Kurze erklärung dazu angezeigt.")
        Einstellungen.Button2.BackColor = Color.WhiteSmoke
        Einstellungen.TKN.BorderStyle = BorderStyle.None
        Einstellungen.TPF.BorderStyle = BorderStyle.Fixed3D
        Einstellungen.TP.Start()
        MsgBox("Hier werden alle Pfade angezeigt. Dazu zählen:" & vbCrLf & "Killsound Pfad" & vbCrLf & "Chatlog Pfad")
        Einstellungen.KSp.BackColor = Color.Red
        MsgBox("Hier kannst du eine Sound- oder Videodatei (den Pfad davon) einfügen. Diese öffnet sich immer wenn du einen Kill machst.")
        Einstellungen.KSp.BackColor = Color.White
        Einstellungen.Button7.BackColor = Color.Red
        Einstellungen.KSs.BackColor = Color.Red
        Einstellungen.Button6.BackColor = Color.Red
        MsgBox("Mit dem 'Suchen'-Knopf kannst du dich zu deinem Killsound navigieren." & vbCrLf & "Nur wenn der Hacken bei 'Senden' gesetzt ist, wird die Datei geöggnet." & vbCrLf & "Wenn du auf 'Test' klickst, kannst du überprüfen ob du die richtige Datei gewählt hast." & vbCrLf & vbCrLf & "ACHTUNG!!!" & vbCrLf & "Diese funktion kann dich bei einem Kill evt. auf den Desktop werfen.")
        Einstellungen.Button7.BackColor = Color.WhiteSmoke
        Einstellungen.KSs.BackColor = Color.Transparent
        Einstellungen.Button6.BackColor = Color.WhiteSmoke
        Einstellungen.CLPf.BackColor = Color.Red
        Einstellungen.Button1.BackColor = Color.Red
        MsgBox("Hier kannst du den Chatlog.txt Pfad umstellen wenn dieser nicht richtig ist." & vbCrLf & "Der standart eingestellte Pfad sollte jedoch in den meisten Fällen korrekt sein.")
        Einstellungen.CLPf.BackColor = Color.White
        Einstellungen.Button1.BackColor = Color.WhiteSmoke
        Einstellungen.TID.BorderStyle = BorderStyle.Fixed3D
        Einstellungen.TPF.BorderStyle = BorderStyle.None
        Einstellungen.TI.Start()
        Einstellungen.IngameName.BackColor = Color.Red
        MsgBox("Hier sind deine Ingame Daten untergebracht." & vbCrLf & vbCrLf & "In die Rot markierte box kommt dein Ingame Name." & vbCrLf & "Diesen solltest du exakt so schreiben wie er Ingame lautet." & vbCrLf & "Sonst kann der Killzähler bei manchen aktionen nicht reagieren.")
        Einstellungen.IngameName.BackColor = Color.White
        Einstellungen.Kills.BackColor = Color.Red
        MsgBox("Hier kannst du Manuel deine Kills abgleichen." & vbCrLf & "Du kannst das aber auch Ingame mit dem Befehl '/echo AE' machen.")
        Einstellungen.Kills.BackColor = Color.White
        Einstellungen.LVL.BackColor = Color.Red
        MsgBox("Solltest du unter Level 3 sein entferne hier den Haken!" & vbCrLf & "Das wirkt sich auf die Friedhofszeit aus." & vbCrLf & "Über lvl 3: 7 Minuten Friedhof" & vbCrLf & "Level 3 oder drunter: 3 Minuten.")
        Einstellungen.LVL.BackColor = Color.Transparent
        Einstellungen.TDE.BorderStyle = BorderStyle.Fixed3D
        Einstellungen.TID.BorderStyle = BorderStyle.None
        Einstellungen.TD.Start()
        Einstellungen.Green.BackColor = Color.Red
        Einstellungen.Gold.BackColor = Color.Red
        Einstellungen.LSD.BackColor = Color.Red
        Einstellungen.Eisen.BackColor = Color.Red
        MsgBox("Hier kannst du einstellen wieviele Drogen du entnehmen/auf der Hand haben möchtest." & vbCrLf & "Diese Funktion kannst du Ingame mit '/echo get Drogen' abrufen.")
        Einstellungen.Green.BackColor = Color.White
        Einstellungen.Gold.BackColor = Color.White
        Einstellungen.LSD.BackColor = Color.White
        Einstellungen.Eisen.BackColor = Color.White
        Einstellungen.GreenBÄ.BackColor = Color.Red
        Einstellungen.GoldBÄ.BackColor = Color.Red
        Einstellungen.LSDBÄ.BackColor = Color.Red
        Einstellungen.EisenBÄ.BackColor = Color.Red
        MsgBox("Nur wenn hier ein oder mehrere Hacken gesetzt ist/sind wird etwas an dem Betrag geändert.")
        Einstellungen.GreenBÄ.BackColor = Color.Transparent
        Einstellungen.GoldBÄ.BackColor = Color.Transparent
        Einstellungen.LSDBÄ.BackColor = Color.Transparent
        Einstellungen.EisenBÄ.BackColor = Color.Transparent
        Einstellungen.DrogenE.BackColor = Color.Red
        MsgBox("Wenn das ausgewählt ist, werden die gespeicherten Drogen aus dem Lager genommen.")
        Einstellungen.DrogenE.BackColor = Color.Transparent
        Einstellungen.DrogenAA.BackColor = Color.Red
        MsgBox("Wenn das ausgewählt ist, wird ermittelt wieviele Drogen du auf der Hand hast." & vbCrLf & "Dann werden soviele Dorgen aus dem Lager genommen das die eingestellten Drogen sich im Inventar befinden.")
        Einstellungen.DrogenAA.BackColor = Color.Transparent
        Einstellungen.TSo.BorderStyle = BorderStyle.Fixed3D
        Einstellungen.TDE.BorderStyle = BorderStyle.None
        Einstellungen.TS.Start()
        Einstellungen.CDKA.BackColor = Color.Red
        MsgBox("Die CountdownBox ist eine kleine Box welche beim starten eines Countdowns am Linken-oberen Bildschirmrand auftaucht." & vbCrLf & "Darin ist der Countdown." & vbCrLf & "Damit muss das NNP nicht immer im Vordergrund sein damit du den Countdown siehst." & vbCrLf & "Wenn hier der Haken dirnn ist, fährt die Box immer Automatisch aus." & vbCrLf & "Wenn der Haken nicht gesetzt ist, du die CountdownBox trotzdem sehen willst, gehe auf Extras->CountdownBox anzeigen")
        Einstellungen.CDKA.BackColor = Color.Transparent
        Einstellungen.CDKT.BackColor = Color.Red
        MsgBox("Hier kannst du die Tranzparenz der CountdownBox einstellen.")
        Einstellungen.CDKT.BackColor = Color.White
        MsgBox("Hier kannst du den Chat für die '/echo VS'-Funktion einstellen.")
        Einstellungen.VST.BackColor = Color.Red
        MsgBox("Hier kannst du deinen Hilferuf einstellen." & vbCrLf & "Ich empfehle dir '[Ort]' unterzubringen.")
        Einstellungen.VST.BackColor = Color.White
        Einstellungen.VSS.BackColor = Color.Red
        MsgBox("Hier wählst du aus wie oft der Hilferuf abgesendet werden soll.")
        Einstellungen.VSS.BackColor = Color.White
        Einstellungen.HH.BackColor = Color.Red
        MsgBox("Wenn das Aktiv ist, wird Ingame im Chat geschrieben ob und von was du angehittet wirst und wieviel Heal/Armour du verlierst.")
        Einstellungen.HH.BackColor = Color.Transparent
        If (MsgBox("Der Einstellungen-Guide ist jetzt beednet." & vbCrLf & vbCrLf & "Möchtest du den Sonstiges-Guide ausführen?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            SonstigesGuideToolStripMenuItem.PerformClick()
        Else
            MsgBox("Der Guide wurde beendet." & vbCrLf & vbCrLf & " Solltest du noch Fragen haben, gehe auf Extras->Guide und wähle den Passenden Guide aus.")
        End If
        Einstellungen.Button8.PerformClick()
    End Sub

    Private Sub SonstigesGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SonstigesGuideToolStripMenuItem.Click
        MsgBox("Willkommen beim Sonstiges-Guide!")
        If (MsgBox("Hier werden dir die Funktionen und Befehle erklärt." & vbCrLf & "Diese kannst du auch auf der NNP Homepage nachlesen." & vbCrLf & "Möchtest du zur Homepage?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Process.Start("http://www.nnp.gagamichi.com")
        Else
            MsgBox("Die Funktionen:")
            MsgBox("Die Hauptfunktion des NNPs ist das Kills zählen." & vbCrLf & "Dies funktioniert über den Chatlog." & vbCrLf & "Sollte der Chatlog nicht im standart Verzeichnis sein, gehe auf Daite->Einstellungen->Pfade und klicke bei Chatlogpfad auf Suchen. Dann Navigierst du dich zu deinem Chatlogpfad." & vbCrLf & vbCrLf & "Bei jedem Kill (Normaler-/Blacklist-/Beamten-/Gangwar-/Rotorkill) wird die passende Killnachricht gesendet.")
            MsgBox("In der Killnachricht kannst du " & vbCrLf & " [Kills] = die Killanzahl " & vbCrLf & " [HKills] = die heutige Killanzahl " & vbCrLf & " [HP] = das aktuelle Heal " & vbCrLf & " [Ort] = der aktuelle Ort " & vbCrLf & "beliebig unterbringen.")
            MsgBox("Zudem zählt das NNP die Tode und berechnet die KD." & vbCrLf & "Zudem zählt das NNP die heutigen Kills und Tode.")
            MsgBox("Sobald du stirbst startet das NNP einen Countdown welcher dir zeigt wielange du noch tot bist." & vbCrLf & "20 sekunden vor dem ende der Friedhofszeit gibt das NNP ein akustisches Signal." & vbCrLf & "Am ende gibt es 5 davon." & vbCrLf & "Das geht auch mit der Knastzeit.")
            MsgBox("Wenn du Ingame bist wärend eine AD gemacht wurde startet ein Timer." & vbCrLf & "Solltest du versuchen innerhalb der Cooldown zeit der AD eine Werbung zu machen wird dir die Zeit welche noch bis zur Freigabe der AD verbleibt angezeigt.")
            MsgBox("Solltest du wo einbrechen startet das NNP einen Countdown (Tür aufbrechen, Haus ausräumen, fliehen)")
            MsgBox("Das NNP Zeigt dir deinen aktuellen Status (frei/lebend, gefangen, tot, tot(Hitman), Gangwar) an.")
            MsgBox("Wenn du einen Killsound eingestellt hast, wird bei jedem kill die angegebene Datei geöffnet und abgespielt.")
            MsgBox("Solltest du bei /call, /sms oder /service dein Handy aus haben schaltet sich dieses ein und der letzte Befehl wird ausgeführt.")
            MsgBox("Bei /lottoinfo werden zusätzlich die gewählten Lottozahlen angezeigt")
            MsgBox("Wenn der Hit Hinweiß (Einstellungen->Sonstiges) aktiv ist, wird wenn du Ingame angehittet wirst im Chat geschrieben (/echo) mit was du getroffen wirst und wieviel Heal/armour du verlierst. Zudem wird dir als GameText angezeigt wann dein Fahrzeug CarHeal verliert.")
            MsgBox("Das NNP hat auch eine Level-Funktion. Je mehr Kills du hast,um so höher ist dein NNPLevel. (Befehl dazu: /echo NNPLevel)")

            MsgBox("Die Befehle:" & vbCrLf & "Du kannst dir alle Befehle Ingame anzeigen lassen." & vbCrLf & "gib dazu '/echo NNPHelp' ein." & vbCrLf & "ACHTE BEI ALLEN BEFEHLEN AUF DIE GROß/KLEIN SCHREIBUNG!!!")
            MsgBox("/echo NNPHelp" & vbCrLf & "Zeigt ingame alle Befehle an")
            MsgBox("/echo VS & /echo VS2" & vbCrLf & "Ermittelt den Standort und schickt die VSNachricht so oft wie eingestellt in den gewünschten Chat.")
            MsgBox("/echo AE" & vbCrLf & "Gleicht die Ingame Daten mit den NNP Daten ab.")
            MsgBox("/echo NS" & vbCrLf & "Startet das NNP Neu." & vbCrLf & "Das Wirft dich villeicht auf den Desktop")
            MsgBox("/echo TS" & vbCrLf & "Stoppt alle Laufenden Timer")
            MsgBox("/echo VG" & vbCrLf & "Setzt das NNP In den Vordergrung." & vbCrLf & "Lohnt sich eig nur mit 2 Bildschirmen")
            MsgBox("/echo DR" & vbCrLf & "Ist ein Drogenrechner der ab 5kg 25% Mengenrabatt einberechnet" & vbCrLf & "(Bis 5kg normaler Preis + mehr als 5kg mit 75% des Preises")
            MsgBox("/echo get Drogen" & vbCrLf & "Ändert den Drogenbertag auf der Hand (Einstellbar unter Datei->Einstellungen->Drogenetnahme)" & vbCrLf & "Weitere Infos dazu beim Einstellungen-Guide")
            MsgBox("/echo NNPInfo" & vbCrLf & "Zeigt die NNP Informationen im /echo-chat an")
            MsgBox("/echo STVO" & vbCrLf & "Ermittelt das Carheal und schreit in der gegend eine Nachricht mit dem aktuellen Carheal rum.")
            MsgBox("/echo NNPTest" & vbCrLf & "Sendet die eingestellten Killnachrichten in den Chats.")
            MsgBox("/echo SMarkt" & vbCrLf & "Zeigt die zuletzt eingertagene SMarkt Position an.")
            MsgBox("/echo OA" & vbCrLf & "Blendet das Overlay aus.")

        End If
    End Sub

    Private Sub LSDTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSDTimer.Tick

        LSDZ = LSDZ - 1
        If LSDZ = 60 Then
            AddChatMessage("{FF0000}Achtung!{FFFFFF} Die LSD nachwirkung tritt in ca. {00E533}60 sekunden{FFFFFF} ein!")
        End If
        If LSDZ = 30 Then
            AddChatMessage("{FF0000}Achtung!{FFFFFF} Die LSD nachwirkung tritt in ca. {00E533}30 sekunden{FFFFFF} ein!")
        End If
        If LSDZ = 10 Then
            AddChatMessage("{FF0000}Achtung!{FFFFFF} Die LSD nachwirkung tritt in ca. {00E533}10 sekunden{FFFFFF} ein!")
        End If
        If LSDZ < 1 Then
            LSDTimer.Stop()
            LSDZ = 110
        End If


    End Sub

    Private Sub SCDT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCDT.Tick
        SCD = SCD - 1
        If SCD < 0 Then
            SCDT.Stop()
        End If
    End Sub


    Private Sub LinkKopierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject("http://nnp.gagamichi.com", True)
    End Sub

    Private Sub SpartseiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://nnp.gagamichi.com")
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://nnp.gagamichi.com/Download.php")
    End Sub

    Private Sub KnastzeitManuellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnastzeitManuellToolStripMenuItem.Click
        If Me.TopMost = True Then
            Knastzeit.TopMost = True
        End If
        Knastzeit.Show()
    End Sub

    Private Sub BGTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGTimer.Tick
        If Einstellungen.HPW.Checked = True Then
            'HighPing()

            Try
                AddChatMessage(GPPing)
                If GW.Text = "1" Then
                    If GPPing > 10 Then
                        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~r~HIGHPING WARNUNG!~y~ PING:~r~ " & GPPing, 5000, 3)

                    End If
                Else
                    If GPPing > 10 Then
                        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~r~HIGHPING WARNUNG!~y~ PING:~r~ " & GPPing, 5000, 3)
                    End If
                End If
            Catch ex As Exception
                AddChatMessage(ex.ToString)
            End Try

        End If

        If Einstellungen.Übersicht.Checked = True Then
            ' Übersicht
            TextDestroy(ÜbOl)
            WaffenabgleichOT()
            Orte()
            ÜbOl = TextCreate("Arial", 8, True, False, 675, 510, &HFF00FF, "{FFFFFF{FFFFFF}HP: {FF3333}" & GetPlayerHealth & "{FFFFFF}, Armour: {FF3333}" & GetPlayerArmour & vbCrLf & "{FFFFF}Waffe: {FF3333}" & Waffe & vbCrLf & "{FFFFFF}Position: {FF3333}" & Ort & vbCrLf & "{FFFFFF}Kills: {FF3333}" & Kills.Text & "{FFFFFF}, Tode: {FF3333}" & Tode.Text, True, True)
        End If
    End Sub

    Private Sub HilfeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://nnp.gagamichi.com/Hilfe.php")
    End Sub

    Private Sub WaffenTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaffenTimer.Tick

        TB1.Text = "Du bist in " & WZeit & " sekunden fertig."
        P1.Value += 1
        If WZeit < 1 Then
            P1.Value = 0
            If ITA = 0 Then
                P1.Visible = True
            End If
            TB1.Text = ""
            TB2.Text = ""
            WaffenTimer.Stop()
            Ende.Start()
        End If
        WZeit -= 1


    End Sub


    Private Sub TB2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB2.MouseClick
        If TB2.Text = "Ausblenden" Then
            TB1.Text = ""
            TB2.Text = ""
            P1.Value = 0
            P1.Visible = False
            TB2.Enabled = False
        End If
    End Sub

    Private Sub Defi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Defi.Tick

        Defizeit = Defizeit - 1
        TB1.Text = "Spieler ist in " & Defizeit & " Sekunden revived"
        CDK.CDKC.Text = Defizeit
        P1.Value = P1.Value + 1
        CDK.P1.Value = P1.Value
        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~n~~y~Revive dauer: ~g~" & Defizeit & " ~y~Sekunden", 1000, 3)
        If Defizeit < 2 Then
            If Not BombenTimer.Enabled Then
                Ende.Start()
            Else
                Defi.Stop()
            End If
        End If


    End Sub

    Private Sub OverlayAusblendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverlayAusblendenToolStripMenuItem.Click
        OverlayStatus = 0
        DestroyAllVisual()
    End Sub

    Private Sub Progspeichern()
        Try
            Dim path As String = "C:\Program Files (x86)\NNP\NNP.Gaga"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(Kills.Text & vbCrLf & Killsh.Text & vbCrLf & Tode.Text & vbCrLf & Todeh.Text & vbCrLf & Datum.Text & vbCrLf & Einstellungen.IngameName.Text & vbCrLf & Einstellungen.KNB1.Text & vbCrLf & Einstellungen.KNS1.Checked & vbCrLf & Einstellungen.KNB2.Text & vbCrLf & Einstellungen.KNS2.Checked & vbCrLf & Einstellungen.KNB3.Text & vbCrLf & Einstellungen.KNS3.Checked & vbCrLf & Einstellungen.CLPf.Text & vbCrLf & Einstellungen.KSp.Text & vbCrLf & Einstellungen.KSs.Checked & vbCrLf & Einstellungen.Green.Text & vbCrLf & Einstellungen.GreenBÄ.Checked & vbCrLf & Einstellungen.Gold.Text & vbCrLf & Einstellungen.GoldBÄ.Checked & vbCrLf & Einstellungen.VST2.Text & vbCrLf & Einstellungen.VSS2.Text & vbCrLf & Einstellungen.Eisen.Text & vbCrLf & Einstellungen.EisenBÄ.Checked & vbCrLf & Einstellungen.DrogenE.Checked & vbCrLf & Einstellungen.DrogenAA.Checked & vbCrLf & Einstellungen.LSD.Text & vbCrLf & Einstellungen.LSDBÄ.Checked & vbCrLf & Einstellungen.CDKA.Checked & vbCrLf & Einstellungen.CDKT.Text & vbCrLf & Einstellungen.GTAPfad.Text & vbCrLf & Einstellungen.LVL.Checked & vbCrLf & Einstellungen.GWKN.Text & vbCrLf & Einstellungen.GWKNS.Checked & vbCrLf & Einstellungen.VST.Text & vbCrLf & Einstellungen.VSS.Text & vbCrLf & Einstellungen.KNSGW1.Checked & vbCrLf & Einstellungen.KNSGW2.Checked & vbCrLf & Einstellungen.KNSGW3.Checked & vbCrLf & Einstellungen.HH.Checked & vbCrLf & Level & vbCrLf & Einstellungen.CH.Checked & vbCrLf & Einstellungen.HPW.Checked & vbCrLf & Einstellungen.OL.Text & vbCrLf & Einstellungen.ChatAktiv.Checked & vbCrLf & Einstellungen.AusleseReagier.Text & vbCrLf & Einstellungen.AusleseSende.Text & vbCrLf & Einstellungen.OLPX.Text & vbCrLf & Einstellungen.OLPY.Text & vbCrLf & Einstellungen.LoginMsc.Text & vbCrLf & Einstellungen.Übersicht.Checked & vbCrLf & Einstellungen.Noticon.Checked)
            fs.Write(info, 0, info.Length)
            fs.Close()
        Catch
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Es ist ein Fehler beim Speichern aufgetreten!")
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Der Vorgang wird wiederholt!")
            Progspeichern()
            System.Threading.Thread.Sleep("1000")
        End Try

    End Sub

    Private Sub Speichern()
        Try
            Dim path As String = "C:\Program Files (x86)\NNP\NNP.Gaga"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(Kills.Text & vbCrLf & Killsh.Text & vbCrLf & Tode.Text & vbCrLf & Todeh.Text & vbCrLf & Datum.Text & vbCrLf & Einstellungen.IngameName.Text & vbCrLf & Einstellungen.KNB1.Text & vbCrLf & Einstellungen.KNS1.Checked & vbCrLf & Einstellungen.KNB2.Text & vbCrLf & Einstellungen.KNS2.Checked & vbCrLf & Einstellungen.KNB3.Text & vbCrLf & Einstellungen.KNS3.Checked & vbCrLf & Einstellungen.CLPf.Text & vbCrLf & Einstellungen.KSp.Text & vbCrLf & Einstellungen.KSs.Checked & vbCrLf & Einstellungen.Green.Text & vbCrLf & Einstellungen.GreenBÄ.Checked & vbCrLf & Einstellungen.Gold.Text & vbCrLf & Einstellungen.GoldBÄ.Checked & vbCrLf & Einstellungen.VST2.Text & vbCrLf & Einstellungen.VSS2.Text & vbCrLf & Einstellungen.Eisen.Text & vbCrLf & Einstellungen.EisenBÄ.Checked & vbCrLf & Einstellungen.DrogenE.Checked & vbCrLf & Einstellungen.DrogenAA.Checked & vbCrLf & Einstellungen.LSD.Text & vbCrLf & Einstellungen.LSDBÄ.Checked & vbCrLf & Einstellungen.CDKA.Checked & vbCrLf & Einstellungen.CDKT.Text & vbCrLf & Einstellungen.GTAPfad.Text & vbCrLf & Einstellungen.LVL.Checked & vbCrLf & Einstellungen.GWKN.Text & vbCrLf & Einstellungen.GWKNS.Checked & vbCrLf & Einstellungen.VST.Text & vbCrLf & Einstellungen.VSS.Text & vbCrLf & Einstellungen.KNSGW1.Checked & vbCrLf & Einstellungen.KNSGW2.Checked & vbCrLf & Einstellungen.KNSGW3.Checked & vbCrLf & Einstellungen.HH.Checked & vbCrLf & Level & vbCrLf & Einstellungen.CH.Checked & vbCrLf & Einstellungen.HPW.Checked & vbCrLf & Einstellungen.OL.Text & vbCrLf & Einstellungen.ChatAktiv.Checked & vbCrLf & Einstellungen.AusleseReagier.Text & vbCrLf & Einstellungen.AusleseSende.Text & vbCrLf & Einstellungen.OLPX.Text & vbCrLf & Einstellungen.OLPY.Text & vbCrLf & Einstellungen.LoginMsc.Text & vbCrLf & Einstellungen.Übersicht.Checked & vbCrLf & Einstellungen.Noticon.Checked)
            fs.Write(info, 0, info.Length)
            fs.Close()

        Catch
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Es ist ein Fehler beim Speichern aufgetreten!")
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Der Vorgang wird wiederholt!")
            Speichern()
            System.Threading.Thread.Sleep("1000")
        End Try

    End Sub

    Private Sub SpeichernAE()
        Try
            Dim path As String = "C:\Program Files (x86)\NNP\NNP.Gaga"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(AEMorde & vbCrLf & Killsh.Text & vbCrLf & Tode.Text & vbCrLf & Todeh.Text & vbCrLf & Datum.Text & vbCrLf & AEName & vbCrLf & Einstellungen.KNB1.Text & vbCrLf & Einstellungen.KNS1.Checked & vbCrLf & Einstellungen.KNB2.Text & vbCrLf & Einstellungen.KNS2.Checked & vbCrLf & Einstellungen.KNB3.Text & vbCrLf & Einstellungen.KNS3.Checked & vbCrLf & Einstellungen.CLPf.Text & vbCrLf & Einstellungen.KSp.Text & vbCrLf & Einstellungen.KSs.Checked & vbCrLf & Einstellungen.Green.Text & vbCrLf & Einstellungen.GreenBÄ.Checked & vbCrLf & Einstellungen.Gold.Text & vbCrLf & Einstellungen.GoldBÄ.Checked & vbCrLf & Einstellungen.VST2.Text & vbCrLf & Einstellungen.VSS2.Text & vbCrLf & Einstellungen.Eisen.Text & vbCrLf & Einstellungen.EisenBÄ.Checked & vbCrLf & Einstellungen.DrogenE.Checked & vbCrLf & Einstellungen.DrogenAA.Checked & vbCrLf & Einstellungen.LSD.Text & vbCrLf & Einstellungen.LSDBÄ.Checked & vbCrLf & Einstellungen.CDKA.Checked & vbCrLf & Einstellungen.CDKT.Text & vbCrLf & Einstellungen.GTAPfad.Text & vbCrLf & AELevel & vbCrLf & Einstellungen.GWKN.Text & vbCrLf & Einstellungen.GWKNS.Checked & vbCrLf & Einstellungen.VST.Text & vbCrLf & Einstellungen.VSS.Text & vbCrLf & Einstellungen.KNSGW1.Checked & vbCrLf & Einstellungen.KNSGW2.Checked & vbCrLf & Einstellungen.KNSGW3.Checked & vbCrLf & Einstellungen.HH.Checked & vbCrLf & Level & vbCrLf & Einstellungen.CH.Checked & vbCrLf & Einstellungen.HPW.Checked & vbCrLf & Einstellungen.OL.Text & vbCrLf & Einstellungen.ChatAktiv.Checked & vbCrLf & Einstellungen.AusleseReagier.Text & vbCrLf & Einstellungen.AusleseSende.Text & vbCrLf & Einstellungen.OLPX.Text & vbCrLf & Einstellungen.OLPY.Text & vbCrLf & Einstellungen.LoginMsc.Text & vbCrLf & Einstellungen.Übersicht.Checked & vbCrLf & Einstellungen.Noticon.Checked)
            fs.Write(info, 0, info.Length)
            fs.Close()

        Catch
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Es ist ein Fehler beim Speichern aufgetreten!")
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Der Vorgang wird wiederholt!")
            SpeichernAE()
            System.Threading.Thread.Sleep("1000")
        End Try

    End Sub

    Private Sub SpeichernDatum()
        Try
            Dim path As String = "C:\Program Files (x86)\NNP\NNP.Gaga"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(Kills.Text & vbCrLf & "0" & vbCrLf & Tode.Text & vbCrLf & "0" & vbCrLf & Datum.Text & vbCrLf & Einstellungen.IngameName.Text & vbCrLf & Einstellungen.KNB1.Text & vbCrLf & Einstellungen.KNS1.Checked & vbCrLf & Einstellungen.KNB2.Text & vbCrLf & Einstellungen.KNS2.Checked & vbCrLf & Einstellungen.KNB3.Text & vbCrLf & Einstellungen.KNS3.Checked & vbCrLf & Einstellungen.CLPf.Text & vbCrLf & Einstellungen.KSp.Text & vbCrLf & Einstellungen.KSs.Checked & vbCrLf & Einstellungen.Green.Text & vbCrLf & Einstellungen.GreenBÄ.Checked & vbCrLf & Einstellungen.Gold.Text & vbCrLf & Einstellungen.GoldBÄ.Checked & vbCrLf & Einstellungen.VST2.Text & vbCrLf & Einstellungen.VSS2.Text & vbCrLf & Einstellungen.Eisen.Text & vbCrLf & Einstellungen.EisenBÄ.Checked & vbCrLf & Einstellungen.DrogenE.Checked & vbCrLf & Einstellungen.DrogenAA.Checked & vbCrLf & Einstellungen.LSD.Text & vbCrLf & Einstellungen.LSDBÄ.Checked & vbCrLf & Einstellungen.CDKA.Checked & vbCrLf & Einstellungen.CDKT.Text & vbCrLf & Einstellungen.GTAPfad.Text & vbCrLf & Einstellungen.LVL.Checked & vbCrLf & Einstellungen.GWKN.Text & vbCrLf & Einstellungen.GWKNS.Checked & vbCrLf & Einstellungen.VST.Text & vbCrLf & Einstellungen.VSS.Text & vbCrLf & Einstellungen.KNSGW1.Checked & vbCrLf & Einstellungen.KNSGW2.Checked & vbCrLf & Einstellungen.KNSGW3.Checked & vbCrLf & Einstellungen.HH.Checked & vbCrLf & Level & vbCrLf & Einstellungen.CH.Checked & vbCrLf & Einstellungen.HPW.Checked & vbCrLf & Einstellungen.OL.Text & vbCrLf & Einstellungen.ChatAktiv.Checked & vbCrLf & Einstellungen.AusleseReagier.Text & vbCrLf & Einstellungen.AusleseSende.Text & vbCrLf & Einstellungen.OLPX.Text & vbCrLf & Einstellungen.OLPY.Text & vbCrLf & Einstellungen.LoginMsc.Text & vbCrLf & Einstellungen.Übersicht.Checked & vbCrLf & Einstellungen.Noticon.Checked)
            fs.Write(info, 0, info.Length)
            fs.Close()

        Catch
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Es ist ein Fehler beim Speichern aufgetreten!")
            AddChatMessage("{FF3333}Fehler!{FFFFFF}Der Vorgang wird wiederholt!")
            SpeichernDatum()
            System.Threading.Thread.Sleep("1000")
        End Try

    End Sub

    Private Sub Orte()
        Try
            'PosX(X)
            'PosY(Y)
            'PosZ(Z)
            GetPlayerPos(X, Y, Z)
            X = X + 5000
            Y = Y + 5000
            'Koordinaten
            SpielerX = X
            SpielerY = Y
            SpielerZ = Z

            'Ort = Ortdll.Orte(SpielerX, SpielerY, SpielerZ)
            'If Ort = "Unbekannt" then
            'GetZoneName(Zone.Text)
            'GetCityName(Stadt.Text)
            'Ort = "in " & Stadt.Text & " (" & Zone.Text & ")"
            'End if

            'Abgleichen
            If 2625 - -5000 < SpielerX And SpielerX < 2861 - -5000 And -1896 - -5000 < SpielerY And SpielerY < -1656 - -5000 Then
                'GWOrt
                Ort = "an der Arena (Arena Gebiet)"
            ElseIf 2734 - -5000 < SpielerX And SpielerX < 2861 - -5000 And -1527 - -5000 < SpielerY And SpielerY < -1353 - -5000 Then
                'GWOrt
                Ort = "am Parkhaus (Arena Gebiet)"
            ElseIf 2724 - -5000 < SpielerX And SpielerX < 2867 - -5000 And -1172 - -5000 < SpielerY And SpielerY < -1024 - -5000 Then
                'GWOrt
                Ort = "am Hotel (Arena Gebiet)"
            ElseIf 2078 - -5000 < SpielerX And SpielerX < 2347 - -5000 And -2413 - -5000 < SpielerY And SpielerY < -2168 - -5000 Then
                'GWOrt
                Ort = "an der Schiene (Docks Gebiet)"
            ElseIf 2722 - -5000 < SpielerX And SpielerX < 2883 - -5000 And -2580 - -5000 < SpielerY And SpielerY < -2328 - -5000 Then
                'GWOrt
                Ort = "am Schiff (Docks Gebiet)"
            ElseIf 2359 - -5000 < SpielerX And SpielerX < 2501 - -5000 And -2677 - -5000 < SpielerY And SpielerY < -2424 - -5000 Then
                'GWOrt
                Ort = "an den Containern (Docks Gebiet)"
            ElseIf 2392 - -5000 < SpielerX And SpielerX < 2534 - -5000 And 38 - -5000 < SpielerY And SpielerY < 173 - -5000 Then
                'GWOrt
                Ort = "am blauen Haus (OC Gebiet)"
            ElseIf 2141 - -5000 < SpielerX And SpielerX < 2280 - -5000 And -128 - -5000 < SpielerY And SpielerY < 35 - -5000 Then
                'GWOrt
                Ort = "an der Garage (OC Gebiet)"
            ElseIf 2284 - -5000 < SpielerX And SpielerX < 2383 - -5000 And -42 - -5000 < SpielerY And SpielerY < 78 - -5000 Then
                'GWOrt
                Ort = "am Laden (OC Gebiet)"
            ElseIf 2060 - -5000 < SpielerX And SpielerX < 2239 - -5000 And 1378 - -5000 < SpielerY And SpielerY < 1551 - -5000 Then
                'GWOrt
                Ort = "am Casino (LV Gebiet)"
            ElseIf 2212 - -5000 < SpielerX And SpielerX < 2447 - -5000 And 1187 - -5000 < SpielerY And SpielerY < 1378 - -5000 Then
                'GWOrt
                Ort = "an der Pyramide (LV Gebiet)"
            ElseIf 2052 - -5000 < SpielerX And SpielerX < 2348 - -5000 And 970 - -5000 < SpielerY And SpielerY < 1211 - -5000 Then
                'GWOrt
                Ort = "an der Burg (LV Gebiet)"
            ElseIf -318 - -5000 < SpielerX And SpielerX < -193 - -5000 And 2562 - -5000 < SpielerY And SpielerY < 2622 - -5000 Then
                'GWOrt
                Ort = "an der Terasse (Huhn Gebiet)"
            ElseIf -284 - -5000 < SpielerX And SpielerX < -191 - -5000 And 2616 - -5000 < SpielerY And SpielerY < 2700 - -5000 Then
                'GWOrt
                Ort = "am Huhn (Huhn Gebiet)"
            ElseIf -280 - -5000 < SpielerX And SpielerX < -168 - -5000 And 4657 - -5000 < SpielerY And SpielerY < 2745 - -5000 Then
                'GWOrt
                Ort = "am Berg (Huhn Gebiet)"
            ElseIf -674 - -5000 < SpielerX And SpielerX < -754 - -5000 And 1501 - -5000 < SpielerY And SpielerY < 1603 - -5000 Then
                'GWOrt
                Ort = "an der Ruine (Kuh Gebiet)"
            ElseIf -616 - -5000 < SpielerX And SpielerX < -702 - -5000 And 1406 - -5000 < SpielerY And SpielerY < 1491 - -5000 Then
                'GWOrt
                Ort = "am Campingplatz (Kuh Gebiet)"
            ElseIf -901 - -5000 < SpielerX And SpielerX < -833 - -5000 And 1472 - -5000 < SpielerY And SpielerY < 1597 - -5000 Then
                'GWOrt
                Ort = "an der Kuh (Kuh Gebiet)"
            ElseIf 210 - -5000 < SpielerX And SpielerX < 298 - -5000 And -121 - -5000 < SpielerY And SpielerY < -15 - -5000 Then
                'GWOrt
                Ort = "am Laden (Farm Gebiet)"
            ElseIf -86 - -5000 < SpielerX And SpielerX < 6 - -5000 And -53 - -5000 < SpielerY And SpielerY < 126 - -5000 Then
                'GWOrt
                Ort = "an der Farm (Farm Gebiet)"
            ElseIf -74 - -5000 < SpielerX And SpielerX < 16 - -5000 And -290 - -5000 < SpielerY And SpielerY < -202 - -5000 Then
                'GWOrt
                Ort = "am Fleischberg (Farm Gebiet)"
            ElseIf -2277 - -5000 < SpielerX And SpielerX < -2172 - -5000 And -2355 - -5000 < SpielerY And SpielerY < -2213 - -5000 Then
                'GWOrt
                Ort = "am Motel (Anglepine Gebiet)"
            ElseIf -2234 - -5000 < SpielerX And SpielerX < -2115 - -5000 And -2457 - -5000 < SpielerY And SpielerY < -2366 - -5000 Then
                'GWOrt
                Ort = "am Dach (Anglepine Gebiet)"
            ElseIf -2129 - -5000 < SpielerX And SpielerX < -1959 - -5000 And -2606 - -5000 < SpielerY And SpielerY < -2468 - -5000 Then
                'GWOrt
                Ort = "am Campingplatz (Anglepine Gebiet)"
            ElseIf -2497 - -5000 < SpielerX And SpielerX < -2377 - -5000 And -440 - -5000 < SpielerY And SpielerY < -576 - -5000 Then
                'GWOrt
                Ort = "am Dach (SF Gebiet)"
            ElseIf -2801 - -5000 < SpielerX And SpielerX < -2658 - -5000 And 49 - -5000 < SpielerY And SpielerY < 159 - -5000 Then
                'GWOrt
                Ort = "an der Garage (SF Gebiet)"
            ElseIf -2509 - -5000 < SpielerX And SpielerX < -2409 - -5000 And -212 - -5000 < SpielerY And SpielerY < -64 - -5000 Then
                'GWOrt
                Ort = "am Hinterhof (SF Gebiet)"
            ElseIf -2619 - -5000 < SpielerX And SpielerX < -2519 - -5000 And 2235 - -5000 < SpielerY And SpielerY < 2318 - -5000 Then
                'GWOrt
                Ort = "an der Wiese (BS Gebiet)"
            ElseIf -2518 - -5000 < SpielerX And SpielerX < -2455 - -5000 And 2323 - -5000 < SpielerY And SpielerY < 2405 - -5000 Then
                'GWOrt
                Ort = "am Smarkt (BS Gebiet)"
            ElseIf -2309 - -5000 < SpielerX And SpielerX < -2208 - -5000 And 2345 - -5000 < SpielerY And SpielerY < 2393 - -5000 Then
                'GWOrt
                Ort = "an der Fischerhütte (BS Gebiet)"


            ElseIf 178 - -5000 < SpielerX And SpielerX < 234 - -5000 And -277 - -5000 < SpielerY And SpielerY < -199 - -5000 Then
                'Gebäude
                Ort = "am LCN Versteck"
            ElseIf 1457 - -5000 < SpielerX And SpielerX < 1652 - -5000 And -1476 - -5000 < SpielerY And SpielerY < -1299 - -5000 Then
                'Gebäude
                Ort = "am Startower"
            ElseIf 1419 - -5000 < SpielerX And SpielerX < 1640 - -5000 And -1600 - -5000 < SpielerY And SpielerY < -1440 - -5000 Then
                'Gebäude
                Ort = "an der Z-Kurfe (PD)"
            ElseIf 1057 - -5000 < SpielerX And SpielerX < 1274 - -5000 And -1413 - -5000 < SpielerY And SpielerY < -1272 - -5000 Then
                'Gebäude
                Ort = "am LS Krankenhaus (NS)"
            ElseIf 976 - -5000 < SpielerX And SpielerX < 1069 - -5000 And -1411 - -5000 < SpielerY And SpielerY < -1322 - -5000 Then
                'Gebäude
                Ort = "am Donutladen"
            ElseIf 798 - -5000 < SpielerX And SpielerX < 940 - -5000 And -1326 - -5000 < SpielerY And SpielerY < -1148 - -5000 Then
                'Gebäude
                Ort = "auf dem Verwahrplatz"
            ElseIf 790 - -5000 < SpielerX And SpielerX < 959 - -5000 And -1148 - -5000 < SpielerY And SpielerY < -1048 - -5000 Then
                'Gebäude
                Ort = "auf dem Friedhof"
            ElseIf 1843 - -5000 < SpielerX And SpielerX < 2075 - -5000 And -1271 - -5000 < SpielerY And SpielerY < -1124 - -5000 Then
                'Gebäude
                Ort = "am Glenpark"
            ElseIf 965 - -5000 < SpielerX And SpielerX < 1082 - -5000 And -1079 - -5000 < SpielerY And SpielerY < -971 - -5000 Then
                'Gebäude
                Ort = "am BSN PNS"
            ElseIf 925 - -5000 < SpielerX And SpielerX < 1053 - -5000 And -993 - -5000 < SpielerY And SpielerY < -840 - -5000 Then
                'Gebäude
                Ort = "an der BSN Tanke"
            ElseIf 1033 - -5000 < SpielerX And SpielerX < 1149 - -5000 And -979 - -5000 < SpielerY And SpielerY < -852 - -5000 Then
                'Gebäude
                Ort = "am Sexshop"
            ElseIf 1123 - -5000 < SpielerX And SpielerX < 1262 - -5000 And -1002 - -5000 < SpielerY And SpielerY < -839 - -5000 Then
                'Gebäude
                Ort = "am BSN"
            ElseIf 1253 - -5000 < SpielerX And SpielerX < 1361 - -5000 And -929 - -5000 < SpielerY And SpielerY < -838 - -5000 Then
                'Gebäude
                Ort = "am BSN 24/7"
            ElseIf 1178 - -5000 < SpielerX And SpielerX < 1374 - -5000 And -844 - -5000 < SpielerY And SpielerY < -736 - -5000 Then
                'Gebäude
                Ort = "an Maddogs Villa"
            ElseIf 1384 - -5000 < SpielerX And SpielerX < 1560 - -5000 And -1149 - -5000 < SpielerY And SpielerY < -953 - -5000 Then
                'Gebäude
                Ort = "an der Bank"
            ElseIf 1563 - -5000 < SpielerX And SpielerX < 1694 - -5000 And -1213 - -5000 < SpielerY And SpielerY < -1127 - -5000 Then
                'Gebäude
                Ort = "am Lottoladen"
            ElseIf 1674 - -5000 < SpielerX And SpielerX < 1832 - -5000 And -1195 - -5000 < SpielerY And SpielerY < -1086 - -5000 Then
                'Gebäude
                Ort = "an der Feuerwache"
            ElseIf 1843 - -5000 < SpielerX And SpielerX < 1996 - -5000 And -1466 - -5000 < SpielerY And SpielerY < -1324 - -5000 Then
                'Gebäude
                Ort = "am Skaterpark"
            ElseIf 1982 - -5000 < SpielerX And SpielerX < 2124 - -5000 And -1506 - -5000 < SpielerY And SpielerY < -1307 - -5000 Then
                'Gebäude
                Ort = "am Krankenhaus(LS)"
            ElseIf 2161 - -5000 < SpielerX And SpielerX < 2267 - -5000 And -1241 - -5000 < SpielerY And SpielerY < -1126 - -5000 Then
                'Gebäude
                Ort = "am NoobMotel"
            ElseIf 2363 - -5000 < SpielerX And SpielerX < 2456 - -5000 And -1278 - -5000 < SpielerY And SpielerY < -1164 - -5000 Then
                'Gebäude
                Ort = "am PigPen"
            ElseIf 2193 - -5000 < SpielerX And SpielerX < 2313 - -5000 And -1748 - -5000 < SpielerY And SpielerY < -1672 - -5000 Then
                'Gebäude
                Ort = "am GS Gym"
            ElseIf 1783 - -5000 < SpielerX And SpielerX < 1967 - -5000 And -1793 - -5000 < SpielerY And SpielerY < -1585 - -5000 Then
                'Gebäude
                Ort = "am Alhambra"
            ElseIf 1868 - -5000 < SpielerX And SpielerX < 1975 - -5000 And -1828 - -5000 < SpielerY And SpielerY < -1720 - -5000 Then
                'Gebäude
                Ort = "an der GS Tanke"
            ElseIf 1351 - -5000 < SpielerX And SpielerX < 1603 - -5000 And -1920 - -5000 < SpielerY And SpielerY < -1680 - -5000 Then
                'Gebäude
                Ort = "an der Stadthalle"
            ElseIf 1274 - -5000 < SpielerX And SpielerX < 1429 - -5000 And -1867 - -5000 < SpielerY And SpielerY < -1692 - -5000 Then
                'Gebäude
                Ort = "an der Stadthalle 24/7"
            ElseIf 1561 - -5000 < SpielerX And SpielerX < 1973 - -5000 And -2117 - -5000 < SpielerY And SpielerY < -1812 - -5000 Then
                'Gebäude
                Ort = "am LS Bahnhof"
            ElseIf 622 - -5000 < SpielerX And SpielerX < 804 - -5000 And -1398 - -5000 < SpielerY And SpielerY < -1312 - -5000 Then
                'Gebäude
                Ort = "an der Fahrschule"
            ElseIf 619 - -5000 < SpielerX And SpielerX < 807 - -5000 And -1384 - -5000 < SpielerY And SpielerY < -1129 - -5000 Then
                'Gebäude
                Ort = "am Tennisplatz"
            ElseIf 605 - -5000 < SpielerX And SpielerX < 863 - -5000 And -1437 - -5000 < SpielerY And SpielerY < -1237 - -5000 Then
                'Gebäude
                Ort = "am LS Casino"
            ElseIf 429 - -5000 < SpielerX And SpielerX < 571 - -5000 And -1613 - -5000 < SpielerY And SpielerY < -1369 - -5000 Then
                'Gebäude
                Ort = "an der LCN Pizzeria"
            ElseIf 311 - -5000 < SpielerX And SpielerX < 460 - -5000 And -1809 - -5000 < SpielerY And SpielerY < -1643 - -5000 Then
                'Gebäude
                Ort = "an der Pierauffahrt"
            ElseIf 464 - -5000 < SpielerX And SpielerX < 643 - -5000 And -1810 - -5000 < SpielerY And SpielerY < -1664 - -5000 Then
                'Gebäude
                Ort = "am Pier PNS"
            ElseIf 1036 - -5000 < SpielerX And SpielerX < 1332 - -5000 And -1890 - -5000 < SpielerY And SpielerY < -1692 - -5000 Then
                'Gebäude
                Ort = "am Busspawn"
            ElseIf 1031 - -5000 < SpielerX And SpielerX < 1210 - -5000 And -1611 - -5000 < SpielerY And SpielerY < -1384 - -5000 Then
                'Gebäude
                Ort = "am Noobspawn"
            ElseIf 1148 - -5000 < SpielerX And SpielerX < 1313 - -5000 And -1727 - -5000 < SpielerY And SpielerY < -1573 - -5000 Then
                'Gebäude
                Ort = "an der Taxibase"
            ElseIf 854 - -5000 < SpielerX And SpielerX < 1000 - -5000 And -2077 - -5000 < SpielerY And SpielerY < -1858 - -5000 Then
                'Gebäude
                Ort = "am Bootspier"
            ElseIf 335 - -5000 < SpielerX And SpielerX < 497 - -5000 And -2115 - -5000 < SpielerY And SpielerY < -1810 - -5000 Then
                'Gebäude
                Ort = "am Pier"
            ElseIf 743 - -5000 < SpielerX And SpielerX < 891 - -5000 And -1681 - -5000 < SpielerY And SpielerY < -1569 - -5000 Then
                'Gebäude
                Ort = "am BSS"
            ElseIf -84 - -5000 < SpielerX And SpielerX < 165 - -5000 And -1550 - -5000 < SpielerY And SpielerY < -1481 - -5000 Then
                'Gebäude
                Ort = "an der Truckstop Brücke"
            ElseIf -169 - -5000 < SpielerX And SpielerX < -27 - -5000 And 1276 - -5000 < SpielerY And SpielerY < 1468 - -5000 Then
                'Gebäude
                Ort = "am Ufo Kaffee"
            ElseIf 1303 - -5000 < SpielerX And SpielerX < 1454 - -5000 And -1375 - -5000 < SpielerY And SpielerY < -1228 - -5000 Then
                'Gebäude
                Ort = "am Ammunation"
            ElseIf -359 - -5000 < SpielerX And SpielerX < -225 - -5000 And -2369 - -5000 < SpielerY And SpielerY < -1994 - -5000 Then
                'Gebäude
                Ort = "an Riddicks Farm"
            ElseIf -144 - -5000 < SpielerX And SpielerX < 149 - -5000 And -2946 - -5000 < SpielerY And SpielerY < -2659 - -5000 Then
                'Gebäude
                Ort = "an Justins Privatgrundstück"
            ElseIf 859 - -5000 < SpielerX And SpielerX < 1045 - -5000 And 1561 - -5000 < SpielerY And SpielerY < 1893 - -5000 Then
                'Gebäude
                Ort = "am KF Haus"
            ElseIf 993 - -5000 < SpielerX And SpielerX < 1201 - -5000 And 1357 - -5000 < SpielerY And SpielerY < 1799 - -5000 Then
                'Gebäude
                Ort = "an der LV Arena"
            ElseIf 1235 - -5000 < SpielerX And SpielerX < 1737 - -5000 And 1148 - -5000 < SpielerY And SpielerY < 1859 - -5000 Then
                'Geäude
                Ort = "am LV Airport"
            ElseIf 1486 - -5000 < SpielerX And SpielerX < 1647 - -5000 And -1752 - -5000 < SpielerY And SpielerY < -1580 - -5000 Then
                'Geäude
                Ort = "am LSPD"
            ElseIf 2298 - -5000 < SpielerX And SpielerX < 2437 - -5000 And -2032 - -5000 < SpielerY And SpielerY < -2032 - -5000 Then
                'Geäude
                Ort = "am east LS Ammunation"
            ElseIf 2603 - -5000 < SpielerX And SpielerX < 2727 - -5000 And -2053 - -5000 < SpielerY And SpielerY < -1968 - -5000 Then
                'Geäude
                Ort = "an der Lowrider Tuninggarage"
            ElseIf 926 - -5000 < SpielerX And SpielerX < 1209 - -5000 And 852 - -5000 < SpielerY And SpielerY < 1187 - -5000 Then
                'Geäude
                Ort = "an der FBI Base"
            ElseIf 1825 - -5000 < SpielerX And SpielerX < 2037 - -5000 And 875 - -5000 < SpielerY And SpielerY < 1280 - -5000 Then
                'Geäude
                Ort = "am Four Dragons Casino"
            ElseIf 1832 - -5000 < SpielerX And SpielerX < 2044 - -5000 And 1283 - -5000 < SpielerY And SpielerY < 1452 - -5000 Then
                'Geäude
                Ort = "am High Roller Haus (LV)"
            ElseIf 1254 - -5000 < SpielerX And SpielerX < 1560 - -5000 And 2041 - -5000 < SpielerY And SpielerY < 2317 - -5000 Then
                'Geäude
                Ort = "am LV Stadion"
            ElseIf 1835 - -5000 < SpielerX And SpielerX < 2042 - -5000 And 1458 - -5000 < SpielerY And SpielerY < 1731 - -5000 Then
                'Geäude
                Ort = "am LV Piratenschiff"
            ElseIf 1861 - -5000 < SpielerX And SpielerX < 2119 - -5000 And 1720 - -5000 < SpielerY And SpielerY < 2053 - -5000 Then
                'Geäude
                Ort = "an der alten Rifabase (LV)"
            ElseIf 2049 - -5000 < SpielerX And SpielerX < 2328 - -5000 And 1506 - -5000 < SpielerY And SpielerY < 1774 - -5000 Then
                'Geäude
                Ort = "am Caligulas Casino (LV)"
            ElseIf 2131 - -5000 < SpielerX And SpielerX < 2508 - -5000 And 1769 - -5000 < SpielerY And SpielerY < 1973 - -5000 Then
                'Geäude
                Ort = "am Clowns Pocket (LV)"
            ElseIf 2524 - -5000 < SpielerX And SpielerX < 2664 - -5000 And 2228 - -5000 < SpielerY And SpielerY < 2478 - -5000 Then
                'Geäude
                Ort = "an der Russen Disco (LV)"
            ElseIf 2004 - -5000 < SpielerX And SpielerX < 2370 - -5000 And 2287 - -5000 < SpielerY And SpielerY < 2515 - -5000 Then
                'Geäude
                Ort = "am LV PD"
            ElseIf 622 - -5000 < SpielerX And SpielerX < 804 - -5000 And -1398 - -5000 < SpielerY And SpielerY < -1312 - -5000 Then
                'Gebäude
                Ort = "an der Fahrschule"
            ElseIf 1631 - -5000 < SpielerX And SpielerX < 2000 - -5000 And 2635 - -5000 < SpielerY And SpielerY < 2909 - -5000 Then
                'Geäude
                Ort = "am LV Tennisplatz"
            ElseIf 1060 - -5000 < SpielerX And SpielerX < 1639 - -5000 And 2640 - -5000 < SpielerY And SpielerY < 2908 - -5000 Then
                'Geäude
                Ort = "am LV Golfplatz"
            ElseIf 1205 - -5000 < SpielerX And SpielerX < 1594 - -5000 And 2579 - -5000 < SpielerY And SpielerY < 2690 - -5000 Then
                'Geäude
                Ort = "am LV Bahnhof Nord"
            ElseIf 2081 - -5000 < SpielerX And SpielerX < 2471 - -5000 And 2693 - -5000 < SpielerY And SpielerY < 2890 - -5000 Then
                'Geäude
                Ort = "LVNord"
            ElseIf -1152 - -5000 < SpielerX And SpielerX < -905 - -5000 And -786 - -5000 < SpielerY And SpielerY < -492 - -5000 Then
                'Geäude
                Ort = "an der Yakuza Eisfabrik"
            ElseIf -1891 - -5000 < SpielerX And SpielerX < -1770 - -5000 And -123 - -5000 < SpielerY And SpielerY < 224 - -5000 Then
                'Geäude
                Ort = "an Solarin Industries"
            ElseIf -2229 - -5000 < SpielerX And SpielerX < -1927 - -5000 And -569 - -5000 < SpielerY And SpielerY < -321 - -5000 Then
                'Geäude
                Ort = "an der SF Arena"
            ElseIf -803 - -5000 < SpielerX And SpielerX < -302 - -5000 And -716 - -5000 < SpielerY And SpielerY < -356 - -5000 Then
                'Geäude
                Ort = "an der alten O-amt Base"
            ElseIf -2973 - -5000 < SpielerX And SpielerX < -2251 - -5000 And -553 - -5000 < SpielerY And SpielerY < -69 - -5000 Then
                'Geäude
                Ort = "an der Rifa Base"
            ElseIf -2227 - -5000 < SpielerX And SpielerX < -1951 - -5000 And -313 - -5000 < SpielerY And SpielerY < 35 - -5000 Then
                'Geäude
                Ort = "am TÜV"
            ElseIf -2152 - -5000 < SpielerX And SpielerX < -1882 - -5000 And -68 - -5000 < SpielerY And SpielerY < 210 - -5000 Then
                'Geäude
                Ort = "am SF Bahnhof"
            ElseIf -2140 - -5000 < SpielerX And SpielerX < -1851 - -5000 And 179 - -5000 < SpielerY And SpielerY < 396 - -5000 Then
                'Geäude
                Ort = "am SF Bahnhof PNS"
            ElseIf -2157 - -5000 < SpielerX And SpielerX < -1828 - -5000 And 1288 - -5000 < SpielerY And SpielerY < 627 - -5000 Then
                'Geäude
                Ort = "an der Sam AG Base"
            ElseIf -1887 - -5000 < SpielerX And SpielerX < -1753 - -5000 And 443 - -5000 < SpielerY And SpielerY < 732 - -5000 Then
                'Geäude
                Ort = "an der SF Bank"
            ElseIf -1762 - -5000 < SpielerX And SpielerX < -1597 - -5000 And 496 - -5000 < SpielerY And SpielerY < 317 - -5000 Then
                'Geäude
                Ort = "an der SFPD Tanke"
            ElseIf -1778 - -5000 < SpielerX And SpielerX < -1471 - -5000 And 526 - -5000 < SpielerY And SpielerY < 818 - -5000 Then
                'Geäude
                Ort = "am SFPD"
            ElseIf -1662 - -5000 < SpielerX And SpielerX < -1389 - -5000 And 796 - -5000 < SpielerY And SpielerY < 1094 - -5000 Then
                'Geäude
                Ort = "an der SF Stadthalle"
            ElseIf -1873 - -5000 < SpielerX And SpielerX < -1717 - -5000 And 781 - -5000 < SpielerY And SpielerY < 1041 - -5000 Then
                'Geäude
                Ort = "an der Fastfood AG"
            ElseIf -2157 - -5000 < SpielerX And SpielerX < -1803 - -5000 And 1037 - -5000 < SpielerY And SpielerY < 1223 - -5000 Then
                'Geäude
                Ort = "an der SF Kirche"
            ElseIf -1812 - -5000 < SpielerX And SpielerX < -1461 - -5000 And 1286 - -5000 < SpielerY And SpielerY < 1554 - -5000 Then
                'Geäude
                Ort = "am SF Pier"
            ElseIf -1524 - -5000 < SpielerX And SpielerX < -1285 - -5000 And 1446 - -5000 < SpielerY And SpielerY < 1562 - -5000 Then
                'Geäude
                Ort = "am SF Schiff (Klein)"
            ElseIf -2602 - -5000 < SpielerX And SpielerX < -2133 - -5000 And 1482 - -5000 < SpielerY And SpielerY < 1649 - -5000 Then
                'Geäude
                Ort = "am SF Schiff (Groß)"
            ElseIf -2872 - -5000 < SpielerX And SpielerX < -2576 - -5000 And 1206 - -5000 < SpielerY And SpielerY < 1559 - -5000 Then
                'Geäude
                Ort = "an der Yakuza Base"
            ElseIf -2827 - -5000 < SpielerX And SpielerX < -2659 - -5000 And 694 - -5000 < SpielerY And SpielerY < 917 - -5000 Then
                'Geäude
                Ort = "am SF Donutladen"
            ElseIf -2857 - -5000 < SpielerX And SpielerX < -2857 - -5000 And 430 - -5000 < SpielerY And SpielerY < 806 - -5000 Then
                'Geäude
                Ort = "am SF Krankenhaus"
            ElseIf -3015 - -5000 < SpielerX And SpielerX < -2849 - -5000 And 349 - -5000 < SpielerY And SpielerY < 569 - -5000 Then
                'Geäude
                Ort = "am SF Bootsshop"
            ElseIf -2848 - -5000 < SpielerX And SpielerX < -2693 - -5000 And 274 - -5000 < SpielerY And SpielerY < 474 - -5000 Then
                'Geäude
                Ort = "an der Nova Tel AG"
            ElseIf -2651 - -5000 < SpielerX And SpielerX < -2473 - -5000 And -7 - -5000 < SpielerY And SpielerY < 147 - -5000 Then
                'Geäude
                Ort = "am Bikeshop"
            ElseIf -2403 - -5000 < SpielerX And SpielerX < -2237 - -5000 And 17 - -5000 < SpielerY And SpielerY < 287 - -5000 Then
                'Geäude
                Ort = "am SF Baseball Feld"
            ElseIf -2572 - -5000 < SpielerX And SpielerX < -2353 - -5000 And 883 - -5000 < SpielerY And SpielerY < 641 - -5000 Then
                'Geäude
                Ort = "am SF 24/7"
            ElseIf -2563 - -5000 < SpielerX And SpielerX < -2353 - -5000 And 881 - -5000 < SpielerY And SpielerY < 1105 - -5000 Then
                'Geäude
                Ort = "am SF Carshop"
            ElseIf -2395 - -5000 < SpielerX And SpielerX < -2275 - -5000 And 1109 - -5000 < SpielerY And SpielerY < 911 - -5000 Then
                'Geäude
                Ort = "am Carshop Burgershot"
            ElseIf -1054 - -5000 < SpielerX And SpielerX < -462 - -5000 And 1742 - -5000 < SpielerY And SpielerY < 2128 - -5000 Then
                'Geäude
                Ort = "am Staudamm"
            ElseIf 889 - -5000 < SpielerX And SpielerX < 1046 - -5000 And 2014 - -5000 < SpielerY And SpielerY < 2291 - -5000 Then
                'Geäude
                Ort = "an der KF Base"
            ElseIf -1736 - -5000 < SpielerX And SpielerX < -1450 - -5000 And -2959 - -5000 < SpielerY And SpielerY < -2569 - -5000 Then
                'Geäude
                Ort = "an der AP Tanke"
            ElseIf 1118 - -5000 < SpielerX And SpielerX < 1286 - -5000 And -694 - -5000 < SpielerY And SpielerY < -584 - -5000 Then
                'Geäude
                Ort = "an der Noobbrücke"
            ElseIf 1522 - -5000 < SpielerX And SpielerX < 1695 - -5000 And 395 - -5000 < SpielerY And SpielerY < 458 - -5000 Then
                'Geäude
                Ort = "an der O'Sullivan Hütte"
            ElseIf 642 - -5000 < SpielerX And SpielerX < 764 - -5000 And 1890 - -5000 < SpielerY And SpielerY < 2058 - -5000 Then
                'Geäude
                Ort = "am Russen Puff"


            ElseIf 942 - -5000 < SpielerX And SpielerX < 1355 - -5000 And -1192 - -5000 < SpielerY And SpielerY < -1114 - -5000 Then
                'Straße
                Ort = "am Walk of Fame"
            ElseIf 1291 - -5000 < SpielerX And SpielerX < 1423 - -5000 And -1093 - -5000 < SpielerY And SpielerY < -985 - -5000 Then
                'Straße
                Ort = "an der Bankkreuzung"
            ElseIf 862 - -5000 < SpielerX And SpielerX < 1362 - -5000 And -990 - -5000 < SpielerY And SpielerY < -899 - -5000 Then
                'Straße
                Ort = "auf der BSN Straße"
            ElseIf 713 - -5000 < SpielerX And SpielerX < 853 - -5000 And -1065 - -5000 < SpielerY And SpielerY < -841 - -5000 Then
                'Straße
                Ort = "an der DD Auffahrt"
            ElseIf 1343 - -5000 < SpielerX And SpielerX < 1513 - -5000 And -943 - -5000 < SpielerY And SpielerY < -822 - -5000 Then
                'Straße
                Ort = "an der Vinewood Auffahrt"
            ElseIf 632 - -5000 < SpielerX And SpielerX < 806 - -5000 And -2055 - -5000 < SpielerY And SpielerY < -1408 - -5000 Then
                'Straße
                Ort = "am LCN Kanal"
            ElseIf -1253 - -5000 < SpielerX And SpielerX < -797 - -5000 And -1198 - -5000 < SpielerY And SpielerY < -738 - -5000 Then
                'Straße
                Ort = "am SF Tunnel"
            ElseIf 1560 - -5000 < SpielerX And SpielerX < 1820 - -5000 And -905 - -5000 < SpielerY And SpielerY < 743 - -5000 Then
                'Straße
                Ort = "auf der LV Autobahn"
            ElseIf 1751 - -5000 < SpielerX And SpielerX < 1865 - -5000 And 773 - -5000 < SpielerY And SpielerY < 891 - -5000 Then
                'Straße
                Ort = "auf dem LV Kreuz"
            ElseIf 1491 - -5000 < SpielerX And SpielerX < 1855 - -5000 And -1076 - -5000 < SpielerY And SpielerY < -794 - -5000 And SpielerZ > 26 Then
                'Straße
                Ort = "auf der LV Autobahn Auffahrt"
            ElseIf 1304 - -5000 < SpielerX And SpielerX < 1391 - -5000 And -1455 - -5000 < SpielerY And SpielerY < -947 - -5000 Then
                'Straße
                Ort = "auf der Ammustraße"
            ElseIf 943 - -5000 < SpielerX And SpielerX < 1333 - -5000 And -1094 - -5000 < SpielerY And SpielerY < -1013 - -5000 Then
                'Straße
                Ort = "auf der BSN PNS Straße"
            ElseIf 600 - -5000 < SpielerX And SpielerX < 1328 - -5000 And -1426 - -5000 < SpielerY And SpielerY < -1346 - -5000 Then
                'Straße
                Ort = "auf der Noobspawn Straße"
            ElseIf 1742 - -5000 < SpielerX And SpielerX < 1842 - -5000 And 776 - -5000 < SpielerY And SpielerY < 2616 - -5000 Then
                'Straße
                Ort = "auf der mittleren LV Autobahn"
            ElseIf 1108 - -5000 < SpielerX And SpielerX < 1334 - -5000 And 783 - -5000 < SpielerY And SpielerY < 2507 - -5000 Then
                'Straße
                Ort = "auf der westlichen LV Autobahn"
            ElseIf 1122 - -5000 < SpielerX And SpielerX < 2681 - -5000 And 781 - -5000 < SpielerY And SpielerY < 948 - -5000 Then
                'Straße
                Ort = "auf der südlichen LV Autobahn"
            ElseIf 2610 - -5000 < SpielerX And SpielerX < 1804 - -5000 And 837 - -5000 < SpielerY And SpielerY < 2645 - -5000 Then
                'Straße
                Ort = "auf der östlichen LV Autobahn"
            ElseIf 2033 - -5000 < SpielerX And SpielerX < 2673 - -5000 And 2463 - -5000 < SpielerY And SpielerY < 2676 - -5000 Then
                'Straße
                Ort = "auf der nördlichen LV Autobahn"
            ElseIf 1087 - -5000 < SpielerX And SpielerX < 2025 - -5000 And 2381 - -5000 < SpielerY And SpielerY < 2596 - -5000 Then
                'Straße
                Ort = "auf der nördlichen LV Autobahn"
            ElseIf 2549 - -5000 < SpielerX And SpielerX < 2632 - -5000 And -2265 - -5000 < SpielerY And SpielerY < -1458 - -5000 Then
                'Straße
                Ort = "im GS Kanal"
            ElseIf -2383 - -5000 < SpielerX And SpielerX < -1815 - -5000 And 977 - -5000 < SpielerY And SpielerY < 1113 - -5000 Then
                'Straße
                Ort = "im SF Tunnel (Kirche)"
            ElseIf -2729 - -5000 < SpielerX And SpielerX < -2601 - -5000 And 1462 - -5000 < SpielerY And SpielerY < 2242 - -5000 Then
                'Straße
                Ort = "auf der Bayside Brücke"


            ElseIf 1350 - -5000 < SpielerX And SpielerX < 1522 - -5000 And 265 - -5000 < SpielerY And SpielerY < 507 - -5000 Then
                'Gebiet
                Ort = "an der O'Sullivan Base"
            ElseIf 2011 - -5000 < SpielerX And SpielerX < 2604 - -5000 And -1231 - -5000 < SpielerY And SpielerY < -908 - -5000 Then
                'Gebiet
                Ort = "an der Vagos Base"
            ElseIf 1514 - -5000 < SpielerX And SpielerX < 1866 - -5000 And -1179 - -5000 < SpielerY And SpielerY < -996 - -5000 Then
                'Gebiet
                Ort = "auf dem Bankparkplatz"
            ElseIf 2591 - -5000 < SpielerX And SpielerX < 2917 - -5000 And -1930 - -5000 < SpielerY And SpielerY < -1013 - -5000 Then
                'Gebiet
                Ort = "im Arena Gebiet"
            ElseIf 2061 - -5000 < SpielerX And SpielerX < 2616 - -5000 And -1529 - -5000 < SpielerY And SpielerY < -1287 - -5000 Then
                'Gebiet
                Ort = "an der Ballas Base"
            ElseIf 1661 - -5000 < SpielerX And SpielerX < 2117 - -5000 And -1484 - -5000 < SpielerY And SpielerY < -1094 - -5000 Then
                'Gebiet
                Ort = "im Glenpark Gebiet"
            ElseIf 753 - -5000 < SpielerX And SpielerX < 1375 - -5000 And -1184 - -5000 < SpielerY And SpielerY < -912 - -5000 Then
                'Gebiet
                Ort = "im BSN Gebiet"
            ElseIf 523 - -5000 < SpielerX And SpielerX < 883 - -5000 And -686 - -5000 < SpielerY And SpielerY < -369 - -5000 Then
                'Gebiet
                Ort = "in Dillimore"
            ElseIf 1887 - -5000 < SpielerX And SpielerX < 2602 - -5000 And -1880 - -5000 < SpielerY And SpielerY < -1592 - -5000 Then
                'Gebiet
                Ort = "an der Grovestreet Base"
            ElseIf 2094 - -5000 < SpielerX And SpielerX < 2941 - -5000 And -2745 - -5000 < SpielerY And SpielerY < -2090 - -5000 Then
                'Gebiet
                Ort = "im Docks Gebiet"
            ElseIf 1010 - -5000 < SpielerX And SpielerX < 1313 - -5000 And -1862 - -5000 < SpielerY And SpielerY < -1377 - -5000 Then
                'Gebiet
                Ort = "im Noobspawn Gebiet"
            ElseIf 38 - -5000 < SpielerX And SpielerX < 878 - -5000 And -2120 - -5000 < SpielerY And SpielerY < -1679 - -5000 Then
                'Gebiet
                Ort = "im Pier Gebiet"
            ElseIf 76 - -5000 < SpielerX And SpielerX < 605 - -5000 And -1614 - -5000 < SpielerY And SpielerY < -1080 - -5000 Then
                'Gebiet
                Ort = "an der LCN Base"
            ElseIf 1227 - -5000 < SpielerX And SpielerX < 2254 - -5000 And -2825 - -5000 < SpielerY And SpielerY < -2142 - -5000 Then
                'Gebiet
                Ort = "am LS Aiport"
            ElseIf 1034 - -5000 < SpielerX And SpielerX < 1582 - -5000 And -2204 - -5000 < SpielerY And SpielerY < -1814 - -5000 Then
                'Gebiet
                Ort = "am Weißen Haus"
            ElseIf 2026 - -5000 < SpielerX And SpielerX < 2460 - -5000 And 930 - -5000 < SpielerY And SpielerY < 1613 - -5000 Then
                'Gebiet
                Ort = "im LV Gebiet"
            ElseIf -328 - -5000 < SpielerX And SpielerX < 139 - -5000 And -217 - -5000 < SpielerY And SpielerY < 270 - -5000 Then
                'Gebiet
                Ort = "an der Farm"
            ElseIf -251 - -5000 < SpielerX And SpielerX < 235 - -5000 And -457 - -5000 < SpielerY And SpielerY < -167 - -5000 Then
                'Gebiet
                Ort = "am Fleischberg"
            ElseIf -1008 - -5000 < SpielerX And SpielerX < -198 - -5000 And -306 - -5000 < SpielerY And SpielerY < 294 - -5000 Then
                'Gebiet
                Ort = "am Sägewerk"
            ElseIf -298 - -5000 < SpielerX And SpielerX < 55 - -5000 And -1374 - -5000 < SpielerY And SpielerY < -881 - -5000 Then
                'Gebiet
                Ort = "am Truckstop"
            ElseIf -1316 - -5000 < SpielerX And SpielerX < -838 - -5000 And -1845 - -5000 < SpielerY And SpielerY < -1490 - -5000 Then
                'Gebiet
                Ort = "an Justins Farm"
            ElseIf -907 - -5000 < SpielerX And SpielerX < -363 - -5000 And -2206 - -5000 < SpielerY And SpielerY < -1767 - -5000 Then
                'Gebiet
                Ort = "am OC See"
            ElseIf 851 - -5000 < SpielerX And SpielerX < 1229 - -5000 And -450 - -5000 < SpielerY And SpielerY < -139 - -5000 Then
                'Gebiet
                Ort = "an der Sektenfarm"
            ElseIf -517 - -5000 < SpielerX And SpielerX < -142 - -5000 And 1285 - -5000 < SpielerY And SpielerY < 1693 - -5000 Then
                'Gebiet
                Ort = "am Big Ear"
            ElseIf -137 - -5000 < SpielerX And SpielerX < 549 - -5000 And 1586 - -5000 < SpielerY And SpielerY < 2240 - -5000 Then
                'Gebiet
                Ort = "an der Army Base"
            ElseIf -111 - -5000 < SpielerX And SpielerX < 510 - -5000 And 2285 - -5000 < SpielerY And SpielerY < 2646 - -5000 Then
                'Gebiet
                Ort = "am toten Flughafen"
            ElseIf -208 - -5000 < SpielerX And SpielerX < 34 - -5000 And -1590 - -5000 < SpielerY And SpielerY < -1517 - -5000 Then
                'Gebiet
                Ort = "am Campingplatz"
            ElseIf 269 - -5000 < SpielerX And SpielerX < 546 - -5000 And -2549 - -5000 < SpielerY And SpielerY < -2314 - -5000 Then
                'Gebiet
                Ort = "an Bubbles Insel"
            ElseIf 2276 - -5000 < SpielerX And SpielerX < 2756 - -5000 And -2020 - -5000 < SpielerY And SpielerY < -2182 - -5000 Then
                'Gebiet
                Ort = "am Truckshop"
            ElseIf 1408 - -5000 < SpielerX And SpielerX < 1553 - -5000 And -1748 - -5000 < SpielerY And SpielerY < -1565 - -5000 Then
                'Gebiet
                Ort = "am Brunnen an der SH"
            ElseIf 1348 - -5000 < SpielerX And SpielerX < 1348 - -5000 And -1716 - -5000 < SpielerY And SpielerY < -1449 - -5000 Then
                'Gebiet
                Ort = "am PD Kanal"
            ElseIf 232 - -5000 < SpielerX And SpielerX < 937 - -5000 And 589 - -5000 < SpielerY And SpielerY < 1153 - -5000 Then
                'Gebiet
                Ort = "an der Erzmiene"
            ElseIf -1741 - -5000 < SpielerX And SpielerX < -1188 - -5000 And -712 - -5000 < SpielerY And SpielerY < -148 - -5000 Then
                'Gebiet
                Ort = "am SF Airport"
            ElseIf -1663 - -5000 < SpielerX And SpielerX < -1062 - -5000 And -529 - -5000 < SpielerY And SpielerY < 57 - -5000 Then
                'Gebiet
                Ort = "am SF Airport"
            ElseIf -1460 - -5000 < SpielerX And SpielerX < -1001 - -5000 And -63 - -5000 < SpielerY And SpielerY < 529 - -5000 Then
                'Gebiet
                Ort = "am SF Airport"
            ElseIf -1981 - -5000 < SpielerX And SpielerX < -1465 - -5000 And -201 - -5000 < SpielerY And SpielerY < 232 - -5000 Then
                'Gebiet
                Ort = "an den SF Docks"
            ElseIf -1641 - -5000 < SpielerX And SpielerX < -1221 - -5000 And 249 - -5000 < SpielerY And SpielerY < 521 - -5000 Then
                'Gebiet
                Ort = "am Flugzeugträger"
            ElseIf -2175 - -5000 < SpielerX And SpielerX < -1923 - -5000 And -1158 - -5000 < SpielerY And SpielerY < -593 - -5000 Then
                'Gebiet
                Ort = "an Foster Valley"
            ElseIf -3018 - -5000 < SpielerX And SpielerX < -1896 - -5000 And -2211 - -5000 < SpielerY And SpielerY < -855 - -5000 Then
                'Gebiet
                Ort = "am Mount Chiliard"
            ElseIf -2999 - -5000 < SpielerX And SpielerX < -2156 - -5000 And -1009 - -5000 < SpielerY And SpielerY < -440 - -5000 Then
                'Gebiet
                Ort = "am Stromwerk"
            ElseIf -2924 - -5000 < SpielerX And SpielerX < -2442 - -5000 And 25 - -5000 < SpielerY And SpielerY < 484 - -5000 Then
                'Gebiet
                Ort = "im SF Schwulenvirttel"
            ElseIf -483 - -5000 < SpielerX And SpielerX < -162 - -5000 And 1677 - -5000 < SpielerY And SpielerY < 2122 - -5000 Then
                'Gebiet
                Ort = "am LV Geysir"
            ElseIf -1032 - -5000 < SpielerX And SpielerX < -526 - -5000 And 2559 - -5000 < SpielerY And SpielerY < 2986 - -5000 Then
                'Gebiet
                Ort = "am LV Tee Pee Motel"
            ElseIf -1808 - -5000 < SpielerX And SpielerX < -1330 - -5000 And -2366 - -5000 < SpielerY And SpielerY < -2020 - -5000 Then
                'Gebiet
                Ort = "am Steinmetz Job"
            ElseIf 285 - -5000 < SpielerX And SpielerX < 742 - -5000 And 1230 - -5000 < SpielerY And SpielerY < 1729 - -5000 Then
                'Gebiet
                Ort = "auf den Ölfeldern (LV)"




            ElseIf -430 - -5000 < SpielerX And SpielerX < -77 - -5000 And 2525 - -5000 < SpielerY And SpielerY < 2873 - -5000 Then
                'Stadt
                Ort = "am heiligen Huhn"
            ElseIf -980 - -5000 < SpielerX And SpielerX < -566 - -5000 And 1291 - -5000 < SpielerY And SpielerY < 1686 - -5000 Then
                'Stadt
                Ort = "an der heiligen Kuh"
            ElseIf -540 - -5000 < SpielerX And SpielerX < -165 - -5000 And 2112 - -5000 < SpielerY And SpielerY < 2434 - -5000 Then
                'Stadt
                Ort = "im Geisterdorf"


            Else
                GetZoneName(Zone.Text)
                GetCityName(Stadt.Text)
                Ort = "in " & Stadt.Text & " (" & Zone.Text & ")"
            End If
        Catch
            Ort = "ORT: UNBEKANNT"
        End Try

    End Sub

    Sub WPLöschen()


        If KilledWPLer = WP0.ToString.Split(" ")(0) Then
            KWWPs = WP0.ToString.ToString.Split(" ")(2)
            WP0 = ""
        ElseIf KilledWPLer = WP1.ToString.Split(" ")(0) Then
            KWWPs = WP1.ToString.ToString.Split(" ")(2)
            WP1 = ""
        ElseIf KilledWPLer = WP2.ToString.Split(" ")(0) Then
            KWWPs = WP2.ToString.ToString.Split(" ")(2)
            WP2 = ""
        ElseIf KilledWPLer = WP3.ToString.Split(" ")(0) Then
            KWWPs = WP3.ToString.ToString.Split(" ")(2)
            WP3 = ""
        ElseIf KilledWPLer = WP4.ToString.Split(" ")(0) Then
            KWWPs = WP4.ToString.ToString.Split(" ")(2)
            WP4 = ""
        ElseIf KilledWPLer = WP5.ToString.Split(" ")(0) Then
            KWWPs = WP5.ToString.ToString.Split(" ")(2)
            WP5 = ""
        ElseIf KilledWPLer = WP6.ToString.Split(" ")(0) Then
            KWWPs = WP6.ToString.ToString.Split(" ")(2)
            WP6 = ""
        ElseIf KilledWPLer = WP7.ToString.Split(" ")(0) Then
            KWWPs = WP7.ToString.ToString.Split(" ")(2)
            WP7 = ""
        ElseIf KilledWPLer = WP8.ToString.Split(" ")(0) Then
            KWWPs = WP8.ToString.ToString.Split(" ")(2)
            WP8 = ""
        ElseIf KilledWPLer = WP9.ToString.Split(" ")(0) Then
            KWWPs = WP9.ToString.ToString.Split(" ")(2)
            WP9 = ""
        ElseIf KilledWPLer = WP10.ToString.Split(" ")(0) Then
            KWWPs = WP10.ToString.ToString.Split(" ")(2)
            WP10 = ""
        ElseIf KilledWPLer = WP11.ToString.Split(" ")(0) Then
            KWWPs = WP11.ToString.ToString.Split(" ")(2)
            WP11 = ""
        ElseIf KilledWPLer = WP12.ToString.Split(" ")(0) Then
            KWWPs = WP12.ToString.ToString.Split(" ")(2)
            WP12 = ""
        ElseIf KilledWPLer = WP13.ToString.Split(" ")(0) Then
            KWWPs = WP13.ToString.ToString.Split(" ")(2)
            WP13 = ""
        ElseIf KilledWPLer = WP14.ToString.Split(" ")(0) Then
            KWWPs = WP14.ToString.ToString.Split(" ")(2)
            WP14 = ""
        ElseIf KilledWPLer = WP15.ToString.Split(" ")(0) Then
            KWWPs = WP15.ToString.ToString.Split(" ")(2)
            WP15 = ""
        ElseIf KilledWPLer = WP16.ToString.Split(" ")(0) Then
            KWWPs = WP16.ToString.ToString.Split(" ")(2)
            WP16 = ""
        ElseIf KilledWPLer = WP17.ToString.Split(" ")(0) Then
            KWWPs = WP17.ToString.ToString.Split(" ")(2)
            WP17 = ""
        ElseIf KilledWPLer = WP18.ToString.Split(" ")(0) Then
            KWWPs = WP18.ToString.ToString.Split(" ")(2)
            WP18 = ""
        ElseIf KilledWPLer = WP19.ToString.Split(" ")(0) Then
            KWWPs = WP19.ToString.ToString.Split(" ")(2)
            WP19 = ""
        ElseIf KilledWPLer = WP20.ToString.Split(" ")(0) Then
            KWWPs = WP20.ToString.ToString.Split(" ")(2)
            WP20 = ""
        ElseIf KilledWPLer = WP21.ToString.Split(" ")(0) Then
            KWWPs = WP21.ToString.ToString.Split(" ")(2)
            WP21 = ""
        ElseIf KilledWPLer = WP22.ToString.Split(" ")(0) Then
            KWWPs = WP22.ToString.ToString.Split(" ")(2)
            WP22 = ""
        ElseIf KilledWPLer = WP23.ToString.Split(" ")(0) Then
            KWWPs = WP23.ToString.ToString.Split(" ")(2)
            WP23 = ""
        ElseIf KilledWPLer = WP24.ToString.Split(" ")(0) Then
            KWWPs = WP27.ToString.ToString.Split(" ")(2)
            WP24 = ""
        ElseIf KilledWPLer = WP25.ToString.Split(" ")(0) Then
            KWWPs = WP25.ToString.ToString.Split(" ")(2)
            WP25 = ""
        ElseIf KilledWPLer = WP26.ToString.Split(" ")(0) Then
            KWWPs = WP26.ToString.ToString.Split(" ")(2)
            WP26 = ""
        ElseIf KilledWPLer = WP27.ToString.Split(" ")(0) Then
            KWWPs = WP27.ToString.ToString.Split(" ")(2)
            WP27 = ""
        Else
            KWWPs = "??"
        End If

        AddChatMessage("{FF3333}" & KilledWPLer & "{FFFFFF}({00E533}" & KWWPs & " WPs{FFFFFF}) wurde getötet/eingesperrt/gecleart.")


        OverlayStatus = 1
        DestroyAllVisual()
        SetParam("process", "gta_sa.exe")
        OverlayErstellen()


    End Sub

    Sub WPStatus()

        GPA = 0
        GPI = 0
        If Not WP0 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP0)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP0 = WP0 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP0 = WP0 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP0 = WP0 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP1 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP1)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP1 = WP1 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP1 = WP1 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP1 = WP1 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP2 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP2)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP2 = WP2 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP2 = WP2 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP2 = WP2 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP3 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP3)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP3 = WP3 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP3 = WP3 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP3 = WP3 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP4 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP4)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP4 = WP4 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP4 = WP4 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP4 = WP4 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP5 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP5)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP5 = WP5 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP5 = WP5 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP5 = WP5 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP6 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP6)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP6 = WP6 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP6 = WP6 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP6 = WP6 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP7 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP7)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP7 = WP7 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP7 = WP7 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP7 = WP7 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP8 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP8)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP8 = WP8 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP8 = WP8 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP8 = WP8 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP9 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP9)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP9 = WP9 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP9 = WP9 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP9 = WP9 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP10 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP10)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP10 = WP10 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP10 = WP10 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP10 = WP10 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP11 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP11)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP11 = WP11 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP11 = WP11 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP11 = WP11 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP12 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP12)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP12 = WP12 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP12 = WP12 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP12 = WP12 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP13 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP13)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP13 = WP13 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP13 = WP13 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP13 = WP13 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP14 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP14)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP14 = WP14 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP14 = WP14 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP14 = WP14 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP15 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP15)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP15 = WP15 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP15 = WP15 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP15 = WP15 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP16 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP16)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP16 = WP16 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP16 = WP16 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP16 = WP16 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP17 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP17)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP17 = WP17 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP17 = WP17 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP17 = WP17 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP18 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP18)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP18 = WP18 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP18 = WP18 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP18 = WP18 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP19 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP19)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP19 = WP19 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP19 = WP19 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP19 = WP19 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP20 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP20)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP20 = WP20 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP20 = WP20 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP20 = WP20 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP21 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP21)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP21 = WP21 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP21 = WP21 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP21 = WP21 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP22 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP22)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP22 = WP22 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP22 = WP22 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP22 = WP22 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP23 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP23)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP23 = WP23 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP23 = WP23 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP23 = WP23 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP24 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP24)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP24 = WP24 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP24 = WP24 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP24 = WP24 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP25 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP25)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP25 = WP25 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP25 = WP25 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP25 = WP25 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP26 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP26)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP26 = WP26 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP26 = WP26 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP26 = WP26 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2) = "[" & TimeOfDay & "] FEHLER:{FFFFFF} Der Befehl wurde wegen CMD Spam blockiert." Then
                GoTo CMDSPam
            End If
        End If

        If Not WP27 = "" Then
            GPI = GPI + 1
            SendChat("/id " & WP27)
            System.Threading.Thread.Sleep("100")
            If System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("AFK-Modus.") Then
                WP27 = WP27 & " (AFK)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist tot.") Then
                WP27 = WP27 & " (TOT)"
            ElseIf System.IO.File.ReadAllLines(Einstellungen.CLPf.Text)(System.IO.File.ReadAllLines(Einstellungen.CLPf.Text).Length - 2).Contains("User ist im Gefängnis.") Then
                WP27 = WP27 & " (Knast)"
            Else
                GPA = GPA + 1
            End If
            System.Threading.Thread.Sleep("125")
        End If
        GoTo KeinCMDSpam
CMDSPam:
        AddChatMessage("{FF3333}Fehler! {FFFFFF}Der Vorgang wurde wegen CMD Spam abgebrochen!")
KeinCMDSpam:


    End Sub

    Private Sub BombenTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BombenTimer.Tick

        BombenZeit = BombenZeit - 1
        ShowGameText("~n~~n~~n~~n~~n~~n~~n~~n~~n~~y~Zeit bis zur Detonation: ~g~" & BombenZeit & " ~y~Sekunden", 1000, 3)
        If BombenZeit = 60 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If BombenZeit = 30 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If BombenZeit = 10 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If BombenZeit < 2 Then
            If Not TTod.Enabled And Not Defi.Enabled Then
                Ende.Start()
            Else
                BombenTimer.Stop()
            End If
        End If


    End Sub

    Private Sub Waffenabgleich()
        Try
            If IsPlayerInAnyVehicle Then
                Waffe = "einem Fahrzeug"
            Else
                WaffenID = GetPlayerWeaponID
                If WaffenID = 0 Then
                    Waffe = "der Faust"
                ElseIf WaffenID = 5 Then
                    Waffe = "dem Baseballschläger"
                ElseIf WaffenID = 24 Then
                    Waffe = "der Deagle"
                ElseIf WaffenID = 29 Then
                    Waffe = "der MP5"
                ElseIf WaffenID = 30 Then
                    Waffe = "der AK47"
                ElseIf WaffenID = 41 Then
                    Waffe = "dem Spray"
                ElseIf WaffenID = 4 Then
                    Waffe = "dem Messer"
                ElseIf WaffenID = 8 Then
                    Waffe = "dem Katana"
                ElseIf WaffenID = 22 Then
                    Waffe = "der 9mm"
                ElseIf WaffenID = 23 Then
                    Waffe = "der 9mm (Schallgedämpft)"
                ElseIf WaffenID = 9 Then
                    Waffe = "der Kettensäge"
                ElseIf WaffenID = 3 Then
                    Waffe = "dem Schlagstock"
                ElseIf WaffenID = 25 Then
                    Waffe = "der Shotgun"
                ElseIf WaffenID = 31 Then
                    Waffe = "der M4"
                ElseIf WaffenID = 33 Then
                    Waffe = "der Coun Rfile"
                ElseIf WaffenID = 34 Then
                    Waffe = "der Sniper"
                ElseIf WaffenID = 35 Then
                    Waffe = "dem Raketenwerfer"
                ElseIf WaffenID = 42 Then
                    Waffe = "dem Feuerlöscher"
                Else
                    Waffe = "einer unbekannten Waffe"
                End If
            End If
        Catch
            Waffe = "WAFFE: UNBEKANNT"
        End Try

    End Sub

    Private Sub WaffenabgleichOT()
        Try
            If IsPlayerInAnyVehicle Then
                Waffe = "Fahrzeug"
            Else
                WaffenID = GetPlayerWeaponID
                If WaffenID = 0 Then
                    Waffe = "Faust"
                ElseIf WaffenID = 5 Then
                    Waffe = "Baseballschläger"
                ElseIf WaffenID = 24 Then
                    Waffe = "Deagle"
                ElseIf WaffenID = 29 Then
                    Waffe = "MP5"
                ElseIf WaffenID = 30 Then
                    Waffe = "AK47"
                ElseIf WaffenID = 41 Then
                    Waffe = "Spray"
                ElseIf WaffenID = 4 Then
                    Waffe = "Messer"
                ElseIf WaffenID = 8 Then
                    Waffe = "Katana"
                ElseIf WaffenID = 22 Then
                    Waffe = "9mm"
                ElseIf WaffenID = 23 Then
                    Waffe = "9mm (Schallgedämpft)"
                ElseIf WaffenID = 9 Then
                    Waffe = "der Kettensäge"
                ElseIf WaffenID = 3 Then
                    Waffe = "Schlagstock"
                ElseIf WaffenID = 25 Then
                    Waffe = "Shotgun"
                ElseIf WaffenID = 31 Then
                    Waffe = "M4"
                ElseIf WaffenID = 33 Then
                    Waffe = "Coun Rfile"
                ElseIf WaffenID = 34 Then
                    Waffe = "Sniper"
                ElseIf WaffenID = 35 Then
                    Waffe = "Raketenwerfer"
                ElseIf WaffenID = 42 Then
                    Waffe = "Feuerlöscher"
                Else
                    Waffe = "Unbekannte Waffe (id: " & WaffenID & ")"
                End If
            End If
        Catch
            Waffe = "FEHLER (id: " & WaffenID & ")"
        End Try

    End Sub

    Private Sub LogEintrag(ByVal Art As String)

        If Art = "Tot" Then
            'Datum/Uhrzeit
            'Ort

            'Gestorben am 11.03.15 um 15:15 Uhr am BSN.

            'My.Computer.FileSystem.WriteAllText("C:\Program Files (x86)\NNP\Log.Gaga", vbCrLf & "[Tod]  Nr. " & Tode.Text & " am " & Now.Date & " um " & TimeOfDay & " Uhr.", True)
            My.Computer.FileSystem.WriteAllText("C:\Program Files (x86)\NNP\Log.Gaga", vbCrLf & Now.Date & " - " & TimeOfDay & ": Tod nr. " & Tode.Text, True)
        End If
        If Art = "Kill" Then
            'Datum/Uhrzeit
            'Ort
            'Waffe
            'HP und Armour

            'Getötet am 11.03.15 um 16:10 Uhr am BSN mit der Deagle. Überlebt mit 98 hp und 54 Armour.

            Orte()
            Waffenabgleich()

            'My.Computer.FileSystem.WriteAllText("C:\Program Files (x86)\NNP\Log.Gaga", vbCrLf & "[Kill] Nr. " & Kills.Text & " am " & Now.Date & " um " & TimeOfDay & " Uhr " & Ort & " mit " & Waffe & " und mit " & GetPlayerHealth & " hp und " & GetPlayerArmour & " Armour.", True)
            My.Computer.FileSystem.WriteAllText("C:\Program Files (x86)\NNP\Log.Gaga", vbCrLf & Now.Date & " - " & TimeOfDay & ": Kill nr. " & Kills.Text & " " & Ort & " mit " & Waffe & " (" & GetPlayerHealth & " hp, " & GetPlayerArmour & " Armour)", True)
        End If


    End Sub

    Private Sub LogAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogAnzeigenToolStripMenuItem.Click

        KTL.Show()
        If Me.TopMost = True Then
            KTL.TopMost = True
        End If
        If System.IO.File.Exists("C:\Program Files (x86)\NNP\Log.Gaga") Then
            LEintrag = 0
            KTL.ListView1.Columns(0).Text = "Alle Einträge am dem " & System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\Log.Gaga")(0).Split(" ")(2) & ":"
            LEintragMax = System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\Log.Gaga").Length - 1
            Do While LEintrag < LEintragMax
                LEintrag = LEintrag + 1
                KTL.ListView1.Items.Insert(0, System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\Log.Gaga")(LEintrag))
                KTL.ListView1.Items(0).BackColor = If(System.IO.File.ReadAllLines("C:\Program Files (x86)\NNP\Log.Gaga")(LEintrag).Split(" ")(3) = "Tod", Color.Red, Color.Lime)
            Loop
        End If


    End Sub

    Sub WPOverlayZeugs()
        Try
            If Zeile1 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile0 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                GoTo Overlay
            End If
            If Zeile2 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile1.Split(" ")(1) & " " & Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile1.Split(" ")(3) & " " & Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile1.Split(" ")(5) & " " & Zeile1.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile1.Split(" ")(7) & " " & Zeile1.Split(" ")(8)
                Catch
                End Try
                Try
                    WP4 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP5 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP6 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP7 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile3 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile2.Split(" ")(1) & " " & Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile2.Split(" ")(3) & " " & Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile2.Split(" ")(5) & " " & Zeile2.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile2.Split(" ")(7) & " " & Zeile2.Split(" ")(8)
                Catch
                End Try
                Try
                    WP4 = Zeile1.Split(" ")(1) & " " & Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP5 = Zeile1.Split(" ")(3) & " " & Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP6 = Zeile1.Split(" ")(5) & " " & Zeile1.Split(" ")(6)
                Catch
                End Try
                Try
                    WP7 = Zeile1.Split(" ")(7) & " " & Zeile1.Split(" ")(8)
                Catch
                End Try
                Try
                    WP8 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP9 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP10 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP11 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile4 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile3.Split(" ")(1) & " " & Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile3.Split(" ")(3) & " " & Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile3.Split(" ")(5) & " " & Zeile3.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile3.Split(" ")(7) & " " & Zeile3.Split(" ")(8)
                Catch
                End Try
                Try
                    WP4 = Zeile2.Split(" ")(1) & " " & Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP5 = Zeile2.Split(" ")(3) & " " & Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP6 = Zeile2.Split(" ")(5) & " " & Zeile2.Split(" ")(6)
                Catch
                End Try
                Try
                    WP7 = Zeile2.Split(" ")(7) & " " & Zeile2.Split(" ")(8)
                Catch
                End Try
                Try
                    WP8 = Zeile1.Split(" ")(1) & " " & Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP9 = Zeile1.Split(" ")(3) & " " & Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP10 = Zeile1.Split(" ")(5) & " " & Zeile1.Split(" ")(6)
                Catch
                End Try
                Try
                    WP11 = Zeile1.Split(" ")(7) & " " & Zeile1.Split(" ")(8)
                Catch
                End Try
                Try
                    WP12 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP13 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP14 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP15 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile5 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile4.Split(" ")(1) & " " & Zeile4.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile4.Split(" ")(3) & " " & Zeile4.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile4.Split(" ")(5) & " " & Zeile4.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile4.Split(" ")(7) & " " & Zeile4.Split(" ")(8)
                Catch
                End Try
                Try
                    WP4 = Zeile3.Split(" ")(1) & " " & Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP5 = Zeile3.Split(" ")(3) & " " & Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP6 = Zeile3.Split(" ")(5) & " " & Zeile3.Split(" ")(6)
                Catch
                End Try
                Try
                    WP7 = Zeile3.Split(" ")(7) & " " & Zeile3.Split(" ")(8)
                Catch
                End Try
                Try
                    WP8 = Zeile2.Split(" ")(1) & " " & Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP9 = Zeile2.Split(" ")(3) & " " & Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP10 = Zeile2.Split(" ")(5) & " " & Zeile2.Split(" ")(6)
                Catch
                End Try
                Try
                    WP11 = Zeile2.Split(" ")(7) & " " & Zeile2.Split(" ")(8)
                Catch
                End Try
                Try
                    WP12 = Zeile1.Split(" ")(1) & " " & Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP13 = Zeile1.Split(" ")(3) & " " & Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP14 = Zeile1.Split(" ")(5) & " " & Zeile1.Split(" ")(6)
                Catch
                End Try
                Try
                    WP15 = Zeile1.Split(" ")(7) & " " & Zeile1.Split(" ")(8)
                Catch
                End Try
                Try
                    WP16 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP17 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP18 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP19 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile6 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile5.Split(" ")(1) & " " & Zeile5.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile5.Split(" ")(3) & " " & Zeile5.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile5.Split(" ")(5) & " " & Zeile5.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile5.Split(" ")(7) & " " & Zeile5.Split(" ")(8)
                Catch
                End Try
                Try
                    WP4 = Zeile4.Split(" ")(1) & " " & Zeile4.Split(" ")(2)
                Catch
                End Try
                Try
                    WP5 = Zeile4.Split(" ")(3) & " " & Zeile4.Split(" ")(4)
                Catch
                End Try
                Try
                    WP6 = Zeile4.Split(" ")(5) & " " & Zeile4.Split(" ")(6)
                Catch
                End Try
                Try
                    WP7 = Zeile4.Split(" ")(7) & " " & Zeile4.Split(" ")(8)
                Catch
                End Try
                Try
                    WP8 = Zeile3.Split(" ")(1) & " " & Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP9 = Zeile3.Split(" ")(3) & " " & Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP10 = Zeile3.Split(" ")(5) & " " & Zeile3.Split(" ")(6)
                Catch
                End Try
                Try
                    WP11 = Zeile3.Split(" ")(7) & " " & Zeile3.Split(" ")(8)
                Catch
                End Try
                Try
                    WP12 = Zeile2.Split(" ")(1) & " " & Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP13 = Zeile2.Split(" ")(3) & " " & Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP14 = Zeile2.Split(" ")(5) & " " & Zeile2.Split(" ")(6)
                Catch
                End Try
                Try
                    WP15 = Zeile2.Split(" ")(7) & " " & Zeile2.Split(" ")(8)
                Catch
                End Try
                Try
                    WP16 = Zeile1.Split(" ")(1) & " " & Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP17 = Zeile1.Split(" ")(3) & " " & Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP18 = Zeile1.Split(" ")(5) & " " & Zeile1.Split(" ")(6)
                Catch
                End Try
                Try
                    WP19 = Zeile1.Split(" ")(7) & " " & Zeile1.Split(" ")(8)
                Catch
                End Try
                Try
                    WP20 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP21 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP22 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP23 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
            End If
            If Zeile7 = "[" & TimeOfDay & "] Alle gesuchten Personen:" Then
                WP0 = "Keine Verbrecher online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile6.Split(" ")(1) & " " & Zeile6.Split(" ")(2)
                Catch
                End Try
                Try
                    WP1 = Zeile6.Split(" ")(3) & " " & Zeile6.Split(" ")(4)
                Catch
                End Try
                Try
                    WP2 = Zeile6.Split(" ")(5) & " " & Zeile6.Split(" ")(6)
                Catch
                End Try
                Try
                    WP3 = Zeile6.Split(" ")(7) & " " & Zeile6.Split(" ")(8)
                Catch
                End Try
                Try
                    WP4 = Zeile5.Split(" ")(5) & " " & Zeile5.Split(" ")(2)
                Catch
                End Try
                Try
                    WP5 = Zeile5.Split(" ")(3) & " " & Zeile5.Split(" ")(4)
                Catch
                End Try
                Try
                    WP6 = Zeile5.Split(" ")(5) & " " & Zeile5.Split(" ")(6)
                Catch
                End Try
                Try
                    WP7 = Zeile5.Split(" ")(7) & " " & Zeile5.Split(" ")(8)
                Catch
                End Try
                Try
                    WP8 = Zeile4.Split(" ")(1) & " " & Zeile4.Split(" ")(2)
                Catch
                End Try
                Try
                    WP9 = Zeile4.Split(" ")(3) & " " & Zeile4.Split(" ")(4)
                Catch
                End Try
                Try
                    WP10 = Zeile4.Split(" ")(5) & " " & Zeile4.Split(" ")(6)
                Catch
                End Try
                Try
                    WP11 = Zeile4.Split(" ")(7) & " " & Zeile4.Split(" ")(8)
                Catch
                End Try
                Try
                    WP12 = Zeile3.Split(" ")(1) & " " & Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP13 = Zeile3.Split(" ")(3) & " " & Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP14 = Zeile3.Split(" ")(5) & " " & Zeile3.Split(" ")(6)
                Catch
                End Try
                Try
                    WP15 = Zeile3.Split(" ")(7) & " " & Zeile3.Split(" ")(8)
                Catch
                End Try
                Try
                    WP16 = Zeile2.Split(" ")(1) & " " & Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP17 = Zeile2.Split(" ")(3) & " " & Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP18 = Zeile2.Split(" ")(5) & " " & Zeile2.Split(" ")(6)
                Catch
                End Try
                Try
                    WP19 = Zeile2.Split(" ")(7) & " " & Zeile2.Split(" ")(8)
                Catch
                End Try
                Try
                    WP20 = Zeile1.Split(" ")(1) & " " & Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP21 = Zeile1.Split(" ")(3) & " " & Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP22 = Zeile1.Split(" ")(5) & " " & Zeile1.Split(" ")(6)
                Catch
                End Try
                Try
                    WP23 = Zeile1.Split(" ")(7) & " " & Zeile1.Split(" ")(8)
                Catch
                End Try
                Try
                    WP24 = Zeile0.Split(" ")(1) & " " & Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP25 = Zeile0.Split(" ")(3) & " " & Zeile0.Split(" ")(4)
                Catch
                End Try
                Try
                    WP26 = Zeile0.Split(" ")(5) & " " & Zeile0.Split(" ")(6)
                Catch
                End Try
                Try
                    WP27 = Zeile0.Split(" ")(7) & " " & Zeile0.Split(" ")(8)
                Catch
                End Try
                GoTo Overlay
            End If

            'BLOverlay
            If Zeile0 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                GoTo Overlay
            End If
            If Zeile1 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile0.Split(" ")(4)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile2 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile1.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile1.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP4 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP5 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP6 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP7 = Zeile0.Split(" ")(4)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile3 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile2.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile2.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP4 = Zeile1.Split(" ")(1)
                Catch
                End Try
                Try
                    WP5 = Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP6 = Zeile1.Split(" ")(3)
                Catch
                End Try
                Try
                    WP7 = Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP8 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP9 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP10 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP11 = Zeile0.Split(" ")(4)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile4 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile3.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile3.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP4 = Zeile2.Split(" ")(1)
                Catch
                End Try
                Try
                    WP5 = Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP6 = Zeile2.Split(" ")(3)
                Catch
                End Try
                Try
                    WP7 = Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP8 = Zeile1.Split(" ")(1)
                Catch
                End Try
                Try
                    WP9 = Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP10 = Zeile1.Split(" ")(3)
                Catch
                End Try
                Try
                    WP11 = Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP12 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP13 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP14 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP15 = Zeile0.Split(" ")(4)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile5 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile4.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile4.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile4.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile4.Split(" ")(4)
                Catch
                End Try
                Try
                    WP4 = Zeile3.Split(" ")(1)
                Catch
                End Try
                Try
                    WP5 = Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP6 = Zeile3.Split(" ")(3)
                Catch
                End Try
                Try
                    WP7 = Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP8 = Zeile2.Split(" ")(1)
                Catch
                End Try
                Try
                    WP9 = Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP10 = Zeile2.Split(" ")(3)
                Catch
                End Try
                Try
                    WP11 = Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP12 = Zeile1.Split(" ")(1)
                Catch
                End Try
                Try
                    WP13 = Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP14 = Zeile1.Split(" ")(3)
                Catch
                End Try
                Try
                    WP15 = Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP16 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP17 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP18 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP19 = Zeile0.Split(" ")(4)
                Catch
                End Try
                GoTo Overlay
            End If
            If Zeile6 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile5.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile5.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile5.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile5.Split(" ")(4)
                Catch
                End Try
                Try
                    WP4 = Zeile4.Split(" ")(1)
                Catch
                End Try
                Try
                    WP5 = Zeile4.Split(" ")(2)
                Catch
                End Try
                Try
                    WP6 = Zeile4.Split(" ")(3)
                Catch
                End Try
                Try
                    WP7 = Zeile4.Split(" ")(4)
                Catch
                End Try
                Try
                    WP8 = Zeile3.Split(" ")(1)
                Catch
                End Try
                Try
                    WP9 = Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP10 = Zeile3.Split(" ")(3)
                Catch
                End Try
                Try
                    WP11 = Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP12 = Zeile2.Split(" ")(1)
                Catch
                End Try
                Try
                    WP13 = Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP14 = Zeile2.Split(" ")(3)
                Catch
                End Try
                Try
                    WP15 = Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP16 = Zeile1.Split(" ")(1)
                Catch
                End Try
                Try
                    WP17 = Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP18 = Zeile1.Split(" ")(3)
                Catch
                End Try
                Try
                    WP19 = Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP20 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP21 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP22 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP23 = Zeile0.Split(" ")(4)
                Catch
                End Try

            End If
            If Zeile7 = "[" & TimeOfDay & "] Blacklist Spieler Online:" Then
                WP0 = "Keine Blacklistspieler online."
                WP1 = ""
                WP2 = ""
                WP3 = ""
                WP4 = ""
                WP5 = ""
                WP6 = ""
                WP7 = ""
                WP8 = ""
                WP9 = ""
                WP10 = ""
                WP11 = ""
                WP12 = ""
                WP13 = ""
                WP14 = ""
                WP15 = ""
                WP16 = ""
                WP17 = ""
                WP18 = ""
                WP19 = ""
                WP20 = ""
                WP21 = ""
                WP22 = ""
                WP23 = ""
                WP24 = ""
                WP25 = ""
                WP26 = ""
                WP27 = ""
                Try
                    WP0 = Zeile6.Split(" ")(1)
                Catch
                End Try
                Try
                    WP1 = Zeile6.Split(" ")(2)
                Catch
                End Try
                Try
                    WP2 = Zeile6.Split(" ")(3)
                Catch
                End Try
                Try
                    WP3 = Zeile6.Split(" ")(4)
                Catch
                End Try
                Try
                    WP4 = Zeile5.Split(" ")(1)
                Catch
                End Try
                Try
                    WP5 = Zeile5.Split(" ")(2)
                Catch
                End Try
                Try
                    WP6 = Zeile5.Split(" ")(3)
                Catch
                End Try
                Try
                    WP7 = Zeile5.Split(" ")(4)
                Catch
                End Try
                Try
                    WP8 = Zeile4.Split(" ")(1)
                Catch
                End Try
                Try
                    WP9 = Zeile4.Split(" ")(2)
                Catch
                End Try
                Try
                    WP10 = Zeile4.Split(" ")(3)
                Catch
                End Try
                Try
                    WP11 = Zeile4.Split(" ")(4)
                Catch
                End Try
                Try
                    WP12 = Zeile3.Split(" ")(1)
                Catch
                End Try
                Try
                    WP13 = Zeile3.Split(" ")(2)
                Catch
                End Try
                Try
                    WP14 = Zeile3.Split(" ")(3)
                Catch
                End Try
                Try
                    WP15 = Zeile3.Split(" ")(4)
                Catch
                End Try
                Try
                    WP16 = Zeile2.Split(" ")(1)
                Catch
                End Try
                Try
                    WP17 = Zeile2.Split(" ")(2)
                Catch
                End Try
                Try
                    WP18 = Zeile2.Split(" ")(3)
                Catch
                End Try
                Try
                    WP19 = Zeile2.Split(" ")(4)
                Catch
                End Try
                Try
                    WP20 = Zeile1.Split(" ")(1)
                Catch
                End Try
                Try
                    WP21 = Zeile1.Split(" ")(2)
                Catch
                End Try
                Try
                    WP22 = Zeile1.Split(" ")(3)
                Catch
                End Try
                Try
                    WP23 = Zeile1.Split(" ")(4)
                Catch
                End Try
                Try
                    WP24 = Zeile0.Split(" ")(1)
                Catch
                End Try
                Try
                    WP25 = Zeile0.Split(" ")(2)
                Catch
                End Try
                Try
                    WP26 = Zeile0.Split(" ")(3)
                Catch
                End Try
                Try
                    WP27 = Zeile0.Split(" ")(4)
                Catch
                End Try
                GoTo Overlay
            End If

            GoTo OverlayWeiter
Overlay:
            'Replace
            WP0 = WP0.ToString.Replace(",", "")
            WP1 = WP1.ToString.Replace(",", "")
            WP2 = WP2.ToString.Replace(",", "")
            WP3 = WP3.ToString.Replace(",", "")
            WP4 = WP4.ToString.Replace(",", "")
            WP5 = WP5.ToString.Replace(",", "")
            WP6 = WP6.ToString.Replace(",", "")
            WP7 = WP7.ToString.Replace(",", "")
            WP8 = WP8.ToString.Replace(",", "")
            WP9 = WP9.ToString.Replace(",", "")
            WP10 = WP10.ToString.Replace(",", "")
            WP11 = WP11.ToString.Replace(",", "")
            WP12 = WP12.ToString.Replace(",", "")
            WP13 = WP13.ToString.Replace(",", "")
            WP14 = WP14.ToString.Replace(",", "")
            WP15 = WP15.ToString.Replace(",", "")
            WP16 = WP16.ToString.Replace(",", "")
            WP17 = WP17.ToString.Replace(",", "")
            WP18 = WP18.ToString.Replace(",", "")
            WP19 = WP19.ToString.Replace(",", "")
            WP20 = WP20.ToString.Replace(",", "")
            WP21 = WP21.ToString.Replace(",", "")
            WP22 = WP22.ToString.Replace(",", "")
            WP23 = WP23.ToString.Replace(",", "")
            WP24 = WP24.ToString.Replace(",", "")
            WP25 = WP25.ToString.Replace(",", "")
            WP26 = WP26.ToString.Replace(",", "")
            WP27 = WP27.ToString.Replace(",", "")

            WP0 = WP0.ToString.Replace(".", " ")
            WP1 = WP1.ToString.Replace(".", " ")
            WP2 = WP2.ToString.Replace(".", " ")
            WP3 = WP3.ToString.Replace(".", " ")
            WP4 = WP4.ToString.Replace(".", " ")
            WP5 = WP5.ToString.Replace(".", " ")
            WP6 = WP6.ToString.Replace(".", " ")
            WP7 = WP7.ToString.Replace(".", " ")
            WP8 = WP8.ToString.Replace(".", " ")
            WP9 = WP9.ToString.Replace(".", " ")
            WP10 = WP10.ToString.Replace(".", " ")
            WP11 = WP11.ToString.Replace(".", " ")
            WP12 = WP12.ToString.Replace(".", " ")
            WP13 = WP13.ToString.Replace(".", " ")
            WP14 = WP14.ToString.Replace(".", " ")
            WP15 = WP15.ToString.Replace(".", " ")
            WP16 = WP16.ToString.Replace(".", " ")
            WP17 = WP17.ToString.Replace(".", " ")
            WP18 = WP18.ToString.Replace(".", " ")
            WP19 = WP19.ToString.Replace(".", " ")
            WP20 = WP20.ToString.Replace(".", " ")
            WP21 = WP21.ToString.Replace(".", " ")
            WP22 = WP22.ToString.Replace(".", " ")
            WP23 = WP23.ToString.Replace(".", " ")
            WP24 = WP24.ToString.Replace(".", " ")
            WP25 = WP25.ToString.Replace(".", " ")
            WP26 = WP26.ToString.Replace(".", " ")
            WP27 = WP27.ToString.Replace(".", " ")

            WP0 = WP0.ToString.Replace(":", " -")
            WP1 = WP1.ToString.Replace(":", " -")
            WP2 = WP2.ToString.Replace(":", " -")
            WP3 = WP3.ToString.Replace(":", " -")
            WP4 = WP4.ToString.Replace(":", " -")
            WP5 = WP5.ToString.Replace(":", " -")
            WP6 = WP6.ToString.Replace(":", " -")
            WP7 = WP7.ToString.Replace(":", " -")
            WP8 = WP8.ToString.Replace(":", " -")
            WP9 = WP9.ToString.Replace(":", " -")
            WP10 = WP10.ToString.Replace(":", " -")
            WP11 = WP11.ToString.Replace(":", " -")
            WP12 = WP12.ToString.Replace(":", " -")
            WP13 = WP13.ToString.Replace(":", " -")
            WP14 = WP14.ToString.Replace(":", " -")
            WP15 = WP15.ToString.Replace(":", " -")
            WP16 = WP16.ToString.Replace(":", " -")
            WP17 = WP17.ToString.Replace(":", " -")
            WP18 = WP18.ToString.Replace(":", " -")
            WP19 = WP19.ToString.Replace(":", " -")
            WP20 = WP20.ToString.Replace(":", " -")
            WP21 = WP21.ToString.Replace(":", " -")
            WP22 = WP22.ToString.Replace(":", " -")
            WP23 = WP23.ToString.Replace(":", " -")
            WP24 = WP24.ToString.Replace(":", " -")
            WP25 = WP25.ToString.Replace(":", " -")
            WP26 = WP26.ToString.Replace(":", " -")
            WP27 = WP27.ToString.Replace(":", " -")

            WPOverlaySortieren()


            'Overlay(ausgabe)
            OverlayStatus = 1
            DestroyAllVisual()
            AddChatMessage("{0033FF}NNP Info - {FFFFFF}schreibe '/echo GPStatus' um den Status der Gesuchten Personen zu sehen.")
            'SetParam("use_window", "1")
            'SetParam("window", "GTA:SA:MP")
            OverlayErstellen()
            System.Threading.Thread.Sleep("1000")
OverlayWeiter:
        Catch
            AddChatMessage("{FF3333}Fehler!{FFFFFF} Es scheint ein Fehler aufgetreten zu sein. Versuchs nochmal!")
            System.Threading.Thread.Sleep("1000")
        End Try
    End Sub

    Private Sub VersionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionToolStripMenuItem.Click
        MsgBox("Du nutzt die Version: " & Version.Text, MsgBoxStyle.Information, "NNP Version")
    End Sub

    Private Sub NNPChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NNPChatToolStripMenuItem.Click
        MsgBox("Der Chat und alle andere Funktionen welche Zugriff auf die Webseite benötigt haben sind mit der deaktivierung der Webseite nicht mehr Verfügbar!", MsgBoxStyle.Critical, "Nicht Verfügbar!")
    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If Einstellungen.ChatAktiv.Checked = True Or Einstellungen.ChatEnde = 1 Then
        'ChatOnline.Document.GetElementById("NameA").InnerText = CSC
        'ChatOnline.Document.GetElementById("ButtonA").InvokeMember("click")
        'System.Threading.Thread.Sleep("500")
        'End If
        End
    End Sub

    Private Sub GTAVersionPrüfenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GTAVersionPrüfenToolStripMenuItem.Click
        If System.IO.File.Exists(Einstellungen.GTAPfad.Text & "\samp.dll") Then
            Dim SAMPVersion As New System.IO.FileInfo(Einstellungen.GTAPfad.Text & "\samp.dll")
            If SAMPVersion.Length = "2199552" Then
                MsgBox("Deine SAMP Version ist mit der API kompatiebel!", MsgBoxStyle.Information, "Erfolgreich!")
            Else
                MsgBox("Deine SAMP Version ist nicht mit der API kompatiebel!", MsgBoxStyle.Critical, "Fehler!")
                If (MsgBox("Möchtest du die passende SAMP Version Downloaden", MsgBoxStyle.YesNo, "SAMP Version Fehler!") = MsgBoxResult.Yes) Then
                    Status.Text = "Wärend dem Download hängt das Programm. Schließe es nicht!"
                    MsgBox("Der Download der SAMP Version 0.3.7 wird gestartet." & vbCrLf & "Das Programm wird aussehen als würde es sich aufhängen." & vbCrLf & "Schließe es nicht um Fehler zu vermeiden!" & vbCrLf & "Nach dem Download geht es weiter! Dieser könnte ein paar Sekunden dauern!", MsgBoxStyle.Information, "Download startet")
                    My.Computer.Network.DownloadFile("http://files.sa-mp.com/sa-mp-0.3.7-install.exe", "C:\Program Files (x86)\NNP\SAMP.exe")
                    MsgBox("Der Download wurde abgeschlossen!" & vbCrLf & "Sollte bei der Installation eine Fehlermeldung auftreten, mache bitte folgendes:" & vbCrLf & "•Melde dich von deinem Computer ab oder starte ihn neu." & vbCrLf & "•Nach dem erneuten Anmelden starte NICHT GTA!!!" & vbCrLf & "•Starte dieses Programm erneut und führe die SAMP Installation aus.", MsgBoxStyle.Information, "Hinweiß")
                    Process.Start("C:\Program Files (x86)\NNP\SAMP.exe")
                    Status.Text = "Die SAMP Version (0.3.7) wurde gedownloadet und gestartet."
                End If
            End If
        Else
            MsgBox("Das Programm konnte die SAMP Version nicht ermitteln!", MsgBoxStyle.Critical, "Fehler!")
            Einstellungen.Show()
            Einstellungen.TP.Start()
            GTAVersionPrüfenToolStripMenuItem.PerformClick()
Keinpfad:
        End If
    End Sub

    Private Sub CodeEinsehenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeEinsehenToolStripMenuItem.Click
        Process.Start("https://github.com/GagaMichi/NoName-Produkt")
    End Sub

    Private Sub VorschlagToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://nnp.gagamichi.com/Vorschlaege.php")
    End Sub

    Private Sub FunktionenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://nnp.gagamichi.com/Funktionen.php")
    End Sub

    Private Sub MaskenTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskenTimer.Tick
        MaskenZeit -= 1
        TB2.Text = "Du bist noch " & MaskenZeit & " sekunden Maskiert."
        If MaskenZeit <= 0 Then
            AddChatMessage("{FF0000}Achtung! {FFFFFF} Deine Maske läuft {FF0000}jetzt {FFFFFF}(also {FF0000}gleich{FFFFFF})ab!")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            MaskenTimer.Stop()
            TB1.Text = ""
            TB2.Text = ""
        End If
        If MaskenZeit = 60 Then
            AddChatMessage("{FF0000}Achtung! {FFFFFF} Deine Maske läuft in {FF0000}1 Minute {FFFFFF}ab!")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If MaskenZeit = 120 Then
            AddChatMessage("{FF0000}Achtung! {FFFFFF} Deine Maske läuft in {FF0000}2 Minuten {FFFFFF}ab!")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If MaskenZeit = 10 Then
            AddChatMessage("{FF0000}Achtung! {FFFFFF} Deine Maske läuft in {FF0000}10 Sekunden {FFFFFF}ab!")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
        If MaskenZeit < 60 Then
            ShowGameText("~n~~n~~n~~n~~n~~n~~n~~n~~n~~n~~w~Du bist noch ~b~" & MaskenZeit & " ~w~ sekunden Maskiert!", 1000, 3)
        End If
    End Sub

    Private Sub TruckingTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TruckingTimer.Tick
        If TruckingTimerSek >= 0 Then
            TruckingTimerSek -= 1
            ShowGameText("~n~~n~~n~~n~~n~~n~~n~~n~~n~~w~Deine Trucking-wartezeit: ca. ~n~~y~" & TruckingTimerSek & " ~w~ sekunden.", 1000, 3)
        Else
            TruckingTimer.Stop()
        End If

    End Sub

    Private Sub WPOverlaySortieren()
        WPOverlaySortierer.Clear()

        WPOverlaySortierSchritt = 0
        Try
            WPOverlaySortierer.Items.Add(WP0.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP0)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP1.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP1)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP2.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP2)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP3.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP3)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP4.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP4)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP5.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP5)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP6.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP6)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP7.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP7)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP8.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP8)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP9.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP9)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP10.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP10)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP11.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP11)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP12.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP12)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP13.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP13)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP14.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP14)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP15.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP15)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP16.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP16)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP17.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP17)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP18.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP18)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP19.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP19)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP20.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP20)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP21.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP21)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP22.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP22)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP23.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP23)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP24.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP24)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP25.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP25)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP26.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP26)
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WPOverlaySortierer.Items.Add(WP27.Split(" ")(2))
            WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems.Add(WP27)
        Catch
        End Try

        WPOverlaySortierer.Sorting = SortOrder.Descending


        WPOverlaySortierSchritt = 0

        Try
            WP0 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP1 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP2 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP3 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP4 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP5 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP6 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP7 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP8 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP9 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP10 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP11 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP12 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP13 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP14 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP15 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP16 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP17 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP18 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP19 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP20 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP21 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP22 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP23 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP24 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP25 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP26 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try
        Try
            WP27 = WPOverlaySortierer.Items(WPOverlaySortierSchritt).SubItems(1).Text
            WPOverlaySortierSchritt += 1
        Catch
        End Try




    End Sub

    Private Sub OverlayErstellen()
        If IsNumeric(Einstellungen.OL.Text) Then
            TextCreate("Arial", Einstellungen.OL.Text, False, False, Einstellungen.OLPX.Text, Einstellungen.OLPY.Text, &HFF00FF, "{FFFFFF{FF3333}Gesuchte Personen:{00E533}" & vbCrLf & WP0 & vbCrLf & WP1 & vbCrLf & WP2 & vbCrLf & WP3 & vbCrLf & WP4 & vbCrLf & WP5 & vbCrLf & WP6 & vbCrLf & WP7 & vbCrLf & WP8 & vbCrLf & WP9 & vbCrLf & WP10 & vbCrLf & WP11 & vbCrLf & WP12 & vbCrLf & WP13 & vbCrLf & WP14 & vbCrLf & WP15 & vbCrLf & WP16 & vbCrLf & WP17 & vbCrLf & WP18 & vbCrLf & WP19 & vbCrLf & WP20 & vbCrLf & WP21 & vbCrLf & WP22 & vbCrLf & WP23 & vbCrLf & WP24 & vbCrLf & WP25 & vbCrLf & WP26 & vbCrLf & WP27, True, True)
        End If
    End Sub

    Private Sub DirektMitNovaVerbindenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirektMitNovaVerbindenToolStripMenuItem.Click
        Try
            Process.Start(Einstellungen.GTAPfad.Text & "\samp.exe", "178.32.129.176:7777")
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Bitte gib deinen GTA Ordner an.", 0, "Fehler!")

            Einstellungen.Show()
            Einstellungen.Size = New Size(808, 240)
            Einstellungen.TP.Start()
            Einstellungen.Button5.PerformClick()
        End Try
    End Sub

    Private Sub Status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status.Click
        If Status.Text = "Login" Then
            Abspielen = False
            Abspieler.Url = New Uri("http://www.google.de")
            Status.Text = "Frei/lebend"
            Status.BackColor = Color.Green
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        End
    End Sub

    Private Sub ZeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHide.Click
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub WebseiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebseiteToolStripMenuItem.Click
        Process.Start("http://www.nnp.gagamichi.com")
    End Sub

    Private Sub NeuStartenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuStartenToolStripMenuItem1.Click
        NeustartenToolStripMenuItem_Click(sender, e)
    End Sub


    Private Sub EinstellungenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem1.Click
        If Me.TopMost = True Then
            Einstellungen.TopMost = True
        End If
        Einstellungen.Show()
        Einstellungen.Size = New Size(808, 5)
        Einstellungen.Start.Start()
        Einstellungen.TKN.BorderStyle = BorderStyle.Fixed3D
        Einstellungen.TPF.BorderStyle = BorderStyle.None
        Einstellungen.TID.BorderStyle = BorderStyle.None
        Einstellungen.TDE.BorderStyle = BorderStyle.None
        Einstellungen.TSo.BorderStyle = BorderStyle.None
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        Try
            Process.Start(Einstellungen.GTAPfad.Text & "\samp.exe", "178.32.129.176:7777")
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Bitte gib deinen GTA Ordner an.", 0, "Fehler!")

            Einstellungen.Show()
            Einstellungen.Size = New Size(808, 240)
            Einstellungen.TP.Start()
            Einstellungen.Button5.PerformClick()
        End Try
    End Sub

    Private Sub InTaskbarZeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InTaskbarZeigenToolStripMenuItem.Click
        Me.ShowInTaskbar = True
    End Sub

    Private Sub Notify_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notify.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
            Me.TopMost = True
            Me.TopMost = False
        End If
    End Sub

    Private Sub AnkunftTimer() Handles Atimer.Tick
        Try
            aXa = aX
            aYa = aY
            aGa4 = aGa3
            aGa3 = aGa2
            aGa2 = aGa
            aGa = aG
            aDa = aD
            GetPlayerPos(aX, aY, Z)
            aD = Math.Sqrt(((aX - aXz) ^ 2) + ((aY - aYz) ^ 2))
            aGd = (aGa + aGa2 + aGa3 + aGa4 + aG) / 5
            aG = Math.Sqrt(((aX - aXa) ^ 2) + ((aY - aYa) ^ 2))
            aT = aD / aGd
            If aDa > aD Then
                If aT > 300 Then
                    ShowGameText("~n~~n~~n~~n~~n~~n~~n~~y~Du braucht zu lange!~n~~r~BEWEG DICH!", 1000, 3)
                ElseIf aT < 7 Then
                    ShowGameText("~n~~n~~n~~n~~n~~n~~n~~r~Du bist fast da!", 3000, 3)
                    Atimer.Stop()
                Else
                    ShowGameText("~n~~n~~n~~n~~n~~n~~n~~y~Ankunft in ca. ~r~" & aT & " ~y~sekunden", 1000, 3)
                End If
            Else
                ShowGameText("~n~~n~~n~~n~~n~~n~~n~~y~FEHLER!~n~~r~Falsche richtung!", 1000, 3)
            End If
        Catch
            ShowGameText("~n~~n~~n~~n~~n~~n~~n~~y~FEHLER!(" & aT & ")~n~~r~BEWEG DICH!", 1000, 3)
        End Try
    End Sub

    Private Sub CheckATz(ByVal i As Integer)

        GetPlayerPos(aX, aY, Z)
        aXz = azXorte(i)
        aYz = azYorte(i)
        aG = 1
        aGa = 1
        aGa2 = 1
        aGa3 = 1
        aGa4 = 1
        AddChatMessage("{FF0000}Beachte:{FFFFFF} das System funktioniert derzeit nur bei {00E533}gleichbleibender Geschwindigkeit{FFFFFF}")
        AddChatMessage("und auf {00e533}direktem Weg {FFFFFF}zum Ziel exakt (z.B.: in einem Fluggerät)! {FF0000}Bugs treten auch auf!")
        AddChatMessage("Fehlerhafte Orte oder Vorschläge für weitere Orte bitte mir im Forum schreiben. (Orte Außerhalb LS sind in arbeit!")
        AddChatMessage("Berechne ungefähre Ankunftszeit zu {FF0000}" & azNorte(i) & "{FFFFFF}, Distanz: {00E533}" & Math.Round(Math.Sqrt(((aX - aXz) ^ 2) + ((aY - aYz) ^ 2)), 0) & "m{FFFFFF}.")
        Atimer.Start()
    End Sub
End Class


