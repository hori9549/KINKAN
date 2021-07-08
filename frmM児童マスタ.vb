Imports System.Data
Imports System.Data.SqlClient
Imports System.IO　　''ファイル操作用
Imports System.Text  ''エンコード時使用

Public Class frmM児童マスタ
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private mdtbl児童 As New DataTable
    Private mclsコンボ As New clsコンボボックス

    Private yomiConv As ImeComposition.ImeYomiConversion
    Private yomiConv2 As ImeComposition.ImeYomiConversion

    Private Sub frmM児童マスタ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call subクリア()
        Call sub一覧表示()

        Call mclsコンボ.クラスコンボ(cmbクラス)

        ''カナ自動入力
        yomiConv = New ImeComposition.ImeYomiConversion(txt児童氏名, txt児童フリガナ)
        yomiConv2 = New ImeComposition.ImeYomiConversion(txt保護者氏名, txt保護者フリガナ)

    End Sub

    Private Sub sub一覧表示()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * "
        msSQL += " FROM MST_児童"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv一覧.DataSource = myTable
        Call グリッド並び()

        Call cDB.Close()

    End Sub



    Private Sub グリッド並び()
        ''グリッド表示順
        With dgv一覧
            .Columns("colID").DisplayIndex = 0
            .Columns("col児童ID").DisplayIndex = 1
            .Columns("col児童氏名").DisplayIndex = 2
            .Columns("col児童フリガナ").DisplayIndex = 3
            .Columns("colクラス").DisplayIndex = 4
            .Columns("col生年月日").DisplayIndex = 5
            .Columns("col年齢").DisplayIndex = 6
            .Columns("col保護者氏名").DisplayIndex = 7
            .Columns("col保護者フリガナ").DisplayIndex = 8
            .Columns("col郵便番号").DisplayIndex = 9
            .Columns("col住所").DisplayIndex = 10
            .Columns("col連絡先１").DisplayIndex = 11
            .Columns("col連絡先２").DisplayIndex = 12
            .Columns("col備考").DisplayIndex = 13

        End With

    End Sub
    Private Sub subクリア()
        txt児童ID.Text = ""
        txt児童氏名.Text = ""
        txt児童フリガナ.Text = ""
        cmbクラス.SelectedValue = "0"
        txt生年月日.Text = ""
        txt年齢.Text = ""
        txt保護者氏名.Text = ""
        txt保護者フリガナ.Text = ""
        txt郵便番号.Text = ""
        txt住所.Text = ""
        txt連絡先１.Text = ""
        txt連絡先２.Text = ""
        txt備考.Text = ""

        txt児童ID.Text = n児童ID取得()
        Call txt児童氏名.Focus()
    End Sub

    Private Sub txt児童氏名_Enter(sender As Object, e As EventArgs) Handles txt児童氏名.Enter
        yomiConv.Enabled = True
    End Sub

    Private Sub txt児童氏名_Leave(sender As Object, e As EventArgs) Handles txt児童氏名.Leave
        yomiConv.Enabled = False
    End Sub

    Private Sub txt保護者氏名_Enter(sender As Object, e As EventArgs) Handles txt保護者氏名.Enter
        yomiConv2.Enabled = True
    End Sub

    Private Sub txt保護者氏名_Leave(sender As Object, e As EventArgs) Handles txt保護者氏名.Leave
        yomiConv2.Enabled = False
    End Sub



    Private Sub btn生年月日_Click(sender As Object, e As EventArgs) Handles btn生年月日.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt生年月日.Text
        Call sfrm.ShowDialog()
        txt生年月日.Text = sfrm.日付
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim dtbl児童 As New DataTable
        Dim get施設ID As String = my環境設定.施設ID
        Dim get児童ID As String = txt児童ID.Text



        ''エラーチェック==========================================================================================================

        With txt児童ID
            Select Case .Text
                Case ""
                    txt児童ID.Text = n児童ID取得()
                Case Else
            End Select
        End With

        With txt児童氏名
            Select Case .Text
                Case ""
                    MessageBox.Show("児童氏名は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Focus()
                    Exit Sub
                Case Else

            End Select
        End With

        With txt生年月日
            Select Case .Text
                Case ""
                    MessageBox.Show("生年月日は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Focus()
                    Exit Sub
                Case Else

            End Select
        End With

        With txt保護者氏名
            Select Case .Text
                Case ""
                    MessageBox.Show("保護者氏名は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        With txt連絡先１
            Select Case .Text
                Case ""
                    MessageBox.Show("連絡先１は必須入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub

                Case Else
                    'If IsNumeric(.Text) = False Then
                    '    MessageBox.Show("連絡先１は数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    Call .Select()
                    '    Exit Sub
                    'End If
            End Select

        End With

        With txt連絡先２
            Select Case .Text
                Case ""
                    .Text = ""

                Case Else
                    'If IsNumeric(.Text) = False Then
                    '    MessageBox.Show("連絡先２は数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    Call .Focus()
                    '    Exit Sub
                    'End If

            End Select
        End With


        ''登録===================================================================================================================
        'Try
        '存在チェック
        '登録出来るか検索

        msSQL = " SELECT * FROM MST_児童"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND 児童ID = '" & txt児童ID.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl児童) ''データセット作成

        '新規か登録かIF文

        If dtbl児童.Rows.Count = 0 Then

            ''新規追加

            msSQL = " INSERT INTO MST_児童("

            msSQL += " 施設ID"
            msSQL += ",児童ID"
            msSQL += ",児童氏名"
            msSQL += ",児童フリガナ"
            msSQL += ",クラス"
            msSQL += ",生年月日"
            msSQL += ",年齢"
            msSQL += ",保護者氏名"
            msSQL += ",保護者フリガナ"
            msSQL += ",郵便番号"
            msSQL += ",住所"
            msSQL += ",連絡先１"
            msSQL += ",連絡先２"
            msSQL += ",備考"

            msSQL += ")VALUES("

            msSQL += " '" & get施設ID & "'"
            msSQL += ",'" & get児童ID & "'"
            msSQL += ",'" & txt児童氏名.Text & "'"
            msSQL += ",'" & txt児童フリガナ.Text & "'"
            msSQL += ",'" & cmbクラス.SelectedValue & "'"
            msSQL += ",'" & txt生年月日.Text & "'"
            msSQL += ",'" & txt年齢.Text & "'"
            msSQL += ",'" & txt保護者氏名.Text & "'"
            msSQL += ",'" & txt保護者フリガナ.Text & "'"
            msSQL += ",'" & txt郵便番号.Text & "'"
            msSQL += ",'" & txt住所.Text & "'"
            msSQL += ",'" & txt連絡先１.Text & "'"
            msSQL += ",'" & txt連絡先２.Text & "'"
            msSQL += ",'" & txt備考.Text & "'"

            msSQL += ")"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()



        Else
            Select Case MessageBox.Show("児童ID:" & get児童ID & "の修正を行います。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Case ShowDialog.OK
                Case Else
                    Exit Sub
            End Select




            ''更新
            msSQL = " UPDATE MST_児童 SET "
            'msSQL += " 児童ID = '" & txt児童ID.Text & "',"
            msSQL += " 児童氏名 = '" & txt児童氏名.Text & "',"
            msSQL += " 児童フリガナ = '" & txt児童フリガナ.Text & "',"
            msSQL += " クラス = '" & cmbクラス.SelectedValue & "',"
            msSQL += " 生年月日 = '" & txt生年月日.Text & "',"
            msSQL += " 年齢 = '" & txt年齢.Text & "',"
            msSQL += " 保護者氏名 = '" & txt保護者氏名.Text & "',"
            msSQL += " 保護者フリガナ = '" & txt保護者フリガナ.Text & "',"
            msSQL += " 郵便番号 = '" & txt郵便番号.Text & "',"
            msSQL += " 住所 = '" & txt住所.Text & "',"
            msSQL += " 連絡先１ = '" & txt連絡先１.Text & "',"
            msSQL += " 連絡先２ = '" & txt連絡先２.Text & "',"
            msSQL += " 備考 = '" & txt備考.Text & "'"
            msSQL += " WHERE 児童ID = '" & txt児童ID.Text & "'"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
        End If



        ''初期化-----------------------------------------------------
        MessageBox.Show("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()


        ''再表示============================================================================
        Call sub一覧表示()
        'dgv一覧.DataSource = myTable
        'Call グリッド並び()


        ''クリア============================================================================
        Call subクリア()
        Call txt児童ID.Select()

        Call cDB.Close()


    End Sub



    Private Sub btn新規_Click(sender As Object, e As EventArgs) Handles btn新規.Click
        Call subクリア()

    End Sub


    Private Function dtbl児童一覧取得(Optional set児童ID As Integer = 0) As DataTable
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_児童"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        If set児童ID <> 0 Then msSQL += " AND 児童ID='" & set児童ID & "'"
        msSQL += " ORDER BY 児童ID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        Return myTable

    End Function

    Private Function n児童ID取得() As Integer
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        msSQL = "SELECT TOP 1 児童ID FROM MST_児童"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " ORDER BY 児童ID DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1
        Else
            Return myTable.Rows(0)("児童ID") + 1
        End If

    End Function

    Private Sub txt生年月日_Leave(sender As Object, e As EventArgs) Handles txt生年月日.Leave

        txt生年月日.Text = s日付変換(txt生年月日.Text)
        If txt生年月日.Text = "" Then Exit Sub

        txt年齢.Text = n年齢取得(txt生年月日.Text)

    End Sub


    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Call subクリア()


        txt児童ID.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col児童ID").Value.ToString)
        txt児童氏名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col児童氏名").Value.ToString)
        txt児童フリガナ.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col児童フリガナ").Value.ToString)
        cmbクラス.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colクラス").Value.ToString)
        txt保護者氏名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col保護者氏名").Value.ToString)
        txt保護者フリガナ.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col保護者フリガナ").Value.ToString)
        txt郵便番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col郵便番号").Value.ToString)
        txt住所.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col住所").Value.ToString)
        txt連絡先１.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col連絡先１").Value.ToString)
        txt連絡先２.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col連絡先２").Value.ToString)
        txt備考.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col備考").Value.ToString)

        'テキストボックスに時間の表示をしないようにする
        txt生年月日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col生年月日").Value).ToString("yyyy/MM/dd"))

        '生年月日から連動表示
        txt年齢.Text = n年齢取得(txt生年月日.Text)

    End Sub


    Private Sub btn取得_Click(sender As Object, e As EventArgs) Handles btn取得.Click
        Dim subForm As New sfrm住所検索
        subForm.検索郵便 = txt郵便番号.Text
        Call subForm.ShowDialog()

        txt郵便番号.Text = subForm.検索郵便
        txt住所.Text = subForm.検索住所

        Call txt住所.Select(Len(txt住所.Text), 0)

        If txt住所.Text <> "" Then Call txt住所.Select()

    End Sub

End Class