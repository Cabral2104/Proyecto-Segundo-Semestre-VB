Partial Public Class Cuerdas4
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'The code shown so far only declares the Cuerdas4 class and the
    'dtgvGuitarrasAcusticas field, but it does not show its complete implementation.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'The constructor of Cuerdas4 allows assigning a DataGridView object to the instance
    'of the class, which is useful for accessing and manipulating the data displayed in
    'the table from the methods and events of the class.
    Private Sub Cuerdas4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarCuerdas4_Click(sender As Object, e As EventArgs) Handles btnCerrarCuerdas4.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Cuerdas4 form will be
    'automatically closed.
    Private Sub btnAddCarritoArpa_Click(sender As Object, e As EventArgs) Handles btnAddCarritoArpa.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de Arpas
        Dim APSelvi As Integer = CInt(nudArpaSelvi.Value)
        Dim APSelta As Integer = CInt(nudArpaSelta.Value)

        'calculr precio total de cada Arpa
        Dim APSelviPrecioTotal As Long = allPrecios.CalcularprecioGE(APSelvi, allPrecios.precioAPSelvi)
        Dim APSeltaPrecioTotal As Long = allPrecios.CalcularprecioGE(APSelta, allPrecios.precioAPSelta)

        If APSelvi > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("AP Selvi", APSelvi, APSelviPrecioTotal)
        End If
        If APSelta > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("AP Selta", APSelta, APSeltaPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub
    'This method is responsible for adding the selected harps to the shopping cart,
    'displaying the corresponding information in the dtgvGuitarrasAcusticas DataGridView.
    Private Sub btnCASelvi_Click(sender As Object, e As EventArgs) Handles btnCASelvi.Click
        ' Declarar el arreglo de caracteristicas del Arpa Selvi
        Dim CASelvi As String() = {"Pintura con el Acabado que buscas", "Cuerdas de Buena cálidad", "Gran dispersión de Sónido del Instrumento"}

        ' Mostrar las Caracteristicas del Arpa Selvi en un MessageBox
        MessageBox.Show("El Arpa Selvi tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CASelvi))
    End Sub
    'This method displays the characteristics of the Selvi harp in a MessageBox when the
    '"Ver Características" button is clicked.
    Private Sub btnCASelta_Click(sender As Object, e As EventArgs) Handles btnCASelta.Click
        ' Declarar el arreglo de caracteristicas del Arpa Selta
        Dim CASelta As String() = {"Acabado en madera natural", "La más resistente del mercado", "La mejor para conocer el instrumento"}

        ' Mostrar las Caracteristicas del Arpa Selta en un MessageBox
        MessageBox.Show("El Arpa Selta tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CASelta))
    End Sub
    'This method displays the characteristics of the Selta harp in a MessageBox when the
    '"Ver Características" button is clicked.
End Class
