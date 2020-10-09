using design_patterns.ObserverPattern.Subjects;
using System;

namespace design_patterns.ObserverPattern.Observers
{
    public class ObserverA : ISubjectRequester
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Reacted To Event A");
        }
    }
}
