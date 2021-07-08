Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm住所検索
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private get住所 As String
    Public Property 検索住所() As String
        Get
            Return get住所
        End Get

        Set(ByVal value As String)
            get住所 = value
        End Set
    End Property

    Private get郵便番号 As String
    Public Property 検索郵便() As String
        Get
            Return get郵便番号
        End Get

        Set(ByVal value As String)
            get郵便番号 = value
        End Set

    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub sfrm_住所検索_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        '"-"ハイフンが入っていた場合は取り除く  
        get郵便番号 = Replace(get郵便番号, "-", "")
        msSQL = "SELECT 郵便番号, "
        msSQL += " (Replace(都道府県,'　','') + Replace(市区町村,'　','') + Replace(地区,'　','')) as 住所"
        msSQL += " FROM MST_郵便番号 WHERE 郵便番号='" & get郵便番号 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        Select Case myTable.Rows.Count
            Case 0
                get住所 = "データが見つかりません"
                Call Me.Close()
            Case 1
                get郵便番号 = myTable.Rows(0)("郵便番号")
                get住所 = myTable.Rows(0)("住所")
                Call Me.Close()
            Case Else

        End Select

        With dgv一覧
            .DataSource = myTable
        End With

    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'txtID.Text = dgv_一覧.Rows(e.RowIndex).Cells("ID").Value

        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "選択"
                get郵便番号 = dgv一覧.Rows(e.RowIndex).Cells("郵便番号").Value.ToString
                get住所 = dgv一覧.Rows(e.RowIndex).Cells("住所").Value.ToString
                Call Me.Close()

        End Select
    End Sub
End Class
