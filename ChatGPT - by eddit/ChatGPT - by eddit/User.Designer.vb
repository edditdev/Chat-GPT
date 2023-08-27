<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DragMovmenet = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.FormElipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserInput = New Guna.UI.WinForms.GunaTextBox()
        Me.BotInput = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qColor1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.qColor2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.qColor3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rColor3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rColor2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rColor1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rColor4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WebhookText = New Guna.UI.WinForms.GunaTextBox()
        Me.SaveWebHook = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BtnSend2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSend = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AnimShow = New System.Windows.Forms.Timer(Me.components)
        Me.TopBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopBar
        '
        Me.TopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TopBar.Controls.Add(Me.Label4)
        Me.TopBar.Controls.Add(Me.GunaControlBox1)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Controls.Add(Me.PictureBox1)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(577, 33)
        Me.TopBar.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label4.Location = New System.Drawing.Point(92, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "by edditdev"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.Color.LightSteelBlue
        Me.GunaControlBox1.IconSize = 12.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(548, 4)
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
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(30, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CHAT GPT"
        '
        'DragMovmenet
        '
        Me.DragMovmenet.TargetControl = Me.TopBar
        '
        'FormElipse
        '
        Me.FormElipse.Radius = 5
        Me.FormElipse.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How to address you?"
        '
        'UserInput
        '
        Me.UserInput.BackColor = System.Drawing.Color.Transparent
        Me.UserInput.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.UserInput.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.UserInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserInput.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.UserInput.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.UserInput.FocusedForeColor = System.Drawing.Color.White
        Me.UserInput.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserInput.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.UserInput.Location = New System.Drawing.Point(19, 76)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserInput.Radius = 5
        Me.UserInput.Size = New System.Drawing.Size(296, 30)
        Me.UserInput.TabIndex = 4
        Me.UserInput.Text = "null"
        '
        'BotInput
        '
        Me.BotInput.BackColor = System.Drawing.Color.Transparent
        Me.BotInput.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BotInput.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BotInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BotInput.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BotInput.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BotInput.FocusedForeColor = System.Drawing.Color.White
        Me.BotInput.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BotInput.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BotInput.Location = New System.Drawing.Point(20, 144)
        Me.BotInput.Name = "BotInput"
        Me.BotInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BotInput.Radius = 5
        Me.BotInput.Size = New System.Drawing.Size(296, 30)
        Me.BotInput.TabIndex = 7
        Me.BotInput.Text = "null"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(17, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BOT Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Location = New System.Drawing.Point(17, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Respond color"
        '
        'qColor1
        '
        Me.qColor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qColor1.AnimationHoverSpeed = 0.07!
        Me.qColor1.AnimationSpeed = 0.03!
        Me.qColor1.BackColor = System.Drawing.Color.Transparent
        Me.qColor1.BaseColor = System.Drawing.Color.Lime
        Me.qColor1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.qColor1.BorderSize = 3
        Me.qColor1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.qColor1.CheckedBaseColor = System.Drawing.Color.Lime
        Me.qColor1.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.qColor1.CheckedForeColor = System.Drawing.Color.White
        Me.qColor1.CheckedImage = Nothing
        Me.qColor1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.qColor1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.qColor1.FocusedColor = System.Drawing.Color.Empty
        Me.qColor1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.qColor1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.qColor1.Image = Nothing
        Me.qColor1.ImageSize = New System.Drawing.Size(16, 16)
        Me.qColor1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qColor1.Location = New System.Drawing.Point(3, 5)
        Me.qColor1.Name = "qColor1"
        Me.qColor1.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.qColor1.OnHoverBorderColor = System.Drawing.Color.Lime
        Me.qColor1.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.qColor1.OnHoverImage = Nothing
        Me.qColor1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qColor1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.qColor1.Radius = 5
        Me.qColor1.Size = New System.Drawing.Size(22, 21)
        Me.qColor1.TabIndex = 14
        '
        'qColor2
        '
        Me.qColor2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qColor2.AnimationHoverSpeed = 0.07!
        Me.qColor2.AnimationSpeed = 0.03!
        Me.qColor2.BackColor = System.Drawing.Color.Transparent
        Me.qColor2.BaseColor = System.Drawing.Color.Crimson
        Me.qColor2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.qColor2.BorderSize = 3
        Me.qColor2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.qColor2.CheckedBaseColor = System.Drawing.Color.Crimson
        Me.qColor2.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.qColor2.CheckedForeColor = System.Drawing.Color.White
        Me.qColor2.CheckedImage = Nothing
        Me.qColor2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.qColor2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.qColor2.FocusedColor = System.Drawing.Color.Empty
        Me.qColor2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.qColor2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.qColor2.Image = Nothing
        Me.qColor2.ImageSize = New System.Drawing.Size(16, 16)
        Me.qColor2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qColor2.Location = New System.Drawing.Point(31, 5)
        Me.qColor2.Name = "qColor2"
        Me.qColor2.OnHoverBaseColor = System.Drawing.Color.Crimson
        Me.qColor2.OnHoverBorderColor = System.Drawing.Color.Crimson
        Me.qColor2.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.qColor2.OnHoverImage = Nothing
        Me.qColor2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qColor2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.qColor2.Radius = 5
        Me.qColor2.Size = New System.Drawing.Size(22, 21)
        Me.qColor2.TabIndex = 15
        '
        'qColor3
        '
        Me.qColor3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qColor3.AnimationHoverSpeed = 0.07!
        Me.qColor3.AnimationSpeed = 0.03!
        Me.qColor3.BackColor = System.Drawing.Color.Transparent
        Me.qColor3.BaseColor = System.Drawing.Color.DodgerBlue
        Me.qColor3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.qColor3.BorderSize = 3
        Me.qColor3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.qColor3.CheckedBaseColor = System.Drawing.Color.DodgerBlue
        Me.qColor3.CheckedBorderColor = System.Drawing.Color.DodgerBlue
        Me.qColor3.CheckedForeColor = System.Drawing.Color.White
        Me.qColor3.CheckedImage = Nothing
        Me.qColor3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.qColor3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.qColor3.FocusedColor = System.Drawing.Color.Empty
        Me.qColor3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.qColor3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.qColor3.Image = Nothing
        Me.qColor3.ImageSize = New System.Drawing.Size(16, 16)
        Me.qColor3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qColor3.Location = New System.Drawing.Point(59, 5)
        Me.qColor3.Name = "qColor3"
        Me.qColor3.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.qColor3.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.qColor3.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.qColor3.OnHoverImage = Nothing
        Me.qColor3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qColor3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.qColor3.Radius = 5
        Me.qColor3.Size = New System.Drawing.Size(22, 21)
        Me.qColor3.TabIndex = 16
        '
        'rColor3
        '
        Me.rColor3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rColor3.AnimationHoverSpeed = 0.07!
        Me.rColor3.AnimationSpeed = 0.03!
        Me.rColor3.BackColor = System.Drawing.Color.Transparent
        Me.rColor3.BaseColor = System.Drawing.Color.DodgerBlue
        Me.rColor3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rColor3.BorderSize = 3
        Me.rColor3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.rColor3.CheckedBaseColor = System.Drawing.Color.DodgerBlue
        Me.rColor3.CheckedBorderColor = System.Drawing.Color.DodgerBlue
        Me.rColor3.CheckedForeColor = System.Drawing.Color.White
        Me.rColor3.CheckedImage = Nothing
        Me.rColor3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.rColor3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rColor3.FocusedColor = System.Drawing.Color.Empty
        Me.rColor3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rColor3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor3.Image = Nothing
        Me.rColor3.ImageSize = New System.Drawing.Size(16, 16)
        Me.rColor3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor3.Location = New System.Drawing.Point(60, 2)
        Me.rColor3.Name = "rColor3"
        Me.rColor3.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.rColor3.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.rColor3.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor3.OnHoverImage = Nothing
        Me.rColor3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.rColor3.Radius = 5
        Me.rColor3.Size = New System.Drawing.Size(22, 21)
        Me.rColor3.TabIndex = 19
        '
        'rColor2
        '
        Me.rColor2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rColor2.AnimationHoverSpeed = 0.07!
        Me.rColor2.AnimationSpeed = 0.03!
        Me.rColor2.BackColor = System.Drawing.Color.Transparent
        Me.rColor2.BaseColor = System.Drawing.Color.Crimson
        Me.rColor2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rColor2.BorderSize = 3
        Me.rColor2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.rColor2.CheckedBaseColor = System.Drawing.Color.Crimson
        Me.rColor2.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.rColor2.CheckedForeColor = System.Drawing.Color.White
        Me.rColor2.CheckedImage = Nothing
        Me.rColor2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.rColor2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rColor2.FocusedColor = System.Drawing.Color.Empty
        Me.rColor2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rColor2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor2.Image = Nothing
        Me.rColor2.ImageSize = New System.Drawing.Size(16, 16)
        Me.rColor2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor2.Location = New System.Drawing.Point(32, 2)
        Me.rColor2.Name = "rColor2"
        Me.rColor2.OnHoverBaseColor = System.Drawing.Color.Crimson
        Me.rColor2.OnHoverBorderColor = System.Drawing.Color.Crimson
        Me.rColor2.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor2.OnHoverImage = Nothing
        Me.rColor2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.rColor2.Radius = 5
        Me.rColor2.Size = New System.Drawing.Size(22, 21)
        Me.rColor2.TabIndex = 18
        '
        'rColor1
        '
        Me.rColor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rColor1.AnimationHoverSpeed = 0.07!
        Me.rColor1.AnimationSpeed = 0.03!
        Me.rColor1.BackColor = System.Drawing.Color.Transparent
        Me.rColor1.BaseColor = System.Drawing.Color.Lime
        Me.rColor1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rColor1.BorderSize = 3
        Me.rColor1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.rColor1.CheckedBaseColor = System.Drawing.Color.Lime
        Me.rColor1.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.rColor1.CheckedForeColor = System.Drawing.Color.White
        Me.rColor1.CheckedImage = Nothing
        Me.rColor1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.rColor1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rColor1.FocusedColor = System.Drawing.Color.Empty
        Me.rColor1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rColor1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor1.Image = Nothing
        Me.rColor1.ImageSize = New System.Drawing.Size(16, 16)
        Me.rColor1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor1.Location = New System.Drawing.Point(4, 2)
        Me.rColor1.Name = "rColor1"
        Me.rColor1.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.rColor1.OnHoverBorderColor = System.Drawing.Color.Lime
        Me.rColor1.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor1.OnHoverImage = Nothing
        Me.rColor1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.rColor1.Radius = 5
        Me.rColor1.Size = New System.Drawing.Size(22, 21)
        Me.rColor1.TabIndex = 17
        '
        'rColor4
        '
        Me.rColor4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rColor4.AnimationHoverSpeed = 0.07!
        Me.rColor4.AnimationSpeed = 0.03!
        Me.rColor4.BackColor = System.Drawing.Color.Transparent
        Me.rColor4.BaseColor = System.Drawing.Color.White
        Me.rColor4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rColor4.BorderSize = 3
        Me.rColor4.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.rColor4.CheckedBaseColor = System.Drawing.Color.White
        Me.rColor4.CheckedBorderColor = System.Drawing.Color.White
        Me.rColor4.CheckedForeColor = System.Drawing.Color.White
        Me.rColor4.CheckedImage = Nothing
        Me.rColor4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.rColor4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rColor4.FocusedColor = System.Drawing.Color.Empty
        Me.rColor4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rColor4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor4.Image = Nothing
        Me.rColor4.ImageSize = New System.Drawing.Size(16, 16)
        Me.rColor4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor4.Location = New System.Drawing.Point(88, 2)
        Me.rColor4.Name = "rColor4"
        Me.rColor4.OnHoverBaseColor = System.Drawing.Color.White
        Me.rColor4.OnHoverBorderColor = System.Drawing.Color.White
        Me.rColor4.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.rColor4.OnHoverImage = Nothing
        Me.rColor4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rColor4.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.rColor4.Radius = 5
        Me.rColor4.Size = New System.Drawing.Size(22, 21)
        Me.rColor4.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.qColor1)
        Me.Panel1.Controls.Add(Me.qColor2)
        Me.Panel1.Controls.Add(Me.qColor3)
        Me.Panel1.Location = New System.Drawing.Point(21, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 29)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rColor1)
        Me.Panel2.Controls.Add(Me.rColor2)
        Me.Panel2.Controls.Add(Me.rColor4)
        Me.Panel2.Controls.Add(Me.rColor3)
        Me.Panel2.Location = New System.Drawing.Point(19, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(113, 26)
        Me.Panel2.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(17, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Question color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label7.Location = New System.Drawing.Point(181, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 22)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Chat GPT Model"
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Items.AddRange(New Object() {"text-davinci-003", "text-davinci-002", "code-davinci-002", "gpt-3.5-turbo", "gpt-3.5-turbo-0301", "gpt-3.5-turbo-16k-0613", "gpt-3.5-turbo-0613"})
        Me.GunaComboBox1.Location = New System.Drawing.Point(185, 219)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.LightSteelBlue
        Me.GunaComboBox1.Radius = 3
        Me.GunaComboBox1.Size = New System.Drawing.Size(155, 26)
        Me.GunaComboBox1.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Location = New System.Drawing.Point(181, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 22)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Jailbreaks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.Location = New System.Drawing.Point(20, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 22)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Discord Webhook"
        '
        'WebhookText
        '
        Me.WebhookText.BackColor = System.Drawing.Color.Transparent
        Me.WebhookText.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.WebhookText.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.WebhookText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.WebhookText.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.WebhookText.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.WebhookText.FocusedForeColor = System.Drawing.Color.White
        Me.WebhookText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.WebhookText.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.WebhookText.Location = New System.Drawing.Point(21, 350)
        Me.WebhookText.Name = "WebhookText"
        Me.WebhookText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WebhookText.Radius = 5
        Me.WebhookText.Size = New System.Drawing.Size(469, 30)
        Me.WebhookText.TabIndex = 28
        Me.WebhookText.Text = "null"
        '
        'SaveWebHook
        '
        Me.SaveWebHook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveWebHook.Animated = True
        Me.SaveWebHook.AnimationHoverSpeed = 0.07!
        Me.SaveWebHook.AnimationSpeed = 0.03!
        Me.SaveWebHook.BackColor = System.Drawing.Color.Transparent
        Me.SaveWebHook.BaseColor = System.Drawing.Color.Transparent
        Me.SaveWebHook.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.SaveWebHook.BorderSize = 2
        Me.SaveWebHook.CheckedBaseColor = System.Drawing.Color.Gray
        Me.SaveWebHook.CheckedBorderColor = System.Drawing.Color.Black
        Me.SaveWebHook.CheckedForeColor = System.Drawing.Color.White
        Me.SaveWebHook.CheckedImage = CType(resources.GetObject("SaveWebHook.CheckedImage"), System.Drawing.Image)
        Me.SaveWebHook.CheckedLineColor = System.Drawing.Color.DimGray
        Me.SaveWebHook.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SaveWebHook.FocusedColor = System.Drawing.Color.Empty
        Me.SaveWebHook.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.SaveWebHook.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.SaveWebHook.Image = Nothing
        Me.SaveWebHook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SaveWebHook.ImageSize = New System.Drawing.Size(20, 20)
        Me.SaveWebHook.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SaveWebHook.Location = New System.Drawing.Point(496, 350)
        Me.SaveWebHook.Name = "SaveWebHook"
        Me.SaveWebHook.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.SaveWebHook.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.SaveWebHook.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.SaveWebHook.OnHoverImage = Nothing
        Me.SaveWebHook.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SaveWebHook.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.SaveWebHook.Radius = 5
        Me.SaveWebHook.Size = New System.Drawing.Size(60, 30)
        Me.SaveWebHook.TabIndex = 29
        Me.SaveWebHook.Text = "Save"
        Me.SaveWebHook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaAdvenceButton1.BorderSize = 2
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(186, 273)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(130, 30)
        Me.GunaAdvenceButton1.TabIndex = 25
        Me.GunaAdvenceButton1.Text = "Load DAN Jailbreak"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSend2
        '
        Me.BtnSend2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSend2.Animated = True
        Me.BtnSend2.AnimationHoverSpeed = 0.07!
        Me.BtnSend2.AnimationSpeed = 0.03!
        Me.BtnSend2.BackColor = System.Drawing.Color.Transparent
        Me.BtnSend2.BaseColor = System.Drawing.Color.Transparent
        Me.BtnSend2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend2.BorderSize = 2
        Me.BtnSend2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BtnSend2.CheckedBorderColor = System.Drawing.Color.Black
        Me.BtnSend2.CheckedForeColor = System.Drawing.Color.White
        Me.BtnSend2.CheckedImage = CType(resources.GetObject("BtnSend2.CheckedImage"), System.Drawing.Image)
        Me.BtnSend2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BtnSend2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnSend2.FocusedColor = System.Drawing.Color.Empty
        Me.BtnSend2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.BtnSend2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSend2.Image = Nothing
        Me.BtnSend2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnSend2.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnSend2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSend2.Location = New System.Drawing.Point(322, 144)
        Me.BtnSend2.Name = "BtnSend2"
        Me.BtnSend2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend2.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSend2.OnHoverImage = Nothing
        Me.BtnSend2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSend2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend2.Radius = 5
        Me.BtnSend2.Size = New System.Drawing.Size(60, 30)
        Me.BtnSend2.TabIndex = 8
        Me.BtnSend2.Text = "Save"
        Me.BtnSend2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSend.FocusedColor = System.Drawing.Color.Empty
        Me.btnSend.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSend.Image = Nothing
        Me.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSend.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSend.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSend.Location = New System.Drawing.Point(321, 76)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.OnHoverForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSend.OnHoverImage = Nothing
        Me.btnSend.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSend.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSend.Radius = 5
        Me.btnSend.Size = New System.Drawing.Size(60, 30)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Save"
        Me.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ChatGPT___by_eddit.My.Resources.Resources.icons8_cyclone_24px
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'AnimShow
        '
        Me.AnimShow.Enabled = True
        Me.AnimShow.Interval = 30
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 427)
        Me.Controls.Add(Me.SaveWebHook)
        Me.Controls.Add(Me.WebhookText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSend2)
        Me.Controls.Add(Me.BotInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.TopMost = True
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopBar As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DragMovmenet As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents FormElipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label2 As Label
    Friend WithEvents UserInput As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnSend As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BtnSend2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BotInput As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents qColor1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents qColor3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents qColor2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents rColor4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents rColor3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents rColor2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents rColor1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents SaveWebHook As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents WebhookText As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AnimShow As Timer
End Class
