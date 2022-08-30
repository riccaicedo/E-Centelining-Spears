Public Class Convertidora

    'Variables Del libro Excel
    Public HDatos = libro.Worksheets("DATOS")
    Public HCenterlining = libro.Worksheets("CONVERTIDORA")

    'Variables Globales
    Dim turno As String
    Dim supervisor As String
    Dim operario As String
    Dim referencia As String
    Dim LabelConvertidora As String
    Dim contadorVariablesFuera As Integer
    Dim SaludMaquina As Decimal

    'Cerrar Formulario Secundario
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelX.Click
        Me.Close()
    End Sub

#Region "Envio de Datos"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or
            TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or
            TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Or
            TextBox16.Text = "" Or TextBox17.Text = "" Or TextBox18.Text = "" Or TextBox19.Text = "" Or TextBox20.Text = "" Or
            TextBox21.Text = "" Or TextBox22.Text = "" Or TextBox23.Text = "" Or TextBox24.Text = "" Or TextBox25.Text = "" Or
            TextBox26.Text = "" Or TextBox27.Text = "" Or TextBox28.Text = "" Or TextBox29.Text = "" Or TextBox30.Text = "" Or
            TextBox31.Text = "" Or CBTurno.Text = "" Or CBSupervisor.Text = "" Or
            CBOperario.Text = "" Or CBReferencia.Text = "") Or
            (TextBox1.Text = "-" Or TextBox2.Text = "-" Or TextBox3.Text = "-" Or TextBox4.Text = "-" Or TextBox5.Text = "-" Or
            TextBox6.Text = "-" Or TextBox7.Text = "-" Or TextBox8.Text = "-" Or TextBox9.Text = "-" Or TextBox10.Text = "-" Or
            TextBox11.Text = "-" Or TextBox12.Text = "-" Or TextBox13.Text = "-" Or TextBox14.Text = "-" Or TextBox15.Text = "-" Or
            TextBox16.Text = "-" Or TextBox17.Text = "-" Or TextBox18.Text = "-" Or TextBox19.Text = "-" Or TextBox20.Text = "-" Or
            TextBox21.Text = "-" Or TextBox22.Text = "-" Or TextBox23.Text = "-" Or TextBox24.Text = "-" Or TextBox25.Text = "-" Or
            TextBox26.Text = "-" Or TextBox27.Text = "-" Or TextBox28.Text = "-" Or TextBox29.Text = "-" Or TextBox30.Text = "-" Or
            TextBox31.Text = "-" Or CBTurno.Text = "-" Or CBSupervisor.Text = "-" Or
            CBOperario.Text = "-" Or CBReferencia.Text = "-") Then
            MsgBox("Se encuentran casillas en blanco o con datos invalidos")
        Else

            'Variables 
            'Dim fecha As String = Format(Now, "short Date")
            Dim fecha As Date = Today
            'Dim fecha As String = DateString
            Dim hora As String = TimeOfDay.TimeOfDay.ToString
            Dim Ucolumna

            'Variables para guardar limites
            Dim LSC As Decimal
            Dim OBJ As Decimal
            Dim LIC As Decimal


            'Variables de Proceso
            Dim textb As Integer
            textb = 0
            Dim VariablesConvertidora As String

            'Dim TemperaturaSpinPumpB As String = TextBox2.Text

            'Format(Now, "dddd, d MMM yyyy")
            'MsgBox(fecha)
            'MsgBox("fecha personalizada: " & Format(Now, "d/MM/yyyy"))

            'Funcion para Mostar la Fila vacia seleccionas la Hoja - Inicio FILA- Inicio COLUMNA
            Final = NReg(HCenterlining, 7, 1)

            'Funcion para Mostar la ultima Columna seleccionas la Hoja - Inicio FILA- Inicio COLUMNA
            Ucolumna = NRegC(HCenterlining, 6, 1)

            ' Pegar variables Staticas
            HCenterlining.cells(Final, 1) = fecha
            HCenterlining.cells(Final, 2) = hora
            HCenterlining.cells(Final, 5) = referencia
            HCenterlining.Cells(Final, 6) = supervisor
            HCenterlining.Cells(Final, 7) = operario
            HCenterlining.Cells(Final, 8) = turno

            'Instalar Referencia
            If referencia = "Huggies Cuidado 4 en 1 X80" Then
                HCenterlining.Cells(5, 6) = "BW HUG CUID 4EN1 FTOP 12X80 BNOVA (O&D)"
            End If
            If referencia = "Huggies Limpieza Efectiva (O&D) X80" Then
                HCenterlining.Cells(5, 6) = "BW HUG LIMP EFECT FTOP 1X640 (8X80) (O&D)"
            End If
            If referencia = "Huggies Manitas y Caritas X80" Then
                HCenterlining.Cells(5, 6) = "BW HUG MAN Y CARIT FTOP 12X80 BNOVA"
            End If
            If referencia = "Huggies Limpieza Efectiva X48" Then
                HCenterlining.Cells(5, 6) = "BW HUG LIMP EFECT FTOP 24X48 BNOVA"
            End If
            If referencia = "Huggies Limpieza Efectiva X96 Maluma" Then
                HCenterlining.Cells(5, 6) = "BW HUG LIMP EFECT FTOP 12X96 BNOVA"
            End If
            If referencia = "Huggies Limpieza Efectiva X120" Then
                HCenterlining.Cells(5, 6) = "BW HUG LIMP EFECT FTOP 12X120 BNOVA"
            End If
            If referencia = "Huggies Puro y Natural X80" Then
                HCenterlining.Cells(5, 6) = "BW HUG P&N FTOP 12X80 BNOVA"
            End If
            If referencia = "Huggies Limpieza Efectiva X96" Then
                HCenterlining.Cells(5, 6) = "BW HUG LIMP EFECT FTOP 12X96"
            End If
            If referencia = "Huggies Puro y Natural X48" Then
                HCenterlining.Cells(5, 6) = "BW HUG P&N FTOP 24X48"
            End If

            'prueba recorrer todos los texbox y Pegarlos--
            For Each oControl As Control In Me.PanelVariables.Controls


                If TypeOf oControl Is TextBox Then

                    textb += 1
                    VariablesConvertidora = CType(oControl, TextBox).Text


