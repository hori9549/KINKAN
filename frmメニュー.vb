Public Class frmメニュー
    Private Shared _mutex As System.Threading.Mutex
    Private OpenForm As Form

    Private Sub frmメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblバージョン.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
    End Sub

    Private Sub btn環境設定_Click(sender As Object, e As EventArgs) Handles btn環境設定.Click
        Dim sfrm As New frmM環境設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn区分管理マスタ_Click(sender As Object, e As EventArgs) Handles btn区分管理マスタ.Click
        Dim sfrm As New frmM区分管理
        Call sfrm.ShowDialog()
    End Sub


    Private Sub frmメニュー_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub btn郵便番号取込_Click(sender As Object, e As EventArgs) Handles btn郵便番号取込.Click
        Dim sfrm As New frmM郵便番号取込
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn職員マスタ_Click(sender As Object, e As EventArgs) Handles btn職員マスタ.Click
        Dim sfrm As New frmM職員マスタ
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btnカレンダーマスタ_Click(sender As Object, e As EventArgs) Handles  btnカレンダーマスタ.Click
        Dim sfrm As New frmMカレンダー
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btnシフト管理表_Click(sender As Object, e As EventArgs) Handles btnシフト管理表.Click
        Dim sfrm As New frmMシフト作成
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn超過勤務確認_Click(sender As Object, e As EventArgs) Handles btn超過勤務確認.Click
        Dim sfrm As New sfrm超過勤務管理
        sfrm.日付 = New Date(Now.Year, Now.Month, 1)
        sfrm.職員 = ""
        Call sfrm.ShowDialog()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If MS職員ID <> "1" Then
            TabControl1.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn児童マスタ_Click(sender As Object, e As EventArgs) Handles btn児童マスタ.Click
        Dim sfrm As New frmM児童マスタ
        Call sfrm.ShowDialog()
    End Sub
End Class