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
        Button1 = New Button()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        GroupBox1 = New GroupBox()
        Label2 = New RadioButton()
        Label1 = New RadioButton()
        GroupBox2 = New GroupBox()
        Label4 = New RadioButton()
        Label3 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(574, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(114, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(126, 146)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(180, 129)
        ListBox1.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(33, 299)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 150)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 29)
        Label2.TabIndex = 1
        Label2.TabStop = True
        Label2.Text = "ToLower"
        Label2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 29)
        Label1.TabIndex = 0
        Label1.TabStop = True
        Label1.Text = "ToUpper"
        Label1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(458, 299)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 150)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Colour"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 29)
        Label4.TabIndex = 1
        Label4.TabStop = True
        Label4.Text = "Purple"
        Label4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 29)
        Label3.TabIndex = 0
        Label3.TabStop = True
        Label3.Text = "Green"
        Label3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ListBox1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As RadioButton
    Friend WithEvents Label1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As RadioButton
    Friend WithEvents Label3 As RadioButton
End Class
