int opcion;

do
{
    // Mostrar el menú
    Console.WriteLine("[Menú de opciones]");
    Console.WriteLine("==================");
    Console.WriteLine("[1]. Determinar si un número ingresado por el usuario es positivo, negativo o cero");
    Console.WriteLine("[2]. Imprimir un mensaje según el día de la semana");
    Console.WriteLine("[3]. Calcular la suma de los primeros 100 números naturales");
    Console.WriteLine("[4]. Imprimir todos los números desde 1 hasta el número ingresado");
    Console.WriteLine("[5]. Calcular el área de un círculo");
    Console.WriteLine("[6]. Mostrar los elementos de un arreglo");
    Console.WriteLine("[7]. Mostrar nombres de personas en una lista");
    Console.WriteLine("[8]. Salir");

    // Leer la opción del usuario
    Console.WriteLine("Ingrese una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    // Ejecutar la opción seleccionada
    switch (opcion)
    {
        case 1:
            Console.WriteLine(validacionNumero());
            break;
        case 2:
            diaSemana();
            break;
        case 3:
            Console.WriteLine("La suma es: " + sumNumeros());
            break;
        case 4:
            RecorridoNumero();
            break;
        case 5:
            CalcularAreaCirculo();
            break;
            //case 6:
            //    MostrarElementosArreglo();
            //    break;
            //case 7:
            //    MostrarNombresLista();
            //    break;
            //case 8:
            //    Console.WriteLine("Saliendo del programa...");
            //    break;
            //default:
            //    Console.WriteLine("Opción no válida. Intente nuevamente.");
            //    break;
    }

    Console.WriteLine("\n Presione cualquier tecla para continuar...");
    Console.ReadKey();
} while (opcion != 8);


//Opcion 1
string validacionNumero()
{
    Console.WriteLine("Ingrese un número: ");
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());    

    string resultado = string.Empty;
    if (numeroIngresado > 0)
    {
        resultado = "El numero es Positivo";
        return resultado;
    }

    if (numeroIngresado == 0)
    {
        resultado = "El numero es Cero";
        return resultado;
    }
    else
    {
        resultado = "El numero es Negativo";
        return resultado;
    }
    Console.WriteLine(resultado);
    
    
}

//Opcion 2
void diaSemana()
{
    Console.WriteLine("ingrese un dia de la semana: ");
    int diaIngresado = Convert.ToInt32( Console.ReadLine());
    
   
    switch (diaIngresado)
    {
        case 1:
            Console.WriteLine("Ingreso el dia lunes");            
            break;
        case 2:
            Console.WriteLine("Ingreso el dia martes");
            break;
        case 3:
            Console.WriteLine("Ingreso el dia miércoles");
            break;
        case 4:
            Console.WriteLine("Ingreso el dia jueves");
            break;
        case 5:
            Console.WriteLine("Ingreso el dia viernes");
            break;
        case 6:
            Console.WriteLine("Ingreso el dia sábado");
            break;
        case 7:
            Console.WriteLine("Ingreso el dia domingo");
            break;
        }
       
}

//Opcion 3
int sumNumeros()
{
    int resultadoSuma = 0;
    for (int i = 1; i <= 100; i++)
    {
        resultadoSuma = resultadoSuma + i;
    }
    return resultadoSuma;
}

//Opcion 4
void RecorridoNumero()
{
    Console.WriteLine("Ingrese numero natural y positivo:");
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= numeroIngresado; i++)
    {
        Console.WriteLine("Impresión Hasta el #: " + i);
    }
}

double CalcularAreaCirculo()
{
    double radio;

    Console.WriteLine("Ingrese el radio del círculo: ");
    radio = Convert.ToDouble(Console.ReadLine());

    // Fórmula para calcular el área de un círculo
    double area = Math.PI * Math.Pow(radio, 2);

    Console.WriteLine("El área del círculo es: " + area);

    return area;
}