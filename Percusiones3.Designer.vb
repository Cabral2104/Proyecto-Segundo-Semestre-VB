<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Percusiones3
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
        Me.btnAddCarritoTimbal = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.nudTimbalMajestic32 = New System.Windows.Forms.NumericUpDown()
        Me.lblTimbalMajestic32 = New System.Windows.Forms.Label()
        Me.nudTimbalAdams32 = New System.Windows.Forms.NumericUpDown()
        Me.lblTimbalAdams32 = New System.Windows.Forms.Label()
        Me.lblGuitarrasElectricas = New System.Windows.Forms.Label()
        Me.btnCerrarPercusiones3 = New System.Windows.Forms.Button()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudTimbalMajestic32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimbalAdams32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddCarritoTimbal
        '
        Me.btnAddCarritoTimbal.Location = New System.Drawing.Point(452, 486)
        Me.btnAddCarritoTimbal.Name = "btnAddCarritoTimbal"
        Me.btnAddCarritoTimbal.Size = New System.Drawing.Size(103, 23)
        Me.btnAddCarritoTimbal.TabIndex = 26
        Me.btnAddCarritoTimbal.Text = "Agregar al Carrito"
        Me.btnAddCarritoTimbal.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(467, 269)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 13)
        Me.label2.TabIndex = 25
        Me.label2.Text = "$4000"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(159, 408)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 24
        Me.label1.Text = "$3000"
        '
        'nudTimbalMajestic32
        '
        Me.nudTimbalMajestic32.Location = New System.Drawing.Point(408, 246)
        Me.nudTimbalMajestic32.Name = "nudTimbalMajestic32"
        Me.nudTimbalMajestic32.Size = New System.Drawing.Size(156, 20)
        Me.nudTimbalMajestic32.TabIndex = 23
        '
        'lblTimbalMajestic32
        '
        Me.lblTimbalMajestic32.AutoSize = True
        Me.lblTimbalMajestic32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimbalMajestic32.Location = New System.Drawing.Point(416, 223)
        Me.lblTimbalMajestic32.Name = "lblTimbalMajestic32"
        Me.lblTimbalMajestic32.Size = New System.Drawing.Size(139, 20)
        Me.lblTimbalMajestic32.TabIndex = 22
        Me.lblTimbalMajestic32.Text = "Timbal Majestic 32"
        '
        'nudTimbalAdams32
        '
        Me.nudTimbalAdams32.Location = New System.Drawing.Point(101, 385)
        Me.nudTimbalAdams32.Name = "nudTimbalAdams32"
        Me.nudTimbalAdams32.Size = New System.Drawing.Size(156, 20)
        Me.nudTimbalAdams32.TabIndex = 20
        '
        'lblTimbalAdams32
        '
        Me.lblTimbalAdams32.AutoSize = True
        Me.lblTimbalAdams32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimbalAdams32.Location = New System.Drawing.Point(116, 362)
        Me.lblTimbalAdams32.Name = "lblTimbalAdams32"
        Me.lblTimbalAdams32.Size = New System.Drawing.Size(131, 20)
        Me.lblTimbalAdams32.TabIndex = 19
        Me.lblTimbalAdams32.Text = "Timbal Adams 32"
        '
        'lblGuitarrasElectricas
        '
        Me.lblGuitarrasElectricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuitarrasElectricas.Location = New System.Drawing.Point(269, 9)
        Me.lblGuitarrasElectricas.Name = "lblGuitarrasElectricas"
        Me.lblGuitarrasElectricas.Size = New System.Drawing.Size(162, 35)
        Me.lblGuitarrasElectricas.TabIndex = 17
        Me.lblGuitarrasElectricas.Text = "Timbales"
        '
        'btnCerrarPercusiones3
        '
        Me.btnCerrarPercusiones3.Location = New System.Drawing.Point(641, 9)
        Me.btnCerrarPercusiones3.Name = "btnCerrarPercusiones3"
        Me.btnCerrarPercusiones3.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarPercusiones3.TabIndex = 16
        Me.btnCerrarPercusiones3.Text = "X"
        Me.btnCerrarPercusiones3.UseVisualStyleBackColor = True
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Timbal_Majestic_32
        Me.pictureBox3.Location = New System.Drawing.Point(408, 84)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(156, 136)
        Me.pictureBox3.TabIndex = 21
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Proyecto_Segundo_Semestre_VB.My.Resources.Resources.Timbal_Adams_32
        Me.pictureBox1.Location = New System.Drawing.Point(101, 223)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(156, 136)
        Me.pictureBox1.TabIndex = 18
        Me.pictureBox1.TabStop = False
        '
        'Percusiones3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(736, 749)
        Me.Controls.Add(Me.btnAddCarritoTimbal)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.nudTimbalMajestic32)
        Me.Controls.Add(Me.lblTimbalMajestic32)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.nudTimbalAdams32)
        Me.Controls.Add(Me.lblTimbalAdams32)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblGuitarrasElectricas)
        Me.Controls.Add(Me.btnCerrarPercusiones3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(440, 30)
        Me.Name = "Percusiones3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Percusiones3"
        CType(Me.nudTimbalMajestic32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimbalAdams32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnAddCarritoTimbal As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents nudTimbalMajestic32 As NumericUpDown
    Private WithEvents lblTimbalMajestic32 As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents nudTimbalAdams32 As NumericUpDown
    Private WithEvents lblTimbalAdams32 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblGuitarrasElectricas As Label
    Private WithEvents btnCerrarPercusiones3 As Button
End Class
