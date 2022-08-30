Public Class CasePacker

    'Evita que se devuelva el scroll
    Protected Overrides Function ScrollToControl(activeControl As Control) As Point
        Return Me.DisplayRectangle.Location
    End Function


    'Variables Del libro Excel
    Public HDatos = libro.Worksheets("DATOS")
    Public HCenterlining = libro.Worksheets("CASE PACKER")

    'Variables Globales
    Dim turno As String
    Dim supervisor As String
    Dim operario As String
    Dim referencia As String
    Dim LabelCasePacker2 As String
    Dim contadorVariablesFuera As Integer
    Dim SaludMaquina As Decimal

    'AutoScroll'
    Private Sub ScrollableForm()
        Me.AutoScroll = True
    End Sub

    'Cerrar Formulario Secundario
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelX.Click
        Me.Close()
    End Sub

#Region "Envio de Datos"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox40.Text = "" Or TextBox41.Text = "" Or TextBox42.Text = "" Or TextBox43.Text = "" Or TextBox44.Text = "" Or
            TextBox45.Text = "" Or TextBox46.Text = "" Or TextBox47.Text = "" Or TextBox48.Text = "" Or TextBox49.Text = "" Or
            TextBox50.Text = "" Or TextBox51.Text = "" Or TextBox52.Text = "" Or TextBox53.Text = "" Or TextBox54.Text = "" Or
            TextBox55.Text = "" Or TextBox56.Text = "" Or TextBox57.Text = "" Or TextBox59.Text = "" Or TextBox58.Text = "" Or
            CBTurno.Text = "" Or CBSupervisor.Text = "" Or
            CBOperario.Text = "" Or CBReferencia.Text = "") Or
            (TextBox40.Text = "-" Or TextBox41.Text = "-" Or TextBox42.Text = "-" Or TextBox43.Text = "-" Or TextBox44.Text = "-" Or
            TextBox45.Text = "-" Or TextBox46.Text = "-" Or TextBox47.Text = "-" Or TextBox48.Text = "-" Or TextBox49.Text = "-" Or
            TextBox50.Text = "-" Or TextBox51.Text = "-" Or TextBox52.Text = "-" Or TextBox53.Text = "-" Or TextBox54.Text = "-" Or
            TextBox55.Text = "-" Or TextBox56.Text = "-" Or TextBox57.Text = "-" Or TextBox59.Text = "-" Or TextBox58.Text = "-" Or
            CBTurno.Text = "-" Or CBSupervisor.Text = "-" Or
            CBOperario.Text = "-" Or CBReferencia.Text = "-") Then
            MsgBox("Se encuentran casillas con en blanco o con datos invalidos")
        Else

            'Variables 
            Dim fecha As Date = Today
            Dim hora As String = TimeOfDay.TimeOfDay.ToString
            Dim Ucolumna

            'Variables para guardar limites
            Dim LSC As Decimal
            Dim OBJ As Decimal
            Dim LIC As Decimal


            'Variables de Proceso
            Dim textb As Integer
            textb = 0
            Dim VariablesCasePacker2 As String

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
                    VariablesCasePacker2 = CType(oControl, TextBox).Text
#Region "label CasePacker2"
                    If textb = 1 Then
                        LabelCasePacker2 = Label59.Text
                    End If
                    If textb = 2 Then
                        LabelCasePacker2 = Label222.Text
                    End If
                    If textb = 3 Then
                        LabelCasePacker2 = Label57.Text
                    End If
                    If textb = 4 Then
                        LabelCasePacker2 = Label56.Text
                    End If
                    If textb = 5 Then
                        LabelCasePacker2 = Label55.Text
                    End If
                    If textb = 6 Then
                        LabelCasePacker2 = Label54.Text
                    End If
                    If textb = 7 Then
                        LabelCasePacker2 = Label53.Text
                    End If
                    If textb = 8 Then
                        LabelCasePacker2 = Label52.Text
                    End If
                    If textb = 9 Then
                        LabelCasePacker2 = Label51.Text
                    End If
                    If textb = 10 Then
                        LabelCasePacker2 = Label50.Text
                    End If
                    If textb = 11 Then
                        LabelCasePacker2 = Label49.Text
                    End If
                    If textb = 12 Then
                        LabelCasePacker2 = Label48.Text
                    End If
                    If textb = 13 Then
                        LabelCasePacker2 = Label47.Text
                    End If
                    If textb = 14 Then
                        LabelCasePacker2 = Label46.Text
                    End If
                    If textb = 15 Then
                        LabelCasePacker2 = Label45.Text
                    End If
                    If textb = 16 Then
                        LabelCasePacker2 = Label44.Text
                    End If
                    If textb = 17 Then
                        LabelCasePacker2 = Label43.Text
                    End If
                    If textb = 18 Then
                        LabelCasePacker2 = Label42.Text
                    End If
                    If textb = 19 Then
                        LabelCasePacker2 = Label41.Text
                    End If
                    If textb = 20 Then
                        LabelCasePacker2 = Label40.Text
                    End If
