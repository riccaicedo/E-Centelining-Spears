Module Module1

    'Encuentra la ultima fila vacia
    Public Function NReg(Hoja As Microsoft.Office.Interop.Excel.Worksheet, nFila As Long, nColumna As Long)
        Do Until Hoja.Cells(nFila, nColumna).Text = ""
            nFila += 1
        Loop
        Return nFila
    End Function

    'Encuentra la ultima columna vacia
    Public Function NRegC(Hoja As Microsoft.Office.Interop.Excel.Worksheet, nFila As Long, nColumna As Long)
        Do Until Hoja.Cells(nFila, nColumna).Text = ""
            nColumna += 1
        Loop
        Return nColumna
    End Function

    Public Function Emax(Hoja As Microsoft.Office.Interop.Excel.WorksheetFunction, R1 As Long, R2 As Long)
        Dim valormaximo As Integer
        valormaximo = Hoja.Max(R1, R2)
        Return valormaximo
    End Function

End Module
