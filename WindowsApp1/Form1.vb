Public Class Form1
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        WebBrowser1.Navigate(SearchBox.Text)
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        If WebBrowser1.IsBusy = True Then
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            ProgressBar1.Value = 1
        End If
    End Sub
    Private Sub Search_Enter(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Search.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            WebBrowser1.Navigate(SearchBox.Text)
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = True
            Me.Text = WebBrowser1.StatusText
        End If
        If WebBrowser1.IsBusy = True Then
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            ProgressBar1.Value = 1
        End If

    End Sub


    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        WebBrowser1.GoBack()
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        If WebBrowser1.IsBusy = True Then
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            ProgressBar1.Value = 1
        End If
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        If WebBrowser1.IsBusy = True Then
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            ProgressBar1.Value = 1
        End If
    End Sub

    Private Sub Ref_Click(sender As Object, e As EventArgs) Handles ref.Click
        WebBrowser1.Refresh()
        Me.Text = WebBrowser1.StatusText
        Timer1.Enabled = True
        Me.Text = WebBrowser1.StatusText
        If WebBrowser1.IsBusy = True Then
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            ProgressBar1.Value = 1
        End If
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
        End If
        If WebBrowser1.IsBusy = True Then
            Me.Text = WebBrowser1.StatusText
        Else
            Me.Text = WebBrowser1.StatusText
            Timer1.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            ProgressBar1.Value = 1
        End If
    End Sub


End Class
