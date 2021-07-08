<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMシフト作成
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl年度 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtシフト年 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn作成 = New System.Windows.Forms.Button()
        Me.txtシフト月 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.dgvカレンダー = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col休日区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col施設ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col年度 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col年月日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定追加 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col曜日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl施設 = New System.Windows.Forms.Label()
        Me.btnシフト表 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvカレンダー, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl年度
        '
        Me.lbl年度.AutoSize = True
        Me.lbl年度.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl年度.Location = New System.Drawing.Point(25, 9)
        Me.lbl年度.Name = "lbl年度"
        Me.lbl年度.Size = New System.Drawing.Size(80, 27)
        Me.lbl年度.TabIndex = 0
        Me.lbl年度.Text = "YYYY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "年度"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtシフト年)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn作成)
        Me.GroupBox1.Controls.Add(Me.txtシフト月)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(738, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 59)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "シフト作成"
        '
        'txtシフト年
        '
        Me.txtシフト年.Location = New System.Drawing.Point(33, 24)
        Me.txtシフト年.Name = "txtシフト年"
        Me.txtシフト年.Size = New System.Drawing.Size(100, 26)
        Me.txtシフト年.TabIndex = 0
        Me.txtシフト年.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "年"
        '
        'btn作成
        '
        Me.btn作成.Location = New System.Drawing.Point(351, 18)
        Me.btn作成.Name = "btn作成"
        Me.btn作成.Size = New System.Drawing.Size(75, 35)
        Me.btn作成.TabIndex = 4
        Me.btn作成.Text = "作成"
        Me.btn作成.UseVisualStyleBackColor = True
        '
        'txtシフト月
        '
        Me.txtシフト月.Location = New System.Drawing.Point(193, 23)
        Me.txtシフト月.Name = "txtシフト月"
        Me.txtシフト月.Size = New System.Drawing.Size(66, 26)
        Me.txtシフト月.TabIndex = 2
        Me.txtシフト月.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "月"
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(17, 71)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(88, 39)
        Me.btn4.TabIndex = 4
        Me.btn4.TabStop = False
        Me.btn4.Tag = "4"
        Me.btn4.Text = "4月"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(105, 71)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(88, 39)
        Me.btn5.TabIndex = 5
        Me.btn5.TabStop = False
        Me.btn5.Tag = "5"
        Me.btn5.Text = "5月"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(193, 71)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(88, 39)
        Me.btn6.TabIndex = 6
        Me.btn6.TabStop = False
        Me.btn6.Tag = "6"
        Me.btn6.Text = "6月"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(281, 71)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(88, 39)
        Me.btn7.TabIndex = 7
        Me.btn7.TabStop = False
        Me.btn7.Tag = "7"
        Me.btn7.Text = "7月"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(369, 71)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(88, 39)
        Me.btn8.TabIndex = 8
        Me.btn8.TabStop = False
        Me.btn8.Tag = "8"
        Me.btn8.Text = "8月"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(457, 71)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(88, 39)
        Me.btn9.TabIndex = 9
        Me.btn9.TabStop = False
        Me.btn9.Tag = "9"
        Me.btn9.Text = "9月"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(545, 71)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(88, 39)
        Me.btn10.TabIndex = 10
        Me.btn10.TabStop = False
        Me.btn10.Tag = "10"
        Me.btn10.Text = "10月"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn11
        '
        Me.btn11.Location = New System.Drawing.Point(633, 71)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(88, 39)
        Me.btn11.TabIndex = 11
        Me.btn11.TabStop = False
        Me.btn11.Tag = "11"
        Me.btn11.Text = "11月"
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Location = New System.Drawing.Point(721, 71)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(88, 39)
        Me.btn12.TabIndex = 12
        Me.btn12.TabStop = False
        Me.btn12.Tag = "12"
        Me.btn12.Text = "12月"
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(809, 71)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(88, 39)
        Me.btn1.TabIndex = 13
        Me.btn1.TabStop = False
        Me.btn1.Tag = "1"
        Me.btn1.Text = "1月"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(897, 71)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(88, 39)
        Me.btn2.TabIndex = 14
        Me.btn2.TabStop = False
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2月"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(985, 71)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(88, 39)
        Me.btn3.TabIndex = 15
        Me.btn3.TabStop = False
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3月"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'dgvカレンダー
        '
        Me.dgvカレンダー.AllowUserToAddRows = False
        Me.dgvカレンダー.AllowUserToDeleteRows = False
        Me.dgvカレンダー.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvカレンダー.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvカレンダー.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvカレンダー.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col休日区分, Me.col施設ID, Me.col年度, Me.col年月日, Me.col予定追加, Me.col曜日, Me.col予定})
        Me.dgvカレンダー.Location = New System.Drawing.Point(14, 110)
        Me.dgvカレンダー.Name = "dgvカレンダー"
        Me.dgvカレンダー.ReadOnly = True
        Me.dgvカレンダー.RowHeadersVisible = False
        Me.dgvカレンダー.RowTemplate.Height = 30
        Me.dgvカレンダー.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvカレンダー.Size = New System.Drawing.Size(1156, 556)
        Me.dgvカレンダー.TabIndex = 16
        Me.dgvカレンダー.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'col休日区分
        '
        Me.col休日区分.DataPropertyName = "休日区分"
        Me.col休日区分.HeaderText = "休日"
        Me.col休日区分.Name = "col休日区分"
        Me.col休日区分.ReadOnly = True
        Me.col休日区分.Visible = False
        '
        'col施設ID
        '
        Me.col施設ID.DataPropertyName = "施設ID"
        Me.col施設ID.HeaderText = "施設ID"
        Me.col施設ID.Name = "col施設ID"
        Me.col施設ID.ReadOnly = True
        Me.col施設ID.Visible = False
        '
        'col年度
        '
        Me.col年度.DataPropertyName = "年度"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col年度.DefaultCellStyle = DataGridViewCellStyle6
        Me.col年度.HeaderText = "年度"
        Me.col年度.Name = "col年度"
        Me.col年度.ReadOnly = True
        Me.col年度.Visible = False
        Me.col年度.Width = 70
        '
        'col年月日
        '
        Me.col年月日.DataPropertyName = "年月日"
        DataGridViewCellStyle7.Format = "M"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.col年月日.DefaultCellStyle = DataGridViewCellStyle7
        Me.col年月日.HeaderText = "年月日"
        Me.col年月日.Name = "col年月日"
        Me.col年月日.ReadOnly = True
        Me.col年月日.Visible = False
        '
        'col予定追加
        '
        Me.col予定追加.DataPropertyName = "年月日"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "M"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.col予定追加.DefaultCellStyle = DataGridViewCellStyle8
        Me.col予定追加.HeaderText = "予定追加"
        Me.col予定追加.Name = "col予定追加"
        Me.col予定追加.ReadOnly = True
        Me.col予定追加.Width = 120
        '
        'col曜日
        '
        Me.col曜日.DataPropertyName = "曜日"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col曜日.DefaultCellStyle = DataGridViewCellStyle9
        Me.col曜日.HeaderText = "曜日"
        Me.col曜日.Name = "col曜日"
        Me.col曜日.ReadOnly = True
        Me.col曜日.Width = 75
        '
        'col予定
        '
        Me.col予定.DataPropertyName = "予定"
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col予定.DefaultCellStyle = DataGridViewCellStyle10
        Me.col予定.HeaderText = "シフト"
        Me.col予定.Name = "col予定"
        Me.col予定.ReadOnly = True
        Me.col予定.Width = 900
        '
        'lbl施設
        '
        Me.lbl施設.AutoSize = True
        Me.lbl施設.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl施設.Location = New System.Drawing.Point(188, 9)
        Me.lbl施設.Name = "lbl施設"
        Me.lbl施設.Size = New System.Drawing.Size(68, 27)
        Me.lbl施設.TabIndex = 2
        Me.lbl施設.Text = "施設"
        '
        'btnシフト表
        '
        Me.btnシフト表.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnシフト表.ForeColor = System.Drawing.Color.Green
        Me.btnシフト表.Location = New System.Drawing.Point(885, 674)
        Me.btnシフト表.Margin = New System.Windows.Forms.Padding(5)
        Me.btnシフト表.Name = "btnシフト表"
        Me.btnシフト表.Size = New System.Drawing.Size(125, 40)
        Me.btnシフト表.TabIndex = 103
        Me.btnシフト表.Text = "シフト表"
        Me.btnシフト表.UseVisualStyleBackColor = True
        '
        'frmMシフト作成
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.btnシフト表)
        Me.Controls.Add(Me.lbl施設)
        Me.Controls.Add(Me.dgvカレンダー)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl年度)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmMシフト作成"
        Me.Text = "シフト"
        Me.Controls.SetChildIndex(Me.lbl年度, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btn4, 0)
        Me.Controls.SetChildIndex(Me.btn5, 0)
        Me.Controls.SetChildIndex(Me.btn6, 0)
        Me.Controls.SetChildIndex(Me.btn7, 0)
        Me.Controls.SetChildIndex(Me.btn8, 0)
        Me.Controls.SetChildIndex(Me.btn9, 0)
        Me.Controls.SetChildIndex(Me.btn10, 0)
        Me.Controls.SetChildIndex(Me.btn11, 0)
        Me.Controls.SetChildIndex(Me.btn12, 0)
        Me.Controls.SetChildIndex(Me.btn1, 0)
        Me.Controls.SetChildIndex(Me.btn2, 0)
        Me.Controls.SetChildIndex(Me.btn3, 0)
        Me.Controls.SetChildIndex(Me.dgvカレンダー, 0)
        Me.Controls.SetChildIndex(Me.lbl施設, 0)
        Me.Controls.SetChildIndex(Me.btnシフト表, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvカレンダー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl年度 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn作成 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn11 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents dgvカレンダー As DataGridView
    Friend WithEvents lbl施設 As Label
    Friend WithEvents colID_区分 As DataGridViewTextBoxColumn
    Friend WithEvents txtシフト年 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtシフト月 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col休日区分 As DataGridViewTextBoxColumn
    Friend WithEvents col施設ID As DataGridViewTextBoxColumn
    Friend WithEvents col年度 As DataGridViewTextBoxColumn
    Friend WithEvents col年月日 As DataGridViewTextBoxColumn
    Friend WithEvents col予定追加 As DataGridViewButtonColumn
    Friend WithEvents col曜日 As DataGridViewTextBoxColumn
    Friend WithEvents col予定 As DataGridViewTextBoxColumn
    Friend WithEvents btnシフト表 As Button
End Class
