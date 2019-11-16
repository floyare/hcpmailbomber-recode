<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits MaterialSkin.Controls.MaterialForm

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pMailFor = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.pStart = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pStop = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.pMailCount = New MaterialSkin.Controls.MaterialLabel()
        Me.pStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.pMailFrom = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.pPassFrom = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.pBypassCheck = New MaterialSkin.Controls.MaterialCheckBox()
        Me.pClassicBypass = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pHTMLBypass = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pTitle = New System.Windows.Forms.TextBox()
        Me.pBody = New System.Windows.Forms.RichTextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.pChecker = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 92)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(619, 291)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.MaterialLabel11)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.MaterialLabel2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Information"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.pStatus)
        Me.TabPage2.Controls.Add(Me.pMailCount)
        Me.TabPage2.Controls.Add(Me.MaterialLabel5)
        Me.TabPage2.Controls.Add(Me.MaterialLabel4)
        Me.TabPage2.Controls.Add(Me.MaterialLabel3)
        Me.TabPage2.Controls.Add(Me.pStop)
        Me.TabPage2.Controls.Add(Me.pStart)
        Me.TabPage2.Controls.Add(Me.pMailFor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(611, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MailBomber"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(176, 35)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(388, 26)
        Me.MaterialTabSelector1.TabIndex = 2
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.MaterialLabel10)
        Me.TabPage3.Controls.Add(Me.MaterialLabel9)
        Me.TabPage3.Controls.Add(Me.pBody)
        Me.TabPage3.Controls.Add(Me.pTitle)
        Me.TabPage3.Controls.Add(Me.pHTMLBypass)
        Me.TabPage3.Controls.Add(Me.pClassicBypass)
        Me.TabPage3.Controls.Add(Me.pBypassCheck)
        Me.TabPage3.Controls.Add(Me.MaterialLabel8)
        Me.TabPage3.Controls.Add(Me.MaterialDivider1)
        Me.TabPage3.Controls.Add(Me.MaterialLabel7)
        Me.TabPage3.Controls.Add(Me.MaterialLabel6)
        Me.TabPage3.Controls.Add(Me.pPassFrom)
        Me.TabPage3.Controls.Add(Me.pMailFrom)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(611, 262)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(17, 20)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(120, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "HCPMailBomber"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "recode v0.1a"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(17, 83)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(91, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Information:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(486, 93)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'pMailFor
        '
        Me.pMailFor.Depth = 0
        Me.pMailFor.Hint = ""
        Me.pMailFor.Location = New System.Drawing.Point(17, 19)
        Me.pMailFor.MaxLength = 32767
        Me.pMailFor.MouseState = MaterialSkin.MouseState.HOVER
        Me.pMailFor.Name = "pMailFor"
        Me.pMailFor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pMailFor.SelectedText = ""
        Me.pMailFor.SelectionLength = 0
        Me.pMailFor.SelectionStart = 0
        Me.pMailFor.Size = New System.Drawing.Size(219, 23)
        Me.pMailFor.TabIndex = 0
        Me.pMailFor.TabStop = False
        Me.pMailFor.UseSystemPasswordChar = False
        '
        'pStart
        '
        Me.pStart.AutoSize = True
        Me.pStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pStart.Depth = 0
        Me.pStart.Icon = Nothing
        Me.pStart.Location = New System.Drawing.Point(17, 48)
        Me.pStart.MouseState = MaterialSkin.MouseState.HOVER
        Me.pStart.Name = "pStart"
        Me.pStart.Primary = True
        Me.pStart.Size = New System.Drawing.Size(64, 36)
        Me.pStart.TabIndex = 1
        Me.pStart.Text = "Start"
        Me.pStart.UseVisualStyleBackColor = True
        '
        'pStop
        '
        Me.pStop.AutoSize = True
        Me.pStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pStop.Depth = 0
        Me.pStop.Icon = Nothing
        Me.pStop.Location = New System.Drawing.Point(172, 48)
        Me.pStop.MouseState = MaterialSkin.MouseState.HOVER
        Me.pStop.Name = "pStop"
        Me.pStop.Primary = True
        Me.pStop.Size = New System.Drawing.Size(56, 36)
        Me.pStop.TabIndex = 2
        Me.pStop.Text = "Stop"
        Me.pStop.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(243, 19)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "E-mail"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(13, 104)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(92, 19)
        Me.MaterialLabel4.TabIndex = 4
        Me.MaterialLabel4.Text = "Sent emails:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(13, 123)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MaterialLabel5.TabIndex = 5
        Me.MaterialLabel5.Text = "Status:"
        '
        'pMailCount
        '
        Me.pMailCount.AutoSize = True
        Me.pMailCount.Depth = 0
        Me.pMailCount.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMailCount.ForeColor = System.Drawing.Color.Black
        Me.pMailCount.Location = New System.Drawing.Point(111, 103)
        Me.pMailCount.MouseState = MaterialSkin.MouseState.HOVER
        Me.pMailCount.Name = "pMailCount"
        Me.pMailCount.Size = New System.Drawing.Size(18, 20)
        Me.pMailCount.TabIndex = 6
        Me.pMailCount.Text = "0"
        '
        'pStatus
        '
        Me.pStatus.AutoSize = True
        Me.pStatus.Depth = 0
        Me.pStatus.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.pStatus.ForeColor = System.Drawing.Color.DarkOrange
        Me.pStatus.Location = New System.Drawing.Point(75, 123)
        Me.pStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.pStatus.Name = "pStatus"
        Me.pStatus.Size = New System.Drawing.Size(33, 19)
        Me.pStatus.TabIndex = 7
        Me.pStatus.Text = "Idle"
        '
        'pMailFrom
        '
        Me.pMailFrom.Depth = 0
        Me.pMailFrom.Hint = ""
        Me.pMailFrom.Location = New System.Drawing.Point(15, 18)
        Me.pMailFrom.MaxLength = 32767
        Me.pMailFrom.MouseState = MaterialSkin.MouseState.HOVER
        Me.pMailFrom.Name = "pMailFrom"
        Me.pMailFrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pMailFrom.SelectedText = ""
        Me.pMailFrom.SelectionLength = 0
        Me.pMailFrom.SelectionStart = 0
        Me.pMailFrom.Size = New System.Drawing.Size(208, 23)
        Me.pMailFrom.TabIndex = 0
        Me.pMailFrom.TabStop = False
        Me.pMailFrom.UseSystemPasswordChar = False
        '
        'pPassFrom
        '
        Me.pPassFrom.Depth = 0
        Me.pPassFrom.Hint = ""
        Me.pPassFrom.Location = New System.Drawing.Point(15, 63)
        Me.pPassFrom.MaxLength = 32767
        Me.pPassFrom.MouseState = MaterialSkin.MouseState.HOVER
        Me.pPassFrom.Name = "pPassFrom"
        Me.pPassFrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pPassFrom.SelectedText = ""
        Me.pPassFrom.SelectionLength = 0
        Me.pPassFrom.SelectionStart = 0
        Me.pPassFrom.Size = New System.Drawing.Size(208, 23)
        Me.pPassFrom.TabIndex = 1
        Me.pPassFrom.TabStop = False
        Me.pPassFrom.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(241, 18)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel6.TabIndex = 4
        Me.MaterialLabel6.Text = "E-mail"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(241, 63)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(75, 19)
        Me.MaterialLabel7.TabIndex = 5
        Me.MaterialLabel7.Text = "Password"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(329, 0)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(14, 262)
        Me.MaterialDivider1.TabIndex = 6
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(349, 18)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(46, 19)
        Me.MaterialLabel8.TabIndex = 7
        Me.MaterialLabel8.Text = "Misc:"
        '
        'pBypassCheck
        '
        Me.pBypassCheck.AutoSize = True
        Me.pBypassCheck.Depth = 0
        Me.pBypassCheck.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.pBypassCheck.Location = New System.Drawing.Point(353, 41)
        Me.pBypassCheck.Margin = New System.Windows.Forms.Padding(0)
        Me.pBypassCheck.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.pBypassCheck.MouseState = MaterialSkin.MouseState.HOVER
        Me.pBypassCheck.Name = "pBypassCheck"
        Me.pBypassCheck.Ripple = True
        Me.pBypassCheck.Size = New System.Drawing.Size(141, 30)
        Me.pBypassCheck.TabIndex = 8
        Me.pBypassCheck.Text = "Anti-spam bypass"
        Me.pBypassCheck.UseVisualStyleBackColor = True
        '
        'pClassicBypass
        '
        Me.pClassicBypass.AutoSize = True
        Me.pClassicBypass.Depth = 0
        Me.pClassicBypass.Enabled = False
        Me.pClassicBypass.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.pClassicBypass.Location = New System.Drawing.Point(373, 71)
        Me.pClassicBypass.Margin = New System.Windows.Forms.Padding(0)
        Me.pClassicBypass.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.pClassicBypass.MouseState = MaterialSkin.MouseState.HOVER
        Me.pClassicBypass.Name = "pClassicBypass"
        Me.pClassicBypass.Ripple = True
        Me.pClassicBypass.Size = New System.Drawing.Size(74, 30)
        Me.pClassicBypass.TabIndex = 9
        Me.pClassicBypass.TabStop = True
        Me.pClassicBypass.Text = "Classic"
        Me.pClassicBypass.UseVisualStyleBackColor = True
        '
        'pHTMLBypass
        '
        Me.pHTMLBypass.AutoSize = True
        Me.pHTMLBypass.Depth = 0
        Me.pHTMLBypass.Enabled = False
        Me.pHTMLBypass.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.pHTMLBypass.Location = New System.Drawing.Point(373, 101)
        Me.pHTMLBypass.Margin = New System.Windows.Forms.Padding(0)
        Me.pHTMLBypass.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.pHTMLBypass.MouseState = MaterialSkin.MouseState.HOVER
        Me.pHTMLBypass.Name = "pHTMLBypass"
        Me.pHTMLBypass.Ripple = True
        Me.pHTMLBypass.Size = New System.Drawing.Size(66, 30)
        Me.pHTMLBypass.TabIndex = 10
        Me.pHTMLBypass.TabStop = True
        Me.pHTMLBypass.Text = "HTML"
        Me.pHTMLBypass.UseVisualStyleBackColor = True
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pTitle.Location = New System.Drawing.Point(15, 116)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(208, 15)
        Me.pTitle.TabIndex = 11
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pBody.Location = New System.Drawing.Point(15, 160)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(208, 79)
        Me.pBody.TabIndex = 12
        Me.pBody.Text = ""
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(229, 116)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(39, 19)
        Me.MaterialLabel9.TabIndex = 13
        Me.MaterialLabel9.Text = "Title"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(229, 156)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(42, 19)
        Me.MaterialLabel10.TabIndex = 14
        Me.MaterialLabel10.Text = "Body"
        '
        'pChecker
        '
        Me.pChecker.Enabled = True
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(17, 195)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(48, 19)
        Me.MaterialLabel11.TabIndex = 4
        Me.MaterialLabel11.Text = "Todo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "- Random 10minute mail"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 399)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "main"
        Me.Text = "HCPMailBomber"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pMailCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pStop As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pStart As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pMailFor As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pBody As RichTextBox
    Friend WithEvents pTitle As TextBox
    Friend WithEvents pHTMLBypass As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents pClassicBypass As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents pBypassCheck As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pPassFrom As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pMailFrom As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pChecker As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
End Class
