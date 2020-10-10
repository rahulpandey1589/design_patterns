using design_patterns.ObserverPattern.CustomExample.Observables;
using System;

namespace design_patterns.ObserverPattern.CustomExample.Observers.ConcreteObservers
{
    public class FirstGroupMember : IGroupMember
    {
        public string Name
        {
            get
            {
                return "First Member";
            }
        }

        public void Update(IGroup groupObj, string message)
        {
            Console.WriteLine(message);
        }
    }
}
