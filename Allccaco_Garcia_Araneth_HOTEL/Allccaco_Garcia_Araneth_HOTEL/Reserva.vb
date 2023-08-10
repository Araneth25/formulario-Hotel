Public Class Reserva

    Dim nombre, apellido, movil As String
    Dim cantidad, precioH, resultadoH As Integer
    Dim descuento, resultadoD, importeTot, baseImponible, Iva, total As Double
    Private Sub txtMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMovil.KeyPress
        'EL USUARIO DEBE COLOCAR SI O SI EL TELEFONO DE MOVIL SÓLO CON NUMEROS NO LETRAS
        'ESO INCLUYE QUE SÓLO ESTÁ CON NUMERACIÓN

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puedes digitar numeros")
        End If

    End Sub

    Private Sub Reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TIMER O TIEMPO QUE VA RECURRIR
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MIENTRAS EL LABEL QUE NO ES VISIBLE EN EL FORMULARIO VA AVANZANDO SEGUN EL TIMER
        'CADA SEGUNDOS HABRÁ UN CAMBIO DE IMAGEN INCLUYENDO SI LLEGA A FINAL PASA A UN BUCLE

        Label4.Text += 1

        If Label4.Text = "50" Then
            PictureBox1.Image = My.Resources._1_4_1
        End If

        If Label4.Text = "100" Then
            PictureBox1.Image = My.Resources._1_1_1
        End If

        If Label4.Text = "150" Then
            PictureBox1.Image = My.Resources._1_2_1
        End If

        If Label4.Text = "200" Then
            PictureBox1.Image = My.Resources._1_5_1
        End If

        If Label4.Text = "250" Then
            Timer1.Stop()
            PictureBox1.Image = My.Resources._1_3_1
            Label4.Text = "0"
            Timer1.Start()

        End If
    End Sub

    Private Sub cmdDatos_Click(sender As Object, e As EventArgs) Handles cmdDatos.Click
        'AL REALIZAR LAS FECHAS EL USUARIO DEBERÁ PRESIONAR LOS DATOS PARA QUE PUEDA RELLENARLO
        p1.Visible = True
    End Sub

    Private Sub cmdHabitacion_Click(sender As Object, e As EventArgs) Handles cmdHabitacion.Click
        'COMPROBANDO QUE TIENE LOS DATOS REALIZADOS EL USUARIO PODRÁ ACCEDER A SELECCIONAR UNA HABITACION PRFERENTE
        movil = txtMovil.Text
        nombre = txtNombre.Text
        apellido = txtApellidos.Text

        'COLOCA MAYUSCULAS LA PRIMERA LETRA DE TODAS LAS CASILLAS CORRESPONDIENTES
        'NOMBRE
        Dim cadena, cadena2 As String

        cadena = txtNombre.Text

        cadena2 = UCase(Mid(cadena, 1, 1))
        For i = 2 To Len(cadena)
            If Mid(cadena, i, 1) <> " " Then
                cadena2 = cadena2 & LCase(Mid(cadena, i, 1))
            Else
                i = i + 1
                cadena2 = cadena2 & " " & UCase(Mid(cadena, i, 1))
            End If
        Next

        txtNombre.Text = cadena2

        'APELLIDO
        Dim cadena3, cadena4 As String

        cadena3 = txtApellidos.Text

        cadena4 = UCase(Mid(cadena3, 1, 1))
        For i = 2 To Len(cadena3)
            If Mid(cadena3, i, 1) <> " " Then
                cadena4 = cadena4 & LCase(Mid(cadena3, i, 1))
            Else
                i = i + 1
                cadena4 = cadena4 & " " & UCase(Mid(cadena3, i, 1))
            End If
        Next

        txtApellidos.Text = cadena4

        'MIENTRAS EL NOMBRE Y APELLIDO SEA MENOR DE 2 NO PODRA ACCEDER A LA SELECCION DE HABITACION
        'TAMBIEN EN UN EMAIL DEBE EXISTIR UN @ Y UN PUNTO
        If Len(nombre) < 2 Then
            MsgBox("Introducir nombre con más de 2 caracteres")
        End If

        If Len(apellido) < 2 Then
            MsgBox("Introducir apellido(s) con más de 2 caracteres")
        End If

        If Len(movil) < 9 Then
            MsgBox("Numero de movil incorrecto")
        End If

        If Not txtEmail.Text.Contains("@") Or Not txtEmail.Text.Contains(".") Then
            MsgBox("Correo incorrecto, debe contener '@' y '.'")
        End If

        'UNA VEZ DADO EL NUMERO CORRECTO Y CON MAS DE 3 CARACTERES DE NOMBRE Y APELLIDO
        If Len(movil) = 9 And Len(nombre) >= 3 And Len(apellido) >= 3 And txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".") Then
            p2.Visible = True
        End If

    End Sub

    Private Sub cmdCupones_Click(sender As Object, e As EventArgs) Handles cmdCupones.Click
        'EL USUARIO DEBE SELECCIONAR EL TIPO DE HABITACION QUE DESEA Y PODRÁ PINCHAR O PRESIONAR SI QUISIERA O NO CUPONES
        If rbHSimple.Checked = True Or rbHDoble.Checked = True Or rbSuite.Checked = True Or rbSRoyal.Checked = True Then
            lblPregunt.Visible = True
            rbSI.Visible = True
            rbNO.Visible = True
        Else
            MsgBox("Seleccionar el tipo de habitación")
        End If
    End Sub

    Private Sub rbSI_CheckedChanged(sender As Object, e As EventArgs) Handles rbSI.CheckedChanged
        'AL MARCAR QUE SI DESEA UN CUPON SE MOSTRARÁ EL PANEL CON SU REFERENTE IMAGEN Y CUPON QUE DESEE
        p3.Visible = True
        lblCode.Visible = True
        txtCode.Visible = True
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        'LOS CODIGOS DE CUPON EN ESTE HOTEL CONSISTE EN NUMEROS DE 5 DIGITOS POR ELLO SI EL USUARIO
        'INTENTA COLOCAR UN NUMERO AL AZAR O LETRA NO PODRÁ OBTENER EL CUPON DEBIDO
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("CODIGO INCORRECTO")
        End If

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'EL USUARIO SOLO DEBE INTRODUCIR EL NOMBRE CON LETRAS NO CON NUMEROS
        e.Handled = IsNumeric(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
            MsgBox("Solo puedes digitar letras")
        End If
    End Sub

    Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
        'EL USUARIO SOLO DEBE INTRODUCIR EL APELLIDO CON LETRAS NO CON NUMEROS
        e.Handled = IsNumeric(e.KeyChar)
        If IsNumeric(e.KeyChar) Then
            MsgBox("Solo puedes digitar letras")
        End If
    End Sub

    Private Sub rbNO_CheckedChanged(sender As Object, e As EventArgs) Handles rbNO.CheckedChanged
        'AL NO QUERER EL USUARIO CUPONES SOLO SE MOSTRARÁ EL PANEL CON SU IMAGEN DE PROMOCIONES QUE CONTIENE EL HOTEL
        p3.Visible = False
        lblCode.Visible = False
        txtCode.Visible = False
        p5.Visible = True
        p4.Visible = True
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        'MIENTRAS EL USUARIO ESCRIBA EL CUPON CORRECTO SE MOSTRARÁ EN COLOR VERDE MIENTRAS NO. SÓLO SERÁ DE ROJO
        If txtCode.Text = "57689" Or txtCode.Text = "21253" Or txtCode.Text = "25276" Then
            txtCode.ForeColor = Color.Green
        Else
            txtCode.ForeColor = Color.OrangeRed
        End If

    End Sub

    Private Sub rb25_CheckedChanged(sender As Object, e As EventArgs) Handles rb25.CheckedChanged
        'AL PRESIONAR O ELEGIR EL CUPON DE 25% EL USUARIO PODRÁ EL CODIGO DEL CUPON EN SU RESPECTIVA IMAGEN
        pbcupon.Visible = True
        pbcupon.Image = My.Resources.cupon31

        If rb25.Checked = True Then
            Factura.lblTipodeDescuento.Text = "10%"
        End If

    End Sub

    Private Sub calendarioMonth_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarioMonth.DateChanged
        If calendarioMonth.SelectionStart < Now.Date Then
            calendarioMonth.SelectionStart = Now.Date
        End If

    End Sub

    Private Sub rb50_CheckedChanged(sender As Object, e As EventArgs) Handles rb50.CheckedChanged
        'AL PRESIONAR O ELEGIR EL CUPON DE 50% EL USUARIO PODRÁ EL CODIGO DEL CUPON EN SU RESPECTIVA IMAGEN
        pbcupon.Visible = True
        pbcupon.Image = My.Resources.cupon1

        If rb50.Checked = True Then
            Factura.lblTipodeDescuento.Text = "25%"
        End If
    End Sub

    Private Sub CmdCaptura_Click(sender As Object, e As EventArgs) Handles CmdCaptura.Click
        'COMANDO PARA CAPTURAR CUANTOS DIAS QUIERE RESERVAR .. SELECCIONADO DESDE EL CALENDARIO DESDE INICIO Y FIN 


        If cbHabitaciones.SelectedItem = True And cbHuespedes.SelectedItem = True Then
            txtFecha.Text = calendarioDay.Value
            txtInicio.Text = calendarioMonth.SelectionStart.Date
            txtFin.Text = calendarioMonth.SelectionRange.End
            Dim inicio As Date
            Dim fin As Date
            Dim result As New TimeSpan()

            'Calculo de los dias de reserva
            inicio = txtInicio.Text
            fin = txtFin.Text
            result = fin - inicio
            Me.txtDias.Text = DateDiff("d", inicio, fin)
        Else
            MsgBox("No ha seleccionado habitaciones/huespedes")
        End If


    End Sub

    Private Sub rbHSimple_CheckedChanged(sender As Object, e As EventArgs) Handles rbHSimple.CheckedChanged
        'EL USARIO MIENTRAS ELIJA LA HABITACION SIMPLE LE SALDRÁ EL PRECIO DE LA HABITACION A UN LADO
        lblHSimple.Visible = True
        lblHDoble.Visible = False
        lblS.Visible = False
        lblSRoyal.Visible = False

        If rbHSimple.Checked = True Then
            Factura.lblPrecioHabitacion.Text = "119"
        End If

    End Sub

    Private Sub rbHDoble_CheckedChanged(sender As Object, e As EventArgs) Handles rbHDoble.CheckedChanged
        'EL USARIO MIENTRAS ELIJA LA HABITACION DOBLE LE SALDRÁ EL PRECIO DE LA HABITACION A UN LADO
        lblHSimple.Visible = False
        lblHDoble.Visible = True
        lblS.Visible = False
        lblSRoyal.Visible = False

        If rbHDoble.Checked = True Then
            Factura.lblPrecioHabitacion.Text = "220"
        End If

    End Sub

    Private Sub rbSuite_CheckedChanged(sender As Object, e As EventArgs) Handles rbSuite.CheckedChanged
        'EL USARIO MIENTRAS ELIJA LA HABITACION SUITE LE SALDRÁ EL PRECIO DE LA HABITACION A UN LADO
        lblHSimple.Visible = False
        lblS.Visible = True
        lblHDoble.Visible = False
        lblSRoyal.Visible = False

        If rbSuite.Checked = True Then
            Factura.lblPrecioHabitacion.Text = "375"
        End If

    End Sub

    Private Sub rbSRoyal_CheckedChanged(sender As Object, e As EventArgs) Handles rbSRoyal.CheckedChanged
        'EL USARIO MIENTRAS ELIJA LA HABITACION SUITE ROYAL LE SALDRÁ EL PRECIO DE LA HABITACION A UN LADO
        lblHSimple.Visible = False
        lblSRoyal.Visible = True
        lblHDoble.Visible = False
        lblS.Visible = False

        If rbSRoyal.Checked = True Then
            Factura.lblPrecioHabitacion.Text = "469"
        End If

    End Sub

    Private Sub cbHabitaciones_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbHabitaciones.SelectedValueChanged
        'PADANDO DATOS AL LABEL DE LA RESERVA INDICANDO LA CANTIDAD DE HABITACIONES
        Factura.lblCantidadHab.Text = cbHabitaciones.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbNO.Checked = True Then
            txtCode.Clear()

        End If

        If rbSI.Checked = True And (txtCode.Text = "57689" Or txtCode.Text = "21253" Or txtCode.Text = "25276") Then
            'AL PINCHAR FACTURA EL USUARIO PODRÁ ACCEDER LA TOTALIDAD QUE ES
            Factura.Show()
            cantidad = Convert.ToInt32(Factura.lblCantidadHab.Text)
            precioH = Convert.ToInt32(Factura.lblPrecioHabitacion.Text)
            resultadoH = Val(cantidad) * Val(precioH)
            Factura.lblTotalHabitacion.Text = resultadoH


            descuento = Val(Factura.lblTipodeDescuento.Text)
            resultadoD = Val(resultadoH * (Val(descuento) / 100))
            Factura.lblDescuento.Text = resultadoD

            importeTot = Val(resultadoH - resultadoD)
            Factura.lblImporteTotal.Text = importeTot

            'BASE IMPONIBLE ENTRE 1.21
            baseImponible = Val(importeTot / 1.21)
            'COMPROBANDO. IVA DEL 21%
            Iva = Val(baseImponible * 0.21)
            'SUMAMOS EL IMPORTE TOTAL + EL IVA 
            Factura.lblIva.Text = Format(Iva, "###.##")

            total = Val(importeTot + Iva)
            Factura.lblTOTALPago.Text = Format(total, "###.##")
        Else
            'CALCULANDO A PESAR DE QUE EL USUARIO DIGA QUE NO QUIERE CUPONES
            If rbNO.Checked = True Then
                Factura.Show()
                cantidad = Convert.ToInt32(Factura.lblCantidadHab.Text)
                precioH = Convert.ToInt32(Factura.lblPrecioHabitacion.Text)
                resultadoH = Val(cantidad) * Val(precioH)
                Factura.lblTotalHabitacion.Text = resultadoH


                descuento = Val(Factura.lblTipodeDescuento.Text)
                resultadoD = resultadoH
                Factura.lblDescuento.Text = resultadoD

                importeTot = resultadoD
                Factura.lblImporteTotal.Text = importeTot

                'BASE IMPONIBLE ENTRE 1.21
                baseImponible = Val(importeTot / 1.21)
                'COMPROBANDO. IVA DEL 21%
                Iva = Val(baseImponible * 0.21)
                'SUMAMOS EL IMPORTE TOTAL + EL IVA 
                Factura.lblIva.Text = Format(Iva, "###.##")

                total = Val(importeTot + Iva)
                Factura.lblTOTALPago.Text = Format(total, "###.##")

            End If

            MsgBox("Escribir codigo de descuento")
        End If

    End Sub

    Private Sub rb75_CheckedChanged(sender As Object, e As EventArgs) Handles rb75.CheckedChanged
        'AL PRESIONAR O ELEGIR EL CUPON DE 75% EL USUARIO PODRÁ EL CODIGO DEL CUPON EN SU RESPECTIVA IMAGEN
        pbcupon.Visible = True
        pbcupon.Image = My.Resources.cupon2

        If rb75.Checked = True Then
            Factura.lblTipodeDescuento.Text = "50%"
        End If
    End Sub

End Class