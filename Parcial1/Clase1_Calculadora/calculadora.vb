Imports System.Data

Public Class Form1

    Dim operacion As String = ""
    Dim parentesisAbierto As Boolean = False

    '==================================================
    ' ACTUALIZAR RESULTADO
    '==================================================
    Private Sub ActualizarResultado()

        Try

            If operacion = "" Then

                Mostrar.Text = "0"
                Exit Sub

            End If

            Dim dt As New DataTable()
            Dim resultado = dt.Compute(operacion, Nothing)

            ' SOLO muestra resultado
            Mostrar.Text = resultado.ToString()

        Catch ex As Exception

            ' Si la operación está incompleta
            Mostrar.Text = "0"

        End Try

    End Sub

    '==================================================
    ' AGREGAR TEXTO
    '==================================================
    Private Sub AgregarTexto(valor As String)

        operacion &= valor

        ' SOLO muestra la operación
        Digitar.Text = operacion

    End Sub

    '==================================================
    ' BOTONES NÚMEROS
    '==================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarTexto("4")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarTexto("7")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AgregarTexto("8")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AgregarTexto("9")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AgregarTexto("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AgregarTexto("3")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AgregarTexto("5")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AgregarTexto("2")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AgregarTexto("1")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AgregarTexto("0")
    End Sub

    '==================================================
    ' BOTONES OPERADORES
    '==================================================

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AgregarTexto("*")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AgregarTexto("/")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AgregarTexto("+")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AgregarTexto("-")
    End Sub

    '==================================================
    ' PARÉNTESIS
    '==================================================

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If parentesisAbierto = False Then

            AgregarTexto("(")
            parentesisAbierto = True

        Else

            AgregarTexto(")")
            parentesisAbierto = False

        End If

    End Sub

    '==================================================
    ' BORRAR TODO
    '==================================================

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        operacion = ""
        Digitar.Text = ""
        Mostrar.Text = "0"
        parentesisAbierto = False

    End Sub

    '==================================================
    ' BORRAR ÚLTIMO CARACTER
    '==================================================

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If operacion.Length > 0 Then

            operacion = operacion.Substring(0, operacion.Length - 1)

            Digitar.Text = operacion

        End If

    End Sub

    '==================================================
    ' BOTÓN IGUAL =
    '==================================================

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Try

            Dim dt As New DataTable()
            Dim resultado = dt.Compute(operacion, Nothing)

            ' Mostrar SOLO resultado
            Mostrar.Text = resultado.ToString()

            ' Guardar resultado para seguir operando
            operacion = resultado.ToString()

        Catch ex As Exception

            Mostrar.Text = "Error"

        End Try

    End Sub

    '==================================================
    ' SOLO PERMITIR NÚMEROS Y OPERADORES
    '==================================================

    Private Sub Digitar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Digitar.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> "+"c AndAlso
           e.KeyChar <> "-"c AndAlso
           e.KeyChar <> "*"c AndAlso
           e.KeyChar <> "/"c AndAlso
           e.KeyChar <> "("c AndAlso
           e.KeyChar <> ")"c AndAlso
           e.KeyChar <> "."c AndAlso
           e.KeyChar <> ChrW(Keys.Back) Then

            e.Handled = True

        End If

    End Sub

End Class