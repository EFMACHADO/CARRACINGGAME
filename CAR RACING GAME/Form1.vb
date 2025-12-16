Public Class Form1

    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Dim sideDirection As Integer = 1
    Dim rnd As New Random

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 7
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

        RoadMover.Stop()
        RacerMover1.Stop()
        RacerMover2.Stop()
        RacerMover3.Stop()
        DirectionTimer.Stop()
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score > 10 And score < 30 Then speed = 10
        If score > 30 And score < 50 Then speed = 13
        If score > 50 And score < 70 Then speed = 18
        If score > 100 Then speed = 22

        Label2.Text = "Speed " & speed

        If (car.Bounds.IntersectsWith(race1.Bounds)) Then endgame()
        If (car.Bounds.IntersectsWith(race2.Bounds)) Then endgame()
        If (car.Bounds.IntersectsWith(race3.Bounds)) Then endgame()
    End Sub

    Private Sub DirectionTimer_Tick(sender As Object, e As EventArgs) Handles DirectionTimer.Tick
        If rnd.Next(0, 2) = 0 Then
            sideDirection = -1
        Else
            sideDirection = 1
        End If
    End Sub

    Private Sub endgame()
        Button1.Visible = True
        Label3.Visible = True
        RoadMover.Stop()
        RacerMover1.Stop()
        RacerMover2.Stop()
        RacerMover3.Stop()
        DirectionTimer.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then RightSide.Start()
        If e.KeyCode = Keys.Left Then LeftSide.Start()
        If e.KeyCode = Keys.Down Then DownSide.Start()
        If e.KeyCode = Keys.Up Then UpSide.Start()
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If car.Location.X > 0 Then car.Left -= 5
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If car.Location.X < 295 Then car.Left += 5
    End Sub

    Private Sub DownSide_Tick(sender As Object, e As EventArgs) Handles DownSide.Tick
        If car.Location.Y < 500 Then car.Top += 5
    End Sub

    Private Sub UpSide_Tick(sender As Object, e As EventArgs) Handles UpSide.Tick
        If car.Location.Y > 0 Then car.Top -= 5
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
        DownSide.Stop()
        UpSide.Stop()
    End Sub

    Private Sub RacerMover1_Tick(sender As Object, e As EventArgs) Handles RacerMover1.Tick
        race1.Top += speed / 2
        race1.Left += sideDirection * 2

        If race1.Top >= Me.Height Then
            score += 1
            Label1.Text = "Score " & score
            race1.Top = -(rnd.Next(0, 200) + race1.Height)
            race1.Left = rnd.Next(0, 50)
        End If
    End Sub

    Private Sub RacerMover2_Tick(sender As Object, e As EventArgs) Handles RacerMover2.Tick
        race2.Top += speed / 3
        race2.Left += sideDirection * 2

        If race2.Top >= Me.Height Then
            score += 1
            Label1.Text = "Score " & score
            race2.Top = -(rnd.Next(0, 200) + race2.Height)
            race2.Left = rnd.Next(0, 50) + 100
        End If
    End Sub

    Private Sub RacerMover3_Tick(sender As Object, e As EventArgs) Handles RacerMover3.Tick
        race3.Top += speed / 2
        race3.Left += sideDirection * 2

        If race3.Top >= Me.Height Then
            score += 1
            Label1.Text = "Score " & score
            race3.Top = -(rnd.Next(0, 200) + race3.Height)
            race3.Left = rnd.Next(0, 120) + 180
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        score = 0
        Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
        Button2.Visible = False
        RoadMover.Start()
        RacerMover1.Start()
        RacerMover2.Start()
        RacerMover3.Start()
        DirectionTimer.Start()
    End Sub

End Class
