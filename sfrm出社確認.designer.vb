<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm出勤確認
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb検温 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.picImg = New System.Windows.Forms.PictureBox()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(292, 208)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(128, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'lblメッセージ
        '
        Me.lblメッセージ.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメッセージ.ForeColor = System.Drawing.Color.Blue
        Me.lblメッセージ.Location = New System.Drawing.Point(169, 9)
        Me.lblメッセージ.Name = "lblメッセージ"
        Me.lblメッセージ.Size = New System.Drawing.Size(355, 141)
        Me.lblメッセージ.TabIndex = 3
        Me.lblメッセージ.Text = "おはようございます。○○さん" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本日もよろしくお願いします。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "検温結果を選択してください。"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "体温"
        '
        'cmb検温
        '
        Me.cmb検温.FormattingEnabled = True
        Me.cmb検温.Location = New System.Drawing.Point(102, 173)
        Me.cmb検温.Name = "cmb検温"
        Me.cmb検温.Size = New System.Drawing.Size(128, 27)
        Me.cmb検温.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "℃"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(102, 208)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(128, 44)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'picImg
        '
        Me.picImg.Image = Global.KINKAN.My.Resources.Resources.きんかんアイコン
        Me.picImg.InitialImage = Nothing
        Me.picImg.Location = New System.Drawing.Point(12, 9)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(151, 141)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 109
        Me.picImg.TabStop = False
        '
        'sfrm出勤確認
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(536, 266)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb検温)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrm出勤確認"
        Me.ShowInTaskbar = False
        Me.Text = "出勤確認"
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblメッセージ As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb検温 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOK As Button
    Public WithEvents picImg As PictureBox
End Class
