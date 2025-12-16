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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        race2 = New PictureBox()
        race1 = New PictureBox()
        race3 = New PictureBox()
        car = New PictureBox()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RacerMover1 = New Timer(components)
        RacerMover2 = New Timer(components)
        RacerMover3 = New Timer(components)
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        DownSide = New Timer(components)
        UpSide = New Timer(components)
        DirectionTimer = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(car, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Location = New Point(90, -7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(18, 101)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Location = New Point(213, -7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(18, 101)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Location = New Point(90, 125)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(18, 101)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Location = New Point(213, 125)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(18, 101)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ButtonHighlight
        PictureBox5.Location = New Point(213, 257)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(18, 101)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.ButtonHighlight
        PictureBox6.Location = New Point(90, 257)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(18, 101)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ButtonHighlight
        PictureBox7.Location = New Point(90, 380)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(18, 101)
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.ButtonHighlight
        PictureBox8.Location = New Point(213, 380)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(18, 101)
        PictureBox8.TabIndex = 7
        PictureBox8.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Cross
        Label1.Font = New Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 25)
        Label1.TabIndex = 8
        Label1.Text = "SPEED 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Cross
        Label2.Font = New Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(241, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 25)
        Label2.TabIndex = 9
        Label2.Text = "SCORE 0"
        ' 
        ' race2
        ' 
        race2.Image = My.Resources.Resources._4
        race2.Location = New Point(138, 50)
        race2.Name = "race2"
        race2.Size = New Size(42, 67)
        race2.SizeMode = PictureBoxSizeMode.Zoom
        race2.TabIndex = 10
        race2.TabStop = False
        ' 
        ' race1
        ' 
        race1.Image = My.Resources.Resources._3
        race1.Location = New Point(268, 125)
        race1.Name = "race1"
        race1.Size = New Size(42, 67)
        race1.SizeMode = PictureBoxSizeMode.Zoom
        race1.TabIndex = 11
        race1.TabStop = False
        ' 
        ' race3
        ' 
        race3.Image = CType(resources.GetObject("race3.Image"), Image)
        race3.Location = New Point(29, 125)
        race3.Name = "race3"
        race3.Size = New Size(42, 67)
        race3.SizeMode = PictureBoxSizeMode.Zoom
        race3.TabIndex = 12
        race3.TabStop = False
        ' 
        ' car
        ' 
        car.Image = My.Resources.Resources._11
        car.Location = New Point(138, 304)
        car.Name = "car"
        car.Size = New Size(42, 67)
        car.SizeMode = PictureBoxSizeMode.Zoom
        car.TabIndex = 13
        car.TabStop = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' RacerMover1
        ' 
        RacerMover1.Enabled = True
        RacerMover1.Interval = 10
        ' 
        ' RacerMover2
        ' 
        RacerMover2.Enabled = True
        RacerMover2.Interval = 10
        ' 
        ' RacerMover3
        ' 
        RacerMover3.Enabled = True
        RacerMover3.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Agency FB", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(108, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 35)
        Label3.TabIndex = 14
        Label3.Text = "GAMEOVER"
        Label3.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(114, 257)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 32)
        Button1.TabIndex = 15
        Button1.Text = "REPLAY"
        Button1.UseVisualStyleBackColor = True
        Button1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.HighlightText
        Button2.Font = New Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(114, 142)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 32)
        Button2.TabIndex = 16
        Button2.Text = "START"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' DownSide
        ' 
        DownSide.Interval = 10
        ' 
        ' UpSide
        ' 
        UpSide.Interval = 10
        ' 
        ' DirectionTimer
        ' 
        DirectionTimer.Enabled = True
        DirectionTimer.Interval = 5000
        ' 
        ' Timer3
        ' 
        Timer3.Enabled = True
        Timer3.Interval = 10
        ' 
        ' Timer4
        ' 
        Timer4.Enabled = True
        Timer4.Interval = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(334, 461)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(car)
        Controls.Add(race3)
        Controls.Add(race1)
        Controls.Add(race2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        ForeColor = Color.LimeGreen
        MaximumSize = New Size(350, 500)
        MinimumSize = New Size(350, 500)
        Name = "Form1"
        Text = "CAR RACING GAME"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(car, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents race3 As PictureBox
    Friend WithEvents car As PictureBox

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles race3.Click

    End Sub

    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RacerMover1 As Timer
    Friend WithEvents RacerMover2 As Timer
    Friend WithEvents RacerMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DownSide As Timer
    Friend WithEvents UpSide As Timer
    Friend WithEvents DirectionTimer As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    'End Sub
End Class
