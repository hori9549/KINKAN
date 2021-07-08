' @(s)
'   区分管理マスタ
'
Imports System.Data
Imports System.Data.SqlClient

Public Class frmM区分管理
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス

    'エンタータブ処理
    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        Dim getControl As Control = Me.ActiveControl

        ''ボタンだったらタブにしない
        Select Case getControl.GetType.Name
            Case "TextBox", "ComboBox"
                'Returnキーが押されているか調べる
                'AltかCtrlキーが押されている時は、本来の動作をさせる
                If ((keyData And Keys.KeyCode) = Keys.Return) AndAlso _
                    ((keyData And (Keys.Alt Or Keys.Control)) = Keys.None) Then
                    'Tabキーを押した時と同じ動作をさせる
                    'Shiftキーが押されている時は、逆順にする
                    Me.ProcessTabKey((keyData And Keys.Shift) <> Keys.Shift)
                    '本来の処理はさせない
                    Return True
                End If
                Return MyBase.ProcessDialogKey(keyData)

            Case Else

        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub frm区分管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''コンボボックスセット
        Call myコンボ.区分コンボ(cmb区分_区分明細)

        Call txt区分名.select()
        Call sub一覧表示_区分()
        Call sub一覧表示_区分明細()
        txt区分.Text = i区分コード最大取得()

    End Sub

    Private Sub frm区分管理_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call frmメニュー.Show()
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        With txt区分名
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("区分名は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .select()
                    Exit Sub
                Case Else
            End Select
        End With

        ''存在チェック
        msSQL = " SELECT * FROM MST_区分"
        msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " AND 区分 = " & txt区分.Text

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then

            ''新規追加
            msSQL = " INSERT INTO MST_区分("
            msSQL += " 施設ID"
            msSQL += ",区分"
            msSQL += ",区分名"
            msSQL += ",備考"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += " '" & my環境設定.施設ID & "'"
            msSQL += ",'" & Trim(txt区分.Text) & "'"
            msSQL += ",'" & Trim(txt区分名.Text) & "'"
            msSQL += ",'" & Trim(txt備考.Text) & "'"
            msSQL += " )"

        Else

            ''更新
            msSQL = " UPDATE MST_区分 SET "
            msSQL += " 区分名 = '" & Trim(txt区分名.Text) & "'"
            msSQL += ",備考 = '" & Trim(txt備考.Text) & "'"
            msSQL += " WHERE 施設ID = " & my環境設定.施設ID
            msSQL += " AND 区分 =" & txt区分.Text


        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''再表示
        Call sub一覧表示_区分()

        ''クリア
        txt区分.Text = i区分コード最大取得()
        txt区分名.Text = ""
        Call txt区分名.select()
        Call cDB.Close()

        ''コンボボックスセット
        Call myコンボ.区分コンボ(cmb区分_区分明細)
    End Sub

    Private Sub sub一覧表示_区分()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_区分"
        msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " ORDER BY 区分"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv区分.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

    '
    ' 機能      : 区分マスタの最大区分を取得する
    '
    ' 返り値    : 最大数に１を加算する
    '
    ' 機能説明  : 
    '
    ' 備考      : 
    '
    Private Function i区分コード最大取得() As Integer
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM MST_区分"
        msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " ORDER BY  区分 DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1

        Else
            Return myTable.Rows(0)("区分") + 1

        End If

        Call cDB.Close()
    End Function

    Private Sub dgv区分_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv区分.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        txt区分.Text = Trim(dgv区分.Rows(e.RowIndex).Cells("col区分_区分").Value.ToString)
        txt区分名.Text = Trim(dgv区分.Rows(e.RowIndex).Cells("col区分名_区分").Value.ToString)
        txt備考.Text = Trim(dgv区分.Rows(e.RowIndex).Cells("col備考_区分").Value.ToString)

    End Sub

    Private Sub btn登録_明細_Click(sender As Object, e As EventArgs) Handles btn登録_明細.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        With cmb区分_区分明細
            Select Case .SelectedValue
                Case 0
                    sfrmメッセージ.ShowDialog("区分は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .select()
                    Exit Sub
                Case Else
            End Select
        End With

        With txt内容_区分明細
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("内容は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .select()
                    Exit Sub
                Case Else
            End Select
        End With

        ''存在チェック
        msSQL = " SELECT * FROM MST_区分明細"
        msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " AND 区分 = " & cmb区分_区分明細.SelectedValue
        msSQL += " AND コード = " & txtコード_区分明細.Text

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then

            ''新規追加
            msSQL = " INSERT INTO MST_区分明細("
            msSQL += " 施設ID"
            msSQL += ",区分"
            msSQL += ",コード"
            msSQL += ",内容"
            msSQL += ",備考"
            msSQL += ",削除フラグ"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += " '" & my環境設定.施設ID & "'"
            msSQL += ",'" & Trim(cmb区分_区分明細.SelectedValue) & "'"
            msSQL += ",'" & Trim(txtコード_区分明細.Text) & "'"
            msSQL += ",'" & Trim(txt内容_区分明細.Text) & "'"
            msSQL += ",'" & Trim(txt備考_区分明細.Text) & "'"
            msSQL += ",'0'"
            msSQL += " )"

        Else

            ''更新
            msSQL = " UPDATE MST_区分明細 SET "
            msSQL += " 区分 = '" & Trim(cmb区分_区分明細.SelectedValue) & "'"
            msSQL += ",内容 = '" & Trim(txt内容_区分明細.Text) & "'"
            msSQL += ",備考 = '" & Trim(txt備考_区分明細.Text) & "'"
            msSQL += ",削除フラグ = '" & Math.Abs(CInt(chk削除_区分明細.Checked)) & "'"
            msSQL += " WHERE 施設ID = " & my環境設定.施設ID
            msSQL += " AND 区分 = " & cmb区分_区分明細.SelectedValue
            msSQL += " AND コード = " & txtコード_区分明細.Text

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''再表示
        Call sub一覧表示_区分明細()

        ''クリア
        Call sub一覧表示_区分明細(cmb区分_区分明細.SelectedValue)
        txtコード_区分明細.Text = iコード最大取得(cmb区分_区分明細.SelectedValue)
        txt内容_区分明細.Text = ""
        txt備考_区分明細.Text = ""
        Call txt内容_区分明細.select()
        Call cDB.Close()

    End Sub

    '
    ' 機能      : 区分明細の最大コードを取得する
    '
    ' 返り値    : 最大コードに１を加算する
    '
    ' 機能説明  : 
    '
    ' 備考      : 
    '
    Private Function iコード最大取得(set区分 As String) As Integer
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM MST_区分明細"
        msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " AND 区分 = " & set区分
        msSQL += " ORDER BY コード DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1

        Else
            Return myTable.Rows(0)("コード") + 1

        End If

        Call cDB.Close()
    End Function


    Private Sub sub一覧表示_区分明細(Optional ByVal set区分 As Integer = 0)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_区分明細"
        msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        If set区分 <> 0 Then msSQL += " AND 区分='" & set区分 & "'"
        msSQL += " ORDER BY 区分,コード"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv区分明細.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs)
        Call Me.Close()

    End Sub

    Private Sub dgv区分明細_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv区分明細.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        txtコード_区分明細.Text = Trim(dgv区分明細.Rows(e.RowIndex).Cells("colコード_区分明細").Value.ToString)
        txt内容_区分明細.Text = Trim(dgv区分明細.Rows(e.RowIndex).Cells("col内容_区分明細").Value.ToString)
        txt備考_区分明細.Text = Trim(dgv区分明細.Rows(e.RowIndex).Cells("col備考_区分明細").Value.ToString)
        cmb区分_区分明細.SelectedValue = Trim(dgv区分明細.Rows(e.RowIndex).Cells("col区分_区分明細").Value.ToString)
        chk削除_区分明細.Checked = Trim(dgv区分明細.Rows(e.RowIndex).Cells("col削除_区分明細").Value.ToString)
    End Sub

    Private Sub subクリア_明細()
        Call sub一覧表示_区分明細(cmb区分_区分明細.SelectedValue)
        txtコード_区分明細.Text = iコード最大取得(cmb区分_区分明細.SelectedValue)
        txt内容_区分明細.Text = ""
        txt備考_区分明細.Text = ""
        chk削除_区分明細.Checked = False
    End Sub

    Private Sub cmb区分_区分明細_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb区分_区分明細.SelectionChangeCommitted
        Call subクリア_明細()

    End Sub

    Private Sub btn新規_Click(sender As Object, e As EventArgs) Handles btn新規.Click
        txt区分.Text = i区分コード最大取得()
        txt区分名.Text = ""
        txt備考.Text = ""
    End Sub

    Private Sub Tab区分明細_Click(sender As Object, e As EventArgs) Handles Tab区分明細.Click

    End Sub

    Private Sub btn新規_明細_Click(sender As Object, e As EventArgs) Handles btn新規_明細.Click
        Call subクリア_明細()
    End Sub
End Class