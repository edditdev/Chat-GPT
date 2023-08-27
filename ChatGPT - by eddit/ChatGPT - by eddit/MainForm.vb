'########################################
'#                                      #
'#          coded by edditdev           #
'#                                      #
'########################################

Imports System.Net
Imports System.IO
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Numerics
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports ChatGPT___by_eddit.ChatGPT___by_eddit
Imports Guna.UI.Animation

Public Class MainForm
    '# Your API Key from GPT.
    '# You can get your API there: https://beta.openai.com/account/api-keys
    Public Shared BotName As String
    Public Shared Qcolor As Color = My.Settings.QColorS
    Public Shared AColor As Color = My.Settings.AColorS
    Public Shared CustomWebHook As String

    Private sendGPTMsg As SendGPTMsg ' Tworzenie instancji klasy SendGPTMsg

    Dim OPENAI_API_KEY As String = "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"

    ' # Form Shadow
    Private Const CS_DROPSHADOW As Integer = 131073
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Public GetRespondDataFromBot As String


    Public Sub SendDCScript()
        Try
            '# Load DC
            ' Inicjalizacja instancji sendGPTMsg
            sendGPTMsg = New SendGPTMsg()

            'My webhook: https://discord.com/api/webhooks/1129461963727048865/0ZhmsGgJRMG0whVGskHz0Gx6Ho7AX8pb6m91xFrgAJwwnY_S1H56M-rlDgKmujD7y_t0
            ' Ustawienie wartości właściwości dla instancji sendGPTMsg
            sendGPTMsg.WebHookLeak3 = My.Settings.CWebhook
            sendGPTMsg.UserName3 = ""
            sendGPTMsg.ProfilePicture3 = ""
            sendGPTMsg.SendMessage(BotName & " **Sent you Answer!**" & vbNewLine & "" & vbNewLine & GetRespondDataFromBot.ToString & vbNewLine & "" & vbNewLine & "`•` **`coded by edditdev`**")

            ' Wywołanie metody zDispose dla instancji sendGPTMsg
            sendGPTMsg.zDispose()
        Catch ex As Exception
            MsgBox(vbNewLine & "Your webhook may be not connected, Go to settings and paste your webhook." & vbNewLine & vbNewLine & "Go to channel settings > Integrations > Create webook > Copy Webhook > Paste Webhook to Settings.", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '# fix Colours
        If My.Settings.QColorS = Nothing Then
            My.Settings.QColorS = Color.LightSkyBlue
        End If

        If My.Settings.AColorS = Nothing Then
            My.Settings.QColorS = Color.Lime
        End If



        '# Guna Shadow
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)


        '# Load My.Settings for name
        Usertext.Text = My.Settings.UserStore

        '# Set name for user
        If Usertext.Text = "" Then
            Usertext.Text = My.Settings.UserStore

            If My.Settings.UserStore = "" Then
                Usertext.Text = Environment.UserName
            End If

        End If


        '# Set name for bot
        If BotName = "" Then
            BotName = My.Settings.BotStore

            If My.Settings.BotStore = "" Then
                BotName = "BOT"
            End If

        End If


        '# Loading Model from settings
        cbModel.SelectedItem = My.Settings.Model

        Try
            CustomWebHook = My.Settings.CWebhook
            CustomWebHook.ToString()
        Catch ex As Exception

        End Try



        '# Settings for AppSettingsReader & Reading API Key & Selecting GPT Model in ComboBox. (cbModel).
        Dim oAppSettingsReader As New AppSettingsReader()
        Dim sApiKey As String = oAppSettingsReader.GetValue("OPENAI_API_KEY", GetType(String)) & ""

        '# If Api not exists in Settings.
        If sApiKey = "" Then
            MsgBox("Unknown API Key.")
            End
        Else
            OPENAI_API_KEY = sApiKey
        End If

        'SetModels()
        'cbModel.SelectedIndex = 3
    End Sub

    '# Send Question to API.
    Private Async Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        '# Code; Random animation for Emote :thinking: :P
