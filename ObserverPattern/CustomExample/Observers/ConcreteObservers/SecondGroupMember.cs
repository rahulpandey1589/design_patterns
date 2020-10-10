using design_patterns.ObserverPattern.CustomExample.Observables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.ObserverPattern.CustomExample.Observers.ConcreteObservers
{
    public class SecondGroupMember : IGroupMember
    {
        public string Name
        {
            get
            {
                return "Second Group Name";
            }
        }

        public void Update(IGroup groupObj, string message)
        {
            Console.WriteLine(message);
        }
    }
}
