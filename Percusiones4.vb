Partial Public Class Percusiones4
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'The Percusiones4 class is a form that displays information about percussion
    'instruments and uses a DataGridView object to interact with the data in a tabular
    'form.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'The constructor of Percusiones4 initializes the Percusiones4 form and sets up the
    'DataGridView object to be used by the form in its percussion-related operations.
    Private Sub btnCerrarPercusiones4_Click(sender As Object, e As EventArgs) Handles btnCerrarPercusiones4.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Percusiones4 form will be
    'automatically closed.
    Private Sub btnAddCarritoTriangulo_Click(sender As Object, e As EventArgs) Handles btnAddCarritoTriangulo.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de los Triángulos
        Dim TACharls As Integer = CInt(nudTrianguloCharls.Value)
        Dim TAXO As Integer = CInt(nudTrianguloXO.Value)

        'calculr precio total de cada Arpa
        Dim TACharlsPrecioTotal As Long = allPrecios.CalcularprecioGE(TACharls, allPrecios.precioTACharls)
        Dim TAXOPrecioTotal As Long = allPrecios.CalcularprecioGE(TAXO, allPrecios.precioTAXO)

        If TACharls > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Triángulo Charls", TACharls, TACharlsPrecioTotal)
        End If
        If TAXO > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Triángulo XO", TAXO, TAXOPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub

    Private Sub Percusiones4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'The method adds the selected triangles to the shopping cart, displaying them in the
    'DataGridView with their quantity and total price.
End Class
