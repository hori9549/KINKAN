<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrmログイン
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
        Me.btnログイン = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtパスワード = New System.Windows.Forms.TextBox()
        Me.txt職員ID = New System.Windows.Forms.TextBox()
        Me.lblメッセージ = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(300, 158)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(128, 44)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'btnログイン
        '
        Me.btnログイン.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnログイン.BackColor = System.Drawing.Color.Transparent
        Me.btnログイン.Location = New System.Drawing.Point(110, 158)
        Me.btnログイン.Margin = New System.Windows.Forms.Padding(5)
        Me.btnログイン.Name = "btnログイン"
        Me.btnログイン.Size = New System.Drawing.Size(128, 44)
        Me.btnログイン.TabIndex = 4
        Me.btnログイン.Text = "ログイン"
        Me.btnログイン.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(104, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 19)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "パスワード"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(125, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 19)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "職員ID"
        '
        'txtパスワード
        '
        Me.txtパスワード.Location = New System.Drawing.Point(195, 62)
        Me.txtパスワード.Name = "txtパスワード"
        Me.txtパスワード.PasswordChar = Global.Microsoft.VisualBasic.ChrW(65290)
        Me.txtパスワード.Size = New System.Drawing.Size(233, 26)
        Me.txtパスワード.TabIndex = 3
        '
        'txt職員ID
        '
        Me.txt職員ID.Location = New System.Drawing.Point(195, 30)
        Me.txt職員ID.Name = "txt職員ID"
        Me.txt職員ID.Size = New System.Drawing.Size(233, 26)
        Me.txt職員ID.TabIndex = 1
        '
        'lblメッセージ
        '
        Me.lblメッセージ.AutoSize = True
        Me.lblメッセージ.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメッセージ.ForeColor = System.Drawing.Color.Red
        Me.lblメッセージ.Location = New System.Drawing.Point(106, 101)
        Me.lblメッセージ.Name = "lblメッセージ"
        Me.lblメッセージ.Size = New System.Drawing.Size(57, 19)
        Me.lblメッセージ.TabIndex = 6
        Me.lblメッセージ.Text = "XXXX"
        '
        'sfrmログイン
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(536, 216)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtパスワード)
        Me.Controls.Add(Me.txt職員ID)
        Me.Controls.Add(Me.btnログイン)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrmログイン"
        Me.ShowInTaskbar = False
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnログイン As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtパスワード As TextBox
    Friend WithEvents txt職員ID As TextBox
    Friend WithEvents lblメッセージ As Label
End Class