#End Region

                    ' llenado de limites 
                    LSC = HCenterlining.Cells(3, Ucolumna - textb).Value
                    OBJ = HCenterlining.Cells(4, Ucolumna - textb).Value
                    LIC = HCenterlining.Cells(5, Ucolumna - textb).Value

                    ' Inserta las variables
                    HCenterlining.Cells(Final, Ucolumna - textb) = Convert.ToDecimal(VariablesCasePacker2)

                    ' Examina las variables si se encuentran dentro de los limites 
                    If Convert.ToDecimal(VariablesCasePacker2) <= LIC Or Convert.ToDecimal(VariablesCasePacker2) >= LSC Then

                        contadorVariablesFuera += 1

                        'Envio de Comentarios
                        Dim descripcion As String
                        descripcion = InputBox("Descripcion de Evento " & LabelCasePacker2 & ": " & VariablesCasePacker2, "Variables Fuera de Rango : # " & contadorVariablesFuera)

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
            TextBox40.Text = vbNullChar
            TextBox41.Text = vbNullChar
            TextBox42.Text = vbNullChar
            TextBox43.Text = vbNullChar
            TextBox44.Text = vbNullChar
            TextBox45.Text = vbNullChar
            TextBox46.Text = vbNullChar
            TextBox47.Text = vbNullChar
            TextBox48.Text = vbNullChar
            TextBox49.Text = vbNullChar
            TextBox50.Text = vbNullChar
            TextBox51.Text = vbNullChar
            TextBox52.Text = vbNullChar
            TextBox53.Text = vbNullChar
            TextBox54.Text = vbNullChar
            TextBox55.Text = vbNullChar
            TextBox56.Text = vbNullChar
            TextBox57.Text = vbNullChar
            TextBox59.Text = vbNullChar
            TextBox58.Text = vbNullChar
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox40.KeyPress
        Call Condicion(TextBox40, e)
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox41.KeyPress
        Call Condicion(TextBox41, e)
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox42.KeyPress
        Call Condicion(TextBox42, e)
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox43.KeyPress
        Call Condicion(TextBox43, e)
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox44.KeyPress
        Call Condicion(TextBox44, e)
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox45.KeyPress
        Call Condicion(TextBox45, e)
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox46.KeyPress
        Call Condicion(TextBox46, e)
    End Sub
    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox47.KeyPress
        Call Condicion(TextBox47, e)
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox48.KeyPress
        Call Condicion(TextBox48, e)
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox49.KeyPress
        Call Condicion(TextBox49, e)
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox50.KeyPress
        Call Condicion(TextBox50, e)
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox51.KeyPress
        Call Condicion(TextBox51, e)
    End Sub
    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox52.KeyPress
        Call Condicion(TextBox52, e)
    End Sub
    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox53.KeyPress
        Call Condicion(TextBox53, e)
    End Sub
    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox54.KeyPress
        Call Condicion(TextBox54, e)
    End Sub
    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox55.KeyPress
        Call Condicion(TextBox55, e)
    End Sub
    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox56.KeyPress
        Call Condicion(TextBox56, e)
    End Sub
    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox57.KeyPress
        Call Condicion(TextBox57, e)
    End Sub
    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs)
        Call Condicion(TextBox59, e)
    End Sub
    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs)
        Call Condicion(TextBox58, e)
    End Sub

    'Resaltar Textbox al presionar Enter
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox40.Enter
        TextBox40.SelectionStart = 0
        TextBox40.SelectionLength = TextBox40.Text.Length
    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox41.Enter
        TextBox41.SelectionStart = 0
        TextBox41.SelectionLength = TextBox41.Text.Length
    End Sub
    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox42.Enter
        TextBox42.SelectionStart = 0
        TextBox42.SelectionLength = TextBox42.Text.Length
    End Sub
    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox43.Enter
        TextBox43.SelectionStart = 0
        TextBox43.SelectionLength = TextBox43.Text.Length
    End Sub
    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TextBox44.Enter
        TextBox44.SelectionStart = 0
        TextBox44.SelectionLength = TextBox44.Text.Length
    End Sub
    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox45.Enter
        TextBox45.SelectionStart = 0
        TextBox45.SelectionLength = TextBox45.Text.Length
    End Sub
    Private Sub TextBox7_Enter(sender As Object, e As EventArgs) Handles TextBox46.Enter
        TextBox46.SelectionStart = 0
        TextBox46.SelectionLength = TextBox46.Text.Length
    End Sub
    Private Sub TextBox8_Enter(sender As Object, e As EventArgs) Handles TextBox47.Enter
        TextBox47.SelectionStart = 0
        TextBox47.SelectionLength = TextBox47.Text.Length
    End Sub
    Private Sub TextBox9_Enter(sender As Object, e As EventArgs) Handles TextBox48.Enter
        TextBox48.SelectionStart = 0
        TextBox48.SelectionLength = TextBox48.Text.Length
    End Sub
    Private Sub TextBox10_Enter(sender As Object, e As EventArgs) Handles TextBox49.Enter
        TextBox49.SelectionStart = 0
        TextBox49.SelectionLength = TextBox49.Text.Length
    End Sub
    Private Sub TextBox11_Enter(sender As Object, e As EventArgs) Handles TextBox50.Enter
        TextBox50.SelectionStart = 0
        TextBox50.SelectionLength = TextBox50.Text.Length
    End Sub
    Private Sub TextBox12_Enter(sender As Object, e As EventArgs) Handles TextBox51.Enter
        TextBox51.SelectionStart = 0
        TextBox51.SelectionLength = TextBox51.Text.Length
    End Sub
    Private Sub TextBox13_Enter(sender As Object, e As EventArgs) Handles TextBox52.Enter
        TextBox52.SelectionStart = 0
        TextBox52.SelectionLength = TextBox52.Text.Length
    End Sub
    Private Sub TextBox14_Enter(sender As Object, e As EventArgs) Handles TextBox53.Enter
        TextBox53.SelectionStart = 0
        TextBox53.SelectionLength = TextBox53.Text.Length
    End Sub
    Private Sub TextBox15_Enter(sender As Object, e As EventArgs) Handles TextBox54.Enter
        TextBox54.SelectionStart = 0
        TextBox54.SelectionLength = TextBox54.Text.Length
    End Sub
    Private Sub TextBox16_Enter(sender As Object, e As EventArgs) Handles TextBox55.Enter
        TextBox55.SelectionStart = 0
        TextBox55.SelectionLength = TextBox55.Text.Length
    End Sub
    Private Sub TextBox17_Enter(sender As Object, e As EventArgs) Handles TextBox56.Enter
        TextBox56.SelectionStart = 0
        TextBox56.SelectionLength = TextBox56.Text.Length
    End Sub
    Private Sub TextBox18_Enter(sender As Object, e As EventArgs) Handles TextBox57.Enter
        TextBox57.SelectionStart = 0
        TextBox57.SelectionLength = TextBox57.Text.Length
    End Sub
    Private Sub TextBox19_Enter(sender As Object, e As EventArgs)
        TextBox58.SelectionStart = 0
        TextBox58.SelectionLength = TextBox58.Text.Length
    End Sub


#End Region

End Class