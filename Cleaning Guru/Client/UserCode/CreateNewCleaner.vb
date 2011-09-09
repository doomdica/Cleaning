
Namespace LightSwitchApplication

    Public Class CreateNewCleaner

        Private Sub CreateNewCleaner_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.CleanerProperty = New Cleaner()
        End Sub

        Private Sub CreateNewCleaner_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.CleanerProperty)
        End Sub

    End Class

End Namespace