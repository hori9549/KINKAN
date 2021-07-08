<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM郵便番号取込
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.txtCSVパス = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn選択 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btn終了
        '
        Me.btn終了.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn終了.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn終了.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn終了.ForeColor = System.Drawing.Color.Red
        Me.btn終了.Location = New System.Drawing.Point(684, 180)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(5)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(125, 44)
        Me.btn終了.TabIndex = 4
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btn登録
        '
        Me.btn登録.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn登録.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(549, 180)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 44)
        Me.btn登録.TabIndex = 3
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'txtCSVパス
        '
        Me.txtCSVパス.Location = New System.Drawing.Point(201, 68)
        Me.txtCSVパス.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCSVパス.Name = "txtCSVパス"
        Me.txtCSVパス.ReadOnly = True
        Me.txtCSVパス.Size = New System.Drawing.Size(487, 26)
        Me.txtCSVパス.TabIndex = 213
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "CSVファイル"
        '
        'btn選択
        '
        Me.btn選択.Location = New System.Drawing.Point(701, 70)
        Me.btn選択.Margin = New System.Windows.Forms.Padding(5)
        Me.btn選択.Name = "btn選択"
        Me.btn選択.Size = New System.Drawing.Size(108, 29)
        Me.btn選択.TabIndex = 215
        Me.btn選択.Text = "選択"
        Me.btn選択.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 124)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(788, 36)
        Me.ProgressBar1.TabIndex = 216
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 9)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(599, 38)
        Me.LinkLabel1.TabIndex = 218
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "郵便局のサイト【http://www.post.japanpost.jp/zipcode/dl/roman-zip.html】" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "より最新版をダウンロードし、CS" &
    "Vデータの取込をすることができます。"
        '
        'frmM郵便番号取込
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn終了
        Me.ClientSize = New System.Drawing.Size(830, 251)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn選択)
        Me.Controls.Add(Me.txtCSVパス)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.btn終了)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmM郵便番号取込"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "郵便番号取込"
        Me.Controls.SetChildIndex(Me.btn終了, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCSVパス, 0)
        Me.Controls.SetChildIndex(Me.btn選択, 0)
        Me.Controls.SetChildIndex(Me.ProgressBar1, 0)
        Me.Controls.SetChildIndex(Me.LinkLabel1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn終了 As System.Windows.Forms.Button
    Friend WithEvents btn登録 As System.Windows.Forms.Button
    Friend WithEvents txtCSVパス As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn選択 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
