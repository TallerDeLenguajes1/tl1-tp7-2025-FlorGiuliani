using EspacioCalculadora;

//Hice la calculadora de dos formas:
//La primera como si fuera una calculadora normal, sin mensajes y accediendo con los símbolos de siempre
//La segunda, como trabajabamos otras veces, con mensajes y eligiendo la operacion con números

string ingresarRespuesta()
{
    string? respuesta;
    do
    {
        respuesta = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(respuesta));
    return respuesta;
}

double ingresarTermino()
{
    string? respuesta;
    double num;
    do
    {
        respuesta = Console.ReadLine();
    } while (!double.TryParse(respuesta, out num));
    return num;
}

Calculadora nuevaOperacion = new Calculadora();

string? respuesta;

    Console.WriteLine("+) Sumar");
    Console.WriteLine("-) Restar");
    Console.WriteLine("x) Multiplicar");
    Console.WriteLine("/) Dividir");
    Console.WriteLine("=) Resultado");
    Console.WriteLine("AC) Limpiar");
    Console.WriteLine("?) Salir");

Console.WriteLine("---CALCULADORA---");
do
{
    respuesta = ingresarRespuesta();

    switch (respuesta)
    {
        case "+":
            nuevaOperacion.Sumar(ingresarTermino());
            break;
        case "-":
            nuevaOperacion.Restar(ingresarTermino());
            break;
        case "x":
            nuevaOperacion.Multiplicar(ingresarTermino());
            break;
        case "/":
            nuevaOperacion.Dividir(ingresarTermino());
            break;
        case "=":
            Console.WriteLine(nuevaOperacion.Resultado);
            break;
        case "AC":
            nuevaOperacion.Limpiar();
            break;
        default:
            break;
    }

} while (respuesta != "?");



/*int ingresarRespuesta(string mensaje)
{
    string? respuesta;
    int num;
    do
    {
        Console.WriteLine(mensaje);
        respuesta = Console.ReadLine();
    } while (!int.TryParse(respuesta, out num));
    return num;
}

double ingresarTermino(string mensaje)
{
    string? respuesta;
    double num;
    do
    {
        Console.WriteLine(mensaje);
        respuesta = Console.ReadLine();
    } while (!double.TryParse(respuesta, out num));
    return num;
}

Calculadora nuevaOperacion = new Calculadora();

int respuesta;

Console.WriteLine("---CALCULADORA---");
do
{
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) Restar");
    Console.WriteLine("3) Multiplicar");
    Console.WriteLine("4) Dividir");
    Console.WriteLine("5) Resultado");
    Console.WriteLine("6) Limpiar");
    Console.WriteLine("7) Salir");

    respuesta = ingresarRespuesta("Igresa la operacion a realizar");

    switch (respuesta)
    {
        case 1:
            nuevaOperacion.Sumar(ingresarTermino("Ingresar el numero a sumar: "));
            break;
        case 2:
            nuevaOperacion.Restar(ingresarTermino("Ingresar el numero a restar: "));
            break;
        case 3:
            nuevaOperacion.Multiplicar(ingresarTermino("Ingresar el numero a multiplicar: "));
            break;
        case 4:
            nuevaOperacion.Dividir(ingresarTermino("Ingresar el numero a dividir: "));
            break;
        case 5:
            Console.WriteLine("El resultado es: " + nuevaOperacion.Resultado);
            break;
        case 6:
            nuevaOperacion.Limpiar();
            break;
        default:
            break;
    }

} while (respuesta != 7); */