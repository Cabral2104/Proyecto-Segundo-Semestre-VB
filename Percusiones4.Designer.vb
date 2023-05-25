<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Percusiones4
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
        Me.btnAddCarritoTriangulo = New System.Windows.Forms.Button()
        Me.nudTrianguloXO = New System.Windows.Forms.NumericUpDown()
        Me.lblTrianguloXO = New System.Windows.Forms.Label()
        Me.nudTrianguloCharls = New System.Windows.Forms.NumericUpDown()
        Me.lblTrianguloCharls = New System.Windows.Forms.Label()
        Me.lblGuitarrasElectricas = New System.Windows.Forms.Label()
        Me.btnCerrarPercusiones4 = New System.Windows.Forms.Button()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudTrianguloXO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTrianguloCharls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(495, 372)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 33
        Me.label2.Text = "$400"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(171, 376)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(31, 13)
        Me.label1.TabIndex = 32
        Me.label1.Text = "$500"
        '
        'btnAddCarritoTriangulo
        '
        Me.btnAddCarritoTriangulo.Location = New System.Drawing.Point(482, 464)
        Me.btnAddCarritoTriangulo.Name = "btnAddCarritoTriangulo"
        Me.btnAddCarritoTriangulo.Size = New System.Drawing.Size(101, 23)
        Me.btnAddCarritoTriangulo.TabIndex = 31
        Me.btnAddCarritoTriangulo.Text = "Agregar al Carrito"
        Me.btnAddCarritoTriangulo.UseVisualStyleBackColor = True
        '
        'nudTrianguloXO
        '
        Me.nudTrianguloXO.Location = New System.Drawing.Point(427, 349)
        Me.nudTrianguloXO.Name = "nudTrianguloXO"
        Me.nudTrianguloXO.Size = New System.Drawing.Size(156, 20)
        Me.nudTrianguloXO.TabIndex = 30
        '
        'lblTrianguloXO
        '
        Me.lblTrianguloXO.AutoSize = True
        Me.lblTrianguloXO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrianguloXO.Location = New System.Drawing.Point(457, 326)
        Me.lblTrianguloXO.Name = "lblTrianguloXO"
        Me.lblTrianguloXO.Size = New System.Drawing.Size(101, 20)
        Me.lblTrianguloXO.TabIndex = 29
        Me.lblTrianguloXO.Text = "Triangulo XO"
        '
        'nudTrianguloCharls
        '
        Me.nudTrianguloCharls.Location = New System.Drawing.Point(110, 349)
        Me.nudTrianguloCharls.Name = "nudTrianguloCharls"
        Me.nudTrianguloCharls.Size = New System.Drawing.Size(156, 20)
        Me.nudTrianguloCharls.TabIndex = 27
        '
        'lblTrianguloCharls
        '
        Me.lblTrianguloCharls.AutoSize = True
        Me.lblTrianguloCharls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrianguloCharls.Location = New System.Drawing.Point(125, 326)
        Me.lblTrianguloCharls.Name = "lblTrianguloCharls"
        Me.lblTrianguloCharls.Size = New System.Drawing.Size(123, 20)
        Me.lblTrianguloCharls.TabIndex = 26
        Me.lblTrianguloCharls.Text = "Triangulo Charls"
        '
        'lblGuitarrasElectricas
        '
        Me.lblGuitarrasElectricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuitarrasElectricas.Location = New System.Drawing.Point(288, 44)
        Me.lblGuitarrasElectricas.Name = "lblGuitarrasElectricas"
        Me.lblGuitarrasElectricas.Size = New System.Drawing.Size(162, 39)
        Me.lblGuitarrasElectricas.TabIndex = 24
        Me.lblGuitarrasElectricas.Text = "Triangulos"
        '
        'btnCerrarPercusiones4
        '
        Me.btnCerrarPercusiones4.Location = New System.Drawing.Point(644, 15)
        Me.btnCerrarPercusiones4.Name = "btnCerrarPercusiones4"
        Me.btnCerrarPercusiones4.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarPercusiones4.TabIndex = 23
        Me.btnCerrarPercusiones4.Text = "X"
        Me.btnCerrarPercusiones4.UseVisualStyleBackColor = True
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Triangulo_XO
        Me.pictureBox3.Location = New System.Drawing.Point(427, 187)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(156, 136)
        Me.pictureBox3.TabIndex = 28
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Triangulo_Charls
        Me.pictureBox1.Location = New System.Drawing.Point(110, 165)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(156, 158)
        Me.pictureBox1.TabIndex = 25
        Me.pictureBox1.TabStop = False
        '
        'Percusiones4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnAddCarritoTriangulo)
        Me.Controls.Add(Me.nudTrianguloXO)
        Me.Controls.Add(Me.lblTrianguloXO)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.nudTrianguloCharls)
        Me.Controls.Add(Me.lblTrianguloCharls)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblGuitarrasElectricas)
        Me.Controls.Add(Me.btnCerrarPercusiones4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Percusiones4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Percusiones4"
        CType(Me.nudTrianguloXO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTrianguloCharls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnAddCarritoTriangulo As Button
    Private WithEvents nudTrianguloXO As NumericUpDown
    Private WithEvents lblTrianguloXO As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents nudTrianguloCharls As NumericUpDown
    Private WithEvents lblTrianguloCharls As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblGuitarrasElectricas As Label
    Private WithEvents btnCerrarPercusiones4 As Button
End Class
