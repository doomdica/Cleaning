
Namespace LightSwitchApplication

    Public Class CleanerDetail

        Private Sub Cleaner_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Cleaner)
        End Sub

        Private Sub Cleaner_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Cleaner)
        End Sub

        Private Sub CleanerDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Cleaner)
        End Sub

    End Class

End Namespace