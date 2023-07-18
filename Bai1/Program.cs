using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        public static List<Person> DS = new List<Person>();
        static void Main(string[] args)
        {
            Init();
            Output();
        }

        public static void Init()
        {
            int n;
            Console.WriteLine("Nhap so nguoi: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Person p = new Person();
                Console.WriteLine($"Nguoi so  {i + 1}:");
                p.Input();
                DS.Add(p);
            }
        }
        public static void Output()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}", "Id", "Name", "Tax");
            foreach (var p in DS) 
            {
                Console.WriteLine("{0,-10}{1,-20}{2,-10}", p.Id, p.Name, p.GetTax());
            }
        }
    }
}
