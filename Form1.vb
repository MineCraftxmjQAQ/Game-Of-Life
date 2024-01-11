Public Class Form1
    Public Raw() As Integer = New Integer(400) {}
    Public Temp() As Integer = New Integer(400) {}
    Public Sign() As Integer = New Integer(400) {}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 400
            Raw(i) = 0
            Sign(i) = 0
        Next i
        HScrollBar1.Value = 1
        HScrollBar2.Value = 1
        ComboBox1.SelectedIndex = 4
        TextBox1.Text = "当前已选中第:" + NumLength(HScrollBar1.Value) + "行,第" + NumLength(HScrollBar2.Value) + "列"
        Button2.Text = "当前细胞死亡,点击改为存活"
        Sign((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 2
        Call Sc()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If StrComp(Button1.Text, "编辑模式") = 0 Then
            TextBox1.Text = "处于演变模式,无法调整细胞状态"
            Button1.Text = "演变模式"
            Timer1.Enabled = True
            ComboBox1.Enabled = True
            HScrollBar1.Enabled = False
            HScrollBar2.Enabled = False
            Button2.Enabled = False
            Call Sc()
        ElseIf StrComp(Button1.Text, "演变模式") = 0 Then
            TextBox1.Text = "当前已选中第:" + NumLength(HScrollBar1.Value) + "行,第" + NumLength(HScrollBar2.Value) + "列"
            Button1.Text = "编辑模式"
            Timer1.Enabled = False
            ComboBox1.Enabled = False
            HScrollBar1.Enabled = True
            HScrollBar2.Enabled = True
            Button2.Enabled = True
            Call Sc()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Raw((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 1 - Raw((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value)
        If Raw((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 0 Then
            Button2.Text = "当前细胞死亡,点击改为存活"
        Else
            Button2.Text = "当前细胞存活,点击改为死亡"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer, j As Integer, k As Integer, cell As Integer
        Dim DirectTemp() As Integer = New Integer(8) {}
        For i = 1 To 400
            Temp(i) = Raw(i)
        Next i
        For i = 1 To 20
            For j = 1 To 20
                For k = 0 To 7
                    DirectTemp(k) = 0
                Next k
                If i > 1 Then '向上
                    If Raw((i - 2) * 20 + j) = 1 Then DirectTemp(0) = 1
                End If
                If j < 20 Then '向右
                    If Raw((i - 1) * 20 + j + 1) = 1 Then DirectTemp(1) = 1
                End If
                If i < 20 Then '向下
                    If Raw(i * 20 + j) = 1 Then DirectTemp(2) = 1
                End If
                If j > 1 Then '向左
                    If Raw((i - 1) * 20 + j - 1) = 1 Then DirectTemp(3) = 1
                End If
                If i > 1 And j > 1 Then '左上
                    If Raw((i - 2) * 20 + j - 1) = 1 Then DirectTemp(4) = 1
                End If
                If i > 1 And j < 20 Then '右上
                    If Raw((i - 2) * 20 + j + 1) = 1 Then DirectTemp(5) = 1
                End If
                If i < 20 And j < 20 Then '右下
                    If Raw(i * 20 + j + 1) = 1 Then DirectTemp(6) = 1
                End If
                If i < 20 And j > 1 Then '左下
                    If Raw(i * 20 + j - 1) = 1 Then DirectTemp(7) = 1
                End If
                cell = DirectTemp(0) + DirectTemp(1) + DirectTemp(2) + DirectTemp(3) + DirectTemp(4) + DirectTemp(5) + DirectTemp(6) + DirectTemp(7)
                If Raw((i - 1) * 20 + j) = 0 And cell = 3 Then Temp((i - 1) * 20 + j) = 1 '当前细胞为死亡状态时， 当周围有3个存活细胞时， 则迭代后该细胞变成存活状态
                If Raw((i - 1) * 20 + j) = 1 And cell < 2 Or cell > 3 Then Temp((i - 1) * 20 + j) = 0 '当前细胞为存活状态时，当周围有3个以上的存活细胞时或当周围的邻居细胞低于两个(不包含两个)存活时，该细胞变成死亡状态
            Next j
        Next i
        For i = 1 To 400
            Raw(i) = Temp(i)
        Next i
        Call Sc()
    End Sub
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim i As Integer
        For i = 0 To 400
            Sign(i) = 0
        Next i
        If Raw((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 0 Then
            Button2.Text = "当前细胞死亡,点击改为存活"
        Else
            Button2.Text = "当前细胞存活,点击改为死亡"
        End If
        TextBox1.Text = "当前已选中第:" + NumLength(HScrollBar1.Value) + "行,第" + NumLength(HScrollBar2.Value) + "列"
        Sign((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 2
        Call Sc()
    End Sub
    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Dim i As Integer
        For i = 0 To 400
            Sign(i) = 0
        Next i
        If Raw((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 0 Then
            Button2.Text = "当前细胞死亡,点击改为存活"
        Else
            Button2.Text = "当前细胞存活,点击改为死亡"
        End If
        TextBox1.Text = "当前已选中第:" + NumLength(HScrollBar1.Value) + "行,第" + NumLength(HScrollBar2.Value) + "列"
        Sign((HScrollBar1.Value - 1) * 20 + HScrollBar2.Value) = 2
        Call Sc()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Timer1.Interval = Val(Mid(ComboBox1.SelectedItem, 1, 3)) * 1000
    End Sub
    Private Sub Sc()
        Dim i As Integer, j As Integer
        Dim Draw() As String = New String(2) {}
        Dim row As String
        Draw(0) = "□"
        Draw(1) = "■"
        Draw(2) = "☑"
        ListBox1.Items.Clear()
        ListBox1.Items.Add(" ---------------------------------------")
        For i = 1 To 20
            row = ""
            For j = 1 To 20
                If Timer1.Enabled = False And Sign((i - 1) * 20 + j) = 2 Then
                    row += Draw(Sign((i - 1) * 20 + j))
                Else
                    row += Draw(Raw((i - 1) * 20 + j))
                End If
            Next j
            ListBox1.Items.Add("|" + row + "|")
        Next i
        ListBox1.Items.Add(" ---------------------------------------")
    End Sub
    Private Shared Function NumLength(Num As String) As String
        If Len(Num) = 1 Then
            NumLength = "  " + Num
        ElseIf Len(Num) = 2 Then
            NumLength = " " + Num
        Else
            NumLength = Num
        End If
    End Function
    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        e.Graphics.FillRectangle(New SolidBrush(e.BackColor), e.Bounds)
        If e.Index >= 0 Then
            Dim sStringFormat As New StringFormat With {
                .LineAlignment = StringAlignment.Center
            }
            e.Graphics.DrawString((CType(sender, ListBox)).Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), e.Bounds, sStringFormat)
        End If
        e.DrawFocusRectangle()
    End Sub
End Class