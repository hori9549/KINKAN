<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmメッセージ
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース

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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.lblメッセージ = New System.Windows.Forms.Label()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Blue
        Me.btnOK.Location = New System.Drawing.Point(26, 5)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(150, 45)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnキャンセル.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnキャンセル.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnキャンセル.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnキャンセル.ForeColor = System.Drawing.Color.Red
        Me.btnキャンセル.Location = New System.Drawing.Point(228, 5)
        Me.btnキャンセル.Margin = New System.Windows.Forms.Padding(5)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(150, 45)
        Me.btnキャンセル.TabIndex = 1
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = False
        '
        'lblメッセージ
        '
        Me.lblメッセージ.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメッセージ.ForeColor = System.Drawing.Color.Blue
        Me.lblメッセージ.Location = New System.Drawing.Point(169, 12)
        Me.lblメッセージ.Name = "lblメッセージ"
        Me.lblメッセージ.Size = New System.Drawing.Size(401, 128)
        Me.lblメッセージ.TabIndex = 4
        Me.lblメッセージ.Text = "メッセージ"
        Me.lblメッセージ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picImg
        '
        Me.picImg.Image = Global.KINKAN.My.Resources.Resources._Error
        Me.picImg.InitialImage = Nothing
        Me.picImg.Location = New System.Drawing.Point(12, 12)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(128, 128)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 109
        Me.picImg.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnキャンセル, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(174, 149)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(405, 55)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'sfrmメッセージ
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnキャンセル
        Me.ClientSize = New System.Drawing.Size(584, 211)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrmメッセージ"
        Me.ShowInTaskbar = False
        Me.Text = "メッセージ"
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnキャンセル As System.Windows.Forms.Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblメッセージ As Label
    Public WithEvents picImg As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
