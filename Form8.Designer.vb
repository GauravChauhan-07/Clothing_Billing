<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(233, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(172, 183)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 97)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(460, 183)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 97)
        Button2.TabIndex = 4
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(741, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(51, 26)
        Button3.TabIndex = 5
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(717, 421)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 12
        Label7.Text = "Label7"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(677, 421)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 11
        Label5.Text = "Label5"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form8"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
End Class
