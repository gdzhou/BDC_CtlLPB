Public Class UctlLPB
#Region "属性"
    Private _LP_ZCS As Integer
    Public Property LP_ZCS() As Integer
        Get
            Return _LP_ZCS
        End Get
        Set(ByVal value As Integer)
            _LP_ZCS = value
        End Set
    End Property

    Private _LP_DSCS As Integer
    Public Property LP_DSCS() As Integer
        Get
            Return _LP_DSCS
        End Get
        Set(ByVal value As Integer)
            _LP_DSCS = value
        End Set
    End Property

    Private _LP_DXCS As Integer
    Public Property LP_DXCS() As Integer
        Get
            Return _LP_DXCS
        End Get
        Set(ByVal value As Integer)
            _LP_DXCS = value
        End Set
    End Property

    Private _LP_DYHS As Integer
    Public Property LP_DYHS() As Integer
        Get
            Return _LP_DYHS
        End Get
        Set(ByVal value As Integer)
            _LP_DYHS = value
        End Set
    End Property


#End Region
#Region "式"

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With Grid1
            .Cols = 1
            .Rows = 1
            .DefaultRowHeight = 40
            .Cols = 11
            .Rows = 11
            .Images.Clear()
            Dim rec As Rectangle = .Cell(1, 1).Bounds
            Dim h As New Hinfo
            Dim rnd As New Random
            For i As Integer = 1 To .Rows - 1
                h.CH = i
                For j As Integer = 1 To .Cols - 1
                    h.SH = i * 100 + j
                    h.ZT = rnd.Next(5)
                    h.SetFlag(rnd.Next(4), rnd.Next(4), rnd.Next(4), rnd.Next(4))
                    .Images.Add(h.toImage(rec), h.SH.ToString)
                    .Cell(i, j).SetImage(h.SH.ToString)
                    .Cell(i, j).Tag = h.SH.ToString
                Next
            Next
        End With
    End Sub
  
    Private Sub Grid1_MouseHover(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.MouseHover
        Dim bpt As Point = Grid1.PointToScreen(Grid1.Location)
        Dim x As Integer = MousePosition.X - bpt.X
        Dim y As Integer = MousePosition.Y - bpt.Y
        Dim cel As FlexCell.Cell = Grid1.HitTest(x, y)
        If cel Is Nothing Then
            Exit Sub
        Else
            ToolTip1.Show(cel.Tag, Grid1, x + 5, y, 500)
        End If
    End Sub
End Class
