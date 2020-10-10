using design_patterns.ObserverPattern.CustomExample.Observers;

namespace design_patterns.ObserverPattern.CustomExample.Observables
{
    public interface IGroup
    {
        void AttachMember(IGroupMember groupMember);

        void DetachMember(IGroupMember groupMember);

        void NotifyMembers(string message);

    }
}
