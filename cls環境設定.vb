Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class cls環境設定
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private getデフォルトプリンタ As String
    Private get施設ID As String
    Private get施設名 As String
    Private getフリガナ As String
    Private get会社名 As String
    Private get代表者 As String
    Private get郵便番号 As String
    Private get住所 As String
    Private get電話番号 As String
    Private getFAX番号 As String
    Private get銀行名 As String
    Private get支店名 As String
    Private get口座区分 As String
    Private get口座番号 As String
    Private get通常開始 As String
    Private get通常終了 As String
    Private get休憩時間 As String
    Private get第1延長開始 As String
    Private get第1延長終了 As String
    Private get第2延長開始 As String
    Private get第2延長終了 As String
    Private get第3延長開始 As String
    Private get第3延長終了 As String
    Private get分入力単位 As String
    Private get時間1開始 As String
    Private get時間1終了 As String
    Private get時間2開始 As String
    Private get時間2終了 As String
    Private get時間3開始 As String
    Private get時間3終了 As String
    Private get時間4開始 As String
    Private get時間4終了 As String
    Private get時間5開始 As String
    Private get時間5終了 As String
    Private get時間6開始 As String
    Private get時間6終了 As String


    Public ReadOnly Property 施設ID() As String
        Get
            Return get施設ID
        End Get

    End Property

    Public ReadOnly Property 施設名() As String
        Get
            Return get施設名
        End Get

    End Property

    Public ReadOnly Property フリガナ() As String
        Get
            Return getフリガナ
        End Get

    End Property

    Public ReadOnly Property 会社名() As String
        Get
            Return get会社名
        End Get

    End Property

    Public ReadOnly Property 代表者() As String
        Get
            Return get代表者
        End Get

    End Property

    Public ReadOnly Property 郵便番号() As String
        Get
            Return get郵便番号
        End Get

    End Property

    Public ReadOnly Property 住所() As String
        Get
            Return get住所
        End Get

    End Property

    Public ReadOnly Property 電話番号() As String
        Get
            Return get電話番号
        End Get

    End Property

    Public ReadOnly Property FAX番号() As String
        Get
            Return getFAX番号
        End Get

    End Property

    Public ReadOnly Property 銀行名() As String
        Get
            Return get銀行名
        End Get

    End Property

    Public ReadOnly Property 支店名() As String
        Get
            Return get支店名
        End Get

    End Property

    Public ReadOnly Property 口座区分() As String
        Get
            Return get口座区分
        End Get

    End Property

    Public ReadOnly Property 口座番号() As String
        Get
            Return get口座番号
        End Get

    End Property

    Public ReadOnly Property デフォルトプリンタ() As String
        Get
            Return getデフォルトプリンタ
        End Get

    End Property

    Public ReadOnly Property 通常開始() As String
        Get
            Return get通常開始
        End Get

    End Property

    Public ReadOnly Property 通常終了() As String
        Get
            Return get通常終了
        End Get

    End Property

    Public ReadOnly Property 休憩時間() As String
        Get
            Return get休憩時間
        End Get

    End Property

    Public ReadOnly Property 第1延長開始() As String
        Get
            Return get第1延長開始
        End Get

    End Property

    Public ReadOnly Property 第1延長終了() As String
        Get
            Return get第1延長終了
        End Get

    End Property


    Public ReadOnly Property 第2延長開始() As String
        Get
            Return get第2延長開始
        End Get

    End Property

    Public ReadOnly Property 第2延長終了() As String
        Get
            Return get第2延長終了
        End Get

    End Property

    Public ReadOnly Property 第3延長開始() As String
        Get
            Return get第3延長開始
        End Get

    End Property

    Public ReadOnly Property 第3延長終了() As String
        Get
            Return get第3延長終了
        End Get

    End Property

    Public ReadOnly Property 分入力単位() As String
        Get
            Return get分入力単位
        End Get

    End Property

    Public ReadOnly Property 時間1開始() As String
        Get
            Return get時間1開始
        End Get

    End Property

    Public ReadOnly Property 時間1終了() As String
        Get
            Return get時間1終了
        End Get

    End Property

    Public ReadOnly Property 時間2開始() As String
        Get
            Return get時間2開始
        End Get

    End Property

    Public ReadOnly Property 時間2終了() As String
        Get
            Return get時間2終了
        End Get

    End Property

    Public ReadOnly Property 時間3開始() As String
        Get
            Return get時間3開始
        End Get

    End Property

    Public ReadOnly Property 時間3終了() As String
        Get
            Return get時間3終了
        End Get

    End Property

    Public ReadOnly Property 時間4開始() As String
        Get
            Return get時間4開始
        End Get

    End Property

    Public ReadOnly Property 時間4終了() As String
        Get
            Return get時間4終了
        End Get

    End Property

    Public ReadOnly Property 時間5開始() As String
        Get
            Return get時間5開始
        End Get

    End Property

    Public ReadOnly Property 時間5終了() As String
        Get
            Return get時間5終了
        End Get

    End Property

    Public ReadOnly Property 時間6開始() As String
        Get
            Return get時間6開始
        End Get

    End Property

    Public ReadOnly Property 時間6終了() As String
        Get
            Return get時間6終了
        End Get

    End Property

    Public Sub New()
        Call 環境設定読込()

    End Sub

    Public Sub 環境設定読込()
        Dim pd As New System.Drawing.Printing.PrintDocument
        Dim cDB As New clsDB
        Dim dtbl施設 As New DataTable
        Dim dtbl環境 As New DataTable


        ''施設情報==================================================
        msSQL = "SELECT * FROM MST_施設"
        msSQL += " WHERE 施設ID='" & ConfigurationManager.AppSettings("InstitutionID") & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl施設) ''データセット作成

        For Each getRow As DataRow In dtbl施設.Rows
            get施設ID = getRow("施設ID")
            get施設名 = getRow("施設名")

        Next

        ''環境情報取得==============================================
        msSQL = "SELECT * FROM MST_環境設定"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl環境) ''データセット作成

        ''デフォルトプリンタ情報の取得-----------------------------
        getデフォルトプリンタ = pd.PrinterSettings.PrinterName

        ''情報取得-------------------------------------------------
        For Each getRow As DataRow In dtbl環境.Rows
            Select Case getRow("ID")
                Case 1 : getフリガナ = getRow("パラメータ")
                Case 2 : get会社名 = getRow("パラメータ")
                Case 3 : get代表者 = getRow("パラメータ")
                Case 4 : get郵便番号 = getRow("パラメータ")
                Case 5 : get住所 = getRow("パラメータ")
                Case 6 : get電話番号 = getRow("パラメータ")
                Case 7 : getFAX番号 = getRow("パラメータ")
                Case 8 : get銀行名 = getRow("パラメータ")
                Case 9 : get支店名 = getRow("パラメータ")
                Case 10 : get口座区分 = getRow("パラメータ")
                Case 11 : get口座番号 = getRow("パラメータ")
                Case 12 : get通常開始 = getRow("パラメータ")
                Case 13 : get通常終了 = getRow("パラメータ")
                Case 14 : get休憩時間 = getRow("パラメータ")
                Case 15 : get第1延長開始 = getRow("パラメータ")
                Case 16 : get第1延長終了 = getRow("パラメータ")
                Case 17 : get第2延長開始 = getRow("パラメータ")
                Case 18 : get第2延長終了 = getRow("パラメータ")
                Case 19 : get第3延長開始 = getRow("パラメータ")
                Case 20 : get第3延長終了 = getRow("パラメータ")
                Case 21 : get分入力単位 = getRow("パラメータ")
                Case 22 : get時間1開始 = getRow("パラメータ")
                Case 23 : get時間1終了 = getRow("パラメータ")
                Case 24 : get時間2開始 = getRow("パラメータ")
                Case 25 : get時間2終了 = getRow("パラメータ")
                Case 26 : get時間3開始 = getRow("パラメータ")
                Case 27 : get時間3終了 = getRow("パラメータ")
                Case 28 : get時間4開始 = getRow("パラメータ")
                Case 29 : get時間4終了 = getRow("パラメータ")
                Case 30 : get時間5開始 = getRow("パラメータ")
                Case 31 : get時間5終了 = getRow("パラメータ")
                Case 32 : get時間6開始 = getRow("パラメータ")
                Case 33 : get時間6終了 = getRow("パラメータ")
            End Select

        Next

    End Sub
End Class
