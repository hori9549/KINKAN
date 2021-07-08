Imports System.Data
Imports System.Data.SqlClient

Public Class frmMシフト作成
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス
    Private n月選択 As New Integer

    Private Sub frm利用者登録_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call frmメニュー.Show()
    End Sub

    Private Sub frm利用者登録_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Now.Month
            Case >= 4 : lbl年度.Text = Now.Year
            Case Else : lbl年度.Text = Now.Year - 1
        End Select
        txtシフト年.Text = Now.Year
        txtシフト月.Text = Now.Month
        lbl施設.Text = my環境設定.施設名 & "カレンダー"

        'Call sub予定表示(lbl年度.Text, Now.Month)
        Dim btn月 As Control
        For n月カウント As Integer = 1 To 12
            btn月 = Me.Controls("btn" & n月カウント)
            If n月カウント = Now.Month Then
                CType(btn月, Button).ForeColor = Color.Red
                Call CType(btn月, Button).PerformClick()
            Else
                CType(btn月, Button).ForeColor = Color.Blue
            End If
        Next

    End Sub
    Private Sub グリッド並び()
        ''グリッド表示順
        With dgvカレンダー
            .Columns("colID").DisplayIndex = 0
            .Columns("col休日区分").DisplayIndex = 1
            .Columns("col施設ID").DisplayIndex = 2
            .Columns("col年度").DisplayIndex = 3
            .Columns("col年月日").DisplayIndex = 4
            .Columns("col予定追加").DisplayIndex = 5
            .Columns("col曜日").DisplayIndex = 6
            .Columns("col予定").DisplayIndex = 7

        End With

    End Sub
    Private Sub btn作成_Click(sender As Object, e As EventArgs) Handles btn作成.Click
        With txtシフト年
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("シフト年が設定されていません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()

                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("シフト年は数字で入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()

                        Exit Sub
                    End If

                    If CInt(.Text) < 2020 Then
                        sfrmメッセージ.ShowDialog("正しいシフト年で入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()

                        Exit Sub
                    End If
            End Select
        End With

        With txtシフト月
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("シフト月が設定されていません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()

                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("シフト月は数字で入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()

                        Exit Sub
                    End If

                    If CInt(.Text) > 12 Then
                        sfrmメッセージ.ShowDialog("正しいシフト月で入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()

                        Exit Sub
                    End If
            End Select
        End With

        Dim dtチェック As Date = New Date(txtシフト年.Text, txtシフト月.Text, 1)
        dtチェック = DateAdd(DateInterval.Month, 1, dtチェック)
        dtチェック = DateAdd(DateInterval.Day, -1, dtチェック)
        If Now.Date <= dtチェック Then
        Else
            sfrmメッセージ.ShowDialog("当月以前のシフトは作成できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call txtシフト月.Select()

            Exit Sub
        End If

        ''処理開始========================================================
        Dim cDB As New clsDB
        Dim dtblカレンダー As New DataTable
        Dim dt開始日 As Date = New Date(txtシフト年.Text, txtシフト月.Text, 1)
        Dim dt終了日 As Date = DateAdd("m", 1, dt開始日)

        ''年度データ確認-----------------------------------------------------
        msSQL = "SELECT * FROM TBL_職員勤務履歴"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 日付>='" & dt開始日 & "'"
        msSQL += " AND 日付<'" & dt終了日 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblカレンダー) ''データセット作成

        If dtblカレンダー.Rows.Count <> 0 Then
            Select Case sfrmメッセージ.ShowDialog(txtシフト月.Text & "年度のデータはすでに作成されています。" & vbCrLf _
                                        & "再作成を行いますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Case DialogResult.OK
                    ''年度データ削除-----------------------------------------
                    msSQL = " DELETE TBL_職員勤務履歴"
                    msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
                    msSQL += " AND 日付>='" & dt開始日 & "'"
                    msSQL += " AND 日付<'" & dt終了日 & "'"

                    mCommand = cDB.getsqlComand(msSQL)
                    Call mCommand.ExecuteNonQuery()
                Case Else
                    Exit Sub
            End Select

        End If

        ''作成開始-------------------------------------------------------------
        'Dim dt開始日 As Date = CDate(txtシフト月.Text & "/4/1")
        'Dim dt終了日 As Date = DateAdd("yyyy", 1, dt開始日)
        Dim dtカウント As Date = dt開始日

        ''職員取得------------------------------------------------------------
        Dim dtbl職員シフト As New DataTable
        Dim sシフト開始 As String
        Dim sシフト終了 As String

        msSQL = "SELECT * FROM MST_職員"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND  退職日 is NULL"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl職員シフト) ''データセット作成

        spbベース.Value = 0
        spbベース.Maximum = 31
        Do Until dtカウント >= dt終了日
            For Each get職員 As DataRow In dtbl職員シフト.Rows

                Select Case dtカウント.DayOfWeek
                    Case 0  ''日
                        sシフト開始 = get職員("日曜出勤時間").ToString
                        sシフト終了 = get職員("日曜退勤時間").ToString
                    Case 1
                        sシフト開始 = get職員("月曜出勤時間").ToString
                        sシフト終了 = get職員("月曜退勤時間").ToString
                    Case 2
                        sシフト開始 = get職員("火曜出勤時間").ToString
                        sシフト終了 = get職員("火曜退勤時間").ToString
                    Case 3
                        sシフト開始 = get職員("水曜出勤時間").ToString
                        sシフト終了 = get職員("水曜退勤時間").ToString
                    Case 4
                        sシフト開始 = get職員("木曜出勤時間").ToString
                        sシフト終了 = get職員("木曜退勤時間").ToString
                    Case 5
                        sシフト開始 = get職員("金曜出勤時間").ToString
                        sシフト終了 = get職員("金曜退勤時間").ToString
                    Case 6
                        sシフト開始 = get職員("土曜出勤時間").ToString
                        sシフト終了 = get職員("土曜退勤時間").ToString
                End Select

                If sシフト開始 <> sシフト終了 Then
                    ''出勤
                    msSQL = " INSERT INTO TBL_職員勤務履歴("

                    msSQL += " 施設ID"
                    msSQL += ",職員ID"
                    msSQL += ",日付"
                    msSQL += ",シフト出勤時間"
                    msSQL += ",シフト退勤時間"
                    msSQL += ",第1延長"
                    msSQL += ",第2延長"
                    msSQL += ",第3延長"
                    msSQL += ",出勤時間"
                    msSQL += ",退勤時間"
                    msSQL += ",休憩時間"
                    msSQL += ",検温"

                    msSQL += " )VALUES("

                    msSQL += "'" & my環境設定.施設ID & "'"
                    msSQL += ",'" & get職員("職員ID") & "'"
                    msSQL += ",'" & dtカウント.ToString("yyyy/MM/dd") & "'"
                    msSQL += ",'" & sシフト開始 & "'"
                    msSQL += ",'" & sシフト終了 & "'"
                    msSQL += ",'0'"
                    msSQL += ",'0'"
                    msSQL += ",'0'"
                    msSQL += ",''"
                    msSQL += ",''"
                    msSQL += ",'" & my環境設定.休憩時間 & "'"
                    msSQL += ",'0'"


                    msSQL += " )"

                    mCommand = cDB.getsqlComand(msSQL)
                    Call mCommand.ExecuteNonQuery()
                End If

            Next

            ''カウントアップ
            dtカウント = DateAdd("d", 1, dtカウント)
            spbベース.Value += 1
        Loop

        Call cDB.Close()
        sfrmメッセージ.ShowDialog("シフト作成が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call sub予定表示(txtシフト年.Text, Now.Month)
    End Sub

    Private Sub sub予定表示(get年度 As Integer, get月 As Integer)
        Dim cDB As New clsDB
        Dim dtblカレンダー As New DataTable
        Dim dt開始日, dt終了日 As Date

        Select Case get月
            Case <= 3
                dt開始日 = New Date(get年度 + 1, get月, 1)
            Case Else
                dt開始日 = New Date(get年度, get月, 1)
        End Select
        dt終了日 = DateAdd("M", 1, dt開始日)
        dt終了日 = DateAdd("d", -1, dt終了日)

        ''表示--------------------------------------------------------
        msSQL = "SELECT MST_カレンダー.* ,('') as 予定,"
        msSQL += " (Case DatePart(Weekday, 年月日)"
        msSQL += "  WHEN 1 THEN '日' "
        msSQL += "  WHEN 2 THEN '月' "
        msSQL += "  WHEN 3 THEN '火' "
        msSQL += "  WHEN 4 THEN '水' "
        msSQL += "  WHEN 5 THEN '木' "
        msSQL += "  WHEN 6 THEN '金' "
        msSQL += "  WHEN 7 THEN '土' "
        msSQL += " END) as 曜日"

        msSQL += " FROM MST_カレンダー"

        msSQL += " WHERE MST_カレンダー.施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 年度='" & get年度 & "'"
        msSQL += " AND 年月日>='" & dt開始日 & "'"
        msSQL += " AND 年月日<='" & dt終了日 & "'"
        msSQL += " ORDER BY 年月日" '"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblカレンダー) ''データセット作成

        ''予定設定
        Dim dtbl予定 As New DataTable
        Dim s予定 As String = ""
        Dim dt開始, dt終了 As DateTime
        For Each get行 As DataRow In dtblカレンダー.Rows
            Call dtbl予定.Clear()
            s予定 = ""

            msSQL = "SELECT * "
            msSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.施設ID = TBL_職員勤務履歴.施設ID AND MST_職員.職員ID= TBL_職員勤務履歴.職員ID)as 職員名"
            msSQL += " FROM TBL_職員勤務履歴"
            msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
            msSQL += " AND 日付 ='" & get行("年月日") & "'"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(dtbl予定) ''データセット作成

            For Each get日予定 As DataRow In dtbl予定.Rows
                If get日予定("シフト出勤時間").ToString = "" Or get日予定("シフト退勤時間").ToString = "" Then
                    s予定 += "00:00～00:00　" & get日予定("職員名").ToString & vbCrLf

                Else
                    dt開始 = DateTime.Parse(get日予定("シフト出勤時間").ToString)
                    dt終了 = DateTime.Parse(get日予定("シフト退勤時間").ToString)

                    s予定 += dt開始.ToString("HH:mm") & "～" & dt終了.ToString("HH:mm") & "　" & get日予定("職員名").ToString & vbCrLf

                End If
            Next
            If s予定 <> "" Then get行("予定") = s予定.Remove(s予定.Length - 2, 2)
        Next

        ''グリッド表示
        With dgvカレンダー
            .DataSource = dtblカレンダー
            Call グリッド並び()
        End With
    End Sub

    Private Sub btn月_Click(sender As Object, e As EventArgs) Handles btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click _
                                                                        , btn10.Click, btn11.Click, btn12.Click, btn1.Click, btn2.Click, btn3.Click

        Dim get月 As Integer = CType(sender, Button).Tag

        Call sub予定表示(lbl年度.Text, get月)
        n月選択 = get月
        Select Case n月選択
            Case >= 4 : txtシフト年.Text = lbl年度.Text
            Case Else : txtシフト年.Text = Now.Year
        End Select
        txtシフト月.Text = get月
    End Sub

    Private Sub dgvカレンダー_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvカレンダー.CellFormatting
        Dim get休日, get日付 As String
        Dim setColor As Color

        If e.RowIndex >= 0 Then
            ''MsgBox(dgv_ASSYList.Rows(e.RowIndex).Cells(0).Value)
            get休日 = dgvカレンダー.Rows(e.RowIndex).Cells("col休日区分").Value ''連番情報取得
            get日付 = dgvカレンダー.Rows(e.RowIndex).Cells("col年月日").Value ''連番情報取得

            Select Case get休日
                Case "1" ''欠品
                    setColor = Color.LightPink
            End Select

            ''着色
            If CDate(get日付).ToString("yyyy/MM/dd") = Now.Date.ToString("yyyy/MM/dd") Then
                Dim i_RowCount As Integer
                For i_RowCount = 0 To dgvカレンダー.ColumnCount - 1
                    dgvカレンダー.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = Color.LightYellow

                Next

            Else
                If get休日 <> "" Then
                    Dim i_RowCount As Integer
                    For i_RowCount = 0 To dgvカレンダー.ColumnCount - 1
                        dgvカレンダー.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = setColor

                    Next
                End If
            End If




        End If
    End Sub

    Private Sub dgvカレンダー_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvカレンダー.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim dt日付 As Date
        Dim myTable As New DataTable

        dt日付 = Trim(dgvカレンダー.Rows(e.RowIndex).Cells("col年月日").Value.ToString)


        Select Case dgvカレンダー.Columns(e.ColumnIndex).Name
            Case "col予定追加"

                Dim sfrm As New sfrmシフト管理
                sfrm.日付 = dt日付.ToString("yyyy/MM/dd")
                sfrm.ShowDialog()

                Call sub予定表示(lbl年度.Text, n月選択)
        End Select
    End Sub

    Private Sub btnシフト表_Click(sender As Object, e As EventArgs) Handles btnシフト表.Click
        Call subシフト表作成(txtシフト年.Text, txtシフト月.Text)

    End Sub
End Class