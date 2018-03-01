using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ряд_Фарея
{
    public class Fraction
    {
        public int P { get; set; }
        public int Q { get; set; }
        Fraction Next;

        public Fraction(int p, int q, Fraction next)
        {
            P = p;
            Q = q;
            Next = next;
        }
    }
    class Program
    {

        public static bool IsMutuallySimple(int a, int b)
        {
            int bigger = Math.Max(a, b);
            int lesser = Math.Min(a, b);
            int NOD = 0;
            for (int i = lesser; i > 0; i--)
            {
                if (lesser % i == 0 && bigger % i == 0)
                {
                    NOD = i;
                    break;
                }
            }
            return (NOD == 1); 
        }
        static void Main(string[] args)
        {
            var fareiSequence = new LinkedList<Fraction>();
            int n = int.Parse(Console.ReadLine());
            var f2 = new Fraction(1, 1, null);
            var f1 = new Fraction(0, 1, f2 );
            fareiSequence.AddFirst(f1);
            fareiSequence.AddLast(f2);
            for (int i = 2; i <= n; i++)
            {
                LinkedListNode<Fraction> j1 = fareiSequence.First; var j2 = j1.Next;
                while (j2 != null)
                {
                    if (f1.Q + f2.Q == i)
                    {
                        Fraction f3 = new Fraction(f1.P + f2.P, i, f2);// возможно, переменная ne[t e;t yt ye;yf
                        fareiSequence.AddAfter(j1, f3);
                        var j3 = j1.Next;
                        j2 = j3.Next;
                    }
                }
            }
        }
    }
}
