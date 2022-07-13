<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroExitoso
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
        Me.pnlBlanco = New System.Windows.Forms.Panel()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblRegistroExitoso = New System.Windows.Forms.Label()
        Me.pnlBlanco.SuspendLayout()
        Me.pnlInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBlanco
        '
        Me.pnlBlanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBlanco.Controls.Add(Me.pnlInicio)
        Me.pnlBlanco.Controls.Add(Me.lblRegistroExitoso)
        Me.pnlBlanco.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlanco.Name = "pnlBlanco"
        Me.pnlBlanco.Size = New System.Drawing.Size(845, 443)
        Me.pnlBlanco.TabIndex = 8
        '
        'pnlInicio
        '
        Me.pnlInicio.BackColor = System.Drawing.Color.Black
        Me.pnlInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInicio.Controls.Add(Me.lblInicio)
        Me.pnlInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlInicio.ForeColor = System.Drawing.Color.White
        Me.pnlInicio.Location = New System.Drawing.Point(271, 236)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(302, 72)
        Me.pnlInicio.TabIndex = 9
        '
        'lblInicio
        '
        Me.lblInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(33, 19)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(234, 32)
        Me.lblInicio.TabIndex = 0
        Me.lblInicio.Text = "Ir a Pantalla de Inicio"
        '
        'lblRegistroExitoso
        '
        Me.lblRegistroExitoso.AutoSize = True
        Me.lblRegistroExitoso.Font = New System.Drawing.Font("Constantia", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegistroExitoso.Location = New System.Drawing.Point(22, 134)
        Me.lblRegistroExitoso.Name = "lblRegistroExitoso"
        Me.lblRegistroExitoso.Size = New System.Drawing.Size(800, 45)
        Me.lblRegistroExitoso.TabIndex = 8
        Me.lblRegistroExitoso.Text = "¡Su cuenta ha sido creada satisfactoriamente!"
        '
        'RegistroExitoso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 443)
        Me.Controls.Add(Me.pnlBlanco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroExitoso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroExitoso"
        Me.pnlBlanco.ResumeLayout(False)
        Me.pnlBlanco.PerformLayout()
        Me.pnlInicio.ResumeLayout(False)
        Me.pnlInicio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBlanco As Panel
    Friend WithEvents pnlInicio As Panel
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblRegistroExitoso As Label
End Class
