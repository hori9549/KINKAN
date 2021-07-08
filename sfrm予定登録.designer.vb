<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrm予定登録
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
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col日付 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btn追加 = New System.Windows.Forms.Button()
        Me.txt予定 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp終了時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp開始時間 = New System.Windows.Forms.DateTimePicker()
        Me.chk休日 = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btn前 = New System.Windows.Forms.Button()
        Me.btn次 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(44, 9)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(213, 27)
        Me.lbl日付.TabIndex = 0
        Me.lbl日付.Text = "yyyy/mm/dd（曜）"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col削除, Me.col日付, Me.col開始時間, Me.col終了時間, Me.col予定})
        Me.dgv一覧.Location = New System.Drawing.Point(6, 89)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(946, 376)
        Me.dgv一覧.TabIndex = 10
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
        'col開始時間
        '
        Me.col開始時間.DataPropertyName = "開始時間"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.col開始時間.DefaultCellStyle = DataGridViewCellStyle1
        Me.col開始時間.HeaderText = "開始"
        Me.col開始時間.Name = "col開始時間"
        Me.col開始時間.ReadOnly = True
        '
        'col終了時間
        '
        Me.col終了時間.DataPropertyName = "終了時間"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col終了時間.DefaultCellStyle = DataGridViewCellStyle2
        Me.col終了時間.HeaderText = "終了"
        Me.col終了時間.Name = "col終了時間"
        Me.col終了時間.ReadOnly = True
        '
        'col予定
        '
        Me.col予定.DataPropertyName = "予定"
        Me.col予定.HeaderText = "予定"
        Me.col予定.Name = "col予定"
        Me.col予定.ReadOnly = True
        Me.col予定.Width = 400
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "時間"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn新規)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.btn追加)
        Me.GroupBox1.Controls.Add(Me.txt予定)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp終了時間)
        Me.GroupBox1.Controls.Add(Me.dtp開始時間)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgv一覧)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 471)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "予定"
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
        Me.btn追加.Location = New System.Drawing.Point(827, 43)
        Me.btn追加.Name = "btn追加"
        Me.btn追加.Size = New System.Drawing.Size(125, 40)
        Me.btn追加.TabIndex = 9
        Me.btn追加.Text = "登録"
        Me.btn追加.UseVisualStyleBackColor = True
        '
        'txt予定
        '
        Me.txt予定.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt予定.Location = New System.Drawing.Point(71, 57)
        Me.txt予定.MaxLength = 50
        Me.txt予定.Name = "txt予定"
        Me.txt予定.Size = New System.Drawing.Size(614, 26)
        Me.txt予定.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "予定"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "～"
        '
        'dtp終了時間
        '
        Me.dtp終了時間.CustomFormat = "HH:mm"
        Me.dtp終了時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp終了時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp終了時間.Location = New System.Drawing.Point(312, 25)
        Me.dtp終了時間.Name = "dtp終了時間"
        Me.dtp終了時間.ShowUpDown = True
        Me.dtp終了時間.Size = New System.Drawing.Size(71, 26)
        Me.dtp終了時間.TabIndex = 6
        '
        'dtp開始時間
        '
        Me.dtp開始時間.CustomFormat = "HH:mm"
        Me.dtp開始時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp開始時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp開始時間.Location = New System.Drawing.Point(209, 25)
        Me.dtp開始時間.Name = "dtp開始時間"
        Me.dtp開始時間.ShowUpDown = True
        Me.dtp開始時間.Size = New System.Drawing.Size(71, 26)
        Me.dtp開始時間.TabIndex = 4
        '
        'chk休日
        '
        Me.chk休日.AutoSize = True
        Me.chk休日.Location = New System.Drawing.Point(312, 11)
        Me.chk休日.Name = "chk休日"
        Me.chk休日.Size = New System.Drawing.Size(66, 23)
        Me.chk休日.TabIndex = 1
        Me.chk休日.Text = "休日"
        Me.chk休日.UseVisualStyleBackColor = True
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
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btn前
        '
        Me.btn前.Location = New System.Drawing.Point(12, 9)
        Me.btn前.Name = "btn前"
        Me.btn前.Size = New System.Drawing.Size(26, 27)
        Me.btn前.TabIndex = 5
        Me.btn前.TabStop = False
        Me.btn前.Text = "<"
        Me.btn前.UseVisualStyleBackColor = True
        '
        'btn次
        '
        Me.btn次.Location = New System.Drawing.Point(263, 9)
        Me.btn次.Name = "btn次"
        Me.btn次.Size = New System.Drawing.Size(26, 27)
        Me.btn次.TabIndex = 6
        Me.btn次.TabStop = False
        Me.btn次.Text = ">"
        Me.btn次.UseVisualStyleBackColor = True
        '
        'sfrm予定登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btn次)
        Me.Controls.Add(Me.btn前)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chk休日)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "sfrm予定登録"
        Me.ShowInTaskbar = False
        Me.Text = "予定登録"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents dtp終了時間 As DateTimePicker
    Friend WithEvents dtp開始時間 As DateTimePicker
    Friend WithEvents chk休日 As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btn追加 As Button
    Friend WithEvents txt予定 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btn新規 As Button
    Friend WithEvents btn前 As Button
    Friend WithEvents btn次 As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col削除 As DataGridViewButtonColumn
    Friend WithEvents col日付 As DataGridViewTextBoxColumn
    Friend WithEvents col開始時間 As DataGridViewTextBoxColumn
    Friend WithEvents col終了時間 As DataGridViewTextBoxColumn
    Friend WithEvents col予定 As DataGridViewTextBoxColumn
End Class
