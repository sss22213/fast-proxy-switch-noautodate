<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.檔案ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關閉程式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.觀禮設定檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關於ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.官方論壇ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.註冊訊息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.錯誤回報ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.引用來源ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "切換proxy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(5, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(449, 304)
        Me.ListBox1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案ToolStripMenuItem, Me.功能ToolStripMenuItem, Me.關於ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '檔案ToolStripMenuItem
        '
        Me.檔案ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.關閉程式ToolStripMenuItem})
        Me.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem"
        Me.檔案ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.檔案ToolStripMenuItem.Text = "檔案"
        '
        '關閉程式ToolStripMenuItem
        '
        Me.關閉程式ToolStripMenuItem.Name = "關閉程式ToolStripMenuItem"
        Me.關閉程式ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.關閉程式ToolStripMenuItem.Text = "關閉程式"
        '
        '功能ToolStripMenuItem
        '
        Me.功能ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.觀禮設定檔ToolStripMenuItem, Me.設定ToolStripMenuItem})
        Me.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem"
        Me.功能ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.功能ToolStripMenuItem.Text = "功能"
        '
        '觀禮設定檔ToolStripMenuItem
        '
        Me.觀禮設定檔ToolStripMenuItem.Name = "觀禮設定檔ToolStripMenuItem"
        Me.觀禮設定檔ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.觀禮設定檔ToolStripMenuItem.Text = "管理設定檔"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        '關於ToolStripMenuItem
        '
        Me.關於ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.官方論壇ToolStripMenuItem, Me.註冊訊息ToolStripMenuItem, Me.錯誤回報ToolStripMenuItem, Me.引用來源ToolStripMenuItem})
        Me.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem"
        Me.關於ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.關於ToolStripMenuItem.Text = "關於"
        '
        '官方論壇ToolStripMenuItem
        '
        Me.官方論壇ToolStripMenuItem.Name = "官方論壇ToolStripMenuItem"
        Me.官方論壇ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.官方論壇ToolStripMenuItem.Text = "官方網站"
        '
        '註冊訊息ToolStripMenuItem
        '
        Me.註冊訊息ToolStripMenuItem.Name = "註冊訊息ToolStripMenuItem"
        Me.註冊訊息ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.註冊訊息ToolStripMenuItem.Text = "註冊訊息"
        '
        '錯誤回報ToolStripMenuItem
        '
        Me.錯誤回報ToolStripMenuItem.Name = "錯誤回報ToolStripMenuItem"
        Me.錯誤回報ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.錯誤回報ToolStripMenuItem.Text = "錯誤回報"
        '
        '引用來源ToolStripMenuItem
        '
        Me.引用來源ToolStripMenuItem.Name = "引用來源ToolStripMenuItem"
        Me.引用來源ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.引用來源ToolStripMenuItem.Text = "引用來源"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(460, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "目前的IP:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(549, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(255, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "目前ISP"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(549, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(266, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(636, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(564, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 47)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "關閉proxy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(602, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 44)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "自動偵測開啟"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(602, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 49)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "自動偵測關閉"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(626, 234)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 12)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "好手氣(更換IP)"
        Me.LinkLabel1.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(636, 264)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(63, 12)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "回復原本IP"
        Me.LinkLabel2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 401)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Fast Proxy Switch noupdate"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 檔案ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 功能ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 關於ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 官方論壇ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 註冊訊息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 觀禮設定檔ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents 設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 關閉程式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 錯誤回報ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents 引用來源ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
