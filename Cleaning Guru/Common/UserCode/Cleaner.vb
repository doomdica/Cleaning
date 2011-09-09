
Namespace LightSwitchApplication

    Public Class Cleaner

        Private Sub CountryRegion_Changed()
            QueryString = AddressLine1 + ", " + City + ", " + Postcode + ", " + CountryRegion
        End Sub

        Private Sub FullName_Compute(ByRef result As String)
            ' Set result to the desired field value
            result = FirstName + " " + LastName
        End Sub
    End Class

End Namespace
