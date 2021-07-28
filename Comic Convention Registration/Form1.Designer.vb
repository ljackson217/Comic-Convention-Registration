' Author: Lindsay Allen (Jackson)
' Date: 03/02/21
' Assignment: Comic Convention Registration


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComicConventionRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComicConventionRegistrationForm))
        Me.bannerPic = New System.Windows.Forms.PictureBox()
        Me.headingLabel = New System.Windows.Forms.Label()
        Me.groupSizeLabel = New System.Windows.Forms.Label()
        Me.registrationCostLabel = New System.Windows.Forms.Label()
        Me.registrationCostOutputLabel = New System.Windows.Forms.Label()
        Me.badgeTypeGroupbox = New System.Windows.Forms.GroupBox()
        Me.conventionRadio = New System.Windows.Forms.RadioButton()
        Me.conventionAutographRadio = New System.Windows.Forms.RadioButton()
        Me.conventionSuperheroRadio = New System.Windows.Forms.RadioButton()
        Me.groupSizeInput = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        CType(Me.bannerPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.badgeTypeGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPic
        '
        Me.bannerPic.Image = CType(resources.GetObject("bannerPic.Image"), System.Drawing.Image)
        Me.bannerPic.Location = New System.Drawing.Point(-9, -1)
        Me.bannerPic.Name = "bannerPic"
        Me.bannerPic.Size = New System.Drawing.Size(513, 135)
        Me.bannerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bannerPic.TabIndex = 0
        Me.bannerPic.TabStop = False
        '
        'headingLabel
        '
        Me.headingLabel.AutoSize = True
        Me.headingLabel.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.headingLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.headingLabel.Location = New System.Drawing.Point(47, 158)
        Me.headingLabel.Name = "headingLabel"
        Me.headingLabel.Size = New System.Drawing.Size(408, 38)
        Me.headingLabel.TabIndex = 1
        Me.headingLabel.Text = "Comic Convention Registration"
        '
        'groupSizeLabel
        '
        Me.groupSizeLabel.AutoSize = True
        Me.groupSizeLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.groupSizeLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.groupSizeLabel.Location = New System.Drawing.Point(159, 240)
        Me.groupSizeLabel.Name = "groupSizeLabel"
        Me.groupSizeLabel.Size = New System.Drawing.Size(101, 23)
        Me.groupSizeLabel.TabIndex = 2
        Me.groupSizeLabel.Text = "Group Size:"
        '
        'registrationCostLabel
        '
        Me.registrationCostLabel.AutoSize = True
        Me.registrationCostLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.registrationCostLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.registrationCostLabel.Location = New System.Drawing.Point(93, 474)
        Me.registrationCostLabel.Name = "registrationCostLabel"
        Me.registrationCostLabel.Size = New System.Drawing.Size(151, 23)
        Me.registrationCostLabel.TabIndex = 3
        Me.registrationCostLabel.Text = "Registration Cost:"
        '
        'registrationCostOutputLabel
        '
        Me.registrationCostOutputLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.registrationCostOutputLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.registrationCostOutputLabel.Location = New System.Drawing.Point(288, 470)
        Me.registrationCostOutputLabel.Name = "registrationCostOutputLabel"
        Me.registrationCostOutputLabel.Size = New System.Drawing.Size(121, 31)
        Me.registrationCostOutputLabel.TabIndex = 4
        '
        'badgeTypeGroupbox
        '
        Me.badgeTypeGroupbox.BackColor = System.Drawing.Color.LightSkyBlue
        Me.badgeTypeGroupbox.Controls.Add(Me.conventionRadio)
        Me.badgeTypeGroupbox.Controls.Add(Me.conventionAutographRadio)
        Me.badgeTypeGroupbox.Controls.Add(Me.conventionSuperheroRadio)
        Me.badgeTypeGroupbox.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.badgeTypeGroupbox.ForeColor = System.Drawing.Color.OrangeRed
        Me.badgeTypeGroupbox.Location = New System.Drawing.Point(71, 285)
        Me.badgeTypeGroupbox.Name = "badgeTypeGroupbox"
        Me.badgeTypeGroupbox.Size = New System.Drawing.Size(360, 148)
        Me.badgeTypeGroupbox.TabIndex = 5
        Me.badgeTypeGroupbox.TabStop = False
        Me.badgeTypeGroupbox.Text = "Select Badge Type:"
        '
        'conventionRadio
        '
        Me.conventionRadio.AutoSize = True
        Me.conventionRadio.Location = New System.Drawing.Point(38, 105)
        Me.conventionRadio.Name = "conventionRadio"
        Me.conventionRadio.Size = New System.Drawing.Size(107, 27)
        Me.conventionRadio.TabIndex = 2
        Me.conventionRadio.TabStop = True
        Me.conventionRadio.Text = "Convention"
        Me.conventionRadio.UseVisualStyleBackColor = True
        '
        'conventionAutographRadio
        '
        Me.conventionAutographRadio.AutoSize = True
        Me.conventionAutographRadio.Location = New System.Drawing.Point(38, 67)
        Me.conventionAutographRadio.Name = "conventionAutographRadio"
        Me.conventionAutographRadio.Size = New System.Drawing.Size(219, 27)
        Me.conventionAutographRadio.TabIndex = 1
        Me.conventionAutographRadio.TabStop = True
        Me.conventionAutographRadio.Text = "Convention + Autographs"
        Me.conventionAutographRadio.UseVisualStyleBackColor = True
        '
        'conventionSuperheroRadio
        '
        Me.conventionSuperheroRadio.AutoSize = True
        Me.conventionSuperheroRadio.Location = New System.Drawing.Point(38, 29)
        Me.conventionSuperheroRadio.Name = "conventionSuperheroRadio"
        Me.conventionSuperheroRadio.Size = New System.Drawing.Size(300, 27)
        Me.conventionSuperheroRadio.TabIndex = 0
        Me.conventionSuperheroRadio.TabStop = True
        Me.conventionSuperheroRadio.Text = "Convention + Superhero Experience"
        Me.conventionSuperheroRadio.UseVisualStyleBackColor = True
        '
        'groupSizeInput
        '
        Me.groupSizeInput.Location = New System.Drawing.Point(281, 240)
        Me.groupSizeInput.Name = "groupSizeInput"
        Me.groupSizeInput.Size = New System.Drawing.Size(62, 23)
        Me.groupSizeInput.TabIndex = 6
        '
        'calculateButton
        '
        Me.calculateButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.calculateButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.calculateButton.Location = New System.Drawing.Point(74, 534)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(155, 38)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.clearButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clearButton.Location = New System.Drawing.Point(273, 534)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(155, 38)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'ComicConventionRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 598)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.groupSizeInput)
        Me.Controls.Add(Me.badgeTypeGroupbox)
        Me.Controls.Add(Me.registrationCostOutputLabel)
        Me.Controls.Add(Me.registrationCostLabel)
        Me.Controls.Add(Me.groupSizeLabel)
        Me.Controls.Add(Me.headingLabel)
        Me.Controls.Add(Me.bannerPic)
        Me.Name = "ComicConventionRegistrationForm"
        Me.Text = "Comic Convention Registration"
        CType(Me.bannerPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.badgeTypeGroupbox.ResumeLayout(False)
        Me.badgeTypeGroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bannerPic As PictureBox
    Friend WithEvents headingLabel As Label
    Friend WithEvents groupSizeLabel As Label
    Friend WithEvents registrationCostLabel As Label
    Friend WithEvents registrationCostOutputLabel As Label
    Friend WithEvents badgeTypeGroupbox As GroupBox
    Friend WithEvents groupSizeInput As TextBox
    Friend WithEvents conventionAutographRadio As RadioButton
    Friend WithEvents conventionSuperheroRadio As RadioButton
    Friend WithEvents conventionRadio As RadioButton
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
End Class
