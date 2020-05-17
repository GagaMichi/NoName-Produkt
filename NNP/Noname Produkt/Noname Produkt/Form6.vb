Public Class FAQ

    Private Sub TextBox5_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("http://www.nnp.gaga.bplaced.net/index.php")
    End Sub

    Private Sub TextBox9_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("http://dracoblue.net/download-release/samp-client-0.3z R1/sa-mp-0.3z-R1-install.exe")
    End Sub

    Private Sub TextBox3_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.nnp.gaga.bplaced.net/Hilfe.php")
    End Sub

    Private Sub Größe_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Größe.Tick
        FAQBox.Size = New Point(Me.Width - 40, Me.Height - 62)
    End Sub
End Class