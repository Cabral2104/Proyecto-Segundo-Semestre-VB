<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Percusiones5
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAddCarritoBombo = New System.Windows.Forms.Button()
        Me.nudBomboAudiotek = New System.Windows.Forms.NumericUpDown()
        Me.lblBomboAudiotek = New System.Windows.Forms.Label()
        Me.lblGuitarrasElectricas = New System.Windows.Forms.Label()
        Me.btnCerrarPercusiones5 = New System.Windows.Forms.Button()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.nudBomboAudiotek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(328, 327)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 32
        Me.label1.Text = "$1500"
        '
        'btnAddCarritoBombo
        '
        Me.btnAddCarritoBombo.Location = New System.Drawing.Point(495, 402)
        Me.btnAddCarritoBombo.Name = "btnAddCarritoBombo"
        Me.btnAddCarritoBombo.Size = New System.Drawing.Size(111, 23)
        Me.btnAddCarritoBombo.TabIndex = 31
        Me.btnAddCarritoBombo.Text = "Agregar al Carrito"
        Me.btnAddCarritoBombo.UseVisualStyleBackColor = True
        '
        'nudBomboAudiotek
        '
        Me.nudBomboAudiotek.Location = New System.Drawing.Point(270, 304)
        Me.nudBomboAudiotek.Name = "nudBomboAudiotek"
        Me.nudBomboAudiotek.Size = New System.Drawing.Size(156, 20)
        Me.nudBomboAudiotek.TabIndex = 30
        '
        'lblBomboAudiotek
        '
        Me.lblBomboAudiotek.AutoSize = True
        Me.lblBomboAudiotek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBomboAudiotek.Location = New System.Drawing.Point(284, 281)
        Me.lblBomboAudiotek.Name = "lblBomboAudiotek"
        Me.lblBomboAudiotek.Size = New System.Drawing.Size(127, 20)
        Me.lblBomboAudiotek.TabIndex = 29
        Me.lblBomboAudiotek.Text = "Bombo Audiotek"
        '
        'lblGuitarrasElectricas
        '
        Me.lblGuitarrasElectricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuitarrasElectricas.Location = New System.Drawing.Point(289, 9)
        Me.lblGuitarrasElectricas.Name = "lblGuitarrasElectricas"
        Me.lblGuitarrasElectricas.Size = New System.Drawing.Size(137, 35)
        Me.lblGuitarrasElectricas.TabIndex = 27
        Me.lblGuitarrasElectricas.Text = "Bombo"
        '
        'btnCerrarPercusiones5
        '
        Me.btnCerrarPercusiones5.Location = New System.Drawing.Point(648, 9)
        Me.btnCerrarPercusiones5.Name = "btnCerrarPercusiones5"
        Me.btnCerrarPercusiones5.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarPercusiones5.TabIndex = 26
        Me.btnCerrarPercusiones5.Text = "X"
        Me.btnCerrarPercusiones5.UseVisualStyleBackColor = True
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Bombo_Audiotek
        Me.pictureBox3.Location = New System.Drawing.Point(270, 103)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(156, 175)
        Me.pictureBox3.TabIndex = 28
        Me.pictureBox3.TabStop = False
        '
        'Percusiones5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnAddCarritoBombo)
        Me.Controls.Add(Me.nudBomboAudiotek)
        Me.Controls.Add(Me.lblBomboAudiotek)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.lblGuitarrasElectricas)
        Me.Controls.Add(Me.btnCerrarPercusiones5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Percusiones5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Percusiones5"
        CType(Me.nudBomboAudiotek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnAddCarritoBombo As Button
    Private WithEvents nudBomboAudiotek As NumericUpDown
    Private WithEvents lblBomboAudiotek As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents lblGuitarrasElectricas As Label
    Private WithEvents btnCerrarPercusiones5 As Button
End Class
