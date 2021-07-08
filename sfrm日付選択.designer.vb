<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrm日付選択
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn今日 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthCalendar
        '
        Me.MonthCalendar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.MonthCalendar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.MonthCalendar.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MonthCalendar.Location = New System.Drawing.Point(10, 10)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.ShowToday = False
        Me.MonthCalendar.ShowTodayCircle = False
        Me.MonthCalendar.TabIndex = 0
        Me.MonthCalendar.TitleBackColor = System.Drawing.Color.SlateBlue
        Me.MonthCalendar.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(83, 260)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 28)
        Me.btn_Exit.TabIndex = 1
        Me.btn_Exit.Text = "閉じる"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn今日
        '
        Me.btn今日.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn今日.BackColor = System.Drawing.SystemColors.Control
        Me.btn今日.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn今日.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn今日.Location = New System.Drawing.Point(12, 259)
        Me.btn今日.Name = "btn今日"
        Me.btn今日.Size = New System.Drawing.Size(42, 28)
        Me.btn今日.TabIndex = 2
        Me.btn今日.Text = "今日"
        Me.btn今日.UseVisualStyleBackColor = False
        '
        'sfrm日付選択
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CancelButton = Me.btn_Exit
        Me.ClientSize = New System.Drawing.Size(311, 299)
        Me.Controls.Add(Me.btn今日)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.MonthCalendar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrm日付選択"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "カレンダー"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn今日 As System.Windows.Forms.Button
End Class
