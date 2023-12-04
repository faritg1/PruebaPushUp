using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos;
public class RetoUno
{
    public void Reto1(int num){
        int result1 = 0;
        int result2 = 1;
        if(num <= 1){
            Console.WriteLine("{0}", "El numero no es valido");
            Console.Write("Presione [ENTER] para continuar ... ");
            Console.ReadKey();
        }else{
            for (int i = 0; i < num; i++){    
                int t = result1;
                result1 = result2;
                result2 = t + result1;
            }
            Console.WriteLine("{0}", result1);
            Console.Write("Presione [ENTER] para continuar ... ");
            Console.ReadKey();
        }
    }
}
