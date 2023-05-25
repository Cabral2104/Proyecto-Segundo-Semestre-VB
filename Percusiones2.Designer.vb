<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Percusiones2
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAddCarritoBEL = New System.Windows.Forms.Button()
        Me.nudBERonald = New System.Windows.Forms.NumericUpDown()
        Me.lblBERonald = New System.Windows.Forms.Label()
        Me.nudBEYamaha = New System.Windows.Forms.NumericUpDown()
        Me.lblBEYamaha = New System.Windows.Forms.Label()
        Me.lblGuitarrasElectricas = New System.Windows.Forms.Label()
        Me.btnCerrarPercusiones2 = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudBERonald, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBEYamaha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(462, 373)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 24
        Me.label2.Text = "$14500"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(150, 286)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 23
        Me.label1.Text = "$14000"
        '
        'btnAddCarritoBEL
        '
        Me.btnAddCarritoBEL.Location = New System.Drawing.Point(556, 427)
        Me.btnAddCarritoBEL.Name = "btnAddCarritoBEL"
        Me.btnAddCarritoBEL.Size = New System.Drawing.Size(100, 23)
        Me.btnAddCarritoBEL.TabIndex = 22
        Me.btnAddCarritoBEL.Text = "Agregar al Carrito"
        Me.btnAddCarritoBEL.UseVisualStyleBackColor = True
        '
        'nudBERonald
        '
        Me.nudBERonald.Location = New System.Drawing.Point(404, 350)
        Me.nudBERonald.Name = "nudBERonald"
        Me.nudBERonald.Size = New System.Drawing.Size(156, 20)
        Me.nudBERonald.TabIndex = 21
        '
        'lblBERonald
        '
        Me.lblBERonald.AutoSize = True
        Me.lblBERonald.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBERonald.Location = New System.Drawing.Point(390, 327)
        Me.lblBERonald.Name = "lblBERonald"
        Me.lblBERonald.Size = New System.Drawing.Size(180, 20)
        Me.lblBERonald.TabIndex = 20
        Me.lblBERonald.Text = "Bateria Eléctrica Ronald"
        '
        'nudBEYamaha
        '
        Me.nudBEYamaha.Location = New System.Drawing.Point(97, 263)
        Me.nudBEYamaha.Name = "nudBEYamaha"
        Me.nudBEYamaha.Size = New System.Drawing.Size(156, 20)
        Me.nudBEYamaha.TabIndex = 18
        '
        'lblBEYamaha
        '
        Me.lblBEYamaha.AutoSize = True
        Me.lblBEYamaha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBEYamaha.Location = New System.Drawing.Point(81, 240)
        Me.lblBEYamaha.Name = "lblBEYamaha"
        Me.lblBEYamaha.Size = New System.Drawing.Size(189, 20)
        Me.lblBEYamaha.TabIndex = 17
        Me.lblBEYamaha.Text = "Bateria Eléctrica Yamaha"
        '
        'lblGuitarrasElectricas
        '
        Me.lblGuitarrasElectricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuitarrasElectricas.Location = New System.Drawing.Point(191, 9)
        Me.lblGuitarrasElectricas.Name = "lblGuitarrasElectricas"
        Me.lblGuitarrasElectricas.Size = New System.Drawing.Size(324, 35)
        Me.lblGuitarrasElectricas.TabIndex = 15
        Me.lblGuitarrasElectricas.Text = "Baterias Eléctricas"
        '
        'btnCerrarPercusiones2
        '
        Me.btnCerrarPercusiones2.Location = New System.Drawing.Point(643, 9)
        Me.btnCerrarPercusiones2.Name = "btnCerrarPercusiones2"
        Me.btnCerrarPercusiones2.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarPercusiones2.TabIndex = 14
        Me.btnCerrarPercusiones2.Text = "X"
        Me.btnCerrarPercusiones2.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Batería_Eléctrica_Roland
        Me.pictureBox2.Location = New System.Drawing.Point(404, 158)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(156, 166)
        Me.pictureBox2.TabIndex = 19
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Batería_Eléctrica_Yamaha
        Me.pictureBox1.Location = New System.Drawing.Point(97, 80)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(156, 157)
        Me.pictureBox1.TabIndex = 16
        Me.pictureBox1.TabStop = False
        '
        'Percusiones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnAddCarritoBEL)
        Me.Controls.Add(Me.nudBERonald)
        Me.Controls.Add(Me.lblBERonald)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.nudBEYamaha)
        Me.Controls.Add(Me.lblBEYamaha)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblGuitarrasElectricas)
        Me.Controls.Add(Me.btnCerrarPercusiones2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Percusiones2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Percusiones2"
        CType(Me.nudBERonald, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBEYamaha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnAddCarritoBEL As Button
    Private WithEvents nudBERonald As NumericUpDown
    Private WithEvents lblBERonald As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents nudBEYamaha As NumericUpDown
    Private WithEvents lblBEYamaha As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblGuitarrasElectricas As Label
    Private WithEvents btnCerrarPercusiones2 As Button
End Class
