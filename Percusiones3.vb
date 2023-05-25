Partial Public Class Percusiones3
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'The class Percusiones3 represents a user interface form that is designed to display
    'and allow manipulation of percussion data in a DataGridView. The DataGridView object
    'is used to store and display the data in a tabular form.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'This constructor is responsible for initializing an instance of the Percusiones3
    'class and assigning the provided DataGridView object to the dtgvGuitarrasAcusticas
    'field for further use in manipulating percussion data in the form.
    Private Sub btnCerrarPercusiones3_Click(sender As Object, e As EventArgs) Handles btnCerrarPercusiones3.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Percusiones3 form will be
    'automatically closed.
    Private Sub btnAddCarritoTimbal_Click(sender As Object, e As EventArgs) Handles btnAddCarritoTimbal.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de las Baterias Eléctricas
        Dim TAdams32 As Integer = CInt(nudTimbalAdams32.Value)
        Dim TMajestic32 As Integer = CInt(nudTimbalMajestic32.Value)

        'calculr precio total de cada Arpa
        Dim TAdams32PrecioTotal As Long = allPrecios.CalcularprecioGE(TAdams32, allPrecios.precioTAdams32)
        Dim TMajestic32PrecioTotal As Long = allPrecios.CalcularprecioGE(TMajestic32, allPrecios.precioTMajestic32)

        If TAdams32 > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Timbal Adams32", TAdams32, TAdams32PrecioTotal)
        End If
        If TMajestic32 > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Timbal Majestic32", TMajestic32, TMajestic32PrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub

    Private Sub Percusiones3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'This event is responsible for adding the selected timpani to the shopping cart,
    'calculating the total price for each type, and displaying the information in the
    'DataGridView.
End Class