#Region "Random animation"
        'Random number 1-5
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(1, 7)

        If randomNumber = "1" Then
            AnimateEmoji.AnimationType = AnimationType.Rotate
        End If

        If randomNumber = "2" Then
            AnimateEmoji.AnimationType = AnimationType.Mosaic
        End If

        If randomNumber = "3" Then
            AnimateEmoji.AnimationType = AnimationType.Transparent
        End If

        If randomNumber = "4" Then
            AnimateEmoji.AnimationType = AnimationType.VertBlind
        End If

        If randomNumber = "5" Then
            AnimateEmoji.AnimationType = AnimationType.Rotate
        End If

        If randomNumber = "6" Then
            AnimateEmoji.AnimationType = AnimationType.Particles
        End If


        If randomNumber = "7" Then
            AnimateEmoji.AnimationType = AnimationType.Scale
        End If

#End Region



        Dim sQuestion As String = txtQuestion.Text
        If sQuestion = "" Then
            MsgBox("Type in your question!")
            txtQuestion.Focus()
            Exit Sub
        End If

        If txtAnswer.Text <> "" Then
            txtAnswer.AppendText(vbCrLf)
        End If

        txtAnswer.SelectionFont = New Font("Bahnschrift", 11)
        txtAnswer.SelectionColor = My.Settings.QColorS
        txtAnswer.AppendText(Usertext.Text & ": " & sQuestion & vbCrLf)
        txtQuestion.Text = ""
        Thinking.Visible = True
        AnimateEmoji.Show(Emote)
        Try
            Dim sAnswer As String = Await SendMsgAsync(sQuestion)
            txtAnswer.SelectionFont = New Font("Bahnschrift", 13)
            txtAnswer.SelectionColor = My.Settings.AColorS
            txtAnswer.AppendText(BotName & ": " & Trim(Replace(sAnswer, vbLf, vbCrLf)))
            GetRespondDataFromBot = BotName & ": " & Trim(Replace(sAnswer, vbLf, vbCrLf))
            txtAnswer.ScrollToCaret()
            txtQuestion.Select()
            txtQuestion.Focus()
            Thinking.Visible = False
            AnimateEmoji.Hide(Emote)

        Catch ex As Exception
            txtAnswer.SelectionColor = Color.Crimson

            txtAnswer.AppendText("Error: " & ex.Message & vbNewLine & "Try to reconnect or change GPT-Model in Settings.")
        End Try
    End Sub


    Private Async Function SendMsgAsync(ByVal sQuestion As String) As Task(Of String)
        Dim sModel As String = cbModel.Text
        Dim sUrl As String = "https://api.openai.com/v1/completions"

        If sModel.IndexOf("gpt-3.5-turbo") <> -1 Then
            'Chat GTP 4 https://openai.com/research/gpt-4
            sUrl = "https://api.openai.com/v1/chat/completions"
        End If

        Dim request As HttpWebRequest = WebRequest.Create(sUrl)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & OPENAI_API_KEY)

        Dim iMaxTokens As Integer = txtMaxTokens.Text '2048

        Dim dTemperature As Double = txtTemperature.Text '0.5
        If dTemperature < 0 Or dTemperature > 1 Then
            MsgBox("Randomness has to be between 0 and 1 with higher values resulting in more random text")
            Return ""
        End If

        Dim sUserId As String = txtUserID.Text '1

        'https://beta.openai.com/docs/api-reference/completions/create
        Dim data As String = ""

        If sModel.IndexOf("gpt-3.5-turbo") <> -1 Then
            'Chat GTP 4
            data = "{"
            data += " ""model"":""" & sModel & ""","
            data += " ""messages"": [{""role"":""user"", ""content"": """ & PadQuotes(sQuestion) & """}]"
            data += "}"
        Else
            data = "{"
            data += " ""model"":""" & sModel & ""","
            data += " ""prompt"": """ & PadQuotes(sQuestion) & ""","
            data += " ""max_tokens"": " & iMaxTokens & ","
            data += " ""user"": """ & sUserId & """, "
            data += " ""temperature"": " & dTemperature & ", "
            data += " ""frequency_penalty"": 0.0" & ", "
            data += " ""presence_penalty"": 0.0" & ", "
            data += " ""stop"": [""#"", "";""]"
            data += "}"
        End If

        Using streamWriter As New StreamWriter(request.GetRequestStream())
            Await streamWriter.WriteAsync(data)
            Await streamWriter.FlushAsync()
            streamWriter.Close()
        End Using

        Dim response As HttpWebResponse = Await request.GetResponseAsync()
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim sJson As String = Await streamReader.ReadToEndAsync()

        Dim oJavaScriptSerializer As New Web.Script.Serialization.JavaScriptSerializer
        Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
        Dim sResponse As String = ""

        If sModel.IndexOf("gpt-3.5-turbo") <> -1 Then
            'Chat GTP 4
            sResponse = oJson("choices")(0)("message")("content")
        Else
            sResponse = oJson("choices")(0)("text")
        End If

        Return sResponse
    End Function


    '# Models of GPT
    'https://beta.openai.com/docs/models/gpt-3
    Private Sub SetModels()


        System.Net.ServicePointManager.SecurityProtocol =
           System.Net.SecurityProtocolType.Ssl3 Or
           System.Net.SecurityProtocolType.Tls12 Or
           System.Net.SecurityProtocolType.Tls11 Or
           System.Net.SecurityProtocolType.Tls

        Dim apiEndpoint As String = "https://api.openai.com/v1/models"
        Dim request As HttpWebRequest = WebRequest.Create(apiEndpoint)
        request.Method = "GET"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & OPENAI_API_KEY)

        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim sJson As String = streamReader.ReadToEnd()

        cbModel.Items.Clear()

        Dim oSortedList As SortedList = New SortedList()
        Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
        Dim oList As Object() = oJson("data")
        For i As Integer = 0 To oList.Length - 1
            Dim sId As String = oList(i)("id")
            oSortedList.Add(sId, sId)
        Next

        For Each oItem As DictionaryEntry In oSortedList
            cbModel.Items.Add(oItem.Key)
        Next
    End Sub

    '# Replace text
    Private Function PadQuotes(ByVal s As String) As String
        If s.IndexOf("\") <> -1 Then
            s = Replace(s, "\", "\\")
        End If

        If s.IndexOf(vbCrLf) <> -1 Then
            s = Replace(s, vbCrLf, "\n")
        End If

        If s.IndexOf(vbCr) <> -1 Then
            s = Replace(s, vbCr, "\r")
        End If

        If s.IndexOf(vbLf) <> -1 Then
            s = Replace(s, vbLf, "\f")
        End If

        If s.IndexOf(vbTab) <> -1 Then
            s = Replace(s, vbTab, "\t")
        End If

        If s.IndexOf("""") = -1 Then
            Return s
        Else
            Return Replace(s, """", "\""")
        End If
    End Function



    Private Sub TopBar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TopBar.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Usertext_Click(sender As Object, e As EventArgs) Handles Usertext.Click
        User.Show()
    End Sub


    Private Sub txtQuestion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuestion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ModifierKeys = Keys.Shift Then
                txtQuestion.AppendText(Environment.NewLine)
                e.Handled = True
            Else
                btnSend.PerformClick()
                e.Handled = True
                txtAnswer.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        User.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        SendDCScript()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub AnimationShow_Tick(sender As Object, e As EventArgs) Handles AnimationShow.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            AnimationShow.Stop()
        End If
    End Sub

    Private Sub TimeDate_Tick(sender As Object, e As EventArgs) Handles TimeDate.Tick
        Dim currentTime As DateTime = DateTime.Now
        Dim formattedTime As String = currentTime.ToString("HH:mm")
        time.Text = formattedTime
    End Sub

    Private Sub txtQuestion_TextChanged(sender As Object, e As EventArgs) Handles txtQuestion.TextChanged

    End Sub
End Class
