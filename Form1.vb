Public Class Form1
    Dim numOfRow As Integer = 13
    Dim lblSeat(4, numOfRow) As Label
    Dim x0 As Integer = 50
    Dim y0 As Integer = 100
    Dim seatWidth As Integer = 30
    Dim seatHeight As Integer = 20
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For j As Integer = 1 To 4
            For i As Integer = 1 To numOfRow
                Dim lbl = New Label
                lblSeat(j, i) = lbl
                lbl.Text = (i - 1) * 4 + j
                lbl.Tag = i
                lbl.Size = New Size(seatWidth, seatHeight)
                lbl.BorderStyle = BorderStyle.FixedSingle
                lbl.BackColor = Color.Green
                lbl.ForeColor = Color.AliceBlue
                lbl.Location = New Point(x0 + i * (seatWidth + 10), y0 + j * (seatHeight + 10))
                Me.Controls.Add(lbl)
            Next
        Next



    End Sub
End Class
