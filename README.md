# VoIP.ms-REST-for-.NET
 An example implementation of the VoIP.ms API using .NET Framework

# Documentation
The Voip.ms API documentation can be found in the [Voip.ms Customer Portal](https://www.voip.ms/m/apidocs.php)

# Getting Started
You will have to enable API access from your account in the Customer Portal at Main Menu > SOAP and REST/JSON API or directly [here](https://www.voip.ms/m/api.php). 

In the same section, you can setup your API password and you'll have to add the IP address where the API is going to be used from. You can also use 0.0.0.0 as a wildcard, but this is discouraged for safety reasons.

![API Interface](https://i.imgur.com/aFEDkvg.png "API Interface")

Your API credentials need to be declared inside the code for the functions to work properly.

```
    Dim api_url As String = "https://voip.ms/api/v1/rest.php"
    Dim strUsername As String = "john.doe@email.com"
    Dim strPassword As String = "johnspassword69"
```

