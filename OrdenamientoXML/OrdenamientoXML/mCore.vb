Imports System.IO
Imports System.Threading

Module mCore
#Region "VARIABLES"
#Region "VARIABLES GENERALES"
    Public G_EmpresaNombre As String = "13 Ponientes analistas"
    Public G_MostrarErrores As Boolean = True
    Public G_ErrorLog As Boolean = False
#End Region
#Region "VARIABLES CORE"
    Public N_Ingreso As Integer
    Public N_Egreso As Integer
    Public N_Traslado As Integer
    Public N_Nomina As Integer
    Public N_Pago As Integer
    Public N_Otro As Integer
    Public N_TotalNuevos As Integer
    Public N_TotalAnalizados As Integer

    Public IdentificadorFolder As String = ""
    Public ListaFolder As List(Of String)

    Public Folder As String = ""
    Public PROCESO_CORE As Thread                'Proceso principal que siempre estará ejecutandose
    Public PROCESO_BUSQUEDA As Thread            'Proceso que almacena la función para buscar archivos
#End Region


#End Region
#Region "FUNCIONES GENERALES"

    Public Sub Msg()
        Msg("<..>", 3)
    End Sub

    ''' <summary>
    ''' Mensaje
    ''' </summary>
    ''' <param name="cadena">cadena</param>
    ''' <param name="tipo">1 INFO| 2 EXCLAMATION | 3 CRITICAL | 4 QUESTION</param>
    Public Sub Msg(ByVal cadena As String, Optional ByVal tipo As Integer = 1)
        Dim icono As Integer
        Select Case tipo
            Case 1
                icono = vbInformation
            Case 2
                icono = vbExclamation
            Case 3
                icono = vbCritical
            Case 4
                icono = vbQuestion
            Case Else
                icono = vbInformation
        End Select
        MsgBox(cadena, icono, G_EmpresaNombre)
    End Sub

    ''' <summary>
    ''' Control de errores
    ''' </summary>
    ''' <param name="ex">ex Exeption</param>
    Public Sub X(ByVal ex As Exception)
        If (G_MostrarErrores) Then
            Msg(ex.StackTrace.ToString, 3)
        End If
        Try
            If G_ErrorLog Then
                Dim fichero As String = "log_Presentacion.txt"
                Dim escritor As StreamWriter

                escritor = File.AppendText(fichero)
                escritor.Write(vbCrLf + "///////////////////////////////////////////////////////////////////////////////////" + vbCrLf)
                escritor.Write(Now.ToString + vbCrLf)
                escritor.Write(ex.Message + vbCrLf)
                escritor.Write(ex.StackTrace + vbCrLf)
                escritor.Write("-------------------------------------------------------------------------------------" + vbCrLf + vbCrLf)
                escritor.Flush()
                escritor.Close()
            End If
        Catch ex2 As Exception
            Msg(ex2.Message, 3)
        End Try

    End Sub
#End Region
#Region "FUNCIONES CORE"

    ''' <summary>
    ''' Inicializa todas las variables
    ''' </summary>
    Public Sub InicializarVariables()
        N_Ingreso = 0
        N_Egreso = 0
        N_Traslado = 0
        N_Nomina = 0
        N_Pago = 0
        N_Otro = 0
        N_TotalNuevos = 0
        N_TotalAnalizados = 0

        ListaFolder = New List(Of String)
        ListaFolder.Add("I")
        ListaFolder.Add("E")
        ListaFolder.Add("T")
        ListaFolder.Add("N")
        ListaFolder.Add("P")

    End Sub

    Public Sub IniciarBusqueda()

        Try
            PROCESO_BUSQUEDA = New Thread(AddressOf Buscararchivos) 'Proceso que buscará archivos
            PROCESO_BUSQUEDA.Start()
        Catch ex As Exception
            X(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Recorre Todos los archivos de una carpeta
    ''' </summary>
    Private Sub Buscararchivos()

        'Documentación
        'https://social.msdn.microsoft.com/Forums/es-ES/56f39dbe-a524-46be-89ef-0fffcaa9706e/problema-con-ruta-de-mas-de-260-caracteres?forum=vbes
        Try
            AnalizarCarpeta("\\?\" & Folder, "\\?\" & Folder) '\\?\  -> Prefijo para solucionar error de path con mas de 250 Caracteres
        Catch ex As Exception
            X(ex)
        End Try

        Try
            PROCESOS_TERMINAR()
        Catch ex As Exception
            X(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Funcion recursiva para recorrer archivos de carpeta
    ''' </summary>
    ''' <param name="sDir"></param>
    ''' <param name="CarpetaRaiz"></param>
    Private Sub AnalizarCarpeta(ByVal sDir As String, ByVal CarpetaRaiz As String)
        Dim d As String
        Dim f As String

        Try
            For Each f In Directory.GetFiles(sDir, "*.*")
                Try
                    If Not DB_FICHEROS_PROCESADOS.Existe(f) Then
                        If ProcesarArchivo(f) Then
                            DB_FICHEROS_PROCESADOS.Insertar(New I_Ficheros_procesados(f))
                        End If
                    End If
                Catch ex As Exception
                    X(ex)
                End Try
            Next
            Try
                For Each d In Directory.GetDirectories(sDir)
                    AnalizarCarpeta(d, CarpetaRaiz)
                Next
            Catch ex As Exception
            End Try
        Catch ex As Exception
            X(ex)
        End Try
    End Sub

    ''' <summary>
    ''' convierte el pdf en texto
    ''' </summary>
    ''' <param name="archivo">Patch</param>
    ''' <returns></returns>
    Public Function ProcesarArchivo(ByVal archivo As String) As Boolean
        Dim ext As String

        'VALIDA LA EXTENCION DEL ARCHIVO
        Try
            ext = Path.GetExtension(archivo)
            If Not ext.ToLower = ".pdf" And Not ext = "" Then
                Return False
            End If
        Catch ex As Exception
            X(ex)
        End Try

        G_Total_ficheros_analizados += 1

        Try
            Dim Cadena As String = ""
            Dim PdfReader = New PdfReader(archivo)
            Dim page As Integer
            Dim indice As Integer = 0

            For page = 1 To PdfReader.NumberOfPages
                Dim currentText = PdfTextExtractor.GetTextFromPage(PdfReader, page, New LocationTextExtractionStrategy())

                currentText = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)))
                Cadena &= currentText
            Next
            PdfReader.Close()

            For Each formato As I_Formato In G_Formatos
                If Cadena.Contains(formato.Cadena) Then
                    G_Total_ficheros_convertidos += 1
                    Return ProcesarFormato(Cadena, G_Formatos(indice), archivo)
                End If
                indice += 1
            Next

            'NO RPOCESADO -------------------------------
            SetNoProcesados(archivo)

        Catch ex As Exception
            X(ex)
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Termina los subprocesos globales abiertos
    ''' </summary>
    Public Sub PROCESOS_TERMINAR()
        On Error Resume Next
        PROCESO_CORE.Abort()
        On Error Resume Next
        PROCESO_CORE.Join()
        'AnalisisInicial()
    End Sub
#End Region

End Module
