Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmission(currentIndex)
        Me.KeyPreview = True
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim data As String = Await response.Content.ReadAsStringAsync()
                Dim json As JObject = JObject.Parse(data)

                If json("success").Value(Of Boolean)() Then
                    Dim submission As JObject = json("submission")

                    txtName.Text = submission("name").ToString()
                    txtEmail.Text = submission("email").ToString()
                    txtPhone.Text = submission("phone").ToString()
                    txtGithubLink.Text = submission("github_link").ToString()
                    txtStopwatchTime.Text = submission("stopwatch_time").ToString()
                Else
                    MessageBox.Show("No submission found.")
                End If
            Else
                MessageBox.Show("Error fetching submission data from server.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading submission: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
