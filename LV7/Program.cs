using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { 7, 1, 2, 46, -4, 21, 109.6, -120.09 };
            NumberSequence sequence = new NumberSequence(arr);        

            Console.WriteLine("Pocetni:\n" + sequence.ToString());

            //BubbleSort bubble = new BubbleSort();
            //sequence.SetSortStrategy(bubble);
            //sequence.Sort();
            //Console.WriteLine("Bubble:\n" + sequence.ToString());

            //SequentialSort sequent = new SequentialSort();
            //sequence.SetSortStrategy(sequent);
            //sequence.Sort();
            //Console.WriteLine("Sekvencijalno:\n" + sequence.ToString());

            CombSort comb = new CombSort();
            sequence.SetSortStrategy(comb);
            sequence.Sort();
            Console.WriteLine("Comb sort:\n" + sequence.ToString());

            LinearSearch linearSearch = new LinearSearch();
            sequence.SetSearchStrategy(linearSearch);
            Console.WriteLine(sequence.Search(7));
        }
    }
}
