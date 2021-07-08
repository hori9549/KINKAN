Imports System.Data
Imports System.Data.SqlClient
Public Class frmL勤怠登録
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Shared _mutex As System.Threading.Mutex

    Private Sub picImg_Click(sender As Object, e As EventArgs) Handles picImg.Click
        Dim sfrm As New sfrmログイン
        Select Case sfrm.ShowDialog()
            Case DialogResult.OK
                Me.Hide()
                Dim sfrmメニュー As New frmメニュー
                Call sfrmメニュー.ShowDialog()
                Me.Show()

            Case Else
        End Select

        Call sub予定一覧(lbl日付.Text)
        Call sub職員一覧()
    End Sub

    Private Sub frmLログイン_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''多重起動禁止========================================================
            _mutex = New System.Threading.Mutex(False, Application.ProductName)

            If _mutex.WaitOne(0, False) = False Then
                sfrmメッセージ.ShowDialog("多重起動はできません。")
                Call Application.Exit()
            End If
            ''====================================================================
        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

        lblバージョン.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        ''環境設定読み込み
        my環境設定 = New cls環境設定
        tim時間.Enabled = True
        slb施設名.Text = my環境設定.施設名

        lbl施設.Text = my環境設定.施設名
        lbl日付.Text = Now.Date.ToString("yyyy/MM/dd（ddd）")
        lbl時間.Text = Now.ToString("HH:mm")
        Call sub予定一覧(lbl日付.Text)
        Call sub職員一覧()
    End Sub

    Private Sub tim時間_Tick(sender As Object, e As EventArgs) Handles tim時間.Tick
        lbl日付.Text = Now.Date.ToString("yyyy/MM/dd（ddd）")
        lbl時間.Text = Now.ToString("HH:mm")

    End Sub

    Private Sub sub職員一覧()
        Dim cDB As New clsDB
        Dim sSubSQL1, sSubSQL2 As String
        Dim dtbl職員 As New DataTable

        sSubSQL1 = "SELECT * FROM TBL_職員勤務履歴"
        sSubSQL1 += " WHERE TBL_職員勤務履歴.日付='" & CDate(lbl日付.Text) & "'"

        sSubSQL2 = "SELECT TBL_職員出張履歴.ID FROM TBL_職員出張履歴 "
        sSubSQL2 += " WHERE TBL_職員出張履歴.施設ID=MST_職員.施設ID"
        sSubSQL2 += " AND TBL_職員出張履歴.職員ID=MST_職員.職員ID"
        sSubSQL2 += " AND TBL_職員出張履歴.終了時間=''"

        msSQL = "SELECT MST_職員.*"
        msSQL += ",(" & sSubSQL2 & ")as 出張"
        msSQL += " ,TS.シフト出勤時間,TS.出勤時間,TS.退勤時間 FROM MST_職員"
        msSQL += " LEFT JOIN (" & sSubSQL1 & ")TS"
        msSQL += " ON MST_職員.施設ID = TS.施設ID"
        msSQL += " AND MST_職員.職員ID = TS.職員ID"

        msSQL += " WHERE MST_職員.退職日 is NULL"
        msSQL += " AND MST_職員.施設ID='" & my環境設定.施設ID & "'"

        msSQL += " ORDER BY CONVERT(int,MST_職員.職員ID)"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl職員) ''データセット作成

        Dim btn職員 As Control
        Dim nカウント As Integer = 1
        For Each getRow As DataRow In dtbl職員.Rows
            btn職員 = Me.Controls("btn" & nカウント)
            CType(btn職員, Button).Text = "　 " & getRow("職員氏名")

            Select Case getRow("出張").ToString
                Case <> ""
                    CType(btn職員, Button).ForeColor = Color.Black
                    CType(btn職員, Button).Enabled = True
                    CType(btn職員, Button).Image = KINKAN.My.Resources.Resources.出張

                Case Else
                    ''出退確認
                    If getRow("出勤時間").ToString = "" Then
                        If getRow("シフト出勤時間").ToString <> "" Then
                            CType(btn職員, Button).ForeColor = Color.Black
                            CType(btn職員, Button).Enabled = True
                            CType(btn職員, Button).Image = Nothing
                        Else
                            CType(btn職員, Button).ForeColor = Color.Gray
                            CType(btn職員, Button).Enabled = True
                            CType(btn職員, Button).Image = KINKAN.My.Resources.Resources.休暇

                        End If

                    Else
                        If getRow("退勤時間").ToString = "" Then
                            CType(btn職員, Button).ForeColor = Color.Blue
                            CType(btn職員, Button).Enabled = True
                            CType(btn職員, Button).Image = KINKAN.My.Resources.Resources.出社

                        Else
                            CType(btn職員, Button).ForeColor = Color.Red
                            CType(btn職員, Button).Enabled = False
                            CType(btn職員, Button).Image = KINKAN.My.Resources.Resources.退勤

                        End If
                    End If

            End Select

            CType(btn職員, Button).Tag = getRow("職員ID")
            nカウント += 1
        Next

    End Sub

    Private Sub sub予定一覧(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable

        msSQL = "SELECT 開始時間,終了時間,予定 FROM MST_カレンダー予定"
        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        msSQL += " AND 日付='" & set日付 & "'"
        msSQL += " ORDER BY ID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成

        dgv一覧.DataSource = dtbl予定

    End Sub

    Private Sub btn職員_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click _
                                                                        , btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click _
                                                                        , btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click _
                                                                        , btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click

        If CType(sender, Button).Tag.ToString = "" Then Exit Sub

        Dim cDB As New clsDB
        Dim dtbl職員勤務履歴 As New DataTable
        Dim sSubSQL As String
        Dim get施設ID As String = my環境設定.施設ID
        Dim get職員ID As String = CType(sender, Button).Tag
        Dim get日付 As String = CDate(lbl日付.Text)
        Dim get時間 As String = lbl時間.Text
        Dim get検温 As String = 0
        Dim get場所 As String = ""
        Dim sfrm出勤 As New sfrm出勤確認
        Dim sfrm退勤 As New sfrm退勤確認
        Dim sfrm出張 As New sfrm出張確認

        sSubSQL = "SELECT TBL_職員出張履歴.ID FROM TBL_職員出張履歴 "
        sSubSQL += " WHERE TBL_職員出張履歴.施設ID=TBL_職員勤務履歴.施設ID"
        sSubSQL += " AND TBL_職員出張履歴.職員ID=TBL_職員勤務履歴.職員ID"
        sSubSQL += " AND TBL_職員出張履歴.終了時間 =''"

        ''TBL_職員勤務履歴更新
        msSQL = "SELECT *"
        msSQL += ",(" & sSubSQL & ")as 出張"
        msSQL += " FROM TBL_職員勤務履歴 "
        msSQL += " WHERE 施設ID='" & get施設ID & "'"
        msSQL += " AND 職員ID='" & get職員ID & "'"
        msSQL += " AND 日付='" & get日付 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl職員勤務履歴) ''データセット作成

        If dtbl職員勤務履歴.Rows.Count = 0 Then
            sfrm出勤.施設ID = get施設ID
            sfrm出勤.職員ID = get職員ID
            Select Case sfrm出勤.ShowDialog()
                Case DialogResult.OK
                    get検温 = sfrm出勤.検温
                Case Else
                    Exit Sub
            End Select

            ''出勤
            msSQL = " INSERT INTO TBL_職員勤務履歴("
            msSQL += " 施設ID"
            msSQL += ",職員ID"
            msSQL += ",日付"
            msSQL += ",出勤時間"
            msSQL += ",退勤時間"
            msSQL += ",検温"
            'msSQL += " 削除"

            msSQL += " )VALUES("

            msSQL += " '" & get施設ID & "'"
            msSQL += ",'" & get職員ID & "'"
            msSQL += ",'" & get日付 & "'"
            msSQL += ",'" & get時間 & "'"
            msSQL += ",''"
            msSQL += ",'" & get検温 & "'"
            'msSQL += ",'0'"
            msSQL += " )"

        Else
            Select Case dtbl職員勤務履歴.Rows(0)("出張").ToString
                Case <> ""
                    sfrm出張.施設ID = get施設ID
                    sfrm出張.職員ID = get職員ID
                    Select Case sfrm出張.ShowDialog()
                        Case DialogResult.OK
                            get場所 = sfrm出張.場所
                        Case Else
                            Exit Sub
                    End Select

                    ''退勤
                    msSQL = " UPDATE TBL_職員出張履歴 SET "
                    msSQL += " 終了日付 = '" & get日付 & "'"
                    msSQL += ",終了時間 = '" & get時間 & "'"

                    msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
                    msSQL += " AND 職員ID='" & get職員ID & "'"
                    msSQL += " AND 終了時間=''"

                    CType(sender, Button).ForeColor = Color.Red

                Case Else
                    If dtbl職員勤務履歴.Rows(0)("出勤時間") = "" Then
                        sfrm出勤.施設ID = get施設ID
                        sfrm出勤.職員ID = get職員ID
                        Select Case sfrm出勤.ShowDialog()
                            Case DialogResult.OK
                                get検温 = sfrm出勤.検温
                            Case Else
                                Exit Sub
                        End Select

                        ''退勤
                        msSQL = " UPDATE TBL_職員勤務履歴 SET "
                        msSQL += " 出勤時間 = '" & get時間 & "'"

                        msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
                        msSQL += " AND 職員ID='" & get職員ID & "'"
                        msSQL += " AND 日付='" & get日付 & "'"

                        CType(sender, Button).ForeColor = Color.Red

                    Else
                        sfrm退勤.施設ID = get施設ID
                        sfrm退勤.職員ID = get職員ID
                        Select Case sfrm退勤.ShowDialog()
                            Case DialogResult.OK    ''退勤
                                ''退勤
                                msSQL = " UPDATE TBL_職員勤務履歴 SET "
                                msSQL += " 退勤時間 = '" & get時間 & "'"

                                msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
                                msSQL += " AND 職員ID='" & get職員ID & "'"
                                msSQL += " AND 日付='" & get日付 & "'"

                            Case DialogResult.No    ''出張
                                ''退勤
                                msSQL = "INSERT INTO TBL_職員出張履歴("
                                msSQL += " 施設ID"
                                msSQL += ",職員ID"
                                msSQL += ",開始日付"
                                msSQL += ",開始時間"
                                msSQL += ",終了日付"
                                msSQL += ",終了時間"
                                msSQL += ",場所"

                                msSQL += " )VALUES("

                                msSQL += " '" & get施設ID & "'"
                                msSQL += ",'" & get職員ID & "'"
                                msSQL += ",'" & get日付 & "'"
                                msSQL += ",'" & get時間 & "'"
                                msSQL += ",NULL"
                                msSQL += ",''"
                                msSQL += ",''"
                                msSQL += " )"

                            Case Else
                                Exit Sub
                        End Select

                        CType(sender, Button).ForeColor = Color.Red

                    End If
            End Select

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()


        Call sub職員一覧()
    End Sub

    Private Sub btn超過勤務届_Click(sender As Object, e As EventArgs) Handles btn超過勤務届.Click
        Dim sfrm As New sfrm超過勤務届
        sfrm.日付 = Now.Date
        sfrm.職員ID = ""
        sfrm.ShowDialog()
    End Sub
End Class