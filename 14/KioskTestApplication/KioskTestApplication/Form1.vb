Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Xml
Imports Octokit

Public Class Form1




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim URI As String = "https://github.com/saravanaesakki/Mytestrep/blob/master/undefined"
        Dim REQ As HttpWebRequest = WebRequest.Create(URI)
        Dim svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes("saravanaesakki@gmail.com:gomathi1"))
        REQ.Headers.Add("Authorization", "Basic " + svcCredentials)
        Dim svcResponse As WebResponse = REQ.GetResponse()
        Dim Objstream As Stream = svcResponse.GetResponseStream
        'Objstream.Read(Buffer, 0, Objstream.Length)

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub repo(owner As String, name As String)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim URI As New System.Uri("https://api.github.com/authorizations")
        Dim data As String = "{""scopes"":[""repo""],""note"":""Create Repo with Ajax"",""client_id"":""6762780c0ec5c261bf96"",""client_secret"":""b3d3b4ea64392aef097a55f4292ba77520cf6738""}"
        'Dim wc As New WebClient
        'wc.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes("saravananesakki@gmail.com:gomathi1")))
        'AddHandler wc.UploadStringCompleted, AddressOf uploadcompleted
        'wc.UploadStringAsync(URI, "POST", data)

        Dim objprodheadervalue As New ProductHeaderValue("Haack-GitHub-Oauth-Demo")
        Dim authcred As New Octokit.Credentials("saravanaesakki@gmail.com", "gomathi1")
        Dim objcon As New Connection(objprodheadervalue)
        objcon.Credentials = authcred
        'Dim authscopes As New Dictionary(Of String, System.Uri)
        'authscopes.Add(data, URI)
        'Dim apival As New Octokit.ApiInfo(authscopes)
        'Dim result As Object = apival.OauthScopes

        Dim objresult As Object = Octokit.ApiUrls.Authorizations()
        Return
        'Dim authcre As New Octokit.Credentials("saravanaesakki@gmail.com", "gomathi1")
        'Dim tokenval As String = CredentialsExtensions.GetToken(authcre)


        'Dim objprodheadervalue As New ProductHeaderValue("Haack-GitHub-Oauth-Demo")
        'Dim authcred As New Octokit.Credentials("saravanaesakki@gmail.com", "gomathi1")
        'Dim objcon As New Connection(objprodheadervalue)
        'objcon.Credentials = authcre
        'Dim authresult As Object = Nothing
        'Dim URI As New System.Uri("https://api.github.com/authorizations")
        'Try


        '    Await Task.Run(Sub()

        '                       authresult = objcon.Get(Of String)(URI, New System.TimeSpan(1000))
        '                   End Sub)
        'Catch ex As Exception

        'End Try

        'Dim iconnect As IConnection = objcon

        'Dim oapiclent As New Octokit.ApiConnection(iconnect)
        'Await Task.Run(Sub()
        '                   Dim o As Object = oapiclent.Get(Of Object)(URI, Nothing)
        '               End Sub)


        'Dim auth As New Octokit.Authorization
        'Dim id As Object = auth.Id
        'Dim token As String = auth.HashedToken()


        'Dim oat As New Octokit.OauthToken
        'Dim authcre2 As New Octokit.Credentials("saravanaesakki@gmail.com", "gomathi1")

        'Dim client = New GitHubClient(New ProductHeaderValue("dotnet-test-functional"), New Uri("https://github.com/"))
        'client.Credentials = authcre
        'Dim objauth As IAuthorizationsClient = client.Authorization
        ''        client.Oauth.CreateAccessToken(New OauthTokenRequest(
        'Dim repo As Octokit.IRepositoriesClient = client.Repository
        'Dim newrepo As New NewRepository("myrep")
        'newrepo.Description = "myrep"
        'newrepo.AutoInit = True
        'Dim obj As Object = Nothing
        'Await Task.Run(Sub()
        '                   obj = repo.Create(newrepo)
        '               End Sub)


        ''Dim URI As New System.Uri("https://github.com/saravanaesakki/Hello")
        ''Dim data As String = "{{'name': 'Hello','description': 'This is your first repository','homepage': 'https://github.com', 'private': false, 'has_issues': true, 'has_wiki': true, 'has_downloads': true}"
        ''Dim wc As New WebClient
        ' ''AddHandler wc.UploadStringCompleted, uploadcompleted
        ''wc.UploadStringAsync(URI, "POST", data)

        'Dim URI As New System.Uri("https://github.com/chudsonsolomon/repos")

        'Dim data As String = "{'name': 'Hello1','description': 'This is your first repository','homepage': 'https://github.com', 'private': false, 'has_issues': true, 'has_wiki': true, 'has_downloads': true}"
        'Dim svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes("hudson4444@gmail.com:hudson4444"))
        'Dim wc As New WebClient
        'wc.Headers.Add("Authorization", "Basic " + svcCredentials)
        'AddHandler wc.UploadStringCompleted, AddressOf uploadcompleted
        'wc.UploadStringAsync(URI, "POST", data)
    End Sub

    Public Sub uploadcompleted(sender As Object, e As System.Net.UploadStringCompletedEventArgs)
        Try
            Dim result As Object = e.Result
        Catch ex As Exception
            lblmessage.Text = ex.InnerException.ToString
        End Try

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim objcon As New Connection(New ProductHeaderValue("Haack-GitHub-Oauth-Demo"), New System.Uri("https://api.github.com/"))
        objcon.Credentials = New Octokit.Credentials("ramu1512@gmail.com", "welcome100")
        Dim objapicon As New ApiConnection(objcon)
        Dim iapicon As IApiConnection = objapicon
        Dim repoclient As New RepositoriesClient(iapicon)
        Dim newrepo As New NewRepository("repfirst")
        newrepo.Description = "repfirst"
        newrepo.AutoInit = True
        'repoclient.Create(newrepo)
        Dim getrepo As Object = repoclient.Get("a", "a")


        'Dim repofileclient As New RepositoryContentsClient(iapicon)
        'Dim repcont As New RepositoryContent
        'Dim path As String = "D:\1.txt"
        'Dim obj As New Octokit.CreateFileRequest("HAi", "hi")
        'repofileclient.CreateFile("ramu1512@gmail.com", "ramalakshmin", path, obj)

        'Dim authclient As New AuthorizationsClient(iapicon)
        'Dim octoauth As New Octokit.NewAuthorization()
        'octoauth.Note = "Created from samples"
        'Dim scopelist As New List(Of String)
        'scopelist.Add("repo")
        'octoauth.Scopes = scopelist
        'authclient.Create(

     
        'repoclient.Create(newrepo)

    End Sub
End Class
