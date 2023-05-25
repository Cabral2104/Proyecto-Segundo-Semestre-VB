Friend Class AllPrecios
    'Variables del valor de las guitarras acústicas
    Public Property precioGAMartin As Long = 1500
    Public Property precioGAGibson As Long = 2000
    Public Property precioGATaylor As Long = 2500
    'Variables del valor de las guitarras eléctricas
    Public Property precioGEFender As Long = 4000
    Public Property precioGEIbanez As Long = 4500
    Public Property precioGEGibson As Long = 3500
    'Variables del valor de los bajos eléctricos
    Public Property precioBEYamaha As Long = 5000
    Public Property precioBEFender As Long = 4500
    Public Property precioBERedSub As Long = 3500
    'Variables del valor de las arpas
    Public Property precioAPSelvi As Long = 7000
    Public Property precioAPSelta As Long = 6000
    'Variables del valor de los violines
    Public Property precioVStenorStudent As Long = 8000
    Public Property precioVSinfonie24 As Long = 10000
    'Variables del valor de las baterías acústicas
    Public Property precioBACrush As Long = 10000
    Public Property precioBAYamaha As Long = 13000
    Public Property precioBAMapex As Long = 12000
    Public Property precioBATama As Long = 14000
    'Variables del valor de las baterías eléctricas
    Public Property precioBELYamaha As Long = 14000
    Public Property precioBELRonald As Long = 14500
    'Variables del valor de los timbales
    Public Property precioTAdams32 As Long = 3000
    Public Property precioTMajestic32 As Long = 4000
    'Variables del valor de los triángulos
    Public Property precioTACharls As Long = 500
    Public Property precioTAXO As Long = 400
    'Variables del valor de los bombos
    Public Property precioBAudiotek As Long = 1500
    'Variables del valor de los instrumentos de aire
    Public Property precioATrompeta As Long = 3500
    Public Property precioAXilófono As Long = 3000
    Public Property precioAAcordeón As Long = 2500
    Public Property precioAFlauta As Long = 300
    ' The AllPrecios class contains variables that represent the prices of different
    'instruments.These variables are used in the calculation of the total price of the
    'selected instruments In their respective add To cart events.

    'Calcular Precio Total de cada cosa
    Public Function CalcularprecioGA(cantidad As Integer, precio As Long) As Long
        Return cantidad * precio
    End Function

    Public Function CalcularprecioGE(cantidad As Integer, precio As Long) As Long
        Return cantidad * precio
    End Function

    Public Function CalcularprecioBE(cantidad As Integer, precio As Long) As Long
        Return cantidad * precio
    End Function
    'These methods can be used To calculate the total price Of the instruments In
    'different parts of the code.
End Class

