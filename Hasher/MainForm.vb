Imports System.IO
Imports System.Security.Cryptography

Public Class MainForm
    Private parentDirectory As String = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()

    Private targetPath As String
    Private algorithmName As String
    Private algorithmType As HashAlgorithm
    Private useSalt As Boolean

    ' Opens a file browser.
    ' The selected becomes the target file.
    Private Sub targetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        openFileDialog.Title = "Target Selection"
        openFileDialog.InitialDirectory = parentDirectory
        openFileDialog.ShowDialog()

        targetLabel.Text = openFileDialog.FileName
        targetPath = openFileDialog.FileName
    End Sub

    ' Manages the wanted algorithm.
    Private Sub algorithmComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles algorithmComboBox.SelectedIndexChanged
        algorithmName = algorithmComboBox.SelectedItem()
        algorithmType = getAlgorithmType(algorithmName)
    End Sub

    ' Manages whether a salt will be used or not.
    Private Sub useSaltCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles useSaltCheckBox.CheckedChanged
        If useSaltCheckBox.Checked Then
            saltSizeTextBox.Enabled = True
        Else
            saltSizeTextBox.Enabled = False
        End If
        useSalt = useSaltCheckBox.Checked
    End Sub

    ' Makes sure everything is prepared for hashing.
    ' Hashes target and stores results in the selected storage path.
    Private Sub hashButton_Click(sender As Object, e As EventArgs) Handles hashButton.Click
        ' For elegant purposes
        saveFileDialog.FileName = String.Empty

        If Not File.Exists(targetPath) Then
            MessageBox.Show("Target Path Does Not Exist.")
            Exit Sub
        End If

        saveFileDialog.Filter = "Hash Formatted File (.hff)|*.hff"
        saveFileDialog.ShowDialog()

        If Path.GetExtension(saveFileDialog.FileName) <> ".hff" Then
            MessageBox.Show("File Must Be Saved As A '.hff' Format.")
            Exit Sub
        End If

        Dim reader As New StreamReader(targetPath)
        Dim writer As New StreamWriter(saveFileDialog.FileName)

        ' Hashes everyline of given file and writes the properties to a new specified file.
        Dim hasher As New Hasher(algorithmType, useSalt)
        Do While reader.Peek() <> -1
            Dim line = reader.ReadLine()
            Dim hash = hasher.Hash(line, saltSizeTextBox.Text - 1)
            With hash
                writer.Write(String.Format("Hash: {0}, Salt: {1}, HashType: {2}{3}",
                                    .Hash,
                                    .Salt,
                                    algorithmName,
                                    Environment.NewLine))
            End With
        Loop
        reader.Close()
        writer.Close()
        MessageBox.Show("Done.")
    End Sub

    ' Non Handlers
    ' Returns the data type depening on the string given.
    Private Function getAlgorithmType(ByVal algorithm As String) As HashAlgorithm
        Select Case algorithm.ToLower
            Case "sha512"
                Return New SHA512Managed()
            Case "sha384"
                Return New SHA384Managed()
            Case "sha256"
                Return New SHA256Managed()
            Case "sha1"
                Return New SHA1Managed()
            Case Else
                Throw New ArgumentOutOfRangeException()
        End Select
    End Function
End Class
