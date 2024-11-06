<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    '
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


    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        usermane = New Label()
        Password = New Label()
        Confirmpassword = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        txtconfirmpassword = New TextBox()
        btnregister = New Button()
        btnback = New Button()
        SuspendLayout()
        ' 
        ' usermane
        ' 
        usermane.AutoSize = True
        usermane.Location = New Point(157, 70)
        usermane.Name = "usermane"
        usermane.Size = New Size(63, 15)
        usermane.TabIndex = 0
        usermane.Text = "Username "
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.Location = New Point(157, 132)
        Password.Name = "Password"
        Password.Size = New Size(60, 15)
        Password.TabIndex = 1
        Password.Text = "Password "
        ' 
        ' Confirmpassword
        ' 
        Confirmpassword.AutoSize = True
        Confirmpassword.Location = New Point(157, 200)
        Confirmpassword.Name = "Confirmpassword"
        Confirmpassword.Size = New Size(102, 15)
        Confirmpassword.TabIndex = 2
        Confirmpassword.Text = "confirm password"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(330, 62)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(330, 124)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 4
        ' 
        ' txtconfirmpassword
        ' 
        txtconfirmpassword.Location = New Point(330, 197)
        txtconfirmpassword.Name = "txtconfirmpassword"
        txtconfirmpassword.Size = New Size(100, 23)
        txtconfirmpassword.TabIndex = 5
        ' 
        ' btnregister
        ' 
        btnregister.Location = New Point(448, 253)
        btnregister.Name = "btnregister"
        btnregister.Size = New Size(75, 23)
        btnregister.TabIndex = 6
        btnregister.Text = "register"
        btnregister.UseVisualStyleBackColor = True
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(641, 253)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 7
        btnback.Text = "back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ClientSize = New Size(800, 450)
        Controls.Add(btnback)
        Controls.Add(btnregister)
        Controls.Add(txtconfirmpassword)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Confirmpassword)
        Controls.Add(Password)
        Controls.Add(usermane)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usermane As Label
    Friend WithEvents Password As Label
    Friend WithEvents Confirmpassword As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents btnregister As Button
    Friend WithEvents btnback As Button
End Class
