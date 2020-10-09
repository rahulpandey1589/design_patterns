using design_patterns.ObserverPattern.Observers;
using design_patterns.ObserverPattern.Subjects;
using System;
using System.Threading;

namespace design_patterns.ObserverPattern
{
    public class ObserverPatternClientApplication
    {
        static void Main(string[] args)
        {
            var objSubject = new Subject();
            objSubject.Attach(new ObserverA());

            Console.WriteLine("------Should we notify events-------------------------------");
            Console.WriteLine("1. Y (for Yes)");
            Console.WriteLine("2. N (for No)");
            Console.WriteLine("3. A (Add New)");
            string response = Console.ReadLine();

            if (response == "Y")
            {
                objSubject.Notify();
            }
            else if(response == "A")
            {
                objSubject.Attach(new ObserverB());
                Thread.Sleep(2000);
                objSubject.Notify();
            }


            Console.ReadKey();

        }
    }
}
