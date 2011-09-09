
Namespace LightSwitchApplication

    Public Class CreateNewJob

        Private Sub CreateNewJob_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.JobProperty = New Job()

        End Sub

        Private Sub CreateNewJob_Saved()
            ' Write your code here.

            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.JobProperty)
        End Sub

        Private Sub CreateNewJob_Saving(ByRef handled As Boolean)
            ' Write your code here.
            If Not JobProperty.Recurance = "N" Then

                If JobProperty.Recurance = "W" Then
                    For i As Integer = 0 To 11

                        Dim weekly As Job
                        weekly = Me.DataWorkspace.ApplicationData.Jobs.AddNew()
                        weekly.Recurance = Me.JobProperty.Recurance
                        weekly.IsDeleted = JobProperty.IsDeleted
                        weekly.Note = JobProperty.Note
                        weekly.StartTime = JobProperty.StartTime.AddDays(7.0)
                        weekly.EndTime = JobProperty.EndTime.AddDays(7.0)
                        weekly.Price = JobProperty.Price
                        weekly.QueryString = JobProperty.QueryString
                        weekly.Client = JobProperty.Client
                        weekly.Cleaner = JobProperty.Cleaner
                        i = i + 1
                    Next
                    Me.DataWorkspace.ApplicationData.SaveChanges()


                ElseIf JobProperty.Recurance = "M" Then


                End If
            End If
        End Sub
    End Class

End Namespace