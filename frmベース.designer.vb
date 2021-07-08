<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmベース
    Inherits System.Windows.Forms.Form

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
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.stsベース = New System.Windows.Forms.StatusStrip()
        Me.slb施設名 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.spbベース = New System.Windows.Forms.ToolStripProgressBar()
        Me.stsベース.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn閉じる
        '
        Me.btn閉じる.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn閉じる.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn閉じる.ForeColor = System.Drawing.Color.Red
        Me.btn閉じる.Location = New System.Drawing.Point(1020, 674)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(150, 40)
        Me.btn閉じる.TabIndex = 101
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'stsベース
        '
        Me.stsベース.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slb施設名, Me.ToolStripStatusLabel1, Me.spbベース})
        Me.stsベース.Location = New System.Drawing.Point(0, 719)
        Me.stsベース.Name = "stsベース"
        Me.stsベース.Size = New System.Drawing.Size(1184, 22)
        Me.stsベース.TabIndex = 102
        Me.stsベース.Text = "StatusStrip1"
        '
        'slb施設名
        '
        Me.slb施設名.Name = "slb施設名"
        Me.slb施設名.Size = New System.Drawing.Size(43, 17)
        Me.slb施設名.Text = "施設名"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1024, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'spbベース
        '
        Me.spbベース.Name = "spbベース"
        Me.spbベース.Size = New System.Drawing.Size(100, 16)
        '
        'frmベース
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CancelButton = Me.btn閉じる
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.stsベース)
        Me.Controls.Add(Me.btn閉じる)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmベース"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmベース"
        Me.stsベース.ResumeLayout(False)
        Me.stsベース.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn閉じる As Button
    Friend WithEvents stsベース As StatusStrip
    Friend WithEvents spbベース As ToolStripProgressBar
    Friend WithEvents slb施設名 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
