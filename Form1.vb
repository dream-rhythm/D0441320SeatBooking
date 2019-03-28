' 作者：陳琮斌
' Author：Dream_Rhythm(Alice)
' 班級：資訊四甲

Public Class Form1
    Dim numOfRow As Integer = 13
    Dim numOfColumn As Integer = 4
    Dim lblSeat(numOfColumn, numOfRow) As Label
    Dim x0 As Integer = 10
    Dim y0 As Integer = 100
    Dim seatWidth As Integer = 45
    Dim seatHeight As Integer = 20
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For j As Integer = 1 To numOfColumn
            For i As Integer = 1 To numOfRow
                Dim lbl = New Label
                lblSeat(j, i) = lbl
                lbl.Text = (i - 1) * 4 + j
                lbl.Tag = (i - 1) * 4 + j
                lbl.Size = New Size(seatWidth, seatHeight)
                lbl.BorderStyle = BorderStyle.FixedSingle
                lbl.BackColor = Color.Green
                lbl.ForeColor = Color.AliceBlue
                lbl.Location = New Point(x0 + i * (seatWidth + 10), y0 + j * (seatHeight + 10))
                Me.Controls.Add(lbl)
                AddHandler lbl.Click, AddressOf lbl_Click
            Next
        Next
    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs)
        Dim seatNumber As Integer = sender.Tag
        If sender.Text <> "已訂位" Then
            MsgBox("位置" & sender.Text & "訂位成功", MsgBoxStyle.Information, "電腦訂位系統")
            sender.Text = "已訂位"
            sender.backColor = Color.Red
            sender.ForeColor = Color.White
        Else
            MsgBox("Opps!這個位置已經被訂走了，請重新選擇", MsgBoxStyle.Critical, "電腦訂位系統")
        End If
    End Sub

End Class
