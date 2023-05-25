Imports System
Imports System.Windows.Forms

Namespace proyecto_2_semestre_vb
    Friend Module Program
        ''' <summary>
        ''' Punto de entrada principal para la aplicación.
        ''' </summary>
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Iniciar Sesión())
        End Sub
    End Module
End Namespace