#Region "label Convertidora"
                    If textb = 18 Then
                        LabelConvertidora = Label31.Text
                    End If
                    If textb = 19 Then
                        LabelConvertidora = Label30.Text
                    End If
                    If textb = 20 Then
                        LabelConvertidora = Label29.Text
                    End If
                    If textb = 21 Then
                        LabelConvertidora = Label28.Text
                    End If
                    If textb = 22 Then
                        LabelConvertidora = Label27.Text
                    End If
                    If textb = 23 Then
                        LabelConvertidora = Label26.Text
                    End If
                    If textb = 24 Then
                        LabelConvertidora = Label25.Text
                    End If
                    If textb = 25 Then
                        LabelConvertidora = Label24.Text
                    End If
                    If textb = 26 Then
                        LabelConvertidora = Label23.Text
                    End If
                    If textb = 27 Then
                        LabelConvertidora = Label22.Text
                    End If
                    If textb = 28 Then
                        LabelConvertidora = Label21.Text
                    End If
                    If textb = 29 Then
                        LabelConvertidora = Label20.Text
                    End If
                    If textb = 30 Then
                        LabelConvertidora = Label19.Text
                    End If
                    If textb = 31 Then
                        LabelConvertidora = Label18.Text
                    End If
                    If textb = 32 Then
                        LabelConvertidora = Label17.Text
                    End If
                    If textb = 33 Then
                        LabelConvertidora = Label16.Text
                    End If
                    If textb = 34 Then
                        LabelConvertidora = Label15.Text
                    End If
                    If textb = 35 Then
                        LabelConvertidora = Label14.Text
                    End If
                    If textb = 36 Then
                        LabelConvertidora = Label13.Text
                    End If
                    If textb = 37 Then
                        LabelConvertidora = Label12.Text
                    End If
                    If textb = 38 Then
                        LabelConvertidora = Label11.Text
                    End If
                    If textb = 39 Then
                        LabelConvertidora = Label10.Text
                    End If
                    If textb = 40 Then
                        LabelConvertidora = Label9.Text
                    End If
                    If textb = 41 Then
                        LabelConvertidora = Label8.Text
                    End If
                    If textb = 42 Then
                        LabelConvertidora = Label7.Text
                    End If
                    If textb = 43 Then
                        LabelConvertidora = Label6.Text
                    End If
                    If textb = 44 Then
                        LabelConvertidora = Label5.Text
                    End If
                    If textb = 45 Then
                        LabelConvertidora = Label4.Text
                    End If
                    If textb = 46 Then
                        LabelConvertidora = Label3.Text
                    End If
                    If textb = 47 Then
                        LabelConvertidora = Label2.Text
                    End If
                    If textb = 48 Then
                        LabelConvertidora = Label1.Text
                    End If
