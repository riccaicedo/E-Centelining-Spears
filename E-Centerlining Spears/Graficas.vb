Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graficas

    'Variables Del libro Excel
    Public HE = libro.Worksheets("EJEMPLO")
    Public Hoja1 = libro.Worksheets("Convertidora")
    Public Hoja2 = libro.Worksheets("PFMS")
    Public Hoja3 = libro.Worksheets("CASE PACKER")
    Public Hoja4 = libro.Worksheets("OKURA")

    'Se asigna por Defecto la Hoja de Ejemplo
    Public DRango = HE

    'Cerrar Formulario Secundario
    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    'Variables Globales
    Dim r1 As Integer
    Dim r2 As Integer
    Dim zoomMas As Integer
    Dim contador As Integer
    Dim zoomMenos As Integer
    Dim columna As Integer
    Dim serie1 As String
    Dim serie2 As String
    Dim Ref As String
    Dim estado As Integer

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

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        Dim fila As Integer
        Dim col1 As String
        Dim colT As String
        Dim col2 As Decimal
        Dim LSC As Decimal
        Dim OBJ As Decimal
        Dim LIC As Decimal
        Dim PLSC As Integer
        Dim POBJ As Integer
        Dim PLIC As Integer

        colT = ""

        If CBSerie1.Text = "" Or CBModulo.Text = "" Or CBRef.Text = "" Then
            MsgBox("Seleccione un Modulo, una Serie, una Referencia y defina un Rango para Graficar tus Datos")
        Else

            If CBRango1.Text = "" Or CBRango2.Text = "" Then
                MsgBox("No hay un Rango definido para Graficar")
            Else

                If r1 > r2 Then
                    MsgBox("Rango Incorrecto")
                Else
                    estado = 1
                    'Creacion de Series
                    Me.Grafico.Series.Clear()
                    Me.Grafico.Series.Add(serie1)
                    Me.Grafico.Series.Add("LSC")
                    Me.Grafico.Series.Add("OBJ")
                    Me.Grafico.Series.Add("LIC")
                    Me.Grafico.Series.Add("PLSC")
                    Me.Grafico.Series.Add("POBJ")
                    Me.Grafico.Series.Add("PLIC")

                    'Limpiar Grafico Serie
                    Me.Grafico.Series(serie1).Points.Clear()
                    Me.Grafico.Series("LSC").Points.Clear()
                    Me.Grafico.Series("OBJ").Points.Clear()
                    Me.Grafico.Series("LIC").Points.Clear()

                    'Creacion del estilo de la Serie
                    Me.Grafico.Series(serie1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    Me.Grafico.Series("LSC").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    Me.Grafico.Series("PLSC").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
                    Me.Grafico.Series("OBJ").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    Me.Grafico.Series("POBJ").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
                    Me.Grafico.Series("LIC").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    Me.Grafico.Series("PLIC").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point

                    'Titulo del area de Grafico 
                    Me.Grafico.ChartAreas("ChartArea1").AxisX.Title = "Tiempo"
                    Me.Grafico.ChartAreas("ChartArea1").AxisY.Title = (serie1)

                    'Se le asigna a la variables zoom el numero de datos visibles del grafico
                    zoomMas = Me.Grafico.ChartAreas("ChartArea1").AxisX.ScaleView.Size

                    'Inhablitar leyenda de serie de puntos 
                    Me.Grafico.Series("PLSC").IsVisibleInLegend = False
                    Me.Grafico.Series("POBJ").IsVisibleInLegend = False
                    Me.Grafico.Series("PLIC").IsVisibleInLegend = False

                    'Color y Estilo de Series
                    Me.Grafico.Series(serie1).BorderWidth = 2
                    Me.Grafico.Series(serie1).Color = Color.SteelBlue
                    Me.Grafico.Series("LSC").Color = Color.Red
                    Me.Grafico.Series("OBJ").Color = Color.Green
                    Me.Grafico.Series("LIC").Color = Color.Red
                    Me.Grafico.Series(serie1).MarkerColor = Color.Blue
                    Me.Grafico.Series(serie1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                    Me.Grafico.Series(serie1).MarkerSize = 7
                    'Me.Grafico.Series(serie1).Label = ""
                    'Me.Grafico.Series(serie1).LabelBackColor = Color.White
                    Me.Grafico.Series(serie1).LabelForeColor = Color.Black

                    'Definir escala del Area del Grafico en eje Y fuera del cero predeterminado
                    Me.Grafico.ChartAreas("ChartArea1").AxisY.IsStartedFromZero = False
                    'Recalcular
                    'Me.Grafico.ChartAreas("ChartArea1").AxisY.Maximum = Double.NaN
                    'Me.Grafico.ChartAreas("ChartArea1").AxisY.Minimum = Double.NaN
                    'Me.Grafico.ChartAreas("ChartArea1").RecalculateAxesScale()


                    For fila = r1 To r2
                        ' Grafica solo los puntos de la Referencia selecionada 
                        If DRango.Cells(fila, 4).Text = Ref Then

                            'valores eje x fecha
                            col1 = DRango.Cells(fila, 1).Text
                            'valores eje x Turno
                            If DRango.Cells(fila, 8).Text = "I" Then
                                colT = "Turno:I\n"
                            End If
                            If DRango.Cells(fila, 8).Text = "II" Then
                                colT = "Turno:II\n"
                            End If
                            If DRango.Cells(fila, 8).Text = "III" Then
                                colT = "Turno:III\n"
                            End If

                            'valores eje Y
                            col2 = DRango.Cells(fila, columna).Text
                            'LSC en eje Y
                            LSC = DRango.Cells(3, columna).Text
                            PLSC = DRango.Cells(3, columna).Text
                            'OBJ en eje Y
                            OBJ = DRango.Cells(4, columna).Text
                            POBJ = DRango.Cells(4, columna).Text
                            'LIC en eje Y
                            LIC = DRango.Cells(5, columna).Text
                            PLIC = DRango.Cells(5, columna).Text

                            'Agregar ToolTip
                            Me.Grafico.Series(serie1).ToolTip = "#VALY"
                            'PUNTOS DE LAS SERIES
                            Me.Grafico.Series(serie1).Points.AddXY(colT & col1, col2)
                            Me.Grafico.Series("LSC").Points.AddXY(col1, LSC)
                            Me.Grafico.Series("OBJ").Points.AddXY(col1, OBJ)
                            Me.Grafico.Series("LIC").Points.AddXY(col1, LIC)

                            'Solo Dibuja un punto en el tiempo
                            If fila = r2 Then
                                Me.Grafico.Series("PLSC").MarkerColor = Color.Red
                                Me.Grafico.Series("PLSC").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                                Me.Grafico.Series("PLSC").MarkerSize = 7
                                Me.Grafico.Series("PLSC").LabelForeColor = Color.Black
                                Me.Grafico.Series("PLSC").Label = "#VALY"
                                Me.Grafico.Series("PLSC").Points.AddXY(col1, LSC)
                                '------------------------------------------------
                                Me.Grafico.Series("POBJ").MarkerColor = Color.Green
                                Me.Grafico.Series("POBJ").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                                Me.Grafico.Series("POBJ").MarkerSize = 7
                                Me.Grafico.Series("POBJ").LabelForeColor = Color.Black
                                Me.Grafico.Series("POBJ").Label = "#VALY"
                                Me.Grafico.Series("POBJ").Points.AddXY(col1, OBJ)
                                '------------------------------------------------
                                Me.Grafico.Series("PLIC").MarkerColor = Color.Red
                                Me.Grafico.Series("PLIC").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                                Me.Grafico.Series("PLIC").MarkerSize = 7
                                Me.Grafico.Series("PLIC").LabelForeColor = Color.Black
                                Me.Grafico.Series("PLIC").Label = "#VALY"
                                Me.Grafico.Series("PLIC").Points.AddXY(col1, LIC)

                            End If

                        End If

                    Next
                End If

            End If

        End If

    End Sub

    Private Sub btnPuntos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPuntos.MouseClick

        If estado = 1 Then

            Dim Respuesta As MsgBoxResult = MsgBox("Desea ver los Valores" &
                                                   "?", vbExclamation + vbYesNo, "Microsoft Excel")
            Select Case Respuesta
                Case MsgBoxResult.Yes
                    Me.Grafico.Series(serie1).Label = "#VALY"

                Case MsgBoxResult.No
                    Me.Grafico.Series(serie1).Label = " "
            End Select

        Else
            MsgBox("Debe existir una grafica ")
        End If

    End Sub

    Private Sub LabelMas_Click(sender As Object, e As EventArgs) Handles LabelMas.Click


        zoomMas = zoomMas + 5
        Me.Grafico.ChartAreas("ChartArea1").AxisX.ScaleView.Size = zoomMas
        zoomMenos = zoomMas

    End Sub

    Private Sub LabelMenos_Click(sender As Object, e As EventArgs) Handles LabelMenos.Click


        If zoomMenos > 5 Then
            zoomMenos = zoomMenos - 5
            Me.Grafico.ChartAreas("ChartArea1").AxisX.ScaleView.Size = zoomMenos
            zoomMas = zoomMenos
        Else MsgBox("No se puede Reducir mas El grafico")

        End If


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class