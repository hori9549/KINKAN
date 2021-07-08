Imports System.Windows.Forms

Public Class sfrmメッセージ
    Private proメッセージ As String
    Private pro表示 As String
    Private proフォーム種類 As String
    Private proアイコン種類 As String

    Overloads Function ShowDialog(setメッセージ As String, Optional set表示 As String = "",
                             Optional setフォーム種類 As MessageBoxButtons = MessageBoxButtons.OK,
                             Optional setアイコン種類 As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        ''パラメーターをここで渡す
        proメッセージ = setメッセージ
        pro表示 = set表示
        proフォーム種類 = setフォーム種類
        proアイコン種類 = setアイコン種類

        Me.Text = pro表示
        lblメッセージ.Text = proメッセージ

        Select Case setフォーム種類
            Case MessageBoxButtons.OK
                btnキャンセル.Visible = False
            Case MessageBoxButtons.OKCancel
                btnキャンセル.Visible = True
            Case Else

        End Select

        Select Case setアイコン種類
            Case MessageBoxIcon.Error
                picImg.Image = KINKAN.My.Resources.Resources._Error
            Case MessageBoxIcon.Warning
                picImg.Image = KINKAN.My.Resources.Resources.Warning
            Case MessageBoxIcon.Information
                picImg.Image = KINKAN.My.Resources.Resources.Information
            Case MessageBoxIcon.Question
                picImg.Image = KINKAN.My.Resources.Resources.Question

            Case Else

        End Select


        ''↓画面を開く
        Return MyBase.ShowDialog
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnキャンセル.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub sfrmメッセージ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
