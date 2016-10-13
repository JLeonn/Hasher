<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.storageLabel = New System.Windows.Forms.Label()
        Me.storageButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.targetLabel = New System.Windows.Forms.Label()
        Me.targetButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saltSizeTextBox = New System.Windows.Forms.TextBox()
        Me.useSaltCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.algorithmComboBox = New System.Windows.Forms.ComboBox()
        Me.hashButton = New System.Windows.Forms.Button()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(595, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(97, 26)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Storage File: "
        '
        'storageLabel
        '
        Me.storageLabel.AutoSize = True
        Me.storageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.storageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageLabel.Location = New System.Drawing.Point(698, 45)
        Me.storageLabel.Name = "storageLabel"
        Me.storageLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.storageLabel.Size = New System.Drawing.Size(115, 25)
        Me.storageLabel.TabIndex = 36
        Me.storageLabel.Text = "No Target Selected."
        '
        'storageButton
        '
        Me.storageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageButton.Location = New System.Drawing.Point(739, 12)
        Me.storageButton.Name = "storageButton"
        Me.storageButton.Size = New System.Drawing.Size(75, 23)
        Me.storageButton.TabIndex = 35
        Me.storageButton.Text = "Browse"
        Me.storageButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(595, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(138, 26)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Select Storage File: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(5)
        Me.Label10.Size = New System.Drawing.Size(89, 26)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Target File: "
        '
        'targetLabel
        '
        Me.targetLabel.AutoSize = True
        Me.targetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.targetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetLabel.Location = New System.Drawing.Point(107, 47)
        Me.targetLabel.Name = "targetLabel"
        Me.targetLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.targetLabel.Size = New System.Drawing.Size(115, 25)
        Me.targetLabel.TabIndex = 32
        Me.targetLabel.Text = "No Target Selected."
        '
        'targetButton
        '
        Me.targetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetButton.Location = New System.Drawing.Point(148, 12)
        Me.targetButton.Name = "targetButton"
        Me.targetButton.Size = New System.Drawing.Size(75, 23)
        Me.targetButton.TabIndex = 31
        Me.targetButton.Text = "Browse"
        Me.targetButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(130, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Select Target File: "
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.Label3)
        Me.groupBox.Controls.Add(Me.saltSizeTextBox)
        Me.groupBox.Controls.Add(Me.useSaltCheckBox)
        Me.groupBox.Controls.Add(Me.Label1)
        Me.groupBox.Controls.Add(Me.algorithmComboBox)
        Me.groupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.Location = New System.Drawing.Point(15, 75)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Padding = New System.Windows.Forms.Padding(0, 15, 17, 15)
        Me.groupBox.Size = New System.Drawing.Size(448, 123)
        Me.groupBox.TabIndex = 38
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "Hashing Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(76, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Salt Size: "
        '
        'saltSizeTextBox
        '
        Me.saltSizeTextBox.Enabled = False
        Me.saltSizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saltSizeTextBox.Location = New System.Drawing.Point(182, 72)
        Me.saltSizeTextBox.Name = "saltSizeTextBox"
        Me.saltSizeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.saltSizeTextBox.TabIndex = 36
        Me.saltSizeTextBox.Text = "20"
        '
        'useSaltCheckBox
        '
        Me.useSaltCheckBox.AutoSize = True
        Me.useSaltCheckBox.Checked = True
        Me.useSaltCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.useSaltCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useSaltCheckBox.Location = New System.Drawing.Point(6, 68)
        Me.useSaltCheckBox.Name = "useSaltCheckBox"
        Me.useSaltCheckBox.Padding = New System.Windows.Forms.Padding(5)
        Me.useSaltCheckBox.Size = New System.Drawing.Size(88, 30)
        Me.useSaltCheckBox.TabIndex = 35
        Me.useSaltCheckBox.Text = "Use Salt"
        Me.useSaltCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Algorithm: "
        '
        'algorithmComboBox
        '
        Me.algorithmComboBox.FormattingEnabled = True
        Me.algorithmComboBox.Items.AddRange(New Object() {"SHA512", "SHA384", "SHA256", "SHA1"})
        Me.algorithmComboBox.Location = New System.Drawing.Point(89, 34)
        Me.algorithmComboBox.Name = "algorithmComboBox"
        Me.algorithmComboBox.Size = New System.Drawing.Size(149, 28)
        Me.algorithmComboBox.TabIndex = 0
        '
        'hashButton
        '
        Me.hashButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hashButton.Location = New System.Drawing.Point(15, 204)
        Me.hashButton.Name = "hashButton"
        Me.hashButton.Size = New System.Drawing.Size(75, 23)
        Me.hashButton.TabIndex = 39
        Me.hashButton.Text = "Hash"
        Me.hashButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 482)
        Me.Controls.Add(Me.hashButton)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.storageLabel)
        Me.Controls.Add(Me.storageButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.targetLabel)
        Me.Controls.Add(Me.targetButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "MainForm"
        Me.Text = "Hasher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents storageLabel As Label
    Friend WithEvents storageButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents targetLabel As Label
    Friend WithEvents targetButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents groupBox As GroupBox
    Friend WithEvents useSaltCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents algorithmComboBox As ComboBox
    Friend WithEvents hashButton As Button
    Friend WithEvents saltSizeTextBox As TextBox
    Friend WithEvents Label3 As Label
End Class
