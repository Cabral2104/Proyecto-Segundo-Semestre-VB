Partial Public Class Aire5
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'The class Aire5 represents a form related to "Aire" and uses a DataGridView to
    'display and manipulate tabular data within it. The variable dtgvGuitarrasAcusticas
    'is used to store a reference to the DataGridView provided through the class
    'constructor.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'The Aire5 constructor is responsible for initializing the form and assigning the
    'provided DataGridView to the dtgvGuitarrasAcusticas variable, allowing it to be
    'accessed and manipulated within the context of the Aire5 class.
    Private Sub btnCerrarAire5_Click(sender As Object, e As EventArgs) Handles btnCerrarAire5.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Aire5 form will be
    'automatically closed.
    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub btnAddCarritoIA_Click(sender As Object, e As EventArgs) Handles btnAddCarritoIA.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de los Triángulos
        Dim ATrompeta As Integer = CInt(nudTrompeta.Value)
        Dim AXilófono As Integer = CInt(nudXilófono.Value)
        Dim AAcordeón As Integer = CInt(nudAcordeón.Value)
        Dim AFlauta As Integer = CInt(nudFlauta.Value)

        'calculr precio total de cada Arpa
        Dim ATrompetaPrecioTotal As Long = allPrecios.CalcularprecioGE(ATrompeta, allPrecios.precioATrompeta)
        Dim AXilófonoPrecioTotal As Long = allPrecios.CalcularprecioGE(AXilófono, allPrecios.precioAXilófono)
        Dim AAcordeónPrecioTotal As Long = allPrecios.CalcularprecioGE(AAcordeón, allPrecios.precioAAcordeón)
        Dim AFlautaPrecioTotal As Long = allPrecios.CalcularprecioGE(AFlauta, allPrecios.precioAFlauta)

        If ATrompeta > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Trompeta", ATrompeta, ATrompetaPrecioTotal)
        End If
        If AXilófono > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Xilófono", AXilófono, AXilófonoPrecioTotal)
        End If
        If AAcordeón > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Acordeón", AAcordeón, AAcordeónPrecioTotal)
        End If
        If AFlauta > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Flauta", AFlauta, AFlautaPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub

    Private Sub Aire5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'The btnAddCarritoIA_Click event calculates the total price of the selected air
    'instruments and adds them to the shopping cart in the DataGridView.
End Class
