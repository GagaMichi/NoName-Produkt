Public Class NNPUpdate
    Private Sub Design()
        Me.Width = Status.Width + 24
        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width / 2) - (Me.Width / 2), Me.Location.Y)
    End Sub

    Private Sub NNPUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Design()
        If Not My.Computer.Network.Ping("http://google.de") Then
            MsgBox("Es besteht keine Verbindung zum Internet!" & vbCrLf & "Das NNP Update kann nicht heruntergeladen werden!", MsgBoxStyle.Critical, "Download Fehler!")
            End
        End If
    End Sub

    Private Sub UpdateS() Handles Ver.DocumentCompleted
        If System.IO.File.Exists(".\Noname Produkt.exe") Then
            System.IO.File.Delete(".\Noname Produkt.exe")
        End If
        My.Computer.Network.DownloadFile("http://nnp.gagamichi.com/Download/Update/Noname Produkt.exe", ".\Noname Produkt.exe")
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Status.Text = "Download erfolgreich!"
        Design()
        Process.Start(".\Noname Produkt.exe")
        End
    End Sub
End Class

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MsgBox("Das NNP Update kann nicht heruntergeladen werden!" & vbCrLf & "Versuche es über den Browser!" & vbCrLf & "Fehler:" & vbCrLf & e.Exception.ToString, MsgBoxStyle.Critical, "Download Fehler!")
            Process.Start("http://nnp.gagamichi.com/Download.php")
            End
        End Sub

    End Class

End Namespace

