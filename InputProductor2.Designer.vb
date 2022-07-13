<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputProductor2
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
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.pnlBlanco = New System.Windows.Forms.Panel()
        Me.lblObligatorio = New System.Windows.Forms.Label()
        Me.lblAsterisco = New System.Windows.Forms.Label()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.pnlAtras = New System.Windows.Forms.Panel()
        Me.lblAtras = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.cboTipoProductor = New System.Windows.Forms.ComboBox()
        Me.lblAsterisco4 = New System.Windows.Forms.Label()
        Me.lblAsterisco3 = New System.Windows.Forms.Label()
        Me.lblMeses = New System.Windows.Forms.Label()
        Me.txtMeses = New System.Windows.Forms.TextBox()
        Me.lblRecorrido = New System.Windows.Forms.Label()
        Me.lblAreasProd = New System.Windows.Forms.Label()
        Me.lblAnios = New System.Windows.Forms.Label()
        Me.txtAnios = New System.Windows.Forms.TextBox()
        Me.lblTiempoExp = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.rdoMujer = New System.Windows.Forms.RadioButton()
        Me.rdoHombre = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblSeccion = New System.Windows.Forms.Label()
        Me.pnlGuardar = New System.Windows.Forms.Panel()
        Me.lblGuardar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBlanco.SuspendLayout()
        Me.pnlAtras.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlGuardar.SuspendLayout()
        Me.SuspendLayout()
        '
        'picImagen
        '
        Me.picImagen.Image = Global.InferfacesHPA3.My.Resources.Resources.ezgif_com_gif_maker__1_
        Me.picImagen.Location = New System.Drawing.Point(888, 0)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(1688, 1098)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 4
        Me.picImagen.TabStop = False
        '
        'pnlBlanco
        '
        Me.pnlBlanco.BackColor = System.Drawing.Color.White
        Me.pnlBlanco.Controls.Add(Me.lblObligatorio)
        Me.pnlBlanco.Controls.Add(Me.lblAsterisco)
        Me.pnlBlanco.Controls.Add(Me.lblProgreso)
        Me.pnlBlanco.Controls.Add(Me.pnlAtras)
        Me.pnlBlanco.Controls.Add(Me.pnlPrincipal)
        Me.pnlBlanco.Controls.Add(Me.pnlGuardar)
        Me.pnlBlanco.Controls.Add(Me.lblTitulo)
        Me.pnlBlanco.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlanco.Name = "pnlBlanco"
        Me.pnlBlanco.Size = New System.Drawing.Size(936, 1098)
        Me.pnlBlanco.TabIndex = 6
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblObligatorio.ForeColor = System.Drawing.Color.Silver
        Me.lblObligatorio.Location = New System.Drawing.Point(112, 880)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(272, 39)
        Me.lblObligatorio.TabIndex = 23
        Me.lblObligatorio.Text = "Campo obligatorio"
        '
        'lblAsterisco
        '
        Me.lblAsterisco.AutoSize = True
        Me.lblAsterisco.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco.Location = New System.Drawing.Point(88, 888)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco.TabIndex = 24
        Me.lblAsterisco.Text = "*"
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Font = New System.Drawing.Font("Gadugi", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProgreso.Location = New System.Drawing.Point(421, 984)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(94, 45)
        Me.lblProgreso.TabIndex = 12
        Me.lblProgreso.Text = "2 / 2"
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
        Me.pnlPrincipal.Controls.Add(Me.cboTipoProductor)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco4)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco3)
        Me.pnlPrincipal.Controls.Add(Me.lblMeses)
        Me.pnlPrincipal.Controls.Add(Me.txtMeses)
        Me.pnlPrincipal.Controls.Add(Me.lblRecorrido)
        Me.pnlPrincipal.Controls.Add(Me.lblAreasProd)
        Me.pnlPrincipal.Controls.Add(Me.lblAnios)
        Me.pnlPrincipal.Controls.Add(Me.txtAnios)
        Me.pnlPrincipal.Controls.Add(Me.lblTiempoExp)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco2)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco1)
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
        'cboTipoProductor
        '
        Me.cboTipoProductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProductor.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboTipoProductor.FormattingEnabled = True
        Me.cboTipoProductor.Items.AddRange(New Object() {"Ejecutivo", "Coproductor", "En línea", "Gerente Productor"})
        Me.cboTipoProductor.Location = New System.Drawing.Point(16, 696)
        Me.cboTipoProductor.Name = "cboTipoProductor"
        Me.cboTipoProductor.Size = New System.Drawing.Size(400, 53)
        Me.cboTipoProductor.TabIndex = 76
        '
        'lblAsterisco4
        '
        Me.lblAsterisco4.AutoSize = True
        Me.lblAsterisco4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco4.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco4.Location = New System.Drawing.Point(328, 640)
        Me.lblAsterisco4.Name = "lblAsterisco4"
        Me.lblAsterisco4.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco4.TabIndex = 75
        Me.lblAsterisco4.Text = "*"
        '
        'lblAsterisco3
        '
        Me.lblAsterisco3.AutoSize = True
        Me.lblAsterisco3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco3.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco3.Location = New System.Drawing.Point(376, 480)
        Me.lblAsterisco3.Name = "lblAsterisco3"
        Me.lblAsterisco3.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco3.TabIndex = 74
        Me.lblAsterisco3.Text = "*"
        '
        'lblMeses
        '
        Me.lblMeses.AutoSize = True
        Me.lblMeses.Font = New System.Drawing.Font("Gadugi", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblMeses.Location = New System.Drawing.Point(376, 544)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(103, 31)
        Me.lblMeses.TabIndex = 73
        Me.lblMeses.Text = "mes(es)"
        '
        'txtMeses
        '
        Me.txtMeses.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMeses.Location = New System.Drawing.Point(272, 536)
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.Size = New System.Drawing.Size(100, 50)
        Me.txtMeses.TabIndex = 72
        '
        'lblRecorrido
        '
        Me.lblRecorrido.AutoSize = True
        Me.lblRecorrido.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRecorrido.Location = New System.Drawing.Point(8, 392)
        Me.lblRecorrido.Name = "lblRecorrido"
        Me.lblRecorrido.Size = New System.Drawing.Size(576, 59)
        Me.lblRecorrido.TabIndex = 71
        Me.lblRecorrido.Text = "Recorrido del productor(a)"
        '
        'lblAreasProd
        '
        Me.lblAreasProd.AutoSize = True
        Me.lblAreasProd.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAreasProd.Location = New System.Drawing.Point(8, 632)
        Me.lblAreasProd.Name = "lblAreasProd"
        Me.lblAreasProd.Size = New System.Drawing.Size(328, 45)
        Me.lblAreasProd.TabIndex = 70
        Me.lblAreasProd.Text = "Área de producción"
        '
        'lblAnios
        '
        Me.lblAnios.AutoSize = True
        Me.lblAnios.Font = New System.Drawing.Font("Gadugi", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblAnios.Location = New System.Drawing.Point(120, 544)
        Me.lblAnios.Name = "lblAnios"
        Me.lblAnios.Size = New System.Drawing.Size(86, 31)
        Me.lblAnios.TabIndex = 69
        Me.lblAnios.Text = "año(s)"
        '
        'txtAnios
        '
        Me.txtAnios.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAnios.Location = New System.Drawing.Point(16, 536)
        Me.txtAnios.Name = "txtAnios"
        Me.txtAnios.Size = New System.Drawing.Size(100, 50)
        Me.txtAnios.TabIndex = 68
        '
        'lblTiempoExp
        '
        Me.lblTiempoExp.AutoSize = True
        Me.lblTiempoExp.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTiempoExp.Location = New System.Drawing.Point(8, 470)
        Me.lblTiempoExp.Name = "lblTiempoExp"
        Me.lblTiempoExp.Size = New System.Drawing.Size(381, 45)
        Me.lblTiempoExp.TabIndex = 67
        Me.lblTiempoExp.Text = "Tiempo de experiencia"
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
        'pnlGuardar
        '
        Me.pnlGuardar.BackColor = System.Drawing.Color.Black
        Me.pnlGuardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGuardar.Controls.Add(Me.lblGuardar)
        Me.pnlGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlGuardar.ForeColor = System.Drawing.Color.White
        Me.pnlGuardar.Location = New System.Drawing.Point(680, 968)
        Me.pnlGuardar.Name = "pnlGuardar"
        Me.pnlGuardar.Size = New System.Drawing.Size(200, 72)
        Me.pnlGuardar.TabIndex = 6
        '
        'lblGuardar
        '
        Me.lblGuardar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGuardar.AutoSize = True
        Me.lblGuardar.Location = New System.Drawing.Point(50, 19)
        Me.lblGuardar.Name = "lblGuardar"
        Me.lblGuardar.Size = New System.Drawing.Size(98, 32)
        Me.lblGuardar.TabIndex = 0
        Me.lblGuardar.Text = "Guardar"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Constantia", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(64, 64)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(580, 170)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Información del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Productor(a)"
        '
        'lblCerrar
        '
        Me.lblCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Consolas", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1864, 8)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(46, 51)
        Me.lblCerrar.TabIndex = 15
        Me.lblCerrar.Text = "x"
        '
        'InputProductor2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 1098)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlBlanco)
        Me.Controls.Add(Me.picImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InputProductor2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputProductor2"
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBlanco.ResumeLayout(False)
        Me.pnlBlanco.PerformLayout()
        Me.pnlAtras.ResumeLayout(False)
        Me.pnlAtras.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlGuardar.ResumeLayout(False)
        Me.pnlGuardar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImagen As PictureBox
    Friend WithEvents pnlBlanco As Panel
    Friend WithEvents lblObligatorio As Label
    Friend WithEvents lblAsterisco As Label
    Friend WithEvents lblProgreso As Label
    Friend WithEvents pnlAtras As Panel
    Friend WithEvents lblAtras As Label
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents lblAsterisco1 As Label
    Friend WithEvents rdoMujer As RadioButton
    Friend WithEvents rdoHombre As RadioButton
    Friend WithEvents lblSexo As Label
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSeccion As Label
    Friend WithEvents pnlGuardar As Panel
    Friend WithEvents lblGuardar As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAsterisco4 As Label
    Friend WithEvents lblAsterisco3 As Label
    Friend WithEvents lblMeses As Label
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents lblRecorrido As Label
    Friend WithEvents lblAreasProd As Label
    Friend WithEvents lblAnios As Label
    Friend WithEvents txtAnios As TextBox
    Friend WithEvents lblTiempoExp As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents cboTipoProductor As ComboBox
End Class
