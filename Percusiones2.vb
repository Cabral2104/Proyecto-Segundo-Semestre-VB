Partial Public Class Percusiones2
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'Percusiones2 is a form that displays percussion data in a DataGridView and uses the
    'dtgvGuitarrasAcusticas object to interact with the control from different methods.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'This constructor initializes the percussion form and sets the DataGridView object
    'that will be used to display and manipulate percussion data in the form.
    Private Sub btnCerrarPercusiones2_Click(sender As Object, e As EventArgs) Handles btnCerrarPercusiones2.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Percusiones2 form will be
    'automatically closed.
    Private Sub btnAddCarritoBEL_Click(sender As Object, e As EventArgs) Handles btnAddCarritoBEL.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de las Baterias Eléctricas
        Dim BELYamaha As Integer = CInt(nudBEYamaha.Value)
        Dim BELRonald As Integer = CInt(nudBERonald.Value)

        'calculr precio total de cada Arpa
        Dim BELYamahaPrecioTotal As Long = allPrecios.CalcularprecioGE(BELYamaha, allPrecios.precioBELYamaha)
        Dim BELRonaldPrecioTotal As Long = allPrecios.CalcularprecioGE(BELRonald, allPrecios.precioBELRonald)

        If BELYamaha > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BEL Yamaha", BELYamaha, BELYamahaPrecioTotal)
        End If
        If BELRonald > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BEL Ronald", BELRonald, BELRonaldPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub

    Private Sub Percusiones2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'This method is responsible for adding the selected electric drums to the shopping
    'cart, calculating the total price, and displaying the information in the DataGridView.
End Class
