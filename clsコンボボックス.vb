Imports System.Data
Imports System.Data.SqlClient

Public Class clsコンボボックス
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public Sub 検温コンボ(setDDL As ComboBox)
        ''検温コンボ
        setDDL.Items.Add("0.0")
        For n温度 As Decimal = 35.0 To 38 Step 0.1
            setDDL.Items.Add(n温度.ToString("#.0"))
        Next
        setDDL.Text = 36.5

    End Sub

    Public Sub 時コンボ(setDDL As ComboBox, Optional set初期時間 As String = "00")
        For n時 As Integer = 0 To 23
            setDDL.Items.Add(n時.ToString("00"))
        Next
        setDDL.Text = set初期時間

    End Sub

    Public Sub 分コンボ(setDDL As ComboBox)
        For n分 As Integer = 0 To 59 Step my環境設定.分入力単位
            setDDL.Items.Add(n分.ToString("00"))
        Next

    End Sub

    Public Sub 区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (区分名) as 表示,区分"
        getSQL += " FROM MST_区分"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " ORDER BY 区分,区分名"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("区分") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "区分"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 口座区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 1 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 職名コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 2 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 資格コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 3 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 担当コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 4 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 勤務区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 5 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 休憩時間コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容,(内容 + '　(' + 備考 + ')')as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 6 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = "0"
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 1

        End With
    End Sub

    Public Sub 部署コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容,(内容)as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 7 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 1

        End With
    End Sub

    Public Sub 勤務内容コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容,(内容)as 表示"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 区分 = 8 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 1

        End With
    End Sub

    Public Sub クラスコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 9 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub
    Public Sub 職員コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT 職員ID"
        getSQL += " ,(職員氏名) as Display"
        getSQL += " ,フリガナ"
        getSQL += " FROM MST_職員"
        getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " AND 退職日 IS NULL"
        getSQL += " ORDER BY フリガナ"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow

        myRow("職員ID") = ""
        myRow("Display") = ""

        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .ValueMember = "職員ID"
            .DisplayMember = "Display"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With

    End Sub

End Class
