using design_patterns.ObserverPattern.Subjects;
using System;

namespace design_patterns.ObserverPattern.Observers
{
    public class ObserverB : ISubjectRequester
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Reacted To Event B");
        }
    }
}
