<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputProductor1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProgreso = New System.Windows.Forms.Label()
        Me.pnlAtras = New System.Windows.Forms.Panel()
        Me.lblAtras = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAsterisco3 = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.lblAsterisco1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
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
        Me.picImagen.Image = Global.InferfacesHPA3.My.Resources.Resources.ezgif_com_gif_maker__1_
        Me.picImagen.Location = New System.Drawing.Point(888, 0)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(1688, 1098)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 3
        Me.picImagen.TabStop = False
        '
        'pnlBlanco
        '
        Me.pnlBlanco.BackColor = System.Drawing.Color.White
        Me.pnlBlanco.Controls.Add(Me.Label1)
        Me.pnlBlanco.Controls.Add(Me.Label4)
        Me.pnlBlanco.Controls.Add(Me.txtProgreso)
        Me.pnlBlanco.Controls.Add(Me.pnlAtras)
        Me.pnlBlanco.Controls.Add(Me.pnlPrincipal)
        Me.pnlBlanco.Controls.Add(Me.pnlSiguiente)
        Me.pnlBlanco.Controls.Add(Me.lblTitulo)
        Me.pnlBlanco.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlanco.Name = "pnlBlanco"
        Me.pnlBlanco.Size = New System.Drawing.Size(936, 1098)
        Me.pnlBlanco.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(112, 880)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 39)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Campo obligatorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(88, 888)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 39)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "*"
        '
        'txtProgreso
        '
        Me.txtProgreso.AutoSize = True
        Me.txtProgreso.Font = New System.Drawing.Font("Gadugi", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtProgreso.Location = New System.Drawing.Point(421, 984)
        Me.txtProgreso.Name = "txtProgreso"
        Me.txtProgreso.Size = New System.Drawing.Size(94, 45)
        Me.txtProgreso.TabIndex = 12
        Me.txtProgreso.Text = "1 / 2"
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
        Me.pnlPrincipal.Controls.Add(Me.Label9)
        Me.pnlPrincipal.Controls.Add(Me.Label8)
        Me.pnlPrincipal.Controls.Add(Me.Label7)
        Me.pnlPrincipal.Controls.Add(Me.Label5)
        Me.pnlPrincipal.Controls.Add(Me.txtEmail)
        Me.pnlPrincipal.Controls.Add(Me.Label6)
        Me.pnlPrincipal.Controls.Add(Me.Label2)
        Me.pnlPrincipal.Controls.Add(Me.txtTelefono)
        Me.pnlPrincipal.Controls.Add(Me.Label3)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco3)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco2)
        Me.pnlPrincipal.Controls.Add(Me.lblAsterisco1)
        Me.pnlPrincipal.Controls.Add(Me.txtID)
        Me.pnlPrincipal.Controls.Add(Me.lblID)
        Me.pnlPrincipal.Controls.Add(Me.txtApellido)
        Me.pnlPrincipal.Controls.Add(Me.lblApellido)
        Me.pnlPrincipal.Controls.Add(Me.txtNombre)
        Me.pnlPrincipal.Controls.Add(Me.lblNombre)
        Me.pnlPrincipal.Controls.Add(Me.lblSeccion)
        Me.pnlPrincipal.Location = New System.Drawing.Point(72, 280)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(824, 584)
        Me.pnlPrincipal.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(432, 458)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(289, 32)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Ej. 8-888-888 / E-777-777"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(432, 602)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 32)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Ej. 2365695"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(432, 754)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(218, 32)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Ej. user@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(120, 696)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 39)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "*"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(16, 744)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(400, 50)
        Me.txtEmail.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(16, 688)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 39)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(144, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 39)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "*"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTelefono.Location = New System.Drawing.Point(16, 594)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(400, 50)
        Me.txtTelefono.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(16, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 39)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Teléfono"
        '
        'lblAsterisco3
        '
        Me.lblAsterisco3.AutoSize = True
        Me.lblAsterisco3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco3.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco3.Location = New System.Drawing.Point(232, 400)
        Me.lblAsterisco3.Name = "lblAsterisco3"
        Me.lblAsterisco3.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco3.TabIndex = 22
        Me.lblAsterisco3.Text = "*"
        '
        'lblAsterisco2
        '
        Me.lblAsterisco2.AutoSize = True
        Me.lblAsterisco2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco2.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco2.Location = New System.Drawing.Point(136, 248)
        Me.lblAsterisco2.Name = "lblAsterisco2"
        Me.lblAsterisco2.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco2.TabIndex = 21
        Me.lblAsterisco2.Text = "*"
        '
        'lblAsterisco1
        '
        Me.lblAsterisco1.AutoSize = True
        Me.lblAsterisco1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsterisco1.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco1.Location = New System.Drawing.Point(136, 96)
        Me.lblAsterisco1.Name = "lblAsterisco1"
        Me.lblAsterisco1.Size = New System.Drawing.Size(31, 39)
        Me.lblAsterisco1.TabIndex = 20
        Me.lblAsterisco1.Text = "*"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtID.Location = New System.Drawing.Point(16, 448)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(400, 50)
        Me.txtID.TabIndex = 18
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblID.Location = New System.Drawing.Point(16, 392)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(217, 39)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "ID o pasaporte"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApellido.Location = New System.Drawing.Point(16, 296)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(400, 50)
        Me.txtApellido.TabIndex = 16
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblApellido.Location = New System.Drawing.Point(8, 240)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(134, 39)
        Me.lblApellido.TabIndex = 15
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(16, 144)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(400, 50)
        Me.txtNombre.TabIndex = 14
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(8, 88)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(131, 39)
        Me.lblNombre.TabIndex = 13
        Me.lblNombre.Text = "Nombre"
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSeccion.Location = New System.Drawing.Point(4, 8)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(455, 59)
        Me.lblSeccion.TabIndex = 10
        Me.lblSeccion.Text = "Información General"
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
        Me.lblCerrar.TabIndex = 14
        Me.lblCerrar.Text = "x"
        '
        'InputProductor1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 1098)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlBlanco)
        Me.Controls.Add(Me.picImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InputProductor1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputProductor1"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProgreso As Label
    Friend WithEvents pnlAtras As Panel
    Friend WithEvents lblAtras As Label
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAsterisco3 As Label
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents lblAsterisco1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSeccion As Label
    Friend WithEvents pnlSiguiente As Panel
    Friend WithEvents lblSiguiente As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCerrar As Label
End Class
