<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerDatos1
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
        Me.PanelTituloConvertidora = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Label()
        Me.CBRango1 = New System.Windows.Forms.ComboBox()
        Me.CBRango2 = New System.Windows.Forms.ComboBox()
        Me.CBSerie1 = New System.Windows.Forms.ComboBox()
        Me.CBRef = New System.Windows.Forms.ComboBox()
        Me.CBModulo = New System.Windows.Forms.ComboBox()
        Me.PanelContenedorControlGrafico = New System.Windows.Forms.Panel()
        Me.ButtonAbrir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonVer = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelTituloConvertidora.SuspendLayout()
        Me.PanelContenedorControlGrafico.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTituloConvertidora
        '
        Me.PanelTituloConvertidora.BackColor = System.Drawing.SystemColors.GrayText
        Me.PanelTituloConvertidora.Controls.Add(Me.Label1)
        Me.PanelTituloConvertidora.Controls.Add(Me.Salir)
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
        'Salir
        '
        Me.Salir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.AutoSize = True
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Location = New System.Drawing.Point(906, 6)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(25, 24)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "X"
        '
        'CBRango1
        '
        Me.CBRango1.FormattingEnabled = True
        Me.CBRango1.Location = New System.Drawing.Point(6, 53)
        Me.CBRango1.Name = "CBRango1"
        Me.CBRango1.Size = New System.Drawing.Size(217, 21)
        Me.CBRango1.TabIndex = 8
        '
        'CBRango2
        '
        Me.CBRango2.FormattingEnabled = True
        Me.CBRango2.Location = New System.Drawing.Point(6, 98)
        Me.CBRango2.Name = "CBRango2"
        Me.CBRango2.Size = New System.Drawing.Size(217, 21)
        Me.CBRango2.TabIndex = 9
        '
        'CBSerie1
        '
        Me.CBSerie1.FormattingEnabled = True
        Me.CBSerie1.Location = New System.Drawing.Point(14, 101)
        Me.CBSerie1.Name = "CBSerie1"
        Me.CBSerie1.Size = New System.Drawing.Size(537, 21)
        Me.CBSerie1.TabIndex = 11
        '
        'CBRef
        '
        Me.CBRef.FormattingEnabled = True
        Me.CBRef.Location = New System.Drawing.Point(210, 42)
        Me.CBRef.Name = "CBRef"
        Me.CBRef.Size = New System.Drawing.Size(341, 21)
        Me.CBRef.TabIndex = 15
        '
        'CBModulo
        '
        Me.CBModulo.FormattingEnabled = True
        Me.CBModulo.Location = New System.Drawing.Point(14, 42)
        Me.CBModulo.Name = "CBModulo"
        Me.CBModulo.Size = New System.Drawing.Size(189, 21)
        Me.CBModulo.TabIndex = 16
        '
        'PanelContenedorControlGrafico
        '
        Me.PanelContenedorControlGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContenedorControlGrafico.BackColor = System.Drawing.Color.DarkGray
        Me.PanelContenedorControlGrafico.Controls.Add(Me.ButtonAbrir)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Panel2)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.ButtonVer)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label6)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label5)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label4)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBSerie1)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBModulo)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBRef)
        Me.PanelContenedorControlGrafico.Location = New System.Drawing.Point(12, 43)
        Me.PanelContenedorControlGrafico.Name = "PanelContenedorControlGrafico"
        Me.PanelContenedorControlGrafico.Size = New System.Drawing.Size(925, 144)
        Me.PanelContenedorControlGrafico.TabIndex = 17
        '
        'ButtonAbrir
        '
        Me.ButtonAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ButtonAbrir.Image = Global.E_Centerlining_Spears.My.Resources.Resources.excel
        Me.ButtonAbrir.Location = New System.Drawing.Point(808, 75)
        Me.ButtonAbrir.Name = "ButtonAbrir"
        Me.ButtonAbrir.Size = New System.Drawing.Size(118, 56)
        Me.ButtonAbrir.TabIndex = 20
        Me.ButtonAbrir.Text = "Abrir Excel"
        Me.ButtonAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonAbrir.UseVisualStyleBackColor = True
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
        Me.Panel2.Location = New System.Drawing.Point(560, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 133)
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
        'ButtonVer
        '
        Me.ButtonVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ButtonVer.Image = Global.E_Centerlining_Spears.My.Resources.Resources.ver_detalles2
        Me.ButtonVer.Location = New System.Drawing.Point(808, 12)
        Me.ButtonVer.Name = "ButtonVer"
        Me.ButtonVer.Size = New System.Drawing.Size(118, 57)
        Me.ButtonVer.TabIndex = 21
        Me.ButtonVer.Text = "Ver Datos"
        Me.ButtonVer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonVer.UseVisualStyleBackColor = True
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
        Me.Label5.Location = New System.Drawing.Point(207, 23)
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
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(925, 479)
        Me.DataGridView1.TabIndex = 18
        '
        'VerDatos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(934, 661)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PanelTituloConvertidora)
        Me.Controls.Add(Me.PanelContenedorControlGrafico)
        Me.Name = "VerDatos1"
        Me.Text = "Datos"
        Me.PanelTituloConvertidora.ResumeLayout(False)
        Me.PanelTituloConvertidora.PerformLayout()
        Me.PanelContenedorControlGrafico.ResumeLayout(False)
        Me.PanelContenedorControlGrafico.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTituloConvertidora As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Salir As Label
    Friend WithEvents CBRango1 As ComboBox
    Friend WithEvents CBRango2 As ComboBox
    Friend WithEvents CBSerie1 As ComboBox
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
    Friend WithEvents ButtonAbrir As Button
    Friend WithEvents ButtonVer As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
