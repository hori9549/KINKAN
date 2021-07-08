<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm退勤確認
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblメッセージ = New System.Windows.Forms.Label()
        Me.btn退勤 = New System.Windows.Forms.Button()
        Me.btn出張 = New System.Windows.Forms.Button()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.btn超過勤務 = New System.Windows.Forms.Button()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(392, 254)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(128, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'lblメッセージ
        '
        Me.lblメッセージ.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメッセージ.ForeColor = System.Drawing.Color.Blue
        Me.lblメッセージ.Location = New System.Drawing.Point(171, 12)
        Me.lblメッセージ.Name = "lblメッセージ"
        Me.lblメッセージ.Size = New System.Drawing.Size(353, 141)
        Me.lblメッセージ.TabIndex = 3
        Me.lblメッセージ.Text = "おつかれさまでした。○○さん。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本日は退勤しますか？"
        '
        'btn退勤
        '
        Me.btn退勤.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn退勤.BackColor = System.Drawing.Color.Transparent
        Me.btn退勤.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn退勤.Location = New System.Drawing.Point(207, 191)
        Me.btn退勤.Margin = New System.Windows.Forms.Padding(5)
        Me.btn退勤.Name = "btn退勤"
        Me.btn退勤.Size = New System.Drawing.Size(128, 44)
        Me.btn退勤.TabIndex = 7
        Me.btn退勤.Text = "退勤"
        Me.btn退勤.UseVisualStyleBackColor = False
        '
        'btn出張
        '
        Me.btn出張.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn出張.BackColor = System.Drawing.Color.Transparent
        Me.btn出張.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn出張.Location = New System.Drawing.Point(14, 191)
        Me.btn出張.Margin = New System.Windows.Forms.Padding(5)
        Me.btn出張.Name = "btn出張"
        Me.btn出張.Size = New System.Drawing.Size(128, 44)
        Me.btn出張.TabIndex = 8
        Me.btn出張.Text = "出張"
        Me.btn出張.UseVisualStyleBackColor = False
        '
        'picImg
        '
        Me.picImg.Image = Global.KINKAN.My.Resources.Resources.きんかんアイコン
        Me.picImg.InitialImage = Nothing
        Me.picImg.Location = New System.Drawing.Point(14, 12)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(151, 141)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 110
        Me.picImg.TabStop = False
        '
        'btn超過勤務
        '
        Me.btn超過勤務.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn超過勤務.BackColor = System.Drawing.Color.Transparent
        Me.btn超過勤務.Location = New System.Drawing.Point(392, 191)
        Me.btn超過勤務.Margin = New System.Windows.Forms.Padding(5)
        Me.btn超過勤務.Name = "btn超過勤務"
        Me.btn超過勤務.Size = New System.Drawing.Size(128, 44)
        Me.btn超過勤務.TabIndex = 111
        Me.btn超過勤務.Text = "超勤退勤"
        Me.btn超過勤務.UseVisualStyleBackColor = False
        '
        'sfrm退勤確認
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(536, 312)
        Me.Controls.Add(Me.btn超過勤務)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.btn出張)
        Me.Controls.Add(Me.btn退勤)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrm退勤確認"
        Me.ShowInTaskbar = False
        Me.Text = "退勤確認"
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblメッセージ As Label
    Friend WithEvents btn退勤 As Button
    Friend WithEvents btn出張 As Button
    Public WithEvents picImg As PictureBox
    Friend WithEvents btn超過勤務 As Button
End Class
