<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversion))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.radToInches = New System.Windows.Forms.RadioButton()
        Me.radToMeters = New System.Windows.Forms.RadioButton()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(391, 52)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(51, 17)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Label1"
        '
        'picBuilding
        '
        Me.picBuilding.Image = CType(resources.GetObject("picBuilding.Image"), System.Drawing.Image)
        Me.picBuilding.Location = New System.Drawing.Point(1, -2)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(307, 220)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 1
        Me.picBuilding.TabStop = False
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(582, 102)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 22)
        Me.txtInput.TabIndex = 2
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(408, 140)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(51, 17)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = "Label2"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.radToInches)
        Me.grpOptions.Controls.Add(Me.radToMeters)
        Me.grpOptions.Location = New System.Drawing.Point(394, 214)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(200, 100)
        Me.grpOptions.TabIndex = 4
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "GroupBox1"
        '
        'radToInches
        '
        Me.radToInches.AutoSize = True
        Me.radToInches.Location = New System.Drawing.Point(39, 62)
        Me.radToInches.Name = "radToInches"
        Me.radToInches.Size = New System.Drawing.Size(115, 21)
        Me.radToInches.TabIndex = 1
        Me.radToInches.TabStop = True
        Me.radToInches.Text = "RadioButton2"
        Me.radToInches.UseVisualStyleBackColor = True
        '
        'radToMeters
        '
        Me.radToMeters.AutoSize = True
        Me.radToMeters.Location = New System.Drawing.Point(39, 35)
        Me.radToMeters.Name = "radToMeters"
        Me.radToMeters.Size = New System.Drawing.Size(115, 21)
        Me.radToMeters.TabIndex = 0
        Me.radToMeters.TabStop = True
        Me.radToMeters.Text = "RadioButton1"
        Me.radToMeters.UseVisualStyleBackColor = True
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Location = New System.Drawing.Point(330, 348)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(51, 17)
        Me.lblConversion.TabIndex = 5
        Me.lblConversion.Text = "Label3"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(49, 392)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Button1"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(333, 404)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Button2"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(582, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Button3"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 518)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.picBuilding)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmConversion"
        Me.Text = "Conversion App"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents radToInches As RadioButton
    Friend WithEvents radToMeters As RadioButton
    Friend WithEvents lblConversion As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
