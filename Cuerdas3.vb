Partial Public Class Cuerdas3
    Inherits Form

    Private dtgvGuitarrasAcusticas As DataGridView
    ' The dtgvGuitarrasAcusticas object is used to display information related to electric bass guitars in some type of graphical interface.

    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dtgvGuitarrasAcusticas = dataGridView
    End Sub
    ' The Cuerdas3 constructor is used to initialize an instance of the Cuerdas3 class and assign the provided DataGridView object to the dtgvGuitarrasAcusticas object of the class. This allows the use and manipulation of the DataGridView object in other methods and events of the Cuerdas3 class.

    Private Sub Cuerdas3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarCuerdas3_Click(sender As Object, e As EventArgs) Handles btnCerrarCuerdas3.Click
        Me.Close()
    End Sub
    ' This method indicates that when the button is clicked, the Cuerdas3 form will be automatically closed.

    Private Sub btnCarritoBE_Click(sender As Object, e As EventArgs) Handles btnCarritoBE.Click
        Dim allPrecios As New AllPrecios()
        ' Create an instance of the AllPrecios class.

        Dim BEYamaha As Integer = CInt(nudBEYamaha.Value)
        Dim BEFender As Integer = CInt(nudBEFender.Value)
        Dim BERedSub As Integer = CInt(nudBERedSub.Value)
        ' Get the quantities from the NumericUpDown controls for the electric bass guitars.

        Dim BEYamahaPrecioTotal As Long = allPrecios.CalcularprecioBE(BEYamaha, allPrecios.precioBEYamaha)
        Dim BEFenderPrecioTotal As Long = allPrecios.CalcularprecioBE(BEFender, allPrecios.precioBEFender)
        Dim BERedSubPrecioTotal As Long = allPrecios.CalcularprecioBE(BERedSub, allPrecios.precioBERedSub)
        ' Calculate the total prices for each electric bass guitar.

        If BEYamaha > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BE Yamaha", BEYamaha, BEYamahaPrecioTotal)
        End If

        If BEFender > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BE Fender", BEFender, BEFenderPrecioTotal)
        End If

        If BERedSub > 0 Then
            dtgvGuitarrasAcusticas.Rows.Add("BE Red Sub", BERedSub, BERedSubPrecioTotal)
        End If
        ' Add the corresponding rows to the DataGridView to display the information of the selected electric bass guitars and their total prices.
        dtgvGuitarrasAcusticas.Visible = True
    End Sub

    Private Sub btnCBEYamaha_Click(sender As Object, e As EventArgs) Handles btnCBEYamaha.Click
        Dim CBEYamaha As String() = {"Wooden body", "Thick strings", "High-quality paint"}
        ' Declare the array of characteristics for the Yamaha electric bass guitar.

        MessageBox.Show("The Yamaha Electric Bass Guitar has the following characteristics:" & Environment.NewLine & String.Join(Environment.NewLine, CBEYamaha))
        ' Display the characteristics of the Yamaha electric bass guitar in a MessageBox.
    End Sub

    Private Sub btnCBEFender_Click(sender As Object, e As EventArgs) Handles btnCBEFender.Click
        Dim CBEFender As String() = {"Shiny and glossy paint", "Best audio quality in the market", "Includes 3 picks"}
        ' Declare the array of characteristics for the Fender electric bass guitar.

        MessageBox.Show("The Fender Electric Bass Guitar has the following characteristics:" & Environment.NewLine & String.Join(Environment.NewLine, CBEFender))
        ' Display the characteristics of the Fender electric bass guitar in a MessageBox.
    End Sub

    Private Sub btnCBERedSub_Click(sender As Object, e As EventArgs) Handles btnCBERedSub.Click
        Dim CBERedSub As String() = {"Wooden body", "Perfect color combination", "Excellent surround sound system"}
        ' Declare the array of characteristics for the RedSub electric bass guitar.

        MessageBox.Show("The RedSub Electric Bass Guitar has the following characteristics:" & Environment.NewLine & String.Join(Environment.NewLine, CBERedSub))
        ' Display the characteristics of the RedSub electric bass guitar in a MessageBox.
    End Sub
End Class
