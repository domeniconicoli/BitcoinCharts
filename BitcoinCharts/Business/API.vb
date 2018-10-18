Imports System.Configuration
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json


Public Class API

    Public Shared Function RequestHistoryData(ByVal StartDate As Date, ByVal EndDate As Date) As Classes.History.HistoryModel

        Try
            ' API endpoint loading from App.Config
            Dim endpointURL = String.Format(ConfigurationManager.AppSettings("BTCHistoryEndpointURL"), StartDate.ToString("yyyy-MM-dd"), EndDate.ToString("yyyy-MM-dd"))

            ' make the request
            Dim request As WebRequest = WebRequest.Create(endpointURL)
            request.Credentials = CredentialCache.DefaultCredentials
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            response.Close()

            ' object deserealization
            Dim result As Classes.History.HistoryModel = JsonConvert.DeserializeObject(Of Classes.History.HistoryModel)(responseFromServer)
            Return result

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

        ' return nothing only if the request went in error (the error should be managed on the form)
        Return Nothing

    End Function

End Class
