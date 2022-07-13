<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaInicio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlAplicar1 = New System.Windows.Forms.Panel()
        Me.lblAplicar1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMovie4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblMovie3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblMovie2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMovie1 = New System.Windows.Forms.Label()
        Me.picMovie1 = New System.Windows.Forms.PictureBox()
        Me.lblPeliculas = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlAplicar1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMovie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblPeliculas)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1915, 1098)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.pnlAplicar1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblMovie4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.lblMovie3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.lblMovie2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.lblMovie1)
        Me.Panel3.Controls.Add(Me.picMovie1)
        Me.Panel3.Location = New System.Drawing.Point(0, 296)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1915, 776)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(-17, 632)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1915, 2)
        Me.Panel4.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(480, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Estado:"
        '
        'pnlAplicar1
        '
        Me.pnlAplicar1.BackColor = System.Drawing.Color.Black
        Me.pnlAplicar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAplicar1.Controls.Add(Me.lblAplicar1)
        Me.pnlAplicar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAplicar1.Location = New System.Drawing.Point(1568, 264)
        Me.pnlAplicar1.Name = "pnlAplicar1"
        Me.pnlAplicar1.Size = New System.Drawing.Size(200, 72)
        Me.pnlAplicar1.TabIndex = 15
        '
        'lblAplicar1
        '
        Me.lblAplicar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAplicar1.AutoSize = True
        Me.lblAplicar1.ForeColor = System.Drawing.Color.White
        Me.lblAplicar1.Location = New System.Drawing.Point(56, 19)
        Me.lblAplicar1.Name = "lblAplicar1"
        Me.lblAplicar1.Size = New System.Drawing.Size(86, 32)
        Me.lblAplicar1.TabIndex = 0
        Me.lblAplicar1.Text = "Aplicar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1000, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(443, 312)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mujer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Altura: 1.50 m – 1.60 m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Piel: Mestizo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Peso: 40 kg - 5" &
    "0 kg" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Pelo: Castaño" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Ojos: Marrón" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Experiencia: mayor a 5 años" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Género: Acción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(480, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 312)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Hombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Altura: 1.70 m – 1.80 m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Piel: Blanco" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Peso: 50 kg - 6" &
    "0 kg" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Pelo: Negro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Ojos: Marrón" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    • Experiencia: mayor a 5 años" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "    • Género: Acción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMovie4
        '
        Me.lblMovie4.AutoSize = True
        Me.lblMovie4.Font = New System.Drawing.Font("Constantia", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMovie4.Location = New System.Drawing.Point(32, 1916)
        Me.lblMovie4.Name = "lblMovie4"
        Me.lblMovie4.Size = New System.Drawing.Size(363, 53)
        Me.lblMovie4.TabIndex = 12
        Me.lblMovie4.Text = "El Grito Silencioso"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.InferfacesHPA3.My.Resources.Resources.Movie4
        Me.PictureBox3.Location = New System.Drawing.Point(48, 1996)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(392, 504)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'lblMovie3
        '
        Me.lblMovie3.AutoSize = True
        Me.lblMovie3.Font = New System.Drawing.Font("Constantia", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMovie3.Location = New System.Drawing.Point(32, 1288)
        Me.lblMovie3.Name = "lblMovie3"
        Me.lblMovie3.Size = New System.Drawing.Size(418, 53)
        Me.lblMovie3.TabIndex = 10
        Me.lblMovie3.Text = "Voy a Pasármelo Bien"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.InferfacesHPA3.My.Resources.Resources.Movie3
        Me.PictureBox2.Location = New System.Drawing.Point(48, 1368)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(392, 504)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lblMovie2
        '
        Me.lblMovie2.AutoSize = True
        Me.lblMovie2.Font = New System.Drawing.Font("Constantia", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMovie2.Location = New System.Drawing.Point(32, 656)
        Me.lblMovie2.Name = "lblMovie2"
        Me.lblMovie2.Size = New System.Drawing.Size(238, 53)
        Me.lblMovie2.TabIndex = 8
        Me.lblMovie2.Text = "Bullet Train"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InferfacesHPA3.My.Resources.Resources.Movie2
        Me.PictureBox1.Location = New System.Drawing.Point(48, 736)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 504)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lblMovie1
        '
        Me.lblMovie1.AutoSize = True
        Me.lblMovie1.Font = New System.Drawing.Font("Constantia", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMovie1.Location = New System.Drawing.Point(32, 16)
        Me.lblMovie1.Name = "lblMovie1"
        Me.lblMovie1.Size = New System.Drawing.Size(369, 53)
        Me.lblMovie1.TabIndex = 6
        Me.lblMovie1.Text = "El Agente Invisible"
        '
        'picMovie1
        '
        Me.picMovie1.Image = Global.InferfacesHPA3.My.Resources.Resources.Movie1
        Me.picMovie1.Location = New System.Drawing.Point(48, 96)
        Me.picMovie1.Name = "picMovie1"
        Me.picMovie1.Size = New System.Drawing.Size(392, 504)
        Me.picMovie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMovie1.TabIndex = 0
        Me.picMovie1.TabStop = False
        '
        'lblPeliculas
        '
        Me.lblPeliculas.AutoSize = True
        Me.lblPeliculas.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPeliculas.Location = New System.Drawing.Point(24, 224)
        Me.lblPeliculas.Name = "lblPeliculas"
        Me.lblPeliculas.Size = New System.Drawing.Size(230, 59)
        Me.lblPeliculas.TabIndex = 5
        Me.lblPeliculas.Text = "Películas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1915, 5)
        Me.Panel2.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Rockwell", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(24, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1257, 147)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "The Big Rear Screen"
        '
        'PantallaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 1098)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaInicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlAplicar1.ResumeLayout(False)
        Me.pnlAplicar1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMovie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPeliculas As Label
    Friend WithEvents lblMovie4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblMovie3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMovie2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMovie1 As Label
    Friend WithEvents picMovie1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlAplicar1 As Panel
    Friend WithEvents lblAplicar1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
End Class
