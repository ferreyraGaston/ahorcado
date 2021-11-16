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
palabra= Console.ReadLine();

// la palabra es representada por guiones  ---
string palabraMostrar="";

for(int i=0; i<n; i++)
if(palabra[i]==' ')
palabraMostrar=palabraMostrar+"";
else
palabraMostrar=palabraMostrar+"-";


//Varables
int fallosRestantes=9;
Char letraActual;
bool terminado=false;

// parte repetitiva 
do{

Console.Clear();

// se muestra la palabra oculta y el usuario elige una letra
Console.ForegroundColor=ConsoleColor.White;  //definimos el text
Console.WriteLine("Palabra oculta: {0}",palabraMostrar);
Console.WriteLine("Fallos restantes: {0}",fallosRestantes);

// el usuario eligue una letra
Console.Write("ingrese una letra: ");
Console.ForegroundColor=ConsoleColor.Yellow;  //definimos el text
letraActual=Convert.ToChar(Console.ReadLine());

// si la letra es un error el contador de fallos descrementa
if(palabra.IndexOf(letraActual)== -1)
fallosRestantes--;

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
if(palabraMostrar.IndexOf("-")<0)
{
    Console.WriteLine("*******Felicidades*****");
    Console.WriteLine("Pla Palabra es: {0}",palabra);
    Console.WriteLine("*******Felicidades*****");
    terminado=true;
}

if(fallosRestantes==0)
{
    Console.WriteLine("lo suento, la palabrea era: {0}",palabra);
    terminado=true;
}
Console.WriteLine();
}

while(!terminado);
Console.WriteLine();

}
    }
}
