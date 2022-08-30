Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports Microsoft.Office.Interop
Imports System.Data

Public Class Centerlining

    'Variable para abrir Libro excel
    'Dim libroPrincipal = ExcelApp.Workbooks.Open(Filename:="C:\Centerlining-Sellado-PFM's\EJEMPLO.xlsx, ReadOnly:=True")
    'Dim libroPrincipal = ExcelApp.Workbooks.Open(Application.StartupPath & "\ExcelBD\CENTERLINING.xlsx", Notify:=False)
    Dim libroPrincipal = ExcelApp.Workbooks.Open(Application.StartupPath & "\ExcelBD\CENTERLINING SPEARS.xlsx")

    'Variable para Bara de Progreso
    Dim contador As Integer

#Region "Funcionalidades del Form"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    ReadOnly cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    'DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    ReadOnly tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click


        If libroPrincipal.Saved() = False Then
            Dim Respuesta As MsgBoxResult = MsgBox("Desea Guardar los Cambios " & libroPrincipal.name &
                                                   "?", vbExclamation + vbYesNo, "Microsoft Excel")
            Select Case Respuesta
                Case MsgBoxResult.Yes
                    ProgressBar1.Value = 0.0
                    ProgressBar1.Maximum = 120
                    tmBarraProgreso.Interval = 40
                    tmBarraProgreso.Enabled = True
                    libroPrincipal.Save()
                    MsgBox("Los Cambios han sido guardados en el libro: " & libroPrincipal.Name)
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()
                Case MsgBoxResult.No
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()
            End Select
        Else
            ExcelApp.Quit()
            libroPrincipal = Nothing
            ExcelApp = Nothing
            Application.Exit()

        End If

    End Sub

    'Variables para CAPTURAR VALORES DE LA PANTALLA
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnRestaurar.Visible = False
        btnMaximizar.Visible = True

    End Sub
#End Region

#Region "Timer del Form Principal"
    Private Sub TmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenuCenterlining.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenuCenterlining.Width = 60
        End If
    End Sub

    Private Sub TmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenuCenterlining.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenuCenterlining.Width = 220
        End If
    End Sub

    Private Sub TmBarraProgreso_Tick(sender As Object, e As EventArgs) Handles tmBarraProgreso.Tick
        If contador <= 120 Then
            ProgressBar1.Value = contador
            contador += 10
        Else
            tmBarraProgreso.Enabled = False
        End If
    End Sub

#End Region

#Region "Funcion de los Botones del Form"

    Private Sub BtnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        AbrirFormEnPanel(Of Graficas)()
        btnGraficar.BackColor = Color.SteelBlue

    End Sub

    Private Sub BtnDataView_Click(sender As Object, e As EventArgs) Handles btnDataView.Click
        'Process.Start(Application.StartupPath & "\ExcelBD\CENTERLINING SPEARS.xlsx")

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        AbrirFormEnPanel(Of VerDatos1)()
        btnDataView.BackColor = Color.SteelBlue
    End Sub

    Private Sub Centerlining_Click(sender As Object, e As EventArgs) Handles btnCenterlining.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        If subMenu.Visible = True Then
            subMenu.Visible = False
            btnCenterlining.BackColor = Color.FromArgb(37, 46, 59)
        Else
            subMenu.Visible = True
            btnCenterlining.BackColor = Color.SteelBlue
        End If

    End Sub

    Private Sub BtnConvertidora_Click(sender As Object, e As EventArgs) Handles btnConvertidora.Click
        btnConvertidora.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of Convertidora)()
    End Sub

    Private Sub BtnPFMs_Click(sender As Object, e As EventArgs) Handles btnPFMS.Click
        btnPFMS.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of PFMs)()
    End Sub

    Private Sub BtnCasePacker_Click(sender As Object, e As EventArgs) Handles btnCasePacker.Click
        btnCasePacker.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of CasePacker)()
    End Sub

    Private Sub BtnOkura_Click(sender As Object, e As EventArgs) Handles btnOkura.Click
        btnOkura.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of Okura)()
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select
        Else
            ProgressBar1.Value = 0.0
            ProgressBar1.Maximum = 120
            tmBarraProgreso.Interval = 40
            tmBarraProgreso.Enabled = True
            libroPrincipal.Save()
            MsgBox("Los Cambios han sido guardados en el libro: " & libroPrincipal.Name)
            ExcelApp.Quit()
            libroPrincipal = Nothing
            ExcelApp = Nothing
            Application.Exit()

        End If

    End Sub


#End Region

    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL
    Private Sub AbrirFormEnPanel(Of Forms As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Forms)().FirstOrDefault() 'Busca Formulario en coleccion

        If formulario Is Nothing Then
            formulario = New Forms With {
                .TopLevel = False,
                .FormBorderStyle = FormBorderStyle.None,
                .Dock = DockStyle.Fill
            }
            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            AddHandler formulario.FormClosed, AddressOf Me.CerrarFormulario
            formulario.Show()
            formulario.BringToFront()
        Else

            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If

            formulario.BringToFront()
        End If
    End Sub

    'METDO PARA CERRAR FORM SECURDARIOS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Codicion para examinar un from abierto
        If (Application.OpenForms("Graficas") Is Nothing) Then
            btnGraficar.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Convertidora") Is Nothing) Then
            btnConvertidora.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("PFMs") Is Nothing) Then
            btnPFMS.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Case Packer") Is Nothing) Then
            btnCasePacker.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Okura") Is Nothing) Then
            btnOkura.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Convertidora") Is Nothing) And (Application.OpenForms("PFMs") Is Nothing) And
            (Application.OpenForms("Case Packer") Is Nothing) And (Application.OpenForms("Okura") Is Nothing) And
            subMenu.Visible = False Then
            btnCenterlining.BackColor = Color.FromArgb(37, 46, 59)
        End If
    End Sub

End Class
