Public Class Form1

    '==================================================
    ' BOTÓN CLASIFICAR
    '==================================================

    Private Sub btnClasificar_Click(sender As Object, e As EventArgs) Handles btnClasificar.Click

        Dim precio As Decimal
        Dim ivaCalculado As Decimal
        Dim precioFinalCalculado As Decimal

        '------------------------------------------
        ' VALIDAR NOMBRE
        '------------------------------------------

        If txtNombre.Text.Trim = "" Then

            MessageBox.Show("Ingrese el nombre del producto")

            txtNombre.Focus()

            Exit Sub

        End If

        '------------------------------------------
        ' VALIDAR PRECIO
        '------------------------------------------

        If Not Decimal.TryParse(txtPrecio.Text, precio) Or precio <= 0 Then

            MessageBox.Show("Ingrese un precio válido y positivo")

            txtPrecio.Clear()

            txtPrecio.Focus()

            Exit Sub

        End If

        '------------------------------------------
        ' CLASIFICAR PRODUCTO
        '------------------------------------------

        If precio < 500 Then

            categoria.Text = "Económico"

        ElseIf precio >= 500 And precio <= 2000 Then

            categoria.Text = "Estándar"

        Else

            categoria.Text = "Premium"

        End If

        '------------------------------------------
        ' CALCULAR IVA Y PRECIO FINAL
        '------------------------------------------

        ivaCalculado = precio * 0.16D

        precioFinalCalculado = precio + ivaCalculado

        iva.Text = ivaCalculado.ToString("C")

        preciofinal.Text = precioFinalCalculado.ToString("C")

    End Sub

    '==================================================
    ' BOTÓN LIMPIAR
    '==================================================

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Clear()

        txtPrecio.Clear()

        categoria.Text = ""

        iva.Text = ""

        preciofinal.Text = ""

        txtNombre.Focus()

    End Sub

End Class