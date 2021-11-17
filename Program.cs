using System;

namespace ahorcado
{
    class Program
{
static void Main(string[] args)
{

        Console.BackgroundColor=ConsoleColor.DarkBlue; //definimos el color de fondo
        Console.ForegroundColor=ConsoleColor.White;  //definimos el text
        Console.Clear();

String palabra;
int n;
Console.WriteLine("Cuantas letras es tu palabra incognita");
Console.ForegroundColor=ConsoleColor.Yellow;  //definimos el text
n= Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor=ConsoleColor.White;  //definimos el text
Console.WriteLine("ingrese la palabra incognita");
Console.ForegroundColor=ConsoleColor.Yellow;  //definimos el text
palabra= Console.ReadLine(); // silla

// la palabra es representada por guiones  ---
string palabraMostrar="";

for(int i=0; i<n; i++)
if(palabra[i]== ' ')
palabraMostrar=palabraMostrar+" ";
else
palabraMostrar=palabraMostrar+"-";


//Varables
int fallosRestantes=7;
Char letraActual;
bool terminado=false;

// parte repetitiva 
do{
// se muestra la palabra oculta y el usuario elige una letra
Console.ForegroundColor=ConsoleColor.White;  //definimos el text
Console.WriteLine("Palabra oculta: {0}",palabraMostrar);
Console.WriteLine("Fallos restantes: {0}",fallosRestantes);

// el usuario eligue una letra
Console.Write("ingrese una letra: ");
Console.ForegroundColor=ConsoleColor.Yellow;  //definimos el text
letraActual=Convert.ToChar(Console.ReadLine());

// si la letra es un error el contador de fallos descrementa

//¿Qué es IndexOf C#?
//Para ver si una cadena contiene un cierto texto, que nos dice en qué posición se encuentra 
//(o devuelve el valor -1 si no aparece)

if(palabra.IndexOf(letraActual)== -1)
fallosRestantes--;

switch(fallosRestantes)
{
    case 7: 
    Console.WriteLine("     -----------      ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");
    Console.WriteLine("    |                   ");       
    Console.WriteLine("    |                   ");
    break;

    case 6: 
    Console.WriteLine("     -----------          ");
    Console.WriteLine("    |          ( )         ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");       
    Console.WriteLine("    |                     ");
    break;

    case 5: 
    Console.WriteLine("     -----------          ");
    Console.WriteLine("    |          ( )         ");
    Console.WriteLine("    |           |          ");
    Console.WriteLine("    |           |          ");
    Console.WriteLine("    |           |          ");
    Console.WriteLine("    |           |          ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");       
    Console.WriteLine("    |                     ");
    break;

    case 4: 
    Console.WriteLine("     -----------          ");
    Console.WriteLine("    |          ( )         ");
    Console.WriteLine("    |       ----|          ");
    Console.WriteLine("    |       |   |          ");
    Console.WriteLine("    |       |   |          ");
    Console.WriteLine("    |           |          ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");       
    Console.WriteLine("    |                     ");     
    break;

    case 3: 
    Console.WriteLine("     -----------          ");
    Console.WriteLine("    |          ( )         ");
    Console.WriteLine("    |       ----|----      ");
    Console.WriteLine("    |       |   |   |      ");
    Console.WriteLine("    |       |   |   |      ");
    Console.WriteLine("    |           |          ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");
    Console.WriteLine("    |                     ");       
    Console.WriteLine("    |                     ");       
    
    break;

    case 2: 
    Console.WriteLine("     -----------          ");
    Console.WriteLine("    |          ( )         ");
    Console.WriteLine("    |       ----|----      ");
    Console.WriteLine("    |       |   |   |      ");
    Console.WriteLine("    |       |   |   |      ");
    Console.WriteLine("    |         __|          ");
    Console.WriteLine("    |         |            ");
    Console.WriteLine("    |         |            ");
    Console.WriteLine("    |         |            ");
    Console.WriteLine("    |                     ");       
    Console.WriteLine("    |                     "); 
    break;

    case 1: 
    Console.WriteLine("     -----------          ");
    Console.WriteLine("    |          ( )         ");
    Console.WriteLine("    |       ----|----      ");
    Console.WriteLine("    |       |   |   |      ");
    Console.WriteLine("    |       |   |   |      ");
    Console.WriteLine("    |         __|___       ");
    Console.WriteLine("    |         |    |       ");
    Console.WriteLine("    |         |    |       ");
    Console.WriteLine("    |         |    |       ");
    Console.WriteLine("    |                      ");       
    Console.WriteLine("    |                      "); 
    break;


}


//si la letra pertenece a la palabra, el jugador
//no pierde el intento y descubre una de las incognitas

string siguienteMostrar="";
for(int i=0; i<n;i++)
{

    if(letraActual==palabra[i])
    siguienteMostrar=siguienteMostrar+letraActual;
    else
    siguienteMostrar=siguienteMostrar+palabraMostrar[i];
}
palabraMostrar=siguienteMostrar;

// si se adivina la palabra o si pierde por los intenos
//determinar si un caracter se encuentra presente dentro de un string 
if(palabraMostrar.IndexOf("-")<0)
{
    Console.BackgroundColor=ConsoleColor.Green; //definimos el color de fondo
    Console.ForegroundColor=ConsoleColor.Black;  //definimos el text
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("***************Felicidades**************");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("la Palabra es: {0}",palabra);
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("***************Felicidades**************");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    terminado=true;
}

if(fallosRestantes==0)
{
    Console.BackgroundColor=ConsoleColor.Red; //definimos el color de fondo    Console.BackgroundColor=ConsoleColor.DarkBlue; //definimos el color de fondo
    Console.ForegroundColor=ConsoleColor.Black;  //definimos el text
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("****************************************");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("lo siento, la palabra era: {0}",palabra);
    Console.WriteLine("");
    Console.WriteLine("****************************************");
    Console.WriteLine("****************************************");
    Console.WriteLine("****************************************");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    terminado=true;
}
Console.WriteLine();

}

while(!terminado); // sale del boot con true
Console.WriteLine();

}
    }
}
