<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputActor2
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
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.pnlBlanco = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.pnlAtras = New System.Windows.Forms.Panel()
        Me.lblAtras = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEjemplo = New System.Windows.Forms.Label()
        Me.lblAsterisco7 = New System.Windows.Forms.Label()
        Me.lblAsterisco6 = New System.Windows.Forms.Label()
        Me.lblAsterisco5 = New System.Windows.Forms.Label()
        Me.lblAsterisco4 = New System.Windows.Forms.Label()
        Me.lblAsterisco3 = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.cboColorOjos = New System.Windows.Forms.ComboBox()
        Me.cboColorCabello = New System.Windows.Forms.ComboBox()
        Me.cboColorPiel = New System.Windows.Forms.ComboBox()
        Me.lblColorOjos = New System.Windows.Forms.Label()
        Me.lblColorCabello = New System.Windows.Forms.Label()
        Me.lblColorPiel = New System.Windows.Forms.Label()
        Me.lblKilogramos = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblMetros = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.rdoMujer = New System.Windows.Forms.RadioButton()
        Me.rdoHombre = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblSeccion = New System.Windows.Forms.Label()
        Me.pnlSiguiente = New System.Windows.Forms.Panel()
        Me.lblSiguiente = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBlanco.SuspendLayout()
        Me.pnlAtras.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlSiguiente.SuspendLayout()
        Me.SuspendLayout()
        '
        'picImagen
        '
        Me.picImagen.Image = Global.InferfacesHPA3.My.Resources.Resources.Roca
        Me.picImagen.Location = New System.Drawing.Point(584, 0)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(1552, 1098)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 3
        Me.picImagen.TabStop = False
        '
        'pnlBlanco
        '
        Me.pnlBlanco.BackColor = System.Drawing.Color.White
        Me.pnlBlanco.Controls.Add(Me.Label2)
        Me.pnlBlanco.Controls.Add(Me.Label4)
        Me.pnlBlanco.Controls.Add(Me.lblProgreso)
        Me.pnlBlanco.Controls.Add(Me.pnlAtras)
        Me.pnlBlanco.Controls.Add(Me.pnlPrincipal)
        Me.pnlBlanco.Controls.Add(Me.pnlSiguiente)
        Me.pnlBlanco.Controls.Add(Me.lblTitulo)
        Me.pnlBlanco.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlanco.Name = "pnlBlanco"
        Me.pnlBlanco.Size = New System.Drawing.Size(936, 1098)
        Me.pnlBlanco.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(112, 880)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 39)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Campo obligatorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(88, 888)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 39)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "*"
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Font = New System.Drawing.Font("Gadugi", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProgreso.Location = New System.Drawing.Point(421, 984)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(94, 45)
        Me.lblProgreso.TabIndex = 12
        Me.lblProgreso.Text = "2 / 3"
        '
        'pnlAtras
        '
        Me.pnlAtras.BackColor = System.Drawing.Color.Black
        Me.pnlAtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtras.Controls.Add(Me.lblAtras)
        Me.pnlAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAtras.ForeColor = System.Drawing.Color.White
        Me.pnlAtras.Location = New System.Drawing.Point(56, 968)
        Me.pnlAtras.Name = "pnlAtras"
        Me.pnlAtras.Size = New System.Drawing.Size(200, 72)
        Me.pnlAtras.TabIndex = 8
        '
        'lblAtras
        '
        Me.lblAtras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtras.AutoSize = True
        Me.lblAtras.Location = New System.Drawing.Point(66, 19)
        Me.lblAtras.Name = "lblAtras"
        Me.lblAtras.Size = New System.Drawing.Size(67, 32)
        Me.lblAtras.TabIndex = 0
        Me.lblAtras.Text = "Atrás"
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.AutoScroll = True
        Me.pnlPrincipal.Controls.Add(Me.Label1)
        Me.pnlPrincipal.Controls.Add(Me.lblEjemplo)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco7)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco6)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco5)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco4)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco3)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco2)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco1)
        Me.pnlPrincipal.Controls.Add(Me.cboColorOjos)
        Me.pnlPrincipal.Controls.Add(Me.cboColorCabello)
        Me.pnlPrincipal.Controls.Add(Me.cboColorPiel)
        Me.pnlPrincipal.Controls.Add(Me.lblColorOjos)
        Me.pnlPrincipal.Controls.Add(Me.lblColorCabello)
        Me.pnlPrincipal.Controls.Add(Me.lblColorPiel)
        Me.pnlPrincipal.Controls.Add(Me.lblKilogramos)
        Me.pnlPrincipal.Controls.Add(Me.txtPeso)
        Me.pnlPrincipal.Controls.Add(Me.lblPeso)
        Me.pnlPrincipal.Controls.Add(Me.lblMetros)
        Me.pnlPrincipal.Controls.Add(Me.txtAltura)
        Me.pnlPrincipal.Controls.Add(Me.lblAltura)
        Me.pnlPrincipal.Controls.Add(Me.rdoMujer)
        Me.pnlPrincipal.Controls.Add(Me.rdoHombre)
        Me.pnlPrincipal.Controls.Add(Me.lblSexo)
        Me.pnlPrincipal.Controls.Add(Me.dtpFechaNac)
        Me.pnlPrincipal.Controls.Add(Me.lblFechaNac)
        Me.pnlPrincipal.Controls.Add(Me.lblSeccion)
        Me.pnlPrincipal.Location = New System.Drawing.Point(72, 280)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(824, 584)
        Me.pnlPrincipal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(488, 592)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 32)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Ej. 20.55"
        '
        'lblEjemplo
        '
        Me.lblEjemplo.AutoSize = True
        Me.lblEjemplo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblEjemplo.ForeColor = System.Drawing.Color.Silver
        Me.lblEjemplo.Location = New System.Drawing.Point(488, 448)
        Me.lblEjemplo.Name = "lblEjemplo"
        Me.lblEjemplo.Size = New System.Drawing.Size(88, 32)
        Me.lblEjemplo.TabIndex = 71
        Me.lblEjemplo.Text = "Ej. 1.70"
        '
        'lblAsterisco7
        '
        Me.lblAsterisco7.AutoSize = True
        Me.lblAsterisco7.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco7.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco7.Location = New System.Drawing.Point(224, 983)
        Me.lblAsterisco7.Name = "lblAsterisco7"
        Me.lblAsterisco7.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco7.TabIndex = 70
        Me.lblAsterisco7.Text = "*"
        '
        'lblAsterisco6
        '
        Me.lblAsterisco6.AutoSize = True
        Me.lblAsterisco6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco6.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco6.Location = New System.Drawing.Point(272, 828)
        Me.lblAsterisco6.Name = "lblAsterisco6"
        Me.lblAsterisco6.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco6.TabIndex = 68
        Me.lblAsterisco6.Text = "*"
        '
        'lblAsterisco5
        '
        Me.lblAsterisco5.AutoSize = True
        Me.lblAsterisco5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco5.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco5.Location = New System.Drawing.Point(216, 676)
        Me.lblAsterisco5.Name = "lblAsterisco5"
        Me.lblAsterisco5.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco5.TabIndex = 66
        Me.lblAsterisco5.Text = "*"
        '
        'lblAsterisco4
        '
        Me.lblAsterisco4.AutoSize = True
        Me.lblAsterisco4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco4.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco4.Location = New System.Drawing.Point(88, 539)
        Me.lblAsterisco4.Name = "lblAsterisco4"
        Me.lblAsterisco4.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco4.TabIndex = 64
        Me.lblAsterisco4.Text = "*"
        '
        'lblAsterisco3
        '
        Me.lblAsterisco3.AutoSize = True
        Me.lblAsterisco3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco3.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco3.Location = New System.Drawing.Point(112, 392)
        Me.lblAsterisco3.Name = "lblAsterisco3"
        Me.lblAsterisco3.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco3.TabIndex = 62
        Me.lblAsterisco3.Text = "*"
        '
        'lblAsterisco2
        '
        Me.lblAsterisco2.AutoSize = True
        Me.lblAsterisco2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco2.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco2.Location = New System.Drawing.Point(88, 248)
        Me.lblAsterisco2.Name = "lblAsterisco2"
        Me.lblAsterisco2.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco2.TabIndex = 60
        Me.lblAsterisco2.Text = "*"
        '
        'lblAsterisco1
        '
        Me.lblAsterisco1.AutoSize = True
        Me.lblAsterisco1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco1.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco1.Location = New System.Drawing.Point(344, 88)
        Me.lblAsterisco1.Name = "lblAsterisco1"
        Me.lblAsterisco1.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco1.TabIndex = 58
        Me.lblAsterisco1.Text = "*"
        '
        'cboColorOjos
        '
        Me.cboColorOjos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColorOjos.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboColorOjos.FormattingEnabled = True
        Me.cboColorOjos.Items.AddRange(New Object() {"Marrón", "Negro", "Verde", "Gris", "Azul"})
        Me.cboColorOjos.Location = New System.Drawing.Point(16, 1026)
        Me.cboColorOjos.Name = "cboColorOjos"
        Me.cboColorOjos.Size = New System.Drawing.Size(400, 53)
        Me.cboColorOjos.TabIndex = 56
        '
        'cboColorCabello
        '
        Me.cboColorCabello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColorCabello.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboColorCabello.FormattingEnabled = True
        Me.cboColorCabello.Items.AddRange(New Object() {"Negro", "Rubio", "Castaño", "Pelirrojo", "Calvo", "Gris", "Blanco"})
        Me.cboColorCabello.Location = New System.Drawing.Point(16, 868)
        Me.cboColorCabello.Name = "cboColorCabello"
        Me.cboColorCabello.Size = New System.Drawing.Size(400, 53)
        Me.cboColorCabello.TabIndex = 55
        '
        'cboColorPiel
        '
        Me.cboColorPiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColorPiel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboColorPiel.FormattingEnabled = True
        Me.cboColorPiel.Items.AddRange(New Object() {"Blanca", "Negra", "Mestizo"})
        Me.cboColorPiel.Location = New System.Drawing.Point(16, 721)
        Me.cboColorPiel.Name = "cboColorPiel"
        Me.cboColorPiel.Size = New System.Drawing.Size(400, 53)
        Me.cboColorPiel.TabIndex = 54
        '
        'lblColorOjos
        '
        Me.lblColorOjos.AutoSize = True
        Me.lblColorOjos.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblColorOjos.Location = New System.Drawing.Point(8, 973)
        Me.lblColorOjos.Name = "lblColorOjos"
        Me.lblColorOjos.Size = New System.Drawing.Size(226, 45)
        Me.lblColorOjos.TabIndex = 52
        Me.lblColorOjos.Text = "Color de ojos"
        '
        'lblColorCabello
        '
        Me.lblColorCabello.AutoSize = True
        Me.lblColorCabello.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblColorCabello.Location = New System.Drawing.Point(8, 813)
        Me.lblColorCabello.Name = "lblColorCabello"
        Me.lblColorCabello.Size = New System.Drawing.Size(275, 45)
        Me.lblColorCabello.TabIndex = 50
        Me.lblColorCabello.Text = "Color de cabello"
        '
        'lblColorPiel
        '
        Me.lblColorPiel.AutoSize = True
        Me.lblColorPiel.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblColorPiel.Location = New System.Drawing.Point(8, 665)
        Me.lblColorPiel.Name = "lblColorPiel"
        Me.lblColorPiel.Size = New System.Drawing.Size(220, 45)
        Me.lblColorPiel.TabIndex = 48
        Me.lblColorPiel.Text = "Color de piel"
        '
        'lblKilogramos
        '
        Me.lblKilogramos.AutoSize = True
        Me.lblKilogramos.Font = New System.Drawing.Font("Gadugi", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblKilogramos.Location = New System.Drawing.Point(424, 592)
        Me.lblKilogramos.Name = "lblKilogramos"
        Me.lblKilogramos.Size = New System.Drawing.Size(46, 31)
        Me.lblKilogramos.TabIndex = 47
        Me.lblKilogramos.Text = "Kg"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPeso.Location = New System.Drawing.Point(16, 582)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(400, 50)
        Me.txtPeso.TabIndex = 46
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPeso.Location = New System.Drawing.Point(8, 523)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(94, 45)
        Me.lblPeso.TabIndex = 45
        Me.lblPeso.Text = "Peso"
        '
        'lblMetros
        '
        Me.lblMetros.AutoSize = True
        Me.lblMetros.Font = New System.Drawing.Font("Gadugi", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblMetros.Location = New System.Drawing.Point(424, 448)
        Me.lblMetros.Name = "lblMetros"
        Me.lblMetros.Size = New System.Drawing.Size(37, 31)
        Me.lblMetros.TabIndex = 44
        Me.lblMetros.Text = "m"
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAltura.Location = New System.Drawing.Point(16, 438)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(400, 50)
        Me.txtAltura.TabIndex = 43
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAltura.Location = New System.Drawing.Point(8, 379)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(120, 45)
        Me.lblAltura.TabIndex = 42
        Me.lblAltura.Text = "Altura"
        '
        'rdoMujer
        '
        Me.rdoMujer.AutoSize = True
        Me.rdoMujer.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoMujer.Location = New System.Drawing.Point(192, 294)
        Me.rdoMujer.Name = "rdoMujer"
        Me.rdoMujer.Size = New System.Drawing.Size(131, 49)
        Me.rdoMujer.TabIndex = 41
        Me.rdoMujer.TabStop = True
        Me.rdoMujer.Text = "Mujer"
        Me.rdoMujer.UseVisualStyleBackColor = True
        '
        'rdoHombre
        '
        Me.rdoHombre.AutoSize = True
        Me.rdoHombre.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoHombre.Location = New System.Drawing.Point(24, 294)
        Me.rdoHombre.Name = "rdoHombre"
        Me.rdoHombre.Size = New System.Drawing.Size(163, 49)
        Me.rdoHombre.TabIndex = 40
        Me.rdoHombre.TabStop = True
        Me.rdoHombre.Text = "Hombre"
        Me.rdoHombre.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSexo.Location = New System.Drawing.Point(8, 235)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(94, 45)
        Me.lblSexo.TabIndex = 39
        Me.lblSexo.Text = "Sexo"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpFechaNac.CustomFormat = "dd/mm/yy"
        Me.dtpFechaNac.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpFechaNac.Location = New System.Drawing.Point(16, 139)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(568, 50)
        Me.dtpFechaNac.TabIndex = 38
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFechaNac.Location = New System.Drawing.Point(8, 76)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(348, 45)
        Me.lblFechaNac.TabIndex = 37
        Me.lblFechaNac.Text = "Fecha de nacimiento"
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSeccion.Location = New System.Drawing.Point(4, 4)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(556, 59)
        Me.lblSeccion.TabIndex = 36
        Me.lblSeccion.Text = "Características específicas"
        '
        'pnlSiguiente
        '
        Me.pnlSiguiente.BackColor = System.Drawing.Color.Black
        Me.pnlSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSiguiente.Controls.Add(Me.lblSiguiente)
        Me.pnlSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSiguiente.ForeColor = System.Drawing.Color.White
        Me.pnlSiguiente.Location = New System.Drawing.Point(680, 968)
        Me.pnlSiguiente.Name = "pnlSiguiente"
        Me.pnlSiguiente.Size = New System.Drawing.Size(200, 72)
        Me.pnlSiguiente.TabIndex = 6
        '
        'lblSiguiente
        '
        Me.lblSiguiente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSiguiente.AutoSize = True
        Me.lblSiguiente.Location = New System.Drawing.Point(42, 19)
        Me.lblSiguiente.Name = "lblSiguiente"
        Me.lblSiguiente.Size = New System.Drawing.Size(115, 32)
        Me.lblSiguiente.TabIndex = 0
        Me.lblSiguiente.Text = "Siguiente"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Constantia", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(64, 64)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(563, 170)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Información del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Actor / Actriz"
        '
        'lblCerrar
        '
        Me.lblCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Consolas", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1864, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(46, 51)
        Me.lblCerrar.TabIndex = 71
        Me.lblCerrar.Text = "x"
        '
        'InputActor2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 1098)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlBlanco)
        Me.Controls.Add(Me.picImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InputActor2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputActor2"
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBlanco.ResumeLayout(False)
        Me.pnlBlanco.PerformLayout()
        Me.pnlAtras.ResumeLayout(False)
        Me.pnlAtras.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlSiguiente.ResumeLayout(False)
        Me.pnlSiguiente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImagen As PictureBox
    Friend WithEvents pnlBlanco As Panel
    Friend WithEvents lblProgreso As Label
    Friend WithEvents pnlAtras As Panel
    Friend WithEvents lblAtras As Label
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents pnlSiguiente As Panel
    Friend WithEvents lblSiguiente As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblColorOjos As Label
    Friend WithEvents lblColorCabello As Label
    Friend WithEvents lblColorPiel As Label
    Friend WithEvents lblKilogramos As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblMetros As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents rdoMujer As RadioButton
    Friend WithEvents rdoHombre As RadioButton
    Friend WithEvents lblSexo As Label
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSeccion As Label
    Friend WithEvents cboColorPiel As ComboBox
    Friend WithEvents cboColorOjos As ComboBox
    Friend WithEvents cboColorCabello As ComboBox
    Friend WithEvents lblAsterisco7 As Label
    Friend WithEvents lblAsterisco6 As Label
    Friend WithEvents lblAsterisco5 As Label
    Friend WithEvents lblAsterisco4 As Label
    Friend WithEvents lblAsterisco3 As Label
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents lblAsterisco1 As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEjemplo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
