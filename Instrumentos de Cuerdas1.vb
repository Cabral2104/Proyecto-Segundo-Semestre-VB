Public Class Instrumentos_de_Cuerdas1
    Private dtgvGuitarrasAcusticas As DataGridView

    'Declare a variable of type DataGridView named dtgvGuitarrasAcusticas.
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()

        dtgvGuitarrasAcusticas = dataGridView
    End Sub

    'This constructor is used to create an instance of the Instrumentos_de_Cuerdas1 class
    'and assign a specified DataGridView object to the dtgvGuitarrasAcusticas field.
    'This allows the Instrumentos_de_Cuerdas1 class to work with the dataGridView object
    'and perform operations on it, such as displaying data or performing specific
    'manipulations related to string instruments.

    Private Sub button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'When this button is pressed, the current form automatically closes.

    Private Sub Instrumentos_de_Cuerdas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCerrarCuerdas1_Click(sender As Object, e As EventArgs) Handles btnCerrarCuerdas1.Click
        Me.Close()
    End Sub

    'When this button is pressed, the current form automatically closes.

    Protected Sub btnAddCarritoGA_Click(sender As Object, e As EventArgs) Handles btnAddCarritoGA.Click
        'crear instancia de la clase AllPrecios
        Dim allPrecios As New AllPrecios()

        'obtener cantidad de numericdown de Guitarras Acusticas
        Dim GAMartin As Integer = CInt(nudGAMartin.Value)
        Dim GAGibson As Integer = CInt(nudGAGibson.Value)
        Dim GATaylor As Integer = CInt(nudGATaylor.Value)

        'calculr precio total de cada GA
        Dim GAMartinPrecioTotal As Long = allPrecios.CalcularprecioGA(GAMartin, allPrecios.precioGAMartin)
        Dim GAGibsonPrecioTotal As Long = allPrecios.CalcularprecioGA(GAGibson, allPrecios.precioGAGibson)
        Dim GATaylorPrecioTotal As Long = allPrecios.CalcularprecioGA(GATaylor, allPrecios.precioGATaylor)

        If GAMartin > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("GA Martin", GAMartin, GAMartinPrecioTotal)
        End If

        If GAGibson > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("GA Gibson", GAGibson, GAGibsonPrecioTotal)
        End If

        If GATaylor > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("GA Taylor", GATaylor, GATaylorPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True

    End Sub

    'This method is used to add rows to the DataGridView control dtgvGuitarrasAcusticas
    'with information about the acoustic guitars selected by the user and their calculated
    'total prices. Depending on the selected quantities, rows corresponding to the Martin,
    'Gibson, and Taylor acoustic guitar types are added.

    Private Sub btnVCGAMartin_Click(sender As Object, e As EventArgs) Handles btnVCGAMartin.Click
        ' Declarar el arreglo de caracteristicas de la guitarra Martin
        Dim CGAMartin As String() = {"Cuerpo de madera", "Cuerdas resistentes", "Durabilidad de afinación", "Incluye 2 puas"}

        ' Mostrar las Caracteristicas de la Guitarra Martin en un MessageBox
        MessageBox.Show("La Guitarra Martin tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CGAMartin))
    End Sub

    'When clicking the button "btnVCGAMartin," a message box is displayed listing the
    'features of the Martin guitar stored in the CGAMartin array. This allows the user to
    'obtain information about the characteristics of that particular type of guitar.

    Private Sub btnVCGAGibson_Click(sender As Object, e As EventArgs) Handles btnVCGAGibson.Click
        ' Declarar el arreglo de caracteristicas de la guitarra Gibson
        Dim CGAGibson As String() = {"Cuerpo de madera", "Cuerdas con alta Durabilidad", "Fácilidad de uso", "Incluye afinador"}

        ' Mostrar las Caracteristicas de la Guitarra Gibson en un MessageBox
        MessageBox.Show("La Guitarra Gibson tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CGAGibson))
    End Sub

    'When clicking the button "btnVCGAGibson," a message box is displayed listing the
    'features of the Gibson guitar stored in the CGAGibson array. This allows the user to
    'obtain information about the characteristics of that particular type of guitar.

    Private Sub btnVGATaylor_Click(sender As Object, e As EventArgs) Handles btnVGATaylor.Click
        ' Declarar el arreglo de caracteristicas de la guitarra Taylor
        Dim CGATaylor As String() = {"Cuerpo de madera", "Peso ligero", "Fácilidad de uso", "Incluye Curso para Aprender Acordes"}

        ' Mostrar las Caracteristicas de la Guitarra Taylor en un MessageBox
        MessageBox.Show("La Guitarra Taylor tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CGATaylor))
    End Sub



    'When clicking the button "btnVGATaylor," a message box is displayed listing the
    'features of the Taylor guitar stored in the CGATaylor array. This allows the user to
    'obtain information about the characteristics of that particular type of guitar.
End Class

