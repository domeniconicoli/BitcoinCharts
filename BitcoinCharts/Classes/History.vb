Namespace Classes

    Public Class History

        Public Class HistoryModel
            Public Property bpi As Dictionary(Of Date, Decimal)
            Public Property disclaimer As String
            Public Property time As Time
        End Class

        Public Class Time
            Public Property updated As String
            Public Property updatedISO As Date
        End Class

    End Class

End Namespace