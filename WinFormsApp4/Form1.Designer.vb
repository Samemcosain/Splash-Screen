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
        Timer1 = New Timer(components)
        Center_panel = New Panel()
        Progressbar = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Center_panel
        ' 
        Center_panel.BorderStyle = BorderStyle.FixedSingle
        Center_panel.Location = New Point(294, 297)
        Center_panel.Name = "Center_panel"
        Center_panel.Size = New Size(593, 16)
        Center_panel.TabIndex = 1
        ' 
        ' Progressbar
        ' 
        Progressbar.BackColor = Color.Orange
        Progressbar.Location = New Point(294, 297)
        Progressbar.Name = "Progressbar"
        Progressbar.Size = New Size(112, 16)
        Progressbar.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(60), CByte(200), CByte(60))
        Label2.Font = New Font("Calibri", 15.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(441, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 31)
        Label2.TabIndex = 5
        Label2.Text = "Loading"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(532, 250)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(80), CByte(250), CByte(80))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(158, 204)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 43)
        Label1.TabIndex = 7
        Label1.Text = "HORSE JUMP RACE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(415, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 8
        Label3.Text = "Label3"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(303, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(82, 27)
        TextBox1.TabIndex = 9
        TextBox1.Text = "ro"
        ' 
        ' Form1
        ' 
        AccessibleRole = AccessibleRole.TitleBar
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(60), CByte(200), CByte(60))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1104, 601)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Progressbar)
        Controls.Add(Center_panel)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Center_panel As Panel
    Friend WithEvents Progressbar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Label1 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
