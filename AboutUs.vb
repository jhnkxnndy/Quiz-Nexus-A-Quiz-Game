Public Class AboutUs
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SettingsFrm.TopLevel = True
        SettingsInterface.Guna2Panel1.Controls.Add(SettingsFrm)
        SettingsFrm.Show()
        SettingsFrm.BringToFront()
        SettingsFrm.Close()
    End Sub
End Class