Imports Microsoft.Office.Interop

Module VariablesGlobales

    'Se crea la instancia y objeto excel
    Public ExcelApp = New Microsoft.Office.Interop.Excel.Application
    Public libro = ExcelApp
    'Variables Del libro Excel
    Public Final As Long
End Module
