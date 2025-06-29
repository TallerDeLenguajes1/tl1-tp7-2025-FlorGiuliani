namespace EspacioEmpleado;

using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

public enum Cargos
{
    Auxiliar = 0,
    Administrativo = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4,
}

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private DateTime fechaDeIngresoEnLaEmpresa;
    private double sueldoBasico;
    private Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, DateTime fechaDeIngresoEnLaEmpresa, double sueldoBasico, Cargos cargo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaDeNacimiento = fechaDeNacimiento;
        this.EstadoCivil = estadoCivil;
        this.FechaDeIngresoEnLaEmpresa = fechaDeIngresoEnLaEmpresa;
        this.SueldoBasico = sueldoBasico;
        this.Cargo = cargo;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaDeIngresoEnLaEmpresa { get => fechaDeIngresoEnLaEmpresa; set => fechaDeIngresoEnLaEmpresa = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public int Antiguedad()
    {
        int antiguedad = (DateTime.Now - fechaDeIngresoEnLaEmpresa).Days / 365;
        return antiguedad;
    }

    public int Edad()
    {
        int edad = (DateTime.Now - fechaDeNacimiento).Days / 365;
        return edad;
    }

    public int Jubilacion()
    {
        int jubilacion = (65 - Edad());
        return jubilacion;
    }

    public double Salario()
    {
        double salario;
        double adicional;
        if (Antiguedad() < 20)
        {
            adicional = Antiguedad() * sueldoBasico / 100;
        }
        else
        {
            adicional = 25 * sueldoBasico / 100;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional += 50 * adicional / 100;
        }
        if (estadoCivil == 'c' || estadoCivil == 'C')
        {
            adicional += 150000;
        }
        salario = sueldoBasico + adicional;
        return salario;
    }
}