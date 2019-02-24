using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] t_34 = new Tank[5];
            t_34[0] = new Tank("T-34 первый");
            t_34[1] = new Tank("T-34 второй");
            t_34[2] = new Tank("T-34 третий");
            t_34[3] = new Tank("T-34 четвертый");
            t_34[4] = new Tank("T-34 пятый");
            Tank[] pant = new Tank[5];
            pant[0] = new Tank("Пантера первый");
            pant[1] = new Tank("Пантера второй");
            pant[2] = new Tank("Пантера третий");
            pant[3] = new Tank("Пантера четвертый");
            pant[4] = new Tank("Пантера пятый");
            for (int i = 0; i < 5; i++)
            {
                fight.Fight(t_34[i] * pant[i], t_34[i], pant[i]);
            }
            
        }
    }   
}
