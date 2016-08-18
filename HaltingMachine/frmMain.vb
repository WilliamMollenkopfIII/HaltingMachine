Public Class frmMain

    Private TimeoutTime As Integer = 1 * 60 * 100 ' Default: 10 minutes, 60 seconds per min, 100 milliseconds per second ? (thought it was 1000 but... vb.net says otherwise?)
    Private ProcessProperties As New ProcessStartInfo
    Private myProcess As Process
    Private percentCounter As Double = 0
    Private millisecondCounter As Double = 0

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        ToggleVisabilityAccessibility() ' assumed initalized by form design definition

        ' Calculate the time
        TimeoutTime = (txtHours.Text * 60 * 60 * 100) + (txtMinutes.Text * 60 * 100) + (txtSeconds.Text * 100)
        timerTimeout.Start() ' Start the timer

        ' Assign the process the file to use and execute
        Try
            ProcessProperties.FileName = txtFile.Text
            myProcess = Process.Start(ProcessProperties)
        Catch ex As Exception
            timerTimeout.Stop()
            MsgBox("An error has occured. Perhaps the filename and path are bad?")
            ToggleVisabilityAccessibility() ' assumed initalized by form design definition
        End Try

    End Sub

    Private Sub ToggleVisabilityAccessibility()
        txtFile.Enabled = Not txtFile.Enabled
        prgbarStatus.Visible = Not prgbarStatus.Visible
        btnRun.Enabled = Not btnRun.Enabled
        lblTimerDisplay.Visible = Not lblTimerDisplay.Visible
        lblPercent.Visible = Not lblPercent.Visible

        txtHours.Enabled = Not txtHours.Enabled
        txtMinutes.Enabled = Not txtMinutes.Enabled
        txtSeconds.Enabled = Not txtSeconds.Enabled
    End Sub
    Private Sub timerTimeout_Tick(sender As Object, e As EventArgs) Handles timerTimeout.Tick
        If prgbarStatus.Value < 100 Then
            millisecondCounter += 1
            percentCounter += 100 / TimeoutTime
            prgbarStatus.Value = percentCounter
            lblTimerDisplay.Text = getMinSecText(millisecondCounter) + " / " + getMinSecText(TimeoutTime / 10)
            lblPercent.Text = (Math.Round(percentCounter, 2)).ToString() + " / 100% "

            prgbarStatus.Refresh()

            If myProcess.HasExited Then
                ' All done
                timerTimeout.Stop()
                ToggleVisabilityAccessibility() ' make ready again for use
            End If
        Else
            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If
            timerTimeout.Stop()

            prgbarStatus.Value = 100
            ToggleVisabilityAccessibility() ' make ready again for use

        End If
    End Sub

    Private Function getMinSecText(milliseconds As Integer)
        ' Hours:Minutes:Seconds
        Return Math.Floor((milliseconds / 10 / 60 / 60)).ToString("00") + ":" + Math.Floor((milliseconds / 10 / 60)).ToString("00") + ":" + Math.Round(((milliseconds / 10) Mod 60), 2).ToString("00")
    End Function

    Private Sub time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress, txtMinutes.KeyPress
        'Source: http://stackoverflow.com/questions/9969824/vb-net-need-text-box-to-only-accept-numbers
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmPilot_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Display a MsgBox asking the user to save changes or abort.
        If Not IsNothing(myProcess) AndAlso Not myProcess.HasExited Then
            If MessageBox.Show("Are you sure? Closing this program will also attempt to force close """ + txtFile.Text + """ also.", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.No Then
                ' Cancel the Closing event from closing the form.
                e.Cancel = True
            Else
                myProcess.Kill() ' force this to close
            End If
        End If
    End Sub
End Class
