Partial Public Class Cuerdas5
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'In the Cuerdas5 class, a variable dtgvGuitarrasAcusticas of type DataGridView is
    'declared. This variable is used to store a reference to the DataGridView control
    'that displays the product details in the form.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'This constructor initializes the visual components of the form and assigns the
    'dataGridView object to the dtgvGuitarrasAcusticas field. This allows access and
    'manipulation of the DataGridView from other methods in the class.
    Private Sub Cuerdas5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarCuerdas5_Click(sender As Object, e As EventArgs) Handles btnCerrarCuerdas5.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Cuerdas5 form will be
    'automatically closed.


    Private Sub btnAddCarritoViolonchelos_Click(sender As Object, e As EventArgs) Handles btnAddCarritoViolonchelos.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de Violonchelos
        Dim VStenor As Integer = CInt(nudVStentor.Value)
        Dim VSinfonie24 As Integer = CInt(nudSinfonie24.Value)

        'calculr precio total de cada Arpa
        Dim VStenorPrecioTotal As Long = allPrecios.CalcularprecioGE(VStenor, allPrecios.precioVStenorStudent)
        Dim VSinfonie24PrecioTotal As Long = allPrecios.CalcularprecioGE(VSinfonie24, allPrecios.precioVSinfonie24)

        If VStenor > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("V Stenor Student II", VStenor, VStenorPrecioTotal)
        End If
        If VSinfonie24 > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("V Sinfonie24 Basic II", VSinfonie24, VSinfonie24PrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub
    'This code handles the logic to add the selected cellos to the shopping cart
    'represented by the DataGridView.
    Private Sub btnVCVStenor_Click(sender As Object, e As EventArgs) Handles btnVCVStenor.Click
        ' Declarar el arreglo de caracteristicas del Violonchelo Stenor
        Dim CVStenor As String() = {"Cuerdas duraderas", "Buen Sónido"}

        ' Mostrar las Caracteristicas del Violonchelo Stenor en un MessageBox
        MessageBox.Show("El Violonchelo Stenor tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CVStenor))
    End Sub
    'This code displays the characteristics of the Stenor cello in a MessageBox when the
    'corresponding button is clicked.
    Private Sub btnVCVSinfonie24_Click(sender As Object, e As EventArgs) Handles btnVCVSinfonie24.Click
        ' Declarar el arreglo de caracteristicas del Violonchelo Stenor
        Dim CVSinfonie24 As String() = {"Cuerdas duraderas", "Buen Sónido", "Diseño Amigable", "Excelente pra aprender a tocar el Violonchelo"}

        ' Mostrar las Caracteristicas del Violonchelo Sinfonie24 en un MessageBox
        MessageBox.Show("El Violonchelo Sinfonie24 tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CVSinfonie24))
    End Sub
    'This code displays the characteristics of the Sinfonie24 cello in a MessageBox when
    'the corresponding button is clicked.
End Class
