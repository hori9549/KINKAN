<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmL勤怠登録
    ''Inherits System.Windows.Forms.Form
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmL勤怠登録))
        Me.lblバージョン = New System.Windows.Forms.Label()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.tim時間 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl施設 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col日付 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn26 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn49 = New System.Windows.Forms.Button()
        Me.btn48 = New System.Windows.Forms.Button()
        Me.btn47 = New System.Windows.Forms.Button()
        Me.btn46 = New System.Windows.Forms.Button()
        Me.btn45 = New System.Windows.Forms.Button()
        Me.btn44 = New System.Windows.Forms.Button()
        Me.btn43 = New System.Windows.Forms.Button()
        Me.btn42 = New System.Windows.Forms.Button()
        Me.btn41 = New System.Windows.Forms.Button()
        Me.btn40 = New System.Windows.Forms.Button()
        Me.btn39 = New System.Windows.Forms.Button()
        Me.btn38 = New System.Windows.Forms.Button()
        Me.btn37 = New System.Windows.Forms.Button()
        Me.btn36 = New System.Windows.Forms.Button()
        Me.btn35 = New System.Windows.Forms.Button()
        Me.btn34 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.btn32 = New System.Windows.Forms.Button()
        Me.btn31 = New System.Windows.Forms.Button()
        Me.btn30 = New System.Windows.Forms.Button()
        Me.btn29 = New System.Windows.Forms.Button()
        Me.btn28 = New System.Windows.Forms.Button()
        Me.btn27 = New System.Windows.Forms.Button()
        Me.btn25 = New System.Windows.Forms.Button()
        Me.btn24 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn19 = New System.Windows.Forms.Button()
        Me.btn18 = New System.Windows.Forms.Button()
        Me.btn17 = New System.Windows.Forms.Button()
        Me.btn16 = New System.Windows.Forms.Button()
        Me.btn15 = New System.Windows.Forms.Button()
        Me.btn14 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn超過勤務届 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblバージョン
        '
        Me.lblバージョン.AutoSize = True
        Me.lblバージョン.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblバージョン.Location = New System.Drawing.Point(78, 150)
        Me.lblバージョン.Name = "lblバージョン"
        Me.lblバージョン.Size = New System.Drawing.Size(93, 19)
        Me.lblバージョン.TabIndex = 6
        Me.lblバージョン.Text = "ver 0.0.0.0"
        '
        'lbl日付
        '
        Me.lbl日付.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(744, 9)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(231, 40)
        Me.lbl日付.TabIndex = 2
        Me.lbl日付.Text = "yyyy/mm/dd"
        '
        'lbl時間
        '
        Me.lbl時間.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl時間.Location = New System.Drawing.Point(1026, 9)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(135, 40)
        Me.lbl時間.TabIndex = 3
        Me.lbl時間.Text = "HH:mm"
        '
        'tim時間
        '
        Me.tim時間.Interval = 30
        '
        'lbl施設
        '
        Me.lbl施設.AutoSize = True
        Me.lbl施設.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl施設.Location = New System.Drawing.Point(236, 9)
        Me.lbl施設.Name = "lbl施設"
        Me.lbl施設.Size = New System.Drawing.Size(97, 40)
        Me.lbl施設.TabIndex = 0
        Me.lbl施設.Text = "施設"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.BackgroundColor = System.Drawing.Color.White
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.ColumnHeadersVisible = False
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col施設ID, Me.col日付, Me.col開始時間, Me.col終了時間, Me.col予定})
        Me.dgv一覧.Location = New System.Drawing.Point(243, 52)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(918, 107)
        Me.dgv一覧.TabIndex = 4
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
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col開始時間.DefaultCellStyle = DataGridViewCellStyle3
        Me.col開始時間.HeaderText = "開始"
        Me.col開始時間.Name = "col開始時間"
        Me.col開始時間.ReadOnly = True
        '
        'col終了時間
        '
        Me.col終了時間.DataPropertyName = "終了時間"
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col終了時間.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.col予定.Width = 690
        '
        'btn26
        '
        Me.btn26.BackgroundImage = CType(resources.GetObject("btn26.BackgroundImage"), System.Drawing.Image)
        Me.btn26.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn26.ForeColor = System.Drawing.Color.Red
        Me.btn26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn26.Location = New System.Drawing.Point(474, 419)
        Me.btn26.Name = "btn26"
        Me.btn26.Size = New System.Drawing.Size(225, 50)
        Me.btn26.TabIndex = 109
        Me.btn26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn26.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.BackgroundImage = CType(resources.GetObject("btn50.BackgroundImage"), System.Drawing.Image)
        Me.btn50.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn50.ForeColor = System.Drawing.Color.Red
        Me.btn50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50.Location = New System.Drawing.Point(936, 619)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(225, 50)
        Me.btn50.TabIndex = 56
        Me.btn50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn49
        '
        Me.btn49.BackgroundImage = CType(resources.GetObject("btn49.BackgroundImage"), System.Drawing.Image)
        Me.btn49.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn49.ForeColor = System.Drawing.Color.Red
        Me.btn49.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn49.Location = New System.Drawing.Point(936, 569)
        Me.btn49.Name = "btn49"
        Me.btn49.Size = New System.Drawing.Size(225, 50)
        Me.btn49.TabIndex = 55
        Me.btn49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn49.UseVisualStyleBackColor = True
        '
        'btn48
        '
        Me.btn48.BackgroundImage = CType(resources.GetObject("btn48.BackgroundImage"), System.Drawing.Image)
        Me.btn48.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn48.ForeColor = System.Drawing.Color.Red
        Me.btn48.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn48.Location = New System.Drawing.Point(936, 519)
        Me.btn48.Name = "btn48"
        Me.btn48.Size = New System.Drawing.Size(225, 50)
        Me.btn48.TabIndex = 54
        Me.btn48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn48.UseVisualStyleBackColor = True
        '
        'btn47
        '
        Me.btn47.BackgroundImage = CType(resources.GetObject("btn47.BackgroundImage"), System.Drawing.Image)
        Me.btn47.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn47.ForeColor = System.Drawing.Color.Red
        Me.btn47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn47.Location = New System.Drawing.Point(936, 469)
        Me.btn47.Name = "btn47"
        Me.btn47.Size = New System.Drawing.Size(225, 50)
        Me.btn47.TabIndex = 53
        Me.btn47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn47.UseVisualStyleBackColor = True
        '
        'btn46
        '
        Me.btn46.BackgroundImage = CType(resources.GetObject("btn46.BackgroundImage"), System.Drawing.Image)
        Me.btn46.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn46.ForeColor = System.Drawing.Color.Red
        Me.btn46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn46.Location = New System.Drawing.Point(936, 419)
        Me.btn46.Name = "btn46"
        Me.btn46.Size = New System.Drawing.Size(225, 50)
        Me.btn46.TabIndex = 52
        Me.btn46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn46.UseVisualStyleBackColor = True
        '
        'btn45
        '
        Me.btn45.BackgroundImage = CType(resources.GetObject("btn45.BackgroundImage"), System.Drawing.Image)
        Me.btn45.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn45.ForeColor = System.Drawing.Color.Red
        Me.btn45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn45.Location = New System.Drawing.Point(936, 369)
        Me.btn45.Name = "btn45"
        Me.btn45.Size = New System.Drawing.Size(225, 50)
        Me.btn45.TabIndex = 51
        Me.btn45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn45.UseVisualStyleBackColor = True
        '
        'btn44
        '
        Me.btn44.BackgroundImage = CType(resources.GetObject("btn44.BackgroundImage"), System.Drawing.Image)
        Me.btn44.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn44.ForeColor = System.Drawing.Color.Red
        Me.btn44.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn44.Location = New System.Drawing.Point(936, 319)
        Me.btn44.Name = "btn44"
        Me.btn44.Size = New System.Drawing.Size(225, 50)
        Me.btn44.TabIndex = 50
        Me.btn44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn44.UseVisualStyleBackColor = True
        '
        'btn43
        '
        Me.btn43.BackgroundImage = CType(resources.GetObject("btn43.BackgroundImage"), System.Drawing.Image)
        Me.btn43.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn43.ForeColor = System.Drawing.Color.Red
        Me.btn43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn43.Location = New System.Drawing.Point(936, 269)
        Me.btn43.Name = "btn43"
        Me.btn43.Size = New System.Drawing.Size(225, 50)
        Me.btn43.TabIndex = 49
        Me.btn43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn43.UseVisualStyleBackColor = True
        '
        'btn42
        '
        Me.btn42.BackgroundImage = CType(resources.GetObject("btn42.BackgroundImage"), System.Drawing.Image)
        Me.btn42.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn42.ForeColor = System.Drawing.Color.Red
        Me.btn42.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn42.Location = New System.Drawing.Point(936, 219)
        Me.btn42.Name = "btn42"
        Me.btn42.Size = New System.Drawing.Size(225, 50)
        Me.btn42.TabIndex = 48
        Me.btn42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn42.UseVisualStyleBackColor = True
        '
        'btn41
        '
        Me.btn41.BackgroundImage = CType(resources.GetObject("btn41.BackgroundImage"), System.Drawing.Image)
        Me.btn41.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn41.ForeColor = System.Drawing.Color.Red
        Me.btn41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn41.Location = New System.Drawing.Point(936, 169)
        Me.btn41.Name = "btn41"
        Me.btn41.Size = New System.Drawing.Size(225, 50)
        Me.btn41.TabIndex = 47
        Me.btn41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn41.UseVisualStyleBackColor = True
        '
        'btn40
        '
        Me.btn40.BackgroundImage = CType(resources.GetObject("btn40.BackgroundImage"), System.Drawing.Image)
        Me.btn40.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn40.ForeColor = System.Drawing.Color.Red
        Me.btn40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40.Location = New System.Drawing.Point(705, 619)
        Me.btn40.Name = "btn40"
        Me.btn40.Size = New System.Drawing.Size(225, 50)
        Me.btn40.TabIndex = 46
        Me.btn40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn40.UseVisualStyleBackColor = True
        '
        'btn39
        '
        Me.btn39.BackgroundImage = CType(resources.GetObject("btn39.BackgroundImage"), System.Drawing.Image)
        Me.btn39.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn39.ForeColor = System.Drawing.Color.Red
        Me.btn39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn39.Location = New System.Drawing.Point(705, 569)
        Me.btn39.Name = "btn39"
        Me.btn39.Size = New System.Drawing.Size(225, 50)
        Me.btn39.TabIndex = 45
        Me.btn39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn39.UseVisualStyleBackColor = True
        '
        'btn38
        '
        Me.btn38.BackgroundImage = CType(resources.GetObject("btn38.BackgroundImage"), System.Drawing.Image)
        Me.btn38.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn38.ForeColor = System.Drawing.Color.Red
        Me.btn38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn38.Location = New System.Drawing.Point(705, 519)
        Me.btn38.Name = "btn38"
        Me.btn38.Size = New System.Drawing.Size(225, 50)
        Me.btn38.TabIndex = 44
        Me.btn38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn38.UseVisualStyleBackColor = True
        '
        'btn37
        '
        Me.btn37.BackgroundImage = CType(resources.GetObject("btn37.BackgroundImage"), System.Drawing.Image)
        Me.btn37.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn37.ForeColor = System.Drawing.Color.Red
        Me.btn37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn37.Location = New System.Drawing.Point(705, 469)
        Me.btn37.Name = "btn37"
        Me.btn37.Size = New System.Drawing.Size(225, 50)
        Me.btn37.TabIndex = 43
        Me.btn37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn37.UseVisualStyleBackColor = True
        '
        'btn36
        '
        Me.btn36.BackgroundImage = CType(resources.GetObject("btn36.BackgroundImage"), System.Drawing.Image)
        Me.btn36.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn36.ForeColor = System.Drawing.Color.Red
        Me.btn36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn36.Location = New System.Drawing.Point(705, 419)
        Me.btn36.Name = "btn36"
        Me.btn36.Size = New System.Drawing.Size(225, 50)
        Me.btn36.TabIndex = 42
        Me.btn36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn36.UseVisualStyleBackColor = True
        '
        'btn35
        '
        Me.btn35.BackgroundImage = CType(resources.GetObject("btn35.BackgroundImage"), System.Drawing.Image)
        Me.btn35.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn35.ForeColor = System.Drawing.Color.Red
        Me.btn35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn35.Location = New System.Drawing.Point(705, 369)
        Me.btn35.Name = "btn35"
        Me.btn35.Size = New System.Drawing.Size(225, 50)
        Me.btn35.TabIndex = 41
        Me.btn35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn35.UseVisualStyleBackColor = True
        '
        'btn34
        '
        Me.btn34.BackgroundImage = CType(resources.GetObject("btn34.BackgroundImage"), System.Drawing.Image)
        Me.btn34.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn34.ForeColor = System.Drawing.Color.Red
        Me.btn34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn34.Location = New System.Drawing.Point(705, 319)
        Me.btn34.Name = "btn34"
        Me.btn34.Size = New System.Drawing.Size(225, 50)
        Me.btn34.TabIndex = 40
        Me.btn34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn34.UseVisualStyleBackColor = True
        '
        'btn33
        '
        Me.btn33.BackgroundImage = CType(resources.GetObject("btn33.BackgroundImage"), System.Drawing.Image)
        Me.btn33.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn33.ForeColor = System.Drawing.Color.Red
        Me.btn33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn33.Location = New System.Drawing.Point(705, 269)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(225, 50)
        Me.btn33.TabIndex = 39
        Me.btn33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn33.UseVisualStyleBackColor = True
        '
        'btn32
        '
        Me.btn32.BackgroundImage = CType(resources.GetObject("btn32.BackgroundImage"), System.Drawing.Image)
        Me.btn32.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn32.ForeColor = System.Drawing.Color.Red
        Me.btn32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn32.Location = New System.Drawing.Point(705, 219)
        Me.btn32.Name = "btn32"
        Me.btn32.Size = New System.Drawing.Size(225, 50)
        Me.btn32.TabIndex = 38
        Me.btn32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn32.UseVisualStyleBackColor = True
        '
        'btn31
        '
        Me.btn31.BackgroundImage = CType(resources.GetObject("btn31.BackgroundImage"), System.Drawing.Image)
        Me.btn31.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn31.ForeColor = System.Drawing.Color.Red
        Me.btn31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn31.Location = New System.Drawing.Point(705, 169)
        Me.btn31.Name = "btn31"
        Me.btn31.Size = New System.Drawing.Size(225, 50)
        Me.btn31.TabIndex = 37
        Me.btn31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn31.UseVisualStyleBackColor = True
        '
        'btn30
        '
        Me.btn30.BackgroundImage = CType(resources.GetObject("btn30.BackgroundImage"), System.Drawing.Image)
        Me.btn30.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn30.ForeColor = System.Drawing.Color.Red
        Me.btn30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30.Location = New System.Drawing.Point(474, 619)
        Me.btn30.Name = "btn30"
        Me.btn30.Size = New System.Drawing.Size(225, 50)
        Me.btn30.TabIndex = 36
        Me.btn30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn30.UseVisualStyleBackColor = True
        '
        'btn29
        '
        Me.btn29.BackgroundImage = CType(resources.GetObject("btn29.BackgroundImage"), System.Drawing.Image)
        Me.btn29.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn29.ForeColor = System.Drawing.Color.Red
        Me.btn29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn29.Location = New System.Drawing.Point(474, 569)
        Me.btn29.Name = "btn29"
        Me.btn29.Size = New System.Drawing.Size(225, 50)
        Me.btn29.TabIndex = 35
        Me.btn29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn29.UseVisualStyleBackColor = True
        '
        'btn28
        '
        Me.btn28.BackgroundImage = CType(resources.GetObject("btn28.BackgroundImage"), System.Drawing.Image)
        Me.btn28.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn28.ForeColor = System.Drawing.Color.Red
        Me.btn28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn28.Location = New System.Drawing.Point(474, 519)
        Me.btn28.Name = "btn28"
        Me.btn28.Size = New System.Drawing.Size(225, 50)
        Me.btn28.TabIndex = 34
        Me.btn28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn28.UseVisualStyleBackColor = True
        '
        'btn27
        '
        Me.btn27.BackgroundImage = CType(resources.GetObject("btn27.BackgroundImage"), System.Drawing.Image)
        Me.btn27.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn27.ForeColor = System.Drawing.Color.Red
        Me.btn27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn27.Location = New System.Drawing.Point(474, 469)
        Me.btn27.Name = "btn27"
        Me.btn27.Size = New System.Drawing.Size(225, 50)
        Me.btn27.TabIndex = 33
        Me.btn27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn27.UseVisualStyleBackColor = True
        '
        'btn25
        '
        Me.btn25.BackgroundImage = CType(resources.GetObject("btn25.BackgroundImage"), System.Drawing.Image)
        Me.btn25.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn25.ForeColor = System.Drawing.Color.Red
        Me.btn25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn25.Location = New System.Drawing.Point(474, 369)
        Me.btn25.Name = "btn25"
        Me.btn25.Size = New System.Drawing.Size(225, 50)
        Me.btn25.TabIndex = 31
        Me.btn25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn25.UseVisualStyleBackColor = True
        '
        'btn24
        '
        Me.btn24.BackgroundImage = CType(resources.GetObject("btn24.BackgroundImage"), System.Drawing.Image)
        Me.btn24.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn24.ForeColor = System.Drawing.Color.Red
        Me.btn24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn24.Location = New System.Drawing.Point(474, 319)
        Me.btn24.Name = "btn24"
        Me.btn24.Size = New System.Drawing.Size(225, 50)
        Me.btn24.TabIndex = 30
        Me.btn24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn24.UseVisualStyleBackColor = True
        '
        'btn23
        '
        Me.btn23.BackgroundImage = CType(resources.GetObject("btn23.BackgroundImage"), System.Drawing.Image)
        Me.btn23.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn23.ForeColor = System.Drawing.Color.Red
        Me.btn23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn23.Location = New System.Drawing.Point(474, 269)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(225, 50)
        Me.btn23.TabIndex = 29
        Me.btn23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn23.UseVisualStyleBackColor = True
        '
        'btn22
        '
        Me.btn22.BackgroundImage = CType(resources.GetObject("btn22.BackgroundImage"), System.Drawing.Image)
        Me.btn22.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn22.ForeColor = System.Drawing.Color.Red
        Me.btn22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn22.Location = New System.Drawing.Point(474, 219)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(225, 50)
        Me.btn22.TabIndex = 28
        Me.btn22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn22.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.BackgroundImage = CType(resources.GetObject("btn21.BackgroundImage"), System.Drawing.Image)
        Me.btn21.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn21.ForeColor = System.Drawing.Color.Red
        Me.btn21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn21.Location = New System.Drawing.Point(474, 169)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(225, 50)
        Me.btn21.TabIndex = 27
        Me.btn21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn21.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.BackgroundImage = CType(resources.GetObject("btn20.BackgroundImage"), System.Drawing.Image)
        Me.btn20.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn20.ForeColor = System.Drawing.Color.Red
        Me.btn20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20.Location = New System.Drawing.Point(243, 619)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(225, 50)
        Me.btn20.TabIndex = 26
        Me.btn20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn19
        '
        Me.btn19.BackgroundImage = CType(resources.GetObject("btn19.BackgroundImage"), System.Drawing.Image)
        Me.btn19.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn19.ForeColor = System.Drawing.Color.Red
        Me.btn19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn19.Location = New System.Drawing.Point(243, 569)
        Me.btn19.Name = "btn19"
        Me.btn19.Size = New System.Drawing.Size(225, 50)
        Me.btn19.TabIndex = 25
        Me.btn19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn19.UseVisualStyleBackColor = True
        '
        'btn18
        '
        Me.btn18.BackgroundImage = CType(resources.GetObject("btn18.BackgroundImage"), System.Drawing.Image)
        Me.btn18.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn18.ForeColor = System.Drawing.Color.Red
        Me.btn18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn18.Location = New System.Drawing.Point(243, 519)
        Me.btn18.Name = "btn18"
        Me.btn18.Size = New System.Drawing.Size(225, 50)
        Me.btn18.TabIndex = 24
        Me.btn18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn18.UseVisualStyleBackColor = True
        '
        'btn17
        '
        Me.btn17.BackgroundImage = CType(resources.GetObject("btn17.BackgroundImage"), System.Drawing.Image)
        Me.btn17.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn17.ForeColor = System.Drawing.Color.Red
        Me.btn17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn17.Location = New System.Drawing.Point(243, 469)
        Me.btn17.Name = "btn17"
        Me.btn17.Size = New System.Drawing.Size(225, 50)
        Me.btn17.TabIndex = 23
        Me.btn17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn17.UseVisualStyleBackColor = True
        '
        'btn16
        '
        Me.btn16.BackgroundImage = CType(resources.GetObject("btn16.BackgroundImage"), System.Drawing.Image)
        Me.btn16.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn16.ForeColor = System.Drawing.Color.Red
        Me.btn16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn16.Location = New System.Drawing.Point(243, 419)
        Me.btn16.Name = "btn16"
        Me.btn16.Size = New System.Drawing.Size(225, 50)
        Me.btn16.TabIndex = 22
        Me.btn16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn16.UseVisualStyleBackColor = True
        '
        'btn15
        '
        Me.btn15.BackgroundImage = CType(resources.GetObject("btn15.BackgroundImage"), System.Drawing.Image)
        Me.btn15.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn15.ForeColor = System.Drawing.Color.Red
        Me.btn15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn15.Location = New System.Drawing.Point(243, 369)
        Me.btn15.Name = "btn15"
        Me.btn15.Size = New System.Drawing.Size(225, 50)
        Me.btn15.TabIndex = 21
        Me.btn15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn15.UseVisualStyleBackColor = True
        '
        'btn14
        '
        Me.btn14.BackgroundImage = CType(resources.GetObject("btn14.BackgroundImage"), System.Drawing.Image)
        Me.btn14.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn14.ForeColor = System.Drawing.Color.Red
        Me.btn14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn14.Location = New System.Drawing.Point(243, 319)
        Me.btn14.Name = "btn14"
        Me.btn14.Size = New System.Drawing.Size(225, 50)
        Me.btn14.TabIndex = 20
        Me.btn14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn14.UseVisualStyleBackColor = True
        '
        'btn13
        '
        Me.btn13.BackgroundImage = CType(resources.GetObject("btn13.BackgroundImage"), System.Drawing.Image)
        Me.btn13.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn13.ForeColor = System.Drawing.Color.Red
        Me.btn13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn13.Location = New System.Drawing.Point(243, 269)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(225, 50)
        Me.btn13.TabIndex = 19
        Me.btn13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn13.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.BackgroundImage = CType(resources.GetObject("btn12.BackgroundImage"), System.Drawing.Image)
        Me.btn12.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn12.ForeColor = System.Drawing.Color.Red
        Me.btn12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn12.Location = New System.Drawing.Point(243, 219)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(225, 50)
        Me.btn12.TabIndex = 18
        Me.btn12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn11
        '
        Me.btn11.BackgroundImage = CType(resources.GetObject("btn11.BackgroundImage"), System.Drawing.Image)
        Me.btn11.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn11.ForeColor = System.Drawing.Color.Red
        Me.btn11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn11.Location = New System.Drawing.Point(243, 169)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(225, 50)
        Me.btn11.TabIndex = 17
        Me.btn11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.BackgroundImage = CType(resources.GetObject("btn10.BackgroundImage"), System.Drawing.Image)
        Me.btn10.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn10.ForeColor = System.Drawing.Color.Red
        Me.btn10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10.Location = New System.Drawing.Point(12, 619)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(225, 50)
        Me.btn10.TabIndex = 16
        Me.btn10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.BackgroundImage = CType(resources.GetObject("btn9.BackgroundImage"), System.Drawing.Image)
        Me.btn9.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Red
        Me.btn9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn9.Location = New System.Drawing.Point(12, 569)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(225, 50)
        Me.btn9.TabIndex = 15
        Me.btn9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.BackgroundImage = CType(resources.GetObject("btn8.BackgroundImage"), System.Drawing.Image)
        Me.btn8.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Red
        Me.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn8.Location = New System.Drawing.Point(12, 519)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(225, 50)
        Me.btn8.TabIndex = 14
        Me.btn8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.BackgroundImage = CType(resources.GetObject("btn7.BackgroundImage"), System.Drawing.Image)
        Me.btn7.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Red
        Me.btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn7.Location = New System.Drawing.Point(12, 469)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(225, 50)
        Me.btn7.TabIndex = 13
        Me.btn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.BackgroundImage = CType(resources.GetObject("btn6.BackgroundImage"), System.Drawing.Image)
        Me.btn6.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Red
        Me.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn6.Location = New System.Drawing.Point(12, 419)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(225, 50)
        Me.btn6.TabIndex = 12
        Me.btn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Red
        Me.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5.Location = New System.Drawing.Point(12, 369)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(225, 50)
        Me.btn5.TabIndex = 11
        Me.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Red
        Me.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.Location = New System.Drawing.Point(12, 319)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(225, 50)
        Me.btn4.TabIndex = 10
        Me.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Red
        Me.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.Location = New System.Drawing.Point(12, 269)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(225, 50)
        Me.btn3.TabIndex = 9
        Me.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Red
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.Location = New System.Drawing.Point(12, 219)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(225, 50)
        Me.btn2.TabIndex = 8
        Me.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Red
        Me.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.Location = New System.Drawing.Point(12, 169)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(225, 50)
        Me.btn1.TabIndex = 7
        Me.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.UseVisualStyleBackColor = True
        '
        'picImg
        '
        Me.picImg.Image = Global.KINKAN.My.Resources.Resources.きんかんタイトル
        Me.picImg.InitialImage = Nothing
        Me.picImg.Location = New System.Drawing.Point(50, 9)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(146, 150)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 108
        Me.picImg.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(474, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(225, 50)
        Me.Button2.TabIndex = 28
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(474, 275)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(225, 50)
        Me.Button3.TabIndex = 29
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(474, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(225, 50)
        Me.Button4.TabIndex = 30
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Red
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(474, 625)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(225, 50)
        Me.Button10.TabIndex = 36
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Red
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(474, 575)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(225, 50)
        Me.Button9.TabIndex = 35
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(474, 525)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(225, 50)
        Me.Button8.TabIndex = 34
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(474, 475)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(225, 50)
        Me.Button7.TabIndex = 33
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn超過勤務届
        '
        Me.btn超過勤務届.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn超過勤務届.ForeColor = System.Drawing.Color.Blue
        Me.btn超過勤務届.Location = New System.Drawing.Point(13, 673)
        Me.btn超過勤務届.Name = "btn超過勤務届"
        Me.btn超過勤務届.Size = New System.Drawing.Size(224, 41)
        Me.btn超過勤務届.TabIndex = 110
        Me.btn超過勤務届.Text = "超過勤務届"
        Me.btn超過勤務届.UseVisualStyleBackColor = True
        '
        'frmL勤怠登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.btn超過勤務届)
        Me.Controls.Add(Me.btn26)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn49)
        Me.Controls.Add(Me.btn48)
        Me.Controls.Add(Me.btn47)
        Me.Controls.Add(Me.btn46)
        Me.Controls.Add(Me.btn45)
        Me.Controls.Add(Me.btn44)
        Me.Controls.Add(Me.btn43)
        Me.Controls.Add(Me.btn42)
        Me.Controls.Add(Me.btn41)
        Me.Controls.Add(Me.btn40)
        Me.Controls.Add(Me.btn39)
        Me.Controls.Add(Me.btn38)
        Me.Controls.Add(Me.btn37)
        Me.Controls.Add(Me.btn36)
        Me.Controls.Add(Me.btn35)
        Me.Controls.Add(Me.btn34)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn32)
        Me.Controls.Add(Me.btn31)
        Me.Controls.Add(Me.btn30)
        Me.Controls.Add(Me.btn29)
        Me.Controls.Add(Me.btn28)
        Me.Controls.Add(Me.btn27)
        Me.Controls.Add(Me.btn25)
        Me.Controls.Add(Me.btn24)
        Me.Controls.Add(Me.btn23)
        Me.Controls.Add(Me.btn22)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.btn19)
        Me.Controls.Add(Me.btn18)
        Me.Controls.Add(Me.btn17)
        Me.Controls.Add(Me.btn16)
        Me.Controls.Add(Me.btn15)
        Me.Controls.Add(Me.btn14)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl施設)
        Me.Controls.Add(Me.lbl時間)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.lblバージョン)
        Me.Controls.Add(Me.picImg)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmL勤怠登録"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "きんかん"
        Me.Controls.SetChildIndex(Me.picImg, 0)
        Me.Controls.SetChildIndex(Me.lblバージョン, 0)
        Me.Controls.SetChildIndex(Me.lbl日付, 0)
        Me.Controls.SetChildIndex(Me.lbl時間, 0)
        Me.Controls.SetChildIndex(Me.lbl施設, 0)
        Me.Controls.SetChildIndex(Me.btn1, 0)
        Me.Controls.SetChildIndex(Me.btn2, 0)
        Me.Controls.SetChildIndex(Me.btn3, 0)
        Me.Controls.SetChildIndex(Me.btn4, 0)
        Me.Controls.SetChildIndex(Me.btn5, 0)
        Me.Controls.SetChildIndex(Me.btn6, 0)
        Me.Controls.SetChildIndex(Me.btn7, 0)
        Me.Controls.SetChildIndex(Me.btn8, 0)
        Me.Controls.SetChildIndex(Me.btn9, 0)
        Me.Controls.SetChildIndex(Me.btn10, 0)
        Me.Controls.SetChildIndex(Me.btn11, 0)
        Me.Controls.SetChildIndex(Me.btn12, 0)
        Me.Controls.SetChildIndex(Me.btn13, 0)
        Me.Controls.SetChildIndex(Me.btn14, 0)
        Me.Controls.SetChildIndex(Me.btn15, 0)
        Me.Controls.SetChildIndex(Me.btn16, 0)
        Me.Controls.SetChildIndex(Me.btn17, 0)
        Me.Controls.SetChildIndex(Me.btn18, 0)
        Me.Controls.SetChildIndex(Me.btn19, 0)
        Me.Controls.SetChildIndex(Me.btn20, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.btn21, 0)
        Me.Controls.SetChildIndex(Me.btn22, 0)
        Me.Controls.SetChildIndex(Me.btn23, 0)
        Me.Controls.SetChildIndex(Me.btn24, 0)
        Me.Controls.SetChildIndex(Me.btn25, 0)
        Me.Controls.SetChildIndex(Me.btn27, 0)
        Me.Controls.SetChildIndex(Me.btn28, 0)
        Me.Controls.SetChildIndex(Me.btn29, 0)
        Me.Controls.SetChildIndex(Me.btn30, 0)
        Me.Controls.SetChildIndex(Me.btn31, 0)
        Me.Controls.SetChildIndex(Me.btn32, 0)
        Me.Controls.SetChildIndex(Me.btn33, 0)
        Me.Controls.SetChildIndex(Me.btn34, 0)
        Me.Controls.SetChildIndex(Me.btn35, 0)
        Me.Controls.SetChildIndex(Me.btn36, 0)
        Me.Controls.SetChildIndex(Me.btn37, 0)
        Me.Controls.SetChildIndex(Me.btn38, 0)
        Me.Controls.SetChildIndex(Me.btn39, 0)
        Me.Controls.SetChildIndex(Me.btn40, 0)
        Me.Controls.SetChildIndex(Me.btn41, 0)
        Me.Controls.SetChildIndex(Me.btn42, 0)
        Me.Controls.SetChildIndex(Me.btn43, 0)
        Me.Controls.SetChildIndex(Me.btn44, 0)
        Me.Controls.SetChildIndex(Me.btn45, 0)
        Me.Controls.SetChildIndex(Me.btn46, 0)
        Me.Controls.SetChildIndex(Me.btn47, 0)
        Me.Controls.SetChildIndex(Me.btn48, 0)
        Me.Controls.SetChildIndex(Me.btn49, 0)
        Me.Controls.SetChildIndex(Me.btn50, 0)
        Me.Controls.SetChildIndex(Me.btn26, 0)
        Me.Controls.SetChildIndex(Me.btn超過勤務届, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblバージョン As Label
    Public WithEvents picImg As PictureBox
    Friend WithEvents lbl日付 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents tim時間 As Timer
    Friend WithEvents lbl施設 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn11 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn13 As Button
    Friend WithEvents btn14 As Button
    Friend WithEvents btn15 As Button
    Friend WithEvents btn16 As Button
    Friend WithEvents btn17 As Button
    Friend WithEvents btn18 As Button
    Friend WithEvents btn19 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn21 As Button
    Friend WithEvents btn22 As Button
    Friend WithEvents btn23 As Button
    Friend WithEvents btn24 As Button
    Friend WithEvents btn25 As Button
    Friend WithEvents btn27 As Button
    Friend WithEvents btn28 As Button
    Friend WithEvents btn29 As Button
    Friend WithEvents btn30 As Button
    Friend WithEvents btn31 As Button
    Friend WithEvents btn32 As Button
    Friend WithEvents btn33 As Button
    Friend WithEvents btn34 As Button
    Friend WithEvents btn35 As Button
    Friend WithEvents btn36 As Button
    Friend WithEvents btn37 As Button
    Friend WithEvents btn38 As Button
    Friend WithEvents btn39 As Button
    Friend WithEvents btn40 As Button
    Friend WithEvents btn41 As Button
    Friend WithEvents btn42 As Button
    Friend WithEvents btn43 As Button
    Friend WithEvents btn44 As Button
    Friend WithEvents btn45 As Button
    Friend WithEvents btn46 As Button
    Friend WithEvents btn47 As Button
    Friend WithEvents btn48 As Button
    Friend WithEvents btn49 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btn26 As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col日付 As DataGridViewTextBoxColumn
    Friend WithEvents col開始時間 As DataGridViewTextBoxColumn
    Friend WithEvents col終了時間 As DataGridViewTextBoxColumn
    Friend WithEvents col予定 As DataGridViewTextBoxColumn
    Friend WithEvents btn超過勤務届 As Button
End Class
