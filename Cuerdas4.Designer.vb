<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuerdas4
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
        Me.btnCASelta = New System.Windows.Forms.Button()
        Me.btnCASelvi = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAddCarritoArpa = New System.Windows.Forms.Button()
        Me.nudArpaSelta = New System.Windows.Forms.NumericUpDown()
        Me.lblArpaSelta = New System.Windows.Forms.Label()
        Me.nudArpaSelvi = New System.Windows.Forms.NumericUpDown()
        Me.lblArpaSelvi = New System.Windows.Forms.Label()
        Me.lblArpas = New System.Windows.Forms.Label()
        Me.btnCerrarCuerdas4 = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudArpaSelta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudArpaSelvi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCASelta
        '
        Me.btnCASelta.Location = New System.Drawing.Point(439, 421)
        Me.btnCASelta.Name = "btnCASelta"
        Me.btnCASelta.Size = New System.Drawing.Size(105, 23)
        Me.btnCASelta.TabIndex = 28
        Me.btnCASelta.Text = "Ver Características"
        Me.btnCASelta.UseVisualStyleBackColor = True
        '
        'btnCASelvi
        '
        Me.btnCASelvi.Location = New System.Drawing.Point(120, 421)
        Me.btnCASelvi.Name = "btnCASelvi"
        Me.btnCASelvi.Size = New System.Drawing.Size(105, 23)
        Me.btnCASelvi.TabIndex = 27
        Me.btnCASelvi.Text = "Ver Características"
        Me.btnCASelvi.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(480, 405)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 13)
        Me.label2.TabIndex = 26
        Me.label2.Text = "$6000"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(156, 405)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "$7000"
        '
        'btnAddCarritoArpa
        '
        Me.btnAddCarritoArpa.Location = New System.Drawing.Point(299, 470)
        Me.btnAddCarritoArpa.Name = "btnAddCarritoArpa"
        Me.btnAddCarritoArpa.Size = New System.Drawing.Size(101, 23)
        Me.btnAddCarritoArpa.TabIndex = 24
        Me.btnAddCarritoArpa.Text = "Agregar al Carrito"
        Me.btnAddCarritoArpa.UseVisualStyleBackColor = True
        '
        'nudArpaSelta
        '
        Me.nudArpaSelta.Location = New System.Drawing.Point(423, 382)
        Me.nudArpaSelta.Name = "nudArpaSelta"
        Me.nudArpaSelta.Size = New System.Drawing.Size(156, 20)
        Me.nudArpaSelta.TabIndex = 23
        '
        'lblArpaSelta
        '
        Me.lblArpaSelta.AutoSize = True
        Me.lblArpaSelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArpaSelta.Location = New System.Drawing.Point(460, 359)
        Me.lblArpaSelta.Name = "lblArpaSelta"
        Me.lblArpaSelta.Size = New System.Drawing.Size(84, 20)
        Me.lblArpaSelta.TabIndex = 22
        Me.lblArpaSelta.Text = "Arpa Selta"
        '
        'nudArpaSelvi
        '
        Me.nudArpaSelvi.Location = New System.Drawing.Point(103, 382)
        Me.nudArpaSelvi.Name = "nudArpaSelvi"
        Me.nudArpaSelvi.Size = New System.Drawing.Size(156, 20)
        Me.nudArpaSelvi.TabIndex = 20
        '
        'lblArpaSelvi
        '
        Me.lblArpaSelvi.AutoSize = True
        Me.lblArpaSelvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArpaSelvi.Location = New System.Drawing.Point(133, 359)
        Me.lblArpaSelvi.Name = "lblArpaSelvi"
        Me.lblArpaSelvi.Size = New System.Drawing.Size(80, 20)
        Me.lblArpaSelvi.TabIndex = 19
        Me.lblArpaSelvi.Text = "Arpa Selvi"
        '
        'lblArpas
        '
        Me.lblArpas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArpas.Location = New System.Drawing.Point(292, 9)
        Me.lblArpas.Name = "lblArpas"
        Me.lblArpas.Size = New System.Drawing.Size(108, 42)
        Me.lblArpas.TabIndex = 17
        Me.lblArpas.Text = "Arpas"
        '
        'btnCerrarCuerdas4
        '
        Me.btnCerrarCuerdas4.Location = New System.Drawing.Point(638, 9)
        Me.btnCerrarCuerdas4.Name = "btnCerrarCuerdas4"
        Me.btnCerrarCuerdas4.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarCuerdas4.TabIndex = 16
        Me.btnCerrarCuerdas4.Text = "X"
        Me.btnCerrarCuerdas4.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Arpa_Selta
        Me.pictureBox2.Location = New System.Drawing.Point(423, 68)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(156, 288)
        Me.pictureBox2.TabIndex = 21
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Arpa_Salvi
        Me.pictureBox1.Location = New System.Drawing.Point(103, 68)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(156, 288)
        Me.pictureBox1.TabIndex = 18
        Me.pictureBox1.TabStop = False
        '
        'Cuerdas4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.btnCASelta)
        Me.Controls.Add(Me.btnCASelvi)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnAddCarritoArpa)
        Me.Controls.Add(Me.nudArpaSelta)
        Me.Controls.Add(Me.lblArpaSelta)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.nudArpaSelvi)
        Me.Controls.Add(Me.lblArpaSelvi)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblArpas)
        Me.Controls.Add(Me.btnCerrarCuerdas4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Cuerdas4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cuerdas4"
        CType(Me.nudArpaSelta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudArpaSelvi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCASelta As Button
    Private WithEvents btnCASelvi As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnAddCarritoArpa As Button
    Private WithEvents nudArpaSelta As NumericUpDown
    Private WithEvents lblArpaSelta As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents nudArpaSelvi As NumericUpDown
    Private WithEvents lblArpaSelvi As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblArpas As Label
    Private WithEvents btnCerrarCuerdas4 As Button
End Class
