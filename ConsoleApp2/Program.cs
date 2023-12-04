using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            a = a.ToUpper();

            a = a.Replace("C","С");
            a = a.Replace("B","В");
            a = a.Replace("Y", "У");
            a = a.Replace("E", "Е");
            a = a.Replace("K", "К");
            a = a.Replace("M", "М");
            a = a.Replace("H", "Н");
            a = a.Replace("O", "О");
            a = a.Replace("P", "Р");
            a = a.Replace("T", "Т");
            a = a.Replace("X", "Х");
            a = a.Replace("A", "А");

            string[] reg = {"1", "4", "02", "102", "3", "5", "6", "7", "8", "9", "10", "11", "111", "82", "12", "13", "113", "14", "15", "16", "116", "17", "18", "19", "95", "21", "121", "22", "75", "80", "41", "23", "93", "123", "24", "124", "84", "", "", "", "", "" };
                if (!char.IsDigit(a[1]) || !char.IsDigit(a[2])|| !char.IsDigit(a[3]))
                {
               
                }
            if (char.IsDigit(a[0]) || char.IsDigit(a[4]) || char.IsDigit(a[5]))
            {
                
            }
            string b = string.Concat(a[6], a[7]);

            for(int i = 0;i<reg.Lenght,i++)
            {
                if ()
            }
            







            a = a.Replace(" ", "");
            Console.WriteLine(a);
        }
    }
}
