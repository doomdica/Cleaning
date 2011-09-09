
Namespace LightSwitchApplication

    Public Class CreateNewClient

        Private Sub CreateNewClient_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.ClientProperty = New Client()
        End Sub

        Private Sub CreateNewClient_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.ClientProperty)
        End Sub

    End Class

End Namespace