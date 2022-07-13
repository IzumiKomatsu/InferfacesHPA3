<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlImagen = New System.Windows.Forms.Panel()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlBlanco = New System.Windows.Forms.Panel()
        Me.pnlEntrar = New System.Windows.Forms.Panel()
        Me.lblEntrar = New System.Windows.Forms.Label()
        Me.linklblCreaCuenta = New System.Windows.Forms.LinkLabel()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblIniciarSesion = New System.Windows.Forms.Label()
        Me.pnlImagen.SuspendLayout()
        Me.pnlBlanco.SuspendLayout()
        Me.pnlEntrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlImagen
        '
        Me.pnlImagen.BackgroundImage = Global.InferfacesHPA3.My.Resources.Resources.Director1
        Me.pnlImagen.Controls.Add(Me.lblCerrar)
        Me.pnlImagen.Controls.Add(Me.lblSubtitulo)
        Me.pnlImagen.Controls.Add(Me.lblTitulo)
        Me.pnlImagen.Location = New System.Drawing.Point(488, 0)
        Me.pnlImagen.Name = "pnlImagen"
        Me.pnlImagen.Size = New System.Drawing.Size(1424, 952)
        Me.pnlImagen.TabIndex = 0
        '
        'lblCerrar
        '
        Me.lblCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.BackColor = System.Drawing.Color.Transparent
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Consolas", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1376, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(46, 51)
        Me.lblCerrar.TabIndex = 14
        Me.lblCerrar.Text = "x"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitulo.Font = New System.Drawing.Font("Rockwell", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.White
        Me.lblSubtitulo.Location = New System.Drawing.Point(200, 512)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(1057, 134)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "La aplicación favorita de productores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y actores."
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Rockwell", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(168, 360)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1257, 147)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "The Big Rear Screen"
        '
        'pnlBlanco
        '
        Me.pnlBlanco.BackColor = System.Drawing.Color.White
        Me.pnlBlanco.Controls.Add(Me.pnlEntrar)
        Me.pnlBlanco.Controls.Add(Me.linklblCreaCuenta)
        Me.pnlBlanco.Controls.Add(Me.txtContrasena)
        Me.pnlBlanco.Controls.Add(Me.txtUsuario)
        Me.pnlBlanco.Controls.Add(Me.lblContrasena)
        Me.pnlBlanco.Controls.Add(Me.lblUsuario)
        Me.pnlBlanco.Controls.Add(Me.lblIniciarSesion)
        Me.pnlBlanco.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlanco.Name = "pnlBlanco"
        Me.pnlBlanco.Size = New System.Drawing.Size(656, 952)
        Me.pnlBlanco.TabIndex = 1
        '
        'pnlEntrar
        '
        Me.pnlEntrar.BackColor = System.Drawing.Color.Black
        Me.pnlEntrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEntrar.Controls.Add(Me.lblEntrar)
        Me.pnlEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlEntrar.Location = New System.Drawing.Point(408, 824)
        Me.pnlEntrar.Name = "pnlEntrar"
        Me.pnlEntrar.Size = New System.Drawing.Size(200, 72)
        Me.pnlEntrar.TabIndex = 8
        '
        'lblEntrar
        '
        Me.lblEntrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEntrar.AutoSize = True
        Me.lblEntrar.ForeColor = System.Drawing.Color.White
        Me.lblEntrar.Location = New System.Drawing.Point(61, 19)
        Me.lblEntrar.Name = "lblEntrar"
        Me.lblEntrar.Size = New System.Drawing.Size(76, 32)
        Me.lblEntrar.TabIndex = 0
        Me.lblEntrar.Text = "Entrar"
        '
        'linklblCreaCuenta
        '
        Me.linklblCreaCuenta.AutoSize = True
        Me.linklblCreaCuenta.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.linklblCreaCuenta.LinkArea = New System.Windows.Forms.LinkArea(18, 14)
        Me.linklblCreaCuenta.Location = New System.Drawing.Point(112, 312)
        Me.linklblCreaCuenta.Name = "linklblCreaCuenta"
        Me.linklblCreaCuenta.Size = New System.Drawing.Size(381, 65)
        Me.linklblCreaCuenta.TabIndex = 5
        Me.linklblCreaCuenta.TabStop = True
        Me.linklblCreaCuenta.Text = "No tienes cuenta. Crea tu cuenta. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toma menos de un minuto."
        Me.linklblCreaCuenta.UseCompatibleTextRendering = True
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContrasena.Location = New System.Drawing.Point(112, 632)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContrasena.Size = New System.Drawing.Size(400, 50)
        Me.txtContrasena.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsuario.Location = New System.Drawing.Point(112, 488)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(400, 50)
        Me.txtUsuario.TabIndex = 3
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContrasena.Location = New System.Drawing.Point(104, 560)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(259, 59)
        Me.lblContrasena.TabIndex = 2
        Me.lblContrasena.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.Location = New System.Drawing.Point(104, 416)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(187, 59)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        '
        'lblIniciarSesion
        '
        Me.lblIniciarSesion.AutoSize = True
        Me.lblIniciarSesion.Font = New System.Drawing.Font("Constantia", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIniciarSesion.Location = New System.Drawing.Point(72, 208)
        Me.lblIniciarSesion.Name = "lblIniciarSesion"
        Me.lblIniciarSesion.Size = New System.Drawing.Size(482, 85)
        Me.lblIniciarSesion.TabIndex = 0
        Me.lblIniciarSesion.Text = "Iniciar Sesión"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1915, 948)
        Me.Controls.Add(Me.pnlBlanco)
        Me.Controls.Add(Me.pnlImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.pnlImagen.ResumeLayout(False)
        Me.pnlImagen.PerformLayout()
        Me.pnlBlanco.ResumeLayout(False)
        Me.pnlBlanco.PerformLayout()
        Me.pnlEntrar.ResumeLayout(False)
        Me.pnlEntrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlImagen As Panel
    Friend WithEvents pnlBlanco As Panel
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIniciarSesion As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents linklblCreaCuenta As LinkLabel
    Friend WithEvents lblCerrar As Label
    Friend WithEvents pnlEntrar As Panel
    Friend WithEvents lblEntrar As Label
End Class
