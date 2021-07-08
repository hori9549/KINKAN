<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM職員マスタ
    ''Inherits System.Windows.Forms.Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt職員ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtパスワード = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt職員氏名 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt生年月日 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt入職日 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt入職時経歴年 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt年齢 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt経歴年 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.btn生年月日 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt入職時経歴月 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt経歴月 = New System.Windows.Forms.TextBox()
        Me.btn退職日 = New System.Windows.Forms.Button()
        Me.txt退職日 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn職員名簿 = New System.Windows.Forms.Button()
        Me.txtフリガナ = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtp月曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp月曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtp火曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp火曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtp水曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp水曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtp日曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp日曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtp木曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp木曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dtp金曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp金曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtp土曜退勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp土曜出勤時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.grb勤怠時間 = New System.Windows.Forms.GroupBox()
        Me.chk日 = New System.Windows.Forms.CheckBox()
        Me.chk土 = New System.Windows.Forms.CheckBox()
        Me.chk金 = New System.Windows.Forms.CheckBox()
        Me.chk木 = New System.Windows.Forms.CheckBox()
        Me.chk水 = New System.Windows.Forms.CheckBox()
        Me.chk火 = New System.Windows.Forms.CheckBox()
        Me.chk月 = New System.Windows.Forms.CheckBox()
        Me.cmb職名 = New System.Windows.Forms.ComboBox()
        Me.cmb資格 = New System.Windows.Forms.ComboBox()
        Me.cmb担当 = New System.Windows.Forms.ComboBox()
        Me.cmb勤務区分 = New System.Windows.Forms.ComboBox()
        Me.btn入職日 = New System.Windows.Forms.Button()
        Me.txt月給 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmb部署1 = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cmb部署2 = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmb部署3 = New System.Windows.Forms.ComboBox()
        Me.txt部署1カウント = New System.Windows.Forms.TextBox()
        Me.txt部署2カウント = New System.Windows.Forms.TextBox()
        Me.txt部署3カウント = New System.Windows.Forms.TextBox()
        Me.btn勤務管理簿 = New System.Windows.Forms.Button()
        Me.txt時給単価 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt超勤単価 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt交通費 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職員ID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col職員氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colフリガナ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colパスワード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col生年月日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入職日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入職時経歴年 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入職時経歴月 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col職名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col資格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col勤務区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col月給 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col時給単価 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col超勤単価 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col交通費 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col部署1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col部署1カウント = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col部署2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col部署2カウント = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col部署3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col部署3カウント = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col月曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col月曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col火曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col火曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col水曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col水曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col木曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col木曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col金曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col金曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col土曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col土曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col日曜出勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col日曜退勤時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col退職日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb勤怠時間.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt職員ID
        '
        Me.txt職員ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt職員ID.Location = New System.Drawing.Point(103, 14)
        Me.txt職員ID.Margin = New System.Windows.Forms.Padding(5)
        Me.txt職員ID.Name = "txt職員ID"
        Me.txt職員ID.ReadOnly = True
        Me.txt職員ID.Size = New System.Drawing.Size(79, 26)
        Me.txt職員ID.TabIndex = 1
        Me.txt職員ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "職員ID"
        '
        'txtパスワード
        '
        Me.txtパスワード.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtパスワード.Location = New System.Drawing.Point(394, 14)
        Me.txtパスワード.Margin = New System.Windows.Forms.Padding(5)
        Me.txtパスワード.Name = "txtパスワード"
        Me.txtパスワード.Size = New System.Drawing.Size(164, 26)
        Me.txtパスワード.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "パスワード"
        '
        'txt職員氏名
        '
        Me.txt職員氏名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt職員氏名.Location = New System.Drawing.Point(103, 70)
        Me.txt職員氏名.Margin = New System.Windows.Forms.Padding(5)
        Me.txt職員氏名.Name = "txt職員氏名"
        Me.txt職員氏名.Size = New System.Drawing.Size(164, 26)
        Me.txt職員氏名.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "職員氏名"
        '
        'txt生年月日
        '
        Me.txt生年月日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt生年月日.Location = New System.Drawing.Point(394, 70)
        Me.txt生年月日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt生年月日.Name = "txt生年月日"
        Me.txt生年月日.Size = New System.Drawing.Size(138, 26)
        Me.txt生年月日.TabIndex = 9
        Me.txt生年月日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "生年月日"
        '
        'txt入職日
        '
        Me.txt入職日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt入職日.Location = New System.Drawing.Point(103, 98)
        Me.txt入職日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt入職日.Name = "txt入職日"
        Me.txt入職日.Size = New System.Drawing.Size(138, 26)
        Me.txt入職日.TabIndex = 15
        Me.txt入職日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "入職日"
        '
        'txt入職時経歴年
        '
        Me.txt入職時経歴年.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt入職時経歴年.Location = New System.Drawing.Point(394, 98)
        Me.txt入職時経歴年.Margin = New System.Windows.Forms.Padding(5)
        Me.txt入職時経歴年.Name = "txt入職時経歴年"
        Me.txt入職時経歴年.Size = New System.Drawing.Size(52, 26)
        Me.txt入職時経歴年.TabIndex = 18
        Me.txt入職時経歴年.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "就職時経歴"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "職名"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "資格"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(888, 130)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "勤務区分"
        '
        'txt備考
        '
        Me.txt備考.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt備考.Location = New System.Drawing.Point(103, 332)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(5)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(765, 54)
        Me.txt備考.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 332)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 19)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "備考"
        '
        'btn登録
        '
        Me.btn登録.ForeColor = System.Drawing.Color.Blue
        Me.btn登録.Location = New System.Drawing.Point(1045, 346)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 40)
        Me.btn登録.TabIndex = 59
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(635, 130)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "担当"
        '
        'txt年齢
        '
        Me.txt年齢.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt年齢.Location = New System.Drawing.Point(685, 70)
        Me.txt年齢.Margin = New System.Windows.Forms.Padding(5)
        Me.txt年齢.Name = "txt年齢"
        Me.txt年齢.ReadOnly = True
        Me.txt年齢.Size = New System.Drawing.Size(79, 26)
        Me.txt年齢.TabIndex = 12
        Me.txt年齢.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(635, 74)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "年齢"
        '
        'txt経歴年
        '
        Me.txt経歴年.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt経歴年.Location = New System.Drawing.Point(685, 98)
        Me.txt経歴年.Margin = New System.Windows.Forms.Padding(5)
        Me.txt経歴年.Name = "txt経歴年"
        Me.txt経歴年.ReadOnly = True
        Me.txt経歴年.Size = New System.Drawing.Size(52, 26)
        Me.txt経歴年.TabIndex = 23
        Me.txt経歴年.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(635, 102)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "経歴"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(767, 74)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 19)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "歳"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(739, 102)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 19)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "年"
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(182, 14)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(27, 27)
        Me.btn新規.TabIndex = 2
        Me.btn新規.TabStop = False
        Me.btn新規.Text = "+"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'btn生年月日
        '
        Me.btn生年月日.Image = Global.KINKAN.My.Resources.Resources.カレンダー
        Me.btn生年月日.Location = New System.Drawing.Point(532, 70)
        Me.btn生年月日.Name = "btn生年月日"
        Me.btn生年月日.Size = New System.Drawing.Size(27, 27)
        Me.btn生年月日.TabIndex = 10
        Me.btn生年月日.TabStop = False
        Me.btn生年月日.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(448, 102)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 19)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "年"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col職員ID, Me.col職員氏名, Me.colフリガナ, Me.colパスワード, Me.col生年月日, Me.col入職日, Me.col入職時経歴年, Me.col入職時経歴月, Me.col職名, Me.col資格, Me.col担当, Me.col勤務区分, Me.col備考, Me.col月給, Me.col時給単価, Me.col超勤単価, Me.col交通費, Me.col部署1, Me.col部署1カウント, Me.col部署2, Me.col部署2カウント, Me.col部署3, Me.col部署3カウント, Me.col月曜出勤時間, Me.col月曜退勤時間, Me.col火曜出勤時間, Me.col火曜退勤時間, Me.col水曜出勤時間, Me.col水曜退勤時間, Me.col木曜出勤時間, Me.col木曜退勤時間, Me.col金曜出勤時間, Me.col金曜退勤時間, Me.col土曜出勤時間, Me.col土曜退勤時間, Me.col日曜出勤時間, Me.col日曜退勤時間, Me.col退職日})
        Me.dgv一覧.Location = New System.Drawing.Point(12, 408)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1158, 258)
        Me.dgv一覧.TabIndex = 60
        Me.dgv一覧.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(534, 102)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 19)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "月"
        '
        'txt入職時経歴月
        '
        Me.txt入職時経歴月.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt入職時経歴月.Location = New System.Drawing.Point(480, 98)
        Me.txt入職時経歴月.Margin = New System.Windows.Forms.Padding(5)
        Me.txt入職時経歴月.Name = "txt入職時経歴月"
        Me.txt入職時経歴月.Size = New System.Drawing.Size(52, 26)
        Me.txt入職時経歴月.TabIndex = 20
        Me.txt入職時経歴月.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(825, 102)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 19)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "月"
        '
        'txt経歴月
        '
        Me.txt経歴月.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt経歴月.Location = New System.Drawing.Point(771, 98)
        Me.txt経歴月.Margin = New System.Windows.Forms.Padding(5)
        Me.txt経歴月.Name = "txt経歴月"
        Me.txt経歴月.ReadOnly = True
        Me.txt経歴月.Size = New System.Drawing.Size(52, 26)
        Me.txt経歴月.TabIndex = 25
        Me.txt経歴月.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn退職日
        '
        Me.btn退職日.Image = Global.KINKAN.My.Resources.Resources.カレンダー
        Me.btn退職日.Location = New System.Drawing.Point(1114, 98)
        Me.btn退職日.Name = "btn退職日"
        Me.btn退職日.Size = New System.Drawing.Size(27, 27)
        Me.btn退職日.TabIndex = 30
        Me.btn退職日.TabStop = False
        Me.btn退職日.UseVisualStyleBackColor = True
        '
        'txt退職日
        '
        Me.txt退職日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt退職日.Location = New System.Drawing.Point(976, 98)
        Me.txt退職日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt退職日.Name = "txt退職日"
        Me.txt退職日.Size = New System.Drawing.Size(138, 26)
        Me.txt退職日.TabIndex = 29
        Me.txt退職日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(907, 102)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 19)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "退職日"
        '
        'btn職員名簿
        '
        Me.btn職員名簿.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn職員名簿.ForeColor = System.Drawing.Color.Green
        Me.btn職員名簿.Location = New System.Drawing.Point(885, 674)
        Me.btn職員名簿.Margin = New System.Windows.Forms.Padding(5)
        Me.btn職員名簿.Name = "btn職員名簿"
        Me.btn職員名簿.Size = New System.Drawing.Size(125, 40)
        Me.btn職員名簿.TabIndex = 62
        Me.btn職員名簿.Text = "職員名簿"
        Me.btn職員名簿.UseVisualStyleBackColor = True
        '
        'txtフリガナ
        '
        Me.txtフリガナ.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtフリガナ.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtフリガナ.Location = New System.Drawing.Point(103, 49)
        Me.txtフリガナ.Margin = New System.Windows.Forms.Padding(5)
        Me.txtフリガナ.Name = "txtフリガナ"
        Me.txtフリガナ.Size = New System.Drawing.Size(164, 20)
        Me.txtフリガナ.TabIndex = 5
        Me.txtフリガナ.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(161, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 19)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "～"
        '
        'dtp月曜退勤時間
        '
        Me.dtp月曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp月曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp月曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp月曜退勤時間.Location = New System.Drawing.Point(190, 25)
        Me.dtp月曜退勤時間.Name = "dtp月曜退勤時間"
        Me.dtp月曜退勤時間.ShowUpDown = True
        Me.dtp月曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp月曜退勤時間.TabIndex = 4
        Me.dtp月曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp月曜出勤時間
        '
        Me.dtp月曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp月曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp月曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp月曜出勤時間.Location = New System.Drawing.Point(84, 25)
        Me.dtp月曜出勤時間.Name = "dtp月曜出勤時間"
        Me.dtp月曜出勤時間.ShowUpDown = True
        Me.dtp月曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp月曜出勤時間.TabIndex = 2
        Me.dtp月曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 19)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "月曜"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(452, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 19)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "～"
        '
        'dtp火曜退勤時間
        '
        Me.dtp火曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp火曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp火曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp火曜退勤時間.Location = New System.Drawing.Point(481, 25)
        Me.dtp火曜退勤時間.Name = "dtp火曜退勤時間"
        Me.dtp火曜退勤時間.ShowUpDown = True
        Me.dtp火曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp火曜退勤時間.TabIndex = 9
        Me.dtp火曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp火曜出勤時間
        '
        Me.dtp火曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp火曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp火曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp火曜出勤時間.Location = New System.Drawing.Point(375, 25)
        Me.dtp火曜出勤時間.Name = "dtp火曜出勤時間"
        Me.dtp火曜出勤時間.ShowUpDown = True
        Me.dtp火曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp火曜出勤時間.TabIndex = 7
        Me.dtp火曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(325, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 19)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "火曜"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(743, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(28, 19)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "～"
        '
        'dtp水曜退勤時間
        '
        Me.dtp水曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp水曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp水曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp水曜退勤時間.Location = New System.Drawing.Point(774, 25)
        Me.dtp水曜退勤時間.Name = "dtp水曜退勤時間"
        Me.dtp水曜退勤時間.ShowUpDown = True
        Me.dtp水曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp水曜退勤時間.TabIndex = 14
        Me.dtp水曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp水曜出勤時間
        '
        Me.dtp水曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp水曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp水曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp水曜出勤時間.Location = New System.Drawing.Point(666, 25)
        Me.dtp水曜出勤時間.Name = "dtp水曜出勤時間"
        Me.dtp水曜出勤時間.ShowUpDown = True
        Me.dtp水曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp水曜出勤時間.TabIndex = 12
        Me.dtp水曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(616, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 19)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "水曜"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1034, 61)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 19)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "～"
        '
        'dtp日曜退勤時間
        '
        Me.dtp日曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp日曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp日曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp日曜退勤時間.Location = New System.Drawing.Point(1063, 57)
        Me.dtp日曜退勤時間.Name = "dtp日曜退勤時間"
        Me.dtp日曜退勤時間.ShowUpDown = True
        Me.dtp日曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp日曜退勤時間.TabIndex = 34
        Me.dtp日曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp日曜出勤時間
        '
        Me.dtp日曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp日曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp日曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp日曜出勤時間.Location = New System.Drawing.Point(957, 57)
        Me.dtp日曜出勤時間.Name = "dtp日曜出勤時間"
        Me.dtp日曜出勤時間.ShowUpDown = True
        Me.dtp日曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp日曜出勤時間.TabIndex = 32
        Me.dtp日曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(907, 61)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 19)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "日曜"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(161, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 19)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "～"
        '
        'dtp木曜退勤時間
        '
        Me.dtp木曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp木曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp木曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp木曜退勤時間.Location = New System.Drawing.Point(190, 57)
        Me.dtp木曜退勤時間.Name = "dtp木曜退勤時間"
        Me.dtp木曜退勤時間.ShowUpDown = True
        Me.dtp木曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp木曜退勤時間.TabIndex = 19
        Me.dtp木曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp木曜出勤時間
        '
        Me.dtp木曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp木曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp木曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp木曜出勤時間.Location = New System.Drawing.Point(84, 57)
        Me.dtp木曜出勤時間.Name = "dtp木曜出勤時間"
        Me.dtp木曜出勤時間.ShowUpDown = True
        Me.dtp木曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp木曜出勤時間.TabIndex = 17
        Me.dtp木曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(34, 61)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 19)
        Me.Label29.TabIndex = 16
        Me.Label29.Text = "木曜"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(452, 61)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 19)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "～"
        '
        'dtp金曜退勤時間
        '
        Me.dtp金曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp金曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp金曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp金曜退勤時間.Location = New System.Drawing.Point(481, 57)
        Me.dtp金曜退勤時間.Name = "dtp金曜退勤時間"
        Me.dtp金曜退勤時間.ShowUpDown = True
        Me.dtp金曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp金曜退勤時間.TabIndex = 24
        Me.dtp金曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp金曜出勤時間
        '
        Me.dtp金曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp金曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp金曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp金曜出勤時間.Location = New System.Drawing.Point(375, 57)
        Me.dtp金曜出勤時間.Name = "dtp金曜出勤時間"
        Me.dtp金曜出勤時間.ShowUpDown = True
        Me.dtp金曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp金曜出勤時間.TabIndex = 22
        Me.dtp金曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(325, 61)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(47, 19)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "金曜"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(743, 61)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(28, 19)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "～"
        '
        'dtp土曜退勤時間
        '
        Me.dtp土曜退勤時間.CustomFormat = "HH:mm"
        Me.dtp土曜退勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp土曜退勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp土曜退勤時間.Location = New System.Drawing.Point(774, 57)
        Me.dtp土曜退勤時間.Name = "dtp土曜退勤時間"
        Me.dtp土曜退勤時間.ShowUpDown = True
        Me.dtp土曜退勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp土曜退勤時間.TabIndex = 29
        Me.dtp土曜退勤時間.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'dtp土曜出勤時間
        '
        Me.dtp土曜出勤時間.CustomFormat = "HH:mm"
        Me.dtp土曜出勤時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp土曜出勤時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp土曜出勤時間.Location = New System.Drawing.Point(666, 57)
        Me.dtp土曜出勤時間.Name = "dtp土曜出勤時間"
        Me.dtp土曜出勤時間.ShowUpDown = True
        Me.dtp土曜出勤時間.Size = New System.Drawing.Size(75, 26)
        Me.dtp土曜出勤時間.TabIndex = 27
        Me.dtp土曜出勤時間.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(616, 61)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 19)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "土曜"
        '
        'grb勤怠時間
        '
        Me.grb勤怠時間.Controls.Add(Me.chk日)
        Me.grb勤怠時間.Controls.Add(Me.chk土)
        Me.grb勤怠時間.Controls.Add(Me.chk金)
        Me.grb勤怠時間.Controls.Add(Me.chk木)
        Me.grb勤怠時間.Controls.Add(Me.chk水)
        Me.grb勤怠時間.Controls.Add(Me.chk火)
        Me.grb勤怠時間.Controls.Add(Me.chk月)
        Me.grb勤怠時間.Controls.Add(Me.dtp月曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label21)
        Me.grb勤怠時間.Controls.Add(Me.Label32)
        Me.grb勤怠時間.Controls.Add(Me.dtp月曜退勤時間)
        Me.grb勤怠時間.Controls.Add(Me.dtp土曜退勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label20)
        Me.grb勤怠時間.Controls.Add(Me.dtp土曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label23)
        Me.grb勤怠時間.Controls.Add(Me.Label33)
        Me.grb勤怠時間.Controls.Add(Me.dtp火曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label30)
        Me.grb勤怠時間.Controls.Add(Me.dtp火曜退勤時間)
        Me.grb勤怠時間.Controls.Add(Me.dtp金曜退勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label22)
        Me.grb勤怠時間.Controls.Add(Me.dtp金曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label25)
        Me.grb勤怠時間.Controls.Add(Me.Label31)
        Me.grb勤怠時間.Controls.Add(Me.dtp水曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label28)
        Me.grb勤怠時間.Controls.Add(Me.dtp水曜退勤時間)
        Me.grb勤怠時間.Controls.Add(Me.dtp木曜退勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label24)
        Me.grb勤怠時間.Controls.Add(Me.dtp木曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label27)
        Me.grb勤怠時間.Controls.Add(Me.Label29)
        Me.grb勤怠時間.Controls.Add(Me.dtp日曜出勤時間)
        Me.grb勤怠時間.Controls.Add(Me.Label26)
        Me.grb勤怠時間.Controls.Add(Me.dtp日曜退勤時間)
        Me.grb勤怠時間.Location = New System.Drawing.Point(19, 222)
        Me.grb勤怠時間.Name = "grb勤怠時間"
        Me.grb勤怠時間.Size = New System.Drawing.Size(1151, 92)
        Me.grb勤怠時間.TabIndex = 56
        Me.grb勤怠時間.TabStop = False
        Me.grb勤怠時間.Text = "勤務時間"
        '
        'chk日
        '
        Me.chk日.AutoSize = True
        Me.chk日.Location = New System.Drawing.Point(892, 63)
        Me.chk日.Name = "chk日"
        Me.chk日.Size = New System.Drawing.Size(15, 14)
        Me.chk日.TabIndex = 30
        Me.chk日.TabStop = False
        Me.chk日.UseVisualStyleBackColor = True
        '
        'chk土
        '
        Me.chk土.AutoSize = True
        Me.chk土.Location = New System.Drawing.Point(602, 63)
        Me.chk土.Name = "chk土"
        Me.chk土.Size = New System.Drawing.Size(15, 14)
        Me.chk土.TabIndex = 25
        Me.chk土.TabStop = False
        Me.chk土.UseVisualStyleBackColor = True
        '
        'chk金
        '
        Me.chk金.AutoSize = True
        Me.chk金.Location = New System.Drawing.Point(312, 63)
        Me.chk金.Name = "chk金"
        Me.chk金.Size = New System.Drawing.Size(15, 14)
        Me.chk金.TabIndex = 20
        Me.chk金.TabStop = False
        Me.chk金.UseVisualStyleBackColor = True
        '
        'chk木
        '
        Me.chk木.AutoSize = True
        Me.chk木.Location = New System.Drawing.Point(21, 63)
        Me.chk木.Name = "chk木"
        Me.chk木.Size = New System.Drawing.Size(15, 14)
        Me.chk木.TabIndex = 15
        Me.chk木.TabStop = False
        Me.chk木.UseVisualStyleBackColor = True
        '
        'chk水
        '
        Me.chk水.AutoSize = True
        Me.chk水.Location = New System.Drawing.Point(602, 31)
        Me.chk水.Name = "chk水"
        Me.chk水.Size = New System.Drawing.Size(15, 14)
        Me.chk水.TabIndex = 10
        Me.chk水.TabStop = False
        Me.chk水.UseVisualStyleBackColor = True
        '
        'chk火
        '
        Me.chk火.AutoSize = True
        Me.chk火.Location = New System.Drawing.Point(311, 31)
        Me.chk火.Name = "chk火"
        Me.chk火.Size = New System.Drawing.Size(15, 14)
        Me.chk火.TabIndex = 5
        Me.chk火.TabStop = False
        Me.chk火.UseVisualStyleBackColor = True
        '
        'chk月
        '
        Me.chk月.AutoSize = True
        Me.chk月.Location = New System.Drawing.Point(22, 31)
        Me.chk月.Name = "chk月"
        Me.chk月.Size = New System.Drawing.Size(15, 14)
        Me.chk月.TabIndex = 0
        Me.chk月.TabStop = False
        Me.chk月.UseVisualStyleBackColor = True
        '
        'cmb職名
        '
        Me.cmb職名.FormattingEnabled = True
        Me.cmb職名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb職名.Location = New System.Drawing.Point(103, 126)
        Me.cmb職名.Name = "cmb職名"
        Me.cmb職名.Size = New System.Drawing.Size(181, 27)
        Me.cmb職名.TabIndex = 32
        '
        'cmb資格
        '
        Me.cmb資格.FormattingEnabled = True
        Me.cmb資格.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb資格.Location = New System.Drawing.Point(394, 126)
        Me.cmb資格.Name = "cmb資格"
        Me.cmb資格.Size = New System.Drawing.Size(181, 27)
        Me.cmb資格.TabIndex = 34
        '
        'cmb担当
        '
        Me.cmb担当.FormattingEnabled = True
        Me.cmb担当.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb担当.Location = New System.Drawing.Point(685, 126)
        Me.cmb担当.Name = "cmb担当"
        Me.cmb担当.Size = New System.Drawing.Size(181, 27)
        Me.cmb担当.TabIndex = 36
        '
        'cmb勤務区分
        '
        Me.cmb勤務区分.FormattingEnabled = True
        Me.cmb勤務区分.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb勤務区分.Location = New System.Drawing.Point(976, 126)
        Me.cmb勤務区分.Name = "cmb勤務区分"
        Me.cmb勤務区分.Size = New System.Drawing.Size(181, 27)
        Me.cmb勤務区分.TabIndex = 38
        '
        'btn入職日
        '
        Me.btn入職日.Image = Global.KINKAN.My.Resources.Resources.カレンダー
        Me.btn入職日.Location = New System.Drawing.Point(241, 98)
        Me.btn入職日.Name = "btn入職日"
        Me.btn入職日.Size = New System.Drawing.Size(27, 27)
        Me.btn入職日.TabIndex = 16
        Me.btn入職日.TabStop = False
        Me.btn入職日.UseVisualStyleBackColor = True
        '
        'txt月給
        '
        Me.txt月給.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt月給.Location = New System.Drawing.Point(103, 186)
        Me.txt月給.Margin = New System.Windows.Forms.Padding(5)
        Me.txt月給.Name = "txt月給"
        Me.txt月給.Size = New System.Drawing.Size(138, 26)
        Me.txt月給.TabIndex = 49
        Me.txt月給.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(54, 190)
        Me.Label34.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 19)
        Me.Label34.TabIndex = 48
        Me.Label34.Text = "月給"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(44, 160)
        Me.Label35.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 19)
        Me.Label35.TabIndex = 39
        Me.Label35.Text = "部署1"
        '
        'cmb部署1
        '
        Me.cmb部署1.FormattingEnabled = True
        Me.cmb部署1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb部署1.Location = New System.Drawing.Point(103, 156)
        Me.cmb部署1.Name = "cmb部署1"
        Me.cmb部署1.Size = New System.Drawing.Size(138, 27)
        Me.cmb部署1.TabIndex = 40
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(335, 160)
        Me.Label36.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(57, 19)
        Me.Label36.TabIndex = 42
        Me.Label36.Text = "部署2"
        '
        'cmb部署2
        '
        Me.cmb部署2.FormattingEnabled = True
        Me.cmb部署2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb部署2.Location = New System.Drawing.Point(394, 156)
        Me.cmb部署2.Name = "cmb部署2"
        Me.cmb部署2.Size = New System.Drawing.Size(138, 27)
        Me.cmb部署2.TabIndex = 43
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(626, 160)
        Me.Label37.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(57, 19)
        Me.Label37.TabIndex = 45
        Me.Label37.Text = "部署3"
        '
        'cmb部署3
        '
        Me.cmb部署3.FormattingEnabled = True
        Me.cmb部署3.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb部署3.Location = New System.Drawing.Point(685, 156)
        Me.cmb部署3.Name = "cmb部署3"
        Me.cmb部署3.Size = New System.Drawing.Size(138, 27)
        Me.cmb部署3.TabIndex = 46
        '
        'txt部署1カウント
        '
        Me.txt部署1カウント.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt部署1カウント.Location = New System.Drawing.Point(241, 156)
        Me.txt部署1カウント.Margin = New System.Windows.Forms.Padding(5)
        Me.txt部署1カウント.Name = "txt部署1カウント"
        Me.txt部署1カウント.Size = New System.Drawing.Size(43, 26)
        Me.txt部署1カウント.TabIndex = 41
        Me.txt部署1カウント.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt部署2カウント
        '
        Me.txt部署2カウント.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt部署2カウント.Location = New System.Drawing.Point(532, 156)
        Me.txt部署2カウント.Margin = New System.Windows.Forms.Padding(5)
        Me.txt部署2カウント.Name = "txt部署2カウント"
        Me.txt部署2カウント.Size = New System.Drawing.Size(43, 26)
        Me.txt部署2カウント.TabIndex = 44
        Me.txt部署2カウント.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt部署3カウント
        '
        Me.txt部署3カウント.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt部署3カウント.Location = New System.Drawing.Point(823, 156)
        Me.txt部署3カウント.Margin = New System.Windows.Forms.Padding(5)
        Me.txt部署3カウント.Name = "txt部署3カウント"
        Me.txt部署3カウント.Size = New System.Drawing.Size(43, 26)
        Me.txt部署3カウント.TabIndex = 47
        Me.txt部署3カウント.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn勤務管理簿
        '
        Me.btn勤務管理簿.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn勤務管理簿.ForeColor = System.Drawing.Color.Green
        Me.btn勤務管理簿.Location = New System.Drawing.Point(678, 674)
        Me.btn勤務管理簿.Margin = New System.Windows.Forms.Padding(5)
        Me.btn勤務管理簿.Name = "btn勤務管理簿"
        Me.btn勤務管理簿.Size = New System.Drawing.Size(190, 40)
        Me.btn勤務管理簿.TabIndex = 61
        Me.btn勤務管理簿.Text = "勤務管理簿(全員)"
        Me.btn勤務管理簿.UseVisualStyleBackColor = True
        '
        'txt時給単価
        '
        Me.txt時給単価.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt時給単価.Location = New System.Drawing.Point(394, 186)
        Me.txt時給単価.Margin = New System.Windows.Forms.Padding(5)
        Me.txt時給単価.Name = "txt時給単価"
        Me.txt時給単価.Size = New System.Drawing.Size(138, 26)
        Me.txt時給単価.TabIndex = 51
        Me.txt時給単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(307, 190)
        Me.Label38.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(85, 19)
        Me.Label38.TabIndex = 50
        Me.Label38.Text = "時給単価"
        '
        'txt超勤単価
        '
        Me.txt超勤単価.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt超勤単価.Location = New System.Drawing.Point(685, 186)
        Me.txt超勤単価.Margin = New System.Windows.Forms.Padding(5)
        Me.txt超勤単価.Name = "txt超勤単価"
        Me.txt超勤単価.Size = New System.Drawing.Size(138, 26)
        Me.txt超勤単価.TabIndex = 53
        Me.txt超勤単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(598, 190)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(85, 19)
        Me.Label39.TabIndex = 52
        Me.Label39.Text = "超勤単価"
        '
        'txt交通費
        '
        Me.txt交通費.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt交通費.Location = New System.Drawing.Point(976, 186)
        Me.txt交通費.Margin = New System.Windows.Forms.Padding(5)
        Me.txt交通費.Name = "txt交通費"
        Me.txt交通費.Size = New System.Drawing.Size(138, 26)
        Me.txt交通費.TabIndex = 55
        Me.txt交通費.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(908, 190)
        Me.Label40.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(66, 19)
        Me.Label40.TabIndex = 54
        Me.Label40.Text = "交通費"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col施設ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.col施設ID.Frozen = True
        Me.col施設ID.HeaderText = "施設ID"
        Me.col施設ID.Name = "col施設ID"
        Me.col施設ID.ReadOnly = True
        Me.col施設ID.Visible = False
        Me.col施設ID.Width = 120
        '
        'col職員ID
        '
        Me.col職員ID.DataPropertyName = "職員ID"
        Me.col職員ID.Frozen = True
        Me.col職員ID.HeaderText = "職員ID"
        Me.col職員ID.Name = "col職員ID"
        Me.col職員ID.ReadOnly = True
        Me.col職員ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col職員ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'col職員氏名
        '
        Me.col職員氏名.DataPropertyName = "職員氏名"
        Me.col職員氏名.Frozen = True
        Me.col職員氏名.HeaderText = "職員氏名"
        Me.col職員氏名.Name = "col職員氏名"
        Me.col職員氏名.ReadOnly = True
        Me.col職員氏名.Width = 200
        '
        'colフリガナ
        '
        Me.colフリガナ.DataPropertyName = "フリガナ"
        Me.colフリガナ.HeaderText = "フリガナ"
        Me.colフリガナ.Name = "colフリガナ"
        Me.colフリガナ.ReadOnly = True
        Me.colフリガナ.Visible = False
        '
        'colパスワード
        '
        Me.colパスワード.DataPropertyName = "パスワード"
        Me.colパスワード.HeaderText = "パスワード"
        Me.colパスワード.Name = "colパスワード"
        Me.colパスワード.ReadOnly = True
        Me.colパスワード.Width = 120
        '
        'col生年月日
        '
        Me.col生年月日.DataPropertyName = "生年月日"
        Me.col生年月日.HeaderText = "生年月日"
        Me.col生年月日.Name = "col生年月日"
        Me.col生年月日.ReadOnly = True
        Me.col生年月日.Width = 120
        '
        'col入職日
        '
        Me.col入職日.DataPropertyName = "入職日"
        Me.col入職日.HeaderText = "入職日"
        Me.col入職日.Name = "col入職日"
        Me.col入職日.ReadOnly = True
        Me.col入職日.Width = 120
        '
        'col入職時経歴年
        '
        Me.col入職時経歴年.DataPropertyName = "入職時経歴年"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col入職時経歴年.DefaultCellStyle = DataGridViewCellStyle2
        Me.col入職時経歴年.HeaderText = "入職時経歴年"
        Me.col入職時経歴年.Name = "col入職時経歴年"
        Me.col入職時経歴年.ReadOnly = True
        Me.col入職時経歴年.Visible = False
        Me.col入職時経歴年.Width = 150
        '
        'col入職時経歴月
        '
        Me.col入職時経歴月.DataPropertyName = "入職時経歴月"
        Me.col入職時経歴月.HeaderText = "入職時経歴月"
        Me.col入職時経歴月.Name = "col入職時経歴月"
        Me.col入職時経歴月.ReadOnly = True
        Me.col入職時経歴月.Visible = False
        Me.col入職時経歴月.Width = 150
        '
        'col職名
        '
        Me.col職名.DataPropertyName = "職名"
        Me.col職名.HeaderText = "職名"
        Me.col職名.Name = "col職名"
        Me.col職名.ReadOnly = True
        Me.col職名.Width = 200
        '
        'col資格
        '
        Me.col資格.DataPropertyName = "資格"
        Me.col資格.HeaderText = "資格"
        Me.col資格.Name = "col資格"
        Me.col資格.ReadOnly = True
        Me.col資格.Width = 200
        '
        'col担当
        '
        Me.col担当.DataPropertyName = "担当"
        Me.col担当.HeaderText = "担当"
        Me.col担当.Name = "col担当"
        Me.col担当.ReadOnly = True
        Me.col担当.Width = 200
        '
        'col勤務区分
        '
        Me.col勤務区分.DataPropertyName = "勤務区分"
        Me.col勤務区分.HeaderText = "勤務区分"
        Me.col勤務区分.Name = "col勤務区分"
        Me.col勤務区分.ReadOnly = True
        Me.col勤務区分.Width = 200
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.ReadOnly = True
        Me.col備考.Width = 300
        '
        'col月給
        '
        Me.col月給.DataPropertyName = "月給"
        Me.col月給.FillWeight = 120.0!
        Me.col月給.HeaderText = "月給"
        Me.col月給.Name = "col月給"
        Me.col月給.ReadOnly = True
        Me.col月給.Width = 120
        '
        'col時給単価
        '
        Me.col時給単価.DataPropertyName = "時給単価"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col時給単価.DefaultCellStyle = DataGridViewCellStyle3
        Me.col時給単価.FillWeight = 120.0!
        Me.col時給単価.HeaderText = "時間単価"
        Me.col時給単価.Name = "col時給単価"
        Me.col時給単価.ReadOnly = True
        Me.col時給単価.Width = 120
        '
        'col超勤単価
        '
        Me.col超勤単価.DataPropertyName = "超勤単価"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col超勤単価.DefaultCellStyle = DataGridViewCellStyle4
        Me.col超勤単価.FillWeight = 120.0!
        Me.col超勤単価.HeaderText = "超勤単価"
        Me.col超勤単価.Name = "col超勤単価"
        Me.col超勤単価.ReadOnly = True
        Me.col超勤単価.Width = 120
        '
        'col交通費
        '
        Me.col交通費.DataPropertyName = "交通費"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col交通費.DefaultCellStyle = DataGridViewCellStyle5
        Me.col交通費.FillWeight = 120.0!
        Me.col交通費.HeaderText = "交通費"
        Me.col交通費.Name = "col交通費"
        Me.col交通費.ReadOnly = True
        Me.col交通費.Width = 120
        '
        'col部署1
        '
        Me.col部署1.DataPropertyName = "部署1"
        Me.col部署1.HeaderText = "部署1"
        Me.col部署1.Name = "col部署1"
        Me.col部署1.ReadOnly = True
        '
        'col部署1カウント
        '
        Me.col部署1カウント.DataPropertyName = "部署1カウント"
        Me.col部署1カウント.HeaderText = "カウント"
        Me.col部署1カウント.Name = "col部署1カウント"
        Me.col部署1カウント.ReadOnly = True
        '
        'col部署2
        '
        Me.col部署2.DataPropertyName = "部署2"
        Me.col部署2.HeaderText = "部署2"
        Me.col部署2.Name = "col部署2"
        Me.col部署2.ReadOnly = True
        '
        'col部署2カウント
        '
        Me.col部署2カウント.DataPropertyName = "部署2カウント"
        Me.col部署2カウント.HeaderText = "カウント"
        Me.col部署2カウント.Name = "col部署2カウント"
        Me.col部署2カウント.ReadOnly = True
        '
        'col部署3
        '
        Me.col部署3.DataPropertyName = "部署3"
        Me.col部署3.HeaderText = "部署3"
        Me.col部署3.Name = "col部署3"
        Me.col部署3.ReadOnly = True
        '
        'col部署3カウント
        '
        Me.col部署3カウント.DataPropertyName = "部署3カウント"
        Me.col部署3カウント.HeaderText = "カウント"
        Me.col部署3カウント.Name = "col部署3カウント"
        Me.col部署3カウント.ReadOnly = True
        '
        'col月曜出勤時間
        '
        Me.col月曜出勤時間.DataPropertyName = "月曜出勤時間"
        Me.col月曜出勤時間.HeaderText = "月曜出"
        Me.col月曜出勤時間.Name = "col月曜出勤時間"
        Me.col月曜出勤時間.ReadOnly = True
        '
        'col月曜退勤時間
        '
        Me.col月曜退勤時間.DataPropertyName = "月曜退勤時間"
        Me.col月曜退勤時間.HeaderText = "月曜退"
        Me.col月曜退勤時間.Name = "col月曜退勤時間"
        Me.col月曜退勤時間.ReadOnly = True
        '
        'col火曜出勤時間
        '
        Me.col火曜出勤時間.DataPropertyName = "火曜出勤時間"
        Me.col火曜出勤時間.HeaderText = "火曜出"
        Me.col火曜出勤時間.Name = "col火曜出勤時間"
        Me.col火曜出勤時間.ReadOnly = True
        '
        'col火曜退勤時間
        '
        Me.col火曜退勤時間.DataPropertyName = "火曜退勤時間"
        Me.col火曜退勤時間.HeaderText = "火曜退"
        Me.col火曜退勤時間.Name = "col火曜退勤時間"
        Me.col火曜退勤時間.ReadOnly = True
        '
        'col水曜出勤時間
        '
        Me.col水曜出勤時間.DataPropertyName = "水曜出勤時間"
        Me.col水曜出勤時間.HeaderText = "水曜出"
        Me.col水曜出勤時間.Name = "col水曜出勤時間"
        Me.col水曜出勤時間.ReadOnly = True
        '
        'col水曜退勤時間
        '
        Me.col水曜退勤時間.DataPropertyName = "水曜退勤時間"
        Me.col水曜退勤時間.HeaderText = "水曜退"
        Me.col水曜退勤時間.Name = "col水曜退勤時間"
        Me.col水曜退勤時間.ReadOnly = True
        '
        'col木曜出勤時間
        '
        Me.col木曜出勤時間.DataPropertyName = "木曜出勤時間"
        Me.col木曜出勤時間.HeaderText = "木曜出"
        Me.col木曜出勤時間.Name = "col木曜出勤時間"
        Me.col木曜出勤時間.ReadOnly = True
        '
        'col木曜退勤時間
        '
        Me.col木曜退勤時間.DataPropertyName = "木曜退勤時間"
        Me.col木曜退勤時間.HeaderText = "木曜退"
        Me.col木曜退勤時間.Name = "col木曜退勤時間"
        Me.col木曜退勤時間.ReadOnly = True
        '
        'col金曜出勤時間
        '
        Me.col金曜出勤時間.DataPropertyName = "金曜出勤時間"
        Me.col金曜出勤時間.HeaderText = "金曜出"
        Me.col金曜出勤時間.Name = "col金曜出勤時間"
        Me.col金曜出勤時間.ReadOnly = True
        '
        'col金曜退勤時間
        '
        Me.col金曜退勤時間.DataPropertyName = "金曜退勤時間"
        Me.col金曜退勤時間.HeaderText = "金曜退"
        Me.col金曜退勤時間.Name = "col金曜退勤時間"
        Me.col金曜退勤時間.ReadOnly = True
        '
        'col土曜出勤時間
        '
        Me.col土曜出勤時間.DataPropertyName = "土曜出勤時間"
        Me.col土曜出勤時間.HeaderText = "土曜出"
        Me.col土曜出勤時間.Name = "col土曜出勤時間"
        Me.col土曜出勤時間.ReadOnly = True
        '
        'col土曜退勤時間
        '
        Me.col土曜退勤時間.DataPropertyName = "土曜退勤時間"
        Me.col土曜退勤時間.HeaderText = "土曜退"
        Me.col土曜退勤時間.Name = "col土曜退勤時間"
        Me.col土曜退勤時間.ReadOnly = True
        '
        'col日曜出勤時間
        '
        Me.col日曜出勤時間.DataPropertyName = "日曜出勤時間"
        Me.col日曜出勤時間.HeaderText = "日曜出"
        Me.col日曜出勤時間.Name = "col日曜出勤時間"
        Me.col日曜出勤時間.ReadOnly = True
        '
        'col日曜退勤時間
        '
        Me.col日曜退勤時間.DataPropertyName = "日曜退勤時間"
        Me.col日曜退勤時間.HeaderText = "日曜退"
        Me.col日曜退勤時間.Name = "col日曜退勤時間"
        Me.col日曜退勤時間.ReadOnly = True
        '
        'col退職日
        '
        Me.col退職日.DataPropertyName = "退職日"
        Me.col退職日.HeaderText = "退職日"
        Me.col退職日.Name = "col退職日"
        Me.col退職日.ReadOnly = True
        Me.col退職日.Width = 120
        '
        'frmM職員マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.txt交通費)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txt超勤単価)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.txt時給単価)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btn勤務管理簿)
        Me.Controls.Add(Me.txt部署3カウント)
        Me.Controls.Add(Me.txt部署2カウント)
        Me.Controls.Add(Me.txt部署1カウント)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.cmb部署3)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.cmb部署2)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmb部署1)
        Me.Controls.Add(Me.txt月給)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.cmb勤務区分)
        Me.Controls.Add(Me.cmb担当)
        Me.Controls.Add(Me.cmb資格)
        Me.Controls.Add(Me.txtフリガナ)
        Me.Controls.Add(Me.btn職員名簿)
        Me.Controls.Add(Me.btn退職日)
        Me.Controls.Add(Me.txt退職日)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt経歴月)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt入職時経歴月)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btn入職日)
        Me.Controls.Add(Me.btn生年月日)
        Me.Controls.Add(Me.btn新規)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt経歴年)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt年齢)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt入職時経歴年)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt入職日)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt生年月日)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt職員氏名)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtパスワード)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt職員ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grb勤怠時間)
        Me.Controls.Add(Me.cmb職名)
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmM職員マスタ"
        Me.Text = "職員マスタ"
        Me.Controls.SetChildIndex(Me.cmb職名, 0)
        Me.Controls.SetChildIndex(Me.grb勤怠時間, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txt職員ID, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtパスワード, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txt職員氏名, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txt生年月日, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txt入職日, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txt入職時経歴年, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txt年齢, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txt経歴年, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.btn新規, 0)
        Me.Controls.SetChildIndex(Me.btn生年月日, 0)
        Me.Controls.SetChildIndex(Me.btn入職日, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.txt入職時経歴月, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txt経歴月, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.txt退職日, 0)
        Me.Controls.SetChildIndex(Me.btn退職日, 0)
        Me.Controls.SetChildIndex(Me.btn職員名簿, 0)
        Me.Controls.SetChildIndex(Me.txtフリガナ, 0)
        Me.Controls.SetChildIndex(Me.cmb資格, 0)
        Me.Controls.SetChildIndex(Me.cmb担当, 0)
        Me.Controls.SetChildIndex(Me.cmb勤務区分, 0)
        Me.Controls.SetChildIndex(Me.Label34, 0)
        Me.Controls.SetChildIndex(Me.txt月給, 0)
        Me.Controls.SetChildIndex(Me.cmb部署1, 0)
        Me.Controls.SetChildIndex(Me.Label35, 0)
        Me.Controls.SetChildIndex(Me.cmb部署2, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.cmb部署3, 0)
        Me.Controls.SetChildIndex(Me.Label37, 0)
        Me.Controls.SetChildIndex(Me.txt部署1カウント, 0)
        Me.Controls.SetChildIndex(Me.txt部署2カウント, 0)
        Me.Controls.SetChildIndex(Me.txt部署3カウント, 0)
        Me.Controls.SetChildIndex(Me.btn勤務管理簿, 0)
        Me.Controls.SetChildIndex(Me.Label38, 0)
        Me.Controls.SetChildIndex(Me.txt時給単価, 0)
        Me.Controls.SetChildIndex(Me.Label39, 0)
        Me.Controls.SetChildIndex(Me.txt超勤単価, 0)
        Me.Controls.SetChildIndex(Me.Label40, 0)
        Me.Controls.SetChildIndex(Me.txt交通費, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb勤怠時間.ResumeLayout(False)
        Me.grb勤怠時間.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt職員ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtパスワード As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt職員氏名 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt生年月日 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt入職日 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt入職時経歴年 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn登録 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txt年齢 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt経歴年 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn新規 As Button
    Friend WithEvents btn生年月日 As Button
    Friend WithEvents btn入職日 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents txt入職時経歴月 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt経歴月 As TextBox
    Friend WithEvents btn退職日 As Button
    Friend WithEvents txt退職日 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn職員名簿 As Button
    Friend WithEvents txtフリガナ As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents dtp月曜退勤時間 As DateTimePicker
    Friend WithEvents dtp月曜出勤時間 As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dtp火曜退勤時間 As DateTimePicker
    Friend WithEvents dtp火曜出勤時間 As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents dtp水曜退勤時間 As DateTimePicker
    Friend WithEvents dtp水曜出勤時間 As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents dtp日曜退勤時間 As DateTimePicker
    Friend WithEvents dtp日曜出勤時間 As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dtp木曜退勤時間 As DateTimePicker
    Friend WithEvents dtp木曜出勤時間 As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents dtp金曜退勤時間 As DateTimePicker
    Friend WithEvents dtp金曜出勤時間 As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents dtp土曜退勤時間 As DateTimePicker
    Friend WithEvents dtp土曜出勤時間 As DateTimePicker
    Friend WithEvents Label33 As Label
    Friend WithEvents grb勤怠時間 As GroupBox
    Friend WithEvents chk日 As CheckBox
    Friend WithEvents chk土 As CheckBox
    Friend WithEvents chk金 As CheckBox
    Friend WithEvents chk木 As CheckBox
    Friend WithEvents chk水 As CheckBox
    Friend WithEvents chk火 As CheckBox
    Friend WithEvents chk月 As CheckBox
    Friend WithEvents cmb職名 As ComboBox
    Friend WithEvents cmb資格 As ComboBox
    Friend WithEvents cmb担当 As ComboBox
    Friend WithEvents cmb勤務区分 As ComboBox
    Friend WithEvents txt月給 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents cmb部署1 As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cmb部署2 As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents cmb部署3 As ComboBox
    Friend WithEvents txt部署1カウント As TextBox
    Friend WithEvents txt部署2カウント As TextBox
    Friend WithEvents txt部署3カウント As TextBox
    Friend WithEvents btn勤務管理簿 As Button
    Friend WithEvents txt時給単価 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txt超勤単価 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txt交通費 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col職員ID As DataGridViewButtonColumn
    Friend WithEvents col職員氏名 As DataGridViewTextBoxColumn
    Friend WithEvents colフリガナ As DataGridViewTextBoxColumn
    Friend WithEvents colパスワード As DataGridViewTextBoxColumn
    Friend WithEvents col生年月日 As DataGridViewTextBoxColumn
    Friend WithEvents col入職日 As DataGridViewTextBoxColumn
    Friend WithEvents col入職時経歴年 As DataGridViewTextBoxColumn
    Friend WithEvents col入職時経歴月 As DataGridViewTextBoxColumn
    Friend WithEvents col職名 As DataGridViewTextBoxColumn
    Friend WithEvents col資格 As DataGridViewTextBoxColumn
    Friend WithEvents col担当 As DataGridViewTextBoxColumn
    Friend WithEvents col勤務区分 As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
    Friend WithEvents col月給 As DataGridViewTextBoxColumn
    Friend WithEvents col時給単価 As DataGridViewTextBoxColumn
    Friend WithEvents col超勤単価 As DataGridViewTextBoxColumn
    Friend WithEvents col交通費 As DataGridViewTextBoxColumn
    Friend WithEvents col部署1 As DataGridViewTextBoxColumn
    Friend WithEvents col部署1カウント As DataGridViewTextBoxColumn
    Friend WithEvents col部署2 As DataGridViewTextBoxColumn
    Friend WithEvents col部署2カウント As DataGridViewTextBoxColumn
    Friend WithEvents col部署3 As DataGridViewTextBoxColumn
    Friend WithEvents col部署3カウント As DataGridViewTextBoxColumn
    Friend WithEvents col月曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col月曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col火曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col火曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col水曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col水曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col木曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col木曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col金曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col金曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col土曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col土曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col日曜出勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col日曜退勤時間 As DataGridViewTextBoxColumn
    Friend WithEvents col退職日 As DataGridViewTextBoxColumn
End Class
