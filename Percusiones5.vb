Partial Public Class Percusiones5
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'This class represents a percussion form and uses a DataGridView to display and
    'manipulate data related to the percussions in the application.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'This constructor creates an instance of the Percusiones5 form and sets up the
    'associated DataGridView object, enabling interaction with that object from the form.
    Private Sub btnCerrarPercusiones5_Click(sender As Object, e As EventArgs) Handles btnCerrarPercusiones5.Click
        Me.Close()
    End Sub
    'This method indicates that when the button is clicked, the Percusiones5 form will be
    'automatically closed.
    Private Sub btnAddCarritoBombo_Click(sender As Object, e As EventArgs) Handles btnAddCarritoBombo.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()
        'obtener cantidad de numericdown de los Triángulos
        Dim BAudiotek As Integer = CInt(nudBomboAudiotek.Value)

        'calculr precio total de cada Arpa
        Dim BAudiotekPrecioTotal As Long = allPrecios.CalcularprecioGE(BAudiotek, allPrecios.precioBAudiotek)

        If BAudiotek > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("Bombo Audiotek", BAudiotek, BAudiotekPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub

    Private Sub Percusiones5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'This event handler adds the Audiotek bass drum to the shopping cart if at least one
    'unit has been selected, calculates the total price, and displays the information
    'in the DataGridView.
End Class
