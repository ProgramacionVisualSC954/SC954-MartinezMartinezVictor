<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        raiz = New Button()
        potencia = New Button()
        Label1 = New Label()
        Digitar = New TextBox()
        Mostrar = New TextBox()
        Button18 = New Button()
        Button17 = New Button()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button16 = New Button()
        Button7 = New Button()
        Button15 = New Button()
        Button6 = New Button()
        Button14 = New Button()
        Button5 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        Button11 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' raiz
        ' 
        raiz.Location = New Point(419, 429)
        raiz.Name = "raiz"
        raiz.Size = New Size(112, 34)
        raiz.TabIndex = 26
        raiz.Text = "√"
        raiz.UseVisualStyleBackColor = True
        ' 
        ' potencia
        ' 
        potencia.Location = New Point(275, 429)
        potencia.Name = "potencia"
        potencia.Size = New Size(112, 34)
        potencia.TabIndex = 25
        potencia.Text = "m²"
        potencia.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(343, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 24
        Label1.Text = "CALCULADORA"
        ' 
        ' Digitar
        ' 
        Digitar.Location = New Point(141, 155)
        Digitar.Name = "Digitar"
        Digitar.Size = New Size(533, 31)
        Digitar.TabIndex = 23
        ' 
        ' Mostrar
        ' 
        Mostrar.Location = New Point(141, 489)
        Mostrar.Name = "Mostrar"
        Mostrar.Size = New Size(533, 31)
        Mostrar.TabIndex = 22
        ' 
        ' Button18
        ' 
        Button18.Location = New Point(562, 429)
        Button18.Name = "Button18"
        Button18.Size = New Size(112, 34)
        Button18.TabIndex = 20
        Button18.Text = "="
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(141, 429)
        Button17.Name = "Button17"
        Button17.Size = New Size(112, 34)
        Button17.TabIndex = 19
        Button17.Text = "0"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(141, 378)
        Button10.Name = "Button10"
        Button10.Size = New Size(112, 34)
        Button10.TabIndex = 18
        Button10.Text = "1"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(275, 378)
        Button9.Name = "Button9"
        Button9.Size = New Size(112, 34)
        Button9.TabIndex = 17
        Button9.Text = "2"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(275, 327)
        Button8.Name = "Button8"
        Button8.Size = New Size(112, 34)
        Button8.TabIndex = 16
        Button8.Text = "5"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(562, 378)
        Button16.Name = "Button16"
        Button16.Size = New Size(112, 34)
        Button16.TabIndex = 21
        Button16.Text = "—"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(419, 378)
        Button7.Name = "Button7"
        Button7.Size = New Size(112, 34)
        Button7.TabIndex = 4
        Button7.Text = "3"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(562, 327)
        Button15.Name = "Button15"
        Button15.Size = New Size(112, 34)
        Button15.TabIndex = 13
        Button15.Text = "+"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(141, 218)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 34)
        Button6.TabIndex = 12
        Button6.Text = "AC"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(562, 218)
        Button14.Name = "Button14"
        Button14.Size = New Size(112, 34)
        Button14.TabIndex = 11
        Button14.Text = "/"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(419, 327)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 10
        Button5.Text = "6"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(419, 218)
        Button12.Name = "Button12"
        Button12.Size = New Size(112, 34)
        Button12.TabIndex = 9
        Button12.Text = "(  )"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(562, 272)
        Button13.Name = "Button13"
        Button13.Size = New Size(112, 34)
        Button13.TabIndex = 8
        Button13.Text = "X"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(275, 218)
        Button11.Name = "Button11"
        Button11.Size = New Size(112, 34)
        Button11.TabIndex = 7
        Button11.Text = "ELIMINAR"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(419, 272)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 6
        Button4.Text = "9"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(275, 272)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "8"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(141, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 14
        Button2.Text = "7"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(141, 327)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 15
        Button1.Text = "4"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 611)
        Controls.Add(raiz)
        Controls.Add(potencia)
        Controls.Add(Label1)
        Controls.Add(Digitar)
        Controls.Add(Mostrar)
        Controls.Add(Button18)
        Controls.Add(Button17)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button16)
        Controls.Add(Button7)
        Controls.Add(Button15)
        Controls.Add(Button6)
        Controls.Add(Button14)
        Controls.Add(Button5)
        Controls.Add(Button12)
        Controls.Add(Button13)
        Controls.Add(Button11)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents raiz As Button
    Friend WithEvents potencia As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Digitar As TextBox
    Friend WithEvents Mostrar As TextBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
