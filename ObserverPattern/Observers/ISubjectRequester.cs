using design_patterns.ObserverPattern.Subjects;

namespace design_patterns.ObserverPattern.Observers
{
    public interface ISubjectRequester
    {
        void Update(ISubject subject);
    }
}
