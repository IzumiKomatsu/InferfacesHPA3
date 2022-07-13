<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputActor3
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pnlAtras = New System.Windows.Forms.Panel()
        Me.lblAtras = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkRomance = New System.Windows.Forms.CheckBox()
        Me.chkAccion = New System.Windows.Forms.CheckBox()
        Me.chkFiccion = New System.Windows.Forms.CheckBox()
        Me.chkTerror = New System.Windows.Forms.CheckBox()
        Me.chkDrama = New System.Windows.Forms.CheckBox()
        Me.chkSuspenso = New System.Windows.Forms.CheckBox()
        Me.chkHorror = New System.Windows.Forms.CheckBox()
        Me.chkComedia = New System.Windows.Forms.CheckBox()
        Me.lblMeses = New System.Windows.Forms.Label()
        Me.txtMeses = New System.Windows.Forms.TextBox()
        Me.lblSeccion = New System.Windows.Forms.Label()
        Me.lblGeneros = New System.Windows.Forms.Label()
        Me.lblAnios = New System.Windows.Forms.Label()
        Me.txtAnios = New System.Windows.Forms.TextBox()
        Me.lblTiempoExp = New System.Windows.Forms.Label()
        Me.pnlGuardar = New System.Windows.Forms.Panel()
        Me.lblGuardar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlAtras.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlGuardar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InferfacesHPA3.My.Resources.Resources.Roca
        Me.PictureBox1.Location = New System.Drawing.Point(584, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1552, 1098)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.pnlAtras)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.pnlGuardar)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(936, 1098)
        Me.Panel2.TabIndex = 6
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Gadugi", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(421, 984)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 45)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "3 / 3"
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
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chkRomance)
        Me.Panel1.Controls.Add(Me.chkAccion)
        Me.Panel1.Controls.Add(Me.chkFiccion)
        Me.Panel1.Controls.Add(Me.chkTerror)
        Me.Panel1.Controls.Add(Me.chkDrama)
        Me.Panel1.Controls.Add(Me.chkSuspenso)
        Me.Panel1.Controls.Add(Me.chkHorror)
        Me.Panel1.Controls.Add(Me.chkComedia)
        Me.Panel1.Controls.Add(Me.lblMeses)
        Me.Panel1.Controls.Add(Me.txtMeses)
        Me.Panel1.Controls.Add(Me.lblSeccion)
        Me.Panel1.Controls.Add(Me.lblGeneros)
        Me.Panel1.Controls.Add(Me.lblAnios)
        Me.Panel1.Controls.Add(Me.txtAnios)
        Me.Panel1.Controls.Add(Me.lblTiempoExp)
        Me.Panel1.Location = New System.Drawing.Point(72, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 584)
        Me.Panel1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(552, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 39)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(376, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 39)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "*"
        '
        'chkRomance
        '
        Me.chkRomance.AutoSize = True
        Me.chkRomance.Location = New System.Drawing.Point(40, 592)
        Me.chkRomance.Name = "chkRomance"
        Me.chkRomance.Size = New System.Drawing.Size(144, 36)
        Me.chkRomance.TabIndex = 64
        Me.chkRomance.Text = "Romance"
        Me.chkRomance.UseVisualStyleBackColor = True
        '
        'chkAccion
        '
        Me.chkAccion.AutoSize = True
        Me.chkAccion.Location = New System.Drawing.Point(40, 552)
        Me.chkAccion.Name = "chkAccion"
        Me.chkAccion.Size = New System.Drawing.Size(117, 36)
        Me.chkAccion.TabIndex = 63
        Me.chkAccion.Text = "Acción"
        Me.chkAccion.UseVisualStyleBackColor = True
        '
        'chkFiccion
        '
        Me.chkFiccion.AutoSize = True
        Me.chkFiccion.Location = New System.Drawing.Point(40, 512)
        Me.chkFiccion.Name = "chkFiccion"
        Me.chkFiccion.Size = New System.Drawing.Size(120, 36)
        Me.chkFiccion.TabIndex = 62
        Me.chkFiccion.Text = "Ficción"
        Me.chkFiccion.UseVisualStyleBackColor = True
        '
        'chkTerror
        '
        Me.chkTerror.AutoSize = True
        Me.chkTerror.Location = New System.Drawing.Point(40, 472)
        Me.chkTerror.Name = "chkTerror"
        Me.chkTerror.Size = New System.Drawing.Size(108, 36)
        Me.chkTerror.TabIndex = 61
        Me.chkTerror.Text = "Terror"
        Me.chkTerror.UseVisualStyleBackColor = True
        '
        'chkDrama
        '
        Me.chkDrama.AutoSize = True
        Me.chkDrama.Location = New System.Drawing.Point(40, 432)
        Me.chkDrama.Name = "chkDrama"
        Me.chkDrama.Size = New System.Drawing.Size(116, 36)
        Me.chkDrama.TabIndex = 60
        Me.chkDrama.Text = "Drama"
        Me.chkDrama.UseVisualStyleBackColor = True
        '
        'chkSuspenso
        '
        Me.chkSuspenso.AutoSize = True
        Me.chkSuspenso.Location = New System.Drawing.Point(40, 392)
        Me.chkSuspenso.Name = "chkSuspenso"
        Me.chkSuspenso.Size = New System.Drawing.Size(148, 36)
        Me.chkSuspenso.TabIndex = 59
        Me.chkSuspenso.Text = "Suspenso"
        Me.chkSuspenso.UseVisualStyleBackColor = True
        '
        'chkHorror
        '
        Me.chkHorror.AutoSize = True
        Me.chkHorror.Location = New System.Drawing.Point(40, 352)
        Me.chkHorror.Name = "chkHorror"
        Me.chkHorror.Size = New System.Drawing.Size(115, 36)
        Me.chkHorror.TabIndex = 58
        Me.chkHorror.Text = "Horror"
        Me.chkHorror.UseVisualStyleBackColor = True
        '
        'chkComedia
        '
        Me.chkComedia.AutoSize = True
        Me.chkComedia.Location = New System.Drawing.Point(40, 312)
        Me.chkComedia.Name = "chkComedia"
        Me.chkComedia.Size = New System.Drawing.Size(141, 36)
        Me.chkComedia.TabIndex = 57
        Me.chkComedia.Text = "Comedia"
        Me.chkComedia.UseVisualStyleBackColor = True
        '
        'lblMeses
        '
        Me.lblMeses.AutoSize = True
        Me.lblMeses.Font = New System.Drawing.Font("Gadugi", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblMeses.Location = New System.Drawing.Point(376, 160)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(103, 31)
        Me.lblMeses.TabIndex = 56
        Me.lblMeses.Text = "mes(es)"
        '
        'txtMeses
        '
        Me.txtMeses.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMeses.Location = New System.Drawing.Point(272, 152)
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.Size = New System.Drawing.Size(100, 50)
        Me.txtMeses.TabIndex = 55
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSeccion.Location = New System.Drawing.Point(8, 8)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(573, 59)
        Me.lblSeccion.TabIndex = 54
        Me.lblSeccion.Text = "Recorrido del actor / actriz"
        '
        'lblGeneros
        '
        Me.lblGeneros.AutoSize = True
        Me.lblGeneros.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGeneros.Location = New System.Drawing.Point(8, 248)
        Me.lblGeneros.Name = "lblGeneros"
        Me.lblGeneros.Size = New System.Drawing.Size(555, 45)
        Me.lblGeneros.TabIndex = 48
        Me.lblGeneros.Text = "Géneros en los que ha participado"
        '
        'lblAnios
        '
        Me.lblAnios.AutoSize = True
        Me.lblAnios.Font = New System.Drawing.Font("Gadugi", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblAnios.Location = New System.Drawing.Point(120, 160)
        Me.lblAnios.Name = "lblAnios"
        Me.lblAnios.Size = New System.Drawing.Size(86, 31)
        Me.lblAnios.TabIndex = 47
        Me.lblAnios.Text = "año(s)"
        '
        'txtAnios
        '
        Me.txtAnios.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAnios.Location = New System.Drawing.Point(16, 152)
        Me.txtAnios.Name = "txtAnios"
        Me.txtAnios.Size = New System.Drawing.Size(100, 50)
        Me.txtAnios.TabIndex = 46
        '
        'lblTiempoExp
        '
        Me.lblTiempoExp.AutoSize = True
        Me.lblTiempoExp.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTiempoExp.Location = New System.Drawing.Point(8, 86)
        Me.lblTiempoExp.Name = "lblTiempoExp"
        Me.lblTiempoExp.Size = New System.Drawing.Size(381, 45)
        Me.lblTiempoExp.TabIndex = 45
        Me.lblTiempoExp.Text = "Tiempo de experiencia"
        '
        'pnlGuardar
        '
        Me.pnlGuardar.BackColor = System.Drawing.Color.Black
        Me.pnlGuardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGuardar.Controls.Add(Me.lblGuardar)
        Me.pnlGuardar.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.lblGuardar.ForeColor = System.Drawing.Color.White
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
        Me.lblCerrar.TabIndex = 14
        Me.lblCerrar.Text = "x"
        '
        'InputActor3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 1098)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InputActor3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputActor3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlAtras.ResumeLayout(False)
        Me.pnlAtras.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlGuardar.ResumeLayout(False)
        Me.pnlGuardar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents pnlAtras As Panel
    Friend WithEvents lblAtras As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGeneros As Label
    Friend WithEvents lblAnios As Label
    Friend WithEvents txtAnios As TextBox
    Friend WithEvents lblTiempoExp As Label
    Friend WithEvents pnlGuardar As Panel
    Friend WithEvents lblGuardar As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblMeses As Label
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents lblSeccion As Label
    Friend WithEvents chkRomance As CheckBox
    Friend WithEvents chkAccion As CheckBox
    Friend WithEvents chkFiccion As CheckBox
    Friend WithEvents chkTerror As CheckBox
    Friend WithEvents chkDrama As CheckBox
    Friend WithEvents chkSuspenso As CheckBox
    Friend WithEvents chkHorror As CheckBox
    Friend WithEvents chkComedia As CheckBox
    Friend WithEvents lblCerrar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
