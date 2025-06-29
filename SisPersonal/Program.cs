using EspacioEmpleado;

void mostrarDatos(Empleado empleado)
{
    string estadoCivil;
    if (empleado.EstadoCivil == 'C' || empleado.EstadoCivil == 'c')
    {
        estadoCivil = "Casado";
    }
    else
    {
        estadoCivil = "Soltero";
    }

    Console.WriteLine("Nombre: " + empleado.Nombre);
    Console.WriteLine("Apellido: " + empleado.Apellido);
    Console.WriteLine("Fecha de Nacimiento: " + empleado.FechaDeNacimiento.ToShortDateString());
    Console.WriteLine("Estado civil: " + estadoCivil);
    Console.WriteLine("Fecha de ingreso a la empresa: " + empleado.FechaDeIngresoEnLaEmpresa.ToShortDateString());
    Console.WriteLine("Sueldo basico: $" + empleado.SueldoBasico.ToString("N2"));
    Console.WriteLine("Cargo: " + empleado.Cargo);
    Console.WriteLine("Antiguedad: " + empleado.Antiguedad() + " años");
    Console.WriteLine("Edad: " + empleado.Edad() + " años");
    Console.WriteLine("Años para jubilarse: " + empleado.Jubilacion() + " años");
    Console.WriteLine("Salario: $" + empleado.Salario().ToString("N2"));
} 

Empleado[] empleados = new Empleado[3];

// Empleado joven, recién ingresado, soltero, cargo Auxiliar
empleados[0] = new Empleado(
    nombre: "Lucía",
    apellido: "Pérez",
    fechaDeNacimiento: new DateTime(2000, 5, 12),
    estadoCivil: 's',
    fechaDeIngresoEnLaEmpresa: DateTime.Now.AddMonths(-6),
    sueldoBasico: 300000,
    cargo: Cargos.Auxiliar
);

// Empleado con antigüedad media, casado, cargo Ingeniero
empleados[1] = new Empleado(
    nombre: "Carlos",
    apellido: "Gómez",
    fechaDeNacimiento: new DateTime(1985, 3, 22),
    estadoCivil: 'C',
    fechaDeIngresoEnLaEmpresa: new DateTime(2010, 8, 15),
    sueldoBasico: 500000,
    cargo: Cargos.Ingeniero
);

// Empleado cercano a jubilarse, casado, cargo Investigador
empleados[2] = new Empleado(
    nombre: "Marta",
    apellido: "Lopez",
    fechaDeNacimiento: new DateTime(1962, 10, 30),
    estadoCivil: 'c',
    fechaDeIngresoEnLaEmpresa: new DateTime(1988, 2, 1),
    sueldoBasico: 600000,
    cargo: Cargos.Investigador
);

double totalSalarios = 0;
foreach (Empleado item in empleados)
{
    totalSalarios += item.Salario();
}
Console.WriteLine("El monto total  de lo que se paga en concepto de Salarios: $" + totalSalarios.ToString("N2"));
//Console.WriteLine($"El monto total de lo que se paga en concepto de Salarios: ${totalSalarios:N2}");

int mayorEdad = 0;
int indice = 0;
for (int i = 0; i < 3; i++)
{
    if (empleados[i].Edad() > mayorEdad)
    {
        indice = i;
    }
}

Console.WriteLine("---Datos del empleado más próximo a jubilarse---");
mostrarDatos(empleados[indice]);
