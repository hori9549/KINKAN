<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM児童マスタ
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
        Me.txt児童フリガナ = New System.Windows.Forms.TextBox()
        Me.btn生年月日 = New System.Windows.Forms.Button()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt年齢 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt生年月日 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt児童氏名 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt児童ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbクラス = New System.Windows.Forms.ComboBox()
        Me.txt保護者フリガナ = New System.Windows.Forms.TextBox()
        Me.txt保護者氏名 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.btn取得 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt連絡先１ = New System.Windows.Forms.TextBox()
        Me.txt連絡先２ = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col児童ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col児童氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col児童フリガナ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colクラス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col生年月日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col年齢 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col保護者氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col保護者フリガナ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col郵便番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col住所 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col連絡先１ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col連絡先２ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt児童フリガナ
        '
        Me.txt児童フリガナ.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt児童フリガナ.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txt児童フリガナ.Location = New System.Drawing.Point(110, 45)
        Me.txt児童フリガナ.Margin = New System.Windows.Forms.Padding(5)
        Me.txt児童フリガナ.Name = "txt児童フリガナ"
        Me.txt児童フリガナ.Size = New System.Drawing.Size(164, 20)
        Me.txt児童フリガナ.TabIndex = 5
        Me.txt児童フリガナ.TabStop = False
        '
        'btn生年月日
        '
        Me.btn生年月日.Location = New System.Drawing.Point(506, 66)
        Me.btn生年月日.Name = "btn生年月日"
        Me.btn生年月日.Size = New System.Drawing.Size(26, 27)
        Me.btn生年月日.TabIndex = 8
        Me.btn生年月日.TabStop = False
        Me.btn生年月日.UseVisualStyleBackColor = True
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(189, 15)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(26, 27)
        Me.btn新規.TabIndex = 2
        Me.btn新規.TabStop = False
        Me.btn新規.Text = "+"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(672, 70)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 19)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "歳"
        '
        'txt年齢
        '
        Me.txt年齢.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt年齢.Location = New System.Drawing.Point(591, 66)
        Me.txt年齢.Margin = New System.Windows.Forms.Padding(5)
        Me.txt年齢.Name = "txt年齢"
        Me.txt年齢.ReadOnly = True
        Me.txt年齢.Size = New System.Drawing.Size(79, 26)
        Me.txt年齢.TabIndex = 10
        Me.txt年齢.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(541, 70)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 19)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "年齢"
        '
        'txt生年月日
        '
        Me.txt生年月日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt生年月日.Location = New System.Drawing.Point(377, 66)
        Me.txt生年月日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt生年月日.Name = "txt生年月日"
        Me.txt生年月日.Size = New System.Drawing.Size(127, 26)
        Me.txt生年月日.TabIndex = 7
        Me.txt生年月日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "生年月日"
        '
        'txt児童氏名
        '
        Me.txt児童氏名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt児童氏名.Location = New System.Drawing.Point(110, 66)
        Me.txt児童氏名.Margin = New System.Windows.Forms.Padding(5)
        Me.txt児童氏名.Name = "txt児童氏名"
        Me.txt児童氏名.Size = New System.Drawing.Size(164, 26)
        Me.txt児童氏名.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "児童氏名"
        '
        'txt児童ID
        '
        Me.txt児童ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt児童ID.Location = New System.Drawing.Point(110, 15)
        Me.txt児童ID.Margin = New System.Windows.Forms.Padding(5)
        Me.txt児童ID.Name = "txt児童ID"
        Me.txt児童ID.ReadOnly = True
        Me.txt児童ID.Size = New System.Drawing.Size(79, 26)
        Me.txt児童ID.TabIndex = 1
        Me.txt児童ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "児童ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(756, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "クラス"
        '
        'cmbクラス
        '
        Me.cmbクラス.FormattingEnabled = True
        Me.cmbクラス.Location = New System.Drawing.Point(808, 66)
        Me.cmbクラス.Name = "cmbクラス"
        Me.cmbクラス.Size = New System.Drawing.Size(204, 27)
        Me.cmbクラス.TabIndex = 13
        '
        'txt保護者フリガナ
        '
        Me.txt保護者フリガナ.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt保護者フリガナ.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txt保護者フリガナ.Location = New System.Drawing.Point(110, 102)
        Me.txt保護者フリガナ.Margin = New System.Windows.Forms.Padding(5)
        Me.txt保護者フリガナ.Name = "txt保護者フリガナ"
        Me.txt保護者フリガナ.Size = New System.Drawing.Size(164, 20)
        Me.txt保護者フリガナ.TabIndex = 16
        Me.txt保護者フリガナ.TabStop = False
        '
        'txt保護者氏名
        '
        Me.txt保護者氏名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt保護者氏名.Location = New System.Drawing.Point(110, 123)
        Me.txt保護者氏名.Margin = New System.Windows.Forms.Padding(5)
        Me.txt保護者氏名.Name = "txt保護者氏名"
        Me.txt保護者氏名.Size = New System.Drawing.Size(164, 26)
        Me.txt保護者氏名.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "保護者氏名"
        '
        'txt郵便番号
        '
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt郵便番号.Location = New System.Drawing.Point(377, 96)
        Me.txt郵便番号.Margin = New System.Windows.Forms.Padding(5)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Size = New System.Drawing.Size(127, 26)
        Me.txt郵便番号.TabIndex = 18
        '
        'btn取得
        '
        Me.btn取得.Location = New System.Drawing.Point(506, 96)
        Me.btn取得.Name = "btn取得"
        Me.btn取得.Size = New System.Drawing.Size(26, 27)
        Me.btn取得.TabIndex = 19
        Me.btn取得.Text = "〒"
        Me.btn取得.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "住所"
        '
        'txt住所
        '
        Me.txt住所.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt住所.Location = New System.Drawing.Point(532, 96)
        Me.txt住所.Margin = New System.Windows.Forms.Padding(5)
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(480, 26)
        Me.txt住所.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(289, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "連絡先 １"
        '
        'txt連絡先１
        '
        Me.txt連絡先１.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt連絡先１.Location = New System.Drawing.Point(377, 124)
        Me.txt連絡先１.Margin = New System.Windows.Forms.Padding(5)
        Me.txt連絡先１.Name = "txt連絡先１"
        Me.txt連絡先１.Size = New System.Drawing.Size(204, 26)
        Me.txt連絡先１.TabIndex = 23
        '
        'txt連絡先２
        '
        Me.txt連絡先２.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt連絡先２.Location = New System.Drawing.Point(808, 124)
        Me.txt連絡先２.Margin = New System.Windows.Forms.Padding(5)
        Me.txt連絡先２.Name = "txt連絡先２"
        Me.txt連絡先２.Size = New System.Drawing.Size(204, 26)
        Me.txt連絡先２.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(720, 128)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "連絡先 ２"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col児童ID, Me.col児童氏名, Me.col児童フリガナ, Me.colクラス, Me.col生年月日, Me.col年齢, Me.col保護者氏名, Me.col保護者フリガナ, Me.col郵便番号, Me.col住所, Me.col連絡先１, Me.col連絡先２, Me.col備考})
        Me.dgv一覧.Location = New System.Drawing.Point(12, 262)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1158, 404)
        Me.dgv一覧.TabIndex = 29
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 120
        '
        'col施設ID
        '
        Me.col施設ID.DataPropertyName = "施設ID"
        Me.col施設ID.HeaderText = "施設ID"
        Me.col施設ID.Name = "col施設ID"
        Me.col施設ID.ReadOnly = True
        Me.col施設ID.Visible = False
        '
        'col児童ID
        '
        Me.col児童ID.DataPropertyName = "児童ID"
        Me.col児童ID.HeaderText = "児童ID"
        Me.col児童ID.Name = "col児童ID"
        Me.col児童ID.ReadOnly = True
        Me.col児童ID.Width = 90
        '
        'col児童氏名
        '
        Me.col児童氏名.DataPropertyName = "児童氏名"
        Me.col児童氏名.HeaderText = "児童氏名"
        Me.col児童氏名.Name = "col児童氏名"
        Me.col児童氏名.ReadOnly = True
        Me.col児童氏名.Width = 130
        '
        'col児童フリガナ
        '
        Me.col児童フリガナ.DataPropertyName = "児童フリガナ"
        Me.col児童フリガナ.HeaderText = "フリガナ"
        Me.col児童フリガナ.Name = "col児童フリガナ"
        Me.col児童フリガナ.ReadOnly = True
        Me.col児童フリガナ.Width = 150
        '
        'colクラス
        '
        Me.colクラス.DataPropertyName = "クラス"
        Me.colクラス.HeaderText = "クラス"
        Me.colクラス.Name = "colクラス"
        Me.colクラス.ReadOnly = True
        '
        'col生年月日
        '
        Me.col生年月日.DataPropertyName = "生年月日"
        Me.col生年月日.HeaderText = "生年月日"
        Me.col生年月日.Name = "col生年月日"
        Me.col生年月日.ReadOnly = True
        Me.col生年月日.Width = 120
        '
        'col年齢
        '
        Me.col年齢.DataPropertyName = "年齢"
        Me.col年齢.HeaderText = "年齢"
        Me.col年齢.Name = "col年齢"
        Me.col年齢.ReadOnly = True
        Me.col年齢.Width = 70
        '
        'col保護者氏名
        '
        Me.col保護者氏名.DataPropertyName = "保護者氏名"
        Me.col保護者氏名.HeaderText = "保護者氏名"
        Me.col保護者氏名.Name = "col保護者氏名"
        Me.col保護者氏名.ReadOnly = True
        Me.col保護者氏名.Width = 130
        '
        'col保護者フリガナ
        '
        Me.col保護者フリガナ.DataPropertyName = "保護者フリガナ"
        Me.col保護者フリガナ.HeaderText = "フリガナ"
        Me.col保護者フリガナ.Name = "col保護者フリガナ"
        Me.col保護者フリガナ.ReadOnly = True
        Me.col保護者フリガナ.Width = 150
        '
        'col郵便番号
        '
        Me.col郵便番号.DataPropertyName = "郵便番号"
        Me.col郵便番号.HeaderText = "郵便番号"
        Me.col郵便番号.Name = "col郵便番号"
        Me.col郵便番号.ReadOnly = True
        Me.col郵便番号.Width = 110
        '
        'col住所
        '
        Me.col住所.DataPropertyName = "住所"
        Me.col住所.HeaderText = "住所"
        Me.col住所.Name = "col住所"
        Me.col住所.ReadOnly = True
        Me.col住所.Width = 300
        '
        'col連絡先１
        '
        Me.col連絡先１.DataPropertyName = "連絡先１"
        Me.col連絡先１.HeaderText = "連絡先１"
        Me.col連絡先１.Name = "col連絡先１"
        Me.col連絡先１.ReadOnly = True
        Me.col連絡先１.Width = 120
        '
        'col連絡先２
        '
        Me.col連絡先２.DataPropertyName = "連絡先２"
        Me.col連絡先２.HeaderText = "連絡先2"
        Me.col連絡先２.Name = "col連絡先２"
        Me.col連絡先２.ReadOnly = True
        Me.col連絡先２.Width = 120
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.ReadOnly = True
        Me.col備考.Width = 300
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 157)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "備考"
        '
        'txt備考
        '
        Me.txt備考.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt備考.Location = New System.Drawing.Point(110, 154)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(5)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt備考.Size = New System.Drawing.Size(902, 102)
        Me.txt備考.TabIndex = 27
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1020, 216)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(150, 40)
        Me.btn登録.TabIndex = 28
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'frmM児童マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.txt連絡先２)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt連絡先１)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn取得)
        Me.Controls.Add(Me.txt郵便番号)
        Me.Controls.Add(Me.txt保護者フリガナ)
        Me.Controls.Add(Me.txt保護者氏名)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbクラス)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt児童フリガナ)
        Me.Controls.Add(Me.btn生年月日)
        Me.Controls.Add(Me.btn新規)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt年齢)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt生年月日)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt児童氏名)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt児童ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmM児童マスタ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "児童マスタ"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txt児童ID, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txt児童氏名, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txt生年月日, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txt年齢, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.btn新規, 0)
        Me.Controls.SetChildIndex(Me.btn生年月日, 0)
        Me.Controls.SetChildIndex(Me.txt児童フリガナ, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cmbクラス, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txt保護者氏名, 0)
        Me.Controls.SetChildIndex(Me.txt保護者フリガナ, 0)
        Me.Controls.SetChildIndex(Me.txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.btn取得, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txt連絡先１, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txt連絡先２, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt児童フリガナ As TextBox
    Friend WithEvents btn生年月日 As Button
    Friend WithEvents btn新規 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txt年齢 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt生年月日 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt児童氏名 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt児童ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbクラス As ComboBox
    Friend WithEvents txt保護者フリガナ As TextBox
    Friend WithEvents txt保護者氏名 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt郵便番号 As TextBox
    Friend WithEvents btn取得 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt住所 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt連絡先１ As TextBox
    Friend WithEvents txt連絡先２ As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents btn登録 As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col児童ID As DataGridViewTextBoxColumn
    Friend WithEvents col児童氏名 As DataGridViewTextBoxColumn
    Friend WithEvents col児童フリガナ As DataGridViewTextBoxColumn
    Friend WithEvents colクラス As DataGridViewTextBoxColumn
    Friend WithEvents col生年月日 As DataGridViewTextBoxColumn
    Friend WithEvents col年齢 As DataGridViewTextBoxColumn
    Friend WithEvents col保護者氏名 As DataGridViewTextBoxColumn
    Friend WithEvents col保護者フリガナ As DataGridViewTextBoxColumn
    Friend WithEvents col郵便番号 As DataGridViewTextBoxColumn
    Friend WithEvents col住所 As DataGridViewTextBoxColumn
    Friend WithEvents col連絡先１ As DataGridViewTextBoxColumn
    Friend WithEvents col連絡先２ As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
End Class
