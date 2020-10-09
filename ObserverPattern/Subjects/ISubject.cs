using design_patterns.ObserverPattern.Observers;

namespace design_patterns.ObserverPattern.Subjects
{
    public interface ISubject
    {
        void Attach(ISubjectRequester observer);

        void Remove(ISubjectRequester observer);

        void Notify();

    }
}
