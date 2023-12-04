using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos;
public class RetoUno
{
    public void Reto1(){
        bool entrando = true;
        int op = 0;
        int num = 0;
        List<int> list = new List<int>();
        do{
            Console.WriteLine("|------------------------PushUp Dev Farit---------------------------|");
            Console.WriteLine("|              1. Total de la suma Fibonacci                        |");
            Console.WriteLine("|              2. Verificar si el numero es  Fibonacci              |");
            Console.WriteLine("|              3. Mostrar los primeros numeros Fibonacci            |");
            Console.WriteLine("|              0. Salir                                             |");
            Console.WriteLine("|___________________________________________________________________|");
            Console.Write("--> ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                Console.Clear();
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("|        Volviendo al inicio           |");
                Console.WriteLine("|--------------------------------------|");
                entrando = false;
                break;
                case 1:
                    Console.WriteLine("Ingrese un numero entero ");
                    Console.Write("--> ");
                    num = int.Parse(Console.ReadLine());
                    if(num <= 1){
                        Console.WriteLine("{0}", "El numero no es valido");
                        Console.Write("Presione [ENTER] para continuar ... ");
                        Console.ReadKey();
                    }else{
                        int result1 = 0;
                        int result2 = 1;
                        for (int i = 0; i < num; i++){    
                            int t = result1;
                            result1 = result2;
                            result2 = t + result1;
                        }
                        Console.WriteLine("La suma de la secuencia Fibonacci: {0}", result1);
                        Console.Write("Presione [ENTER] para continuar ... ");
                        Console.ReadKey();
                    }
                    Console.Clear();
                break;
                case 2:
                    Console.WriteLine("Ingrese un numero entero ");
                    Console.Write("--> ");
                    num = int.Parse(Console.ReadLine());

                    if(num <= 1){
                        Console.WriteLine("{0}", "El numero no es valido");
                        Console.Write("Presione [ENTER] para continuar ... ");
                        Console.ReadKey();
                    }else{
                        int result1 = 0;
                        int result2 = 1;
                        for (int i = 0; i < num; i++){    
                            int t = result1;
                            result1 = result2;
                            result2 = t + result1;
                            list.Add(result1);
                        }
                        if(list.Any(x => x.Equals(num))){
                            Console.WriteLine("Si es un numero fibonacci");
                            Console.Write("Presione [ENTER] para continuar ... ");
                            Console.ReadKey();
                        }else{
                            Console.WriteLine("No es un numero fibonacci");
                            Console.Write("Presione [ENTER] para continuar ... ");
                            Console.ReadKey();
                        }
                    }
                    Console.Clear();
                break;
                case 3:
                    Console.WriteLine("Ingrese un numero entero ");
                    Console.Write("--> ");
                    num = int.Parse(Console.ReadLine());

                    if(num <= 1){
                        Console.WriteLine("{0}", "El numero no es valido");
                        Console.Write("Presione [ENTER] para continuar ... ");
                        Console.ReadKey();
                    }else{
                        int result1 = 0;
                        int result2 = 1;
                        for (int k = 0; k < num; k++){    
                            int t = result1;
                            result1 = result2;
                            result2 = t + result1;
                            Console.WriteLine("{0}", result1);
                        }
                        Console.Write("Presione [ENTER] para continuar ... ");
                        Console.ReadKey();
                    }
                    Console.Clear();
                break;
                default:
                    Console.WriteLine("Te Saliste del RANGO");
                    Console.Write("ESPERE UN MOMENTO ...");
                    Thread.Sleep(2000);
                    Console.Clear();
                break;
            }
        }while (entrando);
    }
}
