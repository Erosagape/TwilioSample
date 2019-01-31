Imports System
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account

Module Main

    Sub Main()
        Const accountID As String = "ACa431865d3af2dda7901551d6eb46a492"
        Const authToken As String = "8b2c8386f334ecef117773f28d3e06a7"

        TwilioClient.Init(accountID, authToken)

        Dim msg = MessageResource.Create(
            [body]:="Greetings! The current time is: " + Now.ToString("HH:mm:ss") + " UORJQ74TQUMGENZ",
            [from]:=New Twilio.Types.PhoneNumber("+15123557928"),
            [to]:=New Twilio.Types.PhoneNumber("+66823320506")
            )
        Console.WriteLine(msg.Sid)

    End Sub

End Module
