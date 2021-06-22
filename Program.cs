using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingresa una cadena de caracteres");
            Console.Write("Ingresa cual es numero maximo de caracteres: ");
            Console.ForegroundColor = ConsoleColor.White;
            int n = int.Parse(Console.ReadLine());
            char[] cadena = new char[n];//-- se crea el arreglo
            for(int i = 0; i < n; i++)//-- guarda los caracteres
            {
                Console.WriteLine("Escribe el caracter "+(i+1)+": ");
                cadena[i] = Convert.ToChar(Console.ReadLine());
            }
            Cadenas Ccadena = new Cadenas(cadena);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Escoge que es lo que deseas hacer: ");
            Console.WriteLine("a.La cadena escrita al revés.");
            Console.WriteLine("b.La cadena en mayúsculas.");
            Console.WriteLine("c.La cadena anterior modificada según las siguientes reglas\n" +
                "A=4\n" +
                "I=1\n" +
                "S=5\n" +
                "B=8\n" +
                "E=3\n" +
                "T=7");
            Console.ForegroundColor = ConsoleColor.White;
            char ans = char.ToUpper(Convert.ToChar(Console.Read()));
            Console.Clear();
            switch (ans)//-- se verifica que opcion se escogio
            {
                case 'A': Console.WriteLine(Ccadena.Reversa()); break;
                case 'B': Console.WriteLine(Ccadena.Mayusculas()); break;
                case 'C':
                    {
                        foreach(char c in Ccadena.Sustitucion())
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    }
               default: Console.WriteLine("Error no esta en la lista lo escrito"); break;
            }
        }
    }
}
