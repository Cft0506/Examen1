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
    Console.WriteLine("[6]. Mostrar 10 elementos numéricos en un arreglo");
    Console.WriteLine("[7]. Mostrar 5 nombres Bíblicos de personas en una lista");
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
        case 6:
            ElementosArreglo();
            break;
        case 7:
            NombresLista();
            break;
        case 8:
            Console.WriteLine("Salio del programa...");
            break;

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
        default:
            Console.WriteLine("Ingreso un numero de [1-7]");
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

//Opcion 5
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

//Opcion 6
void ElementosArreglo()
{
    // Arreglo predefinido
    int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine("Elementos del arreglo:");
    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }
}

//Opcion 7
void NombresLista()
{
    // Lista predefinida
    List<string> nombres = new List<string>() { "Jesus", "Jose", "María", "Pedro", "Judas" };

    Console.WriteLine("Nombres de personas en la lista:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
}