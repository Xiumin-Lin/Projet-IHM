Public Class FormBilan
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonShowCand_Click(sender As Object, e As EventArgs) Handles ButtonShowCand.Click
        FormRecap.Show()
    End Sub

    Private Sub ButtonCloseApp_Click(sender As Object, e As EventArgs) Handles ButtonCloseApp.Click
        Me.Close()
        FormAccueil.Close()
    End Sub

    Private Sub ButtonShowMatiere_Click(sender As Object, e As EventArgs) Handles ButtonShowMatiere.Click
        FormBilanMatiere.Show()
    End Sub
End Class