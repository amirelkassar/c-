using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double year, month, day, mnt, scd;
            DateTime myage;
            Console.WriteLine("please enter ur name");
            string name = Console.ReadLine();
            Console.WriteLine("enter ur password");
            string pass = Console.ReadLine();
            Console.WriteLine(" please enter your date");
            myage = Convert.ToDateTime(Console.ReadLine());
            year =Convert.ToDouble( DateTime.Now.Subtract(myage).TotalDays / 360);
            month = Convert.ToDouble(DateTime.Now.Subtract(myage).TotalDays /30 );
            day = Convert.ToDouble(DateTime.Now.Subtract(myage).TotalHours / 24);
            mnt = Convert.ToDouble(DateTime.Now.Subtract(myage).TotalMinutes / 60);
            scd = Convert.ToDouble(DateTime.Now.Subtract(myage).TotalSeconds / 60);
            Console.WriteLine("your age is ");
            Console.WriteLine(year + "year");
            Console.WriteLine(month + "month");
            Console.WriteLine(day + "day");
            Console.WriteLine(mnt + "minutes");
            Console.WriteLine(scd + "seconds");
            if ((name == "amir") && (pass == "1212"))
            {

                Console.WriteLine("welcome mr." + name);
            }
            else if(!(name == "amir"))
            {
                Console.WriteLine("sorry the username is not correct");
            }
            else
            {
                Console.WriteLine("sorry the password is not correct");
            }
            Console.WriteLine("bye..bye");
            Console.ReadKey();



        }
    }
}
