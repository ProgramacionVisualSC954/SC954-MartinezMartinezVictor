Imports System.Data

Public Class Form1

    Dim operaciones As String = ""
    Dim parentesisAbiertos As Boolean = False

    '==================================================
    ' AGREGAR TEXTO
    '==================================================
    Private Sub AgregarTextos(valor As String)

        operaciones &= valor

        ' Mostrar operación
        Digitar.Text = operaciones

    End Sub

    '==================================================
    ' BOTONES NÚMEROS
    '==================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarTextos("4")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarTextos("7")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AgregarTextos("8")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AgregarTextos("9")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AgregarTextos("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AgregarTextos("3")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AgregarTextos("5")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AgregarTextos("2")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AgregarTextos("1")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AgregarTextos("0")
    End Sub

    '==================================================
    ' BOTONES OPERADORES
    '==================================================

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AgregarTextos("*")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AgregarTextos("/")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AgregarTextos("+")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AgregarTextos("-")
    End Sub

    '==================================================
    ' PARÉNTESIS
    '==================================================

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If parentesisAbiertos = False Then

            AgregarTextos("(")
            parentesisAbiertos = True

        Else

            AgregarTextos(")")
            parentesisAbiertos = False

        End If

    End Sub

    '==================================================
    ' BORRAR TODO
    '==================================================

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        operaciones = ""
        Digitar.Text = ""
        Mostrar.Text = "0"
        parentesisAbiertos = False

    End Sub

    '==================================================
    ' BORRAR ÚLTIMO CARACTER
    '==================================================

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If operaciones.Length > 0 Then

            operaciones = operaciones.Substring(0, operaciones.Length - 1)

            Digitar.Text = operaciones

        End If

    End Sub

    '==================================================
    ' BOTÓN IGUAL =
    '==================================================

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Try

            Dim dt As New DataTable()

            Dim resultado = dt.Compute(operaciones, Nothing)

            Mostrar.Text = resultado.ToString()

            operaciones = resultado.ToString()

        Catch ex As Exception

            Mostrar.Text = "Error"

        End Try

    End Sub

    '==================================================
    ' BOTÓN POTENCIA
    ' Variable del botón: potencia
    '==================================================

    Private Sub potencia_Click(sender As Object, e As EventArgs) Handles potencia.Click

        Try

            Dim numero As Double = Convert.ToDouble(operaciones)

            Dim resultado As Double = Math.Pow(numero, 2)

            Mostrar.Text = resultado.ToString()

            operaciones = resultado.ToString()

        Catch ex As Exception

            Mostrar.Text = "Error"

        End Try

    End Sub

    '==================================================
    ' BOTÓN RAÍZ
    ' Variable del botón: raiz
    '==================================================

    Private Sub raiz_Click(sender As Object, e As EventArgs) Handles raiz.Click

        Try

            Dim numero As Double = Convert.ToDouble(operaciones)

            Dim resultado As Double = Math.Sqrt(numero)

            Mostrar.Text = resultado.ToString()

            operaciones = resultado.ToString()

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