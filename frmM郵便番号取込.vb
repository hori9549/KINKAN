Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports System.Data.SqlClient

Public Class frmM郵便番号取込
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm郵便番号取込_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call frmメニュー.Show()
    End Sub

    Private Sub frm郵便番号取込_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn終了_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn終了.Click
        Call Me.Close()
    End Sub

    Private Sub btn登録_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn登録.Click
        Dim strPrint As String = 0 ''印刷値
        Dim str利用者 As String = 0 ''印刷値

        With txtCSVパス
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("取込CSVファイルを選択してください。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    Exit Sub
                Case Else

            End Select
        End With

        Select Case sfrmメッセージ.ShowDialog("CSVの取込を行います。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.OK
            Case Else : Exit Sub
        End Select

        Call 全件削除()
        Call 読込み()

    End Sub


    Private Sub btn選択_Click(sender As Object, e As EventArgs) Handles btn選択.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog

        '上部に表示する説明テキストを指定する
        ofd.Title = "CSVファイルを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        ofd.InitialDirectory = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        'fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        ofd.RestoreDirectory = True

        'ダイアログを表示する
        Select Case ofd.ShowDialog(Me)
            Case DialogResult.OK
                '選択されたフォルダを表示する
                txtCSVパス.Text = ofd.FileName

            Case DialogResult.Cancel
                txtCSVパス.Text = ""

        End Select
    End Sub

    ''読込み
    Private Sub 読込み()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim getCSVデータ As New StreamReader(txtCSVパス.Text, System.Text.Encoding.Default)    ''インスタンスを生成する
        Dim getCSV行() As String
        Dim getCSV項目() As String

        ''CSVの全データ取得し、改行で区切
        getCSV行 = Split(getCSVデータ.ReadToEnd, vbCrLf)
        ProgressBar1.Maximum = getCSV行.Length

        ''行数を取得
        Dim get件数 As Integer = getCSV行.Length - 1

        ' 読み込みできる文字がなくなるまで繰り返す
        For rowCount As Integer = 0 To get件数
            Dim mySQLDB_SUB As New clsDB

            ''ファイルを 1 行ずつ読み込む
            Dim get行 As String = getCSV行(rowCount)

            ''空白行は飛ばす
            If get行 = "" Then Exit For

            ''項目取得（区切り文字によって修正する）
            getCSV項目 = Split(get行, """,""")

            ''取得したデータをどうするか処理はこの辺にいれる
            msSQL = " INSERT INTO MST_郵便番号("
            msSQL += " 郵便番号,"
            msSQL += " 都道府県,"
            msSQL += " 市区町村,"
            msSQL += " 地区"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += "'" & getCSV項目(0).Substring(1, 7) & "',"
            msSQL += "'" & getCSV項目(1) & "',"
            msSQL += "'" & getCSV項目(2) & "',"
            msSQL += "'" & getCSV項目(3) & "'"
            msSQL += " )"

            mCommand = mySQLDB_SUB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            Call mySQLDB_SUB.Close()
            ProgressBar1.Value += 1
        Next

        ''閉じる
        getCSVデータ.Close()

        sfrmメッセージ.ShowDialog("郵便番号の取込を完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub 全件削除()
        Dim mySQLDB_SUB As New clsDB

        msSQL = "DELETE FROM MST_郵便番号"
        mCommand = mySQLDB_SUB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        Call mySQLDB_SUB.Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'リンク先に移動したことにする
        LinkLabel1.LinkVisited = True
        'ブラウザで開く
        System.Diagnostics.Process.Start("http://www.post.japanpost.jp/zipcode/dl/roman-zip.html")


    End Sub
End Class
