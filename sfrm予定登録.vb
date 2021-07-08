Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm予定登録
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private get日付 As Date
    Public Property 日付() As Date
        Get
            Return get日付
        End Get

        Set(ByVal value As Date)
            get日付 = value
        End Set
    End Property
    Private Sub sfrm予定登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call subカレンダー取得(get日付)
        Call sub予定一覧(get日付)
    End Sub

    Private Sub btn前_Click(sender As Object, e As EventArgs) Handles btn前.Click
        get日付 = DateAdd("d", -1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call subカレンダー取得(get日付)
        Call sub予定一覧(get日付)
    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs) Handles btn次.Click
        get日付 = DateAdd("d", 1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call subカレンダー取得(get日付)
        Call sub予定一覧(get日付)
    End Sub

    Private Sub btn新規_Click(sender As Object, e As EventArgs) Handles btn新規.Click
        Call subクリア()
    End Sub

    Private Sub subカレンダー取得(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtblカレンダー As New DataTable

        ''年度データ確認-----------------------------------------------------
        msSQL = "SELECT * FROM MST_カレンダー"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 年月日='" & set日付 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblカレンダー) ''データセット作成

        If dtblカレンダー.Rows.Count <> 0 Then
            Select Case dtblカレンダー.Rows(0)("休日区分")
                Case 1
                    chk休日.Checked = True
                Case Else
                    chk休日.Checked = False
            End Select

        End If

    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim cDB As New clsDB

        ''更新
        msSQL = " UPDATE MST_カレンダー SET "
        If chk休日.Checked = True Then
            msSQL += " 休日区分='1'"

        Else
            msSQL += " 休日区分='0'"

        End If
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 年月日='" & get日付 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub subクリア()
        txtID.Text = ""
        dtp開始時間.Text = "00:00"
        dtp終了時間.Text = "00:00"
        txt予定.Text = ""

        Call dtp開始時間.select()
    End Sub

    Private Sub sub予定一覧(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable

        msSQL = "SELECT * FROM MST_カレンダー予定"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 日付='" & set日付 & "'"
        msSQL += " ORDER BY 開始時間"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成

        dgv一覧.DataSource = dtbl予定

    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn追加.Click
        With txt予定
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("予定は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .select()
                    Exit Sub
                Case Else

            End Select
        End With

        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID


        ''TBL_職員勤務履歴更新
        msSQL = "SELECT * FROM MST_カレンダー予定"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND ID='" & txtID.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成

        If dtbl予定.Rows.Count = 0 Then
            msSQL = " INSERT INTO MST_カレンダー予定("

            msSQL += " 施設ID"
            msSQL += ",日付"
            msSQL += ",開始時間"
            msSQL += ",終了時間"
            msSQL += ",予定"

            msSQL += ")VALUES("

            msSQL += " '" & get施設ID & "'"
            msSQL += ",'" & get日付 & "'"
            msSQL += ",'" & dtp開始時間.Text & "'"
            msSQL += ",'" & dtp終了時間.Text & "'"
            msSQL += ",'" & txt予定.Text & "'"

            msSQL += ")"
        Else

            msSQL = "UPDATE MST_カレンダー予定 SET"
            msSQL += " 開始時間='" & dtp開始時間.Text & "'"
            msSQL += ",終了時間='" & dtp終了時間.Text & "'"
            msSQL += ",予定='" & txt予定.Text & "'"

            msSQL += " WHERE 施設ID='" & get施設ID & "'"
            msSQL += " AND ID='" & txtID.Text & "'"


        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()
        Call sub予定一覧(get日付)
    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim getID As Integer
        Dim dtbl予定 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID

        getID = Trim(dgv一覧.Rows(e.RowIndex).Cells("colID").Value.ToString)

        ''MST_カレンダー予定
        msSQL = "SELECT * FROM MST_カレンダー予定"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND ID='" & getID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成

        For Each get予定 As DataRow In dtbl予定.Rows
            txtID.Text = getID
            dtp開始時間.Text = get予定("開始時間")
            dtp終了時間.Text = get予定("終了時間")
            txt予定.Text = get予定("予定")

        Next


        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "col削除"
                Select Case sfrmメッセージ.ShowDialog("予定の削除を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Case Windows.Forms.DialogResult.OK
                    Case Else
                        Exit Sub
                End Select

                ''更新
                msSQL = " DELETE FROM MST_カレンダー予定 "
                msSQL += " WHERE ID = '" & getID & "'"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()

                Call sub予定一覧(get日付)

        End Select
    End Sub

End Class
