Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb

Public Class VerDatos2

    'Variables Del libro Excel
    Public Hoja1 = libro.Worksheets("Convertidora")
    Public Hoja2 = libro.Worksheets("PFMS")
    Public Hoja3 = libro.Worksheets("CASE PACKER")
    Public Hoja4 = libro.Worksheets("OKURA")

    'Se asigna por Defecto la Hoja de Ejemplo
    Public DRango = Hoja1

    'Cerrar Formulario Secundario
    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button_Abrir_Click(sender As Object, e As EventArgs) Handles ButtonAbrir.Click
        Process.Start(Application.StartupPath & "\ExcelBD\CENTERLINING SPEARS.xlsx")
    End Sub

    Private Sub CBModulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModulo.SelectedIndexChanged

        If Me.CBModulo.Text = "" Then
            MsgBox("Debe Selecionar Un Modulo")
        Else
            'Limpiamos la lita del combobox
            Me.CBModulo.Items.Clear()
            Me.CBModulo.Items.Add("Convertidora")
            Me.CBModulo.Items.Add("PFMS")
            Me.CBModulo.Items.Add("Case Packer")
            Me.CBModulo.Items.Add("Okura")
        End If

        If Me.CBModulo.Text = "Convertidora" Then
            DRango = Hoja1
        End If
        If Me.CBModulo.Text = "PFMS" Then
            DRango = Hoja2
        End If
        If Me.CBModulo.Text = "Case Packer" Then
            DRango = Hoja3
        End If
        If Me.CBModulo.Text = "Okura" Then
            DRango = Hoja4
        End If
    End Sub

    Private Sub Button_Ver_Click(sender As Object, e As EventArgs) Handles ButtonVer.Click
        If e Is Nothing Then
            Throw New ArgumentNullException(NameOf(e))
        End If

        Try
            Dim MyConnection As OleDbConnection
            Dim dataSet As DataSet
            Dim MyCommand As OleDbDataAdapter
            Dim path = (Application.StartupPath & "\ExcelBD\CENTERLINING SPEARS.xlsx")
            MyConnection = NewMethod1(path)
            MyCommand = NewMethod2(MyConnection)
            dataSet = New DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Shared Function NewMethod2(MyConnection As OleDbConnection) As OleDbDataAdapter
        Return New OleDbDataAdapter("select * from [CENTERLINING SPEARS]", MyConnection)
    End Function

    Private Shared Function NewMethod1(path As String) As OleDbConnection
        Return New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
    End Function

End Class