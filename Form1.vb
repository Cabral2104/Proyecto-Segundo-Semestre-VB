Imports System.IO
Imports System.Collections.Generic

Public Class Form1

    Private comentarios As New List(Of String)()
    Private archivoComentarios As String = "comentarios.txt"

    Public Sub New()
        InitializeComponent()
        diseñoCharly()
        dtgCompra.Visible = False
        If dtgCompra.Visible = True Then
            btnTotalCompra.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComentarios()

    End Sub

    Private Sub diseñoCharly()
        panelSubMenúCuerdas.Visible = False
        PanelSubMenúPercusión.Visible = False

        ' otras formas de personalizar mi diseño
    End Sub

    Private Sub ocultarSubMenú()
        If panelSubMenúCuerdas.Visible = True Then
            panelSubMenúCuerdas.Visible = False
        End If
        If PanelSubMenúPercusión.Visible = True Then
            PanelSubMenúPercusión.Visible = False
        End If

    End Sub

    Private Sub mostrarSubMenú(SubMenú As Panel)
        If SubMenú.Visible = False Then
            ocultarSubMenú()
            SubMenú.Visible = True
        Else
            SubMenú.Visible = False
        End If
    End Sub

    Private Sub btnInstrumentosCuerdas_Click(sender As Object, e As EventArgs) Handles btnInstrumentosCuerdas.Click
        mostrarSubMenú(panelSubMenúCuerdas)
    End Sub
    ' Dentro de este botón, le indicamos que muestre el submenú de instrumentos de cuerda.

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' código para lo que quiera mostrar en cada botón
        ocultarSubMenú()
        Dim cuerdas1 As New Instrumentos_de_Cuerdas1(dtgCompra)
        cuerdas1.Show()
    End Sub
    ' Le indicamos que cuando se presione el botón "guitarras acústicas", debe ocultar el submenú
    ' y, al mismo tiempo, abrir el formulario "Instrumentos_de_Cuerdas1", pasando el parámetro de
    ' nuestro DataGridView donde queremos que se agreguen los elementos que el usuario desea comprar.

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' código para lo que quiera mostrar en cada botón
        ocultarSubMenú()
        Dim cuerdas2 As New Cuerdas2(dtgCompra)
        cuerdas2.Show()
    End Sub
    ' Seguimos el mismo proceso que antes, cambiando el formulario a mostrar a "cuerdas2" para que
    ' podamos ver las guitarras eléctricas.

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' código para lo que quiera mostrar en cada botón
        ocultarSubMenú()
        Dim cuerdas3 As New Cuerdas3(dtgCompra)
        cuerdas3.Show()
    End Sub
    ' Continuamos siguiendo el mismo camino que antes, pero ahora para mostrar "cuerdas3",
    ' que se utiliza para ver las guitarras bajos eléctricas.

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ' código para lo que quiera mostrar en cada botón
        ocultarSubMenú()
        Dim cuerdas4 As New Cuerdas4(dtgCompra)
        cuerdas4.Show()
    End Sub
    ' Repetimos el proceso para mostrar "cuerdas4" donde se mostrarán las arpas.

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ' código para lo que quiera mostrar en cada botón
        ocultarSubMenú()
        Dim cuerdas5 As New Cuerdas5(dtgCompra)
        cuerdas5.Show()
    End Sub
    ' De la misma manera, lo hacemos con "cuerdas5" para mostrar los violines.

    Private Sub btnInstrumentosPercusión_Click(sender As Object, e As EventArgs) Handles btnInstrumentosPercusión.Click
        mostrarSubMenú(PanelSubMenúPercusión)
    End Sub
    ' We instruct the code that when the click event occurs on the "btnInstrumentosPercusión" button, it should display the "panelSubMenúPercusion" submenu to show all the buttons.

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        ' Code for what you want to display on each button
        ocultarSubMenú()
        Dim percusiones1 As New Percusiones1(dtgCompra)
        percusiones1.Show()
    End Sub
    ' In the same way as we did with the string instrument buttons, now for each button, we will indicate that it opens the respective percussion form. Additionally, when the user adds something to the cart using the button, it will be directly added to the same DataGridView. This will allow us to calculate a total at the end.

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles buton10.Click
        ' Code for what you want to display on each button
        ocultarSubMenú()
        Dim percusiones2 As New Percusiones2(dtgCompra)
        percusiones2.Show()
    End Sub
    ' Here, we instruct it to open the "percusiones2" form to display the corresponding electric drums. If something is added to the cart, it should be added to the total count.

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        ' Code for what you want to display on each button
        ocultarSubMenú()
        Dim percusiones3 As New Percusiones3(dtgCompra)
        percusiones3.Show()
    End Sub
    ' We repeat the procedure from before to display the section for timpani instruments.

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        ' Code for what you want to display on each button
        ocultarSubMenú()
        Dim percusiones4 As New Percusiones4(dtgCompra)
        percusiones4.Show()
    End Sub
    ' In this case, it will now show the section for triangle instruments, following the same process as the previous buttons.

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        ' Code for what you want to display on each button
        ocultarSubMenú()
        Dim percusiones5 As New Percusiones5(dtgCompra)
        percusiones5.Show()
    End Sub
    ' We repeat the process for the last one to display the section for bass drum instruments, and it can be added to the total if desired.

    Private Sub btnInstrumentosAire_Click(sender As Object, e As EventArgs) Handles btnInstrumentosAire.Click
        ocultarSubMenú()
        Dim aire5 As New Aire5(dtgCompra)
        aire5.Show()
    End Sub
    'In this button, we instruct that when the click event occurs, the different panels that
    'have been opened should be hidden, and the "aire5" form should be displayed, where all
    'the different wind instruments that can be purchased are located.

    'Private Sub btnComentarios_Click(sender As Object, e As EventArgs) Handles btnComentarios.Click
    '    panelVerInstrumentos.Visible = True
    '    dtgCompra.Visible = False
    'End Sub

    Private Sub btnMostrarComentario_Click(sender As Object, e As EventArgs) Handles btnMostrarComentario.Click
        lblMostrarComentarios.Text = If(comentarios.Count > 0, String.Join(Environment.NewLine, comentarios), "No hay comentarios.")
    End Sub
    'This method updates the text of the label control "lblMostrarComentarios" with the
    'comments stored in the "comentarios" list, displaying the comments on separate lines.
    'If there are no comments in the list, the message "No hay comentarios." (No comments) is displayed.

    Private Sub CargarComentarios()
        If File.Exists(archivoComentarios) Then
            comentarios = File.ReadAllLines(archivoComentarios).ToList()
        End If
    End Sub
    'This method checks if the comments file exists, and if it does, it loads the comments
    'from the file into the "comentarios" list. This allows reading previously stored comments
    'and making them available in the list for future use.

    Private Sub GuardarComentarios()
        File.WriteAllLines(archivoComentarios, comentarios)
    End Sub
    'This method saves the comments stored in the "comentarios" list to a text file. Each
    'comment is saved as a separate line in the file.

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim comentario As String = txtComentarios.Text
        If String.IsNullOrWhiteSpace(comentario) Then
            lblMSJ.Text = "Comentario inválido. Por favor, escribe algo."
        Else
            comentarios.Add(comentario)
            GuardarComentarios()
            txtComentarios.Clear()
            lblMSJ.Text = "Comentario guardado correctamente."
        End If
    End Sub
    'This method retrieves the text from the "txtComentarios" text box control and adds it as
    'a new comment to the "comentarios" list. Then, it saves the comments to a text file and
    'displays a success message in the "lblMSJ" label control. If the entered comment is not
    'valid, an error message is displayed.

    Private Sub btnTotalCompra_Click(sender As Object, e As EventArgs) Handles btnTotalCompra.Click
        Dim sumaTotal As Integer = 0
        For Each fila As DataGridViewRow In dtgCompra.Rows
            If Not fila.IsNewRow Then
                Dim valorCelda As Integer = Convert.ToInt32(fila.Cells("CPrecioTotal").Value)
                sumaTotal += valorCelda
            End If
        Next

        MessageBox.Show("La suma total es: " + sumaTotal.ToString())
    End Sub
    'This method iterates through the rows of a DataGridView and adds up the values of a specific
    'column (total price). Then, it displays the result of the total sum in a message box.
    'Make sure to adjust the column name and behavior according to your specific needs.

    Private Sub btnCerrarForm1_Click(sender As Object, e As EventArgs) Handles btnCerrarForm1.Click
        Me.Close()
    End Sub

    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click
        Dim crearcuenta As New Crear_cuenta()
        Crear_cuenta.Show()
    End Sub

    Private Sub btnIniciarSesión_Click(sender As Object, e As EventArgs) Handles btnIniciarSesión.Click
        Dim iniciarsesion As New Iniciar_Sesión()
        Iniciar_Sesión.Show()
    End Sub
End Class
