Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Imports System.Console
Imports ClosedXML.Excel

Public Class frmM職員マスタ
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private mdtbl職員 As New DataTable
    Private mclsコンボ As New clsコンボボックス

    Private yomiConv As ImeComposition.ImeYomiConversion

    Private Sub frmM職員マスタ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call subクリア()
        Call mclsコンボ.職名コンボ(cmb職名)
        Call mclsコンボ.資格コンボ(cmb資格)
        Call mclsコンボ.担当コンボ(cmb担当)
        Call mclsコンボ.勤務区分コンボ(cmb勤務区分)
        Call mclsコンボ.部署コンボ(cmb部署1)
        Call mclsコンボ.部署コンボ(cmb部署2)
        Call mclsコンボ.部署コンボ(cmb部署3)

        'カナ自動入力
        yomiConv = New ImeComposition.ImeYomiConversion(txt職員氏名, txtフリガナ)

        mdtbl職員 = dtbl職員一覧取得()
        With dgv一覧
            .DataSource = mdtbl職員
            Call グリッド並び()
        End With

    End Sub

    Private Sub グリッド並び()
        ''グリッド表示順
        With dgv一覧
            .Columns("colID").DisplayIndex = 0
            .Columns("col施設ID").DisplayIndex = 1
            .Columns("col職員ID").DisplayIndex = 2
            .Columns("col職員氏名").DisplayIndex = 3
            .Columns("colフリガナ").DisplayIndex = 4
            .Columns("colパスワード").DisplayIndex = 5
            .Columns("col生年月日").DisplayIndex = 6
            .Columns("col入職日").DisplayIndex = 7
            .Columns("col入職時経歴年").DisplayIndex = 8
            .Columns("col入職時経歴月").DisplayIndex = 9
            .Columns("col職名").DisplayIndex = 10
            .Columns("col資格").DisplayIndex = 11
            .Columns("col担当").DisplayIndex = 12
            .Columns("col勤務区分").DisplayIndex = 13
            .Columns("col月給").DisplayIndex = 14
            .Columns("col時給単価").DisplayIndex = 15
            .Columns("col超勤単価").DisplayIndex = 16
            .Columns("col交通費").DisplayIndex = 17


            .Columns("col部署1").DisplayIndex = 18
            .Columns("col部署1カウント").DisplayIndex = 19
            .Columns("col部署2").DisplayIndex = 20
            .Columns("col部署2カウント").DisplayIndex = 21
            .Columns("col部署3").DisplayIndex = 22
            .Columns("col部署3カウント").DisplayIndex = 23

            .Columns("col月曜出勤時間").DisplayIndex = 24
            .Columns("col月曜退勤時間").DisplayIndex = 25
            .Columns("col火曜出勤時間").DisplayIndex = 26
            .Columns("col火曜退勤時間").DisplayIndex = 27
            .Columns("col水曜出勤時間").DisplayIndex = 28
            .Columns("col水曜退勤時間").DisplayIndex = 29
            .Columns("col木曜出勤時間").DisplayIndex = 30
            .Columns("col木曜退勤時間").DisplayIndex = 31
            .Columns("col金曜出勤時間").DisplayIndex = 32
            .Columns("col金曜退勤時間").DisplayIndex = 33
            .Columns("col土曜出勤時間").DisplayIndex = 34
            .Columns("col土曜退勤時間").DisplayIndex = 35
            .Columns("col日曜出勤時間").DisplayIndex = 36
            .Columns("col日曜退勤時間").DisplayIndex = 37
            .Columns("col備考").DisplayIndex = 38
            .Columns("col退職日").DisplayIndex = 39

        End With

    End Sub

    Private Sub btn生年月日_Click(sender As Object, e As EventArgs) Handles btn生年月日.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt生年月日.Text
        Call sfrm.ShowDialog()
        txt生年月日.Text = sfrm.日付
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        With txt職員ID
            Select Case .Text
                Case ""
                    txt職員ID.Text = n職員ID取得()
                Case Else
            End Select
        End With

        With txt職員氏名
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("職員氏名は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        With txt生年月日
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("生年月日は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        With txt入職日
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("入職日は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        With txt入職時経歴年
            Select Case .Text
                Case ""
                    .Text = 0
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("入職時経歴年は数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt入職時経歴月
            Select Case .Text
                Case ""
                    .Text = 0
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("入職時経歴月は数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt月給
            Select Case .Text
                Case ""
                    .Text = 0
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("時間単価は数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt部署1カウント
            Select Case .Text
                Case ""
                    .Text = 0
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("部署1カウントは数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt部署2カウント
            Select Case .Text
                Case ""
                    .Text = 0
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("部署2カウントは数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt部署3カウント
            Select Case .Text
                Case ""
                    .Text = 0
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("部署3カウントは数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        Dim cDB As New clsDB
        Dim dtbl職員 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID
        Dim get職員ID As String = txt職員ID.Text

        ''TBL_職員勤務履歴更新
        msSQL = "SELECT * FROM MST_職員"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND 職員ID='" & get職員ID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl職員) ''データセット作成

        If dtbl職員.Rows.Count = 0 Then
            msSQL = " INSERT INTO MST_職員("

            msSQL += " 施設ID"
            msSQL += ",職員ID"
            msSQL += ",パスワード"
            msSQL += ",職員氏名"
            msSQL += ",フリガナ"
            msSQL += ",生年月日"
            msSQL += ",入職日"
            msSQL += ",入職時経歴年"
            msSQL += ",入職時経歴月"
            msSQL += ",職名"
            msSQL += ",資格"
            msSQL += ",担当"
            msSQL += ",勤務区分"
            msSQL += ",部署1"
            msSQL += ",部署1カウント"
            msSQL += ",部署2"
            msSQL += ",部署2カウント"
            msSQL += ",部署3"
            msSQL += ",部署3カウント"
            msSQL += ",月給"
            msSQL += ",時給単価"
            msSQL += ",超勤単価"
            msSQL += ",交通費"
            msSQL += ",月曜出勤時間"
            msSQL += ",月曜退勤時間"
            msSQL += ",火曜出勤時間"
            msSQL += ",火曜退勤時間"
            msSQL += ",水曜出勤時間"
            msSQL += ",水曜退勤時間"
            msSQL += ",木曜出勤時間"
            msSQL += ",木曜退勤時間"
            msSQL += ",金曜出勤時間"
            msSQL += ",金曜退勤時間"
            msSQL += ",土曜出勤時間"
            msSQL += ",土曜退勤時間"
            msSQL += ",日曜出勤時間"
            msSQL += ",日曜退勤時間"
            msSQL += ",備考"
            msSQL += ",退職日"

            msSQL += ")VALUES("

            msSQL += " '" & get施設ID & "'"
            msSQL += ",'" & get職員ID & "'"
            msSQL += ",'" & txtパスワード.Text & "'"
            msSQL += ",'" & txt職員氏名.Text & "'"
            msSQL += ",'" & txtフリガナ.Text & "'"
            msSQL += ",'" & txt生年月日.Text & "'"
            msSQL += ",'" & txt入職日.Text & "'"
            msSQL += ",'" & txt入職時経歴年.Text & "'"
            msSQL += ",'" & txt入職時経歴月.Text & "'"
            msSQL += ",'" & cmb職名.SelectedValue & "'"
            msSQL += ",'" & cmb資格.Text & "'"
            msSQL += ",'" & cmb担当.Text & "'"
            msSQL += ",'" & cmb勤務区分.Text & "'"
            msSQL += ",'" & cmb部署1.Text & "'"
            msSQL += ",'" & txt部署1カウント.Text & "'"
            msSQL += ",'" & cmb部署2.Text & "'"
            msSQL += ",'" & txt部署2カウント.Text & "'"
            msSQL += ",'" & cmb部署3.Text & "'"
            msSQL += ",'" & txt部署3カウント.Text & "'"
            msSQL += ",'" & txt月給.Text & "'"
            msSQL += ",'" & txt時給単価.Text & "'"
            msSQL += ",'" & txt超勤単価.Text & "'"
            msSQL += ",'" & txt交通費.Text & "'"
            If dtp月曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp月曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp月曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp月曜退勤時間.Text & "'" Else msSQL += ",''"
            If dtp火曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp火曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp火曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp火曜退勤時間.Text & "'" Else msSQL += ",''"
            If dtp水曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp水曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp水曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp水曜退勤時間.Text & "'" Else msSQL += ",''"
            If dtp木曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp木曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp木曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp木曜退勤時間.Text & "'" Else msSQL += ",''"
            If dtp金曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp金曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp金曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp金曜退勤時間.Text & "'" Else msSQL += ",''"
            If dtp土曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp土曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp土曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp土曜退勤時間.Text & "'" Else msSQL += ",''"
            If dtp日曜出勤時間.Text <> "00:00" Then msSQL += ",'" & dtp日曜出勤時間.Text & "'" Else msSQL += ",''"
            If dtp日曜退勤時間.Text <> "00:00" Then msSQL += ",'" & dtp日曜退勤時間.Text & "'" Else msSQL += ",''"
            msSQL += ",'" & txt備考.Text & "'"
            msSQL += ",NULL"

            msSQL += ")"

        Else
            Select Case sfrmメッセージ.ShowDialog("職員ID:" & get職員ID & "の修正を行います。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Case ShowDialog.OK
                Case Else
                    Exit Sub
            End Select

            ''退勤
            msSQL = " UPDATE MST_職員 SET "
            msSQL += " パスワード='" & txtパスワード.Text & "'"
            msSQL += ",職員氏名='" & txt職員氏名.Text & "'"
            msSQL += ",フリガナ='" & txtフリガナ.Text & "'"
            msSQL += ",生年月日='" & txt生年月日.Text & "'"
            msSQL += ",入職日='" & txt入職日.Text & "'"
            msSQL += ",入職時経歴年='" & txt入職時経歴年.Text & "'"
            msSQL += ",入職時経歴月='" & txt入職時経歴月.Text & "'"
            msSQL += ",職名='" & cmb職名.SelectedValue & "'"
            msSQL += ",資格='" & cmb資格.Text & "'"
            msSQL += ",担当='" & cmb担当.Text & "'"
            msSQL += ",勤務区分='" & cmb勤務区分.Text & "'"
            msSQL += ",部署1='" & cmb部署1.Text & "'"
            msSQL += ",部署1カウント='" & txt部署1カウント.Text & "'"
            msSQL += ",部署2='" & cmb部署2.Text & "'"
            msSQL += ",部署2カウント='" & txt部署2カウント.Text & "'"
            msSQL += ",部署3='" & cmb部署3.Text & "'"
            msSQL += ",部署3カウント='" & txt部署3カウント.Text & "'"
            msSQL += ",月給='" & txt月給.Text & "'"
            msSQL += ",時給単価='" & txt時給単価.Text & "'"
            msSQL += ",超勤単価='" & txt超勤単価.Text & "'"
            msSQL += ",交通費='" & txt交通費.Text & "'"
            If dtp月曜出勤時間.Text <> "00:00" Then msSQL += ",月曜出勤時間='" & dtp月曜出勤時間.Text & "'" Else msSQL += ",月曜出勤時間=''"
            If dtp月曜退勤時間.Text <> "00:00" Then msSQL += ",月曜退勤時間='" & dtp月曜退勤時間.Text & "'" Else msSQL += ",月曜退勤時間=''"
            If dtp火曜出勤時間.Text <> "00:00" Then msSQL += ",火曜出勤時間='" & dtp火曜出勤時間.Text & "'" Else msSQL += ",火曜出勤時間=''"
            If dtp火曜退勤時間.Text <> "00:00" Then msSQL += ",火曜退勤時間='" & dtp火曜退勤時間.Text & "'" Else msSQL += ",火曜退勤時間=''"
            If dtp水曜出勤時間.Text <> "00:00" Then msSQL += ",水曜出勤時間='" & dtp水曜出勤時間.Text & "'" Else msSQL += ",水曜出勤時間=''"
            If dtp水曜退勤時間.Text <> "00:00" Then msSQL += ",水曜退勤時間='" & dtp水曜退勤時間.Text & "'" Else msSQL += ",水曜退勤時間=''"
            If dtp木曜出勤時間.Text <> "00:00" Then msSQL += ",木曜出勤時間='" & dtp木曜出勤時間.Text & "'" Else msSQL += ",木曜出勤時間=''"
            If dtp木曜退勤時間.Text <> "00:00" Then msSQL += ",木曜退勤時間='" & dtp木曜退勤時間.Text & "'" Else msSQL += ",木曜退勤時間=''"
            If dtp金曜出勤時間.Text <> "00:00" Then msSQL += ",金曜出勤時間='" & dtp金曜出勤時間.Text & "'" Else msSQL += ",金曜出勤時間=''"
            If dtp金曜退勤時間.Text <> "00:00" Then msSQL += ",金曜退勤時間='" & dtp金曜退勤時間.Text & "'" Else msSQL += ",金曜退勤時間=''"
            If dtp土曜出勤時間.Text <> "00:00" Then msSQL += ",土曜出勤時間='" & dtp土曜出勤時間.Text & "'" Else msSQL += ",土曜出勤時間=''"
            If dtp土曜退勤時間.Text <> "00:00" Then msSQL += ",土曜退勤時間='" & dtp土曜退勤時間.Text & "'" Else msSQL += ",土曜退勤時間=''"
            If dtp日曜出勤時間.Text <> "00:00" Then msSQL += ",日曜出勤時間='" & dtp日曜出勤時間.Text & "'" Else msSQL += ",日曜出勤時間=''"
            If dtp日曜退勤時間.Text <> "00:00" Then msSQL += ",日曜退勤時間='" & dtp日曜退勤時間.Text & "'" Else msSQL += ",日曜退勤時間=''"
            msSQL += ",備考='" & txt備考.Text & "'"

            If txt退職日.Text = "" Then
                msSQL += ",退職日=NULL"
            Else
                msSQL += ",退職日='" & txt退職日.Text & "'"
            End If

            msSQL += " WHERE 施設ID='" & get施設ID & "'"
            msSQL += " AND 職員ID='" & get職員ID & "'"

            CType(sender, Button).ForeColor = Color.Red
        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()

        mdtbl職員 = dtbl職員一覧取得()
        With dgv一覧
            .DataSource = mdtbl職員
            Call グリッド並び()
        End With

    End Sub



    Private Sub btn新規_Click(sender As Object, e As EventArgs) Handles btn新規.Click
        Call subクリア()

    End Sub

    Private Sub subクリア()
        txt職員ID.Text = ""
        txtパスワード.Text = ""
        txtフリガナ.Text = ""
        txt職員氏名.Text = ""
        txt生年月日.Text = ""
        txt年齢.Text = ""
        txt入職日.Text = ""
        txt入職時経歴年.Text = ""
        txt入職時経歴月.Text = ""
        txt経歴年.Text = ""
        cmb職名.SelectedValue = "0"
        cmb資格.Text = ""
        cmb担当.Text = ""
        cmb勤務区分.Text = ""
        txt月給.Text = ""

        cmb部署1.Text = ""
        txt部署1カウント.Text = ""
        cmb部署2.Text = ""
        txt部署2カウント.Text = ""
        cmb部署3.Text = ""
        txt部署3カウント.Text = ""

        chk月.Checked = True
        dtp月曜出勤時間.Text = my環境設定.通常開始
        dtp月曜退勤時間.Text = my環境設定.通常終了
        chk火.Checked = True
        dtp火曜出勤時間.Text = my環境設定.通常開始
        dtp火曜退勤時間.Text = my環境設定.通常終了
        chk水.Checked = True
        dtp水曜出勤時間.Text = my環境設定.通常開始
        dtp水曜退勤時間.Text = my環境設定.通常終了
        chk木.Checked = True
        dtp木曜出勤時間.Text = my環境設定.通常開始
        dtp木曜退勤時間.Text = my環境設定.通常終了
        chk金.Checked = True
        dtp金曜出勤時間.Text = my環境設定.通常開始
        dtp金曜退勤時間.Text = my環境設定.通常終了
        chk土.Checked = True
        dtp土曜出勤時間.Text = my環境設定.通常開始
        dtp土曜退勤時間.Text = my環境設定.通常終了
        chk日.Checked = False
        dtp日曜出勤時間.Text = "00:00"
        dtp日曜退勤時間.Text = "00:00"
        txt備考.Text = ""

        txt職員ID.Text = n職員ID取得()
        Call txtパスワード.Select()
    End Sub

    Private Function dtbl職員一覧取得(Optional set職員ID As Integer = 0) As DataTable
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_職員"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        If set職員ID <> 0 Then msSQL += " AND 職員ID='" & set職員ID & "'"
        msSQL += " ORDER BY 退職日,CONVERT(int,職員ID)"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        Return myTable

    End Function

    Private Function n職員ID取得() As Integer
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        msSQL = "SELECT TOP 1 職員ID FROM MST_職員"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " ORDER BY CONVERT(int,職員ID) DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1
        Else
            Return CInt(myTable.Rows(0)("職員ID")) + 1
        End If


    End Function

    Private Sub txt生年月日_Leave(sender As Object, e As EventArgs) Handles txt生年月日.Leave

        txt生年月日.Text = s日付変換(txt生年月日.Text)
        If txt生年月日.Text = "" Then Exit Sub

        txt年齢.Text = n年齢取得(txt生年月日.Text)

    End Sub

    Private Sub txt入職日_Leave(sender As Object, e As EventArgs) Handles txt入職日.Leave, txt入職時経歴年.Leave, txt入職時経歴月.Leave
        Dim n年 As Integer
        Dim n月 As Integer
        txt入職日.Text = s日付変換(txt入職日.Text)
        If txt入職日.Text = "" Then Exit Sub
        If IsNumeric(txt入職時経歴年.Text) = False Then
            n年 = 0
        Else
            n年 = txt入職時経歴年.Text
        End If
        If IsNumeric(txt入職時経歴月.Text) = False Then
            n月 = 0
        Else
            n月 = txt入職時経歴月.Text
        End If

        Call s経験年月取得(txt入職日.Text, n年, n月, txt経歴年.Text, txt経歴月.Text)
        'txt経歴年.Text = n経験年数取得(txt入職日.Text, n年)
        'txt経歴月.Text = n経験月数取得(txt入職日.Text, n月)
    End Sub

    Private Sub dgv一覧_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv一覧.CellFormatting
        Dim strStatus As String
        Dim setColor As Color

        If e.RowIndex >= 0 Then
            ''MsgBox(dgv_ASSYList.Rows(e.RowIndex).Cells(0).Value)
            strStatus = dgv一覧.Rows(e.RowIndex).Cells("col退職日").Value.ToString ''連番情報取得

            Select Case strStatus
                Case <> "" ''欠品
                    setColor = Color.LightGray
            End Select

            If strStatus <> "" Then
                Dim i_RowCount As Integer
                For i_RowCount = 0 To dgv一覧.ColumnCount - 1
                    dgv一覧.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = setColor

                Next
            End If
        End If
    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim dtbl職員 As DataTable
        Dim get職員ID, get職員氏名 As String

        Call subクリア()
        get職員ID = Trim(dgv一覧.Rows(e.RowIndex).Cells("col職員ID").Value.ToString)
        txt職員ID.Text = get職員ID

        dtbl職員 = dtbl職員一覧取得(txt職員ID.Text)
        For Each get行 As DataRow In dtbl職員.Rows
            txtパスワード.Text = get行("パスワード").ToString
            get職員氏名 = get行("職員氏名").ToString
            txt職員氏名.Text = get職員氏名
            txt生年月日.Text = CDate(get行("生年月日")).ToString("yyyy/MM/dd")
            txt年齢.Text = n年齢取得(txt生年月日.Text)

            txt入職日.Text = CDate(get行("入職日")).ToString("yyyy/MM/dd")
            txt入職時経歴年.Text = get行("入職時経歴年").ToString
            txt入職時経歴月.Text = get行("入職時経歴月").ToString
            Call s経験年月取得(txt入職日.Text, txt入職時経歴年.Text, txt入職時経歴月.Text, txt経歴年.Text, txt経歴月.Text)
            'txt経歴年.Text = n経験年数取得(txt入職日.Text, txt入職時経歴年.Text)
            'txt経歴月.Text = n経験月数取得(txt入職日.Text, txt入職時経歴月.Text)

            cmb職名.SelectedValue = get行("職名").ToString
            cmb資格.Text = get行("資格").ToString
            cmb担当.Text = get行("担当").ToString
            cmb勤務区分.Text = get行("勤務区分").ToString

            cmb部署1.Text = get行("部署1").ToString
            txt部署1カウント.Text = CDec(get行("部署1カウント")).ToString("0.#")
            cmb部署2.Text = get行("部署2").ToString
            txt部署2カウント.Text = CDec(get行("部署2カウント")).ToString("0.#")
            cmb部署3.Text = get行("部署3").ToString
            txt部署3カウント.Text = CDec(get行("部署3カウント")).ToString("0.#")

            txt月給.Text = get行("月給").ToString
            txt時給単価.Text = get行("時給単価").ToString
            txt超勤単価.Text = get行("超勤単価").ToString
            txt交通費.Text = get行("交通費").ToString
            If get行("月曜出勤時間").ToString <> "" Then dtp月曜出勤時間.Text = get行("月曜出勤時間").ToString Else dtp月曜出勤時間.Text = "00:00"
            If get行("月曜退勤時間").ToString <> "" Then dtp月曜退勤時間.Text = get行("月曜退勤時間").ToString Else dtp月曜退勤時間.Text = "00:00"
            If get行("火曜出勤時間").ToString <> "" Then dtp火曜出勤時間.Text = get行("火曜出勤時間").ToString Else dtp火曜出勤時間.Text = "00:00"
            If get行("火曜退勤時間").ToString <> "" Then dtp火曜退勤時間.Text = get行("火曜退勤時間").ToString Else dtp火曜退勤時間.Text = "00:00"
            If get行("水曜出勤時間").ToString <> "" Then dtp水曜出勤時間.Text = get行("水曜出勤時間").ToString Else dtp水曜出勤時間.Text = "00:00"
            If get行("水曜退勤時間").ToString <> "" Then dtp水曜退勤時間.Text = get行("水曜退勤時間").ToString Else dtp水曜退勤時間.Text = "00:00"
            If get行("木曜出勤時間").ToString <> "" Then dtp木曜出勤時間.Text = get行("木曜出勤時間").ToString Else dtp木曜出勤時間.Text = "00:00"
            If get行("木曜退勤時間").ToString <> "" Then dtp木曜退勤時間.Text = get行("木曜退勤時間").ToString Else dtp木曜退勤時間.Text = "00:00"
            If get行("金曜出勤時間").ToString <> "" Then dtp金曜出勤時間.Text = get行("金曜出勤時間").ToString Else dtp金曜出勤時間.Text = "00:00"
            If get行("金曜退勤時間").ToString <> "" Then dtp金曜退勤時間.Text = get行("金曜退勤時間").ToString Else dtp金曜退勤時間.Text = "00:00"
            If get行("土曜出勤時間").ToString <> "" Then dtp土曜出勤時間.Text = get行("土曜出勤時間").ToString Else dtp土曜出勤時間.Text = "00:00"
            If get行("土曜退勤時間").ToString <> "" Then dtp土曜退勤時間.Text = get行("土曜退勤時間").ToString Else dtp土曜退勤時間.Text = "00:00"
            If get行("日曜出勤時間").ToString <> "" Then dtp日曜出勤時間.Text = get行("日曜出勤時間").ToString Else dtp日曜出勤時間.Text = "00:00"
            If get行("日曜退勤時間").ToString <> "" Then dtp日曜退勤時間.Text = get行("日曜退勤時間").ToString Else dtp日曜退勤時間.Text = "00:00"

            txt備考.Text = get行("備考").ToString
            If get行("退職日").ToString = "" Then
                txt退職日.Text = ""
            Else
                txt退職日.Text = CDate(get行("退職日")).ToString("yyyy/MM/dd")
            End If

        Next

        Dim sfrm As New sfrm勤務状況
        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "col職員ID"
                sfrm.日付 = New Date(Now.Year, Now.Month, 1)
                sfrm.職員 = get職員ID
                Call sfrm.ShowDialog()



        End Select
    End Sub

    Private Sub sub勤務管理簿(set年度 As Integer, set職員ID As String, set職員氏名 As String)
        Dim cDB As New clsDB
        Dim mdtbl勤務履歴取得 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID
        Dim sテンプレートパス As String = "Temp\勤務管理簿.xlsx"
        Dim getExcelファイル As String

        Try
            'Excelファイルを開く
            Using workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)

                ''日付、曜日設定==========================================================================
                Dim get開始日, get終了日 As Date
                get開始日 = New Date(set年度, 4, 1)
                get終了日 = DateAdd("yyyy", 1, get開始日)

                Dim worksheet As ClosedXML.Excel.IXLWorksheet
                Dim dtカウント As Date = get開始日
                Do Until dtカウント = get終了日
                    If dtカウント.Day = 1 Then
                        ''シート切り替え---------------------------------------------------------------
                        worksheet = workbook.Worksheet(dtカウント.Month.ToString)

                        ''勤務履歴表示-----------------------------------------------------------------
                        Call mdtbl勤務履歴取得.Clear()    ''データ初期化

                        msSQL = "SELECT * "
                        'msSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.職員ID=TBL_職員勤務履歴.職員ID)as 職員名"
                        msSQL += " FROM TBL_職員勤務履歴"
                        msSQL += " WHERE 施設ID='" & get施設ID & "'"
                        msSQL += " AND 職員ID='" & set職員ID & "'"
                        msSQL += " AND 日付>='" & dtカウント & "'"
                        msSQL += " AND 日付 < '" & DateAdd("M", 1, dtカウント) & "'"

                        mCommand = cDB.getsqlComand(msSQL)
                        mSDA.SelectCommand = mCommand
                        Call mSDA.Fill(mdtbl勤務履歴取得) ''データセット作成

                        worksheet.Cell(3, 2).Value = set職員氏名
                        worksheet.Cell(2, 2).Value = set年度 & "年度　職員勤務管理簿　" & dtカウント.Month.ToString & "月"

                        Dim n日 As Integer
                        Dim dt日付 As Date
                        For Each get行 As DataRow In mdtbl勤務履歴取得.Rows
                            dt日付 = get行("日付")
                            n日 = dt日付.Day

                            ''位置を指定してセルを取得する
                            worksheet.Cell(n日 + 8, 4).Value = get行("シフト出勤時間") & "～" & get行("シフト退勤時間").ToString
                            worksheet.Cell(n日 + 8, 5).Value = get行("出勤時間").ToString
                            worksheet.Cell(n日 + 8, 6).Value = get行("退勤時間").ToString
                            worksheet.Cell(n日 + 8, 3).Value = dt日付.ToString("ddd")

                        Next
                    End If

                    worksheet.Cell(dtカウント.Day + 8, 2).Value = dtカウント.Day
                    worksheet.Cell(dtカウント.Day + 8, 3).Value = dtカウント.ToString("ddd")

                    dtカウント = DateAdd("d", 1, dtカウント)
                Loop

                'ワークブックを保存する===========================================================================================
                Using sfd As SaveFileDialog = New SaveFileDialog
                    'デフォルトのファイル名を指定します
                    sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
                    sfd.FileName = "勤務管理簿" & set職員ID
                    sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

                    If sfd.ShowDialog() = DialogResult.OK Then
                        getExcelファイル = sfd.FileName
                        workbook.SaveAs(getExcelファイル)     ''別ブックで保存

                        ''作成ファイルオープン
                        Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                                    & "作成ファイルを開きますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            Case vbOK
                                Dim execProc As New Process
                                With execProc
                                    .StartInfo.FileName = getExcelファイル
                                    .Start()
                                End With
                        End Select
                    End If
                End Using

            End Using

        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub btn職員名簿_Click(sender As Object, e As EventArgs) Handles btn職員名簿.Click

        Dim n経歴年, n経歴月 As Integer
        Dim sテンプレートパス As String = "Temp\職員名簿.xlsx"
        Dim getExcelファイル As String

        Try
            'Excelファイルを開く
            Using workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)
                'ワークシートを取得する
                Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("Sheet1")

                Dim cel施設名 = worksheet.Cell(5, "I") ' 行番号と列名でも指定可能
                cel施設名.Value = my環境設定.施設名

                Dim cel現在 = worksheet.Cell(6, "I") ' 行番号と列名でも指定可能
                cel現在.Value = Now.Date.ToString("yyyy年M月d日現在")

                Dim n行カウント As Integer = 9
                For Each get行 As DataRow In mdtbl職員.Rows
                    '位置を指定してセルを取得する
                    Dim cel職名 = worksheet.Cell(n行カウント, 2) ' 行番号と列名でも指定可能
                    cel職名.Value = get行("職名").ToString

                    Dim cel職員名 = worksheet.Cell(n行カウント, 3) ' 行番号と列名でも指定可能
                    cel職員名.Value = get行("職員氏名").ToString

                    Dim cel年齢 = worksheet.Cell(n行カウント, 4) ' 行番号と列名でも指定可能
                    cel年齢.Value = n年齢取得(get行("生年月日").ToString)

                    Dim cel経験年月 = worksheet.Cell(n行カウント, 5) ' 行番号と列名でも指定可能
                    cel経験年月.Value = s経験年月取得(get行("入職日").ToString, get行("入職時経歴年").ToString, get行("入職時経歴月").ToString, n経歴年, n経歴月)

                    Dim cel資格 = worksheet.Cell(n行カウント, 6) ' 行番号と列名でも指定可能
                    cel資格.Value = get行("資格").ToString

                    Dim cel担当 = worksheet.Cell(n行カウント, 7) ' 行番号と列名でも指定可能
                    cel担当.Value = get行("担当").ToString

                    Dim cel勤務区分 = worksheet.Cell(n行カウント, 8) ' 行番号と列名でも指定可能
                    cel勤務区分.Value = get行("勤務区分").ToString

                    Dim cel備考 = worksheet.Cell(n行カウント, 9) ' 行番号と列名でも指定可能
                    cel備考.Value = get行("備考").ToString

                    n行カウント += 1
                Next

                'ワークブックを保存する
                Using sfd As SaveFileDialog = New SaveFileDialog
                    'デフォルトのファイル名を指定します
                    sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
                    sfd.FileName = "職員名簿"
                    sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

                    If sfd.ShowDialog() = DialogResult.OK Then
                        getExcelファイル = sfd.FileName
                        workbook.SaveAs(getExcelファイル)     ''別ブックで保存

                        ''作成ファイルオープン
                        Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                                    & "作成ファイルを開きますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            Case vbOK
                                Dim execProc As New Process
                                With execProc
                                    .StartInfo.FileName = getExcelファイル
                                    .Start()
                                End With
                        End Select

                    End If
                End Using
            End Using



        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btn退職日_Click(sender As Object, e As EventArgs) Handles btn退職日.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt退職日.Text
        Call sfrm.ShowDialog()
        txt退職日.Text = sfrm.日付
    End Sub

    Private Sub btn資格取得_Click(sender As Object, e As EventArgs) Handles txt生年月日.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt生年月日.Text
        Call sfrm.ShowDialog()
        txt生年月日.Text = sfrm.日付
    End Sub

    Private Sub btn入職日_Click(sender As Object, e As EventArgs) Handles btn入職日.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt入職日.Text
        Call sfrm.ShowDialog()
        txt入職日.Text = sfrm.日付
    End Sub

    Private Sub chk月_DockChanged(sender As Object, e As EventArgs) Handles chk月.CheckedChanged
        Select Case chk月.Checked
            Case True
                dtp月曜出勤時間.Enabled = True
                dtp月曜退勤時間.Enabled = True
                dtp月曜出勤時間.Text = my環境設定.通常開始
                dtp月曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp月曜出勤時間.Enabled = False
                dtp月曜退勤時間.Enabled = False
                dtp月曜出勤時間.Text = "00:00"
                dtp月曜退勤時間.Text = "00:00"

        End Select
    End Sub

    Private Sub chk火_CheckedChanged(sender As Object, e As EventArgs) Handles chk火.CheckedChanged
        Select Case chk火.Checked
            Case True
                dtp火曜出勤時間.Enabled = True
                dtp火曜退勤時間.Enabled = True
                dtp火曜出勤時間.Text = my環境設定.通常開始
                dtp火曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp火曜出勤時間.Enabled = False
                dtp火曜退勤時間.Enabled = False
                dtp火曜出勤時間.Text = "00:00"
                dtp火曜退勤時間.Text = "00:00"

        End Select
    End Sub

    Private Sub chk水_CheckedChanged(sender As Object, e As EventArgs) Handles chk水.CheckedChanged
        Select Case chk水.Checked
            Case True
                dtp水曜出勤時間.Enabled = True
                dtp水曜退勤時間.Enabled = True
                dtp水曜出勤時間.Text = my環境設定.通常開始
                dtp水曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp水曜出勤時間.Enabled = False
                dtp水曜退勤時間.Enabled = False
                dtp水曜出勤時間.Text = "00:00"
                dtp水曜退勤時間.Text = "00:00"

        End Select
    End Sub
    Private Sub chk木_DockChanged(sender As Object, e As EventArgs) Handles chk木.CheckedChanged
        Select Case chk木.Checked
            Case True
                dtp木曜出勤時間.Enabled = True
                dtp木曜退勤時間.Enabled = True
                dtp木曜出勤時間.Text = my環境設定.通常開始
                dtp木曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp木曜出勤時間.Enabled = False
                dtp木曜退勤時間.Enabled = False
                dtp木曜出勤時間.Text = "00:00"
                dtp木曜退勤時間.Text = "00:00"

        End Select
    End Sub

    Private Sub chk金_DockChanged(sender As Object, e As EventArgs) Handles chk金.CheckedChanged
        Select Case chk金.Checked
            Case True
                dtp金曜出勤時間.Enabled = True
                dtp金曜退勤時間.Enabled = True
                dtp金曜出勤時間.Text = my環境設定.通常開始
                dtp金曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp金曜出勤時間.Enabled = False
                dtp金曜退勤時間.Enabled = False
                dtp金曜出勤時間.Text = "00:00"
                dtp金曜退勤時間.Text = "00:00"

        End Select
    End Sub

    Private Sub chk土_DockChanged(sender As Object, e As EventArgs) Handles chk土.CheckedChanged
        Select Case chk土.Checked
            Case True
                dtp土曜出勤時間.Enabled = True
                dtp土曜退勤時間.Enabled = True
                dtp土曜出勤時間.Text = my環境設定.通常開始
                dtp土曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp土曜出勤時間.Enabled = False
                dtp土曜退勤時間.Enabled = False
                dtp土曜出勤時間.Text = "00:00"
                dtp土曜退勤時間.Text = "00:00"

        End Select
    End Sub

    Private Sub chk日_DockChanged(sender As Object, e As EventArgs) Handles chk日.CheckedChanged
        Select Case chk日.Checked
            Case True
                dtp日曜出勤時間.Enabled = True
                dtp日曜退勤時間.Enabled = True
                dtp日曜出勤時間.Text = my環境設定.通常開始
                dtp日曜退勤時間.Text = my環境設定.通常終了

            Case Else
                dtp日曜出勤時間.Enabled = False
                dtp日曜退勤時間.Enabled = False
                dtp日曜出勤時間.Text = "00:00"
                dtp日曜退勤時間.Text = "00:00"

        End Select
    End Sub

    Private Sub txt職員氏名_Enter(sender As Object, e As EventArgs) Handles txt職員氏名.Enter
        yomiConv.Enabled = True
    End Sub

    Private Sub txt職員氏名_Leave(sender As Object, e As EventArgs) Handles txt職員氏名.Leave
        yomiConv.Enabled = False
    End Sub

    Private Sub btn勤務管理簿_Click(sender As Object, e As EventArgs) Handles btn勤務管理簿.Click
        Select Case sfrmメッセージ.ShowDialog("勤務管理簿の一括作成を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Case Windows.Forms.DialogResult.OK
            Case Else
                Exit Sub
        End Select

        For Each get職員 As DataRow In mdtbl職員.Rows
            Select Case Now.Month
                Case <= 3
                    Call sub勤務管理簿Excel(Now.Year - 1, get職員("職員ID"), False)
                Case Else
                    Call sub勤務管理簿Excel(Now.Year, get職員("職員ID"), False)
            End Select
        Next

        sfrmメッセージ.ShowDialog("勤務管理簿の作成を完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class