using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        public static List<IPerson> DS = new List<IPerson>();
        static void Main(string[] args)
        {
            init();
            Output();
        }
        public static void init()
        {
            Teacher t = new Teacher(1, "Teach1", 22, 5000000, "Truong thpt 1"),
                    t1 = new Teacher(2, "Teach2", 32, 15000000, "Truong thpt 2"),
                    t2 = new Teacher(3, "Teach3", 25, 20000000, "Truong thpt 3");
            Student s = new Student(4, "Studen1", 17, 0, 0, "11a2", "Truong thpt 1"),
                    s1 = new Student(5, "Studen2", 17, 0, 0, "11a5", "Truong thpt 2"),
                    s2 = new Student(6, "Studen3", 17, 0, 0, "11a6", "Truong thpt 3");
            Employee e = new Employee(7, "Em1", 34, 6000000, "Cong ty 1", "Ke toan"),
                     e1 = new Employee(8, "Em2", 25, 60000000, "Cong ty 2", "Truong phong"),
                     e2 = new Employee(9, "Em3", 33, 15000000, "Cong ty 3", "Nhan vien");
            DS.Add(t);
            DS.Add(t1);
            DS.Add(t2);
            DS.Add(s);
            DS.Add(s1);
            DS.Add(s2);
            DS.Add(e);
            DS.Add(e1);
            DS.Add(e2);

        }
        public static void Output()
        {
            int Number_T = 0, Number_S = 0, Number_E = 0;
            foreach (var p in DS)
            {
                if (p is Student)
                    Number_S++;
                if (p is Employee)
                    Number_E++;
                if (p is Teacher)
                    Number_T++;
            }
            Console.WriteLine($"Student : {Number_S}");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Id", "Name", "Age", "Class", "School");
            foreach (var p in DS)
            {
                if (p is Student)
                {
                    Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", p.Id, p.Name, p.Age, p.Class, p.School);
                }    
            }
            Console.WriteLine($"Teacher : {Number_T}");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-20}{4,-10}{5,-10}", "Id", "Name", "Age", "School", "Income", "Tax");
            foreach (var p in DS)
            {
                if (p is Teacher)
                {
                    Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-20}{4,-10}{5,-10}", p.Id, p.Name, p.Age, p.School, p.Income, p.GetTax());
                }
            }
            Console.WriteLine($"Employee : {Number_E}");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-15}{4,-20}{5,-10}{6,-10}", "Id", "Name", "Age", "Company", "JobTitle", "Income", "Tax");
            foreach (var p in DS)
            {
                if (p is Employee)
                {
                    Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-15}{4,-20}{5,-10}{6,-10}", p.Id, p.Name, p.Age, p.Company, p.JobTitle, p.Income, p.GetTax());
                }
            }
        }
    }
}