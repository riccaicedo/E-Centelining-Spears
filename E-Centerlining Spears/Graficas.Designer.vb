<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Graficas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Grafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelTituloConvertidora = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBRango1 = New System.Windows.Forms.ComboBox()
        Me.CBRango2 = New System.Windows.Forms.ComboBox()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.CBSerie1 = New System.Windows.Forms.ComboBox()
        Me.btnPuntos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelMas = New System.Windows.Forms.Label()
        Me.LabelMenos = New System.Windows.Forms.Label()
        Me.CBRef = New System.Windows.Forms.ComboBox()
        Me.CBModulo = New System.Windows.Forms.ComboBox()
        Me.PanelContenedorControlGrafico = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTituloConvertidora.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelContenedorControlGrafico.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grafico
        '
        Me.Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grafico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grafico.BorderlineWidth = 0
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.ScaleView.Size = 5.0R
        ChartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        ChartArea1.AxisX.ScrollBar.Size = 18.0R
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.GrayText
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.GrayText
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.CursorX.LineColor = System.Drawing.Color.DimGray
        ChartArea1.CursorX.SelectionColor = System.Drawing.Color.Maroon
        ChartArea1.CursorY.LineColor = System.Drawing.Color.DimGray
        ChartArea1.CursorY.SelectionColor = System.Drawing.Color.Maroon
        ChartArea1.Name = "ChartArea1"
        Me.Grafico.ChartAreas.Add(ChartArea1)
        Me.Grafico.Cursor = System.Windows.Forms.Cursors.Default
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Me.Grafico.Legends.Add(Legend1)
        Me.Grafico.Location = New System.Drawing.Point(12, 233)
        Me.Grafico.Name = "Grafico"
        Me.Grafico.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Grafico.Size = New System.Drawing.Size(910, 369)
        Me.Grafico.TabIndex = 2
        Me.Grafico.Text = "Chart1"
        '
        'PanelTituloConvertidora
        '
        Me.PanelTituloConvertidora.BackColor = System.Drawing.SystemColors.GrayText
        Me.PanelTituloConvertidora.Controls.Add(Me.Label1)
        Me.PanelTituloConvertidora.Controls.Add(Me.Label2)
        Me.PanelTituloConvertidora.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTituloConvertidora.Location = New System.Drawing.Point(0, 0)
        Me.PanelTituloConvertidora.Name = "PanelTituloConvertidora"
        Me.PanelTituloConvertidora.Size = New System.Drawing.Size(934, 37)
        Me.PanelTituloConvertidora.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Grafica tus Datos"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(906, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'CBRango1
        '
        Me.CBRango1.FormattingEnabled = True
        Me.CBRango1.Location = New System.Drawing.Point(6, 53)
        Me.CBRango1.Name = "CBRango1"
        Me.CBRango1.Size = New System.Drawing.Size(198, 21)
        Me.CBRango1.TabIndex = 8
        '
        'CBRango2
        '
        Me.CBRango2.FormattingEnabled = True
        Me.CBRango2.Location = New System.Drawing.Point(6, 98)
        Me.CBRango2.Name = "CBRango2"
        Me.CBRango2.Size = New System.Drawing.Size(198, 21)
        Me.CBRango2.TabIndex = 9
        '
        'btnGraficar
        '
        Me.btnGraficar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGraficar.Location = New System.Drawing.Point(822, 8)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(75, 23)
        Me.btnGraficar.TabIndex = 10
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'CBSerie1
        '
        Me.CBSerie1.FormattingEnabled = True
        Me.CBSerie1.Location = New System.Drawing.Point(14, 101)
        Me.CBSerie1.Name = "CBSerie1"
        Me.CBSerie1.Size = New System.Drawing.Size(574, 21)
        Me.CBSerie1.TabIndex = 11
        '
        'btnPuntos
        '
        Me.btnPuntos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPuntos.Location = New System.Drawing.Point(822, 40)
        Me.btnPuntos.Name = "btnPuntos"
        Me.btnPuntos.Size = New System.Drawing.Size(75, 23)
        Me.btnPuntos.TabIndex = 13
        Me.btnPuntos.Text = "Puntos"
        Me.btnPuntos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grafico de Control"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.LabelMas)
        Me.Panel1.Controls.Add(Me.LabelMenos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 37)
        Me.Panel1.TabIndex = 14
        '
        'LabelMas
        '
        Me.LabelMas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMas.AutoSize = True
        Me.LabelMas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMas.ForeColor = System.Drawing.Color.White
        Me.LabelMas.Location = New System.Drawing.Point(851, 6)
        Me.LabelMas.Name = "LabelMas"
        Me.LabelMas.Size = New System.Drawing.Size(24, 26)
        Me.LabelMas.TabIndex = 6
        Me.LabelMas.Text = "+"
        '
        'LabelMenos
        '
        Me.LabelMenos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMenos.AutoSize = True
        Me.LabelMenos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMenos.ForeColor = System.Drawing.Color.White
        Me.LabelMenos.Location = New System.Drawing.Point(880, 5)
        Me.LabelMenos.Name = "LabelMenos"
        Me.LabelMenos.Size = New System.Drawing.Size(22, 27)
        Me.LabelMenos.TabIndex = 5
        Me.LabelMenos.Text = "-"
        '
        'CBRef
        '
        Me.CBRef.FormattingEnabled = True
        Me.CBRef.Location = New System.Drawing.Point(259, 42)
        Me.CBRef.Name = "CBRef"
        Me.CBRef.Size = New System.Drawing.Size(329, 21)
        Me.CBRef.TabIndex = 15
        '
        'CBModulo
        '
        Me.CBModulo.FormattingEnabled = True
        Me.CBModulo.Location = New System.Drawing.Point(14, 42)
        Me.CBModulo.Name = "CBModulo"
        Me.CBModulo.Size = New System.Drawing.Size(239, 21)
        Me.CBModulo.TabIndex = 16
        '
        'PanelContenedorControlGrafico
        '
        Me.PanelContenedorControlGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContenedorControlGrafico.BackColor = System.Drawing.Color.DarkGray
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Panel2)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label6)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label5)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label4)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBSerie1)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBModulo)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.btnPuntos)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBRef)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.btnGraficar)
        Me.PanelContenedorControlGrafico.Location = New System.Drawing.Point(12, 43)
        Me.PanelContenedorControlGrafico.Name = "PanelContenedorControlGrafico"
        Me.PanelContenedorControlGrafico.Size = New System.Drawing.Size(910, 144)
        Me.PanelContenedorControlGrafico.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.CBRango2)
        Me.Panel2.Controls.Add(Me.CBRango1)
        Me.Panel2.Location = New System.Drawing.Point(594, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 133)
        Me.Panel2.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Final"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Inicio "
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Rango del Intervalo"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Serie a Graficar"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(256, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Referencia"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Modulo de Maquina"
        '
        'Graficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(934, 661)
        Me.Controls.Add(Me.PanelContenedorControlGrafico)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTituloConvertidora)
        Me.Controls.Add(Me.Grafico)
        Me.Name = "Graficas"
        Me.Text = "Graficas"
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTituloConvertidora.ResumeLayout(False)
        Me.PanelTituloConvertidora.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelContenedorControlGrafico.ResumeLayout(False)
        Me.PanelContenedorControlGrafico.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grafico As DataVisualization.Charting.Chart
    Friend WithEvents PanelTituloConvertidora As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBRango1 As ComboBox
    Friend WithEvents CBRango2 As ComboBox
    Friend WithEvents btnGraficar As Button
    Friend WithEvents CBSerie1 As ComboBox
    Friend WithEvents btnPuntos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBRef As ComboBox
    Friend WithEvents CBModulo As ComboBox
    Friend WithEvents PanelContenedorControlGrafico As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelMas As Label
    Friend WithEvents LabelMenos As Label
End Class
