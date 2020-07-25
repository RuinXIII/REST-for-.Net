' This project uses Newtonsoft.json to parse the JSON response from the API
' To Install it go to "Tools > NuGet Package Manager > Package Manager Console"
' Run the following command in the console: install-package Newtonsoft.json

Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class frmExamples

    Dim api_url As String = "https://voip.ms/api/v1/rest.php"
    Dim strUsername As String = "lavosx@gmail.com"
    Dim strPassword As String = "Inpachi00"

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
End Class
