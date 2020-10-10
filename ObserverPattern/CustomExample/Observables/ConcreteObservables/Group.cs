using design_patterns.ObserverPattern.CustomExample.Observers;
using System.Collections.Generic;
using System.Linq;

namespace design_patterns.ObserverPattern.CustomExample.Observables.ConcreteObservables
{
    public class Group : IGroup
    {
        public List<IGroupMember> GroupMembers = new List<IGroupMember>();
        
        public int ActiveMembers
        {
            get
            {
                return GroupMembers.Count();
            }
        }

        public Group()
        {
        }

        public void AttachMember(IGroupMember groupMember)
        {
            this.GroupMembers.Add(groupMember);
            this.NotifyMembers($"New Member has been added in the group. The member name is {groupMember.Name}");
        }

        public void DetachMember(IGroupMember groupMember)
        {
            this.GroupMembers.Remove(groupMember);
            this.NotifyMembers($"Member has been removed in the group. The member name is {groupMember.Name}");
        }

        public void NotifyMembers(string message)
        {
            foreach (var grpMembers in GroupMembers)
            {
                grpMembers.Update(this, message);
            }
        }

        public void NotifyMembers()
        {
            foreach (var grpMembers in GroupMembers)
            {
                grpMembers.Update(this, GroupDetails.GetNewNotification());
            }
        }
    }
}
