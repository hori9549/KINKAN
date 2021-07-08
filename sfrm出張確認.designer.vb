<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm出張確認
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
        Me.btn帰任 = New System.Windows.Forms.Button()
        Me.picImg = New System.Windows.Forms.PictureBox()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(284, 208)
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
        Me.lblメッセージ.Size = New System.Drawing.Size(356, 141)
        Me.lblメッセージ.TabIndex = 3
        Me.lblメッセージ.Text = "おかえりなさい。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "○○さん。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本日の出張は終わりましたか？"
        '
        'btn帰任
        '
        Me.btn帰任.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn帰任.BackColor = System.Drawing.Color.Transparent
        Me.btn帰任.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn帰任.Location = New System.Drawing.Point(94, 208)
        Me.btn帰任.Margin = New System.Windows.Forms.Padding(5)
        Me.btn帰任.Name = "btn帰任"
        Me.btn帰任.Size = New System.Drawing.Size(128, 44)
        Me.btn帰任.TabIndex = 7
        Me.btn帰任.Text = "帰任"
        Me.btn帰任.UseVisualStyleBackColor = False
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
        'sfrm出張確認
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(536, 266)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.btn帰任)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrm出張確認"
        Me.ShowInTaskbar = False
        Me.Text = "出張確認"
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblメッセージ As Label
    Friend WithEvents btn帰任 As Button
    Public WithEvents picImg As PictureBox
End Class
