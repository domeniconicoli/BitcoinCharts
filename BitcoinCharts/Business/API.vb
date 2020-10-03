Imports System.Configuration
Imports System.Net
Imports Newtonsoft.Json
Imports RestSharp

Public Class API

    Public Shared Function RequestHistoryData(ByVal StartDate As Date, ByVal EndDate As Date) As Classes.History.HistoryModel

        ' API endpoint loading from App.Config
        Dim endpointURL = String.Format(
                ConfigurationManager.AppSettings("BTCHistoryEndpointURL"),
                StartDate.ToString("yyyy-MM-dd"),
                EndDate.ToString("yyyy-MM-dd"))

        ' Make the request
        Dim httpClient = New RestClient()
        Dim request = New RestRequest(endpointURL, Method.GET)
        Dim response = httpClient.Execute(request)

        If (response.StatusCode <> HttpStatusCode.OK) Then
            Throw New Exception($"Communication error, the server responded: {response.StatusCode} - {response.ErrorMessage}")
        End If

        ' Object deserialization
        Return JsonConvert.DeserializeObject(Of Classes.History.HistoryModel)(response.Content)

    End Function

End Class
