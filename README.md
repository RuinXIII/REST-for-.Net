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
# Get Your Own IP Address

```
Private Sub btnGetIPAddress_Click(sender As Object, e As EventArgs) Handles btnGetIPAddress.Click
        Dim client As New HttpClient
        Dim content As New MultipartFormDataContent

        Dim api_username As New StringContent(strUsername)
        Dim api_password As New StringContent(strPassword)
        Dim method As New StringContent("getIP")

        content.Add(api_username, "api_username")
        content.Add(api_password, "api_password")
        content.Add(method, "method")

        Dim response = client.PostAsync(api_url, content).Result
        Dim jsonResponse = response.Content.ReadAsStringAsync()
        Dim jsonObject As JObject = JObject.Parse(jsonResponse.Result.ToString())

        If jsonObject("status") = "success" Then
            MessageBox.Show(jsonObject("ip"))
        Else
            MessageBox.Show(jsonObject("status"))
        End If
    End Sub
```

# Get Account Balance

```
    Private Sub btnGetBalance_Click(sender As Object, e As EventArgs) Handles btnGetBalance.Click
        Dim client As New HttpClient
        Dim content As New MultipartFormDataContent

        Dim api_username As New StringContent(strUsername)
        Dim api_password As New StringContent(strPassword)
        Dim method As New StringContent("getBalance")

        content.Add(api_username, "api_username")
        content.Add(api_password, "api_password")
        content.Add(method, "method")

        Dim response = client.PostAsync(api_url, content).Result
        Dim jsonResponse = response.Content.ReadAsStringAsync()
        Dim jsonObject As JObject = JObject.Parse(jsonResponse.Result.ToString())

        If jsonObject("status") = "success" Then
            MessageBox.Show(jsonObject("balance")("current_balance"))
        Else
            MessageBox.Show(jsonObject("status"))
        End If
    End Sub
```

# Get Ganadian Servers

```
    Private Sub btnGetServers_Click(sender As Object, e As EventArgs) Handles btnGetServers.Click
        Dim client As New HttpClient
        Dim content As New MultipartFormDataContent

        Dim api_username As New StringContent(strUsername)
        Dim api_password As New StringContent(strPassword)
        Dim method As New StringContent("getServersInfo")

        content.Add(api_username, "api_username")
        content.Add(api_password, "api_password")
        content.Add(method, "method")

        Dim response = client.PostAsync(api_url, content).Result
        Dim jsonResponse = response.Content.ReadAsStringAsync()
        Dim jsonObject As JObject = JObject.Parse(jsonResponse.Result.ToString())

        Dim strOutput As String = ""

        If jsonObject("status") = "success" Then
            For Each Row In jsonObject("servers")
                If Row("server_country") = "CAN" Then
                    strOutput += Row("server_hostname").ToString() & vbCrLf
                End If
            Next
            MessageBox.Show(strOutput)
        Else
            MessageBox.Show(jsonObject("status"))
        End If
    End Sub
```

# Support

Please note that we do NOT provide support with your programming language. The only support provided by our staff is for bugs, documentation errors, documentation missing or other questions regarding the functionality of the API. Support regarding the API will be addressed via the ticketing system only at [support@voip.ms](support@voip.ms). Our programmers do not have access to the Live Chat. 
