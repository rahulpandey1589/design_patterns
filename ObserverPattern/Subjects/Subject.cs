using design_patterns.ObserverPattern.Observers;
using System;
using System.Collections.Generic;

namespace design_patterns.ObserverPattern.Subjects
{
    public class Subject : ISubject
    {
        public List<ISubjectRequester> _observer;
        
        public Subject()
        {
            _observer = new List<ISubjectRequester>();       
        }


        public void Attach(ISubjectRequester observer)
        {
            Console.WriteLine("Subject : Attaching new observer");
            _observer.Add(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observer)
            {
                observer.Update(this);
            }
        }

        public void Remove(ISubjectRequester observer)
        {
            Console.WriteLine("Subject : Attaching new observer");
            _observer.Remove(observer);
        }
    }
}
