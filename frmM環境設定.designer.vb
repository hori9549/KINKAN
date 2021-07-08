<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM環境設定
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFAX番号 = New System.Windows.Forms.TextBox()
        Me.txt電話番号 = New System.Windows.Forms.TextBox()
        Me.btn取得 = New System.Windows.Forms.Button()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.txt会社名 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtフリガナ = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt代表者 = New System.Windows.Forms.TextBox()
        Me.cmb口座区分 = New System.Windows.Forms.ComboBox()
        Me.txt口座番号 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt支店名 = New System.Windows.Forms.TextBox()
        Me.txt銀行名 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtp通常開始 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtp通常終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp第1延長開始 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp第1延長終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp第2延長開始 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp第2延長終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.dtp第3延長開始 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp第3延長終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb休憩時間 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb分入力単位 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtp時間1開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp時間1終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtp時間2開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp時間2終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtp時間3開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp時間3終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtp時間6開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp時間6終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtp時間5開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp時間5終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtp時間4開始 = New System.Windows.Forms.DateTimePicker()
        Me.dtp時間4終了 = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.grp簡易 = New System.Windows.Forms.GroupBox()
        Me.grp簡易.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(594, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 19)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "FAX番号"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(591, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 19)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "電話番号"
        '
        'txtFAX番号
        '
        Me.txtFAX番号.Location = New System.Drawing.Point(681, 37)
        Me.txtFAX番号.Name = "txtFAX番号"
        Me.txtFAX番号.Size = New System.Drawing.Size(182, 26)
        Me.txtFAX番号.TabIndex = 7
        '
        'txt電話番号
        '
        Me.txt電話番号.Location = New System.Drawing.Point(681, 5)
        Me.txt電話番号.Name = "txt電話番号"
        Me.txt電話番号.Size = New System.Drawing.Size(182, 26)
        Me.txt電話番号.TabIndex = 3
        '
        'btn取得
        '
        Me.btn取得.Location = New System.Drawing.Point(199, 69)
        Me.btn取得.Name = "btn取得"
        Me.btn取得.Size = New System.Drawing.Size(27, 25)
        Me.btn取得.TabIndex = 10
        Me.btn取得.Text = "〒"
        Me.btn取得.UseVisualStyleBackColor = True
        '
        'txt住所
        '
        Me.txt住所.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt住所.Location = New System.Drawing.Point(227, 69)
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(634, 26)
        Me.txt住所.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "郵便番号"
        '
        'txt郵便番号
        '
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt郵便番号.Location = New System.Drawing.Point(102, 69)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Size = New System.Drawing.Size(96, 26)
        Me.txt郵便番号.TabIndex = 9
        '
        'txt会社名
        '
        Me.txt会社名.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt会社名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt会社名.Location = New System.Drawing.Point(102, 31)
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Size = New System.Drawing.Size(468, 31)
        Me.txt会社名.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "会社名"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "フリガナ"
        '
        'txtフリガナ
        '
        Me.txtフリガナ.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtフリガナ.Location = New System.Drawing.Point(102, 5)
        Me.txtフリガナ.Name = "txtフリガナ"
        Me.txtフリガナ.Size = New System.Drawing.Size(468, 26)
        Me.txtフリガナ.TabIndex = 1
        Me.txtフリガナ.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(32, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 19)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "代表者"
        '
        'txt代表者
        '
        Me.txt代表者.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt代表者.Location = New System.Drawing.Point(102, 100)
        Me.txt代表者.Name = "txt代表者"
        Me.txt代表者.Size = New System.Drawing.Size(182, 26)
        Me.txt代表者.TabIndex = 13
        '
        'cmb口座区分
        '
        Me.cmb口座区分.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb口座区分.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb口座区分.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb口座区分.FormattingEnabled = True
        Me.cmb口座区分.Location = New System.Drawing.Point(680, 128)
        Me.cmb口座区分.Name = "cmb口座区分"
        Me.cmb口座区分.Size = New System.Drawing.Size(75, 27)
        Me.cmb口座区分.TabIndex = 19
        '
        'txt口座番号
        '
        Me.txt口座番号.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt口座番号.Location = New System.Drawing.Point(754, 128)
        Me.txt口座番号.Name = "txt口座番号"
        Me.txt口座番号.Size = New System.Drawing.Size(109, 26)
        Me.txt口座番号.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(591, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 19)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "口座番号"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(336, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 19)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "支店"
        '
        'txt支店名
        '
        Me.txt支店名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt支店名.Location = New System.Drawing.Point(389, 128)
        Me.txt支店名.Name = "txt支店名"
        Me.txt支店名.Size = New System.Drawing.Size(180, 26)
        Me.txt支店名.TabIndex = 17
        '
        'txt銀行名
        '
        Me.txt銀行名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銀行名.Location = New System.Drawing.Point(102, 128)
        Me.txt銀行名.Name = "txt銀行名"
        Me.txt銀行名.Size = New System.Drawing.Size(182, 26)
        Me.txt銀行名.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(51, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 19)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "銀行"
        '
        'dtp通常開始
        '
        Me.dtp通常開始.CustomFormat = "HH:mm"
        Me.dtp通常開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp通常開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp通常開始.Location = New System.Drawing.Point(102, 156)
        Me.dtp通常開始.Name = "dtp通常開始"
        Me.dtp通常開始.ShowUpDown = True
        Me.dtp通常開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp通常開始.TabIndex = 22
        Me.dtp通常開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(52, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 19)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "通常"
        '
        'dtp通常終了
        '
        Me.dtp通常終了.CustomFormat = "HH:mm"
        Me.dtp通常終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp通常終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp通常終了.Location = New System.Drawing.Point(208, 156)
        Me.dtp通常終了.Name = "dtp通常終了"
        Me.dtp通常終了.ShowUpDown = True
        Me.dtp通常終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp通常終了.TabIndex = 24
        Me.dtp通常終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "～"
        '
        'dtp第1延長開始
        '
        Me.dtp第1延長開始.CustomFormat = "HH:mm"
        Me.dtp第1延長開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp第1延長開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp第1延長開始.Location = New System.Drawing.Point(102, 185)
        Me.dtp第1延長開始.Name = "dtp第1延長開始"
        Me.dtp第1延長開始.ShowUpDown = True
        Me.dtp第1延長開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp第1延長開始.TabIndex = 30
        Me.dtp第1延長開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(11, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "早朝延長"
        '
        'dtp第1延長終了
        '
        Me.dtp第1延長終了.CustomFormat = "HH:mm"
        Me.dtp第1延長終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp第1延長終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp第1延長終了.Location = New System.Drawing.Point(208, 185)
        Me.dtp第1延長終了.Name = "dtp第1延長終了"
        Me.dtp第1延長終了.ShowUpDown = True
        Me.dtp第1延長終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp第1延長終了.TabIndex = 32
        Me.dtp第1延長終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "～"
        '
        'dtp第2延長開始
        '
        Me.dtp第2延長開始.CustomFormat = "HH:mm"
        Me.dtp第2延長開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp第2延長開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp第2延長開始.Location = New System.Drawing.Point(389, 185)
        Me.dtp第2延長開始.Name = "dtp第2延長開始"
        Me.dtp第2延長開始.ShowUpDown = True
        Me.dtp第2延長開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp第2延長開始.TabIndex = 34
        Me.dtp第2延長開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(297, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "通常延長"
        '
        'dtp第2延長終了
        '
        Me.dtp第2延長終了.CustomFormat = "HH:mm"
        Me.dtp第2延長終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp第2延長終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp第2延長終了.Location = New System.Drawing.Point(494, 185)
        Me.dtp第2延長終了.Name = "dtp第2延長終了"
        Me.dtp第2延長終了.ShowUpDown = True
        Me.dtp第2延長終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp第2延長終了.TabIndex = 36
        Me.dtp第2延長終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(465, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "～"
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1020, 260)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 36)
        Me.btn登録.TabIndex = 41
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'dtp第3延長開始
        '
        Me.dtp第3延長開始.CustomFormat = "HH:mm"
        Me.dtp第3延長開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp第3延長開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp第3延長開始.Location = New System.Drawing.Point(680, 185)
        Me.dtp第3延長開始.Name = "dtp第3延長開始"
        Me.dtp第3延長開始.ShowUpDown = True
        Me.dtp第3延長開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp第3延長開始.TabIndex = 38
        Me.dtp第3延長開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(589, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 19)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "夕方延長"
        '
        'dtp第3延長終了
        '
        Me.dtp第3延長終了.CustomFormat = "HH:mm"
        Me.dtp第3延長終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp第3延長終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp第3延長終了.Location = New System.Drawing.Point(786, 185)
        Me.dtp第3延長終了.Name = "dtp第3延長終了"
        Me.dtp第3延長終了.ShowUpDown = True
        Me.dtp第3延長終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp第3延長終了.TabIndex = 40
        Me.dtp第3延長終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(757, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 19)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "～"
        '
        'cmb休憩時間
        '
        Me.cmb休憩時間.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb休憩時間.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb休憩時間.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb休憩時間.FormattingEnabled = True
        Me.cmb休憩時間.Location = New System.Drawing.Point(389, 156)
        Me.cmb休憩時間.Name = "cmb休憩時間"
        Me.cmb休憩時間.Size = New System.Drawing.Size(180, 27)
        Me.cmb休憩時間.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(299, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 19)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "休憩時間"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(571, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 19)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "分入力単位"
        '
        'cmb分入力単位
        '
        Me.cmb分入力単位.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb分入力単位.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb分入力単位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb分入力単位.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb分入力単位.FormattingEnabled = True
        Me.cmb分入力単位.Items.AddRange(New Object() {"1", "5", "10", "15", "30"})
        Me.cmb分入力単位.Location = New System.Drawing.Point(680, 156)
        Me.cmb分入力単位.Name = "cmb分入力単位"
        Me.cmb分入力単位.Size = New System.Drawing.Size(75, 27)
        Me.cmb分入力単位.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(22, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 19)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "時間１"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(306, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 19)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "時間2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(599, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 19)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "時間3"
        '
        'dtp時間1開始
        '
        Me.dtp時間1開始.CustomFormat = "HH:mm"
        Me.dtp時間1開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間1開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間1開始.Location = New System.Drawing.Point(86, 25)
        Me.dtp時間1開始.Name = "dtp時間1開始"
        Me.dtp時間1開始.ShowUpDown = True
        Me.dtp時間1開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間1開始.TabIndex = 106
        Me.dtp時間1開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'dtp時間1終了
        '
        Me.dtp時間1終了.CustomFormat = "HH:mm"
        Me.dtp時間1終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間1終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間1終了.Location = New System.Drawing.Point(192, 25)
        Me.dtp時間1終了.Name = "dtp時間1終了"
        Me.dtp時間1終了.ShowUpDown = True
        Me.dtp時間1終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間1終了.TabIndex = 108
        Me.dtp時間1終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(163, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 19)
        Me.Label23.TabIndex = 107
        Me.Label23.Text = "～"
        '
        'dtp時間2開始
        '
        Me.dtp時間2開始.CustomFormat = "HH:mm"
        Me.dtp時間2開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間2開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間2開始.Location = New System.Drawing.Point(373, 25)
        Me.dtp時間2開始.Name = "dtp時間2開始"
        Me.dtp時間2開始.ShowUpDown = True
        Me.dtp時間2開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間2開始.TabIndex = 109
        Me.dtp時間2開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'dtp時間2終了
        '
        Me.dtp時間2終了.CustomFormat = "HH:mm"
        Me.dtp時間2終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間2終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間2終了.Location = New System.Drawing.Point(479, 25)
        Me.dtp時間2終了.Name = "dtp時間2終了"
        Me.dtp時間2終了.ShowUpDown = True
        Me.dtp時間2終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間2終了.TabIndex = 111
        Me.dtp時間2終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(450, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(28, 19)
        Me.Label24.TabIndex = 110
        Me.Label24.Text = "～"
        '
        'dtp時間3開始
        '
        Me.dtp時間3開始.CustomFormat = "HH:mm"
        Me.dtp時間3開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間3開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間3開始.Location = New System.Drawing.Point(664, 25)
        Me.dtp時間3開始.Name = "dtp時間3開始"
        Me.dtp時間3開始.ShowUpDown = True
        Me.dtp時間3開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間3開始.TabIndex = 112
        Me.dtp時間3開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'dtp時間3終了
        '
        Me.dtp時間3終了.CustomFormat = "HH:mm"
        Me.dtp時間3終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間3終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間3終了.Location = New System.Drawing.Point(770, 25)
        Me.dtp時間3終了.Name = "dtp時間3終了"
        Me.dtp時間3終了.ShowUpDown = True
        Me.dtp時間3終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間3終了.TabIndex = 114
        Me.dtp時間3終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(741, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 19)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "～"
        '
        'dtp時間6開始
        '
        Me.dtp時間6開始.CustomFormat = "HH:mm"
        Me.dtp時間6開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間6開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間6開始.Location = New System.Drawing.Point(664, 53)
        Me.dtp時間6開始.Name = "dtp時間6開始"
        Me.dtp時間6開始.ShowUpDown = True
        Me.dtp時間6開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間6開始.TabIndex = 124
        Me.dtp時間6開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'dtp時間6終了
        '
        Me.dtp時間6終了.CustomFormat = "HH:mm"
        Me.dtp時間6終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間6終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間6終了.Location = New System.Drawing.Point(770, 53)
        Me.dtp時間6終了.Name = "dtp時間6終了"
        Me.dtp時間6終了.ShowUpDown = True
        Me.dtp時間6終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間6終了.TabIndex = 126
        Me.dtp時間6終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(741, 57)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 19)
        Me.Label26.TabIndex = 125
        Me.Label26.Text = "～"
        '
        'dtp時間5開始
        '
        Me.dtp時間5開始.CustomFormat = "HH:mm"
        Me.dtp時間5開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間5開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間5開始.Location = New System.Drawing.Point(373, 53)
        Me.dtp時間5開始.Name = "dtp時間5開始"
        Me.dtp時間5開始.ShowUpDown = True
        Me.dtp時間5開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間5開始.TabIndex = 121
        Me.dtp時間5開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'dtp時間5終了
        '
        Me.dtp時間5終了.CustomFormat = "HH:mm"
        Me.dtp時間5終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間5終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間5終了.Location = New System.Drawing.Point(479, 53)
        Me.dtp時間5終了.Name = "dtp時間5終了"
        Me.dtp時間5終了.ShowUpDown = True
        Me.dtp時間5終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間5終了.TabIndex = 123
        Me.dtp時間5終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(450, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 19)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "～"
        '
        'dtp時間4開始
        '
        Me.dtp時間4開始.CustomFormat = "HH:mm"
        Me.dtp時間4開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間4開始.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間4開始.Location = New System.Drawing.Point(86, 53)
        Me.dtp時間4開始.Name = "dtp時間4開始"
        Me.dtp時間4開始.ShowUpDown = True
        Me.dtp時間4開始.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間4開始.TabIndex = 118
        Me.dtp時間4開始.Value = New Date(2020, 10, 2, 7, 30, 0, 0)
        '
        'dtp時間4終了
        '
        Me.dtp時間4終了.CustomFormat = "HH:mm"
        Me.dtp時間4終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp時間4終了.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp時間4終了.Location = New System.Drawing.Point(192, 53)
        Me.dtp時間4終了.Name = "dtp時間4終了"
        Me.dtp時間4終了.ShowUpDown = True
        Me.dtp時間4終了.Size = New System.Drawing.Size(75, 26)
        Me.dtp時間4終了.TabIndex = 120
        Me.dtp時間4終了.Value = New Date(2020, 10, 2, 18, 30, 0, 0)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(163, 57)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 19)
        Me.Label28.TabIndex = 119
        Me.Label28.Text = "～"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.Location = New System.Drawing.Point(599, 57)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 19)
        Me.Label29.TabIndex = 117
        Me.Label29.Text = "時間6"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.Location = New System.Drawing.Point(306, 57)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 19)
        Me.Label30.TabIndex = 116
        Me.Label30.Text = "時間5"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(22, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 19)
        Me.Label31.TabIndex = 115
        Me.Label31.Text = "時間4"
        '
        'grp簡易
        '
        Me.grp簡易.Controls.Add(Me.dtp時間1開始)
        Me.grp簡易.Controls.Add(Me.dtp時間6開始)
        Me.grp簡易.Controls.Add(Me.Label16)
        Me.grp簡易.Controls.Add(Me.dtp時間6終了)
        Me.grp簡易.Controls.Add(Me.Label19)
        Me.grp簡易.Controls.Add(Me.Label26)
        Me.grp簡易.Controls.Add(Me.Label22)
        Me.grp簡易.Controls.Add(Me.dtp時間5開始)
        Me.grp簡易.Controls.Add(Me.Label23)
        Me.grp簡易.Controls.Add(Me.dtp時間5終了)
        Me.grp簡易.Controls.Add(Me.dtp時間1終了)
        Me.grp簡易.Controls.Add(Me.Label27)
        Me.grp簡易.Controls.Add(Me.Label24)
        Me.grp簡易.Controls.Add(Me.dtp時間4開始)
        Me.grp簡易.Controls.Add(Me.dtp時間2終了)
        Me.grp簡易.Controls.Add(Me.dtp時間4終了)
        Me.grp簡易.Controls.Add(Me.dtp時間2開始)
        Me.grp簡易.Controls.Add(Me.Label28)
        Me.grp簡易.Controls.Add(Me.Label25)
        Me.grp簡易.Controls.Add(Me.Label29)
        Me.grp簡易.Controls.Add(Me.dtp時間3終了)
        Me.grp簡易.Controls.Add(Me.Label30)
        Me.grp簡易.Controls.Add(Me.dtp時間3開始)
        Me.grp簡易.Controls.Add(Me.Label31)
        Me.grp簡易.Location = New System.Drawing.Point(16, 217)
        Me.grp簡易.Name = "grp簡易"
        Me.grp簡易.Size = New System.Drawing.Size(862, 100)
        Me.grp簡易.TabIndex = 127
        Me.grp簡易.TabStop = False
        Me.grp簡易.Text = "簡易ボタン"
        '
        'frmM環境設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.grp簡易)
        Me.Controls.Add(Me.cmb分入力単位)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmb休憩時間)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtp第3延長開始)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtp第3延長終了)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.dtp第2延長開始)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtp第2延長終了)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtp第1延長開始)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp第1延長終了)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp通常開始)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.dtp通常終了)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb口座区分)
        Me.Controls.Add(Me.txt口座番号)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt支店名)
        Me.Controls.Add(Me.txt銀行名)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt代表者)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFAX番号)
        Me.Controls.Add(Me.txt電話番号)
        Me.Controls.Add(Me.btn取得)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt郵便番号)
        Me.Controls.Add(Me.txt会社名)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtフリガナ)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmM環境設定"
        Me.Text = "環境設定"
        Me.Controls.SetChildIndex(Me.txtフリガナ, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txt会社名, 0)
        Me.Controls.SetChildIndex(Me.txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.btn取得, 0)
        Me.Controls.SetChildIndex(Me.txt電話番号, 0)
        Me.Controls.SetChildIndex(Me.txtFAX番号, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.txt代表者, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txt銀行名, 0)
        Me.Controls.SetChildIndex(Me.txt支店名, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txt口座番号, 0)
        Me.Controls.SetChildIndex(Me.cmb口座区分, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dtp通常終了, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.dtp通常開始, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.dtp第1延長終了, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.dtp第1延長開始, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.dtp第2延長終了, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.dtp第2延長開始, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.dtp第3延長終了, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.dtp第3延長開始, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.cmb休憩時間, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cmb分入力単位, 0)
        Me.Controls.SetChildIndex(Me.grp簡易, 0)
        Me.grp簡易.ResumeLayout(False)
        Me.grp簡易.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFAX番号 As System.Windows.Forms.TextBox
    Friend WithEvents txt電話番号 As System.Windows.Forms.TextBox
    Friend WithEvents btn取得 As System.Windows.Forms.Button
    Friend WithEvents txt住所 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt郵便番号 As System.Windows.Forms.TextBox
    Friend WithEvents txt会社名 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtフリガナ As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt代表者 As System.Windows.Forms.TextBox
    Friend WithEvents cmb口座区分 As System.Windows.Forms.ComboBox
    Friend WithEvents txt口座番号 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt支店名 As System.Windows.Forms.TextBox
    Friend WithEvents txt銀行名 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp通常開始 As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents dtp通常終了 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp第1延長開始 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp第1延長終了 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp第2延長開始 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp第2延長終了 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents btn登録 As Button
    Friend WithEvents dtp第3延長開始 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp第3延長終了 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb休憩時間 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb分入力単位 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dtp時間1開始 As DateTimePicker
    Friend WithEvents dtp時間1終了 As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents dtp時間2開始 As DateTimePicker
    Friend WithEvents dtp時間2終了 As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents dtp時間3開始 As DateTimePicker
    Friend WithEvents dtp時間3終了 As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents dtp時間6開始 As DateTimePicker
    Friend WithEvents dtp時間6終了 As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents dtp時間5開始 As DateTimePicker
    Friend WithEvents dtp時間5終了 As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents dtp時間4開始 As DateTimePicker
    Friend WithEvents dtp時間4終了 As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents grp簡易 As GroupBox
End Class
