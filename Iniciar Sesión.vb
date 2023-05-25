Imports System.Data.SqlClient

Partial Public Class Iniciar_Sesión
    Inherits Form
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Usuarios;Integrated Security=True"
    'This code stores a connection string that will be used to connect to a local
    'database called "Usuarios" using the integrated security of the operating system.
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Iniciar_Sesión_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub btnConfirmarIS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirmarIS.Click
        Dim email As String = txbCorreoIS.Text
        Dim contraseña As String = txbContraseñaIS.Text

        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(contraseña) Then
            lblMensajeIS.Text = "Por favor, ingrese su email y contraseña."
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "SELECT COUNT(*) FROM UsuariosPS2 WHERE Correo=@Correo AND Contraseña=@Contraseña"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Correo", email)
                    command.Parameters.AddWithValue("@Contraseña", contraseña)
                    Dim count As Integer = CInt(command.ExecuteScalar())

                    If count > 0 Then
                        lblMensajeIS.Text = "Inicio de sesión exitoso."
                        Dim tienda As New Form1()
                        tienda.Show()
                    Else
                        lblMensajeIS.Text = "Email o contraseña incorrectos."
                    End If
                End Using
            Catch ex As Exception
                lblMensajeIS.Text = "Error al iniciar sesión: " & ex.Message
            End Try
        End If
        'Dim tienda As New Form1()
        'tienda.Show()
    End Sub
    'This code verifies if the entered email and password match the records in the
    'database and displays a corresponding success or error message based on the result.
    'Afterwards, it displays the main form.

    Private Sub btnCerrarIS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerrarIS.Click
        Me.Close()
    End Sub
    'This button automatically closes the program when pressed.
End Class