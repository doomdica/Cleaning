
Namespace LightSwitchApplication

    Public Class JobDetail

        Private Sub Job_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Job)
        End Sub

        Private Sub Job_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Job)
        End Sub

        Private Sub JobDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Job)
        End Sub

    End Class

End Namespace