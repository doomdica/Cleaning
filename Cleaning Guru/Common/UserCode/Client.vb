
Namespace LightSwitchApplication

    Public Class Client

        Private Sub Region_Changed()
            QueryString = Address1 + ", " + City + ", " + Postcode + ", " + Region
        End Sub



        Private Sub City_Changed()
            Region = "UK"
        End Sub
    End Class

End Namespace
