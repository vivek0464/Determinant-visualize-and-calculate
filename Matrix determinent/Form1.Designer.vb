<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Me.components = New System.ComponentModel.Container()
        Me.C1 = New System.Windows.Forms.Label()
        Me.C2 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.Label()
        Me.R2 = New System.Windows.Forms.Label()
        Me.R3 = New System.Windows.Forms.Label()
        Me.text11 = New System.Windows.Forms.TextBox()
        Me.text21 = New System.Windows.Forms.TextBox()
        Me.text31 = New System.Windows.Forms.TextBox()
        Me.text12 = New System.Windows.Forms.TextBox()
        Me.text22 = New System.Windows.Forms.TextBox()
        Me.text32 = New System.Windows.Forms.TextBox()
        Me.text13 = New System.Windows.Forms.TextBox()
        Me.text23 = New System.Windows.Forms.TextBox()
        Me.text33 = New System.Windows.Forms.TextBox()
        Me.textValue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.labelLink = New System.Windows.Forms.LinkLabel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnVisualize = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.btnFormula = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelFormula = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.BackColor = System.Drawing.Color.Transparent
        Me.C1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1.Location = New System.Drawing.Point(289, 51)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(37, 27)
        Me.C1.TabIndex = 0
        Me.C1.Text = "C1"
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.BackColor = System.Drawing.Color.Transparent
        Me.C2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2.Location = New System.Drawing.Point(407, 51)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(39, 27)
        Me.C2.TabIndex = 1
        Me.C2.Text = "C2"
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.BackColor = System.Drawing.Color.Transparent
        Me.C3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3.Location = New System.Drawing.Point(529, 51)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(39, 27)
        Me.C3.TabIndex = 2
        Me.C3.Text = "C3"
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.BackColor = System.Drawing.Color.Transparent
        Me.R1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.Location = New System.Drawing.Point(160, 108)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(39, 27)
        Me.R1.TabIndex = 3
        Me.R1.Text = "R1"
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.BackColor = System.Drawing.Color.Transparent
        Me.R2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.Location = New System.Drawing.Point(160, 155)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(41, 27)
        Me.R2.TabIndex = 4
        Me.R2.Text = "R2"
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.BackColor = System.Drawing.Color.Transparent
        Me.R3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3.Location = New System.Drawing.Point(160, 202)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(41, 27)
        Me.R3.TabIndex = 5
        Me.R3.Text = "R3"
        '
        'text11
        '
        Me.text11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text11.Location = New System.Drawing.Point(276, 108)
        Me.text11.Name = "text11"
        Me.text11.Size = New System.Drawing.Size(72, 22)
        Me.text11.TabIndex = 6
        '
        'text21
        '
        Me.text21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text21.Location = New System.Drawing.Point(276, 160)
        Me.text21.Name = "text21"
        Me.text21.Size = New System.Drawing.Size(72, 22)
        Me.text21.TabIndex = 7
        '
        'text31
        '
        Me.text31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text31.Location = New System.Drawing.Point(276, 207)
        Me.text31.Name = "text31"
        Me.text31.Size = New System.Drawing.Size(72, 22)
        Me.text31.TabIndex = 8
        '
        'text12
        '
        Me.text12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text12.Location = New System.Drawing.Point(393, 108)
        Me.text12.Name = "text12"
        Me.text12.Size = New System.Drawing.Size(72, 22)
        Me.text12.TabIndex = 9
        '
        'text22
        '
        Me.text22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text22.Location = New System.Drawing.Point(393, 160)
        Me.text22.Name = "text22"
        Me.text22.Size = New System.Drawing.Size(72, 22)
        Me.text22.TabIndex = 10
        '
        'text32
        '
        Me.text32.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text32.Location = New System.Drawing.Point(393, 206)
        Me.text32.Name = "text32"
        Me.text32.Size = New System.Drawing.Size(72, 22)
        Me.text32.TabIndex = 11
        '
        'text13
        '
        Me.text13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text13.Location = New System.Drawing.Point(510, 107)
        Me.text13.Name = "text13"
        Me.text13.Size = New System.Drawing.Size(72, 22)
        Me.text13.TabIndex = 12
        '
        'text23
        '
        Me.text23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text23.Location = New System.Drawing.Point(510, 160)
        Me.text23.Name = "text23"
        Me.text23.Size = New System.Drawing.Size(72, 22)
        Me.text23.TabIndex = 13
        '
        'text33
        '
        Me.text33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text33.Location = New System.Drawing.Point(510, 207)
        Me.text33.Name = "text33"
        Me.text33.Size = New System.Drawing.Size(72, 22)
        Me.text33.TabIndex = 14
        '
        'textValue
        '
        Me.textValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textValue.Location = New System.Drawing.Point(818, 155)
        Me.textValue.Name = "textValue"
        Me.textValue.Size = New System.Drawing.Size(199, 22)
        Me.textValue.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(684, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 32)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "="
        '
        'labelLink
        '
        Me.labelLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.labelLink.AutoSize = True
        Me.labelLink.BackColor = System.Drawing.Color.Transparent
        Me.labelLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLink.LinkColor = System.Drawing.Color.Red
        Me.labelLink.Location = New System.Drawing.Point(51, 467)
        Me.labelLink.Name = "labelLink"
        Me.labelLink.Size = New System.Drawing.Size(387, 25)
        Me.labelLink.TabIndex = 20
        Me.labelLink.TabStop = True
        Me.labelLink.Text = "Click to know about Matrix Determinant"
        Me.labelLink.VisitedLinkColor = System.Drawing.Color.Lime
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(837, 343)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 42)
        Me.btnCalculate.TabIndex = 21
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(640, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 42)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnVisualize
        '
        Me.btnVisualize.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnVisualize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVisualize.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVisualize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualize.Location = New System.Drawing.Point(441, 343)
        Me.btnVisualize.Name = "btnVisualize"
        Me.btnVisualize.Size = New System.Drawing.Size(158, 42)
        Me.btnVisualize.TabIndex = 23
        Me.btnVisualize.Text = "Visualize"
        Me.btnVisualize.UseVisualStyleBackColor = False
        '
        'btnFormula
        '
        Me.btnFormula.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormula.Location = New System.Drawing.Point(56, 294)
        Me.btnFormula.Name = "btnFormula"
        Me.btnFormula.Size = New System.Drawing.Size(114, 35)
        Me.btnFormula.TabIndex = 25
        Me.btnFormula.Text = "Formula"
        Me.btnFormula.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(720, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 26
        '
        'labelFormula
        '
        Me.labelFormula.AutoSize = True
        Me.labelFormula.BackColor = System.Drawing.Color.Transparent
        Me.labelFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFormula.Location = New System.Drawing.Point(188, 306)
        Me.labelFormula.Name = "labelFormula"
        Me.labelFormula.Size = New System.Drawing.Size(0, 17)
        Me.labelFormula.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(234, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 183)
        Me.Label2.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(625, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 183)
        Me.Label3.TabIndex = 30
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 528)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelFormula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFormula)
        Me.Controls.Add(Me.btnVisualize)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.labelLink)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textValue)
        Me.Controls.Add(Me.text33)
        Me.Controls.Add(Me.text23)
        Me.Controls.Add(Me.text13)
        Me.Controls.Add(Me.text32)
        Me.Controls.Add(Me.text22)
        Me.Controls.Add(Me.text12)
        Me.Controls.Add(Me.text31)
        Me.Controls.Add(Me.text21)
        Me.Controls.Add(Me.text11)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "form"
        Me.Text = "Determinant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1 As System.Windows.Forms.Label
    Friend WithEvents C2 As System.Windows.Forms.Label
    Friend WithEvents C3 As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.Label
    Friend WithEvents R2 As System.Windows.Forms.Label
    Friend WithEvents R3 As System.Windows.Forms.Label
    Friend WithEvents text11 As System.Windows.Forms.TextBox
    Friend WithEvents text21 As System.Windows.Forms.TextBox
    Friend WithEvents text31 As System.Windows.Forms.TextBox
    Friend WithEvents text12 As System.Windows.Forms.TextBox
    Friend WithEvents text22 As System.Windows.Forms.TextBox
    Friend WithEvents text32 As System.Windows.Forms.TextBox
    Friend WithEvents text13 As System.Windows.Forms.TextBox
    Friend WithEvents text23 As System.Windows.Forms.TextBox
    Friend WithEvents text33 As System.Windows.Forms.TextBox
    Friend WithEvents textValue As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents labelLink As System.Windows.Forms.LinkLabel
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnVisualize As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnFormula As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelFormula As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
