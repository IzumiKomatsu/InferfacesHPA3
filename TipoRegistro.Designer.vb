<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoRegistro
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
        Me.pnlAtras = New System.Windows.Forms.Panel()
        Me.lblAtras = New System.Windows.Forms.Label()
        Me.pnlSiguiente = New System.Windows.Forms.Panel()
        Me.lblSiguiente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rboDirector = New System.Windows.Forms.RadioButton()
        Me.rboActor = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlAtras.SuspendLayout()
        Me.pnlSiguiente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InferfacesHPA3.My.Resources.Resources.ezgif_com_gif_maker
        Me.PictureBox1.Location = New System.Drawing.Point(624, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1336, 952)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.pnlAtras)
        Me.Panel2.Controls.Add(Me.pnlSiguiente)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 952)
        Me.Panel2.TabIndex = 2
        '
        'pnlAtras
        '
        Me.pnlAtras.BackColor = System.Drawing.Color.Black
        Me.pnlAtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtras.Controls.Add(Me.lblAtras)
        Me.pnlAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAtras.Location = New System.Drawing.Point(48, 848)
        Me.pnlAtras.Name = "pnlAtras"
        Me.pnlAtras.Size = New System.Drawing.Size(200, 72)
        Me.pnlAtras.TabIndex = 10
        '
        'lblAtras
        '
        Me.lblAtras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtras.AutoSize = True
        Me.lblAtras.ForeColor = System.Drawing.Color.White
        Me.lblAtras.Location = New System.Drawing.Point(66, 19)
        Me.lblAtras.Name = "lblAtras"
        Me.lblAtras.Size = New System.Drawing.Size(67, 32)
        Me.lblAtras.TabIndex = 0
        Me.lblAtras.Text = "Atrás"
        '
        'pnlSiguiente
        '
        Me.pnlSiguiente.BackColor = System.Drawing.Color.Black
        Me.pnlSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSiguiente.Controls.Add(Me.lblSiguiente)
        Me.pnlSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSiguiente.Location = New System.Drawing.Point(408, 848)
        Me.pnlSiguiente.Name = "pnlSiguiente"
        Me.pnlSiguiente.Size = New System.Drawing.Size(200, 72)
        Me.pnlSiguiente.TabIndex = 9
        '
        'lblSiguiente
        '
        Me.lblSiguiente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSiguiente.AutoSize = True
        Me.lblSiguiente.ForeColor = System.Drawing.Color.White
        Me.lblSiguiente.Location = New System.Drawing.Point(42, 19)
        Me.lblSiguiente.Name = "lblSiguiente"
        Me.lblSiguiente.Size = New System.Drawing.Size(115, 32)
        Me.lblSiguiente.TabIndex = 0
        Me.lblSiguiente.Text = "Siguiente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.rboDirector)
        Me.Panel1.Controls.Add(Me.rboActor)
        Me.Panel1.Location = New System.Drawing.Point(72, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 264)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(345, 59)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de usuario"
        '
        'rboDirector
        '
        Me.rboDirector.AutoSize = True
        Me.rboDirector.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rboDirector.Location = New System.Drawing.Point(64, 176)
        Me.rboDirector.Name = "rboDirector"
        Me.rboDirector.Size = New System.Drawing.Size(226, 43)
        Me.rboDirector.TabIndex = 1
        Me.rboDirector.TabStop = True
        Me.rboDirector.Text = "Productor(a)"
        Me.rboDirector.UseVisualStyleBackColor = True
        '
        'rboActor
        '
        Me.rboActor.AutoSize = True
        Me.rboActor.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rboActor.Location = New System.Drawing.Point(64, 112)
        Me.rboActor.Name = "rboActor"
        Me.rboActor.Size = New System.Drawing.Size(237, 43)
        Me.rboActor.TabIndex = 0
        Me.rboActor.TabStop = True
        Me.rboActor.Text = "Actor / Actriz"
        Me.rboActor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(32, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(599, 85)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Registrarse como"
        '
        'lblCerrar
        '
        Me.lblCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Consolas", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1864, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(46, 51)
        Me.lblCerrar.TabIndex = 14
        Me.lblCerrar.Text = "x"
        '
        'TipoRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1915, 948)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TipoRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TipoRegistro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlAtras.ResumeLayout(False)
        Me.pnlAtras.PerformLayout()
        Me.pnlSiguiente.ResumeLayout(False)
        Me.pnlSiguiente.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rboDirector As RadioButton
    Friend WithEvents rboActor As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlSiguiente As Panel
    Friend WithEvents lblSiguiente As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents pnlAtras As Panel
    Friend WithEvents lblAtras As Label
End Class
