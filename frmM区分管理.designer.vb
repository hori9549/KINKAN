<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmM区分管理
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab区分 = New System.Windows.Forms.TabPage()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.dgv区分 = New System.Windows.Forms.DataGridView()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.lbl備考 = New System.Windows.Forms.Label()
        Me.txt区分名 = New System.Windows.Forms.TextBox()
        Me.txt区分 = New System.Windows.Forms.TextBox()
        Me.lbl区分名 = New System.Windows.Forms.Label()
        Me.lbl区分 = New System.Windows.Forms.Label()
        Me.Tab区分明細 = New System.Windows.Forms.TabPage()
        Me.btn新規_明細 = New System.Windows.Forms.Button()
        Me.chk削除_区分明細 = New System.Windows.Forms.CheckBox()
        Me.txt備考_区分明細 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn登録_明細 = New System.Windows.Forms.Button()
        Me.dgv区分明細 = New System.Windows.Forms.DataGridView()
        Me.txtコード_区分明細 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt内容_区分明細 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb区分_区分明細 = New System.Windows.Forms.ComboBox()
        Me.colID_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分名_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colコード_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col内容_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.Tab区分.SuspendLayout()
        CType(Me.dgv区分, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab区分明細.SuspendLayout()
        CType(Me.dgv区分明細, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tab区分)
        Me.TabControl1.Controls.Add(Me.Tab区分明細)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1160, 654)
        Me.TabControl1.TabIndex = 0
        '
        'Tab区分
        '
        Me.Tab区分.Controls.Add(Me.btn新規)
        Me.Tab区分.Controls.Add(Me.btn登録)
        Me.Tab区分.Controls.Add(Me.dgv区分)
        Me.Tab区分.Controls.Add(Me.txt備考)
        Me.Tab区分.Controls.Add(Me.lbl備考)
        Me.Tab区分.Controls.Add(Me.txt区分名)
        Me.Tab区分.Controls.Add(Me.txt区分)
        Me.Tab区分.Controls.Add(Me.lbl区分名)
        Me.Tab区分.Controls.Add(Me.lbl区分)
        Me.Tab区分.Location = New System.Drawing.Point(4, 29)
        Me.Tab区分.Name = "Tab区分"
        Me.Tab区分.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab区分.Size = New System.Drawing.Size(1152, 621)
        Me.Tab区分.TabIndex = 0
        Me.Tab区分.Text = "区分"
        Me.Tab区分.UseVisualStyleBackColor = True
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(160, 18)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(30, 30)
        Me.btn新規.TabIndex = 2
        Me.btn新規.Text = "+"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'btn登録
        '
        Me.btn登録.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn登録.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(1003, 65)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 45)
        Me.btn登録.TabIndex = 7
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'dgv区分
        '
        Me.dgv区分.AllowUserToAddRows = False
        Me.dgv区分.AllowUserToDeleteRows = False
        Me.dgv区分.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv区分.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv区分.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID_区分, Me.col施設ID_区分, Me.col区分_区分, Me.col区分名_区分, Me.col備考_区分})
        Me.dgv区分.Location = New System.Drawing.Point(20, 116)
        Me.dgv区分.Name = "dgv区分"
        Me.dgv区分.ReadOnly = True
        Me.dgv区分.RowHeadersVisible = False
        Me.dgv区分.RowTemplate.Height = 30
        Me.dgv区分.Size = New System.Drawing.Size(1108, 483)
        Me.dgv区分.TabIndex = 8
        Me.dgv区分.TabStop = False
        '
        'txt備考
        '
        Me.txt備考.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt備考.Location = New System.Drawing.Point(100, 84)
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(384, 26)
        Me.txt備考.TabIndex = 6
        '
        'lbl備考
        '
        Me.lbl備考.AutoSize = True
        Me.lbl備考.Location = New System.Drawing.Point(47, 87)
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Size = New System.Drawing.Size(47, 19)
        Me.lbl備考.TabIndex = 5
        Me.lbl備考.Text = "備考"
        '
        'txt区分名
        '
        Me.txt区分名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt区分名.Location = New System.Drawing.Point(100, 52)
        Me.txt区分名.Name = "txt区分名"
        Me.txt区分名.Size = New System.Drawing.Size(384, 26)
        Me.txt区分名.TabIndex = 4
        '
        'txt区分
        '
        Me.txt区分.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt区分.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt区分.Location = New System.Drawing.Point(100, 20)
        Me.txt区分.Name = "txt区分"
        Me.txt区分.ReadOnly = True
        Me.txt区分.Size = New System.Drawing.Size(60, 26)
        Me.txt区分.TabIndex = 1
        Me.txt区分.TabStop = False
        Me.txt区分.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl区分名
        '
        Me.lbl区分名.AutoSize = True
        Me.lbl区分名.Location = New System.Drawing.Point(28, 55)
        Me.lbl区分名.Name = "lbl区分名"
        Me.lbl区分名.Size = New System.Drawing.Size(66, 19)
        Me.lbl区分名.TabIndex = 3
        Me.lbl区分名.Text = "区分名"
        '
        'lbl区分
        '
        Me.lbl区分.AutoSize = True
        Me.lbl区分.Location = New System.Drawing.Point(47, 24)
        Me.lbl区分.Name = "lbl区分"
        Me.lbl区分.Size = New System.Drawing.Size(47, 19)
        Me.lbl区分.TabIndex = 0
        Me.lbl区分.Text = "区分"
        '
        'Tab区分明細
        '
        Me.Tab区分明細.Controls.Add(Me.btn新規_明細)
        Me.Tab区分明細.Controls.Add(Me.chk削除_区分明細)
        Me.Tab区分明細.Controls.Add(Me.txt備考_区分明細)
        Me.Tab区分明細.Controls.Add(Me.Label2)
        Me.Tab区分明細.Controls.Add(Me.btn登録_明細)
        Me.Tab区分明細.Controls.Add(Me.dgv区分明細)
        Me.Tab区分明細.Controls.Add(Me.txtコード_区分明細)
        Me.Tab区分明細.Controls.Add(Me.Label4)
        Me.Tab区分明細.Controls.Add(Me.txt内容_区分明細)
        Me.Tab区分明細.Controls.Add(Me.Label3)
        Me.Tab区分明細.Controls.Add(Me.Label1)
        Me.Tab区分明細.Controls.Add(Me.cmb区分_区分明細)
        Me.Tab区分明細.Location = New System.Drawing.Point(4, 29)
        Me.Tab区分明細.Name = "Tab区分明細"
        Me.Tab区分明細.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab区分明細.Size = New System.Drawing.Size(1152, 621)
        Me.Tab区分明細.TabIndex = 1
        Me.Tab区分明細.Text = "区分明細"
        Me.Tab区分明細.UseVisualStyleBackColor = True
        '
        'btn新規_明細
        '
        Me.btn新規_明細.Location = New System.Drawing.Point(446, 18)
        Me.btn新規_明細.Name = "btn新規_明細"
        Me.btn新規_明細.Size = New System.Drawing.Size(30, 30)
        Me.btn新規_明細.TabIndex = 11
        Me.btn新規_明細.Text = "+"
        Me.btn新規_明細.UseVisualStyleBackColor = True
        '
        'chk削除_区分明細
        '
        Me.chk削除_区分明細.AutoSize = True
        Me.chk削除_区分明細.Location = New System.Drawing.Point(821, 87)
        Me.chk削除_区分明細.Name = "chk削除_区分明細"
        Me.chk削除_区分明細.Size = New System.Drawing.Size(66, 23)
        Me.chk削除_区分明細.TabIndex = 8
        Me.chk削除_区分明細.TabStop = False
        Me.chk削除_区分明細.Text = "削除"
        Me.chk削除_区分明細.UseVisualStyleBackColor = True
        '
        'txt備考_区分明細
        '
        Me.txt備考_区分明細.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt備考_区分明細.Location = New System.Drawing.Point(100, 85)
        Me.txt備考_区分明細.Name = "txt備考_区分明細"
        Me.txt備考_区分明細.Size = New System.Drawing.Size(700, 26)
        Me.txt備考_区分明細.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "備考"
        '
        'btn登録_明細
        '
        Me.btn登録_明細.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn登録_明細.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録_明細.Location = New System.Drawing.Point(997, 66)
        Me.btn登録_明細.Name = "btn登録_明細"
        Me.btn登録_明細.Size = New System.Drawing.Size(125, 45)
        Me.btn登録_明細.TabIndex = 9
        Me.btn登録_明細.Text = "登録"
        Me.btn登録_明細.UseVisualStyleBackColor = True
        '
        'dgv区分明細
        '
        Me.dgv区分明細.AllowUserToAddRows = False
        Me.dgv区分明細.AllowUserToDeleteRows = False
        Me.dgv区分明細.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv区分明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv区分明細.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID_区分明細, Me.col施設ID_区分明細, Me.col区分_区分明細, Me.colコード_区分明細, Me.col内容_区分明細, Me.col備考_区分明細, Me.col削除_区分明細})
        Me.dgv区分明細.Location = New System.Drawing.Point(17, 117)
        Me.dgv区分明細.Name = "dgv区分明細"
        Me.dgv区分明細.ReadOnly = True
        Me.dgv区分明細.RowHeadersVisible = False
        Me.dgv区分明細.RowTemplate.Height = 30
        Me.dgv区分明細.Size = New System.Drawing.Size(1105, 486)
        Me.dgv区分明細.TabIndex = 10
        Me.dgv区分明細.TabStop = False
        '
        'txtコード_区分明細
        '
        Me.txtコード_区分明細.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtコード_区分明細.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtコード_区分明細.Location = New System.Drawing.Point(386, 20)
        Me.txtコード_区分明細.Name = "txtコード_区分明細"
        Me.txtコード_区分明細.ReadOnly = True
        Me.txtコード_区分明細.Size = New System.Drawing.Size(60, 26)
        Me.txtコード_区分明細.TabIndex = 3
        Me.txtコード_区分明細.TabStop = False
        Me.txtコード_区分明細.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "コード"
        '
        'txt内容_区分明細
        '
        Me.txt内容_区分明細.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt内容_区分明細.Location = New System.Drawing.Point(100, 52)
        Me.txt内容_区分明細.Name = "txt内容_区分明細"
        Me.txt内容_区分明細.Size = New System.Drawing.Size(700, 26)
        Me.txt内容_区分明細.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "内容"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "区分"
        '
        'cmb区分_区分明細
        '
        Me.cmb区分_区分明細.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb区分_区分明細.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb区分_区分明細.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb区分_区分明細.FormattingEnabled = True
        Me.cmb区分_区分明細.Location = New System.Drawing.Point(100, 20)
        Me.cmb区分_区分明細.Name = "cmb区分_区分明細"
        Me.cmb区分_区分明細.Size = New System.Drawing.Size(199, 27)
        Me.cmb区分_区分明細.TabIndex = 1
        '
        'colID_区分
        '
        Me.colID_区分.DataPropertyName = "ID"
        Me.colID_区分.HeaderText = "ID"
        Me.colID_区分.Name = "colID_区分"
        Me.colID_区分.ReadOnly = True
        Me.colID_区分.Visible = False
        '
        'col施設ID_区分
        '
        Me.col施設ID_区分.DataPropertyName = "施設ID"
        Me.col施設ID_区分.HeaderText = "施設ID"
        Me.col施設ID_区分.Name = "col施設ID_区分"
        Me.col施設ID_区分.ReadOnly = True
        Me.col施設ID_区分.Visible = False
        '
        'col区分_区分
        '
        Me.col区分_区分.DataPropertyName = "区分"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col区分_区分.DefaultCellStyle = DataGridViewCellStyle1
        Me.col区分_区分.HeaderText = "区分"
        Me.col区分_区分.Name = "col区分_区分"
        Me.col区分_区分.ReadOnly = True
        Me.col区分_区分.Width = 70
        '
        'col区分名_区分
        '
        Me.col区分名_区分.DataPropertyName = "区分名"
        Me.col区分名_区分.HeaderText = "区分名"
        Me.col区分名_区分.Name = "col区分名_区分"
        Me.col区分名_区分.ReadOnly = True
        Me.col区分名_区分.Width = 300
        '
        'col備考_区分
        '
        Me.col備考_区分.DataPropertyName = "備考"
        Me.col備考_区分.HeaderText = "備考"
        Me.col備考_区分.Name = "col備考_区分"
        Me.col備考_区分.ReadOnly = True
        Me.col備考_区分.Width = 300
        '
        'colID_区分明細
        '
        Me.colID_区分明細.DataPropertyName = "ID"
        Me.colID_区分明細.HeaderText = "ID"
        Me.colID_区分明細.Name = "colID_区分明細"
        Me.colID_区分明細.ReadOnly = True
        Me.colID_区分明細.Visible = False
        '
        'col施設ID_区分明細
        '
        Me.col施設ID_区分明細.DataPropertyName = "施設ID"
        Me.col施設ID_区分明細.HeaderText = "施設ID"
        Me.col施設ID_区分明細.Name = "col施設ID_区分明細"
        Me.col施設ID_区分明細.ReadOnly = True
        Me.col施設ID_区分明細.Visible = False
        '
        'col区分_区分明細
        '
        Me.col区分_区分明細.DataPropertyName = "区分"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col区分_区分明細.DefaultCellStyle = DataGridViewCellStyle2
        Me.col区分_区分明細.HeaderText = "区分"
        Me.col区分_区分明細.Name = "col区分_区分明細"
        Me.col区分_区分明細.ReadOnly = True
        Me.col区分_区分明細.Width = 70
        '
        'colコード_区分明細
        '
        Me.colコード_区分明細.DataPropertyName = "コード"
        Me.colコード_区分明細.HeaderText = "コード"
        Me.colコード_区分明細.Name = "colコード_区分明細"
        Me.colコード_区分明細.ReadOnly = True
        '
        'col内容_区分明細
        '
        Me.col内容_区分明細.DataPropertyName = "内容"
        Me.col内容_区分明細.HeaderText = "内容"
        Me.col内容_区分明細.Name = "col内容_区分明細"
        Me.col内容_区分明細.ReadOnly = True
        Me.col内容_区分明細.Width = 400
        '
        'col備考_区分明細
        '
        Me.col備考_区分明細.DataPropertyName = "備考"
        Me.col備考_区分明細.HeaderText = "備考"
        Me.col備考_区分明細.Name = "col備考_区分明細"
        Me.col備考_区分明細.ReadOnly = True
        Me.col備考_区分明細.Width = 400
        '
        'col削除_区分明細
        '
        Me.col削除_区分明細.DataPropertyName = "削除フラグ"
        Me.col削除_区分明細.HeaderText = "削除"
        Me.col削除_区分明細.Name = "col削除_区分明細"
        Me.col削除_区分明細.ReadOnly = True
        Me.col削除_区分明細.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col削除_区分明細.Width = 75
        '
        'frmM区分管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmM区分管理"
        Me.Text = "区分管理マスタ"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.Tab区分.ResumeLayout(False)
        Me.Tab区分.PerformLayout()
        CType(Me.dgv区分, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab区分明細.ResumeLayout(False)
        Me.Tab区分明細.PerformLayout()
        CType(Me.dgv区分明細, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab区分 As System.Windows.Forms.TabPage
    Friend WithEvents btn登録 As System.Windows.Forms.Button
    Friend WithEvents dgv区分 As System.Windows.Forms.DataGridView
    Friend WithEvents txt備考 As System.Windows.Forms.TextBox
    Friend WithEvents lbl備考 As System.Windows.Forms.Label
    Friend WithEvents txt区分名 As System.Windows.Forms.TextBox
    Friend WithEvents txt区分 As System.Windows.Forms.TextBox
    Friend WithEvents lbl区分名 As System.Windows.Forms.Label
    Friend WithEvents lbl区分 As System.Windows.Forms.Label
    Friend WithEvents Tab区分明細 As System.Windows.Forms.TabPage
    Friend WithEvents btn登録_明細 As System.Windows.Forms.Button
    Friend WithEvents dgv区分明細 As System.Windows.Forms.DataGridView
    Friend WithEvents txtコード_区分明細 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt内容_区分明細 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb区分_区分明細 As System.Windows.Forms.ComboBox
    Friend WithEvents txt備考_区分明細 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk削除_区分明細 As System.Windows.Forms.CheckBox
    Friend WithEvents btn新規 As System.Windows.Forms.Button
    Friend WithEvents btn新規_明細 As Button
    Friend WithEvents colID_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col区分_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col区分名_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col備考_区分 As DataGridViewTextBoxColumn
    Friend WithEvents colID_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col区分_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents colコード_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col内容_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col備考_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col削除_区分明細 As DataGridViewTextBoxColumn
End Class
