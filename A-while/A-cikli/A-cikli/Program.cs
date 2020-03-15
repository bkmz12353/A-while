using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_cikli
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные:");
            double x;
            int k;
      ggo:      try
            {
                string vvod = Console.ReadLine();
                string[] arg = vvod.Split(' ');
                k = Convert.ToInt16(arg[0]);
                x = Convert.ToDouble(arg[1].Replace('.', ','));
            }
            catch 
            {
                Console.WriteLine("Введены некоректные данные, пожалуйста повторите ввод!");
                goto ggo;
            }
            double znachenie = 0, summ = znachenie;
            for (int n = 0; n < k; n++)
            {
                double p = 2 * n + 1;
                znachenie = 1/p*Math.Pow((x-1)/(x+1),p);
                summ += znachenie;
            }
            Console.WriteLine("Итоговое значение:");
            Console.WriteLine(summ);
            Console.ReadLine();
        }
    }
}
