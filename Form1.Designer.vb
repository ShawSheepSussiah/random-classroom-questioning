<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        RandomSelectButton = New Button()
        UniversalButton = New Button()
        EnglishExclusiveButton = New Button()
        SelectedStudentLabel = New Label()
        SuspendLayout()
        ' 
        ' RandomSelectButton
        ' 
        RandomSelectButton.Location = New Point(80, 512)
        RandomSelectButton.Name = "RandomSelectButton"
        RandomSelectButton.Size = New Size(143, 37)
        RandomSelectButton.TabIndex = 1
        RandomSelectButton.Text = "随机抽取"
        RandomSelectButton.UseVisualStyleBackColor = True
        ' 
        ' UniversalButton
        ' 
        UniversalButton.Location = New Point(277, 512)
        UniversalButton.Name = "UniversalButton"
        UniversalButton.Size = New Size(165, 37)
        UniversalButton.TabIndex = 2
        UniversalButton.Text = "其他通用"
        UniversalButton.UseVisualStyleBackColor = True
        ' 
        ' EnglishExclusiveButton
        ' 
        EnglishExclusiveButton.Location = New Point(482, 512)
        EnglishExclusiveButton.Name = "EnglishExclusiveButton"
        EnglishExclusiveButton.Size = New Size(190, 37)
        EnglishExclusiveButton.TabIndex = 3
        EnglishExclusiveButton.Text = "英语专属"
        EnglishExclusiveButton.UseVisualStyleBackColor = True
        ' 
        ' SelectedStudentLabel
        ' 
        SelectedStudentLabel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SelectedStudentLabel.Font = New Font("Microsoft JhengHei UI", 48F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        SelectedStudentLabel.Location = New Point(201, 194)
        SelectedStudentLabel.Name = "SelectedStudentLabel"
        SelectedStudentLabel.Size = New Size(409, 134)
        SelectedStudentLabel.TabIndex = 4
        SelectedStudentLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(SelectedStudentLabel)
        Controls.Add(EnglishExclusiveButton)
        Controls.Add(UniversalButton)
        Controls.Add(RandomSelectButton)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents RandomSelectButton As Button
    Friend WithEvents UniversalButton As Button
    Friend WithEvents EnglishExclusiveButton As Button
    Friend WithEvents SelectedStudentLabel As Label
End Class
