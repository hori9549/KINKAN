Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm勤務状況
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス

    Private pro日付 As Date
    Public Property 日付() As Date
        Get
            Return pro日付
        End Get

        Set(ByVal value As Date)
            pro日付 = value
        End Set
    End Property

    Private pro職員 As Integer
    Public Property 職員() As Integer
        Get
            Return pro職員
        End Get

        Set(ByVal value As Integer)
            pro職員 = value
        End Set
    End Property

    Private Sub sfrm予定登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim get日付 As Date = New Date(pro日付.Year, pro日付.Month, 1)
        Call myコンボ.検温コンボ(cmb検温)
        Call myコンボ.職員コンボ(cmb職員)
        Call myコンボ.休憩時間コンボ(cmb休憩時間)
        Call subクリア()

        lbl年月.Text = get日付.ToString("yyyy年MM月")
        cmb職員.SelectedValue = pro職員
        Call subシフト一覧(pro日付)
    End Sub

    Private Sub btn前_Click(sender As Object, e As EventArgs) Handles btn前.Click
        pro日付 = DateAdd("m", -1, pro日付)
        Call subクリア()
        lbl年月.Text = pro日付.ToString("yyyy年MM月")
        cmb職員.SelectedValue = pro職員
        Call subシフト一覧(pro日付)
    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs) Handles btn次.Click
        pro日付 = DateAdd("m", 1, pro日付)
        Call subクリア()
        lbl年月.Text = pro日付.ToString("yyyy年MM月")
        cmb職員.SelectedValue = pro職員
        Call subシフト一覧(pro日付)
    End Sub

    Private Sub subクリア()
        lbl日付.Text = ""
        dtpシフト出勤.Text = "00:00"
        dtpシフト退勤.Text = "00:00"

        If my環境設定.第2延長開始 = "00:00" Then
            chk第1延長.Visible = False
        Else
            chk第1延長.Visible = True
            chk第1延長.Text = "早朝延長(" & my環境設定.第1延長開始 & "～" & my環境設定.第1延長終了 & ")"
            chk第1延長.Checked = False

        End If

        If my環境設定.第2延長開始 = "00:00" Then
            chk第2延長.Visible = False
        Else
            chk第2延長.Visible = True
            chk第2延長.Text = "通常延長(" & my環境設定.第2延長開始 & "～" & my環境設定.第2延長終了 & ")"
            chk第2延長.Checked = False

        End If

        If my環境設定.第3延長開始 = "00:00" Then
            chk第3延長.Visible = False
        Else
            chk第3延長.Visible = True
            chk第3延長.Text = "夕方延長(" & my環境設定.第3延長開始 & "～" & my環境設定.第3延長終了 & ")"
            chk第3延長.Checked = False
        End If

        dtp出勤.Text = "00:00"
        dtp退勤.Text = "00:00"

        cmb職員.SelectedValue = ""
        cmb検温.Text = "0.0"

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub subシフト一覧(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable
        Dim dt開始日, dt終了日 As Date
        dt開始日 = set日付
        dt終了日 = DateAdd("M", 1, dt開始日)

        msSQL = "SELECT * "
        msSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.施設ID = TBL_職員勤務履歴.施設ID AND MST_職員.職員ID= TBL_職員勤務履歴.職員ID)as 職員名"
        msSQL += " FROM TBL_職員勤務履歴"

        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 職員ID='" & cmb職員.SelectedValue & "'"
        msSQL += " AND 日付 >='" & dt開始日 & "'"
        msSQL += " AND 日付 <'" & dt終了日 & "'"
        msSQL += " ORDER BY 日付"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成

        dgv一覧.DataSource = dtbl予定
        Call subグリッド並び_シフト一覧()

    End Sub

    Private Sub subグリッド並び_シフト一覧()
        ''グリッド表示順
        With dgv一覧
            .Columns("col削除").DisplayIndex = 0
            .Columns("colID").DisplayIndex = 1
            .Columns("col施設ID").DisplayIndex = 2
            .Columns("col職員ID").DisplayIndex = 3
            .Columns("col職員名").DisplayIndex = 4
            .Columns("col日付").DisplayIndex = 5
            .Columns("colシフト出勤時間").DisplayIndex = 6
            .Columns("colシフト退勤時間").DisplayIndex = 7
            .Columns("col第1延長").DisplayIndex = 8
            .Columns("col第2延長").DisplayIndex = 9
            .Columns("col第3延長").DisplayIndex = 10
            .Columns("col出勤時間").DisplayIndex = 11
            .Columns("col退勤時間").DisplayIndex = 12
            .Columns("col検温").DisplayIndex = 13

        End With

    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim dtbl勤務履歴 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID

        With cmb職員
            Select Case .SelectedValue
                Case ""
                    sfrmメッセージ.ShowDialog("職員は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .select()
                    Exit Sub
                Case Else

            End Select
        End With

        With lbl日付
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("日付が選択されていません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .select()
                    Exit Sub
                Case Else

            End Select
        End With

        ''TBL_職員勤務履歴更新
        msSQL = "SELECT * FROM TBL_職員勤務履歴"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND 職員ID='" & pro職員 & "'"
        msSQL += " AND 日付='" & lbl日付.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl勤務履歴) ''データセット作成

        If dtbl勤務履歴.Rows.Count = 0 Then
            msSQL = " INSERT INTO TBL_職員勤務履歴("

            msSQL += " 施設ID"
            msSQL += ",職員ID"
            msSQL += ",日付"
            msSQL += ",シフト出勤時間"
            msSQL += ",シフト退勤時間"
            msSQL += ",出勤時間"
            msSQL += ",退勤時間"
            msSQL += ",検温"
            msSQL += ",第1延長"
            msSQL += ",第2延長"
            msSQL += ",第3延長"
            msSQL += ",休憩時間"

            msSQL += ")VALUES("

            msSQL += " '" & get施設ID & "'"
            msSQL += ",'" & pro職員 & "'"
            msSQL += ",'" & lbl日付.Text & "'"
            If dtpシフト出勤.Text <> "00:00" Then msSQL += ",'" & dtpシフト出勤.Text & "'" Else msSQL += ",''"
            If dtpシフト退勤.Text <> "00:00" Then msSQL += ",'" & dtpシフト退勤.Text & "'" Else msSQL += ",''"
            If dtp出勤.Text <> "00:00" Then msSQL += ",'" & dtp出勤.Text & "'" Else msSQL += ",''"
            If dtp退勤.Text <> "00:00" Then msSQL += ",'" & dtp退勤.Text & "'" Else msSQL += ",''"
            msSQL += ",'" & cmb検温.Text & "'"
            msSQL += ",'" & chk第1延長.Checked & "'"
            msSQL += ",'" & chk第2延長.Checked & "'"
            msSQL += ",'" & chk第3延長.Checked & "'"
            msSQL += ",'" & cmb休憩時間.SelectedValue & "'"

            msSQL += ")"

        Else
            msSQL = "UPDATE TBL_職員勤務履歴 SET "
            msSQL += " 職員ID='" & pro職員 & "'"
            If dtpシフト出勤.Text <> "00:00" Then msSQL += ",シフト出勤時間='" & dtpシフト出勤.Text & "'" Else msSQL += ",シフト出勤時間=''"
            If dtpシフト退勤.Text <> "00:00" Then msSQL += ",シフト退勤時間='" & dtpシフト退勤.Text & "'" Else msSQL += ",シフト退勤時間=''"
            If dtp出勤.Text <> "00:00" Then msSQL += ",出勤時間='" & dtp出勤.Text & "'" Else msSQL += ",出勤時間=''"
            If dtp退勤.Text <> "00:00" Then msSQL += ",退勤時間='" & dtp退勤.Text & "'" Else msSQL += ",退勤時間=''"
            msSQL += ",検温='" & cmb検温.Text & "'"
            msSQL += ",第1延長='" & chk第1延長.Checked & "'"
            msSQL += ",第2延長='" & chk第2延長.Checked & "'"
            msSQL += ",第3延長='" & chk第3延長.Checked & "'"
            msSQL += ",休憩時間='" & cmb休憩時間.SelectedValue & "'"

            msSQL += " WHERE 施設ID='" & get施設ID & "'"
            msSQL += " AND 職員ID='" & pro職員 & "'"
            msSQL += " AND 日付='" & lbl日付.Text & "'"

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()
        cmb職員.SelectedValue = pro職員
        Call subシフト一覧(pro日付)
    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim getID As Integer
        Dim dtbl勤務履歴 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID

        getID = Trim(dgv一覧.Rows(e.RowIndex).Cells("colID").Value.ToString)
        ''MST_カレンダー予定
        msSQL = "SELECT * FROM TBL_職員勤務履歴"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND ID='" & getID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl勤務履歴) ''データセット作成

        For Each get履歴 As DataRow In dtbl勤務履歴.Rows
            lbl日付.Text = CDate(get履歴("日付")).ToString("yyyy/MM/dd")
            cmb職員.SelectedValue = get履歴("職員ID").ToString
            If get履歴("シフト出勤時間").ToString <> "" Then dtpシフト出勤.Text = get履歴("シフト出勤時間") Else dtpシフト出勤.Text = "00:00"
            If get履歴("シフト退勤時間").ToString <> "" Then dtpシフト退勤.Text = get履歴("シフト退勤時間") Else dtpシフト退勤.Text = "00:00"
            If get履歴("出勤時間").ToString <> "" Then dtp出勤.Text = get履歴("出勤時間") Else dtp出勤.Text = "00:00"
            If get履歴("退勤時間").ToString <> "" Then dtp退勤.Text = get履歴("退勤時間") Else dtp退勤.Text = "00:00"
            cmb検温.Text = get履歴("検温").ToString
            cmb休憩時間.SelectedValue = CDec(get履歴("休憩時間")).ToString("0.##")

            chk第1延長.Checked = get履歴("第1延長").ToString
            chk第2延長.Checked = get履歴("第2延長").ToString
            chk第3延長.Checked = get履歴("第3延長").ToString
        Next

        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "col削除"
                Select Case sfrmメッセージ.ShowDialog("シフトの削除を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Case Windows.Forms.DialogResult.OK
                    Case Else
                        Exit Sub
                End Select

                ''更新
                msSQL = " DELETE FROM TBL_職員勤務履歴 "
                msSQL += " WHERE ID = '" & getID & "'"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()

                Call subシフト一覧(pro日付)

        End Select
    End Sub

    Private Sub btn新規_Click(sender As Object, e As EventArgs)
        Call subクリア()
    End Sub

    Private Sub dgv一覧_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv一覧.CellFormatting
        Dim getシフト出勤, get出勤 As String
        Dim setColor As Color

        If e.RowIndex >= 0 Then
            ''MsgBox(dgv_ASSYList.Rows(e.RowIndex).Cells(0).Value)
            getシフト出勤 = dgv一覧.Rows(e.RowIndex).Cells("colシフト出勤時間").Value.ToString
            get出勤 = dgv一覧.Rows(e.RowIndex).Cells("col出勤時間").Value

            If getシフト出勤 < get出勤 Then
                setColor = Color.Red

                Dim i_RowCount As Integer
                For i_RowCount = 0 To dgv一覧.ColumnCount - 1
                    dgv一覧.Rows(e.RowIndex).Cells(i_RowCount).Style.ForeColor = setColor

                Next
            End If
        End If
    End Sub

    Private Sub chk第1延長_CheckedChanged(sender As Object, e As EventArgs) Handles chk第1延長.CheckedChanged
        If my環境設定.第1延長開始 <> "00:00" And chk第1延長.Checked = True Then
            dtpシフト出勤.Text = my環境設定.第1延長開始
        End If
    End Sub

    Private Sub chk第2延長_CheckedChanged(sender As Object, e As EventArgs) Handles chk第2延長.CheckedChanged, chk第3延長.CheckedChanged
        If my環境設定.第2延長開始 <> "00:00" And chk第2延長.Checked = True Then
            dtpシフト退勤.Text = my環境設定.第2延長終了
        End If
        If my環境設定.第3延長開始 <> "00:00" And chk第3延長.Checked = True Then
            dtpシフト退勤.Text = my環境設定.第3延長終了
        End If
    End Sub

    Private Sub cmb職員_Leave(sender As Object, e As EventArgs) Handles cmb職員.Leave
        pro職員 = cmb職員.SelectedValue
        Call subシフト一覧(pro日付)
    End Sub

    Private Sub btn職員名簿_Click(sender As Object, e As EventArgs) Handles btn職員名簿.Click

        Select Case pro日付.Month
            Case <= 3
                Call sub勤務管理簿Excel(pro日付.Year - 1, pro職員)
            Case Else
                Call sub勤務管理簿Excel(pro日付.Year, pro職員)
        End Select
    End Sub

    Private Sub cmb職員_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb職員.SelectedIndexChanged
        Call subシフト一覧(pro日付)
    End Sub

    Private Sub lbl年月_Click(sender As Object, e As EventArgs) Handles lbl年月.Click

    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        Try
            Call subシフトエクスポート(pro日付.Year, pro日付.Month, pro職員)

        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnインポート_Click(sender As Object, e As EventArgs) Handles btnインポート.Click
        Dim dtチェック As Date = New Date(pro日付.Year, pro日付.Month, 1)
        dtチェック = DateAdd(DateInterval.Month, 1, dtチェック)
        dtチェック = DateAdd(DateInterval.Day, -1, dtチェック)
        If Now.Date <= dtチェック Then
        Else
            sfrmメッセージ.ShowDialog("当月以前のシフトは作成できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If

        Try
            Call subシフトインポート(pro日付.Year, pro日付.Month, pro職員)

            Call subシフト一覧(pro日付)
            sfrmメッセージ.ShowDialog("インポートが完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn一括出退処理_Click(sender As Object, e As EventArgs) Handles btn一括出退処理.Click
        Select Case sfrmメッセージ.ShowDialog("一括出退処理を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            Case Windows.Forms.DialogResult.OK
            Case Else
                Exit Sub
        End Select

        Call sub一括出退処理(pro日付)

    End Sub

    Private Sub sub一括出退処理(set日付)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable
        Dim dt開始日, dt終了日 As Date
        dt開始日 = set日付
        dt終了日 = DateAdd("M", 1, dt開始日)

        ''出勤時間更新-------------------------------------
        msSQL = "UPDATE TBL_職員勤務履歴 SET"
        msSQL += " 出勤時間 = シフト出勤時間"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 職員ID='" & cmb職員.SelectedValue & "'"
        msSQL += " AND 日付 >='" & dt開始日 & "'"
        msSQL += " AND 日付 <'" & dt終了日 & "'"
        msSQL += " AND 出勤時間 =''"

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''退勤時間更新-------------------------------------
        msSQL = "UPDATE TBL_職員勤務履歴 SET"
        msSQL += " 退勤時間 = シフト退勤時間"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 職員ID='" & cmb職員.SelectedValue & "'"
        msSQL += " AND 日付 >='" & dt開始日 & "'"
        msSQL += " AND 日付 <'" & dt終了日 & "'"
        msSQL += " AND 退勤時間 =''"

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        Call subシフト一覧(pro日付)
    End Sub
End Class
