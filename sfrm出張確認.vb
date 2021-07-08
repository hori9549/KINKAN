Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm出張確認
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private get施設ID As String
    Public Property 施設ID() As String
        Get
            Return get施設ID
        End Get

        Set(ByVal value As String)
            get施設ID = value
        End Set
    End Property

    Private get職員ID As String
    Public Property 職員ID() As String
        Get
            Return get職員ID
        End Get

        Set(ByVal value As String)
            get職員ID = value
        End Set
    End Property

    Private get場所 As Decimal
    Public Property 場所() As String
        Get
            Return get場所
        End Get

        Set(ByVal value As String)
            get場所 = value
        End Set
    End Property


    Private Sub sfrm出勤確認_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim dtbl職員 As New DataTable

        msSQL = "SELECT * FROM MST_職員"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND 職員ID='" & get職員ID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl職員) ''データセット作成

        If dtbl職員.Rows.Count <> 0 Then
            lblメッセージ.Text = "おかえりなさい。" & vbCrLf
            lblメッセージ.Text += "【" & dtbl職員.Rows(0)("職員氏名") & "】さん" & vbCrLf & vbCrLf
            lblメッセージ.Text += "出張は終わりましたか？"

        End If

        Call cDB.Close()

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn帰任.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
