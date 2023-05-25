<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crear_cuenta
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
        Me.btnIniciarSesión = New System.Windows.Forms.Button()
        Me.btnCerrarCC = New System.Windows.Forms.Button()
        Me.lblMensajeCC = New System.Windows.Forms.Label()
        Me.btnConfirmarCC = New System.Windows.Forms.Button()
        Me.txbConfirmarContraseñaCC = New System.Windows.Forms.TextBox()
        Me.lblConfirmarContraseñaCC = New System.Windows.Forms.Label()
        Me.txbContraseñaCC = New System.Windows.Forms.TextBox()
        Me.lblContraseñaCC = New System.Windows.Forms.Label()
        Me.lblCC = New System.Windows.Forms.Label()
        Me.txbCorreoCC = New System.Windows.Forms.TextBox()
        Me.lblCorreoCC = New System.Windows.Forms.Label()
        Me.txbUsuarioCC = New System.Windows.Forms.TextBox()
        Me.lblUsuarioCC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnIniciarSesión
        '
        Me.btnIniciarSesión.Location = New System.Drawing.Point(13, 12)
        Me.btnIniciarSesión.Name = "btnIniciarSesión"
        Me.btnIniciarSesión.Size = New System.Drawing.Size(91, 23)
        Me.btnIniciarSesión.TabIndex = 31
        Me.btnIniciarSesión.Text = "Iniciar Sesión"
        Me.btnIniciarSesión.UseVisualStyleBackColor = True
        '
        'btnCerrarCC
        '
        Me.btnCerrarCC.Location = New System.Drawing.Point(650, 9)
        Me.btnCerrarCC.Name = "btnCerrarCC"
        Me.btnCerrarCC.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarCC.TabIndex = 30
        Me.btnCerrarCC.Text = "X"
        Me.btnCerrarCC.UseVisualStyleBackColor = True
        '
        'lblMensajeCC
        '
        Me.lblMensajeCC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMensajeCC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMensajeCC.Location = New System.Drawing.Point(228, 302)
        Me.lblMensajeCC.Name = "lblMensajeCC"
        Me.lblMensajeCC.Size = New System.Drawing.Size(200, 49)
        Me.lblMensajeCC.TabIndex = 29
        '
        'btnConfirmarCC
        '
        Me.btnConfirmarCC.Location = New System.Drawing.Point(487, 302)
        Me.btnConfirmarCC.Name = "btnConfirmarCC"
        Me.btnConfirmarCC.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmarCC.TabIndex = 28
        Me.btnConfirmarCC.Text = "Confirmar"
        Me.btnConfirmarCC.UseVisualStyleBackColor = True
        '
        'txbConfirmarContraseñaCC
        '
        Me.txbConfirmarContraseñaCC.Location = New System.Drawing.Point(342, 233)
        Me.txbConfirmarContraseñaCC.Name = "txbConfirmarContraseñaCC"
        Me.txbConfirmarContraseñaCC.Size = New System.Drawing.Size(132, 20)
        Me.txbConfirmarContraseñaCC.TabIndex = 27
        '
        'lblConfirmarContraseñaCC
        '
        Me.lblConfirmarContraseñaCC.AutoSize = True
        Me.lblConfirmarContraseñaCC.Location = New System.Drawing.Point(228, 236)
        Me.lblConfirmarContraseñaCC.Name = "lblConfirmarContraseñaCC"
        Me.lblConfirmarContraseñaCC.Size = New System.Drawing.Size(108, 13)
        Me.lblConfirmarContraseñaCC.TabIndex = 26
        Me.lblConfirmarContraseñaCC.Text = "Confirmar Contraseña"
        '
        'txbContraseñaCC
        '
        Me.txbContraseñaCC.Location = New System.Drawing.Point(299, 188)
        Me.txbContraseñaCC.Name = "txbContraseñaCC"
        Me.txbContraseñaCC.Size = New System.Drawing.Size(129, 20)
        Me.txbContraseñaCC.TabIndex = 25
        '
        'lblContraseñaCC
        '
        Me.lblContraseñaCC.AutoSize = True
        Me.lblContraseñaCC.Location = New System.Drawing.Point(228, 191)
        Me.lblContraseñaCC.Name = "lblContraseñaCC"
        Me.lblContraseñaCC.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseñaCC.TabIndex = 24
        Me.lblContraseñaCC.Text = "Contraseña"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCC.Location = New System.Drawing.Point(224, 9)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(269, 37)
        Me.lblCC.TabIndex = 23
        Me.lblCC.Text = "CREAR CUENTA"
        '
        'txbCorreoCC
        '
        Me.txbCorreoCC.Location = New System.Drawing.Point(328, 135)
        Me.txbCorreoCC.Name = "txbCorreoCC"
        Me.txbCorreoCC.Size = New System.Drawing.Size(146, 20)
        Me.txbCorreoCC.TabIndex = 22
        '
        'lblCorreoCC
        '
        Me.lblCorreoCC.AutoSize = True
        Me.lblCorreoCC.Location = New System.Drawing.Point(228, 138)
        Me.lblCorreoCC.Name = "lblCorreoCC"
        Me.lblCorreoCC.Size = New System.Drawing.Size(94, 13)
        Me.lblCorreoCC.TabIndex = 21
        Me.lblCorreoCC.Text = "Correo Eléctronico"
        '
        'txbUsuarioCC
        '
        Me.txbUsuarioCC.Location = New System.Drawing.Point(295, 92)
        Me.txbUsuarioCC.Name = "txbUsuarioCC"
        Me.txbUsuarioCC.Size = New System.Drawing.Size(133, 20)
        Me.txbUsuarioCC.TabIndex = 20
        '
        'lblUsuarioCC
        '
        Me.lblUsuarioCC.AutoSize = True
        Me.lblUsuarioCC.Location = New System.Drawing.Point(246, 99)
        Me.lblUsuarioCC.Name = "lblUsuarioCC"
        Me.lblUsuarioCC.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuarioCC.TabIndex = 19
        Me.lblUsuarioCC.Text = "Usuario"
        '
        'Crear_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.btnIniciarSesión)
        Me.Controls.Add(Me.btnCerrarCC)
        Me.Controls.Add(Me.lblMensajeCC)
        Me.Controls.Add(Me.btnConfirmarCC)
        Me.Controls.Add(Me.txbConfirmarContraseñaCC)
        Me.Controls.Add(Me.lblConfirmarContraseñaCC)
        Me.Controls.Add(Me.txbContraseñaCC)
        Me.Controls.Add(Me.lblContraseñaCC)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.txbCorreoCC)
        Me.Controls.Add(Me.lblCorreoCC)
        Me.Controls.Add(Me.txbUsuarioCC)
        Me.Controls.Add(Me.lblUsuarioCC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Crear_cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Crear_Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnIniciarSesión As Button
    Private WithEvents btnCerrarCC As Button
    Private WithEvents lblMensajeCC As Label
    Private WithEvents btnConfirmarCC As Button
    Private WithEvents txbConfirmarContraseñaCC As TextBox
    Private WithEvents lblConfirmarContraseñaCC As Label
    Private WithEvents txbContraseñaCC As TextBox
    Private WithEvents lblContraseñaCC As Label
    Private WithEvents lblCC As Label
    Private WithEvents txbCorreoCC As TextBox
    Private WithEvents lblCorreoCC As Label
    Private WithEvents txbUsuarioCC As TextBox
    Private WithEvents lblUsuarioCC As Label
End Class
