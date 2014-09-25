Public Class Form1

    Private Sub btnCross_Click(sender As Object, e As EventArgs) Handles btnCross.Click

        Dim strSecretName As String = "Jeremy"
        Dim strNameGuess As String = Me.txtName.Text
        Dim strSecretQuest As String = "Seek the Grail"
        Dim strQuestGuess As String = Me.txtQuest.Text
        Dim strSecretColor As String = "Black"
        Dim strColorGuess As String = Me.txtColor.Text

        If strNameGuess = strSecretName And strQuestGuess = strSecretQuest And strColorGuess = strSecretColor Then
            Me.lblFate.Text = "You may pass!"
        Else
            Me.lblFate.Text = "Die!"
        End If
    End Sub
End Class
