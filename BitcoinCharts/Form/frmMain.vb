Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms

Public Class frmMain

    Private Const CryptoCurrency_BTC As String = "BTC"
    Private Const AxisX_Title As String = "Days"
    Private Const AxisY_Title As String = "Price"
    Private Const AxisY_MinValue As Decimal = 1000
    Private Const AxisY_MaxOffsetValue As Decimal = 1000

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' control initialization
        InitControls()

        ' hide the graph
        MainChart.Visible = False

    End Sub

    Private Sub InitControls()

        ' set the start and end timepicker date 
        Dim defaultStartDate = Date.Now.AddDays(-7)
        Dim defaultEndDate = Date.Now

        If (defaultStartDate < dtpStartDate.MinDate OrElse defaultStartDate > dtpStartDate.MaxDate) Then
            defaultStartDate = dtpStartDate.MinDate
        End If


        If (defaultEndDate < dtpEndDate.MinDate OrElse defaultEndDate > dtpEndDate.MinDate) Then
            defaultEndDate = dtpEndDate.MaxDate
        End If

        dtpStartDate.Value = defaultStartDate
        dtpEndDate.Value = defaultEndDate

    End Sub

    Private Sub btnHistoryDownload_Click(sender As Object, e As EventArgs) Handles btnHistoryDownload.Click

        ' at button click show the graph
        MainChart.Visible = True

        Try

            ' start the data request / data download
            Dim result As Classes.History.HistoryModel = RequestHistoryData(dtpStartDate.Value, dtpEndDate.Value)

            ' get the days list to create the x Axis
            Dim DaysValue As New List(Of String)()
            For Each obj In result.bpi
                DaysValue.Add(obj.Key)
            Next

            ' create the graph, set axis Y max (USD value) + 1000
            ' and axis X (days)
            GraphCreate(result.bpi.Values.Max, DaysValue)

            ' draw series USDValue/Day
            Dim Rates As New ChartValues(Of Decimal)
            For Each obj In result.bpi
                Rates.Add(obj.Value)
            Next

            ' draw the line and add the serie on the graph
            Dim Series As New SeriesCollection
            Dim Line As New LineSeries
            With Line
                .Title = CryptoCurrency_BTC
                .Values = Rates
            End With
            Series.Add(Line)
            MainChart.Series = Series

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' This sub will be called for each data download, because value and days should change each request
    ''' </summary>
    ''' <param name="MaxValue"></param>
    ''' <param name="DaysList"></param>
    Private Sub GraphCreate(ByVal MaxValue As Decimal, ByVal DaysList As List(Of String))
        ' use the max axis X value downloaded + 1000
        Dim valueRange As New List(Of String)()
        Dim seq = Enumerable.Range(AxisY_MinValue, MaxValue + AxisY_MaxOffsetValue)
        For Each s In seq
            valueRange.Add(s)
        Next

        ' adding the axis Y with USD value
        Dim AsseY As New Axis
        With AsseY
            .Title = AxisY_Title
            .Labels = valueRange
        End With

        ' if there are some data, delete it
        If MainChart.AxisY.Count <> 0 Then MainChart.AxisY.Clear()
        MainChart.AxisY.Add(AsseY)

        ' adding axis X
        Dim AsseX As New Axis
        With AsseX
            .Title = AxisX_Title
            .Labels = DaysList
        End With

        ' if there are some data, delete it
        If MainChart.AxisX.Count <> 0 Then MainChart.AxisX.Clear()
        MainChart.AxisX.Add(AsseX)

    End Sub

    ''' <summary>
    ''' TO DO this call should become ASYNC
    ''' </summary>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <returns></returns>
    Private Function RequestHistoryData(ByVal StartDate As Date, ByVal EndDate As Date) As Classes.History.HistoryModel
        'do the request
        Dim objresult As Classes.History.HistoryModel = API.RequestHistoryData(StartDate, EndDate)
        Return objresult

    End Function

End Class
