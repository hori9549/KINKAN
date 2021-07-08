<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrm住所検索
    Inherits System.Windows.Forms.Form
    'Inherits sfrmベース

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
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.選択 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.郵便番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.住所 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(542, 503)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(128, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.選択, Me.郵便番号, Me.住所})
        Me.dgv一覧.Location = New System.Drawing.Point(14, 14)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.Size = New System.Drawing.Size(656, 479)
        Me.dgv一覧.TabIndex = 1
        '
        '選択
        '
        Me.選択.HeaderText = "選択"
        Me.選択.Name = "選択"
        Me.選択.Width = 75
        '
        '郵便番号
        '
        Me.郵便番号.DataPropertyName = "郵便番号"
        Me.郵便番号.HeaderText = "郵便番号"
        Me.郵便番号.Name = "郵便番号"
        Me.郵便番号.Width = 120
        '
        '住所
        '
        Me.住所.DataPropertyName = "住所"
        Me.住所.HeaderText = "住所"
        Me.住所.Name = "住所"
        Me.住所.Width = 400
        '
        'sfrm住所検索
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.dgv一覧)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrm住所検索"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "住所検索"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgv一覧 As System.Windows.Forms.DataGridView
    Friend WithEvents 選択 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 郵便番号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 住所 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
