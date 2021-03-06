﻿Imports System.IO
Imports System.Security.Cryptography
Imports Hasher.Hashing

Public Class MainForm
    Private parentDirectory As String = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()

    Private targetPath As String
    Private algorithmName As String
    Private algorithmType As HashAlgorithm
    Private useSalt As Boolean

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.HashIcon
    End Sub

    ' Opens a file browser.
    ' The selected becomes the target file.
    Private Sub TargetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        openFileDialog.InitialDirectory = parentDirectory
        openFileDialog.Filter = "Text File (.txt)|*.txt"
        openFileDialog.ShowDialog()

        If File.Exists(openFileDialog.FileName) Then
            targetLabel.Text = openFileDialog.FileName
            targetPath = openFileDialog.FileName
        Else
            targetLabel.Text = "No Target Selected."
        End If
    End Sub

    ' Manages the wanted algorithm.
    Private Sub AlgorithmComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles algorithmComboBox.SelectedIndexChanged
        algorithmName = algorithmComboBox.SelectedItem()
        Select Case algorithmName.ToLower
            Case "sha512"
                algorithmType = New SHA512Managed()
            Case "sha384"
                algorithmType = New SHA384Managed()
            Case "sha256"
                algorithmType = New SHA256Managed()
            Case "sha1"
                algorithmType = New SHA1Managed()
            Case Else
                Throw New ArgumentOutOfRangeException()
        End Select
    End Sub

    ' Manages whether a salt will be used or not.
    Private Sub UseSaltCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles useSaltCheckBox.CheckedChanged
        If useSaltCheckBox.Checked Then
            saltSizeTextBox.Enabled = True
        Else
            saltSizeTextBox.Enabled = False
        End If
        useSalt = useSaltCheckBox.Checked
    End Sub

    Private Sub SaltSizeTextBox_Leave(sender As Object, e As EventArgs) Handles saltSizeTextBox.Leave
        If Not Integer.TryParse(saltSizeTextBox.Text, Nothing) Then
            saltSizeTextBox.Text = 20
            MessageBox.Show("Invalid Salt Size.")
        End If
    End Sub

    ' Makes sure everything is prepared for hashing.
    ' Hashes target and stores results in the selected storage path.
    Private Sub HashButton_Click(sender As Object, e As EventArgs) Handles hashButton.Click
        ' Validity Checks
        If Not File.Exists(targetPath) Then
            MessageBox.Show("Target Path Does Not Exist.")
            Exit Sub
        End If

        If algorithmComboBox.SelectedItem = String.Empty Then
            MessageBox.Show("No Hashing Algorithm Selected.")
            Exit Sub
        End If
        saveFileDialog.Filter = "Hash File (.hash)|*.hash"
        saveFileDialog.ShowDialog()

        If Path.GetExtension(saveFileDialog.FileName) <> ".hash" Then
            MessageBox.Show("File Must Be Saved As A '.hash' Format.")
            Exit Sub
        End If

        ' Hashing Process
        Dim reader As New StreamReader(targetPath)
        Dim writer As New StreamWriter(saveFileDialog.FileName)

        ' Hashes everyline of given file and writes the formatted properties to a specified file.
        Dim hasher As New HashBuilder(algorithmType, useSalt)
        Do
            Dim line = reader.ReadLine()
            Dim hash = hasher.Hash(line, saltSizeTextBox.Text)
            With hash
                writer.Write(String.Format("Hash: {0}, Salt: {1}, HashType: {2}{3}",
                                    .Hash,
                                    .Salt,
                                    algorithmName,
                                    Environment.NewLine))
            End With
        Loop Until reader.Peek() = -1
        reader.Close()
        writer.Close()
        MessageBox.Show("Done.")
    End Sub
End Class
