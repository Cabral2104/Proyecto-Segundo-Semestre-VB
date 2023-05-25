Imports System.Data.SqlClient

Partial Public Class Crear_cuenta
    Inherits Form
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Usuarios;Integrated Security=True"
    'This code stores a connection string that will be used to connect to a local
    'database called "Usuarios" using the integrated security of the operating system.
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Crear_cuenta_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub btnConfirmarCC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirmarCC.Click
        Dim nombre As String = txbUsuarioCC.Text
        Dim email As String = txbCorreoCC.Text
        Dim contraseña As String = txbContraseñaCC.Text
        Dim confirmarcontraseña As String = txbConfirmarContraseñaCC.Text

        If contraseña = confirmarcontraseña Then
            If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(contraseña) Then
                lblMensajeCC.Text = "Por favor, complete todos los campos."
            Else
                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        Dim query As String = "INSERT INTO UsuariosPS2 (Usuario, Correo, Contraseña) VALUES (@Usuario, @Correo, @Contraseña)"
                        Dim command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Usuario", nombre)
                        command.Parameters.AddWithValue("@Correo", email)
                        command.Parameters.AddWithValue("@Contraseña", contraseña)
                        command.ExecuteNonQuery()

                        lblMensajeCC.Text = "Registro exitoso."
                        Dim tienda As New Form1()
                        tienda.Show()

                        ' Limpia los campos del formulario después del registro exitoso
                        txbUsuarioCC.Text = ""
                        txbCorreoCC.Text = ""
                        txbContraseñaCC.Text = ""
                    End Using
                Catch ex As Exception
                    lblMensajeCC.Text = "Error al registrar: " & ex.Message
                End Try
            End If
            'Dim tienda As New Form1()
            'tienda.Show()
        Else
            MessageBox.Show("Las Contraseñas no coinciden")
        End If
    End Sub
    'This code performs the insertion of a new user into a database, verifying that the
    'fields are filled out and that the passwords match before performing the insertion.

    Private Sub btnCerrarCC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerrarCC.Click
        Me.Close()
    End Sub
    'This button automatically closes the program when pressed.

    Private Sub btnIniciarSesión_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnIniciarSesión.Click
        Dim iniciarsesion As New Iniciar_Sesión()
        iniciarsesion.Show()
    End Sub
    'This button opens the login form if the client already has a previously registered
    'account.
End Class