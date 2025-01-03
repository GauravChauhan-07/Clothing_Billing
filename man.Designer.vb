<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class man
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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button5 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(683, 424)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 21
        Label5.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(725, 424)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 20
        Label4.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(248, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 19
        Label3.Text = "Label3"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(749, 6)
        Button5.Name = "Button5"
        Button5.Size = New Size(44, 31)
        Button5.TabIndex = 18
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(438, 139)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 91)
        Button2.TabIndex = 15
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(181, 139)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 91)
        Button1.TabIndex = 14
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 13
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 12
        Label1.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(309, 272)
        Button3.Name = "Button3"
        Button3.Size = New Size(172, 91)
        Button3.TabIndex = 22
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' man
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "man"
        Text = "man"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
End Class
