Public Class Form3

    '==================================================
    ' ARRAYS DE PRODUCTOS Y PRECIOS
    '==================================================

    Dim nombres(9) As String
    Dim precios(9) As Decimal

    '==================================================
    ' CARGAR PRODUCTOS AL INICIAR
    '==================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nombres(0) = "Laptop Dell"
        precios(0) = 18500

        nombres(1) = "Mouse Logitech"
        precios(1) = 450

        nombres(2) = "Teclado Redragon"
        precios(2) = 1200

        nombres(3) = "Monitor Samsung"
        precios(3) = 4200

        nombres(4) = "Audifonos Sony"
        precios(4) = 2500

        nombres(5) = "Impresora HP"
        precios(5) = 3900

        nombres(6) = "Tablet Lenovo"
        precios(6) = 5800

        nombres(7) = "Memoria USB Kingston"
        precios(7) = 300

        nombres(8) = "Disco SSD Kingston"
        precios(8) = 2100

        nombres(9) = "Camara Logitech"
        precios(9) = 1700

    End Sub

    '==================================================
    ' BOTÓN BUSCAR
    '==================================================

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As String

        Dim encontrado As Boolean = False

        '------------------------------------------
        ' VALIDAR CAMPO
        '------------------------------------------

        If txtBusqueda.Text.Trim = "" Then

            resultado.Text = "Ingrese un producto"

            txtBusqueda.Focus()

            Exit Sub

        End If

        busqueda = txtBusqueda.Text.ToLower()

        '------------------------------------------
        ' RECORRER ARRAY
        '------------------------------------------

        For i As Integer = 0 To nombres.Length - 1

            If nombres(i).ToLower() = busqueda Then

                resultado.Text =
                    "Producto encontrado" & vbCrLf &
                    "Posición: " & i & vbCrLf &
                    "Precio: " & precios(i).ToString("C")

                encontrado = True

                Exit For

            End If

        Next

        '------------------------------------------
        ' SI NO EXISTE
        '------------------------------------------

        If encontrado = False Then

            resultado.Text = "El producto no existe"

        End If

    End Sub

End Class