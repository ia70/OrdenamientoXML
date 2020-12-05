Imports System.IO
Imports System.Threading
Imports Newtonsoft.Json

Module mCore
#Region "VARIABLES"
#Region "VARIABLES GENERALES"
    Public G_EmpresaNombre As String = "13 Ponientes analistas"
    Public G_MostrarErrores As Boolean = True
    Public G_ErrorLog As Boolean = False
    Public G_TiposJSON As String = "tipos.json"

#End Region
#Region "VARIABLES CORE"
    Public N_TotalNuevos As Integer
    Public N_TotalAnalizados As Integer

    Public Tipos As I_Tipos

    Public ProcesoActivo As Boolean = False
    Public Folder As String = ""
    Public PROCESO_CORE As Thread                'Proceso principal que siempre estará ejecutandose
    Public PROCESO_BUSQUEDA As Thread            'Proceso que almacena la función para buscar archivos
#End Region


#End Region
#Region "FUNCIONES GENERALES"

    ''' <summary>
    ''' Inicializa todas las variables
    ''' </summary>
    Public Sub InicializarVariables()
        N_TotalNuevos = 0
        N_TotalAnalizados = 0

        leerTipos()
    End Sub

    ''' <summary>
    ''' Lee los tipos JSON o escribe el JSON
    ''' </summary>
    Public Sub leerTipos()
        Dim texto As String = ""

        Try
            If File.Exists(G_TiposJSON) Then
                Try
                    Dim sr As New StreamReader(G_TiposJSON)
                    texto = sr.ReadToEnd()
                    sr.Close()
                Catch ex As Exception
                    X(ex)
                End Try

                If texto.Length > 0 Then
                    Tipos = textToObj(texto)
                End If
            Else
                texto = objToText(Tipos)
                crearTipos(texto)
                Tipos = New I_Tipos
            End If
        Catch ex As Exception
            X(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Devuelve un objeto generado desde una cadena
    ''' </summary>
    ''' <param name="cadena">Objeto en cadena</param>
    ''' <returns></returns>
    Public Function textToObj(ByVal cadena As String) As I_Tipos
        Try
            Return JsonConvert.DeserializeObject(Of I_Tipos)(cadena)
        Catch ex As Exception
            X(ex)
            Return New I_Tipos
        End Try
    End Function

    ''' <summary>
    ''' Devuelve el texto de un objeto.
    ''' </summary>
    ''' <param name="obj">Objeto a convertir</param>
    ''' <returns></returns>
    Public Function objToText(ByVal obj As I_Tipos) As String
        Dim texto As String

        Try
            If obj Is Nothing Then
                obj = New I_Tipos
            End If
        Catch ex As Exception
            X(ex)
        End Try

        Try
            texto = JsonConvert.SerializeObject(obj)
            Return texto
        Catch ex As Exception
            X(ex)
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Elimina el fichero (G_TiposJSON) -> tipos.json
    ''' </summary>
    Public Sub eliminarTipos()
        Try
            If File.Exists(G_TiposJSON) Then
                My.Computer.FileSystem.DeleteFile(G_TiposJSON)
            End If
        Catch ex As Exception
            X(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Crear el fichero G_TiposJSON -> tipos.json
    ''' </summary>
    ''' <param name="cadena">Objeto en cadena</param>
    Public Sub crearTipos(ByVal cadena As String)
        Dim escritor As StreamWriter

        eliminarTipos()
        Thread.Sleep(500)

        Try
            escritor = New StreamWriter(G_TiposJSON, False)
            escritor.WriteLine(cadena)
            escritor.Close()
        Catch ex As Exception
        End Try

    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////
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
        Dim aux As String
        Dim procesar As Boolean

        Try
            For Each f In Directory.GetFiles(sDir, "*.xml")
                procesar = True
                aux = ""
                Try
                    aux = GetFolderNombre(f)



                    For Each linea As I_Tipo In Tipos.Tipos
                        If linea.Id = aux Then
                            procesar = False
                            Exit For
                        End If
                    Next

                    If procesar Then
                        N_TotalNuevos += 1
                        ProcesarArchivo(f)
                    Else
                        N_TotalAnalizados += 1
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

    Public Function GetFolderNombre(ByVal cadena As String) As String
        Dim aux As String
        Dim aux2 As String

        Try
            aux = Path.GetDirectoryName(cadena)
            aux2 = Path.GetDirectoryName(aux)
            cadena = aux
            cadena = aux.Substring(aux2.Length + 1)

            Return cadena
        Catch ex As Exception
            X(ex)
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' convierte el pdf en texto
    ''' </summary>
    ''' <param name="archivo">Patch</param>
    ''' <returns></returns>
    Public Function ProcesarArchivo(ByVal archivo As String) As Boolean
        Dim texto As String = ""
        Dim tipoComprobante As String
        Dim carpetaOrigen As String
        Dim carpetaDestino As String
        Dim nombreArchivo As String
        Dim archivoDestino As String

        Try
            Dim sr As New StreamReader(archivo)
            texto = sr.ReadToEnd()
            sr.Close()

            'CALCULOS -----------------------------------
            tipoComprobante = GetTipoComprobante(texto)

            If tipoComprobante.Length > 0 Then
                'Carpeta origen
                carpetaOrigen = Path.GetDirectoryName(archivo)
                'Carpeta destino 
                carpetaDestino = Path.Combine(carpetaOrigen, tipoComprobante)
                'Nombre archivo
                nombreArchivo = Path.GetFileName(archivo)

                archivoDestino = Path.Combine(carpetaDestino, nombreArchivo)

                'Secrea la carpeta si no existe
                Directory.CreateDirectory(carpetaDestino)
                'Se mueve el archivo
                File.Move(archivo, archivoDestino)
            End If
            Return True
        Catch ex As Exception
            X(ex)
        End Try

        Return False
    End Function

    Public Function GetTipoComprobante(ByVal cadena As String) As String
        Dim ini As String = "TipoDeComprobante=" + ChrW(34)
        Dim fin As String = ChrW(34)
        Dim i As Integer

        Try
            i = cadena.IndexOf(ini)
            If i >= 0 Then
                cadena = cadena.Substring(i + ini.Length)
                i = cadena.IndexOf(fin)
                If i >= 0 Then
                    cadena = cadena.Substring(0, i)
                    'SE VERIFICA SI ES COMPROBANTE NUEVO
                    If verificarTipoComprobante(cadena) Then
                        Return cadena
                    End If
                End If
            End If
        Catch ex As Exception
            X(ex)
        End Try

        Return ""
    End Function

    Public Function verificarTipoComprobante(ByVal tipo As String) As Boolean
        Dim existe As Boolean = False
        Dim indice As Integer

        If Tipos.Tipos.Count > 0 Then
            indice = 0
            Try
                For Each linea As I_Tipo In Tipos.Tipos
                    If linea.Id = tipo Then
                        existe = True
                        'SUMA 1 AL TIPO DE COMPROBANTE --------------
                        Tipos.Tipos(indice).Total += 1
                        Exit For
                    End If
                    indice += 1
                Next

                If existe Then
                    Return True
                Else
                    Return agregarTipoComprobante(tipo)
                End If

            Catch ex As Exception
            End Try
        Else
            Return agregarTipoComprobante(tipo)
        End If

        Return False
    End Function

    Public Function agregarTipoComprobante(ByVal tipo As String) As Boolean
        Dim res As Integer
        Dim valor As String

        Try
            res = MsgBox("Desea agregar el tipo de comprobante: '" + tipo + "'?", vbYesNo, G_EmpresaNombre)
            If Res = vbYes Then
                valor = InputBox("Ingrese la descripción para el tipo de comprobante: '" + tipo + "'", G_EmpresaNombre)
                If valor.Length > 0 Then
                    Tipos.Tipos.Add(New I_Tipo(tipo, valor))

                    'SUMA 1 AL TIPO DE COMPROBANTE --------------
                    Tipos.Tipos(Tipos.Tipos.Count - 1).Total += 1

                    crearTipos(objToText(Tipos))
                    Msg("Tipo '" + tipo + "' agregado correctamente!")
                    Return True
                Else
                    Msg("Tipo de comprobante NO agregado!", 2)
                End If
            End If
        Catch ex As Exception
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
        ProcesoActivo = False
        Msg("¡Proceso terminado!")
    End Sub
#End Region

End Module