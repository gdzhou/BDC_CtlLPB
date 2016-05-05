<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctlLPB
    Inherits System.Windows.Forms.UserControl

    'UserControl1 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Grid1 = New FlexCell.Grid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.AllowUserPaste = FlexCell.ClipboardDataEnum.None
        Me.Grid1.AllowUserResizing = FlexCell.ResizeEnum.None
        Me.Grid1.CheckedImage = Nothing
        Me.Grid1.DefaultFont = New System.Drawing.Font("宋体", 9.0!)
        Me.Grid1.DisplayRowNumber = True
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.Blue
        Me.Grid1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(656, 489)
        Me.Grid1.TabIndex = 0
        Me.Grid1.UncheckedImage = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UctlLPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid1)
        Me.DoubleBuffered = True
        Me.Name = "UctlLPB"
        Me.Size = New System.Drawing.Size(656, 489)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
