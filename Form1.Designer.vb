<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ListBox1.Enabled = False
        Me.ListBox1.Font = New System.Drawing.Font("宋体", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 26
        Me.ListBox1.Location = New System.Drawing.Point(207, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(600, 593)
        Me.ListBox1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 24)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "编辑模式"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(12, 39)
        Me.HScrollBar1.Maximum = 20
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(189, 17)
        Me.HScrollBar1.TabIndex = 14
        Me.HScrollBar1.Value = 1
        '
        'HScrollBar2
        '
        Me.HScrollBar2.LargeChange = 1
        Me.HScrollBar2.Location = New System.Drawing.Point(12, 56)
        Me.HScrollBar2.Maximum = 20
        Me.HScrollBar2.Minimum = 1
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(189, 17)
        Me.HScrollBar2.TabIndex = 15
        Me.HScrollBar2.Value = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(189, 23)
        Me.TextBox1.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 24)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0.1s", "0.2s", "0.3s", "0.4s", "0.5s", "0.6s", "0.7s", "0.8s", "0.9s", "1.0s", "1.5s", "2.0s"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 164)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 25)
        Me.ComboBox1.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 135)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(189, 23)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.Text = "下方输入演变速度(默认0.5秒)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 619)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "康威生命游戏"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
End Class
