

Public Class Form1
    Public thingToSearch As String = "."
    Public google As String = "google.com/search?q="
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenwidth As Integer = My.Computer.Screen.Bounds.Width
        Dim screenheight As Integer = My.Computer.Screen.Bounds.Height
        Me.Width = screenwidth
        Me.Height = screenheight
        WebBrowser1.Width = screenwidth
        WebBrowser1.Height = screenheight

    End Sub
    Private Sub Search_Enter(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        If e.KeyChar = Convert.ToChar(13) Then
            Me.Text = WebBrowser1.StatusText

            If SearchBox.Text.IndexOf(thingToSearch) > -1 Then
                Me.Text = WebBrowser1.StatusText
                WebBrowser1.Navigate(SearchBox.Text)
                Me.Text = WebBrowser1.StatusText
            Else
                Me.Text = WebBrowser1.StatusText
                SearchBox.Text = google + SearchBox.Text
                WebBrowser1.Navigate(SearchBox.Text)
                Me.Text = WebBrowser1.StatusText
            End If
        End If

    End Sub


    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        WebBrowser1.GoBack()
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = False

    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        WebBrowser1.GoForward()
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = False


    End Sub

    Private Sub Ref_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        End If
    End Sub

    Private Sub SearchBox_(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SearchBox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            WebBrowser1.Navigate(SearchBox.Text)
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = True
            Me.Text = WebBrowser1.StatusText
            If SearchBox.Text.IndexOf(thingToSearch) > -1 Then
                Me.Text = WebBrowser1.StatusText
                WebBrowser1.Navigate(SearchBox.Text)
                Me.Text = WebBrowser1.StatusText
            Else
                Me.Text = WebBrowser1.StatusText
                SearchBox.Text = google + SearchBox.Text
                WebBrowser1.Navigate(SearchBox.Text)
                Me.Text = WebBrowser1.StatusText
            End If
        End If

    End Sub

    Public Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = False
        Me.Text = WebBrowser1.StatusText
        ProgressBar1.Value = ProgressBar1.Maximum
        ProgressBar1.Value = 1
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = True
        WebBrowser1.Refresh()
        If WebBrowser1.IsBusy = False Then
            Timer1.Enabled = False
        End If
        Me.Text = WebBrowser1.StatusText



    End Sub

    Private Sub Tl_Click(sender As Object, e As EventArgs) Handles Tl.Click
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        WebBrowser1.Navigate(SearchBox.Text)
        Me.Text = WebBrowser1.StatusText
        If SearchBox.Text.IndexOf(thingToSearch) > -1 Then
            Me.Text = WebBrowser1.StatusText
            WebBrowser1.Navigate(SearchBox.Text)
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            SearchBox.Text = google + SearchBox.Text
            WebBrowser1.Navigate(SearchBox.Text)
            Me.Text = WebBrowser1.StatusText
        End If
    End Sub
End Class
