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
        Label1 = New Label()
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        categoria = New Label()
        iva = New Label()
        preciofinal = New Label()
        btnClasificar = New Button()
        btnLimpiar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(286, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 25)
        Label1.TabIndex = 0
        Label1.Text = "Clasificador de Productos"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(124, 89)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 31)
        txtNombre.TabIndex = 1
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(124, 167)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(150, 31)
        txtPrecio.TabIndex = 2
        ' 
        ' categoria
        ' 
        categoria.AutoSize = True
        categoria.Location = New Point(124, 292)
        categoria.Name = "categoria"
        categoria.Size = New Size(19, 25)
        categoria.TabIndex = 3
        categoria.Text = "-"
        ' 
        ' iva
        ' 
        iva.AutoSize = True
        iva.Location = New Point(370, 292)
        iva.Name = "iva"
        iva.Size = New Size(19, 25)
        iva.TabIndex = 4
        iva.Text = "-"
        ' 
        ' preciofinal
        ' 
        preciofinal.AutoSize = True
        preciofinal.Location = New Point(603, 292)
        preciofinal.Name = "preciofinal"
        preciofinal.Size = New Size(19, 25)
        preciofinal.TabIndex = 5
        preciofinal.Text = "-"
        ' 
        ' btnClasificar
        ' 
        btnClasificar.Location = New Point(562, 86)
        btnClasificar.Name = "btnClasificar"
        btnClasificar.Size = New Size(112, 34)
        btnClasificar.TabIndex = 6
        btnClasificar.Text = "Clasificar"
        btnClasificar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(562, 164)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(112, 34)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(124, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(124, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 9
        Label3.Text = "Precio"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnLimpiar)
        Controls.Add(btnClasificar)
        Controls.Add(preciofinal)
        Controls.Add(iva)
        Controls.Add(categoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents categoria As Label
    Friend WithEvents iva As Label
    Friend WithEvents preciofinal As Label
    Friend WithEvents btnClasificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
