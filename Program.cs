// Elabore una aplicación con una clase empleado (Nombre, apellido, cargo, CUIL, cantidad de hijos a cargo y años de antigüedad).
//Un método LiquidarSueldo que mostrará en pantalla la liquidación, que contendrá: el nombre completo, el CUIL y el sueldo a percibir.
//Se sabe que en la empresa hay cinco cargos que perciben un sueldo básico diferente: Asistente($ 100000), Operador($ 150000),
//Ejecutivo de cuenta ($200000), Gerente($500000) y Director ejecutivo ($900000)
//Se sabe asimismo que los empleados tienen derecho a percibir un importe de $10000 como asignación familiar por hijo a cargo,
//y el 7% más de su sueldo básico por año de antigüedad.
//Ingrese varios empleados y calcule su sueldo.


using System.Diagnostics;
using System.IO;

var Empleado1 = new Empleado("Lionel", "Messi", Empleado.tipoCargo.Director, 2034521422, 3, 10);
var Empleado2 = new Empleado("Dibu", "Martines", Empleado.tipoCargo.Gerente, 2123234532, 2, 13);
var Empleado3 = new Empleado("Lionel", "Scaloni", Empleado.tipoCargo.Ejecutivo, 2032534672, 3, 2);


Empleado1.LiquidarSueldo();
Empleado2.LiquidarSueldo();
Empleado3.LiquidarSueldo();

class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public tipoCargo Cargo { get; set; }
    public int CUIL { get; set; }
    public int HijosACargo { get; set; }
    public int Antiguedad { get; set; }

    public enum tipoCargo{
        Asistente,
        Operador,
        Ejecutivo,
        Gerente,
        Director,
    }


    //constructor de empleado
    public Empleado(string NombreEmpleado, string ApellidoEmpleado, tipoCargo CargoEmpleado, int CuilEmpleado, int HijosEmpleados, int AntiguedadEmpleado)
    {
        this.Nombre = NombreEmpleado;
        this.Apellido = ApellidoEmpleado;
        this.Cargo = CargoEmpleado;
        this.CUIL = CuilEmpleado;
        this.HijosACargo = HijosEmpleados;
        this.Antiguedad = AntiguedadEmpleado;
    }


    public void LiquidarSueldo()
    {
        double Sueldo = 0;

        switch (this.Cargo)
        {
            case tipoCargo.Asistente:
                Sueldo = 100000.00;
                break;
            case tipoCargo.Operador:
                Sueldo = 150000.00;
                break;
            case tipoCargo.Ejecutivo:
                Sueldo = 200000.00;
                break;
            case tipoCargo.Gerente:
                Sueldo = 500000.00;
                break;
            case tipoCargo.Director:
                Sueldo = 900000.00;
                break;
        }

        Sueldo = Sueldo + (this.Antiguedad * 0.07);

        Sueldo = Sueldo + (10000 * this.HijosACargo);
        
       Console.WriteLine(this.Nombre + " " + this.Apellido + " Cuil: " + this.CUIL + " Sueldo: $" + Sueldo);
       


    }


}
