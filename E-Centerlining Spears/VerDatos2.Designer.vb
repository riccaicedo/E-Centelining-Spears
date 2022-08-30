<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDatos2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelTituloConvertidora = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonVer = New System.Windows.Forms.Button()
        Me.ButtonAbrir = New System.Windows.Forms.Button()
        Me.LabelModulo = New System.Windows.Forms.Label()
        Me.CBModulo = New System.Windows.Forms.ComboBox()
        Me.PanelTituloConvertidora.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTituloConvertidora
        '
        Me.PanelTituloConvertidora.BackColor = System.Drawing.SystemColors.GrayText
        Me.PanelTituloConvertidora.Controls.Add(Me.LabelTitulo)
        Me.PanelTituloConvertidora.Controls.Add(Me.Label2)
        Me.PanelTituloConvertidora.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTituloConvertidora.Location = New System.Drawing.Point(0, 0)
        Me.PanelTituloConvertidora.Name = "PanelTituloConvertidora"
        Me.PanelTituloConvertidora.Size = New System.Drawing.Size(934, 37)
        Me.PanelTituloConvertidora.TabIndex = 8
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelTitulo.Location = New System.Drawing.Point(3, 6)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(163, 20)
        Me.LabelTitulo.TabIndex = 3
        Me.LabelTitulo.Text = "Datos Centerlining "
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
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(925, 479)
        Me.DataGridView1.TabIndex = 9
        '
        'ButtonVer
        '
        Me.ButtonVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ButtonVer.Location = New System.Drawing.Point(565, 549)
        Me.ButtonVer.Name = "ButtonVer"
        Me.ButtonVer.Size = New System.Drawing.Size(170, 68)
        Me.ButtonVer.TabIndex = 11
        Me.ButtonVer.Text = "Ver Datos"
        Me.ButtonVer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonVer.UseVisualStyleBackColor = True
        '
        'ButtonAbrir
        '
        Me.ButtonAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ButtonAbrir.Location = New System.Drawing.Point(752, 549)
        Me.ButtonAbrir.Name = "ButtonAbrir"
        Me.ButtonAbrir.Size = New System.Drawing.Size(170, 68)
        Me.ButtonAbrir.TabIndex = 10
        Me.ButtonAbrir.Text = "Abrir Excel"
        Me.ButtonAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonAbrir.UseVisualStyleBackColor = True
        '
        'LabelModulo
        '
        Me.LabelModulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelModulo.AutoSize = True
        Me.LabelModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModulo.ForeColor = System.Drawing.Color.White
        Me.LabelModulo.Location = New System.Drawing.Point(16, 552)
        Me.LabelModulo.Name = "LabelModulo"
        Me.LabelModulo.Size = New System.Drawing.Size(143, 16)
        Me.LabelModulo.TabIndex = 17
        Me.LabelModulo.Text = "Modulo de Maquina"
        '
        'CBModulo
        '
        Me.CBModulo.FormattingEnabled = True
        Me.CBModulo.Location = New System.Drawing.Point(21, 575)
        Me.CBModulo.Name = "CBModulo"
        Me.CBModulo.Size = New System.Drawing.Size(521, 21)
        Me.CBModulo.TabIndex = 18
        '
        'VerDatos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(934, 661)
        Me.Controls.Add(Me.LabelModulo)
        Me.Controls.Add(Me.CBModulo)
        Me.Controls.Add(Me.ButtonVer)
        Me.Controls.Add(Me.ButtonAbrir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PanelTituloConvertidora)
        Me.Name = "VerDatos2"
        Me.Text = "VerDatos"
        Me.PanelTituloConvertidora.ResumeLayout(False)
        Me.PanelTituloConvertidora.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTituloConvertidora As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAbrir As Button
    Friend WithEvents ButtonVer As Button
    Friend WithEvents LabelModulo As Label
    Friend WithEvents CBModulo As ComboBox
End Class
