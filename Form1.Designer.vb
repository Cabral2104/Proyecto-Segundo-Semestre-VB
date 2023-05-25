<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelVerInstrumentos = New System.Windows.Forms.Panel()
        Me.PanelMenúLateral = New System.Windows.Forms.Panel()
        Me.btnInstrumentosAire = New System.Windows.Forms.Button()
        Me.PanelSubMenúPercusión = New System.Windows.Forms.Panel()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.buton10 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.btnInstrumentosPercusión = New System.Windows.Forms.Button()
        Me.btnInstrumentosCuerdas = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.panelSubMenúCuerdas = New System.Windows.Forms.Panel()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnCerrarForm1 = New System.Windows.Forms.Button()
        Me.btnTotalCompra = New System.Windows.Forms.Button()
        Me.dtgCompra = New System.Windows.Forms.DataGridView()
        Me.CInstrumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelComentarios = New System.Windows.Forms.Panel()
        Me.lblMostrarComentarios = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.lblMSJ = New System.Windows.Forms.Label()
        Me.btnMostrarComentario = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.btnIniciarSesión = New System.Windows.Forms.Button()
        Me.panelVerInstrumentos.SuspendLayout()
        Me.PanelMenúLateral.SuspendLayout()
        Me.PanelSubMenúPercusión.SuspendLayout()
        Me.panelSubMenúCuerdas.SuspendLayout()
        CType(Me.dtgCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelComentarios.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelVerInstrumentos
        '
        Me.panelVerInstrumentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelVerInstrumentos.Controls.Add(Me.btnIniciarSesión)
        Me.panelVerInstrumentos.Controls.Add(Me.btnCrearCuenta)
        Me.panelVerInstrumentos.Controls.Add(Me.PanelMenúLateral)
        Me.panelVerInstrumentos.Controls.Add(Me.btnCerrarForm1)
        Me.panelVerInstrumentos.Controls.Add(Me.btnTotalCompra)
        Me.panelVerInstrumentos.Controls.Add(Me.dtgCompra)
        Me.panelVerInstrumentos.Controls.Add(Me.panelComentarios)
        Me.panelVerInstrumentos.Controls.Add(Me.pictureBox1)
        Me.panelVerInstrumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelVerInstrumentos.Location = New System.Drawing.Point(0, 0)
        Me.panelVerInstrumentos.Name = "panelVerInstrumentos"
        Me.panelVerInstrumentos.Size = New System.Drawing.Size(970, 710)
        Me.panelVerInstrumentos.TabIndex = 2
        '
        'PanelMenúLateral
        '
        Me.PanelMenúLateral.AutoScroll = True
        Me.PanelMenúLateral.BackColor = System.Drawing.Color.MediumAquamarine
        Me.PanelMenúLateral.Controls.Add(Me.btnInstrumentosAire)
        Me.PanelMenúLateral.Controls.Add(Me.PanelSubMenúPercusión)
        Me.PanelMenúLateral.Controls.Add(Me.btnInstrumentosPercusión)
        Me.PanelMenúLateral.Controls.Add(Me.btnInstrumentosCuerdas)
        Me.PanelMenúLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenúLateral.Controls.Add(Me.panelSubMenúCuerdas)
        Me.PanelMenúLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenúLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenúLateral.Name = "PanelMenúLateral"
        Me.PanelMenúLateral.Size = New System.Drawing.Size(250, 710)
        Me.PanelMenúLateral.TabIndex = 8
        '
        'btnInstrumentosAire
        '
        Me.btnInstrumentosAire.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnInstrumentosAire.Location = New System.Drawing.Point(0, 633)
        Me.btnInstrumentosAire.Name = "btnInstrumentosAire"
        Me.btnInstrumentosAire.Size = New System.Drawing.Size(250, 45)
        Me.btnInstrumentosAire.TabIndex = 11
        Me.btnInstrumentosAire.Text = "Instrumentos de Aire"
        Me.btnInstrumentosAire.UseVisualStyleBackColor = False
        '
        'PanelSubMenúPercusión
        '
        Me.PanelSubMenúPercusión.BackColor = System.Drawing.Color.Turquoise
        Me.PanelSubMenúPercusión.Controls.Add(Me.button7)
        Me.PanelSubMenúPercusión.Controls.Add(Me.button8)
        Me.PanelSubMenúPercusión.Controls.Add(Me.button9)
        Me.PanelSubMenúPercusión.Controls.Add(Me.buton10)
        Me.PanelSubMenúPercusión.Controls.Add(Me.button11)
        Me.PanelSubMenúPercusión.Location = New System.Drawing.Point(1, 409)
        Me.PanelSubMenúPercusión.Name = "PanelSubMenúPercusión"
        Me.PanelSubMenúPercusión.Size = New System.Drawing.Size(250, 226)
        Me.PanelSubMenúPercusión.TabIndex = 10
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.Turquoise
        Me.button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.button7.Location = New System.Drawing.Point(0, 180)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(250, 45)
        Me.button7.TabIndex = 4
        Me.button7.Text = "Bombo"
        Me.button7.UseVisualStyleBackColor = False
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.Color.Turquoise
        Me.button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.button8.Location = New System.Drawing.Point(0, 135)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(250, 45)
        Me.button8.TabIndex = 3
        Me.button8.Text = "Triángulo"
        Me.button8.UseVisualStyleBackColor = False
        '
        'button9
        '
        Me.button9.BackColor = System.Drawing.Color.Turquoise
        Me.button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.button9.Location = New System.Drawing.Point(0, 90)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(250, 45)
        Me.button9.TabIndex = 2
        Me.button9.Text = "Timbales"
        Me.button9.UseVisualStyleBackColor = False
        '
        'buton10
        '
        Me.buton10.BackColor = System.Drawing.Color.Turquoise
        Me.buton10.Dock = System.Windows.Forms.DockStyle.Top
        Me.buton10.Location = New System.Drawing.Point(0, 45)
        Me.buton10.Name = "buton10"
        Me.buton10.Size = New System.Drawing.Size(250, 45)
        Me.buton10.TabIndex = 1
        Me.buton10.Text = "Baterias Eléctricas"
        Me.buton10.UseVisualStyleBackColor = False
        '
        'button11
        '
        Me.button11.BackColor = System.Drawing.Color.Turquoise
        Me.button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.button11.Location = New System.Drawing.Point(0, 0)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(250, 45)
        Me.button11.TabIndex = 0
        Me.button11.Text = "Baterias Acusticas"
        Me.button11.UseVisualStyleBackColor = False
        '
        'btnInstrumentosPercusión
        '
        Me.btnInstrumentosPercusión.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnInstrumentosPercusión.Location = New System.Drawing.Point(0, 366)
        Me.btnInstrumentosPercusión.Name = "btnInstrumentosPercusión"
        Me.btnInstrumentosPercusión.Size = New System.Drawing.Size(250, 45)
        Me.btnInstrumentosPercusión.TabIndex = 9
        Me.btnInstrumentosPercusión.Text = "Instrumentos de Percusión"
        Me.btnInstrumentosPercusión.UseVisualStyleBackColor = False
        '
        'btnInstrumentosCuerdas
        '
        Me.btnInstrumentosCuerdas.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnInstrumentosCuerdas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInstrumentosCuerdas.Location = New System.Drawing.Point(0, 100)
        Me.btnInstrumentosCuerdas.Name = "btnInstrumentosCuerdas"
        Me.btnInstrumentosCuerdas.Size = New System.Drawing.Size(251, 45)
        Me.btnInstrumentosCuerdas.TabIndex = 8
        Me.btnInstrumentosCuerdas.Text = "Instrumentos de Cuerdas"
        Me.btnInstrumentosCuerdas.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(251, 100)
        Me.PanelLogo.TabIndex = 6
        '
        'panelSubMenúCuerdas
        '
        Me.panelSubMenúCuerdas.BackColor = System.Drawing.Color.Turquoise
        Me.panelSubMenúCuerdas.Controls.Add(Me.button5)
        Me.panelSubMenúCuerdas.Controls.Add(Me.button4)
        Me.panelSubMenúCuerdas.Controls.Add(Me.button3)
        Me.panelSubMenúCuerdas.Controls.Add(Me.button2)
        Me.panelSubMenúCuerdas.Controls.Add(Me.button1)
        Me.panelSubMenúCuerdas.Location = New System.Drawing.Point(0, 142)
        Me.panelSubMenúCuerdas.Name = "panelSubMenúCuerdas"
        Me.panelSubMenúCuerdas.Size = New System.Drawing.Size(250, 226)
        Me.panelSubMenúCuerdas.TabIndex = 7
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.Turquoise
        Me.button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.button5.Location = New System.Drawing.Point(0, 180)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(250, 45)
        Me.button5.TabIndex = 5
        Me.button5.Text = "Violonchelos"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.Turquoise
        Me.button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.button4.Location = New System.Drawing.Point(0, 135)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(250, 45)
        Me.button4.TabIndex = 4
        Me.button4.Text = "Arpas"
        Me.button4.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.Turquoise
        Me.button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.button3.Location = New System.Drawing.Point(0, 90)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(250, 45)
        Me.button3.TabIndex = 3
        Me.button3.Text = "Bajos Eléctricos"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Turquoise
        Me.button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.button2.Location = New System.Drawing.Point(0, 45)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(250, 45)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Guitarras Eléctricas"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Turquoise
        Me.button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.button1.Location = New System.Drawing.Point(0, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(250, 45)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Guitarras Acusticas"
        Me.button1.UseVisualStyleBackColor = False
        '
        'btnCerrarForm1
        '
        Me.btnCerrarForm1.Location = New System.Drawing.Point(883, 12)
        Me.btnCerrarForm1.Name = "btnCerrarForm1"
        Me.btnCerrarForm1.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarForm1.TabIndex = 5
        Me.btnCerrarForm1.Text = "Cerrar"
        Me.btnCerrarForm1.UseVisualStyleBackColor = True
        '
        'btnTotalCompra
        '
        Me.btnTotalCompra.Location = New System.Drawing.Point(834, 399)
        Me.btnTotalCompra.Name = "btnTotalCompra"
        Me.btnTotalCompra.Size = New System.Drawing.Size(123, 23)
        Me.btnTotalCompra.TabIndex = 4
        Me.btnTotalCompra.Text = "Total de Compra"
        Me.btnTotalCompra.UseVisualStyleBackColor = True
        '
        'dtgCompra
        '
        Me.dtgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CInstrumento, Me.CCantidad, Me.CPrecioTotal})
        Me.dtgCompra.Location = New System.Drawing.Point(467, 109)
        Me.dtgCompra.Name = "dtgCompra"
        Me.dtgCompra.Size = New System.Drawing.Size(345, 312)
        Me.dtgCompra.TabIndex = 2
        '
        'CInstrumento
        '
        Me.CInstrumento.HeaderText = "Instrumento"
        Me.CInstrumento.Name = "CInstrumento"
        '
        'CCantidad
        '
        Me.CCantidad.HeaderText = "Cantidad"
        Me.CCantidad.Name = "CCantidad"
        '
        'CPrecioTotal
        '
        Me.CPrecioTotal.HeaderText = "Precio Total"
        Me.CPrecioTotal.Name = "CPrecioTotal"
        '
        'panelComentarios
        '
        Me.panelComentarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelComentarios.Controls.Add(Me.lblMostrarComentarios)
        Me.panelComentarios.Controls.Add(Me.txtComentarios)
        Me.panelComentarios.Controls.Add(Me.lblMSJ)
        Me.panelComentarios.Controls.Add(Me.btnMostrarComentario)
        Me.panelComentarios.Controls.Add(Me.button6)
        Me.panelComentarios.Location = New System.Drawing.Point(248, 428)
        Me.panelComentarios.Name = "panelComentarios"
        Me.panelComentarios.Size = New System.Drawing.Size(733, 283)
        Me.panelComentarios.TabIndex = 3
        '
        'lblMostrarComentarios
        '
        Me.lblMostrarComentarios.BackColor = System.Drawing.Color.White
        Me.lblMostrarComentarios.Location = New System.Drawing.Point(333, 39)
        Me.lblMostrarComentarios.Name = "lblMostrarComentarios"
        Me.lblMostrarComentarios.Size = New System.Drawing.Size(347, 218)
        Me.lblMostrarComentarios.TabIndex = 4
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(6, 68)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(321, 186)
        Me.txtComentarios.TabIndex = 3
        '
        'lblMSJ
        '
        Me.lblMSJ.BackColor = System.Drawing.Color.White
        Me.lblMSJ.Location = New System.Drawing.Point(6, 34)
        Me.lblMSJ.Name = "lblMSJ"
        Me.lblMSJ.Size = New System.Drawing.Size(263, 31)
        Me.lblMSJ.TabIndex = 2
        '
        'btnMostrarComentario
        '
        Me.btnMostrarComentario.Location = New System.Drawing.Point(542, 10)
        Me.btnMostrarComentario.Name = "btnMostrarComentario"
        Me.btnMostrarComentario.Size = New System.Drawing.Size(152, 23)
        Me.btnMostrarComentario.TabIndex = 1
        Me.btnMostrarComentario.Text = "Mostrar Comentario"
        Me.btnMostrarComentario.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(6, 3)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(263, 30)
        Me.button6.TabIndex = 0
        Me.button6.Text = "Agregar un Comentario sobre la Tienda"
        Me.button6.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(451, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(377, 392)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.Location = New System.Drawing.Point(258, 12)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(95, 23)
        Me.btnCrearCuenta.TabIndex = 9
        Me.btnCrearCuenta.Text = "Crear Cuenta"
        Me.btnCrearCuenta.UseVisualStyleBackColor = True
        '
        'btnIniciarSesión
        '
        Me.btnIniciarSesión.Location = New System.Drawing.Point(258, 41)
        Me.btnIniciarSesión.Name = "btnIniciarSesión"
        Me.btnIniciarSesión.Size = New System.Drawing.Size(95, 23)
        Me.btnIniciarSesión.TabIndex = 10
        Me.btnIniciarSesión.Text = "Iniciar Sesión"
        Me.btnIniciarSesión.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 710)
        Me.Controls.Add(Me.panelVerInstrumentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelVerInstrumentos.ResumeLayout(False)
        Me.PanelMenúLateral.ResumeLayout(False)
        Me.PanelSubMenúPercusión.ResumeLayout(False)
        Me.panelSubMenúCuerdas.ResumeLayout(False)
        CType(Me.dtgCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelComentarios.ResumeLayout(False)
        Me.panelComentarios.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelVerInstrumentos As Panel
    Friend WithEvents PanelMenúLateral As Panel
    Friend WithEvents btnInstrumentosCuerdas As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents panelSubMenúCuerdas As Panel
    Friend WithEvents button5 As Button
    Friend WithEvents button4 As Button
    Friend WithEvents button3 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents button1 As Button
    Private WithEvents btnCerrarForm1 As Button
    Private WithEvents btnTotalCompra As Button
    Private WithEvents dtgCompra As DataGridView
    Private WithEvents CInstrumento As DataGridViewTextBoxColumn
    Private WithEvents CCantidad As DataGridViewTextBoxColumn
    Private WithEvents CPrecioTotal As DataGridViewTextBoxColumn
    Private WithEvents panelComentarios As Panel
    Private WithEvents lblMostrarComentarios As Label
    Private WithEvents txtComentarios As TextBox
    Private WithEvents lblMSJ As Label
    Private WithEvents btnMostrarComentario As Button
    Private WithEvents button6 As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents PanelSubMenúPercusión As Panel
    Friend WithEvents btnInstrumentosPercusión As Button
    Friend WithEvents btnInstrumentosAire As Button
    Friend WithEvents button7 As Button
    Friend WithEvents button8 As Button
    Friend WithEvents button9 As Button
    Friend WithEvents buton10 As Button
    Friend WithEvents button11 As Button
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents btnIniciarSesión As Button
End Class
