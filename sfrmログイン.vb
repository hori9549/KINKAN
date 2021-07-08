Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrmログイン
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub sfrm出勤確認_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblメッセージ.Text = ""




    End Sub

    Private Function subログイン() As Boolean
        Dim cDB As New clsDB
        Dim dtbl職員 As New DataTable

        msSQL = "SELECT * FROM MST_職員"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 職員ID='" & txt職員ID.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl職員) ''データセット作成

        If dtbl職員.Rows.Count = 0 Then
            lblメッセージ.Text = "社員コード、または、パスワードに誤りがあります。"

        Else
            Dim str_CheckPassword As String = dtbl職員.Rows(0)("パスワード")
            Dim str_InputPassword As String = txtパスワード.Text

            ''パスワード大文字・小文字判別チェック
            If String.Compare(str_CheckPassword, str_InputPassword, False) = 0 Then
                ''認証ＯＫ
                MS職員ID = dtbl職員.Rows(0)("職員ID")
                MS職員名 = dtbl職員.Rows(0)("職員氏名")

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()

            Else
                ''認証ＮＧ
                lblメッセージ.Text = "社員コード、または、パスワードに誤りがあります。"

            End If
        End If

    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnログイン.Click
        With txtパスワード
            Select Case .Text
                Case ""
                    lblメッセージ.Text = "パスワードを入力してください。"

                    Call .Select()
                    Exit Sub
                Case Else

            End Select

        End With

        Call subログイン()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
