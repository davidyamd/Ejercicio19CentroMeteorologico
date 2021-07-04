'Programa elaborado por DAVID YAUCA / 02-07-2021

'PROBLEMA: En un centro meteorológico se llevan las precipitaciones mensuales caídas 
'en tres zonas del país: Occidente, Centro y Oriente. Se desea un programa que reciba 
'como datos de entrada las precipitaciones registradas en los 3 primeros meses de un 
'año para cada región y determine: 
'a) Precipitación trimestral en cada región
'b) Región con mayor y menor precipitación. 

Public Class Form1

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Se inhabilitan los "TextBox" que permiten ingresar la precipitación mensual, y el botón BtnCalcular
        BtnCalcular.Enabled = False

        TxtOccidenteEnero.Enabled = False
        TxtOccidenteFebrero.Enabled = False
        TxtOccidenteMarzo.Enabled = False
        TxtOrienteEnero.Enabled = False
        TxtOrienteFebrero.Enabled = False
        TxtOrienteMarzo.Enabled = False
        TxtCentroEnero.Enabled = False
        TxtCentroFebrero.Enabled = False
        TxtCentroMarzo.Enabled = False


        'Array que almacena la precipitación trimestral de cada región
        Dim Trimestral(2) As Decimal
        Trimestral(0) = Val(TxtOccidenteEnero.Text) + Val(TxtOccidenteFebrero.Text) + Val(TxtOccidenteMarzo.Text)       'Precipitacion trimestral de Occidente
        Trimestral(1) = Val(TxtOrienteEnero.Text) + Val(TxtOrienteFebrero.Text) + Val(TxtOrienteMarzo.Text)             'Precipitacion trimestral de Oriente
        Trimestral(2) = Val(TxtCentroEnero.Text) + Val(TxtCentroFebrero.Text) + Val(TxtCentroMarzo.Text)                'Precipitacion trimestral de Centro

        'Variable que almacenará la mayor precipitación trimestral
        Dim MayorPrecipitacion As Decimal = 0.0

        'Variable que almacenará el nombre de la región con mayor precipitación trimestral
        Dim RegionMayorPrecipitacion As String

        'Comprueba cual es la mayor precipitación trimestral, y almacena su valor en la variable "MayorPrecipitacion"
        For i As Integer = 0 To 2
            If (Trimestral(i) > MayorPrecipitacion) Then
                MayorPrecipitacion = Trimestral(i)
            End If
        Next

        'Comprueba cual es la región con mayor precipitación trimestral, y almacena su nombre en la variable "RegionMayorPrecipitacion"
        If (MayorPrecipitacion = Trimestral(0)) Then
            RegionMayorPrecipitacion = "Occidente"
        ElseIf (MayorPrecipitacion = Trimestral(1)) Then
            RegionMayorPrecipitacion = "Oriente"
        Else
            RegionMayorPrecipitacion = "Centro"
        End If

        'Variable que almacenará la menor precipitación trimestral
        Dim MenorPrecipitacion As Decimal = MayorPrecipitacion

        'Variable que almacenará el nombre de la región con menor precipitación trimestral
        Dim RegionMenorPrecipitacion As String

        'Comprueba cuál es la menor precipitación trimestral, y almacena su valor en la variable "MenorPrecipitacion"
        For i As Integer = 0 To 2
            If (MenorPrecipitacion > Trimestral(i)) Then
                MenorPrecipitacion = Trimestral(i)
            End If
        Next

        'Comprueba cuál es la región con menor precipitación trimestral, y almacena su nombre en la variable "RegionMenorPrecipitacion"
        If (MenorPrecipitacion = Trimestral(0)) Then
            RegionMenorPrecipitacion = "Occidente"
        ElseIf (MenorPrecipitacion = Trimestral(1)) Then
            RegionMenorPrecipitacion = "Oriente"
        Else
            RegionMenorPrecipitacion = "Centro"
        End If


        'Se muestra por pantalla la precipitación trimestral de cada región
        TxtTrimestralOccidente.Text = Trimestral(0)
        TxtTrimestralOriente.Text = Trimestral(1)
        TxtTrimestralCentro.Text = Trimestral(2)

        'Se muestra por pantalla la menor precipitación trimestral, y el nombre de la región con dicha precipitación
        TxtRegionMenorPrecipitacion.Text = RegionMenorPrecipitacion
        TxtMenorPrecipitacion.Text = MenorPrecipitacion

        'Se muestra por pantalla la mayor precipitación trimestral, y el nombre de la región con dicha precipitación
        TxtRegionMayorPrecipitacion.Text = RegionMayorPrecipitacion
        TxtMayorPrecipitacion.Text = MayorPrecipitacion

        'Se establece el foco de entrada en el botón BtnLimpiar
        Me.BtnLimpiar.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'Despliega un MessageBox que le pide confirmación al usuario para salir del programa
        Dim TextoMsgBox As String = "¿Desea salir de la aplicación?"
        Dim TituloMsgBox As String = "Salir"
        Dim BotonesMsgBox As MessageBoxButtons = MessageBoxButtons.YesNo

        Dim MsgBox As DialogResult = MessageBox.Show(TextoMsgBox, TituloMsgBox, BotonesMsgBox)

        'Si la opción del usuario fue "Si", se detiene la ejecución del programa
        If MsgBox = System.Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'Reestablece el formulario a su estado original
        BtnCalcular.Enabled = True

        TxtOccidenteEnero.Enabled = True
        TxtOccidenteFebrero.Enabled = True
        TxtOccidenteMarzo.Enabled = True
        TxtOrienteEnero.Enabled = True
        TxtOrienteFebrero.Enabled = True
        TxtOrienteMarzo.Enabled = True
        TxtCentroEnero.Enabled = True
        TxtCentroFebrero.Enabled = True
        TxtCentroMarzo.Enabled = True

        TxtOccidenteEnero.Clear()
        TxtOccidenteFebrero.Clear()
        TxtOccidenteMarzo.Clear()
        TxtOrienteEnero.Clear()
        TxtOrienteFebrero.Clear()
        TxtOrienteMarzo.Clear()
        TxtCentroEnero.Clear()
        TxtCentroFebrero.Clear()
        TxtCentroMarzo.Clear()

        TxtTrimestralOccidente.Clear()
        TxtTrimestralOriente.Clear()
        TxtTrimestralCentro.Clear()

        TxtRegionMenorPrecipitacion.Clear()
        TxtMenorPrecipitacion.Clear()
        TxtRegionMayorPrecipitacion.Clear()
        TxtMayorPrecipitacion.Clear()

        Me.TxtOccidenteEnero.Focus()
    End Sub

    Private Sub TxtOccidenteEnero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOccidenteEnero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtOccidenteFebrero.Focus()
        End If
    End Sub

    Private Sub TxtOccidenteFebrero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOccidenteFebrero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtOccidenteMarzo.Focus()
        End If
    End Sub

    Private Sub TxtOccidenteMarzo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOccidenteMarzo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtOrienteEnero.Focus()
        End If
    End Sub

    Private Sub TxtOrienteEnero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOrienteEnero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtOrienteFebrero.Focus()
        End If
    End Sub

    Private Sub TxtOrienteFebrero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOrienteFebrero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtOrienteMarzo.Focus()
        End If
    End Sub

    Private Sub TxtOrienteMarzo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOrienteMarzo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtCentroEnero.Focus()
        End If
    End Sub

    Private Sub TxtCentroEnero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCentroEnero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtCentroFebrero.Focus()
        End If
    End Sub

    Private Sub TxtCentroFebrero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCentroFebrero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtCentroMarzo.Focus()
        End If
    End Sub

    Private Sub TxtCentroMarzo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCentroMarzo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.BtnCalcular.Focus()
        End If
    End Sub
End Class