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
        Label1 = New Label()
        Label2 = New Label()
        usntxtbox = New TextBox()
        passtxtbox = New TextBox()
        btnLogin3 = New Button()
        lblregis = New Label()
        btnreset = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        Label1.Location = New Point(47, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 27)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        Label2.Location = New Point(52, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 27)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' usntxtbox
        ' 
        usntxtbox.Location = New Point(166, 145)
        usntxtbox.Name = "usntxtbox"
        usntxtbox.Size = New Size(197, 27)
        usntxtbox.TabIndex = 2
        ' 
        ' passtxtbox
        ' 
        passtxtbox.Location = New Point(166, 191)
        passtxtbox.Name = "passtxtbox"
        passtxtbox.Size = New Size(197, 27)
        passtxtbox.TabIndex = 3
        ' 
        ' btnLogin3
        ' 
        btnLogin3.Font = New Font("Microsoft YaHei UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin3.Location = New Point(119, 258)
        btnLogin3.Name = "btnLogin3"
        btnLogin3.Size = New Size(94, 29)
        btnLogin3.TabIndex = 4
        btnLogin3.Text = "Login"
        btnLogin3.UseVisualStyleBackColor = True
        ' 
        ' lblregis
        ' 
        lblregis.AutoSize = True
        lblregis.BackColor = Color.Transparent
        lblregis.Font = New Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblregis.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblregis.Location = New Point(209, 305)
        lblregis.Name = "lblregis"
        lblregis.Size = New Size(86, 25)
        lblregis.TabIndex = 5
        lblregis.Text = "Register"
        ' 
        ' btnreset
        ' 
        btnreset.Font = New Font("Microsoft YaHei UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnreset.ForeColor = SystemColors.ControlText
        btnreset.Location = New Point(293, 258)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(94, 29)
        btnreset.TabIndex = 6
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        Label3.Location = New Point(182, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 45)
        Label3.TabIndex = 7
        Label3.Text = "Login"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        BackgroundImage = My.Resources.Resources.sky
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(478, 501)
        Controls.Add(Label3)
        Controls.Add(btnreset)
        Controls.Add(lblregis)
        Controls.Add(btnLogin3)
        Controls.Add(passtxtbox)
        Controls.Add(usntxtbox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usntxtbox As TextBox
    Friend WithEvents passtxtbox As TextBox
    Friend WithEvents btnLogin3 As Button
    Friend WithEvents lblregis As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Label3 As Label

End Class
