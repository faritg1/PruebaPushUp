using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaPushUp.Retos;

namespace PruebaPushUp.Menu;
public class Main
{
    public void MenuMain(){
    int op = 0;
    bool entrando = true;
    RetoUno retoUno = new RetoUno();
    do
    {
        try{
            
            Console.WriteLine("|------------------------PushUp Dev Farit---------------------------|");
            Console.WriteLine("|                       1. Reto 1                                   |");
            Console.WriteLine("|                       2. Reto 2                                   |");
            Console.WriteLine("|                       3. Reto 3                                   |");
            Console.WriteLine("|                       4. Reto 4                                   |");
            Console.WriteLine("|                       5. Reto 5                                   |");
            Console.WriteLine("|                       0. Salir                                    |");
            Console.WriteLine("|___________________________________________________________________|");
            Console.Write("--> ");
            op = int.Parse(Console.ReadLine());;

            switch (op){
            case 0:
                Console.Clear();
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("|    Gracias por usar este programa    |");
                Console.WriteLine("|--------------------------------------|");
                entrando = false;
            break;
            case 1:
                Console.Clear();
                Console.WriteLine("Bienvenido al ejercicio Fibonacci");
                Console.WriteLine("Ingrese un numero entero ");
                Console.Write("--> ");
                int num = int.Parse(Console.ReadLine());
                retoUno.Reto1(num);
            break;
            case 2:
                //entitie.Pregunta2();
                Console.Write("Presione [ENTER] para continuar ... ");
                Console.ReadKey();
                Console.Clear();
            break;
            case 3:
                //entitie.Pregunta3();
                Console.Write("Presione [ENTER] para continuar ... ");
                Console.ReadKey();
                Console.Clear();
            break;
            case 4:
                //entitie.Pregunta4();
                Console.Write("Presione [ENTER] para continuar ... ");
                Console.ReadKey();
                Console.Clear();
            break;
            case 5:
                //entitie.Pregunta5();
                Console.Write("Presione [ENTER] para continuar ... ");
                Console.ReadKey();
                Console.Clear();
            break;
            case 6:
                //entitie.Pregunta6();
                Console.Write("Presione [ENTER] para continuar ... ");
                Console.ReadKey();
                Console.Clear();
            break;
            default:
                Console.WriteLine("Te Saliste del RANGO");
                Console.Write("ESPERE UN MOMENTO ...");
                Thread.Sleep(2000);
                Console.Clear();
            break;
            }
        }
        catch (Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
            Console.Write("ESPERE UN MOMENTO ...");
            Thread.Sleep(2000);
            Console.Clear();
        }
    } while (entrando);
}
}





