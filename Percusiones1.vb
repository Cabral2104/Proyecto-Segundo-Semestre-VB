Partial Public Class Percusiones1
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'The purpose of this instance is to display and manipulate tabular data in the form
    'of a table within the form.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'This constructor allows setting the reference to a DataGridView object in the
    'Percusiones1 class, which can be useful for performing operations on the
    'DataGridView from other methods in the class.
    Private Sub btnCerrarPercusiones1_Click(sender As Object, e As EventArgs) Handles btnCerrarPercusiones1.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Percusiones1 form will be
    'automatically closed.
    Private Sub Percusiones1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddCarritoBA_Click(sender As Object, e As EventArgs) Handles btnAddCarritoBA.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de las Baterias Acusticas
        Dim BACrush As Integer = CInt(nudBACrush.Value)
        Dim BAYamaha As Integer = CInt(nudBAYamaha.Value)
        Dim BAMapex As Integer = CInt(nudBAMapex.Value)
        Dim BATama As Integer = CInt(nudBATama.Value)

        'calculr precio total de cada Arpa
        Dim BACrushPrecioTotal As Long = allPrecios.CalcularprecioGE(BACrush, allPrecios.precioBACrush)
        Dim BAYamahaPrecioTotal As Long = allPrecios.CalcularprecioGE(BAYamaha, allPrecios.precioBAYamaha)
        Dim BAMapexPrecioTotal As Long = allPrecios.CalcularprecioGE(BAMapex, allPrecios.precioBAMapex)
        Dim BATamaPrecioTotal As Long = allPrecios.CalcularprecioGE(BATama, allPrecios.precioBATama)

        If BACrush > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BA Crush", BACrush, BACrushPrecioTotal)
        End If
        If BAYamaha > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BA Yamaha", BAYamaha, BAYamahaPrecioTotal)
        End If
        If BAMapex > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BA Mapex", BAMapex, BAMapexPrecioTotal)
        End If
        If BATama > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BA Tama", BATama, BATamaPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub
    'This method adds the selected Acoustic Drums to the shopping cart, displaying the
    'name, quantity, and total price in the DataGridView.
End Class
