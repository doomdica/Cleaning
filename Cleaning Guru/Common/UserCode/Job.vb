
Namespace LightSwitchApplication

    Public Class Job

        Private Sub StartTime_Changed()
            EndTime = StartTime.AddHours(1.0)
            Recurance = "N"
        End Sub

        Private Sub Client_Changed()
            QueryString = Client.Address1 + ", " + Client.City + ", " + Client.Postcode + ", " + Client.Region
        End Sub

    End Class

End Namespace
