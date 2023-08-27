<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.time = New System.Windows.Forms.Label()
        Me.Thinking = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FormElipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ControlElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ControlElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ControlElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.DragMovement = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.txtAnswer = New System.Windows.Forms.RichTextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Emote = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSend = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtQuestion = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelElipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.RichElipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PanelElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.RichElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.cbModel = New System.Windows.Forms.ComboBox()
        Me.txtMaxTokens = New System.Windows.Forms.TextBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Usertext = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.EmoteElipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.AnimationShow = New System.Windows.Forms.Timer(Me.components)
        Me.TimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.AnimateEmoji = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.TopBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Emote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopBar
        '
        Me.TopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TopBar.Controls.Add(Me.time)
        Me.TopBar.Controls.Add(Me.Thinking)
        Me.TopBar.Controls.Add(Me.Label4)
        Me.TopBar.Controls.Add(Me.GunaControlBox3)
        Me.TopBar.Controls.Add(Me.GunaControlBox2)
        Me.TopBar.Controls.Add(Me.GunaControlBox1)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Controls.Add(Me.PictureBox1)
        Me.AnimateEmoji.SetDecoration(Me.TopBar, Guna.UI.Animation.DecorationType.None)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(993, 33)
        Me.TopBar.TabIndex = 0
        '
        'time
        '
        Me.time.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AnimateEmoji.SetDecoration(Me.time, Guna.UI.Animation.DecorationType.None)
        Me.time.Font = New System.Drawing.Font("Bahnschrift Light", 10.0!)
        Me.time.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.time.Location = New System.Drawing.Point(406, 8)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(180, 22)
        Me.time.TabIndex = 5
        Me.time.Text = "00/00"
        Me.time.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Thinking
        '
        Me.Thinking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thinking.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Thinking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AnimateEmoji.SetDecoration(Me.Thinking, Guna.UI.Animation.DecorationType.None)
        Me.Thinking.Location = New System.Drawing.Point(6, 4)
        Me.Thinking.Name = "Thinking"
        Me.Thinking.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.Thinking.Size = New System.Drawing.Size(24, 24)
        Me.Thinking.TabIndex = 2
        Me.Thinking.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.AnimateEmoji.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label4.Location = New System.Drawing.Point(92, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "by edditdev"
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.Animated = True
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.AnimateEmoji.SetDecoration(Me.GunaControlBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaControlBox3.IconColor = System.Drawing.Color.LightSteelBlue
        Me.GunaControlBox3.IconSize = 12.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(904, 4)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.LightSlateGray
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.LightSlateGray
        Me.GunaControlBox3.Size = New System.Drawing.Size(24, 24)
        Me.GunaControlBox3.TabIndex = 3
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.Animated = True
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.AnimateEmoji.SetDecoration(Me.GunaControlBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaControlBox2.IconColor = System.Drawing.Color.LightSteelBlue
        Me.GunaControlBox2.IconSize = 12.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(934, 4)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.LightSlateGray
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.LightSlateGray
        Me.GunaControlBox2.Size = New System.Drawing.Size(24, 24)
        Me.GunaControlBox2.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.AnimateEmoji.SetDecoration(Me.GunaControlBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaControlBox1.IconColor = System.Drawing.Color.LightSteelBlue
        Me.GunaControlBox1.IconSize = 12.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(964, 4)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.LightSlateGray
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.LightSlateGray
        Me.GunaControlBox1.Size = New System.Drawing.Size(24, 24)
        Me.GunaControlBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.AnimateEmoji.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(30, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CHAT GPT"
        '
        'PictureBox1
        '
        Me.AnimateEmoji.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = Global.ChatGPT___by_eddit.My.Resources.Resources.icons8_cyclone_24px
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormElipse
        '
        Me.FormElipse.Radius = 5
        Me.FormElipse.TargetControl = Me
        '
        'ControlElipse1
        '
        Me.ControlElipse1.Radius = 3
        Me.ControlElipse1.TargetControl = Me.GunaControlBox1
        '
        'ControlElipse2
        '
        Me.ControlElipse2.Radius = 3
        Me.ControlElipse2.TargetControl = Me.GunaControlBox2
        '
        'ControlElipse3
        '
        Me.ControlElipse3.Radius = 3
        Me.ControlElipse3.TargetControl = Me.GunaControlBox3
        '
        'DragMovement
        '
        Me.DragMovement.TargetControl = Me.TopBar
        '
        'txtAnswer
        '
        Me.txtAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnimateEmoji.SetDecoration(Me.txtAnswer, Guna.UI.Animation.DecorationType.None)
        Me.txtAnswer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.White
        Me.txtAnswer.Location = New System.Drawing.Point(3, 3)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(945, 529)
        Me.txtAnswer.TabIndex = 1
        Me.txtAnswer.Text = ""
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaGroupBox1.BorderSize = 2
        Me.GunaGroupBox1.Controls.Add(Me.Panel1)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.AnimateEmoji.SetDecoration(Me.GunaGroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 5
        Me.GunaGroupBox1.Size = New System.Drawing.Size(969, 578)
        Me.GunaGroupBox1.TabIndex = 2
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Emote)
        Me.Panel1.Controls.Add(Me.txtAnswer)
        Me.AnimateEmoji.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(10, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 535)
        Me.Panel1.TabIndex = 3
        '
        'Emote
        '
        Me.Emote.BaseColor = System.Drawing.Color.White
        Me.AnimateEmoji.SetDecoration(Me.Emote, Guna.UI.Animation.DecorationType.None)
        Me.Emote.Image = Global.ChatGPT___by_eddit.My.Resources.Resources.giphy
        Me.Emote.Location = New System.Drawing.Point(432, 224)
        Me.Emote.Name = "Emote"
        Me.Emote.Size = New System.Drawing.Size(86, 86)
        Me.Emote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Emote.TabIndex = 0
        Me.Emote.TabStop = False
        Me.Emote.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.AnimateEmoji.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Answer"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaGroupBox2.BorderSize = 2
        Me.GunaGroupBox2.Controls.Add(Me.Panel2)
        Me.GunaGroupBox2.Controls.Add(Me.Label3)
        Me.AnimateEmoji.SetDecoration(Me.GunaGroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaGroupBox2.LineTop = 20
        Me.GunaGroupBox2.Location = New System.Drawing.Point(12, 651)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Radius = 5
        Me.GunaGroupBox2.Size = New System.Drawing.Size(969, 90)
        Me.GunaGroupBox2.TabIndex = 3
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSend)
        Me.Panel2.Controls.Add(Me.txtQuestion)
        Me.AnimateEmoji.SetDecoration(Me.Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(9, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(952, 57)
        Me.Panel2.TabIndex = 4
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.Animated = True
        Me.btnSend.AnimationHoverSpeed = 0.07!
        Me.btnSend.AnimationSpeed = 0.03!
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BaseColor = System.Drawing.Color.Transparent
        Me.btnSend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.BorderSize = 2
        Me.btnSend.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSend.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSend.CheckedForeColor = System.Drawing.Color.White
        Me.btnSend.CheckedImage = CType(resources.GetObject("btnSend.CheckedImage"), System.Drawing.Image)
        Me.btnSend.CheckedLineColor = System.Drawing.Color.DimGray
        Me.AnimateEmoji.SetDecoration(Me.btnSend, Guna.UI.Animation.DecorationType.None)
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSend.FocusedColor = System.Drawing.Color.Empty
        Me.btnSend.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSend.Image = Global.ChatGPT___by_eddit.My.Resources.Resources.icons8_email_send_64px
        Me.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSend.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSend.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSend.Location = New System.Drawing.Point(915, 8)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSend.OnHoverImage = Nothing
        Me.btnSend.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSend.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.Radius = 5
        Me.btnSend.Size = New System.Drawing.Size(36, 41)
        Me.btnSend.TabIndex = 2
        '
        'txtQuestion
        '
        Me.txtQuestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnimateEmoji.SetDecoration(Me.txtQuestion, Guna.UI.Animation.DecorationType.None)
        Me.txtQuestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(3, 3)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtQuestion.Size = New System.Drawing.Size(913, 51)
        Me.txtQuestion.TabIndex = 1
        Me.txtQuestion.Text = "Hi! What's going on?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.AnimateEmoji.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Question"
        '
        'PanelElipse
        '
        Me.PanelElipse.Radius = 5
        Me.PanelElipse.TargetControl = Me.Panel1
        '
        'RichElipse
        '
        Me.RichElipse.Radius = 5
        Me.RichElipse.TargetControl = Me.txtAnswer
        '
        'PanelElipse2
        '
        Me.PanelElipse2.Radius = 5
        Me.PanelElipse2.TargetControl = Me.Panel2
        '
        'RichElipse2
        '
        Me.RichElipse2.Radius = 5
        Me.RichElipse2.TargetControl = Me.txtQuestion
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AnimateEmoji.SetDecoration(Me.txtUserID, Guna.UI.Animation.DecorationType.None)
        Me.txtUserID.Location = New System.Drawing.Point(712, 730)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(68, 20)
        Me.txtUserID.TabIndex = 4
        Me.txtUserID.Text = "1"
        Me.txtUserID.Visible = False
        '
        'cbModel
        '
        Me.cbModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AnimateEmoji.SetDecoration(Me.cbModel, Guna.UI.Animation.DecorationType.None)
        Me.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModel.FormattingEnabled = True
        Me.cbModel.Items.AddRange(New Object() {"text-davinci-003", "text-davinci-002", "code-davinci-002", "gpt-3.5-turbo", "gpt-3.5-turbo-0301", "gpt-3.5-turbo-16k-0613", "gpt-3.5-turbo-0613"})
        Me.cbModel.Location = New System.Drawing.Point(856, 729)
        Me.cbModel.Margin = New System.Windows.Forms.Padding(2)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(139, 21)
        Me.cbModel.TabIndex = 12
        Me.cbModel.Visible = False
        '
        'txtMaxTokens
        '
        Me.txtMaxTokens.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AnimateEmoji.SetDecoration(Me.txtMaxTokens, Guna.UI.Animation.DecorationType.None)
        Me.txtMaxTokens.Location = New System.Drawing.Point(784, 730)
        Me.txtMaxTokens.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaxTokens.Name = "txtMaxTokens"
        Me.txtMaxTokens.Size = New System.Drawing.Size(68, 20)
        Me.txtMaxTokens.TabIndex = 11
        Me.txtMaxTokens.Text = "2048"
        Me.txtMaxTokens.Visible = False
        Me.txtMaxTokens.WordWrap = False
        '
        'txtTemperature
        '
        Me.txtTemperature.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AnimateEmoji.SetDecoration(Me.txtTemperature, Guna.UI.Animation.DecorationType.None)
        Me.txtTemperature.Location = New System.Drawing.Point(640, 730)
        Me.txtTemperature.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(68, 20)
        Me.txtTemperature.TabIndex = 10
        Me.txtTemperature.Text = "1"
        Me.txtTemperature.Visible = False
        Me.txtTemperature.WordWrap = False
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.AnimateEmoji.SetDecoration(Me.GunaAdvenceButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GunaAdvenceButton1.Image = Global.ChatGPT___by_eddit.My.Resources.Resources.icons8_settings_24px
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(951, 39)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(37, 23)
        Me.GunaAdvenceButton1.TabIndex = 13
        '
        'Usertext
        '
        Me.Usertext.AnimationHoverSpeed = 0.07!
        Me.Usertext.AnimationSpeed = 0.03!
        Me.Usertext.BackColor = System.Drawing.Color.Transparent
        Me.Usertext.BaseColor = System.Drawing.Color.Transparent
        Me.Usertext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Usertext.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Usertext.CheckedBorderColor = System.Drawing.Color.Black
        Me.Usertext.CheckedForeColor = System.Drawing.Color.White
        Me.Usertext.CheckedImage = CType(resources.GetObject("Usertext.CheckedImage"), System.Drawing.Image)
        Me.Usertext.CheckedLineColor = System.Drawing.Color.DimGray
        Me.AnimateEmoji.SetDecoration(Me.Usertext, Guna.UI.Animation.DecorationType.None)
        Me.Usertext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Usertext.FocusedColor = System.Drawing.Color.Empty
        Me.Usertext.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Usertext.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Usertext.Image = Global.ChatGPT___by_eddit.My.Resources.Resources.icons8_create_24px
        Me.Usertext.ImageSize = New System.Drawing.Size(16, 18)
        Me.Usertext.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Usertext.Location = New System.Drawing.Point(6, 39)
        Me.Usertext.Name = "Usertext"
        Me.Usertext.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Usertext.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Usertext.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.Usertext.OnHoverImage = Nothing
        Me.Usertext.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Usertext.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Usertext.Radius = 5
        Me.Usertext.Size = New System.Drawing.Size(151, 23)
        Me.Usertext.TabIndex = 4
        '
        'EmoteElipse
        '
        Me.EmoteElipse.Radius = 20
        Me.EmoteElipse.TargetControl = Me.Emote
        '
        'AnimationShow
        '
        Me.AnimationShow.Enabled = True
        Me.AnimationShow.Interval = 50
        '
        'TimeDate
        '
        Me.TimeDate.Enabled = True
        Me.TimeDate.Interval = 1000
        '
        'AnimateEmoji
        '
        Me.AnimateEmoji.AnimationType = Guna.UI.Animation.AnimationType.Particles
        Me.AnimateEmoji.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 1
        Animation2.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 2.0!
        Animation2.TransparencyCoeff = 0!
        Me.AnimateEmoji.DefaultAnimation = Animation2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 745)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.Usertext)
        Me.Controls.Add(Me.cbModel)
        Me.Controls.Add(Me.txtMaxTokens)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.TopBar)
        Me.AnimateEmoji.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPT | By EDDIT"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Emote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FormElipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents ControlElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ControlElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ControlElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents DragMovement As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnswer As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelElipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents RichElipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtQuestion As RichTextBox
    Friend WithEvents PanelElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents RichElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents cbModel As ComboBox
    Friend WithEvents txtMaxTokens As TextBox
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents btnSend As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Thinking As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents Usertext As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label4 As Label
    Friend WithEvents EmoteElipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents AnimationShow As Timer
    Friend WithEvents time As Label
    Friend WithEvents TimeDate As Timer
    Friend WithEvents AnimateEmoji As Guna.UI.WinForms.GunaTransition
    Friend WithEvents Emote As Guna.UI.WinForms.GunaPictureBox
End Class
