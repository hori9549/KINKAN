Imports System.Data
Imports System.Data.SqlClient
Imports ClosedXML.Excel
Module mdlCommon
    Public my環境設定 As cls環境設定
    Public MS職員ID As String
    Public MS職員名 As String

    Public Function s日付変換(ByVal set日付 As String) As String
        Dim ret変換後 As String = ""

        ''空白であれば処理は終わり
        If set日付 = "" Then Return ""

        ''日付であればOK
        If IsDate(set日付) = True Then Return CDate(set日付).ToString("yyyy/MM/dd")

        Try
            Select Case set日付.Length
                Case Is <= 2
                    ret変換後 = Now.Year & "/" & Now.Month & "/" & CInt(set日付).ToString("00")

                Case Is <= 4
                    set日付 = CInt(set日付).ToString("0000")
                    ret変換後 = Now.Year & "/" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2)

                Case 6
                    If set日付.Substring(0, 2) > 50 Then
                        ret変換後 = "19" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2) & "/" & set日付.Substring(4, 2)
                    Else
                        ret変換後 = "20" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2) & "/" & set日付.Substring(4, 2)
                    End If

                Case 8
                    ret変換後 = set日付.Substring(0, 4) & "/" & set日付.Substring(4, 2) & "/" & set日付.Substring(6, 2)

            End Select
        Catch ex As Exception
            ret変換後 = ""
        End Try

        If IsDate(ret変換後) = True Then
            Return CDate(ret変換後).ToString("yyyy/MM/dd")
        Else
            sfrmメッセージ.ShowDialog("日付に変換できません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ""
        End If
    End Function

    Public Function n年齢取得(set生年月日 As Date) As Integer
        n年齢取得 = 0
        If IsDate(set生年月日) = False Then Exit Function

        Dim n生年月日 As Integer = set生年月日.ToString("yyyyMMdd")
        Dim n本日 As Integer = Now.Date.ToString("yyyyMMdd")
        Dim n年齢 As Decimal = (n本日 - n生年月日) / 10000

        Return Math.Floor(n年齢)  ''小数点切り捨て
    End Function

    Public Function s経験年月取得(set入職日 As Date, set入職前履歴年 As String, set入職前履歴月 As String,
                                    ByRef ret経験年 As String, ByRef ret経験月 As String) As String

        If IsDate(set入職日) = False Then Exit Function
        ret経験月 = 0
        ret経験年 = 0
        Dim n月 As Integer = 0
        Dim n年 As Integer = 0
        Dim n年繰 As Integer = 0

        If IsNumeric(set入職前履歴月) = True Then n月 = set入職前履歴月
        If IsNumeric(set入職前履歴年) = True Then n年 = set入職前履歴年

        ''月計算-------------------------------------------------------
        If Now.Month >= set入職日.Month Then
            n月 = Now.Month - set入職日.Month
        Else
            n月 = 12 + Now.Month - set入職日.Month
        End If

        ret経験月 = CInt(set入職前履歴月) + n月 ''小数点切り捨て
        ret経験月 = ret経験月 Mod 12
        n年繰 = Math.Floor(ret経験月 / 12)

        ''年計算--------------------------------------------------------
        Dim n入職日 As Integer = set入職日.ToString("yyyyMMdd")
        Dim n本日 As Integer = Now.Date.ToString("yyyyMMdd")
        Dim n年数 As Decimal = (n本日 - n入職日) / 10000

        ret経験年 = Math.Floor(n年数) + n年繰 + n年

        ''戻り値--------------------------------------------------------
        Return ret経験年 & "年" & ret経験月 & "ヶ月"

    End Function


    Public Sub sub勤務管理簿Excel(set年度 As Integer, set職員ID As String, Optional set表示 As Boolean = True)
        Dim cDB As New clsDB
        Dim mdtbl勤務履歴取得 As New DataTable
        Dim mdtbl超過勤務取得 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID
        Dim sテンプレートパス As String = "Temp\勤務管理簿.xlsx"
        Dim getExcelファイル As String
        Dim dtbl職員 As New DataTable
        Dim s職員名 As String = ""
        Dim n月給 As Integer = 0
        Dim n時給単価 As Integer = 0
        Dim n超勤単価 As Integer = 0
        Dim n交通費 As Integer = 0
        Dim sSQL As String
        Dim myCommand As SqlCommand
        Dim mySDA As New SqlDataAdapter

        sSQL = "SELECT * FROM MST_職員 WHERE 職員ID='" & set職員ID & "'"
        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員) ''データセット作成

        If dtbl職員.Rows.Count <> 0 Then
            s職員名 = dtbl職員.Rows(0)("職員氏名")
            n月給 = dtbl職員.Rows(0)("月給")
            n時給単価 = dtbl職員.Rows(0)("時給単価")
            n超勤単価 = dtbl職員.Rows(0)("超勤単価")
            n交通費 = dtbl職員.Rows(0)("交通費")

        End If

        Try
            'Excelファイルを開く
            Using getWorkBook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)

                ''日付、曜日設定==========================================================================
                Dim get開始日, get終了日 As Date
                get開始日 = New Date(set年度, 4, 1)
                get終了日 = DateAdd("yyyy", 1, get開始日)

                ''勤務履歴表示-----------------------------------------------------------------
                Call mdtbl勤務履歴取得.Clear()    ''データ初期化

                ''年度勤務データ取得-------------------------------------------------------------
                sSQL = "SELECT * "
                'sSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.職員ID=TBL_職員勤務履歴.職員ID)as 職員名"
                sSQL += " FROM TBL_職員勤務履歴"
                sSQL += " WHERE 施設ID='" & get施設ID & "'"
                sSQL += " AND 職員ID='" & set職員ID & "'"
                sSQL += " AND 日付>='" & get開始日 & "'"
                sSQL += " AND 日付 < '" & get終了日 & "'"
                sSQL += " ORDER BY　日付"

                myCommand = cDB.getsqlComand(sSQL)
                mySDA.SelectCommand = myCommand
                Call mySDA.Fill(mdtbl勤務履歴取得) ''データセット作成

                ''年度超過勤務取得-------------------------------------------------------------
                sSQL = "SELECT * "
                'sSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.職員ID=TBL_職員勤務履歴.職員ID)as 職員名"
                sSQL += " FROM TBL_職員超過勤務"
                sSQL += " WHERE 施設ID='" & get施設ID & "'"
                sSQL += " AND 職員ID='" & set職員ID & "'"
                sSQL += " AND 日付>='" & get開始日 & "'"
                sSQL += " AND 日付 < '" & get終了日 & "'"
                sSQL += " ORDER BY　日付"

                myCommand = cDB.getsqlComand(sSQL)
                mySDA.SelectCommand = myCommand
                Call mySDA.Fill(mdtbl超過勤務取得) ''データセット作成

                Dim getWorkSeat As ClosedXML.Excel.IXLWorksheet
                Dim dtカウント As Date = get開始日
                Do Until dtカウント = get終了日
                    If dtカウント.Day = 1 Then
                        ''シート切り替え---------------------------------------------------------------
                        getWorkSeat = getWorkBook.Worksheet(dtカウント.Month.ToString)
                        getWorkSeat.Cell(3, 2).Value = s職員名
                        getWorkSeat.Cell(2, 2).Value = set年度 & "年度　職員勤務管理簿　" & dtカウント.Month.ToString & "月"

                        getWorkSeat.Cell(3, 18).Value = n時給単価
                        getWorkSeat.Cell(4, 18).Value = n超勤単価
                        getWorkSeat.Cell(5, 18).Value = n交通費


                        ''勤務履歴抽出-----------------------------------------------------------------
                        Dim row勤務履歴() As DataRow
                        row勤務履歴 = mdtbl勤務履歴取得.Select("日付>='" & dtカウント & "' AND 日付 < '" & DateAdd("M", 1, dtカウント) & "'")

                        Dim n日 As Integer
                        Dim dt日付 As Date
                        Dim s出勤丸め, s退勤丸め As String
                        For Each get勤務履歴行 As DataRow In row勤務履歴
                            dt日付 = get勤務履歴行("日付")
                            n日 = dt日付.Day

                            ''位置を指定してセルを取得する
                            getWorkSeat.Cell(n日 + 8, 4).Value = get勤務履歴行("シフト出勤時間").ToString & "～" & get勤務履歴行("シフト退勤時間").ToString

                            s出勤丸め = s時間まるめ(get勤務履歴行("出勤時間").ToString, get勤務履歴行("シフト出勤時間").ToString, 1)
                            s退勤丸め = s時間まるめ(get勤務履歴行("退勤時間").ToString, get勤務履歴行("シフト退勤時間").ToString, 2)
                            getWorkSeat.Cell(n日 + 8, 5).Value = s出勤丸め
                            getWorkSeat.Cell(n日 + 8, 6).Value = s退勤丸め
                            If s出勤丸め = "" Then
                                getWorkSeat.Cell(n日 + 8, 7).Value = ""
                                getWorkSeat.Cell(n日 + 8, 8).Value = ""
                            Else
                                getWorkSeat.Cell(n日 + 8, 7).Value = get勤務履歴行("休憩時間").ToString
                                getWorkSeat.Cell(n日 + 8, 8).Value = s勤務時間(s出勤丸め, s退勤丸め, get勤務履歴行("休憩時間").ToString)
                            End If

                        Next

                        ''勤務履歴抽出-----------------------------------------------------------------
                        Dim row超過勤務() As DataRow
                        row超過勤務 = mdtbl超過勤務取得.Select("日付>='" & dtカウント & "' AND 日付 < '" & DateAdd("M", 1, dtカウント) & "'")

                        Dim n超過合計 As Decimal
                        For Each get超過勤務行 As DataRow In row超過勤務
                            If dt日付 <> get超過勤務行("日付") Then
                                n超過合計 = 0
                            End If

                            dt日付 = get超過勤務行("日付")
                            n日 = dt日付.Day

                            Select Case get超過勤務行("勤務内容区分").ToString
                                Case "1"
                                    getWorkSeat.Cell(n日 + 8, 5).Value = get超過勤務行("超勤時間開始").ToString
                                    If s退勤丸め = "" Then getWorkSeat.Cell(n日 + 8, 6).Value = get超過勤務行("超勤時間終了").ToString
                                Case "2", "3"
                                    If s出勤丸め = "" Then getWorkSeat.Cell(n日 + 8, 5).Value = get超過勤務行("超勤時間開始").ToString
                                    getWorkSeat.Cell(n日 + 8, 6).Value = get超過勤務行("超勤時間終了").ToString
                                Case Else
                            End Select

                            n超過合計 += CDec(s勤務時間(get超過勤務行("超勤時間開始").ToString, get超過勤務行("超勤時間終了").ToString, 0))

                            ''位置を指定してセルを取得する
                            getWorkSeat.Cell(n日 + 8, 9).Value = n超過合計.ToString("0.#")
                        Next
                    End If

                    getWorkSeat.Cell(dtカウント.Day + 8, 2).Value = dtカウント.Day
                    getWorkSeat.Cell(dtカウント.Day + 8, 3).Value = dtカウント.ToString("ddd")
                    dtカウント = DateAdd("d", 1, dtカウント)
                Loop

                'ワークブックを保存する===========================================================================================
                Using sfd As SaveFileDialog = New SaveFileDialog
                    'デフォルトのファイル名を指定します
                    sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
                    sfd.FileName = "勤務管理簿" & s職員名 & "(" & set年度 & ")"
                    sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

                    If set表示 = True Then
                        If sfd.ShowDialog() = DialogResult.OK Then
                            getExcelファイル = sfd.FileName
                            getWorkBook.SaveAs(getExcelファイル)     ''別ブックで保存

                            ''作成ファイルオープン
                            Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                                    & "作成ファイルを開きますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                Case vbOK
                                    Dim execProc As New Process
                                    With execProc
                                        .StartInfo.FileName = getExcelファイル
                                        .Start()
                                    End With
                            End Select
                        End If
                    Else
                        ''自動保存
                        getWorkBook.SaveAs(sfd.InitialDirectory & "\" & sfd.FileName & ".xlsx")     ''別ブックで保存
                    End If
                End Using

            End Using

        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub sub超過勤務一覧印刷(set年度 As Integer, Optional set職員ID As String = "", Optional set対象 As String = "")
        Dim getExcelファイル As String
        Dim cDB As New clsDB
        Dim dtbl職員, dtbl職員超過勤務 As New DataTable
        Dim sSQL As String
        Dim myCommand As SqlCommand
        Dim mySDA As New SqlDataAdapter
        Dim sタイトル As String = ""

        If InStr(set対象, "1") <> 0 Then sタイトル += "　朝延長(" & my環境設定.第1延長開始 & "～" & my環境設定.第1延長終了 & ")"
        If InStr(set対象, "2") <> 0 Then sタイトル += "　通常延長(" & my環境設定.第2延長開始 & "～" & my環境設定.第2延長終了 & ")"
        If InStr(set対象, "3") <> 0 Then sタイトル += "　夕延長(" & my環境設定.第3延長開始 & "～" & my環境設定.第3延長終了 & ")"

        Dim get開始日, get終了日 As Date
        get開始日 = New Date(set年度, 4, 1)
        get終了日 = DateAdd("yyyy", 1, get開始日)

        ''職員情報---------------------------------------------
        sSQL = "SELECT * FROM MST_職員"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        If set職員ID <> "" Then sSQL += " AND 職員ID ='" & set職員ID & "'"
        sSQL += " AND 退職日 is NULL"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員) ''データセット作成

        ''超過勤務-----------------------------------------------
        sSQL = "SELECT * FROM TBL_職員超過勤務"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        If set対象 <> "" Then sSQL += " AND 勤務内容区分 IN (" & set対象 & ")"
        sSQL += " AND 日付>='" & get開始日 & "'"
        sSQL += " AND 日付 < '" & get終了日 & "'"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員超過勤務) ''データセット作成

        ''帳票作成=================================================================================
        Dim getWorkBook = New ClosedXML.Excel.XLWorkbook

        Dim n月 As Integer = 0
        Dim dtカウント As Date = get開始日
        Dim getWorkSeet As ClosedXML.Excel.IXLWorksheet

        Dim n行 As Integer
        Do Until dtカウント = get終了日
            If n月 <> dtカウント.Month Then
                n行 = 0
                n月 = dtカウント.Month
                getWorkSeet = getWorkBook.Worksheets.Add(n月 & "月")
                getWorkSeet.PageSetup.PageOrientation = XLPageOrientation.Landscape
                getWorkSeet.PageSetup.PaperSize = XLPaperSize.A4Paper
                getWorkSeet.PageSetup.Margins.Header = 0.1
                getWorkSeet.PageSetup.Margins.Footer = 0.1
                getWorkSeet.PageSetup.Margins.Top = 0.5
                getWorkSeet.PageSetup.Margins.Bottom = 0.5
                getWorkSeet.PageSetup.Margins.Left = 0.2
                getWorkSeet.PageSetup.Margins.Right = 0.2

                Dim Cellタイトル As IXLCell = getWorkSeet.Cell(1, 2)
                Cellタイトル.Value = set年度 & "年度　超過勤務" & sタイトル
                Cellタイトル.Style.Font.FontSize = 18

                Dim Range月 As IXLRange = getWorkSeet.Range(2, 2, 3, 3)
                Range月.Merge(False)
                Range月.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                Range月.Value = "'" & n月 & "月"
                Range月.Style.Font.FontSize = 16
                Range月.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

                Dim n職員カウント As Integer = 0
                For Each get職員 As DataRow In dtbl職員.Rows
                    ''職員------------------------------------------------------------
                    Dim Range職員 As IXLRange = getWorkSeet.Range(2, 4 + n職員カウント * 2, 2, 5 + n職員カウント * 2)
                    Range職員.Merge(False)
                    Range職員.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    Range職員.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    Range職員.Value = get職員("職員氏名")

                    Dim Cell時間 As IXLCell = getWorkSeet.Cell(3, 4 + n職員カウント * 2)
                    Cell時間.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    Cell時間.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    Cell時間.Value = "時間"

                    Dim Cell単価 As IXLCell = getWorkSeet.Cell(3, 5 + n職員カウント * 2)
                    Cell単価.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    Cell単価.Value = get職員("超勤単価")

                    n職員カウント += 1
                Next

                Dim Range合計列 As IXLRange = getWorkSeet.Range(2, 4 + n職員カウント * 2, 3, 4 + n職員カウント * 2)
                Range合計列.Merge(False)
                Range合計列.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                Range合計列.Value = "合計"
                Range合計列.Style.Font.FontSize = 16
                Range合計列.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            End If

            'If dtカウント.Day = 1 Then
            Dim n日 As Integer
            Dim dt日付 As Date

            dt日付 = dtカウント
            n日 = dt日付.Day

            Dim Cell日 As IXLCell = getWorkSeet.Cell(n日 + 3, 2)
            Cell日.Value = n日 ''日
            Cell日.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            Cell日.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            Dim Cell曜日 As IXLCell = getWorkSeet.Cell(n日 + 3, 3)
            Cell曜日.Value = dt日付.ToString("ddd")  ''曜日
            Cell曜日.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            Cell曜日.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            Dim m単価合計 As String = ""
            For n列 As Integer = 0 To dtbl職員.Rows.Count
                If n列 = dtbl職員.Rows.Count Then
                    Dim Cell合計金額 As IXLCell = getWorkSeet.Cell(n日 + 3, 4 + n列 * 2)
                    Cell合計金額.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    Cell合計金額.FormulaA1 = m単価合計

                Else
                    Dim dataRows() As DataRow
                    dataRows = dtbl職員超過勤務.Select("日付 = '" & dt日付 & "' AND 職員ID='" & dtbl職員.Rows(n列)("職員ID") & "'")

                    Dim Cell職員時間 As IXLCell = getWorkSeet.Cell(n日 + 3, 4 + n列 * 2)
                    Cell職員時間.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    If dataRows.Count <> 0 Then Cell職員時間.Value = s勤務時間(dataRows(0)("超勤時間開始"), dataRows(0)("超勤時間終了"), 0)

                    Dim Cell職員単価 As IXLCell = getWorkSeet.Cell(n日 + 3, 5 + n列 * 2)
                    Cell職員単価.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    Cell職員単価.FormulaA1 = Excel英列(4 + n列 * 2) & n日 + 3 & "*" & Excel英列(5 + n列 * 2) & "3"
                    m単価合計 += "+ " & Excel英列(5 + n列 * 2) & n日 + 3
                End If

            Next

            n行 += 1
            dtカウント = DateAdd("d", 1, dtカウント)

            If n月 <> dtカウント.Month Then
                n行 += 1

                ''合計
                Dim Range合計 As IXLRange = getWorkSeet.Range(n行 + 3, 2, n行 + 3, 3)
                Range合計.Merge(False)
                Range合計.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                Range合計.Value = "合計"
                Range合計.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

                Dim 合計単価合計 As String = ""
                For n列 As Integer = 0 To dtbl職員.Rows.Count

                    If n列 = dtbl職員.Rows.Count Then
                        Dim Range合計金額 As IXLCell = getWorkSeet.Cell(n行 + 3, 4 + n列 * 2)
                        Range合計金額.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                        Range合計金額.FormulaA1 = 合計単価合計

                    Else
                        Dim Range職員時間 As IXLCell = getWorkSeet.Cell(n行 + 3, 4 + n列 * 2)
                        Range職員時間.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                        Range職員時間.FormulaA1 = "SUM(" & Excel英列(4 + n列 * 2) & "4:" & Excel英列(4 + n列 * 2) & n行 + 2 & ")"

                        Dim Range職員単価 As IXLCell = getWorkSeet.Cell(n行 + 3, 5 + n列 * 2)
                        Range職員単価.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                        Range職員単価.FormulaA1 = "SUM(" & Excel英列(5 + n列 * 2) & "4:" & Excel英列(5 + n列 * 2) & n行 + 2 & ")"
                        合計単価合計 += "+ " & Excel英列(5 + n列 * 2) & n行 + 3

                    End If

                Next

            End If
        Loop

        ''ファイル保存===========================================================================
        Using sfd As SaveFileDialog = New SaveFileDialog
            'デフォルトのファイル名を指定します
            sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
            sfd.FileName = "超過勤務一覧" & "(" & set年度 & ")"
            sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

            If sfd.ShowDialog() = DialogResult.OK Then
                getExcelファイル = sfd.FileName
                getWorkBook.SaveAs(getExcelファイル)     ''別ブックで保存

                ''作成ファイルオープン
                Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                            & "作成ファイルを開きますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case vbOK
                        Dim execProc As New Process
                        With execProc
                            .StartInfo.FileName = getExcelファイル
                            .Start()
                        End With
                End Select
            End If
        End Using

    End Sub

    Public Sub subシフトエクスポート(set年 As Integer, set月 As Integer, set職員ID As String)
        Dim getExcelファイル As String
        Dim cDB As New clsDB
        Dim dtbl職員, dtbl職員勤務履歴 As New DataTable
        Dim sSQL As String
        Dim myCommand As SqlCommand
        Dim mySDA As New SqlDataAdapter
        Dim sタイトル As String = ""

        Dim get開始日, get終了日 As Date
        get開始日 = New Date(set年, set月, 1)
        get終了日 = DateAdd(DateInterval.Month, 1, get開始日)

        ''職員情報---------------------------------------------
        sSQL = "SELECT * FROM MST_職員"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        sSQL += " AND 職員ID ='" & set職員ID & "'"
        sSQL += " AND 退職日 is NULL"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員) ''データセット作成

        ''超過勤務-----------------------------------------------
        sSQL = "SELECT * FROM TBL_職員勤務履歴"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        sSQL += " AND 職員ID ='" & set職員ID & "'"
        sSQL += " AND 日付>='" & get開始日 & "'"
        sSQL += " AND 日付 < '" & get終了日 & "'"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員勤務履歴) ''データセット作成

        ''帳票作成=================================================================================
        Dim getWorkBook = New XLWorkbook
        Dim getWorkSeet As IXLWorksheet
        getWorkSeet = getWorkBook.Worksheets.Add("Sheet1")

        If dtbl職員.Rows.Count <> 0 Then
            getWorkSeet.Cell(1, 1).Value = "職員"
            Dim Cell職員ID As IXLCell = getWorkSeet.Cell(1, 2)
            Dim Cell職員名 As IXLCell = getWorkSeet.Cell(1, 3)
            Cell職員ID.Value = dtbl職員.Rows(0)("職員ID")
            Cell職員名.Value = dtbl職員.Rows(0)("職員氏名")

        End If

        ''タイトル
        getWorkSeet.Cell(3, 1).Value = "日付"
        getWorkSeet.Cell(3, 2).Value = ""
        getWorkSeet.Cell(3, 3).Value = "シフト出勤時間"
        getWorkSeet.Cell(3, 4).Value = "シフト退勤時間"

        Dim dtカウント As Date = get開始日
        Dim n行 As Integer = 4
        Do Until dtカウント = get終了日
            Dim Cell日付 As IXLCell = getWorkSeet.Cell(n行, 1)
            Dim Cell曜日 As IXLCell = getWorkSeet.Cell(n行, 2)
            Dim Cellシフト出勤時間 As IXLCell = getWorkSeet.Cell(n行, 3)
            Cellシフト出勤時間.Style.NumberFormat.Format = "HH:mm"
            Dim Cellシフト退勤時間 As IXLCell = getWorkSeet.Cell(n行, 4)
            Cellシフト退勤時間.Style.NumberFormat.Format = "HH:mm"

            Cell日付.Value = dtカウント.ToString("yyyy/MM/dd")
            Cell曜日.Value = dtカウント.ToString("ddd")

            Dim get日 As DataRow()
            get日 = dtbl職員勤務履歴.Select("日付 ='" & dtカウント & "'")

            If get日.Length <> 0 Then
                Cellシフト出勤時間.Value = get日(0)("シフト出勤時間").ToString
                Cellシフト退勤時間.Value = get日(0)("シフト退勤時間").ToString

            End If

            n行 += 1
            dtカウント = DateAdd("d", 1, dtカウント)
        Loop

        ''ファイル保存===========================================================================
        Using sfd As SaveFileDialog = New SaveFileDialog
            'デフォルトのファイル名を指定します
            sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
            sfd.FileName = "シフト(" & dtbl職員.Rows(0)("職員氏名") & ")"
            sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

            If sfd.ShowDialog() = DialogResult.OK Then
                getExcelファイル = sfd.FileName
                getWorkBook.SaveAs(getExcelファイル)     ''別ブックで保存

                ''作成ファイルオープン
                Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                            & "作成ファイルを開きますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case vbOK
                        Dim execProc As New Process
                        With execProc
                            .StartInfo.FileName = getExcelファイル
                            .Start()
                        End With
                End Select
            End If
        End Using

    End Sub

    Public Sub subシフトインポート(set年 As Integer, set月 As Integer, set職員ID As String)
        Dim cDB As New clsDB
        Dim sSQL As String
        Dim myCommand As SqlCommand
        Dim mySDA As New SqlDataAdapter

        Dim SFD As New OpenFileDialog
        Dim get職員ID As Integer
        Dim get日付 As String
        Dim getシフト開始 As String
        Dim getシフト終了 As String

        Dim get開始日, get終了日 As Date
        get開始日 = New Date(set年, set月, 1)
        get終了日 = DateAdd(DateInterval.Month, 1, get開始日)

        'ファイル選択ダイアログ
        With SFD
            .Filter = "Excelファイル(*.xlsx)|*.xlsx"
            .Title = "シフトファイルを選択してください"
            .RestoreDirectory = True
            '.CheckFileExists = True
            .CheckPathExists = True

            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

            Dim ExcelFilePath As String = SFD.FileName

            'Excel ファイルを開く
            Using workbook As New XLWorkbook(ExcelFilePath)
                'シート名を指定してシートを取得
                Dim worksheet As IXLWorksheet = workbook.Worksheet(1)
                get職員ID = worksheet.Cell(1, 2).Value

                ''エラーチェック
                If get職員ID <> set職員ID Then
                    Select Case sfrmメッセージ.ShowDialog("職員IDの違うExcelを取り込もうとしています。取込をしてよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Case vbOK
                        Case Else
                            Exit Sub
                    End Select

                End If

                ''全件削除
                ''超過勤務-----------------------------------------------
                sSQL = "DELETE FROM TBL_職員勤務履歴"
                sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
                sSQL += " AND 職員ID ='" & set職員ID & "'"
                sSQL += " AND 日付>='" & get開始日 & "'"
                sSQL += " AND 日付 < '" & get終了日 & "'"

                myCommand = cDB.getsqlComand(sSQL)
                Call myCommand.ExecuteNonQuery()

                ''新規
                For n行 As Integer = 4 To 4 + 31

                    get日付 = worksheet.Cell(n行, 1).Value
                    If IsDate(get日付) = True Then
                        If CDate(get日付) >= get開始日 And CDate(get日付) < get終了日 Then

                            getシフト開始 = worksheet.Cell(n行, 3).Value.ToString
                            If getシフト開始 <> "" Then
                                getシフト開始 = CDate(getシフト開始).ToString("HH:mm")
                            End If
                            getシフト終了 = worksheet.Cell(n行, 4).Value.ToString
                            If getシフト終了 <> "" Then
                                getシフト終了 = CDate(getシフト終了).ToString("HH:mm")
                            End If

                            If getシフト開始 <> "" Then
                                sSQL = " INSERT INTO TBL_職員勤務履歴("

                                sSQL += " 施設ID"
                                sSQL += ",職員ID"
                                sSQL += ",日付"
                                sSQL += ",シフト出勤時間"
                                sSQL += ",シフト退勤時間"
                                sSQL += ",出勤時間"
                                sSQL += ",退勤時間"
                                sSQL += ",検温"
                                sSQL += ",第1延長"
                                sSQL += ",第2延長"
                                sSQL += ",第3延長"
                                sSQL += ",休憩時間"

                                sSQL += ")VALUES("

                                sSQL += " '" & my環境設定.施設ID & "'"
                                sSQL += ",'" & set職員ID & "'"
                                sSQL += ",'" & get日付 & "'"
                                If getシフト開始 <> "" Then sSQL += ",'" & Split(getシフト開始, ":")(0) & ":" & Split(getシフト開始, ":")(1) & "'" Else sSQL += ",''"
                                If getシフト終了 <> "" Then sSQL += ",'" & Split(getシフト終了, ":")(0) & ":" & Split(getシフト終了, ":")(1) & "'" Else sSQL += ",''"
                                sSQL += ",''"
                                sSQL += ",''"
                                sSQL += ",'0.0'"
                                sSQL += ",'False'"
                                sSQL += ",'False'"
                                sSQL += ",'False'"
                                sSQL += ",'" & my環境設定.休憩時間 & "'"

                                sSQL += ")"

                                myCommand = cDB.getsqlComand(sSQL)
                                Call myCommand.ExecuteNonQuery()
                            End If
                        End If

                    End If

                Next

            End Using
        End With

    End Sub

    Public Sub subシフト表作成(set年 As Integer, set月 As Integer)
        Dim getExcelファイル As String
        Dim cDB As New clsDB
        Dim dtbl部署, dtbl職員, dtbl職員勤務履歴 As New DataTable
        Dim sSQL As String
        Dim myCommand As SqlCommand
        Dim mySDA As New SqlDataAdapter
        Dim sタイトル As String = ""

        Dim get開始日, get終了日 As Date
        get開始日 = New Date(set年, set月, 1)
        get終了日 = DateAdd(DateInterval.Month, 1, get開始日)

        ''部署一覧取得--------------------------------------
        sSQL = "SELECT * FROM MST_区分明細"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        sSQL += " AND 区分='7'"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl部署) ''データセット作成

        ''職員情報---------------------------------------------
        sSQL = "SELECT * FROM MST_職員"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        sSQL += " AND 退職日 is NULL"
        sSQL += " ORDER BY CONVERT(int,MST_職員.職員ID)"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員) ''データセット作成

        ''超過勤務-----------------------------------------------
        sSQL = "SELECT * FROM TBL_職員勤務履歴"
        sSQL += " WHERE 施設ID ='" & my環境設定.施設ID & "'"
        sSQL += " AND 日付>='" & get開始日 & "'"
        sSQL += " AND 日付 < '" & get終了日 & "'"

        myCommand = cDB.getsqlComand(sSQL)
        mySDA.SelectCommand = myCommand
        Call mySDA.Fill(dtbl職員勤務履歴) ''データセット作成

        ''帳票作成=================================================================================
        Dim getWorkBook = New XLWorkbook
        For Each row部署 As DataRow In dtbl部署.Rows
            Dim getWorkSeet As IXLWorksheet
            getWorkSeet = getWorkBook.Worksheets.Add(row部署("内容").ToString)
            ''タイトル
            getWorkSeet.Cell(1, 1).Value = "'" & set月 & "月"
            getWorkSeet.Cell(1, 2).Value = ""

            Dim dtカウント As Date = get開始日
            Dim n行 As Integer = 2
            Do Until dtカウント = get終了日
                Dim Cell日付 As IXLCell = getWorkSeet.Cell(n行, 1)
                Dim Cell曜日 As IXLCell = getWorkSeet.Cell(n行, 2)
                Dim Cellシフト出勤時間 As IXLCell = getWorkSeet.Cell(n行, 3)
                Cellシフト出勤時間.Style.NumberFormat.Format = "HH:mm"
                Dim Cellシフト退勤時間 As IXLCell = getWorkSeet.Cell(n行 + 1, 3)
                Cellシフト退勤時間.Style.NumberFormat.Format = "HH:mm"

                Cell日付.Value = dtカウント.ToString("dd")
                Cell曜日.Value = dtカウント.ToString("ddd")

                n行 += 2
                dtカウント = DateAdd("d", 1, dtカウント)
            Loop


            Dim n職員カウント As Integer = 0
            Dim rows職員 As DataRow() = dtbl職員.Select("部署1 ='" & row部署("内容").ToString & "' OR 部署2 ='" & row部署("内容").ToString & "' OR 部署3 ='" & row部署("内容").ToString & "'")
            For Each row職員 As DataRow In rows職員
                Dim Cell職員名 As IXLCell = getWorkSeet.Cell(1, n職員カウント + 3)
                Cell職員名.Value = row職員("職員氏名")

                Dim dtシフト As Date = get開始日
                Dim nシフト行 As Integer = 2
                Do Until dtシフト = get終了日
                    Dim Cellシフト出勤延長 As IXLCell = getWorkSeet.Cell(nシフト行, n職員カウント + 3)
                    Dim Cellシフト出勤時間 As IXLCell = getWorkSeet.Cell(nシフト行, n職員カウント + 4)
                    Cellシフト出勤時間.Style.NumberFormat.Format = "HH:mm"

                    Dim Cellシフト退勤延長 As IXLCell = getWorkSeet.Cell(nシフト行 + 1, n職員カウント + 3)
                    Dim Cellシフト退勤時間 As IXLCell = getWorkSeet.Cell(nシフト行 + 1, n職員カウント + 4)
                    Cellシフト退勤時間.Style.NumberFormat.Format = "HH:mm"

                    Dim get日 As DataRow()
                    get日 = dtbl職員勤務履歴.Select("日付 ='" & dtシフト & "' AND 職員ID ='" & row職員("職員ID") & "'")

                    If get日.Length <> 0 Then
                        If get日(0)("第1延長").ToString = "True" Then Cellシフト出勤延長.Value = "①"
                        Cellシフト出勤時間.Value = get日(0)("シフト出勤時間").ToString

                        If get日(0)("第2延長").ToString = "True" Then Cellシフト退勤延長.Value = "②"
                        If get日(0)("第3延長").ToString = "True" Then Cellシフト退勤延長.Value += "③"
                        Cellシフト退勤時間.Value = get日(0)("シフト退勤時間").ToString

                    End If

                    nシフト行 += 2
                    dtシフト = DateAdd("d", 1, dtシフト)
                Loop

                n職員カウント += 2
            Next



        Next

        ''ファイル保存===========================================================================
        Using sfd As SaveFileDialog = New SaveFileDialog
            'デフォルトのファイル名を指定します
            sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
            sfd.FileName = "シフト表(" & set年 & "年" & set月 & "月)"
            sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

            If sfd.ShowDialog() = DialogResult.OK Then
                getExcelファイル = sfd.FileName
                getWorkBook.SaveAs(getExcelファイル)     ''別ブックで保存

                ''作成ファイルオープン
                Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                            & "作成ファイルを開きますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case vbOK
                        Dim execProc As New Process
                        With execProc
                            .StartInfo.FileName = getExcelファイル
                            .Start()
                        End With
                End Select
            End If
        End Using

    End Sub


    Public Function s勤務時間(set出勤時間 As String, set退勤時間 As String, set休憩時間 As String) As String
        Dim dt出勤, dt退勤 As DateTime
        Dim ts勤務時間 As TimeSpan
        Dim n勤務時間 As Decimal
        s勤務時間 = "0"

        If set出勤時間 = "" Or set退勤時間 = "" Then Exit Function
        dt出勤 = New DateTime(Now.Year, Now.Month, Now.Day, Split(set出勤時間, ":")(0), Split(set出勤時間, ":")(1), 0)
        dt退勤 = New DateTime(Now.Year, Now.Month, Now.Day, Split(set退勤時間, ":")(0), Split(set退勤時間, ":")(1), 0)

        ts勤務時間 = dt退勤 - dt出勤

        n勤務時間 = ts勤務時間.Hours + (ts勤務時間.Minutes \ 15) * 15 / 60 - CInt(set休憩時間)
        s勤務時間 = n勤務時間.ToString("0.##")
    End Function
    ''' <summary>
    ''' 実時間の端数を、シフト時間で丸める
    ''' </summary>
    ''' <param name="set実時間">実態のタイムスタンプ</param>
    ''' <param name="set予定時間">シフト予定時間</param>
    ''' <param name="set出退フラグ">1:出勤,2:退勤</param>
    ''' <returns></returns>
    Public Function s時間まるめ(set実時間 As String, set予定時間 As String, set出退フラグ As Integer) As String
        If set実時間 = "" Then Return ""

        Select Case set出退フラグ
            Case 1  ''出勤
                If set実時間 < set予定時間 Then
                    Return set予定時間

                Else
                    Return set実時間

                End If
            Case Else   ''退勤
                If set実時間 < set予定時間 Then
                    Return set実時間
                Else
                    Return set予定時間

                End If
        End Select


    End Function

    Function Excel英列(ByVal n列数 As Integer) As String
        '    与えられた数値をエクセルの列を表すアルファベットにして返す。
        Dim ret As String
        ret = ""
        Do
            n列数 = n列数 - 1
            ret = Chr(n列数 Mod 26 + 65) & ret
            n列数 = n列数 \ 26
        Loop While n列数 > 0

        Excel英列 = ret
    End Function
End Module
