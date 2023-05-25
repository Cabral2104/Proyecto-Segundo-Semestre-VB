Partial Public Class Cuerdas2
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    'The statement "DataGridView dtgvGuitarrasAcusticas;" in the Cuerdas2 class indicates
    'that a variable named dtgvGuitarrasAcusticas of type DataGridView has been declared.

    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    'When constructing an instance of the Cuerdas2 class And passing a DataGridView
    'object as an argument to the constructor, that object Is assigned to the instance
    'variable dtgvGuitarrasAcusticas. This allows you to use that control in other methods
    'Or events of the class.
    Private Sub Cuerdas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarCuerdas2_Click(sender As Object, e As EventArgs) Handles btnCerrarCuerdas2.Click
        Me.Close()
    End Sub
    'We instruct the program that when this button Is pressed, the "cuerdas2" form should
    'automatically close.
    Private Sub btnCarritoGE_Click(sender As Object, e As EventArgs) Handles btnCarritoGE.Click
        Dim allPrecios As New AllPrecios()
        Dim GEFender As Integer = CInt(nudGEFender.Value)
        Dim GEIbanez As Integer = CInt(nudGEIbanez.Value)
        Dim GEGibson As Integer = CInt(nudGEGibson.Value)

        Dim GEFenderPrecioTotal As Long = allPrecios.CalcularprecioGE(GEFender, allPrecios.precioGEFender)
        Dim GEIbanezPrecioTotal As Long = allPrecios.CalcularprecioGE(GEIbanez, allPrecios.precioGEIbanez)
        Dim GEGibsonPrecioTotal As Long = allPrecios.CalcularprecioGE(GEGibson, allPrecios.precioGEGibson)

        If GEFender > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("GE Fender", GEFender, GEFenderPrecioTotal)
        End If
        If GEIbanez > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("GE Ibanez", GEIbanez, GEIbanezPrecioTotal)
        End If
        If GEGibson > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("GE Gibson", GEGibson, GEGibsonPrecioTotal)
        End If
        dtgvGuitarrasAcusticas.Visible = True
    End Sub
    'When clicking the button "btnCarritoGE," the quantities of Fender, Ibanez, And
    'Gibson electric guitars selected by the user are obtained. The total price Is
    'calculated for each type of guitar, And a row Is added to the DataGridView control
    'with the corresponding information.
    Private Sub btnCGEFender_Click(sender As Object, e As EventArgs) Handles btnCGEFender.Click
        Dim CGEFender As String() = {"Cuerpo de madera", "Cuerdas Gruesas", "Resistente a caídas y golpes", "Incluye CD de Práctica"}

        MessageBox.Show("La Guitarra Fender tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CGEFender))
    End Sub
    'When clicking the button "btnCGEFender," a message box Is displayed with the
    'characteristics of the Fender guitar.
    Private Sub btnCGEIbanez_Click(sender As Object, e As EventArgs) Handles btnCGEIbanez.Click
        Dim CGEIbanez As String() = {"Cuerpo de madera", "Pintura brillante y duradera", "Excelente Sonido"}

        MessageBox.Show("La Guitarra Ibanez tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CGEIbanez))
    End Sub
    'When clicking the button "btnCGEIbanez," a message box Is displayed with the
    'characteristics of the Ibanez guitar.
    Private Sub btnCGEGibson_Click(sender As Object, e As EventArgs) Handles btnCGEGibson.Click
        Dim CGEGibson As String() = {"Cuerpo de madera", "Cuerdas Resistentes a largo plazo", "Perfecta para empezar a Practicar", "Incluye Amplificador"}

        MessageBox.Show("La Guitarra Gibson tiene las siguientes Características:" & Environment.NewLine & String.Join(Environment.NewLine, CGEGibson))
    End Sub
    'When clicking the button "btnCGEGibson," a message box Is displayed with the
    'characteristics of the Gibson guitar.
End Class
