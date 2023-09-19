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
        txtUser = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtLogin = New Button()
        txtClear = New Button()
        chkboxHide = New CheckBox()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(45, 27)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(100, 23)
        txtUser.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(45, 81)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 2
        Label1.Text = "User :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password : "
        ' 
        ' txtLogin
        ' 
        txtLogin.Location = New Point(62, 151)
        txtLogin.Name = "txtLogin"
        txtLogin.Size = New Size(64, 23)
        txtLogin.TabIndex = 4
        txtLogin.Text = "Login"
        txtLogin.UseVisualStyleBackColor = True
        ' 
        ' txtClear
        ' 
        txtClear.Location = New Point(62, 199)
        txtClear.Name = "txtClear"
        txtClear.Size = New Size(64, 23)
        txtClear.TabIndex = 5
        txtClear.Text = "Clear"
        txtClear.UseVisualStyleBackColor = True
        ' 
        ' chkboxHide
        ' 
        chkboxHide.AutoSize = True
        chkboxHide.Location = New Point(45, 110)
        chkboxHide.Name = "chkboxHide"
        chkboxHide.Size = New Size(104, 19)
        chkboxHide.TabIndex = 6
        chkboxHide.Text = "Hide Password"
        chkboxHide.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(190, 248)
        Controls.Add(chkboxHide)
        Controls.Add(txtClear)
        Controls.Add(txtLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLogin As Button
    Friend WithEvents txtClear As Button
    Friend WithEvents chkboxHide As CheckBox
End Class
