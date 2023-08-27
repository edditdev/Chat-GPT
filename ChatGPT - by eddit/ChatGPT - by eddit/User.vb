Imports System.Net
Imports System.Web.Compilation
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class User
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '# Load Shadow
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        '# Load currect data for USER
        Try
            UserInput.Text = My.Settings.UserStore
            If UserInput.Text = "" Then
                UserInput.Text = Environment.UserName

            End If
        Catch ex As Exception

        End Try

        '# Load currect data  for BOT
        Try
            BotInput.Text = My.Settings.BotStore
            If BotInput.Text = "null" Then
                BotInput.Text = "BOT"

            End If
        Catch ex As Exception

        End Try

        '# Try to load checked color box
        qColor1.Checked = My.Settings.QBox1
        qColor2.Checked = My.Settings.QBox2
        qColor3.Checked = My.Settings.QBox3
        rColor1.Checked = My.Settings.RBox1
        rColor2.Checked = My.Settings.RBox2
        rColor3.Checked = My.Settings.RBox3
        rColor4.Checked = My.Settings.RBox4

        '# Loading Model from settings
        ' GunaComboBox1.SelectedItem = My.Settings.Model
        GunaComboBox1.SelectedItem = MainForm.cbModel.SelectedItem


        '# Load Webhook to Textbox
        WebhookText.Text = My.Settings.CWebhook.Trim
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click



        My.Settings.UserStore = UserInput.Text
        My.Settings.Save()


        If UserInput.Text = "" Then
            MainForm.Usertext.Text = Environment.UserName
        End If
        MainForm.Usertext.Text = My.Settings.UserStore
    End Sub

    Private Sub BtnSend2_Click(sender As Object, e As EventArgs) Handles BtnSend2.Click
        My.Settings.BotStore = BotInput.Text
        My.Settings.Save()


        If MainForm.BotName = "" Then
            MainForm.BotName = "BOT"
        End If
        MainForm.BotName = My.Settings.BotStore

    End Sub

    Private Sub qColor1_Click(sender As Object, e As EventArgs) Handles qColor1.Click
        My.Settings.QColorS = Color.Lime
        My.Settings.Save()

        My.Settings.QBox1 = qColor1.Checked
        My.Settings.Save()
    End Sub

    Private Sub qColor2_Click(sender As Object, e As EventArgs) Handles qColor2.Click
        My.Settings.QColorS = Color.Crimson
        My.Settings.Save()


        My.Settings.QBox2 = qColor2.Checked
        My.Settings.Save()
    End Sub

    Private Sub qColor3_Click(sender As Object, e As EventArgs) Handles qColor3.Click
        My.Settings.QColorS = Color.DodgerBlue
        My.Settings.Save()

        My.Settings.QBox3 = qColor3.Checked
        My.Settings.Save()
    End Sub

    Private Sub rColor1_Click(sender As Object, e As EventArgs) Handles rColor1.Click
        My.Settings.AColorS = Color.Lime
        My.Settings.Save()

        My.Settings.RBox1 = rColor1.Checked
        My.Settings.Save()
    End Sub

    Private Sub rColor2_Click(sender As Object, e As EventArgs) Handles rColor2.Click
        My.Settings.AColorS = Color.Crimson
        My.Settings.Save()

        My.Settings.RBox2 = rColor2.Checked
        My.Settings.Save()
    End Sub

    Private Sub rColor3_Click(sender As Object, e As EventArgs) Handles rColor3.Click
        My.Settings.AColorS = Color.DodgerBlue
        My.Settings.Save()

        My.Settings.RBox3 = rColor3.Checked
        My.Settings.Save()
    End Sub

    Private Sub rColor4_Click(sender As Object, e As EventArgs) Handles rColor4.Click
        My.Settings.AColorS = Color.White
        My.Settings.Save()

        My.Settings.RBox4 = rColor4.Checked
        My.Settings.Save()
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        MainForm.cbModel.SelectedItem = GunaComboBox1.SelectedItem
        My.Settings.Model = MainForm.cbModel.SelectedItem
        My.Settings.Save()
    End Sub

    Private Async Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Try
            Dim Results As String = Await New WebClient().DownloadStringTaskAsync("https://pastebin.com/raw/ihTXpFXe")
            MainForm.txtQuestion.Text = Results.ToString
        Catch ex As Exception

        End Try
        MainForm.btnSend.PerformClick()
    End Sub

    Private Sub SaveWebHook_Click(sender As Object, e As EventArgs)
        My.Settings.CWebhook = WebhookText.Text
        My.Settings.Save()
    End Sub

    Private Sub AnimShow_Tick(sender As Object, e As EventArgs) Handles AnimShow.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            AnimShow.Stop()
        End If
    End Sub

    Private Sub SaveWebHook_Click_1(sender As Object, e As EventArgs) Handles SaveWebHook.Click
        My.Settings.CWebhook = WebhookText.Text
        My.Settings.Save()
    End Sub
End Class