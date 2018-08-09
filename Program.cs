using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1, date2;
            DateTime db1, db2, temp;

            Console.WriteLine("Please enter two dates in the format of mm-DD-yyyy");
            date1 = Console.ReadLine();
            date2 = Console.ReadLine();
            db1 = Convert.ToDateTime(date1);
            db2 = Convert.ToDateTime(date2);

            if (db1.Year <= db2.Year)
            {
                if (db1.Year == db2.Year)
                {
                    if (db1.Month <= db2.Month)
                    {
                        if (db1.Month == db2.Month)
                        {
                           if (db1.Day <= db2.Day)
                            {
                                temp = db1;
                                db1 = db2;
                                db2 = temp;
                            }
                        }
                        else
                        {
                            temp = db1;
                            db1 = db2;
                            db2 = temp;
                        }
                    }
                }
                else
                {
                    temp = db1;
                    db1 = db2;
                    db2 = temp;
                }
            }
           

            TimeSpan diff = db1 - db2;           


            Console.WriteLine("It is " + diff.Days + " Days");
            Console.WriteLine((diff.Days * 24) + " Hours");
            Console.WriteLine("And " + (diff.Days * 24 * 60 ) + " Minutes");

            Console.ReadLine();


        }        
    }
}