#End Region

                    ' llenado de limites 
                    LSC = HCenterlining.Cells(3, Ucolumna - textb).Value
                    OBJ = HCenterlining.Cells(4, Ucolumna - textb).Value
                    LIC = HCenterlining.Cells(5, Ucolumna - textb).Value

                    ' Inserta las variables
                    HCenterlining.Cells(Final, Ucolumna - textb) = Convert.ToDecimal(VariablesConvertidora)

                    ' Examina las variables si se encuentran fuera de los limites 
                    If Convert.ToDecimal(VariablesConvertidora) <= LIC Or Convert.ToDecimal(VariablesConvertidora) >= LSC Then

                        contadorVariablesFuera += 1

                        'Envio de Comentarios
                        Dim descripcion As String
                        descripcion = InputBox("Descripcion de Evento " & LabelConvertidora & ": " & VariablesConvertidora, "Variables Fuera de Rango : # " & contadorVariablesFuera)

                        If String.IsNullOrEmpty(descripcion) Then

                            HCenterlining.cells(Final, Ucolumna - textb).AddComment
                            HCenterlining.cells(Final, Ucolumna - textb).Comment.Text("Actualizacion de Limites de Control")
                            HCenterlining.cells(Final, Ucolumna - textb).Interior.Color = RGB(150, 152, 154)
                        Else

                            HCenterlining.cells(Final, Ucolumna - textb).AddComment
                            HCenterlining.cells(Final, Ucolumna - textb).Comment.Text(descripcion)
                            HCenterlining.cells(Final, Ucolumna - textb).Interior.Color = RGB(255, 128, 0)
                        End If

                    End If

                End If

            Next

            SaludMaquina = 100 - ((contadorVariablesFuera / textb) * 100)
            SaludMaquina = Format(SaludMaquina, "0.00")
            MsgBox("Las variables fuera de rango fueron: " & contadorVariablesFuera & vbCrLf & "El estado de salud de su máquina es: " & SaludMaquina & " %.")

            ' Borrar Datos despues de Registralos en el Libro
#Region "Limpieza de TextBox"

            contadorVariablesFuera = 0
            CBTurno.Text = vbNullChar
            CBSupervisor.Text = vbNullChar
            CBOperario.Text = vbNullChar
            CBReferencia.Text = vbNullChar
            TextBox1.Text = vbNullChar
            TextBox2.Text = vbNullChar
            TextBox3.Text = vbNullChar
            TextBox4.Text = vbNullChar
            TextBox5.Text = vbNullChar
            TextBox6.Text = vbNullChar
            TextBox7.Text = vbNullChar
            TextBox8.Text = vbNullChar
            TextBox9.Text = vbNullChar
            TextBox10.Text = vbNullChar
            TextBox11.Text = vbNullChar
            TextBox12.Text = vbNullChar
            TextBox13.Text = vbNullChar
            TextBox14.Text = vbNullChar
            TextBox15.Text = vbNullChar
            TextBox16.Text = vbNullChar
            TextBox17.Text = vbNullChar
            TextBox18.Text = vbNullChar
            TextBox19.Text = vbNullChar
            TextBox20.Text = vbNullChar
            TextBox21.Text = vbNullChar
            TextBox22.Text = vbNullChar
            TextBox23.Text = vbNullChar
            TextBox24.Text = vbNullChar
            TextBox25.Text = vbNullChar
            TextBox26.Text = vbNullChar
            TextBox27.Text = vbNullChar
            TextBox28.Text = vbNullChar
            TextBox29.Text = vbNullChar
            TextBox30.Text = vbNullChar
            TextBox31.Text = vbNullChar
