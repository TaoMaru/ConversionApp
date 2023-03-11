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
        Me.lblHeading.Font = New System.Drawing.Font("Gentium Book Basic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(474, 48)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(237, 40)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Converter App"
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
        Me.txtInput.BackColor = System.Drawing.Color.Lavender
        Me.txtInput.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(652, 132)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(82, 34)
        Me.txtInput.TabIndex = 2
        Me.txtInput.Text = "8888"
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Gentium Book Basic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(348, 117)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(245, 64)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = "Enter a Value and Select a Conversion:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.radToInches)
        Me.grpOptions.Controls.Add(Me.radToMeters)
        Me.grpOptions.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptions.Location = New System.Drawing.Point(353, 198)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(420, 128)
        Me.grpOptions.TabIndex = 4
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Conversion Type"
        '
        'radToInches
        '
        Me.radToInches.AutoSize = True
        Me.radToInches.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radToInches.Location = New System.Drawing.Point(39, 79)
        Me.radToInches.Name = "radToInches"
        Me.radToInches.Size = New System.Drawing.Size(287, 28)
        Me.radToInches.TabIndex = 1
        Me.radToInches.TabStop = True
        Me.radToInches.Text = "Convert Meters to Inches"
        Me.radToInches.UseVisualStyleBackColor = True
        '
        'radToMeters
        '
        Me.radToMeters.AutoSize = True
        Me.radToMeters.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radToMeters.Location = New System.Drawing.Point(39, 45)
        Me.radToMeters.Name = "radToMeters"
        Me.radToMeters.Size = New System.Drawing.Size(287, 28)
        Me.radToMeters.TabIndex = 0
        Me.radToMeters.TabStop = True
        Me.radToMeters.Text = "Convert Inches to Meters"
        Me.radToMeters.UseVisualStyleBackColor = True
        '
        'lblConversion
        '
        Me.lblConversion.Font = New System.Drawing.Font("Gentium Book Basic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(171, 342)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(612, 45)
        Me.lblConversion.TabIndex = 5
        Me.lblConversion.Text = "Converted area: "
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.AliceBlue
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.Black
        Me.btnConvert.Location = New System.Drawing.Point(87, 422)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(159, 59)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.AliceBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(353, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(159, 59)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(619, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 59)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(865, 518)
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
