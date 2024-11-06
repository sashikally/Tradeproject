<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        username = New Label()
        password = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        btnlogin = New Button()
        btnback = New Button()
        SuspendLayout()
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Location = New Point(154, 111)
        username.Name = "username"
        username.Size = New Size(60, 15)
        username.TabIndex = 0
        username.Text = "Username"
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Location = New Point(154, 181)
        password.Name = "password"
        password.Size = New Size(57, 15)
        password.TabIndex = 1
        password.Text = "Password"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(253, 103)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(253, 173)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 4
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(360, 249)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(75, 23)
        btnlogin.TabIndex = 5
        btnlogin.Text = "login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btnback
        ' 
        btnback.BackColor = SystemColors.Control
        btnback.Location = New Point(570, 249)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 6
        btnback.Text = "back"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(btnback)
        Controls.Add(btnlogin)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(password)
        Controls.Add(username)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnback As Button
End Class
