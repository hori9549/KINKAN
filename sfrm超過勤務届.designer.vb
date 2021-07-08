<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm超過勤務届
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btn次 = New System.Windows.Forms.Button()
        Me.btn前 = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb超勤時間開始_分 = New System.Windows.Forms.ComboBox()
        Me.cmb超勤時間開始_時 = New System.Windows.Forms.ComboBox()
        Me.cmb勤務内容区分 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb職員 = New System.Windows.Forms.ComboBox()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btn追加 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col日付 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職員名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col超勤時間開始 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col超勤時間終了 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col勤務内容区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col勤務内容 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col承認者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col承認日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb超勤時間終了_分 = New System.Windows.Forms.ComboBox()
        Me.cmb超勤時間終了_時 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(850, 513)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(120, 40)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'btn次
        '
        Me.btn次.Location = New System.Drawing.Point(263, 9)
        Me.btn次.Name = "btn次"
        Me.btn次.Size = New System.Drawing.Size(26, 27)
        Me.btn次.TabIndex = 2
        Me.btn次.TabStop = False
        Me.btn次.Text = ">"
        Me.btn次.UseVisualStyleBackColor = True
        '
        'btn前
        '
        Me.btn前.Location = New System.Drawing.Point(12, 9)
        Me.btn前.Name = "btn前"
        Me.btn前.Size = New System.Drawing.Size(26, 27)
        Me.btn前.TabIndex = 0
        Me.btn前.TabStop = False
        Me.btn前.Text = "<"
        Me.btn前.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(720, 513)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 40)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(44, 9)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(213, 27)
        Me.lbl日付.TabIndex = 1
        Me.lbl日付.Text = "yyyy/mm/dd（曜）"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmb超勤時間終了_分)
        Me.GroupBox1.Controls.Add(Me.cmb超勤時間終了_時)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb超勤時間開始_分)
        Me.GroupBox1.Controls.Add(Me.cmb超勤時間開始_時)
        Me.GroupBox1.Controls.Add(Me.cmb勤務内容区分)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb職員)
        Me.GroupBox1.Controls.Add(Me.btn新規)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.btn追加)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgv一覧)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 471)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "予定"
        '
        'cmb超勤時間開始_分
        '
        Me.cmb超勤時間開始_分.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb超勤時間開始_分.FormattingEnabled = True
        Me.cmb超勤時間開始_分.Location = New System.Drawing.Point(406, 61)
        Me.cmb超勤時間開始_分.Name = "cmb超勤時間開始_分"
        Me.cmb超勤時間開始_分.Size = New System.Drawing.Size(50, 32)
        Me.cmb超勤時間開始_分.TabIndex = 10
        '
        'cmb超勤時間開始_時
        '
        Me.cmb超勤時間開始_時.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb超勤時間開始_時.FormattingEnabled = True
        Me.cmb超勤時間開始_時.Location = New System.Drawing.Point(344, 61)
        Me.cmb超勤時間開始_時.Name = "cmb超勤時間開始_時"
        Me.cmb超勤時間開始_時.Size = New System.Drawing.Size(50, 32)
        Me.cmb超勤時間開始_時.TabIndex = 8
        '
        'cmb勤務内容区分
        '
        Me.cmb勤務内容区分.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb勤務内容区分.FormattingEnabled = True
        Me.cmb勤務内容区分.Location = New System.Drawing.Point(295, 25)
        Me.cmb勤務内容区分.Name = "cmb勤務内容区分"
        Me.cmb勤務内容区分.Size = New System.Drawing.Size(238, 32)
        Me.cmb勤務内容区分.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "勤務内容"
        '
        'cmb職員
        '
        Me.cmb職員.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb職員.FormattingEnabled = True
        Me.cmb職員.Location = New System.Drawing.Point(71, 61)
        Me.cmb職員.Name = "cmb職員"
        Me.cmb職員.Size = New System.Drawing.Size(201, 32)
        Me.cmb職員.TabIndex = 6
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(121, 25)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(26, 27)
        Me.btn新規.TabIndex = 2
        Me.btn新規.TabStop = False
        Me.btn新規.Text = "+"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(71, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(51, 26)
        Me.txtID.TabIndex = 1
        Me.txtID.TabStop = False
        '
        'btn追加
        '
        Me.btn追加.Location = New System.Drawing.Point(827, 53)
        Me.btn追加.Name = "btn追加"
        Me.btn追加.Size = New System.Drawing.Size(125, 40)
        Me.btn追加.TabIndex = 15
        Me.btn追加.Text = "登録"
        Me.btn追加.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "職員"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "～"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "時間"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col削除, Me.col日付, Me.col職員ID, Me.col職員名, Me.col超勤時間開始, Me.col超勤時間終了, Me.col勤務内容区分, Me.col勤務内容, Me.col承認者, Me.col承認日})
        Me.dgv一覧.Location = New System.Drawing.Point(6, 98)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(946, 367)
        Me.dgv一覧.TabIndex = 16
        Me.dgv一覧.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.Frozen = True
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 70
        '
        'col施設ID
        '
        Me.col施設ID.DataPropertyName = "施設ID"
        Me.col施設ID.HeaderText = "施設ID"
        Me.col施設ID.Name = "col施設ID"
        Me.col施設ID.ReadOnly = True
        Me.col施設ID.Visible = False
        '
        'col削除
        '
        Me.col削除.HeaderText = "削除"
        Me.col削除.Name = "col削除"
        Me.col削除.ReadOnly = True
        Me.col削除.Width = 75
        '
        'col日付
        '
        Me.col日付.DataPropertyName = "日付"
        Me.col日付.HeaderText = "日付"
        Me.col日付.Name = "col日付"
        Me.col日付.ReadOnly = True
        Me.col日付.Visible = False
        '
        'col職員ID
        '
        Me.col職員ID.DataPropertyName = "職員ID"
        Me.col職員ID.HeaderText = "職員ID"
        Me.col職員ID.Name = "col職員ID"
        Me.col職員ID.ReadOnly = True
        Me.col職員ID.Visible = False
        '
        'col職員名
        '
        Me.col職員名.DataPropertyName = "職員名"
        Me.col職員名.HeaderText = "職員名"
        Me.col職員名.Name = "col職員名"
        Me.col職員名.ReadOnly = True
        Me.col職員名.Width = 200
        '
        'col超勤時間開始
        '
        Me.col超勤時間開始.DataPropertyName = "超勤時間開始"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.col超勤時間開始.DefaultCellStyle = DataGridViewCellStyle1
        Me.col超勤時間開始.HeaderText = "時間開始"
        Me.col超勤時間開始.Name = "col超勤時間開始"
        Me.col超勤時間開始.ReadOnly = True
        Me.col超勤時間開始.Width = 120
        '
        'col超勤時間終了
        '
        Me.col超勤時間終了.DataPropertyName = "超勤時間終了"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col超勤時間終了.DefaultCellStyle = DataGridViewCellStyle2
        Me.col超勤時間終了.HeaderText = "時間終了"
        Me.col超勤時間終了.Name = "col超勤時間終了"
        Me.col超勤時間終了.ReadOnly = True
        Me.col超勤時間終了.Width = 120
        '
        'col勤務内容区分
        '
        Me.col勤務内容区分.DataPropertyName = "勤務内容区分"
        Me.col勤務内容区分.HeaderText = "勤務内容区分"
        Me.col勤務内容区分.Name = "col勤務内容区分"
        Me.col勤務内容区分.ReadOnly = True
        Me.col勤務内容区分.Visible = False
        '
        'col勤務内容
        '
        Me.col勤務内容.DataPropertyName = "勤務内容"
        Me.col勤務内容.HeaderText = "勤務内容"
        Me.col勤務内容.Name = "col勤務内容"
        Me.col勤務内容.ReadOnly = True
        Me.col勤務内容.Width = 350
        '
        'col承認者
        '
        Me.col承認者.DataPropertyName = "承認者"
        Me.col承認者.HeaderText = "承認者"
        Me.col承認者.Name = "col承認者"
        Me.col承認者.ReadOnly = True
        Me.col承認者.Visible = False
        '
        'col承認日
        '
        Me.col承認日.DataPropertyName = "承認日"
        Me.col承認日.HeaderText = "承認日"
        Me.col承認日.Name = "col承認日"
        Me.col承認日.ReadOnly = True
        Me.col承認日.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(390, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "："
        '
        'cmb超勤時間終了_分
        '
        Me.cmb超勤時間終了_分.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb超勤時間終了_分.FormattingEnabled = True
        Me.cmb超勤時間終了_分.Location = New System.Drawing.Point(545, 60)
        Me.cmb超勤時間終了_分.Name = "cmb超勤時間終了_分"
        Me.cmb超勤時間終了_分.Size = New System.Drawing.Size(50, 32)
        Me.cmb超勤時間終了_分.TabIndex = 14
        '
        'cmb超勤時間終了_時
        '
        Me.cmb超勤時間終了_時.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb超勤時間終了_時.FormattingEnabled = True
        Me.cmb超勤時間終了_時.Location = New System.Drawing.Point(483, 60)
        Me.cmb超勤時間終了_時.Name = "cmb超勤時間終了_時"
        Me.cmb超勤時間終了_時.Size = New System.Drawing.Size(50, 32)
        Me.cmb超勤時間終了_時.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "："
        '
        'sfrm超過勤務届
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btn次)
        Me.Controls.Add(Me.btn前)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "sfrm超過勤務届"
        Me.ShowInTaskbar = False
        Me.Text = "超過勤務届"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbl日付 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btn追加 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btn新規 As Button
    Friend WithEvents btn前 As Button
    Friend WithEvents btn次 As Button
    Friend WithEvents cmb職員 As ComboBox
    Friend WithEvents cmb勤務内容区分 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col削除 As DataGridViewButtonColumn
    Friend WithEvents col日付 As DataGridViewTextBoxColumn
    Friend WithEvents col職員ID As DataGridViewTextBoxColumn
    Friend WithEvents col職員名 As DataGridViewTextBoxColumn
    Friend WithEvents col超勤時間開始 As DataGridViewTextBoxColumn
    Friend WithEvents col超勤時間終了 As DataGridViewTextBoxColumn
    Friend WithEvents col勤務内容区分 As DataGridViewTextBoxColumn
    Friend WithEvents col勤務内容 As DataGridViewTextBoxColumn
    Friend WithEvents col承認者 As DataGridViewTextBoxColumn
    Friend WithEvents col承認日 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb超勤時間開始_分 As ComboBox
    Friend WithEvents cmb超勤時間開始_時 As ComboBox
    Friend WithEvents cmb超勤時間終了_分 As ComboBox
    Friend WithEvents cmb超勤時間終了_時 As ComboBox
    Friend WithEvents Label7 As Label
End Class
