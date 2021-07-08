<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm超過勤務管理
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn一括承認 = New System.Windows.Forms.Button()
        Me.cmb勤務内容区分 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb職員 = New System.Windows.Forms.ComboBox()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btn追加 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp超勤時間終了 = New System.Windows.Forms.DateTimePicker()
        Me.dtp超勤時間開始 = New System.Windows.Forms.DateTimePicker()
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
        Me.col承認日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col承認者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col承認者名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk第3延長 = New System.Windows.Forms.CheckBox()
        Me.chk第2延長 = New System.Windows.Forms.CheckBox()
        Me.chk第1延長 = New System.Windows.Forms.CheckBox()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.cmb職員検索 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btn次 = New System.Windows.Forms.Button()
        Me.btn前 = New System.Windows.Forms.Button()
        Me.lbl年月 = New System.Windows.Forms.Label()
        Me.btn超過勤務一覧 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(1042, 707)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(124, 40)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn一括承認)
        Me.GroupBox1.Controls.Add(Me.cmb勤務内容区分)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb職員)
        Me.GroupBox1.Controls.Add(Me.btn新規)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.btn追加)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp超勤時間終了)
        Me.GroupBox1.Controls.Add(Me.dtp超勤時間開始)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgv一覧)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 621)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btn一括承認
        '
        Me.btn一括承認.Location = New System.Drawing.Point(1029, 573)
        Me.btn一括承認.Name = "btn一括承認"
        Me.btn一括承認.Size = New System.Drawing.Size(125, 40)
        Me.btn一括承認.TabIndex = 30
        Me.btn一括承認.Text = "一括承認"
        Me.btn一括承認.UseVisualStyleBackColor = True
        '
        'cmb勤務内容区分
        '
        Me.cmb勤務内容区分.FormattingEnabled = True
        Me.cmb勤務内容区分.Location = New System.Drawing.Point(285, 21)
        Me.cmb勤務内容区分.Name = "cmb勤務内容区分"
        Me.cmb勤務内容区分.Size = New System.Drawing.Size(224, 27)
        Me.cmb勤務内容区分.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "勤務内容"
        '
        'cmb職員
        '
        Me.cmb職員.FormattingEnabled = True
        Me.cmb職員.Location = New System.Drawing.Point(61, 52)
        Me.cmb職員.Name = "cmb職員"
        Me.cmb職員.Size = New System.Drawing.Size(201, 27)
        Me.cmb職員.TabIndex = 24
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(111, 21)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(26, 27)
        Me.btn新規.TabIndex = 20
        Me.btn新規.TabStop = False
        Me.btn新規.Text = "+"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ID"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(61, 21)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(51, 26)
        Me.txtID.TabIndex = 19
        Me.txtID.TabStop = False
        '
        'btn追加
        '
        Me.btn追加.Location = New System.Drawing.Point(1029, 39)
        Me.btn追加.Name = "btn追加"
        Me.btn追加.Size = New System.Drawing.Size(125, 40)
        Me.btn追加.TabIndex = 29
        Me.btn追加.Text = "登録"
        Me.btn追加.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "職員"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "～"
        '
        'dtp超勤時間終了
        '
        Me.dtp超勤時間終了.CustomFormat = "HH:mm"
        Me.dtp超勤時間終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp超勤時間終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp超勤時間終了.Location = New System.Drawing.Point(429, 52)
        Me.dtp超勤時間終了.Name = "dtp超勤時間終了"
        Me.dtp超勤時間終了.ShowUpDown = True
        Me.dtp超勤時間終了.Size = New System.Drawing.Size(80, 26)
        Me.dtp超勤時間終了.TabIndex = 28
        '
        'dtp超勤時間開始
        '
        Me.dtp超勤時間開始.CustomFormat = "HH:mm"
        Me.dtp超勤時間開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp超勤時間開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp超勤時間開始.Location = New System.Drawing.Point(330, 52)
        Me.dtp超勤時間開始.Name = "dtp超勤時間開始"
        Me.dtp超勤時間開始.ShowUpDown = True
        Me.dtp超勤時間開始.Size = New System.Drawing.Size(69, 26)
        Me.dtp超勤時間開始.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 25
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
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col削除, Me.col日付, Me.col職員ID, Me.col職員名, Me.col超勤時間開始, Me.col超勤時間終了, Me.col勤務内容区分, Me.col勤務内容, Me.col承認日, Me.col承認者, Me.col承認者名})
        Me.dgv一覧.Location = New System.Drawing.Point(6, 89)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1148, 478)
        Me.dgv一覧.TabIndex = 17
        Me.dgv一覧.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
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
        Me.col日付.Width = 120
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
        Me.col超勤時間開始.HeaderText = "超勤開始"
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
        Me.col超勤時間終了.HeaderText = "超勤終了"
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
        Me.col勤務内容.Width = 250
        '
        'col承認日
        '
        Me.col承認日.DataPropertyName = "承認日"
        Me.col承認日.HeaderText = "承認日"
        Me.col承認日.Name = "col承認日"
        Me.col承認日.ReadOnly = True
        Me.col承認日.Width = 120
        '
        'col承認者
        '
        Me.col承認者.DataPropertyName = "承認者"
        Me.col承認者.HeaderText = "承認者"
        Me.col承認者.Name = "col承認者"
        Me.col承認者.ReadOnly = True
        Me.col承認者.Visible = False
        '
        'col承認者名
        '
        Me.col承認者名.DataPropertyName = "承認者名"
        Me.col承認者名.HeaderText = "承認者名"
        Me.col承認者名.Name = "col承認者名"
        Me.col承認者名.ReadOnly = True
        Me.col承認者名.Width = 120
        '
        'chk第3延長
        '
        Me.chk第3延長.AutoSize = True
        Me.chk第3延長.Location = New System.Drawing.Point(767, 45)
        Me.chk第3延長.Name = "chk第3延長"
        Me.chk第3延長.Size = New System.Drawing.Size(104, 23)
        Me.chk第3延長.TabIndex = 8
        Me.chk第3延長.Text = "夕方延長"
        Me.chk第3延長.UseVisualStyleBackColor = True
        '
        'chk第2延長
        '
        Me.chk第2延長.AutoSize = True
        Me.chk第2延長.Location = New System.Drawing.Point(532, 45)
        Me.chk第2延長.Name = "chk第2延長"
        Me.chk第2延長.Size = New System.Drawing.Size(104, 23)
        Me.chk第2延長.TabIndex = 7
        Me.chk第2延長.Text = "通常延長"
        Me.chk第2延長.UseVisualStyleBackColor = True
        '
        'chk第1延長
        '
        Me.chk第1延長.AutoSize = True
        Me.chk第1延長.Location = New System.Drawing.Point(297, 45)
        Me.chk第1延長.Name = "chk第1延長"
        Me.chk第1延長.Size = New System.Drawing.Size(104, 23)
        Me.chk第1延長.TabIndex = 6
        Me.chk第1延長.Text = "早朝延長"
        Me.chk第1延長.UseVisualStyleBackColor = True
        '
        'btn検索
        '
        Me.btn検索.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn検索.Location = New System.Drawing.Point(1038, 28)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(128, 40)
        Me.btn検索.TabIndex = 16
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'cmb職員検索
        '
        Me.cmb職員検索.FormattingEnabled = True
        Me.cmb職員検索.Location = New System.Drawing.Point(73, 45)
        Me.cmb職員検索.Name = "cmb職員検索"
        Me.cmb職員検索.Size = New System.Drawing.Size(201, 27)
        Me.cmb職員検索.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "職員"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(910, 708)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(124, 40)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btn次
        '
        Me.btn次.Location = New System.Drawing.Point(211, 9)
        Me.btn次.Name = "btn次"
        Me.btn次.Size = New System.Drawing.Size(26, 27)
        Me.btn次.TabIndex = 9
        Me.btn次.TabStop = False
        Me.btn次.Text = ">"
        Me.btn次.UseVisualStyleBackColor = True
        '
        'btn前
        '
        Me.btn前.Location = New System.Drawing.Point(15, 9)
        Me.btn前.Name = "btn前"
        Me.btn前.Size = New System.Drawing.Size(26, 27)
        Me.btn前.TabIndex = 7
        Me.btn前.TabStop = False
        Me.btn前.Text = "<"
        Me.btn前.UseVisualStyleBackColor = True
        '
        'lbl年月
        '
        Me.lbl年月.AutoSize = True
        Me.lbl年月.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl年月.Location = New System.Drawing.Point(47, 9)
        Me.lbl年月.Name = "lbl年月"
        Me.lbl年月.Size = New System.Drawing.Size(158, 27)
        Me.lbl年月.TabIndex = 8
        Me.lbl年月.Text = "yyyy年mm月"
        '
        'btn超過勤務一覧
        '
        Me.btn超過勤務一覧.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn超過勤務一覧.ForeColor = System.Drawing.Color.Green
        Me.btn超過勤務一覧.Location = New System.Drawing.Point(742, 708)
        Me.btn超過勤務一覧.Margin = New System.Windows.Forms.Padding(5)
        Me.btn超過勤務一覧.Name = "btn超過勤務一覧"
        Me.btn超過勤務一覧.Size = New System.Drawing.Size(160, 40)
        Me.btn超過勤務一覧.TabIndex = 45
        Me.btn超過勤務一覧.Text = "超過勤務一覧"
        Me.btn超過勤務一覧.UseVisualStyleBackColor = True
        '
        'sfrm超過勤務管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btn超過勤務一覧)
        Me.Controls.Add(Me.btn次)
        Me.Controls.Add(Me.btn検索)
        Me.Controls.Add(Me.chk第3延長)
        Me.Controls.Add(Me.btn前)
        Me.Controls.Add(Me.chk第2延長)
        Me.Controls.Add(Me.lbl年月)
        Me.Controls.Add(Me.chk第1延長)
        Me.Controls.Add(Me.cmb職員検索)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "sfrm超過勤務管理"
        Me.ShowInTaskbar = False
        Me.Text = "超過勤務管一覧"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btn検索 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb職員検索 As ComboBox
    Friend WithEvents chk第3延長 As CheckBox
    Friend WithEvents chk第2延長 As CheckBox
    Friend WithEvents chk第1延長 As CheckBox
    Friend WithEvents btn次 As Button
    Friend WithEvents btn前 As Button
    Friend WithEvents lbl年月 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents cmb勤務内容区分 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb職員 As ComboBox
    Friend WithEvents btn新規 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btn追加 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp超勤時間終了 As DateTimePicker
    Friend WithEvents dtp超勤時間開始 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn超過勤務一覧 As Button
    Friend WithEvents btn一括承認 As Button
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
    Friend WithEvents col承認日 As DataGridViewTextBoxColumn
    Friend WithEvents col承認者 As DataGridViewTextBoxColumn
    Friend WithEvents col承認者名 As DataGridViewTextBoxColumn
End Class
