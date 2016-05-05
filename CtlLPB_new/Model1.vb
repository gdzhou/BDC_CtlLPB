Module Model1
    Class Hinfo
#Region "状态"
        Enum 销售状态
            未办预售 = 0
            已办预售许可 = 1
            正在办理 = 2
            已售 = 3
        End Enum
        Enum 产权状态
            未做初始登记 = 0
            正在办理 = 1
            已做初始登记 = 2
            已分户 = 3
            预告产权 = 4
        End Enum
        Enum 抵押状态
            未办抵押 = 0
            正在办理抵押 = 1
            已办抵押 = 3
            预告抵押 = 4
        End Enum
        Enum 限制状态
            没有限制 = 0
            正在办理限制 = 1
            已办限制 = 3
        End Enum
        Enum 用途性质
            住宅 = 0
            工业 = 1
            办公 = 2
            商场 = 3
            车库 = 4
            其他 = 5
        End Enum
#End Region

        Private _CH As Integer
        Public Property CH() As Integer
            Get
                Return _CH
            End Get
            Set(ByVal value As Integer)
                _CH = value
            End Set
        End Property

        Private _DY As Integer
        Public Property DY() As Integer
            Get
                Return _DY
            End Get
            Set(ByVal value As Integer)
                _DY = value
            End Set
        End Property

        Private _SH As Integer '
        Public Property SH() As Integer
            Get
                Return _SH
            End Get
            Set(ByVal value As Integer)
                _SH = value
            End Set
        End Property


        Private _ZT As Integer
        Public Property ZT() As Integer
            Get
                Return _ZT
            End Get
            Set(ByVal value As Integer)
                _ZT = value
            End Set
        End Property


        Private Flag() As Integer
        ''' <summary>
        ''' 设置状态
        ''' </summary>
        ''' <param name="xs">销售状态</param>
        ''' <param name="cq">产权状态</param>
        ''' <param name="dy">抵押状态</param>
        ''' <param name="xz">限制状态</param>
        ''' <remarks></remarks>
        Public Sub SetFlag(ByVal xs As Integer, ByVal cq As Integer, ByVal dy As Integer, ByVal xz As Integer)
            Flag = New Integer() {xs, cq, dy, xz}
        End Sub
        Public Sub New()
            Flag = New Integer() {0, 0, 0, 0}
        End Sub
        Public Sub New(ByVal ch As Integer, ByVal dy As Integer, ByVal sh As Integer)
            MyBase.New()
            _CH = ch
            _DY = dy
            _SH = sh
        End Sub
        Private FlagChar() As String = New String() {"售", "产", "抵", "限"}
        Public Function toImage(ByVal rec As Rectangle) As Bitmap
            Dim img As Bitmap = New Bitmap(rec.Width, rec.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Dim pt As Point = New Point(0, 0)
            pt.Offset(rec.Width \ 3, 3)
            g.Clear(GetBackColor(_ZT))
            g.DrawString(_SH.ToString, New Font("宋体", 9), Brushes.Blue, pt)
            g.DrawLine(Pens.Green, New Point(rec.Left, rec.Top + rec.Height / 2), New Point(rec.Right, rec.Top + rec.Height / 2))
            Dim w As Integer = rec.Width \ 4
            Dim h As Integer = rec.Height \ 2
            For i As Integer = 0 To 3
                g.DrawImage(GetColorBlk(w, h, ConvertColor(Flag(i))), New Point(i * w, h))
                g.DrawString(FlagChar(i), New Font("宋体", 9), GetBrushesColor(Flag(i)), New Point(i * w + 2, h + 5))
            Next
            g.Dispose()
            Return img
        End Function
        Private Function GetBackColor(ByVal k As Integer) As Color
            Select Case k
                Case 0
                    Return Color.LightYellow
                Case 1
                    Return Color.DarkGray
                Case 2
                    Return Color.LightGreen
                Case 3
                    Return Color.Orange
                Case 4
                    Return Color.LightBlue
                Case 5
                    Return Color.LightGray
                Case 6
                    Return Color.Pink
                Case Else
                    Return Color.White
            End Select
        End Function
        Private Function GetBrushesColor(ByVal k As Integer) As Brush
            '获取状态文字的颜色'
            Select Case k
                Case 0
                    Return Brushes.White '空白'
                Case 1
                    Return Brushes.Black '绿底黑字'
                Case 2
                    Return Brushes.Blue '黄底蓝字'
                Case 3
                    Return Brushes.Yellow '红底黄字'
                Case 4
                    Return Brushes.Green '蓝底绿字'
                Case Else
                    Return Brushes.White
            End Select
        End Function
        Private Function ConvertColor(ByVal k As Integer) As Color
            Select Case k
                Case 0
                    Return Color.White
                Case 1
                    Return Color.Green
                Case 2
                    Return Color.Yellow
                Case 3
                    Return Color.Red
                Case 4
                    Return Color.Blue
                Case Else
                    Return Color.White
            End Select
        End Function
        Private Function GetColorBlk(ByVal w As Integer, ByVal h As Integer, ByVal color As Color) As Bitmap
            Dim img As Bitmap = New Bitmap(w, h)
            Dim g As Graphics = Graphics.FromImage(img)
            g.Clear(color)
            g.DrawRectangle(Pens.Black, New Rectangle(0, 0, w, h))
            g.Dispose()
            Return img
        End Function

    End Class
   
End Module
