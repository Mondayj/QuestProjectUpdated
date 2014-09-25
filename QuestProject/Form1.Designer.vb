<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCross = New System.Windows.Forms.Button()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCross
        '
        Me.btnCross.Location = New System.Drawing.Point(231, 177)
        Me.btnCross.Name = "btnCross"
        Me.btnCross.Size = New System.Drawing.Size(100, 23)
        Me.btnCross.TabIndex = 0
        Me.btnCross.Text = "May I Cross?"
        Me.btnCross.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(337, 112)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(125, 112)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(231, 112)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(100, 20)
        Me.txtQuest.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "What is your favorite color?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "What is your quest?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "What is your name?"
        '
        'lblFate
        '
        Me.lblFate.AutoSize = True
        Me.lblFate.Location = New System.Drawing.Point(228, 248)
        Me.lblFate.Name = "lblFate"
        Me.lblFate.Size = New System.Drawing.Size(0, 13)
        Me.lblFate.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(710, 503)
        Me.Controls.Add(Me.lblFate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.btnCross)
        Me.Name = "Form1"
        Me.Text = "Bridge Of Death"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCross As System.Windows.Forms.Button
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFate As System.Windows.Forms.Label

End Class