#End Region

        End If

    End Sub
#End Region

#Region "Funciones ComboBox"
    Private Sub CBTurno_Enter(sender As Object, e As EventArgs) Handles CBTurno.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBTurno.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 1) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 1).Text
            Me.CBTurno.Items.Add(lista)
        Next
    End Sub

    Private Sub CBTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTurno.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 1) - 1
        For fila = 2 To final
            If HDatos.Cells(fila, 1).Text = Me.CBTurno.Text Then
                turno = HDatos.Cells(fila, 1).Text
                'MsgBox(turno)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBTurno_TextChanged(sender As Object, e As EventArgs) Handles CBTurno.TextChanged
        If Me.CBTurno.Text = "" Then
            turno = ""

        End If
    End Sub

    Private Sub CBSupervisor_Enter(sender As Object, e As EventArgs) Handles CBSupervisor.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBSupervisor.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 3) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 3).Text
            Me.CBSupervisor.Items.Add(lista)
        Next
    End Sub

    Private Sub CBSupervisor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSupervisor.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 3) - 1

        For fila = 2 To final
            If HDatos.Cells(fila, 3).Text = Me.CBSupervisor.Text Then
                supervisor = HDatos.Cells(fila, 3).Text
                'MsgBox(supervisor)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBSupervisor_TextChanged(sender As Object, e As EventArgs) Handles CBSupervisor.TextChanged
        If Me.CBSupervisor.Text = "" Then
            supervisor = ""

        End If
    End Sub

    Private Sub CBOperario_Enter(sender As Object, e As EventArgs) Handles CBOperario.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBOperario.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 4) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 4).Text
            Me.CBOperario.Items.Add(lista)
        Next
    End Sub

    Private Sub CBOperario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOperario.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 4) - 1

        For fila = 2 To final
            If HDatos.Cells(fila, 4).Text = Me.CBOperario.Text Then
                operario = HDatos.Cells(fila, 4).Text
                'MsgBox(operario)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBOperario_TextChanged(sender As Object, e As EventArgs) Handles CBOperario.TextChanged
        If Me.CBOperario.Text = "" Then
            operario = ""

        End If
    End Sub

    Private Sub CBReferencia_Enter(sender As Object, e As EventArgs) Handles CBReferencia.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBReferencia.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 2) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 2).Text
            Me.CBReferencia.Items.Add(lista)
        Next
    End Sub

    Private Sub CBReferencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBReferencia.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = NReg(HDatos, 2, 2) - 1

        For fila = 2 To final
            If HDatos.Cells(fila, 2).Text = Me.CBReferencia.Text Then
                referencia = HDatos.Cells(fila, 2).Text
                'MsgBox(referencia)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBReferencia_TextChanged(sender As Object, e As EventArgs) Handles CBReferencia.TextChanged
        If Me.CBReferencia.Text = "" Then
            referencia = ""

        End If
    End Sub
#End Region

