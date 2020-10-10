using design_patterns.ObserverPattern.CustomExample.Observables;
using design_patterns.ObserverPattern.CustomExample.Observables.ConcreteObservables;
using design_patterns.ObserverPattern.CustomExample.Observers.ConcreteObservers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace design_patterns.ObserverPattern.CustomExample
{
    public class CustomExampleObserverPattern
    {
        static void Main(string[] args)
        {
            var groupObj = new Group();
            var firstGroupMember = new FirstGroupMember();
            var secondGroupMember = new SecondGroupMember();


            Console.WriteLine("Adding First Member in Group");
            groupObj.AttachMember(firstGroupMember);

            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("Adding Second Member in Group");
            groupObj.AttachMember(secondGroupMember);


           // groupObj.NotifyMembers();  // Notify all members


            
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Detaching Second Member from Group");

            groupObj.DetachMember(secondGroupMember);


            //groupObj.NotifyMembers();


            Console.Read();


        }
    }
}
