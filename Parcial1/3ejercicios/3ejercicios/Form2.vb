Public Class Form2

    '==================================================
    ' LISTAS
    '==================================================

    Dim productos As New List(Of String)()
    Dim precios As New List(Of Decimal)()

    '==================================================
    ' BOTÓN AGREGAR PRODUCTO
    '==================================================

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim precio As Decimal

        '------------------------------------------
        ' VALIDAR NOMBRE
        '------------------------------------------

        If txtNombreProducto.Text.Trim = "" Then

            MessageBox.Show("Ingrese el nombre del producto")

            txtNombreProducto.Focus()

            Exit Sub

        End If

        '------------------------------------------
        ' VALIDAR PRECIO
        '------------------------------------------

        If Not Decimal.TryParse(txtPrecioProducto.Text, precio) Or precio <= 0 Then

            MessageBox.Show("Ingrese un precio válido")

            txtPrecioProducto.Clear()

            txtPrecioProducto.Focus()

            Exit Sub

        End If

        '------------------------------------------
        ' AGREGAR A LAS LISTAS
        '------------------------------------------

        productos.Add(txtNombreProducto.Text)

        precios.Add(precio)

        '------------------------------------------
        ' MOSTRAR EN LISTBOX
        '------------------------------------------

        lstProductos.Items.Add(txtNombreProducto.Text & " - " & precio.ToString("C"))

        '------------------------------------------
        ' CALCULAR SUBTOTAL
        '------------------------------------------

        Dim subtotalCalculado As Decimal = 0

        For Each p As Decimal In precios

            subtotalCalculado += p

        Next

        '------------------------------------------
        ' DESCUENTO SI HAY 3 O MÁS PRODUCTOS
        '------------------------------------------

        Dim descuento As Decimal = 0

        If productos.Count >= 3 Then

            descuento = subtotalCalculado * 0.05D

        End If

        subtotalCalculado -= descuento

        '------------------------------------------
        ' IVA Y TOTAL
        '------------------------------------------

        Dim ivaCalculado As Decimal = subtotalCalculado * 0.16D

        Dim totalCalculado As Decimal = subtotalCalculado + ivaCalculado

        '------------------------------------------
        ' MOSTRAR RESULTADOS
        '------------------------------------------

        Subtotal.Text = subtotalCalculado.ToString("C")

        iva.Text = ivaCalculado.ToString("C")

        total.Text = totalCalculado.ToString("C")

        '------------------------------------------
        ' LIMPIAR CAMPOS
        '------------------------------------------

        txtNombreProducto.Clear()

        txtPrecioProducto.Clear()

        txtNombreProducto.Focus()

    End Sub

    '==================================================
    ' BOTÓN GENERAR TICKET
    '==================================================

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If productos.Count = 0 Then

            MessageBox.Show("No hay productos agregados")

            Exit Sub

        End If

        Dim ticket As String = ""
        Dim contador As Integer = 1

        Dim subtotalCalculado As Decimal = 0

        '------------------------------------------
        ' RECORRER PRODUCTOS
        '------------------------------------------

        For Each precio As Decimal In precios

            subtotalCalculado += precio

        Next

        '------------------------------------------
        ' ARMAR TICKET
        '------------------------------------------

        For i As Integer = 0 To productos.Count - 1

            ticket &= contador & ". " &
                      productos(i) & " - " &
                      precios(i).ToString("C") & vbCrLf

            contador += 1

        Next

        '------------------------------------------
        ' DESCUENTO
        '------------------------------------------

        Dim descuento As Decimal = 0

        If productos.Count >= 3 Then

            descuento = subtotalCalculado * 0.05D

            subtotalCalculado -= descuento

        End If

        '------------------------------------------
        ' IVA Y TOTAL
        '------------------------------------------

        Dim ivaCalculado As Decimal = subtotalCalculado * 0.16D

        Dim totalCalculado As Decimal = subtotalCalculado + ivaCalculado

        '------------------------------------------
        ' DATOS FINALES DEL TICKET
        '------------------------------------------

        ticket &= vbCrLf
        ticket &= "-----------------------------" & vbCrLf
        ticket &= "Subtotal: " & subtotalCalculado.ToString("C") & vbCrLf

        If descuento > 0 Then

            ticket &= "Descuento (5%): -" & descuento.ToString("C") & vbCrLf

        End If

        ticket &= "IVA: " & ivaCalculado.ToString("C") & vbCrLf
        ticket &= "Total: " & totalCalculado.ToString("C") & vbCrLf

        '------------------------------------------
        ' MOSTRAR TICKET
        '------------------------------------------

        MessageBox.Show(ticket, "TICKET DE COMPRA")

    End Sub

End Class