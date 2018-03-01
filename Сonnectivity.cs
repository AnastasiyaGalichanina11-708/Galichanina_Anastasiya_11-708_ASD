using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace связность
{
    class Pair
    {
        int Start { get; set; }
        int Finish { get; set;}
    }
    class Program
    {
        
        public static void AddСommunication(Pair one)
        {
         
        }
        
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var array = new int[10][10];
            
            // заполняем двумерный массив. проверяем если конец и начало пары имееют общий элемент, например если 1-2-5 и 1-5 
            // если 1 и 5 имеют 2 в массиве, то 1-5 мы не добавляем 
            // проходим по двумерному массиву, и если 1-3 то на место: 1 массив 3 элементставим значение true 
        }
    }
}