#Region "Condicion para insertar solo Numeros"
    Public Sub Condicion(sender As TextBox, e As KeyPressEventArgs)
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If

        If Len(cadena) > 0 Then
            filtro += ","
        End If

        ' Agregar Punto (.) y convertirlo en Coma(;)
        If e.KeyChar = "." Then
            SendKeys.Send(",")
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True

            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""

            ' ingresar coma o punto solo despues de un numero
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "," And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then

            If Asc(e.KeyChar) = 13 Then
            Else sender.Text = ""
            End If

        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{Tab}")
        End If

        ' digitar , una sola vez
        If e.KeyChar = "," And Not cadena.IndexOf(",") Or e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Call Condicion(TextBox1, e)
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Call Condicion(TextBox2, e)
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Call Condicion(TextBox3, e)
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Call Condicion(TextBox4, e)
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Call Condicion(TextBox5, e)
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Call Condicion(TextBox6, e)
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Call Condicion(TextBox7, e)
    End Sub
    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        Call Condicion(TextBox8, e)
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Call Condicion(TextBox9, e)
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        Call Condicion(TextBox10, e)
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        Call Condicion(TextBox11, e)
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        Call Condicion(TextBox12, e)
    End Sub
    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        Call Condicion(TextBox13, e)
    End Sub
    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        Call Condicion(TextBox14, e)
    End Sub
    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        Call Condicion(TextBox15, e)
    End Sub
    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        Call Condicion(TextBox16, e)
    End Sub
    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        Call Condicion(TextBox17, e)
    End Sub
    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        Call Condicion(TextBox18, e)
    End Sub
    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        Call Condicion(TextBox19, e)
    End Sub
    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        Call Condicion(TextBox20, e)
    End Sub
    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        Call Condicion(TextBox21, e)
    End Sub
    Private Sub TextBox22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox22.KeyPress
        Call Condicion(TextBox22, e)
    End Sub
    Private Sub TextBox23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox23.KeyPress
        Call Condicion(TextBox23, e)
    End Sub
    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        Call Condicion(TextBox24, e)
    End Sub
    Private Sub TextBox25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox25.KeyPress
        Call Condicion(TextBox25, e)
    End Sub
    Private Sub TextBox26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox26.KeyPress
        Call Condicion(TextBox26, e)
    End Sub
    Private Sub TextBox27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox27.KeyPress
        Call Condicion(TextBox27, e)
    End Sub
    Private Sub TextBox28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox28.KeyPress
        Call Condicion(TextBox28, e)
    End Sub
    Private Sub TextBox29_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox29.KeyPress
        Call Condicion(TextBox29, e)
    End Sub
    Private Sub TextBox30_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox30.KeyPress
        Call Condicion(TextBox30, e)
    End Sub
    Private Sub TextBox31_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox31.KeyPress
        Call Condicion(TextBox31, e)
    End Sub

    'Resaltar Textbox al presionar Enter
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length
    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        TextBox2.SelectionStart = 0
        TextBox2.SelectionLength = TextBox2.Text.Length
    End Sub
    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        TextBox3.SelectionStart = 0
        TextBox3.SelectionLength = TextBox3.Text.Length
    End Sub
    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        TextBox4.SelectionStart = 0
        TextBox4.SelectionLength = TextBox4.Text.Length
    End Sub
    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter
        TextBox5.SelectionStart = 0
        TextBox5.SelectionLength = TextBox5.Text.Length
    End Sub
    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter
        TextBox6.SelectionStart = 0
        TextBox6.SelectionLength = TextBox6.Text.Length
    End Sub
    Private Sub TextBox7_Enter(sender As Object, e As EventArgs) Handles TextBox7.Enter
        TextBox7.SelectionStart = 0
        TextBox7.SelectionLength = TextBox7.Text.Length
    End Sub
    Private Sub TextBox8_Enter(sender As Object, e As EventArgs) Handles TextBox8.Enter
        TextBox8.SelectionStart = 0
        TextBox8.SelectionLength = TextBox8.Text.Length
    End Sub
    Private Sub TextBox9_Enter(sender As Object, e As EventArgs) Handles TextBox9.Enter
        TextBox9.SelectionStart = 0
        TextBox9.SelectionLength = TextBox9.Text.Length
    End Sub
    Private Sub TextBox10_Enter(sender As Object, e As EventArgs) Handles TextBox10.Enter
        TextBox10.SelectionStart = 0
        TextBox10.SelectionLength = TextBox10.Text.Length
    End Sub
    Private Sub TextBox11_Enter(sender As Object, e As EventArgs) Handles TextBox11.Enter
        TextBox11.SelectionStart = 0
        TextBox11.SelectionLength = TextBox11.Text.Length
    End Sub
    Private Sub TextBox12_Enter(sender As Object, e As EventArgs) Handles TextBox12.Enter
        TextBox12.SelectionStart = 0
        TextBox12.SelectionLength = TextBox12.Text.Length
    End Sub
    Private Sub TextBox13_Enter(sender As Object, e As EventArgs) Handles TextBox13.Enter
        TextBox13.SelectionStart = 0
        TextBox13.SelectionLength = TextBox13.Text.Length
    End Sub
    Private Sub TextBox14_Enter(sender As Object, e As EventArgs) Handles TextBox14.Enter
        TextBox14.SelectionStart = 0
        TextBox14.SelectionLength = TextBox14.Text.Length
    End Sub
    Private Sub TextBox15_Enter(sender As Object, e As EventArgs) Handles TextBox15.Enter
        TextBox15.SelectionStart = 0
        TextBox15.SelectionLength = TextBox15.Text.Length
    End Sub
    Private Sub TextBox16_Enter(sender As Object, e As EventArgs) Handles TextBox16.Enter
        TextBox16.SelectionStart = 0
        TextBox16.SelectionLength = TextBox16.Text.Length
    End Sub
    Private Sub TextBox17_Enter(sender As Object, e As EventArgs) Handles TextBox17.Enter
        TextBox17.SelectionStart = 0
        TextBox17.SelectionLength = TextBox17.Text.Length
    End Sub
    Private Sub TextBox18_Enter(sender As Object, e As EventArgs) Handles TextBox18.Enter
        TextBox18.SelectionStart = 0
        TextBox18.SelectionLength = TextBox18.Text.Length
    End Sub
    Private Sub TextBox19_Enter(sender As Object, e As EventArgs) Handles TextBox19.Enter
        TextBox19.SelectionStart = 0
        TextBox19.SelectionLength = TextBox19.Text.Length
    End Sub
    Private Sub TextBox20_Enter(sender As Object, e As EventArgs) Handles TextBox20.Enter
        TextBox20.SelectionStart = 0
        TextBox20.SelectionLength = TextBox20.Text.Length
    End Sub
    Private Sub TextBox21_Enter(sender As Object, e As EventArgs) Handles TextBox21.Enter
        TextBox21.SelectionStart = 0
        TextBox21.SelectionLength = TextBox21.Text.Length
    End Sub
    Private Sub TextBox22_Enter(sender As Object, e As EventArgs) Handles TextBox22.Enter
        TextBox22.SelectionStart = 0
        TextBox22.SelectionLength = TextBox22.Text.Length
    End Sub
    Private Sub TextBox23_Enter(sender As Object, e As EventArgs) Handles TextBox23.Enter
        TextBox23.SelectionStart = 0
        TextBox23.SelectionLength = TextBox23.Text.Length
    End Sub
    Private Sub TextBox24_Enter(sender As Object, e As EventArgs) Handles TextBox24.Enter
        TextBox24.SelectionStart = 0
        TextBox24.SelectionLength = TextBox24.Text.Length
    End Sub
    Private Sub TextBox25_Enter(sender As Object, e As EventArgs) Handles TextBox25.Enter
        TextBox25.SelectionStart = 0
        TextBox25.SelectionLength = TextBox25.Text.Length
    End Sub
    Private Sub TextBox26_Enter(sender As Object, e As EventArgs) Handles TextBox26.Enter
        TextBox26.SelectionStart = 0
        TextBox26.SelectionLength = TextBox26.Text.Length
    End Sub
    Private Sub TextBox27_Enter(sender As Object, e As EventArgs) Handles TextBox27.Enter
        TextBox27.SelectionStart = 0
        TextBox27.SelectionLength = TextBox27.Text.Length
    End Sub
    Private Sub TextBox28_Enter(sender As Object, e As EventArgs) Handles TextBox28.Enter
        TextBox28.SelectionStart = 0
        TextBox28.SelectionLength = TextBox28.Text.Length
    End Sub
    Private Sub TextBox29_Enter(sender As Object, e As EventArgs) Handles TextBox29.Enter
        TextBox29.SelectionStart = 0
        TextBox29.SelectionLength = TextBox29.Text.Length
    End Sub
    Private Sub TextBox30_Enter(sender As Object, e As EventArgs) Handles TextBox30.Enter
        TextBox30.SelectionStart = 0
        TextBox30.SelectionLength = TextBox30.Text.Length
    End Sub
    Private Sub TextBox31_Enter(sender As Object, e As EventArgs) Handles TextBox31.Enter
        TextBox31.SelectionStart = 0
        TextBox31.SelectionLength = TextBox31.Text.Length
    End Sub

#End Region

End Class