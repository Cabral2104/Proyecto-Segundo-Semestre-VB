<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciar_Sesión
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
        Me.btnCerrarIS = New System.Windows.Forms.Button()
        Me.lblMensajeIS = New System.Windows.Forms.Label()
        Me.btnConfirmarIS = New System.Windows.Forms.Button()
        Me.lblIS = New System.Windows.Forms.Label()
        Me.txbContraseñaIS = New System.Windows.Forms.TextBox()
        Me.lblContraseñaIS = New System.Windows.Forms.Label()
        Me.txbCorreoIS = New System.Windows.Forms.TextBox()
        Me.lblCorreoIS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCerrarIS
        '
        Me.btnCerrarIS.Location = New System.Drawing.Point(645, 12)
        Me.btnCerrarIS.Name = "btnCerrarIS"
        Me.btnCerrarIS.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarIS.TabIndex = 26
        Me.btnCerrarIS.Text = "X"
        Me.btnCerrarIS.UseVisualStyleBackColor = True
        '
        'lblMensajeIS
        '
        Me.lblMensajeIS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMensajeIS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMensajeIS.Location = New System.Drawing.Point(200, 189)
        Me.lblMensajeIS.Name = "lblMensajeIS"
        Me.lblMensajeIS.Size = New System.Drawing.Size(200, 49)
        Me.lblMensajeIS.TabIndex = 25
        '
        'btnConfirmarIS
        '
        Me.btnConfirmarIS.Location = New System.Drawing.Point(446, 204)
        Me.btnConfirmarIS.Name = "btnConfirmarIS"
        Me.btnConfirmarIS.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmarIS.TabIndex = 24
        Me.btnConfirmarIS.Text = "Confirmar"
        Me.btnConfirmarIS.UseVisualStyleBackColor = True
        '
        'lblIS
        '
        Me.lblIS.AutoSize = True
        Me.lblIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIS.Location = New System.Drawing.Point(225, 9)
        Me.lblIS.Name = "lblIS"
        Me.lblIS.Size = New System.Drawing.Size(261, 37)
        Me.lblIS.TabIndex = 23
        Me.lblIS.Text = "INICIAR SESIÓN"
        '
        'txbContraseñaIS
        '
        Me.txbContraseñaIS.Location = New System.Drawing.Point(300, 140)
        Me.txbContraseñaIS.Name = "txbContraseñaIS"
        Me.txbContraseñaIS.Size = New System.Drawing.Size(100, 20)
        Me.txbContraseñaIS.TabIndex = 22
        '
        'lblContraseñaIS
        '
        Me.lblContraseñaIS.AutoSize = True
        Me.lblContraseñaIS.Location = New System.Drawing.Point(229, 140)
        Me.lblContraseñaIS.Name = "lblContraseñaIS"
        Me.lblContraseñaIS.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseñaIS.TabIndex = 21
        Me.lblContraseñaIS.Text = "Contraseña"
        '
        'txbCorreoIS
        '
        Me.txbCorreoIS.Location = New System.Drawing.Point(300, 79)
        Me.txbCorreoIS.Name = "txbCorreoIS"
        Me.txbCorreoIS.Size = New System.Drawing.Size(100, 20)
        Me.txbCorreoIS.TabIndex = 20
        '
        'lblCorreoIS
        '
        Me.lblCorreoIS.AutoSize = True
        Me.lblCorreoIS.Location = New System.Drawing.Point(200, 82)
        Me.lblCorreoIS.Name = "lblCorreoIS"
        Me.lblCorreoIS.Size = New System.Drawing.Size(94, 13)
        Me.lblCorreoIS.TabIndex = 19
        Me.lblCorreoIS.Text = "Correo Eléctronico"
        '
        'Iniciar_Sesión
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.btnCerrarIS)
        Me.Controls.Add(Me.lblMensajeIS)
        Me.Controls.Add(Me.btnConfirmarIS)
        Me.Controls.Add(Me.lblIS)
        Me.Controls.Add(Me.txbContraseñaIS)
        Me.Controls.Add(Me.lblContraseñaIS)
        Me.Controls.Add(Me.txbCorreoIS)
        Me.Controls.Add(Me.lblCorreoIS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Iniciar_Sesión"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Iniciar_Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrarIS As Button
    Private WithEvents lblMensajeIS As Label
    Private WithEvents btnConfirmarIS As Button
    Private WithEvents lblIS As Label
    Private WithEvents txbContraseñaIS As TextBox
    Private WithEvents lblContraseñaIS As Label
    Private WithEvents txbCorreoIS As TextBox
    Private WithEvents lblCorreoIS As Label
End Class
