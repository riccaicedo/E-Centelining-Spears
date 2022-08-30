Imports System.Windows.Forms.DataVisualization.Charting

Public Class VerDatos1

    'Variables Del libro Excel
    Public HE = libro.Worksheets("EJEMPLO")
    Public Hoja1 = libro.Worksheets("Convertidora")
    Public Hoja2 = libro.Worksheets("PFMS")
    Public Hoja3 = libro.Worksheets("CASE PACKER")
    Public Hoja4 = libro.Worksheets("OKURA")

    'Se asigna por Defecto la Hoja de Ejemplo
    Public DRango = HE

    'Cerrar Formulario Secundario
    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    'Variables Globales
    Dim r1 As Integer
    Dim r2 As Integer
    ReadOnly zoomMas As Integer
    ReadOnly contador As Integer
    ReadOnly zoomMenos As Integer
    Dim columna As Integer
    Dim serie1 As String
    ReadOnly serie2 As String
    Dim Ref As String
    ReadOnly estado As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

#Region "Funciones ComboBox"


    Private Sub CBModulo_Enter(sender As Object, e As EventArgs) Handles CBModulo.Enter

        'Limpiamos la lita del combobox
        Me.CBModulo.Items.Clear()
        'Me.CBModulo.Items.Add("EJEMPLO")
        Me.CBModulo.Items.Add("Convertidora")
        Me.CBModulo.Items.Add("PFMS")
        Me.CBModulo.Items.Add("CASE PACKER")
        Me.CBModulo.Items.Add("OKURA")

    End Sub

    Private Sub CBModulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModulo.SelectedIndexChanged
        If Me.CBModulo.Text = "HE" Then
            DRango = HE
        End If
        If Me.CBModulo.Text = "Convertidora" Then
            DRango = Hoja1
        End If
        If Me.CBModulo.Text = "PFMS" Then
            DRango = Hoja2
        End If
        If Me.CBModulo.Text = "CASE PACKER" Then
            DRango = Hoja3
        End If
        If Me.CBModulo.Text = "OKURA" Then
            DRango = Hoja4
        End If
    End Sub

    Private Sub CBRef_Enter(sender As Object, e As EventArgs) Handles CBRef.Enter

        If Me.CBModulo.Text = "" Then
            MsgBox("Debe Selecionar Un Modulo")
        Else
            'Limpiamos la lita del combobox
            Me.CBRef.Items.Clear()
            Me.CBRef.Items.Add("BW HUG CUID 4EN1 FTOP 12X80 BNOVA (O&D)")
            Me.CBRef.Items.Add("BW HUG LIMP EFECT FTOP 1X640 (8X80) (O&D)")
            Me.CBRef.Items.Add("BW HUG MAN Y CARIT FTOP 12X80 BNOVA")
            Me.CBRef.Items.Add("BW HUG LIMP EFECT FTOP 24X48 BNOVA")
            Me.CBRef.Items.Add("BW HUG LIMP EFECT FTOP 12X96 BNOVA")
            Me.CBRef.Items.Add("BW HUG LIMP EFECT FTOP 12X120 BNOVA")
            Me.CBRef.Items.Add("BW HUG P&N FTOP 12X80 BNOVA")
            Me.CBRef.Items.Add("BW HUG LIMP EFECT FTOP 12X96")
            Me.CBRef.Items.Add("BW HUG P&N FTOP 24X48")
        End If

    End Sub

    Private Sub CBRef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRef.SelectedIndexChanged

        If Me.CBRef.Text = "" Then
            Ref = " "
        Else
            Ref = Me.CBRef.Text
        End If

    End Sub

    Private Sub CBSerie1_Enter(sender As Object, e As EventArgs) Handles CBSerie1.Enter
        Dim columna As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBSerie1.Items.Clear()

        If Me.CBModulo.Text = "" Then
            MsgBox("Debe Selecionar Un Modulo")
        Else
            'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
            final = NRegC(DRango, 6, 1) - 1
            'en la columna 9 empiezan las series
            For columna = 9 To final
                'en la Fila 6 se encuentran las series
                lista = DRango.Cells(6, columna).Text
                Me.CBSerie1.Items.Add(lista)
            Next
        End If
    End Sub

    Private Sub CBSerie1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSerie1.SelectedIndexChanged

        Dim final As Integer

        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = NRegC(DRango, 7, 1) - 1

        'en la columna 5 empiezan las series 
        For columna = 9 To final
            'en la Fila 6 se encuentran las series
            If DRango.Cells(6, columna).Text = Me.CBSerie1.Text Then
                serie1 = Me.CBSerie1.Text
                columna = columna
                Exit For
            End If

        Next

        If Me.CBSerie1.Text = "" Then
            serie1 = " "
            columna = " "
        End If

    End Sub

    Private Sub CBRango1_Enter(sender As Object, e As EventArgs) Handles CBRango1.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String
        Dim turno As String

        Me.CBRango1.Items.Clear()
        'Funcion para Mostar la ultima fila vacia Hoja-FILA-COLUMNA
        final = NReg(DRango, 7, 1) - 1
        For fila = 7 To final
            'Solo añade los puntos segun Referencia Ubicada en Columna 4
            If DRango.Cells(fila, 4).Text = Ref Then
                lista = DRango.Cells(fila, 1).Text
                turno = DRango.Cells(fila, 8).Text
                Me.CBRango1.Items.Add(lista & " Turno: " & turno)
            End If
        Next
    End Sub

    Private Sub CBRango1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRango1.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        Dim cadena As String

        final = NReg(DRango, 7, 1) - 1

        'Recorre el arreglo fila=inicio y final
        For fila = 7 To final

            cadena = DRango.Cells(fila, 1).Text & " Turno: " & DRango.Cells(fila, 8).Text

            If cadena = Me.CBRango1.Text Then
                r1 = fila
                'MsgBox("RANGO1= " & r1 & "FILA= " & fila)
                Exit For
            End If
        Next

        If Me.CBRango1.Text = "" Then
            r1 = " "
        End If
    End Sub

    Private Sub CBRango2_Enter(sender As Object, e As EventArgs) Handles CBRango2.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String
        Dim turno As String

        Me.CBRango2.Items.Clear()
        'Funcion para Mostar la ultima fila vacia Hoja-FILA-COLUMNA
        final = NReg(DRango, 7, 1) - 1

        For fila = 7 To final
            'Solo añade los puntos segun Referencia Ubicada en Columna 4
            If DRango.Cells(fila, 4).Text = Ref Then
                lista = DRango.Cells(fila, 1).Text
                turno = DRango.Cells(fila, 8).Text
                Me.CBRango2.Items.Add(lista & " Turno: " & turno)
            End If
        Next
    End Sub

    Private Sub CBRango2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRango2.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        Dim cadena As String

        final = NReg(DRango, 7, 1) - 1

        'Recorre el arreglo fila=inicio y final
        For fila = 7 To final

            cadena = DRango.Cells(fila, 1).Text & " Turno: " & DRango.Cells(fila, 8).Text

            If cadena = Me.CBRango2.Text Then
                r2 = fila
                'MsgBox("RANGO2= " & r2 & "FILA= " & fila)
                Exit For
            End If
        Next

        If Me.CBRango2.Text = "" Then
            r2 = " "
        End If
    End Sub

#End Region


    Private Sub Button_Abrir_Click(sender As Object, e As EventArgs) Handles ButtonAbrir.Click
        Process.Start(Application.StartupPath & "\ExcelBD\CENTERLINING SPEARS.xlsx")
    End Sub

End Class