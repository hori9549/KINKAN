Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm超過勤務届
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

    Private pro職員ID As String
    Public Property 職員ID() As String
        Get
            Return pro職員ID
        End Get

        Set(ByVal value As String)
            pro職員ID = value
        End Set
    End Property

    Private Sub sfrm勤務内容区分登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call myコンボ.職員コンボ(cmb職員)
        Call myコンボ.勤務内容コンボ(cmb勤務内容区分)
        Call myコンボ.時コンボ(cmb超勤時間開始_時)
        Call myコンボ.分コンボ(cmb超勤時間開始_分)
        Call myコンボ.時コンボ(cmb超勤時間終了_時)
        Call myコンボ.分コンボ(cmb超勤時間終了_分)

        If pro職員ID = "" Then
            btn前.Enabled = True
            btn次.Enabled = True

        Else
            btn前.Enabled = False
            btn次.Enabled = False

        End If

        lbl日付.Text = pro日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call cmb勤務内容区分.Select()

        Call subカレンダー取得(pro日付)
        Call sub勤務内容区分一覧(pro日付, pro職員ID)
        If pro職員ID <> "" Then cmb職員.SelectedValue = pro職員ID
    End Sub

    Private Sub btn前_Click(sender As Object, e As EventArgs) Handles btn前.Click
        pro日付 = DateAdd("d", -1, pro日付)
        lbl日付.Text = pro日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call subカレンダー取得(pro日付)
        Call sub勤務内容区分一覧(pro日付, pro職員ID)
    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs) Handles btn次.Click
        pro日付 = DateAdd("d", 1, pro日付)
        lbl日付.Text = pro日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call subカレンダー取得(pro日付)
        Call sub勤務内容区分一覧(pro日付, pro職員ID)
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
                    'Me.BackColor = Color.LightPink
                Case Else
                    'Me.BackColor = Nothing
            End Select

        End If

    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub subクリア()
        txtID.Text = ""
        cmb勤務内容区分.Text = ""
        cmb職員.SelectedValue = ""
        cmb超勤時間開始_時.Text = "00"
        cmb超勤時間開始_分.Text = "00"

        cmb超勤時間終了_時.Text = "00"
        cmb超勤時間終了_分.Text = "00"

        Call cmb超勤時間開始_時.Select()
    End Sub

    Private Sub sub勤務内容区分一覧(set日付 As Date, Optional set職員ID As String = "")
        Dim cDB As New clsDB
        Dim dtbl勤務内容区分 As New DataTable

        msSQL = "SELECT * "
        msSQL += ",(SELECT TOP 1 職員氏名 FROM MST_職員 WHERE MST_職員.施設ID = TBL_職員超過勤務.施設ID AND  MST_職員.職員ID= TBL_職員超過勤務.職員ID) as 職員名"
        msSQL += ",(SELECT TOP 1 内容 FROM MST_区分明細 WHERE 施設ID='" & my環境設定.施設ID & "' AND 区分 = 8 AND コード=TBL_職員超過勤務.勤務内容区分) As 勤務内容"
        msSQL += " FROM TBL_職員超過勤務"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 日付='" & set日付 & "'"
        If set職員ID <> "" Then msSQL += " AND 職員ID='" & set職員ID & "'"
        msSQL += " ORDER BY 超勤時間開始"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl勤務内容区分) ''データセット作成

        dgv一覧.DataSource = dtbl勤務内容区分

    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn追加.Click
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
                Case 0
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
            msSQL += ",'" & cmb超勤時間開始_時.Text & ":" & cmb超勤時間開始_分.Text & "'"
            msSQL += ",'" & cmb超勤時間終了_時.Text & ":" & cmb超勤時間終了_分.Text & "'"
            msSQL += ",'" & cmb勤務内容区分.SelectedValue & "'"
            msSQL += ",''"
            msSQL += ",NULL"

            msSQL += ")"
        Else

            msSQL = "UPDATE TBL_職員超過勤務 SET"
            msSQL += " 職員ID='" & cmb職員.SelectedValue & "'"
            msSQL += ",超勤時間開始='" & cmb超勤時間開始_時.Text & ":" & cmb超勤時間開始_分.Text & "'"
            msSQL += ",超勤時間終了='" & cmb超勤時間終了_時.Text & ":" & cmb超勤時間終了_分.Text & "'"
            msSQL += ",勤務内容区分='" & cmb勤務内容区分.SelectedValue & "'"

            msSQL += " WHERE 施設ID='" & get施設ID & "'"
            msSQL += " AND ID='" & txtID.Text & "'"

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()
        Call sub勤務内容区分一覧(pro日付, pro職員ID)
    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim getID As Integer
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
            cmb超勤時間開始_時.Text = Split(get勤務内容区分("超勤時間開始"), ":")(0)
            cmb超勤時間開始_分.Text = Split(get勤務内容区分("超勤時間開始"), ":")(1)
            cmb超勤時間終了_時.Text = Split(get勤務内容区分("超勤時間終了"), ":")(0)
            cmb超勤時間終了_分.Text = Split(get勤務内容区分("超勤時間終了"), ":")(1)
            cmb勤務内容区分.SelectedValue = get勤務内容区分("勤務内容区分")

        Next


        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "col削除"
                Select Case sfrmメッセージ.ShowDialog("勤務内容区分の削除を行います。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Case Windows.Forms.DialogResult.OK
                    Case Else
                        Exit Sub
                End Select

                ''更新
                msSQL = " DELETE FROM TBL_職員超過勤務 "
                msSQL += " WHERE ID = '" & getID & "'"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()

                Call sub勤務内容区分一覧(pro日付, pro職員ID)

        End Select
    End Sub

    Private Sub cmb勤務内容区分_Leave(sender As Object, e As EventArgs) Handles cmb勤務内容区分.Leave
        If cmb勤務内容区分.SelectedValue Is Nothing Then Exit Sub
        Select Case cmb勤務内容区分.SelectedValue.ToString
            Case "1"  ''朝延長
                cmb超勤時間開始_時.Text = Split(my環境設定.第1延長開始, ":")(0)
                cmb超勤時間開始_分.Text = Split(my環境設定.第1延長開始, ":")(1)
                cmb超勤時間終了_時.Text = Split(my環境設定.第1延長終了, ":")(0)
                cmb超勤時間終了_分.Text = Split(my環境設定.第1延長終了, ":")(1)

            Case "2" ''通常延長
                cmb超勤時間開始_時.Text = Split(my環境設定.第2延長開始, ":")(0)
                cmb超勤時間開始_分.Text = Split(my環境設定.第2延長開始, ":")(1)
                cmb超勤時間終了_時.Text = Split(my環境設定.第2延長終了, ":")(0)
                cmb超勤時間終了_分.Text = Split(my環境設定.第2延長終了, ":")(1)

            Case "3"　''夕延長
                cmb超勤時間開始_時.Text = Split(my環境設定.第3延長開始, ":")(0)
                cmb超勤時間開始_分.Text = Split(my環境設定.第3延長開始, ":")(1)
                cmb超勤時間終了_時.Text = Split(my環境設定.第3延長終了, ":")(0)
                cmb超勤時間終了_分.Text = Split(my環境設定.第3延長終了, ":")(1)

            Case Else

        End Select
    End Sub
End Class
