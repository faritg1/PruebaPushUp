using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos;
public class RetoTres
{
    public void retoTres(){
        int div1 = 0;
        int div2 = 0;
        int num1 = 220;
        int num2 = 285;

        for (int i = 1; i <= num1/2 ; i++)
        {
            if(num1 % i == 0){
                div1 += i;
            }
        }
        for (int i = 1; i <= num2/2 ; i++)
        {
            if(num2 % i == 0){
                div2 += i;
            }
        }
        if(num1 == div2 && num2 == div1){
            Console.WriteLine("Numeros amistosos");
            Console.ReadKey();
        }else{
            Console.WriteLine("Los numeros no son amistosos");
            Console.ReadKey();
        }
    }
}
