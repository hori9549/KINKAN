Public Class sfrm日付選択

    ''選択日付
    Private get日付
    Public Property 日付() As String
        Get
            Return get日付
        End Get

        Set(ByVal value As String)
            get日付 = value
        End Set
    End Property

    ''閉じるボタン押下
    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        get日付 = ""

        Call Me.Close()
    End Sub

    ''選択日付を格納
    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected
        get日付 = Format(MonthCalendar.SelectionStart, "yyyy/MM/dd")

        Call Me.Close()
    End Sub

    Private Sub sfrm_InputCalender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form Size
        Me.Size = New Size(MonthCalendar.Size.Width + 30, MonthCalendar.Size.Height + 90)
        'Button Location
        btn_Exit.Location = New Point((Me.Size.Width \ 2) - (btn_Exit.Size.Width \ 2) - 2, btn_Exit.Location.Y)

        If get日付 = "" Then
            MonthCalendar.SetDate(Now.Date)
        Else
            MonthCalendar.SetDate(get日付)
        End If
    End Sub

    Private Sub btn今日_Click(sender As Object, e As EventArgs) Handles btn今日.Click
        get日付 = Now.Date

        Call Me.Close()
    End Sub
End Class