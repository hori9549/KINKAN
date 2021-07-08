<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm勤務状況
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
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col日付 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職員名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colシフト出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colシフト退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col第1延長 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col第2延長 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col第3延長 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col検温 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col休憩時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb休憩時間 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk第3延長 = New System.Windows.Forms.CheckBox()
        Me.chk第2延長 = New System.Windows.Forms.CheckBox()
        Me.chk第1延長 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb検温 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp退勤 = New System.Windows.Forms.DateTimePicker()
        Me.dtp出勤 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpシフト退勤 = New System.Windows.Forms.DateTimePicker()
        Me.dtpシフト出勤 = New System.Windows.Forms.DateTimePicker()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btn次 = New System.Windows.Forms.Button()
        Me.btn前 = New System.Windows.Forms.Button()
        Me.lbl年月 = New System.Windows.Forms.Label()
        Me.cmb職員 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn職員名簿 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btnインポート = New System.Windows.Forms.Button()
        Me.btn一括出退処理 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Cancel_Button.TabIndex = 10
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col削除, Me.col日付, Me.col職員名, Me.colシフト出勤時間, Me.colシフト退勤時間, Me.col第1延長, Me.col第2延長, Me.col第3延長, Me.col出勤時間, Me.col退勤時間, Me.col職員ID, Me.col検温, Me.col休憩時間})
        Me.dgv一覧.Location = New System.Drawing.Point(6, 113)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1148, 492)
        Me.dgv一覧.TabIndex = 19
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
        Me.col削除.DataPropertyName = "日付"
        Me.col削除.HeaderText = "削除"
        Me.col削除.Name = "col削除"
        Me.col削除.ReadOnly = True
        Me.col削除.Width = 120
        '
        'col日付
        '
        Me.col日付.DataPropertyName = "日付"
        DataGridViewCellStyle29.Format = "d"
        DataGridViewCellStyle29.NullValue = Nothing
        Me.col日付.DefaultCellStyle = DataGridViewCellStyle29
        Me.col日付.HeaderText = "日付"
        Me.col日付.Name = "col日付"
        Me.col日付.ReadOnly = True
        Me.col日付.Visible = False
        '
        'col職員名
        '
        Me.col職員名.DataPropertyName = "職員名"
        Me.col職員名.HeaderText = "職員"
        Me.col職員名.Name = "col職員名"
        Me.col職員名.ReadOnly = True
        Me.col職員名.Visible = False
        Me.col職員名.Width = 150
        '
        'colシフト出勤時間
        '
        Me.colシフト出勤時間.DataPropertyName = "シフト出勤時間"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.Format = "t"
        DataGridViewCellStyle30.NullValue = Nothing
        Me.colシフト出勤時間.DefaultCellStyle = DataGridViewCellStyle30
        Me.colシフト出勤時間.HeaderText = "シフト出勤"
        Me.colシフト出勤時間.Name = "colシフト出勤時間"
        Me.colシフト出勤時間.ReadOnly = True
        Me.colシフト出勤時間.Width = 120
        '
        'colシフト退勤時間
        '
        Me.colシフト退勤時間.DataPropertyName = "シフト退勤時間"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.Format = "t"
        DataGridViewCellStyle31.NullValue = Nothing
        Me.colシフト退勤時間.DefaultCellStyle = DataGridViewCellStyle31
        Me.colシフト退勤時間.HeaderText = "シフト退勤"
        Me.colシフト退勤時間.Name = "colシフト退勤時間"
        Me.colシフト退勤時間.ReadOnly = True
        Me.colシフト退勤時間.Width = 120
        '
        'col第1延長
        '
        Me.col第1延長.DataPropertyName = "第1延長"
        Me.col第1延長.HeaderText = "早朝延長"
        Me.col第1延長.Name = "col第1延長"
        Me.col第1延長.ReadOnly = True
        '
        'col第2延長
        '
        Me.col第2延長.DataPropertyName = "第2延長"
        Me.col第2延長.HeaderText = "通常延長"
        Me.col第2延長.Name = "col第2延長"
        Me.col第2延長.ReadOnly = True
        '
        'col第3延長
        '
        Me.col第3延長.DataPropertyName = "第3延長"
        Me.col第3延長.HeaderText = "夕方延長"
        Me.col第3延長.Name = "col第3延長"
        Me.col第3延長.ReadOnly = True
        '
        'col出勤時間
        '
        Me.col出勤時間.DataPropertyName = "出勤時間"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col出勤時間.DefaultCellStyle = DataGridViewCellStyle32
        Me.col出勤時間.HeaderText = "出勤時間"
        Me.col出勤時間.Name = "col出勤時間"
        Me.col出勤時間.ReadOnly = True
        Me.col出勤時間.Width = 120
        '
        'col退勤時間
        '
        Me.col退勤時間.DataPropertyName = "退勤時間"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col退勤時間.DefaultCellStyle = DataGridViewCellStyle33
        Me.col退勤時間.HeaderText = "退勤時間"
        Me.col退勤時間.Name = "col退勤時間"
        Me.col退勤時間.ReadOnly = True
        Me.col退勤時間.Width = 120
        '
        'col職員ID
        '
        Me.col職員ID.DataPropertyName = "職員ID"
        Me.col職員ID.HeaderText = "職員ID"
        Me.col職員ID.Name = "col職員ID"
        Me.col職員ID.ReadOnly = True
        Me.col職員ID.Visible = False
        '
        'col検温
        '
        Me.col検温.DataPropertyName = "検温"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col検温.DefaultCellStyle = DataGridViewCellStyle34
        Me.col検温.HeaderText = "検温"
        Me.col検温.Name = "col検温"
        Me.col検温.ReadOnly = True
        Me.col検温.Width = 75
        '
        'col休憩時間
        '
        Me.col休憩時間.DataPropertyName = "休憩時間"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col休憩時間.DefaultCellStyle = DataGridViewCellStyle35
        Me.col休憩時間.HeaderText = "休憩時間"
        Me.col休憩時間.Name = "col休憩時間"
        Me.col休憩時間.ReadOnly = True
        Me.col休憩時間.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "シフト"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn一括出退処理)
        Me.GroupBox1.Controls.Add(Me.cmb休憩時間)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl日付)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chk第3延長)
        Me.GroupBox1.Controls.Add(Me.chk第2延長)
        Me.GroupBox1.Controls.Add(Me.chk第1延長)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb検温)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp退勤)
        Me.GroupBox1.Controls.Add(Me.dtp出勤)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn登録)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpシフト退勤)
        Me.GroupBox1.Controls.Add(Me.dtpシフト出勤)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgv一覧)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 657)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "休憩時間"
        '
        'cmb休憩時間
        '
        Me.cmb休憩時間.FormattingEnabled = True
        Me.cmb休憩時間.Location = New System.Drawing.Point(572, 77)
        Me.cmb休憩時間.Name = "cmb休憩時間"
        Me.cmb休憩時間.Size = New System.Drawing.Size(139, 27)
        Me.cmb休憩時間.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(485, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "休憩時間"
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(71, 15)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(158, 27)
        Me.lbl日付.TabIndex = 1
        Me.lbl日付.Text = "yyyy/MM/dd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "日付"
        '
        'chk第3延長
        '
        Me.chk第3延長.AutoSize = True
        Me.chk第3延長.Location = New System.Drawing.Point(770, 48)
        Me.chk第3延長.Name = "chk第3延長"
        Me.chk第3延長.Size = New System.Drawing.Size(104, 23)
        Me.chk第3延長.TabIndex = 8
        Me.chk第3延長.Text = "夕方延長"
        Me.chk第3延長.UseVisualStyleBackColor = True
        '
        'chk第2延長
        '
        Me.chk第2延長.AutoSize = True
        Me.chk第2延長.Location = New System.Drawing.Point(535, 48)
        Me.chk第2延長.Name = "chk第2延長"
        Me.chk第2延長.Size = New System.Drawing.Size(104, 23)
        Me.chk第2延長.TabIndex = 7
        Me.chk第2延長.Text = "通常延長"
        Me.chk第2延長.UseVisualStyleBackColor = True
        '
        'chk第1延長
        '
        Me.chk第1延長.AutoSize = True
        Me.chk第1延長.Location = New System.Drawing.Point(300, 48)
        Me.chk第1延長.Name = "chk第1延長"
        Me.chk第1延長.Size = New System.Drawing.Size(104, 23)
        Me.chk第1延長.TabIndex = 6
        Me.chk第1延長.Text = "早朝延長"
        Me.chk第1延長.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(432, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "℃"
        '
        'cmb検温
        '
        Me.cmb検温.FormattingEnabled = True
        Me.cmb検温.Location = New System.Drawing.Point(345, 77)
        Me.cmb検温.Name = "cmb検温"
        Me.cmb検温.Size = New System.Drawing.Size(85, 27)
        Me.cmb検温.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "～"
        '
        'dtp退勤
        '
        Me.dtp退勤.CustomFormat = "HH:mm"
        Me.dtp退勤.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp退勤.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp退勤.Location = New System.Drawing.Point(187, 77)
        Me.dtp退勤.Name = "dtp退勤"
        Me.dtp退勤.ShowUpDown = True
        Me.dtp退勤.Size = New System.Drawing.Size(85, 26)
        Me.dtp退勤.TabIndex = 12
        '
        'dtp出勤
        '
        Me.dtp出勤.CustomFormat = "HH:mm"
        Me.dtp出勤.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp出勤.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp出勤.Location = New System.Drawing.Point(70, 77)
        Me.dtp出勤.Name = "dtp出勤"
        Me.dtp出勤.ShowUpDown = True
        Me.dtp出勤.Size = New System.Drawing.Size(85, 26)
        Me.dtp出勤.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "勤怠"
        '
        'btn登録
        '
        Me.btn登録.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn登録.Location = New System.Drawing.Point(1026, 67)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(128, 40)
        Me.btn登録.TabIndex = 18
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "検温"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "～"
        '
        'dtpシフト退勤
        '
        Me.dtpシフト退勤.CustomFormat = "HH:mm"
        Me.dtpシフト退勤.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpシフト退勤.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtpシフト退勤.Location = New System.Drawing.Point(186, 48)
        Me.dtpシフト退勤.Name = "dtpシフト退勤"
        Me.dtpシフト退勤.ShowUpDown = True
        Me.dtpシフト退勤.Size = New System.Drawing.Size(85, 26)
        Me.dtpシフト退勤.TabIndex = 5
        '
        'dtpシフト出勤
        '
        Me.dtpシフト出勤.CustomFormat = "HH:mm"
        Me.dtpシフト出勤.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpシフト出勤.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtpシフト出勤.Location = New System.Drawing.Point(70, 48)
        Me.dtpシフト出勤.Name = "dtpシフト出勤"
        Me.dtpシフト出勤.ShowUpDown = True
        Me.dtpシフト出勤.Size = New System.Drawing.Size(85, 26)
        Me.dtpシフト出勤.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(907, 707)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(124, 40)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btn次
        '
        Me.btn次.Location = New System.Drawing.Point(210, 11)
        Me.btn次.Name = "btn次"
        Me.btn次.Size = New System.Drawing.Size(26, 27)
        Me.btn次.TabIndex = 2
        Me.btn次.TabStop = False
        Me.btn次.Text = ">"
        Me.btn次.UseVisualStyleBackColor = True
        '
        'btn前
        '
        Me.btn前.Location = New System.Drawing.Point(14, 11)
        Me.btn前.Name = "btn前"
        Me.btn前.Size = New System.Drawing.Size(26, 27)
        Me.btn前.TabIndex = 0
        Me.btn前.TabStop = False
        Me.btn前.Text = "<"
        Me.btn前.UseVisualStyleBackColor = True
        '
        'lbl年月
        '
        Me.lbl年月.AutoSize = True
        Me.lbl年月.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl年月.Location = New System.Drawing.Point(46, 11)
        Me.lbl年月.Name = "lbl年月"
        Me.lbl年月.Size = New System.Drawing.Size(158, 27)
        Me.lbl年月.TabIndex = 1
        Me.lbl年月.Text = "yyyy年mm月"
        '
        'cmb職員
        '
        Me.cmb職員.FormattingEnabled = True
        Me.cmb職員.Location = New System.Drawing.Point(302, 11)
        Me.cmb職員.Name = "cmb職員"
        Me.cmb職員.Size = New System.Drawing.Size(201, 27)
        Me.cmb職員.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "職員"
        '
        'btn職員名簿
        '
        Me.btn職員名簿.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn職員名簿.ForeColor = System.Drawing.Color.Green
        Me.btn職員名簿.Location = New System.Drawing.Point(773, 707)
        Me.btn職員名簿.Margin = New System.Windows.Forms.Padding(5)
        Me.btn職員名簿.Name = "btn職員名簿"
        Me.btn職員名簿.Size = New System.Drawing.Size(125, 40)
        Me.btn職員名簿.TabIndex = 8
        Me.btn職員名簿.Text = "勤務管理簿"
        Me.btn職員名簿.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnエクスポート.ForeColor = System.Drawing.Color.Green
        Me.btnエクスポート.Location = New System.Drawing.Point(18, 707)
        Me.btnエクスポート.Margin = New System.Windows.Forms.Padding(5)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(125, 40)
        Me.btnエクスポート.TabIndex = 6
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btnインポート
        '
        Me.btnインポート.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnインポート.ForeColor = System.Drawing.Color.Green
        Me.btnインポート.Location = New System.Drawing.Point(153, 707)
        Me.btnインポート.Margin = New System.Windows.Forms.Padding(5)
        Me.btnインポート.Name = "btnインポート"
        Me.btnインポート.Size = New System.Drawing.Size(125, 40)
        Me.btnインポート.TabIndex = 7
        Me.btnインポート.Text = "インポート"
        Me.btnインポート.UseVisualStyleBackColor = True
        '
        'btn一括出退処理
        '
        Me.btn一括出退処理.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn一括出退処理.Location = New System.Drawing.Point(1030, 611)
        Me.btn一括出退処理.Name = "btn一括出退処理"
        Me.btn一括出退処理.Size = New System.Drawing.Size(124, 40)
        Me.btn一括出退処理.TabIndex = 20
        Me.btn一括出退処理.Text = "一括出退"
        Me.btn一括出退処理.UseVisualStyleBackColor = True
        '
        'sfrm勤務状況
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btnインポート)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btn職員名簿)
        Me.Controls.Add(Me.cmb職員)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn次)
        Me.Controls.Add(Me.btn前)
        Me.Controls.Add(Me.lbl年月)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "sfrm勤務状況"
        Me.ShowInTaskbar = False
        Me.Text = "勤務状況"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpシフト退勤 As DateTimePicker
    Friend WithEvents dtpシフト出勤 As DateTimePicker
    Friend WithEvents btnOK As Button
    Friend WithEvents btn登録 As Button
    Friend WithEvents btn次 As Button
    Friend WithEvents btn前 As Button
    Friend WithEvents lbl年月 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp退勤 As DateTimePicker
    Friend WithEvents dtp出勤 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb検温 As ComboBox
    Friend WithEvents chk第3延長 As CheckBox
    Friend WithEvents chk第2延長 As CheckBox
    Friend WithEvents chk第1延長 As CheckBox
    Friend WithEvents cmb職員 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl日付 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col削除 As DataGridViewButtonColumn
    Friend WithEvents col日付 As DataGridViewTextBoxColumn
    Friend WithEvents col職員名 As DataGridViewTextBoxColumn
    Friend WithEvents colシフト出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents colシフト退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col第1延長 As DataGridViewCheckBoxColumn
    Friend WithEvents col第2延長 As DataGridViewCheckBoxColumn
    Friend WithEvents col第3延長 As DataGridViewCheckBoxColumn
    Friend WithEvents col出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col職員ID As DataGridViewTextBoxColumn
    Friend WithEvents col検温 As DataGridViewTextBoxColumn
    Friend WithEvents col休憩時間 As DataGridViewTextBoxColumn
    Friend WithEvents btn職員名簿 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb休憩時間 As ComboBox
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btnインポート As Button
    Friend WithEvents btn一括出退処理 As Button
End Class
