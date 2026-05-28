<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        txtNombreProducto = New TextBox()
        txtPrecioProducto = New TextBox()
        btnAgregar = New Button()
        btnGenerar = New Button()
        lstProductos = New ListBox()
        Subtotal = New Label()
        iva = New Label()
        total = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(309, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 25)
        Label1.TabIndex = 0
        Label1.Text = "Generador de Ticket"
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(52, 99)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(150, 31)
        txtNombreProducto.TabIndex = 1
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(52, 177)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(150, 31)
        txtPrecioProducto.TabIndex = 2
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(569, 96)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(112, 34)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Location = New Point(569, 158)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(112, 34)
        btnGenerar.TabIndex = 4
        btnGenerar.Text = "Generar"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' lstProductos
        ' 
        lstProductos.FormattingEnabled = True
        lstProductos.ItemHeight = 25
        lstProductos.Location = New Point(52, 252)
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(180, 129)
        lstProductos.TabIndex = 5
        ' 
        ' Subtotal
        ' 
        Subtotal.AutoSize = True
        Subtotal.Location = New Point(416, 296)
        Subtotal.Name = "Subtotal"
        Subtotal.Size = New Size(63, 25)
        Subtotal.TabIndex = 6
        Subtotal.Text = "Label2"
        ' 
        ' iva
        ' 
        iva.AutoSize = True
        iva.Location = New Point(527, 296)
        iva.Name = "iva"
        iva.Size = New Size(63, 25)
        iva.TabIndex = 7
        iva.Text = "Label3"
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Location = New Point(650, 296)
        total.Name = "total"
        total.Size = New Size(63, 25)
        total.TabIndex = 8
        total.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 25)
        Label5.TabIndex = 9
        Label5.Text = "Nombre Producto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(52, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 25)
        Label6.TabIndex = 10
        Label6.Text = "Precio"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(total)
        Controls.Add(iva)
        Controls.Add(Subtotal)
        Controls.Add(lstProductos)
        Controls.Add(btnGenerar)
        Controls.Add(btnAgregar)
        Controls.Add(txtPrecioProducto)
        Controls.Add(txtNombreProducto)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents Subtotal As Label
    Friend WithEvents iva As Label
    Friend WithEvents total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
