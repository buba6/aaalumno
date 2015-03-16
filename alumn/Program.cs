/*
 * Created by SharpDevelop.
 * User: buba
 * Date: 16/03/2015
 * Time: 04:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace alumn
{
	class clientes : Persona, menosomunes //SE HEREDA PERSONA Y LA INTERFACE
{

ArrayList clie = new ArrayList();
int ncuenta;
string saldo = "";


public clientes()
{
this.ncuenta = 0;
this.saldo = "";
}

public void menualum()
{
int retorno = 1;
while (retorno == 1)
{
Console.Clear();
Console.WriteLine("OPCIONES ");
Console.WriteLine("1.-GUARDAR");
Console.WriteLine("2.-ELIMINAR");
Console.WriteLine("3.-CONSULTAR");
Console.WriteLine("ESCOJA UNA DE LAS OPCIONES");
int opci = int.Parse(Console.ReadLine());

if (opci == 1)
{
alta();
}
if (opci == 2)
{
baja();
}
if (opci == 3)
{
consulta();
}
if ((opci < 1) || (opci > 3))
{
Console.WriteLine("opcion incorrecta");
}
Console.WriteLine("desea realizar otra operacion 1 o 0");

retorno = int.Parse(Console.ReadLine());


}
}
public void alta()
{
object[] estudiante = new object[4];
Console.WriteLine("escriba los datos del alumno");
Console.Write("codigo");

estudiante[0] = int.Parse(Console.ReadLine());

Console.Write("nombre");
estudiante[1] = (Console.ReadLine());

clie.Add(estudiante);
Console.WriteLine("los datos de alumnos han sido guardados");
}

public void baja()
{


for( int mat=0 ;mat<=ncuenta;mat++)
if (mat <= ncuenta)
{


clie.RemoveAt(mat);

}


}

public void consulta()
{


foreach (object[] propi in clie)
{

Console.WriteLine("codigo:" + propi[0]);
Console.WriteLine("nombre:" + propi[1]);




}


}

public override string ToString()
{
return "codigo:" + ncuenta +
"nombre:" + saldo;

}


}
	class Persona
{

public string nombre,apellido;
public int edad;

public Persona()
{
this.nombre = "";
this.apellido = "";
this.edad = 0;
}

public override string ToString()
{
return nombre + edad+ apellido;
}

}
	interface menosomunes
{
void alta();
void baja();
void consulta();
}
	class Principal
{
static void Main()
{
int op = 0;
do
{
Console.Clear();
Console.WriteLine(" Menu de alumnos");
Console.WriteLine("1.-ALTA DE ALUMNOS");
Console.WriteLine("2.-ALTA DE CUENTAS");
Console.WriteLine("SI DESEA SALIR PRESIONE 0");
Console.WriteLine(".....ESCOJA UNA DE LAS OPCIONES");

op = int.Parse(Console.ReadLine());

switch (op)
{
case 0:
Console.WriteLine("usted deseo salir del sistema");
break;

case 1:
clientes a = new clientes();
a.menualum();
break;
case 2:
cuenta ma = new cuenta();
ma.menumaes();
break;

default:
Console.WriteLine("la opcion no es correcta");
break;
}
}
while (op != 0);

}
}
	class cuenta: Persona,menosomunes
{
int ncuenta;
int importe;
string fecha;

ArrayList maes = new ArrayList();

public cuenta()
{
this.ncuenta = 0;
this.importe = 0;
this.fecha = "";
}
public void menumaes()

{


int retorno = 1;
while (retorno == 1)
{
Console.Clear();
Console.WriteLine("OPCIONES PARA CUENTAS");
Console.WriteLine("1.-GUARDAR");
Console.WriteLine("2.-ELIMINAR");
Console.WriteLine("3.-CONSULTAR");
Console.WriteLine("ESCOJA UNA DE LAS OPCIONES");
int opci = int.Parse(Console.ReadLine());

if (opci == 1)
{
alta();
}
if (opci == 2)
{
baja();
}
if (opci == 3)
{
consulta();
}
if ((opci < 1) || (opci > 3))
{
Console.WriteLine("opcion incorrecta");
}
Console.WriteLine("desea realizar otra operacion 1 o 0");

retorno = int.Parse(Console.ReadLine());


}
}
public void alta()
{
object[] maestro = new object[4];
Console.WriteLine("escriba los datos del maestro");
Console.Write("fecha");

maestro[0] = (Console.ReadLine());
Console.Write("cuenta");
maestro[1] = int.Parse(Console.ReadLine());
Console.Write("importe");
maestro[2] = int.Parse(Console.ReadLine());
maes.Add(maestro);
Console.WriteLine("los datos de alumnos han sido guardados");
}


public void baja()
{
Console.WriteLine("dar de baja a un alumno");


Console.WriteLine("ingrese la matricula");


for (int mat = 0; mat <= ncuenta; mat++)
if (mat <= ncuenta)
{


maes.RemoveAt(mat);

}

}








public void consulta()
{
Console.WriteLine("consultar todos los datos de los maestros");


foreach (object[] propi in maes)
{

Console.WriteLine("FECHA :" + propi[0]);
Console.WriteLine("CUENTA:" + propi[1]);
Console.WriteLine("IMPORTE:" + propi[2]);




}

}
public override string ToString()
{
return fecha + importe + ncuenta;
}



}
}
