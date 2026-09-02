Imports System
Module formulario_de_inscripcion
    Sub Main(args As String())
        Dim ids(19) As Integer
        Dim nombres(19) As String
        Dim documentos(19) As String
        Dim edades(19) As Integer
        Dim correos(19) As String
        Dim telefonos(19) As String
        Dim programas(19) As String
        Dim modalidades(19) As String
        Dim estados(19) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------------'
        '--|menu_principal_formulario_de_inscripcion|--'
        '----------------------------------------------'
        Do
            Console.WriteLine("menu principal formulario de inscripcion")
            Console.WriteLine("1) Registrar inscripcion")
            Console.WriteLine("2) Editar inscripcion")
            Console.WriteLine("3) Listar inscripciones")
            Console.WriteLine("4) Buscar inscripcion")
            Console.WriteLine("5) Eliminar inscripcion")
            Console.WriteLine("6) Filtrar inscripciones")
            Console.WriteLine("7) Mostrar resumen")
            Console.WriteLine("8) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '---------------------------'
                '--|registrar_inscripcion|--'
                '---------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas inscripciones.")
                    Else
                        Console.Write("Ingrese el nombre: ")
                        Dim nuevoNombre As String = Console.ReadLine()
                        If nuevoNombre = "" Then
                            Console.WriteLine("El nombre no puede estar vacio.")
                        Else
                            Dim documentoExiste As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If documentos(i).ToLower() = Console.ReadLine().ToLower() Then
                                    documentoExiste = True
                                End If
                            Next
                            Console.Write("Ingrese el documento: ")
                            Dim nuevoDocumento As String = Console.ReadLine()
                            If documentoExiste Then
                                Console.WriteLine("No se puede registrar. El documento ya existe.")
                            Else
                                Console.Write("Ingrese la edad: ")
                                Dim nuevaEdad As Integer = Convert.ToInt32(Console.ReadLine())
                                If nuevaEdad <= 0 Then
                                    Console.WriteLine("La edad debe ser mayor que cero.")
                                Else
                                    Console.Write("Ingrese el correo: ")
                                    Dim nuevoCorreo As String = Console.ReadLine()
                                    Console.Write("Ingrese el telefono: ")
                                    Dim nuevoTelefono As String = Console.ReadLine()
                                    Console.WriteLine("1) Ingenieria Informatica")
                                    Console.WriteLine("2) Administracion")
                                    Console.WriteLine("3) Contabilidad")
                                    Console.WriteLine("4) Marketing")
                                    Console.Write("Seleccione el programa: ")
                                    Dim opcionPrograma As Integer = Convert.ToInt32(Console.ReadLine())
                                    Dim nuevoPrograma As String = ""
                                    Select Case opcionPrograma
                                        Case 1
                                            nuevoPrograma = "Ingenieria Informatica"
                                        Case 2
                                            nuevoPrograma = "Administracion"
                                        Case 3
                                            nuevoPrograma = "Contabilidad"
                                        Case 4
                                            nuevoPrograma = "Marketing"
                                        Case Else
                                            Console.WriteLine("Programa no valido.")
                                    End Select
                                    If nuevoPrograma <> "" Then
                                        Console.WriteLine("1) Presencial")
                                        Console.WriteLine("2) Virtual")
                                        Console.WriteLine("3) Hibrida")
                                        Console.Write("Seleccione la modalidad: ")
                                        Dim opcionModalidad As Integer = Convert.ToInt32(Console.ReadLine())
                                        Dim nuevaModalidad As String = ""
                                        Select Case opcionModalidad
                                            Case 1
                                                nuevaModalidad = "Presencial"
                                            Case 2
                                                nuevaModalidad = "Virtual"
                                            Case 3
                                                nuevaModalidad = "Hibrida"
                                            Case Else
                                                Console.WriteLine("Modalidad no valida.")
                                        End Select
                                        If nuevaModalidad <> "" Then
                                            ids(cantidad) = cantidad + 1
                                            nombres(cantidad) = nuevoNombre
                                            documentos(cantidad) = nuevoDocumento
                                            edades(cantidad) = nuevaEdad
                                            correos(cantidad) = nuevoCorreo
                                            telefonos(cantidad) = nuevoTelefono
                                            programas(cantidad) = nuevoPrograma
                                            modalidades(cantidad) = nuevaModalidad
                                            estados(cantidad) = "Pendiente"
                                            cantidad += 1
                                            Console.WriteLine("Inscripcion registrada correctamente.")
                                            Console.WriteLine("ID: " & ids(cantidad - 1) & " | Nombre: " & nombres(cantidad - 1) & " | Documento: " & documentos(cantidad - 1) & " | Edad: " & edades(cantidad - 1) & " | Correo: " & correos(cantidad - 1) & " | Telefono: " & telefonos(cantidad - 1) & " | Programa: " & programas(cantidad - 1) & " | Modalidad: " & modalidades(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                '------------------------'
                '--|editar_inscripcion|--'
                '------------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen inscripciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la inscripcion a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            Dim nuevoNombre As String = Console.ReadLine()
                            If nuevoNombre = "" Then
                                Console.WriteLine("El nombre no puede estar vacio.")
                            Else
                                nombres(posicion) = nuevoNombre
                                Console.Write("Nuevo documento: ")
                                documentos(posicion) = Console.ReadLine()
                                Console.Write("Nueva edad: ")
                                Dim nuevaEdad As Integer = Convert.ToInt32(Console.ReadLine())
                                If nuevaEdad <= 0 Then
                                    Console.WriteLine("La edad debe ser mayor que cero.")
                                Else
                                    edades(posicion) = nuevaEdad
                                    Console.Write("Nuevo correo: ")
                                    correos(posicion) = Console.ReadLine()
                                    Console.Write("Nuevo telefono: ")
                                    telefonos(posicion) = Console.ReadLine()
                                    Console.WriteLine("1) Ingenieria Informatica")
                                    Console.WriteLine("2) Administracion")
                                    Console.WriteLine("3) Contabilidad")
                                    Console.WriteLine("4) Marketing")
                                    Console.Write("Seleccione el nuevo programa: ")
                                    Dim opcionPrograma As Integer = Convert.ToInt32(Console.ReadLine())
                                    Select Case opcionPrograma
                                        Case 1
                                            programas(posicion) = "Ingenieria Informatica"
                                        Case 2
                                            programas(posicion) = "Administracion"
                                        Case 3
                                            programas(posicion) = "Contabilidad"
                                        Case 4
                                            programas(posicion) = "Marketing"
                                        Case Else
                                            Console.WriteLine("Programa no valido.")
                                    End Select
                                    Console.WriteLine("1) Presencial")
                                    Console.WriteLine("2) Virtual")
                                    Console.WriteLine("3) Hibrida")
                                    Console.Write("Seleccione la nueva modalidad: ")
                                    Dim opcionModalidad As Integer = Convert.ToInt32(Console.ReadLine())
                                    Select Case opcionModalidad
                                        Case 1
                                            modalidades(posicion) = "Presencial"
                                        Case 2
                                            modalidades(posicion) = "Virtual"
                                        Case 3
                                            modalidades(posicion) = "Hibrida"
                                        Case Else
                                            Console.WriteLine("Modalidad no valida.")
                                    End Select
                                    Console.WriteLine("1) Pendiente")
                                    Console.WriteLine("2) Aprobada")
                                    Console.WriteLine("3) Rechazada")
                                    Console.Write("Seleccione el nuevo estado: ")
                                    Dim opcionEstado As Integer = Convert.ToInt32(Console.ReadLine())
                                    Select Case opcionEstado
                                        Case 1
                                            estados(posicion) = "Pendiente"
                                        Case 2
                                            estados(posicion) = "Aprobada"
                                        Case 3
                                            estados(posicion) = "Rechazada"
                                        Case Else
                                            Console.WriteLine("Estado no valido.")
                                    End Select
                                    Console.WriteLine("Inscripcion actualizada correctamente.")
                                    Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Documento: " & documentos(posicion) & " | Edad: " & edades(posicion) & " | Correo: " & correos(posicion) & " | Telefono: " & telefonos(posicion) & " | Programa: " & programas(posicion) & " | Modalidad: " & modalidades(posicion) & " | Estado: " & estados(posicion))
                                End If
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------------'
                '--|listar_inscripciones|--'
                '--------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen inscripciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '------------------------'
                '--|buscar_inscripcion|--'
                '------------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen inscripciones registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por nombre")
                        Console.WriteLine("3) Buscar por documento")
                        Console.WriteLine("4) Buscar por programa")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Documento: " & documentos(posicion) & " | Edad: " & edades(posicion) & " | Correo: " & correos(posicion) & " | Telefono: " & telefonos(posicion) & " | Programa: " & programas(posicion) & " | Modalidad: " & modalidades(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el nombre: ")
                            Dim nombreBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If nombres(i).ToLower().Contains(nombreBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron inscripciones.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese el documento: ")
                            Dim documentoBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If documentos(i).ToLower().Contains(documentoBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron inscripciones.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese el programa: ")
                            Dim programaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If programas(i).ToLower().Contains(programaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron inscripciones en ese programa.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '--------------------------'
                '--|eliminar_inscripcion|--'
                '--------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen inscripciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la inscripcion a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                documentos(i) = documentos(i + 1)
                                edades(i) = edades(i + 1)
                                correos(i) = correos(i + 1)
                                telefonos(i) = telefonos(i + 1)
                                programas(i) = programas(i + 1)
                                modalidades(i) = modalidades(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            nombres(cantidad) = ""
                            documentos(cantidad) = ""
                            edades(cantidad) = 0
                            correos(cantidad) = ""
                            telefonos(cantidad) = ""
                            programas(cantidad) = ""
                            modalidades(cantidad) = ""
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Inscripcion eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------------'
                '--|filtrar_inscripciones|--'
                '---------------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen inscripciones registradas.")
                    Else
                        Console.WriteLine("1) Filtrar por programa")
                        Console.WriteLine("2) Filtrar por modalidad")
                        Console.WriteLine("3) Filtrar por estado")
                        Console.WriteLine("4) Filtrar por edad minima")
                        Console.WriteLine("5) Mostrar todas")
                        Console.Write("Seleccione un filtro: ")
                        Dim tipoFiltro As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoFiltro = 1 Then
                            Console.Write("Ingrese el programa: ")
                            Dim programaFiltro As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If programas(i).ToLower() = programaFiltro.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen inscripciones en ese programa.")
                            End If
                        ElseIf tipoFiltro = 2 Then
                            Console.Write("Ingrese la modalidad: ")
                            Dim modalidadFiltro As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If modalidades(i).ToLower() = modalidadFiltro.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen inscripciones con esa modalidad.")
                            End If
                        ElseIf tipoFiltro = 3 Then
                            Console.Write("Ingrese el estado: ")
                            Dim estadoFiltro As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If estados(i).ToLower() = estadoFiltro.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen inscripciones con ese estado.")
                            End If
                        ElseIf tipoFiltro = 4 Then
                            Console.Write("Ingrese la edad minima: ")
                            Dim edadMinima As Integer = Convert.ToInt32(Console.ReadLine())
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If edades(i) >= edadMinima Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen inscripciones con esa edad minima.")
                            End If
                        ElseIf tipoFiltro = 5 Then
                            For i As Integer = 0 To cantidad - 1
                                Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Edad: " & edades(i) & " | Correo: " & correos(i) & " | Telefono: " & telefonos(i) & " | Programa: " & programas(i) & " | Modalidad: " & modalidades(i) & " | Estado: " & estados(i))
                            Next
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 7
                    If cantidad = 0 Then
                        Console.WriteLine("No existen inscripciones registradas.")
                    Else
                        Dim pendientes As Integer = 0
                        Dim aprobadas As Integer = 0
                        Dim rechazadas As Integer = 0
                        Dim presenciales As Integer = 0
                        Dim virtuales As Integer = 0
                        Dim hibridas As Integer = 0
                        Dim sumaEdades As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            sumaEdades += edades(i)
                            If estados(i) = "Pendiente" Then
                                pendientes += 1
                            ElseIf estados(i) = "Aprobada" Then
                                aprobadas += 1
                            ElseIf estados(i) = "Rechazada" Then
                                rechazadas += 1
                            End If
                            If modalidades(i) = "Presencial" Then
                                presenciales += 1
                            ElseIf modalidades(i) = "Virtual" Then
                                virtuales += 1
                            ElseIf modalidades(i) = "Hibrida" Then
                                hibridas += 1
                            End If
                        Next
                        Dim edadPromedio As Double = sumaEdades / cantidad
                        Console.WriteLine("Total de inscripciones: " & cantidad)
                        Console.WriteLine("Inscripciones pendientes: " & pendientes)
                        Console.WriteLine("Inscripciones aprobadas: " & aprobadas)
                        Console.WriteLine("Inscripciones rechazadas: " & rechazadas)
                        Console.WriteLine("Modalidad presencial: " & presenciales)
                        Console.WriteLine("Modalidad virtual: " & virtuales)
                        Console.WriteLine("Modalidad hibrida: " & hibridas)
                        Console.WriteLine("Edad promedio: " & edadPromedio.ToString("N2"))
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 8
                    Console.WriteLine("Gracias por utilizar Formulario de Inscripcion.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 8
    End Sub
End Module