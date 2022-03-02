using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSalary();
            Tableof12();
            SquareOfArrayElements();
            PrimeNumber();

        }

        private static void PrimeNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the number to be checked:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("the entered number is {0} ", num);
            PrimeNumber(num);
        }

        private static void SquareOfArrayElements()
        {
            int[] arr = new int[4] { 4, 5, 2, 10 };
            Console.Write("The given array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            int[] new_arr = Array_square(arr);
            Console.WriteLine();
            Console.Write("New array after squaring the elements: ");
            for (int i = 0; i < new_arr.Length; i++)
            {
                Console.Write("{0} ", new_arr[i]);
            }
        }

        private static void Tableof12()
        {
            Console.WriteLine("Enter for which number the table is needed");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter upto how many times you need the table:");
            int b = int.Parse(Console.ReadLine());
            DisplayMathTable(a, b);
        }

        private static void CalculateSalary()
        {
            Console.WriteLine("Enter the basic salary");
            double basic = double.Parse(Console.ReadLine());
            CalculateSalary(basic);
        }

        public static void CalculateSalary(double basic)
        {
            if(basic>15000)
            {
                double Dearness_allowance = 0.2 * basic;
                double HRA = 0.25 * basic;
                double trav_all = 0.05 * basic;

                double gross_salary = (basic + Dearness_allowance + HRA + trav_all);

                double pf = 0.04 * basic;
                double insurance = 0.02 * basic;
                double prof_tax = 0.015 * basic;

                double net_salary=gross_salary-(pf+insurance+prof_tax);

                Console.WriteLine(net_salary);
            }
            else
            {
                Console.WriteLine("Basic less than 15000");
            }
        }

        public static void DisplayMathTable(int c, int d)
        {
            int result = 0;

            for (int i = 1; i <= d; i++)
            {
                result = c * i;
                Console.WriteLine("{0}*{1}={2}", c, i, result);
            }
        }

        public static int[] Array_square(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            return arr;
        }

        public static void PrimeNumber(int num)
        {
            int temp = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    temp++;
                }
            }
            if (temp == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
