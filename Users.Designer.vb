<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        sideBarPanel2 = New Panel()
        btnLogOut2 = New Button()
        btnRegisterEvent = New Button()
        btnEvents2 = New Button()
        containerPanel = New Panel()
        TabControl2 = New TabControl()
        TabPage1 = New TabPage()
        lblSpring = New Label()
        pictureSpring = New PictureBox()
        lblMoonlight = New Label()
        pictureMoonlight = New PictureBox()
        lblAviaFest = New Label()
        lblqizxifest = New Label()
        lblAuraConcert = New Label()
        lblDaysOfBloom = New Label()
        pictureQiXi = New PictureBox()
        pcitureAviary = New PictureBox()
        pcitureAurora = New PictureBox()
        pictureDaysOfBloom = New PictureBox()
        lblEventsHeader = New Label()
        TabPageRegisterEvents = New TabPage()
        btnRefresh = New Button()
        btnAdd2 = New Button()
        tblRegisterEvent = New DataGridView()
        lblRegister = New Label()
        sideBarPanel2.SuspendLayout()
        containerPanel.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(pictureSpring, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureMoonlight, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureQiXi, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcitureAviary, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcitureAurora, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureDaysOfBloom, ComponentModel.ISupportInitialize).BeginInit()
        TabPageRegisterEvents.SuspendLayout()
        CType(tblRegisterEvent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sideBarPanel2
        ' 
        sideBarPanel2.BackColor = Color.Transparent
        sideBarPanel2.BackgroundImage = My.Resources.Resources.ccf5d7053190f56a9ef758ab376b58cd
        sideBarPanel2.BackgroundImageLayout = ImageLayout.Stretch
        sideBarPanel2.Controls.Add(btnLogOut2)
        sideBarPanel2.Controls.Add(btnRegisterEvent)
        sideBarPanel2.Controls.Add(btnEvents2)
        sideBarPanel2.Dock = DockStyle.Left
        sideBarPanel2.Location = New Point(0, 0)
        sideBarPanel2.Name = "sideBarPanel2"
        sideBarPanel2.Size = New Size(215, 613)
        sideBarPanel2.TabIndex = 4
        ' 
        ' btnLogOut2
        ' 
        btnLogOut2.BackColor = Color.Transparent
        btnLogOut2.BackgroundImage = My.Resources.Resources.pngtree_vector_logout_icon_png_image_925699
        btnLogOut2.BackgroundImageLayout = ImageLayout.Zoom
        btnLogOut2.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        btnLogOut2.Location = New Point(170, 572)
        btnLogOut2.Name = "btnLogOut2"
        btnLogOut2.Size = New Size(30, 29)
        btnLogOut2.TabIndex = 3
        btnLogOut2.UseVisualStyleBackColor = False
        ' 
        ' btnRegisterEvent
        ' 
        btnRegisterEvent.BackColor = Color.FromArgb(CByte(223), CByte(206), CByte(232))
        btnRegisterEvent.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnRegisterEvent.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        btnRegisterEvent.Location = New Point(38, 327)
        btnRegisterEvent.Name = "btnRegisterEvent"
        btnRegisterEvent.Size = New Size(136, 71)
        btnRegisterEvent.TabIndex = 2
        btnRegisterEvent.Text = "Registered Events"
        btnRegisterEvent.UseVisualStyleBackColor = False
        ' 
        ' btnEvents2
        ' 
        btnEvents2.BackColor = Color.FromArgb(CByte(223), CByte(206), CByte(232))
        btnEvents2.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnEvents2.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        btnEvents2.Location = New Point(38, 237)
        btnEvents2.Name = "btnEvents2"
        btnEvents2.Size = New Size(136, 55)
        btnEvents2.TabIndex = 0
        btnEvents2.Text = "Events"
        btnEvents2.UseVisualStyleBackColor = False
        ' 
        ' containerPanel
        ' 
        containerPanel.Controls.Add(TabControl2)
        containerPanel.Dock = DockStyle.Fill
        containerPanel.Location = New Point(0, 0)
        containerPanel.Name = "containerPanel"
        containerPanel.Size = New Size(989, 613)
        containerPanel.TabIndex = 5
        ' 
        ' TabControl2
        ' 
        TabControl2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl2.Appearance = TabAppearance.FlatButtons
        TabControl2.Controls.Add(TabPage1)
        TabControl2.Controls.Add(TabPageRegisterEvents)
        TabControl2.ItemSize = New Size(0, 1)
        TabControl2.Location = New Point(206, -2)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(783, 615)
        TabControl2.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources._68a4cf5e3b3ca4bf52ce7d791b35897a
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(lblSpring)
        TabPage1.Controls.Add(pictureSpring)
        TabPage1.Controls.Add(lblMoonlight)
        TabPage1.Controls.Add(pictureMoonlight)
        TabPage1.Controls.Add(lblAviaFest)
        TabPage1.Controls.Add(lblqizxifest)
        TabPage1.Controls.Add(lblAuraConcert)
        TabPage1.Controls.Add(lblDaysOfBloom)
        TabPage1.Controls.Add(pictureQiXi)
        TabPage1.Controls.Add(pcitureAviary)
        TabPage1.Controls.Add(pcitureAurora)
        TabPage1.Controls.Add(pictureDaysOfBloom)
        TabPage1.Controls.Add(lblEventsHeader)
        TabPage1.Location = New Point(4, 5)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(775, 606)
        TabPage1.TabIndex = 0
        TabPage1.Text = "tabPageEvents2"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblSpring
        ' 
        lblSpring.AutoSize = True
        lblSpring.BackColor = Color.Transparent
        lblSpring.Font = New Font("Monotype Corsiva", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSpring.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblSpring.Location = New Point(583, 404)
        lblSpring.Name = "lblSpring"
        lblSpring.Size = New Size(143, 27)
        lblSpring.TabIndex = 15
        lblSpring.Text = "Spring Camping"
        ' 
        ' pictureSpring
        ' 
        pictureSpring.Image = My.Resources.Resources._84e89e231774ab9c9d1a39ab4f0d71f9
        pictureSpring.Location = New Point(527, 261)
        pictureSpring.Name = "pictureSpring"
        pictureSpring.Size = New Size(235, 134)
        pictureSpring.SizeMode = PictureBoxSizeMode.Zoom
        pictureSpring.TabIndex = 14
        pictureSpring.TabStop = False
        ' 
        ' lblMoonlight
        ' 
        lblMoonlight.AutoSize = True
        lblMoonlight.BackColor = Color.Transparent
        lblMoonlight.Font = New Font("Monotype Corsiva", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblMoonlight.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblMoonlight.Location = New Point(317, 404)
        lblMoonlight.Name = "lblMoonlight"
        lblMoonlight.Size = New Size(166, 27)
        lblMoonlight.TabIndex = 13
        lblMoonlight.Text = "Days of Moonlight"
        ' 
        ' pictureMoonlight
        ' 
        pictureMoonlight.Image = My.Resources.Resources._459263330_907275004778536_2435564165638041513_n
        pictureMoonlight.Location = New Point(274, 261)
        pictureMoonlight.Name = "pictureMoonlight"
        pictureMoonlight.Size = New Size(235, 134)
        pictureMoonlight.SizeMode = PictureBoxSizeMode.Zoom
        pictureMoonlight.TabIndex = 12
        pictureMoonlight.TabStop = False
        ' 
        ' lblAviaFest
        ' 
        lblAviaFest.AutoSize = True
        lblAviaFest.BackColor = Color.Transparent
        lblAviaFest.Font = New Font("Monotype Corsiva", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAviaFest.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblAviaFest.ImageAlign = ContentAlignment.TopCenter
        lblAviaFest.Location = New Point(57, 404)
        lblAviaFest.Name = "lblAviaFest"
        lblAviaFest.Size = New Size(168, 54)
        lblAviaFest.TabIndex = 11
        lblAviaFest.Text = "Aviary’s Firework " & vbCrLf & "Festival"
        lblAviaFest.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblqizxifest
        ' 
        lblqizxifest.AutoSize = True
        lblqizxifest.BackColor = Color.Transparent
        lblqizxifest.Font = New Font("Monotype Corsiva", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblqizxifest.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblqizxifest.Location = New Point(568, 191)
        lblqizxifest.Name = "lblqizxifest"
        lblqizxifest.Size = New Size(158, 34)
        lblqizxifest.TabIndex = 10
        lblqizxifest.Text = "Qizxi Festival"
        ' 
        ' lblAuraConcert
        ' 
        lblAuraConcert.AutoSize = True
        lblAuraConcert.BackColor = Color.Transparent
        lblAuraConcert.Font = New Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAuraConcert.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblAuraConcert.Location = New Point(326, 191)
        lblAuraConcert.Name = "lblAuraConcert"
        lblAuraConcert.Size = New Size(145, 58)
        lblAuraConcert.TabIndex = 9
        lblAuraConcert.Text = "Aurora Encore " & vbCrLf & "Concert"
        lblAuraConcert.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDaysOfBloom
        ' 
        lblDaysOfBloom.AutoSize = True
        lblDaysOfBloom.BackColor = Color.Transparent
        lblDaysOfBloom.Font = New Font("Monotype Corsiva", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDaysOfBloom.ForeColor = Color.FromArgb(CByte(48), CByte(84), CByte(120))
        lblDaysOfBloom.Location = New Point(63, 191)
        lblDaysOfBloom.Name = "lblDaysOfBloom"
        lblDaysOfBloom.Size = New Size(162, 34)
        lblDaysOfBloom.TabIndex = 8
        lblDaysOfBloom.Text = "Days of Bloom"
        ' 
        ' pictureQiXi
        ' 
        pictureQiXi.Image = My.Resources.Resources.hq720
        pictureQiXi.Location = New Point(527, 49)
        pictureQiXi.Name = "pictureQiXi"
        pictureQiXi.Size = New Size(235, 134)
        pictureQiXi.SizeMode = PictureBoxSizeMode.Zoom
        pictureQiXi.TabIndex = 7
        pictureQiXi.TabStop = False
        ' 
        ' pcitureAviary
        ' 
        pcitureAviary.Image = My.Resources.Resources._411151259_741645734674798_3362751705294817580_n
        pcitureAviary.Location = New Point(19, 261)
        pcitureAviary.Name = "pcitureAviary"
        pcitureAviary.Size = New Size(235, 134)
        pcitureAviary.SizeMode = PictureBoxSizeMode.Zoom
        pcitureAviary.TabIndex = 6
        pcitureAviary.TabStop = False
        ' 
        ' pcitureAurora
        ' 
        pcitureAurora.Image = My.Resources.Resources.maxresdefault
        pcitureAurora.Location = New Point(274, 50)
        pcitureAurora.Name = "pcitureAurora"
        pcitureAurora.Size = New Size(235, 133)
        pcitureAurora.SizeMode = PictureBoxSizeMode.Zoom
        pcitureAurora.TabIndex = 5
        pcitureAurora.TabStop = False
        ' 
        ' pictureDaysOfBloom
        ' 
        pictureDaysOfBloom.Image = My.Resources.Resources.Frs6kaOWcAIF37C
        pictureDaysOfBloom.Location = New Point(19, 50)
        pictureDaysOfBloom.Name = "pictureDaysOfBloom"
        pictureDaysOfBloom.Size = New Size(235, 133)
        pictureDaysOfBloom.SizeMode = PictureBoxSizeMode.Zoom
        pictureDaysOfBloom.TabIndex = 4
        pictureDaysOfBloom.TabStop = False
        ' 
        ' lblEventsHeader
        ' 
        lblEventsHeader.AutoSize = True
        lblEventsHeader.BackColor = Color.Transparent
        lblEventsHeader.Font = New Font("Mistral", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventsHeader.ForeColor = Color.DarkSlateBlue
        lblEventsHeader.Location = New Point(347, 12)
        lblEventsHeader.Name = "lblEventsHeader"
        lblEventsHeader.Size = New Size(105, 41)
        lblEventsHeader.TabIndex = 3
        lblEventsHeader.Text = "EVENTS"
        ' 
        ' TabPageRegisterEvents
        ' 
        TabPageRegisterEvents.BackgroundImage = My.Resources.Resources._68a4cf5e3b3ca4bf52ce7d791b35897a
        TabPageRegisterEvents.BackgroundImageLayout = ImageLayout.Stretch
        TabPageRegisterEvents.Controls.Add(btnRefresh)
        TabPageRegisterEvents.Controls.Add(btnAdd2)
        TabPageRegisterEvents.Controls.Add(tblRegisterEvent)
        TabPageRegisterEvents.Controls.Add(lblRegister)
        TabPageRegisterEvents.ForeColor = Color.DarkSlateBlue
        TabPageRegisterEvents.Location = New Point(4, 5)
        TabPageRegisterEvents.Name = "TabPageRegisterEvents"
        TabPageRegisterEvents.Padding = New Padding(3)
        TabPageRegisterEvents.Size = New Size(793, 606)
        TabPageRegisterEvents.TabIndex = 2
        TabPageRegisterEvents.Text = "TabPage3"
        TabPageRegisterEvents.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Microsoft YaHei UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.DarkSlateBlue
        btnRefresh.Location = New Point(530, 414)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 29)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnAdd2
        ' 
        btnAdd2.Font = New Font("Microsoft YaHei UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd2.ForeColor = Color.DarkSlateBlue
        btnAdd2.Location = New Point(421, 414)
        btnAdd2.Name = "btnAdd2"
        btnAdd2.Size = New Size(94, 29)
        btnAdd2.TabIndex = 6
        btnAdd2.Text = "Add"
        btnAdd2.UseVisualStyleBackColor = True
        ' 
        ' tblRegisterEvent
        ' 
        tblRegisterEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblRegisterEvent.Location = New Point(18, 71)
        tblRegisterEvent.Name = "tblRegisterEvent"
        tblRegisterEvent.RowHeadersWidth = 51
        tblRegisterEvent.Size = New Size(721, 328)
        tblRegisterEvent.TabIndex = 5
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.BackColor = Color.Transparent
        lblRegister.Font = New Font("Mistral", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegister.Location = New Point(315, 30)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(132, 41)
        lblRegister.TabIndex = 4
        lblRegister.Text = "REGISTER"
        ' 
        ' Users
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(989, 613)
        Controls.Add(sideBarPanel2)
        Controls.Add(containerPanel)
        Name = "Users"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Users"
        sideBarPanel2.ResumeLayout(False)
        containerPanel.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(pictureSpring, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureMoonlight, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureQiXi, ComponentModel.ISupportInitialize).EndInit()
        CType(pcitureAviary, ComponentModel.ISupportInitialize).EndInit()
        CType(pcitureAurora, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureDaysOfBloom, ComponentModel.ISupportInitialize).EndInit()
        TabPageRegisterEvents.ResumeLayout(False)
        TabPageRegisterEvents.PerformLayout()
        CType(tblRegisterEvent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents sideBarPanel2 As Panel
    Friend WithEvents btnLogOut2 As Button
    Friend WithEvents btnRegisterEvent As Button
    Friend WithEvents btnEvents2 As Button
    Friend WithEvents containerPanel As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblSpring As Label
    Friend WithEvents pictureSpring As PictureBox
    Friend WithEvents lblMoonlight As Label
    Friend WithEvents pictureMoonlight As PictureBox
    Friend WithEvents lblAviaFest As Label
    Friend WithEvents lblqizxifest As Label
    Friend WithEvents lblAuraConcert As Label
    Friend WithEvents lblDaysOfBloom As Label
    Friend WithEvents pictureQiXi As PictureBox
    Friend WithEvents pcitureAviary As PictureBox
    Friend WithEvents pcitureAurora As PictureBox
    Friend WithEvents pictureDaysOfBloom As PictureBox
    Friend WithEvents lblEventsHeader As Label
    Friend WithEvents TabPageRegisterEvents As TabPage
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents tblRegisterEvent As DataGridView
    Friend WithEvents lblRegister As Label
End Class
