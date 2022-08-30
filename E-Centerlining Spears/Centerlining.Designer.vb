<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Centerlining
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Centerlining))
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmBarraProgreso = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.LogoKCC = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenuCenterlining = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnCenterlining = New System.Windows.Forms.Button()
        Me.btnDataView = New System.Windows.Forms.Button()
        Me.Separador2 = New System.Windows.Forms.Panel()
        Me.Separador1 = New System.Windows.Forms.Panel()
        Me.LetraCoform = New System.Windows.Forms.PictureBox()
        Me.LogoCoform = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.subMenu = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnOkura = New System.Windows.Forms.Button()
        Me.btnCasePacker = New System.Windows.Forms.Button()
        Me.btnPFMS = New System.Windows.Forms.Button()
        Me.btnConvertidora = New System.Windows.Forms.Button()
        Me.PanelBarraProgreso = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.LogoKCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenuCenterlining.SuspendLayout()
        CType(Me.LetraCoform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoCoform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subMenu.SuspendLayout()
        Me.PanelBarraProgreso.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'tmBarraProgreso
        '
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelCabecera.Controls.Add(Me.LogoKCC)
        Me.PanelCabecera.Controls.Add(Me.btnRestaurar)
        Me.PanelCabecera.Controls.Add(Me.btnMinimizar)
        Me.PanelCabecera.Controls.Add(Me.btnMaximizar)
        Me.PanelCabecera.Controls.Add(Me.btnCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1165, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'LogoKCC
        '
        Me.LogoKCC.BackColor = System.Drawing.Color.White
        Me.LogoKCC.Image = Global.E_Centerlining_Spears.My.Resources.Resources.LOGO
        Me.LogoKCC.Location = New System.Drawing.Point(0, 0)
        Me.LogoKCC.Name = "LogoKCC"
        Me.LogoKCC.Size = New System.Drawing.Size(220, 40)
        Me.LogoKCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoKCC.TabIndex = 8
        Me.LogoKCC.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.E_Centerlining_Spears.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1079, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.Text = " "
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.E_Centerlining_Spears.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1033, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.Text = " "
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.E_Centerlining_Spears.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1079, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.Text = " "
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.E_Centerlining_Spears.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(1125, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = " "
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenuCenterlining
        '
        Me.PanelMenuCenterlining.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel2)
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel7)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnCenterlining)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnDataView)
        Me.PanelMenuCenterlining.Controls.Add(Me.Separador2)
        Me.PanelMenuCenterlining.Controls.Add(Me.Separador1)
        Me.PanelMenuCenterlining.Controls.Add(Me.LetraCoform)
        Me.PanelMenuCenterlining.Controls.Add(Me.LogoCoform)
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel1)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnGraficar)
        Me.PanelMenuCenterlining.Controls.Add(Me.subMenu)
        Me.PanelMenuCenterlining.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuCenterlining.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenuCenterlining.Name = "PanelMenuCenterlining"
        Me.PanelMenuCenterlining.Size = New System.Drawing.Size(220, 678)
        Me.PanelMenuCenterlining.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(3, 280)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 75)
        Me.Panel2.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel7.Location = New System.Drawing.Point(3, 199)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 75)
        Me.Panel7.TabIndex = 5
        '
        'btnCenterlining
        '
        Me.btnCenterlining.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCenterlining.FlatAppearance.BorderSize = 0
        Me.btnCenterlining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnCenterlining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCenterlining.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCenterlining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCenterlining.ForeColor = System.Drawing.Color.White
        Me.btnCenterlining.Image = Global.E_Centerlining_Spears.My.Resources.Resources.producto
        Me.btnCenterlining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCenterlining.Location = New System.Drawing.Point(3, 280)
        Me.btnCenterlining.Name = "btnCenterlining"
        Me.btnCenterlining.Size = New System.Drawing.Size(217, 75)
        Me.btnCenterlining.TabIndex = 1
        Me.btnCenterlining.Text = " Centerlining"
        Me.btnCenterlining.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCenterlining.UseVisualStyleBackColor = True
        '
        'btnDataView
        '
        Me.btnDataView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataView.FlatAppearance.BorderSize = 0
        Me.btnDataView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnDataView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataView.ForeColor = System.Drawing.Color.White
        Me.btnDataView.Image = Global.E_Centerlining_Spears.My.Resources.Resources.Lupa
        Me.btnDataView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDataView.Location = New System.Drawing.Point(0, 198)
        Me.btnDataView.Name = "btnDataView"
        Me.btnDataView.Size = New System.Drawing.Size(220, 76)
        Me.btnDataView.TabIndex = 8
        Me.btnDataView.Text = "   Data View"
        Me.btnDataView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataView.UseVisualStyleBackColor = True
        '
        'Separador2
        '
        Me.Separador2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Separador2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Separador2.Location = New System.Drawing.Point(3, 100)
        Me.Separador2.Name = "Separador2"
        Me.Separador2.Size = New System.Drawing.Size(214, 2)
        Me.Separador2.TabIndex = 5
        '
        'Separador1
        '
        Me.Separador1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Separador1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Separador1.Location = New System.Drawing.Point(3, 2)
        Me.Separador1.Name = "Separador1"
        Me.Separador1.Size = New System.Drawing.Size(214, 2)
        Me.Separador1.TabIndex = 4
        '
        'LetraCoform
        '
        Me.LetraCoform.BackColor = System.Drawing.Color.White
        Me.LetraCoform.Image = Global.E_Centerlining_Spears.My.Resources.Resources.OPEX
        Me.LetraCoform.Location = New System.Drawing.Point(119, 11)
        Me.LetraCoform.Name = "LetraCoform"
        Me.LetraCoform.Size = New System.Drawing.Size(80, 85)
        Me.LetraCoform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LetraCoform.TabIndex = 7
        Me.LetraCoform.TabStop = False
        '
        'LogoCoform
        '
        Me.LogoCoform.Image = Global.E_Centerlining_Spears.My.Resources.Resources.WIPES
        Me.LogoCoform.Location = New System.Drawing.Point(18, 8)
        Me.LogoCoform.Name = "LogoCoform"
        Me.LogoCoform.Size = New System.Drawing.Size(80, 88)
        Me.LogoCoform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoCoform.TabIndex = 6
        Me.LogoCoform.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Location = New System.Drawing.Point(3, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 76)
        Me.Panel1.TabIndex = 3
        '
        'btnGraficar
        '
        Me.btnGraficar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGraficar.FlatAppearance.BorderSize = 0
        Me.btnGraficar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnGraficar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficar.ForeColor = System.Drawing.Color.White
        Me.btnGraficar.Image = Global.E_Centerlining_Spears.My.Resources.Resources.reportes
        Me.btnGraficar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficar.Location = New System.Drawing.Point(0, 117)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGraficar.Size = New System.Drawing.Size(220, 75)
        Me.btnGraficar.TabIndex = 0
        Me.btnGraficar.Text = " Graficar"
        Me.btnGraficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'subMenu
        '
        Me.subMenu.Controls.Add(Me.Panel8)
        Me.subMenu.Controls.Add(Me.Panel6)
        Me.subMenu.Controls.Add(Me.Panel4)
        Me.subMenu.Controls.Add(Me.Panel3)
        Me.subMenu.Controls.Add(Me.btnOkura)
        Me.subMenu.Controls.Add(Me.btnCasePacker)
        Me.subMenu.Controls.Add(Me.btnPFMS)
        Me.subMenu.Controls.Add(Me.btnConvertidora)
        Me.subMenu.Location = New System.Drawing.Point(14, 361)
        Me.subMenu.Name = "subMenu"
        Me.subMenu.Size = New System.Drawing.Size(200, 227)
        Me.subMenu.TabIndex = 5
        Me.subMenu.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel8.Location = New System.Drawing.Point(2, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 51)
        Me.Panel8.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.Location = New System.Drawing.Point(2, 174)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 51)
        Me.Panel6.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Location = New System.Drawing.Point(2, 117)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 51)
        Me.Panel4.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Location = New System.Drawing.Point(2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 51)
        Me.Panel3.TabIndex = 5
        '
        'btnOkura
        '
        Me.btnOkura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkura.FlatAppearance.BorderSize = 0
        Me.btnOkura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnOkura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnOkura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOkura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkura.ForeColor = System.Drawing.Color.White
        Me.btnOkura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOkura.Location = New System.Drawing.Point(3, 174)
        Me.btnOkura.Name = "btnOkura"
        Me.btnOkura.Size = New System.Drawing.Size(197, 51)
        Me.btnOkura.TabIndex = 12
        Me.btnOkura.Text = "Okura"
        Me.btnOkura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOkura.UseVisualStyleBackColor = True
        '
        'btnCasePacker
        '
        Me.btnCasePacker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCasePacker.FlatAppearance.BorderSize = 0
        Me.btnCasePacker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnCasePacker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCasePacker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCasePacker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCasePacker.ForeColor = System.Drawing.Color.White
        Me.btnCasePacker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCasePacker.Location = New System.Drawing.Point(1, 117)
        Me.btnCasePacker.Name = "btnCasePacker"
        Me.btnCasePacker.Size = New System.Drawing.Size(200, 51)
        Me.btnCasePacker.TabIndex = 14
        Me.btnCasePacker.Text = "Case Packer"
        Me.btnCasePacker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCasePacker.UseVisualStyleBackColor = True
        '
        'btnPFMS
        '
        Me.btnPFMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPFMS.FlatAppearance.BorderSize = 0
        Me.btnPFMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnPFMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPFMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPFMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPFMS.ForeColor = System.Drawing.Color.White
        Me.btnPFMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPFMS.Location = New System.Drawing.Point(0, 60)
        Me.btnPFMS.Name = "btnPFMS"
        Me.btnPFMS.Size = New System.Drawing.Size(200, 51)
        Me.btnPFMS.TabIndex = 8
        Me.btnPFMS.Text = "PFMs"
        Me.btnPFMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPFMS.UseVisualStyleBackColor = True
        '
        'btnConvertidora
        '
        Me.btnConvertidora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvertidora.FlatAppearance.BorderSize = 0
        Me.btnConvertidora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnConvertidora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnConvertidora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvertidora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertidora.ForeColor = System.Drawing.Color.White
        Me.btnConvertidora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConvertidora.Location = New System.Drawing.Point(0, 3)
        Me.btnConvertidora.Name = "btnConvertidora"
        Me.btnConvertidora.Size = New System.Drawing.Size(200, 51)
        Me.btnConvertidora.TabIndex = 7
        Me.btnConvertidora.Text = "Convertidora"
        Me.btnConvertidora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConvertidora.UseVisualStyleBackColor = True
        '
        'PanelBarraProgreso
        '
        Me.PanelBarraProgreso.Controls.Add(Me.btnGuardar)
        Me.PanelBarraProgreso.Controls.Add(Me.ProgressBar1)
        Me.PanelBarraProgreso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBarraProgreso.Location = New System.Drawing.Point(220, 668)
        Me.PanelBarraProgreso.Name = "PanelBarraProgreso"
        Me.PanelBarraProgreso.Size = New System.Drawing.Size(945, 50)
        Me.PanelBarraProgreso.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.E_Centerlining_Spears.My.Resources.Resources.Guardar3
        Me.btnGuardar.Location = New System.Drawing.Point(896, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(44, 43)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(885, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.PanelBarraProgreso)
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenuCenterlining)
        Me.PanelContenedor.Controls.Add(Me.PanelCabecera)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1165, 718)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.Gray
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(220, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(945, 678)
        Me.PanelFormularios.TabIndex = 2
        '
        'Centerlining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 718)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(980, 661)
        Me.Name = "Centerlining"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centerlining"
        Me.PanelCabecera.ResumeLayout(False)
        CType(Me.LogoKCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenuCenterlining.ResumeLayout(False)
        CType(Me.LetraCoform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoCoform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subMenu.ResumeLayout(False)
        Me.PanelBarraProgreso.ResumeLayout(False)
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents tmBarraProgreso As Timer
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents LogoKCC As PictureBox
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelMenuCenterlining As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnCenterlining As Button
    Friend WithEvents btnDataView As Button
    Friend WithEvents Separador2 As Panel
    Friend WithEvents Separador1 As Panel
    Friend WithEvents LetraCoform As PictureBox
    Friend WithEvents LogoCoform As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGraficar As Button
    Friend WithEvents subMenu As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOkura As Button
    Friend WithEvents btnCasePacker As Button
    Friend WithEvents btnPFMS As Button
    Friend WithEvents btnConvertidora As Button
    Friend WithEvents PanelBarraProgreso As Panel
    Friend WithEvents btnGuardar As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelFormularios As Panel
End Class
