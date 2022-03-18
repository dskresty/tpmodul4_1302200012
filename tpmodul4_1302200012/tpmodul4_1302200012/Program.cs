using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200012
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nama User: ");

            String a = Console.ReadLine();
            HaloGeneric.SapaUser <String> (a);
        }
    }
    class HaloGeneric
    {
        public static void SapaUser <R> (R nama)
        {
            Console.WriteLine("Halo User " + nama); 



            Console.WriteLine("NIM User: ");
            String NIM = Console.ReadLine();
            DataGeneric <String> a = new DataGeneric<string>(NIM);
            a.PrintData();
        }
    }
    class DataGeneric <T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("NIM: " + data);
 
        }
    }
}
