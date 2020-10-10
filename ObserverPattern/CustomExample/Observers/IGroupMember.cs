using design_patterns.ObserverPattern.CustomExample.Observables;

namespace design_patterns.ObserverPattern.CustomExample.Observers
{
    public interface IGroupMember
    {
        #region Properties
        string Name { get;}

        #endregion


        void Update(IGroup groupObj,string message);
    }
}
