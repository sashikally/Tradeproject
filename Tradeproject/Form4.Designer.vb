<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        dgvinvetory = New DataGridView()
        btnupdate = New Button()
        CType(dgvinvetory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvinvetory
        ' 
        dgvinvetory.BackgroundColor = Color.Cyan
        dgvinvetory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvinvetory.Location = New Point(0, 0)
        dgvinvetory.Name = "dgvinvetory"
        dgvinvetory.Size = New Size(240, 150)
        dgvinvetory.TabIndex = 0
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(191, 180)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(75, 23)
        btnupdate.TabIndex = 1
        btnupdate.Text = "update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(btnupdate)
        Controls.Add(dgvinvetory)
        Name = "Form4"
        Text = "Form4"
        CType(dgvinvetory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnupdate As Button
    Public WithEvents dgvinvetory As DataGridView


End Class
