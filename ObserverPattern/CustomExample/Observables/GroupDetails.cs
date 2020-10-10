using design_patterns.ObserverPattern.CustomExample.Observables.ConcreteObservables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace design_patterns.ObserverPattern.CustomExample.Observables
{
    public class GroupDetails : Group
    {

        public string GroupName { get; set; } = "RWA_Notification";

        public static string GetNewNotification()
        {
            return $"New Message Is Posted in Group";
        }

    }
}
