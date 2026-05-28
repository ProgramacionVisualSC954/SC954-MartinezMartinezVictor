<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtBusqueda = New TextBox()
        Label1 = New Label()
        btnBuscar = New Button()
        resultado = New Label()
        SuspendLayout()
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(306, 145)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(150, 31)
        txtBusqueda.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(249, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 25)
        Label1.TabIndex = 1
        Label1.Text = "buscador con ciclo y depurador"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(328, 236)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 34)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' resultado
        ' 
        resultado.AutoSize = True
        resultado.Location = New Point(357, 299)
        resultado.Name = "resultado"
        resultado.Size = New Size(63, 25)
        resultado.TabIndex = 3
        resultado.Text = "Label2"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(resultado)
        Controls.Add(btnBuscar)
        Controls.Add(Label1)
        Controls.Add(txtBusqueda)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents resultado As Label
End Class
