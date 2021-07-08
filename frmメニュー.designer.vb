<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmメニュー
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab依頼書 = New System.Windows.Forms.TabPage()
        Me.btn超過勤務確認 = New System.Windows.Forms.Button()
        Me.btnシフト管理表 = New System.Windows.Forms.Button()
        Me.btnカレンダーマスタ = New System.Windows.Forms.Button()
        Me.tabマスタ = New System.Windows.Forms.TabPage()
        Me.btn郵便番号取込 = New System.Windows.Forms.Button()
        Me.btn事務所マスタ = New System.Windows.Forms.Button()
        Me.btn職員マスタ = New System.Windows.Forms.Button()
        Me.btn区分管理マスタ = New System.Windows.Forms.Button()
        Me.btn環境設定 = New System.Windows.Forms.Button()
        Me.lblバージョン = New System.Windows.Forms.Label()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn児童マスタ = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tab依頼書.SuspendLayout()
        Me.tabマスタ.SuspendLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab依頼書)
        Me.TabControl1.Controls.Add(Me.tabマスタ)
        Me.TabControl1.Location = New System.Drawing.Point(420, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 654)
        Me.TabControl1.TabIndex = 2
        '
        'tab依頼書
        '
        Me.tab依頼書.BackColor = System.Drawing.Color.White
        Me.tab依頼書.Controls.Add(Me.btn超過勤務確認)
        Me.tab依頼書.Controls.Add(Me.btnシフト管理表)
        Me.tab依頼書.Controls.Add(Me.btnカレンダーマスタ)
        Me.tab依頼書.Location = New System.Drawing.Point(4, 29)
        Me.tab依頼書.Name = "tab依頼書"
        Me.tab依頼書.Padding = New System.Windows.Forms.Padding(3)
        Me.tab依頼書.Size = New System.Drawing.Size(742, 621)
        Me.tab依頼書.TabIndex = 0
        Me.tab依頼書.Text = "入退記録"
        '
        'btn超過勤務確認
        '
        Me.btn超過勤務確認.Location = New System.Drawing.Point(20, 71)
        Me.btn超過勤務確認.Name = "btn超過勤務確認"
        Me.btn超過勤務確認.Size = New System.Drawing.Size(230, 45)
        Me.btn超過勤務確認.TabIndex = 14
        Me.btn超過勤務確認.Text = "超過勤務確認"
        Me.btn超過勤務確認.UseVisualStyleBackColor = True
        '
        'btnシフト管理表
        '
        Me.btnシフト管理表.Location = New System.Drawing.Point(257, 20)
        Me.btnシフト管理表.Name = "btnシフト管理表"
        Me.btnシフト管理表.Size = New System.Drawing.Size(230, 45)
        Me.btnシフト管理表.TabIndex = 13
        Me.btnシフト管理表.Text = "シフト管理表"
        Me.btnシフト管理表.UseVisualStyleBackColor = True
        '
        'btnカレンダーマスタ
        '
        Me.btnカレンダーマスタ.Location = New System.Drawing.Point(20, 20)
        Me.btnカレンダーマスタ.Name = "btnカレンダーマスタ"
        Me.btnカレンダーマスタ.Size = New System.Drawing.Size(230, 45)
        Me.btnカレンダーマスタ.TabIndex = 12
        Me.btnカレンダーマスタ.Text = "カレンダーマスタ"
        Me.btnカレンダーマスタ.UseVisualStyleBackColor = True
        '
        'tabマスタ
        '
        Me.tabマスタ.Controls.Add(Me.btn児童マスタ)
        Me.tabマスタ.Controls.Add(Me.btn郵便番号取込)
        Me.tabマスタ.Controls.Add(Me.btn事務所マスタ)
        Me.tabマスタ.Controls.Add(Me.btn職員マスタ)
        Me.tabマスタ.Controls.Add(Me.btn区分管理マスタ)
        Me.tabマスタ.Controls.Add(Me.btn環境設定)
        Me.tabマスタ.Location = New System.Drawing.Point(4, 29)
        Me.tabマスタ.Name = "tabマスタ"
        Me.tabマスタ.Size = New System.Drawing.Size(742, 621)
        Me.tabマスタ.TabIndex = 3
        Me.tabマスタ.Text = "マスタ"
        Me.tabマスタ.UseVisualStyleBackColor = True
        '
        'btn郵便番号取込
        '
        Me.btn郵便番号取込.Location = New System.Drawing.Point(492, 560)
        Me.btn郵便番号取込.Name = "btn郵便番号取込"
        Me.btn郵便番号取込.Size = New System.Drawing.Size(230, 45)
        Me.btn郵便番号取込.TabIndex = 9
        Me.btn郵便番号取込.Text = "郵便番号取込"
        Me.btn郵便番号取込.UseVisualStyleBackColor = True
        Me.btn郵便番号取込.Visible = False
        '
        'btn事務所マスタ
        '
        Me.btn事務所マスタ.Location = New System.Drawing.Point(256, 20)
        Me.btn事務所マスタ.Name = "btn事務所マスタ"
        Me.btn事務所マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn事務所マスタ.TabIndex = 8
        Me.btn事務所マスタ.Text = "事務所マスタ"
        Me.btn事務所マスタ.UseVisualStyleBackColor = True
        Me.btn事務所マスタ.Visible = False
        '
        'btn職員マスタ
        '
        Me.btn職員マスタ.Location = New System.Drawing.Point(20, 20)
        Me.btn職員マスタ.Name = "btn職員マスタ"
        Me.btn職員マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn職員マスタ.TabIndex = 0
        Me.btn職員マスタ.Text = "職員マスタ"
        Me.btn職員マスタ.UseVisualStyleBackColor = True
        '
        'btn区分管理マスタ
        '
        Me.btn区分管理マスタ.Location = New System.Drawing.Point(256, 560)
        Me.btn区分管理マスタ.Name = "btn区分管理マスタ"
        Me.btn区分管理マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn区分管理マスタ.TabIndex = 7
        Me.btn区分管理マスタ.Text = "区分管理マスタ"
        Me.btn区分管理マスタ.UseVisualStyleBackColor = True
        '
        'btn環境設定
        '
        Me.btn環境設定.Location = New System.Drawing.Point(20, 560)
        Me.btn環境設定.Name = "btn環境設定"
        Me.btn環境設定.Size = New System.Drawing.Size(230, 45)
        Me.btn環境設定.TabIndex = 6
        Me.btn環境設定.Text = "環境設定"
        Me.btn環境設定.UseVisualStyleBackColor = True
        '
        'lblバージョン
        '
        Me.lblバージョン.AutoSize = True
        Me.lblバージョン.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblバージョン.Location = New System.Drawing.Point(301, 126)
        Me.lblバージョン.Name = "lblバージョン"
        Me.lblバージョン.Size = New System.Drawing.Size(93, 19)
        Me.lblバージョン.TabIndex = 1
        Me.lblバージョン.Text = "ver 0.0.0.0"
        '
        'picImg
        '
        Me.picImg.Image = Global.KINKAN.My.Resources.Resources.きんかんタイトル
        Me.picImg.InitialImage = Nothing
        Me.picImg.Location = New System.Drawing.Point(12, 12)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(400, 400)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 105
        Me.picImg.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 575)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(366, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 106
        Me.PictureBox2.TabStop = False
        '
        'btn児童マスタ
        '
        Me.btn児童マスタ.Location = New System.Drawing.Point(20, 72)
        Me.btn児童マスタ.Name = "btn児童マスタ"
        Me.btn児童マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn児童マスタ.TabIndex = 10
        Me.btn児童マスタ.Text = "児童マスタ"
        Me.btn児童マスタ.UseVisualStyleBackColor = True
        '
        'frmメニュー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.lblバージョン)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmメニュー"
        Me.Text = "きんかん"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.picImg, 0)
        Me.Controls.SetChildIndex(Me.lblバージョン, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.tab依頼書.ResumeLayout(False)
        Me.tabマスタ.ResumeLayout(False)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab依頼書 As TabPage
    Friend WithEvents tabマスタ As TabPage
    Friend WithEvents btn職員マスタ As Button
    Friend WithEvents btn区分管理マスタ As Button
    Friend WithEvents btn環境設定 As Button
    Friend WithEvents lblバージョン As Label
    Public WithEvents picImg As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn事務所マスタ As Button
    Friend WithEvents btn郵便番号取込 As Button
    Friend WithEvents btnシフト管理表 As Button
    Friend WithEvents btnカレンダーマスタ As Button
    Friend WithEvents btn超過勤務確認 As Button
    Friend WithEvents btn児童マスタ As Button
End Class
