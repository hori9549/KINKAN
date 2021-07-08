Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm超過勤務管理
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

    Private pro職員 As String
    Public Property 職員() As String
        Get
            Return pro職員
        End Get

        Set(ByVal value As String)
            pro職員 = value
        End Set
    End Property

    Private Sub sfrm超過勤務管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call myコンボ.職員コンボ(cmb職員検索)
        Call myコンボ.勤務内容コンボ(cmb勤務内容区分)
        Call myコンボ.職員コンボ(cmb職員)

        Call subクリア()
        Call subクリア明細()

        lbl年月.Text = pro日付.ToString("yyyy年MM月")
        cmb職員検索.SelectedValue = pro職員
        Call sub超過勤務一覧(pro日付)
    End Sub

    Private Sub btn前_Click(sender As Object, e As EventArgs) Handles btn前.Click
        pro日付 = DateAdd("m", -1, pro日付)
        Call subクリア()
        lbl年月.Text = pro日付.ToString("yyyy年MM月")
        cmb職員検索.SelectedValue = pro職員
        Call sub超過勤務一覧(pro日付)
    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs) Handles btn次.Click
        pro日付 = DateAdd("m", 1, pro日付)
        Call subクリア()
        lbl年月.Text = pro日付.ToString("yyyy年MM月")
        cmb職員検索.SelectedValue = pro職員
        Call sub超過勤務一覧(pro日付)
    End Sub

    Private Sub subクリア()

        If my環境設定.第1延長開始 = "00:00" Then
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

        cmb職員検索.SelectedValue = ""



    End Sub

    Private Sub subクリア明細()
        txtID.Text = ""
        cmb勤務内容区分.Text = ""
        cmb職員.SelectedValue = ""
        dtp超勤時間開始.Text = "00:00"
        dtp超勤時間終了.Text = "00:00"

        Call cmb職員検索.Select()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub sub超過勤務一覧(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable
        Dim get対象 As String = ""
        Dim dt開始日, dt終了日 As Date
        dt開始日 = set日付
        dt終了日 = DateAdd("M", 1, dt開始日)

        msSQL = "SELECT * "
        msSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.施設ID = TBL_職員超過勤務.施設ID AND MST_職員.職員ID= TBL_職員超過勤務.職員ID)as 職員名"
        msSQL += ",(SELECT 職員氏名 FROM MST_職員 WHERE MST_職員.施設ID = TBL_職員超過勤務.施設ID AND MST_職員.職員ID= TBL_職員超過勤務.承認者)as 承認者名"
        msSQL += ",(SELECT TOP 1 内容 FROM MST_区分明細 WHERE 施設ID='" & my環境設定.施設ID & "' AND 区分 = 8 AND コード=TBL_職員超過勤務.勤務内容区分) As 勤務内容"
        msSQL += " FROM TBL_職員超過勤務"

        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        If cmb職員検索.SelectedValue <> "" Then msSQL += " AND 職員ID='" & cmb職員検索.SelectedValue & "'"
        If chk第1延長.Checked = True Then get対象 += ",'1'"
        If chk第2延長.Checked = True Then get対象 += ",'2'"
        If chk第3延長.Checked = True Then get対象 += ",'3'"

        If get対象 <> "" Then
            msSQL += " AND 勤務内容区分 IN (" & get対象.Substring(1, get対象.Length - 1) & ")"

        End If

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
            .Columns("col日付").DisplayIndex = 3
            .Columns("col職員ID").DisplayIndex = 4
            .Columns("col職員名").DisplayIndex = 5
            .Columns("col勤務内容区分").DisplayIndex = 6
            .Columns("col勤務内容").DisplayIndex = 7
            .Columns("col超勤時間開始").DisplayIndex = 8
            .Columns("col超勤時間終了").DisplayIndex = 9
            .Columns("col承認日").DisplayIndex = 10
            .Columns("col承認者").DisplayIndex = 11
            .Columns("col承認者名").DisplayIndex = 12

        End With

    End Sub

    Private Sub dgv一覧_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim getシフト出勤, get出勤 As String
        Dim setColor As Color

        If e.RowIndex >= 0 Then
            ''MsgBox(dgv_ASSYList.Rows(e.RowIndex).Cells(0).Value)
            getシフト出勤 = dgv一覧.Rows(e.RowIndex).Cells("colシフト出勤時間").Value
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

    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click
        Call sub超過勤務一覧(pro日付)
        Call subクリア明細()
    End Sub

    Private Sub cmb職員_Leave(sender As Object, e As EventArgs) Handles cmb職員検索.Leave
        pro職員 = cmb職員検索.SelectedValue
        Call sub超過勤務一覧(pro日付)
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim getID As Integer
        Dim get承認日 As String
        Dim dtbl勤務内容区分 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID

        getID = Trim(dgv一覧.Rows(e.RowIndex).Cells("colID").Value.ToString)

        ''TBL_職員超過勤務
        msSQL = "SELECT * FROM TBL_職員超過勤務"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND ID='" & getID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl勤務内容区分) ''データセット作成

        For Each get勤務内容区分 As DataRow In dtbl勤務内容区分.Rows
            txtID.Text = getID
            cmb職員.SelectedValue = get勤務内容区分("職員ID")
            dtp超勤時間開始.Text = get勤務内容区分("超勤時間開始")
            dtp超勤時間終了.Text = get勤務内容区分("超勤時間終了")
            cmb勤務内容区分.SelectedValue = get勤務内容区分("勤務内容区分")

            get承認日 = get勤務内容区分("承認日").ToString
        Next


        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "col削除"
                If get承認日 <> "" Then
                    sfrmメッセージ.ShowDialog("承認されているデータは削除できません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Exit Sub
                End If

                Select Case sfrmメッセージ.ShowDialog("勤務内容区分の削除を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Case Windows.Forms.DialogResult.OK
                    Case Else
                        Exit Sub
                End Select

                ''更新
                msSQL = " DELETE FROM TBL_職員超過勤務 "
                msSQL += " WHERE ID = '" & getID & "'"
                msSQL += " AND 承認日 is NULL"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()

                Call sub超過勤務一覧(pro日付)

        End Select
    End Sub

    Private Sub btn追加_Click(sender As Object, e As EventArgs) Handles btn追加.Click
        With cmb職員
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("職員は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        With cmb勤務内容区分
            Select Case .SelectedValue
                Case ""
                    sfrmメッセージ.ShowDialog("勤務内容区分は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        Dim cDB As New clsDB
        Dim dtbl勤務内容区分 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID

        ''TBL_職員勤務履歴更新
        msSQL = "SELECT * FROM TBL_職員超過勤務"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND ID='" & txtID.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl勤務内容区分) ''データセット作成

        If dtbl勤務内容区分.Rows.Count = 0 Then
            msSQL = " INSERT INTO TBL_職員超過勤務("

            msSQL += " 施設ID"
            msSQL += ",職員ID"
            msSQL += ",日付"
            msSQL += ",超勤時間開始"
            msSQL += ",超勤時間終了"
            msSQL += ",勤務内容区分"
            msSQL += ",承認者"
            msSQL += ",承認日"

            msSQL += ")VALUES("

            msSQL += " '" & get施設ID & "'"
            msSQL += ",'" & cmb職員.SelectedValue & "'"
            msSQL += ",'" & pro日付 & "'"
            msSQL += ",'" & dtp超勤時間開始.Text & "'"
            msSQL += ",'" & dtp超勤時間終了.Text & "'"
            msSQL += ",'" & cmb勤務内容区分.SelectedValue & "'"
            msSQL += ",''"
            msSQL += ",NULL"

            msSQL += ")"
        Else

            msSQL = "UPDATE TBL_職員超過勤務 SET"
            msSQL += " 職員ID='" & cmb職員.SelectedValue & "'"
            msSQL += ",超勤時間開始='" & dtp超勤時間開始.Text & "'"
            msSQL += ",超勤時間終了='" & dtp超勤時間終了.Text & "'"
            msSQL += ",勤務内容区分='" & cmb勤務内容区分.SelectedValue & "'"

            msSQL += " WHERE 施設ID='" & get施設ID & "'"
            msSQL += " AND ID='" & txtID.Text & "'"

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call sub超過勤務一覧(pro日付)
    End Sub

    Private Sub btn新規_Click(sender As Object, e As EventArgs) Handles btn新規.Click
        Call subクリア明細()
    End Sub

    Private Sub btn超過勤務一覧_Click(sender As Object, e As EventArgs) Handles btn超過勤務一覧.Click
        Call sub超過勤務一覧(pro日付)
        Dim get対象 As String = ""
        If chk第1延長.Checked = True Then get対象 += ",'1'"
        If chk第2延長.Checked = True Then get対象 += ",'2'"
        If chk第3延長.Checked = True Then get対象 += ",'3'"
        If get対象 <> "" Then get対象 = get対象.Substring(1, get対象.Length - 1)

        Select Case pro日付.Month
            Case <= 3
                Call sub超過勤務一覧印刷(pro日付.Year - 1, cmb職員検索.SelectedValue, get対象)
            Case Else
                Call sub超過勤務一覧印刷(pro日付.Year, cmb職員検索.SelectedValue, get対象)
        End Select
    End Sub

    Private Sub btn一括承認_Click(sender As Object, e As EventArgs) Handles btn一括承認.Click
        Dim cDB As New clsDB
        Dim dtbl勤務内容区分 As New DataTable
        Dim get対象 As String = ""
        Dim dt開始日, dt終了日 As Date
        dt開始日 = pro日付
        dt終了日 = DateAdd("M", 1, dt開始日)

        Select Case sfrmメッセージ.ShowDialog("超過勤務届の一括承認を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Case Windows.Forms.DialogResult.OK
            Case Else
                Exit Sub
        End Select

        msSQL = "UPDATE TBL_職員超過勤務 SET"
        msSQL += " 承認者='" & MS職員ID & "'"
        msSQL += ",承認日='" & Now.ToString("yyyy/MM/dd") & "'"

        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        If cmb職員検索.SelectedValue <> "" Then msSQL += " AND 職員ID='" & cmb職員検索.SelectedValue & "'"
        If chk第1延長.Checked = True Then get対象 += ",'1'"
        If chk第2延長.Checked = True Then get対象 += ",'2'"
        If chk第3延長.Checked = True Then get対象 += ",'3'"

        If get対象 <> "" Then
            msSQL += " AND 勤務内容区分 IN (" & get対象.Substring(1, get対象.Length - 1) & ")"

        End If

        msSQL += " AND 日付 >='" & dt開始日 & "'"
        msSQL += " AND 日付 <'" & dt終了日 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call sub超過勤務一覧(pro日付)

    End Sub

End Class
